-- CRIA VISÃO DE TABELA TEMPORARIA
CREATE VIEW vw_pesquisa_clientes as 

SELECT 
	ID, 
	CLIENTE, 
	CONTATO, 
	TELEFONE,
	EMAIL, 
	CNPJ_CPF, 
	STATUS_CLIENTE  
FROM 
	vw_pesquisa_clientes
	
;


