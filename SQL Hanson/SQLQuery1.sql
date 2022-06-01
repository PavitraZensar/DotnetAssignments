create table TableB
(
ID int,
tName varchar(30),
gender varchar(10),
department varchar(20))

insert into tableB values(1,'Pranav','Male','IT'),
(3,'Preethi','Female','HR'),
(4,'Anurag','Male','IT')



update tablea set tname='Rajesh',gender='Male' where id=2 and gender='Female'
delete from tableb 
--union
select * from Tablea
select * from tableb

select Id,tname,gender,department from tableA
except
select ID,tname,gender,department from tableB

--tsql with while, and continue
declare @ctr int=1
while(@ctr <=20)
begin
if @ctr % 2 =1
 begin
  set @ctr=@ctr +1
  continue
  end
print 'The counter value is= ' + convert(varchar,@ctr)
 set @ctr= @ctr + 1
end

--tsql with while and break
declare @ctr int
set @ctr=1
while(@ctr <=10)
begin
 print 'The counter Value is :' + cast(@ctr as varchar)
 if @ctr>=6
 break
 set @ctr=@ctr+1
 end

 select t1.Empid,t1.Empname from tblEmployee t1
 where salary>(select avg(Salary) from tblEmployee t2 where t1.DId=t2.DId)

 select t1.empid,t1.empname from tblEmployee t1 inner join 
 (select did, avg(salary) as departmentAverage from tblEmployee 
 group by did) as t2 on t1.did=t2.did
 where t1.Salary > t2.departmentAverage

 --exists: operator to test for existence of rows in the subquery. If found returns boolean true, else false

 --to find employees who have atleast one person reporting to them
 select * from tblEmployee
select empno,EmpName,Job from tblEmployee
 where  exists(select 'x'
 from emp where Mgr=tblEmployee)
 
 -- exists keyword can be alternatively replaced with in keyword as below

 select empno,ename,job from tblEmployee
 where empno in (select mgrid
 from emp where mgrid is not null)

 --not Exists

 --find all departments that do not have employees
select deptno, deptname from dept where not exists(select 'x' from emp where emp.deptno = dept.DeptNo )

 --The above can be replaced with not in 

select dNo, DeptName from tbldepartment where dNo not in(select deptno from emp)