USE [Fundoowfdb]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteNote]    Script Date: 03-06-2020 11:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spDeleteNote]                                           -- To delete Note
(            
    @NoteId  int        
)            
as  
BEGIN TRY                        
   Delete from Notes where  NoteId=@NoteId 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH                 
