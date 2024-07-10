INSERT INTO Products
VALUES
	(1, 'Product1'),
	(2, 'Product2'),
	(3, 'Product3');

INSERT INTO Categories
VALUES
	(1, 'Category1'),
	(2, 'Category2'),
	(3, 'Category3');

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(3, 1);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;