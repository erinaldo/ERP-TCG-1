
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.TurnoCierre_IAE 
	@TipoOperacion CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdTurno CHAR(7) = '',
	@Tipo INT = -1,
	@FechaOperacion DATETIME = '01/01/1901',
	@NroCorrelativo VARCHAR(10) = '',
	@NroOperaciones INT = -1,
	@SubTotal DECIMAL(18,4) = 0,
	@Igv DECIMAL(18,4) = 0,
	@Total DECIMAL(18,4) = 0,
	@Nro_Doc_Inicial VARCHAR(10) = '',
	@Nro_Doc_Final VARCHAR(10) = '',
	@Cantidad_Anulados INT = -1,
	@Monto_Anulados DECIMAL(18,4) = 0,
	@TipoCambio DECIMAL(18,4) = 0,
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @TipoOperacion = 'I'
	BEGIN
		INSERT INTO GRF.TurnoCierre(IdEmpresaSis,IdSucursal,IdTurno,Tipo,FechaOperacion,NroCorrelativo,NroOperaciones,SubTotal,Igv,Total,Nro_Doc_Inicial,Nro_Doc_Final,Cantidad_Anulados,Monto_Anulados,TipoCambio,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@IdTurno,@Tipo,@FechaOperacion,@NroCorrelativo,@NroOperaciones,@SubTotal,@Igv,@Total,@Nro_Doc_Inicial,@Nro_Doc_Final,@Cantidad_Anulados,@Monto_Anulados,@TipoCambio,@Estado,@Usuario,GETDATE(),1)
	END
	ELSE
	IF @TipoOperacion = 'A'
	BEGIN
		UPDATE GRF.TurnoCierre
		SET NroCorrelativo = @NroCorrelativo,
		NroOperaciones = @NroOperaciones,
		SubTotal = @SubTotal,
		Igv = @Igv,
		Total = @Total,
		Nro_Doc_Inicial = @Nro_Doc_Inicial,
		Nro_Doc_Final = @Nro_Doc_Final,
		Cantidad_Anulados = @Cantidad_Anulados,
		Monto_Anulados = @Monto_Anulados,
		TipoCambio = @TipoCambio,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.TurnoCierre
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
