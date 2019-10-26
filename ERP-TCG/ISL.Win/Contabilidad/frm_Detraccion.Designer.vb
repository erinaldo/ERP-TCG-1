<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Detraccion
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetraccion = New ISL.Controles.Grilla(Me.components)
        Me.mnuDetraccion = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiAplicar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGenerarInforme = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRestaurarDetraccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorFueraRango = New ISL.Controles.Colores(Me.components)
        Me.etiFueraRango = New ISL.Controles.Etiqueta(Me.components)
        Me.colorAplica = New ISL.Controles.Colores(Me.components)
        Me.etiAplica = New ISL.Controles.Etiqueta(Me.components)
        Me.numAplica = New ISL.Controles.Numerador(Me.components)
        Me.optEstadoDetrac = New ISL.Controles.Opciones(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInformeDetrac = New ISL.Controles.Grilla(Me.components)
        Me.ficDetraccion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuDetraccion.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.colorFueraRango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAplica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAplica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optEstadoDetrac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griInformeDetrac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetraccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDetraccion)
        Me.UltraTabPageControl1.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(993, 482)
        '
        'griDetraccion
        '
        Me.griDetraccion.ContextMenuStrip = Me.mnuDetraccion
        Me.griDetraccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetraccion.Location = New System.Drawing.Point(0, 60)
        Me.griDetraccion.Name = "griDetraccion"
        Me.griDetraccion.Size = New System.Drawing.Size(993, 422)
        Me.griDetraccion.TabIndex = 1
        '
        'mnuDetraccion
        '
        Me.mnuDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDetraccion.ForeColor = System.Drawing.Color.Black
        Me.mnuDetraccion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAplicar, Me.tsmiGenerarInforme, Me.tsmiRestaurarDetraccion})
        Me.mnuDetraccion.Name = "mnuDetraccion"
        Me.mnuDetraccion.Size = New System.Drawing.Size(212, 70)
        '
        'tsmiAplicar
        '
        Me.tsmiAplicar.Name = "tsmiAplicar"
        Me.tsmiAplicar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmiAplicar.Size = New System.Drawing.Size(211, 22)
        Me.tsmiAplicar.Text = "Aplicar Detraccion"
        '
        'tsmiGenerarInforme
        '
        Me.tsmiGenerarInforme.Name = "tsmiGenerarInforme"
        Me.tsmiGenerarInforme.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tsmiGenerarInforme.Size = New System.Drawing.Size(211, 22)
        Me.tsmiGenerarInforme.Text = "Generar Informe"
        '
        'tsmiRestaurarDetraccion
        '
        Me.tsmiRestaurarDetraccion.Name = "tsmiRestaurarDetraccion"
        Me.tsmiRestaurarDetraccion.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmiRestaurarDetraccion.Size = New System.Drawing.Size(211, 22)
        Me.tsmiRestaurarDetraccion.Text = "Restaurar Detraccion"
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Agrupacion1)
        Me.agrBusqueda.Controls.Add(Me.optEstadoDetrac)
        Me.agrBusqueda.Controls.Add(Me.fecHasta)
        Me.agrBusqueda.Controls.Add(Me.fecDesde)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(993, 60)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Text = "Datos de Busqueda:"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.colorFueraRango)
        Me.Agrupacion1.Controls.Add(Me.etiFueraRango)
        Me.Agrupacion1.Controls.Add(Me.colorAplica)
        Me.Agrupacion1.Controls.Add(Me.etiAplica)
        Me.Agrupacion1.Controls.Add(Me.numAplica)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(436, 21)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(406, 33)
        Me.Agrupacion1.TabIndex = 6
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorFueraRango
        '
        Me.colorFueraRango.Location = New System.Drawing.Point(352, 6)
        Me.colorFueraRango.Name = "colorFueraRango"
        Me.colorFueraRango.Size = New System.Drawing.Size(46, 21)
        Me.colorFueraRango.TabIndex = 9
        Me.colorFueraRango.Text = "Control"
        '
        'etiFueraRango
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.BorderColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiFueraRango.Appearance = Appearance1
        Me.etiFueraRango.AutoSize = True
        Me.etiFueraRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFueraRango.ForeColor = System.Drawing.Color.Black
        Me.etiFueraRango.Location = New System.Drawing.Point(248, 9)
        Me.etiFueraRango.Name = "etiFueraRango"
        Me.etiFueraRango.Size = New System.Drawing.Size(98, 14)
        Me.etiFueraRango.TabIndex = 8
        Me.etiFueraRango.Text = "Pasaron del Rango"
        '
        'colorAplica
        '
        Me.colorAplica.Location = New System.Drawing.Point(196, 5)
        Me.colorAplica.Name = "colorAplica"
        Me.colorAplica.Size = New System.Drawing.Size(46, 21)
        Me.colorAplica.TabIndex = 7
        Me.colorAplica.Text = "Control"
        '
        'etiAplica
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.BorderColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.etiAplica.Appearance = Appearance2
        Me.etiAplica.AutoSize = True
        Me.etiAplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAplica.ForeColor = System.Drawing.Color.Black
        Me.etiAplica.Location = New System.Drawing.Point(6, 8)
        Me.etiAplica.Name = "etiAplica"
        Me.etiAplica.Size = New System.Drawing.Size(127, 14)
        Me.etiAplica.TabIndex = 6
        Me.etiAplica.Text = "Dias Hábiles para Aplicar"
        '
        'numAplica
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.numAplica.Appearance = Appearance3
        Me.numAplica.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAplica.ForeColor = System.Drawing.Color.Black
        Me.numAplica.Location = New System.Drawing.Point(139, 5)
        Me.numAplica.MaskInput = "nnn"
        Me.numAplica.MaxValue = 100
        Me.numAplica.MinValue = 0
        Me.numAplica.Name = "numAplica"
        Me.numAplica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numAplica.Size = New System.Drawing.Size(51, 21)
        Me.numAplica.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAplica.TabIndex = 0
        '
        'optEstadoDetrac
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.optEstadoDetrac.Appearance = Appearance4
        Me.optEstadoDetrac.BackColor = System.Drawing.Color.Transparent
        Me.optEstadoDetrac.BackColorInternal = System.Drawing.Color.Transparent
        Me.optEstadoDetrac.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optEstadoDetrac.CheckedIndex = 0
        Me.optEstadoDetrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEstadoDetrac.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Ventas"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Aplicados"
        Me.optEstadoDetrac.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optEstadoDetrac.ItemSpacingHorizontal = 10
        Me.optEstadoDetrac.Location = New System.Drawing.Point(279, 27)
        Me.optEstadoDetrac.Name = "optEstadoDetrac"
        Me.optEstadoDetrac.Size = New System.Drawing.Size(141, 20)
        Me.optEstadoDetrac.TabIndex = 4
        Me.optEstadoDetrac.Text = "Ventas"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(190, 26)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(83, 20)
        Me.fecHasta.TabIndex = 3
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(56, 26)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(83, 20)
        Me.fecDesde.TabIndex = 2
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.BorderColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(148, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Hasta:"
        '
        'Etiqueta1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.BorderColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance6
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 28)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Desde:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griInformeDetrac)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(993, 482)
        '
        'griInformeDetrac
        '
        Me.griInformeDetrac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInformeDetrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInformeDetrac.Location = New System.Drawing.Point(0, 0)
        Me.griInformeDetrac.Name = "griInformeDetrac"
        Me.griInformeDetrac.Size = New System.Drawing.Size(993, 482)
        Me.griInformeDetrac.TabIndex = 0
        '
        'ficDetraccion
        '
        Me.ficDetraccion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDetraccion.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDetraccion.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDetraccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetraccion.Location = New System.Drawing.Point(0, 0)
        Me.ficDetraccion.Name = "ficDetraccion"
        Me.ficDetraccion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDetraccion.Size = New System.Drawing.Size(995, 505)
        Me.ficDetraccion.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Aplicar Detraccion"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Informes Generados"
        Me.ficDetraccion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDetraccion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(993, 482)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(299, 218)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'frm_Detraccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 505)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDetraccion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Detraccion"
        Me.Text = "Detracciones"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuDetraccion.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.colorFueraRango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAplica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAplica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optEstadoDetrac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griInformeDetrac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetraccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDetraccion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDetraccion As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents optEstadoDetrac As ISL.Controles.Opciones
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents mnuDetraccion As ISL.Controles.MenuContextual
    Friend WithEvents tsmiAplicar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGenerarInforme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRestaurarDetraccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griInformeDetrac As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents numAplica As ISL.Controles.Numerador
    Friend WithEvents etiAplica As ISL.Controles.Etiqueta
    Friend WithEvents colorAplica As ISL.Controles.Colores
    Friend WithEvents etiFueraRango As ISL.Controles.Etiqueta
    Friend WithEvents colorFueraRango As ISL.Controles.Colores
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
