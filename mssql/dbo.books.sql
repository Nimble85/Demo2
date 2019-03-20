USE [BS1Context-e32e49de-5d10-4fd7-8fc4-42487a944aab]
GO

/****** Объект: Table [dbo].[books] Дата скрипта: 20.03.2019 15:27:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[books] (
    [id]     INT            IDENTITY (1, 1) NOT NULL,
    [author] NVARCHAR (MAX) NULL,
    [price]  INT            NOT NULL
);


