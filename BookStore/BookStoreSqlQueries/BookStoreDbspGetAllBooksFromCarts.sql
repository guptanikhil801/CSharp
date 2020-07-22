Create procedure spGetAllBooksFromCarts                                        --  To Retreive All Books 
(            
    @Email varchar(50)        
) 
as           
    
BEGIN TRY                     
   select * from Carts where Email=@Email
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go