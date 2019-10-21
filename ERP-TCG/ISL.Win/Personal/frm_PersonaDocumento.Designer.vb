<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PersonaDocumento
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
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMantDocPer")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GrabarDoc")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CancelarDoc")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GrabarDoc")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CancelarDoc")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griPersonaDocumento = New ISL.Controles.Grilla(Me.components)
        Me.mnuPerDoc = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.ckDiasVencimiento = New ISL.Controles.Chequear(Me.components)
        Me.ndDiasVencimiento = New ISL.Controles.NumeroEntero(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorPorVencer2 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorVencido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorPorVencer = New ISL.Controles.Colores(Me.components)
        Me.etiPorVencer = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadorBus = New ISL.Controles.Combo(Me.components)
        Me.cboTipoDocBus = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.utpMantenimiento = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHistorial = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griImagenes = New ISL.Controles.Grilla(Me.components)
        Me.btnExaminar = New ISL.Controles.Boton(Me.components)
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.FecActividad = New System.Windows.Forms.DateTimePicker()
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me._utpMantenimiento_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuManDocPer = New ISL.Controles.Menu(Me.components)
        Me._utpMantenimiento_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantenimiento_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griImporta = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtMensaje = New ISL.Controles.Texto(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.verTrabajador = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorNoRegistrados = New ISL.Controles.Colores(Me.components)
        Me.colorRegistrados = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnValidar = New ISL.Controles.Boton(Me.components)
        Me.btnBuscar = New ISL.Controles.Boton(Me.components)
        Me.ficPersonaDocumento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griPersonaDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPerDoc.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ckDiasVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndDiasVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.colorPorVencer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorVencido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorPorVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocBus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpMantenimiento.SuspendLayout()
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuManDocPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griImporta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.txtMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.verTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.colorNoRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.ficPersonaDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPersonaDocumento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griPersonaDocumento)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1026, 425)
        '
        'griPersonaDocumento
        '
        Me.griPersonaDocumento.ContextMenuStrip = Me.mnuPerDoc
        Me.griPersonaDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPersonaDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPersonaDocumento.DisplayLayout.MaxColScrollRegions = 1
        Me.griPersonaDocumento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPersonaDocumento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPersonaDocumento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPersonaDocumento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griPersonaDocumento.DisplayLayout.Override.CellPadding = 0
        Me.griPersonaDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPersonaDocumento.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griPersonaDocumento.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPersonaDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPersonaDocumento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPersonaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPersonaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPersonaDocumento.Location = New System.Drawing.Point(0, 82)
        Me.griPersonaDocumento.Name = "griPersonaDocumento"
        Me.griPersonaDocumento.Size = New System.Drawing.Size(1026, 343)
        Me.griPersonaDocumento.TabIndex = 1
        Me.griPersonaDocumento.Text = "Documentos de Personal"
        '
        'mnuPerDoc
        '
        Me.mnuPerDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPerDoc.ForeColor = System.Drawing.Color.Black
        Me.mnuPerDoc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.ToolStripSeparator1, Me.tsmiExportar, Me.tsmiImportar})
        Me.mnuPerDoc.Name = "mnuPerDoc"
        Me.mnuPerDoc.Size = New System.Drawing.Size(114, 120)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(113, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'tsmiExportar
        '
        Me.tsmiExportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.tsmiExportar.Name = "tsmiExportar"
        Me.tsmiExportar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiExportar.Text = "Exportar"
        '
        'tsmiImportar
        '
        Me.tsmiImportar.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.tsmiImportar.Name = "tsmiImportar"
        Me.tsmiImportar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiImportar.Text = "Importar"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.ckDiasVencimiento)
        Me.Agrupacion1.Controls.Add(Me.ndDiasVencimiento)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion8)
        Me.Agrupacion1.Controls.Add(Me.cboTrabajadorBus)
        Me.Agrupacion1.Controls.Add(Me.cboTipoDocBus)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1026, 82)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ckDiasVencimiento
        '
        Me.ckDiasVencimiento.AutoSize = True
        Me.ckDiasVencimiento.BackColor = System.Drawing.Color.Transparent
        Me.ckDiasVencimiento.BackColorInternal = System.Drawing.Color.Transparent
        Me.ckDiasVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDiasVencimiento.ForeColor = System.Drawing.Color.Black
        Me.ckDiasVencimiento.Location = New System.Drawing.Point(11, 54)
        Me.ckDiasVencimiento.Name = "ckDiasVencimiento"
        Me.ckDiasVencimiento.Size = New System.Drawing.Size(195, 17)
        Me.ckDiasVencimiento.TabIndex = 8
        Me.ckDiasVencimiento.Text = "Nro Dias para Evaluar Vencimiento:"
        '
        'ndDiasVencimiento
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.ndDiasVencimiento.Appearance = Appearance1
        Me.ndDiasVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndDiasVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndDiasVencimiento.ForeColor = System.Drawing.Color.Black
        Me.ndDiasVencimiento.Location = New System.Drawing.Point(213, 53)
        Me.ndDiasVencimiento.MaskInput = "nn"
        Me.ndDiasVencimiento.MaxValue = 99
        Me.ndDiasVencimiento.MinValue = 0
        Me.ndDiasVencimiento.Name = "ndDiasVencimiento"
        Me.ndDiasVencimiento.NullText = "0"
        Me.ndDiasVencimiento.Size = New System.Drawing.Size(44, 21)
        Me.ndDiasVencimiento.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndDiasVencimiento.TabIndex = 5
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.colorPorVencer2)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion8.Controls.Add(Me.colorVencido)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion8.Controls.Add(Me.colorPorVencer)
        Me.Agrupacion8.Controls.Add(Me.etiPorVencer)
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(263, 48)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(412, 28)
        Me.Agrupacion8.TabIndex = 4
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorPorVencer2
        '
        Me.colorPorVencer2.Location = New System.Drawing.Point(250, 3)
        Me.colorPorVencer2.Name = "colorPorVencer2"
        Me.colorPorVencer2.Size = New System.Drawing.Size(44, 21)
        Me.colorPorVencer2.TabIndex = 8
        Me.colorPorVencer2.Text = "Control"
        '
        'Etiqueta15
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance2
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(182, 6)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta15.TabIndex = 6
        Me.Etiqueta15.Text = "Por Vencer:"
        '
        'colorVencido
        '
        Me.colorVencido.Location = New System.Drawing.Point(358, 3)
        Me.colorVencido.Name = "colorVencido"
        Me.colorVencido.Size = New System.Drawing.Size(44, 21)
        Me.colorVencido.TabIndex = 5
        Me.colorVencido.Text = "Control"
        '
        'Etiqueta12
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance3
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(300, 6)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta12.TabIndex = 4
        Me.Etiqueta12.Text = "Vencidos:"
        '
        'colorPorVencer
        '
        Me.colorPorVencer.Location = New System.Drawing.Point(132, 3)
        Me.colorPorVencer.Name = "colorPorVencer"
        Me.colorPorVencer.Size = New System.Drawing.Size(44, 21)
        Me.colorPorVencer.TabIndex = 3
        Me.colorPorVencer.Text = "Control"
        '
        'etiPorVencer
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.etiPorVencer.Appearance = Appearance4
        Me.etiPorVencer.AutoSize = True
        Me.etiPorVencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPorVencer.ForeColor = System.Drawing.Color.Black
        Me.etiPorVencer.Location = New System.Drawing.Point(12, 7)
        Me.etiPorVencer.Name = "etiPorVencer"
        Me.etiPorVencer.Size = New System.Drawing.Size(71, 14)
        Me.etiPorVencer.TabIndex = 2
        Me.etiPorVencer.Text = "Por Vencer a:"
        '
        'cboTrabajadorBus
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorBus.Appearance = Appearance5
        Me.cboTrabajadorBus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadorBus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorBus.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajadorBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorBus.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorBus.Location = New System.Drawing.Point(413, 25)
        Me.cboTrabajadorBus.Name = "cboTrabajadorBus"
        Me.cboTrabajadorBus.Size = New System.Drawing.Size(307, 21)
        Me.cboTrabajadorBus.TabIndex = 3
        Me.cboTrabajadorBus.ValueMember = "Id"
        '
        'cboTipoDocBus
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocBus.Appearance = Appearance6
        Me.cboTipoDocBus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocBus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocBus.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocBus.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocBus.Location = New System.Drawing.Point(68, 25)
        Me.cboTipoDocBus.Name = "cboTipoDocBus"
        Me.cboTipoDocBus.Size = New System.Drawing.Size(273, 21)
        Me.cboTipoDocBus.TabIndex = 2
        Me.cboTipoDocBus.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance7
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(347, 29)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Trabajador:"
        '
        'Etiqueta1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance8
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(51, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Tipo Doc:"
        '
        'utpMantenimiento
        '
        Me.utpMantenimiento.Controls.Add(Me.griHistorial)
        Me.utpMantenimiento.Controls.Add(Me.Agrupacion2)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Left)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Right)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Bottom)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Top)
        Me.utpMantenimiento.Location = New System.Drawing.Point(1, 22)
        Me.utpMantenimiento.Name = "utpMantenimiento"
        Me.utpMantenimiento.Size = New System.Drawing.Size(1026, 425)
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
        Me.griHistorial.Location = New System.Drawing.Point(0, 246)
        Me.griHistorial.Name = "griHistorial"
        Me.griHistorial.Size = New System.Drawing.Size(1026, 179)
        Me.griHistorial.TabIndex = 1
        Me.griHistorial.Text = "Historial"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griImagenes)
        Me.Agrupacion2.Controls.Add(Me.btnExaminar)
        Me.Agrupacion2.Controls.Add(Me.txtDescripcion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion2.Controls.Add(Me.fecVencimiento)
        Me.Agrupacion2.Controls.Add(Me.FecActividad)
        Me.Agrupacion2.Controls.Add(Me.txtNumero)
        Me.Agrupacion2.Controls.Add(Me.cboTipoDocumento)
        Me.Agrupacion2.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 28)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1026, 218)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griImagenes
        '
        Me.griImagenes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImagenes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImagenes.DisplayLayout.MaxColScrollRegions = 1
        Me.griImagenes.DisplayLayout.MaxRowScrollRegions = 1
        Me.griImagenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImagenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImagenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griImagenes.DisplayLayout.Override.CellPadding = 0
        Me.griImagenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griImagenes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griImagenes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griImagenes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griImagenes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griImagenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griImagenes.Location = New System.Drawing.Point(396, 54)
        Me.griImagenes.Name = "griImagenes"
        Me.griImagenes.Size = New System.Drawing.Size(270, 151)
        Me.griImagenes.TabIndex = 385
        '
        'btnExaminar
        '
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.btnExaminar.Appearance = Appearance9
        Me.btnExaminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.Black
        Me.btnExaminar.Location = New System.Drawing.Point(396, 27)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(81, 22)
        Me.btnExaminar.TabIndex = 384
        Me.btnExaminar.Text = "Examinar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(126, 108)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(266, 49)
        Me.txtDescripcion.TabIndex = 11
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(55, 112)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta10.TabIndex = 10
        Me.Etiqueta10.Text = "Descripcion:"
        '
        'fecVencimiento
        '
        Me.fecVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecVencimiento.Location = New System.Drawing.Point(126, 189)
        Me.fecVencimiento.Name = "fecVencimiento"
        Me.fecVencimiento.Size = New System.Drawing.Size(89, 20)
        Me.fecVencimiento.TabIndex = 9
        '
        'FecActividad
        '
        Me.FecActividad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecActividad.Location = New System.Drawing.Point(126, 163)
        Me.FecActividad.Name = "FecActividad"
        Me.FecActividad.Size = New System.Drawing.Size(89, 20)
        Me.FecActividad.TabIndex = 8
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(126, 81)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(266, 21)
        Me.txtNumero.TabIndex = 7
        '
        'cboTipoDocumento
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance10
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(126, 54)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(266, 21)
        Me.cboTipoDocumento.TabIndex = 6
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'cboTrabajador
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance11
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(126, 27)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(266, 21)
        Me.cboTrabajador.TabIndex = 5
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(19, 191)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(101, 14)
        Me.Etiqueta9.TabIndex = 4
        Me.Etiqueta9.Text = "Fecha Vencimiento:"
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(35, 165)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta8.TabIndex = 3
        Me.Etiqueta8.Text = "Fecha Actividad:"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(74, 85)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Numero:"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(32, 58)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(88, 14)
        Me.Etiqueta6.TabIndex = 1
        Me.Etiqueta6.Text = "Tipo Documento:"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(60, 31)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Trabajador:"
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Left
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 28)
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.Name = "_utpMantenimiento_Toolbars_Dock_Area_Left"
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 397)
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnuManDocPer
        '
        'mnuManDocPer
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.mnuManDocPer.Appearance = Appearance12
        Me.mnuManDocPer.DesignerFlags = 1
        Me.mnuManDocPer.DockWithinContainer = Me.utpMantenimiento
        Me.mnuManDocPer.ShowQuickCustomizeButton = False
        Me.mnuManDocPer.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        UltraToolbar1.Text = "utMantDocPer"
        Me.mnuManDocPer.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        ButtonTool3.SharedPropsInternal.AppearancesSmall.Appearance = Appearance13
        ButtonTool3.SharedPropsInternal.Caption = "Grabar"
        ButtonTool3.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance14
        ButtonTool4.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuManDocPer.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Right
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1026, 28)
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.Name = "_utpMantenimiento_Toolbars_Dock_Area_Right"
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 397)
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnuManDocPer
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Bottom
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 425)
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.Name = "_utpMantenimiento_Toolbars_Dock_Area_Bottom"
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1026, 0)
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnuManDocPer
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Top
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.Name = "_utpMantenimiento_Toolbars_Dock_Area_Top"
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1026, 28)
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnuManDocPer
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl3.Controls.Add(Me.griImporta)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1026, 425)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(372, 237)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 7
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
        Me.griImporta.Location = New System.Drawing.Point(0, 89)
        Me.griImporta.Name = "griImporta"
        Me.griImporta.Size = New System.Drawing.Size(1026, 336)
        Me.griImporta.TabIndex = 1
        Me.griImporta.Text = "Datos Importados"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion6)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1026, 89)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Acciones:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.txtMensaje)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(595, 21)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(268, 60)
        Me.Agrupacion7.TabIndex = 3
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtMensaje
        '
        Me.txtMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(6, 6)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.Size = New System.Drawing.Size(256, 48)
        Me.txtMensaje.TabIndex = 0
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.verTrabajador)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(155, 52)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(434, 30)
        Me.Agrupacion6.TabIndex = 2
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verTrabajador
        '
        Me.verTrabajador.AutoSize = True
        Me.verTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verTrabajador.ForeColor = System.Drawing.Color.Black
        Me.verTrabajador.Location = New System.Drawing.Point(6, 7)
        Me.verTrabajador.Name = "verTrabajador"
        Me.verTrabajador.Size = New System.Drawing.Size(213, 17)
        Me.verTrabajador.TabIndex = 0
        Me.verTrabajador.Text = "Trabajadores No Registrados en el SGI"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.colorNoRegistrados)
        Me.Agrupacion5.Controls.Add(Me.colorRegistrados)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(155, 21)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(434, 30)
        Me.Agrupacion5.TabIndex = 1
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorNoRegistrados
        '
        Me.colorNoRegistrados.Location = New System.Drawing.Point(353, 5)
        Me.colorNoRegistrados.Name = "colorNoRegistrados"
        Me.colorNoRegistrados.Size = New System.Drawing.Size(44, 21)
        Me.colorNoRegistrados.TabIndex = 3
        Me.colorNoRegistrados.Text = "Control"
        '
        'colorRegistrados
        '
        Me.colorRegistrados.Location = New System.Drawing.Point(146, 5)
        Me.colorRegistrados.Name = "colorRegistrados"
        Me.colorRegistrados.Size = New System.Drawing.Size(44, 21)
        Me.colorRegistrados.TabIndex = 2
        Me.colorRegistrados.Text = "Control"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(196, 9)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(151, 14)
        Me.Etiqueta4.TabIndex = 1
        Me.Etiqueta4.Text = "Datos No Registrados en SGI:"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(7, 8)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(134, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Datos Registrados en SGI:"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.btnValidar)
        Me.Agrupacion4.Controls.Add(Me.btnBuscar)
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(7, 21)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(142, 60)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnValidar
        '
        Me.btnValidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.Black
        Me.btnValidar.Location = New System.Drawing.Point(6, 31)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(130, 25)
        Me.btnValidar.TabIndex = 2
        Me.btnValidar.Text = "= Validar Datos ="
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(6, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(130, 25)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "= Buscar Archivo ="
        '
        'ficPersonaDocumento
        '
        Me.ficPersonaDocumento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficPersonaDocumento.Controls.Add(Me.UltraTabPageControl1)
        Me.ficPersonaDocumento.Controls.Add(Me.utpMantenimiento)
        Me.ficPersonaDocumento.Controls.Add(Me.UltraTabPageControl3)
        Me.ficPersonaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPersonaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPersonaDocumento.Location = New System.Drawing.Point(0, 0)
        Me.ficPersonaDocumento.Name = "ficPersonaDocumento"
        Me.ficPersonaDocumento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficPersonaDocumento.Size = New System.Drawing.Size(1028, 448)
        Me.ficPersonaDocumento.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.utpMantenimiento
        UltraTab2.Text = "Mantenimiento"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Importar"
        Me.ficPersonaDocumento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficPersonaDocumento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1026, 425)
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
        'frm_PersonaDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 448)
        Me.Controls.Add(Me.ficPersonaDocumento)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PersonaDocumento"
        Me.Text = "Documentos Personales"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griPersonaDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPerDoc.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.ckDiasVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndDiasVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.colorPorVencer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorVencido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorPorVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocBus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpMantenimiento.ResumeLayout(False)
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.griImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuManDocPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griImporta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.txtMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.verTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.colorNoRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.ficPersonaDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPersonaDocumento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficPersonaDocumento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpMantenimiento As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griPersonaDocumento As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents cboTrabajadorBus As ISL.Controles.Combo
    Friend WithEvents cboTipoDocBus As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents griHistorial As ISL.Controles.Grilla
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griImporta As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents btnValidar As ISL.Controles.Boton
    Friend WithEvents btnBuscar As ISL.Controles.Boton
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents verTrabajador As ISL.Controles.Chequear
    Friend WithEvents colorNoRegistrados As ISL.Controles.Colores
    Friend WithEvents colorRegistrados As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents fecVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents FecActividad As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents mnuPerDoc As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiImportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents txtMensaje As ISL.Controles.Texto
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuManDocPer As ISL.Controles.Menu
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents colorVencido As ISL.Controles.Colores
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents colorPorVencer As ISL.Controles.Colores
    Friend WithEvents etiPorVencer As ISL.Controles.Etiqueta
    Friend WithEvents ndDiasVencimiento As ISL.Controles.NumeroEntero
    Friend WithEvents colorPorVencer2 As ISL.Controles.Colores
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ckDiasVencimiento As ISL.Controles.Chequear
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExaminar As ISL.Controles.Boton
    Friend WithEvents griImagenes As ISL.Controles.Grilla
End Class
