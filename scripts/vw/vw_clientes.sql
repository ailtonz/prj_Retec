DELIMITER //

CREATE VIEW vw_clientes AS

select 
	cadastros.ID AS ID,
	cadastros.NOME AS CLIENTE,
	cadastros.NOME_FANTASIA AS NOME_FANTASIA,
	
	cadastros.CEP AS CEP,
	cadastros.NUMERO AS NUMERO,
	cadastros.COMPLEMENTO AS COMPLEMENTO,
	cadastros.ENDERECO AS ENDERECO,
	cadastros.BAIRRO AS BAIRRO,
	cadastros.CIDADE AS CIDADE,
	cadastros.ESTADO AS ESTADO,

	cadastros.CONTATO AS CONTATO,
	cadastros.TELEFONE AS TELEFONE,
	cadastros.EMAIL AS EMAIL,
	
	cadastros.CADASTRO_TIPO AS CADASTRO_TIPO,
	cadastros.CNPJ_CPF AS CNPJ_CPF,
	cadastros.IE_RG AS IE_RG,
	cadastros.CADASTRO_STATUS,
	cadastros.CADASTRO_STATUS_OBSERVACAO,
	cadastros.CADASTRO_OBSERVACAO,
	cadastros.CADASTRO_PROPAGANDA,	
	cadastros.COBRANCA_INSCRICAO,
	
	cadastros.REGISTRO_INSERT_EMISSAO,
	cadastros.REGISTRO_INSERT_USUARIO,
	cadastros.REGISTRO_UPDATE_EMISSAO,
	cadastros.REGISTRO_UPDATE_USUARIO,
	cadastros.REGISTRO_RELACIONAMENTO,
	
	concat(cadastros.CADASTRO_STATUS,' - ',cadastros.CADASTRO_STATUS_OBSERVACAO) AS STATUS_CLIENTE

from 
	cadastros 
where
	cadastros.REGISTRO_CATEGORIA = "CLIENTE" 
order by 
	cadastros.ID desc 

DELIMITER ;