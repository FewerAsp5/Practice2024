DROP TABLE USERS;
CREATE TABLE USERS(
userID int IDENTITY(1, 1) PRIMARY KEY,
fio nvarchar(35),
phone nvarchar(15),
login nvarchar(10),
password nvarchar(10),
type int,
photo nvarchar(256)
FOREIGN KEY (type)REFERENCES TYPE(typeID)
);
