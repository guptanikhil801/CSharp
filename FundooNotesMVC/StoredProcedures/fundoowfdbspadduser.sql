USE [Fundoowfdb]
GO
/****** Object:  StoredProcedure [dbo].[spAddUser]    Script Date: 03-06-2020 21:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spAddUser] 
                                                                 -- to add new user 
    @FirstName varchar(50),
    @LastName varchar(50), 
    @PhoneNumber bigint,  
    @Email varchar(50),    
    @Password  varchar(50),
    @ProfilePicture varchar(500)  
  as 
BEGIN TRY
    Insert into Users(FirstName,LastName,PhoneNumber,Email,Password,ProfilePicture)           
    Values(@FirstName,@LastName,@PhoneNumber,@Email,ENCRYPTBYPASSPHRASE('superkey123',@Password),@ProfilePicture)
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
