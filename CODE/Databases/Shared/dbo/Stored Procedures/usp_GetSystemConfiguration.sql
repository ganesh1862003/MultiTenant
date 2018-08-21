CREATE PROC [dbo].[usp_GetSystemConfiguration]
	@ConfigurationKey NVARCHAR(50)
	,@MissionID UNIQUEIDENTIFIER = NULL
	,@CountryOpsID UNIQUEIDENTIFIER = NULL
	,@UnitOpsID UNIQUEIDENTIFIER = NULL
AS
SET NOCOUNT ON;
BEGIN
	SELECT [config].[MissionID]
		,[config].[CountryOpsID]
		,[config].[UnitOpsID]
		,[config].[Key]
		,[config].[Value]
	FROM [dbo].[SystemConfiguration] config
	WHERE [config].[Key] = @ConfigurationKey
		AND (
			(
				[config].UnitOpsID = @UnitOpsID
				AND [config].CountryOpsID = @CountryOpsID
				AND [config].MissionID = @MissionID
				)
			OR (
				[config].UnitOpsID IS NULL
				AND [config].CountryOpsID = @CountryOpsID
				AND [config].MissionID = @MissionID
				)
			OR (
				[config].UnitOpsID IS NULL
				AND [config].CountryOpsID IS NULL
				AND [config].MissionID = @MissionID
				)
			OR (
				[config].UnitOpsID IS NULL
				AND [config].CountryOpsID IS NULL
				AND [config].MissionID IS NULL
				)
			)
END