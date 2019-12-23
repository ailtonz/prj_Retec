DELIMITER //

CREATE VIEW vw_status_servicos AS

select 
	servicos.ID AS ID,
	servicos.SERVICO_STATUS AS "STATUS"
from 
	servicos 
where 
(servicos.REGISTRO_CATEGORIA = _utf8'STATUS_SERVICO') order by servicos.ID desc 
	
DELIMITER ;