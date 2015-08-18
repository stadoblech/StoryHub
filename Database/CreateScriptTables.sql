/* DROP STATEMENT */
DROP TABLE [Users];
go

/*
Created: 12.08.2015
Modified: 12.08.2015
Model: Clean model
Database: MS SQL Server 2014
*/


-- Create tables section -------------------------------------------------

-- Table Users

CREATE TABLE [Users]
(
 [Email] Varchar(120) NOT NULL,
 [Password] Varchar(20) NOT NULL,
 [Activated] Bit DEFAULT 0 NOT NULL,
 [WantsNews] Bit DEFAULT 0 NOT NULL,
 [AppLanguage] Varchar(50) DEFAULT 'en_US' NOT NULL,
 [UseLiveTile] Bit DEFAULT 1 NOT NULL,
 [HasNewContent] Bit DEFAULT 1 NOT NULL,
 [UiDesign] Varchar(50) DEFAULT 'Default' NOT NULL
)
go

-- Add keys for table Users

ALTER TABLE [Users] ADD CONSTRAINT [Email] UNIQUE CLUSTERED ([Email])
go


