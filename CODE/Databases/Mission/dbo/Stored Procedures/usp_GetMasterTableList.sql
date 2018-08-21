/*
    PROCEDURE NAME    : < dbo.usp_GetMasterTableList >
    PROGRAM UNIT TYPE :	< Procedure >
    CREATED BY        :	< GANESHA HANDE>
    CREATED ON        :	< 21-08-2018 >
    PURPOSE           : < Fetch master table list as per formid, categoryid and fieldid> 
    USAGE             : < Description >
    ERROR CODES       : < Error code >	< Condition >
    MODIFICATIONS     : < Modified By > < Modification Date > < Modification >
*/

CREATE PROC [dbo].[usp_GetMasterTableList] ( @i_formId INT = NULL )
AS
SET NOCOUNT ON;
  BEGIN TRY
    SELECT DISTINCT
           [M].[TableName]  AS [TableName]
           ,[M].[KeyColumn]   AS [Key]
           ,[M].[ValueColumn] AS [Value]
      FROM [dbo].[MasterTableList] [M];

  END TRY
  BEGIN CATCH
    SELECT ERROR_NUMBER()   AS [ErrorNumber]
           ,ERROR_MESSAGE() AS [ErrorMessage];
  END CATCH;