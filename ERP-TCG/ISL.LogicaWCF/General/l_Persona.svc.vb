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

''' <summary>
''' Clase: Persona;
''' fecha: 15/10/2011
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_Persona
    Implements Il_Persona

    Dim odPersona As New d_Persona
    Dim olTelefono As New l_Telefono
    Dim olEmail As New l_Email
    Public Mensaje As String = "No se ha Ingresado: "
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar Persona
    ''' </summary>
    ''' <param name="oePersona">Objeto Persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oePersona As e_Persona) As Boolean Implements Il_Persona.Eliminar
        Try
            If Validar(oePersona) Then
                odPersona.Eliminar(oePersona)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna la foto de la persona a partir de su DNI
    ''' </summary>
    ''' <param name="DNI"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function Foto(ByVal DNI As String) As System.Drawing.Bitmap Implements Il_Persona.Foto
    '    Try
    '        Return odPersona.Foto(DNI)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    ''' <summary>
    ''' Guardar o grabar la información de la persona
    ''' </summary>
    ''' <param name="oePersona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oePersona As e_Persona) As String Implements Il_Persona.Guardar
        Try
            Dim _IdPersona As String = ""
            If Validar(oePersona) Then
                olEmail.ValidarLista(oePersona.leEmail)
                olTelefono.ValidarLista(oePersona.leTelefono)
                _IdPersona = odPersona.Guardar(oePersona)
            End If
            Return _IdPersona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizarDatos(ByVal oePersona As e_Persona) As String
        Try
            Dim _IdPersona As String = ""
            _IdPersona = odPersona.ActualizarDatos(oePersona)

                Return _IdPersona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePersona As e_Persona) As System.Collections.Generic.List(Of e_Persona) Implements Il_Persona.Listar
        Try
            Return odPersona.Listar(oePersona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePersona As e_Persona) As e_Persona Implements Il_Persona.Obtener
        Try
            Return odPersona.Obtener(oePersona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Validar Persona
    ''' </summary>
    ''' <param name="oePersona">Objeto Persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oePersona As e_Persona) As Boolean Implements Il_Persona.Validar
        Try
            With oePersona
                ValidarDNI(.Id, .Dni)
                l_FuncionesGenerales.ValidarCampoNoNulo(.ApellidoPaterno, "No ha Ingresado Apellido Paterno")
                l_FuncionesGenerales.ValidarCampoNoNulo(.ApellidoMaterno, "No ha Ingresado Apellido Materno")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDNI(ByVal Id As String, ByVal DNI As String) As Boolean Implements Il_Persona.ValidarDNI
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(DNI, "No ha Ingresado DNI")
            If DNI.Length < 8 Then Throw New Exception("Debe ingresar un dni de 8 digitos")
            Dim oePersona As New e_Persona
            oePersona.Dni = DNI
            oePersona = odPersona.Obtener(oePersona)
            If oePersona.Id <> "" Then
                If Id = "" Then Throw New Exception("Ya existe DNI: " & DNI)
                If oePersona.Id <> Id Then Throw New Exception("Ya existe DNI: " & DNI)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaNacimiento(ByVal FechaNacimiento As Date) As Boolean Implements Il_Persona.ValidarFechaNacimiento
        Try
            If FechaNacimiento = #1/1/1901# Then Throw New Exception("No se ha Ingresado Fecha de Nacimiento")
            If FechaNacimiento >= Date.Now.Date Then Throw New Exception("La Fecha de Nacimiento no puede ser mayor que Hoy")
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
