use Fundoowfdb
go
Create procedure spGetAllPinnedNotes                                          --  To Retreive All Pinned Notes By Email
(            
  @Email NVARCHAR (MAX)                        
)            
as    
BEGIN TRY                     
   select * from Notes where Email = @Email and IsArchive=0 and IsTrash=0 and IsPin=1
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go