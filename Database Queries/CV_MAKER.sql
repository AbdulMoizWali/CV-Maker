create database [CV Maker]

create table User(
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
	UserID varchar(MAX),
	First_name varchar(50),
	Last_name varchar(50),
	Gender varchar(50),
	Country varchar(50),
	City varchar(50),
	Phone varchar(11),
	Profilepic image,
	SocialID int,
	SkillID int,
	EducationID int,
	Experience_ID int
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
	Title varchar(11),
	Company_name varchar(11),
	Description varchar(100),
	Starting_Date date,
	Ending_Date date,
	Job_type varchar(11),
	primary key(Experience_ID, Title)
)