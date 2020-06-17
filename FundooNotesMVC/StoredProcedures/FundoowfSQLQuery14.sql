use Fundoowfdb
go

CREATE PROCEDURE spAddLabel 
    @Email NVARCHAR (MAX) ,                                           -- to Add new Label  
    @Details NVARCHAR (MAX)  
  as 
BEGIN TRY
    Insert into Labels(Email,Details)           
    Values(@Email,@Details)
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
