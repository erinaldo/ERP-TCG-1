<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteDescTrabajador
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
        Me.griDescTrabajador = New ISL.Controles.Grilla(Me.components)
        Me.agrDatosBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEnviar = New ISL.Controles.Boton(Me.components)
        Me.cboPlanilla = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.optnrodesc = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficRptDescuentos = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDescTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBusqueda.SuspendLayout()
        CType(Me.cboPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optnrodesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficRptDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficRptDescuentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDescTrabajador)
        Me.UltraTabPageControl1.Controls.Add(Me.agrDatosBusqueda)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(802, 362)
        '
        'griDescTrabajador
        '
        Me.griDescTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDescTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDescTrabajador.Location = New System.Drawing.Point(0, 53)
        Me.griDescTrabajador.Name = "griDescTrabajador"
        Me.griDescTrabajador.Size = New System.Drawing.Size(802, 309)
        Me.griDescTrabajador.TabIndex = 1
        Me.griDescTrabajador.Text = "Grilla1"
        '
        'agrDatosBusqueda
        '
        Me.agrDatosBusqueda.Controls.Add(Me.btnEnviar)
        Me.agrDatosBusqueda.Controls.Add(Me.cboPlanilla)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrDatosBusqueda.Controls.Add(Me.optnrodesc)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrDatosBusqueda.Controls.Add(Me.fecPeriodo)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosBusqueda.Name = "agrDatosBusqueda"
        Me.agrDatosBusqueda.Size = New System.Drawing.Size(802, 53)
        Me.agrDatosBusqueda.TabIndex = 0
        Me.agrDatosBusqueda.Text = "Datos de Búsqueda:"
        Me.agrDatosBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnEnviar
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.Image = Global.ISL.Win.My.Resources.Resources.Siguiente
        Me.btnEnviar.Appearance = Appearance1
        Me.btnEnviar.AutoSize = True
        Me.btnEnviar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(570, 22)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 26)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = " ENVIAR"
        '
        'cboPlanilla
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboPlanilla.Appearance = Appearance2
        Me.cboPlanilla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlanilla.ForeColor = System.Drawing.Color.Black
        Me.cboPlanilla.Location = New System.Drawing.Point(443, 24)
        Me.cboPlanilla.Name = "cboPlanilla"
        Me.cboPlanilla.Size = New System.Drawing.Size(121, 21)
        Me.cboPlanilla.TabIndex = 6
        Me.cboPlanilla.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(392, 27)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Planilla:"
        '
        'optnrodesc
        '
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.optnrodesc.Appearance = Appearance4
        Me.optnrodesc.BackColor = System.Drawing.Color.Transparent
        Me.optnrodesc.BackColorInternal = System.Drawing.Color.Transparent
        Me.optnrodesc.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optnrodesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optnrodesc.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "1"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "2"
        Me.optnrodesc.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optnrodesc.ItemSpacingHorizontal = 20
        Me.optnrodesc.ItemSpacingVertical = 5
        Me.optnrodesc.Location = New System.Drawing.Point(290, 25)
        Me.optnrodesc.Name = "optnrodesc"
        Me.optnrodesc.Size = New System.Drawing.Size(96, 19)
        Me.optnrodesc.TabIndex = 4
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(201, 27)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Nro Descuento:"
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(63, 24)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.ShowUpDown = True
        Me.fecPeriodo.Size = New System.Drawing.Size(132, 20)
        Me.fecPeriodo.TabIndex = 2
        '
        'Etiqueta1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance6
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(10, 27)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Periodo:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(802, 362)
        '
        'ficRptDescuentos
        '
        Me.ficRptDescuentos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficRptDescuentos.Controls.Add(Me.UltraTabPageControl1)
        Me.ficRptDescuentos.Controls.Add(Me.UltraTabPageControl2)
        Me.ficRptDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficRptDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficRptDescuentos.Location = New System.Drawing.Point(0, 0)
        Me.ficRptDescuentos.Name = "ficRptDescuentos"
        Me.ficRptDescuentos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficRptDescuentos.Size = New System.Drawing.Size(804, 385)
        Me.ficRptDescuentos.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Descuento por Planilla"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Trabajadores Liquidados"
        Me.ficRptDescuentos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficRptDescuentos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(802, 362)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_ReporteDescTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 385)
        Me.Controls.Add(Me.ficRptDescuentos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteDescTrabajador"
        Me.Text = "Reporte de Ejecucion de Descuento "
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDescTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBusqueda.ResumeLayout(False)
        Me.agrDatosBusqueda.PerformLayout()
        CType(Me.cboPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optnrodesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficRptDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficRptDescuentos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficRptDescuentos As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDescTrabajador As ISL.Controles.Grilla
    Friend WithEvents agrDatosBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents optnrodesc As ISL.Controles.Opciones
    Friend WithEvents btnEnviar As ISL.Controles.Boton
    Friend WithEvents cboPlanilla As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
End Class
