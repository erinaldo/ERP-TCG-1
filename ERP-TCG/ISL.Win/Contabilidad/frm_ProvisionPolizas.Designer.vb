<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProvisionPolizas
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDatos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griReversion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.agrDatosBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.fecEmision = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.upDatos = New Infragistics.Win.Misc.UltraPanel()
        Me.agrListado = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDatos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.upOperacion = New Infragistics.Win.Misc.UltraPanel()
        Me.btnProvisionar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griReversion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBusqueda.SuspendLayout()
        Me.upDatos.ClientArea.SuspendLayout()
        Me.upDatos.SuspendLayout()
        CType(Me.agrListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListado.SuspendLayout()
        CType(Me.ficDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDatos.SuspendLayout()
        Me.upOperacion.ClientArea.SuspendLayout()
        Me.upOperacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDatos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1112, 288)
        '
        'griDatos
        '
        Me.griDatos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDatos.DisplayLayout.MaxColScrollRegions = 1
        Me.griDatos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDatos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDatos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDatos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDatos.DisplayLayout.Override.CellPadding = 0
        Me.griDatos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDatos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griDatos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDatos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDatos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDatos.Location = New System.Drawing.Point(0, 0)
        Me.griDatos.Name = "griDatos"
        Me.griDatos.Size = New System.Drawing.Size(1112, 288)
        Me.griDatos.TabIndex = 1
        Me.griDatos.Text = "Polizas"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griReversion)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1112, 288)
        '
        'griReversion
        '
        Me.griReversion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReversion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReversion.DisplayLayout.MaxColScrollRegions = 1
        Me.griReversion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griReversion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griReversion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griReversion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griReversion.DisplayLayout.Override.CellPadding = 0
        Me.griReversion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griReversion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griReversion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griReversion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griReversion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griReversion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griReversion.Location = New System.Drawing.Point(0, 0)
        Me.griReversion.Name = "griReversion"
        Me.griReversion.Size = New System.Drawing.Size(1112, 288)
        Me.griReversion.TabIndex = 0
        Me.griReversion.Text = "Reversion"
        '
        'agrDatosBusqueda
        '
        Appearance1.FontData.Name = "Tahoma"
        Me.agrDatosBusqueda.Appearance = Appearance1
        Me.agrDatosBusqueda.Controls.Add(Me.fecEmision)
        Me.agrDatosBusqueda.Controls.Add(Me.Etiqueta18)
        Me.agrDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosBusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosBusqueda.Name = "agrDatosBusqueda"
        Me.agrDatosBusqueda.Size = New System.Drawing.Size(1120, 62)
        Me.agrDatosBusqueda.TabIndex = 2
        Me.agrDatosBusqueda.Text = "Generar"
        Me.agrDatosBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecEmision
        '
        Me.fecEmision.CustomFormat = "MMMM/yyyy"
        Me.fecEmision.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecEmision.Location = New System.Drawing.Point(110, 28)
        Me.fecEmision.Name = "fecEmision"
        Me.fecEmision.ShowUpDown = True
        Me.fecEmision.Size = New System.Drawing.Size(138, 20)
        Me.fecEmision.TabIndex = 62
        '
        'Etiqueta18
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Appearance = Appearance2
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(13, 30)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta18.TabIndex = 12
        Me.Etiqueta18.Text = "Fecha Provisión:"
        '
        'upDatos
        '
        '
        'upDatos.ClientArea
        '
        Me.upDatos.ClientArea.Controls.Add(Me.agrListado)
        Me.upDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upDatos.Location = New System.Drawing.Point(0, 62)
        Me.upDatos.Name = "upDatos"
        Me.upDatos.Size = New System.Drawing.Size(1120, 378)
        Me.upDatos.TabIndex = 4
        '
        'agrListado
        '
        Me.agrListado.Controls.Add(Me.ficDatos)
        Me.agrListado.Controls.Add(Me.upOperacion)
        Me.agrListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListado.Location = New System.Drawing.Point(0, 0)
        Me.agrListado.Name = "agrListado"
        Me.agrListado.Size = New System.Drawing.Size(1120, 378)
        Me.agrListado.TabIndex = 4
        Me.agrListado.Text = "Datos a Provisionar:"
        Me.agrListado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDatos
        '
        Me.ficDatos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDatos.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDatos.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDatos.Location = New System.Drawing.Point(3, 64)
        Me.ficDatos.Name = "ficDatos"
        Me.ficDatos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDatos.Size = New System.Drawing.Size(1114, 311)
        Me.ficDatos.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Polizas"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Devengo"
        Me.ficDatos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDatos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1112, 288)
        '
        'upOperacion
        '
        '
        'upOperacion.ClientArea
        '
        Me.upOperacion.ClientArea.Controls.Add(Me.btnProvisionar)
        Me.upOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.upOperacion.Location = New System.Drawing.Point(3, 17)
        Me.upOperacion.Name = "upOperacion"
        Me.upOperacion.Size = New System.Drawing.Size(1114, 47)
        Me.upOperacion.TabIndex = 0
        '
        'btnProvisionar
        '
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.content_tree
        Me.btnProvisionar.Appearance = Appearance3
        Me.btnProvisionar.AutoSize = True
        Me.btnProvisionar.Location = New System.Drawing.Point(13, 12)
        Me.btnProvisionar.Name = "btnProvisionar"
        Me.btnProvisionar.Size = New System.Drawing.Size(117, 26)
        Me.btnProvisionar.TabIndex = 0
        Me.btnProvisionar.Text = "Provisionar Datos"
        '
        'frm_ProvisionPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1120, 440)
        Me.Controls.Add(Me.upDatos)
        Me.Controls.Add(Me.agrDatosBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ProvisionPolizas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Provision de Interes Mensual"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griReversion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBusqueda.ResumeLayout(False)
        Me.agrDatosBusqueda.PerformLayout()
        Me.upDatos.ClientArea.ResumeLayout(False)
        Me.upDatos.ResumeLayout(False)
        CType(Me.agrListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListado.ResumeLayout(False)
        CType(Me.ficDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDatos.ResumeLayout(False)
        Me.upOperacion.ClientArea.ResumeLayout(False)
        Me.upOperacion.ClientArea.PerformLayout()
        Me.upOperacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatosBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents fecEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents upDatos As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents agrListado As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDatos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents upOperacion As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnProvisionar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ficDatos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griReversion As Infragistics.Win.UltraWinGrid.UltraGrid

End Class
