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
Public Class l_ControlUsuario
    Implements Il_ControlUsuario

    Dim odControlUsuario As New d_ControlUsuario

    Public Function Eliminar(ByVal oeControlUsuario As e_ControlUsuario) As Boolean Implements Il_ControlUsuario.Eliminar
        Try
            Return odControlUsuario.Eliminar(oeControlUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlUsuario As e_ControlUsuario) As String Implements Il_ControlUsuario.Guardar
        Try
            Dim id As String = ""
            If Validar(oeControlUsuario) Then
                id = odControlUsuario.Guardar(oeControlUsuario)
            End If
            Return id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeControlUsuario As e_ControlUsuario) As System.Collections.Generic.List(Of e_ControlUsuario) Implements Il_ControlUsuario.Listar
        Try
            Return odControlUsuario.Listar(oeControlUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlUsuario As e_ControlUsuario) As e_ControlUsuario Implements Il_ControlUsuario.Obtener
        Try
            Return odControlUsuario.Obtener(oeControlUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeControlUsuario As e_ControlUsuario) As Boolean Implements Il_ControlUsuario.Validar
        Try
            With oeControlUsuario
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Registrar la salida de usuarios del SGI
    ''' </summary>
    ''' <param name="idControlUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RegistrarSalida(idControlUsuario As String) As Boolean Implements Il_ControlUsuario.RegistrarSalida
        Try
            If Not String.IsNullOrEmpty(idControlUsuario) Then
                Dim oeControlUsuario As New e_ControlUsuario
                oeControlUsuario.Id = idControlUsuario
                oeControlUsuario.TipoOperacion = "S"
                Guardar(oeControlUsuario)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
