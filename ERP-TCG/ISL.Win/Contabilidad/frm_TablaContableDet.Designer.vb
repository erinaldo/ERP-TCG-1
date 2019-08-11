<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TablaContableDet
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto2")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto3")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor1")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor2")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor3")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Logico1")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Logico2")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Logico3")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTablaContable")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTablaContableDet")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto1")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto2")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto3")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor1")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor2")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor3")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Logico1")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Logico2")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Logico3")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTablaContable")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTablaContableDet")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_ListaTablaContableDet = New ISL.Controles.Grilla(Me.components)
        Me.ogdTablaContableDet = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTablaContable = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTablaContableDet = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTablaContableMan = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboTablaContableDet = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.verIndTablaContable = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.decValor3 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decValor2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decValor1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verLogico3 = New ISL.Controles.Chequear(Me.components)
        Me.verLogico2 = New ISL.Controles.Chequear(Me.components)
        Me.verLogico1 = New ISL.Controles.Chequear(Me.components)
        Me.etiValor3 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiValor2 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiValor1 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTexto3 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTexto3 = New ISL.Controles.Texto(Me.components)
        Me.etiTexto2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTexto2 = New ISL.Controles.Texto(Me.components)
        Me.etiTexto1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTexto1 = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.tcTablaContable = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.timTiempo = New ISL.Controles.Tiempo(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_ListaTablaContableDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdTablaContableDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboTablaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrTablaContableDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTablaContableDet.SuspendLayout()
        CType(Me.cboTablaContableMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTablaContableDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndTablaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLogico3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLogico2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLogico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTexto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTexto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTexto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcTablaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTablaContable.SuspendLayout()
        Me.MenuDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_ListaTablaContableDet)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(910, 452)
        '
        'grid_ListaTablaContableDet
        '
        Me.grid_ListaTablaContableDet.DataSource = Me.ogdTablaContableDet
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 500
        UltraGridColumn3.Header.Caption = "Codigo Sunat"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 90
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "IndTabCont"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn13.Width = 50
        UltraGridColumn14.Header.Caption = "TablaContableDet"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Width = 200
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.grid_ListaTablaContableDet.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_ListaTablaContableDet.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ListaTablaContableDet.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_ListaTablaContableDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListaTablaContableDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListaTablaContableDet.Location = New System.Drawing.Point(0, 60)
        Me.grid_ListaTablaContableDet.Name = "grid_ListaTablaContableDet"
        Me.grid_ListaTablaContableDet.Size = New System.Drawing.Size(910, 392)
        Me.grid_ListaTablaContableDet.TabIndex = 3
        Me.grid_ListaTablaContableDet.Text = "Información de Detalles de Tablas Contables "
        '
        'ogdTablaContableDet
        '
        Me.ogdTablaContableDet.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion1.Controls.Add(Me.cboTablaContable)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(910, 60)
        Me.Agrupacion1.TabIndex = 4
        Me.Agrupacion1.Text = "Busca"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta11
        '
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(12, 29)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta11.TabIndex = 1
        Me.Etiqueta11.Text = "Tabla:"
        '
        'cboTablaContable
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTablaContable.Appearance = Appearance1
        Me.cboTablaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTablaContable.DisplayMember = "Nombre"
        Me.cboTablaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTablaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTablaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTablaContable.ForeColor = System.Drawing.Color.Black
        Me.cboTablaContable.Location = New System.Drawing.Point(55, 25)
        Me.cboTablaContable.Name = "cboTablaContable"
        Me.cboTablaContable.Size = New System.Drawing.Size(328, 21)
        Me.cboTablaContable.TabIndex = 0
        Me.cboTablaContable.ValueMember = "Id"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrTablaContableDet)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(910, 452)
        '
        'agrTablaContableDet
        '
        Me.agrTablaContableDet.Controls.Add(Me.Etiqueta2)
        Me.agrTablaContableDet.Controls.Add(Me.cboTablaContableMan)
        Me.agrTablaContableDet.Controls.Add(Me.cboTablaContableDet)
        Me.agrTablaContableDet.Controls.Add(Me.Etiqueta10)
        Me.agrTablaContableDet.Controls.Add(Me.verIndTablaContable)
        Me.agrTablaContableDet.Controls.Add(Me.txtNombre)
        Me.agrTablaContableDet.Controls.Add(Me.decValor3)
        Me.agrTablaContableDet.Controls.Add(Me.decValor2)
        Me.agrTablaContableDet.Controls.Add(Me.decValor1)
        Me.agrTablaContableDet.Controls.Add(Me.verLogico3)
        Me.agrTablaContableDet.Controls.Add(Me.verLogico2)
        Me.agrTablaContableDet.Controls.Add(Me.verLogico1)
        Me.agrTablaContableDet.Controls.Add(Me.etiValor3)
        Me.agrTablaContableDet.Controls.Add(Me.etiValor2)
        Me.agrTablaContableDet.Controls.Add(Me.etiValor1)
        Me.agrTablaContableDet.Controls.Add(Me.etiTexto3)
        Me.agrTablaContableDet.Controls.Add(Me.txtTexto3)
        Me.agrTablaContableDet.Controls.Add(Me.etiTexto2)
        Me.agrTablaContableDet.Controls.Add(Me.txtTexto2)
        Me.agrTablaContableDet.Controls.Add(Me.etiTexto1)
        Me.agrTablaContableDet.Controls.Add(Me.txtTexto1)
        Me.agrTablaContableDet.Controls.Add(Me.Etiqueta1)
        Me.agrTablaContableDet.Controls.Add(Me.verActivo)
        Me.agrTablaContableDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTablaContableDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTablaContableDet.ForeColor = System.Drawing.Color.Black
        Me.agrTablaContableDet.Location = New System.Drawing.Point(0, 0)
        Me.agrTablaContableDet.Name = "agrTablaContableDet"
        Me.agrTablaContableDet.Size = New System.Drawing.Size(910, 452)
        Me.agrTablaContableDet.TabIndex = 0
        Me.agrTablaContableDet.Text = "Datos"
        Me.agrTablaContableDet.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(614, 32)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(87, 14)
        Me.Etiqueta2.TabIndex = 324
        Me.Etiqueta2.Text = "Tabla Contable:"
        '
        'cboTablaContableMan
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTablaContableMan.Appearance = Appearance2
        Me.cboTablaContableMan.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTablaContableMan.DisplayMember = "Nombre"
        Me.cboTablaContableMan.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTablaContableMan.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTablaContableMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTablaContableMan.ForeColor = System.Drawing.Color.Black
        Me.cboTablaContableMan.Location = New System.Drawing.Point(451, 49)
        Me.cboTablaContableMan.Name = "cboTablaContableMan"
        Me.cboTablaContableMan.Size = New System.Drawing.Size(250, 21)
        Me.cboTablaContableMan.TabIndex = 323
        Me.cboTablaContableMan.ValueMember = "Id"
        '
        'cboTablaContableDet
        '
        Me.cboTablaContableDet.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance3.BackColor = System.Drawing.SystemColors.Window
        Appearance3.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboTablaContableDet.DisplayLayout.Appearance = Appearance3
        Me.cboTablaContableDet.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboTablaContableDet.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.cboTablaContableDet.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboTablaContableDet.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.cboTablaContableDet.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboTablaContableDet.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.cboTablaContableDet.DisplayLayout.MaxColScrollRegions = 1
        Me.cboTablaContableDet.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboTablaContableDet.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.cboTablaContableDet.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Me.cboTablaContableDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboTablaContableDet.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.cboTablaContableDet.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboTablaContableDet.DisplayLayout.Override.TemplateAddRowAppearance = Appearance10
        Me.cboTablaContableDet.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboTablaContableDet.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboTablaContableDet.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboTablaContableDet.DisplayMember = "Nombre"
        Me.cboTablaContableDet.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboTablaContableDet.Location = New System.Drawing.Point(451, 95)
        Me.cboTablaContableDet.Name = "cboTablaContableDet"
        Me.cboTablaContableDet.Size = New System.Drawing.Size(250, 22)
        Me.cboTablaContableDet.TabIndex = 322
        Me.cboTablaContableDet.ValueMember = "Id"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(582, 78)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(119, 14)
        Me.Etiqueta10.TabIndex = 321
        Me.Etiqueta10.Text = "Tabla Contable Detalle:"
        '
        'verIndTablaContable
        '
        Me.verIndTablaContable.AutoSize = True
        Me.verIndTablaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndTablaContable.ForeColor = System.Drawing.Color.Black
        Me.verIndTablaContable.Location = New System.Drawing.Point(451, 74)
        Me.verIndTablaContable.Name = "verIndTablaContable"
        Me.verIndTablaContable.Size = New System.Drawing.Size(111, 17)
        Me.verIndTablaContable.TabIndex = 28
        Me.verIndTablaContable.Text = "IndTablaComtable"
        '
        'txtNombre
        '
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Location = New System.Drawing.Point(95, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(450, 21)
        Me.txtNombre.TabIndex = 27
        '
        'decValor3
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.decValor3.Appearance = Appearance11
        Me.decValor3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decValor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValor3.ForeColor = System.Drawing.Color.Black
        Me.decValor3.Location = New System.Drawing.Point(296, 95)
        Me.decValor3.MaskInput = "{double:8.4}"
        Me.decValor3.Name = "decValor3"
        Me.decValor3.NullText = "0.00"
        Me.decValor3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValor3.Size = New System.Drawing.Size(80, 21)
        Me.decValor3.TabIndex = 22
        '
        'decValor2
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.decValor2.Appearance = Appearance12
        Me.decValor2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValor2.ForeColor = System.Drawing.Color.Black
        Me.decValor2.Location = New System.Drawing.Point(296, 72)
        Me.decValor2.MaskInput = "{double:8.4}"
        Me.decValor2.Name = "decValor2"
        Me.decValor2.NullText = "0.00"
        Me.decValor2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValor2.Size = New System.Drawing.Size(80, 21)
        Me.decValor2.TabIndex = 21
        '
        'decValor1
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.decValor1.Appearance = Appearance13
        Me.decValor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValor1.ForeColor = System.Drawing.Color.Black
        Me.decValor1.Location = New System.Drawing.Point(296, 49)
        Me.decValor1.MaskInput = "{double:8.4}"
        Me.decValor1.Name = "decValor1"
        Me.decValor1.NullText = "0.00"
        Me.decValor1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValor1.Size = New System.Drawing.Size(80, 21)
        Me.decValor1.TabIndex = 20
        '
        'verLogico3
        '
        Me.verLogico3.AutoSize = True
        Me.verLogico3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verLogico3.ForeColor = System.Drawing.Color.Black
        Me.verLogico3.Location = New System.Drawing.Point(382, 99)
        Me.verLogico3.Name = "verLogico3"
        Me.verLogico3.Size = New System.Drawing.Size(63, 17)
        Me.verLogico3.TabIndex = 25
        Me.verLogico3.Text = "Lógico 3"
        '
        'verLogico2
        '
        Me.verLogico2.AutoSize = True
        Me.verLogico2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verLogico2.ForeColor = System.Drawing.Color.Black
        Me.verLogico2.Location = New System.Drawing.Point(382, 75)
        Me.verLogico2.Name = "verLogico2"
        Me.verLogico2.Size = New System.Drawing.Size(63, 17)
        Me.verLogico2.TabIndex = 24
        Me.verLogico2.Text = "Lógico 2"
        '
        'verLogico1
        '
        Me.verLogico1.AutoSize = True
        Me.verLogico1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verLogico1.ForeColor = System.Drawing.Color.Black
        Me.verLogico1.Location = New System.Drawing.Point(382, 50)
        Me.verLogico1.Name = "verLogico1"
        Me.verLogico1.Size = New System.Drawing.Size(63, 17)
        Me.verLogico1.TabIndex = 23
        Me.verLogico1.Text = "Lógico 1"
        '
        'etiValor3
        '
        Me.etiValor3.AutoSize = True
        Me.etiValor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiValor3.ForeColor = System.Drawing.Color.Black
        Me.etiValor3.Location = New System.Drawing.Point(251, 99)
        Me.etiValor3.Name = "etiValor3"
        Me.etiValor3.Size = New System.Drawing.Size(42, 14)
        Me.etiValor3.TabIndex = 26
        Me.etiValor3.Text = "Valor 3:"
        '
        'etiValor2
        '
        Me.etiValor2.AutoSize = True
        Me.etiValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiValor2.ForeColor = System.Drawing.Color.Black
        Me.etiValor2.Location = New System.Drawing.Point(251, 77)
        Me.etiValor2.Name = "etiValor2"
        Me.etiValor2.Size = New System.Drawing.Size(42, 14)
        Me.etiValor2.TabIndex = 24
        Me.etiValor2.Text = "Valor 2:"
        '
        'etiValor1
        '
        Me.etiValor1.AutoSize = True
        Me.etiValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiValor1.ForeColor = System.Drawing.Color.Black
        Me.etiValor1.Location = New System.Drawing.Point(251, 53)
        Me.etiValor1.Name = "etiValor1"
        Me.etiValor1.Size = New System.Drawing.Size(42, 14)
        Me.etiValor1.TabIndex = 22
        Me.etiValor1.Text = "Valor 1:"
        '
        'etiTexto3
        '
        Me.etiTexto3.AutoSize = True
        Me.etiTexto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTexto3.ForeColor = System.Drawing.Color.Black
        Me.etiTexto3.Location = New System.Drawing.Point(47, 99)
        Me.etiTexto3.Name = "etiTexto3"
        Me.etiTexto3.Size = New System.Drawing.Size(44, 14)
        Me.etiTexto3.TabIndex = 20
        Me.etiTexto3.Text = "Texto 3:"
        '
        'txtTexto3
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.txtTexto3.Appearance = Appearance14
        Me.txtTexto3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTexto3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTexto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto3.ForeColor = System.Drawing.Color.Black
        Me.txtTexto3.Location = New System.Drawing.Point(95, 95)
        Me.txtTexto3.MaxLength = 50
        Me.txtTexto3.Name = "txtTexto3"
        Me.txtTexto3.Size = New System.Drawing.Size(150, 21)
        Me.txtTexto3.TabIndex = 19
        '
        'etiTexto2
        '
        Me.etiTexto2.AutoSize = True
        Me.etiTexto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTexto2.ForeColor = System.Drawing.Color.Black
        Me.etiTexto2.Location = New System.Drawing.Point(47, 76)
        Me.etiTexto2.Name = "etiTexto2"
        Me.etiTexto2.Size = New System.Drawing.Size(44, 14)
        Me.etiTexto2.TabIndex = 18
        Me.etiTexto2.Text = "Texto 2:"
        '
        'txtTexto2
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.txtTexto2.Appearance = Appearance15
        Me.txtTexto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTexto2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTexto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto2.ForeColor = System.Drawing.Color.Black
        Me.txtTexto2.Location = New System.Drawing.Point(95, 72)
        Me.txtTexto2.MaxLength = 50
        Me.txtTexto2.Name = "txtTexto2"
        Me.txtTexto2.Size = New System.Drawing.Size(150, 21)
        Me.txtTexto2.TabIndex = 17
        '
        'etiTexto1
        '
        Me.etiTexto1.AutoSize = True
        Me.etiTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTexto1.ForeColor = System.Drawing.Color.Black
        Me.etiTexto1.Location = New System.Drawing.Point(18, 53)
        Me.etiTexto1.Name = "etiTexto1"
        Me.etiTexto1.Size = New System.Drawing.Size(74, 14)
        Me.etiTexto1.TabIndex = 16
        Me.etiTexto1.Text = "Codigo Sunat:"
        '
        'txtTexto1
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.txtTexto1.Appearance = Appearance16
        Me.txtTexto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTexto1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto1.ForeColor = System.Drawing.Color.Black
        Me.txtTexto1.Location = New System.Drawing.Point(95, 49)
        Me.txtTexto1.MaxLength = 50
        Me.txtTexto1.Name = "txtTexto1"
        Me.txtTexto1.Size = New System.Drawing.Size(150, 21)
        Me.txtTexto1.TabIndex = 15
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(8, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta1.TabIndex = 13
        Me.Etiqueta1.Text = "Nombre Detalle:"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(779, 77)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 12
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'tcTablaContable
        '
        Me.tcTablaContable.Controls.Add(Me.UltraTabPageControl1)
        Me.tcTablaContable.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcTablaContable.Controls.Add(Me.UltraTabPageControl2)
        Me.tcTablaContable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTablaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTablaContable.Location = New System.Drawing.Point(0, 0)
        Me.tcTablaContable.Name = "tcTablaContable"
        Me.tcTablaContable.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcTablaContable.Size = New System.Drawing.Size(912, 475)
        Me.tcTablaContable.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcTablaContable.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcTablaContable.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(910, 452)
        '
        'timTiempo
        '
        Me.timTiempo.Interval = 1000
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.mnuEliminar})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(122, 82)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(121, 26)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'frm_TablaContableDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(912, 475)
        Me.Controls.Add(Me.tcTablaContable)
        Me.Name = "frm_TablaContableDet"
        Me.Text = "Datos de Tablas Contables"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_ListaTablaContableDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdTablaContableDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboTablaContable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrTablaContableDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTablaContableDet.ResumeLayout(False)
        Me.agrTablaContableDet.PerformLayout()
        CType(Me.cboTablaContableMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTablaContableDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndTablaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLogico3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLogico2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLogico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTexto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTexto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTexto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcTablaContable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTablaContable.ResumeLayout(False)
        Me.MenuDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTablaContable As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_ListaTablaContableDet As ISL.Controles.Grilla
    Friend WithEvents ogdTablaContableDet As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTablaContableDet As ISL.Controles.Agrupacion
    Friend WithEvents etiValor3 As ISL.Controles.Etiqueta
    Friend WithEvents etiValor2 As ISL.Controles.Etiqueta
    Friend WithEvents etiValor1 As ISL.Controles.Etiqueta
    Friend WithEvents etiTexto3 As ISL.Controles.Etiqueta
    Friend WithEvents txtTexto3 As ISL.Controles.Texto
    Friend WithEvents etiTexto2 As ISL.Controles.Etiqueta
    Friend WithEvents txtTexto2 As ISL.Controles.Texto
    Friend WithEvents etiTexto1 As ISL.Controles.Etiqueta
    Friend WithEvents txtTexto1 As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents timTiempo As ISL.Controles.Tiempo
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboTablaContable As ISL.Controles.ComboMaestros
    Friend WithEvents verLogico3 As ISL.Controles.Chequear
    Friend WithEvents verLogico2 As ISL.Controles.Chequear
    Friend WithEvents verLogico1 As ISL.Controles.Chequear
    Friend WithEvents decValor1 As ISL.Controles.NumeroDecimal
    Friend WithEvents decValor3 As ISL.Controles.NumeroDecimal
    Friend WithEvents decValor2 As ISL.Controles.NumeroDecimal
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents verIndTablaContable As ISL.Controles.Chequear
    Friend WithEvents cboTablaContableDet As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboTablaContableMan As ISL.Controles.ComboMaestros

End Class
