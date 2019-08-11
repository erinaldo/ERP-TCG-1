Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_DetalleInventario
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleInventario
        Try
            Dim oeDetalle_Inventario = New e_DetalleInventario( _
                             o_fila("Id").ToString _
                             , o_fila("IdInventario").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("ValorUnitario").ToString _
                             , o_fila("FechaCreacion").ToString _
            )
            Return oeDetalle_Inventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalle_Inventario As e_DetalleInventario) As e_DetalleInventario

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_DetalleInventario_Listar", "", oeDetalle_Inventario.Id)
            If ds.Tables.Count > 0 Then
                oeDetalle_Inventario = Cargar(ds.Tables(0).Rows(0))
                Return oeDetalle_Inventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalle_Inventario As e_DetalleInventario) As List(Of e_DetalleInventario)
        Try
            Dim ldDetalle_Inventario As New List(Of e_DetalleInventario)
            Dim ds As DataSet
            With oeDetalle_Inventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_DetalleInventario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdInventario _
                        , .IdMaterial _
                        , .Cantidad _
                        , .ValorUnitario _
                        , .Fecha _
                        , "" _
                        , 1 _
                        , .IdSubAlmacen)
            End With
            oeDetalle_Inventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalle_Inventario = Cargar(o_Fila)
                    ldDetalle_Inventario.Add(oeDetalle_Inventario)
                Next
                Return ldDetalle_Inventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
