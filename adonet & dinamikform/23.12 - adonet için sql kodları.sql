--proc oluþturdum
--her þeyi serverda bitiriyorum. 
create proc [dbo].[benimprosedurum]
(
	@Id int = null,
	@CustomerID1 varchar(50) = null,
	@CompanyName varchar(50) = null,
	@ContactName varchar(50) = null,
	@Country varchar(50) = null,
	@Action varchar(50) = null
)
as begin
if @Action = 'Insert'
insert into Customers (CustomerID, CompanyName, ContactName, Country)
values (@CustomerID1, @CompanyName, @ContactName, @Country)
if @Action = 'Update'
update Customers
set CompanyName = @CompanyName, ContactName= @ContactName, Country = @Country
where CustomerID = @CustomerID1 

--customers ýn baðlý olduðu tablolardan silmelisin
--order detail, order, en son customer ýn içini sileceksin
if @Action = 'Delete'
begin
delete from [Order Details]  where OrderID = (select o.OrderID from Orders o where o.CustomerID = @CustomerID1)
delete from Orders where OrderID = (select o.OrderID from Orders o where o.CustomerID = @CustomerID1)
delete from Customers where CustomerID = @CustomerID1
end
end



