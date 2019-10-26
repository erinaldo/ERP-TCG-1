<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MontoFlujoDiario
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrMontoFlujoDiario = New ISL.Controles.Agrupacion(Me.components)
        Me.griMontoFlujoDiario = New ISL.Controles.Grilla(Me.components)
        Me.mnuMontoFlujoDiario = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrListaMontoFlujoDiarioDet = New ISL.Controles.Agrupacion(Me.components)
        Me.agrGriDetalle = New ISL.Controles.Agrupacion(Me.components)
        Me.griMFDDetalle = New ISL.Controles.Grilla(Me.components)
        Me.mnuDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiAgregar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiQuitar = New System.Windows.Forms.ToolStripMenuItem
        Me.agrDatoDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.decMontoMax = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConcepto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.decMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.cboTipoVehiculo = New ISL.Controles.Combo(Me.components)
        Me.cboRuta = New ISL.Controles.Combo(Me.components)
        Me.etiMonto = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRuta = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTipoVehiculo = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFlujoCaja = New ISL.Controles.Etiqueta(Me.components)
        Me.ficMontoFlujoDiario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrMontoFlujoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMontoFlujoDiario.SuspendLayout()
        CType(Me.griMontoFlujoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMontoFlujoDiario.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrListaMontoFlujoDiarioDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaMontoFlujoDiarioDet.SuspendLayout()
        CType(Me.agrGriDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGriDetalle.SuspendLayout()
        CType(Me.griMFDDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuDetalle.SuspendLayout()
        CType(Me.agrDatoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.decMontoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.decMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficMontoFlujoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMontoFlujoDiario.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrMontoFlujoDiario)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(715, 458)
        '
        'agrMontoFlujoDiario
        '
        Me.agrMontoFlujoDiario.Controls.Add(Me.griMontoFlujoDiario)
        Me.agrMontoFlujoDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMontoFlujoDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMontoFlujoDiario.ForeColor = System.Drawing.Color.Black
        Me.agrMontoFlujoDiario.Location = New System.Drawing.Point(0, 0)
        Me.agrMontoFlujoDiario.Name = "agrMontoFlujoDiario"
        Me.agrMontoFlujoDiario.Size = New System.Drawing.Size(715, 458)
        Me.agrMontoFlujoDiario.TabIndex = 1
        Me.agrMontoFlujoDiario.Text = "Lista de Montos de Flujo Diario"
        Me.agrMontoFlujoDiario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griMontoFlujoDiario
        '
        Me.griMontoFlujoDiario.ContextMenuStrip = Me.mnuMontoFlujoDiario
        Me.griMontoFlujoDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMontoFlujoDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMontoFlujoDiario.Location = New System.Drawing.Point(2, 18)
        Me.griMontoFlujoDiario.Name = "griMontoFlujoDiario"
        Me.griMontoFlujoDiario.Size = New System.Drawing.Size(711, 438)
        Me.griMontoFlujoDiario.TabIndex = 0
        '
        'mnuMontoFlujoDiario
        '
        Me.mnuMontoFlujoDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMontoFlujoDiario.ForeColor = System.Drawing.Color.Black
        Me.mnuMontoFlujoDiario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiActualizar, Me.tsmiEliminar})
        Me.mnuMontoFlujoDiario.Name = "mnuMontoFlujoDiario"
        Me.mnuMontoFlujoDiario.Size = New System.Drawing.Size(121, 70)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(120, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        '
        'tsmiActualizar
        '
        Me.tsmiActualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiActualizar.Name = "tsmiActualizar"
        Me.tsmiActualizar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiActualizar.Text = "Actualizar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrListaMontoFlujoDiarioDet)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(715, 458)
        '
        'agrListaMontoFlujoDiarioDet
        '
        Me.agrListaMontoFlujoDiarioDet.Controls.Add(Me.agrGriDetalle)
        Me.agrListaMontoFlujoDiarioDet.Controls.Add(Me.agrDatoDetalle)
        Me.agrListaMontoFlujoDiarioDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaMontoFlujoDiarioDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaMontoFlujoDiarioDet.ForeColor = System.Drawing.Color.Black
        Me.agrListaMontoFlujoDiarioDet.Location = New System.Drawing.Point(0, 158)
        Me.agrListaMontoFlujoDiarioDet.Name = "agrListaMontoFlujoDiarioDet"
        Me.agrListaMontoFlujoDiarioDet.Size = New System.Drawing.Size(715, 300)
        Me.agrListaMontoFlujoDiarioDet.TabIndex = 1
        Me.agrListaMontoFlujoDiarioDet.Text = "Lista de Detalle"
        Me.agrListaMontoFlujoDiarioDet.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agrGriDetalle
        '
        Me.agrGriDetalle.Controls.Add(Me.griMFDDetalle)
        Me.agrGriDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrGriDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGriDetalle.ForeColor = System.Drawing.Color.Black
        Me.agrGriDetalle.Location = New System.Drawing.Point(243, 18)
        Me.agrGriDetalle.Name = "agrGriDetalle"
        Me.agrGriDetalle.Size = New System.Drawing.Size(470, 280)
        Me.agrGriDetalle.TabIndex = 2
        Me.agrGriDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griMFDDetalle
        '
        Me.griMFDDetalle.ContextMenuStrip = Me.mnuDetalle
        Me.griMFDDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMFDDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMFDDetalle.Location = New System.Drawing.Point(2, 0)
        Me.griMFDDetalle.Name = "griMFDDetalle"
        Me.griMFDDetalle.Size = New System.Drawing.Size(466, 278)
        Me.griMFDDetalle.TabIndex = 0
        '
        'mnuDetalle
        '
        Me.mnuDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDetalle.ForeColor = System.Drawing.Color.Black
        Me.mnuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAgregar, Me.tsmiEditar, Me.tsmiQuitar})
        Me.mnuDetalle.Name = "mnuDetalle"
        Me.mnuDetalle.Size = New System.Drawing.Size(112, 70)
        '
        'tsmiAgregar
        '
        Me.tsmiAgregar.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsmiAgregar.Name = "tsmiAgregar"
        Me.tsmiAgregar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiAgregar.Text = "Agregar"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Information
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiQuitar
        '
        Me.tsmiQuitar.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.tsmiQuitar.Name = "tsmiQuitar"
        Me.tsmiQuitar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiQuitar.Text = "Quitar"
        '
        'agrDatoDetalle
        '
        Me.agrDatoDetalle.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.agrDatoDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrDatoDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrDatoDetalle.ExpandedSize = New System.Drawing.Size(241, 280)
        Me.agrDatoDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrDatoDetalle.Location = New System.Drawing.Point(2, 18)
        Me.agrDatoDetalle.Name = "agrDatoDetalle"
        Me.agrDatoDetalle.Size = New System.Drawing.Size(241, 280)
        Me.agrDatoDetalle.TabIndex = 1
        Me.agrDatoDetalle.Text = "<< Datos de Detalle >>"
        Me.agrDatoDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnCancelar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAceptar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.decMontoMax)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboConcepto)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(22, 2)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(217, 276)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'btnCancelar
        '
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnCancelar.Appearance = Appearance8
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCancelar.Location = New System.Drawing.Point(110, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 45)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance7
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnAceptar.Location = New System.Drawing.Point(14, 112)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 45)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        '
        'decMontoMax
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.decMontoMax.Appearance = Appearance4
        Me.decMontoMax.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoMax.ForeColor = System.Drawing.Color.Black
        Me.decMontoMax.Location = New System.Drawing.Point(16, 85)
        Me.decMontoMax.Name = "decMontoMax"
        Me.decMontoMax.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoMax.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoMax.Size = New System.Drawing.Size(100, 21)
        Me.decMontoMax.TabIndex = 8
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(14, 65)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Monto Máx:"
        '
        'cboConcepto
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Appearance = Appearance2
        Me.cboConcepto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConcepto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Location = New System.Drawing.Point(16, 38)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(172, 21)
        Me.cboConcepto.TabIndex = 5
        Me.cboConcepto.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(16, 18)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta1.TabIndex = 3
        Me.Etiqueta1.Text = "Concepto:"
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.decMonto)
        Me.agrDatos.Controls.Add(Me.cboFlujoCaja)
        Me.agrDatos.Controls.Add(Me.cboTipoVehiculo)
        Me.agrDatos.Controls.Add(Me.cboRuta)
        Me.agrDatos.Controls.Add(Me.etiMonto)
        Me.agrDatos.Controls.Add(Me.etiRuta)
        Me.agrDatos.Controls.Add(Me.etiTipoVehiculo)
        Me.agrDatos.Controls.Add(Me.etiFlujoCaja)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(715, 158)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'decMonto
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.decMonto.Appearance = Appearance5
        Me.decMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMonto.ForeColor = System.Drawing.Color.Black
        Me.decMonto.Location = New System.Drawing.Point(116, 115)
        Me.decMonto.Name = "decMonto"
        Me.decMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMonto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMonto.ReadOnly = True
        Me.decMonto.Size = New System.Drawing.Size(100, 21)
        Me.decMonto.TabIndex = 7
        '
        'cboFlujoCaja
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Appearance = Appearance1
        Me.cboFlujoCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Location = New System.Drawing.Point(116, 88)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.Size = New System.Drawing.Size(306, 21)
        Me.cboFlujoCaja.TabIndex = 6
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'cboTipoVehiculo
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo.Appearance = Appearance3
        Me.cboTipoVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(116, 61)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(306, 21)
        Me.cboTipoVehiculo.TabIndex = 5
        Me.cboTipoVehiculo.ValueMember = "Id"
        '
        'cboRuta
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboRuta.Appearance = Appearance6
        Me.cboRuta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRuta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRuta.ForeColor = System.Drawing.Color.Black
        Me.cboRuta.Location = New System.Drawing.Point(116, 34)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(306, 21)
        Me.cboRuta.TabIndex = 4
        Me.cboRuta.ValueMember = "Id"
        '
        'etiMonto
        '
        Me.etiMonto.AutoSize = True
        Me.etiMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiMonto.ForeColor = System.Drawing.Color.Black
        Me.etiMonto.Location = New System.Drawing.Point(72, 119)
        Me.etiMonto.Name = "etiMonto"
        Me.etiMonto.Size = New System.Drawing.Size(38, 14)
        Me.etiMonto.TabIndex = 3
        Me.etiMonto.Text = "Monto:"
        '
        'etiRuta
        '
        Me.etiRuta.AutoSize = True
        Me.etiRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRuta.ForeColor = System.Drawing.Color.Black
        Me.etiRuta.Location = New System.Drawing.Point(80, 38)
        Me.etiRuta.Name = "etiRuta"
        Me.etiRuta.Size = New System.Drawing.Size(30, 14)
        Me.etiRuta.TabIndex = 2
        Me.etiRuta.Text = "Ruta:"
        '
        'etiTipoVehiculo
        '
        Me.etiTipoVehiculo.AutoSize = True
        Me.etiTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoVehiculo.ForeColor = System.Drawing.Color.Black
        Me.etiTipoVehiculo.Location = New System.Drawing.Point(38, 65)
        Me.etiTipoVehiculo.Name = "etiTipoVehiculo"
        Me.etiTipoVehiculo.Size = New System.Drawing.Size(74, 14)
        Me.etiTipoVehiculo.TabIndex = 1
        Me.etiTipoVehiculo.Text = "Tipo Vehiculo:"
        '
        'etiFlujoCaja
        '
        Me.etiFlujoCaja.AutoSize = True
        Me.etiFlujoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.etiFlujoCaja.Location = New System.Drawing.Point(55, 92)
        Me.etiFlujoCaja.Name = "etiFlujoCaja"
        Me.etiFlujoCaja.Size = New System.Drawing.Size(57, 14)
        Me.etiFlujoCaja.TabIndex = 0
        Me.etiFlujoCaja.Text = "Flujo Caja:"
        '
        'ficMontoFlujoDiario
        '
        Me.ficMontoFlujoDiario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficMontoFlujoDiario.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMontoFlujoDiario.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMontoFlujoDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMontoFlujoDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMontoFlujoDiario.Location = New System.Drawing.Point(0, 0)
        Me.ficMontoFlujoDiario.Name = "ficMontoFlujoDiario"
        Me.ficMontoFlujoDiario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficMontoFlujoDiario.Size = New System.Drawing.Size(717, 481)
        Me.ficMontoFlujoDiario.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficMontoFlujoDiario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficMontoFlujoDiario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(715, 458)
        '
        'frm_MontoFlujoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 481)
        Me.Controls.Add(Me.ficMontoFlujoDiario)
        Me.Name = "frm_MontoFlujoDiario"
        Me.Text = "Monto de Flujo Diario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrMontoFlujoDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMontoFlujoDiario.ResumeLayout(False)
        CType(Me.griMontoFlujoDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMontoFlujoDiario.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrListaMontoFlujoDiarioDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaMontoFlujoDiarioDet.ResumeLayout(False)
        CType(Me.agrGriDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGriDetalle.ResumeLayout(False)
        CType(Me.griMFDDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuDetalle.ResumeLayout(False)
        CType(Me.agrDatoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.decMontoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.decMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficMontoFlujoDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMontoFlujoDiario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficMontoFlujoDiario As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMontoFlujoDiario As ISL.Controles.Agrupacion
    Friend WithEvents griMontoFlujoDiario As ISL.Controles.Grilla
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents agrListaMontoFlujoDiarioDet As ISL.Controles.Agrupacion
    Friend WithEvents etiRuta As ISL.Controles.Etiqueta
    Friend WithEvents etiTipoVehiculo As ISL.Controles.Etiqueta
    Friend WithEvents etiFlujoCaja As ISL.Controles.Etiqueta
    Friend WithEvents etiMonto As ISL.Controles.Etiqueta
    Friend WithEvents griMFDDetalle As ISL.Controles.Grilla
    Friend WithEvents decMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents cboTipoVehiculo As ISL.Controles.Combo
    Friend WithEvents cboRuta As ISL.Controles.Combo
    Friend WithEvents mnuMontoFlujoDiario As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDetalle As ISL.Controles.MenuContextual
    Friend WithEvents tsmiAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiQuitar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrGriDetalle As ISL.Controles.Agrupacion
    Friend WithEvents agrDatoDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents decMontoMax As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboConcepto As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
End Class
