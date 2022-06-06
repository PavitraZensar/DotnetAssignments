create database StudentMangement
use StudentMangement

create table Course(cid int, Name varchar(80), duration varchar(80), cfee int);
insert into Course
values(4,'ARTIFICIAL INTELLIGENCE','40',40000);
create table Student(stdid int, stdname varchar(80), sdob varchar(80));
insert into Student
values(105,'KIM NAMJOON','9/9/1994');
create table Enroll(cid int, stdid int, enrollment varchar(80));

select * from Student
select * from Course
select * from Enroll
