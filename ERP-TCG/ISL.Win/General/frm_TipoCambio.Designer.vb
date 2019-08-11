<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoCambio
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaOrigen")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaDestino")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCambio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CambioCompra")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CambioVenta")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaOrigen")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaDestino")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCambio")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CambioCompra")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CambioVenta")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.gridTipoCambio = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.NroDecimales = New ISL.Controles.Numerador(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Año1 = New ISL.Win.Año
        Me.Meses1 = New ISL.Win.Meses
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.decCambioCompra = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decCambioVenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaCambio = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMonedaDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMonedaOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.tcTipoCambio = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gridTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.NroDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decCambioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decCambioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonedaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonedaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTipoCambio.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridTipoCambio)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(697, 490)
        '
        'gridTipoCambio
        '
        Me.gridTipoCambio.ContextMenuStrip = Me.MenuContextual1
        Me.gridTipoCambio.DataSource = Me.UltraDataSource2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Moneda Origen"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Monde Destino"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Format = "#,##0.000"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Format = "#,##0.000"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.gridTipoCambio.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridTipoCambio.DisplayLayout.MaxColScrollRegions = 1
        Me.gridTipoCambio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridTipoCambio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridTipoCambio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridTipoCambio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridTipoCambio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridTipoCambio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridTipoCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridTipoCambio.Location = New System.Drawing.Point(0, 56)
        Me.gridTipoCambio.Name = "gridTipoCambio"
        Me.gridTipoCambio.Size = New System.Drawing.Size(697, 434)
        Me.gridTipoCambio.TabIndex = 3
        Me.gridTipoCambio.Text = "Información del tipo de cambio"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Tipo de Cambio"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Tipo de Cambio seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Tipo de Cambio seleccionado"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.NroDecimales)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion1.Controls.Add(Me.Año1)
        Me.Agrupacion1.Controls.Add(Me.Meses1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(697, 56)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.Text = "Busqueda"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(365, 28)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Decimales:"
        '
        'NroDecimales
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.NroDecimales.Appearance = Appearance7
        Me.NroDecimales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NroDecimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroDecimales.ForeColor = System.Drawing.Color.Black
        Me.NroDecimales.Location = New System.Drawing.Point(436, 24)
        Me.NroDecimales.MaskInput = "n"
        Me.NroDecimales.MaxValue = 6
        Me.NroDecimales.MinValue = 0
        Me.NroDecimales.Name = "NroDecimales"
        Me.NroDecimales.Size = New System.Drawing.Size(37, 21)
        Me.NroDecimales.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NroDecimales.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.NroDecimales, "Indique el número de decimales con que desea visualizar los tipos de cambio")
        Me.NroDecimales.Value = 3
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(218, 28)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(27, 14)
        Me.Etiqueta6.TabIndex = 5
        Me.Etiqueta6.Text = "Año:"
        '
        'Año1
        '
        Me.Año1.Año = 2012
        Me.Año1.Location = New System.Drawing.Point(254, 24)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Año1, "Seleccione el año del tipo de cambio")
        '
        'Meses1
        '
        Me.Meses1.Id = Nothing
        Me.Meses1.Location = New System.Drawing.Point(11, 25)
        Me.Meses1.Name = "Meses1"
        Me.Meses1.Nombre = Nothing
        Me.Meses1.Size = New System.Drawing.Size(160, 22)
        Me.Meses1.TabIndex = 3
        Me.Meses1.Texto = "Mes"
        Me.ToolTip1.SetToolTip(Me.Meses1, "Seleccione el mes del tipo de cambio")
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.WebBrowser1)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(697, 490)
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 107)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(697, 383)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias", System.UriKind.Absolute)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.verActivo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion2.Controls.Add(Me.decCambioCompra)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion2.Controls.Add(Me.decCambioVenta)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Controls.Add(Me.fecFechaCambio)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.cboMonedaDestino)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.cboMonedaOrigen)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(697, 107)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(297, 80)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(120, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(297, 29)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(87, 14)
        Me.Etiqueta5.TabIndex = 26
        Me.Etiqueta5.Text = "Cambio Compra:"
        '
        'decCambioCompra
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.decCambioCompra.Appearance = Appearance2
        Me.decCambioCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCambioCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decCambioCompra.ForeColor = System.Drawing.Color.Black
        Me.decCambioCompra.Location = New System.Drawing.Point(390, 25)
        Me.decCambioCompra.MaskInput = "{double:8.4}"
        Me.decCambioCompra.Name = "decCambioCompra"
        Me.decCambioCompra.NullText = "0.00"
        Me.decCambioCompra.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decCambioCompra.Size = New System.Drawing.Size(100, 21)
        Me.decCambioCompra.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.decCambioCompra, "Ingrese el monto del tipo de cambio de compra")
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(297, 53)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(77, 14)
        Me.Etiqueta4.TabIndex = 24
        Me.Etiqueta4.Text = "Cambio Venta:"
        '
        'decCambioVenta
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.decCambioVenta.Appearance = Appearance5
        Me.decCambioVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCambioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decCambioVenta.ForeColor = System.Drawing.Color.Black
        Me.decCambioVenta.Location = New System.Drawing.Point(390, 50)
        Me.decCambioVenta.MaskInput = "{double:8.4}"
        Me.decCambioVenta.Name = "decCambioVenta"
        Me.decCambioVenta.NullText = "0.00"
        Me.decCambioVenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decCambioVenta.Size = New System.Drawing.Size(100, 21)
        Me.decCambioVenta.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.decCambioVenta, "Ingrese el monto del tipo de cambio de venta")
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(11, 80)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(78, 14)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Fecha Cambio:"
        '
        'fecFechaCambio
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaCambio.Appearance = Appearance6
        Me.fecFechaCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaCambio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaCambio.Location = New System.Drawing.Point(100, 76)
        Me.fecFechaCambio.Name = "fecFechaCambio"
        Me.fecFechaCambio.Size = New System.Drawing.Size(144, 21)
        Me.fecFechaCambio.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.fecFechaCambio, "Seleccione la fecha del tipo de cambio")
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(11, 52)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(87, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Moneda Destino:"
        '
        'cboMonedaDestino
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMonedaDestino.Appearance = Appearance1
        Me.cboMonedaDestino.DisplayMember = "Nombre"
        Me.cboMonedaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaDestino.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMonedaDestino.Location = New System.Drawing.Point(100, 49)
        Me.cboMonedaDestino.Name = "cboMonedaDestino"
        Me.cboMonedaDestino.Size = New System.Drawing.Size(167, 21)
        Me.cboMonedaDestino.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cboMonedaDestino, "Seleccione la moneda de destino del tipo de cambio")
        Me.cboMonedaDestino.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 25)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Moneda Origen:"
        '
        'cboMonedaOrigen
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMonedaOrigen.Appearance = Appearance3
        Me.cboMonedaOrigen.DisplayMember = "Nombre"
        Me.cboMonedaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMonedaOrigen.Location = New System.Drawing.Point(100, 22)
        Me.cboMonedaOrigen.Name = "cboMonedaOrigen"
        Me.cboMonedaOrigen.Size = New System.Drawing.Size(167, 21)
        Me.cboMonedaOrigen.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cboMonedaOrigen, "Seleccione la moneda de origen del tipo de cambio")
        Me.cboMonedaOrigen.ValueMember = "Id"
        '
        'tcTipoCambio
        '
        Me.tcTipoCambio.Controls.Add(Me.UltraTabPageControl1)
        Me.tcTipoCambio.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcTipoCambio.Controls.Add(Me.UltraTabPageControl2)
        Me.tcTipoCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTipoCambio.Location = New System.Drawing.Point(0, 0)
        Me.tcTipoCambio.Name = "tcTipoCambio"
        Me.tcTipoCambio.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcTipoCambio.Size = New System.Drawing.Size(699, 513)
        Me.tcTipoCambio.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcTipoCambio.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcTipoCambio.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(697, 490)
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'frm_TipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 513)
        Me.Controls.Add(Me.tcTipoCambio)
        Me.Name = "frm_TipoCambio"
        Me.Text = "Tipo de Cambio"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.gridTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.NroDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decCambioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decCambioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonedaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonedaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTipoCambio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTipoCambio As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridTipoCambio As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents fecFechaCambio As ISL.Controles.Fecha
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboMonedaDestino As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboMonedaOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents decCambioCompra As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decCambioVenta As ISL.Controles.NumeroDecimal
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Meses1 As ISL.Win.Meses
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents NroDecimales As ISL.Controles.Numerador

End Class
