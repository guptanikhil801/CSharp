use Fundoowfdb
go
Create procedure spGetAllCollabrators                                          --  To Retreive All Collabrators
(            
  @UserEmail VARCHAR (50)                         
)            
as    
BEGIN TRY                     
   select * from Collabrators where UserEmail = @UserEmail
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