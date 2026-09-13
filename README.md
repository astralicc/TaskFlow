# 🚀 TaskFlow

Welcome to **TaskFlow**! This is my very first software development project, built specifically as a learning milestone for the LKS (Lomba Kompetensi Siswa) competition. 

TaskFlow is a robust desktop application designed to help users efficiently track and manage their daily tasks. It emphasizes clean code, stable data management, and a professional user interface.

## ✨ Features

* **User Authentication:** Tracks tasks individually based on the currently logged-in user.
* **Complete CRUD Operations:** Create, Read, Update, and Delete tasks seamlessly.
* **Smart Modal Architecture:** Uses a single, intelligently designed modal (`AddTaskModal`) for both creating new tasks and editing existing ones to reduce code duplication.
* **Strict Data Validation:** Implements guard clauses and input sanitization to prevent empty submissions and maintain database integrity.
* **Dynamic Data Binding:** Features a crash-proof DataGridView with auto-incrementing row numbers and seamless Entity Framework object extraction.
* **Status Tracking:** Dropdown-enforced status management (e.g., Pending, Unfinished, Completed) to prevent typos and ensure strict data types.

## 🛠️ Tech Stack

* **Language:** C#
* **Framework:** Windows Forms (WinForms)
* **ORM:** Entity Framework Core (EF Core)
* **Database:** Microsoft SQL Server

## 🚀 Setup Instructions

Follow these steps to run TaskFlow on your local machine:

### 1. Prerequisites
* Install [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload.
* Install **Microsoft SQL Server** and **SQL Server Management Studio (SSMS)**.

### 2. Database Setup
1. Open SSMS and connect to your local SQL Server instance.
2. Open the `TaskFlowDb.sql` file included in this repository.
3. Execute the script to automatically generate the database schema, tables, and default data.
4. *(Optional)* Verify that your database connection string in the C# project (inside `TaskFlowDbContext.cs`) matches your local SQL Server instance name.

### 3. Running the Application
1. Open `TaskFlow.sln` in Visual Studio.
2. Wait a moment for Visual Studio to restore the necessary NuGet packages (like EF Core).
3. Press `F5` or click **Start** at the top of Visual Studio to compile and run the application.

---
*Designed and developed as a foundational learning project for LKS.*
