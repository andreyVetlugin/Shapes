CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name VARCHAR(150)
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name VARCHAR(150)
);

CREATE TABLE ProductCategories (
	ProductId INT,
	CategoryId INT,
	PRIMARY KEY (ProductId, CategoryId),
  	FOREIGN KEY ProductFK(ProductId)
      REFERENCES Products(Id),
  	FOREIGN KEY CategoryFK(CategoryId)
      REFERENCES Categories(Id)
);