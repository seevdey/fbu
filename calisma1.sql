--1.Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.
--select CategoryName, Description from Categories order by CategoryName 

--2.Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table sorted by Phone.
--select ContactName, CompanyName, ContactTitle, Phone from Customers order by Phone

--3.Create a report that shows the capitalized FirstName and capitalized LastName renamed as FirstName and Lastname respectively and HireDate from the employees table sorted from the newest to the oldest employee.
--select upper (FirstName) as Ad, upper(LastName) as Soyad,  HireDate from Employees order by HireDate asc

--4.Create a report that shows the top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from the orders table sorted by Freight in descending order.
--select top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from Orders order by Freight desc

--5.Create a report that shows all the CustomerID in lowercase letter and renamed as ID from the customers table.
--select lower(CustomerID) as [ID] from Customers

--6.Create a report that shows the CompanyName, Fax, Phone, Country, HomePage from the suppliers table sorted by the Country in descending order then by CompanyName in ascending order.
--select CompanyName, Fax, Phone, Country, HomePage from Suppliers order by Country desc, CompanyName asc

--7.Create a report that shows CompanyName, ContactName of all customers from ‘Buenos Aires' only.
--select CompanyName, ContactName from Customers where City = 'Buenos Aires'

--8.Create a report showing ProductName, UnitPrice, QuantityPerUnit of products that are out of stock.
--select ProductName, UnitPrice, QuantityPerUnit from Products where Discontinued = 1
--where Discontinued = 1 stokta olmayan ürünler

--9.Create a report showing all the ContactName, Address, City of all customers not from Germany, Mexico, Spain.
--select ContactName, Address, City from Customers where Country not in ('Germany', 'Mexico', 'Spain')

--10.Create a report showing OrderDate, ShippedDate, CustomerID, Freight of all orders placed on 22 August 1996.
--select OrderDate, ShippedDate, CustomerID, Freight from Orders  where OrderDate = '1996-08-22'

--11.Create a report showing FirstName, LastName, Country from the employees not from United States.
--select FirstName, LastName, Country from Employees where Country != 'USA'
--!=  yerine <> kullanabilirsin

--12.Create a report that shows the EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDate from all orders shipped later than the required date.
--gerekli tarihten sonra sipariþ edilen
--select EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDate from Orders where ShippedDate > RequiredDate

--13.Create a report that shows the City, CompanyName, ContactName of customers from cities starting with A or B.
--select City, CompanyName, ContactName from Customers where City like '[A-B]%' order by city desc
--select City, CompanyName, ContactName from Customers where City like 'A%' or City like 'B%' order by city desc

--14.Create a report showing all the even numbers of OrderID from the orders table.
--select * from Orders where OrderID % 2 = 0

--15.Create a report that shows all the orders where the freight cost more than $500.
--select * from Orders where Freight > 500

--16. Create a report that shows the ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel of all products that are up for reorder. --tekrar sipariþ verilmiþ ürünleri listele
--select ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel from Products where ReorderLevel != 0

--17.Create a report that shows the CompanyName, ContactName number of all customer that have no fax number.
--select CompanyName, ContactName from Customers where Fax is not null

--18.Create a report that shows the FirstName, LastName of all employees that do not report to anybody.
--select FirstName, LastName from Employees where ReportsTo is null

--19. Create a report showing all the odd numbers of OrderID from the orders table.
--select OrderID from Orders where OrderID % 2 = 1

--20.Create a report that shows the CompanyName, ContactName, Fax of all customers that do not have Fax number and sorted by ContactName.
--select CompanyName, ContactName, Fax from Customers where Fax is null order by ContactName

--21.Create a report that shows the City, CompanyName, ContactName of customers from cities that has letter L in the name sorted by ContactName.
--select City, CompanyName, ContactName from Customers where City like '%L%' order by ContactName

--22. Create a report that shows the FirstName, LastName, BirthDate of employees born in the 1950s.
--select FirstName, LastName, BirthDate from Employees where BirthDate >= '1950-01-01' and BirthDate < '1960-01-01';
--SELECT FirstName, LastName,BirthDate
--FROM northwind.employees
--where BirthDate Between '1950-01-01'
--AND '1959-12-31';

--23. Create a report that shows the FirstName, LastName, the year of Birthdate as birth year from the employees table.
--select FirstName, LastName, DATENAME(YEAR, BirthDate) as [Doðum Yýlý] from Employees

--24. Create a report showing OrderID, total number of Order ID as NumberofOrders from the orderdetails table grouped
--select OrderID, count(OrderID) as NumberofOrders from [Order Details] group by OrderID order by NumberofOrders desc

--25.Create a report that shows the SupplierID, ProductName, CompanyName from all product Supplied by Exotic Liquids, Specialty Biscuits, Ltd., Escargots Nouveaux sorted by the supplier ID
--select s.SupplierID, p.ProductName, s.CompanyName from Suppliers s
--inner join Products p on s.SupplierID = p.SupplierID
--where s.CompanyName in('Exotic Liquids', 'Specialty Biscuits Ltd.', 'Escargots Nouveaux')
--order by s.SupplierID desc

