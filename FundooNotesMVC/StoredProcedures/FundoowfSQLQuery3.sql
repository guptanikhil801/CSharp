use Fundoowfdb
go

Create procedure spLogin                                            --for Login 
(            
  @Email varchar(50),    
  @Password  varchar(50)                      
)            
as  
BEGIN TRY                       
   select * from Users where Email = @Email and Password =@Password 
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