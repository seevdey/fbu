----12.01.2023

--select ALL * FROM Employees --burda gizli bir ALL var

----WHERE fiziksel tablodan data �eker
----HAVING olu�turulan sanal tablo �zerinden yap�lan hesaplamalar
--select * from Products where UnitPrice <> 4.5  --sql
--select * from Products where UnitPrice != 4.5  --sql ve c#
----<> e�it de�il demek <-- SQL e ait


--select p.ProductID, p.ProductName, p.UnitPrice from Products p --sadece ihtiyac�n olan bilgileri �ek ALIAS


--select  p.ProductName as UrunAdi , p.UnitPrice as [Urun Fiyati] from Products p


----text, ntext, money, varchar kullanma, max boyut vermne >> index ve tip d�n���mleri

----tablo kolonlar�n�n en ihtiya� duyulandan en az ihtaiya� duyulana g�re s�ralanmas� indeksin performans�n� art�r�r ve sorgu sonucu daha h�zl� gelmeye ba�lar


-----------------------
----13.01.2023

--create database ERP4_code
--go
--use ERP4_code


--/*1. Bire �ok �li�ki */
--create table Schools
--(
--	schoolID int primary key identity(1,1) not null,
--	schoolName nvarchar(100) not null
--)
--go 
--create table Teachers 
--(
--	teacherID int primary key identity(1,1) not null,
--	schoolID int foreign key references Schools(schoolID) not null,
--	teacherName nvarchar(50) not null
--)


--/*1-e �ok DI�ARDAN*/

----kesinlikle tip declare edilmesi �art

--create table Schools2
--(
--	schoolID int primary key identity(1,1) not null,
--	schoolName nvarchar(100) not null
--)
--go 
--create table Teachers2
--(
--	teacherID int primary key identity(1,1) not null,
--	teacherName nvarchar(50) not null
--)

--alter table Teachers2 add schoolID int
--alter table Teachers2 add foreign key(schoolID) references Schools2(schoolID)

----isimler �ok �nemli. bu y�zden sen verme sql kendi versin. nu y�zden constraint eklemiyorum e�er constraint ekleseydim parantez i�ini doldurmam gerekirdi

--/*Bire Bir ili�ki ��erden*/
--create table Users
--(
--	userID int primary key identity(1,1) not null,
--	userName nvarchar(50) not null,
--	userPassword nvarchar(50)
--)
--go
--create table User_Details
--(
--	userDetailID int primary key foreign key references Users(userID) not null, 
--	TCKN nchar(11) not null,
--	phone_Number nvarchar(15) not null,
--	address_Work nvarchar(100) not null,
--	address_Home nvarchar(100),
--	address1 nvarchar(100),
--	address2 nvarchar(100)
--)


--/*Bire Bir ili�ki D��ardan*/ --Do�ru yaz�m �ekli bu
--create table Users2
--(
--	userID int primary key identity(1,1) not null,
--	userName nvarchar(50) not null,
--	userPassword nvarchar(50)
--)
--go
--create table User_Details2
--(
--	userDetailID int primary key not null, 
--	TCKN nchar(11) not null,
--	phone_Number nvarchar(15) not null,
--	address_Work nvarchar(100) not null,
--	address_Home nvarchar(100),
--	address1 nvarchar(100),
--	address2 nvarchar(100)
--)

--alter table User_Details2 add foreign key(userDetailID) references Users2(userID)



--/*�oka �ok Tablo ��erden*/
--create table Students 
--(
--	studentID int primary key identity(1,1) not null,
--	studentName nvarchar(50)
--)
--go
--create table Courses
--(
--	courseID int primary key identity(1,1) not null,
--	courseName nvarchar(50)
--)
--go
--create table Student_Course
--(
--	studentID int not null,
--	courseID int not null,
--	primary key(studentID, courseID)
--	--constraint PK_Student_Course_4562Abc primary key (studentID, courseID)

--)

--alter table Student_Course add foreign key(studentID) references Students(studentID)
--alter table Student_Course add foreign key(courseID) references Courses(courseID)

----foreign key de ayn� yerde yazamazs�n ayr� ayr� yerde yaz

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

