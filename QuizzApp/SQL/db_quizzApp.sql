use master;
go
drop database if exists quizApp;
go
create database quizApp collate croatian_ci_as;
go
use quizApp;

create table users(
id int primary key not null identity (1,1),
username varchar(45) not null,
userPassword varchar(100) not null,
email varchar(100) not null,
highscore int
);

insert into users(username, userPassword, email) values 
	('Test','test123','matijapavkovic74@gmail.com');

select * from users; 