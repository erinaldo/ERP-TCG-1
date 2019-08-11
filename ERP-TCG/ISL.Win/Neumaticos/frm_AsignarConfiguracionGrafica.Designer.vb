<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarConfiguracionGrafica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AsignarConfiguracionGrafica))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_NroLlantasRepuesto = New System.Windows.Forms.Label()
        Me.gb_AsigConfGraf = New System.Windows.Forms.GroupBox()
        Me.cmbConfiguracionNeumatico = New ISL.Controles.ComboMaestros(Me.components)
        Me.ndNroLlantasRepuesto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.gb_AsigConfGraf.SuspendLayout()
        CType(Me.cmbConfiguracionNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndNroLlantasRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración gráfica:"
        '
        'lbl_NroLlantasRepuesto
        '
        Me.lbl_NroLlantasRepuesto.AutoSize = True
        Me.lbl_NroLlantasRepuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroLlantasRepuesto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_NroLlantasRepuesto.Location = New System.Drawing.Point(14, 50)
        Me.lbl_NroLlantasRepuesto.Name = "lbl_NroLlantasRepuesto"
        Me.lbl_NroLlantasRepuesto.Size = New System.Drawing.Size(146, 15)
        Me.lbl_NroLlantasRepuesto.TabIndex = 2
        Me.lbl_NroLlantasRepuesto.Text = "Nº LLantas Repuesto:"
        '
        'gb_AsigConfGraf
        '
        Me.gb_AsigConfGraf.Controls.Add(Me.cmbConfiguracionNeumatico)
        Me.gb_AsigConfGraf.Controls.Add(Me.ndNroLlantasRepuesto)
        Me.gb_AsigConfGraf.Controls.Add(Me.lbl_NroLlantasRepuesto)
        Me.gb_AsigConfGraf.Controls.Add(Me.Label1)
        Me.gb_AsigConfGraf.Location = New System.Drawing.Point(12, 12)
        Me.gb_AsigConfGraf.Name = "gb_AsigConfGraf"
        Me.gb_AsigConfGraf.Size = New System.Drawing.Size(339, 83)
        Me.gb_AsigConfGraf.TabIndex = 0
        Me.gb_AsigConfGraf.TabStop = False
        Me.gb_AsigConfGraf.Text = "Configuracion Grafica:"
        '
        'cmbConfiguracionNeumatico
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cmbConfiguracionNeumatico.Appearance = Appearance1
        Me.cmbConfiguracionNeumatico.DisplayMember = "Nombre"
        Me.cmbConfiguracionNeumatico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbConfiguracionNeumatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConfiguracionNeumatico.ForeColor = System.Drawing.Color.Black
        Me.cmbConfiguracionNeumatico.Location = New System.Drawing.Point(168, 21)
        Me.cmbConfiguracionNeumatico.Name = "cmbConfiguracionNeumatico"
        Me.cmbConfiguracionNeumatico.Size = New System.Drawing.Size(112, 21)
        Me.cmbConfiguracionNeumatico.TabIndex = 1
        Me.cmbConfiguracionNeumatico.ValueMember = "Id"
        '
        'ndNroLlantasRepuesto
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.ndNroLlantasRepuesto.Appearance = Appearance2
        Me.ndNroLlantasRepuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndNroLlantasRepuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndNroLlantasRepuesto.ForeColor = System.Drawing.Color.Black
        Me.ndNroLlantasRepuesto.Location = New System.Drawing.Point(168, 48)
        Me.ndNroLlantasRepuesto.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndNroLlantasRepuesto.Name = "ndNroLlantasRepuesto"
        Me.ndNroLlantasRepuesto.NullText = "0.00"
        Me.ndNroLlantasRepuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndNroLlantasRepuesto.Size = New System.Drawing.Size(73, 21)
        Me.ndNroLlantasRepuesto.TabIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(72, 101)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(112, 31)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.CausesValidation = False
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(190, 101)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frm_AsignarConfiguracionGrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 137)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gb_AsigConfGraf)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AsignarConfiguracionGrafica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Configuracion Grafica"
        Me.gb_AsigConfGraf.ResumeLayout(False)
        Me.gb_AsigConfGraf.PerformLayout()
        CType(Me.cmbConfiguracionNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndNroLlantasRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_NroLlantasRepuesto As System.Windows.Forms.Label
    Friend WithEvents gb_AsigConfGraf As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents ndNroLlantasRepuesto As ISL.Controles.NumeroDecimal
    Friend WithEvents cmbConfiguracionNeumatico As ISL.Controles.ComboMaestros
End Class
