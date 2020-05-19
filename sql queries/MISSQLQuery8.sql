use MISDB
go                                            

CREATE TABLE Candidate_Qualification(
  Id int NOT NULL PRIMARY KEY,
  Candidate_Id int NOT NULL
CONSTRAINT FK_Candidate_Qual_Candidate_Id FOREIGN KEY (Candidate_Id)
 REFERENCES Fellowship_Candidates(Id),
  Diploma int DEFAULT 0,
  Degree_Name varchar(10) NOT NULL,
  Is_Degree_Name_Verified int DEFAULT 0,
  Employee_Decipline varchar(100) NOT NULL,
  Is_Employee_Decipline_Verified int DEFAULT 0,
  Passing_Year int NOT NULL,
  Is_Passing_Year_Verified int DEFAULT 0,
  Aggregate_Per float DEFAULT NULL,
  Final_Year_Per float DEFAULT NULL,
  Is_Final_Year_Per_Verified int DEFAULT 0,
  Training_Institute varchar(20) NOT NULL,
  Is_Training_Institute_Verified int DEFAULT 0,
  Training_Duration_Month int DEFAULT NULL,
  Is_Training_Duration_Month_Verified int DEFAULT 0,
  Other_Training varchar(255) DEFAULT NULL,
  Is_Other_Training_Verified int DEFAULT 0,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL);

