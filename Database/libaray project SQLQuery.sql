/** 
Name: Abdelrahman Mohamed
 Student number : 200709050
Project: Library Automation System
**/

USE LibraryAutomation;


-- View all data in loginTable
SELECT * FROM loginTable;

-- View all data in NewBook
SELECT * FROM NewBook;

-- View all data in NewStudent
SELECT * FROM NewStudent;

-- View all data in IRBook
SELECT * FROM IRBook;


-- ================================
-- Table: loginTable
-- ================================

-- Creating the loginTable to store user credentials
CREATE TABLE loginTable (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,  -- Auto-increment ID
    username VARCHAR(150) NOT NULL,            -- Username (Required)
    pass VARCHAR(150) NOT NULL                 -- Password (Required)
);

-- Insert Sample Data into loginTable
INSERT INTO loginTable (username, pass)
VALUES ('admin', 'admin');



-- Update User Password Based on Username
UPDATE loginTable
SET pass = 'abdo'
WHERE username = '123';


-- ================================
-- Table: NewBook
-- ================================

-- Creating the NewBook table to store book details
CREATE TABLE NewBook (
    bid INT NOT NULL IDENTITY(1,1) PRIMARY KEY, -- Auto-increment Book ID
    bName VARCHAR(250) NOT NULL,               -- Book Name
    bAuthor VARCHAR(250) NOT NULL,             -- Author Name
    bPubl VARCHAR(250) NOT NULL,               -- Publisher Name
    bPDate VARCHAR(250) NOT NULL,              -- Publish Date
    bPrice BIGINT NOT NULL,                    -- Book Price
    bQuan BIGINT NOT NULL                      -- Quantity Available
);


-- Insert Sample Books into NewBook
INSERT INTO NewBook (bName, bAuthor, bPubl, bPDate, bPrice, bQuan)
VALUES 
('Data Structure', 'Jk Singh kumar', 'R and D', '2020-04-20', 5000, 45),
('Oops', 'Jk patel', 'rk publication', '2020-04-20', 800, 24),
('Java', 'Pk Singh', 'Rk Publication', '2020-04-20', 532, 30);


-- View All Books
SELECT * FROM NewBook;


-- ================================
-- Table: NewStudent
-- ================================

-- Creating the NewStudent table to store student details
CREATE TABLE NewStudent (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,   -- Auto-increment Student ID
    StudentName NVARCHAR(255) NOT NULL,        -- Student's Name
    StudentNumber NVARCHAR(50) NOT NULL,       -- Unique Student Number
    Department NVARCHAR(255) NOT NULL,         -- Department of the Student
    EducationLevel NVARCHAR(50) NOT NULL,      -- Education Level
    StudentContact NVARCHAR(50) NOT NULL       -- Contact Information
);

-- Insert Sample Students into NewStudent
INSERT INTO NewStudent (StudentName, StudentNumber, Department, EducationLevel, StudentContact)
VALUES 
('Ahmet Yılmaz', '20230101', 'Computer Engineering', 'Bachelor''s', '5551234567'),
('Fatma Demir', '20230102', 'Electrical Engineering', 'Master''s', '5552345678');


-- View All Students
SELECT * FROM NewStudent;


-- ================================
-- Table: IRBook (Issued and Returned Books)
-- ================================

-- Creating the IRBook table to track issued and returned books
CREATE TABLE IRBook (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,   -- Unique Record ID
    student_number VARCHAR(250) NOT NULL,        -- Student Number
    std_name VARCHAR(250) NOT NULL,              -- Student's Name
    std_dep VARCHAR(250) NOT NULL,               -- Department
    std_contact BIGINT NOT NULL,                 -- Contact Number
    book_name VARCHAR(1250) NOT NULL,            -- Issued Book Name
    book_issue_date VARCHAR(250) NOT NULL,       -- Issue Date
    book_return_date VARCHAR(250)                -- Return Date (Nullable)
);

-- Filter Books Issued but Not Returned
SELECT * FROM IRBook 
WHERE student_number = '1234' AND book_return_date IS NULL;

-- View All Issued and Returned Books
SELECT * FROM IRBook;



-- ================================
-- Stored Procedures
-- ================================
-- Stored Procedure to add a new book to the database
CREATE PROCEDURE AddNewBook
    @bName VARCHAR(250), -- Name of the book
    @bAuthor VARCHAR(250), -- Author of the book
    @bPubl VARCHAR(250), -- Publisher of the book
    @bPDate VARCHAR(250), -- Publish date of the book
    @bPrice BIGINT, -- Price of the book
    @bQuan BIGINT -- Quantity of the book
AS
BEGIN
    -- Insert the provided book details into the NewBook table
    INSERT INTO NewBook (bName, bAuthor, bPubl, bPDate, bPrice, bQuan)
    VALUES (@bName, @bAuthor, @bPubl, @bPDate, @bPrice, @bQuan);
