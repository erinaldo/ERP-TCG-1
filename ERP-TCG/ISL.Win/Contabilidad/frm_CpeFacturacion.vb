'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.IO
Imports System.Threading
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.Misc

Public Class frm_CpeFacturacion
    Inherits Win.frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_CpeFacturacion = Nothing
    Private Shared Operacion As String

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_CpeFacturacion()
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Definicion de Variables"
    Private enviados_portal As New List(Of e_MovimientoDocumento)
    'Dim HiloCpeInicio As New ThreadStart(AddressOf VerificaHiloCpe)
    'Dim HiloCpe As Thread
    'Dim MetodoCpe As New MethodInvoker(AddressOf Envio_PortalConsultas)
    'Private WCF_Cpe As New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe")
    'Private WCF_Cpe As New Cpe_Indu.WS_CpeSoapClient("CL")
    Private oeDocumento As e_MovimientoDocumento, olDocumento As New l_MovimientoDocumento
    Private lst_Documento As List(Of e_MovimientoDocumento)
    Private oeSerie As e_MovimientoDocumento, olSerie As New l_MovimientoDocumento
    Private lst_Serie As List(Of e_MovimientoDocumento)
    Private oeComprobanteBath As e_ComprobanteElectronicoBath, olComprobanteBath As New l_ComprobanteElectronicoBath
    Private oeComprobante As e_ComprobanteElectronico, olComprobante As l_ComprobanteElectronico
    Private oeComprobanteBath_Det As e_ComprobanteElectronicoBath_Detalle, olComprobanteBath_Det As New l_ComprobanteElectronicoBath_Detalle
    Private lst_BathDetalle As List(Of e_ComprobanteElectronicoBath_Detalle)
    Private lst_Bath As List(Of e_ComprobanteElectronicoBath)
    Private lst_Comprobante As List(Of e_ComprobanteElectronico)
    Private bandload As Boolean
    Private oe_TipoDocumento As e_TipoDocumento : Private ol_TipoDocumento As l_TipoDocumento : Private lst_TipoDocumento As New List(Of e_TipoDocumento)

#End Region

#Region "Botones Principales"

    Public Overrides Sub Imprimir()
        Try
            Dim frmImpresion As New frm_FacturaBoletaElectronico
            Dim TipoDoc As Boolean = False
            Dim grilla As UltraGrid = Nothing
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 0 : grilla = ugPendientes
                Case 1 : grilla = ugEnviar
                Case 2 : grilla = ugResumen
                Case 3 : grilla = ugEnviados
                Case 4 : grilla = ugEnviarBaja
                Case 5 : grilla = ugBaja
            End Select
            If grilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
            TipoDoc = IIf(grilla.ActiveRow.Cells("IdTipoDocumento").Value = "1CIX007" Or grilla.ActiveRow.Cells("IdTipoDocumento").Value = "1CIX008", True, False)
            frmImpresion.mt_CargarDatos(grilla.ActiveRow.Cells("Id").Value, TipoDoc, "")
            frmImpresion.StartPosition = FormStartPosition.CenterScreen
            frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            frmImpresion.MaximizeBox = True
            frmImpresion.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try

    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Call Me.Listar_CPE()
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 0
                    If ugPendientes.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugPendientes, "DocumentoPendientes_CPE")
                Case 1
                    If ugEnviar.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugEnviar, "DocumentoPorInformar_CPE")
                Case 2
                    If ugResumen.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugResumen, "ResumenDiairio_CPE")
                Case 3
                    If ugEnviados.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugEnviados, "DocumentoEnviados_CPE")
                Case 4
                    If ugEnviarBaja.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugEnviarBaja, "DocumentoComunicarBaja_CPE")
                Case 5
                    If ugBaja.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugBaja, "DocumentosBaja_CPE")
                Case 6
                    If ugTicket.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugTicket, "Tickets_CPE")
                Case 7
                    If ugEnviarPC.Rows.Count = 0 Then Throw New Exception("No existe registros para exportar al Excel")
                    ExportarGrillaAExcel(ugEnviarPC, "DocumentosEnviarPortal_CPE")
            End Select
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
        End Try
    End Sub
#End Region

