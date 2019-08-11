<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DatosMaestros
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nro")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tabla")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Archivo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(0)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1363)
        Dim ColScrollRegion3 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-664)
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nro")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tabla")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Archivo")
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.gridTablasMaestras = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.btn_Recarga = New ISL.Controles.Boton(Me.components)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.gridTablasMaestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.btn_Recarga)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(715, 43)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'gridTablasMaestras
        '
        Me.gridTablasMaestras.DataSource = Me.UltraDataSource1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 67
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 234
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 297
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.gridTablasMaestras.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridTablasMaestras.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.gridTablasMaestras.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.gridTablasMaestras.DisplayLayout.ColScrollRegions.Add(ColScrollRegion3)
        Me.gridTablasMaestras.DisplayLayout.MaxColScrollRegions = 1
        Me.gridTablasMaestras.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridTablasMaestras.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridTablasMaestras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridTablasMaestras.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridTablasMaestras.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridTablasMaestras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridTablasMaestras.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridTablasMaestras.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridTablasMaestras.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridTablasMaestras.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridTablasMaestras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTablasMaestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridTablasMaestras.Location = New System.Drawing.Point(0, 43)
        Me.gridTablasMaestras.Name = "gridTablasMaestras"
        Me.gridTablasMaestras.Size = New System.Drawing.Size(715, 407)
        Me.gridTablasMaestras.TabIndex = 8
        Me.gridTablasMaestras.Text = "Documentos"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object(-1) {})})
        '
        'btn_Recarga
        '
        Me.btn_Recarga.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_Recarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Recarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Recarga.ForeColor = System.Drawing.Color.Black
        Me.btn_Recarga.Location = New System.Drawing.Point(12, 9)
        Me.btn_Recarga.Name = "btn_Recarga"
        Me.btn_Recarga.Size = New System.Drawing.Size(170, 25)
        Me.btn_Recarga.TabIndex = 0
        Me.btn_Recarga.Text = "Recargar Maestras"
        '
        'frm_DatosMaestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(715, 450)
        Me.Controls.Add(Me.gridTablasMaestras)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_DatosMaestros"
        Me.Text = "Datos Maestros"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.gridTablasMaestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents gridTablasMaestras As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btn_Recarga As ISL.Controles.Boton

End Class
