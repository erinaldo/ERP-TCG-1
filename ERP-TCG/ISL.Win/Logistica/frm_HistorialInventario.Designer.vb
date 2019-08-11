<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HistorialInventario
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Centro")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Centro")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdHistorial")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadFinal")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorTotal")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdHistorial")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadFinal")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorUnitario")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorTotal")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbDatosAdicionales = New System.Windows.Forms.GroupBox()
        Me.rfechasHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfechasDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.grilla_Historial = New ISL.Controles.Grilla(Me.components)
        Me.odHistorial = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaInventario = New ISL.Controles.Grilla(Me.components)
        Me.odInventarioHistorial = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gbCabecera = New System.Windows.Forms.GroupBox()
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSubAlmacen = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCentro = New ISL.Controles.Texto(Me.components)
        Me.txtAlmacen = New ISL.Controles.Texto(Me.components)
        Me.Fecha = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficHistorialInventario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.grilla_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griListaInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odInventarioHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCabecera.SuspendLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficHistorialInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficHistorialInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1086, 590)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbDatosAdicionales)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1086, 590)
        Me.SplitContainer1.SplitterDistance = 48
        Me.SplitContainer1.TabIndex = 9
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.rfechasHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.rfechasDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta21)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.gbDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(1084, 46)
        Me.gbDatosAdicionales.TabIndex = 2
        Me.gbDatosAdicionales.TabStop = False
        '
        'rfechasHasta
        '
        Me.rfechasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfechasHasta.Location = New System.Drawing.Point(193, 16)
        Me.rfechasHasta.Name = "rfechasHasta"
        Me.rfechasHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfechasHasta.TabIndex = 249
        '
        'rfechasDesde
        '
        Me.rfechasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfechasDesde.Location = New System.Drawing.Point(50, 16)
        Me.rfechasDesde.Name = "rfechasDesde"
        Me.rfechasDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfechasDesde.TabIndex = 248
        '
        'Etiqueta21
        '
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(154, 19)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 251
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(10, 19)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta5.TabIndex = 250
        Me.Etiqueta5.Text = "Desde:"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.grilla_Historial)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1084, 536)
        Me.Agrupacion2.TabIndex = 2
        Me.Agrupacion2.Text = "Detalle"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grilla_Historial
        '
        Me.grilla_Historial.DataSource = Me.odHistorial
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.MaskInput = "{date} {longtime}"
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn2.Width = 169
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 8
        UltraGridColumn4.Width = 258
        UltraGridColumn5.Header.Caption = "Sub Almacen"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 197
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Width = 239
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Width = 118
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.grilla_Historial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grilla_Historial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_Historial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grilla_Historial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grilla_Historial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grilla_Historial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grilla_Historial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grilla_Historial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grilla_Historial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilla_Historial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grilla_Historial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grilla_Historial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_Historial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilla_Historial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla_Historial.Location = New System.Drawing.Point(3, 16)
        Me.grilla_Historial.Name = "grilla_Historial"
        Me.grilla_Historial.Size = New System.Drawing.Size(1078, 517)
        Me.grilla_Historial.TabIndex = 9
        Me.grilla_Historial.Text = "Historial"
        '
        'odHistorial
        '
        Me.odHistorial.AllowAdd = False
        Me.odHistorial.AllowDelete = False
        UltraDataColumn2.DataType = GetType(Date)
        Me.odHistorial.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 590)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1086, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 590)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1086, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 590)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1086, 0)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl2.Controls.Add(Me.gbCabecera)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1086, 590)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griListaInventario)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 99)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1086, 491)
        Me.Agrupacion1.TabIndex = 4
        Me.Agrupacion1.Text = "Detalle"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaInventario
        '
        Me.griListaInventario.DataSource = Me.odInventarioHistorial
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn15.Header.VisiblePosition = 4
        UltraGridColumn15.Width = 433
        UltraGridColumn16.Header.VisiblePosition = 5
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "Unidad Medida"
        UltraGridColumn17.Header.VisiblePosition = 6
        Appearance1.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance1
        UltraGridColumn18.Header.Caption = "Stock"
        UltraGridColumn18.Header.VisiblePosition = 7
        UltraGridColumn18.MaskInput = "{double:-9.2:c}"
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance2
        UltraGridColumn19.Header.Caption = "Valor Unitario"
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.MaskInput = "{double:-9.2:c}"
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance3
        UltraGridColumn20.Header.Caption = "Valor Total"
        UltraGridColumn20.Header.VisiblePosition = 9
        UltraGridColumn20.MaskInput = "{double:-9.2:c}"
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance4
        UltraGridColumn21.Header.Caption = "Actualizado Al"
        UltraGridColumn21.Header.VisiblePosition = 10
        UltraGridColumn21.Width = 110
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        Me.griListaInventario.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaInventario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaInventario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaInventario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaInventario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaInventario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaInventario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaInventario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaInventario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griListaInventario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaInventario.Location = New System.Drawing.Point(3, 16)
        Me.griListaInventario.Name = "griListaInventario"
        Me.griListaInventario.Size = New System.Drawing.Size(1080, 472)
        Me.griListaInventario.TabIndex = 8
        Me.griListaInventario.Text = "Stock De Materiales"
        '
        'odInventarioHistorial
        '
        Me.odInventarioHistorial.AllowAdd = False
        Me.odInventarioHistorial.AllowDelete = False
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Date)
        Me.odInventarioHistorial.Band.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21})
        '
        'gbCabecera
        '
        Me.gbCabecera.Controls.Add(Me.txtGlosa)
        Me.gbCabecera.Controls.Add(Me.Etiqueta7)
        Me.gbCabecera.Controls.Add(Me.txtSubAlmacen)
        Me.gbCabecera.Controls.Add(Me.Etiqueta1)
        Me.gbCabecera.Controls.Add(Me.txtCentro)
        Me.gbCabecera.Controls.Add(Me.txtAlmacen)
        Me.gbCabecera.Controls.Add(Me.Fecha)
        Me.gbCabecera.Controls.Add(Me.Etiqueta2)
        Me.gbCabecera.Controls.Add(Me.Etiqueta3)
        Me.gbCabecera.Controls.Add(Me.Etiqueta4)
        Me.gbCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbCabecera.Location = New System.Drawing.Point(0, 0)
        Me.gbCabecera.Name = "gbCabecera"
        Me.gbCabecera.Size = New System.Drawing.Size(1086, 99)
        Me.gbCabecera.TabIndex = 3
        Me.gbCabecera.TabStop = False
        '
        'txtGlosa
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance5
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(522, 37)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(350, 50)
        Me.txtGlosa.TabIndex = 315
        Me.txtGlosa.Tag = "0"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(480, 46)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta7.TabIndex = 316
        Me.Etiqueta7.Text = "Glosa:"
        '
        'txtSubAlmacen
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSubAlmacen.Appearance = Appearance6
        Me.txtSubAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubAlmacen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSubAlmacen.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtSubAlmacen.Location = New System.Drawing.Point(82, 69)
        Me.txtSubAlmacen.MaxLength = 100
        Me.txtSubAlmacen.Name = "txtSubAlmacen"
        Me.txtSubAlmacen.ReadOnly = True
        Me.txtSubAlmacen.Size = New System.Drawing.Size(187, 21)
        Me.txtSubAlmacen.TabIndex = 314
        Me.txtSubAlmacen.Tag = "0"
        '
        'Etiqueta1
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance7
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 73)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta1.TabIndex = 313
        Me.Etiqueta1.Text = "Sub-Almacen"
        '
        'txtCentro
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCentro.Appearance = Appearance8
        Me.txtCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCentro.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCentro.Location = New System.Drawing.Point(300, 15)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.ReadOnly = True
        Me.txtCentro.Size = New System.Drawing.Size(159, 21)
        Me.txtCentro.TabIndex = 311
        Me.txtCentro.Tag = "0"
        '
        'txtAlmacen
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAlmacen.Appearance = Appearance9
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmacen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAlmacen.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtAlmacen.Location = New System.Drawing.Point(82, 42)
        Me.txtAlmacen.MaxLength = 100
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(377, 21)
        Me.txtAlmacen.TabIndex = 312
        Me.txtAlmacen.Tag = "0"
        '
        'Fecha
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Appearance = Appearance10
        Me.Fecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Location = New System.Drawing.Point(82, 15)
        Me.Fecha.MaskInput = "{date} {longtime}"
        Me.Fecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(153, 21)
        Me.Fecha.TabIndex = 310
        '
        'Etiqueta2
        '
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance11
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(29, 46)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta2.TabIndex = 9
        Me.Etiqueta2.Text = "Almacen"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(41, 19)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta3.TabIndex = 309
        Me.Etiqueta3.Text = "Fecha"
        '
        'Etiqueta4
        '
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance12
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(257, 19)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta4.TabIndex = 7
        Me.Etiqueta4.Text = "Centro"
        '
        'ficHistorialInventario
        '
        Me.ficHistorialInventario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficHistorialInventario.Controls.Add(Me.UltraTabPageControl1)
        Me.ficHistorialInventario.Controls.Add(Me.UltraTabPageControl2)
        Me.ficHistorialInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficHistorialInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficHistorialInventario.Location = New System.Drawing.Point(0, 0)
        Me.ficHistorialInventario.Name = "ficHistorialInventario"
        Me.ficHistorialInventario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficHistorialInventario.Size = New System.Drawing.Size(1088, 613)
        Me.ficHistorialInventario.TabIndex = 12
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficHistorialInventario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficHistorialInventario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1086, 590)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_HistorialInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 613)
        Me.Controls.Add(Me.ficHistorialInventario)
        Me.Name = "frm_HistorialInventario"
        Me.Text = "Inventario Historial"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.grilla_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griListaInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odInventarioHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCabecera.ResumeLayout(False)
        Me.gbCabecera.PerformLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficHistorialInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficHistorialInventario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficHistorialInventario As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griListaInventario As ISL.Controles.Grilla
    Friend WithEvents odInventarioHistorial As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbDatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents odHistorial As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents grilla_Historial As ISL.Controles.Grilla
    Friend WithEvents rfechasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfechasDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents gbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtSubAlmacen As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtCentro As ISL.Controles.Texto
    Friend WithEvents txtAlmacen As ISL.Controles.Texto
    Friend WithEvents Fecha As ISL.Controles.Fecha
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
