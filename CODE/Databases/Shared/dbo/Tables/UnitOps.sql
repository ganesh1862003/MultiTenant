CREATE TABLE [dbo].[UnitOps] (
    [Id]             UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]           VARCHAR (250)    NOT NULL,
    [Code]           VARCHAR (11)     NOT NULL,
    [UnitOpsCode]    INT              NOT NULL,
    [JurisdictionId] INT              NOT NULL,
    CONSTRAINT [PK_UnitOps] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Juris_JurisdictId] FOREIGN KEY ([JurisdictionId]) REFERENCES [dbo].[JurisdictionMap] ([Id])
);



