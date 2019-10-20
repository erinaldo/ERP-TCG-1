'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Usuario

    Implements Il_Usuario

    Dim odUsuario As New d_Usuario

    Public Function ActualizaFechaUltimoIngreso(ByVal oeUsuario As e_Usuario) As Boolean Implements Il_Usuario.ActualizaFechaUltimoIngreso
        Try
            Return odUsuario.ActualizaFechaIngreso(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Area(ByVal oeUsuario As e_Usuario) As e_Area Implements Il_Usuario.Area
        Try
            Dim olTrabajador As New l_Trabajador
            Dim oeTrabajador As New e_Trabajador
            Dim oePersona As New e_Persona
            oeTrabajador.oePersona.Id = oeUsuario.oePersona.Id
            oeTrabajador.Activo = True
            oeTrabajador = olTrabajador.ObtenerObjeto(oeTrabajador)
            Dim olArea As New l_Area
            Dim oeArea As New e_Area
            oeArea.Id = oeTrabajador.oeArea.Id
            oeArea.Activo = True
            Return olArea.Obtener(oeArea)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarClave(ByVal oeUsuario As e_Usuario) As Boolean Implements Il_Usuario.CambiarClave
        Try
            Return odUsuario.CambiarClave(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeUsuario As e_Usuario) As Boolean Implements Il_Usuario.Eliminar
        Try
            If Validar(oeUsuario) Then
                odUsuario.Eliminar(oeUsuario)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeUsuario As e_Usuario) As Boolean Implements Il_Usuario.Guardar
        Try
            If Validar(oeUsuario) Then
                Return odUsuario.Guardar(oeUsuario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function IniciarSesion(ByVal oeUsuario As e_Usuario) As e_Usuario Implements Il_Usuario.IniciarSesion
        Try
            Dim usuario As e_Usuario = odUsuario.Cargar(oeUsuario)
            Return usuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeUsuario As e_Usuario) As System.Collections.Generic.List(Of e_Usuario) Implements Il_Usuario.Listar
        Try
            Return odUsuario.Listar(oeUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarIngreso(ByVal oeUsuario As e_Usuario) As System.Collections.Generic.List(Of e_Usuario) Implements Il_Usuario.ListarIngreso
        Try
            Return odUsuario.ListarIngreso(oeUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Función que permite recuperar la clave olvidada de usuario del SGI, remitiéndosela al email registrado en el sistema
    ''' </summary>
    ''' <param name="usuario">Login del usuario que necesita recuperar su clave</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RecuperarClave(usuario As String) As String Implements Il_Usuario.RecuperarClave
        Try
            Dim oeUsuario As New e_Usuario
            If usuario.Trim = "ADMINLOG" Then Throw New Exception("Login de usuario no válido")
            oeUsuario.Login = usuario.Trim
            oeUsuario = Obtener(oeUsuario)
            Dim oeEmail As New e_Email
            oeEmail.TipoOperacion = "1"
            oeEmail.TipoPersonaEmpresa = 1
            oeEmail.Principal = -1
            oeEmail.IdPersonaEmpresa = oeUsuario.oePersona.Id
            Dim olEmail As New l_Email
            Dim leEmail As New List(Of e_Email)
            leEmail = olEmail.Listar(oeEmail)
            Dim clienteSMTP As New System.Net.Mail.SmtpClient()
            clienteSMTP.Host = "mail.induamerica.com.pe"
            'clienteSMTP.Port = 25
            clienteSMTP.EnableSsl = False
            clienteSMTP.Credentials = New Net.NetworkCredential("sistemas@induamerica.com.pe", "sis4758")
            Dim correo As New System.Net.Mail.MailMessage()
            If leEmail.Count = 0 Then Throw New Exception("No tiene Email")
            Dim cadenaemail As String = ""
            For Each oe As e_Email In leEmail
                cadenaemail = cadenaemail & Environment.NewLine & oe.Nombre
                correo.To.Add(oe.Nombre)
            Next
            correo.From = New System.Net.Mail.MailAddress("sistemas@induamerica.com.pe")
            correo.Subject = "Recuperación de Contraseña de Seguridad"
            correo.Body = "Su contraseña de acceso al Sistema ISL es: " & oeUsuario.Clave
            clienteSMTP.Send(correo)
            Return "Mensaje Enviado, Rebice su(s) Email(s):" & cadenaemail
        Catch ex As Exception
            Throw ex
        End Try

    End Function



    ''' <summary>
    ''' Retorna la lista de usuarios actualmente conectados al SGI
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarConectados() As System.Collections.Generic.List(Of e_UsuarioConectado) Implements Il_Usuario.ListarConectados
        Try
            Return odUsuario.ListarConectados()
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Retorna la lista de usuarios actualmente conectados al SGI
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarDesconectados() As System.Collections.Generic.List(Of e_UsuarioDesconectado) Implements Il_Usuario.ListarDesconectados
        Try
            Return odUsuario.ListarDesconectados()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarSinAccesoUnaSemana() As System.Collections.Generic.List(Of e_UsuarioSinAcceso) Implements Il_Usuario.ListarSinAccesoUnaSemana
        Try
            Return odUsuario.ListarUsuariosSinAccesoUltimaSemana()
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarSinAccesoMasDeUnaSemana() As System.Collections.Generic.List(Of e_UsuarioSinAcceso) Implements Il_Usuario.ListarSinAccesoMasDeUnaSemana
        Try
            Return odUsuario.ListarUsuariosSinAccesoMasDeUnaSemana()
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeUsuario As e_Usuario) As e_Usuario Implements Il_Usuario.Obtener
        Try
            Return odUsuario.Obtener(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener2(ByVal oeUsuario As e_Usuario) As e_Usuario Implements Il_Usuario.Obtener2
        Try
            Return odUsuario.Obtener2(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerAutorizado(ByVal oeUsuario As e_Usuario) As e_Usuario Implements Il_Usuario.ObtenerAutorizado
        Try
            Return odUsuario.ObtenerAutorizacion(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Valida la entidad Usuario
    ''' </summary>
    ''' <param name="oeUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeUsuario As e_Usuario) As Boolean Implements Il_Usuario.Validar
        Try
            If String.IsNullOrEmpty(oeUsuario.Login) Then Throw New Exception("No ha ingreso el Login")
            If String.IsNullOrEmpty(oeUsuario.Clave) Then Throw New Exception("No ha ingreso el Clave")
            If oeUsuario.leUsuarioPerfil.Count < 1 Then Throw New Exception("Seleccione al menos un Perfil del Usuario")
            Return True
        Catch ex As Exception
            Throw ex
            Return True
        End Try
    End Function

    Public Function ValidarClave(ByVal Clave As String) As Boolean Implements Il_Usuario.ValidarClave
        Try
            If String.IsNullOrEmpty(Clave) Then Throw New Exception("No se ha Ingresado: Clave")
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ValidarNombre(ByVal Nombre As String) As Boolean Implements Il_Usuario.ValidarNombre
        Try
            If String.IsNullOrEmpty(Nombre) Then Throw New Exception("No se ha ingredado: Nombre")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidaSalida(ByVal oeUsuario As e_Usuario) As System.Data.DataSet Implements Il_Usuario.ValidaSalida
        Try
            Return odUsuario.ValidaSalida(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidaTurno(ByVal oeUsuario As e_Usuario) As Boolean Implements Il_Usuario.ValidaTurno
        Try
            Return odUsuario.ValidaTurno(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerUsuarioInicial(ByVal oeUsuario As e_Usuario) As e_Usuario Implements Il_Usuario.ObtenerUsuarioInicial
        Try
            Return odUsuario.ObtenerUsuarioInicial(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function Inicializar() As e_Usuario Implements Il_Usuario.Inicializar
    '    Dim oeUsuario As New e_Usuario
    '    Dim area As New e_Area
    '    area.Activo = True
    '    Dim persona As New e_Persona
    '    persona.Activo = True
    '    Dim controlturnousuario As New e_ControlTurnoUsuario
    '    controlturnousuario.Activo = True
    '    oeUsuario.oeArea = area
    '    oeUsuario.oePersona = persona
    '    oeUsuario.oeControlTurnoUsuario = controlturnousuario
    '    Return oeUsuario
    'End Function

    Public Function ObtieneFechaServidor(oeUsuario As e_Usuario) As e_Usuario Implements Il_Usuario.ObtieneFechaServidor
        Try
            Return odUsuario.ObtenerFechaServidor(oeUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para verificar y/o autenticar al Usuario que ingresa al SGI
    ''' </summary>
    ''' <param name="usuario">Login o nombre del usuario</param>
    ''' <param name="clave">Clave de acceso al SGI</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Autenticar(usuario As String, clave As String) As e_Usuario Implements Il_Usuario.Autenticar

        Dim gUsuarioSGI As New e_Usuario
        Dim olUsuario As New l_Usuario

        gUsuarioSGI.Autenticado = False
        Dim mensajeErrorAcceso As String = "Usuario o clave incorrecta"
        Try
            Dim oeUsuario As New e_Usuario(usuario, clave)
            oeUsuario.TipoOperacion = "F"
            oeUsuario.IndCompleto = True
            gUsuarioSGI = olUsuario.Obtener2(oeUsuario)

            If gUsuarioSGI.Id = "" Then Throw New Exception(mensajeErrorAcceso)
            If Not gUsuarioSGI.Activo Then Throw New Exception("Su Cuenta de Usuario ya no pertenece a la Empresa")
            If gUsuarioSGI.Autenticado Then
                olUsuario.ValidaTurno(gUsuarioSGI)
                gUsuarioSGI.IndFechaUltimoIngreso = True
                olUsuario.ActualizaFechaUltimoIngreso(gUsuarioSGI)
                'If gUsuarioSGI.Controlado > 0 Then
                '    Dim oeControlUsuario As New e_ControlUsuario
                '    Dim olControlUsuario As New l_ControlUsuario
                '    oeControlUsuario.IdUsuario = gUsuarioSGI.Id
                '    oeControlUsuario.Ipv4 = gUsuarioSGI.ObtenerLoginWindows & "(" & gUsuarioSGI.ObtenerIP & ")"
                '    oeControlUsuario.TipoOperacion = "I"
                '    'gIdControl = olControlUsuario.Guardar(oeControlUsuario)
                'End If

                'If gUsuarioSGI.IdTrabajador.Trim <> "" Then
                '    oeTrabSeguridad = New e_TrabajadorSeguridad
                '    oeTrabSeguridad.IdTrabajador = gUsuarioSGI.IdTrabajador
                ' gleTrabSeguridad = olTrabSeguridad.Listar(oeTrabSeguridad)
                'End If
                'gleActividadRestringida = gUsuarioSGI.leARUsuario

                ''Obtener Perfil Principal
                'gUsuarioSGI.Autenticado = True

            End If
            Return gUsuarioSGI
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
