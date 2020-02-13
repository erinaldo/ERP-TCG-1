﻿Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
'Imports MessagingToolkit.QRCode.Codec
Imports System.IO

Public Class frm_DocumentoCtble_Imprimir

    Private IdDocumentoCtble As String, TipoPapel As String, ModuloEmision As String, CodigoQR As String = "", Footer As String = ""
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
            If DocumentoCtble.IdTipoDocumento <> "GCH000000001" Then
                CodigoQR = ""
                Footer = "Autorizado mediante Resolucion de Intendencia Nª 0720050000152/SUNAT" & vbCrLf & "Representacion impresa del comprobante de venta electronico. Consulte su documento en cpe.sunat.gob.pe"
            End If

            '@0001 Ini
            'Dim dc As DataColumn
            'dc = New DataColumn("EmpresaSis", Type.GetType("System.String"))
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
            Dim Archivo As String = "\\LADERA\ComprobanteElectronico\pdf\" & DocumentoCtble.DatosImpresion.TipoDocumento & "_" & DocumentoCtble.Serie & DocumentoCtble.Numero & ".pdf"
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