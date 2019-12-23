UPDATE
	vw_cad_clientes_contatos
SET
	vw_cad_clientes_contatos.ID_CLIENTE = (SELECT vw_cad_clientes.ID_CLIENTE FROM vw_cad_clientes WHERE vw_cad_clientes.COBRANCA_INSCRICAO ="00000218064896")
﻿WHERE 
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO = "00000218064896";


-- UPDATE v.01
UPDATE 
   vw_cad_clientes_contatos a
LEFT JOIN vw_cad_clientes b ON
    a.COBRANCA_INSCRICAO = b.COBRANCA_INSCRICAO
SET
   a.ID_CLIENTE = b.ID_CLIENTE;

 
-- UPDATE DE TESTES
UPDATE vw_cad_clientes_contatos
	SET
	ID_CLIENTE = "0";

-- SELEÇÃO DE CONTATOS
select * from vw_cad_clientes_contatos;

-- SELEÇÃO DE CLIENTES
select * from vw_cad_clientes;
