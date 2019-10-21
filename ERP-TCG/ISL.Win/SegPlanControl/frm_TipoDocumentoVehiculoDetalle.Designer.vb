<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoDocumentoVehiculoDetalle
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTodosCliente")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTodosMaterial")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTodosCliente")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTodosMaterial")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Select", 0, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Select", 0, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ogdLista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.ogdCliente = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tcPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalAccidentes = New ISL.Controles.Agrupacion(Me.components)
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ColorSinAsignar = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTodos = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboMaterialListar = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboClienteListar = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTipoDocumentoListar = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.chkTodosMaterial = New System.Windows.Forms.CheckBox()
        Me.chkTodosCliente = New System.Windows.Forms.CheckBox()
        Me.gridMateriales = New ISL.Controles.Grilla(Me.components)
        Me.gridClientes = New ISL.Controles.Grilla(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcPrincipal.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalAccidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalAccidentes.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.ColorSinAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.cboMaterialListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumentoListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.gridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ogdLista
        '
        UltraDataColumn9.DataType = GetType(Date)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Date)
        UltraDataColumn14.DataType = GetType(Boolean)
        UltraDataColumn15.DataType = GetType(Boolean)
        Me.ogdLista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'ogdCliente
        '
        Me.ogdCliente.Band.Columns.AddRange(New Object() {UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'tcPrincipal
        '
        Me.tcPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcPrincipal.Controls.Add(Me.UltraTabPageControl7)
        Me.tcPrincipal.Controls.Add(Me.utpDetalle)
        Me.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tcPrincipal.Name = "tcPrincipal"
        Me.tcPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcPrincipal.Size = New System.Drawing.Size(929, 431)
        Me.tcPrincipal.TabIndex = 5
        UltraTab5.Key = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "Lista"
        UltraTab6.Key = "Mantenimiento"
        UltraTab6.TabPage = Me.utpDetalle
        UltraTab6.Text = "Mantenimiento"
        Me.tcPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.tcPrincipal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(927, 408)
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalAccidentes)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(927, 408)
        '
        'agrTotalAccidentes
        '
        Me.agrTotalAccidentes.Controls.Add(Me.griLista)
        Me.agrTotalAccidentes.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.agrTotalAccidentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalAccidentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalAccidentes.ForeColor = System.Drawing.Color.Black
        Me.agrTotalAccidentes.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalAccidentes.Name = "agrTotalAccidentes"
        Me.agrTotalAccidentes.Size = New System.Drawing.Size(927, 408)
        Me.agrTotalAccidentes.TabIndex = 1
        Me.agrTotalAccidentes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLista
        '
        Me.griLista.DataSource = Me.ogdLista
        UltraGridColumn11.Header.Fixed = True
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 100
        UltraGridColumn12.Header.Fixed = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 100
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 100
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.Width = 220
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 100
        UltraGridColumn37.Header.VisiblePosition = 6
        UltraGridColumn37.Width = 280
        UltraGridColumn38.Header.VisiblePosition = 7
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.Width = 100
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Width = 220
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn40.Width = 110
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 13
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 14
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.Caption = "TodoCliente"
        UltraGridColumn45.Header.VisiblePosition = 5
        UltraGridColumn45.Width = 40
        UltraGridColumn46.Header.Caption = "TodoMaterial"
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn46.Width = 40
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn23, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.UseFixedHeaders = True
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griLista.Location = New System.Drawing.Point(3, 87)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(921, 318)
        Me.griLista.TabIndex = 22
        '
        'UltraExpandableGroupBox6
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance1
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(921, 84)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(921, 84)
        Me.UltraExpandableGroupBox6.TabIndex = 21
        Me.UltraExpandableGroupBox6.Text = "Busqueda"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox3)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(915, 61)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance2
        Me.UltraGroupBox3.Controls.Add(Me.ColorSinAsignar)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta28)
        Me.UltraGroupBox3.Controls.Add(Me.ColorTodos)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta24)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(786, 1)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(132, 60)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorSinAsignar
        '
        Me.ColorSinAsignar.Color = System.Drawing.Color.GreenYellow
        Me.ColorSinAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorSinAsignar.Location = New System.Drawing.Point(74, 11)
        Me.ColorSinAsignar.Name = "ColorSinAsignar"
        Me.ColorSinAsignar.Size = New System.Drawing.Size(44, 19)
        Me.ColorSinAsignar.TabIndex = 11
        Me.ColorSinAsignar.Text = "GreenYellow"
        '
        'Etiqueta28
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance3
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(33, 38)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta28.TabIndex = 12
        Me.Etiqueta28.Text = "Todos:"
        '
        'ColorTodos
        '
        Me.ColorTodos.Color = System.Drawing.Color.LightBlue
        Me.ColorTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTodos.Location = New System.Drawing.Point(72, 35)
        Me.ColorTodos.Name = "ColorTodos"
        Me.ColorTodos.Size = New System.Drawing.Size(44, 19)
        Me.ColorTodos.TabIndex = 13
        Me.ColorTodos.Text = "LightBlue"
        '
        'Etiqueta24
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance4
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(8, 14)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta24.TabIndex = 10
        Me.Etiqueta24.Text = "Sin Asignar:"
        '
        'UltraGroupBox13
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance5
        Me.UltraGroupBox13.Controls.Add(Me.cboMaterialListar)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox13.Controls.Add(Me.cboClienteListar)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox13.Controls.Add(Me.cboTipoDocumentoListar)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(-1, 1)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(781, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboMaterialListar
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialListar.Appearance = Appearance6
        Me.cboMaterialListar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMaterialListar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterialListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterialListar.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialListar.Location = New System.Drawing.Point(474, 6)
        Me.cboMaterialListar.Name = "cboMaterialListar"
        Me.cboMaterialListar.Size = New System.Drawing.Size(301, 21)
        Me.cboMaterialListar.TabIndex = 22
        Me.cboMaterialListar.ValueMember = "Id"
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(421, 10)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel2.TabIndex = 21
        Me.UltraLabel2.Text = "Material:"
        '
        'cboClienteListar
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.cboClienteListar.Appearance = Appearance8
        Me.cboClienteListar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClienteListar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteListar.ForeColor = System.Drawing.Color.Black
        Me.cboClienteListar.Location = New System.Drawing.Point(103, 33)
        Me.cboClienteListar.Name = "cboClienteListar"
        Me.cboClienteListar.Size = New System.Drawing.Size(309, 21)
        Me.cboClienteListar.TabIndex = 20
        Me.cboClienteListar.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(51, 38)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel1.TabIndex = 19
        Me.UltraLabel1.Text = "Cliente:"
        '
        'cboTipoDocumentoListar
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumentoListar.Appearance = Appearance10
        Me.cboTipoDocumentoListar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumentoListar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumentoListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumentoListar.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumentoListar.Location = New System.Drawing.Point(103, 6)
        Me.cboTipoDocumentoListar.Name = "cboTipoDocumentoListar"
        Me.cboTipoDocumentoListar.Size = New System.Drawing.Size(309, 21)
        Me.cboTipoDocumentoListar.TabIndex = 18
        Me.cboTipoDocumentoListar.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance11
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(6, 11)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel16.TabIndex = 17
        Me.UltraLabel16.Text = "TipoDocumento:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.ugb_Espera)
        Me.utpDetalle.Controls.Add(Me.chkTodosMaterial)
        Me.utpDetalle.Controls.Add(Me.chkTodosCliente)
        Me.utpDetalle.Controls.Add(Me.gridMateriales)
        Me.utpDetalle.Controls.Add(Me.gridClientes)
        Me.utpDetalle.Controls.Add(Me.cboTipoDocumento)
        Me.utpDetalle.Controls.Add(Me.UltraLabel14)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(927, 408)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(266, 241)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 17
        Me.ugb_Espera.Visible = False
        '
        'chkTodosMaterial
        '
        Me.chkTodosMaterial.AutoSize = True
        Me.chkTodosMaterial.BackColor = System.Drawing.Color.Transparent
        Me.chkTodosMaterial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodosMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkTodosMaterial.ForeColor = System.Drawing.Color.Navy
        Me.chkTodosMaterial.Location = New System.Drawing.Point(343, 37)
        Me.chkTodosMaterial.Name = "chkTodosMaterial"
        Me.chkTodosMaterial.Size = New System.Drawing.Size(91, 17)
        Me.chkTodosMaterial.TabIndex = 58
        Me.chkTodosMaterial.Text = "Todo Material"
        Me.chkTodosMaterial.UseVisualStyleBackColor = False
        '
        'chkTodosCliente
        '
        Me.chkTodosCliente.AutoSize = True
        Me.chkTodosCliente.BackColor = System.Drawing.Color.Transparent
        Me.chkTodosCliente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkTodosCliente.ForeColor = System.Drawing.Color.Navy
        Me.chkTodosCliente.Location = New System.Drawing.Point(39, 36)
        Me.chkTodosCliente.Name = "chkTodosCliente"
        Me.chkTodosCliente.Size = New System.Drawing.Size(86, 17)
        Me.chkTodosCliente.TabIndex = 56
        Me.chkTodosCliente.Text = "Todo Cliente"
        Me.chkTodosCliente.UseVisualStyleBackColor = False
        '
        'gridMateriales
        '
        Me.gridMateriales.DataSource = Me.ogdCliente
        UltraGridColumn7.Header.Fixed = True
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 100
        UltraGridColumn8.Header.Caption = "Materiales"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 210
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn10.DataType = GetType(Boolean)
        UltraGridColumn10.Header.Caption = ""
        UltraGridColumn10.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn10.Header.Fixed = True
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Width = 30
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.gridMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridMateriales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.gridMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.gridMateriales.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridMateriales.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMateriales.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridMateriales.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridMateriales.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.gridMateriales.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridMateriales.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.gridMateriales.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.gridMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridMateriales.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.gridMateriales.Location = New System.Drawing.Point(343, 60)
        Me.gridMateriales.Name = "gridMateriales"
        Me.gridMateriales.Size = New System.Drawing.Size(318, 310)
        Me.gridMateriales.TabIndex = 55
        '
        'gridClientes
        '
        Me.gridClientes.DataSource = Me.ogdCliente
        UltraGridColumn3.Header.Fixed = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 100
        UltraGridColumn4.Header.Caption = "Clientes"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 210
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn6.DataType = GetType(Boolean)
        UltraGridColumn6.Header.Caption = ""
        UltraGridColumn6.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn6.Header.Fixed = True
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Width = 30
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.gridClientes.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridClientes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.gridClientes.DisplayLayout.MaxColScrollRegions = 1
        Me.gridClientes.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridClientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridClientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridClientes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridClientes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridClientes.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.gridClientes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridClientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.gridClientes.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.gridClientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridClientes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridClientes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridClientes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridClientes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.gridClientes.Location = New System.Drawing.Point(19, 60)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.Size = New System.Drawing.Size(318, 310)
        Me.gridClientes.TabIndex = 54
        '
        'cboTipoDocumento
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance12
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(111, 11)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(550, 21)
        Me.cboTipoDocumento.TabIndex = 48
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'UltraLabel14
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance13
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(15, 11)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel14.TabIndex = 53
        Me.UltraLabel14.Text = "Tipo Documento:"
        '
        'frm_TipoDocumentoVehiculoDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 431)
        Me.Controls.Add(Me.tcPrincipal)
        Me.Name = "frm_TipoDocumentoVehiculoDetalle"
        Me.Text = "TipoDocumentoVehiculoDetalle"
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcPrincipal.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalAccidentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalAccidentes.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.ColorSinAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.cboMaterialListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumentoListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        Me.utpDetalle.PerformLayout()
        CType(Me.gridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalAccidentes As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColorSinAsignar As ISL.Controles.Colores
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTodos As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboTipoDocumentoListar As ISL.Controles.Combo
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdCliente As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents gridClientes As ISL.Controles.Grilla
    Friend WithEvents gridMateriales As ISL.Controles.Grilla
    Friend WithEvents chkTodosCliente As System.Windows.Forms.CheckBox
    Friend WithEvents cboMaterialListar As ISL.Controles.Combo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboClienteListar As ISL.Controles.Combo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdLista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents chkTodosMaterial As System.Windows.Forms.CheckBox
End Class
