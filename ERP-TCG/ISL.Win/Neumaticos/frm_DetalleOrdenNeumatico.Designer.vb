<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DetalleOrdenNeumatico
    Inherits System.Windows.Forms.Form

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
        Me.griPreRegistro = New ISL.Controles.Grilla(Me.components)
        Me.spContenedor = New System.Windows.Forms.SplitContainer()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMaterial = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        CType(Me.griPreRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spContenedor.Panel1.SuspendLayout()
        Me.spContenedor.Panel2.SuspendLayout()
        Me.spContenedor.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.SuspendLayout()
        '
        'griPreRegistro
        '
        Me.griPreRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPreRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPreRegistro.Location = New System.Drawing.Point(2, 2)
        Me.griPreRegistro.Name = "griPreRegistro"
        Me.griPreRegistro.Size = New System.Drawing.Size(468, 180)
        Me.griPreRegistro.TabIndex = 0
        Me.griPreRegistro.Text = "Listado de Neumaticos"
        '
        'spContenedor
        '
        Me.spContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spContenedor.Location = New System.Drawing.Point(0, 0)
        Me.spContenedor.Name = "spContenedor"
        Me.spContenedor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spContenedor.Panel1
        '
        Me.spContenedor.Panel1.Controls.Add(Me.Agrupacion3)
        Me.spContenedor.Panel1.Controls.Add(Me.Agrupacion2)
        '
        'spContenedor.Panel2
        '
        Me.spContenedor.Panel2.Controls.Add(Me.Agrupacion1)
        Me.spContenedor.Size = New System.Drawing.Size(472, 324)
        Me.spContenedor.SplitterDistance = 258
        Me.spContenedor.TabIndex = 1
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.griPreRegistro)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 74)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(472, 184)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.txtProveedor)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.txtMaterial)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(472, 74)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos de Neumatico"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtProveedor
        '
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(76, 48)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(384, 21)
        Me.txtProveedor.TabIndex = 3
        '
        'Etiqueta2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance1
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(13, 50)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Proveedor:"
        '
        'txtMaterial
        '
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.Location = New System.Drawing.Point(76, 21)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(384, 21)
        Me.txtMaterial.TabIndex = 1
        '
        'Etiqueta1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance2
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(25, 23)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Material:"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.btnCancelar)
        Me.Agrupacion1.Controls.Add(Me.btnAceptar)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(472, 62)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Acciones"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCancelar
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.btnCancelar.Appearance = Appearance3
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(241, 24)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "= Cancelar ="
        '
        'btnAceptar
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.btnAceptar.Appearance = Appearance4
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(145, 24)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "= Aceptar ="
        '
        'frm_DetalleOrdenNeumatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 324)
        Me.Controls.Add(Me.spContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_DetalleOrdenNeumatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre Registro de Neumatico"
        CType(Me.griPreRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContenedor.Panel1.ResumeLayout(False)
        Me.spContenedor.Panel2.ResumeLayout(False)
        CType(Me.spContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContenedor.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents griPreRegistro As ISL.Controles.Grilla
    Friend WithEvents spContenedor As System.Windows.Forms.SplitContainer
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtMaterial As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
End Class
