use BookStoreDb
go                                         -- Books Table
Create table Books(          
    BookId int identity  primary key ,          
    Name NVARCHAR (MAX) Not NULL,
    Author NVARCHAR (MAX) NOT NULL,
	Image NVARCHAR (MAX),
    Price float NOT NULL,
	AvailableStock int ,
    Description  NVARCHAR (MAX) ,   
    Rating float,
    Review  NVARCHAR (MAX)
);