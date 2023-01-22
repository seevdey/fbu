----12.01.2023

--select ALL * FROM Employees --burda gizli bir ALL var

----WHERE fiziksel tablodan data çeker
----HAVING oluþturulan sanal tablo üzerinden yapýlan hesaplamalar
--select * from Products where UnitPrice <> 4.5  --sql
--select * from Products where UnitPrice != 4.5  --sql ve c#
----<> eþit deðil demek <-- SQL e ait


--select p.ProductID, p.ProductName, p.UnitPrice from Products p --sadece ihtiyacýn olan bilgileri çek ALIAS


--select  p.ProductName as UrunAdi , p.UnitPrice as [Urun Fiyati] from Products p


----text, ntext, money, varchar kullanma, max boyut vermne >> index ve tip dönüþümleri

----tablo kolonlarýnýn en ihtiyaç duyulandan en az ihtaiyaç duyulana göre sýralanmasý indeksin performansýný artýrýr ve sorgu sonucu daha hýzlý gelmeye baþlar


-----------------------
----13.01.2023

--create database ERP4_code
--go
--use ERP4_code


--/*1. Bire Çok Ýliþki */
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


--/*1-e çok DIÞARDAN*/

----kesinlikle tip declare edilmesi þart

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

----isimler çok önemli. bu yüzden sen verme sql kendi versin. nu yüzden constraint eklemiyorum eðer constraint ekleseydim parantez içini doldurmam gerekirdi

--/*Bire Bir iliþki Ýçerden*/
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


--/*Bire Bir iliþki Dýþardan*/ --Doðru yazým þekli bu
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



--/*Çoka Çok Tablo Ýçerden*/
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

----foreign key de ayný yerde yazamazsýn ayrý ayrý yerde yaz

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


----userýd ogretmenlerle öðrencileri baðlayalým oraya da foreign key ekleyelim 

----NORTHWIND

--select getdate()

--select datepart(yy, OrderDate) as Yil, datepart(mm, OrderDate) as Ay, datepart(dd, OrderDate) as Gun from Orders

----çalýþanlarýn yaþýný hesaplama
--select datediff(year, BirthDate, getdate()) as from Employees

--select top 1 p.ProductName from Products p --ilk çalýþaný getirir

--select MIN(p.ProductName) from Products p --ilk çalýþaný getirir

--select MAX(p.ProductName) from Products p --son çalýþaný getirir

----2 ve 5 e raporlama yapanlarý listele
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

--select COUNT(*) from Employees -- * primary key e göre hareket ediyor
--select COUNT(ReportsTo) from Employees --* olanlarý sayýyor

--delete from where EmployeeID = 9 --iliþkili olduðu için bu kaydý silemezsin

--insert Employees (FirstName, LastName) values ('Sevde', 'Yýlmaz')

--select COUNT(*) from Employees 
--select COUNT(ReportsTo) from Employees 

----tüm aggregate alanlarý için geçerli o alanlarýn null olmamasý gerekiyor. buna dikkat et

----product name i B ile baþlayan ürünler
--select * from Products p  where ProductName like 'B%'

----olumsuzluk içeren bir þey varsa parçalara ayýrarak yaz

----------------------------------------------------------------------------------------------------

----16.01.2023
----CAST

--/*
--	as kullanýlmasý gerekir
--	as tip dönüþümüne yardýmcý oluyor
--*/
--select '24' + '37' --2437
--select '24' + 37 --31
--select CAST ('24' as int) + CAST('37' as int) --61

--select CAST(getdate() as date) --2023-01-16

--select CAST(getdate() as datetime) --2023-01-16 10:19:43.977

--select CAST(getdate() as datetime2) --2023-01-16 10:22:42.9800000

--select CAST(getdate() as smalldatetime) --2023-01-16 10:20:00

--select CAST(getdate() as datetimeoffset) --2023-01-16 10:22:23.2700000 +00:00

----basamak deðeri ölçeðe kesinlikle eþit ya da büyük olmasý gerekiyor
----float yuvarladýðý için kullanýlmasýný istemiyoruz. parasal þeylerde kullanýlmaz

--select CAST('True' as bit) --1
--select CAST('False' as bit) --0



----CONVERT
--select CONVERT(nvarchar(20), getdate()) --Jan 16 2023 10:29AM
--select CONVERT(nvarchar(11), getdate()) --Jan 16 2023

--select CONVERT(nvarchar(25), getdate(),113) --16 Jan 2023 10:32:21:527

