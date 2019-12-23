CONCAT(Substring(Inicio,9, 2) , "/" , Substring(Inicio,6, 2) , "/" , Substring(Inicio,1, 4))

SET p_ORG_CONTRATO_INICIO		=	CONCAT(Substring(p_CONTRATO_INICIO,7, 4) , "/" , Substring(p_CONTRATO_INICIO,4, 2) , "/" , Substring(p_CONTRATO_INICIO,1, 5));