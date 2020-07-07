use BookStoreDb
go

CREATE PROCEDURE spAddBookByAdmin 
    @Name NVARCHAR (MAX) ,                                           -- to Add new Book 
    @Author NVARCHAR (MAX),
    @Description  NVARCHAR (MAX) ,   
    @Image  NVARCHAR (MAX) ,    
    @Price float,
    @AvailableStock int,
    @Rating float    
  as 
BEGIN TRY
    Insert into Books(Name,Author,Description,Image,Price,AvailableStock,Rating)           
    Values(@Name,@Author,@Description,@Image,@Price,@AvailableStock,@Rating)
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
  go