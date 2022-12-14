
--12 DECEMBER 2022

--master ana tablo
--CRTL+F5 --> parse etmiþ oluyorum
--çalýþtýrmadan evvel hata var mý yok mu kontrol ediyor. Intellince visual studioda class oluþturuyoduk o1. diyince name çýkýyodu ya sql de bu çýkmýyor

--CREATE DATABASE denemeiskur2 --tablo oluþturma

--DROP DATABASE denemeiskur2 --tablo silme

--SQL iki bölümden oluþur --> 1.DDL, 2.DML
--1.DDL --> Data Definition Language --> Tanýmlamak için kullanýlan kýsým
--2.DML Tanýmlý Veri üzerinde iþlem yapýyoruz
--DDL --> Hiçbir þey yok ortada boþ sen oluþturuyorsun hangi komutlarla --> 1.CREATE, 2.DROP, 3.ALTER ile oluþturuyosun
--Veri tabaný yapablirsin
--Tablo oluþturma, silme, güncelleme
--Index oluþturabilirsin drop alter yapabilirsin
--Storage Prosedure --> her þeyi clientta deðil serverda çalýþtýrýyorsun. client çöp. server ana cihaz
--Fonksiyon oluþturabilirim
--Trigger oluþturabilirim, silerim

--database nin ismini 'xx' deðiþtirdim
--ALTER DATABASE denemeiskur2
--MODIFY Name = xx 


--sað týkladýðýmda yaptýðým iþlemleri kodla yapýyorum
--CREATE DATABASE ManuelDB
--ON PRIMARY ( 
--Name = manueldb_data,
--FileName = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\manueldb.mdf',
--Size = 10MB,
--FileGrowth = 3MB, --boyut artýrma. MMB 3MB artýrmasýný saðlýyor
--MaxSize = 60MB
--)

--Log On(
--Name = manueldb_log,
--FileName = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\manueldb.ldf',
--Size = 3MB,
--FileGrowth = 10%,
--MaxSize = 10MB
--)



--database, tablo, diyagram oluþturma
--her sütunun ne anlama geldiðini yaz
--create database KuzeyRuzgari
--go --birden fazla SQL i birbirine baðlýyor. peþpeþe çalýþmasýný saðlýyor
--use KuzeyRuzgari
--go
--create table Personeller
--(
--	PersonelId int PRIMARY KEY identity(1,1) not null,
--	PersonelAdi nvarchar(50) not null,
--	PersonelSoyadi nvarchar(50) not null
--)
--go
--create table Musteriler 
--(
--	MusteriId int PRIMARY KEY identity(1,1) not null,
--	SirketAdi nvarchar(50) not null,
--	Telefonu nvarchar(15) not null
--)
--go
--create table Siparis
--(
--	SiparisId int PRIMARY KEY identity(1,1) not null,
--	SiparisTarihi date not null,
--	SiparisiVerenMusteriID int foreign key references Musteriler(MusteriId) not null,
--	SiparisAlanPersonelID int foreign key references Personeller(PersonelId) not null,
--)


--create table Araclar
--(
--	AracId int PRIMARY KEY identity(1,1) not null,
--	Marka nvarchar(40) not null,
--	Plaka nvarchar(49) not null,
--	YapimYili datetime not null

--	--YapimYili için kýsýtlama yapýyorum
--	--yýl bazýnda karþýlaþtýr, araba yaþý 10 dan büyük olamaz
--	--þu andaki tarih YapimYili ile aradaki farký yýl bazýnda al bulduðun deðer 10 dan küçükse içeriye veri at, deðilse atma
--	constraint YapimYili check(datediff(YEAR, YapimYili, getdate()) < 10),
	
--	--plaka tek olmalý 2. plaka olamaz
--	unique (Plaka)
--)


--Araç olup olmadýðýný kontrol edicez 
--insert --> içeriye veri ekleme
--yapimyili ve alisyili arasýnda 10 dan fazla yýl varsa veriyi eklemez
--insert into Araclar Values('Toyota', '34 ZA 2022', '01.01.2015') 


--Araclar tablosunda markanýn varchar özelliðini 50 olarak deðiþtiriyoruz
--alter table Araclar
--alter column Marka nvarchar(50) not  null

--sütun ekleme
--alter table Araclar
--add column MotorGucu int

--sütun silme
--alter table Araclar
--drop column MotorGucu 


