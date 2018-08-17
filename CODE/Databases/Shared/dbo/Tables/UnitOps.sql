CREATE TABLE [dbo].[UnitOps] (
    [UnitOpsID]      UNIQUEIDENTIFIER NOT NULL,
    [UnitOpsName]    NVARCHAR (100)   NOT NULL,
    [UnitOpsCode]    NVARCHAR (50)    NOT NULL,
    [JurisdictionID] UNIQUEIDENTIFIER NOT NULL,
    [Code]           CHAR (20)        NULL,
    CONSTRAINT [PK_UnitOps] PRIMARY KEY CLUSTERED ([UnitOpsID] ASC),
    CONSTRAINT [FK_UnitOps_Jurisdiction] FOREIGN KEY ([JurisdictionID]) REFERENCES [dbo].[Jurisdiction] ([JurisdictionID])
);

