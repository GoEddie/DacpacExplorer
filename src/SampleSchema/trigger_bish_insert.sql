CREATE TRIGGER [trigger_bish_insert]
	ON [dbo].[bish]
	FOR DELETE, INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON
		if exists(select * from inserted where Tosh = 99)
			raiserror('errrrrrrm', 2, 1)
	END
