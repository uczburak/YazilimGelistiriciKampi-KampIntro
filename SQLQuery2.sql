--Select 
--ANSI

select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

select * from Customers where City = 'Berlin'

--case insensitive
sElEcT * from Products where CategoryID = 1 or CategoryID = 3

sElEcT * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID = 1 order by UnitPrice desc --ascending --descending

select count(*) from Products where CategoryID = 2


-- her bir kategorideki farklı ürünleri listeleyen sorgu.
select categoryId, count(*) from Products group by CategoryID

select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO / Data transformation Object.

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID