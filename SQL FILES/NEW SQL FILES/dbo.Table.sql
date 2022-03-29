CREATE TABLE [dbo].[Table] (
    [RentID]   INT        NOT NULL,
    [CustName] NCHAR (10) NOT NULL,
    [RentDate] DATE       NOT NULL,
    [RentFee]  INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([RentID] ASC)
);

