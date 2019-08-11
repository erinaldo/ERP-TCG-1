<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpresaAportacion
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.rbComFLujo = New System.Windows.Forms.RadioButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.rbMixtaSaldo = New System.Windows.Forms.RadioButton()
        Me.rbMixtaFlujo = New System.Windows.Forms.RadioButton()
        Me.cboEmpresa = New ISL.Controles.Combo(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.rbSisPrivado = New System.Windows.Forms.RadioButton()
        Me.rbSisNacional = New System.Windows.Forms.RadioButton()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.cboEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.rbComFLujo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(304, 47)
        '
        'rbComFLujo
        '
        Me.rbComFLujo.AutoSize = True
        Me.rbComFLujo.BackColor = System.Drawing.Color.Transparent
        Me.rbComFLujo.Checked = True
        Me.rbComFLujo.ForeColor = System.Drawing.Color.Navy
        Me.rbComFLujo.Location = New System.Drawing.Point(108, 18)
        Me.rbComFLujo.Name = "rbComFLujo"
        Me.rbComFLujo.Size = New System.Drawing.Size(78, 17)
        Me.rbComFLujo.TabIndex = 3
        Me.rbComFLujo.TabStop = True
        Me.rbComFLujo.Text = "Sobre Flujo"
        Me.rbComFLujo.UseVisualStyleBackColor = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.rbMixtaSaldo)
        Me.UltraTabPageControl2.Controls.Add(Me.rbMixtaFlujo)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(304, 47)
        '
        'rbMixtaSaldo
        '
        Me.rbMixtaSaldo.AutoSize = True
        Me.rbMixtaSaldo.BackColor = System.Drawing.Color.Transparent
        Me.rbMixtaSaldo.ForeColor = System.Drawing.Color.Navy
        Me.rbMixtaSaldo.Location = New System.Drawing.Point(93, 16)
        Me.rbMixtaSaldo.Name = "rbMixtaSaldo"
        Me.rbMixtaSaldo.Size = New System.Drawing.Size(83, 17)
        Me.rbMixtaSaldo.TabIndex = 4
        Me.rbMixtaSaldo.Text = "Sobre Saldo"
        Me.rbMixtaSaldo.UseVisualStyleBackColor = False
        '
        'rbMixtaFlujo
        '
        Me.rbMixtaFlujo.AutoSize = True
        Me.rbMixtaFlujo.BackColor = System.Drawing.Color.Transparent
        Me.rbMixtaFlujo.ForeColor = System.Drawing.Color.Navy
        Me.rbMixtaFlujo.Location = New System.Drawing.Point(9, 16)
        Me.rbMixtaFlujo.Name = "rbMixtaFlujo"
        Me.rbMixtaFlujo.Size = New System.Drawing.Size(78, 17)
        Me.rbMixtaFlujo.TabIndex = 336
        Me.rbMixtaFlujo.Text = "Sobre Flujo"
        Me.rbMixtaFlujo.UseVisualStyleBackColor = False
        '
        'cboEmpresa
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboEmpresa.Appearance = Appearance1
        Me.cboEmpresa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresa.ForeColor = System.Drawing.Color.Black
        Me.cboEmpresa.Location = New System.Drawing.Point(84, 45)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(231, 21)
        Me.cboEmpresa.TabIndex = 1
        Me.cboEmpresa.ValueMember = "Id"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Boton1)
        Me.Agrupacion1.Controls.Add(Me.btnAprobar)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.fecFechaNacimiento)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(342, 293)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Datos Generales"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Boton1
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.Boton1.Appearance = Appearance2
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.Location = New System.Drawing.Point(190, 243)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(78, 27)
        Me.Boton1.TabIndex = 335
        Me.Boton1.Text = "Cancelar"
        Me.Boton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAprobar
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnAprobar.Appearance = Appearance3
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.Location = New System.Drawing.Point(88, 243)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(78, 27)
        Me.btnAprobar.TabIndex = 334
        Me.btnAprobar.Text = "Guardar"
        Me.btnAprobar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Etiqueta2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance4
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(47, 22)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(96, 14)
        Me.Etiqueta2.TabIndex = 7
        Me.Etiqueta2.Text = "Fecha Nacimiento:"
        '
        'fecFechaNacimiento
        '
        Me.fecFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaNacimiento.Location = New System.Drawing.Point(149, 19)
        Me.fecFechaNacimiento.Name = "fecFechaNacimiento"
        Me.fecFechaNacimiento.Size = New System.Drawing.Size(119, 20)
        Me.fecFechaNacimiento.TabIndex = 0
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.rbSisPrivado)
        Me.Agrupacion2.Controls.Add(Me.rbSisNacional)
        Me.Agrupacion2.Controls.Add(Me.cboEmpresa)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(6, 45)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(330, 183)
        Me.Agrupacion2.TabIndex = 2
        Me.Agrupacion2.Text = "SistemaPension"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbSisPrivado
        '
        Me.rbSisPrivado.AutoSize = True
        Me.rbSisPrivado.BackColor = System.Drawing.Color.Transparent
        Me.rbSisPrivado.Checked = True
        Me.rbSisPrivado.ForeColor = System.Drawing.Color.Navy
        Me.rbSisPrivado.Location = New System.Drawing.Point(13, 22)
        Me.rbSisPrivado.Name = "rbSisPrivado"
        Me.rbSisPrivado.Size = New System.Drawing.Size(46, 17)
        Me.rbSisPrivado.TabIndex = 1
        Me.rbSisPrivado.TabStop = True
        Me.rbSisPrivado.Text = "SPP"
        Me.rbSisPrivado.UseVisualStyleBackColor = False
        '
        'rbSisNacional
        '
        Me.rbSisNacional.AutoSize = True
        Me.rbSisNacional.BackColor = System.Drawing.Color.Transparent
        Me.rbSisNacional.ForeColor = System.Drawing.Color.Navy
        Me.rbSisNacional.Location = New System.Drawing.Point(168, 22)
        Me.rbSisNacional.Name = "rbSisNacional"
        Me.rbSisNacional.Size = New System.Drawing.Size(47, 17)
        Me.rbSisNacional.TabIndex = 0
        Me.rbSisNacional.Text = "SNP"
        Me.rbSisNacional.UseVisualStyleBackColor = False
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(3, 49)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Empresa AFP:"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Ficha1)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 82)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(312, 89)
        Me.Agrupacion3.TabIndex = 5
        Me.Agrupacion3.Text = "TipoComision"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl1)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl2)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(3, 16)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Ficha1.Size = New System.Drawing.Size(306, 70)
        Me.Ficha1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Normal"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mixta"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(304, 47)
        '
        'frm_EmpresaAportacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 293)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_EmpresaAportacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpresaAportacion"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.cboEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboEmpresa As ISL.Controles.Combo
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents rbComFLujo As System.Windows.Forms.RadioButton
    Friend WithEvents rbMixtaSaldo As System.Windows.Forms.RadioButton
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents rbSisPrivado As System.Windows.Forms.RadioButton
    Friend WithEvents rbSisNacional As System.Windows.Forms.RadioButton
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Boton1 As ISL.Controles.Boton
    Friend WithEvents btnAprobar As ISL.Controles.Boton
    Friend WithEvents rbMixtaFlujo As System.Windows.Forms.RadioButton
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
End Class
