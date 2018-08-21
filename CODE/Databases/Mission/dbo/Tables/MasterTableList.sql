CREATE TABLE [dbo].[MasterTableList] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [TableName]   VARCHAR (100) NOT NULL,
    [KeyColumn]   VARCHAR (50)  NOT NULL,
    [ValueColumn] VARCHAR (100) NOT NULL
);

