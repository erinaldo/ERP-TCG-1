<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteSaldoTrabajador
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.etiTrabajador)
        Me.UltraGroupBox1.Controls.Add(Me.cboTrabajador)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(845, 42)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiTrabajador
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance1
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajador.Location = New System.Drawing.Point(18, 16)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 41
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'cboTrabajador
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance2
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(84, 12)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(356, 21)
        Me.cboTrabajador.TabIndex = 42
        Me.cboTrabajador.ValueMember = "Id"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(845, 332)
        Me.ReportViewer1.TabIndex = 2
        '
        'frm_ReporteSaldoTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 374)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm_ReporteSaldoTrabajador"
        Me.Text = "Saldo Trabajador"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