/*
	DML Komutlarý 
	1.Insert --> yeni kayýt ekleme
	2. Update --> güncelleme
	3.Delete --> silme (asla kullanmayacaksýn), 
	4.Select --> listeleme
*/


--select 2+3 as Toplama
--select 'Merhaba' + '//' + 'Dünya' as Mesaj

--select upper('sema') as baþlýk --büyük harfe çevirme
--select SUBSTRING('Bu sýnýftan güzel bir ekip olur mu?' ,1,11)

--select rtrim (SUBSTRING('    Bu sýnýftan güzel bir ekip olur mu?' ,1,16)) --saðdaki boþluðu siler
--select ltrim (SUBSTRING('Bu sýnýftan güzel bir ekip olur mu?    ' ,1,16)) --soldaki boþluðu siler


--select replace ('ÝÞKUR', 'Ýþ', 'Yaz')  --> ÝÞKUR yerine YazKUR yaz  -> replace yer deðiþtirmek demek

--select MONTH(getdate()) --þu an bulunduðumuz ay
--select DATEADD(day, 2, getdate()) --2 gün sonraki tarihi ekleme

--select DATENAME(dayofyear, getdate()) --yýlýn kaçýncý gününde olduðumuzu gösterir
--select DATENAME(WEEKDAY, getdate()) --haftanýn hangi gününde olduðumuzu gösterir


--select * from Shippers --tüm tablo
--select CompanyName from Shippers --tabloda CompanyName kolonu 
--as ile nick atýyorum
--select CompanyName as [Firma Ýsmi] from Shippers --tabloda CompanyName kolonunun ismini Firma Ýsmi yaptýk
--Herhangi bir tablo, isim takma isim olursa olsun eðer boþluk ifadesi varsa sonuna ve baþýna köþeli parantezi kullanmak zorundasýn

--müþteri tablosunun tüm sütunlarýný türkçeleþtirilmiþ halini 

--select 
--CustomerId as [Müþteri ID],
--CompanyName as [Þirket Adý],
--ContactName as [Ýletiþim Adý],
--ContactTitle as [Ýletiþim Baþlýðý],
--Address as Adres,
--City as Þehir,
--Region as Bölge,
--PostalCode as [Posta Kodu],
--Country as Ülke,
--Phone as Telefon,
--Fax as Faks
--from Customers

--Çalýþanlarýn employeid lerinin adlarýný ve soyadlarýný raporla, adlar ve soyadlar tek bir kolonda gelsin ve kolon adý Ad soyad olsun
--select EmployeeID, FirstName + ' ' + LastName as [Ad Soyad] from Employees

--select ProductID, ProductName, UnitPrice, UnitPrice * 1.18 as [KDV li Fiyat] from Products
--UnitPrice * 1.18 as [KDV li Fiyat] <-- aggregation (geçici) sütun

--fiyatý 30 dan büyük olanlarý getir
--where koþul
--select ProductID, ProductName from Products where UnitPrice > 30


--londrada yaþayan personelin listesi
--select * from Employees where City = 'London'

--kategoriID si 5 olmayan ürünlerin adlarý ve kategorilerini gösteriniz
--select CategoryID, ProductName from Products where CategoryID != 5


--13 DECEMBER 2022

--mart ayýnda alýnmýþ olan sipariþlerin OrderID, OrderDate sütunlarýyla raporla
--select OrderID, CONVERT(varchar(20),OrderDate,113) AS 'March' from Orders where datename(Month, OrderDate) = 'March'

--60 yaþýn üstünde çalýþanlarý listele
--select * from Employees where datediff(YEAR, BirthDate, getdate()) > 60 --iki tarih arasýndaki fark

--yaþý 60 yaþýndann büyük olan amerikalýlarý listele
--select * from Employees where datediff(YEAR, BirthDate, getdate()) > 60 and Country = 'USA'


--sipariþ tarihi 1997 dan büyük olanlar, kargo ücreti 20 den büyük, Fransaya gönderilmemiþ sipariþler
--select * from Orders where ShipCountry != 'France' and Freight > 20 and OrderDate > '1997'

--henüz müþteriye ulaþmamýþ sipariþleri listele
--select * from Orders where ShippedDate is null

--kimseye rapor vermeyen personelin firstname last name, title
--select  FirstName, LastName,Title from Employees where ReportsTo is null

--kategoriId si 5 olan, ürün bedeli 20 den büyük 300 den küçük olan ve stok durumu null olmayan ürünlerin detaylarýný 
--select * from Products where CategoryID = 5 and (UnitPrice > 20 and UnitPrice <300) and UnitsInStock is not null

