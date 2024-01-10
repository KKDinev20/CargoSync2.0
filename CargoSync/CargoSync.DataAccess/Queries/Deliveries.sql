INSERT INTO [dbo].[Deliveries] ([Destination], [ETA], [Status]) VALUES ('Barcelona-Rome', '08:45:00', 'On going');
INSERT INTO [dbo].[Deliveries] ([Destination], [ETA], [Status]) VALUES ('Vienna-Paris', '10:30:00', 'Scheduled');
INSERT INTO [dbo].[Deliveries] ([Destination], [ETA], [Status]) VALUES ('Stockholm-Madrid', '12:15:00', 'Completed');

CREATE TABLE [dbo].[Deliveries] (
    [DeliveryID]  INT            IDENTITY (1, 1) NOT NULL,
    [Destination] NVARCHAR (MAX) NOT NULL,
    [ETA]         NVARCHAR (MAX) NOT NULL,
    [Status]      NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Deliveries] PRIMARY KEY CLUSTERED ([DeliveryID] ASC)
);

