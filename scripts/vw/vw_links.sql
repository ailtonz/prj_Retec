DELIMITER //

CREATE VIEW vw_links AS

select 
	cadastros.ID AS ID,
	cadastros.NOME AS DESCRICAO,
	cadastros.CADASTRO_OBSERVACAO AS LINK
from 
	cadastros 
where 
	(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_LINKS') order by cadastros.ID desc //

DELIMITER ;