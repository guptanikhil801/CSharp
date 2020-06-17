use Fundoowfdb
go
Create procedure spGetAllLabels                                          --  To Retreive All Labels
(            
  @Email VARCHAR (50)                         
)            
as    
BEGIN TRY                     
   select * from Labels where Email = @Email
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