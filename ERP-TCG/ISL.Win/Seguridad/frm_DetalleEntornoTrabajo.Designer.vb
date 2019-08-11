<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DetalleEntornoTrabajo
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Me.agrDetalleEntorno = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleEntorno = New ISL.Controles.Grilla(Me.components)
        Me.ordDetalleEntorno = New ISL.Controles.OrigenDatos(Me.components)
        CType(Me.agrDetalleEntorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalleEntorno.SuspendLayout()
        CType(Me.griDetalleEntorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordDetalleEntorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agrDetalleEntorno
        '
        Me.agrDetalleEntorno.Controls.Add(Me.griDetalleEntorno)
        Me.agrDetalleEntorno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalleEntorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalleEntorno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrDetalleEntorno.Location = New System.Drawing.Point(0, 0)
        Me.agrDetalleEntorno.Name = "agrDetalleEntorno"
        Me.agrDetalleEntorno.Size = New System.Drawing.Size(525, 341)
        Me.agrDetalleEntorno.TabIndex = 0
        Me.agrDetalleEntorno.Text = "Datos:"
        Me.agrDetalleEntorno.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDetalleEntorno
        '
        Me.griDetalleEntorno.DataSource = Me.ordDetalleEntorno
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 64
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 364
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.griDetalleEntorno.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDetalleEntorno.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleEntorno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleEntorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleEntorno.Location = New System.Drawing.Point(2, 18)
        Me.griDetalleEntorno.Name = "griDetalleEntorno"
        Me.griDetalleEntorno.Size = New System.Drawing.Size(521, 321)
        Me.griDetalleEntorno.TabIndex = 0
        Me.griDetalleEntorno.Text = "Detalles del entorno de trabajo"
        '
        'ordDetalleEntorno
        '
        Me.ordDetalleEntorno.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'frm_DetalleEntornoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 341)
        Me.Controls.Add(Me.agrDetalleEntorno)
        Me.Name = "frm_DetalleEntornoTrabajo"
        Me.Text = "Detalle Entorno Trabajo"
        CType(Me.agrDetalleEntorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalleEntorno.ResumeLayout(False)
        CType(Me.griDetalleEntorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordDetalleEntorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDetalleEntorno As ISL.Controles.Agrupacion
    Friend WithEvents griDetalleEntorno As ISL.Controles.Grilla
    Friend WithEvents ordDetalleEntorno As ISL.Controles.OrigenDatos
End Class
