<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PagoDescuento
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griDescuentoMes = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboPlanillaBus = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.optConcepto = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnEjecutar = New ISL.Controles.Boton(Me.components)
        Me.optNroDesc = New ISL.Controles.Opciones(Me.components)
        Me.etiNroDescuento = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFecha = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griPrestamoAsociado = New ISL.Controles.Grilla(Me.components)
        Me.mnuLiquida = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiLiquidar = New System.Windows.Forms.ToolStripMenuItem()
        Me.griTrabajadorCesado = New ISL.Controles.Grilla(Me.components)
        Me.ficDescuento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTip = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDescuentoMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboPlanillaBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optNroDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griPrestamoAsociado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuLiquida.SuspendLayout()
        CType(Me.griTrabajadorCesado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDescuento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl1.Controls.Add(Me.griDescuentoMes)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(881, 550)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(235, 244)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 7
        Me.ugb_Espera.Visible = False
        '
        'griDescuentoMes
        '
        Me.griDescuentoMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDescuentoMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDescuentoMes.Location = New System.Drawing.Point(0, 87)
        Me.griDescuentoMes.Name = "griDescuentoMes"
        Me.griDescuentoMes.Size = New System.Drawing.Size(881, 463)
        Me.griDescuentoMes.TabIndex = 1
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboPlanillaBus)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.optConcepto)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.btnEjecutar)
        Me.Agrupacion1.Controls.Add(Me.optNroDesc)
        Me.Agrupacion1.Controls.Add(Me.etiNroDescuento)
        Me.Agrupacion1.Controls.Add(Me.fecFecha)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(881, 87)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Busqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboPlanillaBus
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboPlanillaBus.Appearance = Appearance1
        Me.cboPlanillaBus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPlanillaBus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPlanillaBus.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPlanillaBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlanillaBus.ForeColor = System.Drawing.Color.Black
        Me.cboPlanillaBus.Location = New System.Drawing.Point(610, 25)
        Me.cboPlanillaBus.Name = "cboPlanillaBus"
        Me.cboPlanillaBus.Size = New System.Drawing.Size(144, 21)
        Me.cboPlanillaBus.TabIndex = 10
        Me.cboPlanillaBus.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance2
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(561, 29)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta4.TabIndex = 9
        Me.Etiqueta4.Text = "Planilla:"
        '
        'optConcepto
        '
        Me.optConcepto.BackColor = System.Drawing.Color.Transparent
        Me.optConcepto.BackColorInternal = System.Drawing.Color.Transparent
        Me.optConcepto.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optConcepto.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Adelanto de Sueldo"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Sanciones"
        Me.optConcepto.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optConcepto.ItemSpacingHorizontal = 10
        Me.optConcepto.ItemSpacingVertical = 10
        Me.optConcepto.Location = New System.Drawing.Point(77, 52)
        Me.optConcepto.Name = "optConcepto"
        Me.optConcepto.Size = New System.Drawing.Size(221, 23)
        Me.optConcepto.TabIndex = 8
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(17, 57)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta3.TabIndex = 7
        Me.Etiqueta3.Text = "Concepto:"
        '
        'btnEjecutar
        '
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnEjecutar.Appearance = Appearance4
        Me.btnEjecutar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEjecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.ForeColor = System.Drawing.Color.Black
        Me.btnEjecutar.Location = New System.Drawing.Point(610, 49)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(83, 26)
        Me.btnEjecutar.TabIndex = 6
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'optNroDesc
        '
        Me.optNroDesc.BackColor = System.Drawing.Color.Transparent
        Me.optNroDesc.BackColorInternal = System.Drawing.Color.Transparent
        Me.optNroDesc.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optNroDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNroDesc.ForeColor = System.Drawing.Color.Black
        ValueListItem3.DataValue = "Default Item"
        ValueListItem3.DisplayText = "1"
        ValueListItem4.DataValue = "ValueListItem1"
        ValueListItem4.DisplayText = "2"
        Me.optNroDesc.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.optNroDesc.ItemSpacingHorizontal = 10
        Me.optNroDesc.ItemSpacingVertical = 10
        Me.optNroDesc.Location = New System.Drawing.Point(449, 52)
        Me.optNroDesc.Name = "optNroDesc"
        Me.optNroDesc.Size = New System.Drawing.Size(74, 23)
        Me.optNroDesc.TabIndex = 5
        '
        'etiNroDescuento
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.etiNroDescuento.Appearance = Appearance5
        Me.etiNroDescuento.AutoSize = True
        Me.etiNroDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroDescuento.ForeColor = System.Drawing.Color.Black
        Me.etiNroDescuento.Location = New System.Drawing.Point(363, 57)
        Me.etiNroDescuento.Name = "etiNroDescuento"
        Me.etiNroDescuento.Size = New System.Drawing.Size(80, 14)
        Me.etiNroDescuento.TabIndex = 4
        Me.etiNroDescuento.Text = "Nro Descuento: "
        '
        'fecFecha
        '
        Me.fecFecha.CustomFormat = "MMMM/yyyy"
        Me.fecFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecFecha.Location = New System.Drawing.Point(407, 26)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.ShowUpDown = True
        Me.fecFecha.Size = New System.Drawing.Size(148, 20)
        Me.fecFecha.TabIndex = 3
        '
        'Etiqueta2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance6
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(363, 29)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Fecha: "
        '
        'cboTrabajador
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance7
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(77, 25)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(280, 21)
        Me.cboTrabajador.TabIndex = 1
        Me.cboTrabajador.ValueMember = "Id"
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
        Me.Etiqueta1.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Trabajador: "
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griPrestamoAsociado)
        Me.UltraTabPageControl2.Controls.Add(Me.griTrabajadorCesado)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(881, 550)
        '
        'griPrestamoAsociado
        '
        Me.griPrestamoAsociado.ContextMenuStrip = Me.mnuLiquida
        Me.griPrestamoAsociado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPrestamoAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPrestamoAsociado.Location = New System.Drawing.Point(0, 368)
        Me.griPrestamoAsociado.Name = "griPrestamoAsociado"
        Me.griPrestamoAsociado.Size = New System.Drawing.Size(881, 182)
        Me.griPrestamoAsociado.TabIndex = 1
        Me.griPrestamoAsociado.Text = "Grilla2"
        '
        'mnuLiquida
        '
        Me.mnuLiquida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLiquida.ForeColor = System.Drawing.Color.Black
        Me.mnuLiquida.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLiquidar})
        Me.mnuLiquida.Name = "mnuLiquida"
        Me.mnuLiquida.Size = New System.Drawing.Size(112, 26)
        '
        'tsmiLiquidar
        '
        Me.tsmiLiquidar.Name = "tsmiLiquidar"
        Me.tsmiLiquidar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiLiquidar.Text = "Liquidar"
        '
        'griTrabajadorCesado
        '
        Me.griTrabajadorCesado.Dock = System.Windows.Forms.DockStyle.Top
        Me.griTrabajadorCesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTrabajadorCesado.Location = New System.Drawing.Point(0, 0)
        Me.griTrabajadorCesado.Name = "griTrabajadorCesado"
        Me.griTrabajadorCesado.Size = New System.Drawing.Size(881, 368)
        Me.griTrabajadorCesado.TabIndex = 0
        Me.griTrabajadorCesado.Text = "Grilla1"
        '
        'ficDescuento
        '
        Me.ficDescuento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDescuento.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDescuento.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDescuento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDescuento.Location = New System.Drawing.Point(0, 0)
        Me.ficDescuento.Name = "ficDescuento"
        Me.ficDescuento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDescuento.Size = New System.Drawing.Size(883, 573)
        Me.ficDescuento.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Trabajadores en Actividad"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Trabajadores Cesados"
        Me.ficDescuento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDescuento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(881, 550)
        '
        'ToolTip
        '
        Me.ToolTip.ContainingControl = Me
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_PagoDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 573)
        Me.Controls.Add(Me.ficDescuento)
        Me.Name = "frm_PagoDescuento"
        Me.Text = "Descuento del Mes"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDescuentoMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboPlanillaBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optNroDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griPrestamoAsociado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuLiquida.ResumeLayout(False)
        CType(Me.griTrabajadorCesado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDescuento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDescuento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents fecFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents griDescuentoMes As ISL.Controles.Grilla
    Friend WithEvents optNroDesc As ISL.Controles.Opciones
    Friend WithEvents etiNroDescuento As ISL.Controles.Etiqueta
    Friend WithEvents ToolTip As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents btnEjecutar As ISL.Controles.Boton
    Friend WithEvents optConcepto As ISL.Controles.Opciones
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents griPrestamoAsociado As ISL.Controles.Grilla
    Friend WithEvents griTrabajadorCesado As ISL.Controles.Grilla
    Friend WithEvents mnuLiquida As ISL.Controles.MenuContextual
    Friend WithEvents tsmiLiquidar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboPlanillaBus As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
