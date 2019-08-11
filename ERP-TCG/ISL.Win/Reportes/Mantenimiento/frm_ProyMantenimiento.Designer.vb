<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProyMantenimiento
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
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboModelo = New ISL.Controles.Combo(Me.components)
        Me.cboMarca = New ISL.Controles.Combo(Me.components)
        Me.cboUnidadMedida = New ISL.Controles.Combo(Me.components)
        Me.griProyMant = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griProyMant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.cboModelo)
        Me.Agrupacion1.Controls.Add(Me.cboMarca)
        Me.Agrupacion1.Controls.Add(Me.cboUnidadMedida)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(999, 53)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos de Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta3
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance1
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(526, 28)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Modelo:"
        '
        'Etiqueta2
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance2
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(259, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Marca:"
        '
        'Etiqueta1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance3
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(12, 28)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(93, 15)
        Me.Etiqueta1.TabIndex = 3
        Me.Etiqueta1.Text = "Unidad Medida:"
        '
        'cboModelo
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboModelo.Appearance = Appearance4
        Me.cboModelo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboModelo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboModelo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModelo.ForeColor = System.Drawing.Color.Black
        Me.cboModelo.Location = New System.Drawing.Point(577, 24)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Size = New System.Drawing.Size(162, 22)
        Me.cboModelo.TabIndex = 2
        Me.cboModelo.ValueMember = "Id"
        '
        'cboMarca
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboMarca.Appearance = Appearance5
        Me.cboMarca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMarca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMarca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.ForeColor = System.Drawing.Color.Black
        Me.cboMarca.Location = New System.Drawing.Point(304, 24)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(216, 22)
        Me.cboMarca.TabIndex = 1
        Me.cboMarca.ValueMember = "Id"
        '
        'cboUnidadMedida
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboUnidadMedida.Appearance = Appearance6
        Me.cboUnidadMedida.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUnidadMedida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUnidadMedida.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUnidadMedida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadMedida.ForeColor = System.Drawing.Color.Black
        Me.cboUnidadMedida.Location = New System.Drawing.Point(109, 24)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(144, 22)
        Me.cboUnidadMedida.TabIndex = 0
        Me.cboUnidadMedida.ValueMember = "Id"
        '
        'griProyMant
        '
        Me.griProyMant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProyMant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProyMant.Location = New System.Drawing.Point(0, 53)
        Me.griProyMant.Name = "griProyMant"
        Me.griProyMant.Size = New System.Drawing.Size(999, 401)
        Me.griProyMant.TabIndex = 1
        Me.griProyMant.Text = "Listado de Unidades"
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
        Me.ugb_Espera.Location = New System.Drawing.Point(301, 193)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 6
        Me.ugb_Espera.Visible = False
        '
        'frm_ProyMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 454)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.griProyMant)
        Me.Controls.Add(Me.Agrupacion1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ProyMantenimiento"
        Me.Text = "Proyeccion Mantenimiento"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griProyMant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboModelo As ISL.Controles.Combo
    Friend WithEvents cboMarca As ISL.Controles.Combo
    Friend WithEvents cboUnidadMedida As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents griProyMant As ISL.Controles.Grilla
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
