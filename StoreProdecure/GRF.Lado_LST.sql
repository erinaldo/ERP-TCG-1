
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Lado_LST 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdIsla INT = -1,
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = '',
	@Activo INT = -1
AS
BEGIN
	IF @Tipo = 'N'
	BEGIN
		SELECT l.Id, l.IdEmpresaSis, l.IdSucursal, l.IdIsla, i.Nombre Isla, l.Nombre, l.Estado, l.Activo
		FROM GRF.Lado(NOLOCK) l INNER JOIN GRF.Isla(NOLOCK) i ON i.Id = l.IdIsla
		WHERE l.Id = IIF(@Id = -1, l.Id, @Id) AND
		l.IdIsla = IIF(@IdIsla = -1, l.IdIsla, @IdIsla) AND
		l.Activo = IIF(@Activo = -1, l.Activo, @Activo)
	END
END
GO
