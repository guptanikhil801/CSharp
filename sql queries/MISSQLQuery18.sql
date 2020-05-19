use  MISDB
go

  CREATE TABLE Lab(
  Id int NOT NULL PRIMARY KEY,
  Name varchar(50) DEFAULT NULL,
  Location varchar(50) DEFAULT NULL,
  Address  varchar(255) DEFAULT NULL,
  Status int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
); 