<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DevolucionMaterial
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gbNroOT = New System.Windows.Forms.GroupBox()
        Me.etiPendiente = New ISL.Controles.Etiqueta(Me.components)
        Me.ndCantidad = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbNroOT.SuspendLayout()
        CType(Me.ndCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(235, 110)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.ForeColor = System.Drawing.Color.Navy
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
        Me.Cancel_Button.ForeColor = System.Drawing.Color.Navy
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'gbNroOT
        '
        Me.gbNroOT.BackColor = System.Drawing.Color.Transparent
        Me.gbNroOT.Controls.Add(Me.etiPendiente)
        Me.gbNroOT.Controls.Add(Me.ndCantidad)
        Me.gbNroOT.Controls.Add(Me.Etiqueta2)
        Me.gbNroOT.Controls.Add(Me.Etiqueta1)
        Me.gbNroOT.Controls.Add(Me.txtNombre)
        Me.gbNroOT.Controls.Add(Me.Etiqueta7)
        Me.gbNroOT.Controls.Add(Me.txtCodigo)
        Me.gbNroOT.ForeColor = System.Drawing.Color.Navy
        Me.gbNroOT.Location = New System.Drawing.Point(12, 1)
        Me.gbNroOT.Name = "gbNroOT"
        Me.gbNroOT.Size = New System.Drawing.Size(369, 103)
        Me.gbNroOT.TabIndex = 0
        Me.gbNroOT.TabStop = False
        Me.gbNroOT.Text = "Datos Material:"
        '
        'etiPendiente
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiPendiente.Appearance = Appearance1
        Me.etiPendiente.AutoSize = True
        Me.etiPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPendiente.ForeColor = System.Drawing.Color.Black
        Me.etiPendiente.Location = New System.Drawing.Point(151, 76)
        Me.etiPendiente.Name = "etiPendiente"
        Me.etiPendiente.Size = New System.Drawing.Size(31, 14)
        Me.etiPendiente.TabIndex = 6
        Me.etiPendiente.Text = "******"
        '
        'ndCantidad
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.ndCantidad.Appearance = Appearance2
        Me.ndCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCantidad.ForeColor = System.Drawing.Color.Black
        Me.ndCantidad.Location = New System.Drawing.Point(65, 72)
        Me.ndCantidad.MaskInput = "{LOC}nnnn.nn"
        Me.ndCantidad.Name = "ndCantidad"
        Me.ndCantidad.NullText = "0.00"
        Me.ndCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCantidad.Size = New System.Drawing.Size(80, 21)
        Me.ndCantidad.TabIndex = 5
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(17, 76)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(51, 14)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Cantidad:"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(17, 49)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Nombre:"
        '
        'txtNombre
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(65, 45)
        Me.txtNombre.MaxLength = 10
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(286, 21)
        Me.txtNombre.TabIndex = 3
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(17, 22)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta7.TabIndex = 0
        Me.Etiqueta7.Text = "Codigo:"
        '
        'txtCodigo
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance4
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(65, 19)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(80, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'frm_DevolucionMaterial
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(393, 145)
        Me.Controls.Add(Me.gbNroOT)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_DevolucionMaterial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Devolucion Material"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbNroOT.ResumeLayout(False)
        Me.gbNroOT.PerformLayout()
        CType(Me.ndCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbNroOT As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ndCantidad As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents etiPendiente As ISL.Controles.Etiqueta

End Class
