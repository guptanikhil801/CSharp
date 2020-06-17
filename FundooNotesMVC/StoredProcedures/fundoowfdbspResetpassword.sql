USE [Fundoowfdb]
GO
/****** Object:  StoredProcedure [dbo].[spResetPassword]    Script Date: 03-06-2020 21:38:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spResetPassword]                                         
    @Email varchar(50),    
    @Password  varchar(50)
             
as 
BEGIN TRY                      
   Update Users             
   set          
   Password=ENCRYPTBYPASSPHRASE('superkey123',@Password)         
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
