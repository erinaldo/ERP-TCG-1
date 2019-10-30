
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Isla_LST 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdEstacionServicio INT = -1,
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = '',
	@Activo INT = -1
AS
BEGIN
	IF @Tipo = 'N'
	BEGIN
		SELECT i.Id, i.IdEmpresaSis, i.IdSucursal, i.IdEstacionServicio, es.Nombre EstacionServicio, i.Nombre, i.Estado, i.Activo
		FROM GRF.Isla(NOLOCK) i INNER JOIN GRF.EstacionServicio(NOLOCK) es ON es.Id = i.IdEstacionServicio
		WHERE i.Id = IIF(@Id = -1, i.Id, @Id) AND
		i.IdEstacionServicio = IIF(@IdEstacionServicio = -1, i.IdEstacionServicio, @IdEstacionServicio) AND
		i.Activo = IIF(@Activo = -1, i.Activo, @Activo)
	END
END
GO
