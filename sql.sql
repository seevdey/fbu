
--12 DECEMBER 2022

--master ana tablo
--CRTL+F5 --> parse etmi� oluyorum
--�al��t�rmadan evvel hata var m� yok mu kontrol ediyor. Intellince visual studioda class olu�turuyoduk o1. diyince name ��k�yodu ya sql de bu ��km�yor

--CREATE DATABASE denemeiskur2 --tablo olu�turma

--DROP DATABASE denemeiskur2 --tablo silme

--SQL iki b�l�mden olu�ur --> 1.DDL, 2.DML
--1.DDL --> Data Definition Language --> Tan�mlamak i�in kullan�lan k�s�m
--2.DML Tan�ml� Veri �zerinde i�lem yap�yoruz
--DDL --> Hi�bir �ey yok ortada bo� sen olu�turuyorsun hangi komutlarla --> 1.CREATE, 2.DROP, 3.ALTER ile olu�turuyosun
--Veri taban� yapablirsin
--Tablo olu�turma, silme, g�ncelleme
--Index olu�turabilirsin drop alter yapabilirsin
--Storage Prosedure --> her �eyi clientta de�il serverda �al��t�r�yorsun. client ��p. server ana cihaz
--Fonksiyon olu�turabilirim
--Trigger olu�turabilirim, silerim

--database nin ismini 'xx' de�i�tirdim
--ALTER DATABASE denemeiskur2
--MODIFY Name = xx 


--sa� t�klad���mda yapt���m i�lemleri kodla yap�yorum
--CREATE DATABASE ManuelDB
--ON PRIMARY ( 
--Name = manueldb_data,
--FileName = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\manueldb.mdf',
--Size = 10MB,
--FileGrowth = 3MB, --boyut art�rma. MMB 3MB art�rmas�n� sa�l�yor
--MaxSize = 60MB
--)

--Log On(
--Name = manueldb_log,
--FileName = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\manueldb.ldf',
--Size = 3MB,
--FileGrowth = 10%,
--MaxSize = 10MB
--)



--database, tablo, diyagram olu�turma
--her s�tunun ne anlama geldi�ini yaz
--create database KuzeyRuzgari
--go --birden fazla SQL i birbirine ba�l�yor. pe�pe�e �al��mas�n� sa�l�yor
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

--	--YapimYili i�in k�s�tlama yap�yorum
--	--y�l baz�nda kar��la�t�r, araba ya�� 10 dan b�y�k olamaz
--	--�u andaki tarih YapimYili ile aradaki fark� y�l baz�nda al buldu�un de�er 10 dan k���kse i�eriye veri at, de�ilse atma
--	constraint YapimYili check(datediff(YEAR, YapimYili, getdate()) < 10),
	
--	--plaka tek olmal� 2. plaka olamaz
--	unique (Plaka)
--)


--Ara� olup olmad���n� kontrol edicez 
--insert --> i�eriye veri ekleme
--yapimyili ve alisyili aras�nda 10 dan fazla y�l varsa veriyi eklemez
--insert into Araclar Values('Toyota', '34 ZA 2022', '01.01.2015') 


--Araclar tablosunda markan�n varchar �zelli�ini 50 olarak de�i�tiriyoruz
--alter table Araclar
--alter column Marka nvarchar(50) not  null

--s�tun ekleme
--alter table Araclar
--add column MotorGucu int

--s�tun silme
--alter table Araclar
--drop column MotorGucu 


/*
	DML Komutlar� 
	1.Insert --> yeni kay�t ekleme
	2. Update --> g�ncelleme
	3.Delete --> silme (asla kullanmayacaks�n), 
	4.Select --> listeleme
*/


--select 2+3 as Toplama
--select 'Merhaba' + '//' + 'D�nya' as Mesaj

--select upper('sema') as ba�l�k --b�y�k harfe �evirme
--select SUBSTRING('Bu s�n�ftan g�zel bir ekip olur mu?' ,1,11)

