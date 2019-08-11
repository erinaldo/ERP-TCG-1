<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Lugar
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Lugar))
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraFin")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraInicio")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraFin")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbigeo")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCorto")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoRuta")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbigeo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCorto")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoRuta")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griClienteLugarTienda = New ISL.Controles.Grilla(Me.components)
        Me.ogdClienteLugar = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cbgClienteProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCentroCosto = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoTienda = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtLugarTienda = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griVentanaHoraria = New ISL.Controles.Grilla(Me.components)
        Me.ogdVentanaHoraria = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecHoraFinVH = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecHoraInicioVH = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigoTiendaVH = New ISL.Controles.Texto(Me.components)
        Me.txtLugarTiendaVH = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregarVH = New Infragistics.Win.Misc.UltraButton()
        Me.cboClienteVH = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Inserta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualiza = New System.Windows.Forms.ToolStripMenuItem()
        Me.Elimina = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLugar = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboListaReferencia = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.agrListaRegistro = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorBloque = New ISL.Controles.Colores(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnGuardarLugar = New ISL.Controles.Boton(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboReferencia = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtId = New ISL.Controles.Texto(Me.components)
        Me.txtTipoRuta = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Ubigeo1 = New ISL.Win.Ubigeo()
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficTiempoFlete = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ficLugar = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griClienteLugarTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdClienteLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cbgClienteProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLugarTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griVentanaHoraria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdVentanaHoraria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txtCodigoTiendaVH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLugarTiendaVH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteVH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboListaReferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.cboReferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficTiempoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficLugar.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griClienteLugarTienda)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1087, 283)
        '
        'griClienteLugarTienda
        '
        Me.griClienteLugarTienda.DataSource = Me.ogdClienteLugar
        Appearance1.BackColor = System.Drawing.Color.White
        Me.griClienteLugarTienda.DisplayLayout.Appearance = Appearance1
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.Caption = "Cliente"
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Width = 250
        UltraGridColumn39.Header.VisiblePosition = 5
        UltraGridColumn39.Width = 150
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Width = 50
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Width = 50
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridColumn42.Width = 200
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43})
        Me.griClienteLugarTienda.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griClienteLugarTienda.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griClienteLugarTienda.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griClienteLugarTienda.DisplayLayout.GroupByBox.Hidden = True
        Me.griClienteLugarTienda.DisplayLayout.MaxColScrollRegions = 1
        Me.griClienteLugarTienda.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griClienteLugarTienda.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griClienteLugarTienda.DisplayLayout.Override.CellPadding = 2
        Me.griClienteLugarTienda.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griClienteLugarTienda.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griClienteLugarTienda.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griClienteLugarTienda.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griClienteLugarTienda.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griClienteLugarTienda.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griClienteLugarTienda.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griClienteLugarTienda.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griClienteLugarTienda.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griClienteLugarTienda.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griClienteLugarTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griClienteLugarTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griClienteLugarTienda.Location = New System.Drawing.Point(0, 123)
        Me.griClienteLugarTienda.Name = "griClienteLugarTienda"
        Me.griClienteLugarTienda.Size = New System.Drawing.Size(1087, 160)
        Me.griClienteLugarTienda.TabIndex = 1
        Me.griClienteLugarTienda.Tag = ""
        '
        'ogdClienteLugar
        '
        Me.ogdClienteLugar.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cbgClienteProveedor)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.txtObservacion)
        Me.UltraGroupBox1.Controls.Add(Me.txtCentroCosto)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.txtCodigoTienda)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.txtLugarTienda)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.btnAgregar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1087, 123)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cbgClienteProveedor
        '
        Me.cbgClienteProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cbgClienteProveedor.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cbgClienteProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgClienteProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgClienteProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgClienteProveedor.Location = New System.Drawing.Point(103, 27)
        Me.cbgClienteProveedor.Name = "cbgClienteProveedor"
        Me.cbgClienteProveedor.Size = New System.Drawing.Size(370, 23)
        Me.cbgClienteProveedor.TabIndex = 2
        '
        'UltraLabel8
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance2
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(29, 79)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel8.TabIndex = 18
        Me.UltraLabel8.Text = "Observacion:"
        '
        'txtObservacion
        '
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Location = New System.Drawing.Point(103, 76)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(370, 40)
        Me.txtObservacion.TabIndex = 4
        '
        'txtCentroCosto
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCentroCosto.Appearance = Appearance3
        Me.txtCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroCosto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroCosto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCentroCosto.Location = New System.Drawing.Point(346, 5)
        Me.txtCentroCosto.MaxLength = 10
        Me.txtCentroCosto.Name = "txtCentroCosto"
        Me.txtCentroCosto.Size = New System.Drawing.Size(127, 21)
        Me.txtCentroCosto.TabIndex = 1
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(271, 9)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel7.TabIndex = 15
        Me.UltraLabel7.Text = "Centro Costo:"
        '
        'txtCodigoTienda
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoTienda.Appearance = Appearance5
        Me.txtCodigoTienda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTienda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTienda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoTienda.Location = New System.Drawing.Point(103, 5)
        Me.txtCodigoTienda.MaxLength = 10
        Me.txtCodigoTienda.Name = "txtCodigoTienda"
        Me.txtCodigoTienda.Size = New System.Drawing.Size(94, 21)
        Me.txtCodigoTienda.TabIndex = 0
        Me.txtCodigoTienda.TabStop = False
        '
        'UltraLabel6
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance6
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(57, 9)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel6.TabIndex = 13
        Me.UltraLabel6.Text = "Código:"
        '
        'txtLugarTienda
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLugarTienda.Appearance = Appearance7
        Me.txtLugarTienda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugarTienda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtLugarTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTienda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLugarTienda.Location = New System.Drawing.Point(103, 52)
        Me.txtLugarTienda.MaxLength = 200
        Me.txtLugarTienda.Name = "txtLugarTienda"
        Me.txtLugarTienda.Size = New System.Drawing.Size(370, 21)
        Me.txtLugarTienda.TabIndex = 3
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(26, 56)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(74, 15)
        Me.UltraLabel5.TabIndex = 11
        Me.UltraLabel5.Text = "Lugar Tienda:"
        '
        'btnAgregar
        '
        Appearance9.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance9
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(477, 76)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.TabStop = False
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
        '
        'UltraLabel3
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance10
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(2, 33)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(97, 15)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Cliente/Proveedor:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griVentanaHoraria)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1087, 283)
        '
        'griVentanaHoraria
        '
        Me.griVentanaHoraria.DataSource = Me.ogdVentanaHoraria
        Appearance11.BackColor = System.Drawing.Color.White
        Me.griVentanaHoraria.DisplayLayout.Appearance = Appearance11
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Cliente"
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn22.Width = 300
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Width = 200
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn24.Width = 50
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Header.VisiblePosition = 6
        UltraGridColumn26.MaskInput = "{LOC}hh:mm"
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn27.Header.VisiblePosition = 7
        UltraGridColumn27.MaskInput = "{LOC}hh:mm"
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        Me.griVentanaHoraria.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griVentanaHoraria.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griVentanaHoraria.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griVentanaHoraria.DisplayLayout.GroupByBox.Hidden = True
        Me.griVentanaHoraria.DisplayLayout.MaxColScrollRegions = 1
        Me.griVentanaHoraria.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVentanaHoraria.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVentanaHoraria.DisplayLayout.Override.CellPadding = 2
        Me.griVentanaHoraria.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVentanaHoraria.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griVentanaHoraria.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVentanaHoraria.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVentanaHoraria.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griVentanaHoraria.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griVentanaHoraria.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVentanaHoraria.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griVentanaHoraria.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griVentanaHoraria.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griVentanaHoraria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVentanaHoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVentanaHoraria.Location = New System.Drawing.Point(0, 125)
        Me.griVentanaHoraria.Name = "griVentanaHoraria"
        Me.griVentanaHoraria.Size = New System.Drawing.Size(1087, 158)
        Me.griVentanaHoraria.TabIndex = 2
        Me.griVentanaHoraria.Tag = ""
        '
        'ogdVentanaHoraria
        '
        UltraDataColumn15.DataType = GetType(Date)
        UltraDataColumn16.DataType = GetType(Date)
        Me.ogdVentanaHoraria.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox2.Controls.Add(Me.fecHoraFinVH)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox2.Controls.Add(Me.fecHoraInicioVH)
        Me.UltraGroupBox2.Controls.Add(Me.txtCodigoTiendaVH)
        Me.UltraGroupBox2.Controls.Add(Me.txtLugarTiendaVH)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox2.Controls.Add(Me.btnAgregarVH)
        Me.UltraGroupBox2.Controls.Add(Me.cboClienteVH)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1087, 125)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraLabel13
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance12
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(4, 8)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel13.TabIndex = 23
        Me.UltraLabel13.Text = "Codigo:"
        '
        'fecHoraFinVH
        '
        Me.fecHoraFinVH.CustomFormat = "HH:mm"
        Me.fecHoraFinVH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecHoraFinVH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHoraFinVH.Location = New System.Drawing.Point(249, 97)
        Me.fecHoraFinVH.Name = "fecHoraFinVH"
        Me.fecHoraFinVH.ShowUpDown = True
        Me.fecHoraFinVH.Size = New System.Drawing.Size(53, 20)
        Me.fecHoraFinVH.TabIndex = 4
        Me.fecHoraFinVH.Value = New Date(2012, 12, 28, 0, 0, 0, 0)
        '
        'UltraLabel11
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance13
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(124, 100)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(119, 15)
        Me.UltraLabel11.TabIndex = 21
        Me.UltraLabel11.Text = "Hora Fin SobreEstadia:"
        '
        'UltraLabel12
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance14
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(113, 78)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(131, 15)
        Me.UltraLabel12.TabIndex = 20
        Me.UltraLabel12.Text = "Hora Inicio SobreEstadia:"
        '
        'fecHoraInicioVH
        '
        Me.fecHoraInicioVH.CustomFormat = "HH:mm"
        Me.fecHoraInicioVH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecHoraInicioVH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHoraInicioVH.Location = New System.Drawing.Point(249, 75)
        Me.fecHoraInicioVH.Name = "fecHoraInicioVH"
        Me.fecHoraInicioVH.ShowUpDown = True
        Me.fecHoraInicioVH.Size = New System.Drawing.Size(53, 20)
        Me.fecHoraInicioVH.TabIndex = 3
        Me.fecHoraInicioVH.Value = New Date(2012, 12, 28, 0, 0, 0, 0)
        '
        'txtCodigoTiendaVH
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoTiendaVH.Appearance = Appearance15
        Me.txtCodigoTiendaVH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTiendaVH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoTiendaVH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTiendaVH.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoTiendaVH.Location = New System.Drawing.Point(51, 4)
        Me.txtCodigoTiendaVH.MaxLength = 10
        Me.txtCodigoTiendaVH.Name = "txtCodigoTiendaVH"
        Me.txtCodigoTiendaVH.Size = New System.Drawing.Size(70, 21)
        Me.txtCodigoTiendaVH.TabIndex = 0
        Me.txtCodigoTiendaVH.TabStop = False
        '
        'txtLugarTiendaVH
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLugarTiendaVH.Appearance = Appearance16
        Me.txtLugarTiendaVH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugarTiendaVH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtLugarTiendaVH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTiendaVH.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLugarTiendaVH.Location = New System.Drawing.Point(51, 51)
        Me.txtLugarTiendaVH.MaxLength = 200
        Me.txtLugarTiendaVH.Name = "txtLugarTiendaVH"
        Me.txtLugarTiendaVH.Size = New System.Drawing.Size(250, 21)
        Me.txtLugarTiendaVH.TabIndex = 2
        '
        'UltraLabel16
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance17
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(5, 55)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel16.TabIndex = 11
        Me.UltraLabel16.Text = "Tienda:"
        '
        'btnAgregarVH
        '
        Appearance18.Image = "add.ico"
        Me.btnAgregarVH.Appearance = Appearance18
        Me.btnAgregarVH.ImageList = Me.imagenes
        Me.btnAgregarVH.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarVH.Location = New System.Drawing.Point(308, 87)
        Me.btnAgregarVH.Name = "btnAgregarVH"
        Me.btnAgregarVH.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarVH.TabIndex = 5
        Me.btnAgregarVH.TabStop = False
        '
        'cboClienteVH
        '
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.cboClienteVH.Appearance = Appearance19
        Me.cboClienteVH.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClienteVH.DisplayMember = "Nombre"
        Me.cboClienteVH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteVH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteVH.ForeColor = System.Drawing.Color.Black
        Me.cboClienteVH.ImageList = Me.imagenes
        Me.cboClienteVH.Location = New System.Drawing.Point(51, 27)
        Me.cboClienteVH.Name = "cboClienteVH"
        Me.cboClienteVH.Size = New System.Drawing.Size(350, 21)
        Me.cboClienteVH.TabIndex = 1
        Me.cboClienteVH.ValueMember = "Id"
        '
        'UltraLabel17
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance20
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(4, 31)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 2
        Me.UltraLabel17.Text = "Cliente:"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griLista)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1089, 506)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdLugar
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn1.Header.Appearance = Appearance21
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance22
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 83
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance23.TextHAlignAsString = "Center"
        UltraGridColumn3.Header.Appearance = Appearance23
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 272
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn4.Header.Appearance = Appearance24
        UltraGridColumn4.Header.Caption = "Equivalencia"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 200
        Appearance25.ForeColor = System.Drawing.Color.White
        Appearance25.Image = 3
        Appearance25.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance25.TextHAlignAsString = "Left"
        UltraGridColumn5.CellAppearance = Appearance25
        Appearance26.Image = 1
        Appearance26.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn5.CellButtonAppearance = Appearance26
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance27.TextHAlignAsString = "Center"
        UltraGridColumn5.Header.Appearance = Appearance27
        UltraGridColumn5.Header.Caption = ""
        UltraGridColumn5.Header.VisiblePosition = 10
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn5.Width = 20
        Appearance28.TextHAlignAsString = "Center"
        UltraGridColumn6.Header.Appearance = Appearance28
        UltraGridColumn6.Header.Caption = "Ubigeo"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 114
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance29.TextHAlignAsString = "Center"
        UltraGridColumn7.Header.Appearance = Appearance29
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance30.TextHAlignAsString = "Center"
        UltraGridColumn8.Header.Appearance = Appearance30
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        Appearance31.TextHAlignAsString = "Center"
        UltraGridColumn9.Header.Appearance = Appearance31
        UltraGridColumn9.Header.Caption = "Nombre Corto"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 187
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Width = 60
        UltraGridColumn11.Header.Caption = "Referencia"
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Width = 200
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 55)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1089, 451)
        Me.griLista.TabIndex = 3
        Me.griLista.Text = "Grilla1"
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Inserta, Me.Actualiza, Me.Elimina})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(121, 70)
        '
        'Inserta
        '
        Me.Inserta.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Inserta.Name = "Inserta"
        Me.Inserta.Size = New System.Drawing.Size(120, 22)
        Me.Inserta.Text = "Nuevo"
        Me.Inserta.ToolTipText = "Agregar un nuevo Lugar"
        '
        'Actualiza
        '
        Me.Actualiza.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Actualiza.Name = "Actualiza"
        Me.Actualiza.Size = New System.Drawing.Size(120, 22)
        Me.Actualiza.Text = "Actualizar"
        Me.Actualiza.ToolTipText = "Actualizar un Lugar seleccionado"
        '
        'Elimina
        '
        Me.Elimina.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(120, 22)
        Me.Elimina.Text = "Eliminar"
        Me.Elimina.ToolTipText = "Eliminar un Lugar seleccionada"
        '
        'ogdLugar
        '
        UltraDataColumn21.DataType = GetType(Boolean)
        Me.ogdLugar.Band.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
        '
        'Agrupacion1
        '
        Appearance35.BackColor = System.Drawing.Color.White
        Appearance35.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance35
        Me.Agrupacion1.Controls.Add(Me.UltraLabel10)
        Me.Agrupacion1.Controls.Add(Me.cboListaReferencia)
        Me.Agrupacion1.Controls.Add(Me.btnGuardar)
        Me.Agrupacion1.Controls.Add(Me.agrListaRegistro)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta45)
        Me.Agrupacion1.Controls.Add(Me.ColorBloque)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1089, 55)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.Text = "Cambiar Datos Masivamente"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel10
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance36
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(349, 30)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel10.TabIndex = 44
        Me.UltraLabel10.Text = "Referencia:"
        '
        'cboListaReferencia
        '
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.cboListaReferencia.Appearance = Appearance37
        Me.cboListaReferencia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance38.Image = 8
        EditorButton1.Appearance = Appearance38
        Me.cboListaReferencia.ButtonsRight.Add(EditorButton1)
        Me.cboListaReferencia.DisplayMember = "Nombre"
        Me.cboListaReferencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboListaReferencia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboListaReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboListaReferencia.ForeColor = System.Drawing.Color.Black
        Me.cboListaReferencia.ImageList = Me.imagenes
        Me.cboListaReferencia.Location = New System.Drawing.Point(413, 26)
        Me.cboListaReferencia.Name = "cboListaReferencia"
        Me.cboListaReferencia.Size = New System.Drawing.Size(300, 21)
        Me.cboListaReferencia.TabIndex = 0
        Me.cboListaReferencia.ValueMember = "Id"
        '
        'btnGuardar
        '
        Appearance39.Image = 1
        Appearance39.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnGuardar.Appearance = Appearance39
        Me.btnGuardar.ImageList = Me.imagenes
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(717, 21)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 30)
        Me.btnGuardar.TabIndex = 7
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaRegistro.ForeColor = System.Drawing.Color.Black
        Me.agrListaRegistro.Location = New System.Drawing.Point(3, 32)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(150, 20)
        Me.agrListaRegistro.TabIndex = 0
        Me.agrListaRegistro.Text = "Lista Registro: "
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta45
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance40
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(764, 31)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta45.TabIndex = 5
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'ColorBloque
        '
        Me.ColorBloque.Color = System.Drawing.Color.Cyan
        Me.ColorBloque.Location = New System.Drawing.Point(831, 27)
        Me.ColorBloque.Name = "ColorBloque"
        Me.ColorBloque.Size = New System.Drawing.Size(44, 21)
        Me.ColorBloque.TabIndex = 6
        Me.ColorBloque.Text = "Cyan"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.UltraTabControl1)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1089, 506)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 200)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl1.Size = New System.Drawing.Size(1089, 306)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab6.Key = "0"
        UltraTab6.TabPage = Me.UltraTabPageControl1
        UltraTab6.Text = "ClienteLugar"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "VentaHoraria"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab3})
        Me.UltraTabControl1.TabStop = False
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1087, 283)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.btnGuardarLugar)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.ugb_Espera)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel9)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboReferencia)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtId)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtTipoRuta)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Ubigeo1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtAbreviatura)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(1089, 200)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos:"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnGuardarLugar
        '
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardarLugar.Appearance = Appearance41
        Me.btnGuardarLugar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardarLugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarLugar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarLugar.Location = New System.Drawing.Point(371, 159)
        Me.btnGuardarLugar.Name = "btnGuardarLugar"
        Me.btnGuardarLugar.Size = New System.Drawing.Size(77, 25)
        Me.btnGuardarLugar.TabIndex = 44
        Me.btnGuardarLugar.TabStop = False
        Me.btnGuardarLugar.Text = "Guardar"
        Me.btnGuardarLugar.Visible = False
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.Location = New System.Drawing.Point(445, 132)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(392, 68)
        Me.ugb_Espera.TabIndex = 7
        Me.ugb_Espera.Visible = False
        '
        'UltraLabel9
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance42
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(26, 96)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel9.TabIndex = 42
        Me.UltraLabel9.Text = "Referencia:"
        '
        'cboReferencia
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboReferencia.Appearance = Appearance43
        Me.cboReferencia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboReferencia.DisplayMember = "Nombre"
        Me.cboReferencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboReferencia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReferencia.ForeColor = System.Drawing.Color.Black
        Me.cboReferencia.ImageList = Me.imagenes
        Me.cboReferencia.Location = New System.Drawing.Point(90, 94)
        Me.cboReferencia.Name = "cboReferencia"
        Me.cboReferencia.Size = New System.Drawing.Size(300, 21)
        Me.cboReferencia.TabIndex = 4
        Me.cboReferencia.ValueMember = "Id"
        '
        'txtId
        '
        Appearance44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Appearance = Appearance44
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Location = New System.Drawing.Point(5, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(20, 22)
        Me.txtId.TabIndex = 41
        Me.txtId.Visible = False
        '
        'txtTipoRuta
        '
        Appearance45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoRuta.Appearance = Appearance45
        Me.txtTipoRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoRuta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoRuta.Location = New System.Drawing.Point(340, 25)
        Me.txtTipoRuta.MaxLength = 5
        Me.txtTipoRuta.Name = "txtTipoRuta"
        Me.txtTipoRuta.Size = New System.Drawing.Size(50, 21)
        Me.txtTipoRuta.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Appearance46.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance46
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(281, 27)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel2.TabIndex = 39
        Me.UltraLabel2.Text = "Tipo Ruta:"
        '
        'Ubigeo1
        '
        Me.Ubigeo1.BackColor = System.Drawing.Color.Transparent
        Me.Ubigeo1.Id = Nothing
        Me.Ubigeo1.Location = New System.Drawing.Point(4, 117)
        Me.Ubigeo1.Name = "Ubigeo1"
        Me.Ubigeo1.Size = New System.Drawing.Size(361, 80)
        Me.Ubigeo1.TabIndex = 5
        '
        'txtAbreviatura
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance47
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(90, 71)
        Me.txtAbreviatura.MaxLength = 200
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(300, 21)
        Me.txtAbreviatura.TabIndex = 3
        '
        'UltraLabel1
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Appearance48.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance48
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 73)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(70, 15)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Equivalencia:"
        '
        'txtCodigo
        '
        Appearance49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance49
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(90, 25)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(70, 21)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        '
        'txtNombre
        '
        Appearance50.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance50
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(90, 48)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(300, 21)
        Me.txtNombre.TabIndex = 2
        '
        'UltraLabel22
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Appearance51.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance51
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(41, 50)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Nombre:"
        '
        'UltraLabel4
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Appearance52.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance52
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(46, 27)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Código:"
        '
        'ficTiempoFlete
        '
        Me.ficTiempoFlete.Location = New System.Drawing.Point(0, 0)
        Me.ficTiempoFlete.Name = "ficTiempoFlete"
        Me.ficTiempoFlete.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficTiempoFlete.Size = New System.Drawing.Size(200, 100)
        Me.ficTiempoFlete.TabIndex = 0
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(196, 77)
        '
        'ficLugar
        '
        Me.ficLugar.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficLugar.Controls.Add(Me.UltraTabPageControl7)
        Me.ficLugar.Controls.Add(Me.utpDetalle)
        Me.ficLugar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficLugar.Location = New System.Drawing.Point(0, 0)
        Me.ficLugar.Name = "ficLugar"
        Me.ficLugar.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficLugar.Size = New System.Drawing.Size(1091, 529)
        Me.ficLugar.TabIndex = 6
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficLugar.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficLugar.TabStop = False
        Me.ficLugar.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1089, 506)
        '
        'frm_Lugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1091, 529)
        Me.Controls.Add(Me.ficLugar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frm_Lugar"
        Me.Text = "Lugar"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griClienteLugarTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdClienteLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cbgClienteProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLugarTienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griVentanaHoraria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdVentanaHoraria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txtCodigoTiendaVH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLugarTiendaVH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteVH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboListaReferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.cboReferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficTiempoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficLugar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficLugar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficLugar As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents Ubigeo1 As ISL.Win.Ubigeo
    Friend WithEvents ogdLugar As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents txtTipoRuta As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ficTiempoFlete As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Inserta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Actualiza As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Elimina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griClienteLugarTienda As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdClienteLugar As ISL.Controles.OrigenDatos
    Friend WithEvents txtLugarTienda As ISL.Controles.Texto
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCentroCosto As ISL.Controles.Texto
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoTienda As ISL.Controles.Texto
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtId As ISL.Controles.Texto
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griVentanaHoraria As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHoraFinVH As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecHoraInicioVH As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodigoTiendaVH As ISL.Controles.Texto
    Friend WithEvents txtLugarTiendaVH As ISL.Controles.Texto
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregarVH As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboClienteVH As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdVentanaHoraria As ISL.Controles.OrigenDatos
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboReferencia As ISL.Controles.ComboMaestros
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents agrListaRegistro As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents ColorBloque As ISL.Controles.Colores
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboListaReferencia As ISL.Controles.ComboMaestros
    Friend WithEvents btnGuardarLugar As ISL.Controles.Boton
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbgClienteProveedor As Infragistics.Win.UltraWinGrid.UltraCombo

End Class
