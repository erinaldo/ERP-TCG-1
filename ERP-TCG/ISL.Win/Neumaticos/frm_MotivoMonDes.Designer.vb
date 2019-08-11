<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MotivoMonDes
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
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAlmacen")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndReencauche")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndReparacion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBaja")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAlmacen")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndReencauche")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndReparacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndBaja")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalMarcas = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_Motivo = New ISL.Controles.Grilla(Me.components)
        Me.odMotivo = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkBaja = New ISL.Controles.Chequear(Me.components)
        Me.chkReparacion = New ISL.Controles.Chequear(Me.components)
        Me.chkReencauche = New ISL.Controles.Chequear(Me.components)
        Me.chkAlmacen = New ISL.Controles.Chequear(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.lblCodigo = New Infragistics.Win.Misc.UltraLabel()
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.tcMotivo = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalMarcas.SuspendLayout()
        CType(Me.grid_Motivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.chkBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReencauche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcMotivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalMarcas)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(985, 455)
        '
        'agrTotalMarcas
        '
        Me.agrTotalMarcas.Controls.Add(Me.grid_Motivo)
        Me.agrTotalMarcas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalMarcas.ForeColor = System.Drawing.Color.Black
        Me.agrTotalMarcas.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalMarcas.Name = "agrTotalMarcas"
        Me.agrTotalMarcas.Size = New System.Drawing.Size(985, 455)
        Me.agrTotalMarcas.TabIndex = 0
        Me.agrTotalMarcas.Text = "Total de motivos"
        Me.agrTotalMarcas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_Motivo
        '
        Me.grid_Motivo.DataSource = Me.odMotivo
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 346
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.Caption = "Almacen"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Reencuache"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 91
        UltraGridColumn6.Header.Caption = "Reparacion"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn7.Header.Caption = "Baja"
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.grid_Motivo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_Motivo.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Motivo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Motivo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Motivo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Motivo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Motivo.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.grid_Motivo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Motivo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Motivo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Motivo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Motivo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Motivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Motivo.Location = New System.Drawing.Point(3, 16)
        Me.grid_Motivo.Name = "grid_Motivo"
        Me.grid_Motivo.Size = New System.Drawing.Size(979, 436)
        Me.grid_Motivo.TabIndex = 0
        '
        'odMotivo
        '
        UltraDataColumn3.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        UltraDataColumn4.DataType = GetType(Boolean)
        UltraDataColumn4.DefaultValue = False
        UltraDataColumn5.DataType = GetType(Boolean)
        UltraDataColumn5.DefaultValue = False
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataColumn6.DefaultValue = False
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn7.DefaultValue = False
        UltraDataColumn8.DataType = GetType(Boolean)
        Me.odMotivo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(985, 455)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Agrupacion1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.lblCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(985, 140)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.chkBaja)
        Me.Agrupacion1.Controls.Add(Me.chkReparacion)
        Me.Agrupacion1.Controls.Add(Me.chkReencauche)
        Me.Agrupacion1.Controls.Add(Me.chkAlmacen)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(19, 84)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(375, 47)
        Me.Agrupacion1.TabIndex = 4
        Me.Agrupacion1.Text = "Tipo:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkBaja
        '
        Me.chkBaja.BackColor = System.Drawing.Color.Transparent
        Me.chkBaja.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkBaja.Location = New System.Drawing.Point(300, 19)
        Me.chkBaja.Name = "chkBaja"
        Me.chkBaja.Size = New System.Drawing.Size(53, 20)
        Me.chkBaja.TabIndex = 3
        Me.chkBaja.Text = "Baja"
        '
        'chkReparacion
        '
        Me.chkReparacion.BackColor = System.Drawing.Color.Transparent
        Me.chkReparacion.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkReparacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReparacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkReparacion.Location = New System.Drawing.Point(210, 19)
        Me.chkReparacion.Name = "chkReparacion"
        Me.chkReparacion.Size = New System.Drawing.Size(84, 20)
        Me.chkReparacion.TabIndex = 2
        Me.chkReparacion.Text = "Reparacion"
        '
        'chkReencauche
        '
        Me.chkReencauche.BackColor = System.Drawing.Color.Transparent
        Me.chkReencauche.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkReencauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReencauche.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkReencauche.Location = New System.Drawing.Point(108, 19)
        Me.chkReencauche.Name = "chkReencauche"
        Me.chkReencauche.Size = New System.Drawing.Size(96, 20)
        Me.chkReencauche.TabIndex = 1
        Me.chkReencauche.Text = "Reencauche"
        '
        'chkAlmacen
        '
        Me.chkAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.chkAlmacen.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkAlmacen.Location = New System.Drawing.Point(27, 19)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(75, 20)
        Me.chkAlmacen.TabIndex = 0
        Me.chkAlmacen.Text = "Almacen"
        '
        'txtCodigo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance1
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(73, 30)
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.lblCodigo.Appearance = Appearance2
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(20, 32)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo:"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(917, 103)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 5
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(73, 57)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(321, 21)
        Me.txtNombre.TabIndex = 3
        '
        'UltraLabel22
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance4
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(20, 59)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 2
        Me.UltraLabel22.Text = "Nombre:"
        '
        'tcMotivo
        '
        Me.tcMotivo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcMotivo.Controls.Add(Me.UltraTabPageControl7)
        Me.tcMotivo.Controls.Add(Me.utpDetalle)
        Me.tcMotivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMotivo.Location = New System.Drawing.Point(0, 0)
        Me.tcMotivo.Name = "tcMotivo"
        Me.tcMotivo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcMotivo.Size = New System.Drawing.Size(987, 478)
        Me.tcMotivo.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcMotivo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcMotivo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(985, 455)
        '
        'frm_MotivoMonDes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(987, 478)
        Me.Controls.Add(Me.tcMotivo)
        Me.Name = "frm_MotivoMonDes"
        Me.Text = "Motivos de Montaje o Desmontaje"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalMarcas.ResumeLayout(False)
        CType(Me.grid_Motivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.chkBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReencauche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcMotivo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcMotivo As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalMarcas As ISL.Controles.Agrupacion
    Friend WithEvents grid_Motivo As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odMotivo As ISL.Controles.OrigenDatos
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents lblCodigo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents chkBaja As ISL.Controles.Chequear
    Friend WithEvents chkReparacion As ISL.Controles.Chequear
    Friend WithEvents chkReencauche As ISL.Controles.Chequear
    Friend WithEvents chkAlmacen As ISL.Controles.Chequear
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider

End Class
