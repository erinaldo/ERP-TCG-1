<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meses
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMes
        '
        Me.cboMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboMes.Appearance = Appearance1
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "Enero"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Febrero"
        ValueListItem3.DataValue = "3"
        ValueListItem3.DisplayText = "Marzo"
        ValueListItem4.DataValue = "4"
        ValueListItem4.DisplayText = "Abril"
        ValueListItem5.DataValue = "5"
        ValueListItem5.DisplayText = "Mayo"
        ValueListItem6.DataValue = "6"
        ValueListItem6.DisplayText = "Junio"
        ValueListItem7.DataValue = "7"
        ValueListItem7.DisplayText = "Julio"
        ValueListItem8.DataValue = "8"
        ValueListItem8.DisplayText = "Agosto"
        ValueListItem9.DataValue = "9"
        ValueListItem9.DisplayText = "Septiembre"
        ValueListItem10.DataValue = "10"
        ValueListItem10.DisplayText = "Octubre"
        ValueListItem11.DataValue = "11"
        ValueListItem11.DisplayText = "Noviembre"
        ValueListItem12.DataValue = "12"
        ValueListItem12.DisplayText = "Diciembre"
        Me.cboMes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9, ValueListItem10, ValueListItem11, ValueListItem12})
        Me.cboMes.Location = New System.Drawing.Point(34, 0)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(124, 21)
        Me.cboMes.TabIndex = 0
        Me.cboMes.ValueMember = ""
        '
        'Etiqueta
        '
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.Etiqueta.Appearance = Appearance2
        Me.Etiqueta.AutoSize = True
        Me.Etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta.Location = New System.Drawing.Point(3, 3)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta.TabIndex = 1
        '
        'Meses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Etiqueta)
        Me.Controls.Add(Me.cboMes)
        Me.Name = "Meses"
        Me.Size = New System.Drawing.Size(160, 22)
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta As ISL.Controles.Etiqueta

End Class
