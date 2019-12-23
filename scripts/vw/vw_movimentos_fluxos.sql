DELIMITER //

CREATE VIEW vw_movimentos_fluxos AS

SELECT
	id						,
	PLANO       		,
	MOVIMENTO   		,
	CONTROLE				,
	CONTA					,
	DataDeEmissao		,
	DataDeVencimento	,
	ValorOriginal		,
	DataDePagamento	,
	ValorFinal			,
	Transacao	,
	Documento			,
	Observacao			,
	REGISTRO_CATEGORIA,
	REGISTRO_INSERT_USUARIO	,
	REGISTRO_INSERT_EMISSAO
FROM
	movimentos
WHERE
	movimentos.REGISTRO_CATEGORIA = "MOVIMENTO"
ORDER BY
	id desc  //

DELIMITER ;