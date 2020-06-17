use Fundoowfdb
go

Create procedure spDeleteLabel                                           -- To delete Label
(            
    @Email VARCHAR (50),
    @LabelId  int        
)            
as  
BEGIN TRY                        
   Delete from Labels where Email=@Email and LabelId=@LabelId 
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