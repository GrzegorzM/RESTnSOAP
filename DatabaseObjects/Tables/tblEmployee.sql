CREATE TABLE [dbo].[tblEmployee]
(
	Id int primary key identity(1, 1),
    Name nvarchar(50) not null,
    Gender nvarchar(50) not null,
    DateOfBirth datetime not null
)