#Region "Configuración de Grillas"

    Private Sub TablaDocumentos(ByVal grilla As UltraWinGrid.UltraGrid, ByVal mostrar As Boolean)
        Try
            With grilla
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!) '**7!
                ' "EstadoElectronico" (-estadoBaja)               
                .DisplayLayout.Bands(0).Columns("FechaEmision").SortIndicator = SortOrder.Descending
                .DisplayLayout.Bands(0).Columns("Select").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Id").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("NroDoc").Header.VisiblePosition = 8 '***DNI / RUC
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Igv").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("CodigoSunat").Header.VisiblePosition = 13  '---CODIGO SUNAT
                .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("EstadoElectronico").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("EstadoBaja").Header.VisiblePosition = 17

                .DisplayLayout.Bands(0).Columns("Select").Width = 55
                .DisplayLayout.Bands(0).Columns("Id").Width = 70
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 110
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 130
                .DisplayLayout.Bands(0).Columns("Serie").Width = 45
                .DisplayLayout.Bands(0).Columns("Numero").Width = 90
                .DisplayLayout.Bands(0).Columns("SubTotal").Width = 100
                .DisplayLayout.Bands(0).Columns("Igv").Width = 100
                .DisplayLayout.Bands(0).Columns("Total").Width = 100
                .DisplayLayout.Bands(0).Columns("CodigoSunat").Width = 70
                .DisplayLayout.Bands(0).Columns("IdEstado").Width = 70
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 80
                .DisplayLayout.Bands(0).Columns("EstadoElectronico").Width = 75 '**ESTADO
                .DisplayLayout.Bands(0).Columns("EstadoBaja").Width = 30
                .DisplayLayout.Bands(0).Columns("NroDoc").Width = 90
                .DisplayLayout.Bands(0).Columns("NroDoc").Header.Caption = "RUC/DNI"
            End With
            FormatoGrilla(grilla, mostrar)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Habilitar_Edicion_Check(_ban As Boolean, grilla As UltraGrid)
        With grilla
            If _ban Then
                .DisplayLayout.Bands(0).Columns("Select").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                .DisplayLayout.Bands(0).Columns("Select").CellActivation = Activation.NoEdit
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            Else
                .DisplayLayout.Bands(0).Columns("Select").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Select").CellActivation = Activation.AllowEdit
            End If
        End With
    End Sub

    Private Sub FormatoGrilla(grilla As UltraGrid, _ban As Boolean)
        'If utcFichaDocumentos.SelectedTab.Index = 0 Or utcFichaDocumentos.SelectedTab.Index = 1 Or utcFichaDocumentos.SelectedTab.Index = 3 Then
        '    OcultarColumna(grilla, True, "Select", "Id", "IdTipoDocumento", "CodigoSunat", "IdEstado", "EstadoBaja", "EstadoElectronico", "CodigoSunat")
        'Else

        OcultarColumna(grilla, True, "Select", "Id", "IdTipoDocumento", "CodigoSunat", "IdEstadoDocumento", "EstadoBaja", "CodigoSunat")
        'End If

        FormatoColumna(grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Igv", "SubTotal", "Total")

        With grilla
            grilla.DisplayLayout.Bands(0).Columns("Select").Header.Caption = "Enviar"

            If _ban Then
                If cmb_TipoDoc.Enabled = True Then
                    If utcFichaDocumentos.SelectedTab.Index <> 7 Then
                        If cmb_TipoDoc.SelectedIndex = 0 Then
                            .DisplayLayout.Bands(0).Columns("Select").Hidden = True
                        Else
                            .DisplayLayout.Bands(0).Columns("Select").Hidden = False
                        End If
                    Else
                        .DisplayLayout.Bands(0).Columns("Select").Hidden = False
                    End If
                Else
                    .DisplayLayout.Bands(0).Columns("Select").Hidden = False
                End If
            Else
                .DisplayLayout.Bands(0).Columns("Select").Hidden = True
            End If
            .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fecha Emisión"
            .DisplayLayout.Bands(0).Columns("Numero").Header.Caption = "Número"
            .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Documento"
            .DisplayLayout.Bands(0).Columns("Igv").Header.Caption = "IGV"
            .DisplayLayout.Bands(0).Columns("CodigoSunat").Header.Caption = "Codigo Sunat"
            .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Estado"
            .DisplayLayout.Bands(0).Columns("Select").Header.Caption = "Enviar"
            .DisplayLayout.Bands(0).Columns("EstadoElectronico").Header.Caption = "Electrónico"
            .DisplayLayout.Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
            .DisplayLayout.Override.SelectTypeRow = SelectType.SingleAutoDrag
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.SeparateElement
            .DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.Yellow
            .DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Red
            .DisplayLayout.Override.SelectedRowAppearance.BorderColor = Color.Yellow
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1
            .DisplayLayout.MaxColScrollRegions = 1
            .DisplayLayout.MaxRowScrollRegions = 1
            .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
        End With

        'Tamaños de Celdas Automáticos
        If grilla.Rows.Count > 0 Then grilla.DisplayLayout.PerformAutoResizeColumns(True, PerformAutoSizeType.AllRowsInBand)

        'Apariencia de Griilas: Color de filas y columnas
        apariencia_Estados_Grilla(grilla)
    End Sub

    Private Sub apariencia_Estados_Grilla(ByVal grilla As UltraWinGrid.UltraGrid)
        Try
            If grilla.Name = "ugTicket" Then
                For Each fila In grilla.Rows
                    Select Case Trim(fila.Cells("Estado").Value)
                        Case "A", "ACEPTADA"
                            fila.CellAppearance.BackColor = ucpAceptado.Color
                        Case "R", "RECHAZADA"
                            fila.CellAppearance.BackColor = ucpRechazado.Color
                        Case "E", "EN PROCESO"
                            fila.CellAppearance.BackColor = ucpProceso.Color
                    End Select
                    For Each child In fila.ChildBands(0).Rows
                        child.Cells("SubTotal").Appearance.BackColor = Color.SkyBlue
                        child.Cells("Igv").Appearance.BackColor = Color.Wheat
                        child.Cells("Total").Appearance.BackColor = Color.Pink
                    Next
                Next
            Else
                For Each fila In grilla.Rows
                    Select Case fila.Cells("EstadoElectronico").Value
                        Case "A", "ACEPTADA"
                            fila.CellAppearance.BackColor = ucpAceptado.Color
                        Case "R", "RECHAZADA"
                            fila.CellAppearance.BackColor = ucpRechazado.Color
                        Case "E", "EN PROCESO"
                            fila.CellAppearance.BackColor = ucpProceso.Color
                    End Select
                    fila.Cells("SubTotal").Appearance.BackColor = Color.SkyBlue
                    fila.Cells("Igv").Appearance.BackColor = Color.Wheat
                    fila.Cells("Total").Appearance.BackColor = Color.Pink
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDocumentos(grilla As UltraGrid, dt As DataTable, _ban As Boolean, header As String)
        Try
            Dim opc_b As Boolean = 1
            grilla.DataSource = dt
            FormatoGrilla(grilla, _ban)
            grilla.Text = header & " (" & dt.Rows.Count.ToString & ")"

            If utcFichaDocumentos.SelectedTab.Index = 1 Then
                If cmb_TipoDoc.SelectedIndex = 0 Then
                    Habilitar_Edicion_Check(True, grilla)
                Else
                    opc_b = IIf(grilla.Rows.Count > 0, 1, 0)
                    MostrarItems_Menu(opc_b, opc_b, IIf(utcFichaDocumentos.SelectedTab.Index = 4, 0, 1), 1, opc_b, opc_b, opc_b, opc_b, opc_b, 0, 1, 1)
                    Habilitar_Edicion_Check(False, grilla)
                End If
            ElseIf utcFichaDocumentos.SelectedTab.Index = 7 Or utcFichaDocumentos.SelectedTab.Index = 0 Then
                opc_b = IIf(grilla.Rows.Count > 0, 1, 0)
                MostrarItems_Menu(opc_b, 0, 1, 1, 0, 0, 0, 0, opc_b, 0, 0, 1)
                Habilitar_Edicion_Check(False, grilla)
            ElseIf utcFichaDocumentos.SelectedTab.Index = 2 Or utcFichaDocumentos.SelectedTab.Index = 4 Then
                opc_b = IIf(grilla.Rows.Count > 0, 1, 0)
                MostrarItems_Menu(opc_b, 0, 0, 0, opc_b, opc_b, opc_b, opc_b, opc_b, 0, 1, 1)
                Habilitar_Edicion_Check(False, grilla)
            ElseIf utcFichaDocumentos.SelectedTab.Index = 3 Or utcFichaDocumentos.SelectedTab.Index = 5 Then
                opc_b = IIf(grilla.Rows.Count > 0, 1, 0)
                MostrarItems_Menu(0, 0, 1, 1, 0, opc_b, opc_b, 0, opc_b, IIf(utcFichaDocumentos.SelectedTab.Index = 3, 1, 0), 0, 1)
                Habilitar_Edicion_Check(False, grilla)
            Else
                opc_b = IIf(grilla.Rows.Count > 0, 1, 0)
                MostrarItems_Menu(0, opc_b, 1, 0, 0, 0, 0, 0, opc_b, opc_b, 0, 1)
                Habilitar_Edicion_Check(False, grilla)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTicket(ByVal loTicket As DataSet)
        Try
            Dim relacionBath As DataRelation
            Dim Id As DataColumn = loTicket.Tables(0).Columns("Id")
            Dim IdBath As DataColumn = loTicket.Tables(1).Columns("IdBath")
            relacionBath = New DataRelation("FK_Relacion", Id, IdBath, False)
            loTicket.Relations.Add(relacionBath)
            loTicket.AcceptChanges()
            ugTicket.DataSource = loTicket
            With ugTicket
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)

                OcultarColumna(ugTicket, True, "Id", "TipoReferencia", "UsuarioCrea", "FechaCrea", "UsuarioModifica", "FechaModifica")

                .DisplayLayout.Bands(0).Columns("FechaEnvio").SortIndicator = SortOrder.Descending
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdBath").Hidden = True
                .DisplayLayout.Bands(1).Columns("estado").Hidden = True
                .DisplayLayout.Bands(1).Columns("Id").SortIndicator = SortOrder.Descending
                'CABECERA
                .DisplayLayout.Bands(0).Columns("Id").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("TipoReferencia").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("xmlbase64").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("nombrexml").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("cdrxml").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Ticket").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Tipo").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("FechaCrea").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("FechaModifica").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 15

                'CABECERADETALLE
                .DisplayLayout.Bands(1).Columns("Id").Header.VisiblePosition = 1
                .DisplayLayout.Bands(1).Columns("IdBath").Header.VisiblePosition = 2
                .DisplayLayout.Bands(1).Columns("Nro_comp").Header.VisiblePosition = 3
                .DisplayLayout.Bands(1).Columns("TipoDocumento").Header.VisiblePosition = 5
                .DisplayLayout.Bands(1).Columns("FechaEmision").Header.VisiblePosition = 4
                .DisplayLayout.Bands(1).Columns("SubTotal").Header.VisiblePosition = 6
                .DisplayLayout.Bands(1).Columns("Igv").Header.VisiblePosition = 7
                .DisplayLayout.Bands(1).Columns("Total").Header.VisiblePosition = 8
                .DisplayLayout.Bands(1).Columns("Estado").Header.VisiblePosition = 9
                .DisplayLayout.Bands(1).Columns("IndBaja").Header.VisiblePosition = 10

                .DisplayLayout.Bands(1).Columns("SubTotal").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("Igv").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("FechaEnvio").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("FechaEmision").CellAppearance.TextHAlign = HAlign.Center

                .DisplayLayout.Bands(1).Columns("SubTotal").Style = ColumnStyle.Double
                .DisplayLayout.Bands(1).Columns("Igv").Style = ColumnStyle.Double
                .DisplayLayout.Bands(1).Columns("Total").Style = ColumnStyle.Double
                'COLUMNAS
                .DisplayLayout.Bands(0).Columns("Id").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoReferencia").Width = 30
                .DisplayLayout.Bands(0).Columns("FechaEnvio").Width = 80
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 100
                .DisplayLayout.Bands(0).Columns("xmlbase64").Width = 100
                .DisplayLayout.Bands(0).Columns("nombrexml").Width = 175
                .DisplayLayout.Bands(0).Columns("cdrxml").Width = 100
                .DisplayLayout.Bands(0).Columns("Ticket").Width = 100
                .DisplayLayout.Bands(0).Columns("Tipo").Width = 160
                .DisplayLayout.Bands(0).Columns("Estado").Width = 90
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaCrea").Width = 70
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaModifica").Width = 70

                .DisplayLayout.Bands(0).Columns("cdrxml").Header.Caption = "CDR Xml"
                .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.Caption = "Fec. Envío"
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emisión"
                .DisplayLayout.Bands(0).Columns("Tipo").Header.Caption = "Tipo Documento"
                .DisplayLayout.Bands(0).Columns("nombrexml").Header.Caption = "Nombre XML"
                .DisplayLayout.Bands(0).Columns("xmlbase64").Header.Caption = "Xml B64"
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.Caption = "Doc."

                .DisplayLayout.Bands(1).Columns("FechaEmision").Header.Caption = "Fec. Emisión"
                .DisplayLayout.Bands(1).Columns("Nro_comp").Header.Caption = "Serie - Correlativo"
                .DisplayLayout.Bands(1).Columns("TipoDocumento").Header.Caption = "Tipo Documento"


                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                'If .Rows.Count > 0 Then .DisplayLayout.PerformAutoResizeColumns(True, PerformAutoSizeType.AllRowsInBand)
                .DisplayLayout.Override.SelectTypeRow = SelectType.SingleAutoDrag
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.SeparateElement
                .DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.Yellow
                .DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Red
                .DisplayLayout.Override.SelectedRowAppearance.BorderColor = Color.Yellow
                .DisplayLayout.Bands(0).Columns("cdrxml").Width = 120
                .DisplayLayout.Bands(1).Columns("FechaEmision").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("FechaEnvio").CellActivation = Activation.NoEdit
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            End With
        Catch ex As Exception
            Throw ex
        Finally
            ugTicket.DataBind()
        End Try
    End Sub

