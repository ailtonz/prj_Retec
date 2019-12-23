DELIMITER //

CREATE VIEW vw_servicos_ligacoes_status AS

select 
	servicos.ID AS ID,
	servicos.SERVICO_STATUS AS "STATUS"
	
from 
	servicos 
where 
(servicos.REGISTRO_CATEGORIA = _utf8'STATUS_LIGACAO') order by servicos.SERVICO_STATUS asc  //

DELIMITER ;