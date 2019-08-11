<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CaracteristicaEspecial
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrLista = New ISL.Controles.Agrupacion(Me.components)
        Me.griCaracteristicaEspecial = New ISL.Controles.Grilla(Me.components)
        Me.odCaracteristicaEspecial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrMantenimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficCaracteristicaEspecial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLista.SuspendLayout()
        CType(Me.griCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMantenimiento.SuspendLayout()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCaracteristicaEspecial.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrLista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(586, 352)
        '
        'agrLista
        '
        Me.agrLista.Controls.Add(Me.griCaracteristicaEspecial)
        Me.agrLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrLista.Location = New System.Drawing.Point(0, 0)
        Me.agrLista.Name = "agrLista"
        Me.agrLista.Size = New System.Drawing.Size(586, 352)
        Me.agrLista.TabIndex = 0
        Me.agrLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griCaracteristicaEspecial
        '
        Me.griCaracteristicaEspecial.DataSource = Me.odCaracteristicaEspecial
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 350
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 105
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.griCaracteristicaEspecial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griCaracteristicaEspecial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCaracteristicaEspecial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCaracteristicaEspecial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCaracteristicaEspecial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCaracteristicaEspecial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCaracteristicaEspecial.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.griCaracteristicaEspecial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCaracteristicaEspecial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCaracteristicaEspecial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCaracteristicaEspecial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griCaracteristicaEspecial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCaracteristicaEspecial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCaracteristicaEspecial.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCaracteristicaEspecial.Location = New System.Drawing.Point(2, 2)
        Me.griCaracteristicaEspecial.Name = "griCaracteristicaEspecial"
        Me.griCaracteristicaEspecial.Size = New System.Drawing.Size(582, 348)
        Me.griCaracteristicaEspecial.TabIndex = 0
        Me.griCaracteristicaEspecial.Text = "Listado de Caracteristicas Especiales"
        '
        'odCaracteristicaEspecial
        '
        UltraDataColumn4.DataType = GetType(Date)
        Me.odCaracteristicaEspecial.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'Filtro
        '
        Me.Filtro.MenuSettings.RightAlignedMenus = True
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrMantenimiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(586, 352)
        '
        'agrMantenimiento
        '
        Me.agrMantenimiento.Controls.Add(Me.txtAbreviatura)
        Me.agrMantenimiento.Controls.Add(Me.txtNombre)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta3)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta2)
        Me.agrMantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMantenimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.agrMantenimiento.Name = "agrMantenimiento"
        Me.agrMantenimiento.Size = New System.Drawing.Size(586, 111)
        Me.agrMantenimiento.TabIndex = 0
        Me.agrMantenimiento.Text = "Dato"
        Me.agrMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtAbreviatura
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance1
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtAbreviatura.Location = New System.Drawing.Point(86, 56)
        Me.txtAbreviatura.MaxLength = 10
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(90, 22)
        Me.txtAbreviatura.TabIndex = 3
        '
        'txtNombre
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance2
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtNombre.Location = New System.Drawing.Point(86, 28)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(339, 22)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Tag = "0"
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta3.Location = New System.Drawing.Point(16, 60)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Abreviatura:"
        '
        'Etiqueta2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance4
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(34, 32)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Nombre:"
        '
        'ficCaracteristicaEspecial
        '
        Me.ficCaracteristicaEspecial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCaracteristicaEspecial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficCaracteristicaEspecial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficCaracteristicaEspecial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCaracteristicaEspecial.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCaracteristicaEspecial.Location = New System.Drawing.Point(0, 0)
        Me.ficCaracteristicaEspecial.Name = "ficCaracteristicaEspecial"
        Me.ficCaracteristicaEspecial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCaracteristicaEspecial.Size = New System.Drawing.Size(588, 375)
        Me.ficCaracteristicaEspecial.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficCaracteristicaEspecial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCaracteristicaEspecial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(586, 352)
        '
        'frm_CaracteristicaEspecial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 375)
        Me.Controls.Add(Me.ficCaracteristicaEspecial)
        Me.Name = "frm_CaracteristicaEspecial"
        Me.Text = "Caracteristicas Especiales"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLista.ResumeLayout(False)
        CType(Me.griCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMantenimiento.ResumeLayout(False)
        Me.agrMantenimiento.PerformLayout()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCaracteristicaEspecial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCaracteristicaEspecial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrLista As ISL.Controles.Agrupacion
    Friend WithEvents griCaracteristicaEspecial As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMantenimiento As ISL.Controles.Agrupacion
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents odCaracteristicaEspecial As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro As ISL.Controles.Filtro
End Class
