use BookStoreDb
go

CREATE PROCEDURE spAddCustomer
                                                                 -- to add new Customer
    @FirstName varchar(50),
    @LastName varchar(50), 
    @PhoneNumber bigint,  
    @Email varchar(50),    
    @Password  varchar(50),
    @ProfilePicture varchar(500)  
  as 
BEGIN TRY
    Insert into Customers(FirstName,LastName,PhoneNumber,Email,Password,ProfilePicture)           
    Values(@FirstName,@LastName,@PhoneNumber,@Email,ENCRYPTBYPASSPHRASE('supersecuredkey123',@Password),@ProfilePicture)
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
  go