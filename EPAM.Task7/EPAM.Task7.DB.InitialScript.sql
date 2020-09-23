USE [master]
GO

/****** Object:  Database [EPAM.Task7.DB]    Script Date: 24.09.2020 1:53:12 ******/
CREATE DATABASE [EPAM.Task7.DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EPAM.Task7.DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EPAM.Task7.DB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EPAM.Task7.DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EPAM.Task7.DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EPAM.Task7.DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EPAM.Task7.DB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET ARITHABORT OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EPAM.Task7.DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EPAM.Task7.DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EPAM.Task7.DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EPAM.Task7.DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EPAM.Task7.DB] SET  MULTI_USER 
GO

ALTER DATABASE [EPAM.Task7.DB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EPAM.Task7.DB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EPAM.Task7.DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EPAM.Task7.DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [EPAM.Task7.DB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EPAM.Task7.DB] SET  READ_WRITE 
GO

USE [EPAM.Task7.DB]
GO

/****** Object:  Table [dbo].[Award]    Script Date: 24.09.2020 1:55:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Award](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[ImageURL] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Award] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[User]    Script Date: 24.09.2020 1:55:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[UserImageURL] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[UsersAwards]    Script Date: 24.09.2020 1:55:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UsersAwards](
	[UserId] [int] NOT NULL,
	[AwardId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[AwardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UsersAwards]  WITH CHECK ADD FOREIGN KEY([AwardId])
REFERENCES [dbo].[Award] ([Id])
GO

ALTER TABLE [dbo].[UsersAwards]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO

/****** Object:  StoredProcedure [dbo].[AddAward]    Script Date: 24.09.2020 1:55:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AddAward]
@Title NVARCHAR(50),
@ImageURL NVARCHAR(200)
AS
BEGIN
	INSERT INTO Award(Title, ImageURL)
	VALUES (@Title, @ImageURL)
END
GO

/****** Object:  StoredProcedure [dbo].[AddAwardToUser]    Script Date: 24.09.2020 1:56:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AddAwardToUser]
@awardId int,
@userId int
AS
BEGIN
	INSERT INTO [dbo].[UsersAwards] (UserId, AwardId)
	VALUES (@userId, @awardId)
END
GO

/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 24.09.2020 1:56:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AddUser]
@Name NVARCHAR(50),
@UserImageURL NVARCHAR(200),
@DateOfBirth date
AS
BEGIN
	INSERT INTO [dbo].[User](Name,UserImageURL,DateOfBirth)
	VALUES(@Name, @UserImageURL, @DateOfBirth)
END
GO

/****** Object:  StoredProcedure [dbo].[DeleteAward]    Script Date: 24.09.2020 1:56:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeleteAward]
@Id int
AS
BEGIN
	DELETE FROM [Award] WHERE [Id]=@Id 
END
GO

/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 24.09.2020 1:57:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeleteUser]
@Id int
AS
BEGIN
	DELETE FROM [User] WHERE Id = @Id
END
GO

/****** Object:  StoredProcedure [dbo].[EditAward]    Script Date: 24.09.2020 1:57:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[EditAward]
@Id int,
@Title NVARCHAR(50),
@ImageURL NVARCHAR(200)
AS
BEGIN
	UPDATE [dbo].[Award] SET [Title]=@Title, [ImageURL]=@ImageURL WHERE [Id]=@Id 
END
GO

/****** Object:  StoredProcedure [dbo].[EditUser]    Script Date: 24.09.2020 1:57:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[EditUser]
@Id int,
@Name NVARCHAR(50),
@DateOfBirth date,
@UserImageURL NVARCHAR(200)
AS
BEGIN
	UPDATE [dbo].[User] SET [Name]=@Name, [DateOfBirth]=@DateOfBirth, [UserImageURL]=@UserImageURL WHERE [Id]=@Id 
END
GO

/****** Object:  StoredProcedure [dbo].[GetAllAwards]    Script Date: 24.09.2020 1:57:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetAllAwards]
AS
BEGIN
	SELECT * FROM [Award] 
END
GO

/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 24.09.2020 1:57:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetAllUsers]

AS
BEGIN
	SELECT * FROM [dbo].[User]
END
GO

/****** Object:  StoredProcedure [dbo].[GetAllUsersAndAwards]    Script Date: 24.09.2020 1:58:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[GetAllUsersAndAwards]

AS
BEGIN
	select [Name], [Title] from [User] u
	join [UsersAwards] ua on u.Id = ua.UserId
	join [Award] a on ua.AwardId = a.Id
END
GO

/****** Object:  StoredProcedure [dbo].[GetAwardById]    Script Date: 24.09.2020 1:58:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetAwardById]
@id int
AS
BEGIN
	SELECT * FROM [Award] WHERE [Id]=@id
END
GO

/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 24.09.2020 1:58:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetUserById]
@Id int
AS
BEGIN
	SELECT * FROM [User] WHERE Id=@Id
	
END
GO

















