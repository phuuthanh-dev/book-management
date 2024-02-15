﻿USE [master]
GO
/****** Object:  Database [BookManagement2024DB]    Script Date: 16/06/2024 10:27:19 CH ******/
CREATE DATABASE [BookManagement2024DB]
GO
USE [BookManagement2024DB]
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] NOT NULL,
	[BookName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[BookCategoryId] [int] NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookCategory]    Script Date: 16/06/2023 10:27:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCategory](
	[BookCategoryId] [int] NOT NULL,
	[BookGenreType] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_BookCategory] PRIMARY KEY CLUSTERED 
(
	[BookCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookManagementMember]    Script Date: 16/06/2023 10:27:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookManagementMember](
	[MemberId] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[MemberRole] [int] NOT NULL,
 CONSTRAINT [PK_BookManagementMember] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (1, N'The Handbook Of International Trade And Finance', N'An international trade transaction, no matter how straightforward it may seem at the start, is not completed until delivery has taken place, any other obligations have been fulfilled and the seller has received payment. This may seem obvious; however, even seemingly simple transactions can, and sometimes do, go wrong.', CAST(N'2005-01-01T00:00:00.000' AS DateTime), 10, 45.99, 4, N'Anders Grath')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (2, N'Snow Crash', N'Hiro lives in a Los Angeles where franchises line the freeway as far as the eye can see. The only relief from the sea of logos is within the autonomous city-states, where law-abiding citizens don’t dare leave their mansions.', CAST(N'2001-01-01T00:00:00.000' AS DateTime), 20, 12.99, 2, N'Neal Stephenson')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (3, N'Contact: A Novel', N'The future is here…in an adventure of cosmic dimension. When a signal is discovered that seems to come from far beyond our solar system, a multinational team of scientists decides to find the source. What follows is an eye-opening journey out to the stars to the most awesome encounter in human history. Who—or what—is out there? Why are they watching us? And what do they want with us?', CAST(N'2019-02-26T00:00:00.000' AS DateTime), 15, 12.99, 2, N'Carl Sagan')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (4, N'The Time Machine', N'The story follows a Victorian scientist, who claims that he has invented a device that enables him to travel through time, and has visited the future, arriving in the year 802,701 in what had once been London.', CAST(N'2021-06-29T00:00:00.000' AS DateTime), 11, 6.99, 2, N'H.G. Wells')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (5, N'Rosewater (The Wormwood Trilogy, 1)', N'Rosewater is a town on the edge. A community formed around the edges of a mysterious alien biodome, its residents comprise the hopeful, the hungry, and the helpless -- people eager for a glimpse inside the dome or a taste of its rumored healing powers.', CAST(N'2018-09-18T00:00:00.000' AS DateTime), 27, 10.49, 2, N'Tade Thompson')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (6, N'The Last Russian Doll', N'A haunting, epic novel about betrayal, revenge, and redemption that follows three generations of Russian women, from the 1917 revolution to the last days of the Soviet Union, and the enduring love story at the center.
', CAST(N'2023-03-14T00:00:00.000' AS DateTime), 21, 19.99, 3, N'Kristen Loesch')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (7, N'The Whip: a novel inspired by the story of Charley Parkhurst', N'The Whip is inspired by the true story of a woman, Charlotte "Charley" Parkhurst (1812-1879) who lived most of her extraordinary life as a man in the old west. As a young woman in Rhode Island, she fell in love with a runaway slave and had his child. The destruction of her family drove her west to California, dressed as a man, to track the killer.
', CAST(N'2011-12-31T00:00:00.000' AS DateTime), 5, 20.71, 3, N'Karen Kondazian')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (8, N'Where the Lost Wander: A Novel', N'In this epic and haunting love story set on the Oregon Trail, a family and their unlikely protector find their way through peril, uncertainty, and loss.', CAST(N'2020-04-28T00:00:00.000' AS DateTime), 12, 8.28, 3, N'Amy Harmon')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (9, N'All the Light We Cannot See: A Novel', N'Winner of the Pulitzer Prize* A New York Times Book Review Top Ten Book* A National Book Award Finalist', CAST(N'2017-04-04T00:00:00.000' AS DateTime), 30, 16.43, 3, N'Anthony Doerr')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (10, N'Dave Ramsey''s Complete Guide To Money', N'Dave Ramsey’s Complete Guide to Money offers the ultra-practical way to learn how money works.', CAST(N'2012-01-01T00:00:00.000' AS DateTime), 7, 12.09, 4, N'Dave Ramsey')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (11, N'How to Manage Your Money When You Don''t Have Any', N'Unlike many personal finance books, How to Manage Your Money When You Don''t Have Any was specifically written for Americans who struggle to make it on a monthly basis. It provides a respectful, no-nonsense look at the difficult realities of our modern economy, along with an easy to follow path toward better financial stability that will give hope to even the most financially strapped households. Created by a financial expert who hasn''t struck it rich, How to Manage Your Money When You Don''t Have Any offers a first hand..', CAST(N'2012-06-07T00:00:00.000' AS DateTime), 3, 11.99, 4, N'Mr Erik Wecks')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (12, N'Clever Girl Finance: Ditch debt, save money and build real wealth', N'Join the ranks of thousands of smart and savvy women who have turned to money expert and author Bola Sokunbi for guidance on ditching debt, saving money, and building real wealth.', CAST(N'2019-06-25T00:00:00.000' AS DateTime), 17, 14.99, 4, N'Bola Sokunbi')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (13, N'Growing Money', N'Colin and Devon are cousins who share the same birthday. On their eighth birthday, their grandpa gifts them two envelopes of money to do anything they like with it.', CAST(N'2023-06-13T00:00:00.000' AS DateTime), 29, 11.99, 4, N'Brandon L Parker')
INSERT [dbo].[Book] ([BookId], [BookName], [Description], [ReleaseDate], [Quantity], [Price], [BookCategoryId], [Author]) VALUES (14, N'Clever Girl Finance: Learn How Investing Works, Grow Your Money', N'Clever Girl Finance: Learn How Investing Works, Grow Your Money is the leading guide for women who seek to learn the basic foundations of personal investing. In a no-nonsense and straightforward style, this book teaches readers.', CAST(N'2020-10-02T00:00:00.000' AS DateTime), 19, 13.6, 4, N'Bola Sokunbi')
GO
INSERT [dbo].[BookCategory] ([BookCategoryId], [BookGenreType], [Description]) VALUES (1, N'Fiction', N'Fiction is any creative work, chiefly any narrative work, portraying individuals, events, or places that are imaginary, or in ways that are imaginary.')
INSERT [dbo].[BookCategory] ([BookCategoryId], [BookGenreType], [Description]) VALUES (2, N'Science Fiction', N'Science fiction is a genre of speculative fiction, which typically deals with imaginative and futuristic concepts such as advanced science and technology, space exploration, time travel, parallel universes, and extraterrestrial life.')
INSERT [dbo].[BookCategory] ([BookCategoryId], [BookGenreType], [Description]) VALUES (3, N'Historical Fiction', N'Historical fiction is a literary genre in which the plot takes place in a setting related to the past events, but is fictional.')
INSERT [dbo].[BookCategory] ([BookCategoryId], [BookGenreType], [Description]) VALUES (4, N'Finance', N'Finance is a field that deals with the study of investments. It includes the dynamics of assets and liabilities over time under conditions of different degrees of uncertainty and risk. Finance can also be defined as the science of money management. Finance aims to price assets based on their risk level and their expected rate of return.')
GO
INSERT [dbo].[BookManagementMember] ([MemberId], [Password], [Email], [FullName], [MemberRole]) VALUES (1, N'12345', N'admin', N'Administrator', 1)
INSERT [dbo].[BookManagementMember] ([MemberId], [Password], [Email], [FullName], [MemberRole]) VALUES (2, N'Staff@zxc123', N'staff@local', N'Staff', 2)
INSERT [dbo].[BookManagementMember] ([MemberId], [Password], [Email], [FullName], [MemberRole]) VALUES (3, N'Member@qww11', N'member1@local', N'Member 1', 3)
INSERT [dbo].[BookManagementMember] ([MemberId], [Password], [Email], [FullName], [MemberRole]) VALUES (4, N'Member@qasa', N'member2@local', N'Member 2', 3)
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_BookCategory] FOREIGN KEY([BookCategoryId])
REFERENCES [dbo].[BookCategory] ([BookCategoryId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_BookCategory]
GO
USE [master]
GO
ALTER DATABASE [BookManagement2024DB] SET  READ_WRITE 
GO