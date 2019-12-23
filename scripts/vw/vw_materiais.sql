DELIMITER //

CREATE VIEW vw_materiais AS

select 
	cadastros.ID AS ID,
	cadastros.NOME AS MATERIAL
	
from 
	cadastros 
where 
	(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_MATERIAL') order by cadastros.NOME asc //

DELIMITER ;