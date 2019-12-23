DELIMITER //

CREATE  PROCEDURE `spMovimentoFluxo`(IN `p_ID` INT, IN `P_PLANO` VARCHAR(50), IN `p_MOVIMENTO` VARCHAR(50), IN `p_CONTROLE` VARCHAR(50), IN `p_CONTA` VARCHAR(50), IN `p_DataDeVencimento` VARCHAR(50), IN `p_ValorOriginal` VARCHAR(50), IN `p_DataDePagamento` VARCHAR(50), IN `p_ValorFinal` VARCHAR(50), IN `p_Transacao` VARCHAR(50), IN `p_Documento` VARCHAR(50), IN `p_Observacao` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "MOVIMENTO";

IF P_PLANO = "" THEN
	SET P_PLANO = "PESSOAL";
END IF;

IF p_MOVIMENTO  = ""  THEN
	SET p_MOVIMENTO = "DESPESA";
END IF;

IF p_CONTROLE  = ""  THEN
	SET p_CONTROLE = "VARIAVEL";
END IF;

IF P_TRANSACAO  = ""  THEN
	SET P_TRANSACAO = "DEBITO";
END IF;

IF p_ID = "0" THEN
 INSERT INTO movimentos
         (
				PLANO       		,
				MOVIMENTO   		,
				CONTROLE				,
				CONTA					,
				DataDeEmissao		,
				DataDeVencimento	,
				ValorOriginal		,
				DataDePagamento	,
				ValorFinal			,
				Transacao			,
				Documento			,
				Observacao			,
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_USUARIO	,
				REGISTRO_INSERT_EMISSAO
         )
    VALUES 
         (
  				trim(ucase(P_PLANO))   	,
				trim(ucase(p_MOVIMENTO))   	,
				trim(ucase(p_CONTROLE))			,
				trim(ucase(p_CONTA))				,
				now()					,
				p_DataDeVencimento				,
				REPLACE(p_ValorOriginal,',','.'),
				p_DataDePagamento					,
				REPLACE(p_ValorFinal,',','.')	,
				trim(ucase(p_Transacao)),
				trim(ucase(p_DOCUMENTO))		,
				trim(ucase(p_OBSERVACAO))		,
             p_CATEGORIA   		  			,
             ucase(p_USUARIO)      			,
             now()
         );
ELSEIF p_ID <> "0" THEN

	IF p_CONTA <> "" THEN
		UPDATE movimentos
			SET 
	         PLANO       		= trim(ucase(p_PLANO))		, 
	         MOVIMENTO   		= trim(ucase(p_MOVIMENTO))	,
				CONTROLE				= trim(ucase(p_CONTROLE))	,
				CONTA					= trim(ucase(p_CONTA))		,
				DataDeVencimento	= p_DataDeVencimento						,
				ValorOriginal		= REPLACE(p_ValorOriginal,',','.')	,
				DataDePagamento	= p_DataDePagamento						,
				ValorFinal			= REPLACE(p_ValorFinal,',','.') 		,
				Transacao		 	= trim(ucase(p_Transacao)) ,
				DOCUMENTO			= trim(ucase(p_DOCUMENTO))	,
				OBSERVACAO			= trim(ucase(p_OBSERVACAO)),
	         REGISTRO_UPDATE_USUARIO  = ucase(p_USUARIO)  ,
	         REGISTRO_UPDATE_EMISSAO	= now()	
	         
		WHERE id = p_ID;
		
	ELSE
		DELETE FROM movimentos WHERE id = p_ID;
	END IF;  

END IF;  

SELECT * FROM vw_dgv_movimentos;
     

END //

DELIMITER ;