DELIMITER //

CREATE VIEW vw_tipos_cadastros AS

select 
	cadastros.ID AS ID,
	cadastros.CADASTRO_TIPO AS TIPO
	
from 
	cadastros 
where 
(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_TIPO_CADASTRO') order by cadastros.CADASTRO_TIPO asc;

DELIMITER ;