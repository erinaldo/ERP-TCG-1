<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActualizarGastoFuncion
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.agrDatos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboCuenta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboTipoGasto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.griDatos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.cboCuenta)
        Me.agrDatos.Controls.Add(Me.txtCuenta)
        Me.agrDatos.Controls.Add(Me.cboTipoGasto)
        Me.agrDatos.Controls.Add(Me.UltraLabel3)
        Me.agrDatos.Controls.Add(Me.UltraLabel1)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(793, 63)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCuenta
        '
        Me.cboCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuenta.Location = New System.Drawing.Point(353, 25)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.ReadOnly = True
        Me.cboCuenta.Size = New System.Drawing.Size(76, 22)
        Me.cboCuenta.TabIndex = 6
        Me.cboCuenta.ValueMember = "Id"
        '
        'txtCuenta
        '
        Me.txtCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta.Location = New System.Drawing.Point(435, 25)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(341, 22)
        Me.txtCuenta.TabIndex = 5
        '
        'cboTipoGasto
        '
        Me.cboTipoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboTipoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoGasto.Location = New System.Drawing.Point(80, 25)
        Me.cboTipoGasto.Name = "cboTipoGasto"
        Me.cboTipoGasto.ReadOnly = True
        Me.cboTipoGasto.Size = New System.Drawing.Size(218, 22)
        Me.cboTipoGasto.TabIndex = 3
        Me.cboTipoGasto.ValueMember = "Id"
        '
        'UltraLabel3
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(304, 29)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Cuenta:"
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 29)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Tipo Gasto:"
        '
        'griDatos
        '
        Me.griDatos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDatos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
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
        Me.griDatos.Location = New System.Drawing.Point(0, 63)
        Me.griDatos.Name = "griDatos"
        Me.griDatos.Size = New System.Drawing.Size(793, 198)
        Me.griDatos.TabIndex = 1
        Me.griDatos.Text = "UltraGrid1"
        '
        'frm_ActualizarGastoFuncion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 261)
        Me.Controls.Add(Me.griDatos)
        Me.Controls.Add(Me.agrDatos)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ActualizarGastoFuncion"
        Me.Text = "Datos para actualizar"
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDatos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboTipoGasto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboCuenta As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
