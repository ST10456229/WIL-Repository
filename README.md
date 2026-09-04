ChowDown Café — Digital Marketing & Operations Platform

<p align="center"> <img src="https://github.com/user-attachments/assets/f6048073-162c-4aee-8848-6cb1f312fdbe" alt="ChowDown Café" width="500"> </p>

<p align="center"> A unified digital platform for <strong>ChowDown Café</strong> combining business management, digital marketing, inventory management, customer ordering, and mobile engagement. </p>

<p align="center"> <img src="https://img.shields.io/badge/version-1.0.0-blue" alt="Version"> <img src="https://img.shields.io/badge/PHP-8.x-777BB4?logo=php" alt="PHP"> <img src="https://img.shields.io/badge/Kotlin-1.9.x-7F52FF?logo=kotlin" alt="Kotlin"> <img src="https://img.shields.io/badge/MySQL-8.x-4479A1?logo=mysql" alt="MySQL"> <img src="https://img.shields.io/badge/Firebase-Firestore-FFCA28?logo=firebase" alt="Firebase"> <img src="https://img.shields.io/badge/Docker-Containerized-2496ED?logo=docker" alt="Docker"> <img src="https://img.shields.io/badge/CI%2FCD-GitHub%20Actions-2088FF?logo=github-actions" alt="GitHub Actions"> </p>

📋 Table of Contents
Project Overview
Problem Statement
Solution Overview
System Architecture
Technology Stack
DevOps Pipeline
Database Design
Project Structure
Wireframes & Design
Team Members
Milestones
Getting Started
Contributing
License
Contact
References
Project Status
📖 Project Overview

ChowDown Café is an independent café and coffee shop situated in Durban CBD.

The project aims to develop a unified digital platform that addresses two major business challenges:

Challenge	Description
📢 Marketing & Customer Engagement	Limited online presence, no dedicated digital platform for promotions, and reliance on physical foot traffic
📦 Stock Management	Manual, paper-based inventory tracking resulting in inaccurate stock counts
The Platform Consists Of
🌐 PHP Web Admin Panel

Used by the café owner and staff to:

Manage marketing posts
Manage stock and inventory
Manage staff
View analytics
Generate reports
📱 Kotlin Android Application

Used by customers to:

View promotions
Browse products
Place pickup orders
Track orders
Receive notifications
Contact the café
🗄️ Shared Data Layer
MySQL — Business and operational data
Firebase Firestore — Customer and notification data
🎯 Problem Statement

The owner of ChowDown Café experiences difficulty attracting new customers and retaining existing customers due to the absence of a well-defined digital marketing strategy.

The café has limited online visibility, making it difficult to compete with businesses that utilise:

Social media
Email newsletters
Search engine optimisation
Digital ordering platforms
Key Issues Identified
Problem Area	Issue	Severity
Marketing	Limited digital presence	🔴 High
Marketing	Low online visibility	🔴 High
Stock Management	Difficulty maintaining accurate daily stock counts	🔴 High
Stock Management	Manual stock sheets	🔴 High
Ordering	Customers cannot place orders remotely	🔴 High
Ordering	No digital ordering or kitchen workflow	🔴 High
Operations	Baking schedules can cause delays	🟡 Medium
Staff	Staff-related operational challenges	🟡 Medium
🛠️ Solution Overview
🌐 Admin Web Panel

The web-based administration system provides:

🔐 Secure owner and staff authentication
📊 Dashboard with real-time analytics
📢 Marketing post management
📦 Stock management
⚠️ Low-stock alerts
👥 Staff management
📄 Report generation
📱 Customer Android Application

The mobile application provides:

🚀 Splash screen and onboarding
📢 Marketing posts and promotions
🛒 Pickup ordering
📍 Real-time order tracking
🔔 Push notifications
📞 Business contact options
🗺️ Map/location access
🗄️ Shared Database

MySQL stores:

Administrators
Staff
Products
Stock transactions
Orders
Marketing posts
Analytics

Firebase Firestore stores:

