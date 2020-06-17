use Fundoowfdb
go
Create procedure    spProfilePictureUpload                                         -- ProfilePicture upload
    @Email VARCHAR(50),
    @Image VARCHAR (500)
as  
BEGIN TRY                     
   Update Users            
   set ProfilePicture=@Image              
   where Email=@Email 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go