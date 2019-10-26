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
Public Class l_MantenimientoEquipo
    Implements Il_MantenimientoEquipo

    Dim odMantenimientoEquipo As New d_MantenimientoEquipo

    Public Function Eliminar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As Boolean Implements Il_MantenimientoEquipo.Eliminar
        Try
            Return odMantenimientoEquipo.Eliminar(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As Boolean Implements Il_MantenimientoEquipo.Guardar
        Try
            If Validar(oeMantenimientoEquipo) Then
                Return odMantenimientoEquipo.Guardar(oeMantenimientoEquipo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As System.Collections.Generic.List(Of e_MantenimientoEquipo) Implements Il_MantenimientoEquipo.Listar
        Try
            Return odMantenimientoEquipo.Listar(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As e_MantenimientoEquipo Implements Il_MantenimientoEquipo.Obtener
        Try
            Return odMantenimientoEquipo.Obtener(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As Boolean Implements Il_MantenimientoEquipo.Validar
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
