-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- ====================================================================================================================
-- Code		| Date			| User		| Description
---====================================================================================================================
-- @0001	| 2019-12-28	| User99	| Se adiciono la columna idcaja
-- ====================================================================================================================

ALTER PROCEDURE [CON].[ISP_MovimientoCajaBanco_Listar]
	@TIPOOPERACION CHAR (1) = '', 
	@Id CHAR (16)='', 
	@IdFlujoCaja CHAR (12)='', 
	@NroBoucher VARCHAR (20)='', 
	@IdCuentaBancaria CHAR (12)='', 
	@Fecha DATETIME='01/01/1901', 
	@IdTipoDocumento CHAR (9)='', 
	@IdPeriodoConcilia CHAR (7)='', 
	@Activo BIT=NULL, 
	@IdAsientoMovimiento CHAR (16)='1CH0000002432119', 
	@TipoCambio DECIMAL (12, 4)=0, 
	@TotalMN DECIMAL (18, 4)=0, 
	@TotalME DECIMAL (18, 4)=0, 
	@FechaFin DATETIME='01/01/1901', 
	@NoConciliado INT=-1, 
	@Ejercicio INT=-1
AS
BEGIN 
	DECLARE @SQL AS VARCHAR(MAX) 
	IF @TIPOOPERACION = ''
	BEGIN
		SET @SQL = 'SELECT MCB.Id, MCB.IdFlujoCaja, 
		MCB.NroBoucher, MCB.IdCuentaBancaria, CB.IdMoneda,
		MCB.Fecha, MCB.IdTipoDocumento, 
		MCB.IdPeriodoConcilia, MCB.Activo, 
		MCB.IdAsientoMovimiento, AM.Glosa,
		MCB.TipoCambio, MCB.TotalMN * operador as TotalMN,
		MCB.TotalME * operador as TotalME, 
		U.NombreCompleto UsuarioCreacion, TG.Nombre TipoGasto, ISNULL(MCB.IdTipoGasto, '''') IdTipoGasto, A.NroAsiento,
		MCB.IdCaja
		FROM  CON.MovimientoCajaBanco(nolock) MCB 
		INNER JOIN TES.CuentaBancaria(nolock) CB ON MCB.IdCuentaBancaria = CB.Id 
		INNER JOIN CON.AsientoMovimiento(NOLOCK) AM on AM.Id = MCB.IdAsientoMovimiento 
		INNER JOIN CON.Asiento(NOLOCK) A ON AM.IdAsiento = A.Id
		LEFT JOIN SGD.Ift_Usuario() U ON AM.IdUsuarioCrea = U.Id 
		LEFT JOIN TES.TipoGasto(NOLOCK) TG ON MCB.IdTipoGasto = TG.Id
		WHERE 1=1 ' 
		IF @Id <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.Id = ' + CHAR(39) +  @Id  +  CHAR(39) 
		 END 
		IF @IdFlujoCaja <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.IdFlujoCaja = ' + CHAR(39) +  @IdFlujoCaja  +  CHAR(39) 
		 END 
		IF @NroBoucher <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.NroBoucher = ' + CHAR(39) +  @NroBoucher  +  CHAR(39) 
		 END 
		IF @IdCuentaBancaria <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.IdCuentaBancaria = ' + CHAR(39) +  @IdCuentaBancaria  +  CHAR(39) 
		 END 
		IF @Fecha <> '01/01/1901' and @FechaFin <> '01/01/1901'
		 BEGIN 
			SET @SQL = @SQL + ' AND (CONVERT(datetime, DATEDIFF(d, 0, MCB.Fecha), 102) <= CONVERT(datetime, DATEDIFF(d, 0, ' + CHAR(39) +  CONVERT(VARCHAR,@FechaFin) + CHAR(39) + '), 102) AND '
			SET @SQL = @SQL + 'CONVERT(datetime, DATEDIFF(d, 0, MCB.Fecha), 102) >= CONVERT(datetime, DATEDIFF(d, 0, ' + CHAR(39) +  CONVERT(VARCHAR,@Fecha) + CHAR(39) + '), 102))  '
		 END 
		IF @IdTipoDocumento <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.IdTipoDocumento = ' + CHAR(39) +  @IdTipoDocumento  +  CHAR(39) 
		 END 
		IF @IdPeriodoConcilia <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.IdPeriodoConcilia = ' + CHAR(39) +  @IdPeriodoConcilia  +  CHAR(39) 
		 END 
		IF @Activo IS NOT NULL
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.Activo = ' + CHAR(39) + CONVERT(VARCHAR,@Activo) +  CHAR(39) 
		 END 
		IF @IdAsientoMovimiento <> ''
		 BEGIN 
			 SET @SQL = @SQL + ' AND MCB.IdAsientoMovimiento = ' + CHAR(39) +  @IdAsientoMovimiento  +  CHAR(39) 
		 END 
		IF @NoConciliado = 0
		 BEGIN 
			 SET @SQL = @SQL + ' AND isnull(MCB.IdPeriodoConcilia,'''') = '''' '
		 END 
		 set @sql =  @sql + ' order by MCB.Fecha '
		 --print @sql
		EXEC(@SQL) 
	END
	IF @TIPOOPERACION = 'S' -- SALDO DE CUENTAS BANCARIAS POR EJERCICICIO
	BEGIN
		SELECT '' as Id, '' as IdFlujoCaja, '' as NroBoucher, '' as IdCuentaBancaria, '' as IdMoneda, '01/01/1901' as Fecha, '' as IdTipoDocumento, '' as IdPeriodoConcilia, 
		1 as Activo, '' as IdAsientoMovimiento, 0 as TipoCambio, SUM(MCB.TotalMN * MCB.operador)as TotalMN , 
		SUM(MCB.TotalME* MCB.operador) as TotalME, '' AS Glosa, '' UsuarioCreacion, '' TipoGasto, '' IdTipoGasto, '' NroAsiento,
		'' IdCaja -- @0001
		FROM CON.MovimientoCajaBanco AS MCB with(nolock)
		INNER JOIN CON.Periodo AS P with(nolock)ON P.Id = MCB.IdPeriodoConcilia and P.Ejercicio = @Ejercicio 
		where MCB.IdCuentaBancaria = @IdCuentaBancaria and ISNULL(MCB.IdPeriodoConcilia,'') <> ''  AND MCB.Activo = 1
		group by MCB.IdCuentaBancaria
		
	END
	IF @TIPOOPERACION = 'R'
	BEGIN
		SELECT '' as Id, '' as IdFlujoCaja, '' as NroBoucher, '' as IdCuentaBancaria, 
		'' as IdMoneda, '01/01/1901' as Fecha, '' as IdTipoDocumento, '' as IdPeriodoConcilia, 
		1 as Activo, '' as IdAsientoMovimiento, 0 as TipoCambio, 
		sum(MCB.TotalMN * MCB.operador)as TotalMN , sum(MCB.TotalME* MCB.operador) as TotalME, 
		'' AS Glosa, '' UsuarioCreacion, '' TipoGasto, '' IdTipoGasto, '' NroAsiento,
		'' IdCaja -- @0001
		FROM CON.MovimientoCajaBanco AS MCB with(nolock)
		INNER JOIN CON.Periodo AS P with(nolock)ON P.Id = MCB.IdPeriodoConcilia and P.Ejercicio = @Ejercicio 
		where MCB.IdCuentaBancaria = CASE @IdCuentaBancaria WHEN '' THEN MCB.IdCuentaBancaria ELSE @IdCuentaBancaria	END  
				and MCB.Fecha < @Fecha AND MCB.Activo = 1
		group by MCB.IdCuentaBancaria
		
	END

	IF @TIPOOPERACION = 'C'
	BEGIN
		SELECT MCB.Id,'' AS IdFlujoCaja,'' as NroBoucher, '' as IdCuentaBancaria, 
		'' as IdMoneda,MCB.Fecha , '' AS IdTipoDocumento, MCB.IdPeriodoConcilia,
		MCB.Activo,ISNULL(MCB.IdAsientoMovimiento,'') as IdAsientoMovimiento,
		MCB.TipoCambio, 0.0 TotalMN,0.0 TotalME,'' as Glosa, '' UsuarioCreacion,
		'' TipoGasto, ISNULL(MCB.IdTipoGasto, '') IdTipoGasto, '' NroAsiento,
		'' IdCaja -- @0001
		 FROM CON.MovimientoCajaBanco MCB
		INNER JOIN CON.Periodo P ON MCB.IdPeriodoConcilia=P.Id 
		WHERE MCB.Id = @ID		
	END

	IF @TIPOOPERACION = 'D' -- Obtener Movimiento Caja Banco por IdAsiento
		BEGIN
			SELECT MCB.Id, MCB.IdFlujoCaja, MCB.NroBoucher, MCB.IdCuentaBancaria, CB.IdMoneda, MCB.Fecha, MCB.IdTipoDocumento, MCB.IdPeriodoConcilia, MCB.Activo, 
			MCB.IdAsientoMovimiento, AM.Glosa, MCB.TipoCambio, MCB.TotalMN * operador as TotalMN, MCB.TotalME * operador as TotalME, 
			U.NombreCompleto UsuarioCreacion, TG.Nombre TipoGasto, ISNULL(MCB.IdTipoGasto, '') IdTipoGasto, A.NroAsiento,
			MCB.IdCaja -- @0001
			FROM  CON.MovimientoCajaBanco(nolock) MCB 
			INNER JOIN TES.CuentaBancaria(nolock) CB ON MCB.IdCuentaBancaria = CB.Id 
			INNER JOIN CON.AsientoMovimiento(NOLOCK) AM on AM.Id = MCB.IdAsientoMovimiento 
			INNER JOIN CON.Asiento(NOLOCK) A ON AM.IdAsiento = A.Id
			LEFT JOIN SGD.Ift_Usuario() U ON AM.IdUsuarioCrea = U.Id 
			LEFT JOIN TES.TipoGasto(NOLOCK) TG ON MCB.IdTipoGasto = TG.Id
			WHERE MCB.Activo = 1 AND AM.Activo = 1 AND A.Activo = 1 AND A.Id = LTRIM(RTRIM(@IdAsientoMovimiento))
		END
	IF @TIPOOPERACION = 'O' -- Obtener Movimiento Caja Banco por Obligacion Pago
		BEGIN
			SELECT MCB.Id, MCB.IdFlujoCaja, MCB.NroBoucher, MCB.IdCuentaBancaria, CB.IdMoneda, MCB.Fecha, MCB.IdTipoDocumento, MCB.IdPeriodoConcilia, MCB.Activo, 
			MCB.IdAsientoMovimiento, AM.Glosa, MCB.TipoCambio, MCB.TotalMN * operador as TotalMN, MCB.TotalME * operador as TotalME, 
			U.NombreCompleto UsuarioCreacion, TG.Nombre TipoGasto, ISNULL(MCB.IdTipoGasto, '') IdTipoGasto, A.NroAsiento,
			MCB.IdCaja -- @0001
			FROM  CON.MovimientoCajaBanco(nolock) MCB 
			INNER JOIN TES.CuentaBancaria(nolock) CB ON MCB.IdCuentaBancaria = CB.Id 
			INNER JOIN CON.AsientoMovimiento(NOLOCK) AM on AM.Id = MCB.IdAsientoMovimiento 
			INNER JOIN CON.Asiento(NOLOCK) A ON AM.IdAsiento = A.Id
			INNER JOIN FIN.ObligacionPago(NOLOCK) OP ON OP.IdMovimientoCajaBanco = MCB.Id
			LEFT JOIN SGD.Ift_Usuario() U ON AM.IdUsuarioCrea = U.Id 
			LEFT JOIN TES.TipoGasto(NOLOCK) TG ON MCB.IdTipoGasto = TG.Id
			WHERE MCB.Activo = 1 AND AM.Activo = 1 AND OP.Activo = 1 AND OP.Id = LTRIM(RTRIM(@IdAsientoMovimiento))
		END
	IF @TIPOOPERACION = 'X' -- Obtener Movimiento Bancarios por Periodo Conciliado
		BEGIN
			SELECT MCB.Id, MCB.IdFlujoCaja, MCB.NroBoucher, MCB.IdCuentaBancaria, CB.IdMoneda, MCB.Fecha, MCB.IdTipoDocumento, MCB.IdPeriodoConcilia, MCB.Activo, 
			MCB.IdAsientoMovimiento, AM.Glosa, MCB.TipoCambio, MCB.TotalMN * operador as TotalMN, MCB.TotalME * operador as TotalME, 
			U.NombreCompleto UsuarioCreacion, TG.Nombre TipoGasto, ISNULL(MCB.IdTipoGasto, '') IdTipoGasto, A.NroAsiento,
			MCB.IdCaja -- @0001
			FROM  CON.MovimientoCajaBanco(nolock) MCB 
			INNER JOIN TES.CuentaBancaria(nolock) CB ON MCB.IdCuentaBancaria = CB.Id 
			INNER JOIN CON.AsientoMovimiento(NOLOCK) AM on AM.Id = MCB.IdAsientoMovimiento 
			INNER JOIN CON.Asiento(NOLOCK) A ON AM.IdAsiento = A.Id
			LEFT JOIN SGD.Ift_Usuario() U ON AM.IdUsuarioCrea = U.Id 
			LEFT JOIN TES.TipoGasto(NOLOCK) TG ON MCB.IdTipoGasto = TG.Id
			WHERE MCB.Activo = 1 AND ISNULL(MCB.IdPeriodoConcilia,'')= @IdPeriodoConcilia AND MCB.IdCuentaBancaria = @IdCuentaBancaria
		END
END