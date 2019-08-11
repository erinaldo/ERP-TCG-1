<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteUsuario
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
        Me.components = New System.ComponentModel.Container
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.Ccpp1 = New ISL.Win.CCPP
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.Boton1)
        Me.agrFiltro.Controls.Add(Me.Ccpp1)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1001, 235)
        Me.agrFiltro.TabIndex = 0
        Me.agrFiltro.Text = "Datos de Busqueda:"
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Boton1
        '
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.Location = New System.Drawing.Point(352, 193)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(90, 25)
        Me.Boton1.TabIndex = 1
        Me.Boton1.Text = "Boton1"
        '
        'Ccpp1
        '
        Me.Ccpp1.Id = Nothing
        Me.Ccpp1.Location = New System.Drawing.Point(83, 57)
        Me.Ccpp1.Name = "Ccpp1"
        Me.Ccpp1.Size = New System.Drawing.Size(359, 118)
        Me.Ccpp1.TabIndex = 0
        '
        'frm_ReporteUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 452)
        Me.Controls.Add(Me.agrFiltro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteUsuario"
        Me.Text = "Reporte de Ingreso de Usuario"
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents Ccpp1 As ISL.Win.CCPP
    Friend WithEvents Boton1 As ISL.Controles.Boton
End Class
