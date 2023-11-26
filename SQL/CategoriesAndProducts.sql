DROP TABLE IF EXISTS productcategories;
DROP TABLE IF EXISTS categories;
DROP TABLE IF EXISTS products;

CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
(1, 'Чиабатта с томатами'),
(2, 'Багет мини, с чесноком'),
(3, 'Батон половинка, нарезка'),
(4, 'Тартин зерновой'),
(5, 'Томаты Рост сливовидные, жёлтые'),
(6, 'Томаты Flamenco сливовидные'),
(7, 'Авокадо Хасс Артфрут, проверено спелое'),
(8, 'Малина Артфрут'),
(9, 'Котлеты из индейки'),
(10, 'Форель радужная, слабосолёная, ломтики'),
(11, 'Артезианская вода, с газом'),
(12, 'Лечебно-столовая вода Лузиньян, с газом'),
(13, 'Шоколад Ritter Sport молочный, цельный лесной орех');

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Categories
VALUES
(1, 'Хлеб'),
(2, 'Выпечка'),
(3, 'Овощи и фрукты'),
(4, 'Мясо'),
(5, 'Рыба'),
(6, 'Вода');

CREATE TABLE ProductCategories (
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	FOREIGN KEY (ProductId) REFERENCES Products(Id),
	FOREIGN KEY  (CategoryId) REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 1),
(1, 2),
(2, 2),
(3, 2),
(5, 3),
(6, 3),
(7, 3),
(8, 3),
(9, 4),
(10, 4),
(10, 5),
(11, 6),
(12, 6);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;
