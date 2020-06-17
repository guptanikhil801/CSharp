USE [Fundoowfdb]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCollabrators]    Script Date: 10-06-2020 17:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spGetAllCollabrators]                                          --  To Retreive All Collabrators
(            
  @NoteId int                         
)            
as    
BEGIN TRY                     
   select * from Collabrators where NoteId = @NoteId
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
