CREATE DATABASE pizzeria_db;
USE pizzeria_db;

CREATE TABLE Pizza(
id_pizza INT PRIMARY KEY IDENTITY(1, 1),
nombre_pizza VARCHAR(100),
descp_pizza VARCHAR(250),
precio DECIMAL(10, 2)
)

CREATE TABLE Pasta(	
id_pasta INT PRIMARY KEY IDENTITY(1, 1),
nombre_pasta VARCHAR(100),
descp_pizza VARCHAR(250),
precio DECIMAL(10, 2)
)

CREATE TABLE  Bebida(
id_bebida INT PRIMARY KEY IDENTITY(1, 1),
nombre_bebida VARCHAR(50),
descp_bebida VARCHAR(250),
precio DECIMAL(10, 2)
)

CREATE TABLE Canoa(
id_canoas INT PRIMARY KEY IDENTITY(1, 1),
nombre_canoa VARCHAR(50),
descp_canoa VARCHAR(250),
precio DECIMAL(10, 2)
)

CREATE TABLE Quesadilla(
id_quesadilla INT PRIMARY KEY IDENTITY(1, 1),
nombre_quesadilla VARCHAR(50),
descp_quesadilla VARCHAR(250),
precio DECIMAL(10, 2)
)

CREATE TABLE Burrito(
id_burrito INT PRIMARY KEY IDENTITY(1, 1),
nombre_burrito VARCHAR(50),
descp_burrito VARCHAR(250),
precio DECIMAL(10, 2)
)

CREATE TABLE Piola(
id_piola INT PRIMARY KEY IDENTITY(1, 1),
nombre_piola VARCHAR(50),
descp_piola VARCHAR(250),
precio DECIMAL(10, 2)
)

SELECT * FROM Pizza;
