<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proveedor
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersonaEmpresa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPersonaEmpresa")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersonaEmpresa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActividad")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Email")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim E_Sexo1 As ISL.EntidadesWCF.e_Sexo = New ISL.EntidadesWCF.e_Sexo()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Proveedor))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrGrillaProveedor = New ISL.Controles.Agrupacion(Me.components)
        Me.griProveedor = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ordProveedor = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrProveedor = New ISL.Controles.Agrupacion(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaNacimiento = New ISL.Controles.Fecha(Me.components)
        Me.Sexo1 = New ISL.Win.Sexo()
        Me.etiSexo = New ISL.Controles.Etiqueta(Me.components)
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
        Me.btnObtenerSunat = New ISL.Controles.Boton(Me.components)
        Me.btnGuardarProveedor = New ISL.Controles.Boton(Me.components)
        Me.txtCodigoCE = New ISL.Controles.Texto(Me.components)
        Me.etiCodigoCE = New ISL.Controles.Etiqueta(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtRazonSocial = New ISL.Controles.Texto(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.verActivoCE = New ISL.Controles.Chequear(Me.components)
        Me.etiAbreviatura = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRazonSocial = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRuc = New ISL.Controles.Etiqueta(Me.components)
        Me.ficProveedor = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrGrillaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGrillaProveedor.SuspendLayout()
        CType(Me.griProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ordProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProveedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sexo1.SuspendLayout()
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
        CType(Me.ficProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrGrillaProveedor)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(702, 448)
        '
        'agrGrillaProveedor
        '
        Me.agrGrillaProveedor.Controls.Add(Me.griProveedor)
        Me.agrGrillaProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrGrillaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGrillaProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrGrillaProveedor.Location = New System.Drawing.Point(0, 0)
        Me.agrGrillaProveedor.Name = "agrGrillaProveedor"
        Me.agrGrillaProveedor.Size = New System.Drawing.Size(702, 448)
        Me.agrGrillaProveedor.TabIndex = 0
        Me.agrGrillaProveedor.Text = "Listado de Proveedor:"
        Me.agrGrillaProveedor.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griProveedor
        '
        Me.griProveedor.ContextMenuStrip = Me.MenuContextual1
        Me.griProveedor.DataSource = Me.ordProveedor
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 262
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griProveedor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griProveedor.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProveedor.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProveedor.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProveedor.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProveedor.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProveedor.Location = New System.Drawing.Point(3, 16)
        Me.griProveedor.Name = "griProveedor"
        Me.griProveedor.Size = New System.Drawing.Size(696, 429)
        Me.griProveedor.TabIndex = 0
        Me.griProveedor.Text = "Información de proveedores"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Proveedor"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Proveedor seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Proveedor seleccionado"
        '
        'ordProveedor
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        Me.ordProveedor.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrProveedor)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(702, 448)
        '
        'agrProveedor
        '
        Me.agrProveedor.Controls.Add(Me.PictureBox1)
        Me.agrProveedor.Controls.Add(Me.txtCodigo)
        Me.agrProveedor.Controls.Add(Me.etiCodigo)
        Me.agrProveedor.Controls.Add(Me.verActivo)
        Me.agrProveedor.Controls.Add(Me.fecFechaNacimiento)
        Me.agrProveedor.Controls.Add(Me.Sexo1)
        Me.agrProveedor.Controls.Add(Me.txtNombre)
        Me.agrProveedor.Controls.Add(Me.txtApellidoMaterno)
        Me.agrProveedor.Controls.Add(Me.txtApellidoPaterno)
        Me.agrProveedor.Controls.Add(Me.txtDni)
        Me.agrProveedor.Controls.Add(Me.etiFechaNacimiento)
        Me.agrProveedor.Controls.Add(Me.etiNombre)
        Me.agrProveedor.Controls.Add(Me.etiApellidoMaterno)
        Me.agrProveedor.Controls.Add(Me.etiApellidoPaterno)
        Me.agrProveedor.Controls.Add(Me.etiDni)
        Me.agrProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProveedor.Location = New System.Drawing.Point(0, 0)
        Me.agrProveedor.Name = "agrProveedor"
        Me.agrProveedor.Size = New System.Drawing.Size(702, 266)
        Me.agrProveedor.TabIndex = 0
        Me.agrProveedor.Text = "Datos"
        Me.agrProveedor.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(507, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'txtCodigo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance1
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(132, 204)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 32
        '
        'etiCodigo
        '
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(79, 206)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 31
        Me.etiCodigo.Text = "Código:"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(132, 231)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(120, 20)
        Me.verActivo.TabIndex = 29
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
        Me.fecFechaNacimiento.Location = New System.Drawing.Point(132, 177)
        Me.fecFechaNacimiento.Name = "fecFechaNacimiento"
        Me.fecFechaNacimiento.Size = New System.Drawing.Size(100, 21)
        Me.fecFechaNacimiento.TabIndex = 28
        '
        'Sexo1
        '
        Me.Sexo1.BackColor = System.Drawing.Color.White
        Me.Sexo1.Controls.Add(Me.etiSexo)
        Me.Sexo1.Location = New System.Drawing.Point(74, 147)
        Me.Sexo1.Name = "Sexo1"
        E_Sexo1.Abreviatura = "M"
        E_Sexo1.Id = "1"
        E_Sexo1.Nombre = "Masculino"
        Me.Sexo1.Sexo = E_Sexo1
        Me.Sexo1.Size = New System.Drawing.Size(204, 24)
        Me.Sexo1.TabIndex = 27
        '
        'etiSexo
        '
        Me.etiSexo.AutoSize = True
        Me.etiSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSexo.ForeColor = System.Drawing.Color.Black
        Me.etiSexo.Location = New System.Drawing.Point(4, 4)
        Me.etiSexo.Name = "etiSexo"
        Me.etiSexo.Size = New System.Drawing.Size(29, 14)
        Me.etiSexo.TabIndex = 1
        Me.etiSexo.Text = "Sexo"
        '
        'txtNombre
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(132, 120)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(352, 21)
        Me.txtNombre.TabIndex = 26
        '
        'txtApellidoMaterno
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoMaterno.Appearance = Appearance4
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(132, 93)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(352, 21)
        Me.txtApellidoMaterno.TabIndex = 25
        '
        'txtApellidoPaterno
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoPaterno.Appearance = Appearance5
        Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(132, 66)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(352, 21)
        Me.txtApellidoPaterno.TabIndex = 24
        '
        'txtDni
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDni.Appearance = Appearance6
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDni.Location = New System.Drawing.Point(132, 39)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 21)
        Me.txtDni.TabIndex = 23
        '
        'etiFechaNacimiento
        '
        Me.etiFechaNacimiento.AutoSize = True
        Me.etiFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaNacimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiFechaNacimiento.Location = New System.Drawing.Point(25, 179)
        Me.etiFechaNacimiento.Name = "etiFechaNacimiento"
        Me.etiFechaNacimiento.Size = New System.Drawing.Size(96, 14)
        Me.etiFechaNacimiento.TabIndex = 22
        Me.etiFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(75, 122)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 21
        Me.etiNombre.Text = "Nombre:"
        '
        'etiApellidoMaterno
        '
        Me.etiApellidoMaterno.AutoSize = True
        Me.etiApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiApellidoMaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiApellidoMaterno.Location = New System.Drawing.Point(31, 95)
        Me.etiApellidoMaterno.Name = "etiApellidoMaterno"
        Me.etiApellidoMaterno.Size = New System.Drawing.Size(90, 14)
        Me.etiApellidoMaterno.TabIndex = 20
        Me.etiApellidoMaterno.Text = "Apellido Materno:"
        '
        'etiApellidoPaterno
        '
        Me.etiApellidoPaterno.AutoSize = True
        Me.etiApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiApellidoPaterno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiApellidoPaterno.Location = New System.Drawing.Point(33, 68)
        Me.etiApellidoPaterno.Name = "etiApellidoPaterno"
        Me.etiApellidoPaterno.Size = New System.Drawing.Size(88, 14)
        Me.etiApellidoPaterno.TabIndex = 19
        Me.etiApellidoPaterno.Text = "Apellido Paterno:"
        '
        'etiDni
        '
        Me.etiDni.AutoSize = True
        Me.etiDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiDni.Location = New System.Drawing.Point(95, 41)
        Me.etiDni.Name = "etiDni"
        Me.etiDni.Size = New System.Drawing.Size(26, 14)
        Me.etiDni.TabIndex = 18
        Me.etiDni.Text = "DNI:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.agrClienteEmpresa)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(702, 448)
        '
        'agrClienteEmpresa
        '
        Me.agrClienteEmpresa.Controls.Add(Me.btnObtenerSunat)
        Me.agrClienteEmpresa.Controls.Add(Me.btnGuardarProveedor)
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
        Me.agrClienteEmpresa.Size = New System.Drawing.Size(702, 192)
        Me.agrClienteEmpresa.TabIndex = 1
        Me.agrClienteEmpresa.Text = "Datos:"
        Me.agrClienteEmpresa.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnObtenerSunat
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.hire_me
        Me.btnObtenerSunat.Appearance = Appearance7
        Me.btnObtenerSunat.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnObtenerSunat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnObtenerSunat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerSunat.ForeColor = System.Drawing.Color.Black
        Me.btnObtenerSunat.Location = New System.Drawing.Point(229, 36)
        Me.btnObtenerSunat.Name = "btnObtenerSunat"
        Me.btnObtenerSunat.Size = New System.Drawing.Size(126, 21)
        Me.btnObtenerSunat.TabIndex = 22
        Me.btnObtenerSunat.Text = "Consultar Sunat"
        '
        'btnGuardarProveedor
        '
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardarProveedor.Appearance = Appearance8
        Me.btnGuardarProveedor.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarProveedor.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarProveedor.Location = New System.Drawing.Point(167, 140)
        Me.btnGuardarProveedor.Name = "btnGuardarProveedor"
        Me.btnGuardarProveedor.Size = New System.Drawing.Size(77, 25)
        Me.btnGuardarProveedor.TabIndex = 9
        Me.btnGuardarProveedor.Text = "Guardar"
        Me.btnGuardarProveedor.Visible = False
        '
        'txtCodigoCE
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoCE.Appearance = Appearance9
        Me.txtCodigoCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoCE.Location = New System.Drawing.Point(110, 117)
        Me.txtCodigoCE.Name = "txtCodigoCE"
        Me.txtCodigoCE.Size = New System.Drawing.Size(302, 21)
        Me.txtCodigoCE.TabIndex = 8
        '
        'etiCodigoCE
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.etiCodigoCE.Appearance = Appearance10
        Me.etiCodigoCE.AutoSize = True
        Me.etiCodigoCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigoCE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigoCE.Location = New System.Drawing.Point(63, 119)
        Me.etiCodigoCE.Name = "etiCodigoCE"
        Me.etiCodigoCE.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigoCE.TabIndex = 7
        Me.etiCodigoCE.Text = "Código:"
        '
        'txtAbreviatura
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance11
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(110, 90)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(302, 21)
        Me.txtAbreviatura.TabIndex = 6
        '
        'txtRazonSocial
        '
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRazonSocial.Appearance = Appearance12
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRazonSocial.Location = New System.Drawing.Point(110, 63)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(481, 21)
        Me.txtRazonSocial.TabIndex = 5
        '
        'txtRuc
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRuc.Appearance = Appearance13
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRuc.Location = New System.Drawing.Point(110, 36)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(113, 21)
        Me.txtRuc.TabIndex = 4
        '
        'verActivoCE
        '
        Me.verActivoCE.AutoSize = True
        Me.verActivoCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivoCE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivoCE.Location = New System.Drawing.Point(111, 142)
        Me.verActivoCE.Name = "verActivoCE"
        Me.verActivoCE.Size = New System.Drawing.Size(51, 17)
        Me.verActivoCE.TabIndex = 3
        Me.verActivoCE.Text = "Activo"
        Me.verActivoCE.Visible = False
        '
        'etiAbreviatura
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.etiAbreviatura.Appearance = Appearance14
        Me.etiAbreviatura.AutoSize = True
        Me.etiAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAbreviatura.Location = New System.Drawing.Point(42, 92)
        Me.etiAbreviatura.Name = "etiAbreviatura"
        Me.etiAbreviatura.Size = New System.Drawing.Size(63, 14)
        Me.etiAbreviatura.TabIndex = 2
        Me.etiAbreviatura.Text = "Abreviatura:"
        '
        'etiRazonSocial
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.etiRazonSocial.Appearance = Appearance15
        Me.etiRazonSocial.AutoSize = True
        Me.etiRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiRazonSocial.Location = New System.Drawing.Point(33, 65)
        Me.etiRazonSocial.Name = "etiRazonSocial"
        Me.etiRazonSocial.Size = New System.Drawing.Size(72, 14)
        Me.etiRazonSocial.TabIndex = 1
        Me.etiRazonSocial.Text = "Razón Social:"
        '
        'etiRuc
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.etiRuc.Appearance = Appearance16
        Me.etiRuc.AutoSize = True
        Me.etiRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRuc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiRuc.Location = New System.Drawing.Point(74, 38)
        Me.etiRuc.Name = "etiRuc"
        Me.etiRuc.Size = New System.Drawing.Size(31, 14)
        Me.etiRuc.TabIndex = 0
        Me.etiRuc.Text = "RUC:"
        '
        'ficProveedor
        '
        Me.ficProveedor.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficProveedor.Controls.Add(Me.UltraTabPageControl1)
        Me.ficProveedor.Controls.Add(Me.UltraTabPageControl2)
        Me.ficProveedor.Controls.Add(Me.UltraTabPageControl3)
        Me.ficProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficProveedor.Location = New System.Drawing.Point(0, 0)
        Me.ficProveedor.Name = "ficProveedor"
        Me.ficProveedor.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficProveedor.Size = New System.Drawing.Size(704, 471)
        Me.ficProveedor.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Persona"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Empresa"
        Me.ficProveedor.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficProveedor.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(702, 448)
        '
        'frm_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 471)
        Me.Controls.Add(Me.ficProveedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrGrillaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGrillaProveedor.ResumeLayout(False)
        CType(Me.griProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ordProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProveedor.ResumeLayout(False)
        Me.agrProveedor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sexo1.ResumeLayout(False)
        Me.Sexo1.PerformLayout()
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
        CType(Me.ficProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficProveedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficProveedor As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrGrillaProveedor As ISL.Controles.Agrupacion
    Friend WithEvents griProveedor As ISL.Controles.Grilla
    Friend WithEvents ordProveedor As ISL.Controles.OrigenDatos
    Friend WithEvents agrProveedor As ISL.Controles.Agrupacion
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents fecFechaNacimiento As ISL.Controles.Fecha
    Friend WithEvents Sexo1 As ISL.Win.Sexo
    Friend WithEvents etiSexo As ISL.Controles.Etiqueta
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtApellidoMaterno As ISL.Controles.Texto
    Friend WithEvents txtApellidoPaterno As ISL.Controles.Texto
    Friend WithEvents txtDni As ISL.Controles.Texto
    Friend WithEvents etiFechaNacimiento As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiApellidoMaterno As ISL.Controles.Etiqueta
    Friend WithEvents etiApellidoPaterno As ISL.Controles.Etiqueta
    Friend WithEvents etiDni As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrClienteEmpresa As ISL.Controles.Agrupacion
    Friend WithEvents txtCodigoCE As ISL.Controles.Texto
    Friend WithEvents etiCodigoCE As ISL.Controles.Etiqueta
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtRazonSocial As ISL.Controles.Texto
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents verActivoCE As ISL.Controles.Chequear
    Friend WithEvents etiAbreviatura As ISL.Controles.Etiqueta
    Friend WithEvents etiRazonSocial As ISL.Controles.Etiqueta
    Friend WithEvents etiRuc As ISL.Controles.Etiqueta
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGuardarProveedor As ISL.Controles.Boton
    Friend WithEvents btnObtenerSunat As ISL.Controles.Boton

End Class
