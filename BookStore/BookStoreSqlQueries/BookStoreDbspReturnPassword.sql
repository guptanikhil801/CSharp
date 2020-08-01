Create procedure spReturnPassword                                            --for Login 
(            
  @Email varchar(50)   
)            
as  
BEGIN TRY                       
   select Convert(varchar(50), DecryptByPassPhrase('supersecuredkey123', [Password])) as ReturnPassword from Customers where Email = @Email 
END TRY  
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH