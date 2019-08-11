<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ControlUsuarios
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.griListaUsuario = New ISL.Controles.Grilla(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.griListaUsuariosDesconectados = New ISL.Controles.Grilla(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.griListaUsuariosSinConexionUltimaSemana = New ISL.Controles.Grilla(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.griListaUsuariosSinConexionNunca = New ISL.Controles.Grilla(Me.components)
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTiempoActualizacionDatos = New System.Windows.Forms.ComboBox()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.griListaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.griListaUsuariosDesconectados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.griListaUsuariosSinConexionUltimaSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.griListaUsuariosSinConexionNunca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tiempo1
        '
        Me.Tiempo1.Enabled = True
        Me.Tiempo1.Interval = 30000
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.TabControl1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 46)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1039, 462)
        Me.Agrupacion1.TabIndex = 6
        Me.Agrupacion1.Text = "Detalle Conexiones de Usuarios:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(2, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 442)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.griListaUsuario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1027, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conectados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'griListaUsuario
        '
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaUsuario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaUsuario.Location = New System.Drawing.Point(3, 3)
        Me.griListaUsuario.Name = "griListaUsuario"
        Me.griListaUsuario.Size = New System.Drawing.Size(1021, 410)
        Me.griListaUsuario.TabIndex = 7
        Me.griListaUsuario.Text = "Usuarios actualmente conectados"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.griListaUsuariosDesconectados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1027, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cerraron sesión"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'griListaUsuariosDesconectados
        '
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaUsuariosDesconectados.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaUsuariosDesconectados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaUsuariosDesconectados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaUsuariosDesconectados.Location = New System.Drawing.Point(3, 3)
        Me.griListaUsuariosDesconectados.Name = "griListaUsuariosDesconectados"
        Me.griListaUsuariosDesconectados.Size = New System.Drawing.Size(1021, 410)
        Me.griListaUsuariosDesconectados.TabIndex = 8
        Me.griListaUsuariosDesconectados.Text = "Usuarios desconectados que trabajaron hoy"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.griListaUsuariosSinConexionUltimaSemana)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1027, 416)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "No se conectaron durante la semana"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'griListaUsuariosSinConexionUltimaSemana
        '
        UltraGridBand3.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand3.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand3.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaUsuariosSinConexionUltimaSemana.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaUsuariosSinConexionUltimaSemana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaUsuariosSinConexionUltimaSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaUsuariosSinConexionUltimaSemana.Location = New System.Drawing.Point(0, 0)
        Me.griListaUsuariosSinConexionUltimaSemana.Name = "griListaUsuariosSinConexionUltimaSemana"
        Me.griListaUsuariosSinConexionUltimaSemana.Size = New System.Drawing.Size(1027, 416)
        Me.griListaUsuariosSinConexionUltimaSemana.TabIndex = 9
        Me.griListaUsuariosSinConexionUltimaSemana.Text = "Usuarios que no se han conectado la última semana"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.griListaUsuariosSinConexionNunca)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1027, 416)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Casi no se conectan"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'griListaUsuariosSinConexionNunca
        '
        UltraGridBand4.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand4.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand4.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaUsuariosSinConexionNunca.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaUsuariosSinConexionNunca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaUsuariosSinConexionNunca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaUsuariosSinConexionNunca.Location = New System.Drawing.Point(0, 0)
        Me.griListaUsuariosSinConexionNunca.Name = "griListaUsuariosSinConexionNunca"
        Me.griListaUsuariosSinConexionNunca.Size = New System.Drawing.Size(1027, 416)
        Me.griListaUsuariosSinConexionNunca.TabIndex = 9
        Me.griListaUsuariosSinConexionNunca.Text = "Usuarios que no se conectan hace más de una semana"
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.Label1)
        Me.agrFiltro.Controls.Add(Me.cboTiempoActualizacionDatos)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1039, 46)
        Me.agrFiltro.TabIndex = 4
        Me.agrFiltro.Text = "Busqueda:"
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tiempo de actualización de datos:"
        '
        'cboTiempoActualizacionDatos
        '
        Me.cboTiempoActualizacionDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiempoActualizacionDatos.FormattingEnabled = True
        Me.cboTiempoActualizacionDatos.Items.AddRange(New Object() {"10 segundos", "30 segundos", "1 minuto", "5 minutos", "No actualizar"})
        Me.cboTiempoActualizacionDatos.Location = New System.Drawing.Point(187, 21)
        Me.cboTiempoActualizacionDatos.Name = "cboTiempoActualizacionDatos"
        Me.cboTiempoActualizacionDatos.Size = New System.Drawing.Size(158, 21)
        Me.cboTiempoActualizacionDatos.TabIndex = 11
        '
        'frm_ControlUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1039, 508)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Controls.Add(Me.agrFiltro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ControlUsuarios"
        Me.Text = "Control de Acceso"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.griListaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.griListaUsuariosDesconectados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.griListaUsuariosSinConexionUltimaSemana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.griListaUsuariosSinConexionNunca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.agrFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents griListaUsuario As ISL.Controles.Grilla
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents griListaUsuariosDesconectados As ISL.Controles.Grilla
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTiempoActualizacionDatos As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents griListaUsuariosSinConexionUltimaSemana As ISL.Controles.Grilla
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents griListaUsuariosSinConexionNunca As ISL.Controles.Grilla

End Class
