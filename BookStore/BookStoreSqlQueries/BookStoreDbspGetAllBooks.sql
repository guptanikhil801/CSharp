use BookStoreDb
go
Create procedure spGetAllBooks                                          --  To Retreive All Books 
as           
    
BEGIN TRY                     
   select * from Books 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go