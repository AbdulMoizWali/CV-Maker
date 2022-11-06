create database [CV Maker]

create table Users(
	UserID int primary key,
	RegisterID int
)

create table Register(
	RegisterID int primary key,
	name varchar(20),
	email varchar(50),
	LoginID int
)

create table Login(
	LoginID int primary key,
	username varchar(MAX),
	password varchar(MAX)
)

create table Profile(
	UserID int,
	First_name varchar(50),
	Last_name varchar(50),
	Gender varchar(50),
	Country varchar(50),
	City varchar(50),
	Phone varchar(11),
	Profilepic image,
	SocialID int,
	SocialTitle varchar(20),
	SkillID int,
	SkillTitle varchar(20),
	EducationID int,
	EducationTitle varchar(20),
	Experience_ID int,
	ExperienceTitle varchar(20)
)

create table Social(
	SocialID int,
	Title varchar(20),
	Link varchar(100)
	primary key(SocialID, Title)
)

create table Skills(
	SkillID int,
	Title varchar(20),
	Level int,
	Description varchar(100),
	primary key(SkillID, Title)
)

create table Education(
	EducationID int,
	Title varchar(20),
	City varchar(11),
	Country varchar(11),
	Starting_Date date,
	Ending_Date varchar(11),
	primary key(EducationID, Title)
)

create table Experience(
	Experience_ID int,
	Title varchar(20),
	Company_name varchar(11),
	Description varchar(100),
	Starting_Date date,
	Ending_Date date,
	Job_type varchar(11),
	primary key(Experience_ID, Title)
)









alter table Register add foreign key (LoginID) references Login(LoginID)
alter table Users add foreign key (RegisterID) references Register(RegisterID)
alter table Profile add foreign key (UserID) references Users(UserID)
alter table Profile add unique(UserID)
alter table Profile add foreign key (SocialID,SocialTitle) references Social(SocialID,Title)
alter table Profile add foreign key (SkillID,SkillTitle) references Skills(SkillID,Title)
alter table Profile add foreign key (EducationID,EducationTitle) references Education(EducationID,Title)
alter table Profile add foreign key (Experience_ID,ExperienceTitle) references Experience(Experience_ID,Title)

insert Login values (1,'siddiquegulsher','12345')
insert Login values (2, 'abdulmoiz', '67890')
insert Login values (3, 'khizerzakir', '23456')

select * from Login

insert Register values (1, 'Siddique', 'sp21bsse0033@maju.edu.pk',1)
insert Register values (2, 'Moiz', 'sp21bsse0005@maju.edu.pk',2)
insert Register values (3, 'khizer', 'sp21bsse0033@maju.edu.pk',3)

select * from Register

insert Users values(1,1)
insert Users values(2,2)
insert Users values(3,3)

select * from Users

insert Profile(UserID,First_name,Last_name,Gender,Country,City,Phone,SocialID,SocialTitle,SkillID,SkillTitle,EducationID,EducationTitle,Experience_ID,ExperienceTitle) 
values(1, 'Siddique', 'Gulsher', 'Male', 'Pakistan','Karachi', '03160102314', 1, 'Facebook', 1, 'Web Dveloper', 1, 'Intermediate', 1,'Contant Writer')
insert Profile(UserID,First_name,Last_name,Gender,Country,City,Phone,SocialID,SocialTitle,SkillID,SkillTitle,EducationID,EducationTitle,Experience_ID,ExperienceTitle) 
values(2, 'Abdul', 'Moiz', 'Male', 'Pakistan','Karachi', '03423425256', 2, 'Twitter', 2, 'Excel', 2, 'Intermediate', 2,'Accountent')
insert Profile(UserID,First_name,Last_name,Gender,Country,City,Phone,SocialID,SocialTitle,SkillID,SkillTitle,EducationID,EducationTitle,Experience_ID,ExperienceTitle) 
values(3, 'Khizer', 'Zakir', 'Male', 'Pakistan','Karachi', '03098432353', 3, 'Twitter', 3, 'Graphics Designer', 3, 'Intermediate', 3,'Graphics Designer')

select * from Profile

insert Social values(1, 'Facebook', 'facebook.com')
insert Social values(1, 'Instagram', 'instagram.com')
insert Social values(2, 'Twitter', 'twitter.com')
insert Social values(2, 'Instagram', 'instagram.com')
insert Social values(3, 'Facebook', 'facebook.com')
insert Social values(3, 'Twitter', 'twitter.com')

select * from Social

insert Skills values(1, 'Web Developer','3','Just a simple developer')
insert Skills values(1, 'Contant Writer','4','I Type Fast')
insert Skills values(2, 'Excel','5','Expert in MS excel')
insert Skills values(2, 'Game Developer','3','Can make games in Unity')
insert Skills values(3, 'Graphics Designer','5','Love making art')
insert Skills values(3, 'Php Developer','3','Can make php sites')

select * from Skills

insert Education values(1, 'Intermediate', 'Karachi', 'Pakistan', '11-05-2018', '12-08-2020')
insert Education values(1, 'Matric', 'Makkah', 'KSA', '03-22-2016', '18-11-2017')
insert Education values(2, 'Intermediate', 'Karachi', 'Pakistan', '05-10-2018', '14-11-2020')
insert Education values(2, 'Matric', 'Karachi', 'Pakistan', '04-16-2016', '20-11-2017')
insert Education values(3, 'Intermediate', 'Karachi', 'Pakistan', '03-18-2016', '01-11-2017')
insert Education values(3, 'Matric', 'Karachi', 'Pakistan', '03-30-2016', '03-11-2017')

select * from Education

insert Experience values(1,'Contant Writer', 'OHMit', 'Worked as intern', '08-01-2021', '09-03-2021', 'Off Job')
insert Experience values(2,'Accountent', 'Lalqilla', 'Accounts work for resturant', '02-10-2021', '03-15-2022', 'R Job')
insert Experience values(3,'Graphics Designer', 'Maju', 'Worked as intern', '11-06-2021', '12-10-2021', 'M Job')

select * from Experience

