CREATE TABLE [dbo].[Jurisdiction] (
    [Id]   UNIQUEIDENTIFIER CONSTRAINT [DF__Jurisdiction__Id__5629CD9C] DEFAULT (newid()) NOT NULL,
    [Name] NVARCHAR (250)   NOT NULL,
    [Code] VARCHAR (10)     NULL,
    CONSTRAINT [PK_Jurisdiction] PRIMARY KEY CLUSTERED ([Id] ASC)
);

