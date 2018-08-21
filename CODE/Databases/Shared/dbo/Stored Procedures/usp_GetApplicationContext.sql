CREATE PROC [dbo].[usp_GetApplicationContext]
	@MissionCode NVARCHAR(50) = NULL
	,@CountryOpsCode NVARCHAR(50) = NULL
	,@UnitOpsCode NVARCHAR(50) = NULL
AS
BEGIN	
	SET NOCOUNT ON;

	IF (@UnitOpsCode IS NOT NULL)
	BEGIN
		SELECT [COP].MissionID [MissionID]
			,[JM].CountryOpsID [CountryOpsID]
			,U.[Id] [UnitOpsID]
		FROM [dbo].[UnitOps] U
		INNER JOIN [dbo].[JurisdictionMap] JM ON U.JurisdictionID = JM.[Id]
		INNER JOIN [dbo].[Jurisdiction] J ON [JM].[JurisdictionId] = [J].[Id]
		INNER JOIN [dbo].[CountryOfOperation] COP ON [JM].[CountryOpsId] = [COP].[Id]		
		WHERE U.UnitOpsCode = @UnitOpsCode
	END
	ELSE IF (
			@CountryOpsCode IS NOT NULL
			AND @MissionCode IS NOT NULL
			)
	BEGIN
		SELECT mc.MissionID [MissionID]
			,[mc].[Id] [CountryOpsID]
			,NULL AS [UnitOpsID]
		FROM [dbo].[CountryOfOperation] mc
		INNER JOIN [dbo].[Mission] m ON mc.MissionID = m.[Id]
		WHERE [mc].[Code] = @CountryOpsCode
			AND m.[Code] = @MissionCode
	END
	ELSE IF (@MissionCode IS NOT NULL)
	BEGIN
		SELECT m.[Id] [MissionID]
			,NULL AS [CountryOpsID]
			,NULL AS [UnitOpsID]
		FROM [dbo].[Mission] AS m
		WHERE m.[Code] = @MissionCode
	END
END	