# ☕ ChowDown Café - Digital Marketing & Operations Platform
![Version](https://img.shields.io/badge/version-1.0.0-blue)
![PHP](https://img.shields.io/badge/PHP-8.x-777BB4?logo=php)
![Kotlin](https://img.shields.io/badge/Kotlin-1.9.x-7F52FF?logo=kotlin)
![MySQL](https://img.shields.io/badge/MySQL-8.x-4479A1?logo=mysql)
![Firebase](https://img.shields.io/badge/Firebase-Firestore-FFCA28?logo=firebase)
![DevOps](https://img.shields.io/badge/DevOps-GitHub%20Actions-2088FF?logo=github-actions)
![Docker](https://img.shields.io/badge/Docker-Containerized-2496ED?logo=docker)
---

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Problem Statement](#problem-statement)
- [Solution Overview](#solution-overview)
- [System Architecture](#system-architecture)
- [Technology Stack](#technology-stack)
- [DevOps Pipeline](#devops-pipeline)
- [Database Design](#database-design)
- [Project Structure](#project-structure)
- [Wireframes & Design](#wireframes--design)
- [Team Members](#team-members)
- [Milestones](#milestones)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [License](#license)

---

## 📖 Project Overview

ChowDown is an independent café and coffee shop situated in Durban CBD. This project aims to develop a unified digital platform that addresses two critical business challenges:

| Challenge | Description |
|-----------|-------------|
| **Marketing & Customer Engagement** | Minimal online presence, no digital platform for promotions, sole dependence on foot traffic |
| **Stock Management** | Manual paper-based inventory tracking resulting in inaccurate stock counts |

The system consists of:

- **PHP Web Admin Panel** - For owner and staff to manage marketing posts, stock, and view reports
- **Kotlin Android App** - For customers to view promotions, receive notifications, and place orders
- **Shared Database** - MySQL for business data + Firebase for customer/notification data

---

## 🎯 Problem Statement

The owner of ChowDown finds it difficult to attract new clients and retain current ones due to an absence of a well-defined digital marketing plan. The business has low online visibility, hindering its ability to compete with rivals that utilise social media, email newsletters, and search engine optimisation.

### Key Issues Identified

| Problem Area | Client Statement | Severity |
|--------------|------------------|----------|
| Marketing | "Only WhatsApp at this store" | High |
| Marketing | Low online visibility | High |
| Stock Management | "Keeping an accurate count of stock on a daily basis" | High |
| Stock Management | "Stock sheets manually" | High |
| Ordering | "Customers cannot place orders remotely" | High |
| Ordering | "No digital ordering process, kitchen workflow is manual" | High |
| Operations | "Baking at times causes delays" | Medium |
| Staff | "Staff challenges" | Medium |

---

## 🛠️ Solution Overview

### Admin Panel (Web)

- Secure login system for business owner and staff
- Dashboard with real-time analytics
- Marketing post management (Create/Edit/Delete)
- Stock management with low-stock alerts
- Staff management
- Report generation

### Customer App (Android)

- Splash screen and onboarding
- Browse marketing posts/promotions
- Place orders for pickup
- Real-time order tracking
- Push notifications
- Contact business (call/email/map)

### Shared Database

- MySQL: admins, staff, products, stock_transactions, orders, marketing_posts, analytics
- Firebase Firestore: customers, notifications, customer_notifications

---

## 🏗️ System Architecture

---

## 💻 Technology Stack

### Programming Languages

| Language | Purpose |
|----------|---------|
| PHP 8.x | Backend development (admin panel & API) |
| Kotlin 1.9.x | Android mobile application |
| HTML/CSS/JavaScript | Frontend web development |
| SQL | Database management |

### Development Tools

| Tool | Purpose |
|------|---------|
| Android Studio | Mobile app development |
| Visual Studio Code | PHP development |
| MySQL Workbench | Database design |
| Figma | UI prototyping |
| Postman | API testing |

### DevOps Tools

| Tool | Purpose |
|------|---------|
| GitHub | Version control & collaboration |
| GitHub Actions | CI/CD pipeline automation |
| Docker | Application containerization |
| Docker Compose | Multi-container orchestration |
| SonarQube | Static code analysis |
| Snyk | Dependency vulnerability scanning |
| Prometheus & Grafana | Monitoring and metrics |

### Frameworks & Services

| Framework/Service | Purpose |
|-------------------|---------|
| XAMPP | Local PHP/MySQL server |
| Firebase Firestore | NoSQL document store |
| Firebase Cloud Messaging | Push notifications |
| Chart.js | Web charts |

---

## 🚀 DevOps Pipeline

### CI/CD Workflow


### DevOps KPIs

| KPI | Target |
|-----|--------|
| Build Time | < 5 minutes |
| Test Coverage | > 80% |
| Deployment Frequency | Weekly |
| MTTR | < 30 minutes |
| Change Failure Rate | < 15% |

---

## 🗄️ Database Design

### MySQL Tables (XAMPP)

| Table | Primary Key | Foreign Keys | Description |
|-------|-------------|--------------|-------------|
| `admin` | adminId | - | System administrators |
| `staff` | staffId | adminId → admin | Café staff members |
| `product` | productId | - | Stock items |
| `stock_transaction` | transactionId | productId → product, staffId → staff | Stock usage records |
| `low_stock_alert` | alertId | productId → product, resolvedBy → staff | Low stock warnings |
| `marketing_post` | postId | adminId → admin | Promotional content |
| `analytics` | analyticsId | postId → marketing_post | View statistics |
| `orders` | orderId | customerId → customer | Customer orders |
| `order_items` | orderItemId | orderId → orders, productId → product | Order items |

### Firebase Firestore Collections

| Collection | Document ID | Description |
|------------|-------------|-------------|
| `customers` | Auto UID | Customer profiles |
| `notifications` | Auto UID | Push notification records |
| `customer_notifications` | Auto UID | Junction: tracks which customers received which notifications |

### ERD Summary


---

## 📁 Project Structure

---

## 🎨 Wireframes & Design

### Website Wireframes

| Page | Description |
|------|-------------|
| Login Page | Admin/Staff authentication |
| Admin Dashboard | Overview of key metrics |
| Stock Management | Inventory tracking and alerts |
| Reports Page | Analytical insights |
| Promotions Page | Marketing content management |
| Supplier Details | Supplier and procurement management |

### Mobile App Wireframes

| Page | Description |
|------|-------------|
| First Screen | Splash & onboarding |
| App Dashboard | Home screen with promotions |
| Food Information | Menu item details |
| Item Customization | Size/options selection |
| Cart | Order review |
| Checkout | Payment and collection |
| Confirmation | Order confirmation |
| Order Tracking | Real-time order status |
| Settings | Profile and preferences |

### Design Tool

All wireframes were created using **Figma** and **Draw.io**.

---

## 👥 Team Members

| Name | Student Number | Role | Responsibilities |
|------|----------------|------|------------------|
| Wandile Shobede | ST10457381 | Team Leader / Mobile Support | Managing project lifespan, team discussions, quality standards, primary stakeholder contact |
| Siphamandla Tshabalala | ST10441479 | Project Manager / Mobile App Lead | Note-taking, documentation, meeting coordination, presentations |
| Mlondolozi Shezi | ST10458040 | Backend Lead / Mobile Support | Database structure, backend functionality, data protection, API development |
| Sphumelele Khuzwayo | ST10456229 | Database Designer / Mobile Support | User features, backend API integration, code reviews, responsive design |

### Team Allocation by Task

| Task | Team Member |
|------|-------------|
| Project Plan Update | All members |
| Requirements Review | All members |
| Site Map Update | Wandile, Sphumelele |
| Wireframe Design Update | Wandile, Sphumelele |
| System Design Review | All members |
| DevOps Setup | Mlondolozi, Wandile |
| System Development | All members |
| System Integration | All members |
| Testing & Bug Fixing | All members |
| Documentation | All members |

---

## 🎯 Milestones

| Milestone | Description | Due Date |
|-----------|-------------|----------|
| M1 | Project Initiation | Week 1 |
| M2 | Requirements Approval | Week 3 |
| M3 | Database Design Complete | Week 4 |
| M4 | CI/CD Pipeline Setup | Week 5 |
| M5 | PHP Backend Complete | Week 6 |
| M6 | Kotlin App Prototype | Week 8 |
| M7 | Integration Complete | Week 9 |
| M8 | Code Quality & Security Review | Week 9 |
| M9 | Deployment & Monitoring | Week 10 |
| M10 | Documentation & Handover | Week 10 |
| M11 | Final Submission | Week 10 |
| M12 | Retrospective & Feedback | Week 10 |

---

## 🚀 Getting Started

### Prerequisites

- PHP 8.x
- MySQL 8.x
- XAMPP or WAMP
- Android Studio (for mobile app)
- Docker (for containerization)
- Git

### Local Development Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/YourUsername/ChowDown-Cafe.git
   cd ChowDown-Cafe
   🤝 Contributing
Fork the repository

Create a feature branch (git checkout -b feature/amazing-feature)

Commit your changes (git commit -m 'Add amazing feature')

Push to the branch (git push origin feature/amazing-feature)

Open a Pull Request

Coding Standards
PHP: Follow PSR-12 coding standards

Kotlin: Follow Android Kotlin style guide

Commits: Write meaningful commit messages

📄 License
This project is developed as part of the Work Integrated Learning (WIL) program at Rosebank College.

📞 Contact
Project Supervisor: Asande Zikalala

Team Email: wil.team@chowdown.com

Client: Mr Ibrahim - ChowDown Café, Durban CBD

📚 References
Bennett, S., McRobb, S. and Farmer, R. (2010). Object-Oriented Systems Analysis and Design Using UML. 4th edn. London: McGraw-Hill.

Firebase. (2023). Firebase Documentation. Available at: https://firebase.google.com/docs

Oracle. (2019). Oracle Database Documentation. Available at: https://docs.oracle.com/en/database

📊 Status
Component	Status
Project Plan	✅ Complete
Requirements Analysis	✅ Complete
System Design	✅ Complete
Wireframes	✅ Complete
ERD Design	✅ Complete
DevOps Pipeline	🔄 In Progress
HTML Pages	🔄 In Progress
Mobile App	📅 Planned
Backend API	📅 Planned
Testing	📅 Planned
© 2026 Amajongo - Rosebank College WIL Project

text

---

## HOW TO USE THIS README

1. **Create a GitHub repository** called `ChowDown-Cafe`
2. **Initialize with a README**
3. **Copy and paste** the above content into your `README.md`
4. **Update the repository link** to your actual GitHub URL
5. **Add screenshots** of your wireframes to the `docs/wireframes/` folder
6. **Push your code** and the README to GitHub

---

## WHAT'S INCLUDED IN THIS README

| Section | Purpose |
|---------|---------|
| Project Overview | High-level description of the project |
| Problem Statement | Why this project exists |
| Solution Overview | What the system does |
| System Architecture | Technical design |
| Technology Stack | Tools and languages used |
| DevOps Pipeline | CI/CD workflow |
| Database Design | ERD and table structure |
| Project Structure | Folder organisation |
| Wireframes & Design | UI/UX documentation |
| Team Members | Roles and responsibilities |
| Milestones | Project timeline |
| Getting Started | Setup instructions |
| Contributing | How to contribute |
| Status | Current project progress |

### Three-Tier Architecture
