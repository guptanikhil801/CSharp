use Fundoowfdb
go
Create procedure spGetAllNotes                                          --  To Retreive All Notes
(            
  @Email NVARCHAR (MAX)                         
)            
as    
BEGIN TRY                     
   select * from Notes where Email = @Email and IsArchive=0 and IsTrash=0 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go