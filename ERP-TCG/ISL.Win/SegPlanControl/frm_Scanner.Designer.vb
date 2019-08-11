<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Scanner
    Inherits System.Windows.Forms.Form

    ''Form reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    ''Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer

    ''NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    ''Se puede modificar usando el Diseñador de Windows Forms.  
    ''No lo modifique con el editor de código.
    '<System.Diagnostics.DebuggerStepThrough()> _
    'Private Sub InitializeComponent()
    '    components = New System.ComponentModel.Container
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.Text = "frm_Scanner"
    'End Sub

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents SourceList As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents VersionText As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HideUI As System.Windows.Forms.CheckBox
    Friend WithEvents RotLeft As System.Windows.Forms.Button
    Friend WithEvents RotRight As System.Windows.Forms.Button
    Friend WithEvents SaveToFile As System.Windows.Forms.Button
    Friend WithEvents LoadFile As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SourceList = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VersionText = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HideUI = New System.Windows.Forms.CheckBox()
        Me.RotLeft = New System.Windows.Forms.Button()
        Me.RotRight = New System.Windows.Forms.Button()
        Me.SaveToFile = New System.Windows.Forms.Button()
        Me.LoadFile = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SourceList
        '
        Me.SourceList.Location = New System.Drawing.Point(13, 28)
        Me.SourceList.Name = "SourceList"
        Me.SourceList.Size = New System.Drawing.Size(200, 121)
        Me.SourceList.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 21)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Seleccionar Origen"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 20)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Escanear"
        '
        'Pic
        '
        Me.Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic.Location = New System.Drawing.Point(227, 28)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(415, 450)
        Me.Pic.TabIndex = 3
        Me.Pic.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dispositivo Origen:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(227, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vista Previa:"
        '
        'VersionText
        '
        Me.VersionText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VersionText.Location = New System.Drawing.Point(13, 492)
        Me.VersionText.Name = "VersionText"
        Me.VersionText.Size = New System.Drawing.Size(207, 20)
        Me.VersionText.TabIndex = 4
        Me.VersionText.Text = "Versión..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HideUI)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 90)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escaner"
        '
        'HideUI
        '
        Me.HideUI.Location = New System.Drawing.Point(13, 21)
        Me.HideUI.Name = "HideUI"
        Me.HideUI.Size = New System.Drawing.Size(181, 21)
        Me.HideUI.TabIndex = 0
        Me.HideUI.Text = "Ocultar Dialogo de Dispositivo"
        '
        'RotLeft
        '
        Me.RotLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RotLeft.Location = New System.Drawing.Point(227, 485)
        Me.RotLeft.Name = "RotLeft"
        Me.RotLeft.Size = New System.Drawing.Size(101, 21)
        Me.RotLeft.TabIndex = 6
        Me.RotLeft.Text = "Rotar Izquierda"
        '
        'RotRight
        '
        Me.RotRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RotRight.Location = New System.Drawing.Point(329, 485)
        Me.RotRight.Name = "RotRight"
        Me.RotRight.Size = New System.Drawing.Size(101, 21)
        Me.RotRight.TabIndex = 6
        Me.RotRight.Text = "Rotar Derecha"
        '
        'SaveToFile
        '
        Me.SaveToFile.Location = New System.Drawing.Point(13, 305)
        Me.SaveToFile.Name = "SaveToFile"
        Me.SaveToFile.Size = New System.Drawing.Size(127, 21)
        Me.SaveToFile.TabIndex = 2
        Me.SaveToFile.Text = "Guardar Imagen"
        '
        'LoadFile
        '
        Me.LoadFile.Location = New System.Drawing.Point(13, 333)
        Me.LoadFile.Name = "LoadFile"
        Me.LoadFile.Size = New System.Drawing.Size(127, 21)
        Me.LoadFile.TabIndex = 2
        Me.LoadFile.Text = "Buscar Imagen"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 406)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 21)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(12, 433)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 21)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        '
        'frm_Scanner
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 520)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SourceList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VersionText)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RotLeft)
        Me.Controls.Add(Me.RotRight)
        Me.Controls.Add(Me.SaveToFile)
        Me.Controls.Add(Me.LoadFile)
        Me.Name = "frm_Scanner"
        Me.Text = "Scan"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

#End Region
End Class
