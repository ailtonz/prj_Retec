DELIMITER //

CREATE VIEW vw_servicos_ligacoes AS

SELECT

	servicos.ID,
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

	servicos.PEDIDO_STATUS,	
	servicos.PEDIDO_STATUS_OBSERVACAO,	
		
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

FROM

	servicos 
	
where 
	(servicos.REGISTRO_CATEGORIA = _utf8'LIGACAO') order by servicos.ID desc 
	
DELIMITER ;