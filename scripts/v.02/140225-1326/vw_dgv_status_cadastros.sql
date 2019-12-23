CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW vw_dgv_status_cadastros AS 
select 
cadastros.ID AS ID,
cadastros.CADASTRO_STATUS AS CADASTRO_STATUS,

cadastros.REGISTRO_CATEGORIA AS REGISTRO_CATEGORIA,
cadastros.REGISTRO_INSERT_EMISSAO AS REGISTRO_INSERT_EMISSAO,
cadastros.REGISTRO_INSERT_USUARIO AS REGISTRO_INSERT_USUARIO,
cadastros.REGISTRO_UPDATE_EMISSAO AS REGISTRO_UPDATE_EMISSAO,
cadastros.REGISTRO_UPDATE_USUARIO AS REGISTRO_UPDATE_USUARIO 
from 
cadastros 
where 
(cadastros.REGISTRO_CATEGORIA = _utf8'UTEIS_STATUS') order by cadastros.ID desc;