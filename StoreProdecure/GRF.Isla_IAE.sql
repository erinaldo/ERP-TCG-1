
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Isla_IAE 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdEstacionServicio INT = -1,
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @Tipo = 'I'
	BEGIN
		INSERT INTO GRF.Isla(IdEmpresaSis,IdSucursal,IdEstacionServicio,Nombre,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@IdEstacionServicio,@Nombre,@Estado,@Usuario,GETDATE(),1)
		SELECT @@IDENTITY
	END
	ELSE
	IF @Tipo = 'A'
	BEGIN
		UPDATE GRF.Isla
		SET Nombre = @Nombre,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
		SELECT @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.Isla
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
