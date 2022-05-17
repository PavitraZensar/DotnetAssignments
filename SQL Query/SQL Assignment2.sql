create database Assign2db
use Assign2db
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


--1. Retrieve a list of MANAGERS.
select * from tblEmployee where Job='MANAGER';

 
--2. Find out salary of both MILLER and SMITH. 
select EmpName,Salary from tblEmployee where EmpName in ('MILLER','SMITH')


--3. Find out the names and salaries of all employees earning more than 1000 per month.
select EmpName,Salary from tblEmployee where Salary>1000
 
--4. Display the names and salaries of all employees except JAMES. 
Select Empname,Salary from tblEmployee
where EmpName !='James'


--5. Find out the details of employees whose names begin with ‘S’. 
select * from tblEmployee WHERE EmpName LIKE 'S%';


--6. Find out the names of all employees that have ‘A’ anywhere in their name. 
select * from tblEmployee WHERE EmpName LIKE '_A%';


--7. Find out the names of all employees that have ‘L’ as their third character in their name. 
select * from tblEmployee WHERE EmpName LIKE '--L%';


--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select * from tblEmployee WHERE EmpName LIKE 'A%' or EmpName LIKE 'M%'



--9. Compute yearly salary of SMITH. 
select EmpName,Salary*12 as 'Annual Salary' from tblEmployee where EmpName in ('SMITH')


--10. Compute daily salary of JONES. 
select EmpName,Salary/30 as 'Daily Salary' from tblEmployee where EmpName in ('JONES')


--11. Calculate the total monthly salary of all employees. 
select EmpName,Salary as 'Monthly Salary' from tblEmployee
group by EmpName


--12. Print the average annual salary. 
Select Avg(Salary*12)/12 as "Avg Annual salary" from tblEmployee



--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
Select  EmpName,Job,Salary,dNo from tblEmployee
Where Job!='SALESMAN' And dNo=30
Select * from tblEmployee

--14. List unique departments of the EMP table. 
Select dNo from tblEmployee
Group by dNo

--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.

Select EmpName as "Employee",Salary as "Monthly salary" from tblEmployee
Where Salary>1500 and dNo in (10,30)
