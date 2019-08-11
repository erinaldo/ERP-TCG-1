<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FondoPensionTrabajador
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMantFonPen")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GrabarFon")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CancelarFon")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GrabarFon")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CancelarFon")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griFondoPensionTrabajador = New ISL.Controles.Grilla(Me.components)
        Me.mnuFonPenTra = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImportar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.utpMantFonPen = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHistorial = New ISL.Controles.Grilla(Me.components)
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.chkVidente = New ISL.Controles.Chequear(Me.components)
        Me.verMixta = New ISL.Controles.Chequear(Me.components)
        Me.fecActividad = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCussp = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.agrFlujo = New ISL.Controles.Agrupacion(Me.components)
        Me.ndComision = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.agrSaldo = New ISL.Controles.Agrupacion(Me.components)
        Me.ndSaldoMixta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndComisionMixta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndSeguros = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndObligatorio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboRegimenPensionario = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me._utpMantFonPen_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuMantFonPen = New ISL.Controles.Menu(Me.components)
        Me._utpMantFonPen_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantFonPen_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griImportaDato = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.verEmpresa = New ISL.Controles.Chequear(Me.components)
        Me.verTrabajador = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorNoRegistrado = New ISL.Controles.Colores(Me.components)
        Me.colorRegistrados = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnValidar = New ISL.Controles.Boton(Me.components)
        Me.btnBuscar = New ISL.Controles.Boton(Me.components)
        Me.ficFondoPensionTrabajador = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griFondoPensionTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuFonPenTra.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpMantFonPen.SuspendLayout()
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.chkVidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verMixta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCussp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.agrFlujo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFlujo.SuspendLayout()
        CType(Me.ndComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrSaldo.SuspendLayout()
        CType(Me.ndSaldoMixta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndComisionMixta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndObligatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRegimenPensionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuMantFonPen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griImportaDato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.verEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.colorNoRegistrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficFondoPensionTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFondoPensionTrabajador.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griFondoPensionTrabajador)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(863, 396)
        '
        'griFondoPensionTrabajador
        '
        Me.griFondoPensionTrabajador.ContextMenuStrip = Me.mnuFonPenTra
        Me.griFondoPensionTrabajador.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFondoPensionTrabajador.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFondoPensionTrabajador.DisplayLayout.MaxColScrollRegions = 1
        Me.griFondoPensionTrabajador.DisplayLayout.MaxRowScrollRegions = 1
        Me.griFondoPensionTrabajador.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griFondoPensionTrabajador.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griFondoPensionTrabajador.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griFondoPensionTrabajador.DisplayLayout.Override.CellPadding = 0
        Me.griFondoPensionTrabajador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFondoPensionTrabajador.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griFondoPensionTrabajador.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griFondoPensionTrabajador.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griFondoPensionTrabajador.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griFondoPensionTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFondoPensionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFondoPensionTrabajador.Location = New System.Drawing.Point(0, 58)
        Me.griFondoPensionTrabajador.Name = "griFondoPensionTrabajador"
        Me.griFondoPensionTrabajador.Size = New System.Drawing.Size(863, 338)
        Me.griFondoPensionTrabajador.TabIndex = 1
        Me.griFondoPensionTrabajador.Text = "Asociacion de Trabajadores y Empresas Pensionarias"
        '
        'mnuFonPenTra
        '
        Me.mnuFonPenTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFonPenTra.ForeColor = System.Drawing.Color.Black
        Me.mnuFonPenTra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo2, Me.tsmiEditar2, Me.tsmiEliminar2, Me.tsmiImportar2})
        Me.mnuFonPenTra.Name = "mnuFonPenTra"
        Me.mnuFonPenTra.Size = New System.Drawing.Size(113, 92)
        '
        'tsmiNuevo2
        '
        Me.tsmiNuevo2.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo2.Name = "tsmiNuevo2"
        Me.tsmiNuevo2.Size = New System.Drawing.Size(112, 22)
        Me.tsmiNuevo2.Text = "Nuevo"
        '
        'tsmiEditar2
        '
        Me.tsmiEditar2.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar2.Name = "tsmiEditar2"
        Me.tsmiEditar2.Size = New System.Drawing.Size(112, 22)
        Me.tsmiEditar2.Text = "Editar"
        '
        'tsmiEliminar2
        '
        Me.tsmiEliminar2.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar2.Name = "tsmiEliminar2"
        Me.tsmiEliminar2.Size = New System.Drawing.Size(112, 22)
        Me.tsmiEliminar2.Text = "Eliminar"
        '
        'tsmiImportar2
        '
        Me.tsmiImportar2.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.tsmiImportar2.Name = "tsmiImportar2"
        Me.tsmiImportar2.Size = New System.Drawing.Size(112, 22)
        Me.tsmiImportar2.Text = "Importar"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(863, 58)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos de Busqueda"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'utpMantFonPen
        '
        Me.utpMantFonPen.Controls.Add(Me.griHistorial)
        Me.utpMantFonPen.Controls.Add(Me.agrDatos)
        Me.utpMantFonPen.Controls.Add(Me._utpMantFonPen_Toolbars_Dock_Area_Left)
        Me.utpMantFonPen.Controls.Add(Me._utpMantFonPen_Toolbars_Dock_Area_Right)
        Me.utpMantFonPen.Controls.Add(Me._utpMantFonPen_Toolbars_Dock_Area_Bottom)
        Me.utpMantFonPen.Controls.Add(Me._utpMantFonPen_Toolbars_Dock_Area_Top)
        Me.utpMantFonPen.Location = New System.Drawing.Point(1, 22)
        Me.utpMantFonPen.Name = "utpMantFonPen"
        Me.utpMantFonPen.Size = New System.Drawing.Size(863, 396)
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
        Me.griHistorial.Location = New System.Drawing.Point(0, 211)
        Me.griHistorial.Name = "griHistorial"
        Me.griHistorial.Size = New System.Drawing.Size(863, 185)
        Me.griHistorial.TabIndex = 1
        Me.griHistorial.Text = "Historial de Empresas Pensionarias"
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.chkVidente)
        Me.agrDatos.Controls.Add(Me.verMixta)
        Me.agrDatos.Controls.Add(Me.fecActividad)
        Me.agrDatos.Controls.Add(Me.Etiqueta8)
        Me.agrDatos.Controls.Add(Me.txtCussp)
        Me.agrDatos.Controls.Add(Me.Etiqueta7)
        Me.agrDatos.Controls.Add(Me.txtAbreviatura)
        Me.agrDatos.Controls.Add(Me.Etiqueta6)
        Me.agrDatos.Controls.Add(Me.Agrupacion2)
        Me.agrDatos.Controls.Add(Me.cboRegimenPensionario)
        Me.agrDatos.Controls.Add(Me.Etiqueta2)
        Me.agrDatos.Controls.Add(Me.cboTrabajador)
        Me.agrDatos.Controls.Add(Me.Etiqueta1)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 28)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(863, 183)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = " Datos Generales:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkVidente
        '
        Me.chkVidente.AutoSize = True
        Me.chkVidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVidente.ForeColor = System.Drawing.Color.Black
        Me.chkVidente.Location = New System.Drawing.Point(255, 88)
        Me.chkVidente.Name = "chkVidente"
        Me.chkVidente.Size = New System.Drawing.Size(61, 17)
        Me.chkVidente.TabIndex = 12
        Me.chkVidente.Text = "Vigente:"
        '
        'verMixta
        '
        Me.verMixta.AutoSize = True
        Me.verMixta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verMixta.ForeColor = System.Drawing.Color.Black
        Me.verMixta.Location = New System.Drawing.Point(255, 115)
        Me.verMixta.Name = "verMixta"
        Me.verMixta.Size = New System.Drawing.Size(99, 17)
        Me.verMixta.TabIndex = 11
        Me.verMixta.Text = "Comisión Mixta:"
        '
        'fecActividad
        '
        Me.fecActividad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecActividad.Location = New System.Drawing.Point(128, 139)
        Me.fecActividad.Name = "fecActividad"
        Me.fecActividad.Size = New System.Drawing.Size(83, 20)
        Me.fecActividad.TabIndex = 10
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(37, 141)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta8.TabIndex = 9
        Me.Etiqueta8.Text = "Fecha Actividad:"
        '
        'txtCussp
        '
        Me.txtCussp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCussp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCussp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCussp.Location = New System.Drawing.Point(128, 112)
        Me.txtCussp.Name = "txtCussp"
        Me.txtCussp.Size = New System.Drawing.Size(121, 21)
        Me.txtCussp.TabIndex = 8
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(77, 116)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta7.TabIndex = 7
        Me.Etiqueta7.Text = "CUSPP:"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(128, 85)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(121, 21)
        Me.txtAbreviatura.TabIndex = 6
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(59, 89)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta6.TabIndex = 5
        Me.Etiqueta6.Text = "Abreviatura:"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.agrFlujo)
        Me.Agrupacion2.Controls.Add(Me.ndTotal)
        Me.Agrupacion2.Controls.Add(Me.agrSaldo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion2.Controls.Add(Me.ndSeguros)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion2.Controls.Add(Me.ndObligatorio)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(441, 31)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(280, 140)
        Me.Agrupacion2.TabIndex = 4
        Me.Agrupacion2.Text = "Porcentajes:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrFlujo
        '
        Me.agrFlujo.Controls.Add(Me.ndComision)
        Me.agrFlujo.Controls.Add(Me.Etiqueta4)
        Me.agrFlujo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFlujo.ForeColor = System.Drawing.Color.Black
        Me.agrFlujo.Location = New System.Drawing.Point(6, 43)
        Me.agrFlujo.Name = "agrFlujo"
        Me.agrFlujo.Size = New System.Drawing.Size(137, 64)
        Me.agrFlujo.TabIndex = 11
        Me.agrFlujo.Text = "Comision sobre Flujo"
        Me.agrFlujo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'ndComision
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.ndComision.Appearance = Appearance1
        Me.ndComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndComision.ForeColor = System.Drawing.Color.Black
        Me.ndComision.Location = New System.Drawing.Point(70, 27)
        Me.ndComision.MaskInput = "{double:3.2}"
        Me.ndComision.Name = "ndComision"
        Me.ndComision.NullText = "0.00"
        Me.ndComision.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndComision.ReadOnly = True
        Me.ndComision.Size = New System.Drawing.Size(62, 21)
        Me.ndComision.TabIndex = 3
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(11, 31)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Comision:"
        '
        'ndTotal
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.ndTotal.Appearance = Appearance2
        Me.ndTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndTotal.ForeColor = System.Drawing.Color.Black
        Me.ndTotal.Location = New System.Drawing.Point(188, 113)
        Me.ndTotal.MaskInput = "{double:3.2}"
        Me.ndTotal.Name = "ndTotal"
        Me.ndTotal.NullText = "0.00"
        Me.ndTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndTotal.ReadOnly = True
        Me.ndTotal.Size = New System.Drawing.Size(62, 21)
        Me.ndTotal.TabIndex = 7
        '
        'agrSaldo
        '
        Me.agrSaldo.Controls.Add(Me.ndSaldoMixta)
        Me.agrSaldo.Controls.Add(Me.Etiqueta13)
        Me.agrSaldo.Controls.Add(Me.ndComisionMixta)
        Me.agrSaldo.Controls.Add(Me.Etiqueta12)
        Me.agrSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrSaldo.ForeColor = System.Drawing.Color.Black
        Me.agrSaldo.Location = New System.Drawing.Point(12, 46)
        Me.agrSaldo.Name = "agrSaldo"
        Me.agrSaldo.Size = New System.Drawing.Size(257, 54)
        Me.agrSaldo.TabIndex = 11
        Me.agrSaldo.Text = "Comision Mixta"
        Me.agrSaldo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'ndSaldoMixta
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.ndSaldoMixta.Appearance = Appearance3
        Me.ndSaldoMixta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndSaldoMixta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndSaldoMixta.ForeColor = System.Drawing.Color.Black
        Me.ndSaldoMixta.Location = New System.Drawing.Point(179, 24)
        Me.ndSaldoMixta.MaskInput = "{double:3.2}"
        Me.ndSaldoMixta.Name = "ndSaldoMixta"
        Me.ndSaldoMixta.NullText = "0.00"
        Me.ndSaldoMixta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndSaldoMixta.ReadOnly = True
        Me.ndSaldoMixta.Size = New System.Drawing.Size(62, 21)
        Me.ndSaldoMixta.TabIndex = 6
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(132, 27)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta13.TabIndex = 5
        Me.Etiqueta13.Text = "Sueldo:"
        '
        'ndComisionMixta
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.ndComisionMixta.Appearance = Appearance4
        Me.ndComisionMixta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndComisionMixta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndComisionMixta.ForeColor = System.Drawing.Color.Black
        Me.ndComisionMixta.Location = New System.Drawing.Point(64, 23)
        Me.ndComisionMixta.MaskInput = "{double:3.2}"
        Me.ndComisionMixta.Name = "ndComisionMixta"
        Me.ndComisionMixta.NullText = "0.00"
        Me.ndComisionMixta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndComisionMixta.ReadOnly = True
        Me.ndComisionMixta.Size = New System.Drawing.Size(62, 21)
        Me.ndComisionMixta.TabIndex = 4
        '
        'Etiqueta12
        '
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(5, 27)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta12.TabIndex = 3
        Me.Etiqueta12.Text = "Comision:"
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(150, 116)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta9.TabIndex = 6
        Me.Etiqueta9.Text = "Total:"
        '
        'ndSeguros
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.ndSeguros.Appearance = Appearance5
        Me.ndSeguros.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndSeguros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndSeguros.ForeColor = System.Drawing.Color.Black
        Me.ndSeguros.Location = New System.Drawing.Point(78, 113)
        Me.ndSeguros.MaskInput = "{double:3.2}"
        Me.ndSeguros.Name = "ndSeguros"
        Me.ndSeguros.NullText = "0.00"
        Me.ndSeguros.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndSeguros.ReadOnly = True
        Me.ndSeguros.Size = New System.Drawing.Size(62, 21)
        Me.ndSeguros.TabIndex = 5
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(24, 117)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta5.TabIndex = 4
        Me.Etiqueta5.Text = "Seguros:"
        '
        'ndObligatorio
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.ndObligatorio.Appearance = Appearance6
        Me.ndObligatorio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndObligatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndObligatorio.ForeColor = System.Drawing.Color.Black
        Me.ndObligatorio.Location = New System.Drawing.Point(78, 19)
        Me.ndObligatorio.MaskInput = "{double:3.2}"
        Me.ndObligatorio.Name = "ndObligatorio"
        Me.ndObligatorio.NullText = "0.00"
        Me.ndObligatorio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndObligatorio.ReadOnly = True
        Me.ndObligatorio.Size = New System.Drawing.Size(62, 21)
        Me.ndObligatorio.TabIndex = 1
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(12, 23)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Obligatorio:"
        '
        'cboRegimenPensionario
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.cboRegimenPensionario.Appearance = Appearance7
        Me.cboRegimenPensionario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRegimenPensionario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRegimenPensionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegimenPensionario.ForeColor = System.Drawing.Color.Black
        Me.cboRegimenPensionario.Location = New System.Drawing.Point(128, 58)
        Me.cboRegimenPensionario.Name = "cboRegimenPensionario"
        Me.cboRegimenPensionario.Size = New System.Drawing.Size(307, 21)
        Me.cboRegimenPensionario.TabIndex = 3
        Me.cboRegimenPensionario.ValueMember = "IdEmpresa"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(11, 62)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(111, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Empresa Pensionista:"
        '
        'cboTrabajador
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance8
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(128, 31)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(307, 21)
        Me.cboTrabajador.TabIndex = 1
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(62, 35)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Trabajador:"
        '
        '_utpMantFonPen_Toolbars_Dock_Area_Left
        '
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.Black
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 28)
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.Name = "_utpMantFonPen_Toolbars_Dock_Area_Left"
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 368)
        Me._utpMantFonPen_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnuMantFonPen
        '
        'mnuMantFonPen
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.mnuMantFonPen.Appearance = Appearance9
        Me.mnuMantFonPen.DesignerFlags = 1
        Me.mnuMantFonPen.DockWithinContainer = Me.utpMantFonPen
        Me.mnuMantFonPen.ShowQuickCustomizeButton = False
        Me.mnuMantFonPen.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        UltraToolbar1.Text = "utMantFonPen"
        Me.mnuMantFonPen.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance10.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        ButtonTool3.SharedPropsInternal.AppearancesSmall.Appearance = Appearance10
        ButtonTool3.SharedPropsInternal.Caption = "Grabar"
        ButtonTool3.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance11.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance11
        ButtonTool4.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuMantFonPen.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        '
        '_utpMantFonPen_Toolbars_Dock_Area_Right
        '
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.Black
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(863, 28)
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.Name = "_utpMantFonPen_Toolbars_Dock_Area_Right"
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 368)
        Me._utpMantFonPen_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnuMantFonPen
        '
        '_utpMantFonPen_Toolbars_Dock_Area_Bottom
        '
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.Black
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 396)
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.Name = "_utpMantFonPen_Toolbars_Dock_Area_Bottom"
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(863, 0)
        Me._utpMantFonPen_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnuMantFonPen
        '
        '_utpMantFonPen_Toolbars_Dock_Area_Top
        '
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.Black
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.Name = "_utpMantFonPen_Toolbars_Dock_Area_Top"
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(863, 28)
        Me._utpMantFonPen_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnuMantFonPen
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl3.Controls.Add(Me.griImportaDato)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(863, 396)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(455, 273)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 5
        Me.ugb_Espera.Visible = False
        '
        'griImportaDato
        '
        Me.griImportaDato.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImportaDato.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImportaDato.DisplayLayout.MaxColScrollRegions = 1
        Me.griImportaDato.DisplayLayout.MaxRowScrollRegions = 1
        Me.griImportaDato.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImportaDato.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImportaDato.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griImportaDato.DisplayLayout.Override.CellPadding = 0
        Appearance12.TextHAlignAsString = "Left"
        Me.griImportaDato.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.griImportaDato.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griImportaDato.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griImportaDato.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griImportaDato.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griImportaDato.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griImportaDato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griImportaDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griImportaDato.Location = New System.Drawing.Point(0, 90)
        Me.griImportaDato.Name = "griImportaDato"
        Me.griImportaDato.Size = New System.Drawing.Size(863, 306)
        Me.griImportaDato.TabIndex = 1
        Me.griImportaDato.Text = "Datos Importados"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion3.Controls.Add(Me.btnValidar)
        Me.Agrupacion3.Controls.Add(Me.btnBuscar)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(863, 90)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Acciones:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.verEmpresa)
        Me.Agrupacion5.Controls.Add(Me.verTrabajador)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(149, 54)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(439, 31)
        Me.Agrupacion5.TabIndex = 3
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verEmpresa
        '
        Me.verEmpresa.AutoSize = True
        Me.verEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verEmpresa.ForeColor = System.Drawing.Color.Black
        Me.verEmpresa.Location = New System.Drawing.Point(227, 7)
        Me.verEmpresa.Name = "verEmpresa"
        Me.verEmpresa.Size = New System.Drawing.Size(198, 17)
        Me.verEmpresa.TabIndex = 1
        Me.verEmpresa.Text = "Empresas No Registrados en el SGI"
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
        Me.verTrabajador.Text = "Trabajadores No Regsitrados en el SGI"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.colorNoRegistrado)
        Me.Agrupacion4.Controls.Add(Me.colorRegistrados)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(149, 21)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(439, 31)
        Me.Agrupacion4.TabIndex = 2
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorNoRegistrado
        '
        Me.colorNoRegistrado.Location = New System.Drawing.Point(381, 6)
        Me.colorNoRegistrado.Name = "colorNoRegistrado"
        Me.colorNoRegistrado.Size = New System.Drawing.Size(44, 21)
        Me.colorNoRegistrado.TabIndex = 3
        Me.colorNoRegistrado.Text = "Control"
        '
        'colorRegistrados
        '
        Me.colorRegistrados.Location = New System.Drawing.Point(154, 6)
        Me.colorRegistrados.Name = "colorRegistrados"
        Me.colorRegistrados.Size = New System.Drawing.Size(44, 21)
        Me.colorRegistrados.TabIndex = 2
        Me.colorRegistrados.Text = "Control"
        '
        'Etiqueta11
        '
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(215, 10)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(160, 14)
        Me.Etiqueta11.TabIndex = 1
        Me.Etiqueta11.Text = "Datos No Registrados en el SGI"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(11, 9)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(143, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Datos Registrados en el SGI"
        '
        'btnValidar
        '
        Me.btnValidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.Black
        Me.btnValidar.Location = New System.Drawing.Point(13, 54)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(130, 25)
        Me.btnValidar.TabIndex = 1
        Me.btnValidar.Text = "= Validar Datos ="
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(13, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(130, 25)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "= Buscar Archivo ="
        '
        'ficFondoPensionTrabajador
        '
        Me.ficFondoPensionTrabajador.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficFondoPensionTrabajador.Controls.Add(Me.UltraTabPageControl1)
        Me.ficFondoPensionTrabajador.Controls.Add(Me.utpMantFonPen)
        Me.ficFondoPensionTrabajador.Controls.Add(Me.UltraTabPageControl3)
        Me.ficFondoPensionTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficFondoPensionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficFondoPensionTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.ficFondoPensionTrabajador.Name = "ficFondoPensionTrabajador"
        Me.ficFondoPensionTrabajador.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficFondoPensionTrabajador.Size = New System.Drawing.Size(865, 419)
        Me.ficFondoPensionTrabajador.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.utpMantFonPen
        UltraTab2.Text = "Mantenimiento"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Importar"
        Me.ficFondoPensionTrabajador.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficFondoPensionTrabajador.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(863, 396)
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
        'frm_FondoPensionTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 419)
        Me.Controls.Add(Me.ficFondoPensionTrabajador)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FondoPensionTrabajador"
        Me.Text = "Fondo de Pension por Trabajador"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griFondoPensionTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuFonPenTra.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpMantFonPen.ResumeLayout(False)
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.chkVidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verMixta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCussp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.agrFlujo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFlujo.ResumeLayout(False)
        Me.agrFlujo.PerformLayout()
        CType(Me.ndComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrSaldo.ResumeLayout(False)
        Me.agrSaldo.PerformLayout()
        CType(Me.ndSaldoMixta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndComisionMixta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndSeguros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndObligatorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRegimenPensionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuMantFonPen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griImportaDato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.verEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.colorNoRegistrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficFondoPensionTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFondoPensionTrabajador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficFondoPensionTrabajador As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpMantFonPen As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griFondoPensionTrabajador As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griHistorial As ISL.Controles.Grilla
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents cboRegimenPensionario As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ndSeguros As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ndComision As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents ndObligatorio As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecActividad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents txtCussp As ISL.Controles.Texto
    Friend WithEvents ndTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents griImportaDato As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents btnValidar As ISL.Controles.Boton
    Friend WithEvents btnBuscar As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    ' Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiImportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFonPenTra As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiImportar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents colorNoRegistrado As ISL.Controles.Colores
    Friend WithEvents colorRegistrados As ISL.Controles.Colores
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents verEmpresa As ISL.Controles.Chequear
    Friend WithEvents verTrabajador As ISL.Controles.Chequear
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents verMixta As ISL.Controles.Chequear
    Friend WithEvents agrFlujo As ISL.Controles.Agrupacion
    Friend WithEvents agrSaldo As ISL.Controles.Agrupacion
    Friend WithEvents ndSaldoMixta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents ndComisionMixta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents mnuMantFonPen As ISL.Controles.Menu
    Friend WithEvents _utpMantFonPen_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantFonPen_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantFonPen_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantFonPen_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents chkVidente As ISL.Controles.Chequear
End Class
