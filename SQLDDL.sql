--Q1--
create table MemberCategories(MemberCategory nvarchar(2) not null primary key,MemberCatDescription nvarchar(200) not null)
--Drop table MemberCategories--
--Q2--same like A and B
Insert into MemberCategories values ('C','Class C Members')
--Q3--
create table GoodCustomers(CustomerName nvarchar(50) not null,
						   Address nvarchar(65),
						   PhoneNumber nvarchar(9) not null,
					       MemberCategory nvarchar(2),
						   Primary key(CustomerName,PhoneNumber),
						   Foreign key(MemberCategory) references MemberCategories(MemberCategory)
						   )
--Q4--
Insert into GoodCustomers(CustomerName,Address,PhoneNumber,MemberCategory) select CustomerName,null,PhoneNumber,MemberCategory from Customers where MemberCategory in (Select MemberCategory from MemberCategories)
select * from GoodCustomers
--select CustomerName,Address,PhoneNumber,MemberCategory from Customers where Customerid=5108
--update Customers set PhoneNumber=65897450 where CustomerName='Janine Labrune' and MemberCategory='C'
--Q5--
Insert into GoodCustomers(CustomerName,PhoneNumber,MemberCategory) values('Tracy Tan',736572,'B')
--Q6--
Insert into GoodCustomers values('Grace Leong','15 Bukit Purmei Road, Singapore 0904',278865,'A')
--Q7--
Insert into GoodCustomers values('Lynn Lim','15 Bukit Purmei Road, Singapore 0904',278865,'P')
--Q8--
Update GoodCustomers set Address='22 Bukit Purmei Road, Singapore 0904' where CustomerName='Grace Leong'
--Q9--
Update GoodCustomers set MemberCategory='B' where CustomerName=(Select CustomerName from Customers where CustomerID=5108) and PhoneNumber=(Select PhoneNumber from Customers where CustomerID=5108)
--Q10--
Delete from GoodCustomers where CustomerName='Grace Leong'
--Q11--
Delete from GoodCustomers where MemberCategory='B'
--Q12--
Alter table GoodCustomers add FaxNumber nvarchar(25)
--Q13--
Alter table GoodCustomers alter column Address nvarchar(80)
--Q14--
Alter table GoodCustomers add ICNumber nvarchar(10)
--Q15--
Create unique index ICIndex on GoodCustomers(ICNumber) 
--Q16--
create index FaxIndex on GoodCustomers(FaxNumber) 
--Q17--
Drop index FaxIndex on GoodCustomers
--Q18--
Alter table GoodCustomers drop column FaxNumber
--Q19--
Delete from GoodCustomers
--Q20--
Drop table GoodCustomers
