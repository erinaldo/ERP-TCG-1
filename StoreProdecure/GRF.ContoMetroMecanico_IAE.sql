
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.ContoMetroMecanico_IAE 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdTurno CHAR(7) = '',
	@IdDistribuidor INT = -1,
	@IdContometro_Electronico INT = -1,
	@Conteo_inicial int = 0,
	@Conteo_final int = 0,
	@Movimiento_contometro int = 0,
	@Movimiento_galon DECIMAL(18,4) = 0,
	@Diferencia DECIMAL(18,4) = 0,
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @Tipo = 'I'
	BEGIN
		INSERT INTO GRF.Contometro_Mecanico(IdEmpresaSis,IdSucursal,IdTurno,IdDistribuidor,IdContometro_Electronico,Conteo_inicial,Conteo_final,Movimiento_contometro,Movimiento_galon,Diferencia,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@IdTurno,@IdDistribuidor,@IdContometro_Electronico,@Conteo_inicial,@Conteo_final,@Movimiento_contometro,@Movimiento_galon,@Diferencia,@Estado,@Usuario,GETDATE(),1)
	END
	ELSE
	IF @Tipo = 'A'
	BEGIN
		UPDATE GRF.Contometro_Mecanico
		SET Conteo_inicial = @Conteo_inicial,
		Conteo_final = @Conteo_final,
		Movimiento_contometro = @Movimiento_contometro,
		Movimiento_galon = @Movimiento_galon,
		Diferencia = @Diferencia,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.Contometro_Mecanico
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
