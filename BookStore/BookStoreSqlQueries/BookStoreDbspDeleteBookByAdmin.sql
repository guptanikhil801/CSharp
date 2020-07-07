use BookStoreDb
go

Create procedure spDeleteBookByAdmin           -- To delete Book from Database parmanantly
(            
    @BookId  int        
)            
as  
BEGIN TRY                        
   Delete from Books where BookId=@BookId 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH                 
go