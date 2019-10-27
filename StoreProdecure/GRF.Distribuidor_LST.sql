
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Distribuidor_LST 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdLado INT = -1,
	@IdMaterial CHAR(12) = '',
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = '',
	@Activo INT = -1
AS
BEGIN
	IF @Tipo = 'N'
	BEGIN
		SELECT d.Id, d.IdEmpresaSis, d.IdSucursal, d.IdLado, l.Nombre Lado, d.IdMaterial, d.Nombre, d.Estado, d.Activo
		FROM GRF.Distribuidor(NOLOCK) d INNER JOIN GRF.Lado(NOLOCK) l ON l.Id = d.IdLado
		WHERE d.Id = IIF(@Id = -1, d.Id, @Id) AND
		d.IdLado = IIF(@IdLado = -1, d.IdLado, @IdLado) AND
		d.Activo = IIF(@Activo = -1, d.Activo, @Activo)
	END
END
GO
