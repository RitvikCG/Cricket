create database Cricket;

use Cricket
go

create table country(id int primary key identity(1,1),country_name varchar(30),continent_name varchar(30),country_code varchar(30));


Insert into country values('India','Asia','+91');
Insert into country values('Australia','Australia','+61');
Insert into country values('England','Europe','+44');
Insert into country values('South Africa','Africa','+27');
Insert into country values('New Zealand','Australia','+64');



create table player(id int primary key identity(1,1),player_name varchar(20),player_age int,player_countryid int Foreign Key References country(id));

Insert into player values('Rohit Sharma',29,1);
Insert into player values('Ishan Kishan',34,1)
Insert into player values('Virat Kohli',33,1)
Insert into player values('Dinesh Kartik',25,1)
Insert into player values('Shreyas Iyer',31,1)
Insert into player values('Hardik Pandya',26,1)
Insert into player values('Ravindra Jadeja',33,1)
Insert into player values('Deepak Chahar',30,1)
Insert into player values('Mohd Siraj',30,1)
Insert into player values('Yuzvendra Chahal',29,1)
Insert into player values('Jasprit Bumrah',31,1)

Insert into player values('Jason Roy',26,3);
Insert into player values('Jonny Bairstow',29,3)
Insert into player values('Jos Buttler',32,3)
Insert into player values('Joe Root',35,3)
Insert into player values('Ben Stokes',21,3)
Insert into player values('Eoin Morgan',37,3)
Insert into player values('Moeen Ali',30,3)
Insert into player values('Adil Rasheed',39,3)
Insert into player values('Mark Wood',30,3)
Insert into player values('Ollie Robinson',25,3)
Insert into player values('James Anderson',22,3)

Insert into player values('David Warner',25,2);
Insert into player values('Usman Khwaja',22,2)
Insert into player values('Mitchel Marsh',38,2)
Insert into player values('Steve Smith',28,2)
Insert into player values('Mathew Wade',28,2)
Insert into player values('Glenn Maxwell',29,2)
Insert into player values('Cameron Green',30,2)
Insert into player values('Pat Cummins',39,2)
Insert into player values('Mitchel Starc',20,2)
Insert into player values('Josh Hazelwood',31,2)
Insert into player values('Adam Zampa',29,2)


Insert into player values('Aiden Markram',35,4);
Insert into player values('Quinton de Kock',31,4)
Insert into player values('AB Devilliers',30,4)
Insert into player values('Faf Du Plessis',21,4)
Insert into player values('Rassie VD Dussan',23,4)
Insert into player values('Dwaine Pretorius',38,4)
Insert into player values('Chris Morris',32,4)
Insert into player values('Lungi Ngidi',22,4)
Insert into player values('Imran Tahir',34,4)
Insert into player values('Kagiso Rabada',23,4)
Insert into player values('Tabrez Shamsi',25,4)



Insert into player values('Henry Nicholls',33,5);
Insert into player values('Martin Guptil',22,5)
Insert into player values('Kane Williamson',32,5)
Insert into player values('Mark Chapman',38,5)
Insert into player values('Ros Taylor',21,5)
Insert into player values('James Neesham',22,5)
Insert into player values('Mitchell Santner',23,5)
Insert into player values('Tim Southee',24,5)
Insert into player values('Trent Boult',35,5)
Insert into player values('Ish Sodhi',26,5)
Insert into player values('Lockie Ferguson',27,5)



create table stadium(stadium_id int primary key identity(1,1),stadium_name varchar(20),stadium_matches int,stadium_country int foreign key references country(id));
insert into stadium values('Eden Gardens',3,1);
insert into stadium values('The Gabba',4,2);
insert into stadium values('Manchester Stadium',4,3);
insert into stadium values('Wanderers Stadium',3,4);
insert into stadium values('Bay Oval',3,5);

create table matches(match_id int primary key identity(1,1),stadium_id int foreign key references stadium(stadium_id),team1 int foreign key references country(id),team2 int foreign key references country(id),result varchar(30),date_time datetime,Was_Match_Played varchar(30));
insert into matches values(1,1,4,null,'2022-07-13 20:00:00','yes');
insert into matches values(2,2,3,null,'2022-07-14 20:00:00','yes');
insert into matches values(4,4,5,null,'2022-07-15 20:00:00','yes');
insert into matches values(3,3,1,null,'2022-07-16 15:00:00','yes');
insert into matches values(5,5,3,null,'2022-07-17 20:00:00','yes');
insert into matches values(1,1,2,null,'2022-07-18 15:00:00','yes');
insert into matches values(2,2,5,null,'2022-07-19 20:00:00','yes');
insert into matches values(3,3,4,null,'2022-07-20 20:00:00','yes');
insert into matches values(4,4,2,null,'2022-07-21 20:00:00','yes');
insert into matches values(5,5,1,null,'2022-07-22 20:00:00','yes');

