CREATE DATABASE ProductInfo;
GO

USE ProductInfo;
GO

CREATE TABLE Product ( id INT PRIMARY KEY NOT NULL IDENTITY(1, 1), name VARCHAR (100), description VARCHAR (200), price DECIMAL(18,0) );
GO

INSERT INTO Product
VALUES ('Produto1','Descricao1',10);
GO

INSERT INTO Product
VALUES ('Produto2','Descricao2',20);
GO

INSERT INTO Product
VALUES ('Produto3','Descricao3',30);
GO

INSERT INTO Product
VALUES ('Produto4','Descricao4',40);
GO

INSERT INTO Product
VALUES ('Produto5','Descricao5',50);
GO