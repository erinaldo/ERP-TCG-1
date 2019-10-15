'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.Encripta
Imports System.Transactions

''' <summary>
''' Clase que gestiona los procesos del usuario.
''' Clase de Hereda: d_Persona
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Usuario,Capa del Sistema:Capa de Acceso a Datos </remarks>
Public Class d_Usuario

    Private sqlhelper As New SqlHelper
    Private Encriptador As New Genera
    Dim oePersona As New e_Persona
    Dim odPersona As New d_Persona
    Dim oeUsuarioPerfil As New e_UsuarioPerfil
    Dim odUsuarioPerfil As New d_UsuarioPerfil
    Dim oeTurnoUsuario As New e_TurnoUsuario
    Dim odTurnoUsuario As New d_TurnoUsuario
    Dim oeControlTurnoUsuario As New e_ControlTurnoUsuario
    Dim odControlTurnoUsuario As New d_ControlTurnoUsuario
    Dim oeARUsuario As New e_ActividadRestringida_Usuario
    Dim odARUsuario As New d_ActividadRestringido_Usuario
    Dim oeEmail As New e_Email
    Dim odEmail As New d_Email

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Usuario y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeusuario) de tipo e_Usuario</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Usuario
        Try
            Dim objSexo As New e_Sexo(CType(o_fila("Sexo"), String))
            Dim oeUsuario = New e_Usuario( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Login"), Encriptador.Desencriptar(o_fila("Clave")), _
             o_fila("Activo"), o_fila("ApellidoPaterno"), o_fila("ApellidoMaterno"), o_fila("Nombre"), _
             o_fila("Dni"), objSexo, o_fila("FechaNacimiento"), o_fila("IdPersona"), o_fila("IdTrabajador"), _
             o_fila("Area"), o_fila("IdArea"), o_fila("Controlado"), o_fila("FechaUltimoIngreso"))
            Return oeUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarAutorizado(ByVal o_fila As DataRow) As e_Usuario
        Try
            Dim objSexo As New e_Sexo(CType(o_fila("Sexo"), String))
            Dim oeUsuario = New e_Usuario(o_fila("Id"), _
                                          o_fila("Codigo"), _
                                          o_fila("Login"), _
                                          o_fila("Clave"), _
                                        o_fila("Activo"), _
                                        o_fila("ApellidoPaterno"), _
                                        o_fila("ApellidoMaterno"), _
                                        o_fila("Nombre"), _
                                     o_fila("Dni"), _
                                     objSexo, _
                                     o_fila("FechaNacimiento"), _
                                     o_fila("IdPersona"), o_fila("IdTrabajador"), _
                                     o_fila("Area"), o_fila("IdArea"), _
                                     o_fila("Controlado"), o_fila("FechaUltimoIngreso"))
            Return oeUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función especial agregada para recuperar la lista de usuarios actualmente conectados al SGI
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CargarUsuariosConectados(ByVal o_fila As DataRow) As e_UsuarioConectado
        Try
            Dim oeUsuarioConectado As New e_UsuarioConectado(o_fila("Id"), _
                                          o_fila("nombreTrabajador"), _
                                          o_fila("usuario"), _
                                          o_fila("conectadoDesdePc"), _
                                        o_fila("area"), _
                                        o_fila("ocupacion"), _
                                        o_fila("fechaInicio"), _
                                        o_fila("tiempoTranscurrido"))
            Return oeUsuarioConectado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Cargar información de los usuarios actualmente desconectados, pero que trabajador el día 
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CargarUsuariosDesconectados(ByVal o_fila As DataRow) As e_UsuarioDesconectado
        Try
            Dim oeUsuarioDesconectado As New e_UsuarioDesconectado(o_fila("Id"), _
                                          o_fila("nombreTrabajador"), _
                                          o_fila("usuario"), _
                                          o_fila("conectadoDesdePc"), _
                                        o_fila("area"), _
                                        o_fila("ocupacion"), _
                                        o_fila("fechaSalida"), _
                                        o_fila("tiempoTranscurrido"))
            Return oeUsuarioDesconectado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Cargar usuarios sin acceso durante un tiempo determinado
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CargarUsuariosSinAcceso(ByVal o_fila As DataRow) As e_UsuarioSinAcceso
        Try
            Dim oeUsuarioSinAcceso As New e_UsuarioSinAcceso(o_fila("Id"), _
                                          o_fila("nombreTrabajador"), _
                                          o_fila("usuario"), _
                                        o_fila("area"), _
                                        o_fila("ocupacion"), _
                                        o_fila("fechaUltimoIngreso"), _
                                        o_fila("tiempoTranscurrido"))
            Return oeUsuarioSinAcceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un usuario, el cual es consultado por el procedimiento almacenado SGD.Isp_Usuario_Listar
    ''' enviando su id del usuario.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Usuario.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeUsuario">Recibe una variable oeUsuario de tipo e_Usuario</param>
    ''' <returns>Devuelve una varible oeUsuario de tipo e_Usuario</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeUsuario As e_Usuario) As e_Usuario
        Try
            Dim ds As DataSet
            Dim indCargar As Boolean = oeUsuario.IndCompleto
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", .TipoOperacion, .Id, .Codigo, .Login)
            End With
            Return DevuelveUsuario(ds, oeUsuario, indCargar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener2(ByVal oeUsuario As e_Usuario) As e_Usuario
        Try
            Dim ds As DataSet
            Dim indCargar As Boolean = oeUsuario.IndCompleto
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Login, _
                                              Encriptador.Encriptar(.Clave), _
                                              .oePersona.Dni)
            End With
            Return DevuelveUsuario(ds, oeUsuario, indCargar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerFechaServidor(ByVal oeUsuario As e_Usuario) As e_Usuario
        Try
            Dim ds As DataSet
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", _
                                              .TipoOperacion, _
                                              .Id)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeUsuario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeUsuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Función implementada para WCF con la finalidad de obtener exclusivamente el usuario que se logea 
    ''' </summary>
    ''' <param name="oeUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerUsuarioInicial(ByVal oeUsuario As e_Usuario) As e_Usuario
        Try
            Dim ds As DataSet
            Dim indCargar As Boolean = oeUsuario.IndCompleto
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Login, _
                                              Encriptador.Encriptar(.Clave))
            End With
            Return DevuelveUsuario(ds, oeUsuario, indCargar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerAutorizacion(ByVal oeUsuario As e_Usuario) As e_Usuario
        Try
            Dim ds As DataSet
            Dim Autorizado As New e_Usuario
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Login, _
                                              .Clave)
            End With
            oeUsuario = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    Autorizado = CargarAutorizado(o_Fila)
                Next
            Else
                Autorizado = New e_Usuario
            End If
            Return Autorizado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function DevuelveUsuario(ByVal dsUsuario As DataSet, ByVal oeUsu As e_Usuario, ByVal lb_Ind As Boolean) As e_Usuario
        Try
            oeUsu = New e_Usuario
            If dsUsuario.Tables.Count > 0 AndAlso dsUsuario.Tables(0).Rows.Count > 0 Then
                oeUsu = Cargar(dsUsuario.Tables(0).Rows(0))
                oeUsu.Autenticado = True
                If oeUsu.Id <> "" Then
                    If lb_Ind Then
                        oeUsuarioPerfil.oeUsuario.Id = oeUsu.Id
                        oeUsu.leUsuarioPerfil = odUsuarioPerfil.Listar(oeUsuarioPerfil)
                        oeTurnoUsuario.IdUsuario = oeUsu.Id
                        oeUsu.leTurnoUsuario = odTurnoUsuario.Listar(oeTurnoUsuario)
                        oeControlTurnoUsuario.IdUsuario = oeUsu.Id
                        oeUsu.oeControlTurnoUsuario = odControlTurnoUsuario.Obtener(oeControlTurnoUsuario)
                        oeEmail.TipoPersonaEmpresa = 1
                        oeEmail.TipoOperacion = "1"
                        oeEmail.IdPersonaEmpresa = oeUsu.oePersona.Id
                        oeUsu.oePersona.leEmail = odEmail.Listar(oeEmail)
                        oePersona = New e_Persona
                        oePersona.Activo = True
                        oePersona.Id = oeUsu.oePersona.Id
                        oePersona.CargaCompleta = True
                        oeUsu.oePersona = odPersona.Obtener(oePersona)
                        oeARUsuario = New e_ActividadRestringida_Usuario
                        oeARUsuario.TipoOperacion = ""
                        oeARUsuario.IdUsuario = oeUsu.Id
                        oeUsu.leARUsuario = odARUsuario.Listar(oeARUsuario)
                    End If
                End If
            End If
            Return oeUsu
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerMenu(ByVal oeUsuario As e_Usuario) As e_Usuario
        Try
            Dim dsMenuProceso As New Data.DataSet
            dsMenuProceso = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_ListarMenu", "", oeUsuario.Id)
            If dsMenuProceso.Tables(0).Rows.Count > 0 Then

            End If
            Return oeUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Usuario, el cual es consultado por el procedimiento 
    ''' almacenado SGD.Isp_Usuario_Listar enviando sus atributos del usuario.Una vez obtenido los registros son cargados
    ''' y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeUsuario">Recibe una Variable oeUsuario de tipo e_Usuario </param>
    ''' <returns>Devuelve una lista generica(lUsuario) de objetos de tipo e_Usuario</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeUsuario As e_Usuario) As List(Of e_Usuario)
        Try
            Dim lUsuario As New List(Of e_Usuario)
            Dim ds As DataSet
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Login, .Clave, .oePersona.Dni, .FechaUltimoIngreso, .FechaFinal, .oeArea.Id, .Controlado, .Activo)
            End With
            oeUsuario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeUsuario = Cargar(o_Fila)
                    lUsuario.Add(oeUsuario)
                Next
                Return lUsuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarIngreso(ByVal oeUsuario As e_Usuario) As List(Of e_Usuario)
        Try
            Dim lUsuario As New List(Of e_Usuario)
            Dim ds As DataSet
            With oeUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Login, .Clave, .oePersona.Dni, .FechaUltimoIngreso, .FechaFinal, .oeArea.Id, .Activo)
            End With
            oeUsuario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeUsuario = Cargar(o_Fila)
                    oeUsuario.Ingresado = ds.Tables(2).Rows(0).Item("Ingresado")
                    oeUsuario.NoIngresado = ds.Tables(1).Rows(0).Item("NoIngreso")
                    lUsuario.Add(oeUsuario)
                Next
                Return lUsuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarConectados() As List(Of e_UsuarioConectado)
        Try
            Dim lUsuario As New List(Of e_Usuario)
            Dim lUsuariosConectados As New List(Of e_UsuarioConectado)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", "3")
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    Dim oeUsuarioConectado = CargarUsuariosConectados(o_Fila)
                    lUsuariosConectados.Add(oeUsuarioConectado)
                Next
                Return lUsuariosConectados
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Genera la lista de usuarios que se han desconectado del SGI
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarDesconectados() As List(Of e_UsuarioDesconectado)
        Try
            Dim lUsuario As New List(Of e_Usuario)
            Dim lUsuariosDesconectados As New List(Of e_UsuarioDesconectado)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", "4")
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    Dim oeUsuarioDesconectado = CargarUsuariosDesconectados(o_Fila)
                    lUsuariosDesconectados.Add(oeUsuarioDesconectado)
                Next
                Return lUsuariosDesconectados
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Generar una lista de usuarios que no han accedido al SGI durante la última semaan
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarUsuariosSinAccesoUltimaSemana() As List(Of e_UsuarioSinAcceso)
        Try
            Dim lUsuario As New List(Of e_Usuario)
            Dim lUsuariosSinAcceso As New List(Of e_UsuarioSinAcceso)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", "5")
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    Dim oeUsuarioSinAcceso = CargarUsuariosSinAcceso(o_Fila)
                    lUsuariosSinAcceso.Add(oeUsuarioSinAcceso)
                Next
                Return lUsuariosSinAcceso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Generar una lista de usuarios que no han accedido al SGI más de una semana / incluso nunca 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarUsuariosSinAccesoMasDeUnaSemana() As List(Of e_UsuarioSinAcceso)
        Try
            Dim lUsuario As New List(Of e_Usuario)
            Dim lUsuariosSinAcceso As New List(Of e_UsuarioSinAcceso)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Usuario_Listar", "6")
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    Dim oeUsuarioSinAcceso = CargarUsuariosSinAcceso(o_Fila)
                    lUsuariosSinAcceso.Add(oeUsuarioSinAcceso)
                Next
                Return lUsuariosSinAcceso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo por la cual se verifica el inicio de sesion del usuario,a travez del procedimiento almacenado
    ''' SGD.ISP_UsuarioValidar se enviaran el login y clave del usuario.
    ''' </summary>
    ''' <param name="oeUsuario">Recibe una Variable oeUsuario de tipo e_Usuario </param>
    ''' <returns>Devuelve un dataset, con los datos del usuario</returns>
    ''' <remarks>Capa del sistema:Capa de Acceso a Datos</remarks>
    Public Function IniciarSesion(ByVal oeUsuario As e_Usuario) As Data.DataSet
        Try
            Return sqlhelper.ExecuteDataset("SGD.ISP_UsuarioValidar", "", oeUsuario.Login, Encriptador.Encriptar(oeUsuario.Clave))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que permite obtener iniciar sesion del usuario, a travez de su metodo IniciarSesion obtendremos si el 
    ''' usuario es verificado con su datos o no encontrado en la base de datos.
    ''' </summary>
    ''' <param name="usuario">Objeto que trae el Login y Claves ingresados por el usuario al momento de autenticarse</param>
    ''' <returns>Devuelve una objeto usuario de tipo e_Usuario</returns>
    ''' <remarks>Capa del sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal usuario As e_Usuario) As e_Usuario
        Dim datos As New DataSet
        Try
            datos = IniciarSesion(usuario)
            If datos.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow
                For Each fila In datos.Tables(0).Rows
                    usuario.Autenticado = True
                    usuario.Id = fila("Id")
                    usuario.oePersona.ApellidoPaterno = fila("ApellidoPaterno")
                    usuario.oePersona.ApellidoMaterno = fila("ApellidoMaterno")
                    usuario.oePersona.Nombre = fila("Nombre")
                    usuario.FechaUltimoIngreso = fila("FechaUltimoIngreso")
                    usuario.oePersona.Dni = fila("Dni")
                    usuario.IdTrabajador = fila("IdTrabajador")
                    usuario.Controlado = fila("Controlado")
                Next
            Else
                Throw New Exception("Usuario no se encuentra registrado")
            End If
            Return usuario
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del usuario,a travez del procedimiento almacenado
    ''' SGD.Isp_Usuario_IAE,por el cual van a ser enviados y registrados los datos del usuario y
    ''' obtendremos una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011.
    ''' </summary>
    ''' <param name="oeUsuario">Recibe una variable oeUsuario de tipo e_Usuario</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeUsuario As e_Usuario) As Boolean
        Try
            Using TransScope As New TransactionScope()
                oeUsuario.oePersona.PrefijoID = oeUsuario.PrefijoID '@0001
                Dim _idpadre As String = odPersona.Guardar(oeUsuario.oePersona)
                Dim id As String = ""
                If _idpadre <> "" Then
                    With oeUsuario
                        id = sqlhelper.ExecuteScalar("SGD.Isp_Usuario_IAE", .TipoOperacion,
                         .Id, _idpadre, "M", .Codigo, .Login, Encriptador.Encriptar(.Clave),
                        .IndFechaUltimoIngreso, .Controlado, .Activo, .PrefijoID)
                    End With
                    If oeUsuario.leUsuarioPerfil IsNot Nothing Then
                        For Each oeUsuarioPerfil As e_UsuarioPerfil In oeUsuario.leUsuarioPerfil
                            oeUsuarioPerfil.oeUsuario.Id = id
                            oeUsuarioPerfil.PrefijoID = oeUsuario.PrefijoID '@0001
                            odUsuarioPerfil.Guardar(oeUsuarioPerfil)
                        Next
                    End If
                    If oeUsuario.leTurnoUsuario IsNot Nothing Then
                        For Each oeTurnoUsuario As e_TurnoUsuario In oeUsuario.leTurnoUsuario
                            oeTurnoUsuario.IdUsuario = id
                            oeTurnoUsuario.PrefijoID = oeUsuario.PrefijoID '@0001
                            odTurnoUsuario.Guardar(oeTurnoUsuario)
                        Next
                    End If
                    oeUsuario.oeControlTurnoUsuario.IdUsuario = id
                    oeUsuario.oeControlTurnoUsuario.TipoOperacion = ""
                    Dim odControlTU As New d_ControlTurnoUsuario
                    oeUsuario.oeControlTurnoUsuario.PrefijoID = oeUsuario.PrefijoID '@0001
                    odControlTU.Guardar(oeUsuario.oeControlTurnoUsuario)
                End If
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del usuario,a travez del procedimiento almacenado
    ''' SGD.Isp_Usuario_IAE,por el cual va a ser enviado el id del usuario a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeUsuario">Recibe una variable oeUsuario de tipo objeto e_Usuario</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeUsuario As e_Usuario) As Boolean
        Try
            With oeUsuario
                sqlhelper.ExecuteNonQuery("SGD.Isp_Usuario_IAE" _
                                          , "E" _
                                          , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encarga de actualizar la fecha de ingreso del usuario en el ingreso y salida del sistema,a travez del 
    ''' procedimiento almacenado SGD.Isp_Usuario_IAE, por el cual va ser enviado los datos del usuario para realizar la actualizacion
    ''' obtendremos una respuesta de confirmacion del registro.
    ''' </summary>
    ''' <param name="oeUsuario">Recibe una variable oeUsuario de tipo objeto e_Usuario</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function ActualizaFechaIngreso(ByVal oeUsuario As e_Usuario) As Boolean
        Try
            With oeUsuario
                Return sqlhelper.ExecuteNonQuery("SGD.Isp_Usuario_IAE", .TipoOperacion,
                     .Id, .oePersona.Id, "M", .Codigo, .Login, Encriptador.Encriptar(.Clave),
                    .IndFechaUltimoIngreso, .Controlado, .Activo, .PrefijoID)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarClave(ByVal oeUsuario As e_Usuario) As Boolean
        Try
            Dim Password As String

            With oeUsuario
                If .Clave = "" Then
                    Password = ""
                Else
                    Password = Encriptador.Encriptar(.Clave)
                End If
                Return sqlhelper.ExecuteNonQuery("SGD.Isp_Usuario_IAE", _
                                                 .TipoOperacion, _
                                                 .Id, _
                                                 .oePersona.Id, _
                                                 "M", _
                                                 .Codigo, _
                                                 .Login, _
                                                 Password)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidaTurno(ByVal oeUsuario As e_Usuario) As Boolean
        Try
            Dim ind As Boolean = False
            Dim oeTurnoUsuario As New e_TurnoUsuario
            Dim odTurnoUsuario As New d_TurnoUsuario
            Dim olTurnoUsuario As New List(Of e_TurnoUsuario)
            oeTurnoUsuario.IdUsuario = oeUsuario.Id
            olTurnoUsuario = odTurnoUsuario.Listar(oeTurnoUsuario)
            If olTurnoUsuario.Count > 0 Then
                Dim dsTurno As DataSet = sqlhelper.ExecuteDataset("SGD.ISP_UsuarioValidar", "T", "", "", oeUsuario.Id)
                If dsTurno.Tables.Count > 0 AndAlso dsTurno.Tables(0).Rows.Count > 0 Then
                    ind = True
                Else
                    Dim dsDia As DataSet = sqlhelper.ExecuteDataset("SGD.ISP_UsuarioValidar", "D", "", "", oeUsuario.Id)
                    If dsDia.Tables.Count > 0 AndAlso dsDia.Tables(0).Rows.Count > 0 Then
                        Throw New Exception("Hoy " & dsDia.Tables(0).Rows(0).Item(1).ToString & ", su hora de Ingreso al SGI es: " & dsDia.Tables(0).Rows(0).Item(2).ToString & " a " & dsDia.Tables(0).Rows(0).Item(3).ToString)
                    Else
                        Throw New Exception("Hoy No Tiene Asignado Turno")
                    End If
                End If
            Else
                ind = True
            End If
            Return ind
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidaSalida(ByVal oeUsuario As e_Usuario) As DataSet
        Try
            Return sqlhelper.ExecuteDataset("SGD.ISP_UsuarioValidar", "H", "", "", oeUsuario.Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
