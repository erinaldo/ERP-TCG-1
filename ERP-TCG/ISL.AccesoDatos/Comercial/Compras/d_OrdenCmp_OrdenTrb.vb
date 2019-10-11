'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenCmp_OrdenTrb
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenCmp_OrdenTrb
        Try
            Dim oeOrdenCmp_OrdenTrb = New e_OrdenCmp_OrdenTrb(o_fila("Id").ToString _
                                                              , o_fila("IdOrdenCompra").ToString _
                                                              , o_fila("IdOrdenTrabajo").ToString _
                                                              , o_fila("Activo").ToString)
            Return oeOrdenCmp_OrdenTrb
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As e_OrdenCmp_OrdenTrb
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_OC_OT_Listar", oeOrdenCmp_OrdenTrb.TipoOperacion, oeOrdenCmp_OrdenTrb.Id, oeOrdenCmp_OrdenTrb.IdOrdenCompra, oeOrdenCmp_OrdenTrb.IdOrdenTrabajo)
            oeOrdenCmp_OrdenTrb = New e_OrdenCmp_OrdenTrb
            If ds.Tables(0).rows.Count > 0 Then
                oeOrdenCmp_OrdenTrb = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenCmp_OrdenTrb
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As Boolean
        Try
            With oeOrdenCmp_OrdenTrb
                sqlhelper.ExecuteNonQuery("CMP.Isp_OC_OT_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdOrdenCompra _
                        , .IdOrdenTrabajo _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_OC_OT_IAE", "E", _
             "", oeOrdenCmp_OrdenTrb.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