#End Region

#Region "Métodos CPE"

    Private Function Validar_Correlativo() As String
        Dim serie As String = ""
        Dim correlativo As Integer = 0
        Dim dt_cpe As String = ""
        For Each comprob In ugEnviar.Rows.Where(Function(x) x.Cells("Select").Value = True).ToList
            If serie <> CType(comprob.Cells("Serie").Value, String) Then
                serie = CType(comprob.Cells("Serie").Value, String)
                correlativo = CType(comprob.Cells("Numero").Value, Integer)
            Else
                correlativo += 1
                If correlativo <> CType(comprob.Cells("Numero").Value, Integer) Then
                    For i = 0 To (CType(comprob.Cells("Numero").Value, Integer) - correlativo - 1)
                        correlativo += i
                        dt_cpe &= serie & "-" & CType(correlativo, String).ToString().Trim.PadLeft(8, "0") & ","
                    Next
                    correlativo = CType(comprob.Cells("Numero").Value, Integer)
                End If
            End If
        Next
        If dt_cpe <> "" Then dt_cpe = Mid(dt_cpe, 1, dt_cpe.Length - 1)
        Return dt_cpe.ToString().Trim()
    End Function

    Private Sub Listar_CPE()
        Try
            chk_Validacion.Checked = True
            espFacturacion.Visible = True
            espFacturacion.Refresh()
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim dt As New DataTable
            Dim dv As DataView
            Dim ds As DataSet

            If dtp_FechaHasta.Visible Then ValidarFechaInicioFin(dtp_FechaDesde, dtp_FechaHasta)
            If utcFichaDocumentos.SelectedTab.Index = 6 Then
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.TipoOperacion = "DT"
                oeDocumento._Operador = 9
                oeDocumento.FechaInicio = dtp_FechaDesde.Value
                oeDocumento.FechaFinal = dtp_FechaHasta.Value
                ds = olDocumento.ListaFacturacionElectronica(oeDocumento)
                CargarTicket(ds)
                ugTicket.Text = "Listado de Tickets (" & dt.Rows.Count.ToString & ")"
                apariencia_Estados_Grilla(ugTicket)
            Else
                Dim grilla As UltraGrid = ugPendientes
                Dim header As String = ""
                Dim _ban As Boolean = False
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.TipoOperacion = "LS"
                oeDocumento.FechaInicio = dtp_FechaDesde.Value
                oeDocumento.FechaFinal = dtp_FechaHasta.Value
                oeDocumento.Serie = cmbSerie.Value
                Select Case utcFichaDocumentos.SelectedTab.Index
                    Case 0
                        oeDocumento._Operador = 1
                        grilla = ugPendientes
                        header = "Listado de Documentos Pendientes"
                        _ban = False
                    Case 1
                        oeDocumento._Operador = 2
                        grilla = ugEnviar
                        header = "Listado de Documentos por Informar"
                        _ban = True
                    Case 2
                        oeDocumento.FechaFinal = dtp_FechaDesde.Value.Date
                        oeDocumento._Operador = 3
                        grilla = ugResumen
                        header = "Listado de Resumen Diario"
                        _ban = True
                    Case 3
                        oeDocumento._Operador = 4
                        grilla = ugEnviados
                        header = "Listado de Documentos Informados"
                        _ban = False
                    Case 4
                        oeDocumento.FechaFinal = dtp_FechaDesde.Value.Date
                        'If cmb_TipoDoc.SelectedIndex <> 0 Then
                        '    oeDocumento.FechaFinal = dtp_FechaDesde.Value.Date
                        'Else
                        '    oeDocumento.FechaFinal = dtp_FechaHasta.Value
                        'End If
                        oeDocumento._Operador = 5
                        grilla = ugEnviarBaja
                        header = "Listado de Comunicación de Baja"
                        _ban = True
                    Case 5
                        oeDocumento._Operador = 6
                        grilla = ugBaja
                        header = "Listado de Documentos Anulados "
                        _ban = False
                    Case 7
                        oeDocumento._Operador = 7
                        Tsb_Env_Filtro.Enabled = True
                        grilla = ugEnviarPC
                        header = "Listado de Documentos por Enviar a Portal de Consultas"
                        _ban = True
                End Select
                oeDocumento.IdTipoDocumento = cmb_TipoDoc.Value
                oeDocumento.Abrev_Empresa = Abrev_Empresa
                dt = olDocumento.ListaFacturacionElectronica(oeDocumento).Tables(0)
                dv = dt.DefaultView
                dt = dv.ToTable
                CargarDocumentos(grilla, dt, _ban, header)
            End If

            espFacturacion.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            espFacturacion.Visible = False
        End Try
    End Sub

    Private Function Envio_PortalConsultas(Optional _banEn As Boolean = True) As String
        Dim _ban As Boolean = False
        Dim contEnvios As Integer = 0
        Dim contError As Integer = 0
        Dim contNoEnvios As Integer = 0
        Dim ids As String = ""
        Dim sbMensajeError As New StringBuilder
        Dim sbMensaje As New StringBuilder
        Dim olDocumento As New l_MovimientoDocumento
        Dim oeDocumento As e_MovimientoDocumento
        Dim dsRecibido As DataSet


        Try
            If _banEn Then espFacturacion.Visible = True
            For Each drFila In enviados_portal
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.Id = drFila.Id
                Try
                    olDocumento = New l_MovimientoDocumento
                    oeDocumento.TipoOperacion = "EPC"
                    dsRecibido = olDocumento.ListaFacturacionElectronica(oeDocumento)
                    'Dim msj As String = WCF_Cpe.EnviarCPE_PortalConsultas(dsRecibido)
                    Dim msj As String = ""
                    If msj = 1 Then _ban = True
                    _ban = IIf(msj = 1, True, False)
                    If _ban Then
                        contEnvios += 1
                        oeDocumento.TipoOperacion = "EPC"
                        oeDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                        oeDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olDocumento.Guardar(oeDocumento)
                    Else
                        contNoEnvios += 1
                        ids &= "'" & drFila.Serie & "-" & drFila.Numero & "'."
                    End If
                Catch ex As Exception
                    sbMensajeError.AppendLine("Documento " & drFila.Serie & "-" & drFila.Numero & ": " & ex.Message)
                    contError += 1
                End Try
            Next

            If contEnvios > 0 Then
                sbMensaje.AppendLine("(" + contEnvios.ToString().Trim & ") comprobantes fueron enviados al Portal de Consultas.")
            End If
            If contNoEnvios > 0 Then
                sbMensaje.AppendLine("(" + contNoEnvios.ToString().Trim & ") comprobantes no se pudieron Enviar al Portal de Consultas: " & ids)
            End If
            If contError > 0 Then
                sbMensaje.AppendLine("(" + contError.ToString().Trim & ") comprobantes no se enviaron por contener error: " & ids)
            End If
            sbMensaje.AppendLine(sbMensajeError.ToString)

            Return sbMensaje.ToString
        Catch ex As Exception
            Throw ex
        Finally
            If _banEn Then espFacturacion.Visible = False
            'BarraProgreso1.Visible = False
        End Try
    End Function

    'Public Sub EnviarPortal_Hilo()
    '    Try
    '        HiloCpe = New Thread(HiloCpeInicio)
    '        HiloCpe.IsBackground = True
    '        HiloCpe.Name = "HiloCpe"
    '        HiloCpe.Start()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Public Sub VerificaHiloCpe()
    '    Try
    '        With True
    '            BeginInvoke(MetodoCpe)
    '            Thread.Sleep(0)
    '        End With
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub PorEnviar_Portal()
        Try
            Dim msj As String = ""
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            espFacturacion.Visible = True
            Dim oeDocumento As e_MovimientoDocumento
            enviados_portal = New List(Of e_MovimientoDocumento)
            If ugEnviarPC.Rows.Where(Function(g) g.Cells("Select").Value = True).ToList.Count = 0 Then mensajeEmergente.Confirmacion("Debe seleccionar al menos un documento.")
            For Each drFila In ugEnviarPC.Rows.Where(Function(g) g.Cells("Select").Value = True).ToList
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.Id = drFila.Cells("Id").Value
                oeDocumento.Serie = drFila.Cells("Serie").Value
                oeDocumento.Numero = drFila.Cells("Numero").Value
                enviados_portal.Add(oeDocumento)
            Next
            msj = Envio_PortalConsultas()
            mensajeEmergente.Confirmacion(msj)
            Call Me.Listar_CPE()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            espFacturacion.Visible = False
        End Try
    End Sub

    Private Sub Envio_CPE(tipo_documento As String, b_Envio As Boolean, Optional b_baja As Boolean = False)
        Try
            If bwCpe.IsBusy Then Throw New Exception("EL proceso envío de comprobantes al portal de consultas se encuentra activo. Vuelva e enviar una vez finalizado el proceso.")
            espFacturacion.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim dsComprobante As DataSet
            Dim grilla As UltraGrid
            Dim dtResumen As New DataTable
            Dim sbMensaje As New StringBuilder
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0
            Dim sbMensajeError As New StringBuilder
            Dim dt_cpe As New DataTable
            Dim ids As String = ""
            enviados_portal = New List(Of e_MovimientoDocumento)
            Dim validacion As String = ""
            'WCF_Cpe = New Cpe_Indu.WS_CpeSoapClient("CL")
            'WCF_Cpe = New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe")
            'WCF_Cpe.Inicializar("CL")
            Select Case tipo_documento
                Case "01", "07", "08", "03", "20"
                    If chk_Validacion.Checked And b_Envio = True Then
                        validacion = Validar_Correlativo()
                        If validacion <> "" Then Throw New Exception("Faltan los siguientes comprobantes: " & validacion)
                    End If
                    If utcFichaDocumentos.SelectedTab.Index = 1 Then grilla = ugEnviar Else grilla = ugResumen
                    For Each drFila In grilla.Rows.Where(Function(x) x.Cells("Select").Value = True)
                        oeDocumento = New e_MovimientoDocumento
                        olDocumento = New l_MovimientoDocumento
                        oeDocumento.TipoOperacion = "DT"
                        oeDocumento.Id = drFila.Cells("Id").Value
                        oeDocumento.Abrev_Empresa = Abrev_Empresa
                        If tipo_documento = "03" Then tipo_documento = drFila.Cells("CodigoSunat").Value.ToString().Trim()
                        Select Case tipo_documento
                            Case "01", "03"
                                oeDocumento._Operador = 1
                            Case "07"
                                oeDocumento._Operador = 7
                            Case "08"
                                oeDocumento._Operador = 8
                            Case "20"
                                oeDocumento._Operador = 10
                                RutaArchivos = Replace(RutaArchivos, "Facturacion", "Retencion")
                        End Select

                        dsComprobante = olDocumento.ListaFacturacionElectronica(oeDocumento)
                        If dsComprobante.Tables.Count > 1 Then
                            If dsComprobante.Tables(0).Rows(0).Item("Estado").ToString.Trim = "C" Then
                                Try
                                    If b_Envio Then
                                        'dt_cpe = Deserializar_XmlStr(WCF_Cpe.EnviarXML_CPE("", "", "", "", "", "", olDocumento.ListaFacturacionElectronica(oeDocumento), tipo_documento, RutaArchivos, Abrev_Empresa, b_baja, True))
                                        dt_cpe = Deserializar_XmlStr("")
                                        Registro_ComprobanteElectronico_Bath(dt_cpe, "A", tipo_documento, Nothing)
                                        Dim msjerror As String = dt_cpe.Rows(0).Item("msjerror").ToString().Trim()
                                        If msjerror = "" Then
                                            contAceptados += 1
                                            ids &= "'" & drFila.Cells(0).Text & "',"
                                            oeDocumento.Serie = drFila.Cells("Serie").Value
                                            oeDocumento.Numero = drFila.Cells("Numero").Value
                                            enviados_portal.Add(oeDocumento)
                                        Else
                                            sbMensajeError.AppendLine("Documento " & dsComprobante.Tables(0).Rows(0).Item("nro_comprob") & ": " & msjerror)
                                            contErrores = contErrores + 1
                                        End If
                                    Else
                                        'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GenerarXML_CPE(dsComprobante, Date.Now, tipo_documento, RutaArchivos, Abrev_Empresa, Nothing, Nothing))
                                        dt_cpe = Deserializar_XmlStr("")
                                        Registro_ComprobanteElectronico_Bath(dt_cpe, "", tipo_documento, Nothing)
                                        contAceptados += 1
                                        ids &= "'" & drFila.Cells(0).Text & "',"
                                    End If
                                Catch ex As Exception
                                    sbMensajeError.AppendLine("Documento " & dsComprobante.Tables(0).Rows(0).Item("nro_comprob") & ": " & ex.Message)
                                    If dt_cpe.Rows.Count > 0 Then
                                        contRechazos += 1
                                    Else
                                        contErrores = contErrores + 1
                                    End If
                                End Try
                            End If
                        Else
                            contErrores = contErrores + 1
                        End If

                    Next
                Case "RC", "RA", "RR"
                    If b_baja Then grilla = ugEnviarBaja Else grilla = ugResumen
                    If tipo_documento = "RC" And b_baja = False Then
                        If chk_Validacion.Checked Then
                            validacion = Validar_Correlativo()
                            If validacion <> "" Then Throw New Exception("Faltan los siguientes comprobantes: " & validacion)
                        End If
                    End If
                    Dim C As Boolean = True
                    Dim dsResumen As DataSet
                    Dim item As Integer = 0
                    oeDocumento = New e_MovimientoDocumento
                    olDocumento = New l_MovimientoDocumento
                    oeDocumento.TipoOperacion = "DT"
                    Select Case tipo_documento
                        Case "RC"
                            oeDocumento._Operador = 2
                        Case "RA"
                            oeDocumento._Operador = 4
                        Case "RR"
                            oeDocumento._Operador = 11
                    End Select
                    oeDocumento.FechaEmision = dtp_FechaDesde.Value
                    oeDocumento.Abrev_Empresa = Abrev_Empresa
                    Try
                        dsComprobante = olDocumento.ListaFacturacionElectronica(oeDocumento)
                        For Each fila In grilla.Rows.Where(Function(x) x.Cells("Select").Value = True)
                            item += 1
                            oeDocumento = New e_MovimientoDocumento
                            oeDocumento.Id = fila.Cells("Id").Value
                            oeDocumento.TipoOperacion = "DT"
                            oeDocumento._Operador = IIf(tipo_documento = "RC", 3, IIf(tipo_documento = "RA", 5, 12))
                            oeDocumento.Item = item
                            oeDocumento.IndAnulado = IIf(tipo_documento = "RC", IIf(fila.Cells("Nombre").Value = "ANULADO", IIf(fila.Cells("EstadoElectronico").Value = "ACEPTADA" Or fila.Cells("EstadoElectronico").Value = "A", True, False), False), b_baja)
                            oeDocumento.Abrev_Empresa = Abrev_Empresa
                            dsResumen = olDocumento.ListaFacturacionElectronica(oeDocumento)

                            If C Then 'Se realiza para copiar la estructura
                                If dsResumen.Tables.Count = 0 Then Throw New Exception("Error al copiar estructura.")
                                dtResumen = dsResumen.Tables(0).Clone
                            End If
                            C = False
                            If dsResumen.Tables(0).Rows.Count = 0 Then Throw New Exception("No se encuentra documento: " & oeDocumento.Id)
                            dtResumen.ImportRow(dsResumen.Tables(0).Rows(0))
                        Next
                        'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GenerarXML_CPE(dsComprobante, Date.Now, tipo_documento, RutaArchivos, Abrev_Empresa, dtResumen, b_baja))
                        dt_cpe = Deserializar_XmlStr("")
                        contAceptados += 1

                        Registro_ComprobanteElectronico_Bath(dt_cpe, "I", tipo_documento, dtResumen)
                    Catch ex As Exception
                        sbMensajeError.AppendLine(ex.Message.ToString)
                        If dt_cpe.Rows.Count > 0 Then
                            contRechazos += 1
                        Else
                            contErrores = contErrores + 1
                        End If
                    End Try
            End Select
            If b_Envio Then
                If tipo_documento <> "RC" And tipo_documento <> "RA" And tipo_documento <> "RR" Then
                    sbMensaje.AppendLine("Comprobantes Informados." & vbLf)
                    If contAceptados > 0 Then
                        sbMensaje.AppendLine(contAceptados.ToString().Trim & " comprobante(s) aceptado(s) por la SUNAT.")
                    End If
                    If contRechazos > 0 Then
                        sbMensaje.AppendLine(contRechazos.ToString().Trim & " comprobantes  rechazado(s) por la SUNAT.")
                    End If
                    If contErrores > 0 Then
                        sbMensaje.AppendLine(contErrores.ToString().Trim & " comprobante(s) sin enviar a Sunat porque contienen errores.")
                    End If
                    sbMensaje.AppendLine(sbMensajeError.ToString)
                Else
                    If contAceptados > 0 Then
                        If tipo_documento = "RA" Then
                            sbMensaje.AppendLine("Comunicación de Baja.Ticket Generado: " & dt_cpe.Rows(0).Item("Ticket").ToString().Trim() & "." & vbLf & CStr(dtResumen.Rows.Count) & " comprobante(s) anulado(s).")
                        ElseIf tipo_documento = "RC" Then
                            sbMensaje.AppendLine("Resumen Diario. Ticket Generado: " & dt_cpe.Rows(0).Item("Ticket").ToString().Trim() & "." & vbLf & CStr(dtResumen.Rows.Count) & " comprobante(s) enviado(s).")
                        Else
                            sbMensaje.AppendLine("Resumen de Reversiones. Ticket Generado: " & dt_cpe.Rows(0).Item("Ticket").ToString().Trim() & "." & vbLf & CStr(dtResumen.Rows.Count) & " comprobante(s) enviado(s).")
                        End If
                    End If
                    If contRechazos > 0 Or contErrores > 0 Then
                        sbMensaje.AppendLine(vbLf & sbMensajeError.ToString)
                    End If
                End If
            Else
                If contAceptados > 0 Then
                    sbMensaje.AppendLine("(" + contAceptados.ToString().Trim & ") comprobantes generados en archivo XML.")
                End If
                If contRechazos > 0 Or contErrores > 0 Then
                    sbMensaje.AppendLine("No se puedo generar archivo(s) XML de (" + (contRechazos + contErrores).ToString().Trim & ") comprobante(s).")
                End If

                sbMensaje.AppendLine(sbMensajeError.ToString)
            End If

            If contAceptados = 0 And contErrores = 0 And contRechazos = 0 Then
                mensajeEmergente.Confirmacion("Debe seleccionar al menos un documento.")
            Else
                mensajeEmergente.Confirmacion(sbMensaje.ToString, True)
            End If

            If enviados_portal.Count > 0 Then
                Windows.Forms.Cursor.Current = Cursors.Default
                Cursor.Show()
                espFacturacion.Visible = False
                bwCpe.RunWorkerAsync()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            espFacturacion.Visible = False
        End Try
    End Sub

    'Private Sub Registro_ComprobanteElectronico_Bath(dt_cpe As DataTable, tipo_oper As String, tipo_documento As String, dt_Det As DataTable)
    '    Try
    '        Dim item As Integer = 0
    '        Dim id As String = ""
    '        If tipo_documento = "RC" Or tipo_documento = "RR" Or tipo_documento = "RA" Then
    '            oeComprobanteBath = New e_ComprobanteElectronicoBath
    '            olComprobanteBath = New l_ComprobanteElectronicoBath
    '            With oeComprobanteBath
    '                .TipoOperacion = ""
    '                .Ticket = dt_cpe.Rows(0).Item("Ticket")
    '                lst_Bath = New List(Of e_ComprobanteElectronicoBath)
    '                lst_Bath = olComprobanteBath.Listar(oeComprobanteBath)
    '                If lst_Bath.Count > 0 Then .Id = lst_Bath.Item(0).Id
    '                .xmlbase64 = dt_cpe.Rows(0).Item("xmlbase64")
    '                .FechaEnvio = dt_cpe.Rows(0).Item("fechaEnvio")
    '                .IndBaja = dt_cpe.Rows(0).Item("IndBaja")
    '                .cdrxml = dt_cpe.Rows(0).Item("cdrXML")
    '                .nombrexml = dt_cpe.Rows(0).Item("nombrexml")
    '                .Estado = dt_cpe.Rows(0).Item("Estado")
    '                .TipoReferencia = IIf(tipo_documento = "RC", 0, IIf(tipo_documento = "RA", 1, 2))
    '                .TipoOperacion = IIf(lst_Bath.Count > 0, "A", tipo_oper)
    '            End With
    '            If tipo_oper = "I" Then
    '                lst_BathDetalle = New List(Of e_ComprobanteElectronicoBath_Detalle)
    '                For Each det In dt_Det.Rows
    '                    item += 1
    '                    oeComprobanteBath_Det = New e_ComprobanteElectronicoBath_Detalle
    '                    With oeComprobanteBath_Det
    '                        .Item = item
    '                        .TipoOperacion = tipo_oper
    '                        .IdReferencia = det("id")
    '                        .UsuarioCrea = gUsuarioEOS.Nombre
    '                        .FechaCrea = Date.Now
    '                        .TipoReferencia = IIf(tipo_documento = "RC", 0, 1)
    '                        .IndBaja = IIf(tipo_documento = "RC", IIf(det("condicion") = "1", 0, 1), CType(dt_cpe.Rows(0).Item("IndBaja"), Boolean))
    '                    End With
    '                    lst_BathDetalle.Add(oeComprobanteBath_Det)
    '                Next
    '                oeComprobanteBath.leDetalle = lst_BathDetalle
    '            End If
    '            olComprobanteBath.Guardar(oeComprobanteBath)
    '        Else
    '            oeComprobante = New e_ComprobanteElectronico
    '            olComprobante = New l_ComprobanteElectronico
    '            With oeComprobante
    '                lst_Comprobante = New List(Of e_ComprobanteElectronico)
    '                .IdReferencia = dt_cpe.Rows(0).Item("IdReferencia")
    '                .cdrxml = ""
    '                lst_Comprobante = olComprobante.Listar(oeComprobante)
    '                If lst_Comprobante.Count > 0 Then .Id = lst_Comprobante.Item(0).Id
    '                .xmlbase64 = dt_cpe.Rows(0).Item("xmlbase64")
    '                .valorcodbarras = dt_cpe.Rows(0).Item("valorcodbarras")
    '                .valorcodqr = dt_cpe.Rows(0).Item("valorcodqr")
    '                .cdrxml = dt_cpe.Rows(0).Item("cdrXML")
    '                .nombrexml = dt_cpe.Rows(0).Item("nombrexml")
    '                .ValorResumen = dt_cpe.Rows(0).Item("ValorResumen")
    '                .Firma = dt_cpe.Rows(0).Item("Firma")
    '                .TipoReferencia = dt_cpe.Rows(0).Item("TipoReferencia")
    '                .TipoOperacion = IIf(lst_Comprobante.Count > 0, "T", tipo_oper)
    '                .EstadoElectronico = dt_cpe.Rows(0).Item("EstadoElectronico")
    '                .UsuarioCrea = gUsuarioEOS.Id
    '                .FechaCrea = Date.Now
    '            End With
    '            olComprobante.Guardar(oeComprobante)
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub enviar_consultar_validacion(grilla As UltraGrid, tipo As Boolean)
        Dim c As Integer = 0
        If grilla.Rows.Count = 0 Then
            Throw New Exception("No hay Registros para Enviar o Consultar.")
        Else
            If tipo Then
                If grilla.Selected.Rows.Count = 0 Then Throw New Exception("Debe seleccionar un Registro para Consultar.")
            Else
                If grilla.Rows.Where(Function(x) x.Cells("Select").Value = True).Count = 0 Then Throw New Exception("Debe seleccionar al menos un registro para Enviar.")
            End If
        End If

    End Sub

    Private Sub ConsultaDocumento(ByVal grilla As UltraWinGrid.UltraGrid)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim dt_cpe As DataTable
            Dim dsComprobante As DataSet = Nothing
            Dim sbMensajeError As New StringBuilder
            Dim sbMensaje As New StringBuilder
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0
            Dim lst_CatalogoSunat As New List(Of e_CatalagoCodigoSunat)
            'WCF_Cpe = New Cpe_Indu.WS_CpeSoapClient("CL")

            If grilla.Selected.Rows.Count = 0 Then Throw New Exception("Debe seleccionar 1 Documento para Consultar.")

            oeDocumento = New e_MovimientoDocumento
            oeDocumento.TipoOperacion = "DT"
            oeDocumento._Operador = 6
            oeDocumento.Id = grilla.ActiveRow.Cells("Id").Value
            dsComprobante = olDocumento.ListaFacturacionElectronica(oeDocumento)

            Try
                If dsComprobante.Tables.Count > 0 Then
                    If dsComprobante.Tables(0).Rows.Count = 0 Then Throw New Exception("Documento no presenta filas.")

                    Select Case dsComprobante.Tables(0).Rows(0).Item("estado").ToString.Trim
                        Case "C"
                            'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GetStatus_Documento(dsComprobante.Tables(0), RutaArchivos, Abrev_Empresa))
                            dt_cpe = Deserializar_XmlStr("")
                            Registro_ComprobanteElectronico_Bath(dt_cpe, "A", dsComprobante.Tables(0).Rows(0).Item("tipcomp"), Nothing)
                            sbMensaje.AppendLine(dsComprobante.Tables(0).Rows(0).Item("nombrecom") & " " & dsComprobante.Tables(0).Rows(0).Item("seriecomp") & "-" & dsComprobante.Tables(0).Rows(0).Item("corrcomp") & " fue consultado y se obtuvo CDR.")
                        Case "A"
                            Throw New Exception("El comprobante ya fue informado a Sunat.")
                        Case "R"
                            Throw New Exception("El comprobante fue rechazado por Sunat.")
                        Case Else
                            Throw New Exception("El comprobante aun no ha sido emitido en el sistema.")
                    End Select
                Else
                    Throw New Exception("No se encuentra comprobante.")
                End If
            Catch ex As Exception
                sbMensajeError.AppendLine("Documento " & dsComprobante.Tables(0).Rows(0).Item("seriecomp") & "-" & dsComprobante.Tables(0).Rows(0).Item("corrcomp") & vbNewLine & ex.Message)
            End Try
            'Next

            sbMensaje.AppendLine(sbMensajeError.ToString)

            If sbMensaje.ToString <> "" Then
                mensajeEmergente.Confirmacion(sbMensaje.ToString)
            End If

            Call Me.Listar_CPE()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ConsultarTicket()
        Dim b_error As Boolean = False
        Dim dt_cpe As DataTable = Nothing
        Try
            'WCF_Cpe = New Cpe_Indu.WS_CpeSoapClient("CL")
            'WCF_Cpe = New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe")
            espFacturacion.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ugTicket.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Ticket para consultar!")
            If ugTicket.ActiveRow.Cells("CdrXML").Value = True Then Throw New Exception("Ticket ya fue consultado." & vbLf & "Descargue Constancia de Recepción.")
            'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GetStatus_Ticket(RutaArchivos, ugTicket.ActiveRow.Cells("Ticket").Value, ugTicket.ActiveRow.Cells("NombreXml").Value, "RC", IIf(ugTicket.ActiveRow.Cells("Tipo").Value = "RESUMEN DIARIO", 0, 1), Abrev_Empresa))
            dt_cpe = Deserializar_XmlStr("")
            Registro_ComprobanteElectronico_Bath(dt_cpe, "A", IIf(ugTicket.ActiveRow.Cells("Tipo").Value = "RESUMEN DIARIO", "RC", IIf(ugTicket.ActiveRow.Cells("Tipo").Value = "COMUNICACIÓN DE BAJA", "RA", "RR")), Nothing)
            Dim msjerror As String = dt_cpe.Rows(0).Item("msjerror").ToString().Trim()
            If msjerror = "" Then mensajeEmergente.Confirmacion("Ticket aceptado por la SUNAT.") Else mensajeEmergente.Confirmacion("Ticket rechazado por la SUNAT: " & vbLf & msjerror)
            espFacturacion.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            espFacturacion.Visible = False
            Call Me.Listar_CPE()
        End Try
    End Sub

    Private Sub DescargarXml_Comprobantes(grilla As UltraGrid, Optional cdr As Boolean = False)
        Try
            espFacturacion.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim strRuta As String = ""
            Dim strNombre As String = ""
            If grilla.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante!")

            If grilla.ActiveRow.Index > -1 Then
                Dim oeDoc As New e_MovimientoDocumento
                oeDoc.Id = grilla.Rows(grilla.ActiveRow.Index).Cells("Id").Value
                Dim ol_ComprobElect As New l_ComprobanteElectronico
                Dim olConfiguracion As New l_Configuracion
                strRuta = RutaArchivos
                If utcFichaDocumentos.SelectedTab.Index = 6 Then
                    strNombre = olComprobanteBath.Obtener(New e_ComprobanteElectronicoBath With {.TipoOperacion = "", .Id = oeDoc.Id, .TipoReferencia = 1}).nombrexml
                Else
                    strNombre = ol_ComprobElect.Obtener(New e_ComprobanteElectronico With {.TipoReferencia = 1, .IdReferencia = oeDoc.Id}).nombrexml
                End If
                'Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
                'Dim unidad As String = allDrives.Where(Function(x) x.Name <> "C:\").ToList.Item(0).Name
                If cdr = True Then strNombre = "R-" & strNombre
                strRuta = strRuta.Trim() & strNombre.Trim() & ".ZIP"
                If File.Exists(strRuta.Trim()) Then
                    SdGuardar.FileName = strNombre.Trim() & ".ZIP"
                    SdGuardar.DefaultExt = ".ZIP"
                    SdGuardar.Filter = "*.ZIP|Todos los archivos"
                    SdGuardar.Title = "Guardar ZIP"
                    If SdGuardar.ShowDialog = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.CopyFile(strRuta, SdGuardar.FileName, True)
                    End If
                    'My.Computer.FileSystem.CopyFile(strRuta.Trim() & strNombre.Trim() & ".zip", unidad & strNombre.Trim() & ".zip")
                    'MsgBox("El archivo fue descargado en la dirección " & unidad & strNombre.Trim() & ".zip", MsgBoxStyle.Information, Me.Text)
                    'Process.Start("explorer.exe", unidad & strNombre.Trim() & ".zip")
                Else
                    mensajeEmergente.Confirmacion("No existe archivo. Vuelva a Consultar a SUNAT para obtener el CDR.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            espFacturacion.Visible = False
        End Try
    End Sub
#End Region

#Region "Opciones de Menú CPE"
    Private Sub Tsb_Env_Filtro_Click(sender As Object, e As EventArgs) Handles Tsb_Env_Filtro.Click
        Try
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 1
                    enviar_consultar_validacion(ugEnviar, False)
                    If cmb_TipoDoc.SelectedIndex <> 0 Then
                        Dim tipo_documento As String = "01"
                        Select Case cmb_TipoDoc.Text
                            Case "FACTURA" : tipo_documento = "01"
                            Case "BOLETA DE VENTA" : tipo_documento = "03"
                            Case "NOTA DE CRÉDITO" : tipo_documento = "07"
                            Case "NOTA DE DÉBITO" : tipo_documento = "08"
                            Case "COMPROBANTE DE RETENCIÓN" : tipo_documento = "20"
                        End Select
                        Envio_CPE(tipo_documento, True)        'Comprobante FT, NC, ND
                    End If
                Case 2
                    Envio_CPE("RC", True)    'Resumen Diario (BV, NC y/o ND relacionadas) : Informadas y Anuladas  
                Case 4 : enviar_consultar_validacion(ugEnviarBaja, False)
                    Envio_CPE(IIf(cmb_TipoDoc.Text = "COMPROBANTE DE RETENCIÓN", "RR", "RA"), True, True)   'Comunicación de Baja FT, NC, ND / Resumen de Reversiones (Retenciones)
                Case 7
                    Call Me.PorEnviar_Portal()
            End Select
            Call Me.Listar_CPE()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsb_Consultar_Filtro_Click(sender As Object, e As EventArgs) Handles tsb_Consultar_Filtro.Click
        Try
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 1
                    enviar_consultar_validacion(ugEnviar, True) : ConsultaDocumento(ugEnviar)
                Case 6 : ConsultarTicket()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsb_Exportar_Filtro_Click(sender As Object, e As EventArgs) Handles tsb_Exportar_Filtro.Click
        Try
            Me.Exportar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDFToolStripMenuItem.Click, mImprimirPDF.Click
        Try
            Me.Imprimir()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DescargarCDRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarCDRToolStripMenuItem.Click, mDescargarCDR.Click
        Try
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 3
                    If ugEnviados.ActiveRow.Cells("Serie").Text.Contains("B") Then Throw New Exception("El comprobante no cuenta con CDR porque fue enviado por Resumen.")
                    DescargarXml_Comprobantes(ugEnviados, True)
                Case 6
                    If ugTicket.ActiveRow.Cells("Estado").Value.ToString().Trim() = "E" Or ugTicket.ActiveRow.Cells("Estado").Value.ToString().Trim() = "EN PROCESO" Then Throw New Exception("Ticket " & ugTicket.ActiveRow.Cells("ticket").Value.ToString().Trim() & " no ha sido consultado a SUNAT." & vbLf & "Consultar el Ticket para descargar el CDR.")
                    DescargarXml_Comprobantes(ugTicket, True)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub XMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLToolStripMenuItem.Click
        Try
            Dim tipo_documento As String = "01"
            If utcFichaDocumentos.SelectedTab.Index = 1 Then
                If cmb_TipoDoc.SelectedIndex <> 0 Then
                    Select Case cmb_TipoDoc.Text
                        Case "FACTURA" : tipo_documento = "01"
                        Case "BOLETA DE VENTA" : tipo_documento = "03"
                        Case "NOTA DE CRÉDITO" : tipo_documento = "07"
                        Case "NOTA DE DÉBITO" : tipo_documento = "08"
                        Case "COMPROBANTE DE RETENCIÓN" : tipo_documento = "20"
                    End Select
                    Envio_CPE(tipo_documento, False)        'Generar XML                                     
                End If
            ElseIf utcFichaDocumentos.SelectedTab.Index = 2 Then
                Envio_CPE("03", False)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub DescargaZIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargaZIPToolStripMenuItem.Click, mDescargarXML.Click
        'Try
        '    Select Case utcFichaDocumentos.SelectedTab.Index
        '        Case 1 : DescargarXml_Comprobantes(ugEnviar)
        '        Case 2 : DescargarXml_Comprobantes(ugResumen)
        '        Case 3 : DescargarXml_Comprobantes(ugEnviados)
        '    End Select
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try

        Try
            Dim RutaArchivos As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("DocElectronico") & "\xml\"
            'Dim RutaArchivos As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\" '@0001
            Dim sNombreArchivo As String = ""
            Dim TipoDocumento As String = ""
            Dim SerieDes As String = ""
            Dim NumeroDes As String = ""
            'If ugEnviados.ActiveRow.Cells("EstadoSunat").Value <> "ACEPTADA" Then Throw New Exception("Para Descargar XML, Documento debe ser Aceptada por Sunat.")

            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            If sNombreArchivo <> "" Then
                TipoDocumento = ugEnviados.ActiveRow.Cells("IdTipoDocumento").Value
                If TipoDocumento = "1CH000000026" Then TipoDocumento = "01"
                If TipoDocumento = "1CH000000002" Then TipoDocumento = "03"
                If TipoDocumento = "1CH000000033" Then TipoDocumento = "08"
                If TipoDocumento = "1CH000000030" Then TipoDocumento = "07"

                SerieDes = ugEnviados.ActiveRow.Cells("Serie").Value
                NumeroDes = ugEnviados.ActiveRow.Cells("Numero").Value

                RutaArchivos = RutaArchivos + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                sNombreArchivo = sNombreArchivo + "\" + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                My.Computer.FileSystem.CopyFile(RutaArchivos, sNombreArchivo, True)
                mensajeEmergente.Confirmacion("Se copio archivo correctamente", True)
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    'CARGAR FORMULARIO
    Private Sub frm_CpeFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim direccion As String = WCF_Cpe.InnerChannel.RemoteAddress.ToString()
            Dim direccion As String = ""
            'WCF_Cpe = New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe")
            'Me.Text = Me.Text & " - " & WCF_Cpe.Mensaje_Inicio(Abrev_Empresa, direccion)
            Me.Text = Me.Text & " - "
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
            Call Me.Combo_Series()
            Call Me.Combo_TipoDocumento()
            dtp_FechaHasta.Value = Date.Now
            dtp_FechaDesde.Value = DateAdd(DateInterval.Day, -7, Date.Now)
            Call Me.MostrarItems_Menu(0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1)
            Call Me.Pendientes_CPE()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_CpeFacturacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    'INICIALIZAR GRILLAS
    Private Sub ugEnviarBaja_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles ugEnviarBaja.InitializeLayout
        Try
            If {"ugEnviarBaja"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ugEnviar_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles ugEnviar.InitializeLayout 'Permite seleccionar toda la fila
        Try
            If {"ugEnviar"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ugResumen_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles ugResumen.InitializeLayout 'Permite seleccionar toda la fila
        Try
            If {"ugResumen"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ugEnviarPC_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles ugEnviarPC.InitializeLayout 'Permite seleccionar toda la fila
        Try
            If {"ugEnviarPC"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ugEnviarBaja_CellChange(sender As Object, e As CellEventArgs) Handles ugEnviarBaja.CellChange
        Try
            ugEnviarBaja.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ugEnviar_CellChange(sender As Object, e As CellEventArgs) Handles ugEnviar.CellChange
        ugEnviar.UpdateData()
    End Sub

    Private Sub ugResumen_CellChange(sender As Object, e As CellEventArgs) Handles ugResumen.CellChange
        ugResumen.UpdateData()
    End Sub

    Private Sub ugEnviarPC_CellChange(sender As Object, e As CellEventArgs) Handles ugEnviarPC.CellChange
        ugEnviarPC.UpdateData()
    End Sub

    Private Sub ugTicket_MouseLeaveElement(sender As Object, e As UIElementEventArgs) Handles ugTicket.MouseLeaveElement, ugTicket.MouseEnterElement
        Activar_OpcionesTicket()
    End Sub

    Private Sub ugTicket_AfterRowActivate(sender As Object, e As EventArgs) Handles ugTicket.AfterRowActivate
        Activar_OpcionesTicket()
    End Sub

    Private Sub Activar_OpcionesTicket()
        Dim _ban As Boolean = False
        Try
            If ugTicket.ActiveRow.ChildBands(0).Rows.Count > 0 Then
                _ban = True : MenuDetalle.Items("mDescargarCDR").Visible = True : tsb_Consultar_Filtro.Enabled = True : DescargarCDRToolStripMenuItem.Visible = True
            End If
        Catch ex As NullReferenceException
            If _ban = False Then MenuDetalle.Items("mDescargarCDR").Visible = False : tsb_Consultar_Filtro.Enabled = False : DescargarCDRToolStripMenuItem.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'SELECCIONAR TABS

    Private Sub utcFichaDocumentos_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles utcFichaDocumentos.SelectedTabChanged
        Try
            bandload = True
            Call Me.Cargar_TipoDocumento()
            Call Me.Habilitar_OpcionesMenu()
            Call Me.Cargar_Series_Tipo()
            Call Me.Listar_CPE()
            bandload = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub upGrillas_Resize(sender As Object, e As EventArgs) Handles upGrillas.Resize
        espFacturacion.Location = New System.Drawing.Point((Me.Width / 2) - (espFacturacion.Width / 2), (Me.Height / 2) - espFacturacion.Height)
    End Sub

    'SELECCIONAR TIPO DOCUMENTO
    Private Sub cmb_TipoDoc_ValueChanged(sender As Object, e As EventArgs) Handles cmb_TipoDoc.ValueChanged
        Try
            Call Me.Habilitar_OpcionesMenu()
            Call Me.Cargar_Series_Tipo()
            If bandload = False Then Call Me.Listar_CPE()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cmbSerie_ValueChanged(sender As Object, e As EventArgs) Handles cmbSerie.ValueChanged
        Try
            If bandload = False Then Call Me.Listar_CPE()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'VALIDAR MENU
    Private Sub MenuDetalle_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuDetalle.Opening
        Dim grilla As UltraGrid
        Select Case utcFichaDocumentos.SelectedTab.Index
            Case 1, 2
                grilla = IIf(utcFichaDocumentos.SelectedTab.Index = 1, ugEnviar, ugResumen)
                If grilla.Rows.Count > 0 Then
                    MenuHabilitar(True, True, False)
                Else
                    MenuHabilitar(False, False, False)
                End If
            Case 3, 4, 5
                grilla = IIf(utcFichaDocumentos.SelectedTab.Index = 3, ugEnviados, IIf(utcFichaDocumentos.SelectedTab.Index = 4, ugEnviarBaja, ugBaja))
                If grilla.Rows.Count > 0 Then
                    MenuHabilitar(True, True, IIf(utcFichaDocumentos.SelectedTab.Index = 3, True, False))
                Else
                    MenuHabilitar(False, False, False)
                End If
            Case 6
                If ugTicket.Rows.Count > 0 Then
                    MenuHabilitar(False, False, True)
                Else
                    MenuHabilitar(False, False, False)
                End If
            Case Else
                MenuHabilitar(False, False, False)
        End Select
    End Sub

    Private Sub bwCpe_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwCpe.DoWork
        Try
            e.Result = Envio_PortalConsultas(False)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub bwCpe_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwCpe.RunWorkerCompleted
        Try
            'Manejar el caso en que se produzca un error o excepción
            If (e.Error IsNot Nothing) Then
                'MsgBox(e.Error.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            Else
                If e.Cancelled Then
                    'Manejar el caso en que el usuario haya cancelado la operación. 
                    frm_Menu.Alerta.Show(CargarDatosAlerta("ENVIO CPE", "Servicio Portal de Consultas Inactivo", My.Resources.Information, "AlertaEnvioPortal", Misc.ScreenPosition.BottomRight))
                Else
                    'Manejar el caso en que la operación haya finalizado con éxito
                    If e.Result IsNot Nothing AndAlso e.Result <> "" Then
                        frm_Menu.Alerta.Show(CargarDatosAlerta("ENVIO CPE", e.Result.ToString(), My.Resources.Information, "AlertaEnvioPortal", Misc.ScreenPosition.BottomRight))
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Controles"

    Private Sub Cargar_Series_Tipo()
        If utcFichaDocumentos.SelectedTab.Index = 2 Then
            gmt_ComboEspecifico(cmbSerie, lst_Serie.Where(Function(x) x.Tipo = "2" Or x.Id = "TODOS").ToList, 0, "Serie")
        ElseIf utcFichaDocumentos.SelectedTab.Index = 1 Or utcFichaDocumentos.SelectedTab.Index = 4 Then
            gmt_ComboEspecifico(cmbSerie, lst_Serie.Where(Function(x) x.Tipo = "1" Or x.Id = "TODOS").ToList, 0, "Serie")
        Else
            Select Case cmb_TipoDoc.Text
                Case "BOLETA DE VENTA"
                    gmt_ComboEspecifico(cmbSerie, lst_Serie.Where(Function(x) x.Tipo = "2" Or x.Id = "TODOS").ToList, 0, "Serie")
                Case "FACTURA"
                    gmt_ComboEspecifico(cmbSerie, lst_Serie.Where(Function(x) x.Tipo = "1" Or x.Id = "TODOS").ToList, 0, "Serie")
                Case "COMPROBANTE DE RETENCIÓN"
                    gmt_ComboEspecifico(cmbSerie, lst_Serie.Where(Function(x) x.Tipo = "3" Or x.Id = "TODOS").ToList, 0, "Serie")
                Case Else
                    gmt_ComboEspecifico(cmbSerie, lst_Serie, 0, "Serie")
            End Select
        End If
    End Sub

    Private Sub Cargar_TipoDocumento()
        Select Case utcFichaDocumentos.SelectedTab.Index
            Case 0
                gmt_ComboEspecifico(cmb_TipoDoc, lst_TipoDocumento.Where(Function(x) x.Nombre <> "BOLETA DE VENTA" And x.Nombre <> "COMPROBANTE DE RETENCIÓN").ToList, 0)
            Case 1, 4
                gmt_ComboEspecifico(cmb_TipoDoc, lst_TipoDocumento.Where(Function(x) x.Nombre <> "BOLETA DE VENTA").ToList, 0)
            Case Else
                gmt_ComboEspecifico(cmb_TipoDoc, lst_TipoDocumento, 0)
        End Select
    End Sub

    Private Sub Habilitar_OpcionesMenu()
        Dim _ban As Boolean = False
        Select Case utcFichaDocumentos.SelectedTab.Index
            Case 1
                Select Case cmb_TipoDoc.SelectedIndex
                    Case 0
                        Call Me.MostrarItems_Menu(0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1)
                    Case Else
                        If utcFichaDocumentos.SelectedTab.Index = 1 Then _ban = True
                        Call Me.MostrarItems_Menu(1, 1, _ban, 1, _ban, _ban, 1, 0, 1, 0, _ban, 1)
                End Select
            Case 4
                Call Me.MostrarItems_Menu(1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1)
            Case 2
                Call Me.MostrarItems_Menu(1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1)
            Case 6
                Call Me.MostrarItems_Menu(0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0)
            Case 7
                Call Me.MostrarItems_Menu(1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1)
            Case 3, 5
                If utcFichaDocumentos.SelectedTab.Index = 3 Then _ban = True
                Call Me.MostrarItems_Menu(0, 0, 1, 1, 0, _ban, 1, 0, 1, _ban, 0, 1)
            Case Else
                Call Me.MostrarItems_Menu(0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1)
        End Select
    End Sub

    Private Sub TransporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransporteToolStripMenuItem.Click
        Try
            Dim frmImpresion As New frm_FacturaBoletaElectronico
            Dim TipoDoc As Boolean = False
            Dim grilla As UltraGrid = Nothing
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 0 : grilla = ugPendientes
                Case 1 : grilla = ugEnviar
                Case 2 : grilla = ugResumen
                Case 3 : grilla = ugEnviados
                Case 4 : grilla = ugEnviarBaja
                Case 5 : grilla = ugBaja
            End Select
            If grilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
            TipoDoc = IIf(grilla.ActiveRow.Cells("IdTipoDocumento").Value = "1CIX007" Or grilla.ActiveRow.Cells("IdTipoDocumento").Value = "1CIX008", True, False)
            frmImpresion.mt_CargarDatos(grilla.ActiveRow.Cells("Id").Value, TipoDoc, "")
            frmImpresion.StartPosition = FormStartPosition.CenterScreen
            frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            frmImpresion.MaximizeBox = True
            frmImpresion.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComercialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComercialToolStripMenuItem.Click
        Try
            Dim frmImpresion As New frm_FacturaBoletaElectronico
            Dim TipoDoc As Boolean = False
            Dim grilla As UltraGrid = Nothing
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 0 : grilla = ugPendientes
                Case 1 : grilla = ugEnviar
                Case 2 : grilla = ugResumen
                Case 3 : grilla = ugEnviados
                Case 4 : grilla = ugEnviarBaja
                Case 5 : grilla = ugBaja
            End Select
            If grilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
            gmt_Imprimir_Documento(grilla.ActiveRow.Cells("Id").Value, "A4", "OV", "")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GrifoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrifoToolStripMenuItem.Click
        Try
            Dim frmImpresion As New frm_FacturaBoletaElectronico
            Dim TipoDoc As Boolean = False
            Dim grilla As UltraGrid = Nothing
            Select Case utcFichaDocumentos.SelectedTab.Index
                Case 0 : grilla = ugPendientes
                Case 1 : grilla = ugEnviar
                Case 2 : grilla = ugResumen
                Case 3 : grilla = ugEnviados
                Case 4 : grilla = ugEnviarBaja
                Case 5 : grilla = ugBaja
            End Select
            If grilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
            gmt_Imprimir_Documento(grilla.ActiveRow.Cells("Id").Value, "A4", "GRIFO", "")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarItems_Menu(ByVal enviar As Boolean, ByVal consultar As Boolean, ByVal fecha As Boolean,
                            ByVal TipoDoc As Boolean, ByVal xml As Boolean, ByVal zip As Boolean, ByVal pdf As Boolean,
                             email As Boolean, excel As Boolean, cdr As Boolean, validar_corr As Boolean, serie As Boolean)
        Tsb_Env_Filtro.Enabled = enviar
        tsb_Consultar_Filtro.Enabled = consultar
        cmb_TipoDoc.Enabled = TipoDoc
        XMLToolStripMenuItem.Visible = xml
        PDFToolStripMenuItem.Visible = pdf
        DescargaZIPToolStripMenuItem.Visible = zip
        EnvioACorreoToolStripMenuItem.Visible = email
        DescargarCDRToolStripMenuItem.Visible = cdr
        tsb_Exportar_Filtro.Enabled = excel
        If fecha Then lblDesde.Text = "Desde:" : rbResumen.Visible = False Else lblDesde.Text = "Emisión:" : rbResumen.Visible = True : rbResumen.Text = IIf(utcFichaDocumentos.SelectedTab.Index = 2, "Resumen Diario", "Comunicación de Baja")
        lblHasta.Visible = fecha
        dtp_FechaHasta.Visible = fecha
        chk_Validacion.Enabled = validar_corr
        cmbSerie.Enabled = serie
        If serie = False Then cmbSerie.SelectedIndex = 0
    End Sub

    Private Sub Combo_TipoDocumento()
        Try
            oe_TipoDocumento = New e_TipoDocumento
            ol_TipoDocumento = New l_TipoDocumento
            lst_TipoDocumento = New List(Of e_TipoDocumento)
            oe_TipoDocumento.Id = "TODOS"
            oe_TipoDocumento.Nombre = "TODOS"
            lst_TipoDocumento.Add(oe_TipoDocumento)
            oe_TipoDocumento.TipoOperacion = "E"
            lst_TipoDocumento.AddRange(ol_TipoDocumento.Listar(oe_TipoDocumento))
            gmt_ComboEspecifico(cmb_TipoDoc, lst_TipoDocumento, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Combo_Series()
        Try
            Dim dt_serie As DataTable
            oeSerie = New e_MovimientoDocumento
            olSerie = New l_MovimientoDocumento
            lst_Serie = New List(Of e_MovimientoDocumento)
            oe_TipoDocumento = New e_TipoDocumento
            oeSerie.Id = "TODOS"
            oeSerie.Serie = "TODOS"
            lst_Serie.Add(oeSerie)
            oeSerie.TipoOperacion = "SER"
            dt_serie = olSerie.ListaFacturacionElectronica(oeSerie).Tables(0)
            For Each ser In dt_serie.Rows
                oeSerie = New e_MovimientoDocumento
                oeSerie.Id = ser.Item("Id").ToString().Trim()
                oeSerie.Serie = ser.Item("Serie").ToString().Trim()
                oeSerie.Tipo = ser.Item("Tipo").ToString().Trim()
                lst_Serie.Add(oeSerie)
            Next
            gmt_ComboEspecifico(cmbSerie, lst_Serie, 0, "Serie")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try
    End Sub

    Private Sub MenuHabilitar(xml As Boolean, pdf As Boolean, cdr As Boolean)
        MenuDetalle.Visible = xml
        MenuDetalle.Items("mDescargarXML").Visible = xml
        MenuDetalle.Items("mImprimirPDF").Visible = pdf
        MenuDetalle.Items("mDescargarCDR").Visible = cdr
    End Sub

    Private Sub Pendientes_CPE()
        Try
            'Dim dt As DataTable
            'Dim sbMensaje As New StringBuilder
            'Dim tipo_doc As String = ""
            'oeDocumento = New e_MovimientoDocumento
            'oeDocumento.TipoOperacion = "PTE"
            'dt = olDocumento.ListaFacturacionElectronica(oeDocumento).Tables(0)
            'Dim msj As String = ""
            'If dt.Rows.Count > 0 Then

            '    For Each row As DataRow In dt.Rows
            '        If tipo_doc <> row.Item("TipoDocumento") Then
            '            tipo_doc = row.Item("TipoDocumento")
            '            sbMensaje.AppendLine(CStr(row.Item("TipoDocumento")).ToString())
            '            sbMensaje.Append(": ").AppendLine()
            '        End If
            '        msj = CStr(Format(row.Item("FechaEmision"), "dd-MM-yyyy")) & ": " & row.Item("Cantidad").ToString
            '        sbMensaje.Append(msj).AppendLine()
            '    Next
            '    frm_Menu.AlertaInforma.Show(CargarDatosAlerta("Documentos no informados a SUNAT", sbMensaje.ToString, My.Resources.Information, "ENVIO CPE", Misc.ScreenPosition.BottomLeft))
            '    'frm_Menu.Alerta.Show("Documentos no informados a SUNAT", sbMensaje.ToString, My.Resources.Information)
            '    'mensajeEmergente.Confirmacion(sbMensaje.ToString, True)

            'End If
            'sbMensaje.Clear()

            'tipo_doc = ""
            'oeDocumento = New e_MovimientoDocumento
            'oeDocumento.TipoOperacion = "CBJ"
            'dt = olDocumento.ListaFacturacionElectronica(oeDocumento).Tables(0)
            'If dt.Rows.Count > 0 Then
            '    For Each row As DataRow In dt.Rows
            '        If tipo_doc <> row.Item("TipoDocumento") Then
            '            tipo_doc = row.Item("TipoDocumento")
            '            sbMensaje.AppendLine(CStr(row.Item("TipoDocumento")).ToString())
            '            sbMensaje.Append(": ").AppendLine()
            '        End If
            '        msj = CStr(Format(row.Item("FechaEmision"), "dd-MM-yyyy")) & ": " & row.Item("Cantidad").ToString
            '        sbMensaje.Append(msj).AppendLine()
            '    Next
            '    frm_Menu.AlertaBaja.Show(CargarDatosAlerta("Documentos por Comunicar Baja a SUNAT", sbMensaje.ToString, My.Resources.Information, "ENVIO CPE - BAJAS", Misc.ScreenPosition.BottomRight))
            'End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class