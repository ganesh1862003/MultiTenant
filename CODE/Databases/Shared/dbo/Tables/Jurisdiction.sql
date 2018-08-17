CREATE TABLE [dbo].[Jurisdiction] (
    [JurisdictionID]   UNIQUEIDENTIFIER NOT NULL,
    [JurisdictionName] NVARCHAR (100)   NOT NULL,
    [MissionID]        UNIQUEIDENTIFIER NOT NULL,
    [CountryOpsID]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Jurisdiction] PRIMARY KEY CLUSTERED ([JurisdictionID] ASC),
    CONSTRAINT [FK_Jurisdiction_CountryOps] FOREIGN KEY ([CountryOpsID]) REFERENCES [dbo].[CountryOps] ([CountryOpsID]),
    CONSTRAINT [FK_Jurisdiction_Mission] FOREIGN KEY ([MissionID]) REFERENCES [dbo].[Mission] ([MissionID])
);