END;

-- Stored Procedure to get all books from the database
CREATE PROCEDURE GetAllBooks
AS
BEGIN
    -- Select all records from the NewBook table
    SELECT * FROM NewBook;
END;

-- Stored Procedure to issue a book to a student
CREATE PROCEDURE IssueBook
    @student_number VARCHAR(250), -- Student's unique number
    @std_name VARCHAR(250), -- Student's name
    @std_dep VARCHAR(250), -- Student's department
    @std_contact BIGINT, -- Student's contact number
    @book_name VARCHAR(1250), -- Name of the book being issued
    @book_issue_date VARCHAR(250) -- Issue date of the book
AS
BEGIN
    -- Insert a new record in the IRBook table for the issued book
    INSERT INTO IRBook (student_number, std_name, std_dep, std_contact, book_name, book_issue_date, book_return_date)
    VALUES (@student_number, @std_name, @std_dep, @std_contact, @book_name, @book_issue_date, NULL);
END;

-- Stored Procedure to mark a book as returned
CREATE PROCEDURE ReturnBook
    @id INT, -- ID of the record in IRBook table
    @book_return_date VARCHAR(250) -- Return date of the book
AS
BEGIN
    -- Update the return date for the specific record in IRBook table
    UPDATE IRBook
    SET book_return_date = @book_return_date
    WHERE id = @id;
END;

-- Stored Procedure to get issued books for a specific student
CREATE PROCEDURE GetIssuedBooksByStudent
    @student_number VARCHAR(250) -- Student's unique number
AS
BEGIN
    -- Select all books issued to the student that are not returned
    SELECT * FROM IRBook
    WHERE student_number = @student_number AND book_return_date IS NULL;
END;

-- ================================
-- Triggers
-- ================================
-- Trigger to log a message when a new book is added
CREATE TRIGGER trg_AfterBookInsert
ON NewBook
AFTER INSERT
AS
BEGIN
    -- Print a confirmation message when a new book is added
    PRINT 'A new book has been added.';
END;

-- Trigger to log a message when a book is issued
CREATE TRIGGER trg_AfterBookIssue
ON IRBook
AFTER INSERT
AS
BEGIN
    -- Print a confirmation message when a book is issued
    PRINT 'A book has been issued.';
END;

-- Trigger to update the quantity of a book when it is issued
CREATE TRIGGER trg_UpdateQuantityOnIssue
ON IRBook
AFTER INSERT
AS
BEGIN
    -- Declare a variable to store the book name from the inserted row
    DECLARE @book_name VARCHAR(1250);
    SELECT @book_name = book_name FROM inserted;

    -- Update the quantity of the book in NewBook table
    UPDATE NewBook
    SET bQuan = bQuan - 1
    WHERE bName = @book_name;
END;

-- ================================
-- View
-- ================================


-- View to show detailed information about issued books
CREATE VIEW IssuedBookDetails
AS
SELECT
    IRBook.id, -- Record ID from IRBook table
    IRBook.student_number, -- Student's unique number
    NewStudent.StudentName, -- Student's name from NewStudent table
    IRBook.book_name, -- Name of the issued book
    IRBook.book_issue_date, -- Issue date of the book
    IRBook.book_return_date -- Return date of the book (if returned)
FROM IRBook
INNER JOIN NewStudent ON IRBook.student_number = NewStudent.StudentNumber;

-- ================================
-- Functions
-- ================================

-- Function to calculate the total quantity of books in the library
CREATE FUNCTION GetTotalBookQuantity()
RETURNS BIGINT
AS
BEGIN
    -- Declare a variable to store the total quantity
    DECLARE @total BIGINT;
    -- Sum up the quantities of all books in the NewBook table
    SELECT @total = SUM(bQuan) FROM NewBook;
    RETURN @total;
END;

-- Function to check if a student has overdue books
CREATE FUNCTION HasOverdueBooks(@student_number VARCHAR(250))
RETURNS BIT
AS
BEGIN
    -- Declare a variable to store the result (1 if overdue books exist, 0 otherwise)
    DECLARE @result BIT;
    IF EXISTS (
        SELECT * FROM IRBook
        WHERE student_number = @student_number AND book_return_date IS NULL
          AND book_issue_date < DATEADD(DAY, -30, GETDATE()) -- Books issued more than 30 days ago
    )
        SET @result = 1;
    ELSE
        SET @result = 0;

    RETURN @result;
END;

-- Function to count the number of books issued by a specific student
CREATE FUNCTION GetBooksIssuedByStudent(@student_number VARCHAR(250))
RETURNS INT
AS
BEGIN
    -- Declare a variable to store the count of issued books
    DECLARE @count INT;
    -- Count the books issued to the student that are not returned
    SELECT @count = COUNT(*) FROM IRBook
    WHERE student_number = @student_number AND book_return_date IS NULL;
    RETURN @count;
END;
