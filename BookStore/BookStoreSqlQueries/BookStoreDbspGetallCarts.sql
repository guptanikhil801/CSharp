
Create procedure spGetallCarts 
(
@Email varchar(50)
)
as

begin Try
select Carts.BookId, Carts.CartId, Carts.BookQuantity, Books.Name, Books.Author,
Books.Image, Books.Price
From Carts inner join Books on Carts.BookId = Books.BookId where Carts.Email=@Email;
end Try

BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH