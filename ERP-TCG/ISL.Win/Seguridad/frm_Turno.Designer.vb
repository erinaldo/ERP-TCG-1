<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Turno
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraSalida")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraInicio")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraSalida")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrTurno = New ISL.Controles.Agrupacion(Me.components)
        Me.griTurno = New ISL.Controles.Grilla(Me.components)
        Me.ordTurno = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDatoTurno = New ISL.Controles.Agrupacion(Me.components)
        Me.fecHorSalida = New System.Windows.Forms.DateTimePicker
        Me.fecHorInicio = New System.Windows.Forms.DateTimePicker
        Me.cboTurno = New ISL.Controles.Combo(Me.components)
        Me.etiTurno = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDia = New ISL.Controles.Combo(Me.components)
        Me.etiDia = New ISL.Controles.Etiqueta(Me.components)
        Me.HoraSalida = New ISL.Controles.Etiqueta(Me.components)
        Me.etiHoraInicio = New ISL.Controles.Etiqueta(Me.components)
        Me.ficTurno = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiInsertar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTurno.SuspendLayout()
        CType(Me.griTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatoTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoTurno.SuspendLayout()
        CType(Me.cboTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficTurno.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrTurno)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(613, 384)
        '
        'agrTurno
        '
        Me.agrTurno.Controls.Add(Me.griTurno)
        Me.agrTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTurno.ForeColor = System.Drawing.Color.Black
        Me.agrTurno.Location = New System.Drawing.Point(0, 0)
        Me.agrTurno.Name = "agrTurno"
        Me.agrTurno.Size = New System.Drawing.Size(613, 384)
        Me.agrTurno.TabIndex = 1
        Me.agrTurno.Text = "Lista de Turnos"
        Me.agrTurno.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griTurno
        '
        Me.griTurno.DataSource = Me.ordTurno
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTurno.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTurno.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTurno.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTurno.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTurno.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTurno.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTurno.Location = New System.Drawing.Point(2, 18)
        Me.griTurno.Name = "griTurno"
        Me.griTurno.Size = New System.Drawing.Size(609, 364)
        Me.griTurno.TabIndex = 0
        '
        'ordTurno
        '
        Me.ordTurno.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoTurno)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(613, 384)
        '
        'agrDatoTurno
        '
        Me.agrDatoTurno.Controls.Add(Me.fecHorSalida)
        Me.agrDatoTurno.Controls.Add(Me.fecHorInicio)
        Me.agrDatoTurno.Controls.Add(Me.cboTurno)
        Me.agrDatoTurno.Controls.Add(Me.etiTurno)
        Me.agrDatoTurno.Controls.Add(Me.cboDia)
        Me.agrDatoTurno.Controls.Add(Me.etiDia)
        Me.agrDatoTurno.Controls.Add(Me.HoraSalida)
        Me.agrDatoTurno.Controls.Add(Me.etiHoraInicio)
        Me.agrDatoTurno.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoTurno.ForeColor = System.Drawing.Color.Black
        Me.agrDatoTurno.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoTurno.Name = "agrDatoTurno"
        Me.agrDatoTurno.Size = New System.Drawing.Size(613, 177)
        Me.agrDatoTurno.TabIndex = 0
        Me.agrDatoTurno.Text = "Datos:"
        Me.agrDatoTurno.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'fecHorSalida
        '
        Me.fecHorSalida.CustomFormat = "HH:mm:ss"
        Me.fecHorSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHorSalida.Location = New System.Drawing.Point(102, 64)
        Me.fecHorSalida.Name = "fecHorSalida"
        Me.fecHorSalida.ShowUpDown = True
        Me.fecHorSalida.Size = New System.Drawing.Size(70, 20)
        Me.fecHorSalida.TabIndex = 9
        '
        'fecHorInicio
        '
        Me.fecHorInicio.CustomFormat = "HH:mm:ss"
        Me.fecHorInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHorInicio.Location = New System.Drawing.Point(102, 37)
        Me.fecHorInicio.Name = "fecHorInicio"
        Me.fecHorInicio.ShowUpDown = True
        Me.fecHorInicio.Size = New System.Drawing.Size(70, 20)
        Me.fecHorInicio.TabIndex = 8
        '
        'cboTurno
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboTurno.Appearance = Appearance3
        Me.cboTurno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTurno.ForeColor = System.Drawing.Color.Black
        Me.cboTurno.Location = New System.Drawing.Point(102, 117)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(144, 21)
        Me.cboTurno.TabIndex = 7
        Me.cboTurno.ValueMember = "Id"
        '
        'etiTurno
        '
        Me.etiTurno.AutoSize = True
        Me.etiTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTurno.ForeColor = System.Drawing.Color.Black
        Me.etiTurno.Location = New System.Drawing.Point(60, 121)
        Me.etiTurno.Name = "etiTurno"
        Me.etiTurno.Size = New System.Drawing.Size(36, 14)
        Me.etiTurno.TabIndex = 6
        Me.etiTurno.Text = "Turno:"
        '
        'cboDia
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboDia.Appearance = Appearance4
        Me.cboDia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDia.ForeColor = System.Drawing.Color.Black
        Me.cboDia.Location = New System.Drawing.Point(102, 90)
        Me.cboDia.Name = "cboDia"
        Me.cboDia.Size = New System.Drawing.Size(144, 21)
        Me.cboDia.TabIndex = 5
        Me.cboDia.ValueMember = "Id"
        '
        'etiDia
        '
        Me.etiDia.AutoSize = True
        Me.etiDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDia.ForeColor = System.Drawing.Color.Black
        Me.etiDia.Location = New System.Drawing.Point(72, 94)
        Me.etiDia.Name = "etiDia"
        Me.etiDia.Size = New System.Drawing.Size(24, 14)
        Me.etiDia.TabIndex = 4
        Me.etiDia.Text = "Día:"
        '
        'HoraSalida
        '
        Me.HoraSalida.AutoSize = True
        Me.HoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraSalida.ForeColor = System.Drawing.Color.Black
        Me.HoraSalida.Location = New System.Drawing.Point(32, 67)
        Me.HoraSalida.Name = "HoraSalida"
        Me.HoraSalida.Size = New System.Drawing.Size(64, 14)
        Me.HoraSalida.TabIndex = 1
        Me.HoraSalida.Text = "Hora Salida:"
        '
        'etiHoraInicio
        '
        Me.etiHoraInicio.AutoSize = True
        Me.etiHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiHoraInicio.ForeColor = System.Drawing.Color.Black
        Me.etiHoraInicio.Location = New System.Drawing.Point(36, 40)
        Me.etiHoraInicio.Name = "etiHoraInicio"
        Me.etiHoraInicio.Size = New System.Drawing.Size(60, 14)
        Me.etiHoraInicio.TabIndex = 0
        Me.etiHoraInicio.Text = "Hora Inicio:"
        '
        'ficTurno
        '
        Me.ficTurno.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficTurno.Controls.Add(Me.UltraTabPageControl1)
        Me.ficTurno.Controls.Add(Me.UltraTabPageControl2)
        Me.ficTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficTurno.Location = New System.Drawing.Point(0, 0)
        Me.ficTurno.Name = "ficTurno"
        Me.ficTurno.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficTurno.Size = New System.Drawing.Size(615, 407)
        Me.ficTurno.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficTurno.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficTurno.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(613, 384)
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInsertar, Me.tsmiActualizar, Me.tsmiEliminar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'tsmiInsertar
        '
        Me.tsmiInsertar.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiInsertar.Name = "tsmiInsertar"
        Me.tsmiInsertar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiInsertar.Text = "Insertar"
        '
        'tsmiActualizar
        '
        Me.tsmiActualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiActualizar.Name = "tsmiActualizar"
        Me.tsmiActualizar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiActualizar.Text = "Actualizar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'frm_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 407)
        Me.Controls.Add(Me.ficTurno)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Turno"
        Me.Text = "Registrar Turno"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTurno.ResumeLayout(False)
        CType(Me.griTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatoTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoTurno.ResumeLayout(False)
        Me.agrDatoTurno.PerformLayout()
        CType(Me.cboTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficTurno.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficTurno As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griTurno As ISL.Controles.Grilla
    Friend WithEvents agrTurno As ISL.Controles.Agrupacion
    Friend WithEvents agrDatoTurno As ISL.Controles.Agrupacion
    Friend WithEvents HoraSalida As ISL.Controles.Etiqueta
    Friend WithEvents etiHoraInicio As ISL.Controles.Etiqueta
    Friend WithEvents cboDia As ISL.Controles.Combo
    Friend WithEvents etiDia As ISL.Controles.Etiqueta
    Friend WithEvents cboTurno As ISL.Controles.Combo
    Friend WithEvents etiTurno As ISL.Controles.Etiqueta
    Friend WithEvents ordTurno As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecHorInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHorSalida As System.Windows.Forms.DateTimePicker
End Class
