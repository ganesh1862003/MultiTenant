CREATE TABLE [dbo].[JurisdictionMap] (
    [Id]              INT              IDENTITY (1, 1) NOT NULL,
    [JurisdictionId]  UNIQUEIDENTIFIER NULL,
    [CountryOpsId]    UNIQUEIDENTIFIER NULL,
    [StatusId]        INT              NOT NULL,
    [StatusReason]    VARCHAR (250)    NULL,
    [CreatedBy]       INT              CONSTRAINT [DF__Jurisdict__Creat__59063A47] DEFAULT ((1)) NOT NULL,
    [CreatedDateUTC]  DATETIME         CONSTRAINT [DF__Jurisdict__Creat__59FA5E80] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]      INT              NULL,
    [ModifiedDateUTC] DATETIME         NULL,
    CONSTRAINT [PK_JurisdictionMap] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CountryOfOperation_JurisdictionMap] FOREIGN KEY ([CountryOpsId]) REFERENCES [dbo].[CountryOfOperation] ([Id]),
    CONSTRAINT [FK_Jurisdiction_JurisdictionMapId] FOREIGN KEY ([JurisdictionId]) REFERENCES [dbo].[Jurisdiction] ([Id])
);



