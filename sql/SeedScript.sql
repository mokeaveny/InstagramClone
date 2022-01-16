USE MASTER 
GO
DROP DATABASE IF EXISTS InstagramClone
GO

CREATE DATABASE InstagramClone
GO

USE InstagramClone
GO

CREATE TABLE [dbo].[Users] (
	Id int IDENTITY PRIMARY KEY,
	Username varchar(15) NOT NULL UNIQUE,
	Email varchar(50) NOT NULL UNIQUE,
	Forename varchar(20) NOT NULL,
	Surname varchar(20) NOT NULL,
	Age int,
	Rating decimal(4, 2)
)

CREATE TABLE [dbo].[Posts] (
	Id int IDENTITY PRIMARY KEY,
	UserId int FOREIGN KEY REFERENCES Users(Id),
	Image varbinary(max) NOT NULL,
	Caption varchar(2200)
)

CREATE TABLE [dbo].[Comments] (
	Id int IDENTITY PRIMARY KEY,
	PostId int FOREIGN KEY REFERENCES Posts(Id) ON DELETE CASCADE,
	AuthorId int FOREIGN KEY REFERENCES Users(Id) ON DELETE CASCADE,
	Message varchar(2200) NOT NULL
)

INSERT INTO dbo.Users(Username, Email, Forename, Surname, Age, Rating)
VALUES ('mokeaveny', 'mokeav@test.co.uk', 'Michael', 'Keaveny', 21, 5.00)

INSERT INTO dbo.Users(Username, Email, Forename, Surname, Age, Rating)
VALUES ('testapi', 'testapi@gmail.co.uk', 'Magic', 'Amazing', 35, 3.82)

INSERT INTO dbo.Users(Username, Email, Forename, Surname, Age, Rating)
VALUES ('jhalpert', 'jhalpert00@dmifflin.com', 'Jim', 'Halpert', 28, 4.50)

INSERT INTO dbo.Posts(UserId, Image, Caption)
VALUES (1, 0xFFD8FFE000104A6494600001001, 'First Picture!')

INSERT INTO dbo.Posts(UserId, Image, Caption)
VALUES (2, 0xFFD8FFE000104A6494600001001, 'Placeholder For Now!')

INSERT INTO dbo.Posts(UserId, Image, Caption)
VALUES (3, 0xFFD8FFE000104A6494600001001, 'Remember To Insert Proper Values')

INSERT INTO dbo.Comments(PostId, AuthorId, Message)
VALUES(1, 3, 'Nice Post Mate!');

INSERT INTO dbo.Comments(PostId, AuthorId, Message)
VALUES(2, 1, 'Wow, I love this!');

INSERT INTO dbo.Comments(PostId, AuthorId, Message)
VALUES(3, 1, 'Amazing! Keep smashing it bro!');

USE MASTER
GO

CREATE LOGIN [instagramclone_dbuser] WITH PASSWORD=N'Sql1nContainersR0cks!', CHECK_EXPIRATION=OFF, CHECK_POLICY=ON;
GO
USE InstagramClone;
GO
CREATE USER [instagramclone_dbuser] FOR LOGIN [instagramclone_dbuser];
GO
EXEC sp_addrolemember N'db_owner', [instagramclone_dbuser];
GO