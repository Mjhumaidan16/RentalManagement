-- Use master context
USE master;
GO

-- Drop the EquipmentRentalDB if it exists
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'EquipmentRentalDB')
BEGIN
    ALTER DATABASE EquipmentRentalDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE EquipmentRentalDB;
END;
GO

-- Create the database
CREATE DATABASE EquipmentRentalDB;
GO

-- Switch to the new database
USE EquipmentRentalDB;
GO

-- USERS TABLE
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(50) NOT NULL,
    Role VARCHAR(20) CHECK (Role IN ('Admin', 'Manager', 'Customer')) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    PhoneNumber BIGINT,
    Address VARCHAR(50),
    LastLogin DATETIME
);

-- CATEGORIES
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20) UNIQUE NOT NULL,
    Description TEXT NULL
);

-- EQUIPMENT
CREATE TABLE Equipment (
    EquipmentID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Description TEXT NULL,
    CategoryID INT NOT NULL,
    RentalPrice DECIMAL(10,2) NOT NULL,
    AvailabilityStatus VARCHAR(20) CHECK (AvailabilityStatus IN ('Available', 'Unavailable', 'Under Maintenance')) NOT NULL,
    ConditionStatus VARCHAR(20) CHECK (ConditionStatus IN ('New', 'Good', 'Damaged')) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    LastUpdated DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE CASCADE
);

-- RENTAL REQUESTS
CREATE TABLE RentalRequests (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    EquipmentID INT NOT NULL,
    RentalStartDate DATETIME NOT NULL,
    ReturnDate DATETIME NOT NULL,
    TotalCost DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) CHECK (Status IN ('Pending', 'Approved', 'Rejected')) NOT NULL,
    DateRequested DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID) ON DELETE CASCADE
);

-- RENTAL TRANSACTIONS
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
    RentalPeriod INT,
    DateProcessed DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RequestID) REFERENCES RentalRequests(RequestID) ON DELETE CASCADE,
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID)
);

-- RETURN RECORDS
CREATE TABLE ReturnRecords (
    ReturnID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT NOT NULL,
    ActualReturnDate DATETIME NOT NULL,
    ReturnCondition VARCHAR(30) CHECK (ReturnCondition IN ('Good', 'Damaged', 'Lost')) NOT NULL,
    LateReturnFees DECIMAL(10,2) NULL,
    AdditionalCharges DECIMAL(10,2) NULL,
    FOREIGN KEY (TransactionID) REFERENCES RentalTransactions(TransactionID) ON DELETE CASCADE
);

-- FEEDBACK
CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    EquipmentID INT NOT NULL,
    Rating INT CHECK (Rating BETWEEN 1 AND 5) NOT NULL,
    Comment TEXT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    TransactionID INT,
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID),
    FOREIGN KEY (TransactionID) REFERENCES RentalTransactions(TransactionID)
);

-- DOCUMENTS
CREATE TABLE Documents (
    DocumentID INT IDENTITY(1,1) PRIMARY KEY,
    RentalTransactionID INT NOT NULL,
    FileName VARCHAR(100) NOT NULL,
    FileType VARCHAR(50) NOT NULL,
    FilePath VARCHAR(100) NOT NULL,
    UploadedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UserID INT,
    FOREIGN KEY (RentalTransactionID) REFERENCES RentalTransactions(TransactionID) ON DELETE CASCADE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- NOTIFICATIONS
CREATE TABLE Notifications (
    NotificationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    MessageContent TEXT NOT NULL,
    Type VARCHAR(50) CHECK (Type IN ('Rental Approval', 'Return Reminder', 'General')) NOT NULL,
    Status VARCHAR(20) CHECK (Status IN ('Read', 'Unread')) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- LOGS
CREATE TABLE Logs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Action VARCHAR(75) NOT NULL,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    Source VARCHAR(30) CHECK (Source IN ('Web', 'Desktop')) NOT NULL,
    Details TEXT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- PAYMENTS
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentMethod VARCHAR(50) CHECK (PaymentMethod IN ('Credit Card', 'Debit Card', 'PayPal', 'Bank Transfer')) NOT NULL,
    PaymentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) CHECK (Status IN ('Successful', 'Pending', 'Failed')) NOT NULL,
    FOREIGN KEY (TransactionID) REFERENCES RentalTransactions(TransactionID) ON DELETE CASCADE
);

-- MAINTENANCE
CREATE TABLE MaintenanceRecords (
    MaintenanceID INT IDENTITY(1,1) PRIMARY KEY,
    EquipmentID INT NOT NULL,
    MaintenanceDate DATETIME NOT NULL,
    Description TEXT NOT NULL,
    Cost DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) CHECK (Status IN ('Scheduled', 'In Progress', 'Completed')) NOT NULL,
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID) ON DELETE CASCADE
);

