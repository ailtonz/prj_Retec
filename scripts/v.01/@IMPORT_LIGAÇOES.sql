insert into servicos
(
	servicos.ID_CADASTRO,
	servicos.ID_OBRA,
	servicos.ID_SOLICITANTE,
	servicos.ID_MATERIAL,
	
	servicos.SERVICO_EMISSAO,
	servicos.SERVICO_STATUS,
	
	servicos.SERVICO_NOME,
	servicos.SERVICO_CONTATO,
	servicos.SERVICO_TELEFONE,
	servicos.SERVICO_EMAIL,
		
	servicos.PEDIDO_COLOCA,
	servicos.PEDIDO_TROCA,
	servicos.PEDIDO_RETIRA,
	
	servicos.PEDIDO_DT_COLOCA,
	servicos.PEDIDO_DT_TROCA,
	servicos.PEDIDO_DT_RETIRA,	
	
	servicos.PEDIDO_PR_COLOCA,
	servicos.PEDIDO_PR_TROCA,
	servicos.PEDIDO_PR_RETIRA,	

	servicos.PEDIDO_OBS_COLOCA,
	servicos.PEDIDO_OBS_TROCA,
	servicos.PEDIDO_OBS_RETIRA,	
	servicos.PEDIDO_OBS_LIGACAO,	

	servicos.PEDIDO_MATERIAL,
	
	servicos.PEDIDO_STATUS,	
	servicos.PEDIDO_STATUS_OBSERVACAO,
	
	servicos.OBRA_CEP ,
	servicos.OBRA_NUMERO ,
	servicos.OBRA_COMPLEMENTO ,
	servicos.OBRA_ENDERECO ,
	servicos.OBRA_BAIRRO ,
	servicos.OBRA_CIDADE ,
	servicos.OBRA_ESTADO ,

	servicos.OBRA_SOLICITANTE ,
	servicos.OBRA_SOLICITANTE_TELEFONE ,
	servicos.OBRA_SOLICITANTE_EMAIL ,
		
	servicos.CONTRATO_FORMA_PAGAMENTO ,
	servicos.CONTRATO_FATURAMENTO_DIAS ,
	servicos.CONTRATO_PERIODO_LOCACAO ,
	servicos.CONTRATO_RETIRADA_AUTOMATICA ,
	servicos.CONTRATO_VCTO_APOS_ENTREGA ,
	servicos.CONTRATO_MULTA_MORA ,
	servicos.CONTRATO_MULTA_DIA ,	
	
	servicos.CONTRATO_VALOR ,
	servicos.CONTRATO_NFE ,
	servicos.CONTRATO_ISS ,
	servicos.CONTRATO_CTR ,
	
	servicos.COBRANCA_TIPO,
	servicos.COBRANCA_INSCRICAO,
	servicos.COBRANCA_SACADO ,
	servicos.COBRANCA_LOGRADOURO ,
	servicos.COBRANCA_BAIRRO ,
	servicos.COBRANCA_CEP ,
	servicos.COBRANCA_CIDADE ,
	servicos.COBRANCA_ESTADO ,
	
	servicos.COBRANCA_CONTATO ,
	servicos.COBRANCA_TELEFONE ,
	servicos.COBRANCA_EMAIL ,	
	
	servicos.REGISTRO_INSERT_EMISSAO ,
	servicos.REGISTRO_INSERT_USUARIO ,
	servicos.REGISTRO_UPDATE_EMISSAO ,
	servicos.REGISTRO_UPDATE_USUARIO ,
	servicos.REGISTRO_CATEGORIA
	
)

