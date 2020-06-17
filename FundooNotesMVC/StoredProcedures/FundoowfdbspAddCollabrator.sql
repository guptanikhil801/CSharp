USE [Fundoowfdb]
GO
/****** Object:  StoredProcedure [dbo].[spAddCollabrator]    Script Date: 10-06-2020 16:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spAddCollabrator] 
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
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
