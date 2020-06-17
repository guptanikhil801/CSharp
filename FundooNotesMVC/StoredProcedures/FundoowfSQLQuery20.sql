use Fundoowfdb
go

CREATE PROCEDURE spAddCollabrator 
    @UserEmail NVARCHAR (MAX) ,                                           -- to Add new Collabrator  
    @CollabratorEmail NVARCHAR (MAX),
    @NoteId INT
  as 
BEGIN TRY
    Insert into Collabrators(UserEmail,CollabratorEmail,NoteId)           
    Values(@UserEmail,@CollabratorEmail,@NoteId)
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
  go