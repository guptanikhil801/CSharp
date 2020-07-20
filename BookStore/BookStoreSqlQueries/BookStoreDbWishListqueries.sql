create table WishLists(
WishlistId int primary key identity(1,1),
Email NVARCHAR (MAX),
BookId int );
go

CREATE PROCEDURE spAddBookToWishList     -- to add book to wishlist
    @Email varchar(50),    
    @BookId int
  as 
BEGIN TRY
    Insert into WishLists(Email,BookId)           
    Values(@Email,@BookId)
END TRY
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
  go

  Create procedure spDeleteBookFromWishList           -- To delete book from wishlist
(            
    @WishlistId  int        
)            
as  
BEGIN TRY                        
   Delete from WishLists where WishlistId=@WishlistId 
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH                 
go

Create procedure spGetAllBooksFromWishLists                                         --  To Retreive All Books 
(            
    @Email varchar(50)        
) 
as           
    
BEGIN TRY                     
   select * from WishLists where Email=@Email
END TRY 
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH          
go