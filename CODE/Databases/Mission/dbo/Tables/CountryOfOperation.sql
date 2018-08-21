CREATE TABLE [dbo].[CountryOfOperation] (
    [Id]        UNIQUEIDENTIFIER CONSTRAINT [DF__CountryOfOpe__Id__5165187F] DEFAULT (newid()) NOT NULL,
    [Name]      NVARCHAR (250)   NOT NULL,
    [Code]      VARCHAR (10)     NOT NULL,
    [CountryId] INT              NOT NULL,
    [MissionId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CountryOfOperation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Country_CountryOpsId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_Mission_MissionId] FOREIGN KEY ([MissionId]) REFERENCES [dbo].[Mission] ([Id])
);

