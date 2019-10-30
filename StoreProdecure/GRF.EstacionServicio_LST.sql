
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.EstacionServicio_LST 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = '',
	@Activo INT = -1
AS
BEGIN
	IF @Tipo = 'N'
	BEGIN
		SELECT es.Id, es.IdEmpresaSis, es.IdSucursal, es.Nombre, es.Estado, es.Activo
		FROM GRF.EstacionServicio(NOLOCK) es
		WHERE es.Id = IIF(@Id = -1, es.Id, @Id) AND
		es.Activo = IIF(@Activo = -1, es.Activo, @Activo)
	END
END
GO
