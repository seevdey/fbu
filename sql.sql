
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

--Nancy, Andrew ya da Janet tarafýndan alýnmýþ ve Speedy Express ile taþýnmamýþ sipariþleri listele --shippers, orders, employees
--select OrderID, EmployeeID, ShipVia from Orders where EmployeeID in(
--	select EmployeeID from Employees where FirstName in('Nancy', 'Andrew', 'Janet')
--	and
--	ShipVia != (select ShipperID from Shippers where CompanyName = 'Speedy Express')
--) order by EmployeeID desc


--15 DECEMBER 2022

--alt sorguyu kþulda deðil select te de kullanabilirim
--Products tablosun yerine p harfi kullan
--iki tane SuppliersID var mutlaka birine nick vermen gerekiyor. Birbirinden ayýrmak için p.SuppliersID demek Products tablosundan SupplierID yi klullanýyorum demek
--select ProductName, (select CompanyName from Suppliers where SupplierID = p.SupplierID) as [Tedarikçi Adý] from Products p 

--ürünler tablosundaki ürünlerin toplam satýþ miktarý sorgulayan sorgu
--select ProductID, ProductName, (select sum(Quantity) from [Order Details] o where o.ProductID = p.ProductID) as [Satýþ Miktarý] from Products p 

--3 numaralý ürünün satýþ yapýldýðý müþterinin ýd lerini listele
--order da order id yi al
--select CustomerID from Orders Where OrderID in (
--select OrderID from [Order Details] where ProductID = 3)

--2 numaralý nakliyecinin taþýdýðý 4 numaralý personelin satýþ yaptýðý müþterilerin bilgilerini listele
--select * from Customers o where CustomerID in(select CustomerID from Orders where ShipVia = 2 and EmployeeID = 4)

--JOIN
--Ýki tabloyu birbirine baðlamak için kullanýlýr
--iki kümenin kesiþimleri olan kayýtlarý getiriyor

--1. INNER JOIN
--tabloda null olmayann deðerleri getiriyoruz
--burda kesiþim CategoryID oluyor
-- on p.CategoryID = c.CategoryID --> bunun üzerinden baðla
--select ProductName, CategoryName from Products p inner join Categories c on p.CategoryID = c.CategoryID

--ürünlerle, supplier i baðla
--select * from Products p inner join Suppliers s on p.SupplierID = s.SupplierID

--hangi personel hangi müþteriye hangi tarihte satýþ yapmýþtýr (soruda bana söylüyor)
--çalýþaný al ordera git orderdan customera git
--select e.FirstName + ' '  + e.LastName + ' ' as [Ad Soyad], c.ContactName, o.OrderDate
--from Employees e
--inner join Orders o on e.EmployeeID = o.EmployeeID 
--inner join Customers c on o.CustomerID = c.CustomerID

--hangi personel hangi kategoriden hangi ürünleri satmýþtýr
--order detail, order, product, employee
--select e.FirstName + ' '  + e.LastName + ' ' as [Ad Soyad], p.ProductName, c.CategoryName from Employees e
--inner join Orders o on o.EmployeeID = e.EmployeeID
--inner join [Order Details] od on o.OrderID = od.OrderID
--inner join Products p on p.ProductID = od.ProductID
--inner join Categories c on c.CategoryID = p.CategoryID 

--beverage kategorisine ait stoklarda bulunan ürünleri raporlayýnýz
--select * from Products p
--inner join Categories c on c.CategoryID = p.CategoryID where p.UnitsInStock != 0 and c.CategoryName = 'Beverages'

--ÖDEV : Nancy Andrew ve Janet tarafýndan müþterilerden alýnmýþ sipariþlerin Speedy Express ile taþýnmamýþ olan sipariþlerin toplam ne kadarlýk kargo ödemesi yapýlmýþtýr 
--Employees, Shippers, Order
--select  e.FirstName, sum(o.Freight) as [Kargo Toplamý] from Orders o
--inner join Employees e on e.EmployeeID = o.EmployeeID
--inner join Shippers s on s.ShipperID = o.ShipVia
--where e.FirstName in('Nancy', 'Andrew', 'Janet') and s.CompanyName != 'Speedy Express'
--group by e.FirstName


