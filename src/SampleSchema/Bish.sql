CREATE TABLE [dbo].[Bish]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Bash] VARCHAR(255) NOT NULL DEFAULT cast(getdate() as varchar(255)), 
    [Bosh] UNIQUEIDENTIFIER NOT NULL DEFAULT newid(), 
    [Tosh] INT NOT NULL
)
