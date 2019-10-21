<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Perfil
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProcesoNegocio")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProcesoNegocio")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrGrillaPerfil = New ISL.Controles.Agrupacion(Me.components)
        Me.griPerfil = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAcciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrActividadNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.scActividadNegocio = New System.Windows.Forms.SplitContainer()
        Me.griActNegSel = New ISL.Controles.Grilla(Me.components)
        Me.agrBusquedaAN = New ISL.Controles.Agrupacion(Me.components)
        Me.cboProNegBus = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.griActividadNegocio = New ISL.Controles.Grilla(Me.components)
        Me.orgActividadNegocio = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrPerfil = New ISL.Controles.Agrupacion(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.etiAbreviatura = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.agrUsuarios = New ISL.Controles.Agrupacion(Me.components)
        Me.griUsuario = New ISL.Controles.Grilla(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.agrAcciones = New ISL.Controles.Agrupacion(Me.components)
        Me.griActividadRestringida = New ISL.Controles.Grilla(Me.components)
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProcesoNegocio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAccionSistema = New ISL.Controles.Combo(Me.components)
        Me.agrActividadesRestringidas = New ISL.Controles.Agrupacion(Me.components)
        Me.griActividadRestringidaUsuario = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual2 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiGrabar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAplicarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ficPerfil = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrGrillaPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGrillaPerfil.SuspendLayout()
        CType(Me.griPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrActividadNegocio.SuspendLayout()
        CType(Me.scActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scActividadNegocio.Panel1.SuspendLayout()
        Me.scActividadNegocio.Panel2.SuspendLayout()
        Me.scActividadNegocio.SuspendLayout()
        CType(Me.griActNegSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusquedaAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusquedaAN.SuspendLayout()
        CType(Me.cboProNegBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orgActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrPerfil.SuspendLayout()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.agrUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrUsuarios.SuspendLayout()
        CType(Me.griUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.agrAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrAcciones.SuspendLayout()
        CType(Me.griActividadRestringida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAccionSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrActividadesRestringidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrActividadesRestringidas.SuspendLayout()
        CType(Me.griActividadRestringidaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual2.SuspendLayout()
        CType(Me.ficPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPerfil.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrGrillaPerfil)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(984, 390)
        '
        'agrGrillaPerfil
        '
        Me.agrGrillaPerfil.Controls.Add(Me.griPerfil)
        Me.agrGrillaPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrGrillaPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGrillaPerfil.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrGrillaPerfil.Location = New System.Drawing.Point(0, 0)
        Me.agrGrillaPerfil.Name = "agrGrillaPerfil"
        Me.agrGrillaPerfil.Size = New System.Drawing.Size(984, 390)
        Me.agrGrillaPerfil.TabIndex = 1
        Me.agrGrillaPerfil.Text = "Listado de Perfil"
        Me.agrGrillaPerfil.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPerfil
        '
        Me.griPerfil.ContextMenuStrip = Me.MenuContextual1
        Me.griPerfil.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPerfil.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPerfil.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPerfil.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPerfil.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPerfil.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPerfil.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPerfil.Location = New System.Drawing.Point(3, 16)
        Me.griPerfil.Name = "griPerfil"
        Me.griPerfil.Size = New System.Drawing.Size(978, 371)
        Me.griPerfil.TabIndex = 0
        Me.griPerfil.Text = "Información sobre perfiles"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.ToolStripSeparator1, Me.tsmiExportar, Me.tsmiAcciones})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(159, 120)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(158, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        Me.tsmiNuevo.ToolTipText = "Insertar un nuevo Perfil"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(158, 22)
        Me.tsmiEditar.Text = "Editar"
        Me.tsmiEditar.ToolTipText = "Actualizar o modificar el Perfil seleccionado"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(158, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        Me.tsmiEliminar.ToolTipText = "Eliminar el Perfil seleccionado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'tsmiExportar
        '
        Me.tsmiExportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.tsmiExportar.Name = "tsmiExportar"
        Me.tsmiExportar.Size = New System.Drawing.Size(158, 22)
        Me.tsmiExportar.Text = "Exportar"
        '
        'tsmiAcciones
        '
        Me.tsmiAcciones.Image = Global.ISL.Win.My.Resources.Resources.Information
        Me.tsmiAcciones.Name = "tsmiAcciones"
        Me.tsmiAcciones.Size = New System.Drawing.Size(158, 22)
        Me.tsmiAcciones.Text = "Acciones Sistema"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrActividadNegocio)
        Me.UltraTabPageControl2.Controls.Add(Me.agrPerfil)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(984, 390)
        '
        'agrActividadNegocio
        '
        Me.agrActividadNegocio.Controls.Add(Me.scActividadNegocio)
        Me.agrActividadNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrActividadNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrActividadNegocio.Location = New System.Drawing.Point(0, 60)
        Me.agrActividadNegocio.Name = "agrActividadNegocio"
        Me.agrActividadNegocio.Size = New System.Drawing.Size(984, 330)
        Me.agrActividadNegocio.TabIndex = 2
        Me.agrActividadNegocio.Text = "Actividad de Negocio:"
        Me.agrActividadNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'scActividadNegocio
        '
        Me.scActividadNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scActividadNegocio.Location = New System.Drawing.Point(3, 16)
        Me.scActividadNegocio.Name = "scActividadNegocio"
        '
        'scActividadNegocio.Panel1
        '
        Me.scActividadNegocio.Panel1.Controls.Add(Me.griActNegSel)
        Me.scActividadNegocio.Panel1.Controls.Add(Me.agrBusquedaAN)
        '
        'scActividadNegocio.Panel2
        '
        Me.scActividadNegocio.Panel2.Controls.Add(Me.griActividadNegocio)
        Me.scActividadNegocio.Size = New System.Drawing.Size(978, 311)
        Me.scActividadNegocio.SplitterDistance = 445
        Me.scActividadNegocio.TabIndex = 2
        '
        'griActNegSel
        '
        Me.griActNegSel.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griActNegSel.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griActNegSel.DisplayLayout.MaxColScrollRegions = 1
        Me.griActNegSel.DisplayLayout.MaxRowScrollRegions = 1
        Me.griActNegSel.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griActNegSel.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griActNegSel.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griActNegSel.DisplayLayout.Override.CellPadding = 0
        Me.griActNegSel.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griActNegSel.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griActNegSel.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griActNegSel.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griActNegSel.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griActNegSel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griActNegSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griActNegSel.Location = New System.Drawing.Point(0, 39)
        Me.griActNegSel.Name = "griActNegSel"
        Me.griActNegSel.Size = New System.Drawing.Size(445, 272)
        Me.griActNegSel.TabIndex = 1
        Me.griActNegSel.Text = "Grilla1"
        '
        'agrBusquedaAN
        '
        Me.agrBusquedaAN.Controls.Add(Me.cboProNegBus)
        Me.agrBusquedaAN.Controls.Add(Me.Etiqueta3)
        Me.agrBusquedaAN.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusquedaAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusquedaAN.ForeColor = System.Drawing.Color.Black
        Me.agrBusquedaAN.Location = New System.Drawing.Point(0, 0)
        Me.agrBusquedaAN.Name = "agrBusquedaAN"
        Me.agrBusquedaAN.Size = New System.Drawing.Size(445, 39)
        Me.agrBusquedaAN.TabIndex = 0
        Me.agrBusquedaAN.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboProNegBus
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboProNegBus.Appearance = Appearance1
        Me.cboProNegBus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProNegBus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProNegBus.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProNegBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProNegBus.ForeColor = System.Drawing.Color.Black
        Me.cboProNegBus.Location = New System.Drawing.Point(106, 8)
        Me.cboProNegBus.Name = "cboProNegBus"
        Me.cboProNegBus.Size = New System.Drawing.Size(322, 21)
        Me.cboProNegBus.TabIndex = 17
        Me.cboProNegBus.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance2
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(10, 12)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta3.TabIndex = 16
        Me.Etiqueta3.Text = "Proceso Negocio:"
        '
        'griActividadNegocio
        '
        Me.griActividadNegocio.DataSource = Me.orgActividadNegocio
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.griActividadNegocio.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griActividadNegocio.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griActividadNegocio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griActividadNegocio.DisplayLayout.MaxColScrollRegions = 1
        Me.griActividadNegocio.DisplayLayout.MaxRowScrollRegions = 1
        Me.griActividadNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griActividadNegocio.Location = New System.Drawing.Point(0, 0)
        Me.griActividadNegocio.Name = "griActividadNegocio"
        Me.griActividadNegocio.Size = New System.Drawing.Size(529, 311)
        Me.griActividadNegocio.TabIndex = 1
        '
        'orgActividadNegocio
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        Me.orgActividadNegocio.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn11.DataType = GetType(Boolean)
        Me.orgActividadNegocio.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'agrPerfil
        '
        Me.agrPerfil.Controls.Add(Me.txtAbreviatura)
        Me.agrPerfil.Controls.Add(Me.txtNombre)
        Me.agrPerfil.Controls.Add(Me.txtCodigo)
        Me.agrPerfil.Controls.Add(Me.verActivo)
        Me.agrPerfil.Controls.Add(Me.etiAbreviatura)
        Me.agrPerfil.Controls.Add(Me.etiNombre)
        Me.agrPerfil.Controls.Add(Me.etiCodigo)
        Me.agrPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPerfil.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrPerfil.Location = New System.Drawing.Point(0, 0)
        Me.agrPerfil.Name = "agrPerfil"
        Me.agrPerfil.Size = New System.Drawing.Size(984, 60)
        Me.agrPerfil.TabIndex = 0
        Me.agrPerfil.Text = "Datos:"
        Me.agrPerfil.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtAbreviatura
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance3
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(236, 29)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(166, 21)
        Me.txtAbreviatura.TabIndex = 21
        '
        'txtNombre
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance4
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(460, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(429, 21)
        Me.txtNombre.TabIndex = 20
        '
        'txtCodigo
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance5
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(59, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(102, 21)
        Me.txtCodigo.TabIndex = 19
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(896, 27)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 18
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'etiAbreviatura
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.etiAbreviatura.Appearance = Appearance6
        Me.etiAbreviatura.AutoSize = True
        Me.etiAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAbreviatura.Location = New System.Drawing.Point(168, 31)
        Me.etiAbreviatura.Name = "etiAbreviatura"
        Me.etiAbreviatura.Size = New System.Drawing.Size(63, 14)
        Me.etiAbreviatura.TabIndex = 17
        Me.etiAbreviatura.Text = "Abreviatura:"
        '
        'etiNombre
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.etiNombre.Appearance = Appearance7
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(409, 31)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 16
        Me.etiNombre.Text = "Nombre:"
        '
        'etiCodigo
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.etiCodigo.Appearance = Appearance8
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(12, 31)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 15
        Me.etiCodigo.Text = "Código:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(984, 390)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.agrUsuarios)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 390)
        Me.SplitContainer1.SplitterDistance = 355
        Me.SplitContainer1.TabIndex = 0
        '
        'agrUsuarios
        '
        Me.agrUsuarios.Controls.Add(Me.griUsuario)
        Me.agrUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrUsuarios.ForeColor = System.Drawing.Color.Black
        Me.agrUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.agrUsuarios.Name = "agrUsuarios"
        Me.agrUsuarios.Size = New System.Drawing.Size(355, 390)
        Me.agrUsuarios.TabIndex = 0
        Me.agrUsuarios.Text = "Usuarios"
        Me.agrUsuarios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griUsuario
        '
        Me.griUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griUsuario.Location = New System.Drawing.Point(2, 18)
        Me.griUsuario.Name = "griUsuario"
        Me.griUsuario.Size = New System.Drawing.Size(351, 370)
        Me.griUsuario.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.agrAcciones)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.agrActividadesRestringidas)
        Me.SplitContainer2.Size = New System.Drawing.Size(625, 390)
        Me.SplitContainer2.SplitterDistance = 195
        Me.SplitContainer2.TabIndex = 0
        '
        'agrAcciones
        '
        Me.agrAcciones.Controls.Add(Me.griActividadRestringida)
        Me.agrAcciones.Controls.Add(Me.agrBusqueda)
        Me.agrAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrAcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrAcciones.ForeColor = System.Drawing.Color.Black
        Me.agrAcciones.Location = New System.Drawing.Point(0, 0)
        Me.agrAcciones.Name = "agrAcciones"
        Me.agrAcciones.Size = New System.Drawing.Size(625, 195)
        Me.agrAcciones.TabIndex = 0
        Me.agrAcciones.Text = "Configuracion de Acciones de sistema por Proceso"
        Me.agrAcciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griActividadRestringida
        '
        Me.griActividadRestringida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griActividadRestringida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griActividadRestringida.Location = New System.Drawing.Point(2, 59)
        Me.griActividadRestringida.Name = "griActividadRestringida"
        Me.griActividadRestringida.Size = New System.Drawing.Size(621, 134)
        Me.griActividadRestringida.TabIndex = 1
        Me.griActividadRestringida.Text = "Actividades de Negocio"
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.cboProcesoNegocio)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Controls.Add(Me.cboAccionSistema)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(2, 18)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(621, 41)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(12, 12)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Proceso Negocio:"
        '
        'cboProcesoNegocio
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.cboProcesoNegocio.Appearance = Appearance9
        Me.cboProcesoNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProcesoNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcesoNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboProcesoNegocio.Location = New System.Drawing.Point(109, 8)
        Me.cboProcesoNegocio.Name = "cboProcesoNegocio"
        Me.cboProcesoNegocio.Size = New System.Drawing.Size(267, 21)
        Me.cboProcesoNegocio.TabIndex = 2
        Me.cboProcesoNegocio.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(382, 12)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Accion:"
        '
        'cboAccionSistema
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboAccionSistema.Appearance = Appearance10
        Me.cboAccionSistema.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAccionSistema.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAccionSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccionSistema.ForeColor = System.Drawing.Color.Black
        Me.cboAccionSistema.Location = New System.Drawing.Point(428, 8)
        Me.cboAccionSistema.Name = "cboAccionSistema"
        Me.cboAccionSistema.Size = New System.Drawing.Size(175, 21)
        Me.cboAccionSistema.TabIndex = 0
        Me.cboAccionSistema.ValueMember = "Id"
        '
        'agrActividadesRestringidas
        '
        Me.agrActividadesRestringidas.Controls.Add(Me.griActividadRestringidaUsuario)
        Me.agrActividadesRestringidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrActividadesRestringidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrActividadesRestringidas.ForeColor = System.Drawing.Color.Black
        Me.agrActividadesRestringidas.Location = New System.Drawing.Point(0, 0)
        Me.agrActividadesRestringidas.Name = "agrActividadesRestringidas"
        Me.agrActividadesRestringidas.Size = New System.Drawing.Size(625, 191)
        Me.agrActividadesRestringidas.TabIndex = 0
        Me.agrActividadesRestringidas.Text = "Actividades Asociadas por Usuario"
        Me.agrActividadesRestringidas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griActividadRestringidaUsuario
        '
        Me.griActividadRestringidaUsuario.ContextMenuStrip = Me.MenuContextual2
        Me.griActividadRestringidaUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griActividadRestringidaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griActividadRestringidaUsuario.Location = New System.Drawing.Point(2, 18)
        Me.griActividadRestringidaUsuario.Name = "griActividadRestringidaUsuario"
        Me.griActividadRestringidaUsuario.Size = New System.Drawing.Size(621, 171)
        Me.griActividadRestringidaUsuario.TabIndex = 0
        '
        'MenuContextual2
        '
        Me.MenuContextual2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual2.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGrabar, Me.tsmiAplicarTodo})
        Me.MenuContextual2.Name = "MenuContextual2"
        Me.MenuContextual2.Size = New System.Drawing.Size(188, 48)
        '
        'tsmiGrabar
        '
        Me.tsmiGrabar.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.tsmiGrabar.Name = "tsmiGrabar"
        Me.tsmiGrabar.Size = New System.Drawing.Size(187, 22)
        Me.tsmiGrabar.Text = "Aplicar"
        '
        'tsmiAplicarTodo
        '
        Me.tsmiAplicarTodo.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.tsmiAplicarTodo.Name = "tsmiAplicarTodo"
        Me.tsmiAplicarTodo.Size = New System.Drawing.Size(187, 22)
        Me.tsmiAplicarTodo.Text = "Aplicar a Todos Usuario"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ficPerfil
        '
        Me.ficPerfil.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficPerfil.Controls.Add(Me.UltraTabPageControl1)
        Me.ficPerfil.Controls.Add(Me.UltraTabPageControl2)
        Me.ficPerfil.Controls.Add(Me.UltraTabPageControl3)
        Me.ficPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPerfil.Location = New System.Drawing.Point(0, 0)
        Me.ficPerfil.Name = "ficPerfil"
        Me.ficPerfil.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficPerfil.Size = New System.Drawing.Size(986, 413)
        Me.ficPerfil.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Asociar Acciones"
        Me.ficPerfil.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficPerfil.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(984, 390)
        '
        'frm_Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 413)
        Me.Controls.Add(Me.ficPerfil)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Perfil"
        Me.Text = "Perfil de Usuario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrGrillaPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGrillaPerfil.ResumeLayout(False)
        CType(Me.griPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrActividadNegocio.ResumeLayout(False)
        Me.scActividadNegocio.Panel1.ResumeLayout(False)
        Me.scActividadNegocio.Panel2.ResumeLayout(False)
        CType(Me.scActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scActividadNegocio.ResumeLayout(False)
        CType(Me.griActNegSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusquedaAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusquedaAN.ResumeLayout(False)
        Me.agrBusquedaAN.PerformLayout()
        CType(Me.cboProNegBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orgActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrPerfil.ResumeLayout(False)
        Me.agrPerfil.PerformLayout()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.agrUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrUsuarios.ResumeLayout(False)
        CType(Me.griUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.agrAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrAcciones.ResumeLayout(False)
        CType(Me.griActividadRestringida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAccionSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrActividadesRestringidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrActividadesRestringidas.ResumeLayout(False)
        CType(Me.griActividadRestringidaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual2.ResumeLayout(False)
        CType(Me.ficPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPerfil.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficPerfil As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griPerfil As ISL.Controles.Grilla
    Friend WithEvents agrGrillaPerfil As ISL.Controles.Agrupacion
    Friend WithEvents agrPerfil As ISL.Controles.Agrupacion
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents etiAbreviatura As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents agrActividadNegocio As ISL.Controles.Agrupacion
    Friend WithEvents griActividadNegocio As ISL.Controles.Grilla
    Friend WithEvents orgActividadNegocio As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents agrUsuarios As ISL.Controles.Agrupacion
    Friend WithEvents griUsuario As ISL.Controles.Grilla
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents agrAcciones As ISL.Controles.Agrupacion
    Friend WithEvents agrActividadesRestringidas As ISL.Controles.Agrupacion
    Friend WithEvents griActividadRestringida As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents griActividadRestringidaUsuario As ISL.Controles.Grilla
    Friend WithEvents tsmiAcciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboAccionSistema As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboProcesoNegocio As ISL.Controles.Combo
    Friend WithEvents MenuContextual2 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiGrabar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAplicarTodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scActividadNegocio As System.Windows.Forms.SplitContainer
    Friend WithEvents agrBusquedaAN As ISL.Controles.Agrupacion
    Friend WithEvents griActNegSel As ISL.Controles.Grilla
    Friend WithEvents cboProNegBus As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
End Class
