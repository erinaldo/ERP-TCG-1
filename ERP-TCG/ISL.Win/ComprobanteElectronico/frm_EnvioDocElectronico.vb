Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.IO
Imports Ionic.Zip
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports ERP.ServicioExterno
Imports System.Xml

Public Class frm_EnvioDocElectronico
    Inherits Win.frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_EnvioDocElectronico = Nothing
    Private Shared Operacion As String

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EnvioDocElectronico()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private mb_Load As Boolean = False
    Private ol_DocElectronico As l_ComprobantePagoElectronico
    Private wr_SunatEnvio As sFacturacion.billServiceClient
    Private wr_Datos As sFacturacion.sendBillResponse
    Private wr_Envio As sFacturacion.sendBillRequest
    Private wr_DatosStatus As New sFacturacion.getStatusResponse
    Private wr_Resumen As l_ComprobantePagoElectronico_Resumen
    Private wr_Empresa As l_Empresa
    Private lst_DocElectronico, lst_DocBajas As List(Of e_ComprobantePagoElectronico)
    Private mo_Resumen As e_ComprobantePagoElectronico_Resumen
    Private lst_Resumen As List(Of e_ComprobantePagoElectronico_Resumen)
    Private xml_DocRpta As System.Xml.XmlDocument
    Private lst_EstadoSunat As List(Of e_Estado)
    Private wr_Categoria As l_Estado
    Private mo_Documento As e_MovimientoDocumento
    Private mo_Empresa As e_Empresa
    Private wr_Documento As l_MovimientoDocumento
    Private wr_DocImpresion As l_MovimientoDocumento_Impresion
    Private ms_Usuario As String = "20480099720CPESUNAT"
    Private ms_ClaveSol As String = "materiaGRIF01X"

    Dim fs_Rpta As FileStream
    Dim ls_ArchivoZip As String = ""
    Dim ls_ArchivoRpta As String = ""
    Dim ls_Hash As String = ""




