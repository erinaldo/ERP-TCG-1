<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TipoObligacion
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
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrListaAreas = New ISL.Controles.Agrupacion(Me.components)
        Me.griArea = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrArea = New ISL.Controles.Agrupacion(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.ficArea = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrListaAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaAreas.SuspendLayout()
        CType(Me.griArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrArea.SuspendLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrListaAreas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(728, 430)
        '
        'agrListaAreas
        '
        Me.agrListaAreas.Controls.Add(Me.griArea)
        Me.agrListaAreas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaAreas.ForeColor = System.Drawing.Color.Black
        Me.agrListaAreas.Location = New System.Drawing.Point(0, 0)
        Me.agrListaAreas.Name = "agrListaAreas"
        Me.agrListaAreas.Size = New System.Drawing.Size(728, 430)
        Me.agrListaAreas.TabIndex = 1
        Me.agrListaAreas.Text = "Lista de áreas"
        Me.agrListaAreas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griArea
        '
        Me.griArea.DataSource = Me.UltraDataSource1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 371
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griArea.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griArea.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griArea.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griArea.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griArea.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griArea.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griArea.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griArea.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griArea.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griArea.Location = New System.Drawing.Point(2, 18)
        Me.griArea.Name = "griArea"
        Me.griArea.Size = New System.Drawing.Size(724, 410)
        Me.griArea.TabIndex = 1
        Me.griArea.Text = "Información De Tipos De Obligación"
        '
        'UltraDataSource1
        '
        UltraDataColumn4.DataType = GetType(Byte)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrArea)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(911, 452)
        '
        'agrArea
        '
        Me.agrArea.Controls.Add(Me.verActivo)
        Me.agrArea.Controls.Add(Me.txtNombre)
        Me.agrArea.Controls.Add(Me.txtCodigo)
        Me.agrArea.Controls.Add(Me.etiNombre)
        Me.agrArea.Controls.Add(Me.etiCodigo)
        Me.agrArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrArea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrArea.Location = New System.Drawing.Point(0, 0)
        Me.agrArea.Name = "agrArea"
        Me.agrArea.Size = New System.Drawing.Size(911, 126)
        Me.agrArea.TabIndex = 1
        Me.agrArea.Text = "Datos:"
        Me.agrArea.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(107, 92)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 6
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(107, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(349, 21)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodigo
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance4
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(107, 38)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 3
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(55, 69)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 1
        Me.etiNombre.Text = "Nombre:"
        '
        'etiCodigo
        '
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(59, 42)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 0
        Me.etiCodigo.Text = "Código:"
        '
        'ficArea
        '
        Me.ficArea.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficArea.Controls.Add(Me.UltraTabPageControl1)
        Me.ficArea.Controls.Add(Me.UltraTabPageControl2)
        Me.ficArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficArea.Location = New System.Drawing.Point(0, 0)
        Me.ficArea.Name = "ficArea"
        Me.ficArea.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficArea.Size = New System.Drawing.Size(730, 453)
        Me.ficArea.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficArea.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficArea.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(728, 430)
        '
        'Frm_TipoObligacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 453)
        Me.Controls.Add(Me.ficArea)
        Me.Name = "Frm_TipoObligacion"
        Me.Text = "Tipo De Obligación"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrListaAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaAreas.ResumeLayout(False)
        CType(Me.griArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrArea.ResumeLayout(False)
        Me.agrArea.PerformLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficArea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficArea As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaAreas As ISL.Controles.Agrupacion
    Friend WithEvents griArea As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrArea As ISL.Controles.Agrupacion
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
