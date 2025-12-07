# 📚 Library Management System

## 🎥 Video Demonstration

To see the system in action:

- **YouTube:**  
  https://youtu.be/hehpJhh1Btg

- **Google Drive:**  
  https://drive.google.com/file/d/12yA8NuQFsHbvKFp88OGppxZlCjaNppeH/view

---

# 🖼️ Project Screenshots

### Dashboard  
![Dashboard](https://github.com/user-attachments/assets/ea42942a-58d4-4f0b-96a3-7d6c15c6b45a)

### Issued & Returned Books  
![Issued Returned](https://github.com/user-attachments/assets/9dabbdb6-e831-4e83-87d7-c1445f382ae3)

### Add Book  
![Add Book](https://github.com/user-attachments/assets/fab44502-161a-421a-8baf-5675b37e2cc2)

### Add Student  
![Add Student](https://github.com/user-attachments/assets/9567d943-6e6c-4dd7-8295-d98bdca627bd)

### View Students  
![View Students](https://github.com/user-attachments/assets/9d901efd-63f4-4e17-be1e-055755525d8a)

### View Books  
![View Books](https://github.com/user-attachments/assets/cc3d4252-672b-4f76-bd6e-9fecf30be903)

### Return Books  
![Return Books](https://github.com/user-attachments/assets/5629ecd7-4b2c-4628-af8f-b3ed694d12ba)

### Issue Books  
![Issue Books](https://github.com/user-attachments/assets/6cd9fb8b-8974-4a69-987b-7abab9a46f08)

---

# 📌 Project Overview

A complete **Library Management System** developed using:

- **C# Windows Forms**
- **SQL Server**
- **T-SQL Stored Procedures & Triggers**

The system allows you to:

- Manage books  
- Manage students  
- Issue & return books  
- Track all transactions  
- View combined issued/returned reports  

---

# 📦 Included Files

- `LibraryAutomation.bak` – Database backup  
- `LibraryAutomation.sql` – Script to create the database  
- `Abdelrahman_mohamed_200709050.sln` – Visual Studio Solution  
- `ER Diagram.png` – Database diagram  
- `Query folders` – Stored Procedures, Triggers, Functions  
- `projects images windows` – Screenshots  
- `README.txt`  

---

# 🗄️ SQL Backend Details

### Database
- **Name:** `LibraryAutomation`  
- **Engine:** Microsoft SQL Server  
- **Logic:** Stored procedures, triggers, functions, and views  

---

## 🔧 Stored Procedures (5)

- Add or update books  
- Add or update students  
- Delete books  
- Delete students  
- View available books  

---

## ⚠️ Triggers (3)

- Prevent negative book quantities  
- Update book status when issued or returned  
- Block deleting a student with active borrowed books  

---

## 👁️ Database View (1)

- **BorrowedBooksView**  
  Shows issued + returned book details with student names.

---

## 🧮 Functions (3)

- Calculate total number of books  
- Count active members  
- Calculate overdue penalties  

---

# 🚀 Setup & Installation

## 1️⃣ Extract Files
Unzip the project to any folder.

---

## 2️⃣ Create the Database

### Option A — Restore `.bak`

1. Open **SQL Server Management Studio (SSMS)**  
2. Right-click **Databases → Restore Database**  
3. Select file: `LibraryAutomation.bak`  
4. Restore as **LibraryAutomation**

---

### Option B — Run SQL Script

1. Open **LibraryAutomation.sql** in SSMS  
2. Execute  
3. Confirm database name is **LibraryAutomation**

---

## 3️⃣ Configure Visual Studio

Open:

