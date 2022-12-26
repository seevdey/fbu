alter proc [dbo].[benimprosedurumodev]
(
	@Id int = null,
	@ProductID1 varchar(50) = null,
	@ProductName varchar(50) = null,
	@UnitPrice varchar(50) = null,
	@UnitsInStock varchar(50)= null,
	@Action varchar(50) = null
)
as begin
if @Action = 'Insert'
insert into Products (ProductName, UnitPrice, UnitsInStock)
values ( @ProductName, @UnitPrice, @UnitsInStock)
if @Action = 'Update'
update Products
set ProductName = @ProductName, UnitPrice= @UnitPrice, UnitsInStock = @UnitsInStock
where ProductID = @ProductID1
if @Action = 'Delete'
begin
delete from [Order Details]  where OrderID = (select p.ProductID from Products p where p.ProductID = @ProductID1)
delete from Products where ProductID = @ProductID1
end
end

