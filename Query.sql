CREATE DATABASE q2;
USE q2;

CREATE TABLE Categories
(
	id INT IDENTITY, 
	сatename VARCHAR(30) NOT NULL,

	CONSTRAINT PK_Categories_Id PRIMARY KEY(id),
	CONSTRAINT UQ_Categories_Catename UNIQUE(сatename)
);

CREATE TABLE Products
(
	id INT IDENTITY,
	productname VARCHAR(30) NOT NULL,

	CONSTRAINT PK_Products_Id PRIMARY KEY(id),
);

CREATE TABLE Products_Categories
(
	id INT IDENTITY,
	categories_id INT,
	product_id INT NOT NULL,

	CONSTRAINT PK_Products_Categories_Id PRIMARY KEY(id),
	CONSTRAINT FK_Categories_Id FOREIGN KEY(categories_id) REFERENCES  Categories(id),
	CONSTRAINT FK_Product_Id FOREIGN KEY(product_id) REFERENCES Products(id)
);

INSERT INTO Categories VALUES
('Синтезатор'),
('Акустическая гитара'),
('Электронная гитара'),
('Микрофон'),
('Наушники');

INSERT INTO Products VALUES
('KORG Pa600'),
('YAMAHA F310'),
('FENDER STRATOCASTER MN'),
('SHURE SM7B'),
('Beyerdynamic DT 770 PRO'),
('FOCUSRITE Scarlett 2i2 3G');

select * from Categories;
select * from Products_Categories;

INSERT INTO Products_Categories VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(NULL, 6);

SELECT productname AS 'Имя продукта', сatename AS 'Имя Категории' FROM Products_Categories 
JOIN Products ON product_id=Products.id 
LEFT JOIN Categories ON categories_id=Categories.id;