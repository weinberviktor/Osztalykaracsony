--CREATE DATABASE mikulas;
--USE mikulas;

CREATE TABLE emberek(
id INT PRIMARY KEY IDENTITY,
nev VARCHAR(50),
osztaly VARCHAR(10)
);

CREATE TABLE belevalok(
id INT PRIMARY KEY IDENTITY, 
nev VARCHAR(50),
egysegar int,
);

CREATE TABLE csomagok(
id INT PRIMARY KEY IDENTITY,
kitol int  FOREIGN KEY REFERENCES emberek(id),
kinek int FOREIGN KEY REFERENCES emberek(id),
ev int
);

CREATE TABLE osszetetel(
id INT PRIMARY KEY IDENTITY, 
csomag int FOREIGN KEY REFERENCES csomagok(id),
belevalo int FOREIGN KEY REFERENCES belevalok(id),
mennyiseg int
);

INSERT INTO belevalok VALUES
('répa', 15),
('retek', 12),
('mogyoró', 15),
('dió', 20),
('szaloncukor', 60),
('táblacsoki', 350),
('szotyi', 90),
('szájmaszk', 500),
('WC papír', 12000),
('plüssmaci', 1200),
('kisautó', 600),
('playboy magazin', 1890),
('kétsávos kazetta', 120),
('virgács', 350);