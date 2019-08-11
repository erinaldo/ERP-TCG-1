<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteOnomastico
    Inherits ISL.Win.frm_ReporteBasico

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
        Me.Tabla = New ISL.Win.Tabla()
        Me.DatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.DataSetName = "Tabla"
        Me.Tabla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatosBindingSource
        '
        Me.DatosBindingSource.DataMember = "Datos"
        Me.DatosBindingSource.DataSource = Me.Tabla
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(637, 463)
        Me.ReportViewer1.TabIndex = 0
        '
        'frm_ReporteOnomastico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 463)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_ReporteOnomastico"
        Me.Text = "frm_ReporteOnomastico"
        Me.Controls.SetChildIndex(Me.ReportViewer1, 0)
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Shadows WithEvents DatosBindingSource As System.Windows.Forms.BindingSource
    Shadows WithEvents Tabla As ISL.Win.Tabla
    'Friend WithEvents DatosTableAdapter As ISL.Win.TablaTableAdapters.DatosTableAdapter
    Shadows WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
