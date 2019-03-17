CREATE TABLE [dbo].[Employees]
(
	[EmployeeID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [LastName] NVARCHAR(50) NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [Title] NVARCHAR(30) NULL, 
    [BirthDate] DATETIME NULL, 
    [HomePhone] NVARCHAR(24) NULL 
)
