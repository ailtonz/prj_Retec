-- LOCALIZAR ID CLIENTE PELO NUMERO DE INSCRIÇÃO
select id_cliente,nome from vw_cad_clientes where vw_cad_clientes.COBRANCA_INSCRICAO='86734357000119';

-- LISTAR CONTATOS POR INSCRIÇÕES
SELECT COBRANCA_INSCRICAO, COUNT(COBRANCA_INSCRICAO) records FROM vw_cad_clientes_contatos GROUP BY COBRANCA_INSCRICAO HAVING COUNT(COBRANCA_INSCRICAO)>1;

-- LISTAR HISTORICOS SEM RELAÇÃO COM CLIENTES
select id, id_cliente,COBRANCA_INSCRICAO from vw_cad_clientes_historicos where id_cliente is null order by COBRANCA_INSCRICAO;

-- LISTAR OBRAS DO CLIENTE PELA INSCRICAO DE COBRANCA
select * from vw_cad_clientes_obras WHERE ID_CLIENTE IN (select ID_CLIENTE from vw_cad_clientes where COBRANCA_INSCRICAO = '58092891000133')

-- LISTAR CONTATOS DE OBRAS DO CLIENTE PELO ID DO CLIENTE
select * from vw_cad_clientes_obras_contatos WHERE ID_OBRA IN (select ID from vw_cad_clientes_obras where ID_CLIENTE IN (select ID_CLIENTE from vw_cad_clientes where COBRANCA_INSCRICAO = '58092891000133'));

-- CONTAR CARACTERES
SELECT LENGTH(material) as strMaterial  FROM vw_uteis_materiais;