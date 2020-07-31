Create procedure    spUpdateAvailableStock                                         -- to update Book details
@BookId int,
@UpdatedAvailableStock int

as  
BEGIN TRY                     
   Update books            
   set 
   AvailableStock=@UpdatedAvailableStock
   where BookId=@BookId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH