/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Davolio','Nancy','Sales Representative','12/08/1948','(206) 555-9857')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Fuller','Andrew','Vice President, Sales','02/19/1952','(206) 555-9482')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Leverling','Janet','Sales Representative','08/30/1963','(206) 555-3412')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Peacock','Margaret','Sales Representative','09/19/1937','(206) 555-8122')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Buchanan','Steven','Sales Manager','03/04/1955','(71) 555-4848')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Suyama','Michael','Sales Representative','07/02/1963','(71) 555-7773')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('King','Robert','Sales Representative','05/29/1960','(71) 555-5598')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Callahan','Laura','Inside Sales Coordinator','01/09/1958','(206) 555-1189')
GO
INSERT Employees(LastName,FirstName,Title,BirthDate,HomePhone) VALUES('Dodsworth','Anne','Sales Representative','01/27/1966','(71) 555-4444')