--ürünýd si 3,5,7,4,12,8 dýþýnda olanlarýn sipariþ edilmiþ ürünlerin id lerini göster
--select * from [Order Details] where ProductID != 3 and ProductID != 4 and ProductID != 5 and ProductID != 7 and  ProductID != 12 and ProductID != 8 

--select ProductID from [Order Details] where ProductID not in(3, 4, 5, 8, 7, 12) 

--ürünlerin isimleri 3. karakteri a ve b  c den 1 tanesi olan isimleri listeleyiniz
--select * from Products  where ProductName LIKE '__[abc]%'


--SIRALAMA ÝFADESÝ --> ORDER BY
--asc - küçükten büyüðe -- default
--desc - büyükten küçüðe

--select FirstName + ' ' + LastName as  'AdSoyad' from Employees order by AdSoyad desc

--müþteriler tablosunda cusomterid compnay name ve ülkelerine göre fransýz þirketleri, customerid lerine göre tersten sýralanacak þekilde listele
--select CustomerID, CompanyName from Customers where Country = 'France' order by CustomerID desc

--stok miktar 50 den büyük olan, ücreti ucuzdan pahalýya þeklinde sýralanan ürünleri listele --en ucuz 10 ürün
--select top 10 * from Products where UnitsInStock>50 order by UnitPrice

--en son teslim edilen 5 sipariþin detaylarýný göster
--select top 5 * from Orders order by ShippedDate desc

--ürünler tablosundaki stok miktarý en fazla olan en ucuz ürünleri listele
--select * from Products  order by UnitsInStock desc, UnitPrice desc


--çalýþanlar tablosunda kaç ülkeden çalýþaným var
--select distinct Country from Employees 

--select * from Employees

--baþ harfi c olan stoklarda mevcut 10 ile 250 arasýnda ücreti olan ürünleri fiyatlarýna göre listele
--select * from Products where ProductName LIKE 'c%' and UnitPrice > 10 and UnitPrice < 250 and UnitsInStock is not null order by UnitPrice desc

--çarþ günü alýnan, kargo ücreti 20 ile 75 arasýnda olna teslim edilmiþ sipariþleri bilgilerini raporla
--select * from Orders where Freight>20 and Freight<75 and DATENAME(WEEKDAY, ShippedDate) = 'Wednesday' and ShippedDate is not null 


--14 DECEMBER 2022
--harfle baþlayýp belirli bir þey veriyorsan like kullanýyorsun. Ama bire bir eþit olmasýný istersen like kullanmýyosun
--select CompanyName from Customers where CompanyName like  'A%'  --ne olursa olsun CompanyName A ile baþlayan
--select CompanyName from Customers where CompanyName like  '%A' -- sonu A ile biten
--select CompanyName from Customers where CompanyName like  '%od%' --içinde od olan
--select CompanyName from Customers where CompanyName like  '__ton%' --ilk harfi ne olursa olsun, son 3 harfi ton olan

--ilk harfi a ile k arasýnda olan müþterileri listeleyiniz
--select * from Customers where CompanyName like '[A-K]%' 

--ilk harfi a olan 2.harfi n olmayan müþterileri listele
--select * from Customers where CompanyName like '[A][^N]%'

--ülkesi ingiltere olmayan adý a ile baþlayýp soyadý r ile biten doðum tarihi 1985 ten önce olan çalýþanlarýn listsei
--select * from Employees where Country != 'UK' and FirstName like 'a%' and LastName like '%r' and BirthDate > 1985 

--select count(*) from Products --kaç adet ürünüm olduðunu görmek istersem --77 adet ürünüm var
--select count(distinct Country) from  Employees -- kaç farklý ülkeden çalýþaným var
--select sum(UnitsInStock) from Products --stokta toplam kaç adet ürün var -- 3119 tane

--bu zamana kadar ödenmiþ ortalama kargo ücretiniz nedir
--select avg(Freight) from Orders
--select sum(Freight) / Count(Freight) from Orders

