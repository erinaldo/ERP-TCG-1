Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_rptNotaCredito

    Private Function CrearDTDetalleDoc() As Data.DataTable
        Dim DetalleDoc As New Data.DataTable
        With DetalleDoc
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Codigo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("PrecioUnitario", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ValorVenta", Type.GetType("System.Double")))
        End With
        Return DetalleDoc
    End Function

    Private Sub frm_NotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.rvNotaCredito.RefreshReport()
    End Sub

    Public Sub CargarDoc(ByVal oeDoc As e_MovimientoDocumento, ByVal oeDocAso As e_MovimientoDocumento)
        Try
            Dim dtDetalle As Data.DataTable = CrearDTDetalleDoc()
            Dim rw As Data.DataRow
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda

            With oeDoc

                
                oeMoneda.Activo = True
                oeMoneda.Id = .IdMoneda
                oeMoneda = olMoneda.Obtener(oeMoneda)

                rw = dtDetalle.NewRow
                rw("Cantidad") = 0
                rw("Codigo") = ""
                rw("Descripcion") = .Glosa
                rw("PrecioUnitario") = 0
                rw("ValorVenta") = .SubTotal
                dtDetalle.Rows.Add(rw)

                'Procesa los datos de la factura
                Me.rvNotaCredito.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                Me.rvNotaCredito.Visible = True
                'Nueva Linea Local--------
                ' Me.rptFacturaVenta.LocalReport.ReportPath = "Reportes\rptFacturaPrueba.rdlc"
                '-------------------------
                Dim oReport As New ReportDataSource("dsDetalleDoc_dtDetalleDoc", dtDetalle)

                'Parámetros de la cabecera de la factura
                Dim parametros As New List(Of ReportParameter)
                parametros.Add(New ReportParameter("Cliente", .NombreProveedor, False))
                parametros.Add(New ReportParameter("Ruc", .Ruc, False))
                parametros.Add(New ReportParameter("fecEmision", .FechaEmision, False))
                parametros.Add(New ReportParameter("Denominacion", oeDocAso.Tipo, False))
                parametros.Add(New ReportParameter("NroDenominacion", oeDocAso.Serie & " - " & oeDocAso.Numero, False))
                'Dim vardir As String = ""
                'If .Direccion.Length > 70 Then
                '    vardir = .Direccion.Substring(0, 70)
                'Else
                '    vardir = .Direccion
                'End If
                ''Parámetros de pie de factura
                parametros.Add(New ReportParameter("Igv", .IGV, False))
                parametros.Add(New ReportParameter("Otros", 0, False))
                parametros.Add(New ReportParameter("Total", .Total, False))
                parametros.Add(New ReportParameter("TotalLiteral", "SON: " _
                                                   & Conversiones.NumerosALetras.Ejecutar(.Total, True, True _
                                                                                          , IIf(oeMoneda.Nombre = "SOLES", "NUEVOS SOLES", oeMoneda.Nombre)) _
                                                   , False))
                parametros.Add(New ReportParameter("MonedaAbrev", oeMoneda.Abreviatura, False))
                parametros.Add(New ReportParameter("FechaRecepciona", #1/1/1901#, False))
                parametros.Add(New ReportParameter("FechaEmision", oeDocAso.FechaEmision, False))

                'Proceso de generación de la factura
                Me.rvNotaCredito.LocalReport.DataSources.Clear()
                Me.rvNotaCredito.LocalReport.DataSources.Add(oReport)

                Me.rvNotaCredito.LocalReport.SetParameters(parametros)

                Me.rvNotaCredito.LocalReport.Refresh()
                Me.rvNotaCredito.RefreshReport()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class