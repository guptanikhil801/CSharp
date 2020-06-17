use Fundoowfdb
go
Create procedure spRemoveCollabrator                                           -- To Remove Collabrator
(            
    @CollabId  int        
)            
as  
BEGIN TRY                        
   Delete from Collabrators where CollabId=@CollabId 
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