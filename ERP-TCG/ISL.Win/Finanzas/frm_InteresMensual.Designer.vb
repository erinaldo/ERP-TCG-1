<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InteresMensual
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDatos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griReversion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnLeasing = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso1 = New ISL.Controles.BarraProgreso(Me.components)
        Me.agrDatosBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.fecEmision = New System.Windows.Forms.DateTimePicker()
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.BarraProgreso8 = New ISL.Controles.BarraProgreso(Me.components)
        Me.BtnPagoInteresCredito = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso7 = New ISL.Controles.BarraProgreso(Me.components)
        Me.BtnInteresCredito = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso6 = New ISL.Controles.BarraProgreso(Me.components)
        Me.btnInteresReversion = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso5 = New ISL.Controles.BarraProgreso(Me.components)
        Me.btnFec = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso4 = New ISL.Controles.BarraProgreso(Me.components)
        Me.btnFactoring = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso3 = New ISL.Controles.BarraProgreso(Me.components)
        Me.btnFed = New ISL.Controles.Boton(Me.components)
        Me.BarraProgreso2 = New ISL.Controles.BarraProgreso(Me.components)
        Me.btnPagare = New ISL.Controles.Boton(Me.components)
        Me.agrDatos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.upDatos = New Infragistics.Win.Misc.UltraPanel()
        Me.agrListado = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDatos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.upOperacion = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndDolares = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndSoles = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btnProvisionar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griReversion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBusqueda.SuspendLayout()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        Me.upDatos.ClientArea.SuspendLayout()
        Me.upDatos.SuspendLayout()
        CType(Me.agrListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListado.SuspendLayout()
        CType(Me.ficDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDatos.SuspendLayout()
        Me.upOperacion.ClientArea.SuspendLayout()
        Me.upOperacion.SuspendLayout()
        CType(Me.ndDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndSoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDatos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(852, 288)
        '
        'griDatos
        '
        Me.griDatos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDatos.DisplayLayout.MaxColScrollRegions = 1
        Me.griDatos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDatos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDatos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDatos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDatos.DisplayLayout.Override.CellPadding = 0
        Me.griDatos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDatos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griDatos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDatos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDatos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDatos.Location = New System.Drawing.Point(0, 0)
        Me.griDatos.Name = "griDatos"
        Me.griDatos.Size = New System.Drawing.Size(852, 288)
        Me.griDatos.TabIndex = 1
        Me.griDatos.Text = "Intereses"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griReversion)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(852, 288)
        '
        'griReversion
        '
        Me.griReversion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReversion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReversion.DisplayLayout.MaxColScrollRegions = 1
        Me.griReversion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griReversion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griReversion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griReversion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griReversion.DisplayLayout.Override.CellPadding = 0
        Me.griReversion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griReversion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griReversion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griReversion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griReversion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griReversion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griReversion.Location = New System.Drawing.Point(0, 0)
        Me.griReversion.Name = "griReversion"
        Me.griReversion.Size = New System.Drawing.Size(852, 288)
        Me.griReversion.TabIndex = 0
        Me.griReversion.Text = "Reversion"
        '
        'btnLeasing
        '
        Me.btnLeasing.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnLeasing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeasing.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeasing.ForeColor = System.Drawing.Color.Black
        Me.btnLeasing.Location = New System.Drawing.Point(6, 31)
        Me.btnLeasing.Name = "btnLeasing"
        Me.btnLeasing.Size = New System.Drawing.Size(236, 25)
        Me.btnLeasing.TabIndex = 0
        Me.btnLeasing.Text = "INTERES LEASING"
        '
        'BarraProgreso1
        '
        Me.BarraProgreso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso1.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso1.Location = New System.Drawing.Point(248, 31)
        Me.BarraProgreso1.Name = "BarraProgreso1"
        Me.BarraProgreso1.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso1.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso1.TabIndex = 1
        Me.BarraProgreso1.Text = "[Formatted]"
        Me.BarraProgreso1.Visible = False
        '
        'agrDatosBusqueda
        '
        Appearance1.FontData.Name = "Tahoma"
        Me.agrDatosBusqueda.Appearance = Appearance1
        Me.agrDatosBusqueda.Controls.Add(Me.fecEmision)
        Me.agrDatosBusqueda.Controls.Add(Me.DecTC)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta13)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta18)
        Me.agrDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosBusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosBusqueda.Name = "agrDatosBusqueda"
        Me.agrDatosBusqueda.Size = New System.Drawing.Size(1120, 62)
        Me.agrDatosBusqueda.TabIndex = 2
        Me.agrDatosBusqueda.Text = "Generar"
        Me.agrDatosBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecEmision
        '
        Me.fecEmision.CustomFormat = "MMMM/yyyy"
        Me.fecEmision.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecEmision.Location = New System.Drawing.Point(110, 28)
        Me.fecEmision.Name = "fecEmision"
        Me.fecEmision.ShowUpDown = True
        Me.fecEmision.Size = New System.Drawing.Size(138, 20)
        Me.fecEmision.TabIndex = 62
        '
        'DecTC
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance2
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(337, 28)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(106, 22)
        Me.DecTC.TabIndex = 48
        '
        'Etiqueta13
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Appearance = Appearance3
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(260, 30)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta13.TabIndex = 49
        Me.Etiqueta13.Text = "Tipo Cambio:"
        '
        'Etiqueta18
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Appearance = Appearance4
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(13, 30)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta18.TabIndex = 12
        Me.Etiqueta18.Text = "Fecha Provisión:"
        '
        'BarraProgreso8
        '
        Me.BarraProgreso8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso8.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso8.Location = New System.Drawing.Point(248, 242)
        Me.BarraProgreso8.Name = "BarraProgreso8"
        Me.BarraProgreso8.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso8.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso8.TabIndex = 61
        Me.BarraProgreso8.Text = "[Formatted]"
        Me.BarraProgreso8.Visible = False
        '
        'BtnPagoInteresCredito
        '
        Me.BtnPagoInteresCredito.BackColorInternal = System.Drawing.Color.Transparent
        Me.BtnPagoInteresCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPagoInteresCredito.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagoInteresCredito.ForeColor = System.Drawing.Color.Black
        Me.BtnPagoInteresCredito.Location = New System.Drawing.Point(6, 242)
        Me.BtnPagoInteresCredito.Name = "BtnPagoInteresCredito"
        Me.BtnPagoInteresCredito.Size = New System.Drawing.Size(236, 24)
        Me.BtnPagoInteresCredito.TabIndex = 60
        Me.BtnPagoInteresCredito.Text = "PAGO INTERES DE CRÉDITO HIPO."
        '
        'BarraProgreso7
        '
        Me.BarraProgreso7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso7.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso7.Location = New System.Drawing.Point(248, 212)
        Me.BarraProgreso7.Name = "BarraProgreso7"
        Me.BarraProgreso7.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso7.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso7.TabIndex = 59
        Me.BarraProgreso7.Text = "[Formatted]"
        Me.BarraProgreso7.Visible = False
        '
        'BtnInteresCredito
        '
        Me.BtnInteresCredito.BackColorInternal = System.Drawing.Color.Transparent
        Me.BtnInteresCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInteresCredito.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInteresCredito.ForeColor = System.Drawing.Color.Black
        Me.BtnInteresCredito.Location = New System.Drawing.Point(6, 212)
        Me.BtnInteresCredito.Name = "BtnInteresCredito"
        Me.BtnInteresCredito.Size = New System.Drawing.Size(236, 24)
        Me.BtnInteresCredito.TabIndex = 58
        Me.BtnInteresCredito.Text = "PROVISIÓN INTERES DE CRÉDITO HIPO."
        '
        'BarraProgreso6
        '
        Me.BarraProgreso6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso6.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso6.Location = New System.Drawing.Point(248, 182)
        Me.BarraProgreso6.Name = "BarraProgreso6"
        Me.BarraProgreso6.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso6.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso6.TabIndex = 57
        Me.BarraProgreso6.Text = "[Formatted]"
        Me.BarraProgreso6.Visible = False
        '
        'btnInteresReversion
        '
        Me.btnInteresReversion.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnInteresReversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInteresReversion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInteresReversion.ForeColor = System.Drawing.Color.Black
        Me.btnInteresReversion.Location = New System.Drawing.Point(6, 182)
        Me.btnInteresReversion.Name = "btnInteresReversion"
        Me.btnInteresReversion.Size = New System.Drawing.Size(236, 24)
        Me.btnInteresReversion.TabIndex = 56
        Me.btnInteresReversion.Text = "INTERES + REVERSION LEASING"
        '
        'BarraProgreso5
        '
        Me.BarraProgreso5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso5.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso5.Location = New System.Drawing.Point(248, 152)
        Me.BarraProgreso5.Name = "BarraProgreso5"
        Me.BarraProgreso5.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso5.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso5.TabIndex = 55
        Me.BarraProgreso5.Text = "[Formatted]"
        Me.BarraProgreso5.Visible = False
        '
        'btnFec
        '
        Me.btnFec.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnFec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFec.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFec.ForeColor = System.Drawing.Color.Black
        Me.btnFec.Location = New System.Drawing.Point(6, 152)
        Me.btnFec.Name = "btnFec"
        Me.btnFec.Size = New System.Drawing.Size(236, 25)
        Me.btnFec.TabIndex = 54
        Me.btnFec.Text = "INTERES FEC"
        '
        'BarraProgreso4
        '
        Me.BarraProgreso4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso4.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso4.Location = New System.Drawing.Point(248, 121)
        Me.BarraProgreso4.Name = "BarraProgreso4"
        Me.BarraProgreso4.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso4.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso4.TabIndex = 53
        Me.BarraProgreso4.Text = "[Formatted]"
        Me.BarraProgreso4.Visible = False
        '
        'btnFactoring
        '
        Me.btnFactoring.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnFactoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFactoring.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactoring.ForeColor = System.Drawing.Color.Black
        Me.btnFactoring.Location = New System.Drawing.Point(6, 121)
        Me.btnFactoring.Name = "btnFactoring"
        Me.btnFactoring.Size = New System.Drawing.Size(236, 25)
        Me.btnFactoring.TabIndex = 52
        Me.btnFactoring.Text = "INTERES FACTORING"
        '
        'BarraProgreso3
        '
        Me.BarraProgreso3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso3.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso3.Location = New System.Drawing.Point(248, 91)
        Me.BarraProgreso3.Name = "BarraProgreso3"
        Me.BarraProgreso3.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso3.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso3.TabIndex = 51
        Me.BarraProgreso3.Text = "[Formatted]"
        Me.BarraProgreso3.Visible = False
        '
        'btnFed
        '
        Me.btnFed.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnFed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFed.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFed.ForeColor = System.Drawing.Color.Black
        Me.btnFed.Location = New System.Drawing.Point(6, 91)
        Me.btnFed.Name = "btnFed"
        Me.btnFed.Size = New System.Drawing.Size(236, 25)
        Me.btnFed.TabIndex = 50
        Me.btnFed.Text = "INTERES FED"
        '
        'BarraProgreso2
        '
        Me.BarraProgreso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso2.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso2.Location = New System.Drawing.Point(248, 61)
        Me.BarraProgreso2.Name = "BarraProgreso2"
        Me.BarraProgreso2.Size = New System.Drawing.Size(421, 24)
        Me.BarraProgreso2.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso2.TabIndex = 3
        Me.BarraProgreso2.Text = "[Formatted]"
        Me.BarraProgreso2.Visible = False
        '
        'btnPagare
        '
        Me.btnPagare.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnPagare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagare.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagare.ForeColor = System.Drawing.Color.Black
        Me.btnPagare.Location = New System.Drawing.Point(6, 61)
        Me.btnPagare.Name = "btnPagare"
        Me.btnPagare.Size = New System.Drawing.Size(236, 25)
        Me.btnPagare.TabIndex = 2
        Me.btnPagare.Text = "INTERES PAGARE"
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.btnLeasing)
        Me.agrDatos.Controls.Add(Me.BarraProgreso8)
        Me.agrDatos.Controls.Add(Me.BarraProgreso1)
        Me.agrDatos.Controls.Add(Me.BtnPagoInteresCredito)
        Me.agrDatos.Controls.Add(Me.btnPagare)
        Me.agrDatos.Controls.Add(Me.BarraProgreso7)
        Me.agrDatos.Controls.Add(Me.BarraProgreso2)
        Me.agrDatos.Controls.Add(Me.BtnInteresCredito)
        Me.agrDatos.Controls.Add(Me.btnFed)
        Me.agrDatos.Controls.Add(Me.BarraProgreso6)
        Me.agrDatos.Controls.Add(Me.BarraProgreso3)
        Me.agrDatos.Controls.Add(Me.btnInteresReversion)
        Me.agrDatos.Controls.Add(Me.btnFactoring)
        Me.agrDatos.Controls.Add(Me.BarraProgreso5)
        Me.agrDatos.Controls.Add(Me.BarraProgreso4)
        Me.agrDatos.Controls.Add(Me.btnFec)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrDatos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(260, 378)
        Me.agrDatos.TabIndex = 3
        Me.agrDatos.Text = "Obligaciones Financieras:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'upDatos
        '
        '
        'upDatos.ClientArea
        '
        Me.upDatos.ClientArea.Controls.Add(Me.agrListado)
        Me.upDatos.ClientArea.Controls.Add(Me.agrDatos)
        Me.upDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upDatos.Location = New System.Drawing.Point(0, 62)
        Me.upDatos.Name = "upDatos"
        Me.upDatos.Size = New System.Drawing.Size(1120, 378)
        Me.upDatos.TabIndex = 4
        '
        'agrListado
        '
        Me.agrListado.Controls.Add(Me.ficDatos)
        Me.agrListado.Controls.Add(Me.upOperacion)
        Me.agrListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListado.Location = New System.Drawing.Point(260, 0)
        Me.agrListado.Name = "agrListado"
        Me.agrListado.Size = New System.Drawing.Size(860, 378)
        Me.agrListado.TabIndex = 4
        Me.agrListado.Text = "Datos a Provisionar:"
        Me.agrListado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDatos
        '
        Me.ficDatos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDatos.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDatos.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDatos.Location = New System.Drawing.Point(3, 64)
        Me.ficDatos.Name = "ficDatos"
        Me.ficDatos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDatos.Size = New System.Drawing.Size(854, 311)
        Me.ficDatos.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Intereses"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Reversion"
        Me.ficDatos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDatos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(852, 288)
        '
        'upOperacion
        '
        '
        'upOperacion.ClientArea
        '
        Me.upOperacion.ClientArea.Controls.Add(Me.UltraLabel2)
        Me.upOperacion.ClientArea.Controls.Add(Me.ndDolares)
        Me.upOperacion.ClientArea.Controls.Add(Me.UltraLabel1)
        Me.upOperacion.ClientArea.Controls.Add(Me.ndSoles)
        Me.upOperacion.ClientArea.Controls.Add(Me.btnProvisionar)
        Me.upOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.upOperacion.Location = New System.Drawing.Point(3, 17)
        Me.upOperacion.Name = "upOperacion"
        Me.upOperacion.Size = New System.Drawing.Size(854, 47)
        Me.upOperacion.TabIndex = 0
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(340, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 15)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Monto Dolares:"
        '
        'ndDolares
        '
        Me.ndDolares.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndDolares.Location = New System.Drawing.Point(426, 13)
        Me.ndDolares.MaskInput = "{double:9.2}"
        Me.ndDolares.Name = "ndDolares"
        Me.ndDolares.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndDolares.ReadOnly = True
        Me.ndDolares.Size = New System.Drawing.Size(100, 22)
        Me.ndDolares.TabIndex = 3
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(155, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Monto Soles:"
        '
        'ndSoles
        '
        Me.ndSoles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndSoles.Location = New System.Drawing.Point(230, 13)
        Me.ndSoles.MaskInput = "{double:9.2}"
        Me.ndSoles.Name = "ndSoles"
        Me.ndSoles.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndSoles.ReadOnly = True
        Me.ndSoles.Size = New System.Drawing.Size(100, 22)
        Me.ndSoles.TabIndex = 1
        '
        'btnProvisionar
        '
        Appearance5.Image = Global.ISL.Win.My.Resources.Resources.content_tree
        Me.btnProvisionar.Appearance = Appearance5
        Me.btnProvisionar.AutoSize = True
        Me.btnProvisionar.Location = New System.Drawing.Point(13, 12)
        Me.btnProvisionar.Name = "btnProvisionar"
        Me.btnProvisionar.Size = New System.Drawing.Size(117, 26)
        Me.btnProvisionar.TabIndex = 0
        Me.btnProvisionar.Text = "Provisionar Datos"
        '
        'frm_InteresMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1120, 440)
        Me.Controls.Add(Me.upDatos)
        Me.Controls.Add(Me.agrDatosBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_InteresMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Provision de Interes Mensual"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griReversion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBusqueda.ResumeLayout(False)
        Me.agrDatosBusqueda.PerformLayout()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.upDatos.ClientArea.ResumeLayout(False)
        Me.upDatos.ResumeLayout(False)
        CType(Me.agrListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListado.ResumeLayout(False)
        CType(Me.ficDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDatos.ResumeLayout(False)
        Me.upOperacion.ClientArea.ResumeLayout(False)
        Me.upOperacion.ClientArea.PerformLayout()
        Me.upOperacion.ResumeLayout(False)
        CType(Me.ndDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndSoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLeasing As ISL.Controles.Boton
    Friend WithEvents BarraProgreso1 As ISL.Controles.BarraProgreso
    Friend WithEvents agrDatosBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents BarraProgreso2 As ISL.Controles.BarraProgreso
    Friend WithEvents btnPagare As ISL.Controles.Boton
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents BarraProgreso4 As ISL.Controles.BarraProgreso
    Friend WithEvents btnFactoring As ISL.Controles.Boton
    Friend WithEvents BarraProgreso3 As ISL.Controles.BarraProgreso
    Friend WithEvents btnFed As ISL.Controles.Boton
    Friend WithEvents BarraProgreso5 As ISL.Controles.BarraProgreso
    Friend WithEvents btnFec As ISL.Controles.Boton
    Friend WithEvents BarraProgreso6 As ISL.Controles.BarraProgreso
    Friend WithEvents btnInteresReversion As ISL.Controles.Boton
    Friend WithEvents BarraProgreso7 As ISL.Controles.BarraProgreso
    Friend WithEvents BtnInteresCredito As ISL.Controles.Boton
    Friend WithEvents BarraProgreso8 As ISL.Controles.BarraProgreso
    Friend WithEvents BtnPagoInteresCredito As ISL.Controles.Boton
    Friend WithEvents fecEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents agrDatos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents upDatos As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents agrListado As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDatos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents upOperacion As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnProvisionar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ficDatos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griReversion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndDolares As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndSoles As Infragistics.Win.UltraWinEditors.UltraNumericEditor

End Class
