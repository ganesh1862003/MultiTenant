﻿CREATE TABLE [dbo].[JurisdictionMap] (
    [Id]              INT              IDENTITY (1, 1) NOT NULL,
    [JurisdictionId]  UNIQUEIDENTIFIER NULL,
    [CountryOpsId]    UNIQUEIDENTIFIER NULL,
    [StatusId]        INT              NOT NULL,
    [StatusReason]    VARCHAR (250)    NULL,
    [CreatedBy]       INT              DEFAULT ((1)) NOT NULL,
    [CreatedDateUTC]  DATETIME         DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]      INT              NULL,
    [ModifiedDateUTC] DATETIME         NULL,
    CONSTRAINT [PK_JurisdictionMap] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Jurisdiction_JurisdictionMapId] FOREIGN KEY ([JurisdictionId]) REFERENCES [dbo].[Jurisdiction] ([Id])
);

