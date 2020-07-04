<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteMovimientosCaja
    Inherits frm_MenuPadre

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
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboHoraFin = New ISL.Controles.Combo(Me.components)
        Me.cboHoraInicio = New ISL.Controles.Combo(Me.components)
        Me.txt_HoraFin = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_HoraInicio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.fec_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.fec_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldoInicio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.uce_Caja = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griCajaDiario = New ISL.Controles.Grilla(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboHoraFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HoraFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Caja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griCajaDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cboHoraFin)
        Me.UltraGroupBox1.Controls.Add(Me.cboHoraInicio)
        Me.UltraGroupBox1.Controls.Add(Me.txt_HoraFin)
        Me.UltraGroupBox1.Controls.Add(Me.txt_HoraInicio)
        Me.UltraGroupBox1.Controls.Add(Me.fec_FechaFin)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta6)
        Me.UltraGroupBox1.Controls.Add(Me.fec_FechaInicio)
        Me.UltraGroupBox1.Controls.Add(Me.decSaldo)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta3)
        Me.UltraGroupBox1.Controls.Add(Me.decSaldoInicio)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Caja)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1071, 88)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Datos"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboHoraFin
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboHoraFin.Appearance = Appearance1
        Me.cboHoraFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHoraFin.ForeColor = System.Drawing.Color.Black
        Me.cboHoraFin.Location = New System.Drawing.Point(717, 27)
        Me.cboHoraFin.Name = "cboHoraFin"
        Me.cboHoraFin.Size = New System.Drawing.Size(90, 21)
        Me.cboHoraFin.TabIndex = 15
        Me.cboHoraFin.ValueMember = "Id"
        '
        'cboHoraInicio
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboHoraInicio.Appearance = Appearance2
        Me.cboHoraInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHoraInicio.ForeColor = System.Drawing.Color.Black
        Me.cboHoraInicio.Location = New System.Drawing.Point(450, 27)
        Me.cboHoraInicio.Name = "cboHoraInicio"
        Me.cboHoraInicio.Size = New System.Drawing.Size(90, 21)
        Me.cboHoraInicio.TabIndex = 14
        Me.cboHoraInicio.ValueMember = "Id"
        '
        'txt_HoraFin
        '
        Me.txt_HoraFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_HoraFin.Location = New System.Drawing.Point(717, 51)
        Me.txt_HoraFin.Name = "txt_HoraFin"
        Me.txt_HoraFin.ReadOnly = True
        Me.txt_HoraFin.Size = New System.Drawing.Size(76, 22)
        Me.txt_HoraFin.TabIndex = 13
        Me.txt_HoraFin.Visible = False
        '
        'txt_HoraInicio
        '
        Me.txt_HoraInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_HoraInicio.Location = New System.Drawing.Point(450, 54)
        Me.txt_HoraInicio.Name = "txt_HoraInicio"
        Me.txt_HoraInicio.ReadOnly = True
        Me.txt_HoraInicio.Size = New System.Drawing.Size(76, 22)
        Me.txt_HoraInicio.TabIndex = 12
        Me.txt_HoraInicio.Visible = False
        '
        'fec_FechaFin
        '
        Me.fec_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fec_FechaFin.Location = New System.Drawing.Point(620, 27)
        Me.fec_FechaFin.Name = "fec_FechaFin"
        Me.fec_FechaFin.Size = New System.Drawing.Size(95, 21)
        Me.fec_FechaFin.TabIndex = 6
        '
        'Etiqueta6
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance3
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(12, 30)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Caja:"
        '
        'fec_FechaInicio
        '
        Me.fec_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fec_FechaInicio.Location = New System.Drawing.Point(348, 27)
        Me.fec_FechaInicio.Name = "fec_FechaInicio"
        Me.fec_FechaInicio.Size = New System.Drawing.Size(100, 21)
        Me.fec_FechaInicio.TabIndex = 3
        '
        'decSaldo
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance4
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(348, 54)
        Me.decSaldo.MaskInput = "{double:-9.4}"
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.Nullable = True
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldo.ReadOnly = True
        Me.decSaldo.Size = New System.Drawing.Size(100, 21)
        Me.decSaldo.TabIndex = 11
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(262, 30)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(84, 15)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Fecha de Inicio:"
        '
        'Etiqueta2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance6
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(546, 30)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Fecha de Fin:"
        '
        'Etiqueta5
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance7
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(307, 58)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta5.TabIndex = 10
        Me.Etiqueta5.Text = "Saldo:"
        '
        'Etiqueta3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance8
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(83, 58)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "Saldo Anterior:"
        '
        'decSaldoInicio
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.decSaldoInicio.Appearance = Appearance9
        Me.decSaldoInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoInicio.ForeColor = System.Drawing.Color.Black
        Me.decSaldoInicio.Location = New System.Drawing.Point(168, 54)
        Me.decSaldoInicio.Name = "decSaldoInicio"
        Me.decSaldoInicio.NullText = "0.00"
        Me.decSaldoInicio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoInicio.ReadOnly = True
        Me.decSaldoInicio.Size = New System.Drawing.Size(86, 21)
        Me.decSaldoInicio.TabIndex = 9
        '
        'uce_Caja
        '
        Me.uce_Caja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Caja.DropDownListWidth = 250
        Me.uce_Caja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Caja.Location = New System.Drawing.Point(48, 26)
        Me.uce_Caja.Name = "uce_Caja"
        Me.uce_Caja.Size = New System.Drawing.Size(206, 22)
        Me.uce_Caja.TabIndex = 1
        Me.uce_Caja.ValueMember = "Id"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griCajaDiario)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 88)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1071, 272)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Reporte"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griCajaDiario
        '
        Me.griCajaDiario.DisplayLayout.MaxColScrollRegions = 1
        Me.griCajaDiario.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCajaDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCajaDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCajaDiario.Location = New System.Drawing.Point(3, 17)
        Me.griCajaDiario.Name = "griCajaDiario"
        Me.griCajaDiario.Size = New System.Drawing.Size(1065, 252)
        Me.griCajaDiario.TabIndex = 0
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(338, 146)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(394, 68)
        Me.ugb_Espera.TabIndex = 3
        Me.ugb_Espera.Visible = False
        '
        'frm_ReporteMovimientosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 360)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm_ReporteMovimientosCaja"
        Me.Text = "Movimientos Caja"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboHoraFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HoraFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Caja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griCajaDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_Caja As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents griCajaDiario As Controles.Grilla
    Friend WithEvents fec_FechaFin As DateTimePicker
    Friend WithEvents Etiqueta6 As Controles.Etiqueta
    Friend WithEvents fec_FechaInicio As DateTimePicker
    Friend WithEvents decSaldo As Controles.NumeroDecimal
    Friend WithEvents Etiqueta1 As Controles.Etiqueta
    Friend WithEvents Etiqueta2 As Controles.Etiqueta
    Friend WithEvents Etiqueta5 As Controles.Etiqueta
    Friend WithEvents Etiqueta3 As Controles.Etiqueta
    Friend WithEvents decSaldoInicio As Controles.NumeroDecimal
    Friend WithEvents ugb_Espera As Espere
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents txt_HoraInicio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_HoraFin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboHoraInicio As Controles.Combo
    Friend WithEvents cboHoraFin As Controles.Combo
End Class
