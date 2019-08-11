<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrestamoGestion
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadCuota")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cancelado")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCancelado")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadCuota")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cancelado")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCancelado")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPrestamo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuota")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cancelado")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPrestamo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCuota")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cancelado")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrPrestamo = New ISL.Controles.Agrupacion(Me.components)
        Me.griPrestamo = New ISL.Controles.Grilla(Me.components)
        Me.ordPrestamo = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDatoPrestamo = New ISL.Controles.Agrupacion(Me.components)
        Me.fecFecha = New ISL.Controles.Fecha(Me.components)
        Me.etiFecha = New ISL.Controles.Etiqueta(Me.components)
        Me.numCuota = New ISL.Controles.NumeroEntero(Me.components)
        Me.etiCuota = New ISL.Controles.Etiqueta(Me.components)
        Me.numImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiImporte = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.etiConcepto = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConcepto = New ISL.Controles.Combo(Me.components)
        Me.etiGlosa = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.agrPrestamoDetalle = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetallePrestamo = New ISL.Controles.Grilla(Me.components)
        Me.ordPrestamoDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.etiSaldo = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Ficha2 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.numCuota2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.etiCuota2 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiImporte2 = New ISL.Controles.Etiqueta(Me.components)
        Me.numImporte2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiPeriodo = New ISL.Controles.Etiqueta(Me.components)
        Me.fecEjercicio = New ISL.Controles.Fecha(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiAgregar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiQuitar = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrPrestamo.SuspendLayout()
        CType(Me.griPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatoPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoPrestamo.SuspendLayout()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrPrestamoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrPrestamoDetalle.SuspendLayout()
        CType(Me.griDetallePrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordPrestamoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.numCuota2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImporte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrPrestamo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(725, 487)
        '
        'agrPrestamo
        '
        Me.agrPrestamo.Controls.Add(Me.griPrestamo)
        Me.agrPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPrestamo.ForeColor = System.Drawing.Color.Black
        Me.agrPrestamo.Location = New System.Drawing.Point(0, 0)
        Me.agrPrestamo.Name = "agrPrestamo"
        Me.agrPrestamo.Size = New System.Drawing.Size(725, 487)
        Me.agrPrestamo.TabIndex = 0
        Me.agrPrestamo.Text = "Lista de Prestamo"
        Me.agrPrestamo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griPrestamo
        '
        Me.griPrestamo.DataSource = Me.ordPrestamo
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 247
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 256
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 109
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 106
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 85
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPrestamo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griPrestamo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPrestamo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPrestamo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPrestamo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPrestamo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPrestamo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPrestamo.Location = New System.Drawing.Point(2, 18)
        Me.griPrestamo.Name = "griPrestamo"
        Me.griPrestamo.Size = New System.Drawing.Size(721, 467)
        Me.griPrestamo.TabIndex = 0
        '
        'ordPrestamo
        '
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn23.DataType = GetType(Decimal)
        UltraDataColumn24.DataType = GetType(Decimal)
        UltraDataColumn25.DataType = GetType(Integer)
        UltraDataColumn26.DataType = GetType(Boolean)
        UltraDataColumn27.DataType = GetType(Date)
        Me.ordPrestamo.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrPrestamoDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoPrestamo)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(624, 487)
        '
        'agrDatoPrestamo
        '
        Me.agrDatoPrestamo.Controls.Add(Me.NumeroDecimal1)
        Me.agrDatoPrestamo.Controls.Add(Me.etiSaldo)
        Me.agrDatoPrestamo.Controls.Add(Me.PictureBox1)
        Me.agrDatoPrestamo.Controls.Add(Me.txtGlosa)
        Me.agrDatoPrestamo.Controls.Add(Me.etiGlosa)
        Me.agrDatoPrestamo.Controls.Add(Me.cboConcepto)
        Me.agrDatoPrestamo.Controls.Add(Me.etiConcepto)
        Me.agrDatoPrestamo.Controls.Add(Me.fecFecha)
        Me.agrDatoPrestamo.Controls.Add(Me.etiFecha)
        Me.agrDatoPrestamo.Controls.Add(Me.numCuota)
        Me.agrDatoPrestamo.Controls.Add(Me.etiCuota)
        Me.agrDatoPrestamo.Controls.Add(Me.numImporte)
        Me.agrDatoPrestamo.Controls.Add(Me.etiImporte)
        Me.agrDatoPrestamo.Controls.Add(Me.cboTrabajador)
        Me.agrDatoPrestamo.Controls.Add(Me.etiTrabajador)
        Me.agrDatoPrestamo.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.agrDatoPrestamo.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoPrestamo.Name = "agrDatoPrestamo"
        Me.agrDatoPrestamo.Size = New System.Drawing.Size(624, 259)
        Me.agrDatoPrestamo.TabIndex = 0
        Me.agrDatoPrestamo.Text = "Dato:"
        Me.agrDatoPrestamo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'fecFecha
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.fecFecha.Appearance = Appearance8
        Me.fecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFecha.ForeColor = System.Drawing.Color.Black
        Me.fecFecha.Location = New System.Drawing.Point(76, 55)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(103, 21)
        Me.fecFecha.TabIndex = 7
        '
        'etiFecha
        '
        Me.etiFecha.AutoSize = True
        Me.etiFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecha.ForeColor = System.Drawing.Color.Black
        Me.etiFecha.Location = New System.Drawing.Point(32, 59)
        Me.etiFecha.Name = "etiFecha"
        Me.etiFecha.Size = New System.Drawing.Size(38, 14)
        Me.etiFecha.TabIndex = 6
        Me.etiFecha.Text = "Fecha:"
        '
        'numCuota
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.numCuota.Appearance = Appearance9
        Me.numCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuota.ForeColor = System.Drawing.Color.Black
        Me.numCuota.Location = New System.Drawing.Point(76, 223)
        Me.numCuota.Name = "numCuota"
        Me.numCuota.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCuota.Size = New System.Drawing.Size(54, 21)
        Me.numCuota.TabIndex = 5
        '
        'etiCuota
        '
        Me.etiCuota.AutoSize = True
        Me.etiCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCuota.ForeColor = System.Drawing.Color.Black
        Me.etiCuota.Location = New System.Drawing.Point(10, 227)
        Me.etiCuota.Name = "etiCuota"
        Me.etiCuota.Size = New System.Drawing.Size(63, 14)
        Me.etiCuota.TabIndex = 4
        Me.etiCuota.Text = "Nro Cuotas:"
        '
        'numImporte
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.numImporte.Appearance = Appearance10
        Me.numImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numImporte.ForeColor = System.Drawing.Color.Black
        Me.numImporte.Location = New System.Drawing.Point(76, 196)
        Me.numImporte.Name = "numImporte"
        Me.numImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numImporte.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numImporte.Size = New System.Drawing.Size(84, 21)
        Me.numImporte.TabIndex = 3
        '
        'etiImporte
        '
        Me.etiImporte.AutoSize = True
        Me.etiImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiImporte.ForeColor = System.Drawing.Color.Black
        Me.etiImporte.Location = New System.Drawing.Point(26, 200)
        Me.etiImporte.Name = "etiImporte"
        Me.etiImporte.Size = New System.Drawing.Size(44, 14)
        Me.etiImporte.TabIndex = 2
        Me.etiImporte.Text = "Importe:"
        '
        'cboTrabajador
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance5
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(76, 28)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(333, 21)
        Me.cboTrabajador.TabIndex = 1
        Me.cboTrabajador.ValueMember = "Id"
        '
        'etiTrabajador
        '
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajador.Location = New System.Drawing.Point(10, 32)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 0
        Me.etiTrabajador.Text = "Trabajador:"
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
        Me.Ficha1.Size = New System.Drawing.Size(626, 510)
        Me.Ficha1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(624, 487)
        '
        'etiConcepto
        '
        Me.etiConcepto.AutoSize = True
        Me.etiConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiConcepto.ForeColor = System.Drawing.Color.Black
        Me.etiConcepto.Location = New System.Drawing.Point(16, 86)
        Me.etiConcepto.Name = "etiConcepto"
        Me.etiConcepto.Size = New System.Drawing.Size(54, 14)
        Me.etiConcepto.TabIndex = 8
        Me.etiConcepto.Text = "Concepto:"
        '
        'cboConcepto
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Appearance = Appearance1
        Me.cboConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Location = New System.Drawing.Point(76, 82)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(199, 21)
        Me.cboConcepto.TabIndex = 9
        Me.cboConcepto.ValueMember = "Id"
        '
        'etiGlosa
        '
        Me.etiGlosa.AutoSize = True
        Me.etiGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGlosa.ForeColor = System.Drawing.Color.Black
        Me.etiGlosa.Location = New System.Drawing.Point(34, 115)
        Me.etiGlosa.Name = "etiGlosa"
        Me.etiGlosa.Size = New System.Drawing.Size(36, 14)
        Me.etiGlosa.TabIndex = 10
        Me.etiGlosa.Text = "Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(76, 111)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(333, 79)
        Me.txtGlosa.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(429, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'agrPrestamoDetalle
        '
        Me.agrPrestamoDetalle.Controls.Add(Me.Ficha2)
        Me.agrPrestamoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrPrestamoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPrestamoDetalle.ForeColor = System.Drawing.Color.Black
        Me.agrPrestamoDetalle.Location = New System.Drawing.Point(0, 259)
        Me.agrPrestamoDetalle.Name = "agrPrestamoDetalle"
        Me.agrPrestamoDetalle.Size = New System.Drawing.Size(624, 228)
        Me.agrPrestamoDetalle.TabIndex = 1
        Me.agrPrestamoDetalle.Text = "Detalle Prestamo"
        Me.agrPrestamoDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDetallePrestamo
        '
        Me.griDetallePrestamo.DataSource = Me.ordPrestamoDetalle
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Width = 118
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn17.Header.VisiblePosition = 4
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.griDetallePrestamo.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griDetallePrestamo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetallePrestamo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetallePrestamo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetallePrestamo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetallePrestamo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griDetallePrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetallePrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetallePrestamo.Location = New System.Drawing.Point(0, 0)
        Me.griDetallePrestamo.Name = "griDetallePrestamo"
        Me.griDetallePrestamo.Size = New System.Drawing.Size(616, 182)
        Me.griDetallePrestamo.TabIndex = 0
        '
        'ordPrestamoDetalle
        '
        UltraDataColumn30.DataType = GetType(Integer)
        UltraDataColumn31.DataType = GetType(Short)
        UltraDataColumn32.DataType = GetType(Short)
        UltraDataColumn33.DataType = GetType(Decimal)
        UltraDataColumn34.DataType = GetType(Boolean)
        Me.ordPrestamoDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34})
        '
        'etiSaldo
        '
        Me.etiSaldo.AutoSize = True
        Me.etiSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSaldo.ForeColor = System.Drawing.Color.Black
        Me.etiSaldo.Location = New System.Drawing.Point(179, 200)
        Me.etiSaldo.Name = "etiSaldo"
        Me.etiSaldo.Size = New System.Drawing.Size(35, 14)
        Me.etiSaldo.TabIndex = 41
        Me.etiSaldo.Text = "Saldo:"
        '
        'NumeroDecimal1
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Appearance = Appearance2
        Me.NumeroDecimal1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal1.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Location = New System.Drawing.Point(220, 196)
        Me.NumeroDecimal1.Name = "NumeroDecimal1"
        Me.NumeroDecimal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.NumeroDecimal1.Size = New System.Drawing.Size(84, 21)
        Me.NumeroDecimal1.TabIndex = 42
        '
        'Ficha2
        '
        Me.Ficha2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl3)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl4)
        Me.Ficha2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha2.Location = New System.Drawing.Point(2, 18)
        Me.Ficha2.Name = "Ficha2"
        Me.Ficha2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.Ficha2.Size = New System.Drawing.Size(620, 208)
        Me.Ficha2.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Mantenimiento"
        Me.Ficha2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.Ficha2.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(616, 182)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griDetallePrestamo)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(616, 182)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.btnCancelar)
        Me.UltraTabPageControl4.Controls.Add(Me.btnAceptar)
        Me.UltraTabPageControl4.Controls.Add(Me.fecEjercicio)
        Me.UltraTabPageControl4.Controls.Add(Me.etiPeriodo)
        Me.UltraTabPageControl4.Controls.Add(Me.numImporte2)
        Me.UltraTabPageControl4.Controls.Add(Me.etiImporte2)
        Me.UltraTabPageControl4.Controls.Add(Me.numCuota2)
        Me.UltraTabPageControl4.Controls.Add(Me.etiCuota2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(717, 182)
        '
        'numCuota2
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.numCuota2.Appearance = Appearance3
        Me.numCuota2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCuota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuota2.ForeColor = System.Drawing.Color.Black
        Me.numCuota2.Location = New System.Drawing.Point(78, 15)
        Me.numCuota2.Name = "numCuota2"
        Me.numCuota2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCuota2.Size = New System.Drawing.Size(54, 21)
        Me.numCuota2.TabIndex = 7
        '
        'etiCuota2
        '
        Me.etiCuota2.AutoSize = True
        Me.etiCuota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCuota2.ForeColor = System.Drawing.Color.Black
        Me.etiCuota2.Location = New System.Drawing.Point(36, 19)
        Me.etiCuota2.Name = "etiCuota2"
        Me.etiCuota2.Size = New System.Drawing.Size(36, 14)
        Me.etiCuota2.TabIndex = 6
        Me.etiCuota2.Text = "Cuota:"
        '
        'etiImporte2
        '
        Me.etiImporte2.AutoSize = True
        Me.etiImporte2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiImporte2.ForeColor = System.Drawing.Color.Black
        Me.etiImporte2.Location = New System.Drawing.Point(28, 46)
        Me.etiImporte2.Name = "etiImporte2"
        Me.etiImporte2.Size = New System.Drawing.Size(44, 14)
        Me.etiImporte2.TabIndex = 8
        Me.etiImporte2.Text = "Importe:"
        '
        'numImporte2
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.numImporte2.Appearance = Appearance7
        Me.numImporte2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numImporte2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numImporte2.ForeColor = System.Drawing.Color.Black
        Me.numImporte2.Location = New System.Drawing.Point(78, 42)
        Me.numImporte2.Name = "numImporte2"
        Me.numImporte2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numImporte2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numImporte2.Size = New System.Drawing.Size(84, 21)
        Me.numImporte2.TabIndex = 9
        '
        'etiPeriodo
        '
        Me.etiPeriodo.AutoSize = True
        Me.etiPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPeriodo.ForeColor = System.Drawing.Color.Black
        Me.etiPeriodo.Location = New System.Drawing.Point(142, 19)
        Me.etiPeriodo.Name = "etiPeriodo"
        Me.etiPeriodo.Size = New System.Drawing.Size(45, 14)
        Me.etiPeriodo.TabIndex = 10
        Me.etiPeriodo.Text = "Periodo:"
        '
        'fecEjercicio
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.fecEjercicio.Appearance = Appearance4
        Me.fecEjercicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecEjercicio.ForeColor = System.Drawing.Color.Black
        Me.fecEjercicio.FormatString = ""
        Me.fecEjercicio.Location = New System.Drawing.Point(193, 15)
        Me.fecEjercicio.MaskInput = "mm/yyyy"
        Me.fecEjercicio.Name = "fecEjercicio"
        Me.fecEjercicio.Size = New System.Drawing.Size(78, 21)
        Me.fecEjercicio.TabIndex = 11
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(78, 83)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(181, 83)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAgregar, Me.tsmiQuitar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(112, 48)
        '
        'tsmiAgregar
        '
        Me.tsmiAgregar.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsmiAgregar.Name = "tsmiAgregar"
        Me.tsmiAgregar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiAgregar.Text = "Agregar"
        '
        'tsmiQuitar
        '
        Me.tsmiQuitar.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.tsmiQuitar.Name = "tsmiQuitar"
        Me.tsmiQuitar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiQuitar.Text = "Quitar"
        '
        'frm_PrestamoGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 510)
        Me.Controls.Add(Me.Ficha1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PrestamoGestion"
        Me.Text = "Gestión de Prestamo"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrPrestamo.ResumeLayout(False)
        CType(Me.griPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatoPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoPrestamo.ResumeLayout(False)
        Me.agrDatoPrestamo.PerformLayout()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrPrestamoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrPrestamoDetalle.ResumeLayout(False)
        CType(Me.griDetallePrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordPrestamoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha2.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.numCuota2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImporte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrPrestamo As ISL.Controles.Agrupacion
    Friend WithEvents griPrestamo As ISL.Controles.Grilla
    Friend WithEvents ordPrestamo As ISL.Controles.OrigenDatos
    Friend WithEvents agrDatoPrestamo As ISL.Controles.Agrupacion
    Friend WithEvents numImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents etiImporte As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents fecFecha As ISL.Controles.Fecha
    Friend WithEvents etiFecha As ISL.Controles.Etiqueta
    Friend WithEvents numCuota As ISL.Controles.NumeroEntero
    Friend WithEvents etiCuota As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents etiGlosa As ISL.Controles.Etiqueta
    Friend WithEvents cboConcepto As ISL.Controles.Combo
    Friend WithEvents etiConcepto As ISL.Controles.Etiqueta
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents agrPrestamoDetalle As ISL.Controles.Agrupacion
    Friend WithEvents griDetallePrestamo As ISL.Controles.Grilla
    Friend WithEvents ordPrestamoDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents NumeroDecimal1 As ISL.Controles.NumeroDecimal
    Friend WithEvents etiSaldo As ISL.Controles.Etiqueta
    Friend WithEvents Ficha2 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents etiPeriodo As ISL.Controles.Etiqueta
    Friend WithEvents numImporte2 As ISL.Controles.NumeroDecimal
    Friend WithEvents etiImporte2 As ISL.Controles.Etiqueta
    Friend WithEvents numCuota2 As ISL.Controles.NumeroEntero
    Friend WithEvents etiCuota2 As ISL.Controles.Etiqueta
    Friend WithEvents fecEjercicio As ISL.Controles.Fecha
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiQuitar As System.Windows.Forms.ToolStripMenuItem
End Class
