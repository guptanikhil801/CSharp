use Fundoowfdb
go

CREATE PROCEDURE spAddNotes 
    @Email NVARCHAR (MAX) NULL,                                                             -- to add new Note 
    @Title NVARCHAR (MAX) NULL,
    @Description  NVARCHAR (MAX) ,   
    @Colour  NVARCHAR (MAX) ,    
    @Reminder NVARCHAR (MAX)  
  as 
BEGIN TRY
    Insert into Notes(Email,Title,Description,CreatedDate,ModifiedDate,Colour,Reminder,IsArchive,IsTrash,IsPin)           
    Values(@Email,@Title,@Description,GETUTCDATE(),GETUTCDATE(),@Colour,@Reminder,1,1,1)
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