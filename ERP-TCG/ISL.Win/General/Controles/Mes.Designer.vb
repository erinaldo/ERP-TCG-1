<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mes
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
        Me.numMes = New ISL.Controles.NumeroEntero(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numMes
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.numMes.Appearance = Appearance1
        Me.numMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMes.ForeColor = System.Drawing.Color.Black
        Me.numMes.Location = New System.Drawing.Point(0, 0)
        Me.numMes.MaskInput = "nn"
        Me.numMes.MaxValue = 12
        Me.numMes.MinValue = 1
        Me.numMes.Name = "numMes"
        Me.numMes.Size = New System.Drawing.Size(40, 21)
        Me.numMes.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numMes.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.numMes, "Seleccione y/o especifique el mes")
        Me.numMes.Value = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'Mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.numMes)
        Me.Name = "Mes"
        Me.Size = New System.Drawing.Size(41, 23)
        CType(Me.numMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numMes As ISL.Controles.NumeroEntero
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
