DELIMITER //

CREATE VIEW vw_cep AS

select 
	cadastros.ID AS ID,
	cadastros.CEP AS CEP,
	cadastros.ENDERECO AS ENDERECO,
	cadastros.COMPLEMENTO AS COMPLEMENTO,
	cadastros.BAIRRO AS BAIRRO,
	cadastros.CIDADE AS CIDADE,
	cadastros.ESTADO AS ESTADO,
	cadastros.CONTRATO_VALOR AS VALOR
	
from 
	cadastros 
where (cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_CEP') order by cadastros.ID desc //

DELIMITER ;