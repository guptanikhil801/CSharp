use MISDB
go                                            

CREATE TABLE Mentor_Techstack(
  Id int NOT NULL PRIMARY KEY,
  Mentor_Id int NOT NULL
  CONSTRAINT FK_Mentor_Mentor_Id FOREIGN KEY (Mentor_Id)
  REFERENCES Mentor(Id),
  Tech_Stack_Id int NOT NULL
   CONSTRAINT FK_Mentor_Tech_Stack_Id FOREIGN KEY (Tech_Stack_Id)
   REFERENCES Tech_Stack (Id),
  Status_ int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL 
); 