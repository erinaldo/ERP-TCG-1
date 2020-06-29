<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteCajaDiario
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
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griCajaDiario = New ISL.Controles.Grilla(Me.components)
        Me.MnuConReporteCajaDiario = New ISL.Controles.MenuContextual(Me.components)
        Me.mnuCierreCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadreCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboHoraFin = New ISL.Controles.Combo(Me.components)
        Me.fecFechaInicio = New ISL.Controles.Fecha(Me.components)
        Me.cboHoraInicio = New ISL.Controles.Combo(Me.components)
        Me.fecFechaFin = New ISL.Controles.Fecha(Me.components)
        Me.decSaldoFin = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldoInicio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griCajaDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuConReporteCajaDiario.SuspendLayout()
        CType(Me.agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrupacion1.SuspendLayout()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHoraFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griCajaDiario)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 80)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1180, 376)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.Text = "Movimientos de Caja:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griCajaDiario
        '
        Me.griCajaDiario.ContextMenuStrip = Me.MnuConReporteCajaDiario
        Me.griCajaDiario.DisplayLayout.MaxColScrollRegions = 1
        Me.griCajaDiario.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCajaDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCajaDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCajaDiario.Location = New System.Drawing.Point(3, 16)
        Me.griCajaDiario.Name = "griCajaDiario"
        Me.griCajaDiario.Size = New System.Drawing.Size(1174, 357)
        Me.griCajaDiario.TabIndex = 0
        '
        'MnuConReporteCajaDiario
        '
        Me.MnuConReporteCajaDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuConReporteCajaDiario.ForeColor = System.Drawing.Color.Black
        Me.MnuConReporteCajaDiario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCierreCaja, Me.CuadreCajaToolStripMenuItem})
        Me.MnuConReporteCajaDiario.Name = "MnuConReporteCajaDiario"
        Me.MnuConReporteCajaDiario.Size = New System.Drawing.Size(141, 48)
        '
        'mnuCierreCaja
        '
        Me.mnuCierreCaja.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.mnuCierreCaja.Name = "mnuCierreCaja"
        Me.mnuCierreCaja.Size = New System.Drawing.Size(140, 22)
        Me.mnuCierreCaja.Text = "Cierre de Caja"
        '
        'CuadreCajaToolStripMenuItem
        '
        Me.CuadreCajaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.CuadreCajaToolStripMenuItem.Name = "CuadreCajaToolStripMenuItem"
        Me.CuadreCajaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CuadreCajaToolStripMenuItem.Text = "Cuadre Caja"
        '
        'agrupacion1
        '
        Me.agrupacion1.Controls.Add(Me.decSaldo)
        Me.agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.agrupacion1.Controls.Add(Me.cboHoraFin)
        Me.agrupacion1.Controls.Add(Me.fecFechaInicio)
        Me.agrupacion1.Controls.Add(Me.cboHoraInicio)
        Me.agrupacion1.Controls.Add(Me.fecFechaFin)
        Me.agrupacion1.Controls.Add(Me.decSaldoFin)
        Me.agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.agrupacion1.Controls.Add(Me.decSaldoInicio)
        Me.agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.agrupacion1.Name = "agrupacion1"
        Me.agrupacion1.Size = New System.Drawing.Size(1180, 80)
        Me.agrupacion1.TabIndex = 0
        Me.agrupacion1.Text = "Datos de Búsqueda:"
        Me.agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decSaldo
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance1
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(704, 52)
        Me.decSaldo.MaskInput = "{double:-9.4}"
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.Nullable = True
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldo.ReadOnly = True
        Me.decSaldo.Size = New System.Drawing.Size(86, 21)
        Me.decSaldo.TabIndex = 11
        '
        'Etiqueta1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance2
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(14, 26)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(84, 15)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Fecha de Inicio:"
        '
        'cboHoraFin
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboHoraFin.Appearance = Appearance3
        Me.cboHoraFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHoraFin.ForeColor = System.Drawing.Color.Black
        Me.cboHoraFin.Location = New System.Drawing.Point(456, 24)
        Me.cboHoraFin.Name = "cboHoraFin"
        Me.cboHoraFin.Size = New System.Drawing.Size(76, 21)
        Me.cboHoraFin.TabIndex = 5
        Me.cboHoraFin.ValueMember = "Id"
        '
        'fecFechaInicio
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.fecFechaInicio.Appearance = Appearance4
        Me.fecFechaInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.fecFechaInicio.Location = New System.Drawing.Point(100, 24)
        Me.fecFechaInicio.Name = "fecFechaInicio"
        Me.fecFechaInicio.Size = New System.Drawing.Size(85, 21)
        Me.fecFechaInicio.TabIndex = 1
        '
        'cboHoraInicio
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboHoraInicio.Appearance = Appearance5
        Me.cboHoraInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHoraInicio.ForeColor = System.Drawing.Color.Black
        Me.cboHoraInicio.Location = New System.Drawing.Point(191, 24)
        Me.cboHoraInicio.Name = "cboHoraInicio"
        Me.cboHoraInicio.Size = New System.Drawing.Size(76, 21)
        Me.cboHoraInicio.TabIndex = 2
        Me.cboHoraInicio.ValueMember = "Id"
        '
        'fecFechaFin
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.fecFechaFin.Appearance = Appearance6
        Me.fecFechaFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaFin.ForeColor = System.Drawing.Color.Black
        Me.fecFechaFin.Location = New System.Drawing.Point(365, 24)
        Me.fecFechaFin.Name = "fecFechaFin"
        Me.fecFechaFin.Size = New System.Drawing.Size(85, 21)
        Me.fecFechaFin.TabIndex = 4
        '
        'decSaldoFin
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.decSaldoFin.Appearance = Appearance7
        Me.decSaldoFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoFin.ForeColor = System.Drawing.Color.Black
        Me.decSaldoFin.Location = New System.Drawing.Point(365, 50)
        Me.decSaldoFin.MaskInput = "{double:-9.4}"
        Me.decSaldoFin.Name = "decSaldoFin"
        Me.decSaldoFin.Nullable = True
        Me.decSaldoFin.NullText = "0.00"
        Me.decSaldoFin.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoFin.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoFin.ReadOnly = True
        Me.decSaldoFin.Size = New System.Drawing.Size(86, 21)
        Me.decSaldoFin.TabIndex = 9
        '
        'Etiqueta2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance8
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(289, 26)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Fecha de Fin:"
        '
        'Etiqueta5
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance9
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(664, 54)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta5.TabIndex = 10
        Me.Etiqueta5.Text = "Saldo:"
        '
        'Etiqueta3
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance10
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(17, 55)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Saldo Anterior:"
        '
        'Etiqueta4
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance11
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(283, 52)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "Saldo Anterior:"
        '
        'decSaldoInicio
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.decSaldoInicio.Appearance = Appearance12
        Me.decSaldoInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoInicio.ForeColor = System.Drawing.Color.Black
        Me.decSaldoInicio.Location = New System.Drawing.Point(99, 53)
        Me.decSaldoInicio.Name = "decSaldoInicio"
        Me.decSaldoInicio.NullText = "0.00"
        Me.decSaldoInicio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoInicio.ReadOnly = True
        Me.decSaldoInicio.Size = New System.Drawing.Size(86, 21)
        Me.decSaldoInicio.TabIndex = 7
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(393, 194)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(394, 68)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'frm_ReporteCajaDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 456)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.Agrupacion2)
        Me.Controls.Add(Me.agrupacion1)
        Me.Name = "frm_ReporteCajaDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte de Caja Diario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griCajaDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuConReporteCajaDiario.ResumeLayout(False)
        CType(Me.agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrupacion1.ResumeLayout(False)
        Me.agrupacion1.PerformLayout()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHoraFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldoFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents griCajaDiario As ISL.Controles.Grilla
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaFin As ISL.Controles.Fecha
    Friend WithEvents fecFechaInicio As ISL.Controles.Fecha
    Friend WithEvents decSaldoFin As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decSaldoInicio As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboHoraFin As ISL.Controles.Combo
    Friend WithEvents cboHoraInicio As ISL.Controles.Combo
    Friend WithEvents MnuConReporteCajaDiario As ISL.Controles.MenuContextual
    Friend WithEvents mnuCierreCaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents CuadreCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
