use MISDB
go                                            

CREATE TABLE Mentor(
  Id int NOT NULL PRIMARY KEY,
  Name varchar(50) DEFAULT NULL,
  Mentor_Type varchar(20) DEFAULT NULL,
  Lab_Id int NOT NULL
  CONSTRAINT FK_mentor_lab_id FOREIGN KEY (Lab_Id)
  REFERENCES Lab(Id),
  Status int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
);