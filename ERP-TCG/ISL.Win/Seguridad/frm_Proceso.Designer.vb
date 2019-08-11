<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proceso
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Protegido")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Protegido")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Orden")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Proceso))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalProcesos = New ISL.Controles.Agrupacion(Me.components)
        Me.griProceso = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ordProceso = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrProceso = New ISL.Controles.Agrupacion(Me.components)
        Me.verExplorador = New ISL.Controles.Chequear(Me.components)
        Me.nroOrden = New ISL.Controles.Numero(Me.components)
        Me.etiOrden = New ISL.Controles.Etiqueta(Me.components)
        Me.verProtegido = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.etiAbreviatura = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.ficProceso = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrTotalProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalProcesos.SuspendLayout()
        CType(Me.griProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ordProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProceso.SuspendLayout()
        CType(Me.verExplorador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verProtegido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficProceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrTotalProcesos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(700, 433)
        '
        'agrTotalProcesos
        '
        Me.agrTotalProcesos.Controls.Add(Me.griProceso)
        Me.agrTotalProcesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalProcesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalProcesos.ForeColor = System.Drawing.Color.Black
        Me.agrTotalProcesos.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalProcesos.Name = "agrTotalProcesos"
        Me.agrTotalProcesos.Size = New System.Drawing.Size(700, 433)
        Me.agrTotalProcesos.TabIndex = 1
        Me.agrTotalProcesos.Text = "Total de Procesos"
        Me.agrTotalProcesos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griProceso
        '
        Me.griProceso.ContextMenuStrip = Me.MenuContextual1
        Me.griProceso.DataSource = Me.ordProceso
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 245
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProceso.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griProceso.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProceso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griProceso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProceso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProceso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProceso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProceso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProceso.Location = New System.Drawing.Point(2, 18)
        Me.griProceso.Name = "griProceso"
        Me.griProceso.Size = New System.Drawing.Size(696, 413)
        Me.griProceso.TabIndex = 1
        Me.griProceso.Text = "Información de Procesos"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Proceso"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EditarToolStripMenuItem.Text = "Actualizar"
        Me.EditarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Proceso seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Proceso seleccionado"
        '
        'ordProceso
        '
        UltraDataColumn5.DataType = GetType(Boolean)
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Boolean)
        Me.ordProceso.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrProceso)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(700, 433)
        '
        'agrProceso
        '
        Me.agrProceso.Controls.Add(Me.verExplorador)
        Me.agrProceso.Controls.Add(Me.nroOrden)
        Me.agrProceso.Controls.Add(Me.etiOrden)
        Me.agrProceso.Controls.Add(Me.verProtegido)
        Me.agrProceso.Controls.Add(Me.txtAbreviatura)
        Me.agrProceso.Controls.Add(Me.txtNombre)
        Me.agrProceso.Controls.Add(Me.txtCodigo)
        Me.agrProceso.Controls.Add(Me.verActivo)
        Me.agrProceso.Controls.Add(Me.etiAbreviatura)
        Me.agrProceso.Controls.Add(Me.etiNombre)
        Me.agrProceso.Controls.Add(Me.etiCodigo)
        Me.agrProceso.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProceso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProceso.Location = New System.Drawing.Point(0, 0)
        Me.agrProceso.Name = "agrProceso"
        Me.agrProceso.Size = New System.Drawing.Size(700, 231)
        Me.agrProceso.TabIndex = 0
        Me.agrProceso.Text = "Datos"
        Me.agrProceso.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'verExplorador
        '
        Me.verExplorador.AutoSize = True
        Me.verExplorador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verExplorador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verExplorador.Location = New System.Drawing.Point(125, 144)
        Me.verExplorador.Name = "verExplorador"
        Me.verExplorador.Size = New System.Drawing.Size(74, 17)
        Me.verExplorador.TabIndex = 14
        Me.verExplorador.Text = "Explorador"
        '
        'nroOrden
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nroOrden.Appearance = Appearance1
        Me.nroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nroOrden.Location = New System.Drawing.Point(125, 117)
        Me.nroOrden.MaxValue = 999
        Me.nroOrden.MinValue = 0
        Me.nroOrden.Name = "nroOrden"
        Me.nroOrden.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.nroOrden.Size = New System.Drawing.Size(68, 21)
        Me.nroOrden.TabIndex = 13
        '
        'etiOrden
        '
        Me.etiOrden.AutoSize = True
        Me.etiOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiOrden.Location = New System.Drawing.Point(70, 121)
        Me.etiOrden.Name = "etiOrden"
        Me.etiOrden.Size = New System.Drawing.Size(38, 14)
        Me.etiOrden.TabIndex = 8
        Me.etiOrden.Text = "Orden:"
        '
        'verProtegido
        '
        Me.verProtegido.AutoSize = True
        Me.verProtegido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verProtegido.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verProtegido.Location = New System.Drawing.Point(125, 167)
        Me.verProtegido.Name = "verProtegido"
        Me.verProtegido.Size = New System.Drawing.Size(68, 17)
        Me.verProtegido.TabIndex = 7
        Me.verProtegido.Text = "Protegido"
        '
        'txtAbreviatura
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance2
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(125, 90)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(166, 21)
        Me.txtAbreviatura.TabIndex = 6
        '
        'txtNombre
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(125, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(429, 21)
        Me.txtNombre.TabIndex = 5
        '
        'txtCodigo
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance4
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(125, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(166, 21)
        Me.txtCodigo.TabIndex = 4
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(125, 190)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 3
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'etiAbreviatura
        '
        Me.etiAbreviatura.AutoSize = True
        Me.etiAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAbreviatura.Location = New System.Drawing.Point(45, 94)
        Me.etiAbreviatura.Name = "etiAbreviatura"
        Me.etiAbreviatura.Size = New System.Drawing.Size(63, 14)
        Me.etiAbreviatura.TabIndex = 2
        Me.etiAbreviatura.Text = "Abreviatura:"
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(62, 67)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 1
        Me.etiNombre.Text = "Nombre:"
        '
        'etiCodigo
        '
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(66, 40)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 0
        Me.etiCodigo.Text = "Código:"
        '
        'ficProceso
        '
        Me.ficProceso.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficProceso.Controls.Add(Me.UltraTabPageControl1)
        Me.ficProceso.Controls.Add(Me.UltraTabPageControl2)
        Me.ficProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficProceso.Location = New System.Drawing.Point(0, 0)
        Me.ficProceso.Name = "ficProceso"
        Me.ficProceso.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficProceso.Size = New System.Drawing.Size(702, 456)
        Me.ficProceso.TabIndex = 0
        UltraTab1.Key = "ficLista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "ficMantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficProceso.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficProceso.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(700, 433)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckPathExists = False
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_Proceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 456)
        Me.Controls.Add(Me.ficProceso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Proceso"
        Me.Text = "Procesos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrTotalProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalProcesos.ResumeLayout(False)
        CType(Me.griProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ordProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProceso.ResumeLayout(False)
        Me.agrProceso.PerformLayout()
        CType(Me.verExplorador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verProtegido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficProceso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficProceso As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ordProceso As ISL.Controles.OrigenDatos
    Friend WithEvents agrProceso As ISL.Controles.Agrupacion
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents etiAbreviatura As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents verProtegido As ISL.Controles.Chequear
    Friend WithEvents etiOrden As ISL.Controles.Etiqueta
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents nroOrden As ISL.Controles.Numero
    Friend WithEvents agrTotalProcesos As ISL.Controles.Agrupacion
    Friend WithEvents griProceso As ISL.Controles.Grilla
    Friend WithEvents verExplorador As ISL.Controles.Chequear
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
