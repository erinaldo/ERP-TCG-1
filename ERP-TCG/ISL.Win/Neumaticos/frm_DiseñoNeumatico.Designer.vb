<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DiseñoNeumatico
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMedidaNeumatico")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cocada")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete1")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete2")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete3")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete4")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lonas")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMedidaNeumatico")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cocada")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete1")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete2")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete3")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete4")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lonas")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalMarcas = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_DiseñoNeumatico = New ISL.Controles.Grilla(Me.components)
        Me.odDiseñoNeu = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.ndCocadaMinima = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndCocada = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndRibete1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndRibete2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.ndRibete3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbMarca = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbMedidaNeumatico = New ISL.Controles.ComboMaestros(Me.components)
        Me.ndLonas = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.tcDiseños = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalMarcas.SuspendLayout()
        CType(Me.grid_DiseñoNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDiseñoNeu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ndCocadaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCocada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndRibete1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndRibete2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndRibete3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMedidaNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndLonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcDiseños, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDiseños.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalMarcas)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(998, 439)
        '
        'agrTotalMarcas
        '
        Me.agrTotalMarcas.Controls.Add(Me.grid_DiseñoNeumatico)
        Me.agrTotalMarcas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalMarcas.ForeColor = System.Drawing.Color.Black
        Me.agrTotalMarcas.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalMarcas.Name = "agrTotalMarcas"
        Me.agrTotalMarcas.Size = New System.Drawing.Size(998, 439)
        Me.agrTotalMarcas.TabIndex = 0
        Me.agrTotalMarcas.Text = "Total de marcas"
        Me.agrTotalMarcas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_DiseñoNeumatico
        '
        Me.grid_DiseñoNeumatico.DataSource = Me.odDiseñoNeu
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 124
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 14
        UltraGridColumn9.Header.Caption = "Ribete 1"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn10.Header.Caption = "Ribete 2"
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn11.Header.Caption = "Ribete 3"
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn12.Header.Caption = "Ribete 4"
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 9
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.grid_DiseñoNeumatico.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_DiseñoNeumatico.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_DiseñoNeumatico.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DiseñoNeumatico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_DiseñoNeumatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_DiseñoNeumatico.Location = New System.Drawing.Point(3, 16)
        Me.grid_DiseñoNeumatico.Name = "grid_DiseñoNeumatico"
        Me.grid_DiseñoNeumatico.Size = New System.Drawing.Size(992, 420)
        Me.grid_DiseñoNeumatico.TabIndex = 0
        '
        'odDiseñoNeu
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Decimal)
        UltraDataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn9.DataType = GetType(Decimal)
        UltraDataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn10.DataType = GetType(Decimal)
        UltraDataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn11.DataType = GetType(Decimal)
        UltraDataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn12.DataType = GetType(Decimal)
        UltraDataColumn12.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn13.DataType = GetType(Integer)
        UltraDataColumn13.DefaultValue = 0
        Me.odDiseñoNeu.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(998, 439)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel9)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Agrupacion1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cmbMarca)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cmbMedidaNeumatico)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.ndLonas)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel5)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(998, 157)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCodigo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance1
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(73, 21)
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'UltraLabel9
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance2
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(20, 23)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel9.TabIndex = 0
        Me.UltraLabel9.Text = "Codigo:"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.ndCocadaMinima)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel7)
        Me.Agrupacion1.Controls.Add(Me.ndCocada)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel8)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion1.Controls.Add(Me.ndRibete1)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion1.Controls.Add(Me.ndRibete2)
        Me.Agrupacion1.Controls.Add(Me.ndRibete3)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(385, 21)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(333, 127)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Ribetes:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ndCocadaMinima
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.ndCocadaMinima.Appearance = Appearance3
        Me.ndCocadaMinima.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndCocadaMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCocadaMinima.ForeColor = System.Drawing.Color.Black
        Me.ndCocadaMinima.Location = New System.Drawing.Point(122, 91)
        Me.ndCocadaMinima.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndCocadaMinima.Name = "ndCocadaMinima"
        Me.ndCocadaMinima.NullText = "0.00"
        Me.ndCocadaMinima.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCocadaMinima.Size = New System.Drawing.Size(87, 21)
        Me.ndCocadaMinima.TabIndex = 9
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(125, 71)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(86, 14)
        Me.UltraLabel7.TabIndex = 8
        Me.UltraLabel7.Text = "Cocada Minima:"
        '
        'ndCocada
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.ndCocada.Appearance = Appearance5
        Me.ndCocada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndCocada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCocada.ForeColor = System.Drawing.Color.Black
        Me.ndCocada.Location = New System.Drawing.Point(15, 91)
        Me.ndCocada.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndCocada.Name = "ndCocada"
        Me.ndCocada.NullText = "0.00"
        Me.ndCocada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCocada.Size = New System.Drawing.Size(87, 21)
        Me.ndCocada.TabIndex = 7
        '
        'UltraLabel8
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance6
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(18, 71)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel8.TabIndex = 6
        Me.UltraLabel8.Text = "Cocada:"
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(15, 21)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Ribete 1:"
        '
        'ndRibete1
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.ndRibete1.Appearance = Appearance8
        Me.ndRibete1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndRibete1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete1.ForeColor = System.Drawing.Color.Black
        Me.ndRibete1.Location = New System.Drawing.Point(15, 44)
        Me.ndRibete1.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete1.Name = "ndRibete1"
        Me.ndRibete1.NullText = "0"
        Me.ndRibete1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete1.Size = New System.Drawing.Size(87, 21)
        Me.ndRibete1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete1.SpinIncrement = 1
        Me.ndRibete1.TabIndex = 1
        '
        'UltraLabel4
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance9
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(122, 21)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Ribete 2:"
        '
        'ndRibete2
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.ndRibete2.Appearance = Appearance10
        Me.ndRibete2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndRibete2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete2.ForeColor = System.Drawing.Color.Black
        Me.ndRibete2.Location = New System.Drawing.Point(122, 44)
        Me.ndRibete2.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete2.Name = "ndRibete2"
        Me.ndRibete2.NullText = "0"
        Me.ndRibete2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete2.Size = New System.Drawing.Size(87, 21)
        Me.ndRibete2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete2.SpinIncrement = 1
        Me.ndRibete2.TabIndex = 3
        '
        'ndRibete3
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.ndRibete3.Appearance = Appearance11
        Me.ndRibete3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndRibete3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete3.ForeColor = System.Drawing.Color.Black
        Me.ndRibete3.Location = New System.Drawing.Point(227, 44)
        Me.ndRibete3.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete3.Name = "ndRibete3"
        Me.ndRibete3.NullText = "0"
        Me.ndRibete3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete3.Size = New System.Drawing.Size(87, 21)
        Me.ndRibete3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete3.SpinIncrement = 1
        Me.ndRibete3.TabIndex = 5
        '
        'UltraLabel6
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance12
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(227, 21)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel6.TabIndex = 4
        Me.UltraLabel6.Text = "Ribete 3:"
        '
        'UltraLabel2
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance13
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(20, 75)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Marca:"
        '
        'cmbMarca
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.cmbMarca.Appearance = Appearance14
        Me.cmbMarca.DisplayMember = "Nombre"
        Me.cmbMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.ForeColor = System.Drawing.Color.Black
        Me.cmbMarca.Location = New System.Drawing.Point(73, 73)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(170, 21)
        Me.cmbMarca.TabIndex = 5
        Me.cmbMarca.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 102)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Medida:"
        '
        'cmbMedidaNeumatico
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.cmbMedidaNeumatico.Appearance = Appearance16
        Me.cmbMedidaNeumatico.DisplayMember = "Nombre"
        Me.cmbMedidaNeumatico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMedidaNeumatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedidaNeumatico.ForeColor = System.Drawing.Color.Black
        Me.cmbMedidaNeumatico.Location = New System.Drawing.Point(73, 100)
        Me.cmbMedidaNeumatico.Name = "cmbMedidaNeumatico"
        Me.cmbMedidaNeumatico.Size = New System.Drawing.Size(170, 21)
        Me.cmbMedidaNeumatico.TabIndex = 7
        Me.cmbMedidaNeumatico.ValueMember = "Id"
        '
        'ndLonas
        '
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.ndLonas.Appearance = Appearance17
        Me.ndLonas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndLonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndLonas.ForeColor = System.Drawing.Color.Black
        Me.ndLonas.Location = New System.Drawing.Point(73, 127)
        Me.ndLonas.Name = "ndLonas"
        Me.ndLonas.NullText = "0.00"
        Me.ndLonas.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndLonas.Size = New System.Drawing.Size(100, 21)
        Me.ndLonas.TabIndex = 9
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(936, 112)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 1
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'UltraLabel5
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance18
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(21, 129)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel5.TabIndex = 8
        Me.UltraLabel5.Text = "Lonas:"
        '
        'txtNombre
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance19
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(73, 47)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(290, 21)
        Me.txtNombre.TabIndex = 3
        '
        'UltraLabel22
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance20
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(20, 49)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 2
        Me.UltraLabel22.Text = "Nombre:"
        '
        'tcDiseños
        '
        Me.tcDiseños.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcDiseños.Controls.Add(Me.UltraTabPageControl7)
        Me.tcDiseños.Controls.Add(Me.utpDetalle)
        Me.tcDiseños.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcDiseños.Location = New System.Drawing.Point(0, 0)
        Me.tcDiseños.Name = "tcDiseños"
        Me.tcDiseños.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcDiseños.Size = New System.Drawing.Size(1000, 462)
        Me.tcDiseños.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcDiseños.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcDiseños.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(998, 439)
        '
        'frm_DiseñoNeumatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1000, 462)
        Me.Controls.Add(Me.tcDiseños)
        Me.Name = "frm_DiseñoNeumatico"
        Me.Text = "Diseño del Neumatico"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalMarcas.ResumeLayout(False)
        CType(Me.grid_DiseñoNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDiseñoNeu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.ndCocadaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCocada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndRibete1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndRibete2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndRibete3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMedidaNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndLonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcDiseños, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDiseños.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcDiseños As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalMarcas As ISL.Controles.Agrupacion
    Friend WithEvents grid_DiseñoNeumatico As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbMedidaNeumatico As ISL.Controles.ComboMaestros
    Friend WithEvents ndLonas As ISL.Controles.NumeroDecimal
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odDiseñoNeu As ISL.Controles.OrigenDatos
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbMarca As ISL.Controles.ComboMaestros
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents ndRibete1 As ISL.Controles.NumeroEntero
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndCocada As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndRibete3 As ISL.Controles.NumeroEntero
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndRibete2 As ISL.Controles.NumeroEntero
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndCocadaMinima As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider

End Class
