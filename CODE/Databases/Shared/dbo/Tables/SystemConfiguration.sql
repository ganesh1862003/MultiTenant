CREATE TABLE [dbo].[SystemConfiguration] (
    [SystemConfigurationID] INT              NOT NULL,
    [MissionID]             UNIQUEIDENTIFIER NULL,
    [CountryOpsID]          UNIQUEIDENTIFIER NULL,
    [UnitOpsID]             UNIQUEIDENTIFIER NULL,
    [ConfigurationKey]      NVARCHAR (50)    NOT NULL,
    [ConfigurationValue]    NVARCHAR (500)   NOT NULL,
    CONSTRAINT [PK_SystemConfiguration] PRIMARY KEY CLUSTERED ([SystemConfigurationID] ASC)
);

