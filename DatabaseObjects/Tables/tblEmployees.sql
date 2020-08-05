CREATE TABLE [dbo].[tblEmployees]
(
	id int primary key identity(1, 1),
    FirstName nvarchar(50) not null,
    LastName nvarchar(50) not null,
    Gender nvarchar(50) not null,
    Salary int not null
)
