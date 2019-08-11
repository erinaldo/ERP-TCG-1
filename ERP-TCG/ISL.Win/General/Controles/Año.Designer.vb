<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Año
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numAño
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance1
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.numAño, "Seleccione y/o especifique el año ")
        Me.numAño.Value = 2011
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'Año
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.numAño)
        Me.Name = "Año"
        Me.Size = New System.Drawing.Size(54, 23)
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