Customers
Notifications
Customer notification records
🏗️ System Architecture

The system follows a multi-component architecture consisting of:

                    ┌─────────────────────┐
                    │    Customer App     │
                    │   Kotlin / Android  │
                    └──────────┬──────────┘
                               │
                               │ API / Firebase
                               ▼
                    ┌─────────────────────┐
                    │    Backend / API    │
                    │       PHP 8.x       │
                    └──────────┬──────────┘
                               │
                    ┌──────────┴──────────┐
                    ▼                     ▼
          ┌─────────────────┐   ┌──────────────────┐
          │     MySQL       │   │ Firebase         │
          │ Business Data   │   │ Firestore / FCM  │
          └─────────────────┘   └──────────────────┘
                    ▲
                    │
          ┌─────────┴─────────┐
          │   Admin Web Panel │
          │     PHP / Web     │
          └───────────────────┘
💻 Technology Stack
Programming Languages
Technology	Purpose
PHP 8.x	Backend development, admin panel and API
Kotlin 1.9.x	Android mobile application
HTML / CSS / JavaScript	Web frontend
SQL	Database management
Development Tools
Tool	Purpose
Android Studio	Android application development
Visual Studio Code	PHP and web development
MySQL Workbench	Database design
Figma	UI prototyping
Postman	API testing
DevOps Tools
Tool	Purpose
GitHub	Version control and collaboration
GitHub Actions	CI/CD pipeline automation
Docker	Application containerisation
Docker Compose	Multi-container orchestration
SonarQube	Static code analysis
Snyk	Dependency vulnerability scanning
Prometheus	Monitoring and metrics
Grafana	Monitoring dashboards
Frameworks & Services
Framework / Service	Purpose
XAMPP	Local PHP/MySQL development server
Firebase Firestore	NoSQL document database
Firebase Cloud Messaging	Push notifications
Chart.js	Web-based charts and analytics
⚙️ DevOps KPIs

The project targets the following DevOps performance indicators:

KPI	Target
Build Time	< 5 minutes
Test Coverage	> 80%
Deployment Frequency	Weekly
Mean Time to Recovery (MTTR)	< 30 minutes
Change Failure Rate	< 15%
🗄️ Database Design
MySQL Database
Table	Primary Key	Foreign Keys	Description
admin	adminId	—	System administrators
staff	staffId	adminId → admin	Café staff members
product	productId	—	Stock items
stock_transaction	transactionId	productId, staffId	Stock usage records
low_stock_alert	alertId	productId, resolvedBy	Low-stock warnings
marketing_post	postId	adminId	Promotional content
analytics	analyticsId	postId	Marketing post statistics
orders	orderId	customerId	Customer orders
order_items	orderItemId	orderId, productId	Individual order items
Firebase Firestore
Collection	Document ID	Description
customers	Auto UID	Customer profiles
notifications	Auto UID	Push notification records
customer_notifications	Auto UID	Tracks notifications received by customers
Entity Relationship Diagram

<p align="center"> <img src="https://github.com/user-attachments/assets/f6048073-162c-4aee-8848-6cb1f312fdbe" alt="ChowDown Café ERD" width="800"> </p>

📁 Project Structure
ChowDown-Cafe/
│
├── admin-panel/
│   ├── assets/
│   ├── css/
│   ├── js/
│   ├── includes/
│   └── pages/
│
├── android-app/
│   ├── app/
│   └── gradle/
│
├── database/
│   └── schema.sql
│
├── docker/
│
├── docs/
│   ├── wireframes/
│   ├── diagrams/
│   └── documentation/
│
├── .github/
│   └── workflows/
│
├── .env.example
├── docker-compose.yml
└── README.md
🎨 Wireframes & Design

All wireframes were created using Figma and Draw.io.

