use Fundoowfdb
go
CREATE TABLE Labels(                           -- Label Table
    Email   NVARCHAR (MAX) NULL,
    LabelId INT  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    Details NVARCHAR (MAX) NULL
);