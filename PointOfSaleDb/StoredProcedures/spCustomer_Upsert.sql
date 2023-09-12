CREATE PROCEDURE [dbo].[spCustomer_Upsert]
	@CustomerId int output,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50)
AS
	BEGIN
		IF EXISTS (SELECT 1 FROM Customer WHERE Email = @Email)
		BEGIN
			UPDATE Customer SET
				FirstName = @FirstName,
				LastName = @LastName
			WHERE Email = @Email;
			SELECT @CustomerId = Id FROM Customer WHERE Email = @Email;
		END

		ELSE
		BEGIN
			INSERT INTO Customer (FirstName, LastName, Email)
			VALUES (@FirstName, @LastName, @Email);
			SELECT @CustomerId = SCOPE_IDENTITY();
		END

	END
