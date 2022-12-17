create database [CV Maker]
use [CV Maker]

/*
CREATE TABLE [User] (
  [UserID] int,
  [RegisterID] int unique,
  [Role] varchar(11),
  PRIMARY KEY ([UserID]),

  CONSTRAINT [FK_User.RegisterID]
    FOREIGN KEY (RegisterID)
      REFERENCES Register(RegisterID)
);
*/




CREATE TABLE [user] (
  [UserID] int identity(1, 1),
  [username] varchar(50),
  [password] varchar(50),
  [register_date] date,
  [Role] varchar(11),
  PRIMARY KEY ([UserID])
);


CREATE TABLE [Profile] (
  [UserID] int unique,
  [First_name] varchar(50),
  [Last_name] varchar(50),
  [Gender] varchar(10),
  [Country] varchar(50),
  [City] varchar(50),
  [Phone] varchar(11),
  [Profilepic] image,
  [ProfileID] int identity(1, 1),
  PRIMARY KEY ([ProfileID]),
  CONSTRAINT [FK_Profile.UserID]
    FOREIGN KEY ([userID])
      REFERENCES [user](UserID)
);



CREATE TABLE [Skills] (
  [ProfileID] int,
  [SkillID] int identity(1, 1),
  [Title] varchar(20),
  [Level] int,
  PRIMARY KEY ([SkillID]),
  CONSTRAINT [FK_Skills.ProfileID]
    FOREIGN KEY ([ProfileID])
      REFERENCES [Profile]([ProfileID])
);

CREATE TABLE [Social] (
  [ProfileID] int,
  [SocialID] int identity(1, 1),
  [Title] varchar(20),
  [Link] varchar(100),
  PRIMARY KEY ([SocialID]),
  CONSTRAINT [FK_Social.ProfileID]
    FOREIGN KEY ([ProfileID])
      REFERENCES [Profile]([ProfileID])
);

CREATE TABLE [login_log] (
  [LoginID] int identity(1, 1),
  [UserID] int,
  [login_time] datetime,
  [logout_time] datetime,
  PRIMARY KEY ([LoginID]),
  CONSTRAINT [FK_login_log.UserID]
    FOREIGN KEY ([UserID])
      REFERENCES [user]([UserID])
);

CREATE TABLE [Experience] (
  [ProfileID] int,
  [ExperienceID] int identity(1, 1),
  [Title] varchar(50),
  [Company_name] varchar(20),
  [Description] varchar(100),
  [Starting_Date] date,
  [Ending_Date] date,
  [Job_type] varchar(20),
  PRIMARY KEY ([ExperienceID]),
  CONSTRAINT [FK_Experience.ProfileID]
    FOREIGN KEY ([ProfileID])
      REFERENCES [Profile]([ProfileID])
);

CREATE TABLE [Education] (
  [ProfileID] int,
  [EducationID] int identity(1, 1),
  [Title] varchar(50),
  [Institute] varchar(50),
  [City] varchar(20),
  [Country] varchar(20),
  [Starting_Date] date,
  [Ending_Date] date,
  PRIMARY KEY ([EducationID]),
  CONSTRAINT [FK_Education.ProfileID]
    FOREIGN KEY ([ProfileID])
      REFERENCES [Profile]([ProfileID])
);

/*
CREATE TABLE [register] (
  [RegisterID] int identity(1, 1),
  [username] varchar(50),
  [password] varchar(50),
  [register_date] date,
  PRIMARY KEY ([RegisterID])
);
*/



---------  User  ---------

create procedure Insert_User @Username varchar(50), @Password varchar(50), @RegisterDate date, @Role varchar(11)
as
insert into [User] values (@Username, @Password, @RegisterDate, @Role)

drop procedure Insert_User

exec Insert_User 'A.Moiz', '12', '10-9-22', 'User'
exec Insert_User 'Siddique', '2', '12-9-22', 'Admin'
exec Insert_User 'khizer', '3', '8-9-22', 'User'

create procedure Search_User_by_UserPass @Username varchar(50), @Password varchar(50)
as
declare @userid int
select @userid = UserID from [User] where username = @Username and password = @Password
return @userid

drop procedure Search_User_by_UserPass

create procedure Delete_User @Userid int
as
declare @ProfileID int
select @ProfileID = ProfileID from Profile where UserID = @Userid
delete from Education where ProfileID = @ProfileID
delete from Experience where ProfileID = @ProfileID
delete from Skills where ProfileID = @ProfileID
delete from Social where ProfileID = @ProfileID
delete from login_log where UserID = @Userid
delete from Profile where ProfileID = @ProfileID
delete from [User] where UserID = @Userid

drop procedure Delete_User

select * from Profile


create procedure Get_ActiveUser
as
select top 1 [User].UserID, [User].username, [User].password, [User].Role, [User].register_date from login_log 
join [User] on [User].UserID = login_log.UserID
order by login_time desc

create procedure Update_User @UserID int, @Password varchar(50)
as
update [User] set password = @Password where UserID = @UserID


exec Get_ActiveUser