----Create Database ERP4_code2
----Go
----Use ERP4_code2
----Go

--Create Table Schools
--(
--	SchoolID int primary key identity(1,1) not null,
--	SchoolName nvarchar(100) not null
--)
--Go
--Create Table Students
--(
--	StudentID int primary key identity(1,1) not null,
--	StudentName nvarchar(50) not null
--)
--Go
--Create Table TeacherDetail
--(
--	TeacherDetailID int primary key not null,
--	Phone nvarchar(15) not null,
--	Email nvarchar(15) not null
--)
--GO
--Create Table Teachers
--(
--	TeacherID int primary key identity(1,1) not null,
--	TeacherName nvarchar(50) not null
--)
--Alter Table Teachers add SchoolID int
--Alter Table Teachers add foreign key (SchoolID) references Schools(SchoolID)
--Alter Table TeacherDetail add foreign key (TeacherDetailID) references Teachers(TeacherID)

--Go
--Create Table Courses
--(
--	CourseID int primary key identity(1,1) not null,
--	CourseName nvarchar(50) not null
--)
--Alter Table Courses add TeacherID int
--Alter Table Courses add foreign key (TeacherID) references Teachers(TeacherID)
--Go 
--Create Table StudentCourse
--(
--	StudentID int not null,
--	CourseID int not null,
--	primary key (StudentID, CourseID) 
--)

--Alter Table StudentCourse add foreign key (StudentID) references Students(StudentID)
--Alter Table StudentCourse add foreign key (CourseID) references Courses(CourseID)


----user�d ogretmenlerle ��rencileri ba�layal�m oraya da foreign key ekleyelim 

----NORTHWIND

--select getdate()

--select datepart(yy, OrderDate) as Yil, datepart(mm, OrderDate) as Ay, datepart(dd, OrderDate) as Gun from Orders

----�al��anlar�n ya��n� hesaplama
--select datediff(year, BirthDate, getdate()) as from Employees

--select top 1 p.ProductName from Products p --ilk �al��an� getirir

--select MIN(p.ProductName) from Products p --ilk �al��an� getirir

--select MAX(p.ProductName) from Products p --son �al��an� getirir

----2 ve 5 e raporlama yapanlar� listele
--select  FirstName, LastName,Title from Employees where ReportsTo = 2 or ReportsTo = 5

----ALIAS(isimlendirme)
----cross join
--select * from Products p, [Order Details] od 

--select * from Products p, [Order Details] od where p.ProductID = od.ProductID

----inner join ile
--select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID


--select AVG(p.UnitPrice) from Products --ortalama

--select SUM(p.UnitPrice) from Products --toplama

--select COUNT(*) from Products p -- 
--select COUNT(p.ProductID) from Products p

--select COUNT(*) from Employees -- * primary key e g�re hareket ediyor
--select COUNT(ReportsTo) from Employees --* olanlar� say�yor

--delete from where EmployeeID = 9 --ili�kili oldu�u i�in bu kayd� silemezsin

--insert Employees (FirstName, LastName) values ('Sevde', 'Y�lmaz')

--select COUNT(*) from Employees 
--select COUNT(ReportsTo) from Employees 

----t�m aggregate alanlar� i�in ge�erli o alanlar�n null olmamas� gerekiyor. buna dikkat et

----product name i B ile ba�layan �r�nler
--select * from Products p  where ProductName like 'B%'

----olumsuzluk i�eren bir �ey varsa par�alara ay�rarak yaz

----------------------------------------------------------------------------------------------------

----16.01.2023
----CAST

--/*
--	as kullan�lmas� gerekir
--	as tip d�n���m�ne yard�mc� oluyor
--*/
--select '24' + '37' --2437
--select '24' + 37 --31
--select CAST ('24' as int) + CAST('37' as int) --61

--select CAST(getdate() as date) --2023-01-16

--select CAST(getdate() as datetime) --2023-01-16 10:19:43.977

--select CAST(getdate() as datetime2) --2023-01-16 10:22:42.9800000

--select CAST(getdate() as smalldatetime) --2023-01-16 10:20:00

--select CAST(getdate() as datetimeoffset) --2023-01-16 10:22:23.2700000 +00:00