--select CONVERT(nvarchar(25), getdate(),111) --2023/01/16

--select CONVERT(nvarchar(25), getdate(),110) --01-16-2023

---------------------------------------------------------------------------------------

---- DISTINCT benzersiz koþullarý getirir
--select DISTINCT e.ReportsTo from Employees e

----Çalýþanlarým hangi þehirde yaþýyor?
--select DISTINCT  e.City from Employees e 

----aggregate fonksiyonlardan herhangi biriin kullandýysan isim vermek zorundasýn
--select  COUNT (DISTINCT e.City) as SehirSayisi from Employees e 

--select  UPPER('bilgisaYAR') --BÝLGÝSAYAR
--select LOWER('bilgisaYAR') --bilgisayar
--select LEN('bilgisaYAR') --10

--select POWER(3,2) --9

--select LTRIM('		bilgisaYAR') --soldaki boþluðu alýr

--select RTRIM('bilgisaYAR		') --saðdaki boþluðu alýr

--select TRIM ('		bilgisaYAR		') --her iki taraftaki boþluðu alýr(hrm sað hem sol)

--select SUBSTRING('bilgisaYAR', 1,5) --bilgi
--select REPLACE ('bil gi SAYAR', ' ', '') -- kelime,arayacaðýn kýsým, deðiþtireceðin kýsým,  ÇIKTI: bilgiSAYAR

--select CONCAT('bilgi', ' ', 'SAYAR') --bilgi SAYAR

---- 90(555) 444 55 55 >> 5554445555
----declare deðiþken tanýmla. tipini belirt
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
---- Tabloya deðer eklenirken, null deðer alabilen kolona hiçbir þey girmeyip boþ býrakýrsak, 
----tabloya select çektiðimizde o kolondaki null sarý görünür. 
----Ama o kolona string olarak NULL deðeri atarsak diðer Null ile ayný deðildir
--insert Kisiler Values(3, 'Tokatlý',NULL)

----------------------------------------------------------------

---- KategoriID si 2,4,7 olmayanlarý getiren sorgu
--select * from Categories where CategoryID IN (2,4,7)
--select * from Categories where CategoryID NOT IN (2,4,7)

----------------------------------------------------------------

---- Berlin, Madrid, London
--Select * from Customers where City IN ('Berlin', 'Madrid', 'London')
--Select * from Customers where City NOT IN ('Berlin', 'Madrid', 'London')

----------------------------------------------------------------
------ BETWEEN

---- Betweende her iki tarafta dahil
---- fiyatý 10 ile 25 arasýnda olan ürünleri getiren sorgu
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

---- Hangi üründen toplam kaç adet ürün sipariþ verilmiþtir

--Select od.ProductID, SUM(od.Quantity) as ToplamUrunSayisi from [Order Details] od group by od.ProductID 
--Order by od.ProductID

---- Ürün bazlý toplam sipariþ adedi

--Select od.ProductID, COUNT(*) as SiparisAdedi from [Order Details] od group by od.ProductID 
--Order by od.ProductID

---- Sipariþe Göre ciro
----SELECT od.OrderID, ROUND(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)), 2) AS Ciro FROM [Order Details] od group by od.OrderID

--SELECT od.OrderID, CAST(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) As decimal(18,2)) AS Ciro FROM [Order Details] od 
--group by od.OrderID Order By Ciro

----Hangi kategoride kaç çeþit tane ürün var
--SELECT * FROM Products
--SELECT p.CategoryID, COUNT(*) AS CesitUrun FROM Products p GROUP BY p.CategoryID

----Kategori bazlý sipariþ verilen ürünler hangileridir
--SELECT p.CategoryID, p.ProductName, COUNT(*) AS CesitUrun FROM [Order Details] od 
--JOIN Products p on od.ProductID = p.ProductID group by p.CategoryID, p.ProductName
 
-- -- Fiyatý ortalama üzerinde olan ürünler
--SELECT p.ProductName, p.UnitPrice FROM Products p 
--WHERE p.UnitPrice > (SELECT AVG(p.UnitPrice) FROM Products p) 


----------------------------------------------------------------

----- HAVING

---- Sipariþ adedi 4'ten fazla olan ürünler

--SELECT od.ProductID, COUNT(od.Quantity) AS SiparisAdedi FROM [Order Details] od 
--GROUP BY od.ProductID
--HAVING COUNT(od.Quantity) > 4
--ORDER BY SiparisAdedi

