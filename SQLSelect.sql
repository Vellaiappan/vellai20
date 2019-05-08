--Q1a--
select * from Shippers
--Q1b--
select * from Shippers order by CompanyName --Desc--
--Q2a--
select FirstName,LastName,Title,BirthDate,City from Employees
--Q2b--
select distinct Title from Employees
--Q3--
select * from [Order Details] where OrderID in (select OrderID from Orders where OrderDate='19 May 1997')
select * from Orders where OrderDate='19 May 1997'
--Q4--
select * from Customers where city='London' or city='Madrid' 
--Q5--
select CustomerID,CompanyName from Customers where Country='UK' order by ContactName
--Q6--
 select OrderID,OrderDate from Orders where CustomerID='Hanar'
 --Q7--
 select Titleofcourtesy+' '+FirstName+' '+LastName from Employees
 --Q8--
 select OrderID,OrderDate from Orders where CustomerID in (select CustomerID from Customers where CompanyName='Maison Dewey')
 --Q9--
 select * from Products where ProductName Like '%lager%'
 --Q10--
 select CustomerID,ContactName from Customers where CustomerID not in(select CustomerID from Orders)
 --Q11-
 select avg(UnitPrice) from Products
 --Q12--
 select distinct city from Customers where City is not null
 --Q13--
 select count(distinct CustomerId) from Orders
 --Q14--
 select companyname,phone from customers where fax is null
 --Q15--
 select sum(unitprice*quantity) from [Order Details]
 --Q16--
 select orderid from Orders where CustomerId in (select CustomerID from Customers where CompanyName='Alan Out' or CompanyName='Blone Coy')
 --Practise--
 SELECT o.CustomerID FROM orders o GROUP BY CustomerID
 SELECT o.CustomerID, count(*), count(o.orderId) FROM orders o GROUP BY CustomerID
 SELECT CustomerID, orderId FROM orders  GROUP BY CustomerID
 --finish--
 --Q17--
 select Customers.CustomerId,Count(OrderId) As TotalOrders from Orders,Customers where Customers.CustomerID=Orders.CustomerID Group By Customers.CustomerID
 --Q18--
 select CompanyName,OrderID from Orders,Customers where Customers.CustomerID='BONAP' And Customers.CustomerID=Orders.CustomerID
 --select Customers.CompanyName,Count(OrderId) As TotalOrders from Orders,Customers where Customers.CustomerID='BONAP' And Orders.CustomerID='BONAP' Group By Customers.CompanyName --
 --Q19a--
 select count(OrderId) as OrderCount,Customers.CustomerID,companyname from Orders,Customers where Customers.CustomerID=Orders.CustomerID Group By Customers.CustomerID,CompanyName having Count(OrderId)>10 Order By OrderCount Desc   
 --Q19b--
 select count(OrderId) as OrderCount,Customers.CustomerID,companyname from Orders,Customers 
 where Customers.CustomerID='BONAP' And Customers.CustomerID=Orders.CustomerID 
 Group By Customers.CustomerID,CompanyName
