DELETE FROM	vw_cad_contatos_clientes WHERE ID in (SELECT ID FROM vw_cad_contatos_clientes WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF = '24797483830'));

SELECT ID FROM vw_cad_contatos_clientes WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF = '24797483830');

SELECT * FROM vw_cad_clientes WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF = '24797483830')

SELECT * FROM vw_cad_contatos_clientes WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF ='13673795805')
SELECT * FROM vw_cad_clientes_historicos WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF ='13673795805')

SELECT * FROM vw_cad_clientes_obras WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF ='13673795805')
SELECT * FROM vw_cad_contatos_obras WHERE ID_OBRA in (SELECT ID FROM vw_cad_clientes_obras WHERE ID_CLIENTE in (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF ='13673795805'))