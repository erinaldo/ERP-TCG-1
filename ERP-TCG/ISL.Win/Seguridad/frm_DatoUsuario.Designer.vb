<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DatoUsuario
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
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtMensaje = New ISL.Controles.Texto(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.verPersonal = New ISL.Controles.Chequear(Me.components)
        Me.verCorporativo = New ISL.Controles.Chequear(Me.components)
        Me.txtPersonal = New ISL.Controles.Texto(Me.components)
        Me.txtCorporativo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnCerrrar = New ISL.Controles.Boton(Me.components)
        Me.btnGuardar = New ISL.Controles.Boton(Me.components)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.verPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCorporativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorporativo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.Agrupacion1.Controls.Add(Me.txtMensaje)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(8, 11)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(564, 158)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Información Relacionada al presente Proceso "
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtMensaje
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.txtMensaje.Appearance = Appearance1
        Me.txtMensaje.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(6, 28)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.Size = New System.Drawing.Size(552, 120)
        Me.txtMensaje.TabIndex = 0
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.verPersonal)
        Me.Agrupacion2.Controls.Add(Me.verCorporativo)
        Me.Agrupacion2.Controls.Add(Me.txtPersonal)
        Me.Agrupacion2.Controls.Add(Me.txtCorporativo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.btnCerrrar)
        Me.Agrupacion2.Controls.Add(Me.btnGuardar)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(8, 175)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(564, 174)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verPersonal
        '
        Me.verPersonal.AutoSize = True
        Me.verPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verPersonal.ForeColor = System.Drawing.Color.Black
        Me.verPersonal.Location = New System.Drawing.Point(100, 98)
        Me.verPersonal.Name = "verPersonal"
        Me.verPersonal.Size = New System.Drawing.Size(168, 17)
        Me.verPersonal.TabIndex = 7
        Me.verPersonal.Text = "No Cuento con email personal"
        '
        'verCorporativo
        '
        Me.verCorporativo.AutoSize = True
        Me.verCorporativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCorporativo.ForeColor = System.Drawing.Color.Black
        Me.verCorporativo.Location = New System.Drawing.Point(100, 48)
        Me.verCorporativo.Name = "verCorporativo"
        Me.verCorporativo.Size = New System.Drawing.Size(181, 17)
        Me.verCorporativo.TabIndex = 6
        Me.verCorporativo.Text = "No Cuento con email corporativo"
        '
        'txtPersonal
        '
        Me.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPersonal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonal.Location = New System.Drawing.Point(100, 71)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(428, 21)
        Me.txtPersonal.TabIndex = 5
        '
        'txtCorporativo
        '
        Me.txtCorporativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorporativo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCorporativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporativo.Location = New System.Drawing.Point(100, 21)
        Me.txtCorporativo.Name = "txtCorporativo"
        Me.txtCorporativo.Size = New System.Drawing.Size(428, 21)
        Me.txtCorporativo.TabIndex = 4
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(43, 75)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(51, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Personal:"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(30, 25)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Corporativo:"
        '
        'btnCerrrar
        '
        Me.btnCerrrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCerrrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrrar.Location = New System.Drawing.Point(295, 132)
        Me.btnCerrrar.Name = "btnCerrrar"
        Me.btnCerrrar.Size = New System.Drawing.Size(90, 25)
        Me.btnCerrrar.TabIndex = 1
        Me.btnCerrrar.Text = "= Cerrar ="
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(184, 132)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 25)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "= Guardar ="
        '
        'frm_DatoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Agrupacion2)
        Me.Controls.Add(Me.Agrupacion1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_DatoUsuario"
        Me.Text = "Ingreso de Datos"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.verPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCorporativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorporativo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents txtMensaje As ISL.Controles.Texto
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents btnCerrrar As ISL.Controles.Boton
    Friend WithEvents btnGuardar As ISL.Controles.Boton
    Friend WithEvents txtPersonal As ISL.Controles.Texto
    Friend WithEvents txtCorporativo As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verPersonal As ISL.Controles.Chequear
    Friend WithEvents verCorporativo As ISL.Controles.Chequear
End Class