--Q19c--
 select count(OrderId) as OrderCount,Customers.CustomerID,companyname from Orders,Customers 
 where Customers.CustomerID=Orders.CustomerID Group By Customers.CustomerID,CompanyName 
 having count(OrderId)>(select count(orderId) from Orders where CustomerID='BONAP')
 --Q20a--
 select p.*,c.CategoryID,c.CategoryName from Products p,Categories c 
 where (p.CategoryID=1 or p.CategoryID=2) and p.CategoryID=c.CategoryID 
 order by ProductID,ProductName
 --Q20b--
 select p.*,c.CategoryID,c.CategoryName from Products p,Categories c 
 where (c.CategoryName='Beverages' or c.CategoryName='Condiments') and p.CategoryID=c.CategoryID 
 order by ProductName,ProductID
 --Q21a--
 select Count(*) as totalemployees from Employees
 --Q21b--
 select count(*) as USAEmployees from Employees where Country='USA'
 --Q22--
 select * from orders 
 where EmployeeID in (select EmployeeID from Employees where Title='Sales Representative') and ShipVia=(select ShipperID from Shippers where CompanyName='United Package')
 --Q23--
 select Employee.TitleOfCourtesy+' '+Employee.FirstName+' '+Employee.LastName As EmployeeName,
 Manager.TitleOfCourtesy+' '+Manager.FirstName+' '+Manager.LastName As Manager  
 from Employees Employee,Employees Manager 
 where Employee.ReportsTo=Manager.EmployeeID
 --Q24--
 select  o.ProductID,p.ProductName,Sum(o.UnitPrice*o.Quantity) as TotalPrice,sum((o.UnitPrice*o.Quantity)-(o.UnitPrice*Quantity*Discount)) As DiscountedPrice,sum(o.UnitPrice*Quantity*Discount) as DiscountAmount from [Order Details] o,Products p
 where o.ProductID=p.ProductID
 group by o.ProductID,P.ProductName order by DiscountedPrice Desc

 select * from [Order Details] where ProductID=38

 --Q25--
 select CustomerId,c.CompanyName,City from Customers c where City not in (select city from Suppliers )
 --Q26--
 select City from Customers c where City in (select city from Suppliers )
 --Q27a--
 select CompanyName,Address,Phone from Customers
 UNION
 select CompanyName,Address,Phone from Suppliers
 --Q27b--
 select CompanyName,Address,Phone from Customers
 UNION
 select CompanyName,Address,Phone from Suppliers
 UNION
 select CompanyName,null as Address,Phone from Shippers 
 --Q28--
 select
 Manager.TitleOfCourtesy+' '+Manager.FirstName+' '+Manager.LastName As Manager  
 from Employees Manager 
 where Manager.EmployeeID=(select ReportsTo from Employees where EmployeeID=(select EmployeeId from Orders where OrderId=10248))
 --Q29--
 select ProductId,ProductName from Products where UnitPrice>(select avg(unitprice) from Products)
--Q30--
select OrderId,Sum(UnitPrice*Quantity) as totalprice from [Order Details] group by OrderID having Sum(UnitPrice*Quantity)>10000
--Q31--
select o.OrderId,CustomerId,Sum(UnitPrice*Quantity) from Orders o,[Order Details] od 
where o.OrderID=od.OrderID group by o.OrderID,CustomerID
having Sum(UnitPrice*Quantity)>10000
--Q32--
select o.OrderId,o.CustomerId,c.CompanyName,Sum(UnitPrice*Quantity) from Orders o,[Order Details] od,Customers c 
where o.OrderID=od.OrderID and o.CustomerID=c.CustomerID group by o.OrderID,o.CustomerID,CompanyName
having Sum(UnitPrice*Quantity)>10000
--Q33--
select CustomerId,sum(Quantity*UnitPrice) as TotalAmount from Orders,[Order Details] where orders.OrderID=[Order Details].OrderID Group by CustomerID
--Q34--
select sum(Quantity*UnitPrice),count(Distinct CustomerID),sum(Quantity*UnitPrice)/count(Distinct CustomerID) as TotalAmount from Orders,[Order Details] where orders.OrderID=[Order Details].OrderID
--Q35--
select o.CustomerId,c.CompanyName,Sum(UnitPrice*Quantity) from Orders o,[Order Details] od,Customers c 
where o.OrderID=od.OrderID and o.CustomerID=c.CustomerID group by o.CustomerID,CompanyName
having Sum(UnitPrice*Quantity)>(select sum(Quantity*UnitPrice)/count(Distinct CustomerID) from Orders,[Order Details] where orders.OrderID=[Order Details].OrderID)
--Q36--
select CustomerId,sum(Quantity*UnitPrice) as TotalAmount from Orders,[Order Details] 
where orders.OrderID=[Order Details].OrderID And year(OrderDate)=1997 Group by CustomerID

