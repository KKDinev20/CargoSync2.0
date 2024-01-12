INSERT INTO [dbo].[Users] ([DeliveryID], [UserName], [UserType])
VALUES
    (1, 'John Doe', 'Customer'),
    (2, 'Jane Smith', 'Customer'),
    (3, 'Mark Johnson', 'Driver'),
    (4, 'Emily White', 'Driver'),
    (5, 'Chris Brown', 'Customer'),
    (6, 'Sarah Davis', 'Customer'),
    (7, 'Alex Turner', 'Driver'),
    (8, 'Olivia Green', 'Driver'),
    (9, 'Ryan Wilson', 'Customer'),
    (10, 'Emma Carter', 'Customer');

CREATE TABLE [dbo].[Users] (
    [UserID]   INT            NOT NULL,
    [UserName] NVARCHAR (MAX) NOT NULL,
    [UserType] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [UQ_Users_DeliveryID] UNIQUE NONCLUSTERED ([UserID] ASC),
    CONSTRAINT [FK_Users_Deliveries] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Deliveries] ([DeliveryID]) ON DELETE CASCADE
);
