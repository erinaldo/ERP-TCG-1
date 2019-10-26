Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlTurnoUsuario
    Implements Il_ControlTurnoUsuario
    Dim odControlTurnoUsuario As New d_ControlTurnoUsuario

    Public Function Eliminar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean Implements Il_ControlTurnoUsuario.Eliminar
        Try
            Return odControlTurnoUsuario.Eliminar(oeControlTurnoUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean Implements Il_ControlTurnoUsuario.Guardar
        Try
            If Validar(oeControlTurnoUsuario) Then
                Return odControlTurnoUsuario.Guardar(oeControlTurnoUsuario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As System.Collections.Generic.List(Of e_ControlTurnoUsuario) Implements Il_ControlTurnoUsuario.Listar
        Try
            Return odControlTurnoUsuario.Listar(oeControlTurnoUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As e_ControlTurnoUsuario Implements Il_ControlTurnoUsuario.Obtener
        Try
            Return odControlTurnoUsuario.Obtener(oeControlTurnoUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean Implements Il_ControlTurnoUsuario.Validar
        Try
            With oeControlTurnoUsuario
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
