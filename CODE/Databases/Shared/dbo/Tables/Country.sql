CREATE TABLE [dbo].[Country] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Code]        NVARCHAR (100) NOT NULL,
    [ISOCode2]    CHAR (2)       NULL,
    [ISOCode3]    CHAR (3)       NULL,
    [DialCode]    NVARCHAR (100) NULL,
    [Nationality] VARCHAR (200)  NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([Id] ASC)
);

