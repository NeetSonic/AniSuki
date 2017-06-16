--分辨率视图
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE [Name] = 'ViewResolution') BEGIN
	DROP VIEW [ViewResolution]
END
GO
CREATE VIEW [ViewResolution]([ID], [Width], [Height], [Res])
WITH SCHEMABINDING
AS 
SELECT [ID], [Width], [Height], 
CONVERT(NVARCHAR, [Width]) + N'x' + CONVERT(NVARCHAR, [Height]) AS [Res] 
FROM [dbo].[Resolution]
GO

--动画标签视图
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE [Name] = 'ViewAnimeTag') BEGIN
	DROP VIEW [ViewAnimeTag]
END
GO
CREATE VIEW [ViewAnimeTag]([AID], [TID], [TagName])
WITH SCHEMABINDING
AS 
SELECT [AT].[AID], [AT].[TID], [T].[Name] AS [TagName]
FROM [dbo].[AnimeTag] AS [AT] 
LEFT JOIN [dbo].[Tag] AS [T] ON [AT].[TID] = [T].[ID] 
GO

--动画配音视图
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE [Name] = 'ViewAnimeCV') BEGIN
	DROP VIEW [ViewAnimeCV]
END
GO
CREATE VIEW [ViewAnimeCV]([AID], [CID], [CharaName], [CastName])
WITH SCHEMABINDING
AS 
SELECT [AC].[AID], [AC].[CID], [AC].[CharaName], [C].[Name] AS [CastName]
FROM [dbo].[AnimeCV] AS [AC] 
LEFT JOIN [dbo].[Cast] AS [C] ON [AC].[CID] = [C].[ID] 
GO

--动画视图
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE [Name] = 'ViewAnime') BEGIN
	DROP VIEW [ViewAnime]
END
GO
CREATE VIEW [ViewAnime]([AnimeID], [AnimeName], [AnimeComment], [AnimeDate], 
[ProducerID], [ProducerName], [ProducerWebsite], 
[ResolutionID], [ResolutionWidth], [ResolutionHeight], [Resolution],
[Tags], [CVs])
WITH SCHEMABINDING
AS SELECT [A].[ID] AS [AnimeID], [A].[Name] AS [AnimeName], [A].[Comment] AS [AnimeComment], 
[A].[Date] AS [AnimeDate], [P].[ID] AS [ProducerID], [P].[Name] AS [ProducerName], 
[P].[Website] AS [ProducerWebsite], [R].[ID] AS [ResolutionID], [R].[Width] AS [ResolutionWidth],
[R].[Height] AS [ResolutionHeight], CONVERT(NVARCHAR, [R].[Width]) + N'x' + CONVERT(NVARCHAR, [R].[Height]) AS [Resolution],
(SELECT [TagName] + N' ' FROM [dbo].[ViewAnimeTag] WHERE [AID] = [A].[ID] ORDER BY [TagName] ASC FOR XML PATH('')) AS [Tags],
(SELECT [CharaName] + N'：' + [CastName] + N' | ' FROM [dbo].[ViewAnimeCV] WHERE [AID] = [A].[ID] ORDER BY [CharaName] ASC FOR XML PATH('')) AS [CVs]
FROM [dbo].[Anime] AS [A] 
LEFT JOIN [dbo].[Producer] AS [P] ON [A].[ProducerID] = [P].[ID]
LEFT JOIN [dbo].[Resolution] AS [R] ON [A].[ResolutionID] = [R].[ID]
GO