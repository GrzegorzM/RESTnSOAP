CREATE TABLE [dbo].[tblStudents]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1, 1),
	Name nvarchar(50) not null,
	Gender nvarchar(50) not null,
	TotalMarks int not null
)
