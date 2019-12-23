DELIMITER //

CREATE VIEW vw_clientes_observacoes AS

select 
	cadastros.ID AS ID,
	cadastros.CADASTRO_STATUS_OBSERVACAO AS OBSERVACAO,
	cadastros.CADASTRO_STATUS AS "SERVICO"
	
from 
	cadastros 
where 
	(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_STATUS') order by cadastros.ID desc 
	
DELIMITER ;