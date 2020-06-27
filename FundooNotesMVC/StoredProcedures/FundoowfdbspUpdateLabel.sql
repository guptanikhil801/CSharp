use Fundoowfdb
go

Create procedure    spUpdateLabel                                         -- to update Label
    @LabelId int,
    @Details NVARCHAR (MAX)
as  
BEGIN TRY                     
   Update Labels            
   set Details=@Details              
   where LabelId=@LabelId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go