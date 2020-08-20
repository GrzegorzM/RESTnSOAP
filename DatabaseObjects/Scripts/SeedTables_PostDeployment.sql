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

Insert into tblStudents values('Mark Hastings','Male',900)
Insert into tblStudents values('Pam Nicholas','Female',760)
Insert into tblStudents values('John Stenson','Male',980)
Insert into tblStudents values('Ram Gerald','Male',990)
Insert into tblStudents values('Ron Simpson','Male',440)
Insert into tblStudents values('Able Wicht','Male',320)
Insert into tblStudents values('Steve Thompson','Male',983)
Insert into tblStudents values('James Bynes','Male',720)
Insert into tblStudents values('Mary Ward','Female',870)
Insert into tblStudents values('Nick Niron','Male',680)

Insert into tblEmployee values ('Mark', 'Male', '10/10/1980')
Insert into tblEmployee values ('Mary', 'Female', '11/10/1981')
Insert into tblEmployee values ('John', 'Male', '8/10/1979')

Insert into tblEmployees values ('Mark', 'Hastings', 'Male', 60000)
Insert into tblEmployees values ('Steve', 'Pound', 'Male', 45000)
Insert into tblEmployees values ('Ben', 'Hoskins', 'Male', 70000)
Insert into tblEmployees values ('Philip', 'Hastings', 'Male', 45000)
Insert into tblEmployees values ('Mary', 'Lambeth', 'Female', 30000)
Insert into tblEmployees values ('Valarie', 'Vikings', 'Female', 35000)
Insert into tblEmployees values ('John', 'Stanmore', 'Male', 80000)

Insert into tblUsers values ('male','male')
Insert into tblUsers values ('female','female')