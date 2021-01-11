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
('r�pa', 15),
('retek', 12),
('mogyor�', 15),
('di�', 20),
('szaloncukor', 60),
('t�blacsoki', 350),
('szotyi', 90),
('sz�jmaszk', 500),
('WC pap�r', 12000),
('pl�ssmaci', 1200),
('kisaut�', 600),
('playboy magazin', 1890),
('k�ts�vos kazetta', 120),
('virg�cs', 350);