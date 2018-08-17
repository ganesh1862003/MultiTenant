CREATE TABLE [dbo].[Mission] (
    [MissionID]   UNIQUEIDENTIFIER NOT NULL,
    [MissionName] NVARCHAR (100)   NOT NULL,
    [MissionCode] NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Mission] PRIMARY KEY CLUSTERED ([MissionID] ASC)
);

