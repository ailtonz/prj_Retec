DELIMITER //

CREATE VIEW vw_status_precificacao AS

SELECT 
	cadastros.ID AS ID,
	cadastros.CONTRATO_OBSERVACAO AS DESCRICAO
	
FROM 
	cadastros 
WHERE 
(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_PRECO') ORDER BY cadastros.CONTRATO_OBSERVACAO asc 
	
DELIMITER ;