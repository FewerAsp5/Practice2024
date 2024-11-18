DROP TABLE TYPE;
CREATE TABLE TYPE (
typeID int IDENTITY(1, 1) PRIMARY KEY,
role nvarchar(50)
);
INSERT INTO TYPE (role)
VALUES ('Менеджер');
INSERT INTO TYPE (role)
VALUES ('Мастер');
INSERT INTO TYPE (role)
VALUES ('Оператор');
INSERT INTO TYPE (role)
VALUES ('Клиент');