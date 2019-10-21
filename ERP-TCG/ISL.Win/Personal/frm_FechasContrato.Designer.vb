<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FechasContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FechasContrato))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.Datos = New ISL.Controles.Agrupacion(Me.components)
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.numSueldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecInicio = New System.Windows.Forms.DateTimePicker()
        Me.fecTermino = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Datos.SuspendLayout()
        CType(Me.numSueldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.Boton1)
        Me.Datos.Controls.Add(Me.btnAprobar)
        Me.Datos.Controls.Add(Me.numSueldo)
        Me.Datos.Controls.Add(Me.Etiqueta6)
        Me.Datos.Controls.Add(Me.fecInicio)
        Me.Datos.Controls.Add(Me.fecTermino)
        Me.Datos.Controls.Add(Me.Etiqueta4)
        Me.Datos.Controls.Add(Me.Etiqueta5)
        Me.Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datos.ForeColor = System.Drawing.Color.Black
        Me.Datos.Location = New System.Drawing.Point(0, 0)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(345, 131)
        Me.Datos.TabIndex = 0
        Me.Datos.Text = "Datos"
        Me.Datos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Boton1
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance1.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.Boton1.Appearance = Appearance1
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.Location = New System.Drawing.Point(249, 72)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(78, 27)
        Me.Boton1.TabIndex = 4
        Me.Boton1.Text = "Cancelar"
        Me.Boton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAprobar
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnAprobar.Appearance = Appearance2
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.Location = New System.Drawing.Point(249, 29)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(78, 27)
        Me.btnAprobar.TabIndex = 0
        Me.btnAprobar.Text = "Aceptar"
        Me.btnAprobar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'numSueldo
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.numSueldo.Appearance = Appearance3
        Me.numSueldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSueldo.ForeColor = System.Drawing.Color.Black
        Me.numSueldo.FormatString = "#,##0.00"
        Me.numSueldo.Location = New System.Drawing.Point(104, 85)
        Me.numSueldo.Name = "numSueldo"
        Me.numSueldo.Nullable = True
        Me.numSueldo.NullText = "0.00"
        Me.numSueldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numSueldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numSueldo.Size = New System.Drawing.Size(88, 21)
        Me.numSueldo.TabIndex = 3
        '
        'Etiqueta6
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance4
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(57, 89)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta6.TabIndex = 339
        Me.Etiqueta6.Text = "Sueldo:"
        '
        'fecInicio
        '
        Me.fecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicio.Location = New System.Drawing.Point(104, 25)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(110, 20)
        Me.fecInicio.TabIndex = 1
        '
        'fecTermino
        '
        Me.fecTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecTermino.Location = New System.Drawing.Point(104, 56)
        Me.fecTermino.Name = "fecTermino"
        Me.fecTermino.Size = New System.Drawing.Size(110, 20)
        Me.fecTermino.TabIndex = 2
        '
        'Etiqueta4
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance5
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(32, 29)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta4.TabIndex = 336
        Me.Etiqueta4.Text = "Fecha Inicio:"
        '
        'Etiqueta5
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance6
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(17, 58)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta5.TabIndex = 337
        Me.Etiqueta5.Text = "Fecha Termino:"
        '
        'frm_FechasContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 131)
        Me.Controls.Add(Me.Datos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FechasContrato"
        Me.Text = "Fechas Contrato Nuevo"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.numSueldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents Datos As ISL.Controles.Agrupacion
    Friend WithEvents Boton1 As ISL.Controles.Boton
    Friend WithEvents btnAprobar As ISL.Controles.Boton
    Friend WithEvents numSueldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
End Class