🌐 Website Wireframes
Page	Description
Login Page	Admin and staff authentication
Admin Dashboard	Overview of key business metrics
Stock Management	Inventory tracking and stock alerts
Reports Page	Analytical insights and reports
Promotions Page	Marketing content management
Supplier Details	Supplier and procurement management
📱 Mobile App Wireframes
Screen	Description
First Screen	Splash screen and onboarding
App Dashboard	Home screen with promotions
Food Information	Menu item details
Item Customization	Size and option selection
Cart	Order review
Checkout	Payment and collection
Confirmation	Order confirmation
Order Tracking	Real-time order status
Settings	Profile and preferences
👥 Team Members
Team Member	Student Number	Role	Responsibilities
Wandile Shobede	ST10457381	Team Leader / Mobile Support	Project management, team discussions, quality standards and stakeholder communication
Siphamandla Tshabalala	ST10441479	Project Manager / Mobile App Lead	Documentation, meeting coordination, note-taking and presentations
Mlondolozi Shezi	ST10458040	Backend Lead / Mobile Support	Database structure, backend functionality, data protection and API development
Sphumelele Khuzwayo	ST10456229	Database Designer / Mobile Support	User features, backend API integration, code reviews and responsive design
Team Allocation
Task	Team Member(s)
Project Plan Update	All members
Requirements Review	All members
Site Map Update	Wandile, Sphumelele
Wireframe Design Update	Wandile, Sphumelele
System Design Review	All members
DevOps Setup	Mlondolozi, Wandile
System Development	All members
System Integration	All members
Testing & Bug Fixing	All members
Documentation	All members
🎯 Milestones
Milestone	Description	Due
M1	Project Initiation	Week 1
M2	Requirements Approval	Week 3
M3	Database Design Complete	Week 4
M4	CI/CD Pipeline Setup	Week 5
M5	PHP Backend Complete	Week 6
M6	Kotlin App Prototype	Week 8
M7	Integration Complete	Week 9
M8	Code Quality & Security Review	Week 9
M9	Deployment & Monitoring	Week 10
M10	Documentation & Handover	Week 10
M11	Final Submission	Week 10
M12	Retrospective & Feedback	Week 10
🚀 Getting Started
Prerequisites

Make sure the following software is installed:

PHP 8.x
MySQL 8.x
XAMPP or WAMP
Android Studio
Docker
Git
1. Clone the Repository
git clone https://github.com/YourUsername/ChowDown-Cafe.git
cd ChowDown-Cafe
2. Set Up the Database
Start Apache and MySQL in XAMPP.
Open phpMyAdmin.
Import:
database/schema.sql
3. Configure Environment Variables

Copy the example environment file:

cp .env.example .env

Then update the database credentials inside .env.

4. Start the Web Application

Place the admin-panel folder inside your XAMPP htdocs directory.

Then access:

http://localhost/chowdown-cafe/admin-panel/
5. Configure the Android Application
Open the Android project in Android Studio.
Configure Firebase.
Connect the application to the required Firebase services.
Run the application on an emulator or physical Android device.
🐳 Optional: Docker

To start the Docker environment:

docker-compose up -d
🤝 Contributing

Contributions are welcome.

Contribution Workflow
Fork the repository.
Create a feature branch:
git checkout -b feature/amazing-feature
Commit your changes:
git commit -m "Add amazing feature"
Push your branch:
git push origin feature/amazing-feature
Open a Pull Request.
Coding Standards
PHP: Follow PSR-12 coding standards.
Kotlin: Follow the Android Kotlin style guide.
Git: Use meaningful commit messages.
📄 License

This project was developed as part of the Work Integrated Learning (WIL) programme at Rosebank College.

📞 Contact

Project Supervisor: Asande Zikalala

Team Email: ST10457381@rcconnect.edu.za

Client: Mr Ibrahim — ChowDown Café, Durban CBD

📚 References
Bennett, S., McRobb, S. and Farmer, R. (2010). Object-Oriented Systems Analysis and Design Using UML. 4th ed. London: McGraw-Hill.
Firebase. (2023). Firebase Documentation.
Oracle. (2019). Oracle Database Documentation.
📊 Project Status
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

<p align="center"> <strong>© 2026 Amajongo — Rosebank College WIL Project</strong> </p>
