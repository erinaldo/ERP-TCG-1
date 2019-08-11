<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ParticipacionAcciones
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDoc")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDoc")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Accionista")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAcciones")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcParticipacion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDoc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAcc")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaBaja")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ParticipacionAcciones))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.ugParticipantes = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.decCapitalB = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.decValorB = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.FechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.eFechaBaja = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.txtDocumento = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroAccion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDoc = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoAccion = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficParticipacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ugParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.decCapitalB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValorB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficParticipacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficParticipacion.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(907, 384)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.ugParticipantes)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(907, 384)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ugParticipantes
        '
        Me.ugParticipantes.ContextMenuStrip = Me.MenuContextual1
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn1.Header.Caption = "Tipo Doc."
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn1.Width = 141
        UltraGridColumn2.Header.Caption = "Nro. Doc."
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.Width = 83
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Width = 325
        UltraGridColumn4.Header.Caption = "Tipo Acción"
        UltraGridColumn4.Header.VisiblePosition = 6
        UltraGridColumn4.Width = 326
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance1
        UltraGridColumn5.Header.Caption = "Nro. Acciones"
        UltraGridColumn5.Header.VisiblePosition = 7
        UltraGridColumn5.MaskInput = "{double:9.2}"
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 90
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.Header.Caption = "% Participación"
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn6.MaskInput = "{double:9.2}"
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 93
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Codigo Doc."
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Width = 71
        UltraGridColumn16.Header.Caption = "Codigo Acc."
        UltraGridColumn16.Header.VisiblePosition = 5
        UltraGridColumn16.Width = 78
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn11, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.ugParticipantes.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugParticipantes.DisplayLayout.MaxColScrollRegions = 1
        Me.ugParticipantes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugParticipantes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugParticipantes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.ugParticipantes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.ugParticipantes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ugParticipantes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugParticipantes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.ugParticipantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugParticipantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugParticipantes.Location = New System.Drawing.Point(2, 65)
        Me.ugParticipantes.Name = "ugParticipantes"
        Me.ugParticipantes.Size = New System.Drawing.Size(903, 317)
        Me.ugParticipantes.TabIndex = 232
        Me.ugParticipantes.Text = "Información de Accionistas"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.decCapitalB)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion3.Controls.Add(Me.decValorB)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(903, 63)
        Me.Agrupacion3.TabIndex = 231
        Me.Agrupacion3.Text = "Búsqueda"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decCapitalB
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.decCapitalB.Appearance = Appearance3
        Me.decCapitalB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCapitalB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decCapitalB.ForeColor = System.Drawing.Color.Black
        Me.decCapitalB.Location = New System.Drawing.Point(67, 24)
        Me.decCapitalB.MaskInput = "{double:-9.2}"
        Me.decCapitalB.Name = "decCapitalB"
        Me.decCapitalB.Nullable = True
        Me.decCapitalB.NullText = "0.00"
        Me.decCapitalB.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decCapitalB.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decCapitalB.ReadOnly = True
        Me.decCapitalB.Size = New System.Drawing.Size(90, 22)
        Me.decCapitalB.TabIndex = 247
        Me.decCapitalB.TabStop = False
        '
        'Etiqueta10
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance4
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(16, 28)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta10.TabIndex = 246
        Me.Etiqueta10.Text = "Capital:"
        '
        'decValorB
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.decValorB.Appearance = Appearance5
        Me.decValorB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decValorB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorB.ForeColor = System.Drawing.Color.Black
        Me.decValorB.Location = New System.Drawing.Point(253, 24)
        Me.decValorB.MaskInput = "{double:-9.2}"
        Me.decValorB.Name = "decValorB"
        Me.decValorB.Nullable = True
        Me.decValorB.NullText = "0.00"
        Me.decValorB.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorB.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decValorB.ReadOnly = True
        Me.decValorB.Size = New System.Drawing.Size(90, 22)
        Me.decValorB.TabIndex = 247
        Me.decValorB.TabStop = False
        '
        'Etiqueta7
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance6
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(174, 28)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta7.TabIndex = 246
        Me.Etiqueta7.Text = "Valor Acción:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(907, 384)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ugb_Espera)
        Me.Agrupacion2.Controls.Add(Me.FechaBaja)
        Me.Agrupacion2.Controls.Add(Me.eFechaBaja)
        Me.Agrupacion2.Controls.Add(Me.Fecha)
        Me.Agrupacion2.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion2.Controls.Add(Me.txtDocumento)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion2.Controls.Add(Me.txtNroAccion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion2.Controls.Add(Me.cboTipoDoc)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion2.Controls.Add(Me.cboTipoAccion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(907, 384)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(256, 195)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 8
        Me.ugb_Espera.Visible = False
        '
        'FechaBaja
        '
        Me.FechaBaja.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaBaja.Location = New System.Drawing.Point(365, 135)
        Me.FechaBaja.Name = "FechaBaja"
        Me.FechaBaja.Size = New System.Drawing.Size(79, 20)
        Me.FechaBaja.TabIndex = 249
        '
        'eFechaBaja
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.eFechaBaja.Appearance = Appearance7
        Me.eFechaBaja.AutoSize = True
        Me.eFechaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eFechaBaja.ForeColor = System.Drawing.Color.Black
        Me.eFechaBaja.Location = New System.Drawing.Point(292, 139)
        Me.eFechaBaja.Name = "eFechaBaja"
        Me.eFechaBaja.Size = New System.Drawing.Size(67, 14)
        Me.eFechaBaja.TabIndex = 248
        Me.eFechaBaja.Text = "Fecha Baja:"
        '
        'Fecha
        '
        Me.Fecha.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha.Location = New System.Drawing.Point(110, 133)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(79, 20)
        Me.Fecha.TabIndex = 247
        '
        'cboTrabajador
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance8
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance9.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance9
        Me.cboTrabajador.ButtonsRight.Add(EditorButton1)
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Location = New System.Drawing.Point(110, 31)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(334, 22)
        Me.cboTrabajador.TabIndex = 246
        Me.cboTrabajador.ValueMember = "Id"
        '
        'txtDocumento
        '
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(110, 82)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.ReadOnly = True
        Me.txtDocumento.Size = New System.Drawing.Size(139, 22)
        Me.txtDocumento.TabIndex = 238
        '
        'Etiqueta5
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance10
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(33, 86)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta5.TabIndex = 237
        Me.Etiqueta5.Text = "Documento:"
        '
        'txtNroAccion
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.txtNroAccion.Appearance = Appearance11
        Me.txtNroAccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroAccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroAccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroAccion.Location = New System.Drawing.Point(344, 82)
        Me.txtNroAccion.Name = "txtNroAccion"
        Me.txtNroAccion.Size = New System.Drawing.Size(100, 22)
        Me.txtNroAccion.TabIndex = 236
        Me.txtNroAccion.Text = "0"
        '
        'Etiqueta6
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance12
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(256, 86)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta6.TabIndex = 1
        Me.Etiqueta6.Text = "Nro. Acciones:"
        '
        'cboTipoDoc
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDoc.Appearance = Appearance13
        Me.cboTipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDoc.Location = New System.Drawing.Point(110, 57)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(334, 21)
        Me.cboTipoDoc.TabIndex = 235
        Me.cboTipoDoc.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance14
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(7, 61)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(94, 14)
        Me.Etiqueta11.TabIndex = 1
        Me.Etiqueta11.Text = "Tipo Documento:"
        '
        'cboTipoAccion
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoAccion.Appearance = Appearance15
        Me.cboTipoAccion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoAccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoAccion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoAccion.Location = New System.Drawing.Point(110, 108)
        Me.cboTipoAccion.Name = "cboTipoAccion"
        Me.cboTipoAccion.Size = New System.Drawing.Size(334, 21)
        Me.cboTipoAccion.TabIndex = 235
        Me.cboTipoAccion.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance16
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(61, 136)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta12.TabIndex = 1
        Me.Etiqueta12.Text = "Fecha:"
        '
        'Etiqueta4
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance17
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(16, 112)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta4.TabIndex = 1
        Me.Etiqueta4.Text = "Tipo de Acción:"
        '
        'Etiqueta2
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance18
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(36, 38)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Trabajador:"
        '
        'ficParticipacion
        '
        Me.ficParticipacion.Controls.Add(Me.UltraTabPageControl1)
        Me.ficParticipacion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficParticipacion.Controls.Add(Me.UltraTabPageControl2)
        Me.ficParticipacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficParticipacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficParticipacion.Location = New System.Drawing.Point(0, 0)
        Me.ficParticipacion.Name = "ficParticipacion"
        Me.ficParticipacion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficParticipacion.Size = New System.Drawing.Size(909, 407)
        Me.ficParticipacion.TabIndex = 4
        UltraTab5.Key = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Lista"
        UltraTab6.Key = "Mantenimiento"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Mantenimiento"
        Me.ficParticipacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.ficParticipacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(907, 384)
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(153, 92)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        Me.NuevoToolStripMenuItem.ToolTipText = "Solicitar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        Me.EditarToolStripMenuItem.ToolTipText = "Evaluar "
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'frm_ParticipacionAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(909, 407)
        Me.Controls.Add(Me.ficParticipacion)
        Me.Name = "frm_ParticipacionAcciones"
        Me.Text = "Participación de Acciones"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.ugParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.decCapitalB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValorB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroAccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficParticipacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficParticipacion.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficParticipacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents ugParticipantes As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoAccion As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroAccion As ISL.Controles.Texto
    Friend WithEvents txtDocumento As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents decCapitalB As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents decValorB As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDoc As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents FechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents eFechaBaja As ISL.Controles.Etiqueta
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
