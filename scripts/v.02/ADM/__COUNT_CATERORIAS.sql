SELECT 
	(SELECT COUNT(*) FROM vw_clientes) AS CLIENTES ,
	(SELECT COUNT(*) FROM vw_clientes_obras) AS CLIENTES_OBRAS ,
	(SELECT COUNT(*) FROM vw_clientes_contatos) AS CLIENTES_CONTATOS ,
	(SELECT COUNT(*) FROM vw_clientes_historico) AS HISTORICO ;