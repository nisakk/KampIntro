--Select
--ANSII

Select ContactName Adi, CompanyName Sirketadi,City Sehir  from Customers

Select * from Customers where Country = 'Germany'
--case insensitive
Select * from Products where categoryID = 1 or CategoryID = 3

Select * from Products where categoryID = 1 and UnitPrice>= 10

Select* from Products order by  CategoryID,ProductName

Select * from  Products where CategoryID= 1 order by UnitPrice desc  --desc artan -- asc azalan

Select count(*) from Products where CategoryID = 2

select CategoryId, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) <10

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice> 10

--DTO Data Transformation object

select * from Products p Left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