--------  Login Logs  --------
create procedure Insert_LoginLogs @Username varchar(50), @Password varchar(50), @LoginTime datetime
as
declare @userid int
exec @userid = Search_User_by_UserPass @Username, @Password
insert into login_log(UserID, login_time) values (@userid, @LoginTime)

exec Insert_LoginLogs 'A.Moiz', '1', '2011-2-25'

drop procedure Insert_LoginLogs

create procedure Insert_LoginLogs_Logouttime
as
declare @LoginID int
set @LoginID = (select top 1 LoginID from login_log order by login_time desc)
update login_log set logout_time = GETDATE() where LoginID = @LoginID

exec Insert_LoginLogs_Logouttime


create procedure Get_LoginLogs
as
select 
[User].UserID,
[User].username,
login_log.login_time,
login_log.logout_time
from login_log
join [User] on login_log.UserID = [User].UserID

drop procedure Get_LoginLogs

exec Get_LoginLogs



----- Profile -----
--insert profile--
create procedure Insert_Profile
@First_Name varchar(50), @Last_Name varchar(50), @Gender varchar(10), @Country varchar(50), @City varchar(50), 
@Phone_Number varchar(11), @Picture image
as
declare @Userid int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
insert into Profile(UserID, First_name, Last_name, Gender, Country, City, Phone, Profilepic) 
values(@Userid, @First_Name, @Last_Name, @Gender, @Country, @City, @Phone_Number, @Picture)

select * from Profile
select ProfileID from Profile where UserID = 3

create procedure Update_Profile
@First_Name varchar(50), @Last_Name varchar(50), @Gender varchar(10), @Country varchar(50), @City varchar(50), 
@Phone_Number varchar(11), @Picture image
as
declare @Userid int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
update Profile set  
First_name = @First_Name, 
Last_name = @Last_Name, 
Gender = @Gender, 
Country = @Country, 
City = @City, 
Phone = @Phone_Number, 
Profilepic = @Picture
where UserID = @Userid







create procedure Get_ActiveUserProfile
as
declare @Userid int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
select * from Profile where UserID = @Userid

exec Get_ActiveUserProfile



/*
create procedure get_last_login_UserID
as
declare @Userid int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
return @Userid

declare @value int
exec @value get_last_login_UserID
print @value
*/
/* ruff work
insert into login_log(UserID, login_time) values(3, GETDATE())
select *  from login_log
declare @Userid int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
print @Userid
*/






insert into login_log(UserID, login_time) values (4, GETDATE())
insert into login_log(UserID, login_time) values (5, GETDATE())

delete from login_log
delete from Profile where ProfileID = 7







--Skills--
--Insert Skill--
create procedure Insert_Skill
@Title varchar(20), @Level int
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
insert into Skills(ProfileID, Title, Level) values(@Profile_ID, @Title, @Level)


create procedure Get_ActiveUserProfile_Skills
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
select Title, Level from Skills where ProfileID = @Profile_ID
--------
--delete Skill
--create procedure Delete_Skill


exec Insert_Skill 'UI design', 2
exec Insert_Skill 'Graphics design', 3




--Education--
--Insert Education
create procedure Insert_Education
@Title varchar(50), @Institute varchar(50), @City varchar(20), @Country varchar(20), @Starting_Date date, @Ending_Date date
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
insert into Education(ProfileID, Title, Institute, City, Country, Starting_Date, Ending_Date)
values(@Profile_ID, @Title, @Institute, @City, @Country, @Starting_Date, @Ending_Date)

create procedure Get_ActiveUserProfile_Education
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
select Title, Institute, City, Country, Starting_Date, Ending_Date from Education where ProfileID = @Profile_ID

exec Insert_Education 'FSC', 'Government college', 'Karachi', 'Pakistan', '14-Dec-2020', '17-Jan-2021'

exec Get_ActiveUserProfile_Education



--Experience--
--Insert Experience
create procedure Insert_Experience
@Title varchar(50), @Company_name varchar(50), @Description varchar(20), @Starting_Date date, @Ending_Date date, @Job_type varchar(20)
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
insert into Experience(ProfileID, Title, Company_name, Description, Starting_Date, Ending_Date, Job_type)
values(@Profile_ID, @Title, @Company_name, @Description, @Starting_Date, @Ending_Date, @Job_type)

create procedure Get_ActiveUserProfile_Experience
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
select Title, Company_name, Description, Starting_Date, Ending_Date, Job_type from Experience where ProfileID=@Profile_ID


exec Insert_Experience 'Intership', 'Maju', 'Kashif nay mujay salary nahi di', '21-sep-2021', '21-oct-2021', 'Part-time'

--Social--
--Insert Social
create procedure Insert_Social
@Title varchar(20), @Link varchar(100)
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
insert into Social(ProfileID, Title, Link) values(@Profile_ID, @Title, @Link)

create procedure Get_ActiveUserProfile_Social
as
declare @Userid int, @Profile_ID int
set @Userid = (select top 1 UserID from login_log order by login_time desc)
set @Profile_ID = (select ProfileID from Profile where UserID = @Userid)
select Title, Link from Social where ProfileID=@Profile_ID

exec Insert_Social 'Instagram', 'Instagram.com'


select * from [User]
select * from Profile
select * from login_log
select * from Education
select * from Experience
select * from Skills
select * from Social
