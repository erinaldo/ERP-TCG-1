<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentoSinAsociacion
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Agrupacion = New ISL.Controles.Agrupacion(Me.components)
        Me.gbEvaluar = New Infragistics.Win.Misc.UltraGroupBox
        Me.rbAprobar = New System.Windows.Forms.RadioButton
        Me.rbRechazar = New System.Windows.Forms.RadioButton
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.Agrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion.SuspendLayout()
        CType(Me.gbEvaluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEvaluar.SuspendLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion
        '
        Me.Agrupacion.Controls.Add(Me.gbEvaluar)
        Me.Agrupacion.Controls.Add(Me.btnCancel)
        Me.Agrupacion.Controls.Add(Me.btnGuardar)
        Me.Agrupacion.Controls.Add(Me.txtGlosa)
        Me.Agrupacion.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion.Controls.Add(Me.Fecha)
        Me.Agrupacion.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion.Name = "Agrupacion"
        Me.Agrupacion.Size = New System.Drawing.Size(445, 186)
        Me.Agrupacion.TabIndex = 1
        Me.Agrupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbEvaluar
        '
        Me.gbEvaluar.Controls.Add(Me.rbAprobar)
        Me.gbEvaluar.Controls.Add(Me.rbRechazar)
        Me.gbEvaluar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEvaluar.Location = New System.Drawing.Point(8, 109)
        Me.gbEvaluar.Name = "gbEvaluar"
        Me.gbEvaluar.Size = New System.Drawing.Size(429, 33)
        Me.gbEvaluar.TabIndex = 326
        Me.gbEvaluar.Text = "Evaluar"
        Me.gbEvaluar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbAprobar
        '
        Me.rbAprobar.AutoSize = True
        Me.rbAprobar.BackColor = System.Drawing.Color.Transparent
        Me.rbAprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAprobar.Location = New System.Drawing.Point(145, 12)
        Me.rbAprobar.Name = "rbAprobar"
        Me.rbAprobar.Size = New System.Drawing.Size(71, 17)
        Me.rbAprobar.TabIndex = 323
        Me.rbAprobar.TabStop = True
        Me.rbAprobar.Text = "Aprobar"
        Me.rbAprobar.UseVisualStyleBackColor = False
        '
        'rbRechazar
        '
        Me.rbRechazar.AutoSize = True
        Me.rbRechazar.BackColor = System.Drawing.Color.Transparent
        Me.rbRechazar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRechazar.Location = New System.Drawing.Point(232, 12)
        Me.rbRechazar.Name = "rbRechazar"
        Me.rbRechazar.Size = New System.Drawing.Size(78, 17)
        Me.rbRechazar.TabIndex = 324
        Me.rbRechazar.TabStop = True
        Me.rbRechazar.Text = "Rechazar"
        Me.rbRechazar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Appearance50.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.btnCancel.Appearance = Appearance50
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(343, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 29)
        Me.btnCancel.TabIndex = 322
        Me.btnCancel.Text = "Cancelar"
        '
        'btnGuardar
        '
        Appearance1.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance1
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(240, 148)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 29)
        Me.btnGuardar.TabIndex = 321
        Me.btnGuardar.Text = "Guardar"
        '
        'txtGlosa
        '
        Appearance42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance42
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(53, 35)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(384, 70)
        Me.txtGlosa.TabIndex = 319
        Me.txtGlosa.Tag = "0"
        '
        'Etiqueta7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance4
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(13, 53)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta7.TabIndex = 320
        Me.Etiqueta7.Text = "Glosa:"
        '
        'Fecha
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Appearance = Appearance7
        Me.Fecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Location = New System.Drawing.Point(53, 8)
        Me.Fecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(79, 21)
        Me.Fecha.TabIndex = 318
        '
        'Etiqueta3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance2
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(13, 12)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta3.TabIndex = 317
        Me.Etiqueta3.Text = "Fecha"
        '
        'frm_DocumentoSinAsociacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 186)
        Me.Controls.Add(Me.Agrupacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_DocumentoSinAsociacion"
        Me.Text = "Documento Sin Asociación"
        CType(Me.Agrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion.ResumeLayout(False)
        Me.Agrupacion.PerformLayout()
        CType(Me.gbEvaluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEvaluar.ResumeLayout(False)
        Me.gbEvaluar.PerformLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion As ISL.Controles.Agrupacion
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha As ISL.Controles.Fecha
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents rbRechazar As System.Windows.Forms.RadioButton
    Friend WithEvents rbAprobar As System.Windows.Forms.RadioButton
    Friend WithEvents gbEvaluar As Infragistics.Win.Misc.UltraGroupBox
End Class
