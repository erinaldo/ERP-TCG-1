<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteObligacionxPeriodo
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.rvwDatos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.agrDatos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboCuenta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboProveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboMes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboEjercicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkResumen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvwDatos
        '
        Me.rvwDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvwDatos.Location = New System.Drawing.Point(0, 101)
        Me.rvwDatos.Name = "rvwDatos"
        Me.rvwDatos.Size = New System.Drawing.Size(956, 328)
        Me.rvwDatos.TabIndex = 1
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.txtCuenta)
        Me.agrDatos.Controls.Add(Me.cboCuenta)
        Me.agrDatos.Controls.Add(Me.cboProveedor)
        Me.agrDatos.Controls.Add(Me.cboMes)
        Me.agrDatos.Controls.Add(Me.cboEjercicio)
        Me.agrDatos.Controls.Add(Me.chkResumen)
        Me.agrDatos.Controls.Add(Me.UltraLabel4)
        Me.agrDatos.Controls.Add(Me.UltraLabel3)
        Me.agrDatos.Controls.Add(Me.UltraLabel2)
        Me.agrDatos.Controls.Add(Me.UltraLabel1)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(956, 101)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCuenta
        '
        Me.txtCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCuenta.Location = New System.Drawing.Point(182, 68)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(350, 22)
        Me.txtCuenta.TabIndex = 9
        '
        'cboCuenta
        '
        Me.cboCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuenta.Location = New System.Drawing.Point(80, 68)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(96, 22)
        Me.cboCuenta.TabIndex = 8
        Me.cboCuenta.ValueMember = "Id"
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboProveedor.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboProveedor.Location = New System.Drawing.Point(80, 40)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(452, 22)
        Me.cboProveedor.TabIndex = 7
        Me.cboProveedor.ValueMember = "Id"
        '
        'cboMes
        '
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Location = New System.Drawing.Point(216, 12)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(96, 22)
        Me.cboMes.TabIndex = 6
        '
        'cboEjercicio
        '
        Me.cboEjercicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboEjercicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEjercicio.Location = New System.Drawing.Point(80, 12)
        Me.cboEjercicio.Name = "cboEjercicio"
        Me.cboEjercicio.Size = New System.Drawing.Size(96, 22)
        Me.cboEjercicio.TabIndex = 5
        '
        'chkResumen
        '
        Me.chkResumen.AutoSize = True
        Me.chkResumen.BackColor = System.Drawing.Color.Transparent
        Me.chkResumen.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkResumen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkResumen.Location = New System.Drawing.Point(318, 15)
        Me.chkResumen.Name = "chkResumen"
        Me.chkResumen.Size = New System.Drawing.Size(73, 18)
        Me.chkResumen.TabIndex = 4
        Me.chkResumen.Text = "Resumen:"
        '
        'UltraLabel4
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(31, 72)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel4.TabIndex = 3
        Me.UltraLabel4.Text = "Cuenta:"
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(15, 44)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Proveedor:"
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(182, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(28, 15)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Mes:"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 15)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(50, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Ejercicio:"
        '
        'frm_ReporteObligacionxPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 429)
        Me.Controls.Add(Me.rvwDatos)
        Me.Controls.Add(Me.agrDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteObligacionxPeriodo"
        Me.Text = "frm_ReporteObligacionxPeriodo"
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkResumen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboCuenta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboProveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboMes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboEjercicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents rvwDatos As Microsoft.Reporting.WinForms.ReportViewer
End Class
