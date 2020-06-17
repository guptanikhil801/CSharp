use Fundoowfdb
go

Create procedure    spUpdateLabel                                         -- to update Label
    @LabelId int,
    @Email varchar(50),
    @Details NVARCHAR (MAX)
as  
BEGIN TRY                     
   Update Labels            
   set Details=@Details              
   where Email=@Email and LabelId=@LabelId 
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