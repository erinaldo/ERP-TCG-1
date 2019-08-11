<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EnviarNeumatico
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.fecMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndPrecioVenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiPrecio = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbMotivo = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtTipoVehiculo = New ISL.Controles.Texto(Me.components)
        Me.cboTecnico = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboConductor = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboVehiculo = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ndPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Agrupacion1.Appearance = Appearance1
        Me.Agrupacion1.Controls.Add(Me.fecMovimiento)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.ndPrecioVenta)
        Me.Agrupacion1.Controls.Add(Me.etiPrecio)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.cmbMotivo)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.txtCodigo)
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(12, 7)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(517, 87)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Enviar Neumatico:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecMovimiento
        '
        Me.fecMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecMovimiento.Location = New System.Drawing.Point(232, 26)
        Me.fecMovimiento.Name = "fecMovimiento"
        Me.fecMovimiento.Size = New System.Drawing.Size(90, 20)
        Me.fecMovimiento.TabIndex = 3
        '
        'Etiqueta3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance2
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(163, 28)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Fecha Mov:"
        '
        'ndPrecioVenta
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.ndPrecioVenta.Appearance = Appearance3
        Me.ndPrecioVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndPrecioVenta.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndPrecioVenta.ForeColor = System.Drawing.Color.Black
        Me.ndPrecioVenta.Location = New System.Drawing.Point(406, 24)
        Me.ndPrecioVenta.Name = "ndPrecioVenta"
        Me.ndPrecioVenta.NullText = "0.00"
        Me.ndPrecioVenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndPrecioVenta.Size = New System.Drawing.Size(100, 22)
        Me.ndPrecioVenta.TabIndex = 5
        '
        'etiPrecio
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.etiPrecio.Appearance = Appearance4
        Me.etiPrecio.AutoSize = True
        Me.etiPrecio.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPrecio.ForeColor = System.Drawing.Color.Black
        Me.etiPrecio.Location = New System.Drawing.Point(328, 28)
        Me.etiPrecio.Name = "etiPrecio"
        Me.etiPrecio.Size = New System.Drawing.Size(69, 15)
        Me.etiPrecio.TabIndex = 4
        Me.etiPrecio.Text = "Precio Venta:"
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(9, 55)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Motivo:"
        '
        'cmbMotivo
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cmbMotivo.Appearance = Appearance6
        Me.cmbMotivo.DisplayMember = "Nombre"
        Me.cmbMotivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbMotivo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMotivo.ForeColor = System.Drawing.Color.Black
        Me.cmbMotivo.Location = New System.Drawing.Point(57, 51)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(449, 22)
        Me.cmbMotivo.TabIndex = 7
        Me.cmbMotivo.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance7
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(7, 28)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(57, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'btnCancel
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.btnCancel.Appearance = Appearance8
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(421, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 29)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancelar"
        '
        'btnGuardar
        '
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance9
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(318, 217)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 29)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txtTipoVehiculo)
        Me.UltraGroupBox1.Controls.Add(Me.cboTecnico)
        Me.UltraGroupBox1.Controls.Add(Me.cboConductor)
        Me.UltraGroupBox1.Controls.Add(Me.cboVehiculo)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta7)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta6)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(517, 115)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Datos de Ultimo Montaje"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTipoVehiculo
        '
        Me.txtTipoVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoVehiculo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoVehiculo.Location = New System.Drawing.Point(337, 24)
        Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
        Me.txtTipoVehiculo.Size = New System.Drawing.Size(168, 22)
        Me.txtTipoVehiculo.TabIndex = 3
        '
        'cboTecnico
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboTecnico.Appearance = Appearance10
        Me.cboTecnico.DisplayMember = "Nombre"
        Me.cboTecnico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboTecnico.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTecnico.ForeColor = System.Drawing.Color.Black
        Me.cboTecnico.Location = New System.Drawing.Point(132, 78)
        Me.cboTecnico.Name = "cboTecnico"
        Me.cboTecnico.Size = New System.Drawing.Size(374, 22)
        Me.cboTecnico.TabIndex = 7
        Me.cboTecnico.ValueMember = "Id"
        '
        'cboConductor
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.cboConductor.Appearance = Appearance11
        Me.cboConductor.DisplayMember = "Nombre"
        Me.cboConductor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboConductor.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConductor.ForeColor = System.Drawing.Color.Black
        Me.cboConductor.Location = New System.Drawing.Point(132, 51)
        Me.cboConductor.Name = "cboConductor"
        Me.cboConductor.Size = New System.Drawing.Size(374, 22)
        Me.cboConductor.TabIndex = 5
        Me.cboConductor.ValueMember = "Id"
        '
        'cboVehiculo
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculo.Appearance = Appearance12
        Me.cboVehiculo.DisplayMember = "Nombre"
        Me.cboVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboVehiculo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculo.Location = New System.Drawing.Point(132, 24)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(116, 22)
        Me.cboVehiculo.TabIndex = 1
        Me.cboVehiculo.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance13
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(17, 82)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(109, 15)
        Me.Etiqueta7.TabIndex = 6
        Me.Etiqueta7.Text = "Tecnico Responsable:"
        '
        'Etiqueta6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance14
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(69, 55)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta6.TabIndex = 4
        Me.Etiqueta6.Text = "Conductor:"
        '
        'Etiqueta5
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance15
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(254, 28)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Tipo Vehiculo:"
        '
        'Etiqueta4
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance16
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(77, 28)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Vehiculo:"
        '
        'frm_EnviarNeumatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 251)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Agrupacion1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_EnviarNeumatico"
        Me.Text = "Enviar Neumatico"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.ndPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txtTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConductor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cmbMotivo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents ndPrecioVenta As ISL.Controles.NumeroDecimal
    Friend WithEvents etiPrecio As ISL.Controles.Etiqueta
    Friend WithEvents fecMovimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtTipoVehiculo As ISL.Controles.Texto
    Friend WithEvents cboTecnico As ISL.Controles.ComboMaestros
    Friend WithEvents cboConductor As ISL.Controles.ComboMaestros
    Friend WithEvents cboVehiculo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
End Class
