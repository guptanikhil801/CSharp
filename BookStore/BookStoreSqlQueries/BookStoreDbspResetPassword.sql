use BookStoreDb                                       -- Reset Password
go

CREATE PROCEDURE spResetPassword                                         
    @Email varchar(50),    
    @Password  varchar(50)
             
as 
BEGIN TRY                      
   Update Customers             
   set          
   Password = ENCRYPTBYPASSPHRASE('supersecuredkey123',@Password)         
   where Email=@Email  
  END TRY 
 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH       
go