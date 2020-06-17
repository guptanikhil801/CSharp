use Fundoowfdb
go
 
Create table Notes(          
    NoteId int identity NOT NULL primary key ,          
    Email NVARCHAR (MAX) NULL,
    Title NVARCHAR (MAX) NULL,
    Description  NVARCHAR (MAX) ,
    CreatedDate  DATETIME2 (7)  ,
    ModifiedDate DATETIME2 (7)  ,
    Image  NVARCHAR (MAX) ,
    Colour  NVARCHAR (MAX) ,
    Reminder NVARCHAR (MAX) ,
    IsArchive BIT  NOT NULL,
    IsTrash BIT  NOT NULL,
    IsPin  BIT  NOT NULL,
);