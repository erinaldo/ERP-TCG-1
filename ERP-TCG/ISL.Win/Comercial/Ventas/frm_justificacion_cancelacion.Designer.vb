<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_justificacion_cancelacion
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtMotivoCancelacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMotivoCancelacion = New Infragistics.Win.Misc.UltraLabel()
        Me.cboConcepto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtMotivoCancelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(227, 145)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'txtMotivoCancelacion
        '
        Me.txtMotivoCancelacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(12, 62)
        Me.txtMotivoCancelacion.MaxLength = 500
        Me.txtMotivoCancelacion.Multiline = True
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(358, 70)
        Me.txtMotivoCancelacion.TabIndex = 3
        '
        'lblMotivoCancelacion
        '
        Me.lblMotivoCancelacion.AutoSize = True
        Me.lblMotivoCancelacion.Location = New System.Drawing.Point(12, 12)
        Me.lblMotivoCancelacion.Name = "lblMotivoCancelacion"
        Me.lblMotivoCancelacion.Size = New System.Drawing.Size(90, 14)
        Me.lblMotivoCancelacion.TabIndex = 2
        Me.lblMotivoCancelacion.Text = "Escriba el motivo"
        '
        'cboConcepto
        '
        Me.cboConcepto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboConcepto.DisplayMember = "Nombre"
        Me.cboConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.Location = New System.Drawing.Point(12, 34)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(358, 21)
        Me.cboConcepto.TabIndex = 18
        Me.cboConcepto.ValueMember = "Id"
        '
        'frm_justificacion_cancelacion
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(385, 186)
        Me.Controls.Add(Me.cboConcepto)
        Me.Controls.Add(Me.txtMotivoCancelacion)
        Me.Controls.Add(Me.lblMotivoCancelacion)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_justificacion_cancelacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Motivo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.txtMotivoCancelacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtMotivoCancelacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblMotivoCancelacion As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboConcepto As Infragistics.Win.UltraWinEditors.UltraComboEditor

End Class
