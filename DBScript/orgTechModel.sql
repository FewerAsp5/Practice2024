DROP TABLE orgTechModel;
CREATE TABLE orgTechModel(
orgTechModelID int IDENTITY(1, 1) PRIMARY KEY, 
TechTypeID int, 
Model nvarchar(45),
FOREIGN KEY (TechTypeID) REFERENCES TechType(TechTypeID)
);