<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoMovimientoInventario
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrLista = New ISL.Controles.Agrupacion(Me.components)
        Me.griTipoMovimientoInventario = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.odMovimientoInventario = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrMantenimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficTipoMovimientoInventario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLista.SuspendLayout()
        CType(Me.griTipoMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMantenimiento.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficTipoMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficTipoMovimientoInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrLista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(753, 391)
        '
        'agrLista
        '
        Me.agrLista.Controls.Add(Me.griTipoMovimientoInventario)
        Me.agrLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrLista.Location = New System.Drawing.Point(0, 0)
        Me.agrLista.Name = "agrLista"
        Me.agrLista.Size = New System.Drawing.Size(753, 391)
        Me.agrLista.TabIndex = 0
        Me.agrLista.Text = "Total de Tipo de Movimientos de Inventario:"
        Me.agrLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griTipoMovimientoInventario
        '
        Me.griTipoMovimientoInventario.ContextMenuStrip = Me.MenuContextual1
        Me.griTipoMovimientoInventario.DataSource = Me.odMovimientoInventario
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance10
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 70
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 443
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 120
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.griTipoMovimientoInventario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTipoMovimientoInventario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTipoMovimientoInventario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griTipoMovimientoInventario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BorderColor = System.Drawing.Color.Silver
        Me.griTipoMovimientoInventario.DisplayLayout.Override.CellAppearance = Appearance7
        Me.griTipoMovimientoInventario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTipoMovimientoInventario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTipoMovimientoInventario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTipoMovimientoInventario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.griTipoMovimientoInventario.DisplayLayout.Override.RowAppearance = Appearance8
        Me.griTipoMovimientoInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTipoMovimientoInventario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTipoMovimientoInventario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTipoMovimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTipoMovimientoInventario.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTipoMovimientoInventario.Location = New System.Drawing.Point(2, 18)
        Me.griTipoMovimientoInventario.Name = "griTipoMovimientoInventario"
        Me.griTipoMovimientoInventario.Size = New System.Drawing.Size(749, 371)
        Me.griTipoMovimientoInventario.TabIndex = 1
        Me.griTipoMovimientoInventario.Text = "Listado de Tipo de Movimiento de Inventario"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Tipo de Movimiento de Inventario"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Tipo de Movimiento de Inventario seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Tipo de Movimiento de Inventario seleccionado"
        '
        'odMovimientoInventario
        '
        UltraDataColumn5.DataType = GetType(Boolean)
        Me.odMovimientoInventario.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrMantenimiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(753, 391)
        '
        'agrMantenimiento
        '
        Me.agrMantenimiento.Controls.Add(Me.txtId)
        Me.agrMantenimiento.Controls.Add(Me.txtCodigo)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta1)
        Me.agrMantenimiento.Controls.Add(Me.verActivo)
        Me.agrMantenimiento.Controls.Add(Me.txtAbreviatura)
        Me.agrMantenimiento.Controls.Add(Me.txtNombre)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta3)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta2)
        Me.agrMantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMantenimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.agrMantenimiento.Name = "agrMantenimiento"
        Me.agrMantenimiento.Size = New System.Drawing.Size(753, 147)
        Me.agrMantenimiento.TabIndex = 1
        Me.agrMantenimiento.Text = "Dato"
        Me.agrMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(11, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(20, 21)
        Me.txtId.TabIndex = 10
        Me.txtId.Visible = False
        '
        'txtCodigo
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance3
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCodigo.Location = New System.Drawing.Point(96, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Tag = "0"
        '
        'Etiqueta1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance4
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(47, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta1.TabIndex = 8
        Me.Etiqueta1.Text = "Código:"
        '
        'verActivo
        '
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(96, 100)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(120, 20)
        Me.verActivo.TabIndex = 4
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtAbreviatura
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance1
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtAbreviatura.Location = New System.Drawing.Point(96, 75)
        Me.txtAbreviatura.MaxLength = 10
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(90, 21)
        Me.txtAbreviatura.TabIndex = 3
        '
        'txtNombre
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance2
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtNombre.Location = New System.Drawing.Point(95, 50)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(316, 21)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Tag = "0"
        '
        'Etiqueta3
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance6
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta3.Location = New System.Drawing.Point(27, 75)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Abreviatura:"
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(46, 52)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Nombre:"
        '
        'ficTipoMovimientoInventario
        '
        Me.ficTipoMovimientoInventario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficTipoMovimientoInventario.Controls.Add(Me.UltraTabPageControl1)
        Me.ficTipoMovimientoInventario.Controls.Add(Me.UltraTabPageControl2)
        Me.ficTipoMovimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficTipoMovimientoInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficTipoMovimientoInventario.Location = New System.Drawing.Point(0, 0)
        Me.ficTipoMovimientoInventario.Name = "ficTipoMovimientoInventario"
        Me.ficTipoMovimientoInventario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficTipoMovimientoInventario.Size = New System.Drawing.Size(755, 414)
        Me.ficTipoMovimientoInventario.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficTipoMovimientoInventario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficTipoMovimientoInventario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(753, 391)
        '
        'frm_TipoMovimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(755, 414)
        Me.Controls.Add(Me.ficTipoMovimientoInventario)
        Me.Name = "frm_TipoMovimientoInventario"
        Me.Text = "Tipo de Movimiento de Inventario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLista.ResumeLayout(False)
        CType(Me.griTipoMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMantenimiento.ResumeLayout(False)
        Me.agrMantenimiento.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficTipoMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficTipoMovimientoInventario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficTipoMovimientoInventario As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrLista As ISL.Controles.Agrupacion
    Friend WithEvents griTipoMovimientoInventario As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMantenimiento As ISL.Controles.Agrupacion
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents odMovimientoInventario As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
