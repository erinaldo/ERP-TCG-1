'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Public Class d_MovimientoCaja
    Private sqlhelper As New SqlHelper

    Private oeMovimientoCaja As New e_MovimientoCaja

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoCaja
        Try
            Dim oeMovimientoCaja = New e_MovimientoCaja( _
             o_fila("Empresa"), _
             o_fila("FechaCompleta"), _
             o_fila("Viaje"), _
             o_fila("Usuario"), _
             o_fila("Voucher"), _
             o_fila("Egreso"), _
             o_fila("Glosa"), _
             o_fila("IdTrabajadorRecepciona"), _
             o_fila("NombreCompleto"), _
             o_fila("Dni"), _
             o_fila("Cargo"), _
             o_fila("Piloto"), _
             o_fila("EgresoTexto"), _
             o_fila("Mov"))
            Return oeMovimientoCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoCaja As e_MovimientoCaja) As e_MovimientoCaja
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ImprimirDocumentoTesoreria", oeMovimientoCaja.TipoOperacion, oeMovimientoCaja.IdMovimiento)
            oeMovimientoCaja = New e_MovimientoCaja
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoCaja = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoCaja As e_MovimientoCaja) As List(Of e_MovimientoCaja)
        Try
            Dim ldMovimientoCaja As New List(Of e_MovimientoCaja)
            Dim ds As DataSet
            With oeMovimientoCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_ImprimirDocumentoTesoreria", oeMovimientoCaja.TipoOperacion, oeMovimientoCaja.IdMovimiento)
            End With
            oeMovimientoCaja = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    ldMovimientoCaja.Add(Cargar(o_Fila))
                Next
                Return ldMovimientoCaja
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
