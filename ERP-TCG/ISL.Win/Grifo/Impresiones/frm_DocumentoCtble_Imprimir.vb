Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports MessagingToolkit.QRCode.Codec
Imports System.IO

Public Class frm_DocumentoCtble_Imprimir

    Private IdDocumentoCtble As String, TipoPapel As String, ModuloEmision As String, CodigoQR As String = "", Footer As String = ""
    Dim Qr_Code As New QRCodeEncoder
    Private DocumentoCtble As New e_MovimientoDocumento, wr_DocumentoCtble As New l_MovimientoDocumento
    Private ListaDocumentos As New List(Of e_MovimientoDocumento)
    Private DT1 As New DataTable, DT2 As New DataTable
    Private RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        mt_Exportar_Complementos()
    End Sub

    Private TituloExcel As String = "Documentos Anexos de "

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        mt_Cerrar()
    End Sub
    'Dim Qr_Code As New QRCodeEncoder

    Sub New(pIdDocumentoCtble As String, pTipoPapel As String, pModulo As String, pTipoOp As String)
        InitializeComponent()
        IdDocumentoCtble = pIdDocumentoCtble
        TipoPapel = pTipoPapel
        ModuloEmision = pModulo
        Inicializar(pTipoOp)
    End Sub

    Private Function lf_ObtenerTipoDoc(IdTipoDoc) As String
        Dim TipoDoc As String = ""
        Try
            Select Case IdTipoDoc
                Case "BOLETA DE VENTA"
                    TipoDoc = "03"
                Case "FACTURA"
                    TipoDoc = "01"
                Case "NOTA DE CRÉDITO"
                    TipoDoc = "07"
                Case "NOTA DE DÉBITO"
                    TipoDoc = "08"
                Case Else
                    TipoDoc = ""
            End Select
        Catch ex As Exception
            Throw ex
        End Try
        Return TipoDoc
    End Function

    Private Sub Inicializar(pTipoOp As String)
        Try
            Dim IGV As Double = 0
            Dim Total As Double = 0
            Dim Emision As Date
            DocumentoCtble = wr_DocumentoCtble.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})
            If pTipoOp = "" Then
                DT1 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "CAB", .Id = IdDocumentoCtble})
                DT2 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "DET", .Id = IdDocumentoCtble})
            Else
                DT1 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = (pTipoOp + "" + "C"), .Id = IdDocumentoCtble})
                DT2 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = (pTipoOp + "" + "D"), .Id = IdDocumentoCtble})

                DT1.Rows(0).Item("MontoLetras") = ConvertirNumeroALetras(Math.Round(DT1.Rows(0).Item("Total"), 2).ToString) + " " + DT1.Rows(0).Item("Moneda")
            End If

            If DocumentoCtble.IdTipoDocumento <> "GCH000000001" Then
                CodigoQR = ""
                Footer = "Autorizado mediante Resolucion de Intendencia Nª 0720050000152/SUNAT" & vbCrLf & "Representacion impresa del comprobante de venta electronico. Consulte su documento en cpe.sunat.gob.pe"
            End If
            Dim Resumen As String = ""
            For Each row As DataRow In DT1.Rows
                IGV = CDbl(row("IGV"))
                Total = CDbl(row("Total"))
                Emision = CDate(row("Emision"))
                Resumen = gs_RucEmpresaSistema & "|" & lf_ObtenerTipoDoc(row("Tipo")) & "|" & Strings.Left(row("SerieNumero"), 4) & "|" &
                    Strings.Right(row("SerieNumero"), 8) & "|" & IGV.ToString("F2") & "|" & Total.ToString("F2") & "|" &
                    Emision.ToString("yyyy-MM-dd") & "|" & IIf(CStr(row("DOI")).Length = "8", "1", "6") & "|" & row("DOI") & "|"
                Dim ImagenQR As Image = Qr_Code.Encode(Resumen)
                row("QR") = ImageToBase64(ImagenQR, System.Drawing.Imaging.ImageFormat.Jpeg)
            Next
            'oe_DocElectronico.RUCEmisor & "|" & oe_DocElectronico.TipoDocumento & "|" & Strings.Left(oe_DocElectronico.Documento, 4) & "|" &
            '     Strings.Right(oe_DocElectronico.Documento, 8) & "|" & oe_DocElectronico.TotalIGV.ToString("F2") & "|" & oe_DocElectronico.Total.ToString("F2") & "|" &
            '     oe_DocElectronico.FechaEmision.ToString("yyyy-MM-dd") & "|" & IIf(oe_DocElectronico.DocumentoReceptor.Length = 8, "1", "6") & "|" &
            '     oe_DocElectronico.DocumentoReceptor & "|"

            '@0001 Ini
            'Dim dc As DataColumn
            ''dc = New DataColumn("EmpresaSis", Type.GetType("System.String"))
            'DT1.Columns.Add(dc)
            'dc = New DataColumn("CodigoQR", Type.GetType("System.String"))
            'DT1.Columns.Add(dc)
            'dc = New DataColumn("Footer", Type.GetType("System.String"))
            'DT1.Columns.Add(dc)
            'DT1.Rows(0).Item("EmpresaSis") = gs_TxtEmpresaSistema.Trim
            'DT1.Rows(0).Item("CodigoQR") = CodigoQR.Trim
            'DT1.Rows(0).Item("Footer") = Footer.Trim
            '@0001 Fin

            BSO1.DataSource = DT1
            BSO2.DataSource = DT2

            '' Complementos
            ListaDocumentos = wr_DocumentoCtble.Listar(New e_MovimientoDocumento With {.TipoOperacion = "ASO", .Id = IdDocumentoCtble})
            bso_Documento.DataSource = ListaDocumentos
            udg_Documentos.DataBind()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Function ImageToBase64(ByVal mImage As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As New System.IO.MemoryStream()
            ' Convert Image to byte[]
            mImage.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

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
                .LocalReport.DisplayName = DT1.Rows(0).Item("DOI").ToString + "-" + DT1.Rows(0).Item("SerieNumero").ToString
                .LocalReport.Refresh()
            End With

            VISOR.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub frm_DocumentoCtble_Imprimir_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mt_Cerrar()
    End Sub

    Private Sub mt_Cerrar()
        Try
            '\\LADERA\ComprobanteElectronico\pdf\
            'D:\Sistema\xml\
            Dim Archivo As String = "D:\Sistema\xml\" & DocumentoCtble.DatosImpresion.TipoDocumento & "_" & DocumentoCtble.Serie & DocumentoCtble.Numero & ".pdf"
            Dim PDF As Byte()
            Dim filepath As String = Archivo
            If File.Exists(filepath) Then My.Computer.FileSystem.DeleteFile(filepath)
            PDF = VISOR.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim fs As New FileStream(Archivo, FileMode.Create)
            fs.Write(PDF, 0, PDF.Length)
            fs.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Obtener_RutaReporte(IdTipoDocumento As String) As String
        'Dim Raiz As String = "...\Debug\Grifo\Impresiones\"
        'C:\Users\CESS\Source\Repos\ERP-TCG\ERP-TCG\ISL.Win\Grifo\Impresiones\rpt_DocumentoCtble_A4.rdlc
        Dim Raiz As String = Path.Combine(Application.StartupPath, "Grifo") & "\Impresiones\"
        Select Case ModuloEmision
            Case "GRIFO"
                Select Case IdTipoDocumento
                    Case "1CH000000026" 'Factura
                        TituloExcel = TituloExcel & "FACTURA " & DocumentoCtble.Serie & DocumentoCtble.Numero
                        grb_DocumentosAsociados.Text = TituloExcel
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_FacturaVenta_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_FacturaVenta_Ticket.rdlc"
                        End Select
                    Case "1CH000000002" 'Boleta de Venta
                        TituloExcel = TituloExcel & "BOLETA DE VENTA " & DocumentoCtble.Serie & DocumentoCtble.Numero
                        grb_DocumentosAsociados.Text = TituloExcel
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_BoletaVenta_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_BoletaVenta_Ticket.rdlc"
                        End Select
                    Case "GCH000000001" 'Nota de Despacho
                        TituloExcel = TituloExcel & "NOTA DE DESPACHO " & DocumentoCtble.Serie & DocumentoCtble.Numero
                        grb_DocumentosAsociados.Text = TituloExcel
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_NotaDespacho_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_NotaDespacho_Ticket.rdlc"
                        End Select
                    Case Else
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_DocumentoCtble_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_DocumentoCtble_Ticket.rdlc"
                        End Select
                End Select
            Case "OV"
                'Select Case IdTipoDocumento '@0001
                'Case "GCH000000001" 'Nota de Despacho '@0001
                Select Case TipoPapel
                    Case "A4" : Return Raiz & "rpt_DocumentoCtble_A4_Comercial.rdlc"
                    Case "TICKET" : Return "Reportes\Comercial\Ventas\rpt_ND_Ticket.rdlc"
                    Case "NCTICKET" : Return "Reportes\Comercial\Ventas\rpt_NC_Ticket.rdlc"
                End Select
                'End Select '@0001
                'Case Else '@0001
            Case "TRANSPORTE"
                'Select Case IdTipoDocumento '@0001
                'Case "GCH000000001" 'Nota de Despacho '@0001
                Select Case TipoPapel
                    Case "A4" : Return Raiz & "rpt_DocumentoCtble_A4_Transporte1.rdlc"
                    Case "TICKET" : Return "Reportes\Comercial\Ventas\rpt_ND_Ticket.rdlc"
                    Case "NCTICKET" : Return "Reportes\Comercial\Ventas\rpt_NC_Ticket.rdlc"
                End Select
                'End Select '@0001
                'Case Else '@0001
                Return ""
        End Select

        Return ""
    End Function

    Private Sub mt_Exportar_Complementos()
        Try
            If udg_Documentos.Rows.Count > 0 Then
                Exportar_Excel(udg_Documentos,  tituloExcel)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class