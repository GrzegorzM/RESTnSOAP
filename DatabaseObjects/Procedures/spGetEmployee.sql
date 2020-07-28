CREATE PROCEDURE [dbo].[spGetEmployee]
	@Id int
AS
	SELECT * from tblEmployee where Id = @Id;