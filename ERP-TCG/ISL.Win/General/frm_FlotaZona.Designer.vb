<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FlotaZona
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
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndZona")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFlota")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndZonaD2")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeActual")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuotaTracto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndZona")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFlota")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndZonaD2")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdJefeActual")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuotaTracto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlota")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlota")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdFlota = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griJefe = New ISL.Controles.Grilla(Me.components)
        Me.udsJefe = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tspJefeAsignado = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitar = New System.Windows.Forms.ToolStripButton()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboJefeAsignado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnQuitarCuota = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarCuota = New Infragistics.Win.Misc.UltraButton()
        Me.griCuota = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.numCuotaTracto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.VerZonaD2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.verZona = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verFlota = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ficDemanda = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecCuota = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.griJefe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsJefe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspJefeAsignado.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cboJefeAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.griCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCuotaTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerZonaD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDemanda.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(994, 488)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 0)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(994, 488)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdFlota
        UltraGridBand1.ColHeaderLines = 2
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 85
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Width = 60
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn18.Width = 250
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.Caption = "Zona"
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn20.Width = 41
        UltraGridColumn21.Header.Caption = "Flota"
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn21.Width = 40
        UltraGridColumn22.Header.Caption = "Zona D2"
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn22.Width = 54
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.Width = 257
        UltraGridColumn24.Header.VisiblePosition = 8
        UltraGridColumn24.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.VisiblePosition = 9
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn2})
        UltraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(2, 19)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(990, 467)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(121, 70)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(120, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(120, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(120, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'ogdFlota
        '
        Me.ogdFlota.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.UltraGroupBox1)
        Me.utpDetalle.Controls.Add(Me.agrDatoGeneral)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(994, 488)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ugb_Espera)
        Me.UltraGroupBox1.Controls.Add(Me.griJefe)
        Me.UltraGroupBox1.Controls.Add(Me.tspJefeAsignado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 153)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(994, 335)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Detalle"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(370, 117)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 68)
        Me.ugb_Espera.TabIndex = 3
        Me.ugb_Espera.Visible = False
        '
        'griJefe
        '
        Me.griJefe.DataSource = Me.udsJefe
        Appearance2.BackColor = System.Drawing.Color.White
        Me.griJefe.DisplayLayout.Appearance = Appearance2
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Header.Caption = "Jefe"
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn26.Width = 226
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn27.Header.VisiblePosition = 6
        UltraGridColumn27.Width = 120
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn28.Header.VisiblePosition = 4
        UltraGridColumn28.Width = 230
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn29.Header.Caption = "Fecha Inicio"
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn29.Width = 82
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn30.Header.Caption = "Fecha Fin"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 75
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn31.Header.VisiblePosition = 5
        UltraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn31.Width = 40
        UltraGridColumn32.Header.VisiblePosition = 7
        UltraGridColumn33.Header.VisiblePosition = 9
        UltraGridColumn34.Header.VisiblePosition = 10
        UltraGridColumn35.Header.VisiblePosition = 11
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Header.VisiblePosition = 8
        UltraGridColumn36.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.griJefe.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griJefe.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griJefe.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griJefe.DisplayLayout.GroupByBox.Hidden = True
        Me.griJefe.DisplayLayout.MaxColScrollRegions = 1
        Me.griJefe.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griJefe.DisplayLayout.Override.CellPadding = 0
        Me.griJefe.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griJefe.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griJefe.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance3.TextHAlignAsString = "Left"
        Me.griJefe.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.griJefe.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griJefe.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance4.TextVAlignAsString = "Middle"
        Me.griJefe.DisplayLayout.Override.RowAppearance = Appearance4
        Me.griJefe.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griJefe.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griJefe.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griJefe.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griJefe.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griJefe.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griJefe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griJefe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griJefe.Location = New System.Drawing.Point(3, 114)
        Me.griJefe.Name = "griJefe"
        Me.griJefe.Size = New System.Drawing.Size(988, 218)
        Me.griJefe.TabIndex = 13
        Me.griJefe.Tag = ""
        '
        'udsJefe
        '
        UltraDataColumn15.DataType = GetType(Date)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataColumn19.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Boolean)
        Me.udsJefe.Band.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tspJefeAsignado
        '
        Me.tspJefeAsignado.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspJefeAsignado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbQuitar})
        Me.tspJefeAsignado.Location = New System.Drawing.Point(3, 89)
        Me.tspJefeAsignado.Name = "tspJefeAsignado"
        Me.tspJefeAsignado.Size = New System.Drawing.Size(988, 25)
        Me.tspJefeAsignado.TabIndex = 12
        Me.tspJefeAsignado.Text = "ToolStrip1"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregar.Text = "Agregar (Ins)"
        '
        'tsbQuitar
        '
        Me.tsbQuitar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitar.Name = "tsbQuitar"
        Me.tsbQuitar.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitar.Text = "Quitar (Del)"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.cboJefeAsignado)
        Me.UltraGroupBox2.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox2.Controls.Add(Me.Label4)
        Me.UltraGroupBox2.Controls.Add(Me.Label3)
        Me.UltraGroupBox2.Controls.Add(Me.Label2)
        Me.UltraGroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(3, 17)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(988, 72)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboJefeAsignado
        '
        Me.cboJefeAsignado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboJefeAsignado.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboJefeAsignado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboJefeAsignado.DisplayMember = "Nombre"
        Me.cboJefeAsignado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboJefeAsignado.DropDownListWidth = -1
        Me.cboJefeAsignado.Location = New System.Drawing.Point(83, 10)
        Me.cboJefeAsignado.Name = "cboJefeAsignado"
        Me.cboJefeAsignado.Size = New System.Drawing.Size(291, 22)
        Me.cboJefeAsignado.TabIndex = 0
        Me.cboJefeAsignado.ValueMember = "Id"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(83, 38)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(489, 29)
        Me.txtGlosa.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(45, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Glosa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(3, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Jefe Asignado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(403, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "Fecha Inicio:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(472, 11)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(100, 21)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.fecCuota)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel5)
        Me.agrDatoGeneral.Controls.Add(Me.btnQuitarCuota)
        Me.agrDatoGeneral.Controls.Add(Me.btnAgregarCuota)
        Me.agrDatoGeneral.Controls.Add(Me.griCuota)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel3)
        Me.agrDatoGeneral.Controls.Add(Me.numCuotaTracto)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel2)
        Me.agrDatoGeneral.Controls.Add(Me.txtDescripcion)
        Me.agrDatoGeneral.Controls.Add(Me.VerZonaD2)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel1)
        Me.agrDatoGeneral.Controls.Add(Me.txtNombre)
        Me.agrDatoGeneral.Controls.Add(Me.verZona)
        Me.agrDatoGeneral.Controls.Add(Me.verFlota)
        Me.agrDatoGeneral.Controls.Add(Me.txtId)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel4)
        Me.agrDatoGeneral.Controls.Add(Me.txtCodigo)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(994, 153)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Dato General"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnQuitarCuota
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.BorderColor = System.Drawing.Color.Transparent
        Me.btnQuitarCuota.Appearance = Appearance6
        Me.btnQuitarCuota.Location = New System.Drawing.Point(891, 19)
        Me.btnQuitarCuota.Name = "btnQuitarCuota"
        Me.btnQuitarCuota.Size = New System.Drawing.Size(90, 27)
        Me.btnQuitarCuota.TabIndex = 23
        Me.btnQuitarCuota.Text = "Quitar"
        '
        'btnAgregarCuota
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.BorderColor = System.Drawing.Color.Transparent
        Me.btnAgregarCuota.Appearance = Appearance7
        Me.btnAgregarCuota.Location = New System.Drawing.Point(792, 19)
        Me.btnAgregarCuota.Name = "btnAgregarCuota"
        Me.btnAgregarCuota.Size = New System.Drawing.Size(90, 27)
        Me.btnAgregarCuota.TabIndex = 22
        Me.btnAgregarCuota.Text = "Agregar"
        '
        'griCuota
        '
        Me.griCuota.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCuota.DisplayLayout.MaxColScrollRegions = 1
        Me.griCuota.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCuota.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCuota.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCuota.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griCuota.DisplayLayout.Override.CellPadding = 0
        Me.griCuota.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCuota.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griCuota.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCuota.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCuota.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCuota.Location = New System.Drawing.Point(475, 48)
        Me.griCuota.Name = "griCuota"
        Me.griCuota.Size = New System.Drawing.Size(508, 92)
        Me.griCuota.TabIndex = 21
        Me.griCuota.Text = "UltraGrid1"
        '
        'UltraLabel3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Black
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance8
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(475, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel3.TabIndex = 20
        Me.UltraLabel3.Text = "Cuota:"
        '
        'numCuotaTracto
        '
        Me.numCuotaTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCuotaTracto.Location = New System.Drawing.Point(518, 20)
        Me.numCuotaTracto.Name = "numCuotaTracto"
        Me.numCuotaTracto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCuotaTracto.Size = New System.Drawing.Size(95, 22)
        Me.numCuotaTracto.TabIndex = 19
        '
        'UltraLabel2
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Black
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance9
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(5, 72)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel2.TabIndex = 18
        Me.UltraLabel2.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(77, 72)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(370, 68)
        Me.txtDescripcion.TabIndex = 3
        '
        'VerZonaD2
        '
        Appearance10.FontData.Name = "Tahoma"
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.VerZonaD2.Appearance = Appearance10
        Me.VerZonaD2.AutoSize = True
        Me.VerZonaD2.BackColor = System.Drawing.Color.Transparent
        Me.VerZonaD2.BackColorInternal = System.Drawing.Color.Transparent
        Me.VerZonaD2.Location = New System.Drawing.Point(384, 20)
        Me.VerZonaD2.Name = "VerZonaD2"
        Me.VerZonaD2.Size = New System.Drawing.Size(63, 18)
        Me.VerZonaD2.TabIndex = 6
        Me.VerZonaD2.Text = "Zona D2"
        '
        'UltraLabel1
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 48)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel1.TabIndex = 16
        Me.UltraLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(77, 46)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 22)
        Me.txtNombre.TabIndex = 2
        '
        'verZona
        '
        Appearance12.FontData.Name = "Tahoma"
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.verZona.Appearance = Appearance12
        Me.verZona.AutoSize = True
        Me.verZona.BackColor = System.Drawing.Color.Transparent
        Me.verZona.BackColorInternal = System.Drawing.Color.Transparent
        Me.verZona.Location = New System.Drawing.Point(268, 20)
        Me.verZona.Name = "verZona"
        Me.verZona.Size = New System.Drawing.Size(46, 18)
        Me.verZona.TabIndex = 4
        Me.verZona.Text = "Zona"
        '
        'verFlota
        '
        Appearance13.FontData.Name = "Tahoma"
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.verFlota.Appearance = Appearance13
        Me.verFlota.AutoSize = True
        Me.verFlota.BackColor = System.Drawing.Color.Transparent
        Me.verFlota.BackColorInternal = System.Drawing.Color.Transparent
        Me.verFlota.Location = New System.Drawing.Point(328, 20)
        Me.verFlota.Name = "verFlota"
        Me.verFlota.Size = New System.Drawing.Size(46, 18)
        Me.verFlota.TabIndex = 5
        Me.verFlota.Text = "Flota"
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(154, 22)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(20, 22)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'UltraLabel4
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Black
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance14
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(29, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(77, 22)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(71, 22)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        '
        'ficDemanda
        '
        Me.ficDemanda.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDemanda.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDemanda.Controls.Add(Me.utpDetalle)
        Me.ficDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDemanda.Location = New System.Drawing.Point(0, 0)
        Me.ficDemanda.Name = "ficDemanda"
        Me.ficDemanda.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDemanda.Size = New System.Drawing.Size(996, 511)
        Me.ficDemanda.TabIndex = 1
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        UltraTab7.Key = "Mantenimiento"
        UltraTab7.TabPage = Me.utpDetalle
        UltraTab7.Text = "Mantenimiento"
        Me.ficDemanda.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.ficDemanda.TabStop = False
        Me.ficDemanda.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(994, 488)
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(619, 24)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel5.TabIndex = 24
        Me.UltraLabel5.Text = "Fecha:"
        '
        'fecCuota
        '
        Me.fecCuota.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecCuota.Location = New System.Drawing.Point(663, 21)
        Me.fecCuota.Name = "fecCuota"
        Me.fecCuota.Size = New System.Drawing.Size(100, 21)
        Me.fecCuota.TabIndex = 25
        '
        'frm_FlotaZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 511)
        Me.Controls.Add(Me.ficDemanda)
        Me.KeyPreview = True
        Me.Name = "frm_FlotaZona"
        Me.Text = "Flota Zona"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdFlota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.griJefe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsJefe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspJefeAsignado.ResumeLayout(False)
        Me.tspJefeAsignado.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cboJefeAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.griCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCuotaTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerZonaD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verFlota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDemanda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDemanda As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents verZona As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verFlota As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ogdFlota As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerZonaD2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboJefeAsignado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents tspJefeAsignado As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents griJefe As ISL.Controles.Grilla
    Friend WithEvents udsJefe As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numCuotaTracto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents griCuota As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnQuitarCuota As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarCuota As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecCuota As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
End Class
