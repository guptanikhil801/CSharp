use MISDB
go                                          

CREATE TABLE Candidate_Techstack_Assignment(
  Id int NOT NULL PRIMARY KEY,
  Requirement_Id int NOT NULL
  CONSTRAINT FK_Candidate_Techstack_Assignment_Requirement_Id FOREIGN KEY (Requirement_Id)
  REFERENCES Company_Requirement (Id),
  Candidate_Id int NOT NULL
  CONSTRAINT FK_Candidate_Techstack_Id FOREIGN KEY (Candidate_Id)
  REFERENCES Fellowship_Candidates (Id),
  Assign_Date datetime DEFAULT NULL,
  Status_ varchar(20) DEFAULT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
);