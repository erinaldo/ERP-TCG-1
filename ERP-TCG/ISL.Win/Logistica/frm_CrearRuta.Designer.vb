<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CrearRuta
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
        Me.lbx_Lugar = New System.Windows.Forms.ListBox
        Me.lbx_Ruta = New System.Windows.Forms.ListBox
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.btnAbajo = New System.Windows.Forms.Button
        Me.btnArriba = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.txt_Ruta = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Pesos = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.SuspendLayout()
        '
        'lbx_Lugar
        '
        Me.lbx_Lugar.DisplayMember = "NombreCorto"
        Me.lbx_Lugar.FormattingEnabled = True
        Me.lbx_Lugar.Location = New System.Drawing.Point(29, 38)
        Me.lbx_Lugar.Name = "lbx_Lugar"
        Me.lbx_Lugar.Size = New System.Drawing.Size(220, 95)
        Me.lbx_Lugar.TabIndex = 0
        Me.lbx_Lugar.ValueMember = "Id"
        '
        'lbx_Ruta
        '
        Me.lbx_Ruta.DisplayMember = "NombreCorto"
        Me.lbx_Ruta.FormattingEnabled = True
        Me.lbx_Ruta.Location = New System.Drawing.Point(298, 38)
        Me.lbx_Ruta.Name = "lbx_Ruta"
        Me.lbx_Ruta.Size = New System.Drawing.Size(148, 95)
        Me.lbx_Ruta.TabIndex = 1
        Me.lbx_Ruta.ValueMember = "Id"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(68, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(181, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(452, 85)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(36, 23)
        Me.btnAbajo.TabIndex = 3
        Me.btnAbajo.Text = "\/"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'btnArriba
        '
        Me.btnArriba.Location = New System.Drawing.Point(452, 56)
        Me.btnArriba.Name = "btnArriba"
        Me.btnArriba.Size = New System.Drawing.Size(36, 23)
        Me.btnArriba.TabIndex = 4
        Me.btnArriba.Text = "/\"
        Me.btnArriba.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(255, 56)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(36, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = ">"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(256, 85)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(36, 23)
        Me.btnQuitar.TabIndex = 6
        Me.btnQuitar.Text = "<"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'txt_Ruta
        '
        Me.txt_Ruta.Location = New System.Drawing.Point(68, 149)
        Me.txt_Ruta.Name = "txt_Ruta"
        Me.txt_Ruta.ReadOnly = True
        Me.txt_Ruta.Size = New System.Drawing.Size(541, 20)
        Me.txt_Ruta.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button5.Location = New System.Drawing.Point(503, 52)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 27)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Aceptar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.Location = New System.Drawing.Point(503, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 27)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ruta: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Buscar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 243
        Me.Label2.Text = "Pesos: "
        '
        'txt_Pesos
        '
        Me.txt_Pesos.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        Me.txt_Pesos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.txt_Pesos.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txt_Pesos.Location = New System.Drawing.Point(68, 175)
        Me.txt_Pesos.Name = "txt_Pesos"
        Me.txt_Pesos.Size = New System.Drawing.Size(541, 20)
        Me.txt_Pesos.TabIndex = 244
        '
        'frm_CrearRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 230)
        Me.Controls.Add(Me.txt_Pesos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txt_Ruta)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnArriba)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lbx_Ruta)
        Me.Controls.Add(Me.lbx_Lugar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CrearRuta"
        Me.Text = "Crear ruta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbx_Lugar As System.Windows.Forms.ListBox
    Friend WithEvents lbx_Ruta As System.Windows.Forms.ListBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAbajo As System.Windows.Forms.Button
    Friend WithEvents btnArriba As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents txt_Ruta As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Pesos As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
End Class
