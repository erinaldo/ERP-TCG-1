<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Autorizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Autorizacion))
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.txtClave = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboJefeArea = New ISL.Controles.ComboMaestros(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtMotivoGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.txtClave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJefeArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtMotivoGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Appearance1.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnCancelar.Appearance = Appearance1
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancelar.Location = New System.Drawing.Point(205, 114)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance2
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAceptar.Location = New System.Drawing.Point(89, 114)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "&Aceptar"
        '
        'txtClave
        '
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClave.Appearance = Appearance3
        Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClave.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(79, 35)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(150, 21)
        Me.txtClave.TabIndex = 16
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(4, 39)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel1.TabIndex = 15
        Me.UltraLabel1.Text = "Clave Autoriz:"
        '
        'cboJefeArea
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboJefeArea.Appearance = Appearance5
        Me.cboJefeArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboJefeArea.DisplayMember = "Nombre"
        Me.cboJefeArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboJefeArea.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboJefeArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJefeArea.ForeColor = System.Drawing.Color.Black
        Me.cboJefeArea.ImageList = Me.imagenes
        Me.cboJefeArea.Location = New System.Drawing.Point(79, 11)
        Me.cboJefeArea.Name = "cboJefeArea"
        Me.cboJefeArea.Size = New System.Drawing.Size(300, 21)
        Me.cboJefeArea.TabIndex = 14
        Me.cboJefeArea.ValueMember = "Id"
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
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'UltraLabel28
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance6
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(23, 15)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel28.TabIndex = 13
        Me.UltraLabel28.Text = "Jefe Area:"
        '
        'Agrupacion1
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance7
        Me.Agrupacion1.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion1.Controls.Add(Me.txtMotivoGlosa)
        Me.Agrupacion1.Controls.Add(Me.btnCancelar)
        Me.Agrupacion1.Controls.Add(Me.cboJefeArea)
        Me.Agrupacion1.Controls.Add(Me.btnAceptar)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel28)
        Me.Agrupacion1.Controls.Add(Me.txtClave)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(384, 161)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(5, 61)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 20
        Me.UltraLabel2.Text = "Motivo Glosa:"
        '
        'txtMotivoGlosa
        '
        Me.txtMotivoGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoGlosa.Enabled = False
        Me.txtMotivoGlosa.Location = New System.Drawing.Point(79, 58)
        Me.txtMotivoGlosa.Multiline = True
        Me.txtMotivoGlosa.Name = "txtMotivoGlosa"
        Me.txtMotivoGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoGlosa.Size = New System.Drawing.Size(300, 45)
        Me.txtMotivoGlosa.TabIndex = 19
        '
        'frm_Autorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.Agrupacion1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Autorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizacion"
        CType(Me.txtClave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJefeArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtMotivoGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents cboJefeArea As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtClave As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMotivoGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