--Toplam kaç dolarlýk ciromuz var indirimleri göz önüne al
--select SUM((UnitPrice*Quantity)-(UnitPrice*Quantity*Discount) from [Order Details]
--select SUM((1-Discount) * (UnitPrice*Quantity)) from [Order Details]

--ülke baþýna ortalama ne kadar kargo ücreti ödenmiþtir
--select sum(Freight) / count(distinct ShipCountry) from Orders

--her üründen ortalama kaç dolarlýk satýþ yapýlmýþtýr
--select AVG((1-Discount) * (UnitPrice*Quantity)) from [Order Details]

--5ten büyük en düþük satýþýmýzda kaç dolarlýk satýþ yapýlmýþtýr
--select MIN((1-Discount) * (UnitPrice*Quantity)) from [Order Details] where (1-Discount) * (UnitPrice*Quantity) > 5
--select MIN((1-Discount) * (UnitPrice*Quantity)) from [Order Details] where UnitPrice > 5

--Duruma göe yeni kolon açma
--switch case gibi ama burda case when mantýðý var

--select ProductName, UnitPrice, UnitsInStock, [Stok Durumu] = 
--case 
--	when UnitsInStock < 50 then 'Kritik Stok'
--	when UnitsInStock between 50 and 75 then 'Normal Stok'
--	when UnitsInStock > 75 then 'Stok Fazlasý'
--end
--from Products
--order by UnitsInStock


--ürün tablosundaki ürünlerin fiyatý 50 den büyükse pahalý, 50 ise alýnýr, 50 den küçükse ucu<
--select *, [Alýnma Durumu] =  
--case
--	when UnitPrice > 50 then 'Pahalý'
--	when UnitPrice = 50 then 'Alýnýr'
--	when UnitPrice < 50 then 'Ucuz'
--end
--from Products
--order by UnitPrice desc


--Aggreate fonksiyonlarý baðlý olduklarý sütunlarýn sorgu içine almak için kullanýlýr.
--Eðer bir aggreate fonklsiyonu varsa sorguda onun için kullanýrýz group by ý 
--select Country, Count(Country) as [Toplam Çalýþan Sayýsý] from Employees group by Country

--hangi kategoride kaç tane ürün var
--select CategoryID, Count(ProductID) as [Toplam Ürün] from Products group by CategoryID

--ülkelere göre sipariþ sayýlarýný raporla, en çok sipariþ veren 3 ülkeyi listeleyiniz
--select top 3 ShipCountry, Count(OrderID) as [Sipariþ Sayýsý] from Orders group by ShipCountry order by [Sipariþ Sayýsý] desc

--hangi personel kaç satýþ yapmýþtýr
--select  EmployeeID, count(OrderID) as [Toplam Satýþ] from Orders group by EmployeeID

--hangi müþteri kaç kere alýþveriþ yapmýþtýr
--select CustomerID, count(OrderID) as [Toplam Alýþveriþ] from Orders group by CustomerID

--ürün tablosundaki tedarikçi kategoriye göre grupla kaç dolarlýk olduðu toplam ürün satýþ tutarý
--kaç satýþ deyince stok ve ürün fiyatýný çarp
--select SupplierID, sum(UnitPrice * UnitsInStock) as [Toplam] from Products group by SupplierID

--select SupplierID, sum(UnitPrice * UnitsInStock) as [Toplam] from Products group by CategoryID, SupplierID order by  SupplierID

/*
Subsquery (Alt Sorgular)

1. Joinler yetersiz kaldýðýnda 
2. Having iþlemi yetersiz kaldýðýnda 

*/

--UnitPrice ýn ortalamadan yüksek deðer olmasý gerekiyor
--25 ürün var bunlarýn fiyatý ortalamanýn üstünde
--select ProductName, UnitPrice, (select avg(UnitPrice) from Products) as [Ortalama Deðer] 
--from Products 
--where UnitPrice > (select avg(UnitPrice) from Products)

--Nancy nin almýþ olduðu sipariþlerin id lerini raporla
--select OrderID from Orders where EmployeeID = (select EmployeeID from Employees where FirstName = 'Nancy')

--Beverages kategorisine ait ürünleri listele
--select * from Products where CategoryID = (select CategoryID from Categories where CategoryName = 'Beverages')

--Nancy, Andrew ya da Janet tarafýndan alýnmýþ ve Speedy Express ile taþýnmamýþ sipariþleri listele

select * from Orders where EmployeeID in(
	select EmployeeID from Employees where FirstName in('Nancy', 'Andrew', 'Janet')
	and
	ShipVia != (select ShipperID from Shippers where CompanyName = 'Speedy Express')
) order by EmployeeID desc

--select * from Orders
--select * from shippers
--select * from Employees

--*shippers, orders, *employees