-- CRIAR TABELA TEMPORARIA
CREATE TABLE IF NOT EXISTS tmp_cep_sao_paulo as 

SELECT 
	*
FROM 
	tmp_cep
WHERE
	tmp_cep.uf_sigla = "SP";