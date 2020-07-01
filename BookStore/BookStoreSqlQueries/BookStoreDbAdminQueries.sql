use BookStoreDb
go
 
Create table Admins(          					     -- Admin Table
    Email varchar(50) Primary key,    
    Password  varbinary(50) NOT NULL, 
);
go

CREATE PROCEDURE spAddAdmin
                                                          -- to add new Admin
    @Email varchar(50),    
    @Password  varchar(50)
  as 
BEGIN TRY
    Insert into Admins(Email,Password)           
    Values(@Email,ENCRYPTBYPASSPHRASE('supersecuredkey123',@Password))
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
  go

Create procedure spAdminLogin								 --for Admin Login 
(            
  @Email varchar(50),    
  @Password  varchar(50)                      
)            
as  
BEGIN TRY                       
   select * from Admins where Email = @Email and Convert(varchar(50), DecryptByPassPhrase('supersecuredkey123', [Password])) = @Password 
END TRY  
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go