----basamak de�eri �l�e�e kesinlikle e�it ya da b�y�k olmas� gerekiyor
----float yuvarlad��� i�in kullan�lmas�n� istemiyoruz. parasal �eylerde kullan�lmaz

--select CAST('True' as bit) --1
--select CAST('False' as bit) --0



----CONVERT
--select CONVERT(nvarchar(20), getdate()) --Jan 16 2023 10:29AM
--select CONVERT(nvarchar(11), getdate()) --Jan 16 2023

--select CONVERT(nvarchar(25), getdate(),113) --16 Jan 2023 10:32:21:527

--select CONVERT(nvarchar(25), getdate(),111) --2023/01/16

--select CONVERT(nvarchar(25), getdate(),110) --01-16-2023

---------------------------------------------------------------------------------------

---- DISTINCT benzersiz ko�ullar� getirir
--select DISTINCT e.ReportsTo from Employees e

----�al��anlar�m hangi �ehirde ya��yor?
--select DISTINCT  e.City from Employees e 

----aggregate fonksiyonlardan herhangi biriin kulland�ysan isim vermek zorundas�n
--select  COUNT (DISTINCT e.City) as SehirSayisi from Employees e 

--select  UPPER('bilgisaYAR') --B�LG�SAYAR
--select LOWER('bilgisaYAR') --bilgisayar
--select LEN('bilgisaYAR') --10

--select POWER(3,2) --9

--select LTRIM('		bilgisaYAR') --soldaki bo�lu�u al�r

--select RTRIM('bilgisaYAR		') --sa�daki bo�lu�u al�r

--select TRIM ('		bilgisaYAR		') --her iki taraftaki bo�lu�u al�r(hrm sa� hem sol)

--select SUBSTRING('bilgisaYAR', 1,5) --bilgi
--select REPLACE ('bil gi SAYAR', ' ', '') -- kelime,arayaca��n k�s�m, de�i�tirece�in k�s�m,  �IKTI: bilgiSAYAR

--select CONCAT('bilgi', ' ', 'SAYAR') --bilgi SAYAR

---- 90(555) 444 55 55 >> 5554445555
----declare de�i�ken tan�mla. tipini belirt
----set --> 
--DECLARE @telNo nvarchar(50)
--set @telNo  = '90(555) 444 55 55'
----select SUBSTRING(@telNo, 4, LEN(@telNo))
--set @telNo = (select SUBSTRING(@telNo, 4, LEN(@telNo)))
--set @telNo =  (select REPLACE(@telNo, ' ', ''))
--set @telNo =  (select REPLACE(@telNo, ')', ''))
--select @telNo

---------------


--create DATABASE Ali
--use Ali 
--go

--select * from Kisiler
---- Tabloya de�er eklenirken, null de�er alabilen kolona hi�bir �ey girmeyip bo� b�rak�rsak, 
----tabloya select �ekti�imizde o kolondaki null sar� g�r�n�r. 
----Ama o kolona string olarak NULL de�eri atarsak di�er Null ile ayn� de�ildir
--insert Kisiler Values(3, 'Tokatl�',NULL)

----------------------------------------------------------------

---- KategoriID si 2,4,7 olmayanlar� getiren sorgu
--select * from Categories where CategoryID IN (2,4,7)
--select * from Categories where CategoryID NOT IN (2,4,7)

----------------------------------------------------------------

---- Berlin, Madrid, London
--Select * from Customers where City IN ('Berlin', 'Madrid', 'London')
--Select * from Customers where City NOT IN ('Berlin', 'Madrid', 'London')

----------------------------------------------------------------
------ BETWEEN

---- Betweende her iki tarafta dahil
---- fiyat� 10 ile 25 aras�nda olan �r�nleri getiren sorgu
--Select * from Products where UnitPrice between 10 and 25 order by UnitPrice

--Select * from Orders where YEAR(OrderDate) Between YEAR('1996-08-05') And YEAR('1997-08-05') order by OrderDate
--Select * from Orders where YEAR(OrderDate) Between YEAR('1996') And YEAR('1997') order by OrderDate
--Select * from Orders where YEAR(OrderDate) Between 1996 And 1997 order by OrderDate
--Select * from Orders where YEAR(OrderDate) Not Between YEAR('1996') And YEAR('1997') order by OrderDate

