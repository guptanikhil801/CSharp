use MISDB
go                                            

CREATE TABLE Tech_Type (
  Id int NOT NULL PRIMARY KEY,
  Type_Name varchar(50) NOT NULL,
  Cur_Status char(1) DEFAULT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
);

CREATE TABLE Tech_Stack (
  Id int NOT NULL PRIMARY KEY,
  Tech_Name varchar(50) NOT NULL,
  Image_Path varchar(500) DEFAULT NULL,
  Framework text DEFAULT NULL,
  Cur_Status char(1) DEFAULT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
); 