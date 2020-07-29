CREATE PROCEDURE [dbo].[spSaveEmployeeKnownType]
	@Name nvarchar(50),  
	@Gender nvarchar(50),  
	@DateOfBirth DateTime,
	@EmployeeType int,
	@AnnualSalary int = null,
	@HourlyPay int = null,
	@HoursWorked int = null
AS
    Insert into tblEmployee values (@Name, @Gender, @DateOfBirth, 
	@EmployeeType, @AnnualSalary, @HourlyPay, @HoursWorked)