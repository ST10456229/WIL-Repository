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

### Three-Tier Architecture
