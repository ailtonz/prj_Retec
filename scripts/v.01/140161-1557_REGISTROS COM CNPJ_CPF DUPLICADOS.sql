-- PROCURAR REGISTROS COM CNPJ_CPF DUPLICADOS
SELECT 
       ID_CLIENTE, 
       CNPJ_CPF,nome, COUNT(CNPJ_CPF) records 
FROM 
     vw_cad_clientes 
GROUP BY CNPJ_CPF HAVING COUNT(CNPJ_CPF)>1;	 



-- CRIAR "LISTA TEMPORARIA DE REGISTROS COM CNPJ_CPF DUPLICADOS"
INSERT INTO 
	 cadastros
(cadastros.ID_RELACAO, cadastros.CADASTRO_CATEGORIA )

(SELECT ID_CLIENTE,"ok" as marca FROM vw_cad_clientes GROUP BY CNPJ_CPF HAVING COUNT(CNPJ_CPF)>1);


-- LISTAR "LISTA TEMPORARIA DE REGISTROS COM CNPJ_CPF DUPLICADOS"
select  
	cadastros.ID_RELACAO, cadastros.CADASTRO_CATEGORIA
from
	cadastros
where 
	cadastros.CADASTRO_CATEGORIA = "ok";



-- EXCLUIR REGISTROS DUPLICADOS
DELETE FROM vw_cad_clientes WHERE ID_CLIENTE IN (SELECT * FROM (

select  
	cadastros.ID_RELACAO
from
	cadastros
where 
	cadastros.CADASTRO_CATEGORIA = "ok"

) AS p);
	


-- EXCLUIR "LISTA TEMPORARIA DE REGISTROS COM CNPJ_CPF DUPLICADOS"
DELETE FROM cadastros WHERE ID_RELACAO IN (SELECT * FROM (

select  
	cadastros.ID_RELACAO
from
	cadastros
where 
	cadastros.CADASTRO_CATEGORIA = "ok"

) AS p);

