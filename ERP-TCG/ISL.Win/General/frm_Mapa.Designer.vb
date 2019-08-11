<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mapa
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
        Me.components = New System.ComponentModel.Container
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipoMapa = New System.Windows.Forms.ComboBox
        Me.cboVehiculo = New System.Windows.Forms.ComboBox
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiLugar = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCiudad = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCalle = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboTipoMapa)
        Me.Agrupacion1.Controls.Add(Me.cboVehiculo)
        Me.Agrupacion1.Controls.Add(Me.txtEstado)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.etiLugar)
        Me.Agrupacion1.Controls.Add(Me.txtCiudad)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.txtCalle)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.btnBuscar)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1023, 52)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda de información del lugar"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboTipoMapa
        '
        Me.cboTipoMapa.DisplayMember = "Satelital"
        Me.cboTipoMapa.FormattingEnabled = True
        Me.cboTipoMapa.Items.AddRange(New Object() {"Terreno", "Ruta", "Satelital", "Hibrido"})
        Me.cboTipoMapa.Location = New System.Drawing.Point(882, 22)
        Me.cboTipoMapa.Name = "cboTipoMapa"
        Me.cboTipoMapa.Size = New System.Drawing.Size(78, 21)
        Me.cboTipoMapa.TabIndex = 5
        Me.cboTipoMapa.ValueMember = "Satelital"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(658, 23)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(121, 21)
        Me.cboVehiculo.TabIndex = 4
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(462, 22)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(135, 21)
        Me.txtEstado.TabIndex = 2
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(617, 26)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta3.TabIndex = 1
        Me.Etiqueta3.Text = "Placa:"
        '
        'etiLugar
        '
        Me.etiLugar.AutoSize = True
        Me.etiLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiLugar.ForeColor = System.Drawing.Color.Black
        Me.etiLugar.Location = New System.Drawing.Point(404, 26)
        Me.etiLugar.Name = "etiLugar"
        Me.etiLugar.Size = New System.Drawing.Size(32, 14)
        Me.etiLugar.TabIndex = 1
        Me.etiLugar.Text = "Lugar"
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(248, 22)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(135, 21)
        Me.txtCiudad.TabIndex = 1
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(190, 26)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Ciudad"
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(42, 22)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(135, 21)
        Me.txtCalle.TabIndex = 0
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(7, 26)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Calle"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(785, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 25)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Ubicar"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.WebBrowser1)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 52)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1023, 264)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.Text = "Mapa"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 18)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1019, 244)
        Me.WebBrowser1.TabIndex = 0
        '
        'frm_Mapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 316)
        Me.Controls.Add(Me.Agrupacion2)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_Mapa"
        Me.Text = "Información gráfica de lugares - mapas"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents txtCiudad As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtCalle As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents btnBuscar As ISL.Controles.Boton
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents etiLugar As ISL.Controles.Etiqueta
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cboVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoMapa As System.Windows.Forms.ComboBox
End Class
