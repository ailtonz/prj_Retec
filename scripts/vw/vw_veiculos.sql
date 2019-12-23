DELIMITER //

CREATE VIEW vw_veiculos AS

select 
	cadastros.ID AS ID,
	cadastros.CEP AS PLACA,
	cadastros.NOME AS MODELO
from 
	cadastros 
where 
(cadastros.REGISTRO_CATEGORIA = _utf8'VEICULO') order by cadastros.ID desc //

DELIMITER ;