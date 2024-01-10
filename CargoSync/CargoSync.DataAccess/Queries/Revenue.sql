INSERT INTO [dbo].[Revenue] ([DeliveryID], [Amount], [Month])
VALUES
    (1, 1000.00, 'January'),
    (2, 1200.50, 'January'),
    (3, 800.75, 'February'),
    (4, 900.00, 'February'),
    (5, 1500.25, 'March'),
    (6, 1800.75, 'March'),
    (7, 950.50, 'April'),
    (8, 1100.25, 'April'),
    (9, 1300.75, 'May'),
    (10, 1000.00, 'May');

CREATE TABLE [dbo].[Revenue] (
    [RevenueID] INT             NOT NULL,
    [Amount]    DECIMAL (18, 2) NOT NULL,
    [Month]     NVARCHAR (MAX)  NOT NULL,
    CONSTRAINT [PK_Revenue] PRIMARY KEY CLUSTERED ([RevenueID] ASC),
    CONSTRAINT [UQ_Revenue_DeliveryID] UNIQUE NONCLUSTERED ([RevenueID] ASC),
    CONSTRAINT [FK_Revenue_Deliveries] FOREIGN KEY ([RevenueID]) REFERENCES [dbo].[Deliveries] ([DeliveryID])
);

