<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoHorario
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
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TipoHorario))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtObservaciones = New ISL.Controles.Texto(Me.components)
        Me.fecRechazo = New System.Windows.Forms.DateTimePicker()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Boton1)
        Me.Agrupacion1.Controls.Add(Me.btnAprobar)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel12)
        Me.Agrupacion1.Controls.Add(Me.txtObservaciones)
        Me.Agrupacion1.Controls.Add(Me.fecRechazo)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(565, 116)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Boton1
        '
        Appearance165.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance165.Image = "16 (Delete).ico"
        Me.Boton1.Appearance = Appearance165
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.ImageList = Me.imagenes
        Me.Boton1.Location = New System.Drawing.Point(436, 55)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(78, 27)
        Me.Boton1.TabIndex = 331
        Me.Boton1.Text = "Cancelar"
        Me.Boton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "16 (Ok).ico")
        Me.imagenes.Images.SetKeyName(1, "16 (Money bag).ico")
        Me.imagenes.Images.SetKeyName(2, "16 (Minus).ico")
        Me.imagenes.Images.SetKeyName(3, "16 (Delete).ico")
        Me.imagenes.Images.SetKeyName(4, "16 (File new).ico")
        '
        'btnAprobar
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance1.Image = "16 (Ok).ico"
        Me.btnAprobar.Appearance = Appearance1
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.ImageList = Me.imagenes
        Me.btnAprobar.Location = New System.Drawing.Point(436, 12)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(78, 27)
        Me.btnAprobar.TabIndex = 330
        Me.btnAprobar.Text = "Guardar"
        Me.btnAprobar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(61, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(34, 15)
        Me.UltraLabel1.TabIndex = 329
        Me.UltraLabel1.Text = "Fecha"
        '
        'UltraLabel12
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance30
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(47, 41)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel12.TabIndex = 327
        Me.UltraLabel12.Text = "Nombre:"
        '
        'txtObservaciones
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Appearance = Appearance3
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Location = New System.Drawing.Point(106, 39)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(305, 54)
        Me.txtObservaciones.TabIndex = 14
        '
        'fecRechazo
        '
        Me.fecRechazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecRechazo.Location = New System.Drawing.Point(106, 12)
        Me.fecRechazo.Name = "fecRechazo"
        Me.fecRechazo.Size = New System.Drawing.Size(95, 20)
        Me.fecRechazo.TabIndex = 4
        '
        'frm_TipoHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 116)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_TipoHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Horario"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Boton1 As ISL.Controles.Boton
    Friend WithEvents btnAprobar As ISL.Controles.Boton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservaciones As ISL.Controles.Texto
    Friend WithEvents fecRechazo As System.Windows.Forms.DateTimePicker
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
End Class
