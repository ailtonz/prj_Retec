DELIMITER //

CREATE VIEW vw_telefones AS

select 
	cadastros.ID AS ID,
	cadastros.NOME AS DESCRICAO,
	cadastros.TELEFONE,
	cadastros.EMAIL,
	cadastros.CONTATO,
	cadastros.CADASTRO_OBSERVACAO AS OBSERVACAO
	
from 
	cadastros 
where 
	(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_TELEFONE') order by cadastros.NOME asc //

DELIMITER ;