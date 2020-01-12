Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
'Imports MessagingToolkit.QRCode.Codec
Imports System.IO

Public Class frm_DocumentoCtble_Imprimir

    Private IdDocumentoCtble As String, TipoPapel As String, ModuloEmision As String
    Private DocumentoCtble As New e_MovimientoDocumento, wr_DocumentoCtble As New l_MovimientoDocumento
    Private DT1 As New DataTable, DT2 As New DataTable, DT3 As New DataTable
    'Dim Qr_Code As New QRCodeEncoder

    Sub New(pIdDocumentoCtble As String, pTipoPapel As String, pModulo As String)
        InitializeComponent()
        IdDocumentoCtble = pIdDocumentoCtble
        TipoPapel = pIdDocumentoCtble
        ModuloEmision = pModulo
        DT1 = wr_DocumentoCtble.dt_DocumentoCtble(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})
        DT2 = wr_DocumentoCtble.dt_DocumentoCtble_Detalle(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})
        DT3 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})
    End Sub


    Private Sub frm_DocumentoCtble_Imprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ReportDataSource1 As New ReportDataSource("DocumentoCtble", DT1)
            Dim ReportDataSource2 As New ReportDataSource("DocumentoCtble_Detalle", DT2)
            Dim ReportDataSource3 As New ReportDataSource("DocumentoCtble_Impresion", DT3)

            With ReportViewer1
                .LocalReport.ReportPath = Obtener_RutaReporte(DocumentoCtble.IdTipoDocumento)
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(ReportDataSource1)
                .LocalReport.DataSources.Add(ReportDataSource2)
                .LocalReport.DataSources.Add(ReportDataSource3)
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

                'Dim myParams(9) As Microsoft.Reporting.WinForms.ReportParameter
                'myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("DOCUMENTO", mo_DocElectronico.Documento)
                'myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("DIRECCION", mo_DocElectronico.DomFiscal)
                'myParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("RAZONSOCIAL", mo_DocElectronico.RazonSocial)
                'myParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("TELEFONO", go_Empresa.Telefono)
                'myParams(4) = New Microsoft.Reporting.WinForms.ReportParameter("MONTOLETRAS", MontoLetras)
                'myParams(5) = New Microsoft.Reporting.WinForms.ReportParameter("HASH", mo_DocElectronico.Hash)
                'myParams(6) = New Microsoft.Reporting.WinForms.ReportParameter("CODIGOQR", CodigoQR)
                'myParams(7) = New Microsoft.Reporting.WinForms.ReportParameter("SEDE_PRODUCTIVA", gs_SedeProductiva)
                'myParams(8) = New Microsoft.Reporting.WinForms.ReportParameter("MONTO_IGV", CStr(CInt(gn_IGV * 100)))
                'myParams(9) = New Microsoft.Reporting.WinForms.ReportParameter("TOTAL_DOC", mo_DocElectronico.Total)
                '.LocalReport.SetParameters(myParams)

                .LocalReport.Refresh()
                .RefreshReport()
            End With

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub frm_DocumentoCtble_Imprimir_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            'Dim Archivo As String = "C:\TEST\" & DocumentoCtble.DatosImpresion.TipoDocumento & "_" & DocumentoCtble.Serie & DocumentoCtble.Numero & ".pdf"
            'Dim bytes As Byte()
            'Dim filepath As String = Archivo
            'If File.Exists(filepath) Then My.Computer.FileSystem.DeleteFile(filepath)
            'bytes = ReportViewer1.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            'Dim fs As New FileStream(Archivo, FileMode.Create)
            'fs.Write(bytes, 0, bytes.Length)
            'fs.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Obtener_RutaReporte(IdTipoDocumento As String) As String
        Select Case ModuloEmision
            Case "GRIFO"
                Select Case IdTipoDocumento
                    Case "1CH000000026" 'Factura
                        Select Case TipoPapel
                            Case "A4" : Return ""
                            Case "TICKET" : Return "Grifo\Impresiones\rpt_DocumentoCtble_Termica.rdlc"
                        End Select
                    Case "1CH000000002" 'Boleta de Venta
                        Select Case TipoPapel
                            Case "A4" : Return ""
                            Case "TICKET" : Return "Grifo\Impresiones\rpt_DocumentoCtble_Termica.rdlc"
                        End Select
                    Case "GCH000000001" 'Nota de Despacho
                        Select Case TipoPapel
                            Case "A4" : Return ""
                            Case "TICKET" : Return "Grifo\Impresiones\rpt_DocumentoCtble_Termica.rdlc"
                        End Select
                End Select
            Case Else
                Return ""
        End Select
    End Function
End Class