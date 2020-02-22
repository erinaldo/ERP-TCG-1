<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentoAnulado
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDocAnulados = New ISL.Controles.Grilla(Me.components)
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.fecEmision = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDoc = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficDocAnulado = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDocAnulados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDocAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDocAnulado.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDocAnulados)
        Me.UltraTabPageControl1.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(882, 358)
        '
        'griDocAnulados
        '
        Me.griDocAnulados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocAnulados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocAnulados.Location = New System.Drawing.Point(0, 47)
        Me.griDocAnulados.Name = "griDocAnulados"
        Me.griDocAnulados.Size = New System.Drawing.Size(882, 311)
        Me.griDocAnulados.TabIndex = 1
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.cboTipoDocumento)
        Me.agrBusqueda.Controls.Add(Me.fecHasta)
        Me.agrBusqueda.Controls.Add(Me.fecDesde)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(882, 47)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipoDocumento
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance1
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(394, 11)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(162, 21)
        Me.cboTipoDocumento.TabIndex = 5
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(206, 11)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(85, 20)
        Me.fecHasta.TabIndex = 4
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(72, 11)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(85, 20)
        Me.fecDesde.TabIndex = 3
        '
        'Etiqueta3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance2
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(297, 15)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Tipo Documento:"
        '
        'Etiqueta2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance3
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(163, 15)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Hasta:"
        '
        'Etiqueta1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance4
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(26, 15)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Desde:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(882, 358)
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.fecEmision)
        Me.agrDatos.Controls.Add(Me.Etiqueta9)
        Me.agrDatos.Controls.Add(Me.txtNumero)
        Me.agrDatos.Controls.Add(Me.Etiqueta8)
        Me.agrDatos.Controls.Add(Me.txtSerie)
        Me.agrDatos.Controls.Add(Me.Etiqueta7)
        Me.agrDatos.Controls.Add(Me.cboTipoDoc)
        Me.agrDatos.Controls.Add(Me.Etiqueta6)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(882, 130)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecEmision
        '
        Me.fecEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecEmision.Location = New System.Drawing.Point(120, 87)
        Me.fecEmision.Name = "fecEmision"
        Me.fecEmision.Size = New System.Drawing.Size(80, 20)
        Me.fecEmision.TabIndex = 7
        '
        'Etiqueta9
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance5
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(31, 89)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta9.TabIndex = 6
        Me.Etiqueta9.Text = "Fecha Emision:"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(235, 60)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(83, 21)
        Me.txtNumero.TabIndex = 5
        '
        'Etiqueta8
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance6
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(185, 64)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta8.TabIndex = 4
        Me.Etiqueta8.Text = "Numero:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(118, 60)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(45, 21)
        Me.txtSerie.TabIndex = 3
        '
        'Etiqueta7
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance7
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(80, 64)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Serie:"
        '
        'cboTipoDoc
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDoc.Appearance = Appearance8
        Me.cboTipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDoc.Location = New System.Drawing.Point(118, 33)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoDoc.TabIndex = 1
        Me.cboTipoDoc.ValueMember = "Id"
        '
        'Etiqueta6
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance9
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(23, 37)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Tipo Documento:"
        '
        'ficDocAnulado
        '
        Me.ficDocAnulado.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDocAnulado.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDocAnulado.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDocAnulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDocAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDocAnulado.Location = New System.Drawing.Point(0, 0)
        Me.ficDocAnulado.Name = "ficDocAnulado"
        Me.ficDocAnulado.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDocAnulado.Size = New System.Drawing.Size(884, 381)
        Me.ficDocAnulado.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficDocAnulado.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDocAnulado.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(882, 358)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_DocumentoAnulado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 381)
        Me.Controls.Add(Me.ficDocAnulado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_DocumentoAnulado"
        Me.Text = "Documentos Anulados"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDocAnulados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDocAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDocAnulado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDocAnulado As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDocAnulados As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDoc As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
