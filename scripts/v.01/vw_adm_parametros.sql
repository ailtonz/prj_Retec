SELECT 	
	t2.Pesquisa as Pesquisa,
	t1.Ordem as Ordem,
	t1.Descricao01 as Parametro,
	t1.Descricao02 as Descricao 
FROM 
	administracao as t1,
	(select tmp2.Descricao01 as pesquisa, tmp2.codControle as codControle from	administracao as tmp2 where tmp2.codRelacao = 1) as t2
WHERE
	t1.codRelacao = t2.codControle
ORDER BY
	t2.Pesquisa,
	t1.ordem;