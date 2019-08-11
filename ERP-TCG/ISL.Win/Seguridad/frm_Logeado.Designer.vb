<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Logeado
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ampliacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSalida")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ampliacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Salida")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrLogeo = New ISL.Controles.Agrupacion(Me.components)
        Me.griLogeo = New ISL.Controles.Grilla(Me.components)
        Me.ordLogeo = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaFin = New ISL.Controles.Fecha(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrHistorial = New ISL.Controles.Agrupacion(Me.components)
        Me.verUsuario = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboUsuario = New ISL.Controles.Combo(Me.components)
        Me.etiSalida = New ISL.Controles.Etiqueta(Me.components)
        Me.colorSalida = New ISL.Controles.Colores(Me.components)
        Me.etiFecha = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFecha = New ISL.Controles.Fecha(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDato = New ISL.Controles.Agrupacion(Me.components)
        Me.verSalida = New ISL.Controles.Chequear(Me.components)
        Me.etiMinutos = New ISL.Controles.Etiqueta(Me.components)
        Me.numAmpliacion = New ISL.Controles.Numero(Me.components)
        Me.fecFechaSalida = New ISL.Controles.Fecha(Me.components)
        Me.fecFechaInicio = New ISL.Controles.Fecha(Me.components)
        Me.txtNombreCompleto = New ISL.Controles.Texto(Me.components)
        Me.etiAmpliacion = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaSalida = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaInicio = New ISL.Controles.Etiqueta(Me.components)
        Me.etiUsuario = New ISL.Controles.Etiqueta(Me.components)
        Me.ficLogeo = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrLogeo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLogeo.SuspendLayout()
        CType(Me.griLogeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordLogeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.fecFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrHistorial.SuspendLayout()
        CType(Me.verUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDato.SuspendLayout()
        CType(Me.verSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmpliacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCompleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficLogeo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficLogeo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrLogeo)
        Me.UltraTabPageControl1.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(975, 383)
        '
        'agrLogeo
        '
        Me.agrLogeo.Controls.Add(Me.griLogeo)
        Me.agrLogeo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrLogeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLogeo.ForeColor = System.Drawing.Color.Black
        Me.agrLogeo.Location = New System.Drawing.Point(0, 77)
        Me.agrLogeo.Name = "agrLogeo"
        Me.agrLogeo.Size = New System.Drawing.Size(975, 306)
        Me.agrLogeo.TabIndex = 2
        Me.agrLogeo.Text = "Lista de Logeo"
        Me.agrLogeo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griLogeo
        '
        Me.griLogeo.DataSource = Me.ordLogeo
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 88
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 92
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 199
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 288
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn13.Width = 144
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn14.Width = 144
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn15.Width = 67
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 7
        UltraGridColumn16.Width = 45
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLogeo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLogeo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLogeo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLogeo.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griLogeo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLogeo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLogeo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLogeo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griLogeo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLogeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLogeo.Location = New System.Drawing.Point(2, 18)
        Me.griLogeo.Name = "griLogeo"
        Me.griLogeo.Size = New System.Drawing.Size(971, 286)
        Me.griLogeo.TabIndex = 0
        '
        'ordLogeo
        '
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Short)
        UltraDataColumn8.DataType = GetType(Boolean)
        Me.ordLogeo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Controls.Add(Me.fecFechaFin)
        Me.agrBusqueda.Controls.Add(Me.cboArea)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.agrHistorial)
        Me.agrBusqueda.Controls.Add(Me.etiFecha)
        Me.agrBusqueda.Controls.Add(Me.fecFecha)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(975, 77)
        Me.agrBusqueda.TabIndex = 1
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(212, 26)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(11, 14)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "A"
        '
        'fecFechaFin
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.fecFechaFin.Appearance = Appearance1
        Me.fecFechaFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaFin.ForeColor = System.Drawing.Color.Black
        Me.fecFechaFin.Location = New System.Drawing.Point(246, 22)
        Me.fecFechaFin.Name = "fecFechaFin"
        Me.fecFechaFin.Size = New System.Drawing.Size(102, 21)
        Me.fecFechaFin.TabIndex = 7
        '
        'cboArea
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance2
        Me.cboArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(91, 48)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(257, 21)
        Me.cboArea.TabIndex = 6
        Me.cboArea.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(54, 52)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Area:"
        '
        'agrHistorial
        '
        Me.agrHistorial.Controls.Add(Me.verUsuario)
        Me.agrHistorial.Controls.Add(Me.Etiqueta1)
        Me.agrHistorial.Controls.Add(Me.cboUsuario)
        Me.agrHistorial.Controls.Add(Me.etiSalida)
        Me.agrHistorial.Controls.Add(Me.colorSalida)
        Me.agrHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrHistorial.ForeColor = System.Drawing.Color.Black
        Me.agrHistorial.Location = New System.Drawing.Point(381, 22)
        Me.agrHistorial.Name = "agrHistorial"
        Me.agrHistorial.Size = New System.Drawing.Size(433, 51)
        Me.agrHistorial.TabIndex = 4
        Me.agrHistorial.Text = "       Logeo de Usuario:"
        Me.agrHistorial.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'verUsuario
        '
        Me.verUsuario.AutoSize = True
        Me.verUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verUsuario.ForeColor = System.Drawing.Color.Black
        Me.verUsuario.Location = New System.Drawing.Point(10, 2)
        Me.verUsuario.Name = "verUsuario"
        Me.verUsuario.Size = New System.Drawing.Size(14, 13)
        Me.verUsuario.TabIndex = 5
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(18, 22)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta1.TabIndex = 5
        Me.Etiqueta1.Text = "Usuario:"
        '
        'cboUsuario
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Appearance = Appearance3
        Me.cboUsuario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboUsuario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUsuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuario.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Location = New System.Drawing.Point(69, 18)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(257, 21)
        Me.cboUsuario.TabIndex = 4
        Me.cboUsuario.ValueMember = "Id"
        '
        'etiSalida
        '
        Me.etiSalida.AutoSize = True
        Me.etiSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSalida.ForeColor = System.Drawing.Color.Black
        Me.etiSalida.Location = New System.Drawing.Point(332, 22)
        Me.etiSalida.Name = "etiSalida"
        Me.etiSalida.Size = New System.Drawing.Size(38, 14)
        Me.etiSalida.TabIndex = 3
        Me.etiSalida.Text = "Salida:"
        '
        'colorSalida
        '
        Me.colorSalida.Location = New System.Drawing.Point(376, 18)
        Me.colorSalida.Name = "colorSalida"
        Me.colorSalida.Size = New System.Drawing.Size(43, 21)
        Me.colorSalida.TabIndex = 2
        Me.colorSalida.Text = "Control"
        '
        'etiFecha
        '
        Me.etiFecha.AutoSize = True
        Me.etiFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecha.ForeColor = System.Drawing.Color.Black
        Me.etiFecha.Location = New System.Drawing.Point(11, 26)
        Me.etiFecha.Name = "etiFecha"
        Me.etiFecha.Size = New System.Drawing.Size(73, 14)
        Me.etiFecha.TabIndex = 1
        Me.etiFecha.Text = "Rango Fecha:"
        '
        'fecFecha
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.fecFecha.Appearance = Appearance4
        Me.fecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFecha.ForeColor = System.Drawing.Color.Black
        Me.fecFecha.Location = New System.Drawing.Point(91, 22)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(102, 21)
        Me.fecFecha.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDato)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(975, 383)
        '
        'agrDato
        '
        Me.agrDato.Controls.Add(Me.verSalida)
        Me.agrDato.Controls.Add(Me.etiMinutos)
        Me.agrDato.Controls.Add(Me.numAmpliacion)
        Me.agrDato.Controls.Add(Me.fecFechaSalida)
        Me.agrDato.Controls.Add(Me.fecFechaInicio)
        Me.agrDato.Controls.Add(Me.txtNombreCompleto)
        Me.agrDato.Controls.Add(Me.etiAmpliacion)
        Me.agrDato.Controls.Add(Me.etiFechaSalida)
        Me.agrDato.Controls.Add(Me.etiFechaInicio)
        Me.agrDato.Controls.Add(Me.etiUsuario)
        Me.agrDato.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDato.ForeColor = System.Drawing.Color.Black
        Me.agrDato.Location = New System.Drawing.Point(0, 0)
        Me.agrDato.Name = "agrDato"
        Me.agrDato.Size = New System.Drawing.Size(975, 179)
        Me.agrDato.TabIndex = 0
        Me.agrDato.Text = "Datos:"
        Me.agrDato.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'verSalida
        '
        Me.verSalida.AutoSize = True
        Me.verSalida.Enabled = False
        Me.verSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verSalida.ForeColor = System.Drawing.Color.Black
        Me.verSalida.Location = New System.Drawing.Point(99, 138)
        Me.verSalida.Name = "verSalida"
        Me.verSalida.Size = New System.Drawing.Size(52, 17)
        Me.verSalida.TabIndex = 9
        Me.verSalida.Text = "Salida"
        '
        'etiMinutos
        '
        Me.etiMinutos.AutoSize = True
        Me.etiMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiMinutos.ForeColor = System.Drawing.Color.Black
        Me.etiMinutos.Location = New System.Drawing.Point(162, 115)
        Me.etiMinutos.Name = "etiMinutos"
        Me.etiMinutos.Size = New System.Drawing.Size(43, 14)
        Me.etiMinutos.TabIndex = 8
        Me.etiMinutos.Text = "minutos"
        '
        'numAmpliacion
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.numAmpliacion.Appearance = Appearance5
        Me.numAmpliacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAmpliacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAmpliacion.ForeColor = System.Drawing.Color.Black
        Me.numAmpliacion.Location = New System.Drawing.Point(99, 111)
        Me.numAmpliacion.Name = "numAmpliacion"
        Me.numAmpliacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numAmpliacion.Size = New System.Drawing.Size(57, 21)
        Me.numAmpliacion.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAmpliacion.TabIndex = 7
        '
        'fecFechaSalida
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.fecFechaSalida.Appearance = Appearance6
        Me.fecFechaSalida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaSalida.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaSalida.ForeColor = System.Drawing.Color.Black
        Me.fecFechaSalida.Location = New System.Drawing.Point(99, 84)
        Me.fecFechaSalida.MaskInput = "{date} {time}"
        Me.fecFechaSalida.Name = "fecFechaSalida"
        Me.fecFechaSalida.ReadOnly = True
        Me.fecFechaSalida.Size = New System.Drawing.Size(144, 21)
        Me.fecFechaSalida.TabIndex = 6
        '
        'fecFechaInicio
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.fecFechaInicio.Appearance = Appearance7
        Me.fecFechaInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaInicio.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.fecFechaInicio.Location = New System.Drawing.Point(99, 57)
        Me.fecFechaInicio.MaskInput = "{date} {time}"
        Me.fecFechaInicio.Name = "fecFechaInicio"
        Me.fecFechaInicio.ReadOnly = True
        Me.fecFechaInicio.Size = New System.Drawing.Size(144, 21)
        Me.fecFechaInicio.TabIndex = 5
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCompleto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(99, 30)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(330, 21)
        Me.txtNombreCompleto.TabIndex = 4
        '
        'etiAmpliacion
        '
        Me.etiAmpliacion.AutoSize = True
        Me.etiAmpliacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAmpliacion.ForeColor = System.Drawing.Color.Black
        Me.etiAmpliacion.Location = New System.Drawing.Point(32, 115)
        Me.etiAmpliacion.Name = "etiAmpliacion"
        Me.etiAmpliacion.Size = New System.Drawing.Size(61, 14)
        Me.etiAmpliacion.TabIndex = 3
        Me.etiAmpliacion.Text = "Ampliación:"
        '
        'etiFechaSalida
        '
        Me.etiFechaSalida.AutoSize = True
        Me.etiFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaSalida.ForeColor = System.Drawing.Color.Black
        Me.etiFechaSalida.Location = New System.Drawing.Point(25, 88)
        Me.etiFechaSalida.Name = "etiFechaSalida"
        Me.etiFechaSalida.Size = New System.Drawing.Size(68, 14)
        Me.etiFechaSalida.TabIndex = 2
        Me.etiFechaSalida.Text = "FechaSalida:"
        '
        'etiFechaInicio
        '
        Me.etiFechaInicio.AutoSize = True
        Me.etiFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.etiFechaInicio.Location = New System.Drawing.Point(27, 61)
        Me.etiFechaInicio.Name = "etiFechaInicio"
        Me.etiFechaInicio.Size = New System.Drawing.Size(66, 14)
        Me.etiFechaInicio.TabIndex = 1
        Me.etiFechaInicio.Text = "Fecha Inicio:"
        '
        'etiUsuario
        '
        Me.etiUsuario.AutoSize = True
        Me.etiUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiUsuario.ForeColor = System.Drawing.Color.Black
        Me.etiUsuario.Location = New System.Drawing.Point(48, 34)
        Me.etiUsuario.Name = "etiUsuario"
        Me.etiUsuario.Size = New System.Drawing.Size(45, 14)
        Me.etiUsuario.TabIndex = 0
        Me.etiUsuario.Text = "Usuario:"
        '
        'ficLogeo
        '
        Me.ficLogeo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficLogeo.Controls.Add(Me.UltraTabPageControl1)
        Me.ficLogeo.Controls.Add(Me.UltraTabPageControl2)
        Me.ficLogeo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficLogeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficLogeo.Location = New System.Drawing.Point(0, 0)
        Me.ficLogeo.Name = "ficLogeo"
        Me.ficLogeo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficLogeo.Size = New System.Drawing.Size(977, 406)
        Me.ficLogeo.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficLogeo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficLogeo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(975, 383)
        '
        'frm_Logeado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 406)
        Me.Controls.Add(Me.ficLogeo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Logeado"
        Me.Text = "Registro de Logeos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrLogeo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLogeo.ResumeLayout(False)
        CType(Me.griLogeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordLogeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.fecFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrHistorial.ResumeLayout(False)
        Me.agrHistorial.PerformLayout()
        CType(Me.verUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDato.ResumeLayout(False)
        Me.agrDato.PerformLayout()
        CType(Me.verSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmpliacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCompleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficLogeo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficLogeo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficLogeo As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griLogeo As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ordLogeo As ISL.Controles.OrigenDatos
    Friend WithEvents agrDato As ISL.Controles.Agrupacion
    Friend WithEvents etiAmpliacion As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaSalida As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaInicio As ISL.Controles.Etiqueta
    Friend WithEvents etiUsuario As ISL.Controles.Etiqueta
    Friend WithEvents txtNombreCompleto As ISL.Controles.Texto
    Friend WithEvents verSalida As ISL.Controles.Chequear
    Friend WithEvents etiMinutos As ISL.Controles.Etiqueta
    Friend WithEvents numAmpliacion As ISL.Controles.Numero
    Friend WithEvents fecFechaSalida As ISL.Controles.Fecha
    Friend WithEvents fecFechaInicio As ISL.Controles.Fecha
    Friend WithEvents agrLogeo As ISL.Controles.Agrupacion
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents etiFecha As ISL.Controles.Etiqueta
    Friend WithEvents fecFecha As ISL.Controles.Fecha
    Friend WithEvents etiSalida As ISL.Controles.Etiqueta
    Friend WithEvents colorSalida As ISL.Controles.Colores
    Friend WithEvents agrHistorial As ISL.Controles.Agrupacion
    Friend WithEvents verUsuario As ISL.Controles.Chequear
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboUsuario As ISL.Controles.Combo
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaFin As ISL.Controles.Fecha
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
