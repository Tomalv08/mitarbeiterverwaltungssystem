-- Use the target database
USE MitarbeiterDB;
GO

-- Example update: Add a new column to the Employee table
IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'Email' AND Object_ID = Object_ID(N'Employee'))
BEGIN
    ALTER TABLE Employee ADD Email VARCHAR(255) NULL;
    PRINT 'Column Email added to Employee table';
END
ELSE
BEGIN
    PRINT 'Column Email already exists in Employee table';
END
GO

-- Example update: Modify the length of the Position column in Manager table
IF EXISTS (SELECT * FROM sys.columns WHERE Name = N'Position' AND Object_ID = Object_ID(N'Manager') AND max_length < 512)
BEGIN
    ALTER TABLE Manager ALTER COLUMN Position VARCHAR(512) NOT NULL;
    PRINT 'Column Position length updated in Manager table';
END
ELSE
BEGIN
    PRINT 'Column Position in Manager table is already of the required length';
END
GO
