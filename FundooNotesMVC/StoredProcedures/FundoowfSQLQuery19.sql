use Fundoowfdb
go
CREATE TABLE Collabrators (
    UserEmail NVARCHAR (MAX) NOT NULL,
    CollabId INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    CollabratorEmail NVARCHAR (MAX) NULL,
    NoteId INT DEFAULT ((0)) NOT NULL
);