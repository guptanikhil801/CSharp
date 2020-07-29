  Create procedure spDeleteCartRecord           -- To delete cart after order
(            
    @Email  nvarchar(max)       
)            
as  
BEGIN TRY                        
   Delete from Carts where Email=@Email
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH