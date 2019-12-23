-- CLIENTE
CALL `sp_CAD_CLIENTE`('INSERT', 'PF', '24797483830', '263787667', 'ailtonzsilva', 'ailton zacarias da silva', '05750130', '89', 'bl 4 ap 104', 'ailton', '11 2373-7625', 'ailton@teste.com.br', 'google', 'adm')

-- CLIENTE X CONTATOS
CALL `sp_CAD_CLIENTE_CONTATO`('CLIENTE', 'INSERT', '0', '0', 'AILTON.ZACARIAS', '1199999-0000', 'AILTON@TESTE.COM', 'OBS.CLIENTE', '1', 'ADM', '24797483830')

-- OBRAS
CALL `sp_CAD_CLIENTE_OBRA`('INSERT', '24797483830', '788369', '05750130', '89', 'BL 4 ap 104', 'ailton', '11 2373-7625', 'ailton@yahoo.com', 'pf', '0', 'ailton zacarias', '54270110', 'ailton', '11 94857-5143', 'ailton@gmail.com', '13/01/14', '1', '1', '1', 'adm', '', '', '123.36', '', '', '', '', '', 'RUA QUATORZE', 'CURADO IV', 'JABOATÃO ', 'PE','','','','')

-- COBRAS X CONTATOS
CALL `sp_CAD_CLIENTE_CONTATO`('OBRA', 'INSERT', '0', '788370', 'AILTON.SILVA', '1199999-0000', 'AILTON@TESTE.COM', 'OBS.CLIENTE', '1', 'ADM', '24797483830')

-- CONSULTAS DE CADASTROS

SELECT * FROM vw_cad_clientes;
SELECT * FROM vw_cad_clientes_contatos;

SELECT * FROM vw_cad_clientes_obras;
SELECT * FROM vw_cad_clientes_obras_contatos;