-- Define o banco de dados que será utilizado
USE Peoples_manha;

-- Insere dois funcionários
INSERT INTO Funcionarios (Nome, Sobrenome, DataNascimento) 
VALUES	('Catarina', 'Strada', '1999-02-01')
		,('Tadeu', 'Vitelli', '1950-03-01')
		,('Doug', 'Mantovani' ,'2001-02-12');

-- Insere o TipoUsuario
INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES ('Admnistrador'),('Comum');

INSERT INTO Usuario (Email, Senha, IdTipoUsuario)
VALUES ('admin@gmail.com','admin123', 1),
	   ('admin2@gmail.com','admin123', 1),
	   ('Tadeu@gmail.com','Tadeu123', 2),
	   ('Catararina@gmail.com','cat@gmail.com', 2),
	   ('Doug@gmail.com', 'matadordemonstros', 2);


	

-- Atualiza o valor da coluna DataNascimento
UPDATE Funcionarios SET DataNascimento = '1993-03-17';

UPDATE Funcionarios SET IdUsuario = 3 WHERE IdFuncionario = 2;

UPDATE Funcionarios SET IdUsuario = 4 WHERE IdFuncionario = 1;

UPDATE Funcionarios SET IdUsuario = 5 WHERE IdFuncionario = 3;
