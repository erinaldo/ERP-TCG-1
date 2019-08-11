Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MantenimientoEquipo
    Implements Il_MantenimientoEquipo

    Dim odMantenimientoEquipo As New d_MantenimientoEquipo

    Public Function Eliminar(ByVal oeMantenimientoEquipo As EntidadesWCF.e_MantenimientoEquipo) As Boolean Implements Il_MantenimientoEquipo.Eliminar
        Try
            Return odMantenimientoEquipo.Eliminar(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoEquipo As EntidadesWCF.e_MantenimientoEquipo) As Boolean Implements Il_MantenimientoEquipo.Guardar
        Try
            If Validar(oeMantenimientoEquipo) Then
                Return odMantenimientoEquipo.Guardar(oeMantenimientoEquipo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoEquipo As EntidadesWCF.e_MantenimientoEquipo) As System.Collections.Generic.List(Of EntidadesWCF.e_MantenimientoEquipo) Implements Il_MantenimientoEquipo.Listar
        Try
            Return odMantenimientoEquipo.Listar(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoEquipo As EntidadesWCF.e_MantenimientoEquipo) As EntidadesWCF.e_MantenimientoEquipo Implements Il_MantenimientoEquipo.Obtener
        Try
            Return odMantenimientoEquipo.Obtener(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimientoEquipo As EntidadesWCF.e_MantenimientoEquipo) As Boolean Implements Il_MantenimientoEquipo.Validar
        Try
            With oeMantenimientoEquipo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
