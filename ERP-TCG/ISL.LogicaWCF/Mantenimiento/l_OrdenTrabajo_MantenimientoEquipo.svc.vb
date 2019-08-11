Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajo_MantenimientoEquipo
    Implements Il_OrdenTrabajo_MantenimientoEquipo

    Dim odOrdenTrabajo_MantenimientoEquipo As New d_OrdenTrabajo_MantenimientoEquipo

    Public Function Eliminar(ByVal oeOrdenTrabajo_MantenimientoEquipo As EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo) As Boolean Implements Il_OrdenTrabajo_MantenimientoEquipo.Eliminar
        Try
            Return odOrdenTrabajo_MantenimientoEquipo.Eliminar(oeOrdenTrabajo_MantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo_MantenimientoEquipo As EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo) As Boolean Implements Il_OrdenTrabajo_MantenimientoEquipo.Guardar
        Try
            If Validar(oeOrdenTrabajo_MantenimientoEquipo) Then
                Return odOrdenTrabajo_MantenimientoEquipo.Guardar(oeOrdenTrabajo_MantenimientoEquipo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_MantenimientoEquipo As EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo) Implements Il_OrdenTrabajo_MantenimientoEquipo.Listar
        Try
            Return odOrdenTrabajo_MantenimientoEquipo.Listar(oeOrdenTrabajo_MantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As System.Data.DataSet Implements Il_OrdenTrabajo_MantenimientoEquipo.ListarDataSet
        Try
            Return odOrdenTrabajo_MantenimientoEquipo.Listar(ls_IdOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_MantenimientoEquipo As EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo) As EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo Implements Il_OrdenTrabajo_MantenimientoEquipo.Obtener
        Try
            Return odOrdenTrabajo_MantenimientoEquipo.Obtener(oeOrdenTrabajo_MantenimientoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajo_MantenimientoEquipo As EntidadesWCF.e_OrdenTrabajo_MantenimientoEquipo) As Boolean Implements Il_OrdenTrabajo_MantenimientoEquipo.Validar
        Try
            With oeOrdenTrabajo_MantenimientoEquipo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
