create table TableA
(
ID int,
tName varchar(30),
gender varchar(10),
department varchar(20))

insert into TableA values(2,'Pranav','Male','IT'),
(1,'Sweety','Female','HR'),
(3,'Jimin','Male','IT')



update tablea set tname='Rajesh',gender='Male' where id=3 and gender='Female'
delete from tableb 
--union
select * from tblEmployee
select count(*) from tblEmployee
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

 select t1.EmpNo,t1.EmpName from tblEmployee t1
 where Salary>(select avg(Salary) from tblEmployee t2 where t1.dNo=t2.dNo)

 select t1.EmpNo,t1.EmpName from tblEmployee t1 inner join 
 (select dNo, avg(Salary) as departmentAverage from tblEmployee 
 group by dNo) as t2 on t1.dNo=t2.dNo
 where t1.Salary > t2.departmentAverage

 --exists: operator to test for existence of rows in the subquery. If found returns boolean true, else false

 --to find employees who have atleast one person reporting to them
 select * from tblEmployee
select EmpNo,EmpName,Job from tblEmployee  t1
 where  exists(select 'x'
 from tblEmployee where Mgr=t1.EmpNo)
 
 -- exists keyword can be alternatively replaced with in keyword as below

select EmpNo,EmpName,Job from tblEmployee  t1
 where EmpNo in (select Mgr
 from tblEmployee where Mgr is not null)

 --not Exists

 --find all departments that do not have employees
select DeptNo, DeptName from tblDepartment where not exists(select 'x' from tblEmployee where tblEmployee.EmpNo = tblDepartment.DeptNo )

 --The above can be replaced with not in 

select DeptNo, DeptName from tblDepartment where DeptNo not in(select dNo from tblEmployee)