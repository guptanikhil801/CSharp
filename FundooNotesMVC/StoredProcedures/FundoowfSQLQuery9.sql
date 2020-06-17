USE [Fundoowfdb]
GO
/****** Object:  StoredProcedure [dbo].[spGetNoteById]    Script Date: 26-05-2020 15:51:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spGetNoteById]                                          --  to retreive note by id
(            
  @Email VARCHAR (50),    
  @NoteId  int                      
)            
as    
BEGIN TRY                     
   select * from Notes where Email = @Email and NoteId =@NoteId and IsArchive=0 and IsTrash=0
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