--select rtrim (SUBSTRING('    Bu s�n�ftan g�zel bir ekip olur mu?' ,1,16)) --sa�daki bo�lu�u siler
--select ltrim (SUBSTRING('Bu s�n�ftan g�zel bir ekip olur mu?    ' ,1,16)) --soldaki bo�lu�u siler


--select replace ('��KUR', '��', 'Yaz')  --> ��KUR yerine YazKUR yaz  -> replace yer de�i�tirmek demek

--select MONTH(getdate()) --�u an bulundu�umuz ay
--select DATEADD(day, 2, getdate()) --2 g�n sonraki tarihi ekleme

--select DATENAME(dayofyear, getdate()) --y�l�n ka��nc� g�n�nde oldu�umuzu g�sterir
--select DATENAME(WEEKDAY, getdate()) --haftan�n hangi g�n�nde oldu�umuzu g�sterir


--select * from Shippers --t�m tablo
--select CompanyName from Shippers --tabloda CompanyName kolonu 
--as ile nick at�yorum
--select CompanyName as [Firma �smi] from Shippers --tabloda CompanyName kolonunun ismini Firma �smi yapt�k
--Herhangi bir tablo, isim takma isim olursa olsun e�er bo�luk ifadesi varsa sonuna ve ba��na k��eli parantezi kullanmak zorundas�n

--m��teri tablosunun t�m s�tunlar�n� t�rk�ele�tirilmi� halini 

--select 
--CustomerId as [M��teri ID],
--CompanyName as [�irket Ad�],
--ContactName as [�leti�im Ad�],
--ContactTitle as [�leti�im Ba�l���],
--Address as Adres,
--City as �ehir,
--Region as B�lge,
--PostalCode as [Posta Kodu],
--Country as �lke,
--Phone as Telefon,
--Fax as Faks
--from Customers

--�al��anlar�n employeid lerinin adlar�n� ve soyadlar�n� raporla, adlar ve soyadlar tek bir kolonda gelsin ve kolon ad� Ad soyad olsun
--select EmployeeID, FirstName + ' ' + LastName as [Ad Soyad] from Employees

--select ProductID, ProductName, UnitPrice, UnitPrice * 1.18 as [KDV li Fiyat] from Products
--UnitPrice * 1.18 as [KDV li Fiyat] <-- aggregation (ge�ici) s�tun

--fiyat� 30 dan b�y�k olanlar� getir
--where ko�ul
--select ProductID, ProductName from Products where UnitPrice > 30


--londrada ya�ayan personelin listesi
--select * from Employees where City = 'London'

--kategoriID si 5 olmayan �r�nlerin adlar� ve kategorilerini g�steriniz
--select CategoryID, ProductName from Products where CategoryID != 5


--13 DECEMBER 2022

--mart ay�nda al�nm�� olan sipari�lerin OrderID, OrderDate s�tunlar�yla raporla
--select OrderID, CONVERT(varchar(20),OrderDate,113) AS 'March' from Orders where datename(Month, OrderDate) = 'March'

--60 ya��n �st�nde �al��anlar� listele
--select * from Employees where datediff(YEAR, BirthDate, getdate()) > 60 --iki tarih aras�ndaki fark

--ya�� 60 ya��ndann b�y�k olan amerikal�lar� listele
--select * from Employees where datediff(YEAR, BirthDate, getdate()) > 60 and Country = 'USA'


--sipari� tarihi 1997 dan b�y�k olanlar, kargo �creti 20 den b�y�k, Fransaya g�nderilmemi� sipari�ler
--select * from Orders where ShipCountry != 'France' and Freight > 20 and OrderDate > '1997'

--hen�z m��teriye ula�mam�� sipari�leri listele
--select * from Orders where ShippedDate is null

--kimseye rapor vermeyen personelin firstname last name, title
--select  FirstName, LastName,Title from Employees where ReportsTo is null

--kategoriId si 5 olan, �r�n bedeli 20 den b�y�k 300 den k���k olan ve stok durumu null olmayan �r�nlerin detaylar�n� 
--select * from Products where CategoryID = 5 and (UnitPrice > 20 and UnitPrice <300) and UnitsInStock is not null

