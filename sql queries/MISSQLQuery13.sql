use MISDB
go                                      

CREATE TABLE Company(
  Id int NOT NULL PRIMARY KEY,
  Name varchar(50) NOT NULL,
  Address varchar(150) DEFAULT NULL,
  Location varchar(50) DEFAULT NULL,
  Status int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL,
);