----------------------------------------------------------------

------ AGGREGATE FUNCTIONS

--Select SUM(p.UnitPrice) as Toplam from Products p 

--Select AVG(p.UnitPrice) as Toplam from Products p 

--Select Count(*) as UrunSayisi from Products p

---- Hangi �r�nden toplam ka� adet �r�n sipari� verilmi�tir

--Select od.ProductID, SUM(od.Quantity) as ToplamUrunSayisi from [Order Details] od group by od.ProductID 
--Order by od.ProductID

---- �r�n bazl� toplam sipari� adedi

--Select od.ProductID, COUNT(*) as SiparisAdedi from [Order Details] od group by od.ProductID 
--Order by od.ProductID

---- Sipari�e G�re ciro
----SELECT od.OrderID, ROUND(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)), 2) AS Ciro FROM [Order Details] od group by od.OrderID

--SELECT od.OrderID, CAST(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) As decimal(18,2)) AS Ciro FROM [Order Details] od 
--group by od.OrderID Order By Ciro

----Hangi kategoride ka� �e�it tane �r�n var
--SELECT * FROM Products
--SELECT p.CategoryID, COUNT(*) AS CesitUrun FROM Products p GROUP BY p.CategoryID

----Kategori bazl� sipari� verilen �r�nler hangileridir
--SELECT p.CategoryID, p.ProductName, COUNT(*) AS CesitUrun FROM [Order Details] od 
--JOIN Products p on od.ProductID = p.ProductID group by p.CategoryID, p.ProductName
 
-- -- Fiyat� ortalama �zerinde olan �r�nler
--SELECT p.ProductName, p.UnitPrice FROM Products p 
--WHERE p.UnitPrice > (SELECT AVG(p.UnitPrice) FROM Products p) 


----------------------------------------------------------------

----- HAVING

---- Sipari� adedi 4'ten fazla olan �r�nler

--SELECT od.ProductID, COUNT(od.Quantity) AS SiparisAdedi FROM [Order Details] od 
--GROUP BY od.ProductID
--HAVING COUNT(od.Quantity) > 4
--ORDER BY SiparisAdedi

---- Sipari� adedi 10dan fazla olan ve Product ID'si 50den b�y�k olan �r�nler

--SELECT od.ProductID, COUNT(od.Quantity) AS SiparisAdedi FROM [Order Details] od 
--where od.ProductID > 50
--GROUP BY od.ProductID
--HAVING COUNT(od.Quantity) > 10
--ORDER BY SiparisAdedi

---- Sipari� bazl� toplam cironun, ortalama cironun �zerine ��kt��� sat��lar hangileridir?

--SELECT od.OrderID, 
--CAST(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) As decimal(18,2)) as ToplamTutar
--FROM [Order Details] od  Group by od.OrderID 
--Having SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) > 
--			(SELECT AVG(Tablo.SiparisBazliTutar) FROM 
--			(Select od.OrderID, 
--			SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) as SiparisBazliTutar 
--			from [Order Details] od group by od.OrderID) as Tablo)

----- VIEW  

--Alter view SiparisOrtCiro
--as
--SELECT od.OrderID, 
--CAST(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) As decimal(18,2)) as ToplamTutar
--FROM [Order Details] od  Group by od.OrderID 
--Having SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) > 
--			(SELECT AVG(Tablo.SiparisBazliTutar) FROM 
--			(Select od.OrderID, 
--			SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) as SiparisBazliTutar 
--			from [Order Details] od group by od.OrderID) as Tablo)

--Select * from SiparisOrtCiro

-----------------------------------------------------------------------------------

----17.01.2023

------Toplam sat�� miktar� 500 adetten az sat�lan �r�nleri getiren sorgu
------sipari� say�s� ile ilgili bir �ey soruluyorsa count yapmam�z gerekiyor
----select od.ProductID, SUM(od.Quantity) as SatisAdedi from [Order Details] od
----group by od.ProductID 
----having SUM(od.Quantity) < 500
----order by od.ProductID 