--LEFT JOIN / RIGHT JOIN
--soldaki tablo Categories, soldaki tabloyu baz aldý
--Products saðdaki tablo
--select ProductName from Categories c left join Products p on p.CategoryID = c.CategoryID --77 kayýt var Maske yok -- Categories tablosunu baz aldý
--select ProductName from Categories c right join Products p on p.CategoryID = c.CategoryID --78 kayýt var Maske de aldý --Product tablosunu baz aldý


--1. Hangi ürün hangi nakliye firmasýyla taþýnmýþtýr
--select o.OrderID, p.ProductName,  sh.CompanyName from Products p
--inner join [Order Details] od on p.ProductID = od.ProductID
--inner join Orders o on o.OrderID = od.OrderID
--inner join Shippers sh on sh.ShipperID = o.ShipVia


--2. Hangi tedarikçiden toplam kaç tl lik ürün satýlmýþtýr
--select s.SupplierID, s.CompanyName, ((1-od.Discount) * (od.UnitPrice*od.Quantity)) as Ciro  from Suppliers s
--left join Products p on s.SupplierID = p.SupplierID
--left join [Order Details] od on od.ProductID = p.ProductID


--3. Kategorilerin toplam satýþ raporlarý 
--select c.CategoryName, sum(Quantity) as [Toplam Satýþ] from Categories c 
--inner join Products p on p.CategoryID = c.CategoryID
--inner join [Order Details] od on od.ProductID = p.ProductID
--group by c.CategoryName


--4. Hangi personel hangi ürünü toplam kaç dolarlýk satmýþtýr
--select  e.FirstName + ' '  + e.LastName + ' ' as [Ad Soyad], p.ProductName, sum(((1-od.Discount) * (od.UnitPrice*od.Quantity))) as Ciro 
--from Employees e 
--inner join Orders o on o.EmployeeID = e.EmployeeID
--inner join [Order Details] od on od.OrderID = o.OrderID
--inner join Products p on p.ProductID = od.ProductID
--group by e.FirstName, e.LastName, p.ProductName

--16 DECEMBER 2022

--SQL de Aggregate fonksiyonlarla hesaplama yaptýðýmýz sütunlara where cümlesinde koþul ifadesi veremeyiz 
--Koþul ifadesi verebilmek için HAVING kelimesini kullanýrýz

--Quantity için where kulananamam çünkü baþýnda aggregate var ama Quantity için illa da kulanmak istersen HAVING kullanabilirsin
--SELECT p.ProductName, sum(Quantity) as [Siparis Miktarý] FROM [Order Details] od
--INNER JOIN Products p ON p.ProductID = od.ProductID
--GROUP BY p.ProductName
--HAVING sum(Quantity) > 1200 --sipariþ miktarý 1200 den büyük olanlarý listele
--ORDER BY [Siparis Miktarý] desc

--SQL de yanlýþ alt sorgu yazarsan döngüyü kýramazsýn c# taki gibi. 
--Alt alta sorgularý birbirine baðlarken önceden küçük küçük planlayýp sonra birleþtirmen lazým.

--250 den fazla sipariþ taþýmýþ olan kargo firmalarýnýn adlarýný, telno ve sipariþ miktarlarýný raporla
--Shippers, Orders
--select s.CompanyName, s.Phone, count(o.ShipVia) as [Sipariþ Miktarý] from Orders o
--inner join Shippers s on s.ShipperID = o.ShipVia
--group by s.CompanyName, s.Phone
--having count(o.ShipVia) > 250
--order by [Sipariþ Miktarý] desc

--birleþtirme fonksiyonu 
--union
--select CompanyName, Phone, 'Suppliers' from Suppliers 
--union 
--select CompanyName, Phone, 'Customers' from Customers

--kesiþimde intersect
--INTERSECT operatörü, yalnýzca her iki input kümesinde bulunan satýrlarý döndürür. 
--select UnitPrice,ProductID from [Order Details]
--intersect
--select UnitPrice, ProductID from Products
--order by UnitPrice

--fark kümesi
--except

--Order Details te olup Products ta olmayanlar
--select UnitPrice, ProductID  from [Order Details]
--except 
--select UnitPrice, ProductID  from Products
--order by UnitPrice


--select * from [Order Details] where ProductID = 33
--select * from Products where ProductID = 33



--ASLA KULLANMA!!!!! fazla kayýtta yormuþ olursun
--sorgu sürdükçe RAM þiþer
--cross koin kartezyen çarpýmý
--8 kategoriyi 78 ürünle çarptý toplam 624
--1 kategori 78 ürün demek
--select ProductName, CategoryName from Products cross join Categories 

