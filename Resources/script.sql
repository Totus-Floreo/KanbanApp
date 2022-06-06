USE [master]
GO
/****** Object:  Database [KanbanDB]    Script Date: 6/6/2022 12:33:31 PM ******/
CREATE DATABASE [KanbanDB]
GO
USE [KanbanDB]
GO
ALTER DATABASE [KanbanDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KanbanDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KanbanDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KanbanDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KanbanDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KanbanDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KanbanDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KanbanDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KanbanDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KanbanDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KanbanDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KanbanDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KanbanDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KanbanDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KanbanDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KanbanDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KanbanDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KanbanDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KanbanDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KanbanDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KanbanDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KanbanDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KanbanDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KanbanDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KanbanDB] SET RECOVERY FULL 
GO
ALTER DATABASE [KanbanDB] SET  MULTI_USER 
GO
ALTER DATABASE [KanbanDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KanbanDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KanbanDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KanbanDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KanbanDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KanbanDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [KanbanDB] SET QUERY_STORE = OFF
GO
USE [KanbanDB]
GO
/****** Object:  Table [dbo].[Kanbans]    Script Date: 6/6/2022 12:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kanbans](
	[kanbanID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kanbans] PRIMARY KEY CLUSTERED 
(
	[kanbanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 6/6/2022 12:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[statusID] [int] IDENTITY(1,1) NOT NULL,
	[kanbanID] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 6/6/2022 12:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[taskID] [int] IDENTITY(1,1) NOT NULL,
	[kanbanID] [int] NOT NULL,
	[statusID] [int] NOT NULL,
	[toolID] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[taskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tools]    Script Date: 6/6/2022 12:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tools](
	[toolID] [int] IDENTITY(1,1) NOT NULL,
	[kanbanID] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tools] PRIMARY KEY CLUSTERED 
(
	[toolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/6/2022 12:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](150) NOT NULL,
	[birthdate] [date] NOT NULL,
	[joindate] [date] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersKanbans]    Script Date: 6/6/2022 12:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersKanbans](
	[userID] [int] NOT NULL,
	[kanbanID] [int] NOT NULL,
 CONSTRAINT [PK_UsersKanbans] PRIMARY KEY CLUSTERED 
(
	[userID] ASC,
	[kanbanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kanbans] ON 

INSERT [dbo].[Kanbans] ([kanbanID], [name]) VALUES (1, N'test')
INSERT [dbo].[Kanbans] ([kanbanID], [name]) VALUES (2, N'test2')
SET IDENTITY_INSERT [dbo].[Kanbans] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([statusID], [kanbanID], [name]) VALUES (1, 1, N'work')
INSERT [dbo].[Status] ([statusID], [kanbanID], [name]) VALUES (2, 1, N'done')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([taskID], [kanbanID], [statusID], [toolID], [name]) VALUES (1, 1, 1, 1, N'Create program')
INSERT [dbo].[Tasks] ([taskID], [kanbanID], [statusID], [toolID], [name]) VALUES (2, 1, 2, 2, N'Create DB')
SET IDENTITY_INSERT [dbo].[Tasks] OFF
GO
SET IDENTITY_INSERT [dbo].[Tools] ON 

INSERT [dbo].[Tools] ([toolID], [kanbanID], [name]) VALUES (1, 1, N'me')
INSERT [dbo].[Tools] ([toolID], [kanbanID], [name]) VALUES (2, 1, N'friend')
SET IDENTITY_INSERT [dbo].[Tools] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([userID], [login], [password], [email], [fullname], [birthdate], [joindate]) VALUES (1, N'admin', N'admin', N'admin@admin.local', N'Timur Kulakov', CAST(N'2002-01-10' AS Date), CAST(N'2022-06-06' AS Date))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
INSERT [dbo].[UsersKanbans] ([userID], [kanbanID]) VALUES (1, 1)
INSERT [dbo].[UsersKanbans] ([userID], [kanbanID]) VALUES (1, 2)
GO
ALTER TABLE [dbo].[Status]  WITH CHECK ADD  CONSTRAINT [FK_Status_Status] FOREIGN KEY([kanbanID])
REFERENCES [dbo].[Kanbans] ([kanbanID])
GO
ALTER TABLE [dbo].[Status] CHECK CONSTRAINT [FK_Status_Status]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Kanbans] FOREIGN KEY([kanbanID])
REFERENCES [dbo].[Kanbans] ([kanbanID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Kanbans]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Status1] FOREIGN KEY([statusID])
REFERENCES [dbo].[Status] ([statusID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Status1]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Tools1] FOREIGN KEY([toolID])
REFERENCES [dbo].[Tools] ([toolID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Tools1]
GO
ALTER TABLE [dbo].[Tools]  WITH CHECK ADD  CONSTRAINT [FK_Tools_Kanbans1] FOREIGN KEY([kanbanID])
REFERENCES [dbo].[Kanbans] ([kanbanID])
GO
ALTER TABLE [dbo].[Tools] CHECK CONSTRAINT [FK_Tools_Kanbans1]
GO
ALTER TABLE [dbo].[UsersKanbans]  WITH CHECK ADD  CONSTRAINT [FK_UsersKanbans_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[UsersKanbans] CHECK CONSTRAINT [FK_UsersKanbans_Users]
GO
ALTER TABLE [dbo].[UsersKanbans]  WITH CHECK ADD  CONSTRAINT [FK_UsersKanbans_UsersKanbans] FOREIGN KEY([kanbanID])
REFERENCES [dbo].[Kanbans] ([kanbanID])
GO
ALTER TABLE [dbo].[UsersKanbans] CHECK CONSTRAINT [FK_UsersKanbans_UsersKanbans]
GO
USE [master]
GO
ALTER DATABASE [KanbanDB] SET  READ_WRITE 
GO
