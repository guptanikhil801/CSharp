use MISDB
go                                           

CREATE TABLE Mentor_Ideation_Map(
  Id int NOT NULL PRIMARY KEY,
  Mentor_Id int NOT NULL
  CONSTRAINT FK_Mentor_Ideation_Map_Mentor_Id FOREIGN KEY (Mentor_Id) 
  REFERENCES Mentor(Id),
  Status int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
);