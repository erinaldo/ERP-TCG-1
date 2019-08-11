Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ReporteOrdenAsignacion
    Inherits ISL.Win.frm_MenuPadre

#Region "Clase"

    Class CustomMergedCellEvaluator
        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            Dim band As Boolean = False
            Dim IdTM1, IdTM2 As String
            Dim Id1, Id2 As String
            Dim Fecha1, Fecha2 As Date
            IdTM1 = DirectCast(row1.GetCellValue("IdOA"), String)
            IdTM2 = DirectCast(row2.GetCellValue("IdOA"), String)
            If IdTM1 = IdTM2 Then
                Select Case column.Key
                    Case "Fecha"
                        Fecha1 = DirectCast(row1.GetCellValue("Fecha"), Date)
                        Fecha2 = DirectCast(row2.GetCellValue("Fecha"), Date)
                        If Fecha1 = Fecha2 Then band = True
                    Case "Estado"
                        Id1 = DirectCast(row1.GetCellValue("Estado"), String)
                        Id2 = DirectCast(row2.GetCellValue("Estado"), String)
                        If Id1 = Id2 Then band = True
                    Case "UnidadAsignada"
                        Id1 = DirectCast(row1.GetCellValue("UnidadAsignada"), String)
                        Id2 = DirectCast(row2.GetCellValue("UnidadAsignada"), String)
                        If Id1 = Id2 Then band = True
                    Case Else
                        band = True
                End Select
            End If
            Return band
        End Function
    End Class

