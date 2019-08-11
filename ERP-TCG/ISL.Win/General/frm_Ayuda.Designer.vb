<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ayuda
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnInicio = New System.Windows.Forms.Button
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = Global.ISL.Win.My.Resources.Resources.Siguiente
        Me.btnSiguiente.Location = New System.Drawing.Point(153, 0)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(77, 74)
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = "Avanzar"
        Me.ToolTip1.SetToolTip(Me.btnSiguiente, "Muestra la siguiente ayuda")
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Image = Global.ISL.Win.My.Resources.Resources.atras
        Me.btnAnterior.Location = New System.Drawing.Point(78, 0)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(77, 74)
        Me.btnAnterior.TabIndex = 4
        Me.btnAnterior.Text = "Regresar"
        Me.ToolTip1.SetToolTip(Me.btnAnterior, "Muestra la ayuda anterior")
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Image = Global.ISL.Win.My.Resources.Resources.Home
        Me.btnInicio.Location = New System.Drawing.Point(3, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(77, 74)
        Me.btnInicio.TabIndex = 3
        Me.btnInicio.Text = "Inicio"
        Me.ToolTip1.SetToolTip(Me.btnInicio, "Muestra la página principal del sistema de ayudas ISL")
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(776, 97)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(776, 97)
        Me.UltraExpandableGroupBox1.TabIndex = 3
        Me.UltraExpandableGroupBox1.Text = "Opciones de navegación"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnSiguiente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAnterior)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnInicio)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(770, 74)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.WebBrowser1)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 97)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(776, 222)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Información del sistema de ayudas ISL"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(770, 203)
        Me.WebBrowser1.TabIndex = 2
        '
        'frm_Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(776, 319)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Name = "frm_Ayuda"
        Me.Text = "Ayuda del Sistema"
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
