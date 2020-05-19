use MISDB
go

CREATE TABLE Hired_Candidates (
  Id int NOT NULL PRIMARY KEY,
  First_Name varchar(100) NOT NULL,
  Middle_Name varchar(100) DEFAULT NULL,
  Last_Name varchar(100) NOT NULL,
  Email varchar(50) NOT NULL,
  Mobile_Num bigint NOT NULL,
  Hired_City varchar(50) NOT NULL,
  Hired_Date datetime NOT NULL,
  Degree varchar(100) NOT NULL,
  Aggregate_Per float DEFAULT NULL,
  Current_Pincode int DEFAULT NULL,
  Permanent_Pincode int DEFAULT NULL,
  Hired_Lab varchar(20) DEFAULT NULL,
  Attitude_Remark varchar(15) DEFAULT NULL,
  Communication_Remark varchar(15) DEFAULT NULL,
  Knowledge_Remark varchar(15) DEFAULT NULL,
  Status varchar(20) NOT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL,
);
