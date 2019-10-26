Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlActividad
    Implements Il_ControlActividad
    Dim odControlActividad As New d_ControlActividad

    Public Function Eliminar(ByVal oeControlActividad As e_ControlActividad) As Boolean Implements Il_ControlActividad.Eliminar
        Try
            Return odControlActividad.Eliminar(oeControlActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlActividad As e_ControlActividad) As Boolean Implements Il_ControlActividad.Guardar
        Try
            If Validar(oeControlActividad) Then
                Return odControlActividad.Guardar(oeControlActividad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlActividad As e_ControlActividad) As System.Collections.Generic.List(Of e_ControlActividad) Implements Il_ControlActividad.Listar
        Try
            Return odControlActividad.Listar(oeControlActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlActividad As e_ControlActividad) As e_ControlActividad Implements Il_ControlActividad.Obtener
        Try
            Return odControlActividad.Obtener(oeControlActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlActividad As e_ControlActividad) As Boolean Implements Il_ControlActividad.Validar
        Try
            With oeControlActividad
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