--kayýt ekleme
--insert into Shippers(CompanyName, Phone)
--values('Furkan Kargo', 11111189)

--kayýt ekleme, 2.yol
--insert into Shippers
--values('Göktug Kargo', 89)

--select * from Shippers


--çalýþan tablsouna kendini ekle
--insert into Employees

--select * from Employees



--ikisi de ShipperID 5 deðerini getirir 

--identity oturum bazlý çalýþmýyor, tablo bazýnda çalýþýyor
--genellikle identity kullanýlýr
--son ShipperID 5 ise herkes 6 yý alýyor
--select @@IDENTITY --@@demel globali iþaret ediyor demek, aþaðýdaki herkes globali kullanmýþ oluyor

----oturum bazlý çalýþýr
--select SCOPE_IDENTITY()

--select * from Shippers


--id si 5 olan verinin telefonunu güncelle
--update Shippers
--set Phone = '212 333 22 44'
--where ShipperID = 5

--select * from Shippers


---çalýþanlar tablosundaki dg tarihini nancy i 01011967 yap  ,city i kastamonu yap
--select * from Employees 
--update Employees
--set BirthDate = '1997-01-01', City = 'Kastamonu'
--where FirstName = 'Nancy'


--yanlýþlýkla bütün ürülerin fiyatýný 50 yaptým. baþýna begin trans koyarsam geri alma þansým var
--sonuna rollback tran
--update yaparken baþýna begin tran koymalýsýn

--select * from Products
--select*from Employees

/*
--1. çalýþtýracaðýn yer
--begin tran
--update Products set UnitPrice = 50

--2. çalýþtýracaðýn yer --geri almak için
--rollback tran
*/

--begin tran
--update Products set UnitPrice = 50
----update Employees set FirstName = 'Sevde'

--rollback tran


--DELETE ve TRUNCATE i asla kullanmýyorsun
--4 den büyük olan ShipperID leri sil
--delete from Shippers where ShipperID > 4


/*
	delete ile silmeyeceksin ama delete i kullanacaksýn
	tablonun sonuna del sütunu ekle, bit olarak tanýmlayacaksýn hepsi 0 olacak
	sen bir butona sil dediðin zaman gelip bu sütunu 1 yapacaksýn
	geri almak istediðinde 0 yap
	göster dediðin zamanda 0 larý göstereceksin
	kullanýcý da görmediði için siliniþ zannedecek oysaki o veri silinmemiþ olacak
*/


--Müþteri senden tablo isterse create view kullanabilirsin

--Amerikalýlar diye view var yani sanal tablo. Ben bunu çaðýrdýðým zaman amerikalý müþterilerim otomatik olarak geliyor
--create view Amerikalýlar 
--as
--Select c.CustomerID, c.CompanyName, o.OrderID, o.OrderDate from Orders o
--inner join Customers c on c.CustomerID = o.CustomerID
--where c.Country = 'USA'

--kontrol
--select * from Amerikalýlar

--bu tablo Views altýnda oluþuyor


--select * from Amerikalýlar a
--inner join Orders o on a.OrderID = o.OrderID

--select * from Amerikalýlar


--19 DECEMBER 2022
--Speedy Express ile taþýnmýþ Nancy'nin almýþ olduðu pzt günleri ya da 'Dumon' ya da 'Alfki' id li müþteriler tarafýndan verilmiþ olan sipariþleri listeleyen view i tasarla,
--taþýyanýn ismi çalýþanýn ilk adý ve 
--order id, order date, firstname, customerid,
--view in ismi ; Nancy nin sipariþleri

--select * from Shippers
--select * from Employees
--select * from Orders --order date ve customer id 

