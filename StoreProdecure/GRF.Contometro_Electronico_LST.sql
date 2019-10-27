
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Contometro_Electronico_LST 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdTurno CHAR(7) = '',
	@IdDistribuidor INT = -1,
	@Estado INT = -1,
	@Usuario CHAR(12) = '',
	@Activo INT = -1
AS
BEGIN
	IF @Tipo = 'N'
	BEGIN
		SELECT ce.Id, ce.IdEmpresaSis, ce.IdSucursal, ce.IdTurno, t.Turno, ce.IdDistribuidor, d.Nombre Distribuidor, ce.Conteo_inicial, ce.Conteo_final, ce.Movimiento_galones, ce.Conteo_inicial_Venta, ce.Diferencia_galones, ce.Precio_Referencial, ce.Monto_Factor, ce.Estado, ce.Activo
		FROM GRF.Contometro_Electronico(NOLOCK) ce INNER JOIN SGD.Turno(NOLOCK) t ON t.Id = ce.IdTurno
		INNER JOIN GRF.Distribuidor(NOLOCK) d ON d.Id = ce.IdDistribuidor
		WHERE ce.Id = IIF(@Id = -1, ce.Id, @Id) AND
		ce.IdTurno = IIF(@IdTurno = '', ce.IdTurno, @IdTurno) AND
		ce.Activo = IIF(@Activo = -1, ce.Activo, @Activo)
	END
END
GO
