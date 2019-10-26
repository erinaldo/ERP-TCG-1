'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_PagoDescuento
    Private sqlhelper As New SqlHelper
    Private oePagoDescuento As New e_PagoDescuento

    Private Function Cargar(ByVal o_fila As DataRow) As e_PagoDescuento
        Try
            oePagoDescuento = New e_PagoDescuento(o_fila("IdTrabajador"), _
                                                  o_fila("Dni"), _
                                                  o_fila("Trabajador"), _
                                                  o_fila("Monto"), _
                                                  o_fila("Saldo"), _
                                                  o_fila("Cuota"), _
                                                  o_fila("CadIdPrestamo"), _
                                                  o_fila("MontoPrestamo"), _
                                                  o_fila("CadIdPrestamoDet"))
            Return oePagoDescuento
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Listar(ByVal oePagoDescuento As e_PagoDescuento) As List(Of e_PagoDescuento)
        Try
            Dim lePagoDescuento As New List(Of e_PagoDescuento)
            Dim ds As DataSet
            With oePagoDescuento
                ds = sqlhelper.ExecuteDataset("[TES].[Isp_PagoDescuento_Listar]", _
                                                 .TipoOperacion _
                                                , .IdTrabajador _
                                                , .Anio _
                                                , .Mes _
                                                , .DobleMes _
                                                , .Indicador)

            End With
            oePagoDescuento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePagoDescuento = Cargar(o_Fila)
                    lePagoDescuento.Add(oePagoDescuento)
                Next
            End If
            Return lePagoDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
