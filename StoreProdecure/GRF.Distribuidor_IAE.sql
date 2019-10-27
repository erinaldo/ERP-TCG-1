
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Distribuidor_IAE 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdLado INT = -1,
	@IdMaterial CHAR(12) = '',
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @Tipo = 'I'
	BEGIN
		INSERT INTO GRF.Distribuidor(IdEmpresaSis,IdSucursal,IdLado,IdMaterial,Nombre,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@IdLado,@IdMaterial,@Nombre,@Estado,@Usuario,GETDATE(),1)
	END
	ELSE
	IF @Tipo = 'A'
	BEGIN
		UPDATE GRF.Distribuidor
		SET Nombre = @Nombre,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.Distribuidor
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
