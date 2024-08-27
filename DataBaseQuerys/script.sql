USE [master]
GO
/****** Object:  Database [SMS2]    Script Date: 27-08-2024 12:44:23 ******/
CREATE DATABASE [SMS2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMS2', FILENAME = N'C:\Users\Owner\SMS2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMS2_log', FILENAME = N'C:\Users\Owner\SMS2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SMS2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMS2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMS2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMS2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMS2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMS2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMS2] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMS2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SMS2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMS2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMS2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMS2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMS2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMS2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMS2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMS2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMS2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SMS2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMS2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMS2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMS2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMS2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMS2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMS2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMS2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SMS2] SET  MULTI_USER 
GO
ALTER DATABASE [SMS2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMS2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMS2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMS2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMS2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SMS2] SET QUERY_STORE = OFF
GO
USE [SMS2]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 27-08-2024 12:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](100) NULL,
	[CourseCode] [varchar](10) NULL,
	[Credits] [int] NULL,
	[Department] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 27-08-2024 12:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[DateOfBirth] [varchar](500) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[Position] [varchar](50) NULL,
	[HireDate] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 27-08-2024 12:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[DateOfBirth] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[EnrollmentDate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27-08-2024 12:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[PasswordHash] [varchar](255) NOT NULL,
	[Email] [varchar](100) NULL,
	[IsActive] [varchar](50) NULL,
	[CreatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (1, N'test', N'test', N'Aug 27 2024 12:40AM', N'male', N'sojat', N'4545455', N'dfgd@fdg.com', N'Aug 27 2024 12:40AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (2, N'pavan', N'soni', N'Aug 27 2024 12:40AM', N'male', N'soajt', N'56456464', N'sdfds@dfd.com', N'Aug 27 2024 12:40AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (3, N'kishan', N'shing', N'Aug 27 2024 12:40AM', N'male', N'pali', N'563434432', N'sdfkjsh@dfd.com', N'Aug 27 2024 12:40AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (4, N'shweta', N'soni', N'Aug 27 2024 12:40AM', N'female', N'pali', N'3904909', N'sdfs@dsfd.com', N'Aug 27 2024 12:40AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (5, N'test123', N'SONI', N'Aug 27 2024 12:40AM', N'female', N'pali', N'07014099600', N'sdfsd@gmail.com', N'Aug 27 2024 12:40AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (6, N'test321', N'SONI', N'Aug 27 2024  1:24AM', NULL, NULL, N'5453432222', N'ewfds@gmail.com', N'Aug 27 2024  1:24AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (7, N'test456', N'SONI', N'Aug 27 2024  1:28AM', NULL, NULL, N'07014099600', N'werwerw@gmail.com', N'Aug 27 2024  1:28AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (8, N'test765', N'SONI', N'Aug 27 2024  1:32AM', NULL, NULL, N'07014099600', N'sdf@gmail.com', N'Aug 27 2024  1:32AM')
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [EnrollmentDate]) VALUES (9, N'shweta', N'soni', N'Aug 27 2024 12:26PM', NULL, NULL, N'07014099600', N'sonipavan160@gmail.com', N'Aug 27 2024 12:26PM')
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [IsActive], [CreatedAt]) VALUES (1, N'pavan', N'12345', N'testing@gmail.com', N'1', NULL)
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [IsActive], [CreatedAt]) VALUES (2, N'test123', N'test123', N'sdfsd@gmail.com', NULL, CAST(N'2024-08-27T01:10:15.100' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [IsActive], [CreatedAt]) VALUES (3, N'test321', N'test321', N'ewfds@gmail.com', NULL, CAST(N'2024-08-27T01:24:18.310' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [IsActive], [CreatedAt]) VALUES (4, N'test456', N'test456', N'werwerw@gmail.com', NULL, CAST(N'2024-08-27T01:28:30.790' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [IsActive], [CreatedAt]) VALUES (5, N'test765', N'test765', N'sdf@gmail.com', NULL, CAST(N'2024-08-27T01:32:13.713' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [IsActive], [CreatedAt]) VALUES (6, N'shweta', N'12345', N'sonipavan160@gmail.com', NULL, CAST(N'2024-08-27T12:26:36.407' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Students__A9D1053414EC968D]    Script Date: 27-08-2024 12:44:25 ******/
ALTER TABLE [dbo].[Students] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentRecords]    Script Date: 27-08-2024 12:44:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudentRecords]
    @StudentId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Retrieve all students if no ID is provided, otherwise retrieve a specific student
    IF @StudentId IS NULL
    BEGIN
        SELECT StudentId, FirstName, LastName, DateOfBirth, Email, phonenumber, Address,EnrollmentDate,Gender
        FROM Students;
    END
    ELSE
    BEGIN
        SELECT StudentId, FirstName, LastName, DateOfBirth, Email, phonenumber, Address,EnrollmentDate,Gender
        FROM Students
        WHERE StudentId = @StudentId;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SaveRegData]    Script Date: 27-08-2024 12:44:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveRegData]
    @FirstName NVARCHAR(50) = null,
    @LastName NVARCHAR(50) =null,
    @DateOfBirth DATE = null,
    @Email NVARCHAR(100) = null,
    @Phone NVARCHAR(20) = NULL,
    @Address NVARCHAR(255) = NULL,
    @Password nvarchar(250)
AS
BEGIN
    INSERT INTO Students (FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address,EnrollmentDate)
    VALUES (@FirstName, @LastName, getdate(), @Email, @Phone, @Address,GETDATE());

    insert into Users(Username,PasswordHash,Email,CreatedAt)
    values (@FirstName,@Password,@Email,GETDATE())
    select 'Success' as flag;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VerifyUser]    Script Date: 27-08-2024 12:44:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VerifyUser]
	@Name varchar(200),
	@Password varchar(200)
AS
begin
	declare @status int
	if exists(select * from Users where Username = @Name and PasswordHash =@Password)
	begin  
		--set @status=1
		select 'Success' as status
	end
	else
	begin
		select 'Failed' as status
	end
	--select @status as status
end
GO
USE [master]
GO
ALTER DATABASE [SMS2] SET  READ_WRITE 
GO
