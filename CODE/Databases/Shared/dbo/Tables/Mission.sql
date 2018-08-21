CREATE TABLE [dbo].[Mission] (
    [Id]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name] NVARCHAR (250)   NOT NULL,
    [Code] VARCHAR (10)     NOT NULL,
    CONSTRAINT [PK_Mission] PRIMARY KEY CLUSTERED ([Id] ASC)
);



