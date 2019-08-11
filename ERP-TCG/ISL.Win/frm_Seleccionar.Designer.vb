<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Seleccionar
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGrupo = New ISL.Controles.Combo(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Etiqueta1
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance1
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(32, 52)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Grupo:"
        '
        'cboGrupo
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.Appearance = Appearance2
        Me.cboGrupo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboGrupo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGrupo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.Location = New System.Drawing.Point(77, 48)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(251, 21)
        Me.cboGrupo.TabIndex = 1
        Me.cboGrupo.ValueMember = "Id"
        '
        'btnAceptar
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance3
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(80, 86)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnCancelar.Appearance = Appearance4
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(176, 86)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'cboArea
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance5
        Me.cboArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(77, 21)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(251, 21)
        Me.cboArea.TabIndex = 4
        Me.cboArea.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance6
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(40, 25)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(31, 14)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Area:"
        '
        'frm_Selecionar
        '
        Me.ClientSize = New System.Drawing.Size(348, 140)
        Me.Controls.Add(Me.Etiqueta2)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cboGrupo)
        Me.Controls.Add(Me.Etiqueta1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Selecionar"
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents e_ControlPermisosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents odMaterialMarca As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboGrupo As ISL.Controles.Combo
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
End Class
