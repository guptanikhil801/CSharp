use MISDB
go

CREATE TABLE Candidates_Bank_Det_Check (
  Id int NOT NULL,
  Candidate_Id  int NOT NULL,
  Field_Name int NOT NULL,
  Is_Verified int DEFAULT NULL,
  Lastupd_Stamp datetime DEFAULT NULL,
  Lastupd_User int DEFAULT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL
);