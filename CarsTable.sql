CREATE TABLE [dbo].[Cars] (
    [Car ID]  INT        NOT NULL,
    [Make] VarCHAR (45) NOT NULL,
    [Model] VarCHAR (45) NOT NULL,
	[Year] VarCHAR (45) NOT NUll,
	[Image] Image NOT NULL,
    PRIMARY KEY  CLUSTERED ([Car ID] ASC )
);
