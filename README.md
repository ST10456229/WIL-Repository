<div align="center">

  <img width="280" alt="ChowDown Cafe Logo" src="https://github.com/user-attachments/assets/f6048073-162c-4aee-8848-6cb1f312fdbe" />

  # ☕ ChowDown Café
  ### Digital Marketing & Operations Platform

  [![Version](https://img.shields.io/badge/version-1.0.0-blue?style=for-the-badge)](#)
  [![PHP](https://img.shields.io/badge/PHP-8.x-777BB4?style=for-the-badge&logo=php)](#)
  [![Kotlin](https://img.shields.io/badge/Kotlin-1.9.x-7F52FF?style=for-the-badge&logo=kotlin)](#)
  [![MySQL](https://img.shields.io/badge/MySQL-8.x-4479A1?style=for-the-badge&logo=mysql)](#)
  [![Firebase](https://img.shields.io/badge/Firebase-Firestore-FFCA28?style=for-the-badge&logo=firebase)](#)
  [![DevOps](https://img.shields.io/badge/DevOps-GitHub%20Actions-2088FF?style=for-the-badge&logo=github-actions)](#)
  [![Docker](https://img.shields.io/badge/Docker-Containerized-2496ED?style=for-the-badge&logo=docker)](#)

  **🏆 Rosebank College - Work Integrated Learning (WIL) Project**  
  *Team Amajongo • 2026*

</div>

---

## 📋 Table of Contents

<details>
<summary><b>📑 Click to expand Table of Contents</b></summary>

- [📖 Project Overview](#-project-overview)
- [🎯 SMART Objectives](#-smart-objectives)
- [🎯 Problem Statement](#-problem-statement)
- [🛠️ Solution Overview](#️-solution-overview)
- [💻 Technology Stack](#-technology-stack)
- [🗄️ Database Design](#️-database-design)
- [🎨 Wireframes & Design](#-wireframes--design)
- [👥 Team Members](#-team-members)
- [🎯 Milestones](#-milestones)
- [🚀 Getting Started](#-getting-started)
- [🤝 Contributing](#-contributing)
- [📊 Status](#-status)
- [📄 License & References](#-license)

</details>

---

## 📖 Project Overview

| Attribute | Details |
| :--- | :--- |
| **🏢 Location** | Durban CBD, South Africa |
| **👤 Client** | Mr Ibrahim — Owner, ChowDown Café |
| **📅 Established** | September 2024 |
| **🎓 Institution** | Rosebank College — Diploma in IT |

ChowDown is an independent café situated in Durban CBD. This project delivers a unified digital platform addressing two core business challenges:

| Challenge | Description |
| :--- | :--- |
| **📢 Marketing & Engagement** | Minimal online presence, no digital promotional platform, heavy reliance on foot traffic. |
| **📦 Stock Management** | Manual, paper-based inventory tracking leading to inaccurate stock counts. |

---

## 🎯 SMART Objectives

| Objective | Target | Alignment |
| :--- | :--- | :--- |
| **📈 Increase Customer Engagement** | 50 app downloads + 30 email sign-ups in Month 1 | Marketing |
| **📊 Improve Stock Accuracy** | Reduce stock discrepancies by 90% | Stock Management |
| **⏱️ Staff Efficiency** | Record stock usage in under 30 seconds | Stock Management |
| **👁️ Real-time Visibility** | Instant owner alerts for low-stock levels | Stock Management |
| **📱 Digital Marketing Reach** | Publish promotions instantly to all app users | Marketing |

---

## 🎯 Problem Statement

The owner of ChowDown struggles to attract and retain customers without a defined digital strategy. Low online visibility hinders competition against regional rivals utilizing social channels, email campaigns, and online ordering.

### 🔴 Key Issues Identified

| Problem Area | Client Feedback / Issue | Severity |
| :--- | :--- | :---: |
| **📢 Marketing** | "Only WhatsApp at this store" | 🔴 High |
| **📢 Marketing** | Low online visibility | 🔴 High |
| **📦 Stock Management** | "Keeping an accurate count of stock on a daily basis" | 🔴 High |
| **📦 Stock Management** | Relying on paper stock sheets manually | 🔴 High |
| **🛒 Ordering** | "Customers cannot place orders remotely" | 🔴 High |
| **🛒 Ordering** | No digital ordering process; kitchen workflow is fully manual | 🔴 High |
| **⚙️ Operations** | Baking bottlenecks causing service delays | 🟡 Medium |
| **👥 Staff** | Staff tracking and operational coordination challenges | 🟡 Medium |

---

## 🛠️ Solution Overview

### 📱 System Components

<div align="center">

| 🌐 Admin Panel (Web) | 📱 Customer App (Android) | 🗄️ Shared Database |
| :--- | :--- | :--- |
| • Secure authentication system<br>• Dashboard analytics & charts<br>• Marketing post management<br>• Inventory tracking & alerts<br>• Staff & supplier management<br>• Automated report generation | • Onboarding flow<br>• Browse promotions & menu<br>• Pickup order creation<br>• Real-time order tracking<br>• Push notifications<br>• Profile & settings management | **MySQL (XAMPP)**<br>• `admins`, `staff`, `products`<br>• `orders`, `marketing_posts`<br><br>**Firebase Firestore**<br>• `customers`<br>• `notifications` |

</div>

### 📊 Value Delivered

| Benefit | Expected Impact |
| :--- | :--- |
| **💰 Increased Revenue** | +10 additional daily orders |
| **📉 Reduced Waste** | 5% reduction in stock spoilage |
| **📢 Direct Marketing** | Real-time push engagement via Android app |
| **⏱️ Time Savings** | ~2 hours saved per day for staff |
| **📈 Return on Investment** | Projected 243% ROI |

---

## 💻 Technology Stack

### Languages & Core Services

| Category | Technology | Version / Details | Purpose |
| :--- | :--- | :--- | :--- |
| **Languages** | PHP | 8.x | Backend API & Admin Portal |
| | Kotlin | 1.9.x | Native Android Application |
| | HTML5 / CSS3 / JS | ES6+ | Web Admin Interface |
| | SQL | MySQL 8.x | Relational Database |
| **Databases** | MySQL | 8.x | Core transactional storage |
| | Firebase Firestore | NoSQL | Real-time notifications & user profiles |

### Tools & Infrastructure

| Tool | Category | Purpose |
| :--- | :--- | :--- |
| **Android Studio** | IDE | Mobile app development |
| **VS Code / MySQL Workbench** | IDE / DB | Backend development & schema design |
| **Figma / Draw.io** | Design | UI Prototyping & System Architecture |
| **Docker & Docker Compose** | Containerization | Application environment orchestration |
| **GitHub Actions** | DevOps / CI/CD | Automated testing & deployment pipelines |
| **SonarQube & Snyk** | Security | Static code analysis & vulnerability checks |
| **Prometheus & Grafana** | Monitoring | System metrics & performance tracking |

### DevOps KPIs

| KPI | Target |
| :--- | :---: |
| **Build Time** | `< 5 minutes` |
| **Test Coverage** | `> 80%` |
| **Deployment Frequency** | Weekly |
| **MTTR** | `< 30 minutes` |
| **Change Failure Rate** | `< 15%` |

---

## 🗄️ Database Design

### MySQL Relational Tables (XAMPP)

| Table | Primary Key | Foreign Keys | Description |
| :--- | :--- | :--- | :--- |
| `admin` | `adminId` | — | System administrators |
| `staff` | `staffId` | `adminId` → `admin` | Café employees |
| `product` | `productId` | — | Menu items & raw inventory |
| `stock_transaction` | `transactionId` | `productId`, `staffId` | Inventory usage logs |
| `low_stock_alert` | `alertId` | `productId`, `resolvedBy` | Automated stock triggers |
| `marketing_post` | `postId` | `adminId` → `admin` | Promotional campaigns |
| `analytics` | `analyticsId` | `postId` → `marketing_post` | Campaign impression data |
| `orders` | `orderId` | `customerId` → `customer` | Order history records |
| `order_items` | `orderItemId` | `orderId`, `productId` | Individual order items |

### Firebase Firestore Collections

| Collection | Document ID | Description |
| :--- | :--- | :--- |
| `customers` | Auto UID | Customer profile data |
| `notifications` | Auto UID | Push notification logs |
| `customer_notifications` | Auto UID | Junction mapping customer notification history |

---

## 🎨 Wireframes & Design

### 🌐 Admin Web Interface

<div align="center">

| Login Screen | Admin Dashboard |
| :---: | :---: |
| <img width="400" alt="Login Page" src="https://github.com/user-attachments/assets/33fcf8ed-fce2-4ec7-8e16-6de767ff050f" /> | <img width="400" alt="Admin Dashboard" src="https://github.com/user-attachments/assets/affd5fcd-2125-4190-b458-6a3d0c42371c" /> |

| Reports Interface | Promotions Management |
| :---: | :---: |
| <img width="400" alt="Reports Page" src="https://github.com/user-attachments/assets/5b7a4702-3904-419e-8aba-b711a14f547d" /> | <img width="400" alt="Promotions Page" src="https://github.com/user-attachments/assets/10ae9e6b-270b-47e4-885e-4b7982f53fe7" /> |

</div>

### 📱 Android Mobile Application

<div align="center">

| Onboarding | App Dashboard | Item Details |
| :---: | :---: | :---: |
| <img width="200" alt="Onboarding" src="https://github.com/user-attachments/assets/3fba39bd-8db0-4bcd-834a-1b9a70bcc9f2" /> | <img width="200" alt="App Dashboard" src="https://github.com/user-attachments/assets/84377ffc-f157-43a7-8142-f5cace859e87" /> | <img width="200" alt="Food Information" src="https://github.com/user-attachments/assets/464d1598-23b6-4d20-8b24-91e59b1bcccf" /> |

| Customization | Shopping Cart | Checkout |
| :---: | :---: | :---: |
| <img width="200" alt="Item Customization" src="https://github.com/user-attachments/assets/ec8744c1-f5ff-40b6-8493-60c798ddb398" /> | <img width="200" alt="Cart" src="https://github.com/user-attachments/assets/f5e8d2f1-26ec-4f81-96b9-4a48074f7256" /> | <img width="200" alt="Checkout" src="https://github.com/user-attachments/assets/c6280bc5-1876-4a7f-bf73-9e4dded7b8e6" /> |

</div>

---

## 👥 Team Members

| Name | Student ID | Role | Core Responsibilities |
| :--- | :--- | :--- | :--- |
| **Wandile Shobede** | `ST10457381` | Team Lead / Mobile Support | Lifecycle management, client communication, QA standards |
| **Siphamandla Tshabalala** | `ST10441479` | Project Manager / Mobile Lead | Documentation, scrum scheduling, sprint presentations |
| **Mlondolozi Shezi** | `ST10458040` | Backend Lead / Mobile Support | Architecture design, database schema, REST API implementation |
| **Sphumelele Khuzwayo** | `ST10456229` | DB Designer / Mobile Support | UI/UX implementation, API integration, code review |

---

## 🎯 Milestones

| Milestone | Description | Target Timeline |
| :---: | :--- | :--- |
| **M1** | Project Initiation & Setup | Week 1 |
| **M2** | Requirements Sign-off | Week 3 |
| **M3** | Database Architecture Finalized | Week 4 |
| **M4** | CI/CD Pipeline Operational | Week 5 |
| **M5** | PHP Backend Services Complete | Week 6 |
| **M6** | Kotlin App Prototype Ready | Week 8 |
| **M7** | System Integration Complete | Week 9 |
| **M8** | Security Audit & Quality Review | Week 9 |
| **M9** | Production Deployment & Monitoring | Week 10 |
| **M10** | Handover & Documentation | Week 10 |

---

## 🚀 Getting Started

### Prerequisites

* **PHP** `8.x` & **MySQL** `8.x` (via XAMPP/WAMP)
* **Android Studio** (Electric Eel or newer)
* **Docker Desktop** *(Optional)*
* **Git**

### Local Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/YourUsername/ChowDown-Cafe.git](https://github.com/YourUsername/ChowDown-Cafe.git)
   cd ChowDown-Cafe

Database Setup:Start Apache & MySQL via XAMPP Control Panel.Open phpMyAdmin (http://localhost/phpmyadmin).Create database chowdown_db and import database/schema.sql.Configure Environment:Bashcp .env.example .env
# Update .env with your local MySQL credentials
Run Admin Panel:Move the repository to your server root (e.g., htdocs/chowdown-cafe).Navigate to http://localhost/chowdown-cafe/admin-panel/.Run Mobile App:Open /mobile-app in Android Studio.Link your google-services.json file for Firebase.Build and run on an Android Virtual Device (AVD).Docker DeploymentBashdocker-compose up -d --build
📊 StatusComponentStatusProject Charter & Planning✅ CompleteRequirements Specification✅ CompleteArchitecture & DB Design✅ CompleteUI/UX Wireframes✅ CompleteCI/CD Pipeline🔄 In ProgressWeb Admin Front-end🔄 In ProgressAndroid Application📅 PlannedREST API Services📅 Planned🤝 ContributingFork the Project Repository.Create your Feature Branch (git checkout -b feature/AmazingFeature).Commit your Changes (git commit -m 'Add some AmazingFeature').Push to the Branch (git push origin feature/AmazingFeature).Open a Pull Request.📄 License & ReferencesDeveloped for the Work Integrated Learning (WIL) program at Rosebank College.ReferencesBennett, S., McRobb, S. and Farmer, R. (2010). Object-Oriented Systems Analysis and Design Using UML. 4th edn. McGraw-Hill.Firebase Documentation. (2023). Available at: firebase.google.com/docs© 2026 Team Amajongo — Rosebank College WIL Project
