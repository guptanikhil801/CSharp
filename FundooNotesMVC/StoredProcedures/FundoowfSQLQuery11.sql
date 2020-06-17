Create procedure spDeleteNote                                           -- To delete Note
(            
    @Email VARCHAR (50),
    @NoteId  int        
)            
as  
BEGIN TRY                        
   Delete from Notes where Email=@Email and NoteId=@NoteId 
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