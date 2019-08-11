<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TarifasProveedor
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigencia")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TarifasProveedor))
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarifasProveedor = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdTarifasProveedor = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.cboLugar = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.numImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiNumero = New ISL.Controles.Etiqueta(Me.components)
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griTarifasProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ogdTarifasProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griTarifasProveedor)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(997, 203)
        '
        'griTarifasProveedor
        '
        Me.griTarifasProveedor.ContextMenuStrip = Me.MenuContextual1
        Me.griTarifasProveedor.DataSource = Me.ogdTarifasProveedor
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griTarifasProveedor.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Width = 130
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 215
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance2
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn10.CellButtonAppearance = Appearance3
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn10.Header.Appearance = Appearance4
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.MaskInput = "{double:9.4}"
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn10.Width = 102
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Width = 198
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Width = 204
        UltraGridColumn15.Header.Caption = "Carga"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Width = 126
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.griTarifasProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTarifasProveedor.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.griTarifasProveedor.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.griTarifasProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasProveedor.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasProveedor.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.griTarifasProveedor.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifasProveedor.DisplayLayout.MaxRowScrollRegions = 1
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Appearance8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griTarifasProveedor.DisplayLayout.Override.ActiveCellAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.SystemColors.Highlight
        Appearance9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griTarifasProveedor.DisplayLayout.Override.ActiveRowAppearance = Appearance9
        Me.griTarifasProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griTarifasProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Me.griTarifasProveedor.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griTarifasProveedor.DisplayLayout.Override.CellAppearance = Appearance11
        Me.griTarifasProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTarifasProveedor.DisplayLayout.Override.CellPadding = 0
        Appearance12.BackColor = System.Drawing.SystemColors.Control
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.griTarifasProveedor.DisplayLayout.Override.GroupByRowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Left"
        Me.griTarifasProveedor.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.griTarifasProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifasProveedor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Me.griTarifasProveedor.DisplayLayout.Override.RowAppearance = Appearance14
        Me.griTarifasProveedor.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.griTarifasProveedor.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.griTarifasProveedor.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griTarifasProveedor.DisplayLayout.Override.TemplateAddRowAppearance = Appearance15
        Me.griTarifasProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifasProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarifasProveedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griTarifasProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifasProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifasProveedor.Location = New System.Drawing.Point(0, 0)
        Me.griTarifasProveedor.Name = "griTarifasProveedor"
        Me.griTarifasProveedor.Size = New System.Drawing.Size(997, 203)
        Me.griTarifasProveedor.TabIndex = 1
        Me.griTarifasProveedor.Text = "Grilla1"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ExportarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(114, 48)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Marca"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        Me.ExportarToolStripMenuItem.ToolTipText = "Exportar"
        '
        'ogdTarifasProveedor
        '
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Integer)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Double)
        Me.ogdTarifasProveedor.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Boton1)
        Me.UltraTabPageControl2.Controls.Add(Me.btnAprobar)
        Me.UltraTabPageControl2.Controls.Add(Me.cboLugar)
        Me.UltraTabPageControl2.Controls.Add(Me.Etiqueta1)
        Me.UltraTabPageControl2.Controls.Add(Me.numImporte)
        Me.UltraTabPageControl2.Controls.Add(Me.etiNumero)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(784, 203)
        '
        'Boton1
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance16.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.Boton1.Appearance = Appearance16
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.Location = New System.Drawing.Point(172, 87)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(78, 27)
        Me.Boton1.TabIndex = 333
        Me.Boton1.Text = "Cancelar"
        Me.Boton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAprobar
        '
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.btnAprobar.Appearance = Appearance17
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.Location = New System.Drawing.Point(65, 87)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(78, 27)
        Me.btnAprobar.TabIndex = 332
        Me.btnAprobar.Text = "Guardar"
        Me.btnAprobar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'cboLugar
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Appearance = Appearance18
        Me.cboLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Location = New System.Drawing.Point(106, 40)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(229, 21)
        Me.cboLugar.TabIndex = 26
        Me.cboLugar.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance19
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(65, 44)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta1.TabIndex = 25
        Me.Etiqueta1.Text = "Lugar:"
        '
        'numImporte
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.numImporte.Appearance = Appearance20
        Me.numImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numImporte.ForeColor = System.Drawing.Color.Black
        Me.numImporte.FormatString = "#,##0.00"
        Me.numImporte.Location = New System.Drawing.Point(106, 8)
        Me.numImporte.Name = "numImporte"
        Me.numImporte.Nullable = True
        Me.numImporte.NullText = "0.00"
        Me.numImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numImporte.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numImporte.Size = New System.Drawing.Size(88, 21)
        Me.numImporte.TabIndex = 24
        '
        'etiNumero
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.etiNumero.Appearance = Appearance21
        Me.etiNumero.AutoSize = True
        Me.etiNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNumero.ForeColor = System.Drawing.Color.Black
        Me.etiNumero.Location = New System.Drawing.Point(11, 12)
        Me.etiNumero.Name = "etiNumero"
        Me.etiNumero.Size = New System.Drawing.Size(89, 14)
        Me.etiNumero.TabIndex = 13
        Me.etiNumero.Text = "Importe(Sin IGV):"
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl1)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl2)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(0, 0)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Ficha1.Size = New System.Drawing.Size(999, 226)
        Me.Ficha1.TabIndex = 500
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.Ficha1.TabStop = False
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(997, 203)
        '
        'frm_TarifasProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 226)
        Me.Controls.Add(Me.Ficha1)
        Me.Name = "frm_TarifasProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas Proveedor"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griTarifasProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ogdTarifasProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdTarifasProveedor As ISL.Controles.OrigenDatos
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griTarifasProveedor As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents etiNumero As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents numImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents cboLugar As ISL.Controles.Combo
    Friend WithEvents Boton1 As ISL.Controles.Boton
    Friend WithEvents btnAprobar As ISL.Controles.Boton
End Class