-- INSERT USERS
INSERT INTO Users (Name, Email, PasswordHash, PhoneNumber, Address, Role) VALUES
('Admin User', 'admin@example.com', 'hashed123', 9731234567, 'Admin HQ', 'Admin'),
('John Doe', 'john@example.com', 'hashed456', 9739876543, 'Customer Street', 'Customer'),
('Manager One', 'manager@example.com', 'hashed789', 9731122334, 'Manager Avenue', 'Manager');

-- INSERT CATEGORIES
INSERT INTO Categories (Name, Description) VALUES
('Cameras', 'Photography and video equipment'),
('Laptops', 'Computing devices for rent'),
('Tools', 'Construction and mechanical tools');

-- INSERT EQUIPMENT
INSERT INTO Equipment (Name, Description, CategoryID, RentalPrice, AvailabilityStatus, ConditionStatus) VALUES
('Canon EOS R5', 'High-quality camera', 1, 50.00, 'Available', 'New'),
('Dell XPS 15', 'Powerful laptop', 2, 40.00, 'Available', 'Good'),
('Bosch Hammer Drill', 'Heavy-duty drill for concrete and masonry', 3, 30.00, 'Available', 'New'),
('Stanley Claw Hammer', 'Durable steel hammer for carpentry', 3, 10.00, 'Available', 'Good');

-- INSERT RENTAL REQUESTS
INSERT INTO RentalRequests (CustomerID, EquipmentID, RentalStartDate, ReturnDate, TotalCost, Status) VALUES
(2, 1, '2025-05-20', '2025-05-25', 250.00, 'Pending'),
(2, 3, '2025-06-01', '2025-06-03', 60.00, 'Approved'),
(2, 4, '2025-06-05', '2025-06-07', 20.00, 'Pending');

-- INSERT RENTAL TRANSACTIONS
INSERT INTO RentalTransactions (RequestID, CustomerID, EquipmentID, ActualStartDate, RentalFee, Deposit, PaymentStatus, RentalPeriod) VALUES
(1, 2, 1, '2025-05-20', 250.00, 50.00, 'Paid', 5),
(2, 2, 3, '2025-06-01', 60.00, 10.00, 'Paid', 2),
(3, 2, 4, '2025-06-05', 20.00, 5.00, 'Pending', 2);

-- INSERT RETURN RECORDS
INSERT INTO ReturnRecords (TransactionID, ActualReturnDate, ReturnCondition, LateReturnFees, AdditionalCharges) VALUES
(1, '2025-05-25', 'Good', 0.00, 0.00),
(2, '2025-06-03', 'Good', 0.00, 0.00);

-- INSERT FEEDBACK
INSERT INTO Feedback (CustomerID, EquipmentID, Rating, Comment, TransactionID) VALUES
(2, 1, 5, 'Amazing experience!', 1),
(2, 3, 4, 'Worked great for my renovation project.', 2);

-- INSERT DOCUMENTS
INSERT INTO Documents (RentalTransactionID, FileName, FileType, FilePath, UserID) VALUES
(1, 'contract.pdf', 'PDF', '/files/contracts/contract1.pdf', 2),
(2, 'drill_rental_agreement.pdf', 'PDF', '/files/contracts/drill_contract.pdf', 2);

-- INSERT NOTIFICATIONS
INSERT INTO Notifications (UserID, MessageContent, Type, Status) VALUES
(2, 'Your rental request is pending approval.', 'Rental Approval', 'Unread'),
(2, 'Your drill rental has been approved.', 'Rental Approval', 'Read'),
(2, 'Your hammer rental request is pending.', 'Rental Approval', 'Unread');

-- INSERT LOGS
INSERT INTO Logs (UserID, Action, Source, Details) VALUES
(2, 'Submitted rental request', 'Web', 'User requested Canon EOS R5 for 5 days.'),
(2, 'Requested Bosch Hammer Drill rental', 'Web', 'User selected 2-day rental.'),
(2, 'Requested Stanley Claw Hammer rental', 'Web', 'User selected 2-day rental.');

-- INSERT PAYMENTS
INSERT INTO Payments (TransactionID, Amount, PaymentMethod, Status) VALUES
(1, 300.00, 'Credit Card', 'Successful'),
(2, 70.00, 'PayPal', 'Successful'),
(3, 25.00, 'Credit Card', 'Pending');

-- INSERT MAINTENANCE RECORDS
INSERT INTO MaintenanceRecords (EquipmentID, MaintenanceDate, Description, Cost, Status) VALUES
(1, '2025-05-18', 'Lens cleaning and firmware update', 20.00, 'Completed'),
(3, '2025-05-19', 'Battery replacement and testing', 15.00, 'Completed'),
(4, '2025-05-17', 'Handle inspection and grip repair', 5.00, 'Completed');
