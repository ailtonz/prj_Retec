INSERT INTO 
	vw_cad_clientes_historicos
	(HISTORICO,
	COBRANCA_INSCRICAO,
	CATEGORIA)

	(
	SELECT 
		new_clientes_obs.Observacao,
		new_clientes_obs.strINSCRICAO,
		new_clientes_obs.CADASTRO_CATEGORIA
	FROM 
		new_clientes_obs 
	);
	
SELECT * FROM vw_cad_clientes_historicos;