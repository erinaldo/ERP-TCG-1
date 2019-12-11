<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ActualizarAlmacen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_MaterialAlmacen", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAdm")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMaximo")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMinimo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdZona")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griAlmMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.num_Cantidad = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAceptar = New Infragistics.Win.Misc.UltraButton()
        Me.txtMaterial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCodigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.EMaterialAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griAlmMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.num_Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMaterialAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griAlmMaterial)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 45)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(947, 405)
        Me.UltraGroupBox2.TabIndex = 3
        Me.UltraGroupBox2.Text = "Almacenes"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griAlmMaterial
        '
        Me.griAlmMaterial.DataSource = Me.EMaterialAlmacenBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAlmMaterial.DisplayLayout.Appearance = Appearance1
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.Hidden = True
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn1.CellAppearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 3
        UltraGridColumn1.MaskInput = "{double:9.4}"
        UltraGridColumn1.Width = 109
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Hidden = True
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance3
        UltraGridColumn42.Header.VisiblePosition = 9
        UltraGridColumn42.MaskInput = "{double:9.4}"
        UltraGridColumn42.Width = 113
        UltraGridColumn41.Header.VisiblePosition = 18
        UltraGridColumn41.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 16
        UltraGridColumn40.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 12
        UltraGridColumn33.Hidden = True
        UltraGridColumn36.Header.Caption = "SubAlmacen"
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridColumn36.Width = 173
        UltraGridColumn35.Header.Caption = "Lote"
        UltraGridColumn35.Header.VisiblePosition = 1
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.Width = 190
        UltraGridColumn2.Header.VisiblePosition = 10
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 243
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Width = 257
        UltraGridColumn3.Header.VisiblePosition = 13
        UltraGridColumn3.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 14
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 15
        UltraGridColumn6.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 17
        UltraGridColumn8.Hidden = True
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance4
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn9.MaskInput = "{double:9.4}"
        UltraGridColumn9.Width = 114
        UltraGridColumn48.Header.VisiblePosition = 19
        UltraGridColumn48.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn1, UltraGridColumn4, UltraGridColumn42, UltraGridColumn41, UltraGridColumn40, UltraGridColumn7, UltraGridColumn33, UltraGridColumn36, UltraGridColumn35, UltraGridColumn2, UltraGridColumn15, UltraGridColumn16, UltraGridColumn3, UltraGridColumn5, UltraGridColumn6, UltraGridColumn8, UltraGridColumn9, UltraGridColumn48})
        Me.griAlmMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griAlmMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.griAlmMaterial.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.griAlmMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.griAlmMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAlmMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmMaterial.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAlmMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.griAlmMaterial.DisplayLayout.Override.RowAppearance = Appearance8
        Me.griAlmMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlmMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmMaterial.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAlmMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAlmMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAlmMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlmMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmMaterial.Location = New System.Drawing.Point(3, 17)
        Me.griAlmMaterial.Name = "griAlmMaterial"
        Me.griAlmMaterial.Size = New System.Drawing.Size(941, 385)
        Me.griAlmMaterial.TabIndex = 1
        Me.griAlmMaterial.Text = "Grilla2"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.num_Cantidad)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.btnCancelar)
        Me.UltraGroupBox1.Controls.Add(Me.btnAceptar)
        Me.UltraGroupBox1.Controls.Add(Me.txtMaterial)
        Me.UltraGroupBox1.Controls.Add(Me.txtCodigo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(947, 45)
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'num_Cantidad
        '
        Me.num_Cantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.num_Cantidad.Location = New System.Drawing.Point(621, 12)
        Me.num_Cantidad.MaskInput = "{double:9.3}"
        Me.num_Cantidad.Name = "num_Cantidad"
        Me.num_Cantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.num_Cantidad.ReadOnly = True
        Me.num_Cantidad.Size = New System.Drawing.Size(100, 22)
        Me.num_Cantidad.TabIndex = 333
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(563, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel1.TabIndex = 332
        Me.UltraLabel1.Text = "Cantidad:"
        '
        'btnCancelar
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.btnCancelar.Appearance = Appearance10
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(821, 11)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 26)
        Me.btnCancelar.TabIndex = 331
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAceptar
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAceptar.Appearance = Appearance11
        Me.btnAceptar.Location = New System.Drawing.Point(727, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 26)
        Me.btnAceptar.TabIndex = 330
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtMaterial
        '
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Location = New System.Drawing.Point(160, 12)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(397, 22)
        Me.txtMaterial.TabIndex = 329
        '
        'txtCodigo
        '
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Location = New System.Drawing.Point(66, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(88, 22)
        Me.txtCodigo.TabIndex = 328
        '
        'UltraLabel17
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance12
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(12, 16)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel17.TabIndex = 325
        Me.UltraLabel17.Text = "Material:"
        '
        'EMaterialAlmacenBindingSource
        '
        Me.EMaterialAlmacenBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_MaterialAlmacen)
        '
        'frm_ActualizarAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 450)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ActualizarAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Almacen"
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griAlmMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.num_Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMaterialAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griAlmMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents num_Cantidad As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMaterial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents EMaterialAlmacenBindingSource As BindingSource
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
