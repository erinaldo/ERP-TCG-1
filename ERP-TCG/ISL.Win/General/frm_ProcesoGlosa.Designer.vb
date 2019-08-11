<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProcesoGlosa
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ProcesoGlosa))
        Me.agrListaGlosa = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaGlosa = New ISL.Controles.Grilla(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.cboProcesoNegocio = New ISL.Controles.ComboMaestros(Me.components)
        Me.mcDetalles = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiAgregar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiQuitar = New System.Windows.Forms.ToolStripMenuItem
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        CType(Me.agrListaGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaGlosa.SuspendLayout()
        CType(Me.griListaGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.cboProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'agrListaGlosa
        '
        Me.agrListaGlosa.Controls.Add(Me.griListaGlosa)
        Me.agrListaGlosa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaGlosa.ForeColor = System.Drawing.Color.Black
        Me.agrListaGlosa.Location = New System.Drawing.Point(0, 58)
        Me.agrListaGlosa.Name = "agrListaGlosa"
        Me.agrListaGlosa.Size = New System.Drawing.Size(840, 374)
        Me.agrListaGlosa.TabIndex = 2
        Me.agrListaGlosa.Text = "Glosas"
        Me.agrListaGlosa.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaGlosa
        '
        Me.griListaGlosa.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaGlosa.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGlosa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGlosa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaGlosa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaGlosa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaGlosa.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaGlosa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaGlosa.Location = New System.Drawing.Point(2, 18)
        Me.griListaGlosa.Name = "griListaGlosa"
        Me.griListaGlosa.Size = New System.Drawing.Size(836, 354)
        Me.griListaGlosa.TabIndex = 0
        Me.griListaGlosa.Text = "Listado de Glosas"
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.UltraLabel22)
        Me.agrProcesoNegocio.Controls.Add(Me.cboProcesoNegocio)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.Black
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(840, 58)
        Me.agrProcesoNegocio.TabIndex = 1
        Me.agrProcesoNegocio.Text = "Proceso Negocio"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraLabel22
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance3
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(45, 30)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel22.TabIndex = 4
        Me.UltraLabel22.Text = "Proceso:"
        '
        'cboProcesoNegocio
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboProcesoNegocio.Appearance = Appearance2
        Me.cboProcesoNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProcesoNegocio.DisplayMember = "Nombre"
        Me.cboProcesoNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcesoNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboProcesoNegocio.Location = New System.Drawing.Point(111, 27)
        Me.cboProcesoNegocio.Name = "cboProcesoNegocio"
        Me.cboProcesoNegocio.Size = New System.Drawing.Size(346, 21)
        Me.cboProcesoNegocio.TabIndex = 0
        Me.cboProcesoNegocio.ValueMember = "Id"
        '
        'mcDetalles
        '
        Me.mcDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalles.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mcDetalles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAgregar, Me.tsmiQuitar})
        Me.mcDetalles.Name = "MenuContextual1"
        Me.mcDetalles.Size = New System.Drawing.Size(112, 48)
        '
        'tsmiAgregar
        '
        Me.tsmiAgregar.Image = CType(resources.GetObject("tsmiAgregar.Image"), System.Drawing.Image)
        Me.tsmiAgregar.Name = "tsmiAgregar"
        Me.tsmiAgregar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiAgregar.Text = "Agregar"
        '
        'tsmiQuitar
        '
        Me.tsmiQuitar.Image = CType(resources.GetObject("tsmiQuitar.Image"), System.Drawing.Image)
        Me.tsmiQuitar.Name = "tsmiQuitar"
        Me.tsmiQuitar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiQuitar.Text = "Quitar"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_ProcesoGlosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 432)
        Me.Controls.Add(Me.agrListaGlosa)
        Me.Controls.Add(Me.agrProcesoNegocio)
        Me.Name = "frm_ProcesoGlosa"
        Me.Text = "Proceso Glosa"
        CType(Me.agrListaGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaGlosa.ResumeLayout(False)
        CType(Me.griListaGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.cboProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents griListaGlosa As ISL.Controles.Grilla
    Friend WithEvents cboProcesoNegocio As ISL.Controles.ComboMaestros
    Friend WithEvents agrListaGlosa As ISL.Controles.Agrupacion
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents mcDetalles As ISL.Controles.MenuContextual
    Friend WithEvents tsmiAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiQuitar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
