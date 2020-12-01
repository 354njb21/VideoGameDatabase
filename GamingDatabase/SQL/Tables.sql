
DROP TABLE IF EXISTS Gaming.Game;
DROP TABLE IF EXISTS Gaming.Company;
DROP TABLE IF EXISTS Gaming.[Platform];
DROP TABLE IF EXISTS [Platform].Sales;
DROP TABLE IF EXISTS Gaming.GamePlatform;
DROP TABLE IF EXISTS Gaming.GameSale;
DROP TABLE IF EXISTS Players.Streamers;
GO



CREATE TABLE Gaming.Company
	(
		CompanyID INT IDENTITY PRIMARY KEY,
		[Name] NVARCHAR(256) NOT NULL
	);

CREATE TABLE Gaming.Game
	(
		GameID INT NOT NULL IDENTITY PRIMARY KEY,
		CompanyID INT NOT NULL FOREIGN KEY
			REFERENCES Gaming.Company(CompanyID),
		[Name] NVARCHAR(128) NOT NULL,
		Genre NVARCHAR(64) NOT NULL,
		Rating NVARCHAR(2) NOT NULL,
		YearReleased SMALLINT NOT NULL,
		Price DECIMAL(4, 2) NOT NULL,
		ReviewScore TINYINT NOT NULL
	);

CREATE TABLE Gaming.[Platform]
	(
		PlatformID INT NOT NULL IDENTITY PRIMARY KEY,
		[Name] NVARCHAR(64) NOT NULL
	);

CREATE TABLE [Platform].Sales
	(
		SalesID INT NOT NULL IDENTITY PRIMARY KEY,
		PlatformID INT NOT NULL FOREIGN KEY
			REFERENCES Gaming.[Platform](PlatformID),
		Year SMALLINT NOT NULL,
		Sales DECIMAL(5, 2)
	);

CREATE TABLE Gaming.GamePlatform
	(
		PlatformID INT NOT NULL FOREIGN KEY
			REFERENCES Gaming.Platform(PlatformID),
		GameID INT NOT NULL FOREIGN KEY
			REFERENCES Gaming.Game(GameID)

		PRIMARY KEY(GameID, PlatformID)
	);

CREATE TABLE Gaming.GameSale
	(
		GameSaleID INT NOT NULL IDENTITY PRIMARY KEY,
		GameID INT NOT NULL FOREIGN KEY
			REFERENCES Gaming.Game(GameID),
		OverallSale DECIMAL(5, 2) NOT NULL
	);

CREATE TABLE Players.Streamers
(
	StreamerId int NOT NULL identity(1,1) PRIMARY KEY,
	StreamerName NVARCHAR(64) NOT NULL,
	Subscribers int NOT NULL,
	Viewers bigint NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);



INSERT Gaming.[Platform] ([Name])
VALUES(N'Nintendo 3DS')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Nintendo DS')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Nintendo Switch')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Nintendo Wii')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Nintendo WiiU')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Playstation 3')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Playstation 4')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Playstation Vista')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Xbox 360')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Xbox One')

INSERT Gaming.[Platform] ([Name])
VALUES(N'Sony PSP')


