use MISDB
go                                           

CREATE TABLE Candidate_Docs(
  Id int NOT NULL PRIMARY KEY,
  Candidate_Id int NOT NULL
CONSTRAINT FK_Candidate_Docs_Candidate_Id FOREIGN KEY (Candidate_Id)
REFERENCES Fellowship_Candidates(Id),
  Doc_Type varchar(20) DEFAULT NULL,
  Doc_Path varchar(500) DEFAULT NULL,
  Status int DEFAULT 1,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL);