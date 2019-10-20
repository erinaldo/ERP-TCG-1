'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid


Public Class frm_ReporteDocumentosVenta
    Inherits frm_MenuPadre

#Region "Inicializar formulario"

    'Public Sub New()
    '    ' Llamada necesaria para el Diseñador de Windows Forms.
    '    InitializeComponent()
    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '    CargarDatos()
    'End Sub

    Private Shared instancia As frm_ReporteDocumentosVenta = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteDocumentosVenta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeReporteDoc As New e_ReporteDocumento
    Dim olReporteDoc As New l_ReporteDocumento
    Dim leReporteDoc As New List(Of e_ReporteDocumento)

    Dim oeTipoDoc As New e_TipoDocumento
    Dim olTipoDoc As New l_TipoDocumento
    Dim leTipoDoc As New List(Of e_TipoDocumento)

    Dim oeEstadoDoc As New e_Estado
    Dim olEstadoDoc As New l_Estado
    Dim leEstadoDoc As New List(Of e_Estado)

    Dim BandLoad As Boolean = False

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        'MyBase.Consultar(Activo)
        Try
            oeReporteDoc = New e_ReporteDocumento
            oeReporteDoc.IdTipoDoc = cboTipoDocumento.Value
            oeReporteDoc.IdEstadoDocumento = cboEstadoDocumento.Value
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oeReporteDoc._Fechadesde = fecDesde.Value
            oeReporteDoc._FechaHasta = fecHasta.Value
            leReporteDoc = olReporteDoc.Listar(oeReporteDoc)
            CargarDatos(leReporteDoc)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        'MyBase.Exportar()
        Exportar_Excel(griDocumento)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteDocumentosVenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griDocumento.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteDocumentosVenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteDocumentosVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            BandLoad = True
            ficDocVenta.Tabs(1).Enabled = False
            CargarDatos(New List(Of e_ReporteDocumento))
            BandLoad = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
#End Region

#Region "Metodos"

    Public Sub CargarCombos()
        Try
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.Id = ""
            oeTipoDoc.Nombre = "TODOS"
            leTipoDoc.Add(oeTipoDoc)

            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = "F"
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))

            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = ""
            oeTipoDoc.Nombre = "NOTA DE CRÉDITO"
            oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)
            leTipoDoc.Add(oeTipoDoc)

            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = ""
            oeTipoDoc.Nombre = "NOTA DE DÉBITO"
            oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)
            leTipoDoc.Add(oeTipoDoc)

            LlenarCombo(cboTipoDocumento, "Nombre", leTipoDoc, 0)

            oeEstadoDoc = New e_Estado
            oeEstadoDoc.Id = ""
            oeEstadoDoc.Nombre = "TODOS"
            leEstadoDoc.Add(oeEstadoDoc)

            oeEstadoDoc = New e_Estado
            oeEstadoDoc.Nombre = "FACTURAR"
            leEstadoDoc.AddRange(olEstadoDoc.Listar(oeEstadoDoc))

            LlenarCombo(cboEstadoDocumento, "Nombre", leEstadoDoc, 0)

        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Public Sub CargarDatos(ByVal leDoc As List(Of e_ReporteDocumento))
        Try
            With griDocumento

                .DataSource = leDoc

                If BandLoad Then

                    For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                        If Col.Key.Contains("Id") Then Col.Hidden = True : Col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    Next

                    .DisplayLayout.Bands(0).Columns("Serie").SortIndicator = SortOrder.Ascending

                    .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SaldoNeto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                    .DisplayLayout.Bands(0).Columns("CadenaOperacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("CadenaViaje").Hidden = True

                    .DisplayLayout.Bands(0).Columns("TipoDoc").Width = 110
                    .DisplayLayout.Bands(0).Columns("Serie").Width = 35
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 65
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 65
                    .DisplayLayout.Bands(0).Columns("Cliente").Width = 300
                    .DisplayLayout.Bands(0).Columns("NroDocumento").Width = 70
                    .DisplayLayout.Bands(0).Columns("SubTotal").Width = 65
                    .DisplayLayout.Bands(0).Columns("IGV").Width = 65
                    .DisplayLayout.Bands(0).Columns("Total").Width = 65
                    .DisplayLayout.Bands(0).Columns("Saldo").Width = 65
                    .DisplayLayout.Bands(0).Columns("Detraccion").Width = 65
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Width = 65
                    .DisplayLayout.Bands(0).Columns("SaldoNeto").Width = 65
                    .DisplayLayout.Bands(0).Columns("TipoMoneda").Width = 25
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 35
                    .DisplayLayout.Bands(0).Columns("TotalSoles").Width = 65
                    .DisplayLayout.Bands(0).Columns("EstadoDocumento").Width = 75
                    .DisplayLayout.Bands(0).Columns("Indicador").Width = 30
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                    .DisplayLayout.Bands(0).Columns("CadenaOperacion").Width = 150

                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emis."
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Header.Caption = "Saldo Detrac."
                    .DisplayLayout.Bands(0).Columns("TipoMoneda").Header.Caption = "T.M."
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                    .DisplayLayout.Bands(0).Columns("EstadoDocumento").Header.Caption = "Estado"
                    .DisplayLayout.Bands(0).Columns("Indicador").Header.Caption = "M/S"

                    .DisplayLayout.Bands(0).Columns("SubTotal").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("IGV").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Detraccion").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("SaldoNeto").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("TipoCambio").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("TotalSoles").CellAppearance.TextHAlign = HAlign.Right

                    .DisplayLayout.Bands(0).Columns("SubTotal").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("IGV").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("Total").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("Saldo").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("Detraccion").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("SaldoNeto").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("TotalSoles").Format = "#,##0.00"

                    .DisplayLayout.Bands(0).Columns("FechaEmision").Style = ColumnStyle.Date
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Style = ColumnStyle.Date
                    .DisplayLayout.Bands(0).Columns("SubTotal").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("IGV").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Detraccion").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("SaldoNeto").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("TotalSoles").Style = ColumnStyle.Double

                    .DisplayLayout.Bands(0).Columns("Glosa").CellMultiLine = DefaultableBoolean.True

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                    .DisplayLayout.Override.FilterUIProvider = Filtro1

                End If

                CalcularTotales(griDocumento, "TotalSoles")

                If griDocumento.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class