DELIMITER //

CREATE VIEW vw_adm_cadastros AS

select 
	tmp2.codControle as codControle,
	tmp2.Descricao01 as Cadastro
from	
	administracao as tmp2 
where 
	tmp2.codRelacao = 1 
order by
	tmp2.Descricao01;

DELIMITER ;