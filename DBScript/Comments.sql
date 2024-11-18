DROP TABLE Comments;
CREATE TABLE Comments (commentID int IDENTITY(1, 1) PRIMARY KEY, 
message nvarchar(300),
requestID int,
FOREIGN KEY (requestID) REFERENCES Requests(requestID) ON DELETE CASCADE
);