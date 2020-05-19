use MISDB
go                                           

CREATE TABLE Maker_Program(
  Id int NOT NULL PRIMARY KEY,             
  Program_Name varchar NOT NULL,
  Program_Type varchar(10) DEFAULT NULL,
  Program_Link text DEFAULT NULL,
  Tech_Stack_Id int DEFAULT NULL
  CONSTRAINT FK_Maker_Program_Tech_Stack_Id FOREIGN KEY (Tech_Stack_Id)
  REFERENCES  Tech_Stack(Id),  
  Tech_Type_Id int NOT NULL
  CONSTRAINT FK_Maker_Program_Tech_Type_Id FOREIGN KEY (Tech_Type_Id)
  REFERENCES Tech_Type(Id),
  Is_Program_Approved int,
  Description_ varchar(500) DEFAULT NULL,
  Status_ int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL,
);