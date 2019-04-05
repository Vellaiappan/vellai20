---Insert Customers---
Insert into Customer(CustomerId,CustomerName,Address,PhoneNumber,Username,Password) values('Cus001','Vellaiappan','Trichy,India',75643245,'vellai20',HASHBYTES('MD5','12345'))
Insert into Customer(CustomerId,CustomerName,Address,PhoneNumber,Username,Password) values('Cus002','Karkulazhi','Trichy,India',23567894,'kk25',HASHBYTES('MD5','54321'))
Insert into Customer(CustomerId,CustomerName,Address,PhoneNumber,Username,Password) values('Cus003','Wang','KualaLumpur,Malaysia',87643689,'wang25',HASHBYTES('MD5','12345'))
Insert into Customer(CustomerId,CustomerName,Address,PhoneNumber,Username,Password) values('Cus004','Yingxuan','Clementi,Singapore',98653256,'ying30',HASHBYTES('MD5','54321'))
select * from Customer
---Insert Products---
Insert into Product values('Prod1','Norton Security','Norton is one of an anti virus software.','~/Photos/virus1.jpg',100)
Insert into Product values('Prod2','Mcafee Antivirus','Mcafee is a leading antivirus software.','~/Photos/virus2.jpg',50)
Insert into Product values('Prod3','Avast','Avast is most used for Internet Security.','~/Photos/virus3.jpg',200)
Insert into Product values('Prod4','Mcafee Total','Mcafee Total protect from all kind of attack.','~/Photos/virus4.jpg',60)
Insert into Product values('Prod5','Kapersky','Kapersky security secure the online transactions.','~/Photos/virus5.jpg',40)
Insert into Product values('Prod6','QuickHeal','QuickHeal removes all kind of virus and attack.','~/Photos/virus6.jpg',30)
select * from product

select * from Purchases