<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DetalleGrupos
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grupoEstado = New ISL.Controles.Agrupacion(Me.components)
        Me.Grilla2 = New ISL.Controles.Grilla(Me.components)
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.UltraCombo2 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.Exportar = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoEstado.SuspendLayout()
        CType(Me.Grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.UltraCombo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoEstado
        '
        Appearance71.BackColor = System.Drawing.Color.White
        Appearance71.BackColor2 = System.Drawing.Color.White
        Me.grupoEstado.ContentAreaAppearance = Appearance71
        Me.grupoEstado.Controls.Add(Me.Grilla2)
        Me.grupoEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoEstado.Location = New System.Drawing.Point(0, 0)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(1142, 518)
        Me.grupoEstado.TabIndex = 300
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Grilla2
        '
        Me.Grilla2.ContextMenuStrip = Me.MenuContextual1
        Me.Grilla2.DisplayLayout.MaxColScrollRegions = 1
        Me.Grilla2.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.Grilla2.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla2.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grilla2.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grilla2.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grilla2.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.Grilla2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grilla2.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grilla2.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Grilla2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grilla2.DisplayLayout.UseFixedHeaders = True
        Me.Grilla2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla2.Location = New System.Drawing.Point(3, 0)
        Me.Grilla2.Name = "Grilla2"
        Me.Grilla2.Size = New System.Drawing.Size(1136, 515)
        Me.Grilla2.TabIndex = 69
        Me.Grilla2.Tag = ""
        '
        'UltraLabel24
        '
        Appearance181.BackColor = System.Drawing.Color.Transparent
        Appearance181.ForeColor = System.Drawing.Color.Navy
        Appearance181.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance181
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(2, 13)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel24.TabIndex = 306
        Me.UltraLabel24.Text = "Material:"
        '
        'UltraButton1
        '
        Appearance180.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Appearance180.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance180.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.UltraButton1.Appearance = Appearance180
        Me.UltraButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.UltraButton1.Location = New System.Drawing.Point(409, 4)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(45, 30)
        Me.UltraButton1.TabIndex = 283
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraButton1)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraCombo2)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel24)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(1103, 77)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel4.Visible = False
        '
        'UltraCombo2
        '
        Me.UltraCombo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraCombo2.CheckedListSettings.CheckStateMember = ""
        Me.UltraCombo2.DisplayMember = "Nombre"
        Me.UltraCombo2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraCombo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraCombo2.Location = New System.Drawing.Point(53, 8)
        Me.UltraCombo2.Name = "UltraCombo2"
        Me.UltraCombo2.Size = New System.Drawing.Size(350, 22)
        Me.UltraCombo2.TabIndex = 305
        Me.UltraCombo2.ValueMember = "Id"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Exportar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(153, 48)
        '
        'Exportar
        '
        Me.Exportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(152, 22)
        Me.Exportar.Text = "Exportar"
        '
        'frm_DetalleGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 518)
        Me.Controls.Add(Me.grupoEstado)
        Me.Name = "frm_DetalleGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Grupo"
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoEstado.ResumeLayout(False)
        CType(Me.Grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.UltraCombo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoEstado As ISL.Controles.Agrupacion
    Friend WithEvents Grilla2 As ISL.Controles.Grilla
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraCombo2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents Exportar As System.Windows.Forms.ToolStripMenuItem
End Class
