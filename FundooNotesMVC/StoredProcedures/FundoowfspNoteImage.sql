use Fundoowfdb
go
Create procedure    spNoteImage                                         -- NoteImage
    @NoteId int,
    @Image NVARCHAR (MAX)
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