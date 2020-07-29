CREATE PROCEDURE [dbo].[spGetEmployeeKnownType]
	@Id int
AS
	Select * from tblEmployee where Id = @Id;
