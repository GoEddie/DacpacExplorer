ALTER TABLE [dbo].[Bish]
	ADD CONSTRAINT [fk_bish_tosh_bing_bong]
	FOREIGN KEY (tosh)
	REFERENCES [bing] (bong)
