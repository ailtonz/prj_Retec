DELIMITER //

CREATE VIEW vw_movimentos_transacoes AS

select 
	movimentos.id AS ID,
	movimentos.Transacao AS TRANSACAO
from 
	movimentos 
where (movimentos.REGISTRO_CATEGORIA = _utf8'MOV_TRANSACAO') order by movimentos.Transacao //

DELIMITER ;