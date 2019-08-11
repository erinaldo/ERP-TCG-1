Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles
Imports Infragistics.UltraChart.Resources.Appearance
Imports Infragistics.UltraChart.Core.Layers

Public Class frm_ReporteConsumoEquipo
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteConsumoEquipo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteConsumoEquipo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim leCentro As New List(Of e_Centro)

    Dim oeAlmacen As New e_Almacen
    Dim olAlmacen As New l_Almacen
    Dim leAlmacen As New List(Of e_Almacen)
    Dim leAlmacenAux As New List(Of e_Almacen)

    Dim oeReporteCE As New e_ReporteConsumoEquipo
    Dim olReporteCE As New l_OrdenTrabajo
    Dim leReporteCE As New List(Of e_ReporteConsumoEquipo)
    Dim leRCEAnual As New List(Of e_ReporteConsumoEquipo)
    Dim leEquipoAnual As New List(Of e_ReporteConsumoEquipo)
    Dim leMaterialAnual As New List(Of e_ReporteConsumoEquipo)

    Dim oeOTMaterial As New e_ReporteOTMaterial
    Dim olOTMaterial As New l_OrdenTrabajoMaterial
    Dim leOTMaerial As New List(Of e_ReporteOTMaterial)

    Dim oeOTServicio As New e_ReporteOTServicio
    Dim olOTservicio As New l_OrdenTrabajo_Servicio
    Dim leOTServicio As New List(Of e_ReporteOTServicio)

    Dim oeOAsignacion As New e_ReporteOA
    Dim olOAsignacion As New l_OrdenAsignacion
    Dim leOAsignacion As New List(Of e_ReporteOA)

    Dim IdAlmacen, IdEquipo, IndUnidad, Material, EstDetalle, Equipo As String
    Dim dtMaterial As New DataTable()

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            oeReporteCE = New e_ReporteConsumoEquipo
            oeReporteCE.TipoOperacion = String.Empty
            oeReporteCE.Anio = fecPeriodo.Value.Year
            oeReporteCE.Mes = FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
            Select Case optEquipo.CheckedIndex
                Case 0 : oeReporteCE.Indicador = ""
                Case 1 : oeReporteCE.Indicador = "V"
                Case 2 : oeReporteCE.Indicador = "T"
                Case 3 : oeReporteCE.Indicador = "A"
            End Select
            CargarFiltros()
            oeReporteCE.IdAlmacen = IdAlmacen
            leReporteCE = olReporteCE.ListarReporteCE(oeReporteCE)
            oeReporteCE.TipoOperacion = "A"
            leRCEAnual = olReporteCE.ListarReporteCE(oeReporteCE)
            CargarReporteCE(leReporteCE)
            CreaGrafico_General()
            If griConsumo.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
            ficGrafico.SelectedTab = ficGrafico.Tabs(0)
            ficGrafico.Tabs(1).Enabled = False
            ficGrafico.Tabs(2).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griConsumo.Rows.Count > 0 Then Exportar_Excel(griConsumo)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteConsumoEquipo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub frm_ReporteConsumoEquipo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteConsumoEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            optEquipo.CheckedIndex = 0
            CargarCombo()
            leReporteCE = New List(Of e_ReporteConsumoEquipo)
            CargarReporteCE(leReporteCE)
            ficGrafico.SelectedTab = ficGrafico.Tabs(0)
            ficGrafico.Tabs(1).Enabled = False
            ficGrafico.Tabs(2).Enabled = False
            graGeneral.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        If cboCentro.SelectedIndex > -1 Then
            Try
                leAlmacenAux = New List(Of e_Almacen)
                leAlmacenAux = leAlmacen.Where(Function(item) item.IdCentro = cboCentro.Value).ToList
                CargarAlmacen(leAlmacenAux)
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        End If
    End Sub

    Private Sub griAlmacenes_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAlmacenes.CellChange
        griAlmacenes.UpdateData()
    End Sub

    Private Sub griAlmacenes_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griAlmacenes.AfterHeaderCheckStateChanged
        griAlmacenes.UpdateData()
    End Sub

    Private Sub griConsumo_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles griConsumo.DoubleClickCell
        Try
            If griConsumo.Rows.Count > 0 Then
                If griConsumo.ActiveRow.Index > -1 Then
                    Select e.Cell.Column.Key.ToString
                        Case "CostoMaterial"
                            EstDetalle = "CM"
                            oeOTMaterial = New e_ReporteOTMaterial
                            oeOTMaterial.TipoOperacion = "L"
                            oeOTMaterial.FechaInicio = fecPeriodo.Value
                            IdEquipo = griConsumo.ActiveRow.Cells("Id").Value
                            Equipo = griConsumo.ActiveRow.Cells("Nombre").Value
                            IndUnidad = griConsumo.ActiveRow.Cells("Indicador").Value
                            oeOTMaterial.IdEquipo = griConsumo.ActiveRow.Cells("Id").Value
                            oeOTMaterial.IdAlmacen = IdAlmacen
                            leOTMaerial = olOTMaterial.ListarReporte(oeOTMaterial)
                            CargarOTMaterial(leOTMaerial)
                            oeReporteCE = New e_ReporteConsumoEquipo
                            oeReporteCE.TipoOperacion = "A"
                            oeReporteCE.Id = griConsumo.ActiveRow.Cells("Id").Value
                            oeReporteCE.Indicador = griConsumo.ActiveRow.Cells("Indicador").Value
                            oeReporteCE.IdAlmacen = IdAlmacen
                            oeReporteCE.Anio = fecPeriodo.Value.Year.ToString
                            leEquipoAnual = olReporteCE.ListarReporteCE(oeReporteCE)
                            CreaGrafico_Equipo()
                        Case "CostoServicio"
                            EstDetalle = "CS"
                            oeOTServicio = New e_ReporteOTServicio
                            oeOTServicio.TipoOperacion = "L"
                            oeOTServicio.FechaInicio = fecPeriodo.Value
                            IdEquipo = griConsumo.ActiveRow.Cells("Id").Value
                            Equipo = griConsumo.ActiveRow.Cells("Nombre").Value
                            IndUnidad = griConsumo.ActiveRow.Cells("Indicador").Value
                            oeOTServicio.IdEquipo = griConsumo.ActiveRow.Cells("Id").Value
                            leOTServicio = olOTservicio.ListarReporte(oeOTServicio)
                            CargarOTServicio(leOTServicio)
                            oeReporteCE = New e_ReporteConsumoEquipo
                            oeReporteCE.TipoOperacion = "A"
                            oeReporteCE.Id = griConsumo.ActiveRow.Cells("Id").Value
                            oeReporteCE.Indicador = griConsumo.ActiveRow.Cells("Indicador").Value
                            oeReporteCE.IdAlmacen = IdAlmacen
                            oeReporteCE.Anio = fecPeriodo.Value.Year.ToString
                            leEquipoAnual = olReporteCE.ListarReporteCE(oeReporteCE)
                            CreaGrafico_Equipo()
                        Case "CostoAsignacion"
                            EstDetalle = "CA"
                            oeOAsignacion = New e_ReporteOA
                            oeOAsignacion.TipoOperacion = "L"
                            oeOAsignacion.FechaDesde = fecPeriodo.Value
                            oeOAsignacion.IdAlmacen = IdAlmacen
                            IdEquipo = griConsumo.ActiveRow.Cells("Id").Value
                            Equipo = griConsumo.ActiveRow.Cells("Nombre").Value
                            IndUnidad = griConsumo.ActiveRow.Cells("Indicador").Value
                            oeOAsignacion.IdUnidad = griConsumo.ActiveRow.Cells("Indicador").Value & griConsumo.ActiveRow.Cells("Id").Value
                            leOAsignacion = olOAsignacion.ListarReporte(oeOAsignacion)
                            CargarOAsignacion(leOAsignacion)
                            oeReporteCE = New e_ReporteConsumoEquipo
                            oeReporteCE.TipoOperacion = "A"
                            oeReporteCE.Id = griConsumo.ActiveRow.Cells("Id").Value
                            oeReporteCE.Indicador = griConsumo.ActiveRow.Cells("Indicador").Value
                            oeReporteCE.IdAlmacen = IdAlmacen
                            oeReporteCE.Anio = fecPeriodo.Value.Year.ToString
                            leEquipoAnual = olReporteCE.ListarReporteCE(oeReporteCE)
                            CreaGrafico_Equipo()
                    End Select
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalle_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles griDetalle.DoubleClickCell
        Try
            If griDetalle.Rows.Count > 0 Then
                If griDetalle.ActiveRow.Index > -1 Then
                    Select Case EstDetalle
                        Case "CM"
                            oeReporteCE = New e_ReporteConsumoEquipo
                            oeReporteCE.TipoOperacion = "M"
                            oeReporteCE.IdAlmacen = IdAlmacen
                            oeReporteCE.IdMaterial = griDetalle.ActiveRow.Cells("IdMat").Value
                            Material = "MATERIAL: " & griDetalle.ActiveRow.Cells("Material").Value
                            oeReporteCE.Anio = fecPeriodo.Value.Year
                            oeReporteCE.Id = IdEquipo
                            oeReporteCE.Indicador = IndUnidad
                            leMaterialAnual = olReporteCE.ListarReporteCE(oeReporteCE)
                            CreaGrafico_Material()
                        Case "CS"
                            oeReporteCE = New e_ReporteConsumoEquipo
                            oeReporteCE.TipoOperacion = "S"
                            oeReporteCE.IdAlmacen = IdAlmacen
                            oeReporteCE.IdMaterial = griDetalle.ActiveRow.Cells("IdServ").Value
                            Material = "SERVICIO: " & griDetalle.ActiveRow.Cells("Servicio").Value
                            oeReporteCE.Anio = fecPeriodo.Value.Year
                            oeReporteCE.Id = IdEquipo
                            oeReporteCE.Indicador = IndUnidad
                            leMaterialAnual = olReporteCE.ListarReporteCE(oeReporteCE)
                            CreaGrafico_Material()
                        Case "CA"
                            oeReporteCE = New e_ReporteConsumoEquipo
                            oeReporteCE.TipoOperacion = "N"
                            oeReporteCE.IdAlmacen = IdAlmacen
                            oeReporteCE.IdMaterial = griDetalle.ActiveRow.Cells("IdMat").Value
                            Material = "MATERIAL: " & griDetalle.ActiveRow.Cells("Material").Value
                            oeReporteCE.Anio = fecPeriodo.Value.Year
                            oeReporteCE.Id = IdEquipo
                            oeReporteCE.Indicador = IndUnidad
                            leMaterialAnual = olReporteCE.ListarReporteCE(oeReporteCE)
                            CreaGrafico_Material()
                    End Select
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombo()
        Try

            oeAlmacen = New e_Almacen
            oeAlmacen.TipoOperacion = String.Empty
            oeAlmacen.Activo = True
            leAlmacen = olAlmacen.Listar(oeAlmacen)

            oeCentro = New e_Centro
            oeCentro.TipoOperacion = "O"
            leCentro = olCentro.Listar(oeCentro)
            LlenarCombo(cboCentro, "Nombre", leCentro, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAlmacen(ByVal leAlm As List(Of e_Almacen))
        Try
            With griAlmacenes
                .DataSource = leAlm
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
                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 50
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 55
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
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

    Private Sub CargarReporteCE(ByVal leRepCE As List(Of e_ReporteConsumoEquipo))
        Try
            With griConsumo
                Dim leAux As New List(Of e_ReporteConsumoEquipo)
                leAux = leRepCE.OrderBy(Function(item) item.Indicador & item.Nombre).ToList
                .DataSource = leAux
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Indicador").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("CostoMaterial").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("CostoServicio").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("CostoAsignacion").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("CostoTotal").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("CostoMaterial").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("CostoServicio").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("CostoAsignacion").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("CostoTotal").CellAppearance.TextHAlign = HAlign.Right
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
            CalcularTotales(griConsumo, "CostoMaterial", "CostoServicio", "CostoAsignacion", "CostoTotal")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFiltros()
        Try
            IdAlmacen = ""
            For Each Fila In griAlmacenes.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value = True)
                IdAlmacen = IdAlmacen & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdAlmacen.Trim <> "" Then
                IdAlmacen = IdAlmacen.Substring(0, IdAlmacen.Length - 1)
            Else
                Throw New Exception("Seleccione al menos un Almacén")
            End If
        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Private Sub CargarOTMaterial(ByVal leOTM As List(Of e_ReporteOTMaterial))
        With griDetalle

            .ResetDisplayLayout()
            .DataSource = leOTM

            .DisplayLayout.Bands(0).Columns("IdTipoMant").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMat").Hidden = True
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Hidden = True
            .DisplayLayout.Bands(0).Columns("Mantenimiento").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaInicioTrabajo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
            .DisplayLayout.Bands(0).Columns("Equipo").Hidden = True

            .DisplayLayout.Bands(0).Columns("NroOT").Header.VisiblePosition = 0
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("CodigoMat").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("Material").Header.VisiblePosition = 4
            .DisplayLayout.Bands(0).Columns("CantidadMat").Header.VisiblePosition = 5
            .DisplayLayout.Bands(0).Columns("CantidadReal").Header.VisiblePosition = 6
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.VisiblePosition = 7
            .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 8


            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Width = 80
            .DisplayLayout.Bands(0).Columns("Mantenimiento").Width = 200
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Width = 60
            .DisplayLayout.Bands(0).Columns("FechaInicioTrabajo").Width = 60
            .DisplayLayout.Bands(0).Columns("Equipo").Width = 60
            .DisplayLayout.Bands(0).Columns("CodigoMat").Width = 60
            .DisplayLayout.Bands(0).Columns("Material").Width = 250
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Width = 50

            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Caption = "Fecha Prog."
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Header.Caption = "Tipo Mant."
            .DisplayLayout.Bands(0).Columns("CantidadMat").Header.Caption = "Cant. Pedido"
            .DisplayLayout.Bands(0).Columns("CantidadReal").Header.Caption = "Cant. Entreg."
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "P.U."

            .DisplayLayout.Bands(0).Columns("CantidadMat").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("CantidadReal").Style = ColumnStyle.Double

            .DisplayLayout.Bands(0).Columns("CantidadMat").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("CantidadReal").CellAppearance.TextHAlign = HAlign.Right

            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.BackColor = Color.LightBlue

            .Text = "CONSUMO DE ORDEN DE TRABAJO POR MATERIAL DE EQUIPO: " & Equipo

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
        CalcularTotales(griDetalle, "Importe")
    End Sub

    Private Sub CargarOTServicio(ByVal leOTS As List(Of e_ReporteOTServicio))
        With griDetalle

            .ResetDisplayLayout()
            .DataSource = leOTS

            .DisplayLayout.Bands(0).Columns("IdOT").Hidden = True
            .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Hidden = True
            .DisplayLayout.Bands(0).Columns("Mantenimiento").Hidden = True
            .DisplayLayout.Bands(0).Columns("Marca").Hidden = True
            .DisplayLayout.Bands(0).Columns("Placa").Hidden = True
            .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = True
            .DisplayLayout.Bands(0).Columns("Total").Hidden = True
            .DisplayLayout.Bands(0).Columns("Cantidad").Hidden = True
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdServ").Hidden = True

            .DisplayLayout.Bands(0).Columns("NroOT").Header.VisiblePosition = 0
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Servicio").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Proveedor").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("CostoOTS").Header.VisiblePosition = 4

            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Width = 60
            .DisplayLayout.Bands(0).Columns("Servicio").Width = 150
            .DisplayLayout.Bands(0).Columns("Proveedor").Width = 150

            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Caption = "Fecha Prog."

            .DisplayLayout.Bands(0).Columns("CostoOTS").Style = ColumnStyle.Double

            .DisplayLayout.Bands(0).Columns("CostoOTS").CellAppearance.TextHAlign = HAlign.Right

            .DisplayLayout.UseFixedHeaders = True
            .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
            .DisplayLayout.Bands(0).Columns("NroOT").Header.Fixed = True
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Fixed = True

            .Text = "CONSUMO DE ORDEN DE TRABAJO POR SERVICIO DE EQUIPO: " & Equipo

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

        CalcularTotales(griDetalle, "CostoOTS")

    End Sub

    Private Sub CargarOAsignacion(ByVal leOA As List(Of e_ReporteOA))
        With griDetalle
            .ResetDisplayLayout()
            .DataSource = leOA

            .DisplayLayout.Bands(0).Columns("IdOA").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
            .DisplayLayout.Bands(0).Columns("UnidadAsignada").Hidden = True
            .DisplayLayout.Bands(0).Columns("UnidadMedida").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMat").Hidden = True

            .DisplayLayout.Bands(0).Columns("NroOA").Header.VisiblePosition = 0
            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("CodMat").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Material").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("CantPedida").Header.VisiblePosition = 4
            .DisplayLayout.Bands(0).Columns("CantEntregada").Header.VisiblePosition = 5
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.VisiblePosition = 6
            .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 7
            '.DisplayLayout.Bands(0).Columns("Proveedor").Header.VisiblePosition = 8
            '.DisplayLayout.Bands(0).Columns("CostoOTS").Header.VisiblePosition = 9


            .DisplayLayout.Bands(0).Columns("Fecha").Width = 60
            .DisplayLayout.Bands(0).Columns("Material").Width = 200
            .DisplayLayout.Bands(0).Columns("CodMat").Width = 60

            .DisplayLayout.Bands(0).Columns("CantPedida").Header.Caption = "Cant. Pedido"
            .DisplayLayout.Bands(0).Columns("CantEntregada").Header.Caption = "Cant. Entregado"

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

            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.BackColor = Color.LightBlue

            .Text = "CONSUMO DE ORDEN DE TRABAJO POR ASIGANCION DE EQUIPO: " & Equipo

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
        CalcularTotales(griDetalle, "Importe")
    End Sub

    Private Sub CreaGrafico_General()

        Try

            graGeneral.Visible = True

            'Dim graTipo As New ChartType
            'graTipo = ChartType.Composite

            Me.graGeneral.ChartType = ChartType.Composite

            Me.graGeneral.CompositeChart.ChartLayers.Clear()

            Dim myChartArea As New ChartArea()
            Me.graGeneral.CompositeChart.ChartAreas.Add(myChartArea)

            Dim axisX As New AxisItem()
            axisX.OrientationType = AxisNumber.X_Axis
            axisX.DataType = AxisDataType.String
            axisX.SetLabelAxisType = SetLabelAxisType.GroupBySeries
            axisX.Labels.Visible = False
            'axisX.Labels.ItemFormatString = "<ITEM_LABEL>"
            'axisX.Labels.Orientation = TextOrientation.VerticalLeftFacing
            Dim axisY As New AxisItem()
            axisY.OrientationType = AxisNumber.Y_Axis
            axisY.DataType = AxisDataType.Numeric
            axisY.Labels.ItemFormatString = "S/. " & "<DATA_VALUE:#,##0.0#>"
            myChartArea.Axes.Add(axisX)
            myChartArea.Axes.Add(axisY)

            Dim myColumnLayer As New ChartLayerAppearance()
            myColumnLayer.ChartType = ChartType.ColumnChart
            myColumnLayer.ChartArea = myChartArea
            myColumnLayer.AxisX = axisX
            myColumnLayer.AxisY = axisY

            Dim leGraGeneral As New List(Of e_ReporteConsumoEquipo)
            leGraGeneral = leRCEAnual.OrderBy(Function(item) CInt(item.Id)).ToList

            For Each oeGraGeneral In leGraGeneral
                Dim series As New NumericSeries()
                series.Label = MonthName(CInt(oeGraGeneral.Id), True).ToUpper
                ' this code populates the series using unbound data
                series.Points.Add(New NumericDataPoint(oeGraGeneral.CostoMaterial, "Costo Material", False))
                series.Points.Add(New NumericDataPoint(oeGraGeneral.CostoServicio, "Costo Servicio", False))
                series.Points.Add(New NumericDataPoint(oeGraGeneral.CostoAsignacion, "Costo Asignacion", False))
                Me.graGeneral.CompositeChart.Series.Add(series)
                myColumnLayer.Series.Add(series)
            Next

            'Agregar Base Cero
            Dim serieszero As New NumericSeries()
            serieszero.Label = ""
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            Me.graGeneral.CompositeChart.Series.Add(serieszero)
            myColumnLayer.Series.Add(serieszero)

            Me.graGeneral.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            Me.graGeneral.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            Me.graGeneral.Tooltips.FormatString = "<ITEM_LABEL>: " & Environment.NewLine & "S/. <DATA_VALUE:#,###,##0.00>"

            Me.graGeneral.CompositeChart.ChartLayers.Add(myColumnLayer)
            Me.graGeneral.ColorModel.ModelStyle = ColorModels.CustomLinear

            Dim myLegend As New CompositeLegend()
            myLegend.ChartLayers.Add(myColumnLayer)
            myLegend.Bounds = New Rectangle(0, 75, 20, 25)
            myLegend.BoundsMeasureType = MeasureType.Percentage
            myLegend.PE.ElementType = PaintElementType.Gradient
            myLegend.PE.FillGradientStyle = 5
            myLegend.PE.Fill = Color.Transparent
            myLegend.PE.FillStopColor = Color.Transparent
            myLegend.Border.CornerRadius = 10
            myLegend.Border.Thickness = 0
            Me.graGeneral.CompositeChart.Legends.Add(myLegend)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CreaGrafico_Equipo()
        Try

            ficGrafico.Tabs(1).Enabled = True
            ficGrafico.SelectedTab = ficGrafico.Tabs(1)

            graEquipo.Visible = True

            Me.graEquipo.ChartType = ChartType.Composite

            Me.graEquipo.CompositeChart.ChartLayers.Clear()

            Dim myChartArea As New ChartArea()
            Me.graEquipo.CompositeChart.ChartAreas.Add(myChartArea)

            Dim axisX As New AxisItem()
            axisX.OrientationType = AxisNumber.X_Axis
            axisX.DataType = AxisDataType.String
            axisX.SetLabelAxisType = SetLabelAxisType.GroupBySeries
            axisX.Labels.Visible = False
            Dim axisY As New AxisItem()
            axisY.OrientationType = AxisNumber.Y_Axis
            axisY.DataType = AxisDataType.Numeric
            axisY.Labels.ItemFormatString = "S/. " & "<DATA_VALUE:#,##0.0#>"
            myChartArea.Axes.Add(axisX)
            myChartArea.Axes.Add(axisY)

            Dim myColumnLayer As New ChartLayerAppearance()
            myColumnLayer.ChartType = ChartType.ColumnChart
            myColumnLayer.ChartArea = myChartArea
            myColumnLayer.AxisX = axisX
            myColumnLayer.AxisY = axisY

            Dim leGraEquipo As New List(Of e_ReporteConsumoEquipo)
            leGraEquipo = leEquipoAnual.OrderBy(Function(item) CInt(item.Id)).ToList

            For Each oeGraEquipo In DevuelveLista(leGraEquipo)
                Dim series As New NumericSeries()
                series.Label = MonthName(CInt(oeGraEquipo.Id), True).ToUpper
                series.Points.Add(New NumericDataPoint(oeGraEquipo.CostoMaterial, "Costo Material", False))
                series.Points.Add(New NumericDataPoint(oeGraEquipo.CostoServicio, "Costo Servicio", False))
                series.Points.Add(New NumericDataPoint(oeGraEquipo.CostoAsignacion, "Costo Asignacion", False))
                Me.graEquipo.CompositeChart.Series.Add(series)
                myColumnLayer.Series.Add(series)
            Next

            'Agregar Base Cero
            Dim serieszero As New NumericSeries()
            serieszero.Label = ""
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            Me.graEquipo.CompositeChart.Series.Add(serieszero)
            myColumnLayer.Series.Add(serieszero)

            Me.graEquipo.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            Me.graEquipo.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            Me.graEquipo.Tooltips.FormatString = "<ITEM_LABEL>: " & Environment.NewLine & "S/. <DATA_VALUE:#,###,##0.00>"

            Me.graEquipo.TitleTop.Font = New Font("Arial", 10, FontStyle.Bold)
            Me.graEquipo.TitleTop.HorizontalAlign = StringAlignment.Center
            Me.graEquipo.TitleTop.Text = Equipo

            Me.graEquipo.CompositeChart.ChartLayers.Add(myColumnLayer)
            Me.graEquipo.ColorModel.ModelStyle = ColorModels.CustomLinear

            Dim myLegend As New CompositeLegend()
            myLegend.ChartLayers.Add(myColumnLayer)
            myLegend.Bounds = New Rectangle(0, 75, 20, 25)
            myLegend.BoundsMeasureType = MeasureType.Percentage
            myLegend.PE.ElementType = PaintElementType.Gradient
            myLegend.PE.FillGradientStyle = 5
            myLegend.PE.Fill = Color.Transparent
            myLegend.PE.FillStopColor = Color.Transparent
            myLegend.Border.CornerRadius = 10
            myLegend.Border.Thickness = 0
            Me.graEquipo.CompositeChart.Legends.Add(myLegend)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function DevuelveLista(ByVal le As List(Of e_ReporteConsumoEquipo), Optional ByVal band As Boolean = False) As List(Of e_ReporteConsumoEquipo)
        Try
            Dim objEquConsu As New e_ReporteConsumoEquipo
            Dim leAux As New List(Of e_ReporteConsumoEquipo)
            Dim lx As New List(Of e_ReporteConsumoEquipo)
            Dim nmes As Integer = 0
            If le.Count > 0 Then
                Dim nromes As Integer = 0
                nromes = le(le.Count - 1).Id
                If fecPeriodo.Value.Month > nromes Then
                    nromes = fecPeriodo.Value.Month
                End If
                For x As Integer = 0 To nromes - 1
                    nmes = x + 1
                    If band Then dtMaterial.Columns.Add(MonthName(nmes, True).ToUpper, System.Type.GetType("System.Double"))
                    objEquConsu = New e_ReporteConsumoEquipo
                    lx = New List(Of e_ReporteConsumoEquipo)
                    lx = le.Where(Function(item) CInt(item.Id) = nmes).ToList
                    If lx.Count > 0 Then
                        objEquConsu.Id = lx(0).Id
                        objEquConsu.CostoMaterial = lx(0).CostoMaterial
                        objEquConsu.CostoServicio = lx(0).CostoServicio
                        objEquConsu.CostoAsignacion = lx(0).CostoAsignacion
                    Else
                        objEquConsu.Id = nmes
                        objEquConsu.CostoMaterial = 0
                        objEquConsu.CostoServicio = 0
                        objEquConsu.CostoAsignacion = 0
                    End If
                    leAux.Add(objEquConsu)
                Next
            End If
            Return leAux
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CreaGrafico_Material()
        Try

            ficGrafico.Tabs(2).Enabled = True
            ficGrafico.SelectedTab = ficGrafico.Tabs(2)

            graMatServ.Visible = True

            Dim leGraMaterial As New List(Of e_ReporteConsumoEquipo)
            Dim leGraMatAux As New List(Of e_ReporteConsumoEquipo)
            leGraMaterial = leMaterialAnual.OrderBy(Function(item) CInt(item.Id)).ToList

            dtMaterial = New DataTable
            dtMaterial.Columns.Add("Material", System.Type.GetType("System.String"))

            leGraMatAux = DevuelveLista(leGraMaterial, True)

            Dim Fila As DataRow

            Fila = dtMaterial.NewRow
            Fila(0) = Material

            For Each oeGraMaterial In leGraMatAux
                Select Case EstDetalle
                    Case "CM"
                        Fila(CInt(oeGraMaterial.Id)) = oeGraMaterial.CostoMaterial
                    Case "CS"
                        Fila(CInt(oeGraMaterial.Id)) = oeGraMaterial.CostoServicio
                    Case "CA"
                        Fila(CInt(oeGraMaterial.Id)) = oeGraMaterial.CostoAsignacion
                End Select

            Next

            dtMaterial.Rows.Add(Fila)

            graMatServ.ChartType = ChartType.LineChart
            graMatServ.ColorModel.ModelStyle = ColorModels.CustomLinear

            graMatServ.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:#,##0.0#>"
            graMatServ.Axis.X.Labels.Orientation = TextOrientation.Horizontal

            Me.graMatServ.TitleTop.Font = New Font("Arial", 10, FontStyle.Bold)
            Me.graMatServ.TitleTop.HorizontalAlign = StringAlignment.Center
            Me.graMatServ.TitleTop.Text = Material

            Me.graMatServ.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            Me.graMatServ.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            Me.graMatServ.Tooltips.FormatString = "<ITEM_LABEL>: " & Environment.NewLine & "<DATA_VALUE:#,###,##0.00>"

            graMatServ.Data.ZeroAligned = True
            graMatServ.Data.DataSource = dtMaterial
            graMatServ.Data.DataBind()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class