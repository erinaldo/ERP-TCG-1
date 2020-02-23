<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cliente
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPersonaEmpresa")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActividad")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oePersona")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oeEmpresa")
        Dim E_Sexo1 As ERP.EntidadesWCF.e_Sexo = New ERP.EntidadesWCF.e_Sexo()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cliente))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.etiComisionista = New ISL.Controles.Etiqueta(Me.components)
        Me.colorComisionista = New ISL.Controles.Colores(Me.components)
        Me.agrGrillaCliente = New ISL.Controles.Agrupacion(Me.components)
        Me.griCliente = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ordCliente = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrCliente = New ISL.Controles.Agrupacion(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Sexo1 = New ISL.Win.Sexo()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.verComisionista = New ISL.Controles.Chequear(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaNacimiento = New ISL.Controles.Fecha(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtApellidoMaterno = New ISL.Controles.Texto(Me.components)
        Me.txtApellidoPaterno = New ISL.Controles.Texto(Me.components)
        Me.txtDni = New ISL.Controles.Texto(Me.components)
        Me.etiFechaNacimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiApellidoMaterno = New ISL.Controles.Etiqueta(Me.components)
        Me.etiApellidoPaterno = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDni = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrClienteEmpresa = New ISL.Controles.Agrupacion(Me.components)
        Me.txtCodigoCE = New ISL.Controles.Texto(Me.components)
        Me.etiCodigoCE = New ISL.Controles.Etiqueta(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtRazonSocial = New ISL.Controles.Texto(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.verActivoCE = New ISL.Controles.Chequear(Me.components)
        Me.etiAbreviatura = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRazonSocial = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRuc = New ISL.Controles.Etiqueta(Me.components)
        Me.ficCliente = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDireccionFiscal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.colorComisionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrGrillaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGrillaCliente.SuspendLayout()
        CType(Me.griCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ordCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCliente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verComisionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.agrClienteEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrClienteEmpresa.SuspendLayout()
        CType(Me.txtCodigoCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivoCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCliente.SuspendLayout()
        CType(Me.txtDireccionFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.AutoScroll = True
        Me.UltraTabPageControl1.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl1.Controls.Add(Me.agrGrillaCliente)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(804, 460)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agrBusqueda.Controls.Add(Me.etiComisionista)
        Me.agrBusqueda.Controls.Add(Me.colorComisionista)
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(804, 53)
        Me.agrBusqueda.TabIndex = 1
        Me.agrBusqueda.Text = "Busqueda:"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'etiComisionista
        '
        Me.etiComisionista.AutoSize = True
        Me.etiComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiComisionista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiComisionista.Location = New System.Drawing.Point(20, 26)
        Me.etiComisionista.Name = "etiComisionista"
        Me.etiComisionista.Size = New System.Drawing.Size(70, 14)
        Me.etiComisionista.TabIndex = 1
        Me.etiComisionista.Text = "Comisionista:"
        '
        'colorComisionista
        '
        Me.colorComisionista.Location = New System.Drawing.Point(96, 22)
        Me.colorComisionista.Name = "colorComisionista"
        Me.colorComisionista.Size = New System.Drawing.Size(46, 21)
        Me.colorComisionista.TabIndex = 0
        Me.colorComisionista.Text = "Control"
        '
        'agrGrillaCliente
        '
        Me.agrGrillaCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agrGrillaCliente.Controls.Add(Me.griCliente)
        Me.agrGrillaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGrillaCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrGrillaCliente.Location = New System.Drawing.Point(0, 53)
        Me.agrGrillaCliente.Name = "agrGrillaCliente"
        Me.agrGrillaCliente.Size = New System.Drawing.Size(804, 407)
        Me.agrGrillaCliente.TabIndex = 0
        Me.agrGrillaCliente.Text = "Listado de Cliente:"
        Me.agrGrillaCliente.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griCliente
        '
        Me.griCliente.ContextMenuStrip = Me.MenuContextual1
        Me.griCliente.DataSource = Me.ordCliente
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 397
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griCliente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCliente.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCliente.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCliente.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCliente.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCliente.Location = New System.Drawing.Point(2, 18)
        Me.griCliente.Name = "griCliente"
        Me.griCliente.Size = New System.Drawing.Size(800, 387)
        Me.griCliente.TabIndex = 0
        Me.griCliente.Text = "Listado de Clientes"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Cliente"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Cliente seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Cliente seleccionado"
        '
        'ordCliente
        '
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Boolean)
        Me.ordCliente.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.AutoScroll = True
        Me.UltraTabPageControl2.Controls.Add(Me.agrCliente)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(804, 460)
        '
        'agrCliente
        '
        Me.agrCliente.Controls.Add(Me.PictureBox1)
        Me.agrCliente.Controls.Add(Me.Sexo1)
        Me.agrCliente.Controls.Add(Me.txtCodigo)
        Me.agrCliente.Controls.Add(Me.etiCodigo)
        Me.agrCliente.Controls.Add(Me.verComisionista)
        Me.agrCliente.Controls.Add(Me.verActivo)
        Me.agrCliente.Controls.Add(Me.fecFechaNacimiento)
        Me.agrCliente.Controls.Add(Me.txtNombre)
        Me.agrCliente.Controls.Add(Me.txtApellidoMaterno)
        Me.agrCliente.Controls.Add(Me.txtApellidoPaterno)
        Me.agrCliente.Controls.Add(Me.txtDni)
        Me.agrCliente.Controls.Add(Me.etiFechaNacimiento)
        Me.agrCliente.Controls.Add(Me.etiNombre)
        Me.agrCliente.Controls.Add(Me.etiApellidoMaterno)
        Me.agrCliente.Controls.Add(Me.etiApellidoPaterno)
        Me.agrCliente.Controls.Add(Me.etiDni)
        Me.agrCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrCliente.Location = New System.Drawing.Point(0, 0)
        Me.agrCliente.Name = "agrCliente"
        Me.agrCliente.Size = New System.Drawing.Size(804, 276)
        Me.agrCliente.TabIndex = 0
        Me.agrCliente.Text = "Datos:"
        Me.agrCliente.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(521, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Sexo1
        '
        Me.Sexo1.BackColor = System.Drawing.Color.White
        Me.Sexo1.Location = New System.Drawing.Point(87, 143)
        Me.Sexo1.Name = "Sexo1"
        E_Sexo1.Abreviatura = "M"
        E_Sexo1.Id = "1"
        E_Sexo1.Nombre = "Masculino"
        Me.Sexo1.Sexo = E_Sexo1
        Me.Sexo1.Size = New System.Drawing.Size(204, 24)
        Me.Sexo1.TabIndex = 18
        '
        'txtCodigo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance1
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(138, 200)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 17
        '
        'etiCodigo
        '
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(84, 204)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 16
        Me.etiCodigo.Text = "Código:"
        '
        'verComisionista
        '
        Me.verComisionista.AutoSize = True
        Me.verComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verComisionista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verComisionista.Location = New System.Drawing.Point(138, 227)
        Me.verComisionista.Name = "verComisionista"
        Me.verComisionista.Size = New System.Drawing.Size(84, 17)
        Me.verComisionista.TabIndex = 15
        Me.verComisionista.Text = "Comisionista"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(138, 250)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 14
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'fecFechaNacimiento
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaNacimiento.Appearance = Appearance2
        Me.fecFechaNacimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaNacimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaNacimiento.Location = New System.Drawing.Point(138, 173)
        Me.fecFechaNacimiento.Name = "fecFechaNacimiento"
        Me.fecFechaNacimiento.Size = New System.Drawing.Size(100, 21)
        Me.fecFechaNacimiento.TabIndex = 12
        '
        'txtNombre
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(138, 116)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(352, 21)
        Me.txtNombre.TabIndex = 10
        '
        'txtApellidoMaterno
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoMaterno.Appearance = Appearance4
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(138, 89)
        Me.txtApellidoMaterno.MaxLength = 50
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(352, 21)
        Me.txtApellidoMaterno.TabIndex = 9
        '
        'txtApellidoPaterno
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoPaterno.Appearance = Appearance5
        Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(138, 62)
        Me.txtApellidoPaterno.MaxLength = 50
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(352, 21)
        Me.txtApellidoPaterno.TabIndex = 8
        '
        'txtDni
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDni.Appearance = Appearance6
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDni.Location = New System.Drawing.Point(138, 35)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 21)
        Me.txtDni.TabIndex = 7
        '
        'etiFechaNacimiento
        '
        Me.etiFechaNacimiento.AutoSize = True
        Me.etiFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaNacimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiFechaNacimiento.Location = New System.Drawing.Point(30, 177)
        Me.etiFechaNacimiento.Name = "etiFechaNacimiento"
        Me.etiFechaNacimiento.Size = New System.Drawing.Size(96, 14)
        Me.etiFechaNacimiento.TabIndex = 5
        Me.etiFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(80, 120)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 3
        Me.etiNombre.Text = "Nombre:"
        '
        'etiApellidoMaterno
        '
        Me.etiApellidoMaterno.AutoSize = True
        Me.etiApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiApellidoMaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiApellidoMaterno.Location = New System.Drawing.Point(36, 93)
        Me.etiApellidoMaterno.Name = "etiApellidoMaterno"
        Me.etiApellidoMaterno.Size = New System.Drawing.Size(90, 14)
        Me.etiApellidoMaterno.TabIndex = 2
        Me.etiApellidoMaterno.Text = "Apellido Materno:"
        '
        'etiApellidoPaterno
        '
        Me.etiApellidoPaterno.AutoSize = True
        Me.etiApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiApellidoPaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiApellidoPaterno.Location = New System.Drawing.Point(38, 66)
        Me.etiApellidoPaterno.Name = "etiApellidoPaterno"
        Me.etiApellidoPaterno.Size = New System.Drawing.Size(88, 14)
        Me.etiApellidoPaterno.TabIndex = 1
        Me.etiApellidoPaterno.Text = "Apellido Paterno:"
        '
        'etiDni
        '
        Me.etiDni.AutoSize = True
        Me.etiDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiDni.Location = New System.Drawing.Point(100, 39)
        Me.etiDni.Name = "etiDni"
        Me.etiDni.Size = New System.Drawing.Size(26, 14)
        Me.etiDni.TabIndex = 0
        Me.etiDni.Text = "DNI:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.AutoScroll = True
        Me.UltraTabPageControl3.Controls.Add(Me.agrClienteEmpresa)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(804, 460)
        '
        'agrClienteEmpresa
        '
        Me.agrClienteEmpresa.Controls.Add(Me.Etiqueta13)
        Me.agrClienteEmpresa.Controls.Add(Me.txtDireccionFiscal)
        Me.agrClienteEmpresa.Controls.Add(Me.txtCodigoCE)
        Me.agrClienteEmpresa.Controls.Add(Me.etiCodigoCE)
        Me.agrClienteEmpresa.Controls.Add(Me.txtAbreviatura)
        Me.agrClienteEmpresa.Controls.Add(Me.txtRazonSocial)
        Me.agrClienteEmpresa.Controls.Add(Me.txtRuc)
        Me.agrClienteEmpresa.Controls.Add(Me.verActivoCE)
        Me.agrClienteEmpresa.Controls.Add(Me.etiAbreviatura)
        Me.agrClienteEmpresa.Controls.Add(Me.etiRazonSocial)
        Me.agrClienteEmpresa.Controls.Add(Me.etiRuc)
        Me.agrClienteEmpresa.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrClienteEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrClienteEmpresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrClienteEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.agrClienteEmpresa.Name = "agrClienteEmpresa"
        Me.agrClienteEmpresa.Size = New System.Drawing.Size(804, 209)
        Me.agrClienteEmpresa.TabIndex = 0
        Me.agrClienteEmpresa.Text = "Datos:"
        Me.agrClienteEmpresa.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtCodigoCE
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoCE.Appearance = Appearance8
        Me.txtCodigoCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoCE.Location = New System.Drawing.Point(110, 117)
        Me.txtCodigoCE.MaxLength = 6
        Me.txtCodigoCE.Name = "txtCodigoCE"
        Me.txtCodigoCE.Size = New System.Drawing.Size(77, 21)
        Me.txtCodigoCE.TabIndex = 8
        '
        'etiCodigoCE
        '
        Me.etiCodigoCE.AutoSize = True
        Me.etiCodigoCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigoCE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigoCE.Location = New System.Drawing.Point(41, 121)
        Me.etiCodigoCE.Name = "etiCodigoCE"
        Me.etiCodigoCE.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigoCE.TabIndex = 7
        Me.etiCodigoCE.Text = "Código:"
        '
        'txtAbreviatura
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance9
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(110, 90)
        Me.txtAbreviatura.MaxLength = 100
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(302, 21)
        Me.txtAbreviatura.TabIndex = 6
        '
        'txtRazonSocial
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRazonSocial.Appearance = Appearance10
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRazonSocial.Location = New System.Drawing.Point(110, 63)
        Me.txtRazonSocial.MaxLength = 250
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(481, 21)
        Me.txtRazonSocial.TabIndex = 5
        '
        'txtRuc
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRuc.Appearance = Appearance11
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRuc.Location = New System.Drawing.Point(110, 36)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 21)
        Me.txtRuc.TabIndex = 4
        '
        'verActivoCE
        '
        Me.verActivoCE.AutoSize = True
        Me.verActivoCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivoCE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivoCE.Location = New System.Drawing.Point(110, 178)
        Me.verActivoCE.Name = "verActivoCE"
        Me.verActivoCE.Size = New System.Drawing.Size(51, 17)
        Me.verActivoCE.TabIndex = 3
        Me.verActivoCE.Text = "Activo"
        Me.verActivoCE.Visible = False
        '
        'etiAbreviatura
        '
        Me.etiAbreviatura.AutoSize = True
        Me.etiAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAbreviatura.Location = New System.Drawing.Point(41, 94)
        Me.etiAbreviatura.Name = "etiAbreviatura"
        Me.etiAbreviatura.Size = New System.Drawing.Size(63, 14)
        Me.etiAbreviatura.TabIndex = 2
        Me.etiAbreviatura.Text = "Abreviatura:"
        '
        'etiRazonSocial
        '
        Me.etiRazonSocial.AutoSize = True
        Me.etiRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiRazonSocial.Location = New System.Drawing.Point(35, 67)
        Me.etiRazonSocial.Name = "etiRazonSocial"
        Me.etiRazonSocial.Size = New System.Drawing.Size(72, 14)
        Me.etiRazonSocial.TabIndex = 1
        Me.etiRazonSocial.Text = "Razón Social:"
        '
        'etiRuc
        '
        Me.etiRuc.AutoSize = True
        Me.etiRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRuc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiRuc.Location = New System.Drawing.Point(50, 40)
        Me.etiRuc.Name = "etiRuc"
        Me.etiRuc.Size = New System.Drawing.Size(59, 14)
        Me.etiRuc.TabIndex = 0
        Me.etiRuc.Text = "RUC / DNI:"
        '
        'ficCliente
        '
        Me.ficCliente.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCliente.Controls.Add(Me.UltraTabPageControl1)
        Me.ficCliente.Controls.Add(Me.UltraTabPageControl2)
        Me.ficCliente.Controls.Add(Me.UltraTabPageControl3)
        Me.ficCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCliente.Location = New System.Drawing.Point(0, 0)
        Me.ficCliente.Name = "ficCliente"
        Me.ficCliente.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCliente.Size = New System.Drawing.Size(806, 483)
        Me.ficCliente.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Persona"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Empresa"
        Me.ficCliente.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficCliente.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(804, 460)
        '
        'Etiqueta13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance7
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(23, 149)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(85, 15)
        Me.Etiqueta13.TabIndex = 25
        Me.Etiqueta13.Text = "Direccion Fiscal:"
        '
        'txtDireccionFiscal
        '
        Me.txtDireccionFiscal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDireccionFiscal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionFiscal.Location = New System.Drawing.Point(110, 144)
        Me.txtDireccionFiscal.Name = "txtDireccionFiscal"
        Me.txtDireccionFiscal.Size = New System.Drawing.Size(656, 22)
        Me.txtDireccionFiscal.TabIndex = 24
        '
        'frm_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 483)
        Me.Controls.Add(Me.ficCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Cliente"
        Me.Text = "Cliente"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.colorComisionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrGrillaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGrillaCliente.ResumeLayout(False)
        CType(Me.griCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ordCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCliente.ResumeLayout(False)
        Me.agrCliente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verComisionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.agrClienteEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrClienteEmpresa.ResumeLayout(False)
        Me.agrClienteEmpresa.PerformLayout()
        CType(Me.txtCodigoCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivoCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCliente.ResumeLayout(False)
        CType(Me.txtDireccionFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCliente As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrGrillaCliente As ISL.Controles.Agrupacion
    Friend WithEvents griCliente As ISL.Controles.Grilla
    Friend WithEvents ordCliente As ISL.Controles.OrigenDatos
    Friend WithEvents agrCliente As ISL.Controles.Agrupacion
    Friend WithEvents etiDni As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiApellidoMaterno As ISL.Controles.Etiqueta
    Friend WithEvents etiApellidoPaterno As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaNacimiento As ISL.Controles.Etiqueta
    Friend WithEvents verComisionista As ISL.Controles.Chequear
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents fecFechaNacimiento As ISL.Controles.Fecha
    'Friend WithEvents Sexo1 As ISL.Win.Sexo
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtApellidoMaterno As ISL.Controles.Texto
    Friend WithEvents txtApellidoPaterno As ISL.Controles.Texto
    Friend WithEvents txtDni As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrClienteEmpresa As ISL.Controles.Agrupacion
    Friend WithEvents etiRuc As ISL.Controles.Etiqueta
    Friend WithEvents etiRazonSocial As ISL.Controles.Etiqueta
    Friend WithEvents etiAbreviatura As ISL.Controles.Etiqueta
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtRazonSocial As ISL.Controles.Texto
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents verActivoCE As ISL.Controles.Chequear
    Friend WithEvents txtCodigoCE As ISL.Controles.Texto
    Friend WithEvents etiCodigoCE As ISL.Controles.Etiqueta
    Friend WithEvents Sexo1 As ISL.Win.Sexo
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents etiComisionista As ISL.Controles.Etiqueta
    Friend WithEvents colorComisionista As ISL.Controles.Colores
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Etiqueta13 As Controles.Etiqueta
    Friend WithEvents txtDireccionFiscal As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
