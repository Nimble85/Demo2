CREATE DATABASE BS1Context
GO

USE [BS1Context]
GO

/****** Объект: Table [dbo].[books] Дата скрипта: 22.03.2019 14:39:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[books] (
    [id]     INT            IDENTITY (1, 1) NOT NULL,
    [author] NVARCHAR (MAX) NULL,
    [name]   NVARCHAR (MAX) NULL,
    [price]  INT            NOT NULL
);

SET IDENTITY_INSERT [dbo].[books] ON
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (1, N'Leo Tolstoy', N'War & Peace', 120)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (2, N'George Eliot', N'Middlemarch', 142)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (3, N'Jane Austen', N'Pride & Prejudice ', 85)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (4, N'Virginia Woolf', N'Mrs. Dalloway', 86)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (5, N'Emily Brontë', N'Wuthering Heights', 225)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (6, N'Charlotte Brontë', N'Jane Eyre', 124)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (7, N'Charles Dickens', N'Great Expectations', 251)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (8, N'Charles Dickens', N'David Copperfield', 425)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (9, N'Vladimir Nabokov', N'Lolita', 135)
INSERT INTO [dbo].[books] ([id], [author], [name], [price]) VALUES (10, N'George Orwell', N'1984', 352)
SET IDENTITY_INSERT [dbo].[books] OFF

