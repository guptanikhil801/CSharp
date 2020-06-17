use Fundoowfdb
go
Create procedure    spTrashNote                                         -- To Trash
    @NoteId int
as  
BEGIN TRY                     
   Update Notes            
   set IsTrash=1              
   where  NoteId=@NoteId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go