use Fundoowfdb
go
Create procedure spDeleteLabel                                           -- To delete Label
(            
    @LabelId  int        
)            
as  
BEGIN TRY                        
   Delete from Labels where LabelId=@LabelId 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH                 
go