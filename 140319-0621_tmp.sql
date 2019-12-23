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
	'0' AS DT_TROCA,
	'0' AS DT_RETIRA,	
	
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
	vw_dgv_clientes_obras.ID ='1707629'
	AND
	vw_dgv_cad_materiais.ID = '1709261'
	AND
	vw_dgv_clientes_obras_contatos.ID = '1709289';