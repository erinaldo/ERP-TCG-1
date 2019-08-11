<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SueldoTrabajador
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMantSueTra")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GrabarSue")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CancelarSue")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GrabarSue")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CancelarSue")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griSueldoTrabajador = New ISL.Controles.Grilla(Me.components)
        Me.mnuSueTra = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOtros = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.utpMantSueTra = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHistorial = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboPeriocidad = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoPago = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecActividad = New System.Windows.Forms.DateTimePicker()
        Me.ndSueldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me._utpMantSueTra_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuMantSueTra = New ISL.Controles.Menu(Me.components)
        Me._utpMantSueTra_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantSueTra_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griImporta = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnBuscar = New ISL.Controles.Boton(Me.components)
        Me.btnValidar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.verTrabajador = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorNoRegistrados = New ISL.Controles.Colores(Me.components)
        Me.colorRegistrados = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griOtros = New ISL.Controles.Grilla(Me.components)
        Me.agrOperacion = New ISL.Controles.Agrupacion(Me.components)
        Me.btnVerificarMas = New ISL.Controles.Boton(Me.components)
        Me.btnBuscarMas = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoMas = New ISL.Controles.Combo(Me.components)
        Me.ficSueldoTrabajador = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkVigente = New ISL.Controles.Chequear(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griSueldoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuSueTra.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpMantSueTra.SuspendLayout()
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cboPeriocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndSueldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMantSueTra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griImporta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.verTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.colorNoRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperacion.SuspendLayout()
        CType(Me.cboTipoMas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficSueldoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficSueldoTrabajador.SuspendLayout()
        CType(Me.chkVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griSueldoTrabajador)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(729, 339)
        '
        'griSueldoTrabajador
        '
        Me.griSueldoTrabajador.ContextMenuStrip = Me.mnuSueTra
        Me.griSueldoTrabajador.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griSueldoTrabajador.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griSueldoTrabajador.DisplayLayout.MaxColScrollRegions = 1
        Me.griSueldoTrabajador.DisplayLayout.MaxRowScrollRegions = 1
        Me.griSueldoTrabajador.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSueldoTrabajador.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSueldoTrabajador.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griSueldoTrabajador.DisplayLayout.Override.CellPadding = 0
        Me.griSueldoTrabajador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griSueldoTrabajador.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griSueldoTrabajador.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griSueldoTrabajador.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griSueldoTrabajador.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griSueldoTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSueldoTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSueldoTrabajador.Location = New System.Drawing.Point(0, 45)
        Me.griSueldoTrabajador.Name = "griSueldoTrabajador"
        Me.griSueldoTrabajador.Size = New System.Drawing.Size(729, 294)
        Me.griSueldoTrabajador.TabIndex = 1
        Me.griSueldoTrabajador.Text = "Relacion de Trabajadores con sus Sueldos"
        '
        'mnuSueTra
        '
        Me.mnuSueTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSueTra.ForeColor = System.Drawing.Color.Black
        Me.mnuSueTra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.tsmiImportar, Me.tsmiOtros})
        Me.mnuSueTra.Name = "mnuSueTra"
        Me.mnuSueTra.Size = New System.Drawing.Size(113, 114)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(112, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(112, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(112, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'tsmiImportar
        '
        Me.tsmiImportar.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.tsmiImportar.Name = "tsmiImportar"
        Me.tsmiImportar.Size = New System.Drawing.Size(112, 22)
        Me.tsmiImportar.Text = "Importar"
        '
        'tsmiOtros
        '
        Me.tsmiOtros.Name = "tsmiOtros"
        Me.tsmiOtros.Size = New System.Drawing.Size(112, 22)
        Me.tsmiOtros.Text = "Otros"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(729, 45)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos de Busqueda"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'utpMantSueTra
        '
        Me.utpMantSueTra.Controls.Add(Me.griHistorial)
        Me.utpMantSueTra.Controls.Add(Me.Agrupacion2)
        Me.utpMantSueTra.Controls.Add(Me._utpMantSueTra_Toolbars_Dock_Area_Left)
        Me.utpMantSueTra.Controls.Add(Me._utpMantSueTra_Toolbars_Dock_Area_Right)
        Me.utpMantSueTra.Controls.Add(Me._utpMantSueTra_Toolbars_Dock_Area_Bottom)
        Me.utpMantSueTra.Controls.Add(Me._utpMantSueTra_Toolbars_Dock_Area_Top)
        Me.utpMantSueTra.Location = New System.Drawing.Point(1, 22)
        Me.utpMantSueTra.Name = "utpMantSueTra"
        Me.utpMantSueTra.Size = New System.Drawing.Size(729, 339)
        '
        'griHistorial
        '
        Me.griHistorial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorial.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griHistorial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griHistorial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griHistorial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griHistorial.DisplayLayout.Override.CellPadding = 0
        Me.griHistorial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHistorial.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griHistorial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHistorial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griHistorial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorial.Location = New System.Drawing.Point(0, 147)
        Me.griHistorial.Name = "griHistorial"
        Me.griHistorial.Size = New System.Drawing.Size(729, 192)
        Me.griHistorial.TabIndex = 1
        Me.griHistorial.Text = "Historial Sueldo"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.chkVigente)
        Me.Agrupacion2.Controls.Add(Me.cboPeriocidad)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion2.Controls.Add(Me.cboTipoPago)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion2.Controls.Add(Me.fecActividad)
        Me.Agrupacion2.Controls.Add(Me.ndSueldo)
        Me.Agrupacion2.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 28)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(729, 119)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos Generales:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboPeriocidad
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboPeriocidad.Appearance = Appearance1
        Me.cboPeriocidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPeriocidad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPeriocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriocidad.ForeColor = System.Drawing.Color.Black
        Me.cboPeriocidad.Location = New System.Drawing.Point(123, 84)
        Me.cboPeriocidad.Name = "cboPeriocidad"
        Me.cboPeriocidad.Size = New System.Drawing.Size(101, 21)
        Me.cboPeriocidad.TabIndex = 9
        Me.cboPeriocidad.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(53, 87)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Periocidad:"
        '
        'cboTipoPago
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance2
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(354, 57)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(172, 21)
        Me.cboTipoPago.TabIndex = 7
        Me.cboTipoPago.ValueMember = "Id"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(291, 61)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta6.TabIndex = 6
        Me.Etiqueta6.Text = "Tipo Pago:"
        '
        'fecActividad
        '
        Me.fecActividad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecActividad.Location = New System.Drawing.Point(354, 84)
        Me.fecActividad.Name = "fecActividad"
        Me.fecActividad.Size = New System.Drawing.Size(82, 20)
        Me.fecActividad.TabIndex = 5
        '
        'ndSueldo
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.ndSueldo.Appearance = Appearance3
        Me.ndSueldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndSueldo.ForeColor = System.Drawing.Color.Black
        Me.ndSueldo.Location = New System.Drawing.Point(123, 57)
        Me.ndSueldo.Name = "ndSueldo"
        Me.ndSueldo.NullText = "0.00"
        Me.ndSueldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndSueldo.Size = New System.Drawing.Size(101, 21)
        Me.ndSueldo.TabIndex = 4
        '
        'cboTrabajador
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance4
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(123, 30)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(403, 21)
        Me.cboTrabajador.TabIndex = 3
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(263, 87)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Fecha Actividad:"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(71, 61)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Sueldo:"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(52, 34)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Trabajador:"
        '
        '_utpMantSueTra_Toolbars_Dock_Area_Left
        '
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.Black
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 28)
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.Name = "_utpMantSueTra_Toolbars_Dock_Area_Left"
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 311)
        Me._utpMantSueTra_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnuMantSueTra
        '
        'mnuMantSueTra
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.mnuMantSueTra.Appearance = Appearance5
        Me.mnuMantSueTra.DesignerFlags = 1
        Me.mnuMantSueTra.DockWithinContainer = Me.utpMantSueTra
        Me.mnuMantSueTra.ShowQuickCustomizeButton = False
        Me.mnuMantSueTra.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        UltraToolbar1.Text = "utMantSueTra"
        Me.mnuMantSueTra.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance6.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        ButtonTool3.SharedPropsInternal.AppearancesSmall.Appearance = Appearance6
        ButtonTool3.SharedPropsInternal.Caption = "Grabrar"
        ButtonTool3.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance7
        ButtonTool4.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuMantSueTra.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        '
        '_utpMantSueTra_Toolbars_Dock_Area_Right
        '
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.Black
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(729, 28)
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.Name = "_utpMantSueTra_Toolbars_Dock_Area_Right"
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 311)
        Me._utpMantSueTra_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnuMantSueTra
        '
        '_utpMantSueTra_Toolbars_Dock_Area_Bottom
        '
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.Black
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 339)
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.Name = "_utpMantSueTra_Toolbars_Dock_Area_Bottom"
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(729, 0)
        Me._utpMantSueTra_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnuMantSueTra
        '
        '_utpMantSueTra_Toolbars_Dock_Area_Top
        '
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.Black
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.Name = "_utpMantSueTra_Toolbars_Dock_Area_Top"
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(729, 28)
        Me._utpMantSueTra_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnuMantSueTra
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl3.Controls.Add(Me.griImporta)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(729, 339)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(354, 260)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 6
        Me.ugb_Espera.Visible = False
        '
        'griImporta
        '
        Me.griImporta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImporta.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImporta.DisplayLayout.MaxColScrollRegions = 1
        Me.griImporta.DisplayLayout.MaxRowScrollRegions = 1
        Me.griImporta.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImporta.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImporta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griImporta.DisplayLayout.Override.CellPadding = 0
        Me.griImporta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griImporta.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griImporta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griImporta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griImporta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griImporta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griImporta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griImporta.Location = New System.Drawing.Point(0, 87)
        Me.griImporta.Name = "griImporta"
        Me.griImporta.Size = New System.Drawing.Size(729, 252)
        Me.griImporta.TabIndex = 1
        Me.griImporta.Text = "Datos Importados"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Agrupacion6)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(729, 87)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Acciones:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.btnBuscar)
        Me.Agrupacion6.Controls.Add(Me.btnValidar)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(5, 20)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(133, 61)
        Me.Agrupacion6.TabIndex = 4
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(4, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(124, 25)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "= Buscar Archivo ="
        '
        'btnValidar
        '
        Me.btnValidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.Black
        Me.btnValidar.Location = New System.Drawing.Point(4, 32)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(124, 25)
        Me.btnValidar.TabIndex = 1
        Me.btnValidar.Text = "= Validar Datos ="
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.verTrabajador)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(142, 54)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(412, 28)
        Me.Agrupacion5.TabIndex = 3
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verTrabajador
        '
        Me.verTrabajador.AutoSize = True
        Me.verTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verTrabajador.ForeColor = System.Drawing.Color.Black
        Me.verTrabajador.Location = New System.Drawing.Point(6, 6)
        Me.verTrabajador.Name = "verTrabajador"
        Me.verTrabajador.Size = New System.Drawing.Size(201, 17)
        Me.verTrabajador.TabIndex = 0
        Me.verTrabajador.Text = "Trabajadores No Registrados en SGI"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.colorNoRegistrados)
        Me.Agrupacion4.Controls.Add(Me.colorRegistrados)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(142, 21)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(412, 31)
        Me.Agrupacion4.TabIndex = 2
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorNoRegistrados
        '
        Me.colorNoRegistrados.Location = New System.Drawing.Point(347, 5)
        Me.colorNoRegistrados.Name = "colorNoRegistrados"
        Me.colorNoRegistrados.Size = New System.Drawing.Size(44, 21)
        Me.colorNoRegistrados.TabIndex = 3
        Me.colorNoRegistrados.Text = "Control"
        '
        'colorRegistrados
        '
        Me.colorRegistrados.Location = New System.Drawing.Point(143, 5)
        Me.colorRegistrados.Name = "colorRegistrados"
        Me.colorRegistrados.Size = New System.Drawing.Size(44, 21)
        Me.colorRegistrados.TabIndex = 2
        Me.colorRegistrados.Text = "Control"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(193, 9)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(148, 14)
        Me.Etiqueta5.TabIndex = 1
        Me.Etiqueta5.Text = "Datos No Registrados en SGI"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(6, 9)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(131, 14)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Datos Registrados en SGI"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griOtros)
        Me.UltraTabPageControl2.Controls.Add(Me.agrOperacion)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(729, 339)
        '
        'griOtros
        '
        Me.griOtros.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOtros.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOtros.DisplayLayout.MaxColScrollRegions = 1
        Me.griOtros.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOtros.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOtros.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOtros.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griOtros.DisplayLayout.Override.CellPadding = 0
        Me.griOtros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOtros.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griOtros.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOtros.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOtros.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOtros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOtros.Location = New System.Drawing.Point(0, 67)
        Me.griOtros.Name = "griOtros"
        Me.griOtros.Size = New System.Drawing.Size(729, 272)
        Me.griOtros.TabIndex = 1
        Me.griOtros.Text = "Grilla1"
        '
        'agrOperacion
        '
        Me.agrOperacion.Controls.Add(Me.btnVerificarMas)
        Me.agrOperacion.Controls.Add(Me.btnBuscarMas)
        Me.agrOperacion.Controls.Add(Me.Etiqueta8)
        Me.agrOperacion.Controls.Add(Me.cboTipoMas)
        Me.agrOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperacion.ForeColor = System.Drawing.Color.Black
        Me.agrOperacion.Location = New System.Drawing.Point(0, 0)
        Me.agrOperacion.Name = "agrOperacion"
        Me.agrOperacion.Size = New System.Drawing.Size(729, 67)
        Me.agrOperacion.TabIndex = 0
        Me.agrOperacion.Text = "Datos a Operar"
        Me.agrOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnVerificarMas
        '
        Me.btnVerificarMas.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnVerificarMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerificarMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarMas.ForeColor = System.Drawing.Color.Black
        Me.btnVerificarMas.Location = New System.Drawing.Point(330, 26)
        Me.btnVerificarMas.Name = "btnVerificarMas"
        Me.btnVerificarMas.Size = New System.Drawing.Size(90, 25)
        Me.btnVerificarMas.TabIndex = 3
        Me.btnVerificarMas.Text = "= Verifica ="
        '
        'btnBuscarMas
        '
        Me.btnBuscarMas.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarMas.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarMas.Location = New System.Drawing.Point(234, 26)
        Me.btnBuscarMas.Name = "btnBuscarMas"
        Me.btnBuscarMas.Size = New System.Drawing.Size(90, 25)
        Me.btnBuscarMas.TabIndex = 2
        Me.btnBuscarMas.Text = "= Buscar ="
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(11, 31)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(25, 14)
        Me.Etiqueta8.TabIndex = 1
        Me.Etiqueta8.Text = "Tipo"
        '
        'cboTipoMas
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.cboTipoMas.Appearance = Appearance8
        Me.cboTipoMas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMas.ForeColor = System.Drawing.Color.Black
        Me.cboTipoMas.Location = New System.Drawing.Point(42, 27)
        Me.cboTipoMas.Name = "cboTipoMas"
        Me.cboTipoMas.Size = New System.Drawing.Size(186, 21)
        Me.cboTipoMas.TabIndex = 0
        Me.cboTipoMas.ValueMember = "Id"
        '
        'ficSueldoTrabajador
        '
        Me.ficSueldoTrabajador.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficSueldoTrabajador.Controls.Add(Me.UltraTabPageControl1)
        Me.ficSueldoTrabajador.Controls.Add(Me.utpMantSueTra)
        Me.ficSueldoTrabajador.Controls.Add(Me.UltraTabPageControl3)
        Me.ficSueldoTrabajador.Controls.Add(Me.UltraTabPageControl2)
        Me.ficSueldoTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficSueldoTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficSueldoTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.ficSueldoTrabajador.Name = "ficSueldoTrabajador"
        Me.ficSueldoTrabajador.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficSueldoTrabajador.Size = New System.Drawing.Size(731, 362)
        Me.ficSueldoTrabajador.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.utpMantSueTra
        UltraTab2.Text = "Mantenimiento"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Importar"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mas"
        Me.ficSueldoTrabajador.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        Me.ficSueldoTrabajador.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(729, 339)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVigente.ForeColor = System.Drawing.Color.Black
        Me.chkVigente.Location = New System.Drawing.Point(468, 84)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(58, 17)
        Me.chkVigente.TabIndex = 11
        Me.chkVigente.Text = "Vigente"
        '
        'frm_SueldoTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 362)
        Me.Controls.Add(Me.ficSueldoTrabajador)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SueldoTrabajador"
        Me.Text = "Sueldo de Trabajador"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griSueldoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuSueTra.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpMantSueTra.ResumeLayout(False)
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cboPeriocidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndSueldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMantSueTra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griImporta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.verTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.colorNoRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperacion.ResumeLayout(False)
        Me.agrOperacion.PerformLayout()
        CType(Me.cboTipoMas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficSueldoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficSueldoTrabajador.ResumeLayout(False)
        CType(Me.chkVigente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficSueldoTrabajador As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griSueldoTrabajador As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents utpMantSueTra As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griHistorial As ISL.Controles.Grilla
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griImporta As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecActividad As System.Windows.Forms.DateTimePicker
    Friend WithEvents ndSueldo As ISL.Controles.NumeroDecimal
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuSueTra As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiImportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents btnValidar As ISL.Controles.Boton
    Friend WithEvents btnBuscar As ISL.Controles.Boton
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents verTrabajador As ISL.Controles.Chequear
    Friend WithEvents colorNoRegistrados As ISL.Controles.Colores
    Friend WithEvents colorRegistrados As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents _utpMantSueTra_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuMantSueTra As ISL.Controles.Menu
    Friend WithEvents _utpMantSueTra_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantSueTra_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantSueTra_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents cboPeriocidad As ISL.Controles.Combo
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoPago As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griOtros As ISL.Controles.Grilla
    Friend WithEvents agrOperacion As ISL.Controles.Agrupacion
    Friend WithEvents btnVerificarMas As ISL.Controles.Boton
    Friend WithEvents btnBuscarMas As ISL.Controles.Boton
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoMas As ISL.Controles.Combo
    Friend WithEvents tsmiOtros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkVigente As ISL.Controles.Chequear
End Class
