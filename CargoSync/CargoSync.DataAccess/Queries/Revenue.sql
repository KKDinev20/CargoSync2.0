CREATE TABLE [dbo].[Revenue] (
    [RevenueID] INT             NOT NULL,
    [Amount]    DECIMAL (18, 2) NOT NULL,
    [Month]     NVARCHAR (MAX)  NOT NULL,
    CONSTRAINT [PK_Revenue] PRIMARY KEY CLUSTERED ([RevenueID] ASC),
    CONSTRAINT [UQ_Revenue_DeliveryID] UNIQUE NONCLUSTERED ([RevenueID] ASC),
    CONSTRAINT [FK_Revenue_Deliveries] FOREIGN KEY ([RevenueID]) REFERENCES [dbo].[Deliveries] ([DeliveryID])
);

UPDATE [dbo].[Revenue]
SET Amount = 250
WHERE RevenueId = 101