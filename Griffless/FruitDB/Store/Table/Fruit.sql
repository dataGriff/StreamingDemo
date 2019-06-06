﻿CREATE TABLE [Store].[Fruit]
(
	[FruitId]  INT IDENTITY NOT NULL PRIMARY KEY CLUSTERED,
	[FirstInserted] DATETIME2 NOT NULL CONSTRAINT DF_Fruit_FirstInserted DEFAULT SYSUTCDATETIME(),
	[Name] VARCHAR(20) NOT NULL,
	[Colour] VARCHAR(20) NOT NULL,
	[Price] SMALLINT NOT NULL
)
