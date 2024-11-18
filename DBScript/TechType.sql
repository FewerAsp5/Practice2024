DROP TABLE TechType;
CREATE TABLE TechType (TechTypeID int IDENTITY(1, 1) PRIMARY KEY,
typeName nvarchar(10)
);
INSERT INTO TechType (typeName)
VALUES ('Компьютер');
INSERT INTO TechType (typeName)
VALUES ('Ноутбук');
INSERT INTO TechType (typeName)
VALUES ('Принтер');
INSERT INTO TechType (typeName)
VALUES ('Монитор');
INSERT INTO TechType (typeName)
VALUES ('Планшет');