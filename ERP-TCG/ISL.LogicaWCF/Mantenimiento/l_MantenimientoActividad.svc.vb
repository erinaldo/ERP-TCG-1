Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MantenimientoActividad
    Implements Il_MantenimientoActividad

    Dim odMantenimientoActividad As New d_MantenimientoActividad

    Public Function Eliminar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean Implements Il_MantenimientoActividad.Eliminar
        Try
            Return odMantenimientoActividad.Eliminar(oeMantenimientoActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean Implements Il_MantenimientoActividad.Guardar
        Try
            If Validar(oeMantenimientoActividad) Then
                Return odMantenimientoActividad.Guardar(oeMantenimientoActividad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As System.Collections.Generic.List(Of e_MantenimientoActividad) Implements Il_MantenimientoActividad.Listar
        Try
            Return odMantenimientoActividad.Listar(oeMantenimientoActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As e_MantenimientoActividad Implements Il_MantenimientoActividad.Obtener
        Try
            Return odMantenimientoActividad.Obtener(oeMantenimientoActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean Implements Il_MantenimientoActividad.Validar
        Try
            With oeMantenimientoActividad
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
