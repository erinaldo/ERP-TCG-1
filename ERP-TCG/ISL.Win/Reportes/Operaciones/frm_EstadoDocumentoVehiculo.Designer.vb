<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EstadoDocumentoVehiculo
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
        Me.agrDatoBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboFlota = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.griDocumento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.agrDatoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoBusqueda.SuspendLayout()
        CType(Me.cboFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agrDatoBusqueda
        '
        Me.agrDatoBusqueda.Controls.Add(Me.cboFlota)
        Me.agrDatoBusqueda.Controls.Add(Me.UltraLabel1)
        Me.agrDatoBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoBusqueda.Name = "agrDatoBusqueda"
        Me.agrDatoBusqueda.Size = New System.Drawing.Size(737, 66)
        Me.agrDatoBusqueda.TabIndex = 0
        Me.agrDatoBusqueda.Text = "Datos de Búsqueda:"
        Me.agrDatoBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboFlota
        '
        Me.cboFlota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboFlota.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlota.Location = New System.Drawing.Point(65, 31)
        Me.cboFlota.Name = "cboFlota"
        Me.cboFlota.Size = New System.Drawing.Size(199, 22)
        Me.cboFlota.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(26, 35)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Flota:"
        '
        'griDocumento
        '
        Me.griDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumento.Location = New System.Drawing.Point(0, 66)
        Me.griDocumento.Name = "griDocumento"
        Me.griDocumento.Size = New System.Drawing.Size(737, 263)
        Me.griDocumento.TabIndex = 1
        '
        'frm_EstadoDocumentoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 329)
        Me.Controls.Add(Me.griDocumento)
        Me.Controls.Add(Me.agrDatoBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_EstadoDocumentoVehiculo"
        Me.Text = "Estado Documento Vehiculo"
        CType(Me.agrDatoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoBusqueda.ResumeLayout(False)
        Me.agrDatoBusqueda.PerformLayout()
        CType(Me.cboFlota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatoBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDocumento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboFlota As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
