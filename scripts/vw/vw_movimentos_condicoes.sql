DELIMITER //

CREATE VIEW vw_movimentos_condicoes AS

select 
	movimentos.id AS ID,
	movimentos.Transacao AS DESCRICAO,
	movimentos.Controle AS DIAS


from 
	movimentos 
where (movimentos.REGISTRO_CATEGORIA = _utf8'MOV_CONDICAO') order by convert(movimentos.Controle,signed) asc  //

DELIMITER ;