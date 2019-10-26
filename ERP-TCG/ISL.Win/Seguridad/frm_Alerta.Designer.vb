<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Alerta
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividadNegocio")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActividadNegocio")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeAlertaDetalle")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActividadNegocio")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ActividadNegocio")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oeAlertaDetalle")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlerta")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlerta")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ApellidoPaterno")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ApellidoMaterno")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaNacimiento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ApellidoPaterno")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ApellidoMaterno")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaNacimiento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sexo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlerta")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Visual")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sonora")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlerta")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Email")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visual")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sonora")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrAlerta = New ISL.Controles.Agrupacion(Me.components)
        Me.griAlerta = New ISL.Controles.Grilla(Me.components)
        Me.ordAlerta = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDestino = New ISL.Controles.Agrupacion(Me.components)
        Me.spcDestino = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.griAlertaDestino = New ISL.Controles.Grilla(Me.components)
        Me.ordAlertaDestino = New ISL.Controles.OrigenDatos(Me.components)
        Me.panDerecha = New System.Windows.Forms.Panel
        Me.btnMostrarOcultar = New ISL.Controles.Boton(Me.components)
        Me.griEmail = New ISL.Controles.Grilla(Me.components)
        Me.ordPersona = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.spcAlerta = New System.Windows.Forms.SplitContainer
        Me.cboActividadNegocio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verSonora = New ISL.Controles.Chequear(Me.components)
        Me.verVisual = New ISL.Controles.Chequear(Me.components)
        Me.verEmail = New ISL.Controles.Chequear(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.etiGlosa = New ISL.Controles.Etiqueta(Me.components)
        Me.btnMostrar = New ISL.Controles.Boton(Me.components)
        Me.griAlertaHistorial = New ISL.Controles.Grilla(Me.components)
        Me.ordAlertaDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.ficAlerta = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiAtender = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTerminar = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrAlerta.SuspendLayout()
        CType(Me.griAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDestino.SuspendLayout()
        Me.spcDestino.Panel1.SuspendLayout()
        Me.spcDestino.Panel2.SuspendLayout()
        Me.spcDestino.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.griAlertaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordAlertaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panDerecha.SuspendLayout()
        CType(Me.griEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        Me.spcAlerta.Panel1.SuspendLayout()
        Me.spcAlerta.Panel2.SuspendLayout()
        Me.spcAlerta.SuspendLayout()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verSonora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verVisual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAlertaHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordAlertaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficAlerta.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrAlerta)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1016, 483)
        '
        'agrAlerta
        '
        Me.agrAlerta.Controls.Add(Me.griAlerta)
        Me.agrAlerta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrAlerta.ForeColor = System.Drawing.Color.Black
        Me.agrAlerta.Location = New System.Drawing.Point(0, 0)
        Me.agrAlerta.Name = "agrAlerta"
        Me.agrAlerta.Size = New System.Drawing.Size(1016, 483)
        Me.agrAlerta.TabIndex = 0
        Me.agrAlerta.Text = "Listado Alerta"
        Me.agrAlerta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griAlerta
        '
        Me.griAlerta.DataSource = Me.ordAlerta
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Width = 308
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 190
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 294
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.griAlerta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griAlerta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlerta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlerta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlerta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAlerta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlerta.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griAlerta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlerta.Location = New System.Drawing.Point(2, 18)
        Me.griAlerta.Name = "griAlerta"
        Me.griAlerta.Size = New System.Drawing.Size(1012, 463)
        Me.griAlerta.TabIndex = 0
        '
        'ordAlerta
        '
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn9.DataType = GetType(Boolean)
        Me.ordAlerta.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDestino)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1016, 483)
        '
        'agrDestino
        '
        Me.agrDestino.Controls.Add(Me.spcDestino)
        Me.agrDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDestino.ForeColor = System.Drawing.Color.Black
        Me.agrDestino.Location = New System.Drawing.Point(0, 251)
        Me.agrDestino.Name = "agrDestino"
        Me.agrDestino.Size = New System.Drawing.Size(1016, 232)
        Me.agrDestino.TabIndex = 1
        Me.agrDestino.Text = "Enviar a:"
        Me.agrDestino.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'spcDestino
        '
        Me.spcDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcDestino.Location = New System.Drawing.Point(2, 18)
        Me.spcDestino.Name = "spcDestino"
        '
        'spcDestino.Panel1
        '
        Me.spcDestino.Panel1.Controls.Add(Me.Panel1)
        Me.spcDestino.Panel1.Controls.Add(Me.panDerecha)
        '
        'spcDestino.Panel2
        '
        Me.spcDestino.Panel2.Controls.Add(Me.griEmail)
        Me.spcDestino.Size = New System.Drawing.Size(1012, 212)
        Me.spcDestino.SplitterDistance = 503
        Me.spcDestino.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.griAlertaDestino)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 212)
        Me.Panel1.TabIndex = 1
        '
        'griAlertaDestino
        '
        Me.griAlertaDestino.DataSource = Me.ordAlertaDestino
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.Width = 296
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridColumn17.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        UltraGridBand2.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlertaDestino.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griAlertaDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlertaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlertaDestino.Location = New System.Drawing.Point(0, 0)
        Me.griAlertaDestino.Name = "griAlertaDestino"
        Me.griAlertaDestino.Size = New System.Drawing.Size(486, 212)
        Me.griAlertaDestino.TabIndex = 0
        '
        'ordAlertaDestino
        '
        UltraDataColumn15.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.ordAlertaDestino.Band.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'panDerecha
        '
        Me.panDerecha.Controls.Add(Me.btnMostrarOcultar)
        Me.panDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.panDerecha.Location = New System.Drawing.Point(486, 0)
        Me.panDerecha.Name = "panDerecha"
        Me.panDerecha.Size = New System.Drawing.Size(17, 212)
        Me.panDerecha.TabIndex = 0
        '
        'btnMostrarOcultar
        '
        Me.btnMostrarOcultar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarOcultar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnMostrarOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarOcultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarOcultar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnMostrarOcultar.Location = New System.Drawing.Point(2, 43)
        Me.btnMostrarOcultar.Name = "btnMostrarOcultar"
        Me.btnMostrarOcultar.Size = New System.Drawing.Size(15, 130)
        Me.btnMostrarOcultar.TabIndex = 3
        Me.btnMostrarOcultar.Text = "<>"
        '
        'griEmail
        '
        Me.griEmail.DataSource = Me.ordPersona
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Width = 312
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 9
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        UltraGridBand3.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griEmail.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griEmail.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griEmail.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griEmail.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griEmail.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griEmail.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEmail.Location = New System.Drawing.Point(0, 0)
        Me.griEmail.Name = "griEmail"
        Me.griEmail.Size = New System.Drawing.Size(505, 212)
        Me.griEmail.TabIndex = 0
        '
        'ordPersona
        '
        Me.ordPersona.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29})
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.spcAlerta)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(1016, 251)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos Alerta"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'spcAlerta
        '
        Me.spcAlerta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcAlerta.Location = New System.Drawing.Point(2, 18)
        Me.spcAlerta.Name = "spcAlerta"
        '
        'spcAlerta.Panel1
        '
        Me.spcAlerta.Panel1.Controls.Add(Me.cboActividadNegocio)
        Me.spcAlerta.Panel1.Controls.Add(Me.Etiqueta1)
        Me.spcAlerta.Panel1.Controls.Add(Me.verSonora)
        Me.spcAlerta.Panel1.Controls.Add(Me.verVisual)
        Me.spcAlerta.Panel1.Controls.Add(Me.verEmail)
        Me.spcAlerta.Panel1.Controls.Add(Me.txtGlosa)
        Me.spcAlerta.Panel1.Controls.Add(Me.etiGlosa)
        Me.spcAlerta.Panel1.Controls.Add(Me.btnMostrar)
        '
        'spcAlerta.Panel2
        '
        Me.spcAlerta.Panel2.Controls.Add(Me.griAlertaHistorial)
        Me.spcAlerta.Size = New System.Drawing.Size(1012, 231)
        Me.spcAlerta.SplitterDistance = 504
        Me.spcAlerta.TabIndex = 0
        '
        'cboActividadNegocio
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Appearance = Appearance1
        Me.cboActividadNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboActividadNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Location = New System.Drawing.Point(127, 34)
        Me.cboActividadNegocio.Name = "cboActividadNegocio"
        Me.cboActividadNegocio.Size = New System.Drawing.Size(328, 21)
        Me.cboActividadNegocio.TabIndex = 11
        Me.cboActividadNegocio.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 38)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(110, 14)
        Me.Etiqueta1.TabIndex = 10
        Me.Etiqueta1.Text = "Actividad de Negocio:"
        '
        'verSonora
        '
        Me.verSonora.AutoSize = True
        Me.verSonora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verSonora.ForeColor = System.Drawing.Color.Black
        Me.verSonora.Location = New System.Drawing.Point(307, 152)
        Me.verSonora.Name = "verSonora"
        Me.verSonora.Size = New System.Drawing.Size(56, 17)
        Me.verSonora.TabIndex = 9
        Me.verSonora.Text = "Sonora"
        '
        'verVisual
        '
        Me.verVisual.AutoSize = True
        Me.verVisual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verVisual.ForeColor = System.Drawing.Color.Black
        Me.verVisual.Location = New System.Drawing.Point(210, 152)
        Me.verVisual.Name = "verVisual"
        Me.verVisual.Size = New System.Drawing.Size(51, 17)
        Me.verVisual.TabIndex = 8
        Me.verVisual.Text = "Visual"
        '
        'verEmail
        '
        Me.verEmail.AutoSize = True
        Me.verEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verEmail.ForeColor = System.Drawing.Color.Black
        Me.verEmail.Location = New System.Drawing.Point(123, 152)
        Me.verEmail.Name = "verEmail"
        Me.verEmail.Size = New System.Drawing.Size(49, 17)
        Me.verEmail.TabIndex = 7
        Me.verEmail.Text = "Email"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(127, 61)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(328, 85)
        Me.txtGlosa.TabIndex = 6
        '
        'etiGlosa
        '
        Me.etiGlosa.AutoSize = True
        Me.etiGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGlosa.ForeColor = System.Drawing.Color.Black
        Me.etiGlosa.Location = New System.Drawing.Point(85, 63)
        Me.etiGlosa.Name = "etiGlosa"
        Me.etiGlosa.Size = New System.Drawing.Size(36, 14)
        Me.etiGlosa.TabIndex = 5
        Me.etiGlosa.Text = "Glosa:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnMostrar.Location = New System.Drawing.Point(487, 48)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(15, 130)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "<>"
        '
        'griAlertaHistorial
        '
        Me.griAlertaHistorial.DataSource = Me.ordAlertaDetalle
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Width = 187
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Width = 55
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Width = 46
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Width = 49
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.MaskInput = "{date} {time}"
        UltraGridColumn37.Width = 118
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 10
        UltraGridColumn39.Width = 253
        UltraGridColumn40.Header.VisiblePosition = 9
        UltraGridColumn40.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        UltraGridBand4.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlertaHistorial.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griAlertaHistorial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlertaHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlertaHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlertaHistorial.Location = New System.Drawing.Point(0, 0)
        Me.griAlertaHistorial.Name = "griAlertaHistorial"
        Me.griAlertaHistorial.Size = New System.Drawing.Size(504, 231)
        Me.griAlertaHistorial.TabIndex = 0
        '
        'ordAlertaDetalle
        '
        UltraDataColumn37.DataType = GetType(Date)
        UltraDataColumn37.DefaultValue = New Date(CType(0, Long))
        UltraDataColumn40.DataType = GetType(Boolean)
        Me.ordAlertaDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        '
        'ficAlerta
        '
        Me.ficAlerta.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficAlerta.Controls.Add(Me.UltraTabPageControl1)
        Me.ficAlerta.Controls.Add(Me.UltraTabPageControl2)
        Me.ficAlerta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficAlerta.Location = New System.Drawing.Point(0, 0)
        Me.ficAlerta.Name = "ficAlerta"
        Me.ficAlerta.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficAlerta.Size = New System.Drawing.Size(1018, 506)
        Me.ficAlerta.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficAlerta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficAlerta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1016, 483)
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiActualizar, Me.tsmiEliminar, Me.tsmiAtender, Me.tsmiTerminar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 114)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(120, 22)
        Me.tsmiNuevo.Text = "Nuevo"
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
        'tsmiAtender
        '
        Me.tsmiAtender.Name = "tsmiAtender"
        Me.tsmiAtender.Size = New System.Drawing.Size(120, 22)
        Me.tsmiAtender.Text = "Atender"
        '
        'tsmiTerminar
        '
        Me.tsmiTerminar.Name = "tsmiTerminar"
        Me.tsmiTerminar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiTerminar.Text = "Terminar"
        '
        'frm_Alerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 506)
        Me.Controls.Add(Me.ficAlerta)
        Me.Name = "frm_Alerta"
        Me.Text = "Alerta"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrAlerta.ResumeLayout(False)
        CType(Me.griAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDestino.ResumeLayout(False)
        Me.spcDestino.Panel1.ResumeLayout(False)
        Me.spcDestino.Panel2.ResumeLayout(False)
        Me.spcDestino.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.griAlertaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordAlertaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panDerecha.ResumeLayout(False)
        CType(Me.griEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.spcAlerta.Panel1.ResumeLayout(False)
        Me.spcAlerta.Panel1.PerformLayout()
        Me.spcAlerta.Panel2.ResumeLayout(False)
        Me.spcAlerta.ResumeLayout(False)
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verSonora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verVisual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAlertaHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordAlertaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficAlerta.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficAlerta As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrAlerta As ISL.Controles.Agrupacion
    Friend WithEvents griAlerta As ISL.Controles.Grilla
    Friend WithEvents ordAlerta As ISL.Controles.OrigenDatos
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents spcAlerta As System.Windows.Forms.SplitContainer
    Friend WithEvents agrDestino As ISL.Controles.Agrupacion
    Friend WithEvents spcDestino As System.Windows.Forms.SplitContainer
    Friend WithEvents griAlertaDestino As ISL.Controles.Grilla
    Friend WithEvents griAlertaHistorial As ISL.Controles.Grilla
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panDerecha As System.Windows.Forms.Panel
    Friend WithEvents griEmail As ISL.Controles.Grilla
    Friend WithEvents btnMostrarOcultar As ISL.Controles.Boton
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents etiGlosa As ISL.Controles.Etiqueta
    Friend WithEvents btnMostrar As ISL.Controles.Boton
    Friend WithEvents ordAlertaDestino As ISL.Controles.OrigenDatos
    Friend WithEvents ordAlertaDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents verSonora As ISL.Controles.Chequear
    Friend WithEvents verVisual As ISL.Controles.Chequear
    Friend WithEvents verEmail As ISL.Controles.Chequear
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAtender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTerminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ordPersona As ISL.Controles.OrigenDatos
    Friend WithEvents cboActividadNegocio As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
End Class
