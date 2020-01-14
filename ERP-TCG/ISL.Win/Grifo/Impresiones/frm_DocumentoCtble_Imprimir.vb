Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
'Imports MessagingToolkit.QRCode.Codec
Imports System.IO

Public Class frm_DocumentoCtble_Imprimir

    Private IdDocumentoCtble As String, TipoPapel As String, ModuloEmision As String, CodigoQR As String = "", Footer As String = ""
    Private DocumentoCtble As New e_MovimientoDocumento, wr_DocumentoCtble As New l_MovimientoDocumento
    Private DT1 As New DataTable, DT2 As New DataTable
    Private RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource
    'Dim Qr_Code As New QRCodeEncoder

    Sub New(pIdDocumentoCtble As String, pTipoPapel As String, pModulo As String)
        InitializeComponent()
        IdDocumentoCtble = pIdDocumentoCtble
        TipoPapel = pTipoPapel
        ModuloEmision = pModulo
        Inicializar()
    End Sub

    Private Sub Inicializar()
        Try
            DocumentoCtble = wr_DocumentoCtble.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})
            DT1 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "CAB", .Id = IdDocumentoCtble})
            DT2 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "DET", .Id = IdDocumentoCtble})
            BSO1.DataSource = DT1
            BSO2.DataSource = DT2
            If DocumentoCtble.IdTipoDocumento <> "GCH000000001" Then
                CodigoQR = ""
                Footer = "Autorizado mediante Resolucion de Intendencia Nª 0720050000152/SUNAT" & vbCrLf & "Representacion impresa del comprobante de venta electronico. Consulte su documento en cpe.sunat.gob.pe"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub


    Private Sub frm_DocumentoCtble_Imprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With RDS1
                .Name = "Cabecera"
                .Value = BSO1
            End With
            With RDS2
                .Name = "Detalle"
                .Value = BSO2
            End With

            With VISOR
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportPath = Obtener_RutaReporte(DocumentoCtble.IdTipoDocumento)
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(RDS1)
                .LocalReport.DataSources.Add(RDS2)

                '' Parametros
                'Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
                'myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CodigoQR", CodigoQR)
                'myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Footer", Footer)
                '.LocalReport.SetParameters(myParams)

                .LocalReport.Refresh()
            End With

            VISOR.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
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
        'C:\Users\CESS\Source\Repos\ERP-TCG\ERP-TCG\ISL.Win\Grifo\Impresiones\rpt_DocumentoCtble_A4.rdlc
        Select Case ModuloEmision
            Case "GRIFO"
                Select Case IdTipoDocumento
                    Case "1CH000000026" 'Factura
                        Select Case TipoPapel
                            Case "A4" : Return "ISL.Win.rpt_DocumentoCtble_A4.rdlc"
                            Case "TICKET" : Return "Grifo\Impresiones\rpt_DocumentoCtble_Termica.rdlc"
                        End Select
                    Case "1CH000000002" 'Boleta de Venta
                        Select Case TipoPapel
                            Case "A4" : Return "Grifo\Impresiones\rpt_DocumentoCtble_A4.rdlc"
                            Case "TICKET" : Return "Grifo\Impresiones\rpt_DocumentoCtble_Termica.rdlc"
                        End Select
                    Case "GCH000000001" 'Nota de Despacho
                        Select Case TipoPapel
                            Case "A4" : Return "Grifo\Impresiones\rpt_DocumentoCtble_A4.rdlc"
                            Case "TICKET" : Return "Grifo\Impresiones\rpt_DocumentoCtble_Termica.rdlc"
                        End Select
                End Select
            Case Else
                Return ""
        End Select
        Return ""
    End Function
End Class