USE zhengrui;

DROP TABLE IF EXISTS Crusader.[User];
DROP TABLE IF EXISTS Crusader.Chapter;
DROP TABLE IF EXISTS Crusader.NPC;
DROP TABLE IF EXISTS Crusader.[Resource];
DROP TABLE IF EXISTS Crusader.Hero;

CREATE TABLE Crusader.NPC
(
	NPCId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	NPCName NVARCHAR(64) NOT NULL,
	Skill NVARCHAR(64) NOT NULL,
	[Type] NVARCHAR(64) NOT NULL,
	Faction NVARCHAR(64) NOT NULL,
	UNIQUE
	(
		NPCName ASC
	)
);

CREATE TABLE Crusader.[Resource]
(
	ResourceId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	ResourceName NVARCHAR(64) NOT NULL,
	[Type] NVARCHAR(64) NOT NULL,
	Usage NVARCHAR(64) NOT NULL,
	Acquisition NVARCHAR(64) NOT NULL,

	UNIQUE
	(
		ResourceName ASC
	)
);

CREATE TABLE Crusader.Hero
(
	HeroId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	HeroName NVARCHAR(128) NOT NULL,
	HP INT NOT NULL,
	ATK	INT NOT NULL,
	SoulboundWeapon NVARCHAR(128) NOT NULL,
	[Contract] NVARCHAR(64) NOT NULL,
	Faction NVARCHAR(64) NOT NULL,
	Class NVARCHAR(64) NOT NULL,

	UNIQUE
	(
		SoulboundWeapon ASC
	)
);

CREATE TABLE Crusader.Chapter
(
	ChapterId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Episode NVARCHAR(128) NOT NULL,
	ChapterName NVARCHAR(64) NOT NULL,
	Environment NVARCHAR(64) NOT NULL,
	Boss NVARCHAR(64) NOT NULL,
	Cost NVARCHAR(64) NOT NULL,
);

CREATE TABLE Crusader.[User]
(
	UserId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FullName VARCHAR(50) NOT NULL,
	Gender VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Country VARCHAR(50) NOT NULL,
	UserName VARCHAR(50) NOT NULL,
	UserPassword VARCHAR(50) NOT NULL,
	CreditCard VARCHAR(50) NOT NULL,
	BirthDate VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) NOT NULL,
	IsAdmin VARCHAR(50) NOT NULL,

	UNIQUE
	(
		UserName ASC,
		Email ASC
	)
);
