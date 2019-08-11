<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Feriados
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
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoFeriado")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndLaborable")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoFeriado")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoFeriado")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndLaborable")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoFeriado")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Feriados))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griFeriados = New ISL.Controles.Grilla(Me.components)
        Me.odFeriado = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoFeriado = New ISL.Controles.Combo(Me.components)
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.chkIndLaborable = New System.Windows.Forms.CheckBox()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficFeriados = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.btnNuevoFeriado = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odFeriado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.cboTipoFeriado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFeriados.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griFeriados)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(865, 420)
        '
        'griFeriados
        '
        Me.griFeriados.DataSource = Me.odFeriado
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 1
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 4
        UltraGridColumn28.Width = 290
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 8
        UltraGridColumn24.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 5
        UltraGridColumn3.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 6
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 124
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.MaskInput = "{date}"
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn6.Width = 149
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn27, UltraGridColumn28, UltraGridColumn23, UltraGridColumn24, UltraGridColumn3, UltraGridColumn29, UltraGridColumn30, UltraGridColumn6})
        Me.griFeriados.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griFeriados.DisplayLayout.MaxColScrollRegions = 1
        Me.griFeriados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griFeriados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griFeriados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griFeriados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griFeriados.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griFeriados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griFeriados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFeriados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griFeriados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griFeriados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFeriados.Location = New System.Drawing.Point(0, 0)
        Me.griFeriados.Name = "griFeriados"
        Me.griFeriados.Size = New System.Drawing.Size(865, 420)
        Me.griFeriados.TabIndex = 11
        '
        'odFeriado
        '
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn9.DataType = GetType(Date)
        Me.odFeriado.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.btnNuevoFeriado)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpFecha)
        Me.UltraTabPageControl2.Controls.Add(Me.cboTipoFeriado)
        Me.UltraTabPageControl2.Controls.Add(Me.txtDescripcion)
        Me.UltraTabPageControl2.Controls.Add(Me.chkIndLaborable)
        Me.UltraTabPageControl2.Controls.Add(Me.Etiqueta3)
        Me.UltraTabPageControl2.Controls.Add(Me.Etiqueta2)
        Me.UltraTabPageControl2.Controls.Add(Me.Etiqueta1)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(865, 420)
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(98, 17)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(215, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'cboTipoFeriado
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTipoFeriado.Appearance = Appearance2
        Me.cboTipoFeriado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoFeriado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoFeriado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoFeriado.ForeColor = System.Drawing.Color.Black
        Me.cboTipoFeriado.Location = New System.Drawing.Point(98, 51)
        Me.cboTipoFeriado.Name = "cboTipoFeriado"
        Me.cboTipoFeriado.Size = New System.Drawing.Size(215, 21)
        Me.cboTipoFeriado.TabIndex = 10
        Me.cboTipoFeriado.ValueMember = "Id"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(98, 91)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(215, 52)
        Me.txtDescripcion.TabIndex = 11
        '
        'chkIndLaborable
        '
        Me.chkIndLaborable.AutoSize = True
        Me.chkIndLaborable.ForeColor = System.Drawing.Color.Navy
        Me.chkIndLaborable.Location = New System.Drawing.Point(98, 158)
        Me.chkIndLaborable.Name = "chkIndLaborable"
        Me.chkIndLaborable.Size = New System.Drawing.Size(88, 17)
        Me.chkIndLaborable.TabIndex = 12
        Me.chkIndLaborable.Text = "IndLaborable"
        Me.chkIndLaborable.UseVisualStyleBackColor = True
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(27, 94)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta3.TabIndex = 3
        Me.Etiqueta3.Text = "Descripcion:"
        '
        'Etiqueta2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance4
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(23, 55)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Tipo Feriado:"
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(54, 20)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Fecha:"
        '
        'ficFeriados
        '
        Me.ficFeriados.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficFeriados.Controls.Add(Me.UltraTabPageControl1)
        Me.ficFeriados.Controls.Add(Me.UltraTabPageControl2)
        Me.ficFeriados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficFeriados.Location = New System.Drawing.Point(0, 0)
        Me.ficFeriados.Name = "ficFeriados"
        Me.ficFeriados.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficFeriados.Size = New System.Drawing.Size(867, 443)
        Me.ficFeriados.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficFeriados.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficFeriados.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(865, 420)
        '
        'btnNuevoFeriado
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnNuevoFeriado.Appearance = Appearance1
        Me.btnNuevoFeriado.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevoFeriado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoFeriado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoFeriado.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoFeriado.Location = New System.Drawing.Point(319, 47)
        Me.btnNuevoFeriado.Name = "btnNuevoFeriado"
        Me.btnNuevoFeriado.Size = New System.Drawing.Size(25, 25)
        Me.btnNuevoFeriado.TabIndex = 43
        Me.btnNuevoFeriado.TabStop = False
        Me.btnNuevoFeriado.Text = "Reg. Proveedor"
        '
        'frm_Feriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 443)
        Me.Controls.Add(Me.ficFeriados)
        Me.Name = "frm_Feriados"
        Me.Text = "Feriados"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odFeriado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.cboTipoFeriado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFeriados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficFeriados As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griFeriados As ISL.Controles.Grilla
    Friend WithEvents odFeriado As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoFeriado As ISL.Controles.Combo
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents chkIndLaborable As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents btnNuevoFeriado As ISL.Controles.Boton
End Class
