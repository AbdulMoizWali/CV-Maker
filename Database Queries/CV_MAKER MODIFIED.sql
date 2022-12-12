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

exec Insert_User 'A.Moiz', '1', '10-9-22', 'Admin'
exec Insert_User 'Siddique', '2', '12-9-22', 'Admin'
exec Insert_User 'khizer', '3', '8-9-22', 'User'




--------  Login Logs  --------
create procedure Insert_LoginLogs @UserID int, @LoginTime datetime, @LogoutTime datetime
as
insert into login_log values (@UserID, @LoginTime, @LogoutTime)


create procedure Get_LoginLogs
as
select 
CONCAT(Profile.First_name, ' ', Profile.Last_name) as [Username],
login_log.login_time,
login_log.logout_time
from login_log
join [User] on login_log.UserID = [User].UserID
join Profile on [User].UserID = Profile.UserID


-------- User  ---------
/*create procedure Insert_User 
insert into [User] values ()*/




