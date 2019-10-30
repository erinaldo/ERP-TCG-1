
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.TurnoCierre_LST 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdTurno CHAR(7) = '',
	@NroCorrelativo VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = '',
	@Activo INT = -1
AS
BEGIN
	IF @Tipo = 'N'
	BEGIN
		SELECT tc.Id, tc.IdEmpresaSis, tc.IdSucursal, tc.IdTurno, t.Turno, tc.FechaOperacion, tc.NroCorrelativo, tc.NroOperaciones, tc.SubTotal, tc.Igv, tc.Total, tc.Estado, tc.Activo
		FROM GRF.TurnoCierre(NOLOCK) tc INNER JOIN SGD.Turno(NOLOCK) t ON t.Id = tc.IdTurno
		WHERE tc.Id = IIF(@Id = -1, tc.Id, @Id) AND
		--tc.IdTurno = IIF(@IdTurno = -1, tc.IdTurno, @IdTurno) AND
		tc.Activo = IIF(@Activo = -1, tc.Activo, @Activo)
	END
END
GO
