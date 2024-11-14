-- Use the target database
USE MitarbeiterDB;
GO

-- Insert example data into Manager table
INSERT INTO Manager (Id, Name, Position, Department)
VALUES (1, 'John Doe', 'Senior Manager', 'IT');

-- Insert example data into Employee table
INSERT INTO Employee (Name, Position, Department, ManagerId)
VALUES ('Jane Smith', 'Developer', 'IT', 1),
       ('Bob Brown', 'Tester', 'IT', 1);

PRINT 'Example data inserted into Manager and Employee tables';
GO

-- Interactive script for inserting example data
DECLARE @Name VARCHAR(255);
DECLARE @Position VARCHAR(255);
DECLARE @Department VARCHAR(255);
DECLARE @ManagerId INT;

PRINT 'Enter the following details for a new Employee:';
SET @Name = 'Enter name here';  -- Replace with actual user input
SET @Position = 'Enter position here';  -- Replace with actual user input
SET @Department = 'Enter department here';  -- Replace with actual user input
SET @ManagerId = 1;  -- Replace with actual user input

INSERT INTO Employee (Name, Position, Department, ManagerId)
VALUES (@Name, @Position, @Department, @ManagerId);

PRINT 'Interactive example data inserted into Employee table';
GO
