create database Zensar
use Zensar
create table tblDepartment
(
  DeptNo int primary key,
  DeptName varchar(25)not null,
  Loc varchar(30)
)

insert into tblDepartment
values(10,'ACCOUNTING','NEW YORK' ),
(20,'RESEARCH','DALLAS' ),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON' )



select *
from tblDepartment

create table tblEmployee(EmpNo int primary key,
EmpName varchar(30),
Job varchar(20),
Mgr int,
Hiredate date,
Salary float,
Comm int,
dNo int foreign key references tblDepartment(DeptNo)
)

insert into tblEmployee
values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(769,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,NULL,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
(7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10)

select * from tblEmployee

--1. List all employees whose name begins with 'A'. 
select * from tblEmployee WHERE EmpName LIKE 'A%';

--2. Select all those employees who don't have a manager.
select * from tblEmployee where Mgr is null 

--3.List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select EmpName,EmpNo,Salary from tblEmployee where Salary>=1200 and Salary<=1400;

--4.Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select Salary+Salary*10/100 AS "10% PAYRISE" from tblEmployee where job='PRESIDENT'

--5.Find the number of CLERKS employed. Give it a descriptive heading. 
select Count(*) AS "NUMBER OF CLERKS" from tblEmployee where Job='CLERK' 

--6.Find the average salary for each job type and the number of people employed in each job.
select AVG(Salary) AS "AVG Salary", Count(*) AS "NUMBER OF PEOPLE EMPLOYED IN EACH JOB" from tblEmployee 
group by Job


--7.List the employees with the lowest and highest salary
select EmpName, max(Salary) as MAXSalary, min(Salary) as MinSalary from tblEmployee
group by EmpName

--8.List full details of departments that don't have any employees. 
select * from tblDepartment where DeptNo not in (select dNo from tblEmployee)

--9.Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 10. For each department, list its name and number together with the total salary paid to employees in that department. 
select EmpName,Salary from tblEmployee where Job = 'ANALYST' and dNo = 20 Order by EmpName asc 

--10. For each department, list its name and number together with the total salary paid to employees in that department.
select Job,dNo,SUM(Salary) AS "Total Salary" from tblEmployee 
group by Job,dNo

--11. Find out salary of both MILLER and SMITH.
select EmpName,Salary from tblEmployee where EmpName in ('MILLER','SMITH')


--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select * from tblEmployee WHERE EmpName LIKE 'A%' or EmpName LIKE 'M%'


--13. Compute yearly salary of SMITH. 
select EmpName,Salary*12 as 'Annual Salary' from tblEmployee where EmpName in ('SMITH')


--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select EmpName,Salary from tblEmployee where Salary not between 1500 and 2850