---- Sipariþ adedi 10dan fazla olan ve Product ID'si 50den büyük olan ürünler

--SELECT od.ProductID, COUNT(od.Quantity) AS SiparisAdedi FROM [Order Details] od 
--where od.ProductID > 50
--GROUP BY od.ProductID
--HAVING COUNT(od.Quantity) > 10
--ORDER BY SiparisAdedi

---- Sipariþ bazlý toplam cironun, ortalama cironun üzerine çýktýðý satýþlar hangileridir?

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

------Toplam satýþ miktarý 500 adetten az satýlan ürünleri getiren sorgu
------sipariþ sayýsý ile ilgili bir þey soruluyorsa count yapmamýz gerekiyor
----select od.ProductID, SUM(od.Quantity) as SatisAdedi from [Order Details] od
----group by od.ProductID 
----having SUM(od.Quantity) < 500
----order by od.ProductID 


------Toplam satýþ miktarý 500 adetten az satýlan ürünleri isimleriyle getiren sorgu
----select od.ProductID, p.ProductName,SUM(od.Quantity) as SatisAdedi from [Order Details] od
----inner join Products p on od.ProductID = p.ProductID
----group by od.ProductID, p.ProductName
----having SUM(od.Quantity) < 500
----order by od.ProductID

------Toplam satýþ miktarý 500 adetten az satýlan ürünleri isimleriyle getiren ve ProductID si 50 den büyük olan  sorgu
----select od.ProductID, p.ProductName,SUM(od.Quantity) as SatisAdedi from [Order Details] od
----inner join Products p on od.ProductID = p.ProductID
----where p.ProductID > 50
----group by od.ProductID, p.ProductName
----having SUM(od.Quantity) < 500
----order by od.ProductID

----sanal tablo üzerinde hesaplanmýþ bir alan üzerinde iþlem yapmak için HAVING kullanýyoruz
----HAVING e function ile ilgili koþullarý yazacaksýn
----datalar üzerinde yapýlan hesaplama
----veri tabanýnda doðrudan sorgu yapmak istersen WHERE kullanýrsýn
----bu yüzden senin fiziksel tabloda direkt 50 den büyük olanlarý öncesinde çekmen gerekiyor


----1997 yýlýna ait aylýk sipariþ sayýsý ay ve ürün adýyla getiren sorgu

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


----group by all kullanýrsan artýk where koþulu geçersiz olur(satýr bazlý düþündüðü için)


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

----insert Users(userName) values ('Göko')

----insert Users values('isil', '')

----insert Users values('Ali', '12345')

----select * from Users

----create view vw_MyUsers
----as
----select * from Users

----insert vw_MyUsers(userName) values ('Deniz')

----insert vw_MyUsers(userName) values ('Tokatli')


----select * from vw_MyUsers

----Ýzin düzeeltmeden view'a yapýlan deðiþiklik fiziksel tabloyu da etkiler
----Ama fiziksel tablo olan Kisiler tablosunda insert,update,delete izinleri düzenlenir kilitlenir
----O zaman view'a yapýlan deðiþiklik fiziksel tabloyu etkilemez


----update vw_MyUsers
----set postCode = '34000'
----where userID = 2

----delete from vw_MyUsers where userID = 5

----alter view vw_MyUsers
------with encryption --þifrelendi
----as
----select * from Users

----encryption ettiðin þeylerin yedeðini mutlaka al. design kullanamýyorsun. bu proc için de geçerli

-----------------------------------------------------------------------------------------------------
----STORED PROCEDURES
----hýzlý çalþýmasýný saðlýyor
----kendi yazdýðýn fonksiyonda iþnsert update yazarsýn ama çalýþtýramazsýn
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

----with encryption : encryption edeceðin þeyi kaydedip saklaman gerekiyor. Yoksa bu proca eriþip içinde deðiþiklik yapamazsýn 
----with recompile : hangi tablo için çalýþýyorsan onun için exec planý oluþturur

----view içinde proc çaðýrabilirsin



----bu procta sadece bu deðer basýlýr sürekli
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

----store proc içerisinde CRUD var ama view da yok. bu yüzden view de store proc çaðýramazsýn
----begin süslü parantez açýlýþý, end süslü parantez kapanýþý

---------------------------------------------------------------------------------------
----FUNCTION

----create function fn_ToplamaYap
----(
----	@sayi1 int,
----	@sayi2 int
----)
----returns int --sonucun hangi tipte döneceði
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
------3 numaralý id ye sahip elemaný silen proc
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


