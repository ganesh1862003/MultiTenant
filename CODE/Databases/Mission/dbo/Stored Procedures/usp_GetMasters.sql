/*
    PROCEDURE NAME    : < dbo.usp_GetMasters >
    PROGRAM UNIT TYPE :	< Procedure >
    CREATED BY        :	< Ganesha Hande >
    CREATED ON        :	< 28-03-2018 >
    PURPOSE           : < Fetch Master Data from Master Table on passing TableName, Column Name> 
    USAGE             : < Description >
    ERROR CODES       : < Error code >	< Condition >
    MODIFICATIONS     : < Modified By > < Modification Date> < Modification>
*/
CREATE PROCEDURE [dbo].[usp_GetMasters] (
	@i_TableName VARCHAR(100)
	,@i_TableKey VARCHAR(50)
	,@i_TableValue VARCHAR(50)
	,@i_UnitOpsId VARCHAR(max) = NULL
	)
AS
SET NOCOUNT ON;

BEGIN TRY
	PRINT N'Starting execution';

	DECLARE @SQL NVARCHAR(2000);

	IF (@i_TableName = 'dbo.Nationality')
	BEGIN
		SELECT [C].[Id] [Key],[C].[Nationality] [Value] FROM [dbo].[Country] C 
		WHERE [C].[Nationality] IS NOT NULL		
		ORDER BY [C].[Nationality]
	END;
	--ELSE IF (@i_TableName = 'vac.VisaCategory')
	--BEGIN
	--	SELECT [B].[Id] [Key]
	--		,[B].[Name] [Value]
	--	FROM [vac].[VisaCategoryMap] A
	--	INNER JOIN [vac].[VisaCategory] B WITH (NOLOCK) ON [A].[VisaCategoryId] = [B].[Id]
	--	WHERE ([A].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL)
	--END;
	--ELSE IF (@i_TableName = 'vac.MSTSetCount')
	--BEGIN
	--	SELECT [A].[Id] [Key]
	--		,[A].[SetCount] [Value]
	--	FROM vac.MSTSetCount A
	--	WHERE ([A].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL	)		
	--END;
	--ELSE IF (@i_TableName = 'dbo.CountryCode')
	--BEGIN
	--	SELECT 0 [Key],'Select' [Value]
	--	UNION ALL
	--	SELECT [c].[Id] [Key]
	--		,c.[Name] + ' ('+ [c].[CountryCode]+')' [Value]
	--	FROM [dbo].[Country] c WHERE (c.[Name] + ' ('+ [c].[CountryCode]+')') IS NOT NULL
	--	AND [c].[Id] <> -1
		
	--END;
	--ELSE IF (@i_TableName = 'dbo.VisaGratisReason')
	--BEGIN
	--	SELECT [RM].[Id] [Key]
	--		,[RD].[Description] [Value]
	--	FROM [dbo].[ReasonMapping] RM
	--	INNER JOIN [dbo].[ReasonDetails] RD WITH (NOLOCK) ON [RM].[ReasonId] = [RD].[Id]
	--	INNER JOIN [dbo].[ReasonType] RT WITH (NOLOCK) ON [RM].[ReasonTypeId] = [RT].[Id]
	--	WHERE [RT].[Name] = 'Visa Gratis'
	--	AND ([RM].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL)
	--END;
	--ELSE IF (@i_TableName = 'dbo.ServiceGratisReason')
	--BEGIN
	--	SELECT [RM].[Id] [Key]
	--		,[RD].[Description] [Value]
	--	FROM [dbo].[ReasonMapping] RM
	--	INNER JOIN [dbo].[ReasonDetails] RD WITH (NOLOCK) ON [RM].[ReasonId] = [RD].[Id]
	--	INNER JOIN [dbo].[ReasonType] RT WITH (NOLOCK) ON [RM].[ReasonTypeId] = [RT].[Id]
	--	WHERE [RT].[Name] = 'Service Gratis'
	--	AND ([RM].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL)
	--END;
	--ELSE IF (@i_TableName = 'dbo.TravelDocReason')
	--BEGIN
	--	SELECT [RM].[Id] [Key]
	--		,[RD].[Description] [Value]
	--	FROM [dbo].[ReasonMapping] RM
	--	INNER JOIN [dbo].[ReasonDetails] RD WITH (NOLOCK) ON [RM].[ReasonId] = [RD].[Id]
	--	INNER JOIN [dbo].[ReasonType] RT WITH (NOLOCK) ON [RM].[ReasonTypeId] = [RT].[Id]
	--	WHERE [RT].[Name] = 'Override Passport'
	--	AND ([RM].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL)
	--END;
	--ELSE IF (@i_TableName = 'dbo.VasList')
	--BEGIN
	--	SELECT [VS].[Id] [Key]
	--		,[VS].[Name] [Value]
	--	FROM [vac].[VASMap] [VSM]		
	--	INNER JOIN [vac].[VAS] [VS] WITH (NOLOCK) ON [VSM].[VASId] = [VS].[Id]
	--	INNER JOIN [vac].[VASCategory] [VC] WITH (NOLOCK) ON [VS].[VasCategoryId] = [VC].[Id]
	--	WHERE ([VSM].[UnitOpsId]= @i_UnitOpsId	OR @i_UnitOpsId IS NULL)	
	--END;
	--ELSE IF (@i_TableName = 'dbo.DocumentType')
	--BEGIN
	--	SELECT [D].[Id] [Key]
	--		,[D].[Name] [Value]
	--	FROM [dbo].[DocumentMap] DM
	--	INNER JOIN [dbo].[Document] D WITH (NOLOCK) ON [DM].[DocumentId] = [D].[Id]
	--	INNER JOIN [dbo].[DocumentType] DT WITH (NOLOCK) ON [D].[DocumentTypeId] = [DT].[Id]
	--	WHERE [DT].[Id] = 1
	--	AND ([DM].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL);		
	--END;
	--ELSE IF (@i_TableName = 'dbo.CourierOperator')
	--BEGIN
	--	SELECT [C].[Id] [Key]
	--	,[C].[Name] [Value]
	--	FROM [vac].[CourierOperatorInMap] CIN
	--	INNER JOIN [dbo].[CourierOperator] C WITH (NOLOCK) ON CIN.CourierOpId = [C].[Id]
	--	WHERE (	[CIN].[UnitOpsId] = @i_UnitOpsId OR @i_UnitOpsId IS NULL )
	--END;
	--ELSE IF (@i_TableName = 'vac.TravelAgent')
	--BEGIN
	--	SELECT [TA].[Id] [Key]
	--	,[TA].[Name] [Value]
	--	FROM [vac].[TravelAgent] TA
	--	WHERE ([TA].[IsAuthorized] = 1 OR [TA].[IsAuthorized] IS NULL)		
	--	ORDER BY [TA].[IsAuthorized] DESC
	--END;
	--ELSE IF (@i_TableName = 'dbo.OccupationCodes')
	--BEGIN
	--	SELECT [D].[Id] [Key]
	--		,[D].[Name] + ' [' + [D].[Code] + ']' [Value]
	--	FROM [dbo].[OccupationCodes] D
	--END;
	--ELSE IF (@i_TableName = 'dbo.TravelReason')
	--BEGIN
	--	SELECT T.[Id] [Key]
	--		,T.[Name] + ' [' + T.[Code] + ']' [Value]
	--	FROM TravelReason T
	--END;	
	--ELSE IF (@i_TableName = 'dbo.TypeOfVisa')
	--BEGIN
	--	SELECT T.[Id] [Key]
	--		,T.[Name] + ' [' + T.[Code] + ']' [Value]
	--	FROM TypeOfVisa T
	--END;
	--ELSE IF (@i_TableName = 'vac.Status')
	--BEGIN
	--	SELECT A.Id AS [Key],A.[Name] AS [Value]
	--	FROM vac.Status A
	--	INNER JOIN StatusFormRepresentationMapping B
	--		ON A.Id=B.StatusId  
	--	WHERE B.FormId = 2 --Data Entry Form
	--END;
	ELSE
	BEGIN
		SET @SQL = 'SELECT [' + @i_TableKey + ']  AS [Key]
					, [' + @i_TableValue + '] AS [Value]					
				FROM   ' + @i_TableName;

		EXEC (@SQL);
	END;
END TRY

BEGIN CATCH
	SELECT ERROR_NUMBER() AS [ErrorNumber]
		,ERROR_MESSAGE() AS [ErrorMessage];
END CATCH;