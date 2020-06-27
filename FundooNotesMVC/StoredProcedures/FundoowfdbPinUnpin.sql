use Fundoowfdb
go

Create procedure    spPinANote                                         -- To Pin a Note
    @NoteId int
as  
BEGIN TRY                     
   Update Notes            
   set IsPin=1              
   where  NoteId=@NoteId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go

Create procedure    spUnPinANote                                         -- To UnPin a Note
    @NoteId int
as  
BEGIN TRY                     
   Update Notes            
   set IsPin=0              
   where  NoteId=@NoteId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go