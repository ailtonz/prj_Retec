UPDATE new_clientes_obras
	SET 
	new_clientes_obras.CADASTRO_CATEGORIA = "CLIENTE_OBRA";

INSERT INTO 
	vw_cad_clientes_obras
	(
	vw_cad_clientes_obras.COBRANCA_INSCRICAO,
	vw_cad_clientes_obras.COBRANCA_SACADO,	
	vw_cad_clientes_obras.COBRANCA_CONTATO,	
	vw_cad_clientes_obras.COBRANCA_TELEFONE,		
	vw_cad_clientes_obras.COBRANCA_EMAIL,			
	vw_cad_clientes_obras.CONTRATO_VALOR,				
	vw_cad_clientes_obras.CONTRATO_NF,					
	vw_cad_clientes_obras.CONTRATO_ISS,						
	vw_cad_clientes_obras.CONTRATO_CTR,							
	vw_cad_clientes_obras.CADASTRO_OBSERVACAO,
	vw_cad_clientes_obras.CONTRATO_INICIO,
	vw_cad_clientes_obras.CADASTRO_CATEGORIA
	)

	(
	SELECT 
		new_clientes_obras.strINSCRICAO,
		LEFT(new_clientes_obras.Razao,30) AS COBRANCA_SACADO,
		LEFT(new_clientes_obras.Contato,15) AS COBRANCA_CONTATO,
		LEFT(new_clientes_obras.Telefone,50) AS COBRANCA_TELEFONE,		
		LEFT(new_clientes_obras.Email,120) AS COBRANCA_EMAIL,		
		new_clientes_obras.ValorCacamba,								
		new_clientes_obras.NF,
		new_clientes_obras.ISS,		
		new_clientes_obras.CTR,				
		new_clientes_obras.OBS,						
		CONCAT(Substring(new_clientes_obras.Inicio,9, 2) , "/" , Substring(new_clientes_obras.Inicio,6, 2) , "/" , Substring(new_clientes_obras.Inicio,1, 4)) AS CONTRATO_INICIO,								
		new_clientes_obras.CADASTRO_CATEGORIA
	FROM 
		new_clientes_obras 
	);
	
SELECT * FROM vw_cad_clientes_obras;