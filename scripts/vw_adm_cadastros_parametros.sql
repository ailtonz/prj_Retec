DELIMITER //

CREATE VIEW vw_adm_cadastros_parametros AS

SELECT 	
	t2.Cadastro as Cadastro,
	t1.Ordem as Ordem,
	t1.Descricao01 as Parametro,
	t1.Descricao02 as Filtro,
	t1.Descricao03 as Descricao
	
FROM 
	administracao as t1,
	vw_adm_cadastros as t2
WHERE
	t1.codRelacao = t2.codControle
ORDER BY
	t2.Cadastro,
	t1.ordem,
	t1.codControle;

DELIMITER ;