--create view [Nancy'nin Sipariþleri]
--as
--select o.OrderID, o.OrderDate, e.FirstName, c.CustomerID, s.CompanyName from Shippers s 
--inner join Orders o on s.ShipperID = o.ShipVia
--inner join Employees e on e.EmployeeID = o.EmployeeID
--inner join Customers c on c.CustomerID = o.CustomerID
--where DATENAME(WEEKDAY, OrderDate) = 'Monday'
--and c.CustomerID in('DUMON', 'ALFKI')
--and e.FirstName = 'Nancy' 
--and s.CompanyName = 'Speedy Express'


--hangi ürünü hangi müþterinin hangi personelden ismi detaylý satýþ raporu
--select * from Products
--select * from Customers
--select * from Employees
--select * from Orders
--select * from [Order Details]

--create view [Detaylý Satýþ Raporu]
--as 
--select p.ProductName, c.ContactName, e.FirstName + ' ' + e.LastName as [Ad Soyad], o.EmployeeID from 
--Products p
--inner join [Order Details] od on od.ProductID = p.ProductID
--inner join Orders o on  o.OrderID = od.OrderID
--inner join Employees e on o.EmployeeID = e.EmployeeID
--inner join Customers c on c.CustomerID = o.CustomerID


--select * from [Detaylý Satýþ Raporu]

--left join kullanarak
--select p.ProductName, c.ContactName, e.FirstName + ' ' + e.LastName as [Ad Soyad], o.EmployeeID from 
--Products p
--left join [Order Details] od on od.ProductID = p.ProductID
--left join Orders o on  o.OrderID = od.OrderID
--left join Employees e on o.EmployeeID = e.EmployeeID
--left join Customers c on c.CustomerID = o.CustomerID


--VIEW ORNEGI
--create view KategoriEkleme
--as
--select * from Categories
--go 
--insert into KategoriEkleme(CategoryName, [Description])
--values('Sütlü Tatlýlar', 'Süt iyidir')

--select * from KategoriEkleme



--View içinde join varsa INSERT yapýlamaz
--View içinde iliþkili tablolara kayýt eklenemez.
--create view KategoriUrunleri
--as
--select p.ProductName, c.CategoryName from Categories c
--inner join Products p on p.CategoryID = c.CategoryID
--go
--insert into KategoriUrunleri(ProductName, CategoryName)
--values ('Sütlü Nuriye', 'Sütlü Tatlýlar')



--View içinde order by kullandýðýnda top kelimesini kullanmak zorundasýn
--create view FiyataGoreUrunler
--as
--select top 77 ProductName, UnitPrice from Products 
--order by UnitPrice desc

--select * from FiyataGoreUrunler



--verdiðim koþula göre çalýþmasýný istiyorum 
--create view FileBaslayanKargolar
--as
--select * from Shippers s 
--where CompanyName like 'F%'
--with check option --insert iþlemi yaparken bu kurala göre yap 

--yani burdaki view içerisinde insert yapacaðým
--insert into FileBaslayanKargolar(CompanyName)
--values('Fly Kargo')

--insert into FileBaslayanKargolar(CompanyName)
--values('Zly Kargo') --ekleyemiyorum. koþula göre ekleme yapabiliyorum
----verdiðim koþula göre insert edebiliyorum

--select * from Shippers


--shipper dan yaptýðýn view da telefonu kitle ben onu alter table shipper table drop kolon yapamayacaðým
--shipperdaki telefon sütununu kitle yani o sütunu silemeyeceðim

--select * from Shippers

--create view TumKargolarim
--with schemabinding
--as 
--select CompanyName, Phone from dboShippers

--select * from TumKargolarim

--alter table Shippers drop column Phone --kolondan deðer silinmediði, kilitlendiði kontrolü



--view kilitleme -saða týklayýnca design açýk olmayacak
--ben view kodlarýný göremiycem

--alter view Amerikalilar
--with encryption 
--select CompanyName, Phone from dbo.Shippers


--STORED PROCEDURE
--ado da arayüz tanýmlayacaðýmýz zaman. 1. çeþit sql client tarafýna sql yazmak
--clientta hiç sql olmayýp client a sql veriyosun. SQL i server da kullanýyosun. Sql de update delete komutlarýný çalýþtýranlara da store procedure deniyor
--clienta resmen boþ biir kutuya çeviriyoruz
--STORED PROCEDURE --> server tarafýndan bu iþi yapmaya saðlayan procedurelerimiz 

--dopper da elle sql oluþturuyosun.

--bunu serverda yazýyorum, clienttan bu yetkiyi almalýsýn
--create proc KategoriEkle
--(
--@ad nvarchar(20),
--@tel nvarchar(20)
--)
--as insert into Shippers(CompanyName, Phone)
--values(@ad, @tel)


----bunu clientta çalýþtýrýyorum
----çok güvenli
----client ta sql i patlatamazsýn
--KategoriEkle 'Yurtiçi Kargo', '11111111111'

--select * from Shippers



--ürünlerin fiyatlarýna zam yap. zamyapýcý procedure oluþtur. Zam yapýcý 5 dediðim zaman bütün ürünlerin fiyatýna 5 ekleyecek
--create proc ZamYap3
--(
--@miktar money
--)
--as update Products
--set UnitPrice += @miktar

--ZamYap3 5

--select * from Products


--dýþardan girilen kategori adýna ait ürünleri listele
--create proc KategoriyeGoreUrunler
--(
--@kategoriAdi nvarchar(20)
--)
--as select  p.ProductName from Categories c
--inner join Products p on p.CategoryID = c.CategoryID
--where c.CategoryName = @kategoriAdi

--KategoriyeGoreUrunler 'Beverages'



--dýþardan girilen kargo firmasý tarafýndan taþýnmýþ, kargo ücreti min ve max deðerleri verilen sipariþleri listeleyen bir prosedür, ismi sipariþ getirici
--orderid, company name, freight

--create proc SiparisGetirici
--(
--@kargoFirmasi nvarchar(20),
--@min int,
--@max int
--)
--as select o.OrderID, s.CompanyName, o.Freight from Orders o 
--inner join Shippers s on s.ShipperID = o.ShipVia
--where s.CompanyName = @kargoFirmasi and o.Freight > @min and o.Freight < @max


--o.Freight @min between @max


--select * from Orders
--select * from Shippers

--SiparisGetirici 'Speedy Express', 10, 100



 --klavyeden girilen calisanId si tarafýndan alýnmýþ sipariþleri listele
 --dýþardan kaç adet çalýþan id si bilinmemektedir

 --select * from Shippers

--create proc CalisanaGoreSiparisGetir
--(
--	@param nvarchar(max)
--)
--as
--declare @sorgu nvarchar(max) --deðiþken tanýmlama --içerde kullanacaðým deðiþken
--set @sorgu  = ('select OrderID, OrderDate, EmployeeID from Orders where EmployeeID in (' + @param + ') order by EmployeeID')
--Execute(@sorgu)

--dinamik bir sorgu oluþturmuþ olduk
--sql deki sorguyu dinamik bir þekilde kullandým
--bütün iþi server da yapacaðýz. Client ta sorgu çalýþtýrmayacaðýz

--CalisanaGoreSiparisGetir '1,5,4'
--CalisanaGoreSiparisGetir '1,5,4,9,8'


--ürünleridetayli getir isimli procedure. Ürünleri detaylý getirde dýþarýdan firma girilecek tedarikçinin firmasýnýn ismini alacaksýn. 
--girilen firmanýn ürünlerinde önce burada stok miktarý min max stok, sonra min max ücret, tedarikçi ismi içinde ltd olan firmalar gelecek
--create proc UrunleriDetayliGetir3
--(
--	@firmaGir nvarchar(30),
--	@stokMin int,
--	@stokMax int,
--	@ucretMin int,
--	@ucretMax int
--)
--as 
--select s.CompanyName, p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock from Products p
--inner join Suppliers s on p.SupplierID = s.SupplierID
--where s.CompanyName like '%' + @firmaGir + '%'
--and p.UnitsInStock between @stokMin and @stokMax
--and p.UnitPrice between @ucretMin and @ucretMax


--UrunleriDetayliGetir3 'Ltd', 10, 80, 20 , 100

--select * from Suppliers


--dýþardan girilen karakterlerin içerisinde barýndýran müþteri adýna sahip müþterilerce verilmiþ sipariþleri listeleyen bir procedure tasarla
--alter proc SiparisleriListele10
--(
--	@param nvarchar(max)
--)
--as
--declare @sorgu nvarchar(max) --deðiþken tanýmlama --içerde kullanacaðým deðiþken
--set @sorgu  = ('select c.ContactName from Customers c inner join Orders o on o.CustomerID = c.CustomerID where c.ContactName like (''%' + @param + '%'')  ')
--Execute(@sorgu)

--SiparisleriListele10 'ar, an'

--select * from Customers

--T-SQL

--20 DECEMBER 2022

--nesned stored procedure yaptým
--clientta yapacaðýn iþleri store prodecure da yapacaksýn
--böylelikle clienti aþaðýdaki bilgileri almak için kullanacaksýn

--create proc KategoriEkle1New
--(
--	@ad nvarchar(20),
--	@sonid int Output
--	--eðer procedure içinden bir deðeri dýþarý çýkarmak istersek output kelimesini kullanýrýz
--)
--as insert into Categories (CategoryName) values (@ad);
--set @sonid = SCOPE_IDENTITY();
----category ekliyosun ama son id yi scope identity ile alýyorum

--go

--create proc UrunEkleyici
--(
--	@urunadi nvarchar(20),
--	@katAdi nvarchar(15) --kategoriAdi
--)
--as 
--declare @katid int --declare deðiþken tanýmlamak

--if not exists (select CategoryName from Categories where CategoryName = @katAdi) --kategori adindan kategori var mi --yokken burasý çalýþýr --kateogirAdi oluþturuyorum
--begin 
--exec KategoriEkle1New @katAdi, @katid output --yoksa kategoriye ekle
--end

--else --sütlü tatlýlar varsa  çalýþýr --id sini çekiyorum
--begin
--select @katid=CategoryID from Categories where CategoryName = @katAdi
--end

--insert into Products(ProductName, CategoryID) --Product tablosuna ekleme yapýyorum
--values(@urunadi, @katid)

----server tarafý tamam


----client tarafý
----exec UrunEkleyici 'Fýrýnda Sütlaç', 'Sütlü TatlýlarYeni' --biri kategori diðeri ürün olmak üzere 2 tane row yaptým
--exec UrunEkleyici 'Sütlü Nuriye', 'Sütlü TatlýlarYeni' --bir kolon çalýþtý Sütlü Nuriye Product tablosuna eklendi

--select * from Products
--select * from Categories


--id yi almýyoruz böyle bir kayýt zaten var diyoruz. Üsttteki örnekten farký bu
--create proc KategoriEkle2New
--(
--	@ad nvarchar(50),
--	@tanim nvarchar(100)
--)
--as 
--if not exists (select * from Categories where CategoryName = @ad) --CategoryName yoksa ekle
--begin
--insert into Categories (CategoryName, Description) values (@ad, @tanim);
--end

--else --varsa burasý çalýþsýn
--begin
--print 'Böyle bir kayýt zaten var'
--end

--bu procedure ün client tarafýnda kullanýlmasý
--KategoriEkle2New 'ilaçlar', 'Apranax, Asprin'    --bu kaydý 2. kez çalýþtýrýrsan else kýsmý çalýþýr

--select * from Categories --kontrol saðlýyoruz



--girilen ürün kodunu bul seç o ürünün stoðuna dediði kadar ekle store procedure ü yazýnýz
--var olan ürünün miktarýný istediðim stok miktarý kadar artýracaðým

--create proc Kontrol
--(
--	@id int,
--	@stok int
--)
--as
--if exists(select ProductID from Products where ProductID = @id)
--begin
--update Products 
--set UnitsInStock += @stok where ProductID = @id
--end
--else
--begin
--print 'Böyle bir kayýt yok'
--end

--Kontrol 5, 8

--select * from Products


--ürün adý girilecek ve girilen ürün adýný silen procedure
--create proc UrunSil
--(
--	@isim nvarchar(20)
--)
--as 
--if exists (select ProductName from Products where ProductName = @isim)
--begin
--delete from Products where ProductName = @isim
--end
--else
--begin
--print 'Böyle bir kayýt yok'
--end


--------------------------------------FONKSIYONLAR--------------------------------------

--1-Scaler Valued Fonksiyonlar geriye tek satýr deðer döndürenler
--2-Table Valued Fonksiyonlar geriye bir tablo deðer döndürür

--create function ToplamaYap
--(
--@s1 int,
--@s2 int
--)
--returns int
--as
--begin return @s1+@s2
--end


--select dbo.ToplamaYap(10,20) as 'Toplama'


--mevduat faizini hesaplayan function
--create function MevduatFaizi
--(
--	@anapara int,
--	@faizorani int,
--	@gun int
--)
--returns int 
--as 
--begin return (@anapara * @faizorani * @gun) /36500
--end

--select dbo.MevduatFaizi (1000, 15, 30) as 'Mevduat Faizi'

--mail oluþturucu
--isminin soldan 3 harfi, soyadýnýn sondan 3 harf al, araya nokta koy

alter function MailOlustur
(
	@isim nvarchar(50),
	@soyisim nvarchar(50)
)
returns nvarchar
as 
begin return left(@isim, 3) + '.' + right(@soyisim,3) + '@hotmail.com' 
end


select FirstName, LastName, dbo.MailOlustur(FirstName, LastName) from Employees