--26. Create a report that shows the ShipPostalCode, OrderID, OrderDate, RequiredDate, ShippedDate, ShipAddress of all orders with ShipPostalCode beginning with "98124".
--select ShipPostalCode, OrderID, OrderDate, RequiredDate, ShippedDate, ShipAddress from Orders where ShipPostalCode  = '98124'

--27. Create a report that shows the ContactName, ContactTitle, CompanyName of customers that the has no "Sales" in their ContactTitle.
--select ContactName, ContactTitle, CompanyName from Customers where ContactTitle not like '%Sales%'

--28. Create a report that shows the LastName, FirstName, City of employees in cities other "Seattle";
--select LastName, FirstName, City from Employees where City <> 'Seattle'

--29. Create a report that shows the CompanyName, ContactTitle, City, Country of all customers in any city in Mexico or other cities in Spain other than Madrid.
--1
--select CompanyName, ContactTitle, City, Country  from Customers where Country = 'Mexico' or Country =  'Spain' and City  <> 'Madrid'
--2
--SELECT CompanyName, ContactTitle, City, Country
--FROM customers
--WHERE Country IN ('Mexico','Spain')
--AND City <> 'Madrid'

--30. Create a select statement that outputs the following:
--select FirstName + ' '+ LastName + ' can be reached at x ' + Extension as Contactinfo  from Employees

--31.Create a report that shows the ContactName of all customers that do not have letter A as the second alphabet in their Contactname.
--select * from Customers where ContactName not like '_A%'

--32. Create a report that shows the average UnitPrice rounded to the next whole number, total price of UnitsInStock and maximum number of orders from the products table. All saved as AveragePrice, TotalStock and MaxOrder respectively.
--select round(avg(p.UnitPrice), 0 ), sum(p.UnitsInStock) as [Total Stock], MAX(p.UnitsOnOrder) as [Max Order] from Products p 

--33. Create a report that shows the SupplierID, CompanyName, CategoryName, ProductName and UnitPrice from the products, suppliers and categories table.
--select * from Products
--select * from Suppliers
--select * from Categories

--select s.SupplierID, s.CompanyName, p.ProductName, p.UnitPrice, c.CategoryName from Products p
--inner join Suppliers s on p.SupplierID = s.SupplierID
--inner join Categories c on c.CategoryID = p.CategoryID

--34.Create a report that shows the CustomerID, sum of Freight, from the orders table with sum of freight greater $200, grouped by CustomerID. HINT: you will need to use a Groupby and a Having statement.
--select CustomerID, sum(Freight) as [Freight] from Orders
--group by CustomerID
--having sum(Freight) > 200

--35. Create a report that shows the OrderID ContactName, UnitPrice, Quantity, Discount from the order details, orders and customers table with discount given on every purchase.
--select * from [Order Details]
--select * from Orders
--select * from Customers

--select od.OrderID, c.ContactName, od.UnitPrice, od.Discount from [Order Details] od
--inner join Orders o on od.OrderID = o.OrderID
--inner join Customers c on c.CustomerID = o.CustomerID
--where od.Discount != 0


--36. Create a report that shows the EmployeeID, the LastName and FirstName as employee, and the LastName and FirstName of who they report to as manager from the employees table sorted by Employee ID. HINT: This is a SelfJoin.
--select  ee.EmployeeID, ee.FirstName + ' ' + ee.LastName as [Employees] , e.FirstName + ' ' + e.LastName as Manager  from Employees ee
--left join Employees e on e.EmployeeID = ee.ReportsTo
--order by ee.EmployeeID 

--37. Create a report that shows the average, minimum and maximum UnitPrice of all products as AveragePrice, MinimumPrice and MaximumPrice respectively.
--select avg(UnitPrice) as AveragePrice, min(UnitPrice) as MinimumPrice, max(UnitPrice) as  MaximumPrice from Products

--38. Create a view named CustomerInfo that shows the CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Country, Phone, OrderDate, RequiredDate, ShippedDate from the customers and orders table. HINT: Create a View.
--create view CustomerInfo
--as
--select c.CustomerID, c.CompanyName, c.ContactName, c.ContactTitle, c.Address, c.City, c.Country, c.Phone, o.OrderDate, o.RequiredDate, o.ShippedDate from Orders o 
--inner join Customers c on o.CustomerID = c.CustomerID

--select * from Orders
--select * from Customers

--select * from CustomerInfo

--39. Change the name of the view you created from customerinfo to customer details.

--40.Create a view named ProductDetails that shows the ProductID, CompanyName, ProductName, CategoryName, Description, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued from the supplier, products and categories tables. HINT: Create a View
--create view ProductDetails
--as 
--select p.ProductID, s.CompanyName, p.ProductName, c.CategoryName, c.Description, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued from Products p
--inner join Suppliers s on p.SupplierID = s.SupplierID
--inner join Categories c on c.CategoryID = s.SupplierID

--select * from ProductDetails
--select * from Suppliers
--select * from Products
--select * from Categories

--41. Drop the customer details view.
--42. Create a report that fetch the first 5 character of categoryName from the category tables and renamed as ShortInfo
--43. Create a copy of the shipper table as shippers_duplicate. Then insert a copy of shippers data into the new table HINT: Create a Table, use the LIKE Statement and INSERT INTO statement.