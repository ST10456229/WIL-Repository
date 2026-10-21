using System.ComponentModel.DataAnnotations;
using System.Data;
using ChowDownCafe.Data;
using ChowDownCafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChowDownCafe.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersApiController : ControllerBase
    {
        private readonly ChowDownDbContext _context;

        public OrdersApiController(ChowDownDbContext context)
        {
            _context = context;
        }

        // POST: /api/orders
        [HttpPost]
        public async Task<IActionResult> CreateOrder(
            [FromBody] CreateOrderRequest request)
        {
            if (request.Items == null || request.Items.Count == 0)
            {
                return BadRequest(new
                {
                    message = "An order must contain at least one item."
                });
            }

            if (string.IsNullOrWhiteSpace(request.CustomerName))
            {
                return BadRequest(new
                {
                    message = "Customer name is required."
                });
            }

            if (request.Items.Any(item =>
                item.ProductId <= 0 || item.Quantity <= 0))
            {
                return BadRequest(new
                {
                    message = "Each product ID and quantity must be greater than zero."
                });
            }

            // Combine repeated product IDs and safely add quantities.
            List<(int ProductId, int Quantity)> requestedItems;

            try
            {
                requestedItems = request.Items
                    .GroupBy(item => item.ProductId)
                    .Select(group => (
                        ProductId: group.Key,
                        Quantity: group.Aggregate(
                            0,
                            (total, item) => checked(total + item.Quantity)))
                    )
                    .ToList();
            }
            catch (OverflowException)
            {
                return BadRequest(new
                {
                    message = "The requested quantity is too large."
                });
            }

            await using var transaction =
                await _context.Database.BeginTransactionAsync(
                    IsolationLevel.Serializable);

            try
            {
                var productIds = requestedItems
                    .Select(item => item.ProductId)
                    .ToList();

                var products = await _context.Products
                    .Where(product =>
                        productIds.Contains(product.ProductId) &&
                        product.IsActive)
                    .ToListAsync();

                if (products.Count != productIds.Count)
                {
                    await transaction.RollbackAsync();

                    return BadRequest(new
                    {
                        message = "One or more products do not exist or are inactive."
                    });
                }

                var productLookup = products.ToDictionary(
                    product => product.ProductId);

                // Validate prices and stock before changing anything.
                foreach (var item in requestedItems)
                {
                    var product = productLookup[item.ProductId];

                    if (!product.UnitPrice.HasValue ||
                        product.UnitPrice.Value < 0)
                    {
                        await transaction.RollbackAsync();

                        return BadRequest(new
                        {
                            message = $"Product '{product.ProductName}' has no valid price."
                        });
                    }

                    if (item.Quantity > product.QuantityInStock)
                    {
                        var available = product.QuantityInStock;
                        var unit = product.Unit;

                        await transaction.RollbackAsync();

                        return BadRequest(new
                        {
                            message = $"Only {available} {unit} of '{product.ProductName}' are in stock."
                        });
                    }
                }

                decimal total = 0m;

                foreach (var item in requestedItems)
                {
                    var product = productLookup[item.ProductId];

                    total += product.UnitPrice!.Value * item.Quantity;

                    // Deduct stock for this API order.
                    product.QuantityInStock -= item.Quantity;
                }

                // Create the order and record that stock was deducted.
                var order = new Order
                {
                    CustomerName = request.CustomerName.Trim(),

                    CustomerEmail = string.IsNullOrWhiteSpace(
                        request.CustomerEmail)
                        ? null
                        : request.CustomerEmail.Trim(),

                    CustomerPhone = string.IsNullOrWhiteSpace(
                        request.CustomerPhone)
                        ? null
                        : request.CustomerPhone.Trim(),

                    OrderStatus = "Pending",
                    OrderDate = DateTime.UtcNow,

                    Notes = string.IsNullOrWhiteSpace(request.Notes)
                        ? null
                        : request.Notes.Trim(),

                    // Required by the website's cancellation logic.
                    StockDeducted = true
                };

                foreach (var item in requestedItems)
                {
                    var product = productLookup[item.ProductId];

                    order.OrderItems.Add(new OrderItem
                    {
                        ProductId = product.ProductId,
                        Quantity = item.Quantity,
                        UnitPrice = product.UnitPrice!.Value
                    });
                }

                _context.Orders.Add(order);

                // Save order, items and inventory changes together.
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Created(
                    $"/api/orders/{order.OrderId}",
                    new
                    {
                        message = "Order created successfully. Stock has been updated.",
                        orderId = order.OrderId,
                        orderStatus = order.OrderStatus,
                        orderDate = order.OrderDate,
                        totalAmount = total,
                        items = requestedItems.Select(item =>
                        {
                            var product = productLookup[item.ProductId];

                            return new
                            {
                                productId = item.ProductId,
                                productName = product.ProductName,
                                quantity = item.Quantity,
                                unitPrice = product.UnitPrice,
                                lineTotal = product.UnitPrice!.Value * item.Quantity
                            };
                        })
                    });
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }

    public class CreateOrderRequest
    {
        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; } = string.Empty;

        // Optional: blank or omitted email is accepted.
        [StringLength(255)]
        public string? CustomerEmail { get; set; }

        [StringLength(30)]
        public string? CustomerPhone { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Required]
        [MinLength(1)]
        public List<CreateOrderItemRequest> Items { get; set; } = new();
    }

    public class CreateOrderItemRequest
    {
        [Range(1, int.MaxValue)]
        public int ProductId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}