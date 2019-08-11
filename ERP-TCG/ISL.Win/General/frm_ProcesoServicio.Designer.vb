<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProcesoServicio
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proceso")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProcesoNegocio")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proceso")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProcesoNegocio")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proceso")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProcesoNegocio")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griProcesoServicio = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.odProcesoServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrListaProcesosExistentes = New ISL.Controles.Agrupacion(Me.components)
        Me.griProcesosVinculados = New ISL.Controles.Grilla(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.cboServicio = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboProceso = New ISL.Controles.ComboMaestros(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.ficConceptosGenerales = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griProcesoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odProcesoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrListaProcesosExistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaProcesosExistentes.SuspendLayout()
        CType(Me.griProcesosVinculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.cboServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficConceptosGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConceptosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griProcesoServicio)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(929, 482)
        '
        'griProcesoServicio
        '
        Me.griProcesoServicio.ContextMenuStrip = Me.MenuContextual1
        Me.griProcesoServicio.DataSource = Me.odProcesoServicio
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 190
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 750
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.griProcesoServicio.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griProcesoServicio.DisplayLayout.MaxColScrollRegions = 1
        Me.griProcesoServicio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProcesoServicio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griProcesoServicio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griProcesoServicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProcesoServicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProcesoServicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProcesoServicio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProcesoServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProcesoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProcesoServicio.Location = New System.Drawing.Point(0, 0)
        Me.griProcesoServicio.Name = "griProcesoServicio"
        Me.griProcesoServicio.Size = New System.Drawing.Size(929, 482)
        Me.griProcesoServicio.TabIndex = 5
        Me.griProcesoServicio.Text = "Información de Servicios Asociados a Procesos"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Proceso de Negocio"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Proceso de Negocio seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Proceso de Negocio seleccionado"
        '
        'odProcesoServicio
        '
        Me.odProcesoServicio.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrListaProcesosExistentes)
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(929, 482)
        '
        'agrListaProcesosExistentes
        '
        Me.agrListaProcesosExistentes.Controls.Add(Me.griProcesosVinculados)
        Me.agrListaProcesosExistentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaProcesosExistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaProcesosExistentes.ForeColor = System.Drawing.Color.Black
        Me.agrListaProcesosExistentes.Location = New System.Drawing.Point(0, 130)
        Me.agrListaProcesosExistentes.Name = "agrListaProcesosExistentes"
        Me.agrListaProcesosExistentes.Size = New System.Drawing.Size(929, 352)
        Me.agrListaProcesosExistentes.TabIndex = 1
        Me.agrListaProcesosExistentes.Text = " "
        Me.agrListaProcesosExistentes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griProcesosVinculados
        '
        Me.griProcesosVinculados.ContextMenuStrip = Me.MenuContextual1
        Me.griProcesosVinculados.DataSource = Me.odProcesoServicio
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Width = 190
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Width = 750
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.griProcesosVinculados.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griProcesosVinculados.DisplayLayout.MaxColScrollRegions = 1
        Me.griProcesosVinculados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProcesosVinculados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griProcesosVinculados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griProcesosVinculados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProcesosVinculados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProcesosVinculados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProcesosVinculados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProcesosVinculados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProcesosVinculados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProcesosVinculados.Location = New System.Drawing.Point(2, 18)
        Me.griProcesosVinculados.Name = "griProcesosVinculados"
        Me.griProcesosVinculados.Size = New System.Drawing.Size(925, 332)
        Me.griProcesosVinculados.TabIndex = 6
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.cboServicio)
        Me.agrProcesoNegocio.Controls.Add(Me.cboProceso)
        Me.agrProcesoNegocio.Controls.Add(Me.verActivo)
        Me.agrProcesoNegocio.Controls.Add(Me.etiNombre)
        Me.agrProcesoNegocio.Controls.Add(Me.etiCodigo)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(929, 130)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboServicio
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboServicio.Appearance = Appearance2
        Me.cboServicio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboServicio.DisplayMember = "Nombre"
        Me.cboServicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboServicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicio.ForeColor = System.Drawing.Color.Black
        Me.cboServicio.Location = New System.Drawing.Point(153, 64)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(586, 21)
        Me.cboServicio.TabIndex = 11
        Me.cboServicio.ValueMember = "Id"
        '
        'cboProceso
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboProceso.Appearance = Appearance1
        Me.cboProceso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProceso.DisplayMember = "Nombre"
        Me.cboProceso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProceso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProceso.ForeColor = System.Drawing.Color.Black
        Me.cboProceso.Location = New System.Drawing.Point(153, 36)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(351, 21)
        Me.cboProceso.TabIndex = 10
        Me.cboProceso.ValueMember = "Id"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(153, 91)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'etiNombre
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextVAlignAsString = "Middle"
        Me.etiNombre.Appearance = Appearance3
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(99, 68)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(48, 14)
        Me.etiNombre.TabIndex = 3
        Me.etiNombre.Text = "Servicio:"
        '
        'etiCodigo
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextVAlignAsString = "Middle"
        Me.etiCodigo.Appearance = Appearance45
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(98, 40)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(49, 14)
        Me.etiCodigo.TabIndex = 1
        Me.etiCodigo.Text = "Proceso:"
        '
        'ficConceptosGenerales
        '
        Me.ficConceptosGenerales.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficConceptosGenerales.Controls.Add(Me.UltraTabPageControl7)
        Me.ficConceptosGenerales.Controls.Add(Me.utpDetalle)
        Me.ficConceptosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConceptosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficConceptosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.ficConceptosGenerales.Name = "ficConceptosGenerales"
        Me.ficConceptosGenerales.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficConceptosGenerales.Size = New System.Drawing.Size(931, 505)
        Me.ficConceptosGenerales.TabIndex = 7
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficConceptosGenerales.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficConceptosGenerales.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(929, 482)
        '
        'frm_ProcesoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 505)
        Me.Controls.Add(Me.ficConceptosGenerales)
        Me.Name = "frm_ProcesoServicio"
        Me.Text = "Servicios Asociados a Procesos"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griProcesoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odProcesoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrListaProcesosExistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaProcesosExistentes.ResumeLayout(False)
        CType(Me.griProcesosVinculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.cboServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficConceptosGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConceptosGenerales.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odProcesoServicio As ISL.Controles.OrigenDatos
    Friend WithEvents ficConceptosGenerales As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaProcesosExistentes As ISL.Controles.Agrupacion
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents cboServicio As ISL.Controles.ComboMaestros
    Friend WithEvents cboProceso As ISL.Controles.ComboMaestros
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents griProcesoServicio As ISL.Controles.Grilla
    Friend WithEvents griProcesosVinculados As ISL.Controles.Grilla
End Class
