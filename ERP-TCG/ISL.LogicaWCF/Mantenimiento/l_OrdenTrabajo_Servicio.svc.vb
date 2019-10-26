Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajo_Servicio
    Implements Il_OrdenTrabajo_Servicio

    Dim odOrdenTrabajo_Servicio As New d_OrdenTrabajo_Servicio

    Public Function Eliminar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean Implements Il_OrdenTrabajo_Servicio.Eliminar
        Try
            Return odOrdenTrabajo_Servicio.Eliminar(oeOrdenTrabajo_Servicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean Implements Il_OrdenTrabajo_Servicio.Guardar
        Try
            If Validar(oeOrdenTrabajo_Servicio) Then
                Return odOrdenTrabajo_Servicio.Guardar(oeOrdenTrabajo_Servicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As System.Collections.Generic.List(Of e_OrdenTrabajo_Servicio) Implements Il_OrdenTrabajo_Servicio.Listar
        Try
            Return odOrdenTrabajo_Servicio.Listar(oeOrdenTrabajo_Servicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDataSet(ByVal ls_OrdenTrabajo As String) As System.Data.DataSet Implements Il_OrdenTrabajo_Servicio.ListarDataSet
        Try
            Return odOrdenTrabajo_Servicio.Listar(ls_OrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As e_OrdenTrabajo_Servicio Implements Il_OrdenTrabajo_Servicio.Obtener
        Try
            Return odOrdenTrabajo_Servicio.Obtener(oeOrdenTrabajo_Servicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean Implements Il_OrdenTrabajo_Servicio.Validar
        Try
            With oeOrdenTrabajo_Servicio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOTS As e_ReporteOTServicio) As System.Collections.Generic.List(Of e_ReporteOTServicio) Implements Il_OrdenTrabajo_Servicio.ListarReporte
        Try
            Return odOrdenTrabajo_Servicio.ListarReporte(oeReporteOTS)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
