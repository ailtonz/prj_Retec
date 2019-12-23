INSERT INTO cadastros
(
	cadastros.NOME ,
	cadastros.TELEFONE ,
	
	cadastros.CADASTRO_TIPO ,
	cadastros.CNPJ_CPF ,
	cadastros.IE_RG ,
	
	cadastros.CEP ,
	cadastros.ENDERECO ,
	cadastros.NUMERO ,
	cadastros.COMPLEMENTO ,
	cadastros.BAIRRO ,
	cadastros.CIDADE ,
	cadastros.ESTADO ,
	
	cadastros.CONTRATO_FORMA_PAGAMENTO ,
	
	cadastros.CONTRATO_FATURAMENTO_DIAS ,	
	cadastros.CONTRATO_PERIODO_LOCACAO ,
	cadastros.CONTRATO_RETIRADA_AUTOMATICA ,
	cadastros.CONTRATO_VCTO_APOS_ENTREGA ,
	
	cadastros.CONTRATO_MULTA_MORA ,
	cadastros.CONTRATO_MULTA_DIA ,
	
	cadastros.CONTRATO_NF ,
	cadastros.CONTRATO_ISS ,
	cadastros.CONTRATO_CTR ,	
	
	cadastros.CONTRATO_PRECO ,
	cadastros.CONTRATO_VALOR ,	
		
	cadastros.REGISTRO_CATEGORIA,
	cadastros.REGISTRO_INSERT_EMISSAO ,
	cadastros.REGISTRO_INSERT_USUARIO ,
	cadastros.REGISTRO_UPDATE_EMISSAO ,
	cadastros.REGISTRO_UPDATE_USUARIO 	
)

select 
	cadastros_140318_1258.NOME ,
	cadastros_140318_1258.TELEFONE ,
	
	cadastros_140318_1258.CADASTRO_TIPO ,
	cadastros_140318_1258.CNPJ_CPF ,
	cadastros_140318_1258.IE_RG ,
	
	cadastros_140318_1258.CEP ,
	cadastros_140318_1258.ENDERECO ,
	cadastros_140318_1258.NUMERO ,
	cadastros_140318_1258.COMPLEMENTO ,
	cadastros_140318_1258.BAIRRO ,
	cadastros_140318_1258.CIDADE ,
	cadastros_140318_1258.ESTADO ,
	
	cadastros_140318_1258.CONTRATO_FORMA_PAGAMENTO ,
	
	cadastros_140318_1258.CONTRATO_FATURAMENTO_DIAS ,	
	cadastros_140318_1258.CONTRATO_PERIODO_LOCACAO ,
	cadastros_140318_1258.CONTRATO_RETIRADA_AUTOMATICA ,
	cadastros_140318_1258.CONTRATO_VCTO_APOS_ENTREGA ,
	
	cadastros_140318_1258.CONTRATO_MULTA_MORA ,
	cadastros_140318_1258.CONTRATO_MULTA_DIA ,
	
	cadastros_140318_1258.CONTRATO_NF ,
	cadastros_140318_1258.CONTRATO_ISS ,
	cadastros_140318_1258.CONTRATO_CTR ,	
	
	cadastros_140318_1258.CONTRATO_PRECO ,
	cadastros_140318_1258.CONTRATO_VALOR ,	
		
	cadastros_140318_1258.REGISTRO_CATEGORIA,
	cadastros_140318_1258.REGISTRO_INSERT_EMISSAO ,
	cadastros_140318_1258.REGISTRO_INSERT_USUARIO ,
	cadastros_140318_1258.REGISTRO_UPDATE_EMISSAO ,
	cadastros_140318_1258.REGISTRO_UPDATE_USUARIO 	
from 
	cadastros_140318_1258 
where 
	(cadastros_140318_1258.REGISTRO_CATEGORIA = _utf8'ADM_TRANSPORTADOR') order by cadastros_140318_1258.ID desc 