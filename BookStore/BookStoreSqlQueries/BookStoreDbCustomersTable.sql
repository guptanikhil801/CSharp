use BookStoreDb
go
 
Create table Customers(          
    CustId int identity NOT NULL primary key ,          
    FirstName varchar(50),          
    LastName varchar(50),
    PhoneNumber bigint,
    Email varchar(50) NOT NULL,    
    Password  varbinary(50) NOT NULL,
    ProfilePicture varchar(500)     
);
