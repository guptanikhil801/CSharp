use MISDB
go                                            

 CREATE TABLE App_Parameters (
  Id int NOT NULL,
  Key_Type varchar(20) NOT NULL,
  Key_Value varchar(20) NOT NULL,
  Key_Text varchar(80) DEFAULT NULL,
  Cur_Status char(1) DEFAULT NULL,
  Lastupd_User int DEFAULT NULL,
  Lastupd_Stamp datetime DEFAULT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL,
  Seq_Num int DEFAULT NULL
);