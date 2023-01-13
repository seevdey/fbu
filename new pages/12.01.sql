--12.01.2023

select ALL * FROM Employees --burda gizli bir ALL var

--WHERE fiziksel tablodan data �eker
--HAVING olu�turulan sanal tablo �zerinden yap�lan hesaplamalar
select * from Products where UnitPrice <> 4.5  --sql
select * from Products where UnitPrice != 4.5  --sql ve c#
--<> e�it de�il demek <-- SQL e ait


select p.ProductID, p.ProductName, p.UnitPrice from Products p --sadece ihtiyac�n olan bilgileri �ek ALIAS


select  p.ProductName as UrunAdi , p.UnitPrice as [Urun Fiyati] from Products p


--text, ntext, money, varchar kullanma, max boyut vermne >> index ve tip d�n���mleri

--tablo kolonlar�n�n en ihtiya� duyulandan en az ihtaiya� duyulana g�re s�ralanmas� indeksin performans�n� art�r�r ve sorgu sonucu daha h�zl� gelmeye ba�lar


---------------------
--13.01.2023

create database ERP4_code
go
use ERP4_code


/*1. Bire �ok �li�ki */
create table Schools
(
	schoolID int primary key identity(1,1) not null,
	schoolName nvarchar(100) not null
)
go 
create table Teachers 
(
	teacherID int primary key identity(1,1) not null,
	schoolID int foreign key references Schools(schoolID) not null,
	teacherName nvarchar(50) not null
)


/*1-e �ok DI�ARDAN*/

--kesinlikle tip declare edilmesi �art

create table Schools2
(
	schoolID int primary key identity(1,1) not null,
	schoolName nvarchar(100) not null
)
go 
create table Teachers2
(
	teacherID int primary key identity(1,1) not null,
	teacherName nvarchar(50) not null
)

alter table Teachers2 add schoolID int
alter table Teachers2 add foreign key(schoolID) references Schools2(schoolID)

--isimler �ok �nemli. bu y�zden sen verme sql kendi versin. nu y�zden constraint eklemiyorum e�er constraint ekleseydim parantez i�ini doldurmam gerekirdi

/*Bire Bir ili�ki ��erden*/
create table Users
(
	userID int primary key identity(1,1) not null,
	userName nvarchar(50) not null,
	userPassword nvarchar(50)
)
go
create table User_Details
(
	userDetailID int primary key foreign key references Users(userID) not null, 
	TCKN nchar(11) not null,
	phone_Number nvarchar(15) not null,
	address_Work nvarchar(100) not null,
	address_Home nvarchar(100),
	address1 nvarchar(100),
	address2 nvarchar(100)
)


/*Bire Bir ili�ki D��ardan*/ --Do�ru yaz�m �ekli bu
create table Users2
(
	userID int primary key identity(1,1) not null,
	userName nvarchar(50) not null,
	userPassword nvarchar(50)
)
go
create table User_Details2
(
	userDetailID int primary key not null, 
	TCKN nchar(11) not null,
	phone_Number nvarchar(15) not null,
	address_Work nvarchar(100) not null,
	address_Home nvarchar(100),
	address1 nvarchar(100),
	address2 nvarchar(100)
)

alter table User_Details2 add foreign key(userDetailID) references Users2(userID)



/*�oka �ok Tablo ��erden*/
create table Students 
(
	studentID int primary key identity(1,1) not null,
	studentName nvarchar(50)
)
go
create table Courses
(
	courseID int primary key identity(1,1) not null,
	courseName nvarchar(50)
)
go
create table Student_Course
(
	studentID int not null,
	courseID int not null,
	primary key(studentID, courseID)
	--constraint PK_Student_Course_4562Abc primary key (studentID, courseID)

)

alter table Student_Course add foreign key(studentID) references Students(studentID)
alter table Student_Course add foreign key(courseID) references Courses(courseID)

--foreign key de ayn� yerde yazamazs�n ayr� ayr� yerde yaz

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Create Database ERP4_code2
Go
Use ERP4_code2
Go

Create Table Schools
(
	SchoolID int primary key identity(1,1) not null,
	SchoolName nvarchar(100) not null
)
Go
Create Table Students
(
	StudentID int primary key identity(1,1) not null,
	StudentName nvarchar(50) not null
)
Go
Create Table TeacherDetail
(
	TeacherDetailID int primary key not null,
	Phone nvarchar(15) not null,
	Email nvarchar(15) not null
)
GO
Create Table Teachers
(
	TeacherID int primary key identity(1,1) not null,
	TeacherName nvarchar(50) not null
)
Alter Table Teachers add SchoolID int
Alter Table Teachers add foreign key (SchoolID) references Schools(SchoolID)
Alter Table TeacherDetail add foreign key (TeacherDetailID) references Teachers(TeacherID)

Go
Create Table Courses
(
	CourseID int primary key identity(1,1) not null,
	CourseName nvarchar(50) not null
)
Alter Table Courses add TeacherID int
Alter Table Courses add foreign key (TeacherID) references Teachers(TeacherID)
Go 
Create Table StudentCourse
(
	StudentID int not null,
	CourseID int not null,
	primary key (StudentID, CourseID) 
)

Alter Table StudentCourse add foreign key (StudentID) references Students(StudentID)
Alter Table StudentCourse add foreign key (CourseID) references Courses(CourseID)


--user�d ogretmenlerle ��rencileri ba�layal�m oraya da foreign key ekleyelim 

--NORTHWIND

select getdate()

select datepart(yy, OrderDate) as Yil, datepart(mm, OrderDate) as Ay, datepart(dd, OrderDate) as Gun from Orders

--�al��anlar�n ya��n� hesaplama
select datediff(year, BirthDate, getdate()) as from Employees

select top 1 p.ProductName from Products p --ilk �al��an� getirir

select MIN(p.ProductName) from Products p --ilk �al��an� getirir

select MAX(p.ProductName) from Products p --son �al��an� getirir

--2 ve 5 e raporlama yapanlar� listele
select  FirstName, LastName,Title from Employees where ReportsTo = 2 or ReportsTo = 5

--ALIAS(isimlendirme)
--cross join
select * from Products p, [Order Details] od 

select * from Products p, [Order Details] od where p.ProductID = od.ProductID

--inner join ile
select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID


select AVG(p.UnitPrice) from Products --ortalama

select SUM(p.UnitPrice) from Products --toplama

select COUNT(*) from Products p -- 
select COUNT(p.ProductID) from Products p

select COUNT(*) from Employees -- * primary key e g�re hareket ediyor
select COUNT(ReportsTo) from Employees --* olanlar� say�yor

delete from where EmployeeID = 9 --ili�kili oldu�u i�in bu kayd� silemezsin

insert Employees (FirstName, LastName) values ('Sevde', 'Y�lmaz')

select COUNT(*) from Employees 
select COUNT(ReportsTo) from Employees 

--t�m aggregate alanlar� i�in ge�erli o alanlar�n null olmamas� gerekiyor. buna dikkat et

--product name i B ile ba�layan �r�nler
select * from Products p  where ProductName like 'B%'

--olumsuzluk i�eren bir �ey varsa par�alara ay�rarak yaz