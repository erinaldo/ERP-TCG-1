<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChequexCobrar
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCheque")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrado")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCobro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorCobro")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorCobro")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Asociado")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCheque")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cobrado")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCobro")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorCobro")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorCobro")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Asociado")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker
        Me.cboTipoFlete = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCobrado = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCobrado = New ISL.Controles.Colores(Me.components)
        Me.agrChequexCobrar = New ISL.Controles.Agrupacion(Me.components)
        Me.griChequexCobrar = New ISL.Controles.Grilla(Me.components)
        Me.ordChequexCobrar = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.agrCuentaTrabajador = New ISL.Controles.Agrupacion(Me.components)
        Me.verAsociacion = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaCorriente = New ISL.Controles.Combo(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.verCobrar = New ISL.Controles.Chequear(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.fecFechaCobro = New ISL.Controles.Fecha(Me.components)
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaCobro = New ISL.Controles.Etiqueta(Me.components)
        Me.numMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTipoMoneda = New ISL.Controles.Combo(Me.components)
        Me.fecFecha = New ISL.Controles.Fecha(Me.components)
        Me.txtNroCheque = New ISL.Controles.Texto(Me.components)
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.etiMonto = New ISL.Controles.Etiqueta(Me.components)
        Me.eti = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFecha = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNroCheque = New ISL.Controles.Etiqueta(Me.components)
        Me.etiBanco = New ISL.Controles.Etiqueta(Me.components)
        Me.ficChequexCobrar = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiInsertar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiCobrar = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboTipoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrChequexCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrChequexCobrar.SuspendLayout()
        CType(Me.griChequexCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordChequexCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.agrCuentaTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCuentaTrabajador.SuspendLayout()
        CType(Me.verAsociacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficChequexCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficChequexCobrar.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl1.Controls.Add(Me.agrChequexCobrar)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(944, 430)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.fecDesde)
        Me.agrBusqueda.Controls.Add(Me.cboTipoFlete)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Controls.Add(Me.etiCobrado)
        Me.agrBusqueda.Controls.Add(Me.colorCobrado)
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(944, 66)
        Me.agrBusqueda.TabIndex = 2
        Me.agrBusqueda.Text = "Busqueda:"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(437, 33)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta2.TabIndex = 114
        Me.Etiqueta2.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(482, 31)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(110, 20)
        Me.fecDesde.TabIndex = 113
        '
        'cboTipoFlete
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoFlete.Appearance = Appearance2
        Me.cboTipoFlete.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoFlete.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoFlete.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoFlete.Location = New System.Drawing.Point(313, 30)
        Me.cboTipoFlete.Name = "cboTipoFlete"
        Me.cboTipoFlete.Size = New System.Drawing.Size(101, 21)
        Me.cboTipoFlete.TabIndex = 96
        Me.cboTipoFlete.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(194, 34)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(113, 14)
        Me.Etiqueta1.TabIndex = 3
        Me.Etiqueta1.Text = "Cheques asociados a:"
        '
        'etiCobrado
        '
        Me.etiCobrado.AutoSize = True
        Me.etiCobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCobrado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCobrado.Location = New System.Drawing.Point(25, 31)
        Me.etiCobrado.Name = "etiCobrado"
        Me.etiCobrado.Size = New System.Drawing.Size(91, 14)
        Me.etiCobrado.TabIndex = 3
        Me.etiCobrado.Text = "Cheque Cobrado:"
        '
        'colorCobrado
        '
        Me.colorCobrado.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colorCobrado.Location = New System.Drawing.Point(122, 27)
        Me.colorCobrado.Name = "colorCobrado"
        Me.colorCobrado.Size = New System.Drawing.Size(46, 21)
        Me.colorCobrado.TabIndex = 2
        Me.colorCobrado.Text = "192, 255, 192"
        '
        'agrChequexCobrar
        '
        Me.agrChequexCobrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agrChequexCobrar.Controls.Add(Me.griChequexCobrar)
        Me.agrChequexCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrChequexCobrar.ForeColor = System.Drawing.Color.Black
        Me.agrChequexCobrar.Location = New System.Drawing.Point(0, 65)
        Me.agrChequexCobrar.Name = "agrChequexCobrar"
        Me.agrChequexCobrar.Size = New System.Drawing.Size(944, 365)
        Me.agrChequexCobrar.TabIndex = 1
        Me.agrChequexCobrar.Text = "Lista de Cheque por Cobrar:"
        Me.agrChequexCobrar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griChequexCobrar
        '
        Me.griChequexCobrar.DataSource = Me.ordChequexCobrar
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 199
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 195
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Width = 244
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Width = 285
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 13
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        UltraGridBand1.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griChequexCobrar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griChequexCobrar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griChequexCobrar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griChequexCobrar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griChequexCobrar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griChequexCobrar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griChequexCobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griChequexCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griChequexCobrar.Location = New System.Drawing.Point(2, 18)
        Me.griChequexCobrar.Name = "griChequexCobrar"
        Me.griChequexCobrar.Size = New System.Drawing.Size(940, 345)
        Me.griChequexCobrar.TabIndex = 0
        '
        'ordChequexCobrar
        '
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.ordChequexCobrar.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(944, 430)
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.agrCuentaTrabajador)
        Me.agrDatos.Controls.Add(Me.verActivo)
        Me.agrDatos.Controls.Add(Me.verCobrar)
        Me.agrDatos.Controls.Add(Me.cboTrabajador)
        Me.agrDatos.Controls.Add(Me.fecFechaCobro)
        Me.agrDatos.Controls.Add(Me.etiTrabajador)
        Me.agrDatos.Controls.Add(Me.etiFechaCobro)
        Me.agrDatos.Controls.Add(Me.numMonto)
        Me.agrDatos.Controls.Add(Me.cboTipoMoneda)
        Me.agrDatos.Controls.Add(Me.fecFecha)
        Me.agrDatos.Controls.Add(Me.txtNroCheque)
        Me.agrDatos.Controls.Add(Me.cboBanco)
        Me.agrDatos.Controls.Add(Me.etiMonto)
        Me.agrDatos.Controls.Add(Me.eti)
        Me.agrDatos.Controls.Add(Me.etiFecha)
        Me.agrDatos.Controls.Add(Me.etiNroCheque)
        Me.agrDatos.Controls.Add(Me.etiBanco)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(944, 430)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agrCuentaTrabajador
        '
        Me.agrCuentaTrabajador.Controls.Add(Me.verAsociacion)
        Me.agrCuentaTrabajador.Controls.Add(Me.Etiqueta4)
        Me.agrCuentaTrabajador.Controls.Add(Me.cboCuentaCorriente)
        Me.agrCuentaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCuentaTrabajador.ForeColor = System.Drawing.Color.Black
        Me.agrCuentaTrabajador.Location = New System.Drawing.Point(410, 38)
        Me.agrCuentaTrabajador.Name = "agrCuentaTrabajador"
        Me.agrCuentaTrabajador.Size = New System.Drawing.Size(362, 57)
        Me.agrCuentaTrabajador.TabIndex = 20
        Me.agrCuentaTrabajador.Text = "     Asociado a la cuenta del trabajador"
        Me.agrCuentaTrabajador.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'verAsociacion
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.verAsociacion.Appearance = Appearance7
        Me.verAsociacion.BackColor = System.Drawing.Color.Transparent
        Me.verAsociacion.BackColorInternal = System.Drawing.Color.Transparent
        Me.verAsociacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verAsociacion.ForeColor = System.Drawing.Color.Black
        Me.verAsociacion.Location = New System.Drawing.Point(1, 0)
        Me.verAsociacion.Name = "verAsociacion"
        Me.verAsociacion.Size = New System.Drawing.Size(15, 17)
        Me.verAsociacion.TabIndex = 21
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(27, 24)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta4.TabIndex = 16
        Me.Etiqueta4.Text = "Cta Cte:"
        '
        'cboCuentaCorriente
        '
        Appearance31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaCorriente.Appearance = Appearance31
        Me.cboCuentaCorriente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaCorriente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaCorriente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaCorriente.Enabled = False
        Me.cboCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaCorriente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaCorriente.Location = New System.Drawing.Point(77, 24)
        Me.cboCuentaCorriente.Name = "cboCuentaCorriente"
        Me.cboCuentaCorriente.Size = New System.Drawing.Size(273, 21)
        Me.cboCuentaCorriente.TabIndex = 17
        Me.cboCuentaCorriente.ValueMember = "Id"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Checked = True
        Me.verActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(105, 172)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 15
        Me.verActivo.Text = "Activo"
        '
        'verCobrar
        '
        Me.verCobrar.AutoSize = True
        Me.verCobrar.Enabled = False
        Me.verCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCobrar.ForeColor = System.Drawing.Color.Black
        Me.verCobrar.Location = New System.Drawing.Point(105, 196)
        Me.verCobrar.Name = "verCobrar"
        Me.verCobrar.Size = New System.Drawing.Size(63, 17)
        Me.verCobrar.TabIndex = 14
        Me.verCobrar.Text = "Cobrado"
        '
        'cboTrabajador
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance4
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(105, 246)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(273, 21)
        Me.cboTrabajador.TabIndex = 13
        Me.cboTrabajador.ValueMember = "Id"
        '
        'fecFechaCobro
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCobro.Appearance = Appearance9
        Me.fecFechaCobro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaCobro.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCobro.Location = New System.Drawing.Point(105, 219)
        Me.fecFechaCobro.Name = "fecFechaCobro"
        Me.fecFechaCobro.Size = New System.Drawing.Size(144, 21)
        Me.fecFechaCobro.TabIndex = 12
        '
        'etiTrabajador
        '
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajador.Location = New System.Drawing.Point(39, 250)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 11
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'etiFechaCobro
        '
        Me.etiFechaCobro.AutoSize = True
        Me.etiFechaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaCobro.ForeColor = System.Drawing.Color.Black
        Me.etiFechaCobro.Location = New System.Drawing.Point(29, 223)
        Me.etiFechaCobro.Name = "etiFechaCobro"
        Me.etiFechaCobro.Size = New System.Drawing.Size(70, 14)
        Me.etiFechaCobro.TabIndex = 10
        Me.etiFechaCobro.Text = "Fecha Cobro:"
        '
        'numMonto
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.numMonto.Appearance = Appearance3
        Me.numMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMonto.ForeColor = System.Drawing.Color.Black
        Me.numMonto.Location = New System.Drawing.Point(105, 145)
        Me.numMonto.Name = "numMonto"
        Me.numMonto.NullText = "0.00"
        Me.numMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numMonto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numMonto.Size = New System.Drawing.Size(100, 21)
        Me.numMonto.TabIndex = 9
        '
        'cboTipoMoneda
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTipoMoneda.Appearance = Appearance1
        Me.cboTipoMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboTipoMoneda.Location = New System.Drawing.Point(105, 119)
        Me.cboTipoMoneda.Name = "cboTipoMoneda"
        Me.cboTipoMoneda.Size = New System.Drawing.Size(144, 21)
        Me.cboTipoMoneda.TabIndex = 8
        Me.cboTipoMoneda.ValueMember = "Id"
        '
        'fecFecha
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.fecFecha.Appearance = Appearance5
        Me.fecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFecha.ForeColor = System.Drawing.Color.Black
        Me.fecFecha.Location = New System.Drawing.Point(105, 92)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(144, 21)
        Me.fecFecha.TabIndex = 7
        '
        'txtNroCheque
        '
        Me.txtNroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroCheque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCheque.Location = New System.Drawing.Point(105, 65)
        Me.txtNroCheque.MaxLength = 20
        Me.txtNroCheque.Name = "txtNroCheque"
        Me.txtNroCheque.Size = New System.Drawing.Size(273, 21)
        Me.txtNroCheque.TabIndex = 6
        '
        'cboBanco
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboBanco.Appearance = Appearance6
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.Black
        Me.cboBanco.Location = New System.Drawing.Point(105, 38)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(273, 21)
        Me.cboBanco.TabIndex = 5
        Me.cboBanco.ValueMember = "Id"
        '
        'etiMonto
        '
        Me.etiMonto.AutoSize = True
        Me.etiMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiMonto.ForeColor = System.Drawing.Color.Black
        Me.etiMonto.Location = New System.Drawing.Point(61, 149)
        Me.etiMonto.Name = "etiMonto"
        Me.etiMonto.Size = New System.Drawing.Size(38, 14)
        Me.etiMonto.TabIndex = 4
        Me.etiMonto.Text = "Monto:"
        '
        'eti
        '
        Me.eti.AutoSize = True
        Me.eti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eti.ForeColor = System.Drawing.Color.Black
        Me.eti.Location = New System.Drawing.Point(28, 123)
        Me.eti.Name = "eti"
        Me.eti.Size = New System.Drawing.Size(71, 14)
        Me.eti.TabIndex = 3
        Me.eti.Text = "Tipo Moneda:"
        '
        'etiFecha
        '
        Me.etiFecha.AutoSize = True
        Me.etiFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecha.ForeColor = System.Drawing.Color.Black
        Me.etiFecha.Location = New System.Drawing.Point(61, 96)
        Me.etiFecha.Name = "etiFecha"
        Me.etiFecha.Size = New System.Drawing.Size(38, 14)
        Me.etiFecha.TabIndex = 2
        Me.etiFecha.Text = "Fecha:"
        '
        'etiNroCheque
        '
        Me.etiNroCheque.AutoSize = True
        Me.etiNroCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroCheque.ForeColor = System.Drawing.Color.Black
        Me.etiNroCheque.Location = New System.Drawing.Point(33, 69)
        Me.etiNroCheque.Name = "etiNroCheque"
        Me.etiNroCheque.Size = New System.Drawing.Size(66, 14)
        Me.etiNroCheque.TabIndex = 1
        Me.etiNroCheque.Text = "Nro Cheque:"
        '
        'etiBanco
        '
        Me.etiBanco.AutoSize = True
        Me.etiBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiBanco.ForeColor = System.Drawing.Color.Black
        Me.etiBanco.Location = New System.Drawing.Point(61, 42)
        Me.etiBanco.Name = "etiBanco"
        Me.etiBanco.Size = New System.Drawing.Size(38, 14)
        Me.etiBanco.TabIndex = 0
        Me.etiBanco.Text = "Banco:"
        '
        'ficChequexCobrar
        '
        Me.ficChequexCobrar.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficChequexCobrar.Controls.Add(Me.UltraTabPageControl1)
        Me.ficChequexCobrar.Controls.Add(Me.UltraTabPageControl2)
        Me.ficChequexCobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficChequexCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficChequexCobrar.Location = New System.Drawing.Point(0, 0)
        Me.ficChequexCobrar.Name = "ficChequexCobrar"
        Me.ficChequexCobrar.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficChequexCobrar.Size = New System.Drawing.Size(946, 453)
        Me.ficChequexCobrar.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficChequexCobrar.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficChequexCobrar.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(944, 430)
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInsertar, Me.tsmiActualizar, Me.tsmiEliminar, Me.tsmiCobrar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(142, 92)
        '
        'tsmiInsertar
        '
        Me.tsmiInsertar.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiInsertar.Name = "tsmiInsertar"
        Me.tsmiInsertar.Size = New System.Drawing.Size(141, 22)
        Me.tsmiInsertar.Text = "Insertar (F3)"
        '
        'tsmiActualizar
        '
        Me.tsmiActualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiActualizar.Name = "tsmiActualizar"
        Me.tsmiActualizar.Size = New System.Drawing.Size(141, 22)
        Me.tsmiActualizar.Text = "Actualizar (F4)"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(141, 22)
        Me.tsmiEliminar.Text = "Eliminar (F7)"
        '
        'tsmiCobrar
        '
        Me.tsmiCobrar.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.tsmiCobrar.Name = "tsmiCobrar"
        Me.tsmiCobrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.tsmiCobrar.Size = New System.Drawing.Size(141, 22)
        Me.tsmiCobrar.Text = "Cobrar"
        '
        'frm_ChequexCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 453)
        Me.Controls.Add(Me.ficChequexCobrar)
        Me.Name = "frm_ChequexCobrar"
        Me.Text = "Gestión de Cheque por Cobrar"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboTipoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCobrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrChequexCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrChequexCobrar.ResumeLayout(False)
        CType(Me.griChequexCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordChequexCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.agrCuentaTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCuentaTrabajador.ResumeLayout(False)
        Me.agrCuentaTrabajador.PerformLayout()
        CType(Me.verAsociacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficChequexCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficChequexCobrar.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficChequexCobrar As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrChequexCobrar As ISL.Controles.Agrupacion
    Friend WithEvents griChequexCobrar As ISL.Controles.Grilla
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents etiMonto As ISL.Controles.Etiqueta
    Friend WithEvents eti As ISL.Controles.Etiqueta
    Friend WithEvents etiFecha As ISL.Controles.Etiqueta
    Friend WithEvents etiNroCheque As ISL.Controles.Etiqueta
    Friend WithEvents etiBanco As ISL.Controles.Etiqueta
    Friend WithEvents fecFecha As ISL.Controles.Fecha
    Friend WithEvents txtNroCheque As ISL.Controles.Texto
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents numMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents cboTipoMoneda As ISL.Controles.Combo
    Friend WithEvents ordChequexCobrar As ISL.Controles.OrigenDatos
    Friend WithEvents verCobrar As ISL.Controles.Chequear
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents fecFechaCobro As ISL.Controles.Fecha
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaCobro As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCobrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents etiCobrado As ISL.Controles.Etiqueta
    Friend WithEvents colorCobrado As ISL.Controles.Colores
    Friend WithEvents agrCuentaTrabajador As ISL.Controles.Agrupacion
    Friend WithEvents cboCuentaCorriente As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents verAsociacion As ISL.Controles.Chequear
    Friend WithEvents cboTipoFlete As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
End Class
