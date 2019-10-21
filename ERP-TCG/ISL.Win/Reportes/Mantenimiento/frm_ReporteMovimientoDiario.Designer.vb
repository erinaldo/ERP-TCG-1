<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteMovimientoDiario
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
        Me.components = New System.ComponentModel.Container
        Me.agrDatosBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.griMovDiarioOT = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBusqueda.SuspendLayout()
        CType(Me.griMovDiarioOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agrDatosBusqueda
        '
        Me.agrDatosBusqueda.Controls.Add(Me.fecPeriodo)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosBusqueda.Name = "agrDatosBusqueda"
        Me.agrDatosBusqueda.Size = New System.Drawing.Size(889, 60)
        Me.agrDatosBusqueda.TabIndex = 0
        Me.agrDatosBusqueda.Text = "Datos de Búsqueda"
        Me.agrDatosBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(62, 28)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.Size = New System.Drawing.Size(134, 20)
        Me.fecPeriodo.TabIndex = 4
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 30)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta1.TabIndex = 3
        Me.Etiqueta1.Text = "Periodo:"
        '
        'griMovDiarioOT
        '
        Me.griMovDiarioOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovDiarioOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovDiarioOT.Location = New System.Drawing.Point(0, 60)
        Me.griMovDiarioOT.Name = "griMovDiarioOT"
        Me.griMovDiarioOT.Size = New System.Drawing.Size(889, 423)
        Me.griMovDiarioOT.TabIndex = 1
        Me.griMovDiarioOT.Text = "Grilla1"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_ReporteMovimientoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 483)
        Me.Controls.Add(Me.griMovDiarioOT)
        Me.Controls.Add(Me.agrDatosBusqueda)
        Me.Name = "frm_ReporteMovimientoDiario"
        Me.Text = "Movimiento Diario"
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBusqueda.ResumeLayout(False)
        Me.agrDatosBusqueda.PerformLayout()
        CType(Me.griMovDiarioOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatosBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents griMovDiarioOT As ISL.Controles.Grilla
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
