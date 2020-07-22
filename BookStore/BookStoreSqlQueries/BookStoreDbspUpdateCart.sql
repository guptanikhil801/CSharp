Create procedure    spUpdateCart                 -- to update Cart details
@CartId int ,
@BookQuantity int 

as  
BEGIN TRY                     
   Update Carts            
   set BookQuantity=@BookQuantity
   where CartId=@CartId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go