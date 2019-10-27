
-- =============================================
-- Author:		UNKNOW
-- Create date: 2019-10-27
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GRF.Lado_IAE 
	@Tipo CHAR(1) = '',
	@Id INT = -1,
	@IdEmpresaSis CHAR(12) = '',
	@IdSucursal CHAR(12) = '',
	@IdIsla INT = -1,
	@Nombre VARCHAR(500) = '',
	@Estado INT = -1,
	@Usuario CHAR(12) = ''
AS
BEGIN
	IF @Tipo = 'I'
	BEGIN
		INSERT INTO GRF.Lado(IdEmpresaSis,IdSucursal,IdIsla,Nombre,Estado,UsuarioCreacion,FechaCreacion,Activo)
		VALUES(@IdEmpresaSis,@IdSucursal,@IdIsla,@Nombre,@Estado,@Usuario,GETDATE(),1)
	END
	ELSE
	IF @Tipo = 'A'
	BEGIN
		UPDATE GRF.Lado
		SET Nombre = @Nombre,
		Estado = @Estado,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
	ELSE
	BEGIN
		UPDATE GRF.Lado
		SET Activo = 0,
		UsuarioModifica = @Usuario,
		FechaModifica = GETDATE()
		WHERE Id = @Id
	END
END
GO
