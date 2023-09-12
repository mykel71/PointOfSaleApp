CREATE PROCEDURE [dbo].[spPurchase_Insert]
	@Item nvarchar(50),
	@Cost money,
	@CustomerId int
AS
	BEGIN
		INSERT INTO Purchase (Item, Cost, CustomerId)
		VALUES (@Item, @Cost, @CustomerId);
	END
