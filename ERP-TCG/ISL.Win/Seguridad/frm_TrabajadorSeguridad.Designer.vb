<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TrabajadorSeguridad
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProceso")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoTrabajador")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proceso")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadLimite")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreTrabajador")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMinima")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMontoFuncional")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProcesoNegocio")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProceso")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProceso")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoTrabajador")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proceso")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadLimite")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTrabajador")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMinima")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMontoFuncional")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProcesoNegocio")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProceso")
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
        Me.odTrabajadorSeguridad = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tcTrabajadorSeguridad = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_TrabajadorSeguridad = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProceso = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.rbComprobante = New System.Windows.Forms.RadioButton()
        Me.rbMontoDiario = New System.Windows.Forms.RadioButton()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndMontoMinimo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboProcesoM = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboTrabajador = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.odTrabajadorSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcTrabajadorSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTrabajadorSeguridad.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_TrabajadorSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.ndMontoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcesoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'odTrabajadorSeguridad
        '
        Me.odTrabajadorSeguridad.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tcTrabajadorSeguridad
        '
        Me.tcTrabajadorSeguridad.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcTrabajadorSeguridad.Controls.Add(Me.UltraTabPageControl1)
        Me.tcTrabajadorSeguridad.Controls.Add(Me.UltraTabPageControl2)
        Me.tcTrabajadorSeguridad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTrabajadorSeguridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTrabajadorSeguridad.Location = New System.Drawing.Point(0, 0)
        Me.tcTrabajadorSeguridad.Name = "tcTrabajadorSeguridad"
        Me.tcTrabajadorSeguridad.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcTrabajadorSeguridad.Size = New System.Drawing.Size(844, 450)
        Me.tcTrabajadorSeguridad.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcTrabajadorSeguridad.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcTrabajadorSeguridad.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(842, 427)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_TrabajadorSeguridad)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(842, 427)
        '
        'grid_TrabajadorSeguridad
        '
        Me.grid_TrabajadorSeguridad.DataSource = Me.odTrabajadorSeguridad
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_TrabajadorSeguridad.DisplayLayout.Appearance = Appearance1
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Codigo"
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Width = 101
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.Width = 259
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.Caption = "Monto"
        UltraGridColumn23.Header.VisiblePosition = 8
        UltraGridColumn24.Header.VisiblePosition = 9
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Width = 53
        UltraGridColumn25.Header.Caption = "Trabajador"
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Width = 349
        UltraGridColumn26.Header.VisiblePosition = 10
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 14
        UltraGridColumn30.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        Me.grid_TrabajadorSeguridad.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_TrabajadorSeguridad.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_TrabajadorSeguridad.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_TrabajadorSeguridad.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_TrabajadorSeguridad.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grid_TrabajadorSeguridad.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_TrabajadorSeguridad.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_TrabajadorSeguridad.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grid_TrabajadorSeguridad.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_TrabajadorSeguridad.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance5.TextHAlignAsString = "Center"
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_TrabajadorSeguridad.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_TrabajadorSeguridad.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_TrabajadorSeguridad.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_TrabajadorSeguridad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_TrabajadorSeguridad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_TrabajadorSeguridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_TrabajadorSeguridad.Location = New System.Drawing.Point(0, 42)
        Me.grid_TrabajadorSeguridad.Name = "grid_TrabajadorSeguridad"
        Me.grid_TrabajadorSeguridad.Size = New System.Drawing.Size(842, 385)
        Me.grid_TrabajadorSeguridad.TabIndex = 1
        Me.grid_TrabajadorSeguridad.Text = "Grilla1"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.cboProceso)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(842, 42)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta5
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance6
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(41, 16)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta5.TabIndex = 51
        Me.Etiqueta5.Text = "Proceso:"
        '
        'cboProceso
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProceso.Appearance = Appearance7
        Me.cboProceso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboProceso.DisplayMember = "Nombre"
        Me.cboProceso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProceso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProceso.Location = New System.Drawing.Point(93, 11)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(326, 21)
        Me.cboProceso.TabIndex = 50
        Me.cboProceso.ValueMember = "Id"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(842, 427)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.rbComprobante)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.rbMontoDiario)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel3)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.ndMontoMinimo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.ndMonto)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboProcesoM)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboTrabajador)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(842, 169)
        Me.Gb_DatoGeneralDemanda.TabIndex = 1
        Me.Gb_DatoGeneralDemanda.Text = "Datos:"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbComprobante
        '
        Me.rbComprobante.AutoSize = True
        Me.rbComprobante.BackColor = System.Drawing.Color.Transparent
        Me.rbComprobante.ForeColor = System.Drawing.Color.Navy
        Me.rbComprobante.Location = New System.Drawing.Point(203, 134)
        Me.rbComprobante.Name = "rbComprobante"
        Me.rbComprobante.Size = New System.Drawing.Size(88, 17)
        Me.rbComprobante.TabIndex = 58
        Me.rbComprobante.Text = "Comprobante"
        Me.rbComprobante.UseVisualStyleBackColor = False
        '
        'rbMontoDiario
        '
        Me.rbMontoDiario.AutoSize = True
        Me.rbMontoDiario.BackColor = System.Drawing.Color.Transparent
        Me.rbMontoDiario.Checked = True
        Me.rbMontoDiario.ForeColor = System.Drawing.Color.Navy
        Me.rbMontoDiario.Location = New System.Drawing.Point(145, 134)
        Me.rbMontoDiario.Name = "rbMontoDiario"
        Me.rbMontoDiario.Size = New System.Drawing.Size(52, 17)
        Me.rbMontoDiario.TabIndex = 57
        Me.rbMontoDiario.TabStop = True
        Me.rbMontoDiario.Text = "Diario"
        Me.rbMontoDiario.UseVisualStyleBackColor = False
        '
        'UltraLabel3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance8
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(49, 134)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel3.TabIndex = 56
        Me.UltraLabel3.Text = "Tipo Aprobación:"
        '
        'ndMontoMinimo
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.ndMontoMinimo.Appearance = Appearance9
        Me.ndMontoMinimo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndMontoMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndMontoMinimo.ForeColor = System.Drawing.Color.Black
        Me.ndMontoMinimo.Location = New System.Drawing.Point(144, 103)
        Me.ndMontoMinimo.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        Me.ndMontoMinimo.Name = "ndMontoMinimo"
        Me.ndMontoMinimo.NullText = "0.00"
        Me.ndMontoMinimo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndMontoMinimo.Size = New System.Drawing.Size(118, 21)
        Me.ndMontoMinimo.TabIndex = 13
        '
        'UltraLabel2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance10
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(15, 105)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(124, 14)
        Me.UltraLabel2.TabIndex = 54
        Me.UltraLabel2.Text = "Monto Min. Aprobacion:"
        '
        'ndMonto
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.ndMonto.Appearance = Appearance11
        Me.ndMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndMonto.ForeColor = System.Drawing.Color.Black
        Me.ndMonto.Location = New System.Drawing.Point(144, 76)
        Me.ndMonto.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        Me.ndMonto.Name = "ndMonto"
        Me.ndMonto.NullText = "0.00"
        Me.ndMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndMonto.Size = New System.Drawing.Size(118, 21)
        Me.ndMonto.TabIndex = 12
        '
        'cboProcesoM
        '
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProcesoM.Appearance = Appearance12
        Me.cboProcesoM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProcesoM.DisplayMember = "Nombre"
        Me.cboProcesoM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProcesoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcesoM.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProcesoM.Location = New System.Drawing.Point(144, 25)
        Me.cboProcesoM.Name = "cboProcesoM"
        Me.cboProcesoM.Size = New System.Drawing.Size(313, 21)
        Me.cboProcesoM.TabIndex = 10
        Me.cboProcesoM.ValueMember = "Id"
        '
        'cboTrabajador
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance13
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajador.DisplayMember = "Nombre"
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Location = New System.Drawing.Point(144, 49)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(313, 21)
        Me.cboTrabajador.TabIndex = 11
        Me.cboTrabajador.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 78)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(127, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Monto Max. Aprobacion:"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(785, 79)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'UltraLabel22
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance15
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(77, 51)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Trabajador:"
        '
        'UltraLabel4
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance16
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(90, 27)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Proceso:"
        '
        'frm_TrabajadorSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(844, 450)
        Me.Controls.Add(Me.tcTrabajadorSeguridad)
        Me.Name = "frm_TrabajadorSeguridad"
        Me.Text = "Trabajador Seguridad"
        CType(Me.odTrabajadorSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcTrabajadorSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTrabajadorSeguridad.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_TrabajadorSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.ndMontoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcesoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTrabajadorSeguridad As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_TrabajadorSeguridad As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboProceso As ISL.Controles.ComboMaestros
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboProcesoM As ISL.Controles.ComboMaestros
    Friend WithEvents cboTrabajador As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents odTrabajadorSeguridad As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndMontoMinimo As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents rbComprobante As System.Windows.Forms.RadioButton
    Friend WithEvents rbMontoDiario As System.Windows.Forms.RadioButton

End Class
