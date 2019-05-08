
Insert into Tour(ID,Name,Price,Region,MinPax,MaxPax,NumOfPassengers,NumOfDays,DepartureDate,ArrivalDate,Status) 
values('1','4D3N Beijing Muslim Tour',2358,'East Asia',20,30,25,4,'2 Jan 2020','6 Jan 2190','Open')

Insert into Tour(ID,Name,Price,Region,MinPax,MaxPax,NumOfPassengers,NumOfDays,DepartureDate,ArrivalDate,Status) 
values('2','8D7N All Taiwan',3458,'East Asia',20,30,15,8,'3 Jan 2020','11 Jan 2020','Open')

Insert into Tour(ID,Name,Price,Region,MinPax,MaxPax,NumOfPassengers,NumOfDays,DepartureDate,ArrivalDate,Status) 
values('3','10D9N Spectular China',1238,'East Asia',20,30,25,10,'17 Apr 2019','27 Apr 2019','Departed')

INSERT INTO Tour VALUES (4,'10D7N Arctic Autumn Adv With King Crab Safari',5566,'Europe',20,30,22,10,'20200105','20200119',2,null,'Open')

Insert into Tour values
(5,'12D9N Explore Israel And Jordan',4488,'Middle East',20,30,25,12,'20200122','20200203',null,null,'Open'),
(6,'8D South Island Alpine Beauty',3688,'Oceania',20,30,28,8,'20200107','20200119',null,null,'Open'),
(7,'11D South Africa & Victoria Falls',5188,'Africa',20,30,10,11,'20200108','20200125',null,null,'Open')

update Tour set TourLeaderId='1' where ID='3' 
select * from TourLeader

INSERT INTO TourLeader VALUES
(1,'Chen Yingxuan',97580405,'chenyingxuan@gmail.com','F',1000,17,'M3',null,null),
(2,'Kumaresan Karkuzhali',83479173,'karkuzhalikumaresan@gmail.com','P',null,null,null,250,'Middle East, North America'),
(3,'Liu Yang',94826836,'liuyangvip1127@gmail.com','F',1500,18,'M1',null,null),
(4,'Loke Seng Liat',81235321,'sengliat@gmail.com','P',null,null,null,280,'East Asia, Europe'),
(5,'Tan Li Xian',93489302,'lt14430@my.bristol.ac.uk','F',1100,21,'M3',null,null),
(6,'Tan Wei Shan',83718478,'sotong87@gmail.com','P',null,null,null,200,'Oceania, Africa'),
(7,'Tan Yew Vei',94823294,'jeffveiz@hotmail.com','F',1200,15,'M2',null,null),
(8,'Vellaiyappan Lakshmanan Vellaiappan',83247328,'vellai20@gmail.com','P',null,null,null,230,'East Asia, South America'),
(9,'Wang Hongtao',91238478,'wanghongtaonus@gmail.com','F',1300,16,'M2',null,null)

select * from Tour


select * FROM TourLeader where ID not in (select TourLeaderId from Tour where DepartureDate between '21900102' and '21900106' and TourLeaderId is not null)


select * FROM TourLeader where ID not in 
(select TourLeaderId from Tour where DepartureDate between '2/1/2190' and '6/1/2190' and TourLeaderId is not null)

select * FROM TourLeader where ID not in 
                              (select TourLeaderId from Tour where (DepartureDate between '20200106' and '20200122' or ArrivalDate between '20200106' and '20200122' ) and TourLeaderId is not null)

Delete from Tour
Delete from TourLeader
update Tour set TourLeaderId=null where ID='5' 
update Tour set NumOfPassengers=21 where ID='7'

select * from Tour
select * from TourLeader