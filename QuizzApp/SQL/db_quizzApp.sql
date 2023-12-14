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
);

create table highscores
(
userID int,
answer int
);

create table questions (
id int not null primary key identity(1,1),
description varchar(200) not null,

);

create table answers (
id int not null primary key identity(1,1),
text varchar(200) not null,
isCorrect bit not null,
points int not null,
question int not null
);

alter table highscores add foreign key (userID) references users(id);
alter table highscores add foreign key (answer) references answers(id);
alter table answers add foreign key (question) references questions(id);


insert into users(username, userPassword, email) values 
	('Test','test123','matijapavkovic74@gmail.com');

insert into questions (description) values 
	('What is the name of the most decorated warship in naval history?'),
	('Complete the statement: 
			An if statement is a selection statement that allows more than one');

insert into answers (text, isCorrect, points, question) values 
	('HMS Warspite',1,10,1),
	('USS Colorado',0,0,1),
	('KM Scharnhorst',0,0,1),
	('HMS Victory',0,0,1),
	('operation', 0,0,2),
	('possible flow of control', 1,10,2),
	('method call',0,0,2),
	('insanity plea',0,0,2);

insert into highscores (userID, answer) values (1,1),(1,3); 

select * from users; 

select a.username, b.answer, c.points
from users a inner join highscores b on b.userID = a.id
inner join answers c on b.answer = c.id
where c.isCorrect = 1;