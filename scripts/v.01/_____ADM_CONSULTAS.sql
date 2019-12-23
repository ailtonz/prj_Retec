-- LOCALIZAR ID CLIENTE PELO NUMERO DE INSCRIÇÃO
select id_cliente,nome from vw_cad_clientes where vw_cad_clientes.COBRANCA_INSCRICAO='86734357000119';

-- LISTAR CONTATOS POR INSCRIÇÕES
SELECT COBRANCA_INSCRICAO, COUNT(COBRANCA_INSCRICAO) records FROM vw_cad_clientes_contatos GROUP BY COBRANCA_INSCRICAO HAVING COUNT(COBRANCA_INSCRICAO)>1;

-- LISTAR HISTORICOS SEM RELAÇÃO COM CLIENTES
select id, id_cliente,COBRANCA_INSCRICAO from vw_cad_clientes_historicos where id_cliente is null order by COBRANCA_INSCRICAO;

