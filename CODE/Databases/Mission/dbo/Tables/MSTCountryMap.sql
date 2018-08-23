CREATE TABLE [dbo].[MSTCountryMap] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [CountryId]    INT              NOT NULL,
    [MissionId]    UNIQUEIDENTIFIER NOT NULL,
    [CountryOpsId] UNIQUEIDENTIFIER NULL,
    [UnitOpsId]    UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_MSTCountryMap] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Country_MSTCountryMap_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_MSTCountryMap_CountryOfOperation] FOREIGN KEY ([CountryOpsId]) REFERENCES [dbo].[CountryOfOperation] ([Id]),
    CONSTRAINT [FK_MSTCountryMap_Mission] FOREIGN KEY ([MissionId]) REFERENCES [dbo].[Mission] ([Id]),
    CONSTRAINT [FK_MSTCountryMap_UnitOps] FOREIGN KEY ([UnitOpsId]) REFERENCES [dbo].[UnitOps] ([Id])
);

