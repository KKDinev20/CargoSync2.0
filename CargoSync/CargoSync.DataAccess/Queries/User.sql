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

DELETE FROM Users

DECLARE @Counter INT = 1

WHILE @Counter <= 100
BEGIN
    INSERT INTO [dbo].[Users] ([UserID], [UserName], [UserType])
    VALUES
        (@Counter, 'User' + CAST(@Counter AS NVARCHAR(10)), 
         CASE WHEN @Counter % 2 = 0 THEN 'Driver' ELSE 'Customer' END)

    SET @Counter = @Counter + 1
END