------Toplam sat�� miktar� 500 adetten az sat�lan �r�nleri isimleriyle getiren sorgu
----select od.ProductID, p.ProductName,SUM(od.Quantity) as SatisAdedi from [Order Details] od
----inner join Products p on od.ProductID = p.ProductID
----group by od.ProductID, p.ProductName
----having SUM(od.Quantity) < 500
----order by od.ProductID

------Toplam sat�� miktar� 500 adetten az sat�lan �r�nleri isimleriyle getiren ve ProductID si 50 den b�y�k olan  sorgu
----select od.ProductID, p.ProductName,SUM(od.Quantity) as SatisAdedi from [Order Details] od
----inner join Products p on od.ProductID = p.ProductID
----where p.ProductID > 50
----group by od.ProductID, p.ProductName
----having SUM(od.Quantity) < 500
----order by od.ProductID

----sanal tablo �zerinde hesaplanm�� bir alan �zerinde i�lem yapmak i�in HAVING kullan�yoruz
----HAVING e function ile ilgili ko�ullar� yazacaks�n
----datalar �zerinde yap�lan hesaplama
----veri taban�nda do�rudan sorgu yapmak istersen WHERE kullan�rs�n
----bu y�zden senin fiziksel tabloda direkt 50 den b�y�k olanlar� �ncesinde �ekmen gerekiyor


----1997 y�l�na ait ayl�k sipari� say�s� ay ve �r�n ad�yla getiren sorgu

------products, orders, order details 
----select COUNT(od.Quantity) as SiparisSayisi, p.ProductName,
----MONTH(o.OrderDate) as MonthID,
----DATENAME(MONTH,o.OrderDate) as MonthName 
----from Orders o
----inner join [Order Details] od on o.OrderID = od.OrderID
----inner join Products p on od.ProductID = p.ProductID
----where YEAR(o.OrderDate) = '1997'
----group by  p.ProductName,  MONTH(o.OrderDate), DATENAME(MONTH,OrderDate)
----order by MonthID 


----group by all kullan�rsan art�k where ko�ulu ge�ersiz olur(sat�r bazl� d���nd��� i�in)


-------------------------------------------------------------------------------------------
----use master
----go
----create database ERP_17_01

----use ERP_17_01
----go

----create table Users
----(
----	userID int primary key identity(1,1) not null,
----	userName nvarchar(50) not null,
----	postCode nvarchar(5)
----)

----insert Users(userName) values ('G�ko')

----insert Users values('isil', '')

----insert Users values('Ali', '12345')

----select * from Users

----create view vw_MyUsers
----as
----select * from Users

----insert vw_MyUsers(userName) values ('Deniz')

----insert vw_MyUsers(userName) values ('Tokatli')


----select * from vw_MyUsers

----�zin d�zeeltmeden view'a yap�lan de�i�iklik fiziksel tabloyu da etkiler
----Ama fiziksel tablo olan Kisiler tablosunda insert,update,delete izinleri d�zenlenir kilitlenir
----O zaman view'a yap�lan de�i�iklik fiziksel tabloyu etkilemez


----update vw_MyUsers
----set postCode = '34000'
----where userID = 2

----delete from vw_MyUsers where userID = 5

----alter view vw_MyUsers
------with encryption --�ifrelendi
----as
----select * from Users

----encryption etti�in �eylerin yede�ini mutlaka al. design kullanam�yorsun. bu proc i�in de ge�erli

-----------------------------------------------------------------------------------------------------
----STORED PROCEDURES
----h�zl� �al��mas�n� sa�l�yor
----kendi yazd���n fonksiyonda i�nsert update yazars�n ama �al��t�ramazs�n
----store proc da insert update yapabilirsin
----with encryption kullanabilirsin


----parametre kullanarak proc ekleme
----alter proc Proc1
----(
----	@userName nvarchar(20),
----	@postCode nvarchar(20)
----)
------with encryption
----with recompile
----as
----insert into Users(userName, postCode)
----values (@userName, @postCode)
----go

----exec Proc1 'sevde', 34885

----with encryption : encryption edece�in �eyi kaydedip saklaman gerekiyor. Yoksa bu proca eri�ip i�inde de�i�iklik yapamazs�n 
----with recompile : hangi tablo i�in �al���yorsan onun i�in exec plan� olu�turur

