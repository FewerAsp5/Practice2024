DROP TABLE Requests;
CREATE TABLE Requests(requestID int IDENTITY(1, 1) PRIMARY KEY,
startDate DATE,
problemDescryption nvarchar(300), 
requestStatus nvarchar(25),
complectionDate DATE,
repairParts nvarchar(300),
orgTechModel int,
masterID int,
clientID int,
FOREIGN KEY (orgTechModel) REFERENCES orgTechModel(orgTechModelID),
FOREIGN KEY (masterID) REFERENCES USERS(userID),
FOREIGN KEY (clientID) REFERENCES USERS(userID)
);