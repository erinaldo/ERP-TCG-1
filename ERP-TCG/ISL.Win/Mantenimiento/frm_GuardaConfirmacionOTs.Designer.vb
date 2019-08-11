<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GuardaConfirmacionOTs
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
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Agrupacion = New ISL.Controles.Agrupacion(Me.components)
        Me.chkEnviarmail = New System.Windows.Forms.CheckBox()
        Me.optIndComprobancion = New ISL.Controles.Opciones(Me.components)
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.Agrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion.SuspendLayout()
        CType(Me.optIndComprobancion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion
        '
        Me.Agrupacion.Controls.Add(Me.chkEnviarmail)
        Me.Agrupacion.Controls.Add(Me.optIndComprobancion)
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
        Me.Agrupacion.Size = New System.Drawing.Size(415, 166)
        Me.Agrupacion.TabIndex = 0
        Me.Agrupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkEnviarmail
        '
        Me.chkEnviarmail.AutoSize = True
        Me.chkEnviarmail.BackColor = System.Drawing.Color.Transparent
        Me.chkEnviarmail.ForeColor = System.Drawing.Color.Navy
        Me.chkEnviarmail.Location = New System.Drawing.Point(53, 131)
        Me.chkEnviarmail.Name = "chkEnviarmail"
        Me.chkEnviarmail.Size = New System.Drawing.Size(89, 17)
        Me.chkEnviarmail.TabIndex = 324
        Me.chkEnviarmail.Text = "Enviar e-mail."
        Me.chkEnviarmail.UseVisualStyleBackColor = False
        '
        'optIndComprobancion
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.optIndComprobancion.Appearance = Appearance1
        Me.optIndComprobancion.BackColor = System.Drawing.Color.Transparent
        Me.optIndComprobancion.BackColorInternal = System.Drawing.Color.Transparent
        Me.optIndComprobancion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optIndComprobancion.CheckedIndex = 0
        Me.optIndComprobancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIndComprobancion.ForeColor = System.Drawing.Color.Black
        ValueListItem5.DataValue = "ValueListItem1"
        ValueListItem5.DisplayText = "Conforme"
        ValueListItem6.DataValue = False
        ValueListItem6.DisplayText = "Disconforme"
        Me.optIndComprobancion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.optIndComprobancion.ItemSpacingHorizontal = 30
        Me.optIndComprobancion.Location = New System.Drawing.Point(193, 12)
        Me.optIndComprobancion.Name = "optIndComprobancion"
        Me.optIndComprobancion.Size = New System.Drawing.Size(181, 14)
        Me.optIndComprobancion.TabIndex = 323
        Me.optIndComprobancion.Text = "Conforme"
        '
        'btnCancel
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(307, 125)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 29)
        Me.btnCancel.TabIndex = 322
        Me.btnCancel.Text = "Cancelar"
        '
        'btnGuardar
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance3
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(204, 125)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 29)
        Me.btnGuardar.TabIndex = 321
        Me.btnGuardar.Text = "Guardar"
        '
        'txtGlosa
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance4
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(53, 35)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(350, 84)
        Me.txtGlosa.TabIndex = 319
        Me.txtGlosa.Tag = "0"
        '
        'Etiqueta7
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance5
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(13, 37)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta7.TabIndex = 320
        Me.Etiqueta7.Text = "Glosa:"
        '
        'Fecha
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Appearance = Appearance6
        Me.Fecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Location = New System.Drawing.Point(53, 8)
        Me.Fecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(105, 21)
        Me.Fecha.TabIndex = 318
        '
        'Etiqueta3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance7
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(13, 12)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta3.TabIndex = 317
        Me.Etiqueta3.Text = "Fecha"
        '
        'frm_GuardaConfirmacionOTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 166)
        Me.Controls.Add(Me.Agrupacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_GuardaConfirmacionOTs"
        Me.Text = "Guardar OT's Confirmadas"
        CType(Me.Agrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion.ResumeLayout(False)
        Me.Agrupacion.PerformLayout()
        CType(Me.optIndComprobancion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion As ISL.Controles.Agrupacion
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha As ISL.Controles.Fecha
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents optIndComprobancion As ISL.Controles.Opciones
    Friend WithEvents chkEnviarmail As System.Windows.Forms.CheckBox
End Class
