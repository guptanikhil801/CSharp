use Fundoowfdb
go
Create procedure spAllNotes                                          --  To Retreive All Notes 
           
as    
BEGIN TRY                     
   select * from Notes where  IsArchive=0 and IsTrash=0 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go