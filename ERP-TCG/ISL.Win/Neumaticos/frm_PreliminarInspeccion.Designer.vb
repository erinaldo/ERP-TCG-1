<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PreliminarInspeccion
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Me.mnuPreliminar = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiGenerar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEnviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTerminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ficPreliminar = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPreliminarInsp = New ISL.Controles.Grilla(Me.components)
        Me.agrBusquedaRegistro = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstadoBus = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrColores = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorMalo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorRegular = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorBueno = New ISL.Controles.Colores(Me.components)
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griPreNecesidades = New ISL.Controles.Grilla(Me.components)
        Me.agrBusquedaPreliminar = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorTerminado = New ISL.Controles.Colores(Me.components)
        Me.colorEnviado = New ISL.Controles.Colores(Me.components)
        Me.colorGenerada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpPeriodoPreliminar = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetallePre = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griConfiguracionMedida = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleConfig = New ISL.Controles.Grilla(Me.components)
        Me.mnuPreliminar.SuspendLayout()
        CType(Me.ficPreliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPreliminar.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griPreliminarInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusquedaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusquedaRegistro.SuspendLayout()
        CType(Me.cboEstadoBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrColores.SuspendLayout()
        CType(Me.colorMalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRegular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorBueno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griPreNecesidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusquedaPreliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusquedaPreliminar.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorEnviado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorGenerada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griDetallePre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griConfiguracionMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalleConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuPreliminar
        '
        Me.mnuPreliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPreliminar.ForeColor = System.Drawing.Color.Black
        Me.mnuPreliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGenerar, Me.tsmiEditar, Me.tsmiEliminar, Me.tsmiEnviar, Me.tsmiTerminar})
        Me.mnuPreliminar.Name = "MenuContextual1"
        Me.mnuPreliminar.Size = New System.Drawing.Size(244, 114)
        '
        'tsmiGenerar
        '
        Me.tsmiGenerar.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.tsmiGenerar.Name = "tsmiGenerar"
        Me.tsmiGenerar.Size = New System.Drawing.Size(243, 22)
        Me.tsmiGenerar.Text = "Generar Preliminar de Necesidades"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(243, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(243, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'tsmiEnviar
        '
        Me.tsmiEnviar.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.tsmiEnviar.Name = "tsmiEnviar"
        Me.tsmiEnviar.Size = New System.Drawing.Size(243, 22)
        Me.tsmiEnviar.Text = "Crear Requerimiento"
        '
        'tsmiTerminar
        '
        Me.tsmiTerminar.Image = Global.ISL.Win.My.Resources.Resources.Information
        Me.tsmiTerminar.Name = "tsmiTerminar"
        Me.tsmiTerminar.Size = New System.Drawing.Size(243, 22)
        Me.tsmiTerminar.Text = "Terminar Preliminar de Necesidades"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ficPreliminar
        '
        Me.ficPreliminar.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficPreliminar.Controls.Add(Me.UltraTabPageControl1)
        Me.ficPreliminar.Controls.Add(Me.UltraTabPageControl2)
        Me.ficPreliminar.Controls.Add(Me.UltraTabPageControl3)
        Me.ficPreliminar.Controls.Add(Me.UltraTabPageControl4)
        Me.ficPreliminar.Controls.Add(Me.UltraTabPageControl5)
        Me.ficPreliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPreliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPreliminar.Location = New System.Drawing.Point(0, 0)
        Me.ficPreliminar.Name = "ficPreliminar"
        Me.ficPreliminar.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficPreliminar.Size = New System.Drawing.Size(839, 494)
        Me.ficPreliminar.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Registro de Inspecciones"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Preliminar de Necesidades"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Detalle Preliminar"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Configuración Tipo Medida"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Detalle Medida"
        Me.ficPreliminar.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5})
        Me.ficPreliminar.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(837, 471)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl1.Controls.Add(Me.agrBusquedaRegistro)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(837, 471)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griPreliminarInsp)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 89)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(837, 382)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griPreliminarInsp
        '
        Me.griPreliminarInsp.ContextMenuStrip = Me.mnuPreliminar
        Me.griPreliminarInsp.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPreliminarInsp.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPreliminarInsp.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPreliminarInsp.DisplayLayout.MaxColScrollRegions = 1
        Me.griPreliminarInsp.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPreliminarInsp.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griPreliminarInsp.DisplayLayout.Override.CellPadding = 0
        Me.griPreliminarInsp.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPreliminarInsp.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPreliminarInsp.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPreliminarInsp.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPreliminarInsp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPreliminarInsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPreliminarInsp.Location = New System.Drawing.Point(2, 2)
        Me.griPreliminarInsp.Name = "griPreliminarInsp"
        Me.griPreliminarInsp.Size = New System.Drawing.Size(833, 378)
        Me.griPreliminarInsp.TabIndex = 0
        '
        'agrBusquedaRegistro
        '
        Me.agrBusquedaRegistro.Controls.Add(Me.Etiqueta9)
        Me.agrBusquedaRegistro.Controls.Add(Me.cboEstadoBus)
        Me.agrBusquedaRegistro.Controls.Add(Me.Etiqueta4)
        Me.agrBusquedaRegistro.Controls.Add(Me.agrColores)
        Me.agrBusquedaRegistro.Controls.Add(Me.fecPeriodo)
        Me.agrBusquedaRegistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusquedaRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusquedaRegistro.ForeColor = System.Drawing.Color.Black
        Me.agrBusquedaRegistro.Location = New System.Drawing.Point(0, 0)
        Me.agrBusquedaRegistro.Name = "agrBusquedaRegistro"
        Me.agrBusquedaRegistro.Size = New System.Drawing.Size(837, 89)
        Me.agrBusquedaRegistro.TabIndex = 0
        Me.agrBusquedaRegistro.Text = "Datos de Busqueda"
        Me.agrBusquedaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta9
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance1
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(14, 26)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta9.TabIndex = 0
        Me.Etiqueta9.Text = "Periodo:"
        '
        'cboEstadoBus
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBus.Appearance = Appearance2
        Me.cboEstadoBus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoBus.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBus.Location = New System.Drawing.Point(273, 22)
        Me.cboEstadoBus.Name = "cboEstadoBus"
        Me.cboEstadoBus.Size = New System.Drawing.Size(144, 21)
        Me.cboEstadoBus.TabIndex = 3
        Me.cboEstadoBus.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance3
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(226, 26)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Estado:"
        '
        'agrColores
        '
        Me.agrColores.Controls.Add(Me.Etiqueta3)
        Me.agrColores.Controls.Add(Me.colorMalo)
        Me.agrColores.Controls.Add(Me.Etiqueta2)
        Me.agrColores.Controls.Add(Me.ColorRegular)
        Me.agrColores.Controls.Add(Me.Etiqueta1)
        Me.agrColores.Controls.Add(Me.colorBueno)
        Me.agrColores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrColores.ForeColor = System.Drawing.Color.Black
        Me.agrColores.Location = New System.Drawing.Point(11, 50)
        Me.agrColores.Name = "agrColores"
        Me.agrColores.Size = New System.Drawing.Size(815, 29)
        Me.agrColores.TabIndex = 4
        Me.agrColores.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance4
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(594, 9)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(164, 14)
        Me.Etiqueta3.TabIndex = 4
        Me.Etiqueta3.Text = "Malo [Cocada Act < Cocada Min]"
        '
        'colorMalo
        '
        Me.colorMalo.Location = New System.Drawing.Point(764, 5)
        Me.colorMalo.Name = "colorMalo"
        Me.colorMalo.Size = New System.Drawing.Size(45, 21)
        Me.colorMalo.TabIndex = 5
        Me.colorMalo.Text = "Control"
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(256, 9)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(281, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Regular [Cocada Min <= Cocada Act <= Cocada Min + 1]"
        '
        'ColorRegular
        '
        Me.ColorRegular.Location = New System.Drawing.Point(544, 5)
        Me.ColorRegular.Name = "ColorRegular"
        Me.ColorRegular.Size = New System.Drawing.Size(44, 21)
        Me.ColorRegular.TabIndex = 3
        Me.ColorRegular.Text = "Control"
        '
        'Etiqueta1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance6
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 9)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(194, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Bueno [Cocada Act >  Cocada Min + 1]"
        '
        'colorBueno
        '
        Me.colorBueno.Location = New System.Drawing.Point(206, 5)
        Me.colorBueno.Name = "colorBueno"
        Me.colorBueno.Size = New System.Drawing.Size(44, 21)
        Me.colorBueno.TabIndex = 1
        Me.colorBueno.Text = "Control"
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(65, 23)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.ShowUpDown = True
        Me.fecPeriodo.Size = New System.Drawing.Size(155, 20)
        Me.fecPeriodo.TabIndex = 1
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griPreNecesidades)
        Me.UltraTabPageControl2.Controls.Add(Me.agrBusquedaPreliminar)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(837, 471)
        '
        'griPreNecesidades
        '
        Me.griPreNecesidades.ContextMenuStrip = Me.mnuPreliminar
        Me.griPreNecesidades.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPreNecesidades.DisplayLayout.MaxColScrollRegions = 1
        Me.griPreNecesidades.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPreNecesidades.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griPreNecesidades.DisplayLayout.Override.CellPadding = 0
        Me.griPreNecesidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPreNecesidades.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPreNecesidades.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPreNecesidades.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPreNecesidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPreNecesidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPreNecesidades.Location = New System.Drawing.Point(0, 63)
        Me.griPreNecesidades.Name = "griPreNecesidades"
        Me.griPreNecesidades.Size = New System.Drawing.Size(837, 408)
        Me.griPreNecesidades.TabIndex = 1
        '
        'agrBusquedaPreliminar
        '
        Me.agrBusquedaPreliminar.Controls.Add(Me.Etiqueta10)
        Me.agrBusquedaPreliminar.Controls.Add(Me.Etiqueta5)
        Me.agrBusquedaPreliminar.Controls.Add(Me.Agrupacion1)
        Me.agrBusquedaPreliminar.Controls.Add(Me.dtpPeriodoPreliminar)
        Me.agrBusquedaPreliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusquedaPreliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusquedaPreliminar.ForeColor = System.Drawing.Color.Black
        Me.agrBusquedaPreliminar.Location = New System.Drawing.Point(0, 0)
        Me.agrBusquedaPreliminar.Name = "agrBusquedaPreliminar"
        Me.agrBusquedaPreliminar.Size = New System.Drawing.Size(837, 63)
        Me.agrBusquedaPreliminar.TabIndex = 0
        Me.agrBusquedaPreliminar.Text = "Datos de Busqueda:"
        Me.agrBusquedaPreliminar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta10
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance7
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(20, 31)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Estado:"
        '
        'Etiqueta5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance8
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(232, 31)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Estado:"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.colorTerminado)
        Me.Agrupacion1.Controls.Add(Me.colorEnviado)
        Me.Agrupacion1.Controls.Add(Me.colorGenerada)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(279, 23)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(362, 28)
        Me.Agrupacion1.TabIndex = 3
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorTerminado
        '
        Me.colorTerminado.Location = New System.Drawing.Point(312, 3)
        Me.colorTerminado.Name = "colorTerminado"
        Me.colorTerminado.Size = New System.Drawing.Size(43, 21)
        Me.colorTerminado.TabIndex = 5
        Me.colorTerminado.Text = "Control"
        '
        'colorEnviado
        '
        Me.colorEnviado.Location = New System.Drawing.Point(187, 3)
        Me.colorEnviado.Name = "colorEnviado"
        Me.colorEnviado.Size = New System.Drawing.Size(43, 21)
        Me.colorEnviado.TabIndex = 3
        Me.colorEnviado.Text = "Control"
        '
        'colorGenerada
        '
        Me.colorGenerada.Location = New System.Drawing.Point(78, 4)
        Me.colorGenerada.Name = "colorGenerada"
        Me.colorGenerada.Size = New System.Drawing.Size(43, 21)
        Me.colorGenerada.TabIndex = 1
        Me.colorGenerada.Text = "Control"
        '
        'Etiqueta8
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance9
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(236, 7)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta8.TabIndex = 4
        Me.Etiqueta8.Text = "TERMIANDO"
        '
        'Etiqueta7
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance10
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(127, 7)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "ENVIADO"
        '
        'Etiqueta6
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance11
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(6, 8)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "GENERADA"
        '
        'dtpPeriodoPreliminar
        '
        Me.dtpPeriodoPreliminar.CustomFormat = "MMMM/yyyy"
        Me.dtpPeriodoPreliminar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodoPreliminar.Location = New System.Drawing.Point(67, 29)
        Me.dtpPeriodoPreliminar.Name = "dtpPeriodoPreliminar"
        Me.dtpPeriodoPreliminar.ShowUpDown = True
        Me.dtpPeriodoPreliminar.Size = New System.Drawing.Size(155, 20)
        Me.dtpPeriodoPreliminar.TabIndex = 1
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griDetallePre)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(837, 471)
        '
        'griDetallePre
        '
        Me.griDetallePre.ContextMenuStrip = Me.mnuPreliminar
        Me.griDetallePre.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetallePre.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetallePre.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetallePre.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetallePre.DisplayLayout.Override.CellPadding = 0
        Me.griDetallePre.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetallePre.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetallePre.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetallePre.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetallePre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetallePre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetallePre.Location = New System.Drawing.Point(0, 0)
        Me.griDetallePre.Name = "griDetallePre"
        Me.griDetallePre.Size = New System.Drawing.Size(837, 471)
        Me.griDetallePre.TabIndex = 0
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griConfiguracionMedida)
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(837, 471)
        '
        'griConfiguracionMedida
        '
        Me.griConfiguracionMedida.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griConfiguracionMedida.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griConfiguracionMedida.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griConfiguracionMedida.DisplayLayout.GroupByBox.Hidden = True
        Me.griConfiguracionMedida.DisplayLayout.MaxColScrollRegions = 1
        Me.griConfiguracionMedida.DisplayLayout.MaxRowScrollRegions = 1
        Me.griConfiguracionMedida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griConfiguracionMedida.DisplayLayout.Override.CellPadding = 0
        Me.griConfiguracionMedida.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griConfiguracionMedida.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griConfiguracionMedida.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griConfiguracionMedida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griConfiguracionMedida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griConfiguracionMedida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griConfiguracionMedida.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griConfiguracionMedida.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.griConfiguracionMedida.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griConfiguracionMedida.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griConfiguracionMedida.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griConfiguracionMedida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griConfiguracionMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griConfiguracionMedida.Location = New System.Drawing.Point(0, 24)
        Me.griConfiguracionMedida.Name = "griConfiguracionMedida"
        Me.griConfiguracionMedida.Size = New System.Drawing.Size(837, 447)
        Me.griConfiguracionMedida.TabIndex = 3
        Me.griConfiguracionMedida.Text = "Información de vehículos"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(837, 24)
        Me.Agrupacion3.TabIndex = 2
        Me.Agrupacion3.Text = "Datos de Busqueda"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griDetalleConfig)
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(837, 471)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(837, 21)
        Me.Agrupacion4.TabIndex = 2
        Me.Agrupacion4.Text = "Datos de Busqueda"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalleConfig
        '
        Me.griDetalleConfig.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleConfig.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleConfig.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleConfig.DisplayLayout.GroupByBox.Hidden = True
        Me.griDetalleConfig.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleConfig.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetalleConfig.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleConfig.DisplayLayout.Override.CellPadding = 0
        Me.griDetalleConfig.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleConfig.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleConfig.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleConfig.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleConfig.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleConfig.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleConfig.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleConfig.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.griDetalleConfig.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleConfig.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleConfig.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalleConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleConfig.Location = New System.Drawing.Point(0, 21)
        Me.griDetalleConfig.Name = "griDetalleConfig"
        Me.griDetalleConfig.Size = New System.Drawing.Size(837, 450)
        Me.griDetalleConfig.TabIndex = 4
        Me.griDetalleConfig.Text = "Información de vehículos"
        '
        'frm_PreliminarInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 494)
        Me.Controls.Add(Me.ficPreliminar)
        Me.Name = "frm_PreliminarInspeccion"
        Me.Text = "Preliminar"
        Me.mnuPreliminar.ResumeLayout(False)
        CType(Me.ficPreliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPreliminar.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griPreliminarInsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusquedaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusquedaRegistro.ResumeLayout(False)
        Me.agrBusquedaRegistro.PerformLayout()
        CType(Me.cboEstadoBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrColores.ResumeLayout(False)
        Me.agrColores.PerformLayout()
        CType(Me.colorMalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRegular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorBueno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griPreNecesidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusquedaPreliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusquedaPreliminar.ResumeLayout(False)
        Me.agrBusquedaPreliminar.PerformLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorEnviado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorGenerada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griDetallePre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griConfiguracionMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalleConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrBusquedaRegistro As ISL.Controles.Agrupacion
    Friend WithEvents griPreliminarInsp As ISL.Controles.Grilla
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ficPreliminar As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griPreNecesidades As ISL.Controles.Grilla
    Friend WithEvents agrBusquedaPreliminar As ISL.Controles.Agrupacion
    Friend WithEvents dtpPeriodoPreliminar As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDetallePre As ISL.Controles.Grilla
    Friend WithEvents mnuPreliminar As ISL.Controles.MenuContextual
    Friend WithEvents tsmiGenerar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEnviar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTerminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrColores As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents colorMalo As ISL.Controles.Colores
    Friend WithEvents ColorRegular As ISL.Controles.Colores
    Friend WithEvents colorBueno As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoBus As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents colorTerminado As ISL.Controles.Colores
    Friend WithEvents colorEnviado As ISL.Controles.Colores
    Friend WithEvents colorGenerada As ISL.Controles.Colores
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents griConfiguracionMedida As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents griDetalleConfig As ISL.Controles.Grilla
End Class