----view i�inde proc �a��rabilirsin



----bu procta sadece bu de�er bas�l�r s�rekli
----create proc sp_KisilerEkle2
----as
----insert into Users
----values ('xd', 123)

----exec sp_KisilerEkle2


----create proc sp_ViewCagir
----as
----begin 
----select * from vw_MyUsers
----end

----exec  sp_ViewCagir


----create view vw_StoredProcedureCagir
----as
----begin
----exec dbo.sp_ViewCagir
----end

----store proc i�erisinde CRUD var ama view da yok. bu y�zden view de store proc �a��ramazs�n
----begin s�sl� parantez a��l���, end s�sl� parantez kapan���

---------------------------------------------------------------------------------------
----FUNCTION

----create function fn_ToplamaYap
----(
----	@sayi1 int,
----	@sayi2 int
----)
----returns int --sonucun hangi tipte d�nece�i
----as
----	begin 
----		return @sayi1 + @sayi2
----	end

----select dbo.fn_ToplamaYap(10,20) as 'Toplama'



------her fiyata 10 tl ekle.
----select ProductName, UnitPrice, dbo.fn_ToplamaYap(UnitPrice, 10) as ZamliFiyat from Products


------UPDATE STORE PROC
----alter proc sp_UserUpdate
----(
----	@id int,
----	@name nvarchar(20),
----	@postCode nvarchar(20)
----)
----as
----	begin
----		update Users
----		set userName = @name, postCode = @postCode
----		where userID = @id
----	end

----exec sp_UserUpdate 8, 'isildur', 60100

----select * from Users

------DELETE STORE PROC
------3 numaral� id ye sahip eleman� silen proc
----create proc sp_UserDelete
----(
----	@id int
----)
----as
----	begin
----		delete from Users
----		where userID = @id
----	end

----exec sp_UserDelete 8


----ki�inin ad� soyad� girildi�inde mail olu�turan function
------alter function fn_MailOlustur
------(
------	@isim nvarchar(50),
------	@soyisim nvarchar(50),
------	@sirketAdi nvarchar(100)
------)
------returns nvarchar(200)
------as 
------	begin
------		return lower(@isim + '.' + @soyisim +  '@' +  @sirketAdi +'.com')
------	end

------select dbo.fn_MailOlustur('goko', 'yildiz', 'gads')


------select * from Customers


--------------------------------------------------------------------------------------

----19.01.2023
----use ERP_17_01
----go

----create table Employees
----(
----	EmployeeID int primary key identity(1,1) not null,
----	EmployeeName nvarchar(50),
----	Salary decimal(18,2)
----)

----insert Employees
----values
----	('isil', 80000),
----	('atmaca', 80000),
----	('ali', 80000)

----select * from Employees


------maa�lar�n ortalamas�n� alan function
----create function fn_OrtalamaMaas() --scalar-valued function
----returns decimal(18,2)
----	as
----		begin
----			declare @ortalama decimal(18,2) = 0;
----			select @ortalama =  AVG(Salary) from Employees
----			return @ortalama
----		end

----select dbo. fn_OrtalamaMaas() as OrtalamaMaas


----create function fn_EmployeeSelectCekmeyeMecbur()
----returns table --table-valued function
----	as
----		return select * from Employees

----select * from fn_EmployeeSelectCekmeyeMecbur()


---------------------------NORMAL�ZASYON KURALLARI----------------------------
----�sim ve soyisim kolonlar�n�n farkl� s�tunlarda tutulmas� gerekir. Birinin ismi ba�ka ki�inin soyad� olabilir

