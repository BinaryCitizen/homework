CREATE TABLE [dbo].[Users]
(
	[IdUsers] INT NOT NULL PRIMARY KEY, 
    [Login] NCHAR(10) NULL, 
    [Password] NCHAR(10) NULL, 
    [Phone] INT NULL 
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'login',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'IdUsers'