CREATE VIEW vw_funcionarios_cargos AS

select 
	cadastros.ID AS ID,
	cadastros.CADASTRO_PROPAGANDA AS CARGO
	
from 
	cadastros 
where (cadastros.REGISTRO_CATEGORIA = _utf8'FUNCIONARIO_CARGO') order by cadastros.CADASTRO_PROPAGANDA asc    