DELIMITER //

CREATE VIEW vw_cargos AS

select 
	cadastros.ID AS ID,
	cadastros.CADASTRO_PROPAGANDA AS CARGO
	
from 
	cadastros 
where (cadastros.REGISTRO_CATEGORIA = _utf8'FUNCIONARIO_CARGO') order by cadastros.CADASTRO_PROPAGANDA asc;

DELIMITER ;