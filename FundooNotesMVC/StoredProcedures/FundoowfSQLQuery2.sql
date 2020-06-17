use Fundoowfdb
go
 
Create table Users(          
    UserId int identity NOT NULL primary key ,          
    FirstName varchar(50),          
    LastName varchar(50),
    PhoneNumber int,
    Email varchar(50) NOT NULL,    
    Password  varchar(50) NOT NULL,
    ProfilePicture varchar(500)     
);