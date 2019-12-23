-- RELACIONAR CONTATOS COM CLIENTES PELO ID_CLIENTE		
select 
	vw_cad_clientes.COBRANCA_INSCRICAO,vw_cad_clientes_contatos.CONTATO
from 	
	vw_cad_clientes ,vw_cad_clientes_contatos 
	left join 
		vw_cad_clientes_contatos on
	    vw_cad_clientes.COBRANCA_INSCRICAO = vw_cad_clientes_contatos.COBRANCA_INSCRICAO;




--- teste	    
select 
	(select vw_cad_clientes.COBRANCA_INSCRICAO from vw_cad_clientes where vw_cad_clientes.COBRANCA_INSCRICAO = vw_cad_clientes_contatos.COBRANCA_INSCRICAO ) as id,
	vw_cad_clientes_contatos.CONTATO
from 	
	vw_cad_clientes_contatos



---
---
---



UPDATE 
    cadastros a
LEFT JOIN vw_cad_clientes b ON
    a.COBRANCA_INSCRICAO = b.COBRANCA_INSCRICAO
SET
   a.ID_RELACAO = b.ID_CLIENTE;
	WHERE 
		a.COBRANCA_INSCRICAO ="00000218064896" 
	AND 
		a.CADASTRO_CATEGORIA = "CONTATO_CLIENTE";


	    
-- PROCURAR DUPLICADOS
SELECT ID_CLIENTE, CNPJ_CPF,nome, COUNT(CNPJ_CPF) records FROM vw_cad_clientes GROUP BY CNPJ_CPF HAVING COUNT(CNPJ_CPF)>1;	 

SELECT ID_CLIENTE, CNPJ_CPF,nome FROM vw_cad_clientes WHERE CNPJ_CPF = "62205679000102";

DELETE FROM vw_cad_clientes WHERE ID_CLIENTE IN (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF = "62205679000102");

DELETE FROM vw_cad_clientes WHERE ID_CLIENTE IN (SELECT * FROM (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF = "62205679000102" LIMIT 1) AS p);

DELETE FROM vw_cad_clientes WHERE ID_CLIENTE IN (SELECT * FROM (SELECT ID_CLIENTE FROM vw_cad_clientes GROUP BY CNPJ_CPF HAVING COUNT(CNPJ_CPF)>1) AS p);