#End Region

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteOrdenAsignacion = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteOrdenAsignacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeReporteOA As e_ReporteOA
    Dim olReporteOA As l_OrdenAsignacion
    Dim leReporteOA As List(Of e_ReporteOA)

    Dim oeMaterial As e_Material
    Dim olMaterial As l_Material
    Dim leMaterial As List(Of e_Material)

    Dim oeUnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion
    Dim olUnidadAsignacion As l_OrdenAsignacion_UnidadAsignacion
    Dim leUnidadAsignacion As List(Of e_OrdenAsignacion_UnidadAsignacion)

    Dim IdMaterial, IdUnidad As String

    Dim bandMaterial, bandUnidad As Boolean

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeReporteOA = New e_ReporteOA
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oeReporteOA.TipoOperacion = String.Empty
            oeReporteOA.FechaDesde = fecDesde.Value.Date
            oeReporteOA.FechaHasta = fecHasta.Value.Date
            CargarFiltros()
            oeReporteOA.IdMaterial = IdMaterial
            oeReporteOA.IdUnidad = IdUnidad
            leReporteOA = olReporteOA.ListarReporte(oeReporteOA)
            CargarReporteOA(leReporteOA)
            If griReporteOrdenAsignacion.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                ficDatos.Tabs(1).Enabled = False
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                ficDatos.Tabs(1).Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Exportar_Excel(griReporteOrdenAsignacion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteOrdenAsignacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griReporteOrdenAsignacion.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteOrdenAsignacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteOrdenAsignacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            fecHasta.Value = Date.Now.Date
            fecDesde.Value = DateAdd(DateInterval.Day, -7, Date.Now.Date)
            CargarCombos()
            olReporteOA = New l_OrdenAsignacion
            leReporteOA = New List(Of e_ReporteOA)
            CargarReporteOA(leReporteOA)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            ficDatos.Tabs(1).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ReporteOrdenAsignacion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griReporteOrdenAsignacion_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griReporteOrdenAsignacion.InitializeLayout
        e.Layout.Bands(0).Columns("NroOA").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Fecha").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Estado").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("UnidadAsignada").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Area").MergedCellStyle = MergedCellStyle.Always
        For Each col As UltraGridColumn In griReporteOrdenAsignacion.DisplayLayout.Bands(0).Columns
            If col.Key <> "IdOA" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
        Next
    End Sub

    Private Sub griUnidadAsignada_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griUnidadAsignada.CellChange
        griUnidadAsignada.UpdateData()
    End Sub

    Private Sub griMaterial_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMaterial.CellChange
        griMaterial.UpdateData()
    End Sub

    Private Sub griMaterial_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griMaterial.AfterHeaderCheckStateChanged
        griMaterial.UpdateData()
        Dim chkMaterial As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandMaterial = IIf(chkMaterial.ToString = "Checked", False, True)
    End Sub

    Private Sub griUnidadAsignada_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griUnidadAsignada.AfterHeaderCheckStateChanged
        griUnidadAsignada.UpdateData()
        Dim chkUnidad As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandUnidad = IIf(chkUnidad.ToString = "Checked", False, True)
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oeMaterial = New e_Material
            olMaterial = New l_Material
            oeMaterial.TipoOperacion = "G"
            oeMaterial.Activo = True
            leMaterial = olMaterial.Listar(oeMaterial)
            CargarMaterial(leMaterial)

            oeUnidadAsignacion = New e_OrdenAsignacion_UnidadAsignacion
            leUnidadAsignacion = New List(Of e_OrdenAsignacion_UnidadAsignacion)
            olUnidadAsignacion = New l_OrdenAsignacion_UnidadAsignacion
            oeUnidadAsignacion.TipoOperacion = "T"
            leUnidadAsignacion = olUnidadAsignacion.ListarTodo(oeUnidadAsignacion)
            CargarUnidadAsignada(leUnidadAsignacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMaterial(ByVal leMat As List(Of e_Material))
        Try
            With griMaterial
                .DataSource = leMat
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Seleccion" Then
                        Col.Hidden = False
                        If Col.Key = "Seleccion" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Seleccion").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 50
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarUnidadAsignada(ByVal leUnidAsignada As List(Of e_OrdenAsignacion_UnidadAsignacion))
        Try
            With griUnidadAsignada
                .ResetDisplayLayout()
                .DataSource = leUnidAsignada
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Nombre" Or Col.Key = "Selec" Then
                        Col.Hidden = False
                        If Col.Key = "Selec" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Selec").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarReporteOA(ByVal leReportOA As List(Of e_ReporteOA))
        With griReporteOrdenAsignacion
            .DataSource = leReportOA

            .DisplayLayout.Bands(0).Columns("IdOA").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMat").Hidden = True

            '.DisplayLayout.Bands(0).Columns("NroOT").Header.VisiblePosition = 0
            '.DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.VisiblePosition = 1
            '.DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 2
            '.DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 3
            '.DisplayLayout.Bands(0).Columns("Placa").Header.VisiblePosition = 4
            '.DisplayLayout.Bands(0).Columns("TipoMantenimiento").Header.VisiblePosition = 5
            '.DisplayLayout.Bands(0).Columns("Mantenimiento").Header.VisiblePosition = 6
            '.DisplayLayout.Bands(0).Columns("Servicio").Header.VisiblePosition = 7
            '.DisplayLayout.Bands(0).Columns("Proveedor").Header.VisiblePosition = 8
            '.DisplayLayout.Bands(0).Columns("CostoOTS").Header.VisiblePosition = 9

            .DisplayLayout.Bands(0).Columns("NroOA").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Fecha").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Estado").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("UnidadAsignada").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Area").CellAppearance.TextVAlign = VAlign.Middle
            '.DisplayLayout.Bands(0).Columns("FechaProgramacion").CellAppearance.TextVAlign = VAlign.Middle
            '.DisplayLayout.Bands(0).Columns("FechaInicioTrabajo").CellAppearance.TextVAlign = VAlign.Middle
            '.DisplayLayout.Bands(0).Columns("Estado").CellAppearance.TextVAlign = VAlign.Middle
            '.DisplayLayout.Bands(0).Columns("CodigoMat").CellAppearance.TextVAlign = VAlign.Middle
            '.DisplayLayout.Bands(0).Columns("Material").CellAppearance.TextVAlign = VAlign.Middle

            .DisplayLayout.Bands(0).Columns("Fecha").Width = 60
            .DisplayLayout.Bands(0).Columns("Estado").Width = 80
            .DisplayLayout.Bands(0).Columns("UnidadAsignada").Width = 200
            .DisplayLayout.Bands(0).Columns("Material").Width = 200
            .DisplayLayout.Bands(0).Columns("Area").Width = 180
            '.DisplayLayout.Bands(0).Columns("Equipo").Width = 60
            '.DisplayLayout.Bands(0).Columns("CodigoMat").Width = 60
            '.DisplayLayout.Bands(0).Columns("Material").Width = 250
            '.DisplayLayout.Bands(0).Columns("Proveedor").Width = 150

            .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.Caption = "Unid. Med."
            .DisplayLayout.Bands(0).Columns("CantPedida").Header.Caption = "Cant. Pedido"
            .DisplayLayout.Bands(0).Columns("CantEntregada").Header.Caption = "Cant. Entregado"
            '.DisplayLayout.Bands(0).Columns("CantidadMat").Header.Caption = "Cant. Pedido"
            '.DisplayLayout.Bands(0).Columns("CantidadReal").Header.Caption = "Cant. Entregado"

            .DisplayLayout.Bands(0).Columns("CantPedida").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("CantEntregada").Style = ColumnStyle.Double

            .DisplayLayout.Bands(0).Columns("CantPedida").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("CantEntregada").CellAppearance.TextHAlign = HAlign.Right

            '.DisplayLayout.UseFixedHeaders = True
            '.DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
            '.DisplayLayout.Bands(0).Columns("NroOT").Header.Fixed = True
            '.DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Fixed = True
            '.DisplayLayout.Bands(0).Columns("Estado").Header.Fixed = True
            '.DisplayLayout.Bands(0).Columns("Marca").Header.Fixed = True
            '.DisplayLayout.Bands(0).Columns("Placa").Header.Fixed = True


            .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
            .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
            .DisplayLayout.Override.FilterUIProvider = Filtro1
            .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.MaxColScrollRegions = 1
            .DisplayLayout.MaxRowScrollRegions = 1
        End With
        CalcularTotales(griReporteOrdenAsignacion, "Importe")
    End Sub

    Private Sub CargarFiltros()
        IdMaterial = ""
        If bandMaterial Then
            For Each Fila In griMaterial.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value = True)
                IdMaterial = IdMaterial & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdMaterial.Trim <> "" Then IdMaterial = IdMaterial.Substring(0, IdMaterial.Length - 1)
        End If
        IdUnidad = ""
        If bandUnidad Then
            For Each Fila In griUnidadAsignada.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Selec").Value = True)
                IdUnidad = IdUnidad & "'" & Fila.Cells("IndUnidadAsignacion").Value & Fila.Cells("IdUnidadAsignacion").Value & "',"
            Next
            If IdUnidad.Trim <> "" Then IdUnidad = IdUnidad.Substring(0, IdUnidad.Length - 1)
        End If
    End Sub

#End Region

End Class