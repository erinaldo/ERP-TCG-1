<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImprimirValeCombustible
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
        Me.components = New System.ComponentModel.Container
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnImprimir = New ISL.Controles.Boton(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.lsb_Impresora = New System.Windows.Forms.ListBox
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.lsb_Impresora)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(4, 12)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(398, 146)
        Me.Agrupacion1.TabIndex = 308
        Me.Agrupacion1.Text = "Seleccione Impresora:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Location = New System.Drawing.Point(216, 164)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(90, 25)
        Me.btnImprimir.TabIndex = 309
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(312, 164)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 310
        Me.btnCancelar.Text = "Cancelar"
        '
        'lsb_Impresora
        '
        Me.lsb_Impresora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsb_Impresora.FormattingEnabled = True
        Me.lsb_Impresora.Location = New System.Drawing.Point(2, 18)
        Me.lsb_Impresora.Name = "lsb_Impresora"
        Me.lsb_Impresora.Size = New System.Drawing.Size(394, 121)
        Me.lsb_Impresora.TabIndex = 2
        '
        'frm_ImprimirValeCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 197)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_ImprimirValeCombustible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Vale de Combustible"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnImprimir As ISL.Controles.Boton
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents lsb_Impresora As System.Windows.Forms.ListBox
End Class
