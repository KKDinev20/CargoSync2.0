CREATE TABLE [dbo].[Users] (
    [UserID]   INT            NOT NULL,
    [UserName] NVARCHAR (MAX) NOT NULL,
    [UserType] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [UQ_Users_DeliveryID] UNIQUE NONCLUSTERED ([UserID] ASC),
    CONSTRAINT [FK_Users_Deliveries] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Deliveries] ([DeliveryID]) ON DELETE CASCADE
);