#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case fic_DocumentoElectronico.SelectedTab.Index
                Case 0
                    lr_ConsultarDocs()
                Case 1
                    lr_ConsultarBoletas()
                Case 2
                    lr_ListarDocs()
                Case 3
                    lr_ListarTickets()
                Case 4
                    lr_ListarEstados()
            End Select
            Operacion = "Inicializa"
            gmt_ControlBoton(1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_DocumentoElectronico_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        gmt_ControlBoton(1)
    End Sub

    Private Sub frm_DocumentoElectronico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_DocumentoElectronico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gmt_ControlBoton()
    End Sub

    Private Sub frm_ComprobantesElectronicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mb_Load = True
            lr_ConfigurarGrillaDoc(New List(Of e_ComprobantePagoElectronico), udg_Documentos)
            lr_ConfigurarGrillaDoc(New List(Of e_ComprobantePagoElectronico), udg_Facturas)
            lr_ConfigurarGrillaDoc(New List(Of e_ComprobantePagoElectronico), udg_Baja)
            lr_ConfigurarGrillaDoc(New List(Of e_ComprobantePagoElectronico))
            mb_Load = False
            ol_DocElectronico = New l_ComprobantePagoElectronico
            wr_Categoria = New l_Estado
            wr_SunatEnvio = New sFacturacion.billServiceClient
            wr_Datos = New sFacturacion.sendBillResponse
            wr_Envio = New sFacturacion.sendBillRequest
            wr_Resumen = New l_ComprobantePagoElectronico_Resumen
            wr_DatosStatus = New sFacturacion.getStatusResponse
            wr_Documento = New l_MovimientoDocumento
            wr_Empresa = New l_Empresa
            wr_DocImpresion = New l_MovimientoDocumento_Impresion
            DateTimePicker3.Value = Date.Now.AddDays(-7)
            DateTimePicker4.Value = Date.Now.AddDays(-7)
            lr_CargarCombos()
            mt_ObtenerEmpresa()
            'lr_ConfigurarGrillaTickets(wr_Resumen.ListarDataSet(New e_ComprobantePagoElectronico_Resumen With {.IdEmpresaSis = String.Empty}))
            uce_TipoResumen.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsb_GenerarResumen.Name
                    lr_ConsolidarBoletas()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsb_EnviarFactura.Name
                    If lst_DocElectronico.Where(Function(i) i.Sel).Count = 1 Then
                        lr_EnviarDocumentos(lst_DocElectronico.Where(Function(i) i.Sel)(0))
                        lr_ConsultarDocs()
                    Else
                        Throw New Exception("Debe Seleccionar Un Registro para Enviar") '976881787
                    End If
                Case tsb_GenerarXML.Name
                    If lst_DocElectronico.Where(Function(i) i.Sel).Count = 1 Then
                        gmt_GeneraZip(gmt_CPE(New e_MovimientoDocumento With {.Id = lst_DocElectronico.Where(Function(i) i.Sel)(0).Id}))
                    End If
                Case tsb_CambiarEstado.Name
                    If lst_DocElectronico.Where(Function(i) i.Sel).Count = 1 Then
                        lr_CambiarEstadoDocumento(lst_DocElectronico.Where(Function(i) i.Sel)(0))
                        lr_ConsultarDocs()
                    Else
                        Throw New Exception("Debe Seleccionar Un Registro para Enviar") '976881787
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub lr_20(Id As String)
    '    Try
    '        Dim ls_Ruta As String
    '        ls_ArchivoZip = String.Empty
    '        ls_ArchivoRpta = String.Empty
    '        ls_Hash = String.Empty
    '        Dim oe As New e_ComprobantePagoElectronico
    '        oe.Id = Id
    '        oe = ol_DocElectronico.Obtener("UNO", oe)
    '        ls_Ruta = ol_DocElectronico.GenerarEDocNotaDebito20(oe, ls_Hash)
    '        'Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
    '        '    zip.AddFile(ls_Ruta.Trim, "")
    '        '    zip.Save(Replace(ls_Ruta, ".xml", ".zip"))
    '        'End Using
    '        'ls_ArchivoZip = Replace(ls_Ruta, ".xml", ".zip")
    '        'ls_ArchivoRpta = Replace(ls_ArchivoZip, Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, ""), "R-" & Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, ""))
    '        'ls_ArchivoRpta = Replace(ls_ArchivoRpta, gstrRutaDocumentosEle20, gstrRutaDocumentosCDR)
    '        'fs_Rpta = New FileStream(ls_ArchivoRpta, FileMode.Create)
    '        'wr_Envio.contentFile = My.Computer.FileSystem.ReadAllBytes(ls_ArchivoZip)
    '        'wr_Envio.fileName = Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, "")
    '        ''wr_SunatEnvio.Open()
    '        'wr_Datos.applicationResponse = wr_SunatEnvio.sendBill(wr_Envio.fileName, wr_Envio.contentFile, "")
    '        'fs_Rpta.Write(wr_Datos.applicationResponse, 0, wr_Datos.applicationResponse.Length)
    '        'fs_Rpta.Close()
    '        'gr_Extraer(ls_ArchivoRpta)
    '        'xml_DocRpta = New System.Xml.XmlDocument
    '        'xml_DocRpta.PreserveWhitespace = False
    '        'xml_DocRpta.Load(Replace(ls_ArchivoRpta, ".zip", ".xml"))
    '        'lr_LeerRespuestaSunat(xml_DocRpta, Id)

    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If Not fs_Rpta Is Nothing Then
    '            fs_Rpta.Close()
    '        End If
    '        'wr_SunatEnvio.Close()
    '    End Try
    'End Sub

    Private Sub udg_Documentos_CellChange(sender As Object, e As CellEventArgs) Handles udg_Documentos.CellChange
        udg_Documentos.UpdateData()
    End Sub

    Private Sub udg_Facturas_CellChange(sender As Object, e As CellEventArgs) Handles udg_Facturas.CellChange
        udg_Facturas.UpdateData()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        lr_ConfigurarGrillaDoc(New List(Of e_ComprobantePagoElectronico), udg_Documentos)
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        lr_ConfigurarGrillaDoc(New List(Of e_ComprobantePagoElectronico), udg_Baja)
    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked
        Try
            Select Case e.ClickedItem.Name

                Case tsb_EnviarComunicacion.Name
                    'If Not fb_ComprobarSeguridad("BAJA_DOC_ELECTRONICO", ObtenerFechaServidor) Then Throw New Exception("No Tiene Permiso para Generar Comunicaciones de Baja")
                    If MessageBox.Show("Desea Generar una Comunicacion de Baja del Documento Seleccionado?", "ERP-TCG", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        lr_ConsolidarBajas()
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ToolStrip4_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip4.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsb_ConsultarTicket.Name
                    lr_ConsultarTicket()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub udg_Baja_CellChange(sender As Object, e As CellEventArgs) Handles udg_Baja.CellChange
        udg_Baja.UpdateData()
    End Sub

    Private Sub udg_Resumen_CellChange(sender As Object, e As CellEventArgs) Handles udg_Resumen.CellChange
        udg_Resumen.UpdateData()
    End Sub

    Private Sub udg_Facturas_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles udg_Facturas.AfterCellUpdate
        Select Case e.Cell.Column.Key
            Case "Sel"
                With udg_Facturas.DisplayLayout.Bands(0).Layout.ActiveRow
                    If .Cells("Sel").Value Then
                        .Appearance.BackColor = Color.Yellow
                        .Appearance.ForeColor = Color.Red
                    Else
                        .Appearance.BackColor = Color.White
                        .Appearance.ForeColor = Color.Black
                    End If
                End With
        End Select
    End Sub

    Private Sub udg_Documentos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles udg_Documentos.AfterCellUpdate
        Select Case e.Cell.Column.Key
            Case "Sel"
                With udg_Documentos.DisplayLayout.Bands(0).Layout.ActiveRow
                    If .Cells("Sel").Value Then
                        .Appearance.BackColor = Color.Yellow
                        .Appearance.ForeColor = Color.Red
                    Else
                        .Appearance.BackColor = Color.White
                        .Appearance.ForeColor = Color.Black
                    End If
                End With
        End Select
    End Sub

    Private Sub udg_Baja_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles udg_Baja.AfterCellUpdate
        Select Case e.Cell.Column.Key
            Case "Sel"
                With udg_Baja.DisplayLayout.Bands(0).Layout.ActiveRow
                    If .Cells("Sel").Value Then
                        .Appearance.BackColor = Color.Yellow
                        .Appearance.ForeColor = Color.Red
                    Else
                        .Appearance.BackColor = Color.White
                        .Appearance.ForeColor = Color.Black
                    End If
                End With
        End Select
    End Sub

    Private Sub udg_Resumen_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles udg_Resumen.AfterCellUpdate
        Select Case e.Cell.Column.Key
            Case "SEL"
                With udg_Resumen.DisplayLayout.Bands(0).Layout.ActiveRow
                    If .Cells("SEL").Value Then
                        .Appearance.BackColor = Color.Yellow
                        .Appearance.ForeColor = Color.Red
                    Else
                        .Appearance.BackColor = Color.White
                        .Appearance.ForeColor = Color.Black
                    End If
                End With
        End Select
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Try
            lr_SeleccionarRegistrosGrilla(udg_Documentos)
            For Each fila As UltraGridRow In udg_Documentos.Rows
                Select Case fila.Cells("Sel").Value
                    Case True
                        fila.Appearance.BackColor = Color.Yellow
                        fila.Appearance.ForeColor = Color.Red
                    Case Else
                        fila.Appearance.BackColor = Color.White
                        fila.Appearance.ForeColor = Color.Black
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub UltraButton2_Click(sender As Object, e As EventArgs) Handles UltraButton2.Click
        Try
            lr_SeleccionarRegistrosGrilla(udg_Baja)
            For Each fila As UltraGridRow In udg_Baja.Rows
                Select Case fila.Cells("Sel").Value
                    Case True
                        fila.Appearance.BackColor = Color.Yellow
                        fila.Appearance.ForeColor = Color.Red
                    Case Else
                        fila.Appearance.BackColor = Color.White
                        fila.Appearance.ForeColor = Color.Black
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub udg_Resumen_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles udg_Resumen.DoubleClickRow
        Try
            If udg_Resumen.ActiveRow.Band.Index = 1 Then
                lr_MostrarDocumento(udg_Resumen.ActiveRow.Cells("ID").Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub udg_ListaDocs_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles udg_ListaDocs.DoubleClickRow
        Try
            If udg_ListaDocs.Selected.Rows.Count > 0 Then
                lr_MostrarDocumento(udg_ListaDocs.ActiveRow.Cells("Id").Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_ObtenerEmpresa()
        Try
            mo_Empresa = New e_Empresa
            mo_Empresa.TipoOperacion = "LST"
            mo_Empresa.Id = gs_IdEmpresaSistema
            mo_Empresa = wr_Empresa.Obtener(mo_Empresa)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_MostrarDocumento(IdDocumento As String)
        Try
            'mo_Documento = New e_Documento
            'Dim frm_docs_ven As frm_Plantilla
            'Dim ls_Operacion As String = "VISTA"
            'mo_Documento.Id = IdDocumento
            'mo_Documento.IndDocumentoInterno = True
            'mo_Documento = wr_Documento.Listar("GEN", mo_Documento, False)(0)
            'Select Case mo_Documento.IdTipoDocumento
            '    Case "TDO0000000000001"
            '        frm_docs_ven = New frm_DC_Factura_VentasInterna(ls_Operacion, mo_Documento)
            '    Case "TDO0000000000003"
            '        frm_docs_ven = New frm_DC_Boleta_VentaInterna(ls_Operacion, mo_Documento)
            '    Case "TDO0000000000007", "TDO0000000000019"
            '        frm_docs_ven = New frm_DC_NC_VentasInternas(ls_Operacion, mo_Documento, False)
            '    Case "TDO0000000000008", "TDO0000000000020"
            '        frm_docs_ven = New frm_DC_ND_VentaInternas(ls_Operacion, mo_Documento, False)
            '    Case Else
            '        frm_docs_ven = New frm_DocumentoCtble_Reg_Ventas(ls_Operacion, mo_Documento)
            'End Select
            'lr_MostarPanelReg(frm_docs_ven)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_SeleccionarRegistrosGrilla(udg_Grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In udg_Grilla.Rows.Where(Function(item) item.IsFilteredOut = False)
                If Fila.Cells("Sel").Value Then
                    Fila.Cells("Sel").Value = False
                Else
                    Fila.Cells("Sel").Value = True
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConfigurarGrillaDoc(lo As List(Of e_ComprobantePagoElectronico), Grilla As UltraGrid)
        Try
            With Grilla
                .DataSource = lo
                If mb_Load Then
                    .ResetDisplayLayout()
                    gmt_ConfiguraGrilla(Grilla, "Tahoma", True, UIElementBorderStyle.Default)
                    gmt_OcultarColumna(Grilla, False, "Sel", "TipoDocumento", "FechaEmision", "Documento", "Receptor", "SubTotal", "TotalIGV", "Total")
                    .DisplayLayout.Bands(0).Columns("Sel").Width = 50
                    .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 50
                    .DisplayLayout.Bands(0).Columns("Documento").Width = 120
                    .DisplayLayout.Bands(0).Columns("Receptor").Width = 350
                    .DisplayLayout.Bands(0).Columns("SubTotal").Width = 100
                    .DisplayLayout.Bands(0).Columns("TotalIGV").Width = 100
                    .DisplayLayout.Bands(0).Columns("Total").Width = 100
                    .DisplayLayout.Bands(0).Columns("Sel").CellClickAction = CellClickAction.Edit
                    .DisplayLayout.Bands(0).Columns("Sel").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    .DisplayLayout.Bands(0).Columns("Sel").Header.Caption = ""
                    .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "TD"
                    .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                    .DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                    .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
                    .DisplayLayout.Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
                    gmt_FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "SubTotal", "Total", "TotalIGV")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConfigurarGrillaDoc(lo As List(Of e_ComprobantePagoElectronico))
        Try
            With udg_ListaDocs
                .DataSource = lo
                If mb_Load Then
                    .ResetDisplayLayout()
                    gmt_ConfiguraGrilla(udg_ListaDocs, "Tahoma", True, UIElementBorderStyle.Default)
                    gmt_OcultarColumna(udg_ListaDocs, False, "TipoDocumento", "FechaEmision", "Documento", "Receptor", "SubTotal", "TotalIGV", "Total", "IdCentro")
                    .DisplayLayout.Bands(0).Columns("Sel").Width = 50
                    .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 150
                    .DisplayLayout.Bands(0).Columns("Documento").Width = 120
                    .DisplayLayout.Bands(0).Columns("Receptor").Width = 350
                    .DisplayLayout.Bands(0).Columns("SubTotal").Width = 100
                    .DisplayLayout.Bands(0).Columns("TotalIGV").Width = 100
                    .DisplayLayout.Bands(0).Columns("Total").Width = 100
                    .DisplayLayout.Bands(0).Columns("IdCentro").Width = 150
                    .DisplayLayout.Bands(0).Columns("Sel").CellClickAction = CellClickAction.Edit
                    .DisplayLayout.Bands(0).Columns("Sel").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                    .DisplayLayout.Bands(0).Columns("Sel").Header.Caption = ""
                    '.DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "TD"
                    .DisplayLayout.Bands(0).Columns("IdCentro").Header.Caption = "Estado SUNAT"
                    .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                    .DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    '.DisplayLayout.Override.cella = CellClickAction.RowSelect
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                    .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
                    .DisplayLayout.Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
                    gmt_FormatoColumna(udg_ListaDocs, "#,##0.00", ColumnStyle.Double, HAlign.Right, "SubTotal", "Total", "TotalIGV")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConfigurarGrillaTickets(ds As Data.DataSet)
        Try
            With udg_Resumen
                .ResetDisplayLayout()
                .DataSource = ds
                .DisplayLayout.Bands(0).Override.RowAppearance.BackColor = Color.LightGray

                gmt_ConfiguraGrilla(udg_Resumen, "Tahoma", False, UIElementBorderStyle.Default)
                gmt_OcultarColumna(udg_Resumen, True, "Id", "Ruta_XML", "TipoResumen")

                .DisplayLayout.Bands(0).Columns("Sel").Width = 50
                .DisplayLayout.Bands(0).Columns("Sel").Style = ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("Sel").Header.Caption = ""
                .DisplayLayout.Bands(0).Columns("Sel").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                .DisplayLayout.Bands(0).Columns("Sel").CellClickAction = CellClickAction.Edit

                .DisplayLayout.Bands(0).Columns("Res_TXT").Width = 120
                .DisplayLayout.Bands(0).Columns("Res_TXT").Header.Caption = "TipoResumen"

                .DisplayLayout.Bands(0).Columns("FechaResumen").Width = 90
                .DisplayLayout.Bands(0).Columns("FechaResumen").Header.Caption = "FechaResumen"
                .DisplayLayout.Bands(0).Columns("FechaResumen").CellActivation = Activation.NoEdit

                .DisplayLayout.Bands(0).Columns("FechaDocumentos").Width = 90
                .DisplayLayout.Bands(0).Columns("FechaDocumentos").Header.Caption = "FechaDocs"
                .DisplayLayout.Bands(0).Columns("FechaDocumentos").CellActivation = Activation.NoEdit

                .DisplayLayout.Bands(0).Columns("Ticket").Width = 120
                .DisplayLayout.Bands(0).Columns("Ticket").Header.Caption = "NroTicket"

                .DisplayLayout.Bands(0).Columns("Correlativo").Width = 80
                .DisplayLayout.Bands(0).Columns("Correlativo").Header.Caption = "Correlativo"

                .DisplayLayout.Bands(0).Columns("Estado").Width = 120
                .DisplayLayout.Bands(0).Columns("Estado").Header.Caption = "Estado"

                'If ds.Tables(1).Rows.Count > 0 Then
                '    gmt_OcultarColumna(udg_Resumen, True, "IdResumenElectronico", "Id")

                '    .DisplayLayout.Bands(1).Columns("TipoDocumento").Width = 120
                '    .DisplayLayout.Bands(1).Columns("TipoDocumento").Header.Caption = "TipoDocumento"

                '    .DisplayLayout.Bands(1).Columns("FechaEmision").Width = 90
                '    .DisplayLayout.Bands(1).Columns("FechaEmision").Header.Caption = "FechaEmi"
                '    .DisplayLayout.Bands(1).Columns("FechaEmision").CellActivation = Activation.NoEdit

                '    .DisplayLayout.Bands(1).Columns("Documento").Width = 120
                '    .DisplayLayout.Bands(1).Columns("Documento").Header.Caption = "Documento"

                '    .DisplayLayout.Bands(1).Columns("Cliente").Width = 280
                '    .DisplayLayout.Bands(1).Columns("Cliente").Header.Caption = "RazonSocial"

                '    .DisplayLayout.Bands(1).Columns("SubTotal").Width = 100
                '    .DisplayLayout.Bands(1).Columns("SubTotal").Header.Caption = "SubTotal"

                '    .DisplayLayout.Bands(1).Columns("Impuesto").Width = 100
                '    .DisplayLayout.Bands(1).Columns("Impuesto").Header.Caption = "IGV"

                '    .DisplayLayout.Bands(1).Columns("Total").Width = 100
                '    .DisplayLayout.Bands(1).Columns("Total").Header.Caption = "Total"

                '    gmt_FormatoColumna(udg_Resumen, "#,##0.00", ColumnStyle.Double, HAlign.Right, "SubTotal", "Impuesto", "Total")
                'End If
                .DisplayLayout.ViewStyle = ViewStyle.MultiBand
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                .DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConsultarBoletas()
        Try
            lst_DocElectronico = New List(Of e_ComprobantePagoElectronico)
            lst_DocElectronico.AddRange(ol_DocElectronico.Consultar("RES", New e_ComprobantePagoElectronico With {.IdEmpresaSis = gs_IdEmpresaSistema, .FechaEmision = DateTimePicker2.Value}))
            lr_ConfigurarGrillaDoc(lst_DocElectronico, udg_Documentos)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConsultarDocs()
        Try
            lst_DocElectronico = New List(Of e_ComprobantePagoElectronico)
            lst_DocElectronico.AddRange(ol_DocElectronico.Consultar("FAC", New e_ComprobantePagoElectronico With {.IdEmpresaSis = gs_IdEmpresaSistema, .TipoOperacion = "FAC"}))
            lr_ConfigurarGrillaDoc(lst_DocElectronico, udg_Facturas)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConsolidarBoletas()
        Try
            Dim ls_Archivo As String = ""
            ls_Hash = String.Empty
            mo_Resumen = New e_ComprobantePagoElectronico_Resumen
            mo_Resumen.PrefijoID = gs_PrefijoIdSucursal
            mo_Resumen.TipoResumen = 1
            mo_Resumen.FechaResumen = ObtenerFechaServidor.Date.ToString("yyyyMMdd")
            mo_Resumen.IdEmpresaSis = gs_IdEmpresaSistema
            mo_Resumen.TipoOperacion = "OBT"
            mo_Resumen = wr_Resumen.Obtener(mo_Resumen)
            If mo_Resumen.Id.Trim = String.Empty Then
                mo_Resumen.Correlativo = FormatoDocumento(1, 5)
            Else
                mo_Resumen.Id = String.Empty
                mo_Resumen.Correlativo = FormatoDocumento(CStr(CInt(mo_Resumen.Correlativo) + 1), 5)
            End If
            mo_Resumen.IdEmpresaSis = gs_IdEmpresaSistema
            mo_Resumen.FechaResumen = ObtenerFechaServidor.Date.ToString("yyyyMMdd")
            mo_Resumen.FechaDocumentos = DateTimePicker2.Value.Date.ToString("yyyyMMdd")
            mo_Resumen.TipoResumen = 1
            mo_Resumen.IdSucursalSistema = gs_IdSucursal
            mo_Resumen.UsuarioCrea = gUsuarioSGI.Id
            mo_Resumen.IdEstado = "1CIX049"
            ls_ArchivoZip = String.Empty
            'Dim fs_Rpta As FileStream
            If udg_Documentos.Rows.Count = 0 Then Throw New Exception("No Existen Datos")
            If lst_DocElectronico.Where(Function(i) i.Sel).Count = 0 Then Throw New Exception("Seleccione Boletas para Generar Resumen")
            ls_Archivo = ol_DocElectronico.GenerarResumenBoletas20(lst_DocElectronico.Where(Function(i) i.Sel).ToList, mo_Empresa, mo_Resumen, ls_Hash)
            ls_ArchivoZip = (Replace(ls_Archivo, ".xml", ".zip"))
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(ls_Archivo, "")
                zip.Save(ls_ArchivoZip)
            End Using
            'fs_Rpta = New FileStream(ls_ArchivoZip, FileMode.Create)
            wr_Envio.contentFile = My.Computer.FileSystem.ReadAllBytes(ls_ArchivoZip)
            wr_Envio.fileName = Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, "")
            mo_Resumen.Ruta_XML = ls_Archivo
            mo_Resumen.Hash_RSA = ls_Hash
            mo_Resumen.Ticket = wr_SunatEnvio.sendSummary(wr_Envio.fileName, wr_Envio.contentFile, "")
            'If wr_Resumen.Guardar(mo_Resumen, lst_DocElectronico.Where(Function(i) i.Sel).ToList) Then
            '    MessageBox.Show("Resumen Enviado Correctamente. Se Genero el Ticket: " & mo_Resumen.Ticket, "ERP-TCG", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    lr_ConsultarBoletas()
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConsolidarBajas()
        Try
            'Dim ls_Archivo As String = ""
            'If txt_MotivoBaja.Text = String.Empty Then Throw New Exception("Escriba el Motivo de Baja")

            'ls_Hash = String.Empty
            'mo_Resumen = New e_ComprobantePagoElectronico_Resumen
            'mo_Resumen.TipoResumen = 2
            'mo_Resumen.FechaResumen = ObtenerFechaServidor.Date.ToString("yyyyMMdd")
            'mo_Resumen.IdEmpresaSis = gs_IdEmpresaSistema
            'mo_Resumen = wr_Resumen.Obtener("OBT", mo_Resumen)
            'If mo_Resumen.Id.Trim = String.Empty Then
            '    mo_Resumen.Correlativo = FormatoDocumento(1, 5)
            'Else
            '    mo_Resumen.Id = String.Empty
            '    mo_Resumen.Correlativo = FormatoDocumento(CStr(CInt(mo_Resumen.Correlativo) + 1), 5)
            'End If
            'mo_Resumen.IdEmpresaSis = gs_IdEmpresaSistema
            'mo_Resumen.FechaResumen = ObtenerFechaServidor.Date.ToString("yyyyMMdd")
            'mo_Resumen.FechaDocumentos = DateTimePicker3.Value.Date.ToString("yyyyMMdd")
            'mo_Resumen.TipoResumen = 2
            'mo_Resumen.IdSucursal = gstrIdSucursal
            'mo_Resumen.Usuario = gUsuarioEOS.Id
            'ls_ArchivoZip = String.Empty
            'If udg_Baja.Rows.Count = 0 Then Throw New Exception("No Existen Datos")
            'If lst_DocBajas.Where(Function(i) i.Sel).Count = 0 Then Throw New Exception("Seleccione Boletas para Generar Resumen")
            'ls_Archivo = ol_DocElectronico.GenerarDocBaja(lst_DocBajas.Where(Function(i) i.Sel).ToList, mo_Empresa, mo_Resumen, ls_Hash, txt_MotivoBaja.Text)
            'ls_ArchivoZip = (Replace(ls_Archivo, ".xml", ".zip"))
            'Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
            '    zip.AddFile(ls_Archivo, "")
            '    zip.Save(ls_ArchivoZip)
            'End Using
            'wr_Envio.contentFile = My.Computer.FileSystem.ReadAllBytes(ls_ArchivoZip)
            'wr_Envio.fileName = Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, "")
            'mo_Resumen.Ticket = wr_SunatEnvio.sendSummary(wr_Envio.fileName, wr_Envio.contentFile, "")
            'mo_Resumen.Hash = ls_Hash
            'mo_Resumen.Ruta = ls_Archivo
            'If wr_Resumen.Guardar("I", mo_Resumen, lst_DocBajas.Where(Function(i) i.Sel).ToList) Then
            '    lr_ListarDocs()
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_CambiarEstadoDocumento(Documento As e_ComprobantePagoElectronico)
        Try
            If MessageBox.Show("Desea Cambiar a Estado Aceptado el Documento: " & Documento.Documento & "?", "ERP-TCG", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                ol_DocElectronico.CambiarEstado("3", New e_ComprobantePagoElectronico With {.Id = Documento.Id, .Usuario = gUsuarioSGI.Id})
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_EnviarDocumentos(Documento As e_ComprobantePagoElectronico)
        Try
            ls_ArchivoZip = Documento.RutaZip
            ls_ArchivoRpta = Replace(ls_ArchivoZip, Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, ""), "R-" & Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, ""))
            ls_ArchivoRpta = Replace(ls_ArchivoRpta, gstrRutaDocumentosEle20, gstrRutaDocumentosCDR)
            fs_Rpta = New FileStream(ls_ArchivoRpta, FileMode.Create)
            mt_AsignarCredenciales()
            wr_Envio.contentFile = My.Computer.FileSystem.ReadAllBytes(ls_ArchivoZip)
            wr_Envio.fileName = Replace(ls_ArchivoZip, gstrRutaDocumentosEle20, "")
            wr_SunatEnvio.Open()
            wr_Datos.applicationResponse = wr_SunatEnvio.sendBill(wr_Envio.fileName, wr_Envio.contentFile, "")
            fs_Rpta.Write(wr_Datos.applicationResponse, 0, wr_Datos.applicationResponse.Length)
            fs_Rpta.Close()
            lr_Extraer(ls_ArchivoRpta)
            xml_DocRpta = New System.Xml.XmlDocument
            xml_DocRpta.PreserveWhitespace = False
            xml_DocRpta.Load(Replace(ls_ArchivoRpta, ".zip", ".xml"))
            lr_LeerRespuestaSunat(xml_DocRpta, Documento.Id)
        Catch ex As Exception
            Throw ex
        Finally
            If Not fs_Rpta Is Nothing Then
                fs_Rpta.Close()
            End If
        End Try
    End Sub

    Public Sub lr_Extraer(Ruta As String)
        Dim ls_Archivo As String = Replace(Ruta, gstrRutaDocumentosCDR, "")
        Using zip1 As ZipFile = ZipFile.Read(Ruta)
            Dim e As ZipEntry
            For Each e In zip1
                If {Replace(ls_Archivo, ".zip", ".xml")}.Contains(e.FileName) Then
                    e.Extract(gstrRutaDocumentosCDR, ExtractExistingFileAction.OverwriteSilently)
                End If
            Next
        End Using
    End Sub

    Private Sub lr_ListarDocs()
        Try
            lst_DocBajas = New List(Of e_ComprobantePagoElectronico)
            lst_DocBajas.AddRange(ol_DocElectronico.Consultar("VOI", New e_ComprobantePagoElectronico With {.IdEmpresaSis = gs_IdEmpresaSistema, .FechaEmision = DateTimePicker3.Value}))
            lr_ConfigurarGrillaDoc(lst_DocBajas, udg_Baja)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_LeerRespuestaSunat(xml_doc As XmlDocument, IdDocumento As String)
        Try
            Dim XmlNode As XmlNodeList
            Dim mo_DocumentoImp = New e_MovimientoDocumento_Impresion
            Dim ls_Mensaje As String = ""
            mo_DocumentoImp.IdMovimientoDocumento = IdDocumento
            XmlNode = xml_doc.GetElementsByTagName("DigestValue")
            For i = 0 To XmlNode.Count - 1
                mo_DocumentoImp.HashSunat = XmlNode(i).ChildNodes.Item(0).InnerText.Trim()
            Next
            XmlNode = xml_doc.GetElementsByTagName("cbc:ResponseCode")
            'For i = 0 To XmlNode.Count - 1
            '    mo_DocumentoImp.IdEstadoSunat = lf_ObtenerEstadoSunat(XmlNode(i).ChildNodes.Item(0).InnerText.Trim())
            'Next
            XmlNode = xml_doc.GetElementsByTagName("cbc:Description")
            For i = 0 To XmlNode.Count - 1
                ls_Mensaje = XmlNode(i).ChildNodes.Item(0).InnerText.Trim()
            Next
            mo_DocumentoImp.UsuarioCreacion = gUsuarioSGI.Id
            mo_DocumentoImp.TipoOperacion = "Y"
            'mo_DocumentoImp.IndElectronico = False
            wr_DocImpresion.Guardar(mo_DocumentoImp)
            MessageBox.Show(ls_Mensaje, "ERP-TCG", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ListarTickets()
        Try
            Dim DS As Data.DataSet
            ' DS = wr_Resumen.ListarDataSet(New e_ComprobantePagoElectronico_Resumen With {.IdEmpresaSis = gs_IdEmpresaSistema, .TipoResumen = uce_TipoResumen.Value})
            '

            lr_ConfigurarGrillaTickets(DS)
            For x As Integer = 0 To udg_Resumen.Rows.Count - 1
                udg_Resumen.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ConsultarTicket()
        Try
            Dim ln_Cont As Integer = 0
            mo_Resumen = New e_ComprobantePagoElectronico_Resumen
            For Each fila As UltraGridRow In udg_Resumen.Rows
                If fila.Cells("Sel").Value Then
                    ln_Cont += 1
                    With mo_Resumen
                        .Id = fila.Cells("Id").Value
                        .Ticket = fila.Cells("Ticket").Value
                        .Ruta_XML = fila.Cells("Ruta_XML").Value
                        .TipoResumen = fila.Cells("TipoResumen").Value
                    End With
                End If
            Next
            If ln_Cont <> 1 Then Throw New Exception("Debe Seleccionar Un Registro")

            'ls_ArchivoRpta = gstrRutaDocumentosCDR & "R-" & Replace(Replace(mo_Resumen.Ruta, ".xml", ".zip"), gstrRutaDocumentosEle20, "")
            fs_Rpta = New FileStream(ls_ArchivoRpta, FileMode.Create)
            wr_DatosStatus.status = wr_SunatEnvio.getStatus(mo_Resumen.Ticket)
            If wr_DatosStatus.status.statusCode.Trim <> "0098" Then
                fs_Rpta.Write(wr_DatosStatus.status.content, 0, wr_DatosStatus.status.content.Length)
                fs_Rpta.Close()
                lr_Extraer(ls_ArchivoRpta)
                xml_DocRpta = New System.Xml.XmlDocument
                xml_DocRpta.PreserveWhitespace = False
                xml_DocRpta.Load(Replace(ls_ArchivoRpta, ".zip", ".xml"))
                lr_LeerTicketSunat(xml_DocRpta)
            Else
                Throw New Exception("Ticket se Encuentra en Proceso. Favor Intentar mas Tarde")
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If Not fs_Rpta Is Nothing Then fs_Rpta.Close()
        End Try
    End Sub

    Private Sub lr_LeerTicketSunat(xml_doc As XmlDocument)
        Try
            Dim XmlNode As XmlNodeList
            Dim ls_Mensaje As String = ""
            XmlNode = xml_doc.GetElementsByTagName("DigestValue")
            For i = 0 To XmlNode.Count - 1
                mo_Resumen.Rpta_Sunat = XmlNode(i).ChildNodes.Item(0).InnerText.Trim()
            Next
            XmlNode = xml_doc.GetElementsByTagName("cbc:ResponseCode")
            For i = 0 To XmlNode.Count - 1
                mo_Resumen.IdEstado = lf_ObtenerEstadoSunat(XmlNode(i).ChildNodes.Item(0).InnerText.Trim())
            Next
            XmlNode = xml_doc.GetElementsByTagName("cbc:Description")
            For i = 0 To XmlNode.Count - 1
                ls_Mensaje = XmlNode(i).ChildNodes.Item(0).InnerText.Trim()
            Next
            mo_Resumen.UsuarioCrea = gUsuarioSGI.Id
            mo_Resumen.TipoOperacion = "B"
            'If wr_Resumen.Guardar(mo_Resumen, New List(Of e_ComprobantePagoElectronico)) Then
            '    MessageBox.Show(ls_Mensaje, "ERP-TCG", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    lr_ListarTickets()
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_CargarCombos()
        Try
            Dim ListaCategoria As New List(Of e_Estado)
            ListaCategoria.Add(New e_Estado With {.Id = "", .Nombre = "<<NINGUNO>>"})
            ListaCategoria.AddRange(wr_Categoria.Listar(New e_Estado))
            ListaCategoria.Remove(New e_Estado With {.Id = "TDO0000000000004"})
            uce_TipoDocumento.DataSource = ListaCategoria
            uce_TipoDocumento.DisplayMember = "Categoria"
            uce_TipoDocumento.ValueMember = "Id"
            uce_TipoDocumento.SelectedIndex = 0

            ListaCategoria = New List(Of e_Estado)
            'ListaCategoria.Add(New e_Estado With {.Id = "", .Categoria = "<<TODOS>>"})
            'ListaCategoria.AddRange(wr_Categoria.Listar("GEN", New e_Estado With {.Grupo = "ESTADO_DOC_SUNAT", .CodCtble = "1"}))
            uce_Estado.DataSource = ListaCategoria
            uce_Estado.DisplayMember = "Categoria"
            uce_Estado.ValueMember = "Id"
            uce_Estado.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_ListarEstados()
        Try
            lst_DocElectronico = New List(Of e_ComprobantePagoElectronico)
            lst_DocElectronico.AddRange(ol_DocElectronico.Consultar("ENV", New e_ComprobantePagoElectronico With {.IdEmpresaSis = gs_IdEmpresaSistema, .Id = uce_TipoDocumento.Value,
                                        .FechaEmision = DateTimePicker4.Value, .FechaVencimiento = DateTimePicker5.Value, .IdEstadoSunat = uce_Estado.Value}))
            lr_ConfigurarGrillaDoc(lst_DocElectronico.OrderByDescending(Function(i) i.FechaEmision).ToList)
            For Each fila As UltraGridRow In udg_ListaDocs.Rows
                Select Case fila.Cells("IdCentro").Value
                    Case "ACEPTADO"
                        fila.CellAppearance.BackColor = colorAceptado.Color
                    Case "EN PROCESO"
                        fila.CellAppearance.BackColor = colorProceso.Color
                    Case "BAJA"
                        fila.CellAppearance.BackColor = colorBaja.Color()
                    Case Else
                        fila.CellAppearance.BackColor = colorError.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function lf_ObtenerEstadoSunat(ls_CodSunat As String) As String
        Dim oeEstado As New e_Estado
        Try
            oeEstado.TipoOperacion = ""
            oeEstado.Codigo = ls_CodSunat
            'oeEstado = wr_Categoria.Obtener(oeEstado)

            'lst_EstadoSunat = New List(Of e_Estado)
            'lst_EstadoSunat.AddRange(wr_Categoria.Listar(New e_Estado With {.TipoOperacion = "", .Codigo = ls_CodSunat}))
            'If lst_EstadoSunat.Count > 0 Then
            '    ls_IdCatEstadoSunat = lst_EstadoSunat(0).Id
            'End If
        Catch ex As Exception
            Throw ex
        End Try
        Return oeEstado.Id
    End Function

    Private Sub mt_Credenciales()
        System.Net.ServicePointManager.UseNagleAlgorithm = True
        System.Net.ServicePointManager.Expect100Continue = False
        System.Net.ServicePointManager.CheckCertificateRevocationList = True
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateServerCertificate
    End Sub

    Shared Function ValidateServerCertificate(sender As Object _
                                      , certificate As System.Security.Cryptography.X509Certificates.X509Certificate _
                                      , chain As System.Security.Cryptography.X509Certificates.X509Chain _
                                      , sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

    Private Sub mt_AsignarCredenciales()
        wr_SunatEnvio = New sFacturacion.billServiceClient
        mt_Credenciales()
        Dim Credenciales As New l_ClaveSunat(ms_Usuario, ms_ClaveSol)
        wr_SunatEnvio.Endpoint.EndpointBehaviors.Add(Credenciales)
    End Sub

#End Region

End Class