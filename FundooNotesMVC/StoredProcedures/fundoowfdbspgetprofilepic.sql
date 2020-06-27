use Fundoowfdb
go
Create procedure spGetProfilePic                                          --  To Retreive profile pic By Email
(            
  @Email VARCHAR (50)                         
)            
as    
BEGIN TRY                     
   select ProfilePicture from Users where Email = @Email 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure
END CATCH          
go