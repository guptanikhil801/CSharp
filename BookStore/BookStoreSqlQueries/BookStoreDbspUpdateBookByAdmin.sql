Create procedure    spUpdateBookByAdmin                                         -- to update Book details
@BookId int,
@Name NVARCHAR (MAX),   
@Author NVARCHAR (MAX),
@Description NVARCHAR (MAX),
@Image NVARCHAR (MAX),
@Price float,
@AvailableStock int,
@Rating float

as  
BEGIN TRY                     
   Update books            
   set Name=@Name,
   Author=@Author,
   Description=@Description,
   Image=@Image,
   Price=@Price,
   AvailableStock=@AvailableStock,
   Rating=@Rating
   where BookId=@BookId 
END TRY 
BEGIN CATCH 
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH           
go