use MISDB
go                                          

    CREATE TABLE Company_Requirement(
Id int NOT NULL PRIMARY KEY,
Company_Id int NOT NULL,
Candidate_Id int NOT NULL
CONSTRAINT FK_Candidate_Candidate_Id FOREIGN KEY (Candidate_Id)
REFERENCES Fellowship_Candidates(Id),
Requested_Month varchar(20) NOT NULL,
City varchar(20) DEFAULT NULL,
Is_Doc_Verification int DEFAULT 1,
Requirement_Doc_Path varchar(500) DEFAULT NULL,
No_Of_Engg int NOT NULL,
Tech_Stack_Id int NOT NULL,
Tech_Type_Id int NOT NULL,
Maker_Programs_Id int NOT NULL,
Lead_Id int NOT NULL,
Ideateion_Engg_Id int DEFAULT NULL,
Buddy_Engg_Id int  DEFAULT NULL,
Special_Remark text DEFAULT NULL,
Status_ int DEFAULT 1,
Creator_Stamp datetime DEFAULT NULL,
Creator_User int DEFAULT NULL  
);