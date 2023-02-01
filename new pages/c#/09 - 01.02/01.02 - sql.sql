create view vw_MusterileriGetir
as
select c.CompanyName, c.City, c.Country, c.Phone from Customers c

select * from vw_MusterileriGetir





create proc sp_MusterileriGetir
as
select c.CompanyName, c.City, c.Country, c.Phone from Customers c

exec sp_MusterileriGetir



create proc sp_KategoriEkle
(
	@catName nvarchar(50),
	@desc nvarchar(50)
)
as
insert Categories (CategoryName, Description) values (@catName,@desc)