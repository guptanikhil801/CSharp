use MISDB
go                                        

CREATE TABLE User_Details (
  Id int NOT NULL PRIMARY KEY,
  Email varchar(50) NOT NULL,
  First_Name varchar(100) NOT NULL,
  Last_Name varchar(100) NOT NULL,
  Password varchar(15) NOT NULL,
  Contact_Number bigint NOT NULL,
  Verified bit DEFAULT NULL,
CONSTRAINT AK_TransactionID UNIQUE(Email)
); 