--/*
--	1NF: 
--		Tekrarlayan kolonlar olmas�n
--		Birden fazla t�rde bilgi tek bir kolonda yer alamaz(�ki isimli ki�iler ve adres alanlar� gibi durumlar hari�)
--		Her sat�r� ebnzersiz k�lan en az bir unique anahtar olmal�	
--		Bir sat�r� benzersiz k�lan bir veya birden fazla anahtar alan�n olmas� o alan�n super key oldu�unu g�sterir. �R: tel no, primary key
--		Bir tablonun i�erisinde de anahtar aday olmas� durumuna da candidate key denir

--	2NF:
--		Tablo 1NF kural�na uymak zorundad�r
--		Sat�rlar�n tekrar�n� ortadan kald�rmak gereklidir

--	3NF:
--		2NF i sa�lamak zorunda
--		Her kolon e�siz anahtara tam ba��ml� olmak zorundad�r. ba��ml� de�ilse tabloyu ay�r

--	3.5NF: 
--		3NF i sa�lamak zorunda
--		Her belirleyici kolon ayn� zamanda bir aday anahtar olmal�d�r

--	4NF:
--		3NF i sa�lamak zorunda
--		Multli-Valued dependency olmamal�d�r.

--	5NF:
--		T�m NF kurallar�n� sa�lamak zorunda
--		Minimum bo� alan kalmal�

-------------------------------------------------------------------------------------------
--OKAN HOCANIN KURALLAR
--	0. Farkl� isimde de olsa tekrar eden tablo olmamal�(i�erik ayn�)
--	1. Tekrar eden kolon olmamal�
--		-Tekrar eden data olmamal�(kolon bazl� tekrar olmamal�)
--	2. Tekrar eden sat�r olmamal�(Ara tablo hari�)
--		-Tekrar eden data olmamal�(sat�r bazl� tekrar olmamal�)
--	3. Tabloda Primary Key olmak zorunda(Ara tablo hari�)
--	4. Tabloyu Primary Key�e ba��ml� olacak �ekilde olu�tur. En anlaml� �ekilde tablolar� b�l
--	5. Tablolar�n birbirleriyle olan ili�kilerini belirle.(FK)
--	6. �oka-�ok ili�kili tablolar� 1 e �ok ili�kiye d�n��t�recek �ekilde ara tablo tan�mla
--	7. Bu s�raya m�mk�n mertebe uy


--Genelden �zele do�ru veri gir
--*/

----��leden sonra
--use Northwind 
--go

----se�ti�im alanlar� testImport tablosu i�ine kopyalad�m
--select o.ShipName, o.ShipCity, o.ShipCountry INTO testImport from Orders o 

----ERP_17_01 veritaban� i�ine testImport tablosunu kopyala
--select o.ShipName, o.ShipCity, o.ShipCountry INTO ERP_17_01.dbo.testImport from Orders o 


----Customer tablosunda se�ilen kolonlar� NewCustomerTable tablosuna kopyala
--select c.CompanyName, c.ContactName, c.ContactTitle, c.Address INTO NewCustomerTable from Customers c
--select * from NewCustomerTable


--select e.LastName, e.FirstName, e.Title, o.OrderDate, o.RequiredDate ,o.Freight INTO NewEmployeeOrderTable  from Employees e
--inner join Orders o on e.EmployeeID = o.EmployeeID
--select * from NewEmployeeOrderTable



--create table isil 
--(
--	Id int,
--	Adi nvarchar(50),
--	Soyadi nvarchar(50)
--)

--create table atmaca 
--(
--	Id int,
--	Adi nvarchar(50),
--	Soyadi nvarchar(50)
--)


--insert isil values(1, 'Ahmet', 'Kural'), (2, 'S�la', 'Gen�o�lu')

--select * from isil

----isil tablosundakiher �eyi atmaca tablosuna kopyala
--insert into atmaca (Id, Adi, Soyadi) select Id, Adi, Soyadi from isil

--select * from atmaca

--------------

--create table Oyuncular
--(
	
--	Id int,
--	Adi nvarchar(50),
--	Soyadi nvarchar(50)
--)

----Oyuncular tablosu i�ine belirtilen dosyada bulunanlar� kopyala
--BULK INSERT Oyuncular
--FROM 'C:\Users\sevde\OneDrive\Masa�st�\erp.txt'
--with(
--	fieldterminator = ',', --virg�lleri ayra� olarak belirliyor
--	rowterminator = '\n', --alt sat�ra ge�ti�inde alt sat�ra ge�
--	firstrow = 2 --2. row dan ba�la yani tablonun kolon isimlerini(header) alma ID, Adi, Soyad k�sm�n�
--);

--select * from Oyuncular


----BULK INSERT m�lakatta sorarlar bil
