
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Contometro_Mecanico_LST 
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
		SELECT cm.Id, cm.IdEmpresaSis, cm.IdSucursal, cm.IdTurno, t.Turno, cm.IdDistribuidor, d.Nombre Distribuidor, cm.Conteo_inicial, cm.Conteo_final, cm.Movimiento_contometro, cm.Movimiento_galon, cm.Diferencia, cm.Estado, cm.Activo
		FROM GRF.Contometro_Mecanico(NOLOCK) cm INNER JOIN SGD.Turno(NOLOCK) t ON t.Id = cm.IdTurno
		INNER JOIN GRF.Distribuidor(NOLOCK) d ON d.Id = cm.IdDistribuidor
		WHERE cm.Id = IIF(@Id = -1, cm.Id, @Id) AND
		cm.IdTurno = IIF(@IdTurno = '', cm.IdTurno, @IdTurno) AND
		cm.Activo = IIF(@Activo = -1, cm.Activo, @Activo)
	END
END
GO
