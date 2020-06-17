use Fundoowfdb
go
Create procedure    spProfilePictureUpload                                         -- ProfilePicture
    @NoteId int,
    @Image VARCHAR (500)
as  
BEGIN TRY                     
   Update Notes            
   set Image=@Image              
   where NoteId=@NoteId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go