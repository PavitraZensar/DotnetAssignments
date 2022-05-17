create database sqlExam02;
use sqlExam02;
create table Emptble(
Empid int not null,
Name varchar(55),
Salary int,
Deptno int);
insert into Emptble values(1,'Rama',5000,10);
insert into Emptble values(2,'Sita',15000,20);
insert into Emptble values(3,'Padma',45000,30);
select * from Emptble;