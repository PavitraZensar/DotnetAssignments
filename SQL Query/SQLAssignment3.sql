use Assign2db


select * from tblDepartment
select * from tblEmployee


--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select EmpName,Salary from tblEmployee where Salary not between 1500 and 2850


--2. Display the name and job of all employees who do not have a MANAGER. 
select EmpName,Job from tblEmployee where Mgr is null 


--3. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select * from tblEmployee where Salary ! = 1000 and Salary != 3000 and Salary != 5000  and Job = 'CLERK' or Job= 'MANAGER'

--4. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 


--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select * from tblEmployee where EmpName = 'MILLER' AND (dNo = 30 AND Mgr = 7782)



--6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees. 
select count(*) as No_of_employees,EmpName from tblEmployee
where CONVERT(varchar(3),DATEDIFF(Year,HireDate,getdate()))>10
And CONVERT(varchar(3),DATEDIFF(Year,HireDate,getdate()))>20
Group By EmpName

--7. Retrieve the names of departments in ascending order and their employees in descending order. 
Select DeptName,EmpName
From tblEmployee join tblDepartment on tblemployee.dNo=tblDepartment.DeptNo
order by DeptName Asc,EmpName desc

--8. Find out experience of MILLER. 1982-01-23
select DATEDIFF(YYYY,'1982-01-23','2022/05/30') AS DOB_NO_OF_YEARS

--9. How many different departments are there in the employee table. 
select count(*) as "Different departments" , dNo from tblEmployee
group by dNo


--10. Find out which employee either work in SALES or RESEARCH department. 
select * from tblEmployee
where dNo in(select dNo from tblDepartment
where DeptName in ('SALES','RESEARCH'))

--11. Print the name and average salary of each department. 
select EmpName,dNo, AVG(Salary) AS "AVG Salary" from tblEmployee
group by dNo,EmpName 


--12. Select the minimum and maximum salary from employee table. 
select EmpName, max(Salary) as MAXSalary, min(Salary) as MinSalary from tblEmployee
group by EmpName


--13. Select the minimum and maximum salaries from each department in employee table. 
select dNo, max(Salary) as MAXSalary, min(Salary) as MinSalary from tblEmployee
group by dNo

--14. Select the details of employees whose salary is below 1000 and job is CLERK. 
select * from tblEmployee where Salary<1000 and Job = 'CLERK'