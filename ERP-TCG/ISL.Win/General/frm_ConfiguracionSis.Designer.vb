<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConfiguracionSis
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTabla")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreTabla")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionSis")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConfiguracionSis")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConfiguracionSis))
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalBancos = New ISL.Controles.Agrupacion(Me.components)
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.odLista = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griEjercicio = New ISL.Controles.Grilla(Me.components)
        Me.odEjercicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Año = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.btn_AddEjercicio = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Tabla = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTabla = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.tcConfSis = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalBancos.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.griEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.Año.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_ec032c62_34eb_4049_9cdb_33879397313b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.txtTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcConfSis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcConfSis.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalBancos)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(805, 525)
        '
        'agrTotalBancos
        '
        Me.agrTotalBancos.Controls.Add(Me.griLista)
        Me.agrTotalBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalBancos.ForeColor = System.Drawing.Color.Black
        Me.agrTotalBancos.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalBancos.Name = "agrTotalBancos"
        Me.agrTotalBancos.Size = New System.Drawing.Size(805, 525)
        Me.agrTotalBancos.TabIndex = 1
        Me.agrTotalBancos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griLista
        '
        Me.griLista.DataSource = Me.odLista
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 178
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 300
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(2, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(801, 523)
        Me.griLista.TabIndex = 4
        Me.griLista.Text = "Listado de Tablas"
        '
        'odLista
        '
        Me.odLista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.griEjercicio)
        Me.utpDetalle.Controls.Add(Me.UltraGroupBox1)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(805, 525)
        '
        'griEjercicio
        '
        Me.griEjercicio.DataSource = Me.odEjercicio
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.griEjercicio.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griEjercicio.DisplayLayout.MaxColScrollRegions = 1
        Me.griEjercicio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griEjercicio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griEjercicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griEjercicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griEjercicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griEjercicio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griEjercicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEjercicio.Location = New System.Drawing.Point(0, 166)
        Me.griEjercicio.Name = "griEjercicio"
        Me.griEjercicio.Size = New System.Drawing.Size(805, 359)
        Me.griEjercicio.TabIndex = 3
        Me.griEjercicio.Text = "Listado"
        '
        'odEjercicio
        '
        Me.odEjercicio.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Año)
        Me.UltraGroupBox1.Controls.Add(Me.btn_AddEjercicio)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 102)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(805, 64)
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.Text = "Nuevo Ejercicio"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Año
        '
        Me.Año.Año = 2013
        Me.Año.Controls.Add(Me.numAño)
        Me.Año.Controls.Add(Me.NumeroEntero1)
        Me.Año.Controls.Add(Me.object_ec032c62_34eb_4049_9cdb_33879397313b)
        Me.Año.Controls.Add(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b)
        Me.Año.Controls.Add(Me.NumeroEntero3)
        Me.Año.Controls.Add(Me.NumeroEntero4)
        Me.Año.Controls.Add(Me.NumeroEntero5)
        Me.Año.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Año.Location = New System.Drawing.Point(11, 28)
        Me.Año.Name = "Año"
        Me.Año.Size = New System.Drawing.Size(54, 23)
        Me.Año.TabIndex = 232
        '
        'numAño
        '
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance41
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2012
        '
        'NumeroEntero1
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance4
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2012
        '
        'object_ec032c62_34eb_4049_9cdb_33879397313b
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Appearance = Appearance10
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.ForeColor = System.Drawing.Color.Black
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.FormatString = ""
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Location = New System.Drawing.Point(1, 0)
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.MaskInput = "nnnn"
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.MaxValue = 2020
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.MinValue = 2000
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Name = "object_ec032c62_34eb_4049_9cdb_33879397313b"
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.NullText = "0"
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Size = New System.Drawing.Size(52, 21)
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.TabIndex = 0
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Value = 2012
        '
        'object_1747ffef_29a8_4267_84e6_e88591c0ec4b
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Appearance = Appearance14
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.ForeColor = System.Drawing.Color.Black
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.FormatString = ""
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Location = New System.Drawing.Point(1, 0)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.MaskInput = "nnnn"
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.MaxValue = 2020
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.MinValue = 2000
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Name = "object_1747ffef_29a8_4267_84e6_e88591c0ec4b"
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.NullText = "0"
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Size = New System.Drawing.Size(52, 21)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.TabIndex = 0
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Value = 2012
        '
        'NumeroEntero3
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance15
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2012
        '
        'NumeroEntero4
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance16
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2012
        '
        'NumeroEntero5
        '
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance19
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2012
        '
        'btn_AddEjercicio
        '
        Appearance1.Image = 8
        Me.btn_AddEjercicio.Appearance = Appearance1
        Me.btn_AddEjercicio.ImageList = Me.imagenes
        Me.btn_AddEjercicio.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_AddEjercicio.Location = New System.Drawing.Point(70, 24)
        Me.btn_AddEjercicio.Name = "btn_AddEjercicio"
        Me.btn_AddEjercicio.Size = New System.Drawing.Size(91, 30)
        Me.btn_AddEjercicio.TabIndex = 230
        Me.btn_AddEjercicio.Text = "Ejecutar"
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "")
        Me.imagenes.Images.SetKeyName(1, "")
        Me.imagenes.Images.SetKeyName(2, "")
        Me.imagenes.Images.SetKeyName(3, "")
        Me.imagenes.Images.SetKeyName(4, "")
        Me.imagenes.Images.SetKeyName(5, "del.ico")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Tabla)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Etiqueta2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtTabla)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(805, 102)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Tabla
        '
        Me.Tabla.AutoSize = True
        Me.Tabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabla.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Tabla.Location = New System.Drawing.Point(42, 62)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(35, 14)
        Me.Tabla.TabIndex = 6
        Me.Tabla.Text = "Tabla:"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(31, 35)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Nombre:"
        '
        'txtTabla
        '
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTabla.Appearance = Appearance32
        Me.txtTabla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTabla.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTabla.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtTabla.Location = New System.Drawing.Point(83, 58)
        Me.txtTabla.MaxLength = 100
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.ReadOnly = True
        Me.txtTabla.Size = New System.Drawing.Size(196, 21)
        Me.txtTabla.TabIndex = 4
        Me.txtTabla.Tag = "0"
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
        Me.txtNombre.Location = New System.Drawing.Point(83, 31)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(196, 21)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Tag = "0"
        '
        'tcConfSis
        '
        Me.tcConfSis.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcConfSis.Controls.Add(Me.UltraTabPageControl7)
        Me.tcConfSis.Controls.Add(Me.utpDetalle)
        Me.tcConfSis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcConfSis.Location = New System.Drawing.Point(0, 0)
        Me.tcConfSis.Name = "tcConfSis"
        Me.tcConfSis.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcConfSis.Size = New System.Drawing.Size(807, 548)
        Me.tcConfSis.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcConfSis.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcConfSis.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(805, 525)
        '
        'frm_ConfiguracionSis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 548)
        Me.Controls.Add(Me.tcConfSis)
        Me.Name = "frm_ConfiguracionSis"
        Me.Text = "Configuracion Sistema"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalBancos.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.griEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.Año.ResumeLayout(False)
        Me.Año.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_ec032c62_34eb_4049_9cdb_33879397313b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.txtTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcConfSis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcConfSis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcConfSis As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalBancos As ISL.Controles.Agrupacion
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griEjercicio As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_AddEjercicio As Infragistics.Win.Misc.UltraButton
    Friend WithEvents odLista As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtTabla As ISL.Controles.Texto
    Friend WithEvents Tabla As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Año As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents object_ec032c62_34eb_4049_9cdb_33879397313b As ISL.Controles.NumeroEntero
    Friend WithEvents object_1747ffef_29a8_4267_84e6_e88591c0ec4b As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents odEjercicio As ISL.Controles.OrigenDatos
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
End Class
