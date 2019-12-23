DELIMITER //

CREATE VIEW vw_funcionarios AS

select 
	cadastros.ID AS ID,

	cadastros.CNPJ_CPF AS CNPJ_CPF,
	cadastros.IE_RG AS IE_RG,
	cadastros.NOME AS NOME,

	cadastros.TELEFONE AS TELEFONE,
	cadastros.EMAIL AS EMAIL,
	cadastros.CONTATO AS CONTATO,
	
	cadastros.CEP AS CEP,
	cadastros.NUMERO AS NUMERO,
	cadastros.COMPLEMENTO AS COMPLEMENTO,		
	cadastros.ENDERECO AS ENDERECO,
	cadastros.BAIRRO AS BAIRRO,
	cadastros.CIDADE AS CIDADE,
	cadastros.ESTADO AS ESTADO,

	cadastros.CADASTRO_PROPAGANDA AS CARGO,
	cadastros.CONTRATO_VALOR AS SALARIO,

	cadastros.REGISTRO_CATEGORIA AS REGISTRO_CATEGORIA,
	cadastros.REGISTRO_INSERT_EMISSAO AS REGISTRO_INSERT_EMISSAO,
	cadastros.REGISTRO_INSERT_USUARIO AS REGISTRO_INSERT_USUARIO,
	cadastros.REGISTRO_UPDATE_EMISSAO AS REGISTRO_UPDATE_EMISSAO,
	cadastros.REGISTRO_UPDATE_USUARIO AS REGISTRO_UPDATE_USUARIO 
from 
cadastros 
where (cadastros.REGISTRO_CATEGORIA = _utf8'FUNCIONARIO') order by cadastros.ID desc 

DELIMITER ;