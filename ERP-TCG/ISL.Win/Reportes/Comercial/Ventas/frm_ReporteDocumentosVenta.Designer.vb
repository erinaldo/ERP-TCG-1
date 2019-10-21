<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteDocumentosVenta
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDocumento = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDatoBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.cboEstadoDocumento = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ficDocVenta = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoBusqueda.SuspendLayout()
        CType(Me.cboEstadoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDocVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDocVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDocumento)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(797, 403)
        '
        'griDocumento
        '
        Me.griDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumento.Location = New System.Drawing.Point(0, 0)
        Me.griDocumento.Name = "griDocumento"
        Me.griDocumento.Size = New System.Drawing.Size(797, 403)
        Me.griDocumento.TabIndex = 1
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(797, 403)
        '
        'agrDatoBusqueda
        '
        Me.agrDatoBusqueda.Controls.Add(Me.cboEstadoDocumento)
        Me.agrDatoBusqueda.Controls.Add(Me.Etiqueta4)
        Me.agrDatoBusqueda.Controls.Add(Me.cboTipoDocumento)
        Me.agrDatoBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrDatoBusqueda.Controls.Add(Me.fecHasta)
        Me.agrDatoBusqueda.Controls.Add(Me.fecDesde)
        Me.agrDatoBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrDatoBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrDatoBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrDatoBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoBusqueda.Name = "agrDatoBusqueda"
        Me.agrDatoBusqueda.Size = New System.Drawing.Size(799, 57)
        Me.agrDatoBusqueda.TabIndex = 0
        Me.agrDatoBusqueda.Text = "Datos de Búsqueda"
        Me.agrDatoBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboEstadoDocumento
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoDocumento.Appearance = Appearance1
        Me.cboEstadoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoDocumento.Location = New System.Drawing.Point(661, 22)
        Me.cboEstadoDocumento.Name = "cboEstadoDocumento"
        Me.cboEstadoDocumento.Size = New System.Drawing.Size(118, 21)
        Me.cboEstadoDocumento.TabIndex = 7
        Me.cboEstadoDocumento.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance2
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(614, 26)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Estado:"
        '
        'cboTipoDocumento
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance3
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(457, 22)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(153, 21)
        Me.cboTipoDocumento.TabIndex = 5
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance4
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(363, 26)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(88, 14)
        Me.Etiqueta3.TabIndex = 4
        Me.Etiqueta3.Text = "Tipo Documento:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(264, 24)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(93, 20)
        Me.fecHasta.TabIndex = 3
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(90, 24)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(93, 20)
        Me.fecDesde.TabIndex = 2
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(189, 26)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Fecha Hasta:"
        '
        'Etiqueta1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance6
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(12, 26)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Fecha Desde:"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ficDocVenta
        '
        Me.ficDocVenta.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDocVenta.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDocVenta.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDocVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDocVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDocVenta.Location = New System.Drawing.Point(0, 57)
        Me.ficDocVenta.Name = "ficDocVenta"
        Me.ficDocVenta.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDocVenta.Size = New System.Drawing.Size(799, 426)
        Me.ficDocVenta.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Consolidado por Serie"
        Me.ficDocVenta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDocVenta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(797, 403)
        '
        'frm_ReporteDocumentosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 483)
        Me.Controls.Add(Me.ficDocVenta)
        Me.Controls.Add(Me.agrDatoBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteDocumentosVenta"
        Me.Text = "Reporte de Documentos de Venta"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoBusqueda.ResumeLayout(False)
        Me.agrDatoBusqueda.PerformLayout()
        CType(Me.cboEstadoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDocVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDocVenta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatoBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents griDocumento As ISL.Controles.Grilla
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoDocumento As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ficDocVenta As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
End Class
