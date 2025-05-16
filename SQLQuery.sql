
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'EquipmentRentalDB')
BEGIN
    CREATE DATABASE EquipmentRentalDB;
END;
GO

USE EquipmentRentalDB;
GO

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(50) NOT NULL,
    
    Role VARCHAR(20) CHECK (Role IN ('Admin', 'Manager', 'Customer')) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20) UNIQUE NOT NULL,
    Description TEXT NULL
);


CREATE TABLE Equipment (
    EquipmentID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Description TEXT NULL,
    CategoryID INT NOT NULL,
    RentalPrice DECIMAL(10,2) NOT NULL,
    AvailabilityStatus VARCHAR(20) CHECK (AvailabilityStatus IN ('Available', 'Unavailable', 'Under Maintenance')) NOT NULL,
    ConditionStatus VARCHAR(20) CHECK (ConditionStatus IN ('New', 'Good', 'Damaged')) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE CASCADE
);


CREATE TABLE RentalRequests (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    EquipmentID INT NOT NULL,
    RentalStartDate DATETIME NOT NULL,
    ReturnDate DATETIME NOT NULL,
    TotalCost DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) CHECK (Status IN ('Pending', 'Approved', 'Rejected')) NOT NULL,
    
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID) ON DELETE CASCADE
);


CREATE TABLE RentalTransactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    RequestID INT NOT NULL,
    CustomerID INT NOT NULL,
    EquipmentID INT NOT NULL,
    ActualStartDate DATETIME NOT NULL,
    ActualReturnDate DATETIME NULL,
    RentalFee DECIMAL(10,2) NOT NULL,
    Deposit DECIMAL(10,2) NOT NULL,
    PaymentStatus VARCHAR(20) CHECK (PaymentStatus IN ('Paid', 'Pending', 'Overdue')) NOT NULL,
   
    
    FOREIGN KEY (RequestID) REFERENCES RentalRequests(RequestID) ON DELETE CASCADE,
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID)
);


CREATE TABLE ReturnRecords (
    ReturnID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT NOT NULL,
    ActualReturnDate DATETIME NOT NULL,
    ReturnCondition VARCHAR(30) CHECK (ReturnCondition IN ('Good', 'Damaged', 'Lost')) NOT NULL,
    LateReturnFees DECIMAL(10,2) NULL,
    AdditionalCharges DECIMAL(10,2) NULL,
    FOREIGN KEY (TransactionID) REFERENCES RentalTransactions(TransactionID) ON DELETE CASCADE
);


CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    EquipmentID INT NOT NULL,
    
    Rating INT CHECK (Rating BETWEEN 1 AND 5) NOT NULL,
    Comment TEXT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID),
   
);


CREATE TABLE Documents (
    DocumentID INT IDENTITY(1,1) PRIMARY KEY,
    RentalTransactionID INT NOT NULL,
    
    FileName VARCHAR(100) NOT NULL,
    FileType VARCHAR(50) NOT NULL,
    FilePath VARCHAR(100) NOT NULL,
    UploadedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RentalTransactionID) REFERENCES RentalTransactions(TransactionID) ON DELETE CASCADE,
   
);


CREATE TABLE Notifications (
    NotificationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    MessageContent TEXT NOT NULL,
    Type VARCHAR(50) CHECK (Type IN ('Rental Approval', 'Return Reminder', 'General')) NOT NULL,
    Status VARCHAR(20) CHECK (Status IN ('Read', 'Unread')) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);


CREATE TABLE Logs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Action VARCHAR(75) NOT NULL,
   
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    Source VARCHAR(30) CHECK (Source IN ('Web', 'Desktop')) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);


CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentMethod VARCHAR(50) CHECK (PaymentMethod IN ('Credit Card', 'Debit Card', 'PayPal', 'Bank Transfer')) NOT NULL,
    PaymentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) CHECK (Status IN ('Successful', 'Pending', 'Failed')) NOT NULL,
    FOREIGN KEY (TransactionID) REFERENCES RentalTransactions(TransactionID) ON DELETE CASCADE
);


CREATE TABLE MaintenanceRecords (
    MaintenanceID INT IDENTITY(1,1) PRIMARY KEY,
    EquipmentID INT NOT NULL,
    MaintenanceDate DATETIME NOT NULL,
    Description TEXT NOT NULL,
    Cost DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) CHECK (Status IN ('Scheduled', 'In Progress', 'Completed')) NOT NULL,
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID) ON DELETE CASCADE
);


INSERT INTO Users (Name, Email, PasswordHash, PhoneNumber, Address, Role) VALUES
('Admin User', 'admin@example.com', 'hashedpassword123', 1234567890, '123 Admin St', 'Admin'),
('John Doe', 'john@example.com', 'hashedpassword123', 9876543210, '456 Customer Rd', 'Customer'),
('Manager One', 'manager@example.com', 'hashedpassword123', 1122334455, '789 Manager Ln', 'Manager');

INSERT INTO Categories (Name, Description) VALUES
('Power Tools', 'Tools for construction and repair'),
('Cameras', 'Professional and consumer cameras'),
('Event Supplies', 'Items for event management');

INSERT INTO Equipment (Name, Description, CategoryID, RentalPrice, AvailabilityStatus, ConditionStatus) VALUES
('Drill Machine', 'Heavy duty drill machine', 1, 20.00, 'Available', 'New'),
('DSLR Camera', 'Canon EOS DSLR', 2, 50.00, 'Available', 'Good');


SELECT * FROM Users;
SELECT * FROM Categories;
SELECT * FROM Equipment;


ALTER TABLE Users 
ADD PhoneNumber INT,
    Address VARCHAR(50),
    LastLogin DATETIME;
ALTER TABLE Equipment 
ADD LastUpdated DATETIME DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE RentalRequests 
ADD DateRequested DATETIME DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE RentalTransactions 
ADD RentalPeriod INT,
    DateProcessed DATETIME DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE Feedback 
ADD TransactionID INT,
    FOREIGN KEY (TransactionID) REFERENCES RentalTransactions(TransactionID);

ALTER TABLE Documents 
ADD UserID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID);

ALTER TABLE Logs 
ADD Details TEXT;
