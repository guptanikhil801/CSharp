Create procedure spDeleteBookFromCart     -- To delete book from cart
(            
    @CartId  int        
)            
as  
BEGIN TRY                        
   Delete from Carts where CartId=@CartId
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH                 
go