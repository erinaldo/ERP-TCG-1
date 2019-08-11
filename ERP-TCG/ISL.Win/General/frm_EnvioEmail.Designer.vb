<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EnvioEmail
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RutaDocumento")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EnvioEmail))
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
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
        Me.ogdListadoArchivos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ogdCorreos = New ISL.Controles.OrigenDatos(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.agrAdjunto = New ISL.Controles.Agrupacion(Me.components)
        Me.txtMensajeExtra = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.WebBrowser()
        Me.txtPara = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lstBusqueda = New System.Windows.Forms.ListBox()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.lstAdjuntados = New System.Windows.Forms.ListBox()
        Me.txtAsunto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCCO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtDe = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.BtnEnviar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdjuntar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.groupConfirmar = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnConfirmarAtras = New Infragistics.Win.Misc.UltraButton()
        Me.groupDatosCorreo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.ogdListadoArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdCorreos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrAdjunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrAdjunto.SuspendLayout()
        CType(Me.txtPara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupConfirmar.SuspendLayout()
        CType(Me.groupDatosCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupDatosCorreo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ogdListadoArchivos
        '
        UltraDataColumn5.DataType = GetType(Boolean)
        UltraDataColumn5.DefaultValue = False
        Me.ogdListadoArchivos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "")
        Me.imagenes.Images.SetKeyName(1, "")
        Me.imagenes.Images.SetKeyName(2, "")
        Me.imagenes.Images.SetKeyName(3, "")
        Me.imagenes.Images.SetKeyName(4, "")
        Me.imagenes.Images.SetKeyName(5, "")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        Me.imagenes.Images.SetKeyName(12, "01_messages.ico")
        '
        'ogdCorreos
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        Me.ogdCorreos.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'agrAdjunto
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.agrAdjunto.ContentAreaAppearance = Appearance1
        Me.agrAdjunto.Controls.Add(Me.txtMensajeExtra)
        Me.agrAdjunto.Controls.Add(Me.txtMensaje)
        Me.agrAdjunto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.agrAdjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrAdjunto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrAdjunto.Location = New System.Drawing.Point(0, 177)
        Me.agrAdjunto.Name = "agrAdjunto"
        Me.agrAdjunto.Size = New System.Drawing.Size(984, 384)
        Me.agrAdjunto.TabIndex = 1
        Me.agrAdjunto.Text = "Mensaje de Correo"
        Me.agrAdjunto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtMensajeExtra
        '
        Me.txtMensajeExtra.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMensajeExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensajeExtra.Location = New System.Drawing.Point(3, 16)
        Me.txtMensajeExtra.Multiline = True
        Me.txtMensajeExtra.Name = "txtMensajeExtra"
        Me.txtMensajeExtra.Size = New System.Drawing.Size(978, 74)
        Me.txtMensajeExtra.TabIndex = 15
        '
        'txtMensaje
        '
        Me.txtMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtMensaje.Location = New System.Drawing.Point(3, 89)
        Me.txtMensaje.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(978, 292)
        Me.txtMensaje.TabIndex = 0
        '
        'txtPara
        '
        Me.txtPara.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtPara.Location = New System.Drawing.Point(71, 31)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(452, 21)
        Me.txtPara.TabIndex = 3
        '
        'lstBusqueda
        '
        Me.lstBusqueda.FormattingEnabled = True
        Me.lstBusqueda.Location = New System.Drawing.Point(71, 53)
        Me.lstBusqueda.Name = "lstBusqueda"
        Me.lstBusqueda.Size = New System.Drawing.Size(377, 82)
        Me.lstBusqueda.TabIndex = 5
        Me.lstBusqueda.Visible = False
        '
        'UltraButton1
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.UltraButton1.Location = New System.Drawing.Point(575, 37)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(88, 28)
        Me.UltraButton1.TabIndex = 12
        Me.UltraButton1.Text = "Quitar"
        '
        'lstAdjuntados
        '
        Me.lstAdjuntados.FormattingEnabled = True
        Me.lstAdjuntados.Location = New System.Drawing.Point(670, 5)
        Me.lstAdjuntados.Name = "lstAdjuntados"
        Me.lstAdjuntados.Size = New System.Drawing.Size(208, 69)
        Me.lstAdjuntados.TabIndex = 11
        '
        'txtAsunto
        '
        Me.txtAsunto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtAsunto.Location = New System.Drawing.Point(70, 106)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(452, 21)
        Me.txtAsunto.TabIndex = 9
        '
        'txtCCO
        '
        Me.txtCCO.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCCO.Location = New System.Drawing.Point(70, 81)
        Me.txtCCO.Name = "txtCCO"
        Me.txtCCO.Size = New System.Drawing.Size(452, 21)
        Me.txtCCO.TabIndex = 7
        '
        'txtCC
        '
        Me.txtCC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCC.Location = New System.Drawing.Point(70, 57)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(452, 21)
        Me.txtCC.TabIndex = 14
        '
        'txtDe
        '
        Me.txtDe.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDe.Enabled = False
        Me.txtDe.Location = New System.Drawing.Point(71, 7)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(452, 21)
        Me.txtDe.TabIndex = 1
        '
        'BtnEnviar
        '
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.send_email
        Me.BtnEnviar.Appearance = Appearance3
        Me.BtnEnviar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.BtnEnviar.ImageSize = New System.Drawing.Size(25, 25)
        Me.BtnEnviar.Location = New System.Drawing.Point(541, 87)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(127, 39)
        Me.BtnEnviar.TabIndex = 13
        Me.BtnEnviar.Text = "Enviar"
        '
        'btnAdjuntar
        '
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.attachment
        Me.btnAdjuntar.Appearance = Appearance4
        Me.btnAdjuntar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.btnAdjuntar.Location = New System.Drawing.Point(575, 5)
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(88, 28)
        Me.btnAdjuntar.TabIndex = 10
        Me.btnAdjuntar.Text = "Adjuntar"
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.Image = Global.ISL.Win.My.Resources.Resources.user_group
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(17, 84)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel5.TabIndex = 6
        Me.UltraLabel5.Text = "CCO:"
        '
        'UltraLabel4
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.Image = Global.ISL.Win.My.Resources.Resources.user_blue
        Appearance6.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(19, 30)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(47, 16)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Para:"
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.user_male_add
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(24, 58)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "CC:"
        '
        'UltraLabel1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.note
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 111)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(59, 16)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Asunto:"
        '
        'UltraLabel16
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.Image = Global.ISL.Win.My.Resources.Resources.user_male_edit
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance9
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.ImageList = Me.imagenes
        Me.UltraLabel16.Location = New System.Drawing.Point(27, 6)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(38, 16)
        Me.UltraLabel16.TabIndex = 0
        Me.UltraLabel16.Text = "De:"
        '
        'groupConfirmar
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.groupConfirmar.Appearance = Appearance10
        Me.groupConfirmar.Controls.Add(Me.btnConfirmarAtras)
        Me.groupConfirmar.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupConfirmar.Location = New System.Drawing.Point(0, 0)
        Me.groupConfirmar.Name = "groupConfirmar"
        Me.groupConfirmar.Size = New System.Drawing.Size(984, 36)
        Me.groupConfirmar.TabIndex = 16
        Me.groupConfirmar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.groupConfirmar.Visible = False
        '
        'btnConfirmarAtras
        '
        Me.btnConfirmarAtras.Location = New System.Drawing.Point(25, 6)
        Me.btnConfirmarAtras.Name = "btnConfirmarAtras"
        Me.btnConfirmarAtras.Size = New System.Drawing.Size(92, 24)
        Me.btnConfirmarAtras.TabIndex = 0
        Me.btnConfirmarAtras.Text = "Confirmar"
        '
        'groupDatosCorreo
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.groupDatosCorreo.ContentAreaAppearance = Appearance11
        Me.groupDatosCorreo.Controls.Add(Me.txtPara)
        Me.groupDatosCorreo.Controls.Add(Me.UltraLabel16)
        Me.groupDatosCorreo.Controls.Add(Me.lstBusqueda)
        Me.groupDatosCorreo.Controls.Add(Me.UltraLabel1)
        Me.groupDatosCorreo.Controls.Add(Me.UltraButton1)
        Me.groupDatosCorreo.Controls.Add(Me.UltraLabel3)
        Me.groupDatosCorreo.Controls.Add(Me.lstAdjuntados)
        Me.groupDatosCorreo.Controls.Add(Me.UltraLabel4)
        Me.groupDatosCorreo.Controls.Add(Me.txtAsunto)
        Me.groupDatosCorreo.Controls.Add(Me.UltraLabel5)
        Me.groupDatosCorreo.Controls.Add(Me.txtCCO)
        Me.groupDatosCorreo.Controls.Add(Me.btnAdjuntar)
        Me.groupDatosCorreo.Controls.Add(Me.txtCC)
        Me.groupDatosCorreo.Controls.Add(Me.BtnEnviar)
        Me.groupDatosCorreo.Controls.Add(Me.txtDe)
        Me.groupDatosCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupDatosCorreo.Location = New System.Drawing.Point(0, 36)
        Me.groupDatosCorreo.Name = "groupDatosCorreo"
        Me.groupDatosCorreo.Size = New System.Drawing.Size(984, 141)
        Me.groupDatosCorreo.TabIndex = 17
        Me.groupDatosCorreo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(261, 246)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(392, 68)
        Me.ugb_Espera.TabIndex = 18
        Me.ugb_Espera.Visible = False
        '
        'frm_EnvioEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.groupDatosCorreo)
        Me.Controls.Add(Me.groupConfirmar)
        Me.Controls.Add(Me.agrAdjunto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_EnvioEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        CType(Me.ogdListadoArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdCorreos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrAdjunto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrAdjunto.ResumeLayout(False)
        Me.agrAdjunto.PerformLayout()
        CType(Me.txtPara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupConfirmar.ResumeLayout(False)
        CType(Me.groupDatosCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupDatosCorreo.ResumeLayout(False)
        Me.groupDatosCorreo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrAdjunto As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdListadoArchivos As ISL.Controles.OrigenDatos
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdCorreos As ISL.Controles.OrigenDatos
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAdjuntar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnEnviar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtAsunto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCCO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDe As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMensaje As System.Windows.Forms.WebBrowser
    Friend WithEvents lstBusqueda As System.Windows.Forms.ListBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lstAdjuntados As System.Windows.Forms.ListBox
    Friend WithEvents txtPara As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMensajeExtra As System.Windows.Forms.TextBox
    Friend WithEvents groupConfirmar As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnConfirmarAtras As Infragistics.Win.Misc.UltraButton
    Friend WithEvents groupDatosCorreo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
