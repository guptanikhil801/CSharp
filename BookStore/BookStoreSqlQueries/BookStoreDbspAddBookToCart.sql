CREATE PROCEDURE spAddBookToCart    -- to add book to Cart
    @Email varchar(50),    
    @BookId int
  as 
BEGIN TRY
    Insert into Carts(Email,BookId)           
    Values(@Email,@BookId)
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
  go