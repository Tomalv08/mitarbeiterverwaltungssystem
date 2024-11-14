-- Check if the database exists, and if not, create it
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'MitarbeiterDB')
BEGIN
    CREATE DATABASE MitarbeiterDB;
    PRINT 'Database MitarbeiterDB created';
END
ELSE
BEGIN
    PRINT 'Database MitarbeiterDB already exists';
END
GO

-- Use the newly created or existing database
USE MitarbeiterDB;
GO

-- Create Employee table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employee')
BEGIN
    CREATE TABLE Employee (
        Id INT PRIMARY KEY IDENTITY,
        Name VARCHAR(255) NOT NULL,
        Position VARCHAR(255) NOT NULL,
        Department VARCHAR(255),
        ManagerId INT NULL,
        FOREIGN KEY (ManagerId) REFERENCES Employee(Id)
    );
    PRINT 'Table Employee created';
END
ELSE
BEGIN
    PRINT 'Table Employee already exists';
END
GO

-- Create Manager table (inherits from Employee)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Manager')
BEGIN
    CREATE TABLE Manager (
        Id INT PRIMARY KEY,
        Name VARCHAR(255) NOT NULL,
        Position VARCHAR(255) NOT NULL,
        Department VARCHAR(255)
    );
    PRINT 'Table Manager created';
END
ELSE
BEGIN
    PRINT 'Table Manager already exists';
END
GO
