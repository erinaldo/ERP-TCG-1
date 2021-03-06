
-- =============================================
-- Author:		Nevado Barrios Erick
-- Create date: 18/01/2012
-- Description:	
-- =============================================
ALTER PROCEDURE [SGD].[Isp_Turno_Listar] 
	@TIPOOPERACION CHAR(1) = ''
	,@Id CHAR(7) = ''
	,@HoraInicio varchar(20) = ''
	,@HoraSalida varchar(20) = ''
	,@Dia varCHAR(15) = ''
	,@Turno CHAR(1) = ''
	,@UsuarioCreacion CHAR(12) = ''
	,@Activo BIT = NULL
 As 
 BEGIN 
 DECLARE @SQL AS VARCHAR(MAX) 
 SET @SQL = 'SELECT 
Id, HoraInicio, HoraSalida, Dia, Turno, FechaCreacion, UsuarioCreacion, Activo, FechaInicio, FechaSalida
FROM  SGD.Turno(NOLOCK) WHERE 1=1 ' 
IF @Id <> ''
 BEGIN 
     SET @SQL = @SQL + ' AND Id = ' + CHAR(39) +  @Id  +  CHAR(39) 
 END 
IF @HoraInicio <> ''
-- BEGIN 
--     SET @SQL = @SQL + ' AND HoraInicio = ' + CHAR(39) +  @HoraInicio  +  CHAR(39) 
-- END 
--IF @HoraSalida <> ''
-- BEGIN 
--     SET @SQL = @SQL + ' AND HoraSalida = ' + CHAR(39) +  @HoraSalida  +  CHAR(39) 
-- END 
IF @Dia <> ''
 BEGIN 
     SET @SQL = @SQL + ' AND Dia = ' + CHAR(39) +  @Dia  +  CHAR(39) 
 END 
IF @Turno <> ''
 BEGIN 
     SET @SQL = @SQL + ' AND Turno = ' + CHAR(39) +  @Turno  +  CHAR(39) 
 END 
IF @UsuarioCreacion <> ''
 BEGIN 
     SET @SQL = @SQL + ' AND UsuarioCreacion = ' + CHAR(39) +  @UsuarioCreacion  +  CHAR(39) 
 END 
IF @Activo IS NOT NULL
 BEGIN 
     SET @SQL = @SQL + ' AND Activo = ' + CHAR(39) + CONVERT(VARCHAR,@Activo) +  CHAR(39) 
 END 

EXEC(@SQL) 

END 
