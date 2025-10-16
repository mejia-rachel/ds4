--ejemplo 1
use "Northwind"
go

select* from Products

--ejemplo2
 Select ProductID, ProductName, UnitPrice From Products

 --ejemplo 3
 select ProductID, ProductName, UnitPrice
 From Products
 Where UnitPrice > 15

 --ejemplo 4
 Select ProductID, ProductName, UnitPrice
 From Products
 Where UnitPrice >= 15 AND UnitPrice <= 50

 --ejemplo 5
 Select ProductID, ProductName, UnitPrice
 From Products
 Where UnitPrice BETWEEN 15 AND 50

 --ejemplo 6
 Select ProductID, ProductName, UnitPrice
 From Products
 Where NOT UnitPrice > 15

 --ejemplo 7
 Select ProductID, ProductName, UnitPrice
 From Products
 Where ProductID > 15 or UnitPrice < 10

 --ejemplo 8
 Select EmployeeID, LastName FROM Employees
 Where LastName LIKE 'D%' 

 --ejemplo 9
 Select EmployeeID, LastName FROM Employees
 Where LastName LIKE '%N'

 --ejemplo 10
 Select EmployeeID, LastName, Title FROM Employees
 Where Title LIKE '%SALES%'

 --ejemplo 11
 Select EmployeeID, LastName FROM Employees
 Where LastName NOT LIKE 'D%'

--ejemplo 12
select ProductID, ProductName, UnitPrice
From Products
Order By ProductID ASC

--ejemplo 13
select ProductID, ProductName, UnitPrice
From Products
Order By ProductID DESC

--ejemplo 14
Select Distinct OrderID From [Order Details]

--ejemplo 15
select top 5 OrderID, ProductID, Quantity
From [Order Details]

--ejemplo 16
Select top 10 PERCENT OrderID, ProductID, Quantity
From [Order Details]

--ejemplo 17
Select CategoryName AS [Nombre de Categoria]
From Categories

--ejemplo 18
Select OrderId, OrderDate, ShippedDate, ShippedDate + 5 AS RetrasoEnvio
From Orders

--ejemplo 19
Select OrderID, P.ProductID, ProductName
From Products P
INNER JOIN [Order Details] OD
ON P.ProductID=OD.ProductID

--ejemplo 20
Select ProductName, CompanyName, ContactName
From Products P
Full JOIN Suppliers S
On P.SupplierID=S.SupplierID






