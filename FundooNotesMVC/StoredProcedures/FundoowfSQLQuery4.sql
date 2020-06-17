use Fundoowfdb                                       -- Reset Password
go

CREATE PROCEDURE spResetPassword                                         
    @Email varchar(50),    
    @Password  varchar(50)
             
as 
BEGIN TRY                      
   Update Users             
   set          
   Password=@Password         
   where Email=@Email  
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