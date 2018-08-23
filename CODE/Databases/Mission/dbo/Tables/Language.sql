CREATE TABLE [dbo].[Language] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (250) NOT NULL,
    [Code] VARCHAR (10)   NULL,
    CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED ([Id] ASC)
);