--�r�n�d si 3,5,7,4,12,8 d���nda olanlar�n sipari� edilmi� �r�nlerin id lerini g�ster
--select * from [Order Details] where ProductID != 3 and ProductID != 4 and ProductID != 5 and ProductID != 7 and  ProductID != 12 and ProductID != 8 

--select ProductID from [Order Details] where ProductID not in(3, 4, 5, 8, 7, 12) 

--�r�nlerin isimleri 3. karakteri a ve b  c den 1 tanesi olan isimleri listeleyiniz
--select * from Products  where ProductName LIKE '__[abc]%'


--SIRALAMA �FADES� --> ORDER BY
--asc - k���kten b�y��e -- default
--desc - b�y�kten k����e

--select FirstName + ' ' + LastName as  'AdSoyad' from Employees order by AdSoyad desc

--m��teriler tablosunda cusomterid compnay name ve �lkelerine g�re frans�z �irketleri, customerid lerine g�re tersten s�ralanacak �ekilde listele
--select CustomerID, CompanyName from Customers where Country = 'France' order by CustomerID desc

--stok miktar 50 den b�y�k olan, �creti ucuzdan pahal�ya �eklinde s�ralanan �r�nleri listele --en ucuz 10 �r�n
--select top 10 * from Products where UnitsInStock>50 order by UnitPrice

--en son teslim edilen 5 sipari�in detaylar�n� g�ster
--select top 5 * from Orders order by ShippedDate desc

--�r�nler tablosundaki stok miktar� en fazla olan en ucuz �r�nleri listele
--select * from Products  order by UnitsInStock desc, UnitPrice desc


--�al��anlar tablosunda ka� �lkeden �al��an�m var
--select distinct Country from Employees 

--select * from Employees

--ba� harfi c olan stoklarda mevcut 10 ile 250 aras�nda �creti olan �r�nleri fiyatlar�na g�re listele
--select * from Products where ProductName LIKE 'c%' and UnitPrice > 10 and UnitPrice < 250 and UnitsInStock is not null order by UnitPrice desc

--�ar� g�n� al�nan, kargo �creti 20 ile 75 aras�nda olna teslim edilmi� sipari�leri bilgilerini raporla
--select * from Orders where Freight>20 and Freight<75 and DATENAME(WEEKDAY, ShippedDate) = 'Wednesday' and ShippedDate is not null 


--14 DECEMBER 2022
--harfle ba�lay�p belirli bir �ey veriyorsan like kullan�yorsun. Ama bire bir e�it olmas�n� istersen like kullanm�yosun
--select CompanyName from Customers where CompanyName like  'A%'  --ne olursa olsun CompanyName A ile ba�layan
--select CompanyName from Customers where CompanyName like  '%A' -- sonu A ile biten
--select CompanyName from Customers where CompanyName like  '%od%' --i�inde od olan
--select CompanyName from Customers where CompanyName like  '__ton%' --ilk harfi ne olursa olsun, son 3 harfi ton olan

--ilk harfi a ile k aras�nda olan m��terileri listeleyiniz
--select * from Customers where CompanyName like '[A-K]%' 

--ilk harfi a olan 2.harfi n olmayan m��terileri listele
--select * from Customers where CompanyName like '[A][^N]%'

--�lkesi ingiltere olmayan ad� a ile ba�lay�p soyad� r ile biten do�um tarihi 1985 ten �nce olan �al��anlar�n listsei
--select * from Employees where Country != 'UK' and FirstName like 'a%' and LastName like '%r' and BirthDate > 1985 

--select count(*) from Products --ka� adet �r�n�m oldu�unu g�rmek istersem --77 adet �r�n�m var
--select count(distinct Country) from  Employees -- ka� farkl� �lkeden �al��an�m var
--select sum(UnitsInStock) from Products --stokta toplam ka� adet �r�n var -- 3119 tane

--bu zamana kadar �denmi� ortalama kargo �cretiniz nedir
--select avg(Freight) from Orders
--select sum(Freight) / Count(Freight) from Orders

