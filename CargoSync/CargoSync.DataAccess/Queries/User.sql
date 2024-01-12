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

SET IDENTITY_INSERT [dbo].[Users] ON

INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (1, N'User1', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (2, N'User2', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (3, N'User3', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (4, N'User4', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (5, N'User5', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (6, N'User6', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (7, N'User7', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (8, N'User8', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (9, N'User9', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (10, N'User10', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (11, N'User11', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (12, N'User12', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (13, N'User13', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (14, N'User14', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (15, N'User15', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (16, N'User16', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (17, N'User17', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (18, N'User18', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (19, N'User19', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (20, N'User20', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (21, N'User21', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (22, N'User22', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (23, N'User23', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (24, N'User24', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (25, N'User25', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (26, N'User26', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (27, N'User27', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (28, N'User28', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (29, N'User29', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (30, N'User30', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (31, N'User31', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (32, N'User32', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (33, N'User33', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (34, N'User34', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (35, N'User35', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (36, N'User36', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (37, N'User37', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (38, N'User38', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (39, N'User39', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (40, N'User40', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (41, N'User41', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (42, N'User42', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (43, N'User43', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (44, N'User44', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (45, N'User45', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (46, N'User46', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (47, N'User47', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (48, N'User48', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (49, N'User49', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (50, N'User50', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (51, N'User51', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (52, N'User52', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (53, N'User53', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (54, N'User54', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (55, N'User55', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (56, N'User56', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (57, N'User57', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (58, N'User58', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (59, N'User59', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (60, N'User60', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (61, N'User61', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (62, N'User62', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (63, N'User63', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (64, N'User64', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (65, N'User65', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (66, N'User66', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (67, N'User67', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (68, N'User68', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (69, N'User69', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (70, N'User70', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (71, N'User71', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (72, N'User72', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (73, N'User73', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (74, N'User74', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (75, N'User75', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (76, N'User76', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (77, N'User77', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (78, N'User78', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (79, N'User79', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (80, N'User80', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (81, N'User81', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (82, N'User82', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (83, N'User83', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (84, N'User84', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (85, N'User85', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (86, N'User86', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (87, N'User87', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (88, N'User88', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (89, N'User89', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (90, N'User90', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (91, N'User91', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (92, N'User92', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (93, N'User93', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (94, N'User94', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (95, N'User95', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (96, N'User96', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (97, N'User97', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (98, N'User98', N'Driver')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (99, N'User99', N'Customer')
INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType]) VALUES (100, N'User100', N'Driver')
