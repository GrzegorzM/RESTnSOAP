CREATE PROCEDURE [dbo].[spSaveEmployee]
	@Name nvarchar(50),
	@Gender nvarchar(50),
	@DateOfBirth DateTime
AS
	insert into tblEmployee values(@Name, @Gender, @DateOfBirth);