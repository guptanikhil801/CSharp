USE [Fundoowfdb]
GO

Create procedure    spArchiveNote                                         -- To Archive
    @NoteId int
as  
BEGIN TRY                     
   Update Notes            
   set IsArchive=1              
   where  NoteId=@NoteId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go
