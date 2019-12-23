-- CRIAR TABELA TEMPORARIA
CREATE TABLE IF NOT EXISTS tmp_inscricao as 

SELECT 
	cadastros.ID_RELACAO,
	cadastros.COBRANCA_INSCRICAO,
	cadastros.CADASTRO_CATEGORIA 
FROM 
	cadastros
WHERE
	cadastros.CADASTRO_CATEGORIA = "tmp_inscricao";

-- LISTAR TABELA TEMPORARIA
select * from tmp_inscricao;


-- CRIA VISÃO DE TABELA TEMPORARIA
CREATE VIEW vw_inscricao as 

SELECT 
	cadastros.ID_RELACAO,
	cadastros.COBRANCA_INSCRICAO,
	cadastros.CADASTRO_CATEGORIA 
FROM 
	cadastros
WHERE
	cadastros.CADASTRO_CATEGORIA = "tmp_inscricao";


-- LISTAR VISÃO TEMPORARIA
select * from vw_inscricao;


-- EXCLUIR VISÃO DE TABELA TEMPORARIA
DROP VIEW IF EXISTS vw_inscricao;


-- EXCLUIR TABELA TEMPORARIA
DROP TABLE tmp_inscricao;


	
SHOW FULL TABLES;
