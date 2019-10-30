
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.ContoMetroEletronico_IAE 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdTurno CHAR(7) = '',
	@IdDistribuidor INT = -1,
	@Conteo_inicial DECIMAL(18,4) = 0,
	@Conteo_final DECIMAL(18,4) = 0,
	@Movimiento_galones DECIMAL(18,4) = 0,
	@Conteo_inicial_Ventas DECIMAL(18,4) = 0,
	@Diferencia_galones DECIMAL(18,4) = 0,
	@Precio_Referencial DECIMAL(18,4) = 0,
	@Monto_Factor DECIMAL(18,4) = 0,
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @Tipo = 'I'
	BEGIN
		INSERT INTO GRF.Contometro_Electronico(IdEmpresaSis,IdSucursal,IdTurno,IdDistribuidor,Conteo_inicial,Conteo_final,Movimiento_galones,Conteo_inicial_Venta,Diferencia_galones,Precio_Referencial,Monto_Factor,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@IdTurno,@IdDistribuidor,@Conteo_inicial,@Conteo_final,@Movimiento_galones,@Conteo_inicial_Ventas,@Diferencia_galones,@Precio_Referencial,@Monto_Factor,@Estado,@Usuario,GETDATE(),1)
		SELECT @@IDENTITY
	END
	ELSE
	IF @Tipo = 'A'
	BEGIN
		UPDATE GRF.Contometro_Electronico
		SET Conteo_inicial = @Conteo_inicial,
		Conteo_final = @Conteo_final,
		Movimiento_galones = @Movimiento_galones,
		Conteo_inicial_Venta = @Conteo_inicial_Ventas,
		Diferencia_galones = @Diferencia_galones,
		Precio_Referencial = @Precio_Referencial,
		Monto_Factor = @Monto_Factor,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
		SELECT @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.Contometro_Electronico
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
