<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AutenticarTrabajador
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cboTrabajador = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btCambiarClave = New ISL.Controles.Boton(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.txtClaveSeguridad = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtClaveSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTrabajador
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance1
        Me.cboTrabajador.DisplayMember = "NombreCompleto"
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "FO"
        ValueListItem1.DisplayText = "Fecha de orden :"
        ValueListItem2.DataValue = "FE"
        ValueListItem2.DisplayText = "Fecha de entrega :"
        ValueListItem15.DataValue = "FP"
        ValueListItem15.DisplayText = "Fecha de pago :"
        Me.cboTrabajador.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem15})
        Me.cboTrabajador.Location = New System.Drawing.Point(76, 21)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(320, 22)
        Me.cboTrabajador.TabIndex = 313
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance2
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(11, 22)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta7.TabIndex = 314
        Me.Etiqueta7.Text = "Trabajador:"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.btCambiarClave)
        Me.Agrupacion1.Controls.Add(Me.btnCancelar)
        Me.Agrupacion1.Controls.Add(Me.btnAceptar)
        Me.Agrupacion1.Controls.Add(Me.txtClaveSeguridad)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(405, 112)
        Me.Agrupacion1.TabIndex = 315
        Me.Agrupacion1.Text = "Datos"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btCambiarClave
        '
        Me.btCambiarClave.BackColorInternal = System.Drawing.Color.Transparent
        Me.btCambiarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCambiarClave.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btCambiarClave.ForeColor = System.Drawing.Color.Black
        Me.btCambiarClave.Location = New System.Drawing.Point(272, 47)
        Me.btCambiarClave.Name = "btCambiarClave"
        Me.btCambiarClave.Size = New System.Drawing.Size(121, 26)
        Me.btCambiarClave.TabIndex = 319
        Me.btCambiarClave.Text = "Cambiar Clave"
        Me.btCambiarClave.Visible = False
        '
        'btnCancelar
        '
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.btnCancelar.Appearance = Appearance3
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(317, 81)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 26)
        Me.btnCancelar.TabIndex = 318
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance4
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(232, 80)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(79, 27)
        Me.btnAceptar.TabIndex = 317
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtClaveSeguridad
        '
        Me.txtClaveSeguridad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClaveSeguridad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtClaveSeguridad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveSeguridad.Location = New System.Drawing.Point(76, 49)
        Me.txtClaveSeguridad.MaxLength = 8
        Me.txtClaveSeguridad.Name = "txtClaveSeguridad"
        Me.txtClaveSeguridad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveSeguridad.Size = New System.Drawing.Size(158, 22)
        Me.txtClaveSeguridad.TabIndex = 316
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(39, 51)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta1.TabIndex = 315
        Me.Etiqueta1.Text = "Clave:"
        '
        'frm_AutenticarTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(405, 112)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AutenticarTrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Trabajador"
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtClaveSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboTrabajador As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtClaveSeguridad As ISL.Controles.Texto
    Friend WithEvents btCambiarClave As ISL.Controles.Boton
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton

End Class
