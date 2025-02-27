# Job Listings - ASP.NET Core MVC

## 📌 Project Overview
This is a simple **Job Listings** web application built using **ASP.NET Core MVC**. It allows users to view job listings, see job details, edit job entries, and sort jobs by posting date.

## 🚀 Features
- **List all job postings**
- **View job details**
- **Sort jobs by newest/oldest**
- **Edit job details** (including job type selection via a dropdown)
- **Navigation bar with Bootstrap**
- **Partial views for reusability (header & footer)**

## 🛠️ Technologies Used
- **ASP.NET Core MVC**
- **C#**
- **Bootstrap (for styling)**

## 📂 Main Project Structure
```
JobListingsProject/
│-- Controllers/
│   ├── JobController.cs
│-- Models/
│   ├── JobListing.cs
│-- Views/
│   ├── Job/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   ├── Edit.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Navbar.cshtml
│-- wwwroot/
│   ├── css/
│   ├── js/
│-- Program.cs
│-- Startup.cs
│-- README.md
```

## 🔧 Setup & Run
### 1️⃣ Clone the Repository
```sh
git clone https://github.com/shahad-jeza/TechJobPortal_with_ASP.NET.git
cd TechJobPortal
```
### 2️⃣ Run the Application
```sh
dotnet run
```
Open the browser and visit:  
🔗 `https://localhost:5001/Job`


## 📜 License
This project is open-source and available under the **MIT License**.

---
✅ Feel free to contribute or improve this project!