--Toplam ka� dolarl�k ciromuz var indirimleri g�z �n�ne al
--select SUM((UnitPrice*Quantity)-(UnitPrice*Quantity*Discount) from [Order Details]
--select SUM((1-Discount) * (UnitPrice*Quantity)) from [Order Details]

--�lke ba��na ortalama ne kadar kargo �creti �denmi�tir
--select sum(Freight) / count(distinct ShipCountry) from Orders

--her �r�nden ortalama ka� dolarl�k sat�� yap�lm��t�r
--select AVG((1-Discount) * (UnitPrice*Quantity)) from [Order Details]

--5ten b�y�k en d���k sat���m�zda ka� dolarl�k sat�� yap�lm��t�r
--select MIN((1-Discount) * (UnitPrice*Quantity)) from [Order Details] where (1-Discount) * (UnitPrice*Quantity) > 5
--select MIN((1-Discount) * (UnitPrice*Quantity)) from [Order Details] where UnitPrice > 5

--Duruma g�e yeni kolon a�ma
--switch case gibi ama burda case when mant��� var

--select ProductName, UnitPrice, UnitsInStock, [Stok Durumu] = 
--case 
--	when UnitsInStock < 50 then 'Kritik Stok'
--	when UnitsInStock between 50 and 75 then 'Normal Stok'
--	when UnitsInStock > 75 then 'Stok Fazlas�'
--end
--from Products
--order by UnitsInStock


--�r�n tablosundaki �r�nlerin fiyat� 50 den b�y�kse pahal�, 50 ise al�n�r, 50 den k���kse ucu<
--select *, [Al�nma Durumu] =  
--case
--	when UnitPrice > 50 then 'Pahal�'
--	when UnitPrice = 50 then 'Al�n�r'
--	when UnitPrice < 50 then 'Ucuz'
--end
--from Products
--order by UnitPrice desc


--Aggreate fonksiyonlar� ba�l� olduklar� s�tunlar�n sorgu i�ine almak i�in kullan�l�r.
--E�er bir aggreate fonklsiyonu varsa sorguda onun i�in kullan�r�z group by � 
--select Country, Count(Country) as [Toplam �al��an Say�s�] from Employees group by Country

--hangi kategoride ka� tane �r�n var
--select CategoryID, Count(ProductID) as [Toplam �r�n] from Products group by CategoryID

--�lkelere g�re sipari� say�lar�n� raporla, en �ok sipari� veren 3 �lkeyi listeleyiniz
--select top 3 ShipCountry, Count(OrderID) as [Sipari� Say�s�] from Orders group by ShipCountry order by [Sipari� Say�s�] desc

--hangi personel ka� sat�� yapm��t�r
--select  EmployeeID, count(OrderID) as [Toplam Sat��] from Orders group by EmployeeID

--hangi m��teri ka� kere al��veri� yapm��t�r
--select CustomerID, count(OrderID) as [Toplam Al��veri�] from Orders group by CustomerID

--�r�n tablosundaki tedarik�i kategoriye g�re grupla ka� dolarl�k oldu�u toplam �r�n sat�� tutar�
--ka� sat�� deyince stok ve �r�n fiyat�n� �arp
--select SupplierID, sum(UnitPrice * UnitsInStock) as [Toplam] from Products group by SupplierID

--select SupplierID, sum(UnitPrice * UnitsInStock) as [Toplam] from Products group by CategoryID, SupplierID order by  SupplierID

/*
Subsquery (Alt Sorgular)

1. Joinler yetersiz kald���nda 
2. Having i�lemi yetersiz kald���nda 

*/

--UnitPrice �n ortalamadan y�ksek de�er olmas� gerekiyor
--25 �r�n var bunlar�n fiyat� ortalaman�n �st�nde
--select ProductName, UnitPrice, (select avg(UnitPrice) from Products) as [Ortalama De�er] 
--from Products 
--where UnitPrice > (select avg(UnitPrice) from Products)

--Nancy nin alm�� oldu�u sipari�lerin id lerini raporla
--select OrderID from Orders where EmployeeID = (select EmployeeID from Employees where FirstName = 'Nancy')

--Beverages kategorisine ait �r�nleri listele
--select * from Products where CategoryID = (select CategoryID from Categories where CategoryName = 'Beverages')

--Nancy, Andrew ya da Janet taraf�ndan al�nm�� ve Speedy Express ile ta��nmam�� sipari�leri listele --shippers, orders, employees
--select OrderID, EmployeeID, ShipVia from Orders where EmployeeID in(
--	select EmployeeID from Employees where FirstName in('Nancy', 'Andrew', 'Janet')
--	and
--	ShipVia != (select ShipperID from Shippers where CompanyName = 'Speedy Express')
--) order by EmployeeID desc


--15 DECEMBER 2022

--alt sorguyu k�ulda de�il select te de kullanabilirim
--Products tablosun yerine p harfi kullan
--iki tane SuppliersID var mutlaka birine nick vermen gerekiyor. Birbirinden ay�rmak i�in p.SuppliersID demek Products tablosundan SupplierID yi klullan�yorum demek
--select ProductName, (select CompanyName from Suppliers where SupplierID = p.SupplierID) as [Tedarik�i Ad�] from Products p 

--�r�nler tablosundaki �r�nlerin toplam sat�� miktar� sorgulayan sorgu
--select ProductID, ProductName, (select sum(Quantity) from [Order Details] o where o.ProductID = p.ProductID) as [Sat�� Miktar�] from Products p 

--3 numaral� �r�n�n sat�� yap�ld��� m��terinin �d lerini listele
--order da order id yi al
--select CustomerID from Orders Where OrderID in (
--select OrderID from [Order Details] where ProductID = 3)

--2 numaral� nakliyecinin ta��d��� 4 numaral� personelin sat�� yapt��� m��terilerin bilgilerini listele
--select * from Customers o where CustomerID in(select CustomerID from Orders where ShipVia = 2 and EmployeeID = 4)

--JOIN
--�ki tabloyu birbirine ba�lamak i�in kullan�l�r
--iki k�menin kesi�imleri olan kay�tlar� getiriyor

--1. INNER JOIN
--tabloda null olmayann de�erleri getiriyoruz
--burda kesi�im CategoryID oluyor
-- on p.CategoryID = c.CategoryID --> bunun �zerinden ba�la
--select ProductName, CategoryName from Products p inner join Categories c on p.CategoryID = c.CategoryID

--�r�nlerle, supplier i ba�la
--select * from Products p inner join Suppliers s on p.SupplierID = s.SupplierID

--hangi personel hangi m��teriye hangi tarihte sat�� yapm��t�r (soruda bana s�yl�yor)
--�al��an� al ordera git orderdan customera git
--select e.FirstName + ' '  + e.LastName + ' ' as [Ad Soyad], c.ContactName, o.OrderDate
--from Employees e
--inner join Orders o on e.EmployeeID = o.EmployeeID 
--inner join Customers c on o.CustomerID = c.CustomerID

--hangi personel hangi kategoriden hangi �r�nleri satm��t�r
--order detail, order, product, employee
--select e.FirstName + ' '  + e.LastName + ' ' as [Ad Soyad], p.ProductName, c.CategoryName from Employees e
--inner join Orders o on o.EmployeeID = e.EmployeeID
--inner join [Order Details] od on o.OrderID = od.OrderID
--inner join Products p on p.ProductID = od.ProductID
--inner join Categories c on c.CategoryID = p.CategoryID 

--beverage kategorisine ait stoklarda bulunan �r�nleri raporlay�n�z
--select * from Products p
--inner join Categories c on c.CategoryID = p.CategoryID where p.UnitsInStock != 0 and c.CategoryName = 'Beverages'

--�DEV : Nancy Andrew ve Janet taraf�ndan m��terilerden al�nm�� sipari�lerin Speedy Express ile ta��nmam�� olan sipari�lerin toplam ne kadarl�k kargo �demesi yap�lm��t�r 
--Employees, Shippers, Order
--select  e.FirstName, sum(o.Freight) as [Kargo Toplam�] from Orders o
--inner join Employees e on e.EmployeeID = o.EmployeeID
--inner join Shippers s on s.ShipperID = o.ShipVia
--where e.FirstName in('Nancy', 'Andrew', 'Janet') and s.CompanyName != 'Speedy Express'
--group by e.FirstName


--LEFT JOIN / RIGHT JOIN
--soldaki tablo Categories, soldaki tabloyu baz ald�
--Products sa�daki tablo
--select ProductName from Categories c left join Products p on p.CategoryID = c.CategoryID --77 kay�t var Maske yok -- Categories tablosunu baz ald�
--select ProductName from Categories c right join Products p on p.CategoryID = c.CategoryID --78 kay�t var Maske de ald� --Product tablosunu baz ald�


--1. Hangi �r�n hangi nakliye firmas�yla ta��nm��t�r
--select o.OrderID, p.ProductName,  sh.CompanyName from Products p
--inner join [Order Details] od on p.ProductID = od.ProductID
--inner join Orders o on o.OrderID = od.OrderID
--inner join Shippers sh on sh.ShipperID = o.ShipVia


--2. Hangi tedarik�iden toplam ka� tl lik �r�n sat�lm��t�r
--select s.SupplierID, s.CompanyName, ((1-od.Discount) * (od.UnitPrice*od.Quantity)) as Ciro  from Suppliers s
--left join Products p on s.SupplierID = p.SupplierID
--left join [Order Details] od on od.ProductID = p.ProductID


--3. Kategorilerin toplam sat�� raporlar� 
--select c.CategoryName, sum(Quantity) as [Toplam Sat��] from Categories c 
--inner join Products p on p.CategoryID = c.CategoryID
--inner join [Order Details] od on od.ProductID = p.ProductID
--group by c.CategoryName


--4. Hangi personel hangi �r�n� toplam ka� dolarl�k satm��t�r
--select  e.FirstName + ' '  + e.LastName + ' ' as [Ad Soyad], p.ProductName, sum(((1-od.Discount) * (od.UnitPrice*od.Quantity))) as Ciro 
--from Employees e 
--inner join Orders o on o.EmployeeID = e.EmployeeID
--inner join [Order Details] od on od.OrderID = o.OrderID
--inner join Products p on p.ProductID = od.ProductID
--group by e.FirstName, e.LastName, p.ProductName

--16 DECEMBER 2022

--SQL de Aggregate fonksiyonlarla hesaplama yapt���m�z s�tunlara where c�mlesinde ko�ul ifadesi veremeyiz 
--Ko�ul ifadesi verebilmek i�in HAVING kelimesini kullan�r�z

--Quantity i�in where kulananamam ��nk� ba��nda aggregate var ama Quantity i�in illa da kulanmak istersen HAVING kullanabilirsin
--SELECT p.ProductName, sum(Quantity) as [Siparis Miktar�] FROM [Order Details] od
--INNER JOIN Products p ON p.ProductID = od.ProductID
--GROUP BY p.ProductName
--HAVING sum(Quantity) > 1200 --sipari� miktar� 1200 den b�y�k olanlar� listele
--ORDER BY [Siparis Miktar�] desc

--SQL de yanl�� alt sorgu yazarsan d�ng�y� k�ramazs�n c# taki gibi. 
--Alt alta sorgular� birbirine ba�larken �nceden k���k k���k planlay�p sonra birle�tirmen laz�m.

--250 den fazla sipari� ta��m�� olan kargo firmalar�n�n adlar�n�, telno ve sipari� miktarlar�n� raporla
--Shippers, Orders
--select s.CompanyName, s.Phone, count(o.ShipVia) as [Sipari� Miktar�] from Orders o
--inner join Shippers s on s.ShipperID = o.ShipVia
--group by s.CompanyName, s.Phone
--having count(o.ShipVia) > 250
--order by [Sipari� Miktar�] desc

--birle�tirme fonksiyonu 
--union
--select CompanyName, Phone, 'Suppliers' from Suppliers 
--union 
--select CompanyName, Phone, 'Customers' from Customers

--kesi�imde intersect
--INTERSECT operat�r�, yaln�zca her iki input k�mesinde bulunan sat�rlar� d�nd�r�r. 
--select UnitPrice,ProductID from [Order Details]
--intersect
--select UnitPrice, ProductID from Products
--order by UnitPrice

--fark k�mesi
--except

--Order Details te olup Products ta olmayanlar
--select UnitPrice, ProductID  from [Order Details]
--except 
--select UnitPrice, ProductID  from Products
--order by UnitPrice


--select * from [Order Details] where ProductID = 33
--select * from Products where ProductID = 33



--ASLA KULLANMA!!!!! fazla kay�tta yormu� olursun
--sorgu s�rd�k�e RAM �i�er
--cross koin kartezyen �arp�m�
--8 kategoriyi 78 �r�nle �arpt� toplam 624
--1 kategori 78 �r�n demek
--select ProductName, CategoryName from Products cross join Categories 

--kay�t ekleme
--insert into Shippers(CompanyName, Phone)
--values('Furkan Kargo', 11111189)

--kay�t ekleme, 2.yol
--insert into Shippers
--values('G�ktug Kargo', 89)

--select * from Shippers


--�al��an tablsouna kendini ekle
--insert into Employees

--select * from Employees



--ikisi de ShipperID 5 de�erini getirir 

--identity oturum bazl� �al��m�yor, tablo baz�nda �al���yor
--genellikle identity kullan�l�r
--son ShipperID 5 ise herkes 6 y� al�yor
--select @@IDENTITY --@@demel globali i�aret ediyor demek, a�a��daki herkes globali kullanm�� oluyor

----oturum bazl� �al���r
--select SCOPE_IDENTITY()

--select * from Shippers


--id si 5 olan verinin telefonunu g�ncelle
--update Shippers
--set Phone = '212 333 22 44'
--where ShipperID = 5

--select * from Shippers


---�al��anlar tablosundaki dg tarihini nancy i 01011967 yap  ,city i kastamonu yap
--select * from Employees 
--update Employees
--set BirthDate = '1997-01-01', City = 'Kastamonu'
--where FirstName = 'Nancy'


--yanl��l�kla b�t�n �r�lerin fiyat�n� 50 yapt�m. ba��na begin trans koyarsam geri alma �ans�m var
--sonuna rollback tran
--update yaparken ba��na begin tran koymal�s�n

--select * from Products
--select*from Employees

/*
--1. �al��t�raca��n yer
--begin tran
--update Products set UnitPrice = 50

--2. �al��t�raca��n yer --geri almak i�in
--rollback tran
*/

--begin tran
--update Products set UnitPrice = 50
----update Employees set FirstName = 'Sevde'

--rollback tran


--DELETE ve TRUNCATE i asla kullanm�yorsun
--4 den b�y�k olan ShipperID leri sil
--delete from Shippers where ShipperID > 4


/*
	delete ile silmeyeceksin ama delete i kullanacaks�n
	tablonun sonuna del s�tunu ekle, bit olarak tan�mlayacaks�n hepsi 0 olacak
	sen bir butona sil dedi�in zaman gelip bu s�tunu 1 yapacaks�n
	geri almak istedi�inde 0 yap
	g�ster dedi�in zamanda 0 lar� g�stereceksin
	kullan�c� da g�rmedi�i i�in silini� zannedecek oysaki o veri silinmemi� olacak
*/


--M��teri senden tablo isterse create view kullanabilirsin

--Amerikal�lar diye view var yani sanal tablo. Ben bunu �a��rd���m zaman amerikal� m��terilerim otomatik olarak geliyor
--create view Amerikal�lar 
--as
--Select c.CustomerID, c.CompanyName, o.OrderID, o.OrderDate from Orders o
--inner join Customers c on c.CustomerID = o.CustomerID
--where c.Country = 'USA'

--kontrol
--select * from Amerikal�lar

--bu tablo Views alt�nda olu�uyor


select * from Amerikal�lar a
inner join Orders o on a.OrderID = o.OrderID

select * from Amerikal�lar

