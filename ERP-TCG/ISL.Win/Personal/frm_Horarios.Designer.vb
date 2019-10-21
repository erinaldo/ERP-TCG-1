<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Horarios
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoHorario")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraFin")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lunes")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Martes")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Miercoles")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jueves")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viernes")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sabado")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Domingo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoHorario")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndHoraExtra")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoHorario")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraInicio")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraFin")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lunes")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Martes")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Miercoles")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jueves")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viernes")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sabado")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Domingo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoHorario")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndHoraExtra")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoHorario")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraFin")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lunes")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Martes")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Miercoles")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jueves")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viernes")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sabado")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Domingo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoHorario")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndHoraExtra")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Horarios))
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOperaciones = New ISL.Controles.Agrupacion(Me.components)
        Me.griHorarios = New ISL.Controles.Grilla(Me.components)
        Me.odHorarios = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorAnulado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoHorario1 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griHorarioDetalle = New ISL.Controles.Grilla(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.btnNuevoTipo = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnQuitar = New Infragistics.Win.Misc.UltraButton()
        Me.cboTipoHorario = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.fecHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.ficHorarios = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperaciones.SuspendLayout()
        CType(Me.griHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoHorario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griHorarioDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.cboTipoHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficHorarios.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrOperaciones)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1088, 296)
        '
        'agrOperaciones
        '
        Me.agrOperaciones.Controls.Add(Me.griHorarios)
        Me.agrOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperaciones.ForeColor = System.Drawing.Color.Black
        Me.agrOperaciones.Location = New System.Drawing.Point(0, 63)
        Me.agrOperaciones.Name = "agrOperaciones"
        Me.agrOperaciones.Size = New System.Drawing.Size(1088, 233)
        Me.agrOperaciones.TabIndex = 4
        Me.agrOperaciones.Text = "Horarios"
        Me.agrOperaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griHorarios
        '
        Me.griHorarios.DataSource = Me.odHorarios
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.MaskInput = "{LOC}hh:mm"
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.MaskInput = "{LOC}hh:mm"
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 58
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 68
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 76
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Width = 63
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Width = 73
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Width = 63
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Width = 77
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Width = 222
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.griHorarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griHorarios.DisplayLayout.MaxColScrollRegions = 1
        Me.griHorarios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHorarios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHorarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHorarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHorarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griHorarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griHorarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHorarios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHorarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHorarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.griHorarios.Location = New System.Drawing.Point(2, 18)
        Me.griHorarios.Name = "griHorarios"
        Me.griHorarios.Size = New System.Drawing.Size(1084, 213)
        Me.griHorarios.TabIndex = 7
        '
        'odHorarios
        '
        UltraDataColumn3.DataType = GetType(Date)
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Boolean)
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.odHorarios.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ColorAnulado)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion2.Controls.Add(Me.cboTipoHorario1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1088, 63)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Filtros"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorAnulado
        '
        Me.ColorAnulado.Color = System.Drawing.Color.Pink
        Me.ColorAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAnulado.Location = New System.Drawing.Point(508, 27)
        Me.ColorAnulado.Name = "ColorAnulado"
        Me.ColorAnulado.Size = New System.Drawing.Size(43, 19)
        Me.ColorAnulado.TabIndex = 375
        Me.ColorAnulado.Text = "Pink"
        '
        'Etiqueta14
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance47
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(456, 29)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta14.TabIndex = 374
        Me.Etiqueta14.Text = "Vigente:"
        '
        'cboTipoHorario1
        '
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.cboTipoHorario1.Appearance = Appearance19
        Me.cboTipoHorario1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoHorario1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoHorario1.DropDownListWidth = 400
        Me.cboTipoHorario1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoHorario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoHorario1.ForeColor = System.Drawing.Color.Black
        Me.cboTipoHorario1.Location = New System.Drawing.Point(85, 25)
        Me.cboTipoHorario1.Name = "cboTipoHorario1"
        Me.cboTipoHorario1.Size = New System.Drawing.Size(352, 21)
        Me.cboTipoHorario1.TabIndex = 373
        Me.cboTipoHorario1.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance2
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(11, 29)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta3.TabIndex = 372
        Me.Etiqueta3.Text = "Tipo Horario:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Agrupacion1)
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Enabled = False
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1088, 296)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griHorarioDetalle)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 58)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1088, 238)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Detalle"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griHorarioDetalle
        '
        Me.griHorarioDetalle.DataSource = Me.odHorarios
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "TipoHorario"
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Width = 306
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.MaskInput = "{LOC}hh:mm"
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.MaskInput = "{LOC}hh:mm"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn22.Width = 64
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn23.Width = 52
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn24.Width = 65
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn25.Header.VisiblePosition = 8
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn25.Width = 57
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn26.Header.VisiblePosition = 9
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn26.Width = 58
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn27.Header.VisiblePosition = 10
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn27.Width = 64
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn28.Header.VisiblePosition = 11
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn28.Width = 63
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn29.Header.VisiblePosition = 12
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn29.Width = 56
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 13
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 14
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 15
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 16
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        Me.griHorarioDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griHorarioDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griHorarioDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHorarioDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHorarioDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griHorarioDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHorarioDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griHorarioDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHorarioDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHorarioDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHorarioDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHorarioDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHorarioDetalle.Location = New System.Drawing.Point(3, 16)
        Me.griHorarioDetalle.Name = "griHorarioDetalle"
        Me.griHorarioDetalle.Size = New System.Drawing.Size(1082, 219)
        Me.griHorarioDetalle.TabIndex = 11
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.btnNuevoTipo)
        Me.agrProcesoNegocio.Controls.Add(Me.btnQuitar)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTipoHorario)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta2)
        Me.agrProcesoNegocio.Controls.Add(Me.btnAgregar)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Controls.Add(Me.fecHoraFin)
        Me.agrProcesoNegocio.Controls.Add(Me.fecHoraInicio)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1088, 58)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnNuevoTipo
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance15.Image = "16 (File new).ico"
        Me.btnNuevoTipo.Appearance = Appearance15
        Me.btnNuevoTipo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTipo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoTipo.ImageList = Me.imagenes
        Me.btnNuevoTipo.Location = New System.Drawing.Point(443, 20)
        Me.btnNuevoTipo.Name = "btnNuevoTipo"
        Me.btnNuevoTipo.Size = New System.Drawing.Size(25, 25)
        Me.btnNuevoTipo.TabIndex = 373
        Me.btnNuevoTipo.TabStop = False
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "16 (Ok).ico")
        Me.imagenes.Images.SetKeyName(1, "16 (Money bag).ico")
        Me.imagenes.Images.SetKeyName(2, "16 (Minus).ico")
        Me.imagenes.Images.SetKeyName(3, "16 (Delete).ico")
        Me.imagenes.Images.SetKeyName(4, "16 (File new).ico")
        '
        'btnQuitar
        '
        Appearance77.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnQuitar.Appearance = Appearance77
        Me.btnQuitar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitar.Location = New System.Drawing.Point(771, 18)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(30, 30)
        Me.btnQuitar.TabIndex = 372
        '
        'cboTipoHorario
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboTipoHorario.Appearance = Appearance4
        Me.cboTipoHorario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoHorario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoHorario.DropDownListWidth = 400
        Me.cboTipoHorario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoHorario.ForeColor = System.Drawing.Color.Black
        Me.cboTipoHorario.Location = New System.Drawing.Point(85, 24)
        Me.cboTipoHorario.Name = "cboTipoHorario"
        Me.cboTipoHorario.Size = New System.Drawing.Size(352, 21)
        Me.cboTipoHorario.TabIndex = 371
        Me.cboTipoHorario.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(11, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta2.TabIndex = 370
        Me.Etiqueta2.Text = "Tipo Horario:"
        '
        'btnAgregar
        '
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAgregar.Appearance = Appearance8
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(735, 18)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 369
        '
        'Etiqueta1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance6
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(621, 28)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta1.TabIndex = 368
        Me.Etiqueta1.Text = "Hora Fin:"
        '
        'fecHoraFin
        '
        Me.fecHoraFin.CustomFormat = "HH:mm"
        Me.fecHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHoraFin.Location = New System.Drawing.Point(676, 24)
        Me.fecHoraFin.Name = "fecHoraFin"
        Me.fecHoraFin.ShowUpDown = True
        Me.fecHoraFin.Size = New System.Drawing.Size(53, 20)
        Me.fecHoraFin.TabIndex = 367
        Me.fecHoraFin.Value = New Date(2012, 11, 19, 0, 0, 0, 0)
        '
        'fecHoraInicio
        '
        Me.fecHoraInicio.CustomFormat = "HH:mm"
        Me.fecHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHoraInicio.Location = New System.Drawing.Point(547, 24)
        Me.fecHoraInicio.Name = "fecHoraInicio"
        Me.fecHoraInicio.ShowUpDown = True
        Me.fecHoraInicio.Size = New System.Drawing.Size(53, 20)
        Me.fecHoraInicio.TabIndex = 366
        Me.fecHoraInicio.Value = New Date(2012, 11, 19, 0, 0, 0, 0)
        '
        'etiTrabajador
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.etiTrabajador.Appearance = Appearance1
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(481, 28)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 364
        Me.etiTrabajador.Text = "Hora Inicio:"
        '
        'ficHorarios
        '
        Me.ficHorarios.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficHorarios.Controls.Add(Me.UltraTabPageControl7)
        Me.ficHorarios.Controls.Add(Me.utpDetalle)
        Me.ficHorarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficHorarios.Location = New System.Drawing.Point(0, 0)
        Me.ficHorarios.Name = "ficHorarios"
        Me.ficHorarios.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficHorarios.Size = New System.Drawing.Size(1090, 319)
        Me.ficHorarios.TabIndex = 9
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficHorarios.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficHorarios.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1088, 296)
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EvaluarToolStripMenuItem, Me.CobrarToolStripMenuItem, Me.AnularToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(112, 136)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EvaluarToolStripMenuItem
        '
        Me.EvaluarToolStripMenuItem.Image = CType(resources.GetObject("EvaluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EvaluarToolStripMenuItem.Name = "EvaluarToolStripMenuItem"
        Me.EvaluarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EvaluarToolStripMenuItem.Text = "Aprobar"
        '
        'CobrarToolStripMenuItem
        '
        Me.CobrarToolStripMenuItem.Image = CType(resources.GetObject("CobrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CobrarToolStripMenuItem.Name = "CobrarToolStripMenuItem"
        Me.CobrarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CobrarToolStripMenuItem.Text = "Cobrar"
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AnularToolStripMenuItem.Text = "Anular"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'frm_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 319)
        Me.Controls.Add(Me.ficHorarios)
        Me.Name = "frm_Horarios"
        Me.Text = "Horarios"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperaciones.ResumeLayout(False)
        CType(Me.griHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoHorario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griHorarioDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.cboTipoHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficHorarios.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficHorarios As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odHorarios As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvaluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoHorario As ISL.Controles.Combo
    Friend WithEvents griHorarioDetalle As ISL.Controles.Grilla
    Friend WithEvents btnQuitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents agrOperaciones As ISL.Controles.Agrupacion
    Friend WithEvents griHorarios As ISL.Controles.Grilla
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents cboTipoHorario1 As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAnulado As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents btnNuevoTipo As ISL.Controles.Boton
End Class
