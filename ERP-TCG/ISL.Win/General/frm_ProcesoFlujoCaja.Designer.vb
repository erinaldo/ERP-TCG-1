<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProcesoFlujoCaja
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrProcesoFuljoCaja = New ISL.Controles.Agrupacion(Me.components)
        Me.griProcesoFlujo = New ISL.Controles.Grilla(Me.components)
        Me.expFlujoCaja = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griFlujoCaja = New ISL.Controles.Grilla(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.cboProcesoNegocio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficProcesoNegocio = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrProcesoFuljoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoFuljoCaja.SuspendLayout()
        CType(Me.griProcesoFlujo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expFlujoCaja.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.cboProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficProcesoNegocio.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrProcesoFuljoCaja)
        Me.UltraTabPageControl7.Controls.Add(Me.agrProcesoNegocio)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1005, 445)
        '
        'agrProcesoFuljoCaja
        '
        Me.agrProcesoFuljoCaja.Controls.Add(Me.griProcesoFlujo)
        Me.agrProcesoFuljoCaja.Controls.Add(Me.expFlujoCaja)
        Me.agrProcesoFuljoCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrProcesoFuljoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoFuljoCaja.ForeColor = System.Drawing.Color.Black
        Me.agrProcesoFuljoCaja.Location = New System.Drawing.Point(0, 82)
        Me.agrProcesoFuljoCaja.Name = "agrProcesoFuljoCaja"
        Me.agrProcesoFuljoCaja.Size = New System.Drawing.Size(1005, 363)
        Me.agrProcesoFuljoCaja.TabIndex = 3
        Me.agrProcesoFuljoCaja.Text = "Flujo de Caja"
        Me.agrProcesoFuljoCaja.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griProcesoFlujo
        '
        Me.griProcesoFlujo.DisplayLayout.MaxColScrollRegions = 1
        Me.griProcesoFlujo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProcesoFlujo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griProcesoFlujo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProcesoFlujo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProcesoFlujo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProcesoFlujo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProcesoFlujo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProcesoFlujo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griProcesoFlujo.Location = New System.Drawing.Point(3, 16)
        Me.griProcesoFlujo.Name = "griProcesoFlujo"
        Me.griProcesoFlujo.Size = New System.Drawing.Size(977, 344)
        Me.griProcesoFlujo.TabIndex = 2
        Me.griProcesoFlujo.Text = "Flujos de Caja Asociados "
        '
        'expFlujoCaja
        '
        Me.expFlujoCaja.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.expFlujoCaja.Dock = System.Windows.Forms.DockStyle.Right
        Me.expFlujoCaja.Enabled = False
        Me.expFlujoCaja.Expanded = False
        Me.expFlujoCaja.ExpandedSize = New System.Drawing.Size(502, 344)
        Me.expFlujoCaja.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOnBorder
        Me.expFlujoCaja.Location = New System.Drawing.Point(980, 16)
        Me.expFlujoCaja.Name = "expFlujoCaja"
        Me.expFlujoCaja.Size = New System.Drawing.Size(22, 344)
        Me.expFlujoCaja.TabIndex = 0
        Me.expFlujoCaja.Text = "Flujos de Caja"
        Me.expFlujoCaja.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griFlujoCaja)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(479, 337)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'griFlujoCaja
        '
        Me.griFlujoCaja.DisplayLayout.MaxColScrollRegions = 1
        Me.griFlujoCaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griFlujoCaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griFlujoCaja.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griFlujoCaja.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griFlujoCaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFlujoCaja.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griFlujoCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFlujoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griFlujoCaja.Location = New System.Drawing.Point(0, 0)
        Me.griFlujoCaja.Name = "griFlujoCaja"
        Me.griFlujoCaja.Size = New System.Drawing.Size(479, 337)
        Me.griFlujoCaja.TabIndex = 3
        Me.griFlujoCaja.Text = "Flujo de Caja"
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.cboProcesoNegocio)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.Black
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1005, 82)
        Me.agrProcesoNegocio.TabIndex = 2
        Me.agrProcesoNegocio.Text = "Proceso Negocio"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboProcesoNegocio
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProcesoNegocio.Appearance = Appearance1
        Me.cboProcesoNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.Image = 7
        EditorButton1.Appearance = Appearance2
        Me.cboProcesoNegocio.ButtonsRight.Add(EditorButton1)
        Me.cboProcesoNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProcesoNegocio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProcesoNegocio.Location = New System.Drawing.Point(192, 35)
        Me.cboProcesoNegocio.Name = "cboProcesoNegocio"
        Me.cboProcesoNegocio.Size = New System.Drawing.Size(312, 21)
        Me.cboProcesoNegocio.TabIndex = 252
        Me.cboProcesoNegocio.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance3
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(98, 38)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(88, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Proceso Negocio"
        '
        'ficProcesoNegocio
        '
        Me.ficProcesoNegocio.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficProcesoNegocio.Controls.Add(Me.UltraTabPageControl7)
        Me.ficProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.ficProcesoNegocio.Name = "ficProcesoNegocio"
        Me.ficProcesoNegocio.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficProcesoNegocio.Size = New System.Drawing.Size(1007, 468)
        Me.ficProcesoNegocio.TabIndex = 5
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        Me.ficProcesoNegocio.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.ficProcesoNegocio.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1005, 445)
        '
        'frm_ProcesoFlujoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 468)
        Me.Controls.Add(Me.ficProcesoNegocio)
        Me.Name = "frm_ProcesoFlujoCaja"
        Me.Text = "Asociar Flujos a Procesos de Negocio"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrProcesoFuljoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoFuljoCaja.ResumeLayout(False)
        CType(Me.griProcesoFlujo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expFlujoCaja.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.cboProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficProcesoNegocio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficProcesoNegocio As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griProcesoFlujo As ISL.Controles.Grilla
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents agrProcesoFuljoCaja As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents expFlujoCaja As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griFlujoCaja As ISL.Controles.Grilla
    Friend WithEvents cboProcesoNegocio As ISL.Controles.Combo
End Class
