CREATE TABLE [dbo].[tblEmployeeKnownType]
(
	Id int primary key identity(1, 1),
    Name nvarchar(50) not null,
    Gender nvarchar(50) not null,
    DateOfBirth datetime not null,
    EmployeeType int not null,
    AnnualSalary int,
    HourlyPay int,
    HoursWorked int
)
