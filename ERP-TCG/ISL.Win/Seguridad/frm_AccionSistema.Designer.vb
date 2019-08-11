<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AccionSistema
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAccionSistema = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalle = New ISL.Controles.Agrupacion(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.griActividadNegocio = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboProceso = New ISL.Controles.Combo(Me.components)
        Me.griActividadRestringida = New ISL.Controles.Grilla(Me.components)
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficAccionSistema = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griAccionSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalle.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.griActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griActividadRestringida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficAccionSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficAccionSistema.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griAccionSistema)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(685, 463)
        '
        'griAccionSistema
        '
        Me.griAccionSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAccionSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAccionSistema.Location = New System.Drawing.Point(0, 0)
        Me.griAccionSistema.Name = "griAccionSistema"
        Me.griAccionSistema.Size = New System.Drawing.Size(685, 463)
        Me.griAccionSistema.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(685, 463)
        '
        'agrDetalle
        '
        Me.agrDetalle.Controls.Add(Me.SplitContainer1)
        Me.agrDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalle.ForeColor = System.Drawing.Color.Black
        Me.agrDetalle.Location = New System.Drawing.Point(0, 168)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(685, 295)
        Me.agrDetalle.TabIndex = 4
        Me.agrDetalle.Text = "Actividad de Negocio Asociado"
        Me.agrDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 18)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.griActividadNegocio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Agrupacion1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.griActividadRestringida)
        Me.SplitContainer1.Size = New System.Drawing.Size(681, 275)
        Me.SplitContainer1.SplitterDistance = 302
        Me.SplitContainer1.TabIndex = 0
        '
        'griActividadNegocio
        '
        Me.griActividadNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griActividadNegocio.Location = New System.Drawing.Point(0, 49)
        Me.griActividadNegocio.Name = "griActividadNegocio"
        Me.griActividadNegocio.Size = New System.Drawing.Size(302, 226)
        Me.griActividadNegocio.TabIndex = 3
        Me.griActividadNegocio.Text = "Grilla1"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboProceso)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(302, 49)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.Text = "Proceso de Negocio:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboProceso
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboProceso.Appearance = Appearance1
        Me.cboProceso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProceso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProceso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProceso.ForeColor = System.Drawing.Color.Black
        Me.cboProceso.Location = New System.Drawing.Point(5, 21)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(285, 21)
        Me.cboProceso.TabIndex = 1
        Me.cboProceso.ValueMember = "Id"
        '
        'griActividadRestringida
        '
        Me.griActividadRestringida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griActividadRestringida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griActividadRestringida.Location = New System.Drawing.Point(0, 0)
        Me.griActividadRestringida.Name = "griActividadRestringida"
        Me.griActividadRestringida.Size = New System.Drawing.Size(375, 275)
        Me.griActividadRestringida.TabIndex = 0
        Me.griActividadRestringida.Text = "Grilla2"
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.txtDescripcion)
        Me.agrDatos.Controls.Add(Me.txtNombre)
        Me.agrDatos.Controls.Add(Me.txtCodigo)
        Me.agrDatos.Controls.Add(Me.Etiqueta1)
        Me.agrDatos.Controls.Add(Me.Etiqueta3)
        Me.agrDatos.Controls.Add(Me.Etiqueta2)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(685, 168)
        Me.agrDatos.TabIndex = 3
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(115, 86)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(374, 65)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(115, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(374, 21)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(115, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 3
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(67, 36)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Codigo:"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(44, 90)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Descripcion:"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(63, 63)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Nombre:"
        '
        'ficAccionSistema
        '
        Me.ficAccionSistema.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficAccionSistema.Controls.Add(Me.UltraTabPageControl1)
        Me.ficAccionSistema.Controls.Add(Me.UltraTabPageControl2)
        Me.ficAccionSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficAccionSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficAccionSistema.Location = New System.Drawing.Point(0, 0)
        Me.ficAccionSistema.Name = "ficAccionSistema"
        Me.ficAccionSistema.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficAccionSistema.Size = New System.Drawing.Size(687, 486)
        Me.ficAccionSistema.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficAccionSistema.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficAccionSistema.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(685, 463)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_AccionSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 486)
        Me.Controls.Add(Me.ficAccionSistema)
        Me.Name = "frm_AccionSistema"
        Me.Text = "Accion Sistema"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griAccionSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalle.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.griActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griActividadRestringida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficAccionSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficAccionSistema.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficAccionSistema As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAccionSistema As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents agrDetalle As ISL.Controles.Agrupacion
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents griActividadNegocio As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents cboProceso As ISL.Controles.Combo
    Friend WithEvents griActividadRestringida As ISL.Controles.Grilla
End Class
