CREATE TABLE [dbo].[CountryOps] (
    [CountryOpsID]   UNIQUEIDENTIFIER NOT NULL,
    [CountryOpsName] NVARCHAR (100)   NOT NULL,
    [CountryOpsCode] NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_CountryOps] PRIMARY KEY CLUSTERED ([CountryOpsID] ASC)
);

