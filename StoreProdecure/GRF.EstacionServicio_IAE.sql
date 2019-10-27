
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.EstacionServicio_IAE 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @Tipo = 'I'
	BEGIN
		INSERT INTO GRF.EstacionServicio(IdEmpresaSis,IdSucursal,Nombre,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@Nombre,@Estado,@Usuario,GETDATE(),1)
	END
	ELSE
	IF @Tipo = 'A'
	BEGIN
		UPDATE GRF.EstacionServicio
		SET Nombre = @Nombre,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.EstacionServicio
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
