CREATE procedure    spUpdateAvailableStock                                         -- to update Book details
@BookId int,
@PurchaseQuantity int

as  
BEGIN TRY                     
   Update books            
   set 
   AvailableStock=AvailableStock-@PurchaseQuantity
   where BookId=@BookId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH