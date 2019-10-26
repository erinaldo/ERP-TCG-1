<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IntegrarGrupo
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Selec")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Selec")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdResponsable")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrupo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Responsable")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Selec")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConcepto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdResponsable")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrupo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Responsable")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Concepto")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Selec")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griGrupoSancion = New ISL.Controles.Grilla(Me.components)
        Me.mnuIntegrarGrupo = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiIntegrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odIntegrar = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrBsuqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDatosProcesar = New ISL.Controles.Agrupacion(Me.components)
        Me.griSancion = New ISL.Controles.Grilla(Me.components)
        Me.agrDatosAdicionales = New ISL.Controles.Agrupacion(Me.components)
        Me.cboMedioPago = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.fecIntegracion = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficIntegrarGrupo = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griGrupoSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuIntegrarGrupo.SuspendLayout()
        CType(Me.odIntegrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBsuqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBsuqueda.SuspendLayout()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatosProcesar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosProcesar.SuspendLayout()
        CType(Me.griSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosAdicionales.SuspendLayout()
        CType(Me.cboMedioPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficIntegrarGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficIntegrarGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griGrupoSancion)
        Me.UltraTabPageControl1.Controls.Add(Me.agrBsuqueda)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(935, 440)
        '
        'griGrupoSancion
        '
        Me.griGrupoSancion.ContextMenuStrip = Me.mnuIntegrarGrupo
        Me.griGrupoSancion.DataSource = Me.odIntegrar
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 63
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 127
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 67
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 303
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance1
        UltraGridColumn7.Format = "#,##0.00"
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 94
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Width = 215
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Width = 246
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridColumn16.Header.VisiblePosition = 5
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn22.Width = 67
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.Width = 127
        UltraGridColumn24.Header.VisiblePosition = 8
        UltraGridColumn24.Width = 215
        UltraGridColumn25.Header.VisiblePosition = 9
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 10
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 14
        UltraGridColumn30.Width = 303
        UltraGridColumn31.Header.VisiblePosition = 15
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 16
        UltraGridColumn32.Width = 94
        UltraGridColumn33.Header.VisiblePosition = 17
        UltraGridColumn33.Width = 246
        UltraGridColumn34.Header.VisiblePosition = 18
        UltraGridColumn34.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        Me.griGrupoSancion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griGrupoSancion.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griGrupoSancion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGrupoSancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGrupoSancion.Location = New System.Drawing.Point(0, 56)
        Me.griGrupoSancion.Name = "griGrupoSancion"
        Me.griGrupoSancion.Size = New System.Drawing.Size(935, 384)
        Me.griGrupoSancion.TabIndex = 1
        '
        'mnuIntegrarGrupo
        '
        Me.mnuIntegrarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuIntegrarGrupo.ForeColor = System.Drawing.Color.Black
        Me.mnuIntegrarGrupo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiIntegrar})
        Me.mnuIntegrarGrupo.Name = "mnuIntegrarGrupo"
        Me.mnuIntegrarGrupo.Size = New System.Drawing.Size(111, 26)
        '
        'tsmiIntegrar
        '
        Me.tsmiIntegrar.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.tsmiIntegrar.Name = "tsmiIntegrar"
        Me.tsmiIntegrar.Size = New System.Drawing.Size(110, 22)
        Me.tsmiIntegrar.Text = "Integrar"
        '
        'odIntegrar
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Date)
        UltraDataColumn11.DataType = GetType(Date)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        Me.odIntegrar.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn20.DataType = GetType(Boolean)
        UltraDataColumn24.DataType = GetType(Date)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Boolean)
        UltraDataColumn29.DataType = GetType(Date)
        Me.odIntegrar.Band.Columns.AddRange(New Object() {UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'agrBsuqueda
        '
        Me.agrBsuqueda.Controls.Add(Me.cboArea)
        Me.agrBsuqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBsuqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBsuqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBsuqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBsuqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBsuqueda.Name = "agrBsuqueda"
        Me.agrBsuqueda.Size = New System.Drawing.Size(935, 56)
        Me.agrBsuqueda.TabIndex = 0
        Me.agrBsuqueda.Text = "Busqueda:"
        Me.agrBsuqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboArea
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance2
        Me.cboArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(64, 23)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(267, 21)
        Me.cboArea.TabIndex = 1
        Me.cboArea.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(27, 27)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(31, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Area:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatosProcesar)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatosAdicionales)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(935, 440)
        '
        'agrDatosProcesar
        '
        Me.agrDatosProcesar.Controls.Add(Me.griSancion)
        Me.agrDatosProcesar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDatosProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosProcesar.ForeColor = System.Drawing.Color.Black
        Me.agrDatosProcesar.Location = New System.Drawing.Point(0, 59)
        Me.agrDatosProcesar.Name = "agrDatosProcesar"
        Me.agrDatosProcesar.Size = New System.Drawing.Size(935, 381)
        Me.agrDatosProcesar.TabIndex = 1
        Me.agrDatosProcesar.Text = "Datos a Procesar:"
        Me.agrDatosProcesar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griSancion
        '
        Me.griSancion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSancion.Location = New System.Drawing.Point(3, 16)
        Me.griSancion.Name = "griSancion"
        Me.griSancion.Size = New System.Drawing.Size(929, 362)
        Me.griSancion.TabIndex = 0
        '
        'agrDatosAdicionales
        '
        Me.agrDatosAdicionales.Controls.Add(Me.cboMedioPago)
        Me.agrDatosAdicionales.Controls.Add(Me.Etiqueta1)
        Me.agrDatosAdicionales.Controls.Add(Me.decTipoCambio)
        Me.agrDatosAdicionales.Controls.Add(Me.fecIntegracion)
        Me.agrDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.agrDatosAdicionales.Controls.Add(Me.Etiqueta4)
        Me.agrDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosAdicionales.ForeColor = System.Drawing.Color.Black
        Me.agrDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosAdicionales.Name = "agrDatosAdicionales"
        Me.agrDatosAdicionales.Size = New System.Drawing.Size(935, 59)
        Me.agrDatosAdicionales.TabIndex = 0
        Me.agrDatosAdicionales.Text = "Datos Adicionales:"
        Me.agrDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboMedioPago
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboMedioPago.Appearance = Appearance4
        Me.cboMedioPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedioPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedioPago.ForeColor = System.Drawing.Color.Black
        Me.cboMedioPago.Location = New System.Drawing.Point(422, 25)
        Me.cboMedioPago.Name = "cboMedioPago"
        Me.cboMedioPago.Size = New System.Drawing.Size(236, 21)
        Me.cboMedioPago.TabIndex = 5
        Me.cboMedioPago.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(333, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Medio de Pago:"
        '
        'decTipoCambio
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Appearance = Appearance6
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Location = New System.Drawing.Point(227, 25)
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.NullText = "0.00"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTipoCambio.Size = New System.Drawing.Size(100, 21)
        Me.decTipoCambio.TabIndex = 3
        '
        'fecIntegracion
        '
        Me.fecIntegracion.CustomFormat = ""
        Me.fecIntegracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecIntegracion.Location = New System.Drawing.Point(64, 26)
        Me.fecIntegracion.Name = "fecIntegracion"
        Me.fecIntegracion.Size = New System.Drawing.Size(79, 20)
        Me.fecIntegracion.TabIndex = 1
        '
        'Etiqueta5
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance7
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(149, 29)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Tipo Cambio:"
        '
        'Etiqueta4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance8
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(19, 29)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Fecha:"
        '
        'ficIntegrarGrupo
        '
        Me.ficIntegrarGrupo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficIntegrarGrupo.Controls.Add(Me.UltraTabPageControl1)
        Me.ficIntegrarGrupo.Controls.Add(Me.UltraTabPageControl2)
        Me.ficIntegrarGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficIntegrarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficIntegrarGrupo.Location = New System.Drawing.Point(0, 0)
        Me.ficIntegrarGrupo.Name = "ficIntegrarGrupo"
        Me.ficIntegrarGrupo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficIntegrarGrupo.Size = New System.Drawing.Size(937, 463)
        Me.ficIntegrarGrupo.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficIntegrarGrupo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficIntegrarGrupo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(935, 440)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_IntegrarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 463)
        Me.Controls.Add(Me.ficIntegrarGrupo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_IntegrarGrupo"
        Me.Text = "Integracion de Grupo"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griGrupoSancion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuIntegrarGrupo.ResumeLayout(False)
        CType(Me.odIntegrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBsuqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBsuqueda.ResumeLayout(False)
        Me.agrBsuqueda.PerformLayout()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatosProcesar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosProcesar.ResumeLayout(False)
        CType(Me.griSancion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosAdicionales.ResumeLayout(False)
        Me.agrDatosAdicionales.PerformLayout()
        CType(Me.cboMedioPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficIntegrarGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficIntegrarGrupo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficIntegrarGrupo As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griGrupoSancion As ISL.Controles.Grilla
    Friend WithEvents agrBsuqueda As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents griSancion As ISL.Controles.Grilla
    Friend WithEvents mnuIntegrarGrupo As ISL.Controles.MenuContextual
    Friend WithEvents tsmiIntegrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odIntegrar As ISL.Controles.OrigenDatos
    Friend WithEvents agrDatosProcesar As ISL.Controles.Agrupacion
    Friend WithEvents agrDatosAdicionales As ISL.Controles.Agrupacion
    Friend WithEvents decTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents fecIntegracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboMedioPago As ISL.Controles.Combo
End Class
