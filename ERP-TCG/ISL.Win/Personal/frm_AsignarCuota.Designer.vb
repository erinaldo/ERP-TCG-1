<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarCuota
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
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuota")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AsignarCuota))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuota")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrGrillaTrabajador = New ISL.Controles.Agrupacion(Me.components)
        Me.griTrabajadorCuota = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odCuota = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCuota = New ISL.Controles.NumeroDecimal(Me.components)
        Me.agrDatosBasicos = New ISL.Controles.Agrupacion(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaIngreso = New ISL.Controles.Fecha(Me.components)
        Me.chkDisponible = New ISL.Controles.Chequear(Me.components)
        Me.txtCargo = New ISL.Controles.Texto(Me.components)
        Me.etiFechaIngreso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCargo = New ISL.Controles.Etiqueta(Me.components)
        Me.txtArea = New ISL.Controles.Texto(Me.components)
        Me.etiArea = New ISL.Controles.Etiqueta(Me.components)
        Me.FotoTrabajador = New System.Windows.Forms.PictureBox()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCuota = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaFin = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaFin = New ISL.Controles.Fecha(Me.components)
        Me.etiFechaInicio = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaInicio = New ISL.Controles.Fecha(Me.components)
        Me.ficTrabajador = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrGrillaTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGrillaTrabajador.SuspendLayout()
        CType(Me.griTrabajadorCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion.SuspendLayout()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBasicos.SuspendLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficTrabajador.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrGrillaTrabajador)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(997, 478)
        '
        'agrGrillaTrabajador
        '
        Me.agrGrillaTrabajador.Controls.Add(Me.griTrabajadorCuota)
        Me.agrGrillaTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrGrillaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGrillaTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrGrillaTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.agrGrillaTrabajador.Name = "agrGrillaTrabajador"
        Me.agrGrillaTrabajador.Size = New System.Drawing.Size(997, 478)
        Me.agrGrillaTrabajador.TabIndex = 2
        Me.agrGrillaTrabajador.Text = "Lista de Cuotas"
        Me.agrGrillaTrabajador.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griTrabajadorCuota
        '
        Me.griTrabajadorCuota.ContextMenuStrip = Me.MenuContextual1
        Me.griTrabajadorCuota.DataSource = Me.odCuota
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.Width = 65
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.Width = 305
        UltraGridColumn15.Header.VisiblePosition = 4
        UltraGridColumn16.Header.VisiblePosition = 5
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn17.FilterCellAppearance = Appearance1
        UltraGridColumn17.Header.VisiblePosition = 6
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.Header.VisiblePosition = 7
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 9
        UltraGridColumn20.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTrabajadorCuota.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTrabajadorCuota.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTrabajadorCuota.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTrabajadorCuota.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTrabajadorCuota.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTrabajadorCuota.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTrabajadorCuota.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTrabajadorCuota.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTrabajadorCuota.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTrabajadorCuota.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTrabajadorCuota.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griTrabajadorCuota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTrabajadorCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTrabajadorCuota.Location = New System.Drawing.Point(2, 18)
        Me.griTrabajadorCuota.Name = "griTrabajadorCuota"
        Me.griTrabajadorCuota.Size = New System.Drawing.Size(993, 458)
        Me.griTrabajadorCuota.TabIndex = 1
        Me.griTrabajadorCuota.Text = "Información de trabajadores"
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
        Me.InsertarToolStripMenuItem.Image = CType(resources.GetObject("InsertarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Marca"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = CType(resources.GetObject("ActualizarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Marca seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Marca seleccionada"
        '
        'odCuota
        '
        UltraDataColumn7.DataType = GetType(Decimal)
        Me.odCuota.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(997, 478)
        '
        'Agrupacion
        '
        Me.Agrupacion.Controls.Add(Me.cboTrabajadores)
        Me.Agrupacion.Controls.Add(Me.txtCodigo)
        Me.Agrupacion.Controls.Add(Me.etiCodigo)
        Me.Agrupacion.Controls.Add(Me.txtCuota)
        Me.Agrupacion.Controls.Add(Me.agrDatosBasicos)
        Me.Agrupacion.Controls.Add(Me.FotoTrabajador)
        Me.Agrupacion.Controls.Add(Me.etiTrabajador)
        Me.Agrupacion.Controls.Add(Me.etiCuota)
        Me.Agrupacion.Controls.Add(Me.etiFechaFin)
        Me.Agrupacion.Controls.Add(Me.fecFechaFin)
        Me.Agrupacion.Controls.Add(Me.etiFechaInicio)
        Me.Agrupacion.Controls.Add(Me.fecFechaInicio)
        Me.Agrupacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion.Name = "Agrupacion"
        Me.Agrupacion.Size = New System.Drawing.Size(997, 350)
        Me.Agrupacion.TabIndex = 45
        Me.Agrupacion.Text = "Datos Cuota y Trabajador"
        Me.Agrupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboTrabajadores
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance2
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Enabled = False
        Me.cboTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(76, 46)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(350, 21)
        Me.cboTrabajadores.TabIndex = 235
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'txtCodigo
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Appearance = Appearance3
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(76, 23)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 234
        '
        'etiCodigo
        '
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.Black
        Me.etiCodigo.Location = New System.Drawing.Point(31, 27)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 233
        Me.etiCodigo.Text = "Código:"
        '
        'txtCuota
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCuota.Appearance = Appearance4
        Me.txtCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCuota.Location = New System.Drawing.Point(76, 69)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.NullText = "0.00"
        Me.txtCuota.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtCuota.Size = New System.Drawing.Size(90, 21)
        Me.txtCuota.TabIndex = 232
        '
        'agrDatosBasicos
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.agrDatosBasicos.ContentAreaAppearance = Appearance5
        Me.agrDatosBasicos.Controls.Add(Me.verActivo)
        Me.agrDatosBasicos.Controls.Add(Me.fecFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.chkDisponible)
        Me.agrDatosBasicos.Controls.Add(Me.txtCargo)
        Me.agrDatosBasicos.Controls.Add(Me.etiFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.etiCargo)
        Me.agrDatosBasicos.Controls.Add(Me.txtArea)
        Me.agrDatosBasicos.Controls.Add(Me.etiArea)
        Me.agrDatosBasicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBasicos.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBasicos.Location = New System.Drawing.Point(176, 144)
        Me.agrDatosBasicos.Name = "agrDatosBasicos"
        Me.agrDatosBasicos.Size = New System.Drawing.Size(250, 200)
        Me.agrDatosBasicos.TabIndex = 45
        Me.agrDatosBasicos.Text = "Datos Básicos del Trabajador"
        Me.agrDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrDatosBasicos.Visible = False
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(7, 157)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 235
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'fecFechaIngreso
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Appearance = Appearance6
        Me.fecFechaIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Location = New System.Drawing.Point(105, 112)
        Me.fecFechaIngreso.Name = "fecFechaIngreso"
        Me.fecFechaIngreso.ReadOnly = True
        Me.fecFechaIngreso.Size = New System.Drawing.Size(90, 21)
        Me.fecFechaIngreso.TabIndex = 3
        '
        'chkDisponible
        '
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisponible.ForeColor = System.Drawing.Color.Black
        Me.chkDisponible.Location = New System.Drawing.Point(7, 134)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(73, 17)
        Me.chkDisponible.TabIndex = 2
        Me.chkDisponible.Text = "Disponible"
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(46, 66)
        Me.txtCargo.Multiline = True
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(200, 42)
        Me.txtCargo.TabIndex = 1
        Me.txtCargo.Text = "[CARGO]"
        '
        'etiFechaIngreso
        '
        Me.etiFechaIngreso.AutoSize = True
        Me.etiFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.etiFechaIngreso.Location = New System.Drawing.Point(6, 114)
        Me.etiFechaIngreso.Name = "etiFechaIngreso"
        Me.etiFechaIngreso.Size = New System.Drawing.Size(95, 14)
        Me.etiFechaIngreso.TabIndex = 0
        Me.etiFechaIngreso.Text = "Fecha de Ingreso :"
        '
        'etiCargo
        '
        Me.etiCargo.AutoSize = True
        Me.etiCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCargo.ForeColor = System.Drawing.Color.Black
        Me.etiCargo.Location = New System.Drawing.Point(5, 67)
        Me.etiCargo.Name = "etiCargo"
        Me.etiCargo.Size = New System.Drawing.Size(40, 14)
        Me.etiCargo.TabIndex = 0
        Me.etiCargo.Text = "Cargo :"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(46, 22)
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(200, 42)
        Me.txtArea.TabIndex = 1
        Me.txtArea.Text = "[AREA]"
        '
        'etiArea
        '
        Me.etiArea.AutoSize = True
        Me.etiArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiArea.ForeColor = System.Drawing.Color.Black
        Me.etiArea.Location = New System.Drawing.Point(11, 23)
        Me.etiArea.Name = "etiArea"
        Me.etiArea.Size = New System.Drawing.Size(33, 14)
        Me.etiArea.TabIndex = 0
        Me.etiArea.Text = "Area :"
        '
        'FotoTrabajador
        '
        Me.FotoTrabajador.Location = New System.Drawing.Point(4, 144)
        Me.FotoTrabajador.Name = "FotoTrabajador"
        Me.FotoTrabajador.Size = New System.Drawing.Size(170, 200)
        Me.FotoTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTrabajador.TabIndex = 44
        Me.FotoTrabajador.TabStop = False
        '
        'etiTrabajador
        '
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(12, 50)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 36
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'etiCuota
        '
        Me.etiCuota.AutoSize = True
        Me.etiCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCuota.ForeColor = System.Drawing.Color.Black
        Me.etiCuota.Location = New System.Drawing.Point(36, 73)
        Me.etiCuota.Name = "etiCuota"
        Me.etiCuota.Size = New System.Drawing.Size(36, 14)
        Me.etiCuota.TabIndex = 34
        Me.etiCuota.Text = "Cuota:"
        '
        'etiFechaFin
        '
        Me.etiFechaFin.AutoSize = True
        Me.etiFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaFin.ForeColor = System.Drawing.Color.Black
        Me.etiFechaFin.Location = New System.Drawing.Point(16, 119)
        Me.etiFechaFin.Name = "etiFechaFin"
        Me.etiFechaFin.Size = New System.Drawing.Size(56, 14)
        Me.etiFechaFin.TabIndex = 32
        Me.etiFechaFin.Text = "Fecha Fin:"
        '
        'fecFechaFin
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaFin.Appearance = Appearance7
        Me.fecFechaFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaFin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaFin.Location = New System.Drawing.Point(76, 115)
        Me.fecFechaFin.Name = "fecFechaFin"
        Me.fecFechaFin.Size = New System.Drawing.Size(90, 21)
        Me.fecFechaFin.TabIndex = 33
        '
        'etiFechaInicio
        '
        Me.etiFechaInicio.AutoSize = True
        Me.etiFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.etiFechaInicio.Location = New System.Drawing.Point(5, 96)
        Me.etiFechaInicio.Name = "etiFechaInicio"
        Me.etiFechaInicio.Size = New System.Drawing.Size(66, 14)
        Me.etiFechaInicio.TabIndex = 28
        Me.etiFechaInicio.Text = "Fecha Inicio:"
        '
        'fecFechaInicio
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaInicio.Appearance = Appearance8
        Me.fecFechaInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaInicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFechaInicio.Location = New System.Drawing.Point(76, 92)
        Me.fecFechaInicio.Name = "fecFechaInicio"
        Me.fecFechaInicio.Size = New System.Drawing.Size(90, 21)
        Me.fecFechaInicio.TabIndex = 29
        '
        'ficTrabajador
        '
        Me.ficTrabajador.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficTrabajador.Controls.Add(Me.UltraTabPageControl1)
        Me.ficTrabajador.Controls.Add(Me.UltraTabPageControl2)
        Me.ficTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.ficTrabajador.Name = "ficTrabajador"
        Me.ficTrabajador.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficTrabajador.Size = New System.Drawing.Size(999, 501)
        Me.ficTrabajador.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficTrabajador.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficTrabajador.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(997, 478)
        '
        'frm_AsignarCuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 501)
        Me.Controls.Add(Me.ficTrabajador)
        Me.Name = "frm_AsignarCuota"
        Me.Text = "Asignar Cuota"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrGrillaTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGrillaTrabajador.ResumeLayout(False)
        CType(Me.griTrabajadorCuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odCuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion.ResumeLayout(False)
        Me.Agrupacion.PerformLayout()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBasicos.ResumeLayout(False)
        Me.agrDatosBasicos.PerformLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficTrabajador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficTrabajador As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrGrillaTrabajador As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion As ISL.Controles.Agrupacion
    Friend WithEvents etiCuota As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaFin As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaFin As ISL.Controles.Fecha
    Friend WithEvents etiFechaInicio As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaInicio As ISL.Controles.Fecha
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents agrDatosBasicos As ISL.Controles.Agrupacion
    Friend WithEvents fecFechaIngreso As ISL.Controles.Fecha
    Friend WithEvents chkDisponible As ISL.Controles.Chequear
    Friend WithEvents txtCargo As ISL.Controles.Texto
    Friend WithEvents etiFechaIngreso As ISL.Controles.Etiqueta
    Friend WithEvents etiCargo As ISL.Controles.Etiqueta
    Friend WithEvents txtArea As ISL.Controles.Texto
    Friend WithEvents etiArea As ISL.Controles.Etiqueta
    Friend WithEvents FotoTrabajador As System.Windows.Forms.PictureBox
    Friend WithEvents txtCuota As ISL.Controles.NumeroDecimal
    Friend WithEvents odCuota As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents griTrabajadorCuota As ISL.Controles.Grilla
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
