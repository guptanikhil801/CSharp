Create procedure    spUpdateNote                                         -- to update Note
    @NoteId int,
    @Email varchar(50),
    @Title NVARCHAR (MAX) NULL,
    @Colour  NVARCHAR (MAX),
    @Description  NVARCHAR (MAX),
    @Reminder NVARCHAR (MAX)   
as  
BEGIN TRY                     
   Update Notes            
   set Title=@Title,            
   Colour=@Colour,            
   Description=@Description, 
   ModifiedDate=GETUTCDATE(),        
   Reminder=@Reminder               
   where Email=@Email and NoteId=@NoteId 
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