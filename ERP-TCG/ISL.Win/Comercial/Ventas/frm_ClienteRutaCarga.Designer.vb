<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClienteRutaCarga
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCuenta")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Material", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCuenta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCuenta")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClienteRutaCarga))
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griClienteCarga = New ISL.Controles.Grilla(Me.components)
        Me.odClienteRutaCarga = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboLugarBOri = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboLugarBDes = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboClienteBuscar = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMaterial = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficClienteRutaCarga = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.mnuMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griClienteCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odClienteRutaCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboLugarBOri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugarBDes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficClienteRutaCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficClienteRutaCarga.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1114, 524)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griClienteCarga)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 84)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1114, 440)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griClienteCarga
        '
        Me.griClienteCarga.DataSource = Me.odClienteRutaCarga
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 293
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Width = 183
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Width = 164
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Width = 161
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand1.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        Me.griClienteCarga.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griClienteCarga.DisplayLayout.MaxColScrollRegions = 1
        Me.griClienteCarga.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griClienteCarga.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griClienteCarga.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griClienteCarga.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griClienteCarga.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griClienteCarga.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griClienteCarga.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griClienteCarga.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griClienteCarga.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griClienteCarga.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griClienteCarga.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griClienteCarga.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griClienteCarga.DisplayLayout.UseFixedHeaders = True
        Me.griClienteCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griClienteCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griClienteCarga.Location = New System.Drawing.Point(3, 16)
        Me.griClienteCarga.Name = "griClienteCarga"
        Me.griClienteCarga.Size = New System.Drawing.Size(1108, 421)
        Me.griClienteCarga.TabIndex = 1
        Me.griClienteCarga.Tag = ""
        '
        'odClienteRutaCarga
        '
        Me.odClienteRutaCarga.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.UltraLabel2)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel3)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel4)
        Me.agrBusqueda.Controls.Add(Me.cboLugarBOri)
        Me.agrBusqueda.Controls.Add(Me.cboLugarBDes)
        Me.agrBusqueda.Controls.Add(Me.cboClienteBuscar)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1114, 84)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(33, 50)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel2.TabIndex = 16
        Me.UltraLabel2.Text = "Origen:"
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(386, 50)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel3.TabIndex = 17
        Me.UltraLabel3.Text = "Destino:"
        '
        'UltraLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(31, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 15
        Me.UltraLabel4.Text = "Cliente:"
        '
        'cboLugarBOri
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboLugarBOri.Appearance = Appearance4
        Me.cboLugarBOri.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarBOri.DisplayMember = "Nombre"
        Me.cboLugarBOri.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarBOri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarBOri.ForeColor = System.Drawing.Color.Black
        Me.cboLugarBOri.Location = New System.Drawing.Point(80, 46)
        Me.cboLugarBOri.Name = "cboLugarBOri"
        Me.cboLugarBOri.Size = New System.Drawing.Size(300, 21)
        Me.cboLugarBOri.TabIndex = 13
        Me.cboLugarBOri.ValueMember = "Id"
        '
        'cboLugarBDes
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboLugarBDes.Appearance = Appearance5
        Me.cboLugarBDes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarBDes.DisplayMember = "Nombre"
        Me.cboLugarBDes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarBDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarBDes.ForeColor = System.Drawing.Color.Black
        Me.cboLugarBDes.Location = New System.Drawing.Point(438, 46)
        Me.cboLugarBDes.Name = "cboLugarBDes"
        Me.cboLugarBDes.Size = New System.Drawing.Size(295, 21)
        Me.cboLugarBDes.TabIndex = 14
        Me.cboLugarBDes.ValueMember = "Id"
        '
        'cboClienteBuscar
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboClienteBuscar.Appearance = Appearance6
        Me.cboClienteBuscar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance7
        Me.cboClienteBuscar.ButtonsRight.Add(EditorButton1)
        Me.cboClienteBuscar.DisplayMember = "Nombre"
        Me.cboClienteBuscar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteBuscar.ForeColor = System.Drawing.Color.Black
        Me.cboClienteBuscar.Location = New System.Drawing.Point(80, 19)
        Me.cboClienteBuscar.Name = "cboClienteBuscar"
        Me.cboClienteBuscar.Size = New System.Drawing.Size(300, 21)
        Me.cboClienteBuscar.TabIndex = 12
        Me.cboClienteBuscar.ValueMember = "Id"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Enabled = False
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1114, 524)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.rbNo)
        Me.UltraGroupBox2.Controls.Add(Me.rbSi)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.cboMaterial)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox2.Controls.Add(Me.cboOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.cboDestino)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel30)
        Me.UltraGroupBox2.Controls.Add(Me.cboCliente)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1114, 167)
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.Text = "Dato General"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.BackColor = System.Drawing.Color.Transparent
        Me.rbNo.ForeColor = System.Drawing.Color.Navy
        Me.rbNo.Location = New System.Drawing.Point(130, 139)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 16
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = False
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.BackColor = System.Drawing.Color.Transparent
        Me.rbSi.Checked = True
        Me.rbSi.ForeColor = System.Drawing.Color.Navy
        Me.rbSi.Location = New System.Drawing.Point(90, 139)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(34, 17)
        Me.rbSi.TabIndex = 15
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = False
        '
        'UltraLabel1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 141)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel1.TabIndex = 14
        Me.UltraLabel1.Text = "Asegurado:"
        '
        'cboMaterial
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.cboMaterial.Appearance = Appearance9
        Me.cboMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMaterial.DisplayMember = "Nombre"
        Me.cboMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterial.ForeColor = System.Drawing.Color.Black
        Me.cboMaterial.Location = New System.Drawing.Point(89, 108)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(250, 21)
        Me.cboMaterial.TabIndex = 13
        Me.cboMaterial.ValueMember = "Id"
        '
        'UltraLabel14
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance10
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(38, 112)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel14.TabIndex = 12
        Me.UltraLabel14.Text = "Material:"
        '
        'cboOrigen
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.Appearance = Appearance11
        Me.cboOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboOrigen.DisplayMember = "Nombre"
        Me.cboOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.Location = New System.Drawing.Point(89, 54)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(284, 21)
        Me.cboOrigen.TabIndex = 9
        Me.cboOrigen.ValueMember = "Id"
        '
        'cboDestino
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.Appearance = Appearance12
        Me.cboDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDestino.DisplayMember = "Nombre"
        Me.cboDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestino.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.Location = New System.Drawing.Point(89, 81)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(284, 21)
        Me.cboDestino.TabIndex = 11
        Me.cboDestino.ValueMember = "Id"
        '
        'UltraLabel29
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance13
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(45, 58)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel29.TabIndex = 8
        Me.UltraLabel29.Text = "Origen:"
        '
        'UltraLabel30
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance14
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Location = New System.Drawing.Point(40, 85)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel30.TabIndex = 10
        Me.UltraLabel30.Text = "Destino:"
        '
        'cboCliente
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance15
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Appearance16.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton2.Appearance = Appearance16
        Me.cboCliente.ButtonsRight.Add(EditorButton2)
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Location = New System.Drawing.Point(89, 27)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(323, 21)
        Me.cboCliente.TabIndex = 3
        Me.cboCliente.ValueMember = "Id"
        '
        'UltraLabel17
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance17
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(43, 31)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel17.TabIndex = 2
        Me.UltraLabel17.Text = "Cliente:"
        '
        'ficClienteRutaCarga
        '
        Me.ficClienteRutaCarga.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficClienteRutaCarga.Controls.Add(Me.UltraTabPageControl7)
        Me.ficClienteRutaCarga.Controls.Add(Me.UltraTabPageControl1)
        Me.ficClienteRutaCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficClienteRutaCarga.Location = New System.Drawing.Point(0, 0)
        Me.ficClienteRutaCarga.Name = "ficClienteRutaCarga"
        Me.ficClienteRutaCarga.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficClienteRutaCarga.Size = New System.Drawing.Size(1116, 547)
        Me.ficClienteRutaCarga.TabIndex = 2
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        UltraTab1.Key = "Mantenimiento"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Mantenimiento"
        Me.ficClienteRutaCarga.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab1})
        Me.ficClienteRutaCarga.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1114, 524)
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuNuevo, Me.ToolStripMenuEditar, Me.ToolStripMenuEliminar})
        Me.mnuMenu.Name = "ContextMenuStrip1"
        Me.mnuMenu.Size = New System.Drawing.Size(118, 70)
        '
        'ToolStripMenuNuevo
        '
        Me.ToolStripMenuNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuNuevo.Name = "ToolStripMenuNuevo"
        Me.ToolStripMenuNuevo.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuNuevo.Text = "Nuevo"
        '
        'ToolStripMenuEditar
        '
        Me.ToolStripMenuEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ToolStripMenuEditar.Name = "ToolStripMenuEditar"
        Me.ToolStripMenuEditar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuEditar.Text = "Editar"
        '
        'ToolStripMenuEliminar
        '
        Me.ToolStripMenuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuEliminar.Name = "ToolStripMenuEliminar"
        Me.ToolStripMenuEliminar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuEliminar.Text = "Eliminar"
        '
        'frm_ClienteRutaCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 547)
        Me.Controls.Add(Me.ficClienteRutaCarga)
        Me.Name = "frm_ClienteRutaCarga"
        Me.Text = "Cliente Ruta Carga"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griClienteCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odClienteRutaCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboLugarBOri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugarBDes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficClienteRutaCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficClienteRutaCarga.ResumeLayout(False)
        Me.mnuMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficClienteRutaCarga As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griClienteCarga As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents odClienteRutaCarga As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Private WithEvents mnuMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents cboDestino As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMaterial As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboLugarBOri As ISL.Controles.ComboMaestros
    Friend WithEvents cboLugarBDes As ISL.Controles.ComboMaestros
    Friend WithEvents cboClienteBuscar As ISL.Controles.ComboMaestros
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
