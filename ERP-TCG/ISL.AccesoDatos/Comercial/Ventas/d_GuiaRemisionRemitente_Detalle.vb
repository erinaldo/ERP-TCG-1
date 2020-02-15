Imports ERP.EntidadesWCF
Imports System.Data.SqlClient

Public Class d_GuiaRemisionRemitente_Detalle

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GuiaRemisionRemitente_Detalle
        Try
            Dim oeGuiaRemitente = New e_GuiaRemisionRemitente_Detalle With {.Id = o_fila("Id").ToString, .IdGRR_Venta = o_fila("IdGRR_Venta").ToString _
                , .IdUnidadMedida = o_fila("IdUnidadMedida").ToString, .IdMaterial = o_fila("IdMaterial").ToString, .Cantidad = o_fila("Cantidad") _
                , .CodigoMaterial = o_fila("CodigoMaterial").ToString, .Material = o_fila("Material").ToString, .Peso = o_fila("Peso") _
                , .PesoTotal = o_fila("PesoTotal"), .UsuarioCrea = o_fila("UsuarioCrea").ToString}
            Return oeGuiaRemitente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemitente As e_GuiaRemisionRemitente_Detalle) As e_GuiaRemisionRemitente_Detalle
        Try
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("[ADM].[Isp_GRRVenta_Detalle_Listar]", "", .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiaRemitente = Cargar(ds.Tables(0).Rows(0))
                Return oeGuiaRemitente
            Else
                oeGuiaRemitente = New e_GuiaRemisionRemitente_Detalle
                Return oeGuiaRemitente
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemitente As e_GuiaRemisionRemitente_Detalle) As List(Of e_GuiaRemisionRemitente_Detalle)
        Try
            Dim ldGuiaRemitente As New List(Of e_GuiaRemisionRemitente_Detalle)
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("[ADM].[Isp_GRRVenta_Detalle_Listar]", .TipoOperacion, .IdEmpresaSis, .IdSucursal, .Id, .IdGRR_Venta)
            End With
            oeGuiaRemitente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaRemitente = Cargar(o_Fila)
                    ldGuiaRemitente.Add(oeGuiaRemitente)
                Next
            Else
                ldGuiaRemitente = New List(Of e_GuiaRemisionRemitente_Detalle)
            End If
            Return ldGuiaRemitente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDT(oe As e_GuiaRemisionRemitente_Detalle) As DataTable
        Try
            Dim DT As New DataTable, DS As New DataSet
            With oe
                DS = sqlhelper.ExecuteDataset("[ADM].[Isp_GRRVenta_Detalle_Listar]", .TipoOperacion, .Id, .IdEmpresaSis, .IdSucursal, .IdGRR_Venta)
                If DS.Tables(0).Rows.Count > 0 Then
                    DT = DS.Tables(0)
                End If
            End With
            Return DT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemitente As e_GuiaRemisionRemitente_Detalle) As Boolean
        Try
            With oeGuiaRemitente
                sqlhelper.ExecuteNonQuery("[ADM].[Isp_GRRVenta_Detalle_IAE]", .TipoOperacion, .PrefijoID, .Id, .IdEmpresaSis, .IdSucursal,
                                          .IdGRR_Venta, .IdUnidadMedida, .IdMaterial, .Cantidad, .Peso, .UsuarioCrea)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiaRemitente As e_GuiaRemisionRemitente_Detalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[ADM].[Isp_GRRVenta_Detalle_IAE]", "E",
                                        "",
                                        oeGuiaRemitente.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
