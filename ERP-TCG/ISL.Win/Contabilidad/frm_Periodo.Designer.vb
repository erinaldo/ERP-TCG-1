<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Periodo
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreCompras")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreCajaLiquidacion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierraVentas")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreAlmacen")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreTesoreria")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreContabilidad")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierrePlanilla")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CambioCompra")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CambioVenta")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreCombustible")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCierre")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierreCompras")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierreCajaLiquidacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierraVentas")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierreAlmacen")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierreTesoreria")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierreContabilidad")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierrePlanilla")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CambioCompra")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CambioVenta")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CierreCombustible")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCierre")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_ListaPeriodo = New ISL.Controles.Grilla(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odPeriodo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.nroEjercicioBusca = New ISL.Win.Año()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.nroMes = New ISL.Win.Mes()
        Me.nroEjercicio = New ISL.Win.Año()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFin = New ISL.Controles.Fecha(Me.components)
        Me.fecInicio = New ISL.Controles.Fecha(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.verPlanillas = New ISL.Controles.Chequear(Me.components)
        Me.verCajaLiquidacion = New ISL.Controles.Chequear(Me.components)
        Me.VerCombustible = New ISL.Controles.Chequear(Me.components)
        Me.verVentas = New ISL.Controles.Chequear(Me.components)
        Me.verCompras = New ISL.Controles.Chequear(Me.components)
        Me.VerAlmacen = New ISL.Controles.Chequear(Me.components)
        Me.verContabilidad = New ISL.Controles.Chequear(Me.components)
        Me.verTesoreria = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.decTCVenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTCCompra = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.tcEjercicio = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.timTiempo = New ISL.Controles.Tiempo(Me.components)
        Me.Filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_ListaPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.odPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.fecFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.verPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCajaLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTesoreria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.decTCVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTCCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEjercicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_ListaPeriodo)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1017, 342)
        '
        'grid_ListaPeriodo
        '
        Me.grid_ListaPeriodo.ContextMenuStrip = Me.MenuDetalle
        Me.grid_ListaPeriodo.DataSource = Me.odPeriodo
        Appearance1.TextHAlignAsString = "Left"
        Me.grid_ListaPeriodo.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "Ejercicio"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 92
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 62
        UltraGridColumn5.Header.Caption = "Fecha Inicio"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "Fecha Fin"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn14.Header.VisiblePosition = 12
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 15
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 16
        UltraGridColumn19.Header.VisiblePosition = 17
        UltraGridColumn19.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        Me.grid_ListaPeriodo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_ListaPeriodo.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ListaPeriodo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaPeriodo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_ListaPeriodo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListaPeriodo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListaPeriodo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListaPeriodo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListaPeriodo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_ListaPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListaPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListaPeriodo.Location = New System.Drawing.Point(0, 56)
        Me.grid_ListaPeriodo.Name = "grid_ListaPeriodo"
        Me.grid_ListaPeriodo.Size = New System.Drawing.Size(1017, 286)
        Me.grid_ListaPeriodo.TabIndex = 1
        Me.grid_ListaPeriodo.Text = "Información de los periodos"
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.mnuEliminar})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(122, 82)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(121, 26)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'odPeriodo
        '
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataColumn18.DataType = GetType(Boolean)
        Me.odPeriodo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.nroEjercicioBusca)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1017, 56)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.Text = "Busqueda"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance2
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 26)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Ejercicio:"
        '
        'nroEjercicioBusca
        '
        Me.nroEjercicioBusca.Año = 2016
        Me.nroEjercicioBusca.Location = New System.Drawing.Point(58, 23)
        Me.nroEjercicioBusca.Name = "nroEjercicioBusca"
        Me.nroEjercicioBusca.Size = New System.Drawing.Size(54, 23)
        Me.nroEjercicioBusca.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1017, 342)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.nroMes)
        Me.Agrupacion2.Controls.Add(Me.nroEjercicio)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion2.Controls.Add(Me.fecFin)
        Me.Agrupacion2.Controls.Add(Me.fecInicio)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion2.Controls.Add(Me.verActivo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.txtCodigo)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1017, 128)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'nroMes
        '
        Me.nroMes.Location = New System.Drawing.Point(68, 70)
        Me.nroMes.Mes = 3
        Me.nroMes.Name = "nroMes"
        Me.nroMes.Size = New System.Drawing.Size(41, 23)
        Me.nroMes.TabIndex = 26
        '
        'nroEjercicio
        '
        Me.nroEjercicio.Año = 2016
        Me.nroEjercicio.Location = New System.Drawing.Point(68, 45)
        Me.nroEjercicio.Name = "nroEjercicio"
        Me.nroEjercicio.Size = New System.Drawing.Size(54, 23)
        Me.nroEjercicio.TabIndex = 25
        '
        'Etiqueta4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance3
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(6, 73)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta4.TabIndex = 24
        Me.Etiqueta4.Text = "Mes:"
        '
        'Etiqueta3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance4
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(6, 47)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta3.TabIndex = 23
        Me.Etiqueta3.Text = "Ejercicio:"
        '
        'Etiqueta8
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance5
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(208, 103)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(24, 14)
        Me.Etiqueta8.TabIndex = 22
        Me.Etiqueta8.Text = "Fin:"
        '
        'Etiqueta7
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance6
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(6, 101)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta7.TabIndex = 21
        Me.Etiqueta7.Text = "Inicio:"
        '
        'fecFin
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.fecFin.Appearance = Appearance7
        Me.fecFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFin.ForeColor = System.Drawing.Color.Black
        Me.fecFin.Location = New System.Drawing.Point(237, 100)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(106, 21)
        Me.fecFin.TabIndex = 20
        '
        'fecInicio
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.fecInicio.Appearance = Appearance8
        Me.fecInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecInicio.ForeColor = System.Drawing.Color.Black
        Me.fecInicio.Location = New System.Drawing.Point(68, 99)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(111, 21)
        Me.fecInicio.TabIndex = 19
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.verPlanillas)
        Me.Agrupacion4.Controls.Add(Me.verCajaLiquidacion)
        Me.Agrupacion4.Controls.Add(Me.VerCombustible)
        Me.Agrupacion4.Controls.Add(Me.verVentas)
        Me.Agrupacion4.Controls.Add(Me.verCompras)
        Me.Agrupacion4.Controls.Add(Me.VerAlmacen)
        Me.Agrupacion4.Controls.Add(Me.verContabilidad)
        Me.Agrupacion4.Controls.Add(Me.verTesoreria)
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(160, 21)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(514, 76)
        Me.Agrupacion4.TabIndex = 18
        Me.Agrupacion4.Text = "Cierre de Operaciones"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verPlanillas
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.BackColor2 = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.verPlanillas.Appearance = Appearance9
        Me.verPlanillas.BackColor = System.Drawing.Color.Transparent
        Me.verPlanillas.BackColorInternal = System.Drawing.Color.Transparent
        Me.verPlanillas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verPlanillas.ForeColor = System.Drawing.Color.Black
        Me.verPlanillas.Location = New System.Drawing.Point(386, 47)
        Me.verPlanillas.Name = "verPlanillas"
        Me.verPlanillas.Size = New System.Drawing.Size(109, 20)
        Me.verPlanillas.TabIndex = 14
        Me.verPlanillas.Text = "Cerrar Planillas"
        '
        'verCajaLiquidacion
        '
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.verCajaLiquidacion.Appearance = Appearance10
        Me.verCajaLiquidacion.BackColor = System.Drawing.Color.Transparent
        Me.verCajaLiquidacion.BackColorInternal = System.Drawing.Color.Transparent
        Me.verCajaLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCajaLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.verCajaLiquidacion.Location = New System.Drawing.Point(388, 22)
        Me.verCajaLiquidacion.Name = "verCajaLiquidacion"
        Me.verCajaLiquidacion.Size = New System.Drawing.Size(120, 19)
        Me.verCajaLiquidacion.TabIndex = 13
        Me.verCajaLiquidacion.Text = "Cerrar CajaLiqui"
        '
        'VerCombustible
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.BackColor2 = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.VerCombustible.Appearance = Appearance11
        Me.VerCombustible.BackColor = System.Drawing.Color.Transparent
        Me.VerCombustible.BackColorInternal = System.Drawing.Color.Transparent
        Me.VerCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerCombustible.ForeColor = System.Drawing.Color.Black
        Me.VerCombustible.Location = New System.Drawing.Point(259, 48)
        Me.VerCombustible.Name = "VerCombustible"
        Me.VerCombustible.Size = New System.Drawing.Size(128, 20)
        Me.VerCombustible.TabIndex = 12
        Me.VerCombustible.Text = "Cerrar Combustible"
        '
        'verVentas
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.BackColor2 = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.verVentas.Appearance = Appearance12
        Me.verVentas.BackColor = System.Drawing.Color.Transparent
        Me.verVentas.BackColorInternal = System.Drawing.Color.Transparent
        Me.verVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verVentas.ForeColor = System.Drawing.Color.Black
        Me.verVentas.Location = New System.Drawing.Point(7, 48)
        Me.verVentas.Name = "verVentas"
        Me.verVentas.Size = New System.Drawing.Size(120, 20)
        Me.verVentas.TabIndex = 8
        Me.verVentas.Text = "Cerrar Ventas"
        '
        'verCompras
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.BackColor2 = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.verCompras.Appearance = Appearance13
        Me.verCompras.BackColor = System.Drawing.Color.Transparent
        Me.verCompras.BackColorInternal = System.Drawing.Color.Transparent
        Me.verCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCompras.ForeColor = System.Drawing.Color.Black
        Me.verCompras.Location = New System.Drawing.Point(7, 22)
        Me.verCompras.Name = "verCompras"
        Me.verCompras.Size = New System.Drawing.Size(120, 20)
        Me.verCompras.TabIndex = 7
        Me.verCompras.Text = "Cerrar Compras"
        '
        'VerAlmacen
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.BackColor2 = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.VerAlmacen.Appearance = Appearance14
        Me.VerAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.VerAlmacen.BackColorInternal = System.Drawing.Color.Transparent
        Me.VerAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerAlmacen.ForeColor = System.Drawing.Color.Black
        Me.VerAlmacen.Location = New System.Drawing.Point(133, 21)
        Me.VerAlmacen.Name = "VerAlmacen"
        Me.VerAlmacen.Size = New System.Drawing.Size(120, 20)
        Me.VerAlmacen.TabIndex = 9
        Me.VerAlmacen.Text = "Cerrar Almacén"
        '
        'verContabilidad
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.BackColor2 = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.verContabilidad.Appearance = Appearance15
        Me.verContabilidad.BackColor = System.Drawing.Color.Transparent
        Me.verContabilidad.BackColorInternal = System.Drawing.Color.Transparent
        Me.verContabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verContabilidad.ForeColor = System.Drawing.Color.Black
        Me.verContabilidad.Location = New System.Drawing.Point(259, 22)
        Me.verContabilidad.Name = "verContabilidad"
        Me.verContabilidad.Size = New System.Drawing.Size(128, 20)
        Me.verContabilidad.TabIndex = 11
        Me.verContabilidad.Text = "Cerrar Contabilidad"
        '
        'verTesoreria
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.BackColor2 = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.verTesoreria.Appearance = Appearance16
        Me.verTesoreria.BackColor = System.Drawing.Color.Transparent
        Me.verTesoreria.BackColorInternal = System.Drawing.Color.Transparent
        Me.verTesoreria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verTesoreria.ForeColor = System.Drawing.Color.Black
        Me.verTesoreria.Location = New System.Drawing.Point(133, 47)
        Me.verTesoreria.Name = "verTesoreria"
        Me.verTesoreria.Size = New System.Drawing.Size(120, 20)
        Me.verTesoreria.TabIndex = 10
        Me.verTesoreria.Text = "Cerrar Tesorería"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.decTCVenta)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion3.Controls.Add(Me.decTCCompra)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(680, 21)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(199, 75)
        Me.Agrupacion3.TabIndex = 17
        Me.Agrupacion3.Text = "Tipo de Cambio de Cierre"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTCVenta
        '
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.decTCVenta.Appearance = Appearance17
        Me.decTCVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTCVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTCVenta.ForeColor = System.Drawing.Color.Black
        Me.decTCVenta.Location = New System.Drawing.Point(90, 40)
        Me.decTCVenta.MaskInput = "{double:6.4}"
        Me.decTCVenta.Name = "decTCVenta"
        Me.decTCVenta.NullText = "0.00"
        Me.decTCVenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTCVenta.Size = New System.Drawing.Size(100, 21)
        Me.decTCVenta.TabIndex = 16
        '
        'Etiqueta6
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance18
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(6, 19)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(78, 14)
        Me.Etiqueta6.TabIndex = 15
        Me.Etiqueta6.Text = "T. C. Compra:"
        '
        'Etiqueta5
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance19
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(6, 42)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta5.TabIndex = 14
        Me.Etiqueta5.Text = "T. C. Venta:"
        '
        'decTCCompra
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.decTCCompra.Appearance = Appearance20
        Me.decTCCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTCCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTCCompra.ForeColor = System.Drawing.Color.Black
        Me.decTCCompra.FormatString = ""
        Me.decTCCompra.Location = New System.Drawing.Point(90, 18)
        Me.decTCCompra.MaskInput = "{double:6.4}"
        Me.decTCCompra.Name = "decTCCompra"
        Me.decTCCompra.NullText = "0.00"
        Me.decTCCompra.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTCCompra.Size = New System.Drawing.Size(100, 21)
        Me.decTCCompra.TabIndex = 13
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(632, 102)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(120, 20)
        Me.verActivo.TabIndex = 12
        Me.verActivo.Text = "Activo"
        '
        'Etiqueta2
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance21
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 23)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Código:"
        '
        'txtCodigo
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Appearance = Appearance22
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(68, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(86, 21)
        Me.txtCodigo.TabIndex = 0
        '
        'tcEjercicio
        '
        Me.tcEjercicio.Controls.Add(Me.UltraTabPageControl1)
        Me.tcEjercicio.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcEjercicio.Controls.Add(Me.UltraTabPageControl2)
        Me.tcEjercicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcEjercicio.Location = New System.Drawing.Point(0, 0)
        Me.tcEjercicio.Name = "tcEjercicio"
        Me.tcEjercicio.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcEjercicio.Size = New System.Drawing.Size(1019, 365)
        Me.tcEjercicio.TabIndex = 1
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcEjercicio.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcEjercicio.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1017, 342)
        '
        'timTiempo
        '
        Me.timTiempo.Interval = 1000
        '
        'frm_Periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1019, 365)
        Me.Controls.Add(Me.tcEjercicio)
        Me.Name = "frm_Periodo"
        Me.Text = "Periodo"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_ListaPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.odPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.fecFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.verPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCajaLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTesoreria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.decTCVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTCCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEjercicio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents decTCVenta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents decTCCompra As ISL.Controles.NumeroDecimal
    Friend WithEvents verVentas As ISL.Controles.Chequear
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_ListaPeriodo As ISL.Controles.Grilla
    Friend WithEvents odPeriodo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents verCompras As ISL.Controles.Chequear
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents VerAlmacen As ISL.Controles.Chequear
    Friend WithEvents tcEjercicio As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents fecFin As ISL.Controles.Fecha
    Friend WithEvents fecInicio As ISL.Controles.Fecha
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents verContabilidad As ISL.Controles.Chequear
    Friend WithEvents verTesoreria As ISL.Controles.Chequear
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents timTiempo As ISL.Controles.Tiempo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents nroEjercicioBusca As ISL.Win.Año
    Friend WithEvents nroMes As ISL.Win.Mes
    Friend WithEvents nroEjercicio As ISL.Win.Año
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerCombustible As ISL.Controles.Chequear
    Friend WithEvents verCajaLiquidacion As ISL.Controles.Chequear
    Friend WithEvents verPlanillas As ISL.Controles.Chequear
    Friend WithEvents Filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider

End Class
