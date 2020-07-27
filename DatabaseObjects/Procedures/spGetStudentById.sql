CREATE PROCEDURE [dbo].[spGetStudentById]
	@Id int
AS
	SELECT * from tblStudents where Id = @Id;
