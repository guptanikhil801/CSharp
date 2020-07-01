use BookStoreDb
go

Create procedure spLogin                                            --for Login 
(            
  @Email varchar(50),    
  @Password  varchar(50)                      
)            
as  
BEGIN TRY                       
   select * from Customers where Email = @Email and Convert(varchar(50), DecryptByPassPhrase('supersecuredkey123', [Password])) = @Password 
END TRY  
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go