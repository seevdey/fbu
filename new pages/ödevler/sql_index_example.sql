--------------------------------------VÝDEO 35--------------------------------------
create database IndexExample
go
use IndexExample
go
create table tblEmployee
(
	ID int primary key not null,
	Name nvarchar(50),
	Salary nvarchar(50),
	Gender nvarchar(50)
)

insert into tblEmployee values(3, 'Iþýl', 25000, 'Female')
insert into tblEmployee values(4, 'Sevde', 28000, 'Female')
insert into tblEmployee values(1, 'Ali', 30000, 'Male')
insert into tblEmployee values(2, 'Göktuð', 15000, 'Male')
insert into tblEmployee values(6, 'Deniz', 13000, 'Female')
insert into tblEmployee values(7, 'Þeyda', 29000, 'Female')
insert into tblEmployee values(5, 'Taha', 45000, 'Male')
insert into tblEmployee values(8, 'Can', 59000, 'Male')

select * from tblEmployee

select * from tblEmployee
where Salary between 15000 and 30000


CREATE INDEX IX_tblEmployee_Salary
ON tblEmployee (Salary ASC);


sp_Helpindex tblEmployee

drop index tblEmployee.IX_tblEmployee_Salary


--------------------------------------VÝDEO 36--------------------------------------
create table tblEmployee
(
	ID int primary key,
	Name nvarchar(50),
	Salary int, 
	Gender nvarchar(10),
	City nvarchar(50)
)

execute sp_helpindex tblEmployee

insert into tblEmployee values (3, 'Fatih', 48000, 'Male', 'Tokat')
insert into tblEmployee values (1, 'Ahmet', 25900, 'Male', 'Sivas')
insert into tblEmployee values (4, 'Can', 28000, 'Male', 'Burdur')
insert into tblEmployee values (2, 'Burcu', 30000, 'Female', 'Denizli')
insert into tblEmployee values (5, 'Buket', 18000, 'Female', 'Ýzmir')
AA

Create Clustered Index IX_tblEmployee_Gender_Salary
on tblEmployee(Gender desc, Salary asc)

drop index tblEmployee.PK__tblEmplo__3214EC2713729534

Create NonClustered Index IX_tblEmployee_Name
on tblEmployee(Name)


CREATE UNIQUE INDEX AK_UnitMeasure_Name   
 ON Production.UnitMeasure (Name);   

CREATE NONCLUSTERED INDEX IX_IndexName ON IndexName (Column1, Column2) WHERE …
