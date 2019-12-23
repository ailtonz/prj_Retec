DELIMITER //

CREATE VIEW vw_aterros AS

select 
	cadastros.ID AS ID,

	cadastros.NOME_FANTASIA AS FANTASIA,
	cadastros.NOME AS NOME,

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

	cadastros.CADASTRO_TIPO AS TIPO,
	cadastros.CNPJ_CPF AS CNPJ_CPF,
	cadastros.IE_RG AS IE_RG,

	cadastros.CADASTRO_OBSERVACAO AS OBSERVACAO,
	cadastros.CONTRATO_VALOR AS VALOR
from 
cadastros 
where (cadastros.REGISTRO_CATEGORIA = _utf8'ATERRO') order by cadastros.ID desc  
	
DELIMITER ;