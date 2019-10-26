<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MaterialAlmacenRequerimiento
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnGuardarMatAlm = New ISL.Controles.Boton(Me.components)
        Me.txtMaterial = New ISL.Controles.Texto(Me.components)
        Me.numStockMaximo = New ISL.Controles.NumeroEntero(Me.components)
        Me.numStockMinimo = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStockMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.btnCancelar)
        Me.Agrupacion1.Controls.Add(Me.btnGuardarMatAlm)
        Me.Agrupacion1.Controls.Add(Me.txtMaterial)
        Me.Agrupacion1.Controls.Add(Me.numStockMaximo)
        Me.Agrupacion1.Controls.Add(Me.numStockMinimo)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(592, 136)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCancelar
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.btnCancelar.Appearance = Appearance1
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(272, 96)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardarMatAlm
        '
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.btnGuardarMatAlm.Appearance = Appearance2
        Me.btnGuardarMatAlm.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardarMatAlm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarMatAlm.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnGuardarMatAlm.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardarMatAlm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarMatAlm.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarMatAlm.Location = New System.Drawing.Point(91, 96)
        Me.btnGuardarMatAlm.Name = "btnGuardarMatAlm"
        Me.btnGuardarMatAlm.Size = New System.Drawing.Size(90, 25)
        Me.btnGuardarMatAlm.TabIndex = 4
        Me.btnGuardarMatAlm.Text = "Guardar"
        '
        'txtMaterial
        '
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.Location = New System.Drawing.Point(91, 32)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(477, 21)
        Me.txtMaterial.TabIndex = 0
        '
        'numStockMaximo
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.numStockMaximo.Appearance = Appearance3
        Me.numStockMaximo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numStockMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockMaximo.ForeColor = System.Drawing.Color.Black
        Me.numStockMaximo.Location = New System.Drawing.Point(354, 58)
        Me.numStockMaximo.Name = "numStockMaximo"
        Me.numStockMaximo.NullText = "0"
        Me.numStockMaximo.Size = New System.Drawing.Size(100, 21)
        Me.numStockMaximo.TabIndex = 3
        '
        'numStockMinimo
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.numStockMinimo.Appearance = Appearance4
        Me.numStockMinimo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockMinimo.ForeColor = System.Drawing.Color.Black
        Me.numStockMinimo.Location = New System.Drawing.Point(91, 58)
        Me.numStockMinimo.Name = "numStockMinimo"
        Me.numStockMinimo.NullText = "0"
        Me.numStockMinimo.Size = New System.Drawing.Size(100, 21)
        Me.numStockMinimo.TabIndex = 2
        '
        'Etiqueta3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance5
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(12, 62)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(73, 14)
        Me.Etiqueta3.TabIndex = 12
        Me.Etiqueta3.Text = "Stock Minimo:"
        '
        'Etiqueta2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance6
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(272, 62)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(76, 14)
        Me.Etiqueta2.TabIndex = 11
        Me.Etiqueta2.Text = "Stock Maximo:"
        '
        'Etiqueta1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance7
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(39, 36)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta1.TabIndex = 10
        Me.Etiqueta1.Text = "Material:"
        '
        'frm_MaterialAlmacenRequerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 136)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_MaterialAlmacenRequerimiento"
        Me.Text = "Material Almacen"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStockMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnGuardarMatAlm As ISL.Controles.Boton
    Friend WithEvents txtMaterial As ISL.Controles.Texto
    Friend WithEvents numStockMaximo As ISL.Controles.NumeroEntero
    Friend WithEvents numStockMinimo As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
End Class
