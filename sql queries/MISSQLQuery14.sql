use MISDB
go                                          

CREATE TABLE Tech_Type (
  Id int NOT NULL,
  Type_Name varchar(50) NOT NULL,
  Cur_Status char(1) DEFAULT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
);