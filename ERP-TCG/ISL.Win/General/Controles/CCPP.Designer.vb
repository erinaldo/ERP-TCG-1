<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCPP
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Distrito1 = New ISL.Win.Distrito
        Me.etiDistrito = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDistrito = New ISL.Controles.ComboMaestros(Me.components)
        Me.Provincia1 = New ISL.Win.Provincia
        Me.etiProvincia = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProvincia = New ISL.Controles.ComboMaestros(Me.components)
        Me.Departamento1 = New ISL.Win.Departamento
        Me.etiDepartamento = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDepartamento = New ISL.Controles.ComboMaestros(Me.components)
        Me.CentroPoblado1 = New ISL.Win.CentroPoblado
        Me.Distrito1.SuspendLayout()
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Provincia1.SuspendLayout()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Departamento1.SuspendLayout()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Distrito1
        '
        Me.Distrito1.Codigo = Nothing
        Me.Distrito1.CodigoDepartamento = Nothing
        Me.Distrito1.CodigoProvincia = Nothing
        Me.Distrito1.Controls.Add(Me.etiDistrito)
        Me.Distrito1.Controls.Add(Me.cboDistrito)
        Me.Distrito1.Id = Nothing
        Me.Distrito1.Location = New System.Drawing.Point(31, 51)
        Me.Distrito1.Name = "Distrito1"
        Me.Distrito1.Nombre = Nothing
        Me.Distrito1.Size = New System.Drawing.Size(320, 24)
        Me.Distrito1.TabIndex = 5
        '
        'etiDistrito
        '
        Me.etiDistrito.AutoSize = True
        Me.etiDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDistrito.ForeColor = System.Drawing.Color.Black
        Me.etiDistrito.Location = New System.Drawing.Point(5, 6)
        Me.etiDistrito.Name = "etiDistrito"
        Me.etiDistrito.Size = New System.Drawing.Size(38, 14)
        Me.etiDistrito.TabIndex = 3
        Me.etiDistrito.Text = "Distrito"
        '
        'cboDistrito
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboDistrito.Appearance = Appearance3
        Me.cboDistrito.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDistrito.DisplayMember = "Nombre"
        Me.cboDistrito.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDistrito.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.ForeColor = System.Drawing.Color.Black
        Me.cboDistrito.Location = New System.Drawing.Point(85, 2)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(266, 21)
        Me.cboDistrito.TabIndex = 2
        Me.cboDistrito.ValueMember = "Id"
        '
        'Provincia1
        '
        Me.Provincia1.Codigo = Nothing
        Me.Provincia1.CodigoDepartamento = Nothing
        Me.Provincia1.Controls.Add(Me.etiProvincia)
        Me.Provincia1.Controls.Add(Me.cboProvincia)
        Me.Provincia1.Id = Nothing
        Me.Provincia1.Location = New System.Drawing.Point(22, 28)
        Me.Provincia1.Name = "Provincia1"
        Me.Provincia1.Nombre = Nothing
        Me.Provincia1.Size = New System.Drawing.Size(329, 21)
        Me.Provincia1.TabIndex = 4
        '
        'etiProvincia
        '
        Me.etiProvincia.AutoSize = True
        Me.etiProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProvincia.ForeColor = System.Drawing.Color.Black
        Me.etiProvincia.Location = New System.Drawing.Point(4, 4)
        Me.etiProvincia.Name = "etiProvincia"
        Me.etiProvincia.Size = New System.Drawing.Size(49, 14)
        Me.etiProvincia.TabIndex = 1
        Me.etiProvincia.Text = "Provincia"
        '
        'cboProvincia
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboProvincia.Appearance = Appearance2
        Me.cboProvincia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProvincia.DisplayMember = "Nombre"
        Me.cboProvincia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProvincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.ForeColor = System.Drawing.Color.Black
        Me.cboProvincia.Location = New System.Drawing.Point(84, 0)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(266, 21)
        Me.cboProvincia.TabIndex = 0
        Me.cboProvincia.ValueMember = "Id"
        '
        'Departamento1
        '
        Me.Departamento1.Codigo = Nothing
        Me.Departamento1.Controls.Add(Me.etiDepartamento)
        Me.Departamento1.Controls.Add(Me.cboDepartamento)
        Me.Departamento1.Id = Nothing
        Me.Departamento1.Location = New System.Drawing.Point(-1, 3)
        Me.Departamento1.Name = "Departamento1"
        Me.Departamento1.Nombre = Nothing
        Me.Departamento1.Size = New System.Drawing.Size(357, 24)
        Me.Departamento1.TabIndex = 3
        '
        'etiDepartamento
        '
        Me.etiDepartamento.AutoSize = True
        Me.etiDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDepartamento.ForeColor = System.Drawing.Color.Black
        Me.etiDepartamento.Location = New System.Drawing.Point(4, 4)
        Me.etiDepartamento.Name = "etiDepartamento"
        Me.etiDepartamento.Size = New System.Drawing.Size(74, 14)
        Me.etiDepartamento.TabIndex = 1
        Me.etiDepartamento.Text = "Departamento"
        '
        'cboDepartamento
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.Appearance = Appearance1
        Me.cboDepartamento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDepartamento.DisplayMember = "Nombre"
        Me.cboDepartamento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDepartamento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartamento.ForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.Location = New System.Drawing.Point(84, 0)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(266, 21)
        Me.cboDepartamento.TabIndex = 0
        Me.cboDepartamento.ValueMember = "Id"
        '
        'CentroPoblado1
        '
        Me.CentroPoblado1.Codigo = Nothing
        Me.CentroPoblado1.CodigoDepartamento = Nothing
        Me.CentroPoblado1.CodigoDistrito = Nothing
        Me.CentroPoblado1.CodigoProvincia = Nothing
        Me.CentroPoblado1.Id = Nothing
        Me.CentroPoblado1.Location = New System.Drawing.Point(-6, 75)
        Me.CentroPoblado1.Name = "CentroPoblado1"
        Me.CentroPoblado1.Nombre = Nothing
        Me.CentroPoblado1.Size = New System.Drawing.Size(362, 25)
        Me.CentroPoblado1.TabIndex = 6
        '
        'CCPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CentroPoblado1)
        Me.Controls.Add(Me.Distrito1)
        Me.Controls.Add(Me.Provincia1)
        Me.Controls.Add(Me.Departamento1)
        Me.Name = "CCPP"
        Me.Size = New System.Drawing.Size(350, 100)
        Me.Distrito1.ResumeLayout(False)
        Me.Distrito1.PerformLayout()
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Provincia1.ResumeLayout(False)
        Me.Provincia1.PerformLayout()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Departamento1.ResumeLayout(False)
        Me.Departamento1.PerformLayout()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Distrito1 As ISL.Win.Distrito
    Friend WithEvents etiDistrito As ISL.Controles.Etiqueta
    Friend WithEvents cboDistrito As ISL.Controles.ComboMaestros
    Friend WithEvents Provincia1 As ISL.Win.Provincia
    Friend WithEvents etiProvincia As ISL.Controles.Etiqueta
    Friend WithEvents cboProvincia As ISL.Controles.ComboMaestros
    Friend WithEvents Departamento1 As ISL.Win.Departamento
    Friend WithEvents etiDepartamento As ISL.Controles.Etiqueta
    Friend WithEvents cboDepartamento As ISL.Controles.ComboMaestros
    Friend WithEvents CentroPoblado1 As ISL.Win.CentroPoblado

End Class
