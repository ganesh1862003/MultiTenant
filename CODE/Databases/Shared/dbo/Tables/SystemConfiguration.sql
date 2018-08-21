CREATE TABLE [dbo].[SystemConfiguration] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [MissionId]    UNIQUEIDENTIFIER NULL,
    [CountryOpsId] UNIQUEIDENTIFIER NULL,
    [UnitOpsId]    UNIQUEIDENTIFIER NULL,
    [Key]          VARCHAR (100)    NOT NULL,
    [Value]        VARCHAR (MAX)    NOT NULL,
    CONSTRAINT [PK_SystemConfig] PRIMARY KEY CLUSTERED ([Id] ASC)
);



