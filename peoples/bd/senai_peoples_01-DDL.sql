-- Cria o banco de dados
CREATE DATABASE Peoples_manha;

-- Define qual banco de dados será utilizado
USE Peoples_manha;

CREATE TABLE TipoUsuario (
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario VARCHAR(200)
);

CREATE TABLE Usuario (
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario),
	Email VARCHAR (200) NOT NULL,
	Senha VARCHAR (200) NOT NULL
);

-- Cria a tabela Funcionarios
CREATE TABLE Funcionarios 
(
	IdFuncionario	INT IDENTITY PRIMARY KEY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
	,Nome			VARCHAR(200) NOT NULL
	,Sobrenome		VARCHAR(255),
	DataNascimento DATE
);


-- Adiciona a coluna DataNascimento na tabela Funcionarios
ALTER TABLE Funcionarios
ADD DataNascimento DATE