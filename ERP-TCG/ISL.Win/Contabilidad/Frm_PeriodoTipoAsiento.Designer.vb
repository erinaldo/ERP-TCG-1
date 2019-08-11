<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PeriodoTipoAsiento
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.etiTipoAsiento = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoAsiento = New ISL.Controles.Combo(Me.components)
        Me.EtiMes = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.etiEjercicio = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtVoucher = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ChkActivo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.etiEmision = New ISL.Controles.Etiqueta(Me.components)
        Me.FecEmision = New ISL.Controles.Fecha(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.ToolTip = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        CType(Me.cboTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etiTipoAsiento
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiTipoAsiento.Appearance = Appearance1
        Me.etiTipoAsiento.AutoSize = True
        Me.etiTipoAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoAsiento.ForeColor = System.Drawing.Color.Black
        Me.etiTipoAsiento.Location = New System.Drawing.Point(3, 51)
        Me.etiTipoAsiento.Name = "etiTipoAsiento"
        Me.etiTipoAsiento.Size = New System.Drawing.Size(96, 15)
        Me.etiTipoAsiento.TabIndex = 14
        Me.etiTipoAsiento.Text = "Tipo de Asiento:"
        '
        'cboTipoAsiento
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoAsiento.Appearance = Appearance2
        Me.cboTipoAsiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoAsiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoAsiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoAsiento.Location = New System.Drawing.Point(100, 47)
        Me.cboTipoAsiento.Name = "cboTipoAsiento"
        Me.cboTipoAsiento.Size = New System.Drawing.Size(181, 22)
        Me.cboTipoAsiento.TabIndex = 13
        Me.cboTipoAsiento.ValueMember = "Id"
        '
        'EtiMes
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.EtiMes.Appearance = Appearance3
        Me.EtiMes.AutoSize = True
        Me.EtiMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiMes.ForeColor = System.Drawing.Color.Black
        Me.EtiMes.Location = New System.Drawing.Point(160, 27)
        Me.EtiMes.Name = "EtiMes"
        Me.EtiMes.Size = New System.Drawing.Size(30, 14)
        Me.EtiMes.TabIndex = 12
        Me.EtiMes.Text = "Mes:"
        '
        'cboMes
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance4
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(195, 23)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(86, 21)
        Me.cboMes.TabIndex = 11
        Me.cboMes.ValueMember = "Id"
        '
        'etiEjercicio
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.etiEjercicio.Appearance = Appearance5
        Me.etiEjercicio.AutoSize = True
        Me.etiEjercicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEjercicio.ForeColor = System.Drawing.Color.Black
        Me.etiEjercicio.Location = New System.Drawing.Point(41, 27)
        Me.etiEjercicio.Name = "etiEjercicio"
        Me.etiEjercicio.Size = New System.Drawing.Size(57, 15)
        Me.etiEjercicio.TabIndex = 9
        Me.etiEjercicio.Text = "Ejercicio:"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.txtVoucher)
        Me.Agrupacion1.Controls.Add(Me.ChkActivo)
        Me.Agrupacion1.Controls.Add(Me.etiEmision)
        Me.Agrupacion1.Controls.Add(Me.FecEmision)
        Me.Agrupacion1.Controls.Add(Me.btnAceptar)
        Me.Agrupacion1.Controls.Add(Me.btnCancelar)
        Me.Agrupacion1.Controls.Add(Me.etiTipoAsiento)
        Me.Agrupacion1.Controls.Add(Me.etiEjercicio)
        Me.Agrupacion1.Controls.Add(Me.cboTipoAsiento)
        Me.Agrupacion1.Controls.Add(Me.Año1)
        Me.Agrupacion1.Controls.Add(Me.EtiMes)
        Me.Agrupacion1.Controls.Add(Me.cboMes)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(293, 128)
        Me.Agrupacion1.TabIndex = 15
        Me.Agrupacion1.Text = "Seleccionar"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtVoucher
        '
        Me.txtVoucher.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucher.Location = New System.Drawing.Point(101, 72)
        Me.txtVoucher.MaxLength = 10
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(100, 22)
        Me.txtVoucher.TabIndex = 287
        Me.txtVoucher.Visible = False
        '
        'ChkActivo
        '
        Appearance6.BackColor = System.Drawing.Color.LightCyan
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.ChkActivo.Appearance = Appearance6
        Me.ChkActivo.BackColor = System.Drawing.Color.LightCyan
        Me.ChkActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.ChkActivo.Location = New System.Drawing.Point(100, 56)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(181, 19)
        Me.ChkActivo.TabIndex = 286
        Me.ChkActivo.Text = "Enviar compra al Activo"
        Me.ChkActivo.Visible = False
        '
        'etiEmision
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.etiEmision.Appearance = Appearance7
        Me.etiEmision.AutoSize = True
        Me.etiEmision.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEmision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEmision.Location = New System.Drawing.Point(42, 76)
        Me.etiEmision.Name = "etiEmision"
        Me.etiEmision.Size = New System.Drawing.Size(53, 15)
        Me.etiEmision.TabIndex = 285
        Me.etiEmision.Text = "Emision:"
        '
        'FecEmision
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Appearance = Appearance8
        Me.FecEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Location = New System.Drawing.Point(101, 72)
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.Size = New System.Drawing.Size(88, 21)
        Me.FecEmision.TabIndex = 284
        '
        'btnAceptar
        '
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.btnAceptar.Appearance = Appearance9
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(41, 99)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(93, 20)
        Me.btnAceptar.TabIndex = 282
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.btnCancelar.Appearance = Appearance10
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(159, 99)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 20)
        Me.btnCancelar.TabIndex = 283
        Me.btnCancelar.Text = "Cancelar"
        '
        'Año1
        '
        Me.Año1.Año = 2016
        Me.Año1.Location = New System.Drawing.Point(100, 22)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 10
        '
        'ToolTip
        '
        Me.ToolTip.ContainingControl = Me
        '
        'Frm_PeriodoTipoAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 128)
        Me.Controls.Add(Me.Agrupacion1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_PeriodoTipoAsiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodo-TipoAsiento"
        CType(Me.cboTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents etiTipoAsiento As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoAsiento As ISL.Controles.Combo
    Friend WithEvents EtiMes As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents etiEjercicio As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents etiEmision As ISL.Controles.Etiqueta
    Friend WithEvents FecEmision As ISL.Controles.Fecha
    Friend WithEvents ChkActivo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolTip As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents txtVoucher As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