----kiþinin adý soyadý girildiðinde mail oluþturan function
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


------maaþlarýn ortalamasýný alan function
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


---------------------------NORMALÝZASYON KURALLARI----------------------------
----Ýsim ve soyisim kolonlarýnýn farklý sütunlarda tutulmasý gerekir. Birinin ismi baþka kiþinin soyadý olabilir

--/*
--	1NF: 
--		Tekrarlayan kolonlar olmasýn
--		Birden fazla türde bilgi tek bir kolonda yer alamaz(Ýki isimli kiþiler ve adres alanlarý gibi durumlar hariç)
--		Her satýrý ebnzersiz kýlan en az bir unique anahtar olmalý	
--		Bir satýrý benzersiz kýlan bir veya birden fazla anahtar alanýn olmasý o alanýn super key olduðunu gösterir. ÖR: tel no, primary key
--		Bir tablonun içerisinde de anahtar aday olmasý durumuna da candidate key denir

--	2NF:
--		Tablo 1NF kuralýna uymak zorundadýr
--		Satýrlarýn tekrarýný ortadan kaldýrmak gereklidir

--	3NF:
--		2NF i saðlamak zorunda
--		Her kolon eþsiz anahtara tam baðýmlý olmak zorundadýr. baðýmlý deðilse tabloyu ayýr

--	3.5NF: 
--		3NF i saðlamak zorunda
--		Her belirleyici kolon ayný zamanda bir aday anahtar olmalýdýr

--	4NF:
--		3NF i saðlamak zorunda
--		Multli-Valued dependency olmamalýdýr.

--	5NF:
--		Tüm NF kurallarýný saðlamak zorunda
--		Minimum boþ alan kalmalý

-------------------------------------------------------------------------------------------
--OKAN HOCANIN KURALLAR
--	0. Farklý isimde de olsa tekrar eden tablo olmamalý(içerik ayný)
--	1. Tekrar eden kolon olmamalý
--		-Tekrar eden data olmamalý(kolon bazlý tekrar olmamalý)
--	2. Tekrar eden satýr olmamalý(Ara tablo hariç)
--		-Tekrar eden data olmamalý(satýr bazlý tekrar olmamalý)
--	3. Tabloda Primary Key olmak zorunda(Ara tablo hariç)
--	4. Tabloyu Primary Key’e baðýmlý olacak þekilde oluþtur. En anlamlý þekilde tablolarý böl
--	5. Tablolarýn birbirleriyle olan iliþkilerini belirle.(FK)
--	6. Çoka-çok iliþkili tablolarý 1 e çok iliþkiye dönüþtürecek þekilde ara tablo tanýmla
--	7. Bu sýraya mümkün mertebe uy


--Genelden özele doðru veri gir
--*/

----öðleden sonra
--use Northwind 
--go

----seçtiðim alanlarý testImport tablosu içine kopyaladým
--select o.ShipName, o.ShipCity, o.ShipCountry INTO testImport from Orders o 

----ERP_17_01 veritabaný içine testImport tablosunu kopyala
--select o.ShipName, o.ShipCity, o.ShipCountry INTO ERP_17_01.dbo.testImport from Orders o 


----Customer tablosunda seçilen kolonlarý NewCustomerTable tablosuna kopyala
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


--insert isil values(1, 'Ahmet', 'Kural'), (2, 'Sýla', 'Gençoðlu')

--select * from isil

----isil tablosundakiher þeyi atmaca tablosuna kopyala
--insert into atmaca (Id, Adi, Soyadi) select Id, Adi, Soyadi from isil

--select * from atmaca

--------------

--create table Oyuncular
--(
	
--	Id int,
--	Adi nvarchar(50),
--	Soyadi nvarchar(50)
--)

----Oyuncular tablosu içine belirtilen dosyada bulunanlarý kopyala
--BULK INSERT Oyuncular
--FROM 'C:\Users\sevde\OneDrive\Masaüstü\erp.txt'
--with(
--	fieldterminator = ',', --virgülleri ayraç olarak belirliyor
--	rowterminator = '\n', --alt satýra geçtiðinde alt satýra geç
--	firstrow = 2 --2. row dan baþla yani tablonun kolon isimlerini(header) alma ID, Adi, Soyad kýsmýný
--);

--select * from Oyuncular


----BULK INSERT mülakatta sorarlar bil
