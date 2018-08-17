CREATE TABLE [dbo].[MissionCountryOps] (
    [MissionID]    UNIQUEIDENTIFIER NOT NULL,
    [CountryOpsID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_MissionCountryOps_CountryOps] FOREIGN KEY ([CountryOpsID]) REFERENCES [dbo].[CountryOps] ([CountryOpsID]),
    CONSTRAINT [FK_MissionCountryOps_Mission] FOREIGN KEY ([MissionID]) REFERENCES [dbo].[Mission] ([MissionID])
);

