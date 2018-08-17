CREATE PROC [dbo].[usp_GetApplicationContext]
	@MissionCode NVARCHAR(50) = NULL
	,@CountryOpsCode NVARCHAR(50) = NULL
	,@UnitOpsCode NVARCHAR(50) = NULL
AS
BEGIN	
	SET NOCOUNT ON;

	IF (@UnitOpsCode IS NOT NULL)
	BEGIN
		SELECT J.MissionID
			,J.CountryOpsID
			,U.UnitOpsID
		FROM [dbo].[UnitOps] U
		INNER JOIN [dbo].[Jurisdiction] J ON U.JurisdictionID = J.JurisdictionID
		WHERE U.UnitOpsCode = @UnitOpsCode
	END
	ELSE IF (
			@CountryOpsCode IS NOT NULL
			AND @MissionCode IS NOT NULL
			)
	BEGIN
		SELECT mc.MissionID
			,mc.CountryOpsID
			,NULL AS UnitOpsID
		FROM [dbo].[MissionCountryOps] mc
		INNER JOIN [dbo].[CountryOps] c ON mc.CountryOpsID = c.CountryOpsID
		INNER JOIN [dbo].[Mission] m ON mc.MissionID = m.MissionID
		WHERE c.CountryOpsCode = @CountryOpsCode
			AND m.MissionCode = @MissionCode
	END
	ELSE IF (@MissionCode IS NOT NULL)
	BEGIN
		SELECT m.MissionID
			,NULL AS CountryOpsID
			,NULL AS UnitOpsID
		FROM [dbo].[Mission] AS m
		WHERE m.MissionCode = @MissionCode
	END
END	