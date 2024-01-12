CREATE TABLE [dbo].[Deliveries] (
    [DeliveryID]  INT            IDENTITY (1, 1) NOT NULL,
    [Destination] NVARCHAR (MAX) NOT NULL,
    [ETA]         NVARCHAR (MAX) NOT NULL,
    [Status]      NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Deliveries] PRIMARY KEY CLUSTERED ([DeliveryID] ASC)
);

