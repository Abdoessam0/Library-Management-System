README.txt
----------

Library Management System

***** Video Demonstration *****

To understand how to set up and use the system, you can watch one of the following videos:

                      (((  both are the same but diffrent places   )))

1. YouTube Link: https://youtu.be/hehpJhh1Btg  
2. Google Drive Link: https://drive.google.com/file/d/12yA8NuQFsHbvKFp88OGppxZlCjaNppeH/view?usp=sharing

----------

Project Overview

The Library Management System is a desktop application designed to manage books, students, and borrowing/returning processes. The project uses C# for the application interface and Microsoft SQL Server for the database.

----------

Contents

1. Included Files:
   - LibraryAutomation.bak: A backup file of the database.
   - LibraryAutomation.sql: A script to create and initialize the database.
   - Abdelrahman_mohamed_200709050.sln: The Visual Studio solution file.
   - ER Diagram.png: A visual representation of the database structure.
   - Folder Abdelrahman_mohamed_200709050: Contains additional resources.
   - Folder Query folders: Includes stored procedures, triggers, and functions.
   - Folder projects images windows: Contains screenshots of application pages.
   - This file README.txt.

2. Key Features:
   - 5 Stored Procedures: Adding, updating, and deleting book and member records, as well as viewing available books.
   - 3 Triggers:
     - Ensure positive quantities of books.
     - Update book status upon borrowing.
     - Prevent deleting members with active borrowings.
   - 1 View: BorrowedBooksView to display borrowed book details along with member information.
   - 3 Functions:
     - Calculate total books.
     - Count active members.
     - Calculate penalties for overdue returns.

----------

How to Set Up and Run the Project

1. Extract the Files:
   - Extract the .zip file to a folder on your local machine.

2. Setting Up the Database:
   Option A: Restore Database from Backup
   - Open SQL Server Management Studio (SSMS).
   - Connect to your SQL Server instance.
   - Right-click on Databases → Restore Database.
   - Select Device and locate the file LibraryAutomation.bak.
   - Ensure the database is named LibraryAutomation.
   - Click OK to restore the database.

   Option B: Use SQL Script
   - Open SQL Server Management Studio (SSMS).
   - Connect to your SQL Server instance.
   - Open the LibraryAutomation.sql file.
   - Execute the script to create and populate the database.
   - Ensure the database name matches LibraryAutomation.

3. Configuring the Project:
   - Open the Project in Visual Studio:
     - Open Visual Studio.
     - Go to File → Open → Project/Solution.
     - Navigate to the project folder and open Abdelrahman_mohamed_200709050.sln.

   - Update the Connection String:
     - Locate the connection string in the code 

     - Update it with your SQL Server instance name:
       string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

     - Replace YOUR_SERVER_NAME with your SQL Server instance (e.g., DESKTOP-12345\SQLEXPRESS).

4. Running the Application:
   - Build the Project:
     - In Visual Studio, go to Build > Build Solution 

   - Run the Project:
     - click Start to launch the application.

   - Login Credentials:
     - Username: admin
     - Password: admin

----------

Application Walkthrough

Login Page:
- Enter the username and password to log in.
- Redirects to the dashboard upon successful login.

Dashboard:
- Provides options to:
  - Manage Books (Add, Update, View, Delete)
  - Manage Students (Add, Update, View, Delete)
  - Issue Books
  - Return Books
  - View Reports (Issued and Returned Books)

Add Book Page:
- Allows users to add new books with details like name, author, publication, price, and quantity.

View Books Page:
- Displays all books and enables updating prices/quantities or deleting records.

Add Student Page:
- Adds students with details like name, number, department, and contact.

View Students Page:
- Displays student information and allows updates or deletions.

Issue Books Page:
- Issues books to students with limits on borrowing (max 3 books).

Return Books Page:
- Tracks and updates returned books.

Compelete the books page:
 - Show the issue books and Return books transaction 

----------

Troubleshooting

1. Database Connection Issues:
   - Verify SQL Server is running and accessible.
   - Check the database name and server instance in the connection string.

2. Missing Tables or Data:
   - Re-run the LibraryAutomation.sql script or restore the LibraryAutomation.bak file.

3. Build Errors:
   - Ensure all dependencies are installed in Visual Studio.
   - Check your .NET Framework version.

----------

Contact Information

- Name: Abdelrahman Mohamed  
- Email: abdoessammo@gmail.com  
- Phone: +905527508202  

----------

This concludes the **ReadMe** file for the Library Management System. Follow the steps carefully, and feel free to contact me if you encounter any issues. Thank you!
