use MISDB
go

CREATE TABLE Candidate_Bank_Det(
  Id int NOT NULL PRIMARY KEY,
  Candidate_Id int NOT NULL
CONSTRAINT FK_candidate_bank_det_Candidate_Id FOREIGN KEY (Candidate_Id)
REFERENCES Fellowship_Candidates(Id),
 Name varchar(100) NOT NULL,
  Account_Num int NOT NULL,
  Is_Account_Num_Verified int DEFAULT 0,
  Ifsc_Code varchar(20) NOT NULL,
  Is_Ifsc_Code_Verified int DEFAULT 0,
  Pan_Number varchar(10) DEFAULT NULL,
  Is_Pan_Number_Verified int DEFAULT 0,
  Addhaar_Num int NOT NULL,
  Is_Addhaar_Num_Verified int DEFAULT 0,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL,
); 