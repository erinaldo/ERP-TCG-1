<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DetalleCajaExterna
    Inherits System.Windows.Forms.Form

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Datos = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPreEnviado = New ISL.Controles.Colores(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalle = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.MenuContextual1.SuspendLayout()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Datos.SuspendLayout()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPreEnviado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(114, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem1.Text = "Exportar"
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.Etiqueta2)
        Me.Datos.Controls.Add(Me.Colores1)
        Me.Datos.Controls.Add(Me.Etiqueta1)
        Me.Datos.Controls.Add(Me.ColorPreEnviado)
        Me.Datos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datos.ForeColor = System.Drawing.Color.Black
        Me.Datos.Location = New System.Drawing.Point(0, 0)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(977, 62)
        Me.Datos.TabIndex = 1
        Me.Datos.Text = "Datos"
        Me.Datos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.Datos.Visible = False
        '
        'Etiqueta2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance1
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(146, 30)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta2.TabIndex = 106
        Me.Etiqueta2.Text = "Egresos"
        Me.Etiqueta2.Visible = False
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.LimeGreen
        Me.Colores1.Location = New System.Drawing.Point(196, 28)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.ReadOnly = True
        Me.Colores1.Size = New System.Drawing.Size(43, 21)
        Me.Colores1.TabIndex = 105
        Me.Colores1.Text = "LimeGreen"
        Me.Colores1.Visible = False
        '
        'Etiqueta1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance2
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(12, 30)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta1.TabIndex = 104
        Me.Etiqueta1.Text = "PreEnviado"
        '
        'ColorPreEnviado
        '
        Me.ColorPreEnviado.Color = System.Drawing.Color.LightSkyBlue
        Me.ColorPreEnviado.Location = New System.Drawing.Point(79, 28)
        Me.ColorPreEnviado.Name = "ColorPreEnviado"
        Me.ColorPreEnviado.ReadOnly = True
        Me.ColorPreEnviado.Size = New System.Drawing.Size(43, 21)
        Me.ColorPreEnviado.TabIndex = 103
        Me.ColorPreEnviado.Text = "LightSkyBlue"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griDetalle)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 62)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(977, 384)
        Me.Agrupacion2.TabIndex = 2
        Me.Agrupacion2.Text = "Detalle"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalle
        '
        Me.griDetalle.ContextMenuStrip = Me.MenuContextual1
        Me.griDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalle.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalle.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalle.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalle.DisplayLayout.UseFixedHeaders = True
        Me.griDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalle.Location = New System.Drawing.Point(3, 16)
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(971, 365)
        Me.griDetalle.TabIndex = 71
        Me.griDetalle.Tag = ""
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_DetalleCajaExterna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 446)
        Me.Controls.Add(Me.Agrupacion2)
        Me.Controls.Add(Me.Datos)
        Me.Name = "frm_DetalleCajaExterna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DetalleCajaExterna"
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPreEnviado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Datos As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griDetalle As ISL.Controles.Grilla
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPreEnviado As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
