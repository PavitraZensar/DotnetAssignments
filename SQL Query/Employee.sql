create database Zensardb
use Zensardb

create table tbldepartment
(
  DeptId int primary key,
  DeptName varchar(20)not null,
  Loc_city varchar(15)
)

insert into tbldepartment
values(1,'IT','Hyderabad'),
(2,'HR','Pune'),
(3,'Admin','Banglore')


select *
from tbldepartment

create table tblEmployee(Empid int primary key,
EmpName varchar(30),
Gender char(7),
Salary float,
Email varchar(30) unique,
dId int foreign key references tbldepartment(DeptId)
)


insert into tblEmployee
values(101,'Rama','Male',5000,'Rama@zenasar.com',1),
(102,'Seeta','Female',6000,'Seeta@gmail.com',1),
(103,'Radha','Female',7000,'Radha@hotmail.com',2)


select * from tblEmployee
select * from tblEmployee where DId=1
select EmpName,Salary,Gender from tblEmployee where gender='Female'
select * from tblEmployee where salary>=6000
select * from tblEmployee where salary >6000 or salary =6000
select * from tblEmployee where salary >=5000 and salary <=6000 
select * from tblEmployee where salary between 5000 and 6000
select * from tblEmployee where salary not between 5000 and 6000
select * from tblEmployee where EmpName is null 
select * from tblEmployee where EmpName is not null 
select Empname,Salary+500 from tblEmployee
select Empname,Salary*12 from tblEmployee
select Empname,Salary*12 as 'Annual Salary' from tblEmployee
select Empname EmployeeName from tblemployee
select top 3 * from tblEmployee
select top 10 percent Empname,Salary from tblemployee
select * from tblEmployee where Empname like 'A%' 
select * from tblEmployee where empname like '%a'
select * from tblEmployee where empname like '_k%'
select * from tblEmployee where empname like '_i_h%'
select * from tblEmployee where empname like '_[are]%'
select * from tblEmployee where empname like '_[^are]%'
select * from tblEmployee where empname like 'A[^k]%'



insert into tblDepartment(DeptId,DeptName,Loc_city)
values(8,'Business Analyst','USA')

DELETE FROM tbldepartment WHERE 
DeptId='6';

insert into tblEmployee(Empid,EmpName,Gender,Salary,Email,dId)
values(107,'Nikitha','Female',11000,'Nikitha@zenasar.com',5)

DELETE FROM tblEmployee WHERE 
Empid='107';

alter table tblEmployee add Phoneno varchar(15)

update tblemployee set Phoneno='7777777777' where EmpName='Nikitha'


select Gender, count(gender)Total from tblEmployee
group by gender
--restricting groups using having clause
select Gender, count(gender)Total from tblEmployee
group by gender
having count(gender)>0
 
--the above can also be achieved as below
select Gender, count(gender)Total from tblEmployee
where gender is not null
group by gender
 
select * from tblEmployee
--display department wise highest salary
 select did, max(salary) from tblemployee
 group by did
 

 select DeptName,max(salary) from tblEmployee,tbldepartment
where tblEmployee.DId=tbldepartment.DeptId
group by DeptName

Select Gender,count(Gender) from tblEmployee where dId=2
Group by Gender



--Joins
--1. Equi Join/Natural/inner join
--2. Cross Join (cartesan product)
--3. outer join
    --1.left outer
    --2.right outer
    --3.full outer
--4. self join
--1.
Select * from tblEmployee join tbldepartment on tblEmployee.DId=tbldepartment.DeptId
--2.
select tblEmployee.EmpName,tblEmployee.Salary,tbldepartment.DeptName from
tblEmployee join tbldepartment on tblEmployee.DId=tbldepartment.DeptId
--3.
select t1.Empname,t1.salary,t2.deptname from tblEmployee t1 join tbldepartment t2
on t1.DId=t2.DeptId
 
select * from tblEmployee t1 join tbldepartment t2
on t1.DId=t2.DeptId
--left outer join
select * from tblEmployee t1 left outer join tbldepartment t2
on t1.DId=t2.DeptId
 
select * from tblEmployee t1 right outer join tbldepartment t2
on t1.DId=t2.DeptId
 
select * from tblEmployee t1 full  join tbldepartment t2
on t1.DId=t2.DeptId