SELECT

	vw_dgv_clientes.ID,
	vw_dgv_clientes_obras.ID,
	vw_dgv_clientes_obras_contatos.ID,
	vw_dgv_cad_materiais.ID,
	
	DATE_FORMAT(now(),'%d/%m/%Y') as EMISSAO,
	'N.OK' AS STATUS,
	
	vw_dgv_clientes.CLIENTE,
	vw_dgv_clientes.CONTATO,
	vw_dgv_clientes.TELEFONE,
	vw_dgv_clientes.EMAIL,
		
	'1' AS COLOCA,
   '0' AS TROCA,
	'0' AS RETIRA,
	
	DATE_FORMAT(now(),'%d/%m/%Y') as DT_COLOCA,
	DATE_FORMAT(now(),'%d/%m/%Y') AS DT_TROCA,
	DATE_FORMAT(now(),'%d/%m/%Y') AS DT_RETIRA,	
	
	'1' AS PR_COLOCA,
	'0' AS PR_TROCA,
	'0' AS PR_RETIRA,	

	vw_dgv_clientes_obras.CONTRATO_OBS_COLOCA,
	vw_dgv_clientes_obras.CONTRATO_OBS_TROCA,
	vw_dgv_clientes_obras.CONTRATO_OBS_RETIRA,	
	vw_dgv_clientes_obras.CONTRATO_OBS_LIGACAO,	

	vw_dgv_cad_materiais.MATERIAL,
	
	vw_dgv_clientes.CADASTRO_STATUS,	
	vw_dgv_clientes.CADASTRO_STATUS_OBSERVACAO,
	
	vw_dgv_clientes_obras.CEP ,
	vw_dgv_clientes_obras.NUMERO ,
	vw_dgv_clientes_obras.COMPLEMENTO ,
	vw_dgv_clientes_obras.ENDERECO ,
	vw_dgv_clientes_obras.BAIRRO ,
	vw_dgv_clientes_obras.CIDADE ,
	vw_dgv_clientes_obras.ESTADO ,

	vw_dgv_clientes_obras_contatos.CONTATO ,
	vw_dgv_clientes_obras_contatos.TELEFONE ,
	vw_dgv_clientes_obras_contatos.EMAIL ,
		
	vw_dgv_clientes_obras.CONTRATO_FORMA_PAGAMENTO ,
	vw_dgv_clientes_obras.CONTRATO_FATURAMENTO_DIAS ,
	vw_dgv_clientes_obras.CONTRATO_PERIODO_LOCACAO ,
	vw_dgv_clientes_obras.CONTRATO_RETIRADA_AUTOMATICA ,
	vw_dgv_clientes_obras.CONTRATO_VCTO_APOS_ENTREGA ,
	vw_dgv_clientes_obras.CONTRATO_MULTA_MORA ,
	vw_dgv_clientes_obras.CONTRATO_MULTA_DIA ,	
	
	vw_dgv_clientes_obras.CONTRATO_VALOR ,
	vw_dgv_clientes_obras.CONTRATO_NF ,
	vw_dgv_clientes_obras.CONTRATO_ISS ,
	vw_dgv_clientes_obras.CONTRATO_CTR ,
	
	vw_dgv_clientes_obras.COBRANCA_TIPO,
	vw_dgv_clientes_obras.COBRANCA_INSCRICAO,
	vw_dgv_clientes_obras.COBRANCA_SACADO ,
	vw_dgv_clientes_obras.COBRANCA_LOGRADOURO ,
	vw_dgv_clientes_obras.COBRANCA_BAIRRO ,
	vw_dgv_clientes_obras.COBRANCA_CEP ,
	vw_dgv_clientes_obras.COBRANCA_CIDADE ,
	vw_dgv_clientes_obras.COBRANCA_ESTADO ,
	
	vw_dgv_clientes_obras.COBRANCA_CONTATO ,
	vw_dgv_clientes_obras.COBRANCA_TELEFONE ,
	vw_dgv_clientes_obras.COBRANCA_EMAIL ,	
	
	now() as DT_INSERT_EMISSAO,
	'ADM' AS INSERT_USUARIO,			
	now() as DT_UPDATE_EMISSAO,
	'ADM' AS INSERT_USUARIO,	
	'LIGACAO' AS REGISTRO_CATEGORIA
	
FROM 
	vw_dgv_clientes_obras, vw_dgv_clientes, vw_dgv_cad_materiais,vw_dgv_clientes_obras_contatos

WHERE
	vw_dgv_clientes.ID = vw_dgv_clientes_obras.ID_CLIENTE
	AND
	vw_dgv_clientes_obras.ID IN (SELECT vw_dgv_clientes_obras.ID FROM vw_dgv_clientes_obras WHERE vw_dgv_clientes_obras.ID_CLIENTE ='1613988')
	AND
	vw_dgv_cad_materiais.ID = '1709261'
	AND
	vw_dgv_clientes_obras_contatos.ID = '1709289';