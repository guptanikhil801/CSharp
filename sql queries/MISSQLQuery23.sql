use MISDB
go                                            

CREATE TABLE Lab_Threshold(
  Id int NOT NULL PRIMARY KEY,
  Lab_Id int NOT NULL
  CONSTRAINT FK_Lab_Lab_Id FOREIGN KEY (Lab_Id)
  REFERENCES Lab(Id),
  Lab_Capacity varchar(50) DEFAULT NULL,
  Lead_Threshold int DEFAULT NULL,
  Ideation_Engg_Threshold int DEFAULT NULL,
  Buddy_Engg_Threshold int DEFAULT NULL,
  Status_ int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL, 
  );