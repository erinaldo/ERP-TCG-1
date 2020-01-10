Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
'Imports MessagingToolkit.QRCode.Codec
Imports System.IO

Public Class frm_DocumentoCtble_Imprimir

    Dim IdDocumentoCtble As String
    Dim TipoPapel As String
    Dim DocumentoCtble As New e_MovimientoDocumento, wr_DocumentoCtble As New l_MovimientoDocumento
    'Dim Qr_Code As New QRCodeEncoder

    Sub New(pIdDocumentoCtble As String, pTipoPapel As String)
        InitializeComponent()
        IdDocumentoCtble = pIdDocumentoCtble
        TipoPapel = pIdDocumentoCtble
        DocumentoCtble = wr_DocumentoCtble.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})

    End Sub


    Private Sub frm_DocumentoCtble_Imprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ReportDataSource1 As New ReportDataSource("DocumentoCtble", DocumentoCtble)
        Dim ReportDataSource2 As New ReportDataSource("DocumentoCtble_Detalle", DocumentoCtble.lstDetalleDocumento)
        Dim ReportDataSource3 As New ReportDataSource("DocumentoCtble_Impresion", DocumentoCtble.DatosImpresion)

        With ReportViewer1
            .LocalReport.DataSources.Add(ReportDataSource1)
            .LocalReport.DataSources.Add(ReportDataSource2)
            .LocalReport.DataSources.Add(ReportDataSource3)
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportPath = Obtener_RutaReporte(DocumentoCtble.IdTipoDocumento)

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

    Function Obtener_RutaReporte(IdTipoDocumento) As String
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
    End Function
End Class