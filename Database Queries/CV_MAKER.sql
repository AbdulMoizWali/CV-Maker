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