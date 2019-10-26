<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BolsaRuta
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMinimo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoNormal")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMaximo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMinimo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoNormal")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMaximo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrBolsaRuta = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaBolsaRuta = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.orgBolsaRuta = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox
        Me.cboTipoVehiculoTc = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.decMontoMaximo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoNormal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoMinimo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboRuta = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.tcBolsaRuta = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrBolsaRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBolsaRuta.SuspendLayout()
        CType(Me.griListaBolsaRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.orgBolsaRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.cboTipoVehiculoTc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcBolsaRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcBolsaRuta.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrBolsaRuta)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1056, 394)
        '
        'agrBolsaRuta
        '
        Me.agrBolsaRuta.Controls.Add(Me.griListaBolsaRuta)
        Me.agrBolsaRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrBolsaRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBolsaRuta.ForeColor = System.Drawing.Color.Black
        Me.agrBolsaRuta.Location = New System.Drawing.Point(0, 0)
        Me.agrBolsaRuta.Name = "agrBolsaRuta"
        Me.agrBolsaRuta.Size = New System.Drawing.Size(1056, 394)
        Me.agrBolsaRuta.TabIndex = 2
        Me.agrBolsaRuta.Text = "Total:"
        Me.agrBolsaRuta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaBolsaRuta
        '
        Me.griListaBolsaRuta.ContextMenuStrip = Me.MenuContextual1
        Me.griListaBolsaRuta.DataSource = Me.orgBolsaRuta
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 217
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "Tipo Vehiculo"
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.griListaBolsaRuta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaBolsaRuta.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaBolsaRuta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaBolsaRuta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaBolsaRuta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaBolsaRuta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaBolsaRuta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaBolsaRuta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaBolsaRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaBolsaRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaBolsaRuta.Location = New System.Drawing.Point(2, 18)
        Me.griListaBolsaRuta.Name = "griListaBolsaRuta"
        Me.griListaBolsaRuta.Size = New System.Drawing.Size(1052, 374)
        Me.griListaBolsaRuta.TabIndex = 2
        Me.griListaBolsaRuta.Text = "Información de configuración de montos para habilitar por ruta"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(153, 92)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva bolsa de ruta"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la bolsa de ruta seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la bolsa de ruta seleccionada"
        '
        'orgBolsaRuta
        '
        UltraDataColumn4.DataType = GetType(Decimal)
        UltraDataColumn5.DataType = GetType(Decimal)
        UltraDataColumn6.DataType = GetType(Decimal)
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn7.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.orgBolsaRuta.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1056, 394)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboTipoVehiculoTc)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel23)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.decMontoMaximo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.decMontoNormal)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.decMontoMinimo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboRuta)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel12)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel11)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel10)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(1056, 419)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboTipoVehiculoTc
        '
        Appearance73.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculoTc.Appearance = Appearance73
        Me.cboTipoVehiculoTc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoVehiculoTc.DisplayMember = "Nombre"
        Me.cboTipoVehiculoTc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculoTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculoTc.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculoTc.Location = New System.Drawing.Point(148, 63)
        Me.cboTipoVehiculoTc.Name = "cboTipoVehiculoTc"
        Me.cboTipoVehiculoTc.Size = New System.Drawing.Size(280, 21)
        Me.cboTipoVehiculoTc.TabIndex = 3
        Me.cboTipoVehiculoTc.ValueMember = "Id"
        '
        'UltraLabel23
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance79
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(69, 67)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel23.TabIndex = 2
        Me.UltraLabel23.Text = "Tipo Vehiculo:"
        '
        'decMontoMaximo
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMontoMaximo.Appearance = Appearance2
        Me.decMontoMaximo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoMaximo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMontoMaximo.Location = New System.Drawing.Point(148, 132)
        Me.decMontoMaximo.Name = "decMontoMaximo"
        Me.decMontoMaximo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoMaximo.Size = New System.Drawing.Size(75, 21)
        Me.decMontoMaximo.TabIndex = 9
        '
        'decMontoNormal
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMontoNormal.Appearance = Appearance18
        Me.decMontoNormal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoNormal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMontoNormal.Location = New System.Drawing.Point(148, 109)
        Me.decMontoNormal.Name = "decMontoNormal"
        Me.decMontoNormal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoNormal.Size = New System.Drawing.Size(75, 21)
        Me.decMontoNormal.TabIndex = 7
        '
        'decMontoMinimo
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMontoMinimo.Appearance = Appearance19
        Me.decMontoMinimo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoMinimo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMontoMinimo.Location = New System.Drawing.Point(148, 86)
        Me.decMontoMinimo.Name = "decMontoMinimo"
        Me.decMontoMinimo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoMinimo.Size = New System.Drawing.Size(75, 21)
        Me.decMontoMinimo.TabIndex = 5
        '
        'cboRuta
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboRuta.Appearance = Appearance3
        Me.cboRuta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRuta.DisplayMember = "Nombre"
        Me.cboRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRuta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboRuta.Location = New System.Drawing.Point(148, 40)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(280, 21)
        Me.cboRuta.TabIndex = 1
        Me.cboRuta.ValueMember = "Id"
        '
        'UltraLabel12
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance25
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(64, 139)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(82, 14)
        Me.UltraLabel12.TabIndex = 8
        Me.UltraLabel12.Text = "Monto Máximo:"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(148, 157)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 10
        Me.verActivo.Text = "Activo"
        '
        'UltraLabel11
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance5
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(64, 116)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel11.TabIndex = 6
        Me.UltraLabel11.Text = "Monto Normal:"
        '
        'UltraLabel10
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance11
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(64, 93)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Monto Mínimo:"
        '
        'UltraLabel4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(111, 47)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Ruta:"
        '
        'tcBolsaRuta
        '
        Me.tcBolsaRuta.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcBolsaRuta.Controls.Add(Me.UltraTabPageControl7)
        Me.tcBolsaRuta.Controls.Add(Me.utpDetalle)
        Me.tcBolsaRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcBolsaRuta.Location = New System.Drawing.Point(0, 0)
        Me.tcBolsaRuta.Name = "tcBolsaRuta"
        Me.tcBolsaRuta.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcBolsaRuta.Size = New System.Drawing.Size(1058, 417)
        Me.tcBolsaRuta.TabIndex = 3
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcBolsaRuta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcBolsaRuta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1056, 394)
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'frm_BolsaRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 417)
        Me.Controls.Add(Me.tcBolsaRuta)
        Me.Name = "frm_BolsaRuta"
        Me.Text = "Bolsa Ruta"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrBolsaRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBolsaRuta.ResumeLayout(False)
        CType(Me.griListaBolsaRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.orgBolsaRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.cboTipoVehiculoTc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcBolsaRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcBolsaRuta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcBolsaRuta As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents orgBolsaRuta As ISL.Controles.OrigenDatos
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents decMontoMaximo As ISL.Controles.NumeroDecimal
    Friend WithEvents decMontoNormal As ISL.Controles.NumeroDecimal
    Friend WithEvents decMontoMinimo As ISL.Controles.NumeroDecimal
    Friend WithEvents cboRuta As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrBolsaRuta As ISL.Controles.Agrupacion
    Friend WithEvents griListaBolsaRuta As ISL.Controles.Grilla
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents cboTipoVehiculoTc As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
