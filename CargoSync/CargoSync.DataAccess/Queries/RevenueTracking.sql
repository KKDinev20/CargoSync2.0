CREATE TABLE [dbo].[Revenues] (
    [RevenueID] INT IDENTITY(1,1) NOT NULL,
    [Amount] DECIMAL(10,2) NOT NULL,
    [TransactionDate] DATETIME NOT NULL,
    [TransactionID] INT NOT NULL,
    CONSTRAINT [PK_Revenues] PRIMARY KEY CLUSTERED ([RevenueID] ASC),
    CONSTRAINT [FK_Revenues_Deliveries] FOREIGN KEY ([TransactionID]) REFERENCES [dbo].[Deliveries] ([DeliveryID])
);

INSERT INTO Revenues(TransactionID, Amount, TransactionDate) VALUES (1, 150.75, '2023-01-01 08:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (2, 200.50, '2023-01-02 10:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (3, 75.25, '2023-01-03 12:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (4, 300.00, '2023-01-04 15:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (5, 120.00, '2023-01-05 16:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (6, 180.50, '2023-01-06 18:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (7, 220.25, '2023-01-07 21:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (8, 90.75, '2023-01-08 22:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (9, 250.00, '2023-01-09 23:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (10, 300.00, '2023-01-10 01:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (11, 160.25, '2023-01-11 03:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (12, 130.50, '2023-01-12 04:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (13, 270.75, '2023-01-13 05:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (14, 200.00, '2023-01-14 06:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (15, 110.00, '2023-01-15 08:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (16, 240.50, '2023-01-16 09:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (17, 180.25, '2023-01-17 10:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (18, 130.75, '2023-01-18 11:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (19, 290.00, '2023-01-19 13:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (20, 170.50, '2023-01-20 14:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (21, 90.25, '2023-01-21 15:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (22, 210.75, '2023-01-22 16:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (23, 260.00, '2023-01-23 18:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (24, 150.50, '2023-01-24 19:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (25, 120.00, '2023-01-25 20:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (26, 280.25, '2023-01-26 21:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (27, 230.75, '2023-01-27 23:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (28, 190.00, '2023-01-28 00:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (29, 110.50, '2023-01-29 01:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (30, 320.75, '2023-01-30 02:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (31, 260.00, '2023-01-31 04:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (32, 150.50, '2023-02-01 05:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (33, 120.00, '2023-02-02 06:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (34, 280.25, '2023-02-03 07:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (35, 230.75, '2023-02-04 09:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (36, 190.00, '2023-02-05 10:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (37, 110.50, '2023-02-06 11:30:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (38, 320.75, '2023-02-07 12:45:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (39, 260.00, '2023-02-08 14:00:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (40, 150.50, '2023-02-09 15:15:00');
INSERT INTO Revenues (TransactionID, Amount, TransactionDate) VALUES (41, 120.00, '2023-02-10 16:30:00');