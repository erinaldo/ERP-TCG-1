'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_InventarioValorizado
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_InventarioValorizado
        Try
            Dim oeInventarioValorizado = New e_InventarioValorizado( _
                             o_fila("Id").ToString _
                             , o_fila("NroMovimiento").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("TipoMovimiento").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("CantIngreso").ToString _
                             , o_fila("CostoIngreso").ToString _
                             , o_fila("ValorIngreso").ToString _
                             , o_fila("CantSalida").ToString _
                             , o_fila("CostoSalida").ToString _
                             , o_fila("ValorSalida").ToString _
                             , o_fila("CantSaldo").ToString _
                             , o_fila("CostoSaldo").ToString _
                             , o_fila("ValorSaldo").ToString _
            )
            Return oeInventarioValorizado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeInventarioValorizado As e_InventarioValorizado) As List(Of e_InventarioValorizado)
        Try
            Dim ldInventarioValorizado As New List(Of e_InventarioValorizado)
            Dim ds As DataSet
            With oeInventarioValorizado
                ds = sqlhelper.ExecuteDataset("ALM.ISP_Inventario_Listar", .tipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .IdSubAlmacen _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , Nothing _
                        , "" _
                        , Nothing _
                        , .fechaFin _
                        , Nothing _
                        )
                'cambiar el ultimo  nothing fecha de inicio
                oeInventarioValorizado = Nothing
                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeInventarioValorizado = Cargar(o_Fila)
                        ldInventarioValorizado.Add(oeInventarioValorizado)
                    Next

                    Return ldInventarioValorizado
                Else
                    Return Nothing
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
