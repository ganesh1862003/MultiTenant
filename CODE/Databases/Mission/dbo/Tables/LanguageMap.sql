CREATE TABLE [dbo].[LanguageMap] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [LanguageId]   INT              NOT NULL,
    [MissionId]    UNIQUEIDENTIFIER NOT NULL,
    [CountryOpsId] UNIQUEIDENTIFIER NULL,
    [UnitOpsId]    UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_LanguageMap] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Language_LanguageMapId] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Language] ([Id]),
    CONSTRAINT [FK_LanguageMap_CountryOfOperation] FOREIGN KEY ([CountryOpsId]) REFERENCES [dbo].[CountryOfOperation] ([Id]),
    CONSTRAINT [FK_LanguageMap_Mission] FOREIGN KEY ([MissionId]) REFERENCES [dbo].[Mission] ([Id]),
    CONSTRAINT [FK_LanguageMap_UnitOps] FOREIGN KEY ([UnitOpsId]) REFERENCES [dbo].[UnitOps] ([Id])
);

