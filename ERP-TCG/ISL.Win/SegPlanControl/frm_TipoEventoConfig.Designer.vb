<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoEventoConfig
    Inherits ISL.Win.frm_MenuPadre

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TipoEventoConfig))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccionar")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdAreaTipoEvento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ColorIncidente = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorRobo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAlarma = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAccidente = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboEventoBusqueda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.griAreas = New ISL.Controles.Grilla(Me.components)
        Me.ogdArea = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.griAreasAsignadas = New ISL.Controles.Grilla(Me.components)
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEvento = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.tcPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdAreaTipoEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.ColorIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.cboEventoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.griAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl1.Controls.Add(Me.griLista)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1240, 399)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(423, 167)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 24
        Me.ugb_Espera.Visible = False
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdAreaTipoEvento
        UltraGridColumn51.Header.Fixed = True
        UltraGridColumn51.Header.VisiblePosition = 0
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.Width = 90
        UltraGridColumn52.Header.Caption = "AreaTipoEvento"
        UltraGridColumn52.Header.Fixed = True
        UltraGridColumn52.Header.VisiblePosition = 1
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.Width = 90
        UltraGridColumn53.Header.Fixed = True
        UltraGridColumn53.Header.VisiblePosition = 2
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.Width = 90
        UltraGridColumn54.Header.Fixed = True
        UltraGridColumn54.Header.VisiblePosition = 3
        UltraGridColumn54.Width = 120
        UltraGridColumn55.Header.Fixed = True
        UltraGridColumn55.Header.VisiblePosition = 4
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.Width = 90
        UltraGridColumn56.Header.Fixed = True
        UltraGridColumn56.Header.VisiblePosition = 5
        UltraGridColumn56.Width = 220
        UltraGridColumn57.Header.VisiblePosition = 6
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.Width = 90
        UltraGridColumn58.Header.VisiblePosition = 7
        UltraGridColumn58.Width = 180
        UltraGridColumn59.Header.VisiblePosition = 8
        UltraGridColumn59.Width = 250
        UltraGridColumn60.Header.VisiblePosition = 9
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn60.Width = 100
        UltraGridColumn61.Header.VisiblePosition = 10
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.Width = 90
        UltraGridColumn62.Header.VisiblePosition = 11
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.Width = 30
        UltraGridColumn63.Header.VisiblePosition = 12
        UltraGridColumn63.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn63.Width = 100
        UltraGridColumn64.Header.VisiblePosition = 13
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 90
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
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
        Me.griLista.Location = New System.Drawing.Point(0, 84)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1240, 315)
        Me.griLista.TabIndex = 22
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Delete})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(172, 26)
        '
        'Delete
        '
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(171, 22)
        Me.Delete.Text = "Eliminar Tipo Evento"
        Me.Delete.ToolTipText = "Eliminar Tipo de Evento seleccionada"
        '
        'ogdAreaTipoEvento
        '
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn13.DataType = GetType(Date)
        Me.ogdAreaTipoEvento.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'UltraExpandableGroupBox6
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance1
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1240, 84)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1240, 84)
        Me.UltraExpandableGroupBox6.TabIndex = 23
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
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(1234, 61)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance2
        Me.UltraGroupBox3.Controls.Add(Me.ColorIncidente)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox3.Controls.Add(Me.ColorRobo)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox3.Controls.Add(Me.ColorAlarma)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta28)
        Me.UltraGroupBox3.Controls.Add(Me.ColorAccidente)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta24)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(251, 1)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(984, 60)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorIncidente
        '
        Me.ColorIncidente.Color = System.Drawing.Color.SandyBrown
        Me.ColorIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorIncidente.Location = New System.Drawing.Point(210, 11)
        Me.ColorIncidente.Name = "ColorIncidente"
        Me.ColorIncidente.Size = New System.Drawing.Size(44, 19)
        Me.ColorIncidente.TabIndex = 15
        Me.ColorIncidente.Text = "SandyBrown"
        '
        'Etiqueta1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance3
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(167, 38)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta1.TabIndex = 16
        Me.Etiqueta1.Text = "Robo:"
        '
        'ColorRobo
        '
        Me.ColorRobo.Color = System.Drawing.Color.RosyBrown
        Me.ColorRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorRobo.Location = New System.Drawing.Point(210, 35)
        Me.ColorRobo.Name = "ColorRobo"
        Me.ColorRobo.Size = New System.Drawing.Size(44, 19)
        Me.ColorRobo.TabIndex = 17
        Me.ColorRobo.Text = "RosyBrown"
        '
        'Etiqueta2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance4
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(148, 14)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta2.TabIndex = 14
        Me.Etiqueta2.Text = "Incidente:"
        '
        'ColorAlarma
        '
        Me.ColorAlarma.Color = System.Drawing.Color.GreenYellow
        Me.ColorAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAlarma.Location = New System.Drawing.Point(72, 11)
        Me.ColorAlarma.Name = "ColorAlarma"
        Me.ColorAlarma.Size = New System.Drawing.Size(44, 19)
        Me.ColorAlarma.TabIndex = 11
        Me.ColorAlarma.Text = "GreenYellow"
        '
        'Etiqueta28
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance5
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(9, 38)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta28.TabIndex = 12
        Me.Etiqueta28.Text = "Accidente:"
        '
        'ColorAccidente
        '
        Me.ColorAccidente.Color = System.Drawing.Color.LightBlue
        Me.ColorAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAccidente.Location = New System.Drawing.Point(72, 35)
        Me.ColorAccidente.Name = "ColorAccidente"
        Me.ColorAccidente.Size = New System.Drawing.Size(44, 19)
        Me.ColorAccidente.TabIndex = 13
        Me.ColorAccidente.Text = "LightBlue"
        '
        'Etiqueta24
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance6
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(23, 14)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta24.TabIndex = 10
        Me.Etiqueta24.Text = "Alarma:"
        '
        'UltraGroupBox13
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance7
        Me.UltraGroupBox13.Controls.Add(Me.cboEventoBusqueda)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel62)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(-1, 1)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(246, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboEventoBusqueda
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.cboEventoBusqueda.Appearance = Appearance8
        Me.cboEventoBusqueda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEventoBusqueda.DisplayMember = "Login"
        Me.cboEventoBusqueda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEventoBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEventoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventoBusqueda.ForeColor = System.Drawing.Color.Black
        Me.cboEventoBusqueda.Location = New System.Drawing.Point(63, 9)
        Me.cboEventoBusqueda.Name = "cboEventoBusqueda"
        Me.cboEventoBusqueda.Size = New System.Drawing.Size(150, 21)
        Me.cboEventoBusqueda.TabIndex = 4
        Me.cboEventoBusqueda.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance9
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel62.Location = New System.Drawing.Point(15, 13)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel62.TabIndex = 3
        Me.UltraLabel62.Text = "Evento:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1240, 399)
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.griAreas)
        Me.Panel2.Controls.Add(Me.griAreasAsignadas)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.UltraLabel4)
        Me.Panel2.Controls.Add(Me.cboEvento)
        Me.Panel2.Controls.Add(Me.UltraLabel14)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1240, 399)
        Me.Panel2.TabIndex = 1
        '
        'griAreas
        '
        Me.griAreas.DataSource = Me.ogdArea
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 1
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Sel"
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Width = 30
        UltraGridColumn31.Header.Caption = "Area"
        UltraGridColumn31.Header.VisiblePosition = 3
        UltraGridColumn31.Width = 150
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.griAreas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griAreas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griAreas.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAreas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreas.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreas.Location = New System.Drawing.Point(96, 123)
        Me.griAreas.Name = "griAreas"
        Me.griAreas.Size = New System.Drawing.Size(217, 271)
        Me.griAreas.TabIndex = 47
        '
        'ogdArea
        '
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.ogdArea.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'griAreasAsignadas
        '
        Me.griAreasAsignadas.DataSource = Me.ogdAreaTipoEvento
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 13
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Hidden = True
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn44.Header.Caption = "Areas Selecionadas"
        UltraGridColumn44.Header.VisiblePosition = 3
        UltraGridColumn44.Width = 95
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn45.Header.VisiblePosition = 6
        UltraGridColumn45.MaxLength = 500
        UltraGridColumn45.Width = 135
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 9
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 11
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 12
        UltraGridColumn50.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50})
        Me.griAreasAsignadas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griAreasAsignadas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griAreasAsignadas.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasAsignadas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasAsignadas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasAsignadas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAreasAsignadas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreasAsignadas.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreasAsignadas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreasAsignadas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasAsignadas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreasAsignadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasAsignadas.Location = New System.Drawing.Point(317, 123)
        Me.griAreasAsignadas.Name = "griAreasAsignadas"
        Me.griAreasAsignadas.Size = New System.Drawing.Size(292, 271)
        Me.griAreasAsignadas.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 47)
        Me.txtNombre.MaxLength = 80
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(244, 21)
        Me.txtNombre.TabIndex = 2
        '
        'UltraLabel4
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance10
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(61, 49)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(29, 14)
        Me.UltraLabel4.TabIndex = 46
        Me.UltraLabel4.Text = "Tipo:"
        '
        'cboEvento
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.cboEvento.Appearance = Appearance11
        Me.cboEvento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEvento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEvento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEvento.ForeColor = System.Drawing.Color.Black
        Me.cboEvento.Location = New System.Drawing.Point(96, 20)
        Me.cboEvento.Name = "cboEvento"
        Me.cboEvento.Size = New System.Drawing.Size(244, 21)
        Me.cboEvento.TabIndex = 1
        Me.cboEvento.ValueMember = "Id"
        '
        'UltraLabel14
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance12
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(47, 24)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel14.TabIndex = 29
        Me.UltraLabel14.Text = "Evento:"
        '
        'txtDescripcion
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Appearance = Appearance13
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 74)
        Me.txtDescripcion.MaxLength = 400
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(513, 43)
        Me.txtDescripcion.TabIndex = 3
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(23, 75)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Descripción:"
        '
        'tcPrincipal
        '
        Me.tcPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcPrincipal.Controls.Add(Me.UltraTabPageControl1)
        Me.tcPrincipal.Controls.Add(Me.UltraTabPageControl2)
        Me.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tcPrincipal.Name = "tcPrincipal"
        Me.tcPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcPrincipal.Size = New System.Drawing.Size(1242, 422)
        Me.tcPrincipal.TabIndex = 0
        Me.tcPrincipal.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcPrincipal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1240, 399)
        '
        'frm_TipoEventoConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 422)
        Me.Controls.Add(Me.tcPrincipal)
        Me.Name = "frm_TipoEventoConfig"
        Me.Text = "Tipos Evento Viaje"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdAreaTipoEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.ColorIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.cboEventoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.griAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdArea As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdAreaTipoEvento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents griAreasAsignadas As ISL.Controles.Grilla
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEvento As ISL.Controles.Combo
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColorAlarma As ISL.Controles.Colores
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAccidente As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboEventoBusqueda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tcPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents ColorIncidente As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColorRobo As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Private WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griAreas As ISL.Controles.Grilla
End Class
