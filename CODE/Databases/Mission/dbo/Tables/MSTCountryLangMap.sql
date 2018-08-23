CREATE TABLE [dbo].[MSTCountryLangMap] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CountryId]  INT            NOT NULL,
    [LanguageId] INT            NOT NULL,
    [Name]       NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_MSTCountryLangCode] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Country_MSTCountryLangMap_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_Country_MSTCountryLangMap_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Language] ([Id])
);

