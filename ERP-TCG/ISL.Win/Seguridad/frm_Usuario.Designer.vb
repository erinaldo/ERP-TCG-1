<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usuario
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPerfil")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Perfil")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPerfil")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Perfil")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Centro")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Centro")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim E_Sexo1 As ERP.EntidadesWCF.e_Sexo = New ERP.EntidadesWCF.e_Sexo()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Login")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaNacimiento")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sexo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Clave")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Usuario))
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrPerfil = New ISL.Controles.Agrupacion(Me.components)
        Me.griPerfil = New ISL.Controles.Grilla(Me.components)
        Me.ordPerfil = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrListaPerfil = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griPerfilder = New ISL.Controles.Grilla(Me.components)
        Me.ordPerfilDer = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTurno = New ISL.Controles.Agrupacion(Me.components)
        Me.griTurno = New ISL.Controles.Grilla(Me.components)
        Me.agrListaTurno = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaTurno = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.numIntervalo = New ISL.Controles.Numero(Me.components)
        Me.numTiempoAlerta = New ISL.Controles.Numero(Me.components)
        Me.verLanzaAlerta = New ISL.Controles.Chequear(Me.components)
        Me.verCierreAutomatico = New ISL.Controles.Chequear(Me.components)
        Me.etiTiempoAlerta = New ISL.Controles.Etiqueta(Me.components)
        Me.etiIntervalo = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griCentro = New ISL.Controles.Grilla(Me.components)
        Me.ordCentro = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrListaCentro = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griCentroder = New ISL.Controles.Grilla(Me.components)
        Me.ordCentroDer = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalUsuarios = New ISL.Controles.Agrupacion(Me.components)
        Me.griUsuario = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrUsuario = New ISL.Controles.Agrupacion(Me.components)
        Me.agrDatoUsuario = New ISL.Controles.Agrupacion(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.etiLogin = New ISL.Controles.Etiqueta(Me.components)
        Me.txtAutorizacion = New ISL.Controles.Texto(Me.components)
        Me.etiClave = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.verControlado = New ISL.Controles.Chequear(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.txtLogin = New ISL.Controles.Texto(Me.components)
        Me.txtClave = New ISL.Controles.Texto(Me.components)
        Me.agrDatosPersonales = New ISL.Controles.Agrupacion(Me.components)
        Me.etiDni = New ISL.Controles.Etiqueta(Me.components)
        Me.etiApellidoPaterno = New ISL.Controles.Etiqueta(Me.components)
        Me.etiApellidoMaterno = New ISL.Controles.Etiqueta(Me.components)
        Me.fecNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.txtApellidoPaterno = New ISL.Controles.Texto(Me.components)
        Me.txtApellidoMaterno = New ISL.Controles.Texto(Me.components)
        Me.Sexo1 = New ISL.Win.Sexo()
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.etiFechaNacimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDni = New ISL.Controles.Texto(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ordUsuario = New ISL.Controles.OrigenDatos(Me.components)
        Me.ficUsuario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.agrPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrPerfil.SuspendLayout()
        CType(Me.griPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrListaPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaPerfil.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griPerfilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordPerfilDer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.agrTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTurno.SuspendLayout()
        CType(Me.griTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrListaTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaTurno.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griListaTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.numIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTiempoAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLanzaAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCierreAutomatico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrListaCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaCentro.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.griCentroder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordCentroDer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrTotalUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalUsuarios.SuspendLayout()
        CType(Me.griUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.agrUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrUsuario.SuspendLayout()
        CType(Me.agrDatoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoUsuario.SuspendLayout()
        CType(Me.txtAutorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verControlado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosPersonales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosPersonales.SuspendLayout()
        CType(Me.txtApellidoPaterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.agrPerfil)
        Me.UltraTabPageControl3.Controls.Add(Me.agrListaPerfil)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1121, 215)
        '
        'agrPerfil
        '
        Me.agrPerfil.Controls.Add(Me.griPerfil)
        Me.agrPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPerfil.ForeColor = System.Drawing.Color.Black
        Me.agrPerfil.Location = New System.Drawing.Point(458, 0)
        Me.agrPerfil.Name = "agrPerfil"
        Me.agrPerfil.Size = New System.Drawing.Size(663, 215)
        Me.agrPerfil.TabIndex = 3
        Me.agrPerfil.Text = "Perfiles"
        Me.agrPerfil.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griPerfil
        '
        Me.griPerfil.DataSource = Me.ordPerfil
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 66
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 299
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 235
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.griPerfil.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPerfil.Location = New System.Drawing.Point(2, 18)
        Me.griPerfil.Name = "griPerfil"
        Me.griPerfil.Size = New System.Drawing.Size(659, 195)
        Me.griPerfil.TabIndex = 0
        '
        'ordPerfil
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        Me.ordPerfil.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'agrListaPerfil
        '
        Me.agrListaPerfil.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.agrListaPerfil.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrListaPerfil.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrListaPerfil.ExpandedSize = New System.Drawing.Size(458, 215)
        Me.agrListaPerfil.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrListaPerfil.Location = New System.Drawing.Point(0, 0)
        Me.agrListaPerfil.Name = "agrListaPerfil"
        Me.agrListaPerfil.Size = New System.Drawing.Size(458, 215)
        Me.agrListaPerfil.TabIndex = 2
        Me.agrListaPerfil.Text = "<< Lista de Perfiles >>"
        Me.agrListaPerfil.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griPerfilder)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(22, 2)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(434, 211)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griPerfilder
        '
        Me.griPerfilder.DataSource = Me.ordPerfilDer
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Width = 97
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Width = 297
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.griPerfilder.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griPerfilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPerfilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPerfilder.Location = New System.Drawing.Point(0, 0)
        Me.griPerfilder.Name = "griPerfilder"
        Me.griPerfilder.Size = New System.Drawing.Size(434, 211)
        Me.griPerfilder.TabIndex = 0
        '
        'ordPerfilDer
        '
        UltraDataColumn10.DataType = GetType(Boolean)
        Me.ordPerfilDer.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.agrTurno)
        Me.UltraTabPageControl4.Controls.Add(Me.agrListaTurno)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1121, 215)
        '
        'agrTurno
        '
        Me.agrTurno.Controls.Add(Me.griTurno)
        Me.agrTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTurno.ForeColor = System.Drawing.Color.Black
        Me.agrTurno.Location = New System.Drawing.Point(454, 0)
        Me.agrTurno.Name = "agrTurno"
        Me.agrTurno.Size = New System.Drawing.Size(667, 215)
        Me.agrTurno.TabIndex = 1
        Me.agrTurno.Text = "Turnos"
        Me.agrTurno.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griTurno
        '
        Me.griTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTurno.Location = New System.Drawing.Point(2, 18)
        Me.griTurno.Name = "griTurno"
        Me.griTurno.Size = New System.Drawing.Size(663, 195)
        Me.griTurno.TabIndex = 0
        '
        'agrListaTurno
        '
        Me.agrListaTurno.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.agrListaTurno.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.agrListaTurno.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrListaTurno.ExpandedSize = New System.Drawing.Size(454, 215)
        Me.agrListaTurno.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrListaTurno.Location = New System.Drawing.Point(0, 0)
        Me.agrListaTurno.Name = "agrListaTurno"
        Me.agrListaTurno.Size = New System.Drawing.Size(454, 215)
        Me.agrListaTurno.TabIndex = 0
        Me.agrListaTurno.Text = "<< Lista de Turno >>"
        Me.agrListaTurno.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griListaTurno)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(22, 2)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(430, 211)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griListaTurno
        '
        Me.griListaTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaTurno.Location = New System.Drawing.Point(0, 0)
        Me.griListaTurno.Name = "griListaTurno"
        Me.griListaTurno.Size = New System.Drawing.Size(430, 211)
        Me.griListaTurno.TabIndex = 0
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Etiqueta4)
        Me.UltraTabPageControl5.Controls.Add(Me.Etiqueta3)
        Me.UltraTabPageControl5.Controls.Add(Me.numIntervalo)
        Me.UltraTabPageControl5.Controls.Add(Me.numTiempoAlerta)
        Me.UltraTabPageControl5.Controls.Add(Me.verLanzaAlerta)
        Me.UltraTabPageControl5.Controls.Add(Me.verCierreAutomatico)
        Me.UltraTabPageControl5.Controls.Add(Me.etiTiempoAlerta)
        Me.UltraTabPageControl5.Controls.Add(Me.etiIntervalo)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1121, 215)
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(181, 92)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta4.TabIndex = 17
        Me.Etiqueta4.Text = "Minutos"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(181, 65)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta3.TabIndex = 16
        Me.Etiqueta3.Text = "Minutos"
        '
        'numIntervalo
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.numIntervalo.Appearance = Appearance1
        Me.numIntervalo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numIntervalo.Enabled = False
        Me.numIntervalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numIntervalo.ForeColor = System.Drawing.Color.Black
        Me.numIntervalo.Location = New System.Drawing.Point(111, 88)
        Me.numIntervalo.Name = "numIntervalo"
        Me.numIntervalo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIntervalo.Size = New System.Drawing.Size(64, 21)
        Me.numIntervalo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numIntervalo.TabIndex = 15
        '
        'numTiempoAlerta
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.numTiempoAlerta.Appearance = Appearance2
        Me.numTiempoAlerta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTiempoAlerta.Enabled = False
        Me.numTiempoAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTiempoAlerta.ForeColor = System.Drawing.Color.Black
        Me.numTiempoAlerta.Location = New System.Drawing.Point(111, 61)
        Me.numTiempoAlerta.Name = "numTiempoAlerta"
        Me.numTiempoAlerta.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numTiempoAlerta.Size = New System.Drawing.Size(64, 21)
        Me.numTiempoAlerta.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numTiempoAlerta.TabIndex = 14
        '
        'verLanzaAlerta
        '
        Me.verLanzaAlerta.AutoSize = True
        Me.verLanzaAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verLanzaAlerta.ForeColor = System.Drawing.Color.Black
        Me.verLanzaAlerta.Location = New System.Drawing.Point(111, 38)
        Me.verLanzaAlerta.Name = "verLanzaAlerta"
        Me.verLanzaAlerta.Size = New System.Drawing.Size(83, 17)
        Me.verLanzaAlerta.TabIndex = 13
        Me.verLanzaAlerta.Text = "Lanza Alerta"
        '
        'verCierreAutomatico
        '
        Me.verCierreAutomatico.AutoSize = True
        Me.verCierreAutomatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCierreAutomatico.ForeColor = System.Drawing.Color.Black
        Me.verCierreAutomatico.Location = New System.Drawing.Point(111, 15)
        Me.verCierreAutomatico.Name = "verCierreAutomatico"
        Me.verCierreAutomatico.Size = New System.Drawing.Size(109, 17)
        Me.verCierreAutomatico.TabIndex = 12
        Me.verCierreAutomatico.Text = "Cierre Automático"
        '
        'etiTiempoAlerta
        '
        Me.etiTiempoAlerta.AutoSize = True
        Me.etiTiempoAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTiempoAlerta.ForeColor = System.Drawing.Color.Black
        Me.etiTiempoAlerta.Location = New System.Drawing.Point(30, 65)
        Me.etiTiempoAlerta.Name = "etiTiempoAlerta"
        Me.etiTiempoAlerta.Size = New System.Drawing.Size(75, 14)
        Me.etiTiempoAlerta.TabIndex = 1
        Me.etiTiempoAlerta.Text = "Tiempo Alerta:"
        '
        'etiIntervalo
        '
        Me.etiIntervalo.AutoSize = True
        Me.etiIntervalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiIntervalo.ForeColor = System.Drawing.Color.Black
        Me.etiIntervalo.Location = New System.Drawing.Point(56, 92)
        Me.etiIntervalo.Name = "etiIntervalo"
        Me.etiIntervalo.Size = New System.Drawing.Size(49, 14)
        Me.etiIntervalo.TabIndex = 0
        Me.etiIntervalo.Text = "Intervalo:"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl6.Controls.Add(Me.agrListaCentro)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1121, 215)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griCentro)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(458, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(663, 215)
        Me.Agrupacion1.TabIndex = 5
        Me.Agrupacion1.Text = "Sucursal"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griCentro
        '
        Me.griCentro.DataSource = Me.ordCentro
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Width = 66
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Width = 250
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn26.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn25, UltraGridColumn26})
        Me.griCentro.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCentro.Location = New System.Drawing.Point(2, 18)
        Me.griCentro.Name = "griCentro"
        Me.griCentro.Size = New System.Drawing.Size(659, 195)
        Me.griCentro.TabIndex = 0
        '
        'ordCentro
        '
        UltraDataColumn16.DataType = GetType(Boolean)
        Me.ordCentro.Band.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'agrListaCentro
        '
        Me.agrListaCentro.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.agrListaCentro.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.agrListaCentro.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrListaCentro.ExpandedSize = New System.Drawing.Size(458, 215)
        Me.agrListaCentro.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrListaCentro.Location = New System.Drawing.Point(0, 0)
        Me.agrListaCentro.Name = "agrListaCentro"
        Me.agrListaCentro.Size = New System.Drawing.Size(458, 215)
        Me.agrListaCentro.TabIndex = 4
        Me.agrListaCentro.Text = "<< Lista de Sucursal >>"
        Me.agrListaCentro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.griCentroder)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(22, 2)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(434, 211)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'griCentroder
        '
        Me.griCentroder.DataSource = Me.ordCentroDer
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Width = 97
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Width = 297
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn3, UltraGridColumn5, UltraGridColumn6})
        Me.griCentroder.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griCentroder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCentroder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCentroder.Location = New System.Drawing.Point(0, 0)
        Me.griCentroder.Name = "griCentroder"
        Me.griCentroder.Size = New System.Drawing.Size(434, 211)
        Me.griCentroder.TabIndex = 0
        '
        'ordCentroDer
        '
        UltraDataColumn20.DataType = GetType(Boolean)
        Me.ordCentroDer.Band.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrTotalUsuarios)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1123, 511)
        '
        'agrTotalUsuarios
        '
        Me.agrTotalUsuarios.Controls.Add(Me.griUsuario)
        Me.agrTotalUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalUsuarios.ForeColor = System.Drawing.Color.Black
        Me.agrTotalUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalUsuarios.Name = "agrTotalUsuarios"
        Me.agrTotalUsuarios.Size = New System.Drawing.Size(1123, 511)
        Me.agrTotalUsuarios.TabIndex = 1
        Me.agrTotalUsuarios.Text = "Total de Usuarios"
        Me.agrTotalUsuarios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griUsuario
        '
        Me.griUsuario.ContextMenuStrip = Me.MenuContextual1
        Me.griUsuario.DisplayLayout.MaxColScrollRegions = 1
        Me.griUsuario.DisplayLayout.MaxRowScrollRegions = 1
        Me.griUsuario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griUsuario.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griUsuario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griUsuario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griUsuario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griUsuario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griUsuario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griUsuario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griUsuario.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griUsuario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griUsuario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griUsuario.Location = New System.Drawing.Point(2, 18)
        Me.griUsuario.Name = "griUsuario"
        Me.griUsuario.Size = New System.Drawing.Size(1119, 491)
        Me.griUsuario.TabIndex = 1
        Me.griUsuario.Text = "Información de Usuarios"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.ToolStripSeparator1, Me.tsmiExportar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(114, 98)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(113, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        Me.tsmiNuevo.ToolTipText = "Insertar un nuevo Usuario"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEditar.Text = "Editar"
        Me.tsmiEditar.ToolTipText = "Actualizar o modificar el Usuario seleccionado"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        Me.tsmiEliminar.ToolTipText = "Eliminar el Usuario seleccionado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'tsmiExportar
        '
        Me.tsmiExportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.tsmiExportar.Name = "tsmiExportar"
        Me.tsmiExportar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiExportar.Text = "Exportar"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrUsuario)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1123, 511)
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl6)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalle.Location = New System.Drawing.Point(0, 273)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalle.Size = New System.Drawing.Size(1123, 238)
        Me.ficDetalle.TabIndex = 4
        UltraTab3.Key = "Perfil"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Perfil"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Turno"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Control"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Sucursal"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5, UltraTab6})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1121, 215)
        '
        'agrUsuario
        '
        Me.agrUsuario.Controls.Add(Me.agrDatoUsuario)
        Me.agrUsuario.Controls.Add(Me.agrDatosPersonales)
        Me.agrUsuario.Controls.Add(Me.PictureBox1)
        Me.agrUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrUsuario.ForeColor = System.Drawing.Color.Black
        Me.agrUsuario.Location = New System.Drawing.Point(0, 0)
        Me.agrUsuario.Name = "agrUsuario"
        Me.agrUsuario.Size = New System.Drawing.Size(1123, 273)
        Me.agrUsuario.TabIndex = 0
        Me.agrUsuario.Text = "Datos"
        Me.agrUsuario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agrDatoUsuario
        '
        Me.agrDatoUsuario.Controls.Add(Me.etiCodigo)
        Me.agrDatoUsuario.Controls.Add(Me.etiLogin)
        Me.agrDatoUsuario.Controls.Add(Me.txtAutorizacion)
        Me.agrDatoUsuario.Controls.Add(Me.etiClave)
        Me.agrDatoUsuario.Controls.Add(Me.Etiqueta1)
        Me.agrDatoUsuario.Controls.Add(Me.verActivo)
        Me.agrDatoUsuario.Controls.Add(Me.verControlado)
        Me.agrDatoUsuario.Controls.Add(Me.txtCodigo)
        Me.agrDatoUsuario.Controls.Add(Me.txtLogin)
        Me.agrDatoUsuario.Controls.Add(Me.txtClave)
        Me.agrDatoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoUsuario.ForeColor = System.Drawing.Color.Black
        Me.agrDatoUsuario.Location = New System.Drawing.Point(11, 149)
        Me.agrDatoUsuario.Name = "agrDatoUsuario"
        Me.agrDatoUsuario.Size = New System.Drawing.Size(596, 110)
        Me.agrDatoUsuario.TabIndex = 45
        Me.agrDatoUsuario.Text = "Datos de Usuario"
        Me.agrDatoUsuario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiCodigo
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.etiCodigo.Appearance = Appearance3
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.Black
        Me.etiCodigo.Location = New System.Drawing.Point(6, 22)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(44, 14)
        Me.etiCodigo.TabIndex = 11
        Me.etiCodigo.Text = "Código:"
        '
        'etiLogin
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.etiLogin.Appearance = Appearance4
        Me.etiLogin.AutoSize = True
        Me.etiLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiLogin.ForeColor = System.Drawing.Color.Black
        Me.etiLogin.Location = New System.Drawing.Point(112, 22)
        Me.etiLogin.Name = "etiLogin"
        Me.etiLogin.Size = New System.Drawing.Size(35, 14)
        Me.etiLogin.TabIndex = 13
        Me.etiLogin.Text = "Login:"
        '
        'txtAutorizacion
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.txtAutorizacion.Appearance = Appearance5
        Me.txtAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAutorizacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizacion.ForeColor = System.Drawing.Color.Black
        Me.txtAutorizacion.Location = New System.Drawing.Point(6, 84)
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAutorizacion.Size = New System.Drawing.Size(100, 21)
        Me.txtAutorizacion.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.txtAutorizacion, "Digite la clave de acceso del usuario")
        '
        'etiClave
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.etiClave.Appearance = Appearance6
        Me.etiClave.AutoSize = True
        Me.etiClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiClave.ForeColor = System.Drawing.Color.Black
        Me.etiClave.Location = New System.Drawing.Point(363, 22)
        Me.etiClave.Name = "etiClave"
        Me.etiClave.Size = New System.Drawing.Size(37, 14)
        Me.etiClave.TabIndex = 15
        Me.etiClave.Text = "Clave:"
        '
        'Etiqueta1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance7
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 66)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta1.TabIndex = 42
        Me.Etiqueta1.Text = "Autorizacion:"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(197, 84)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 11
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'verControlado
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.FontData.BoldAsString = "True"
        Me.verControlado.Appearance = Appearance8
        Me.verControlado.AutoSize = True
        Me.verControlado.BackColor = System.Drawing.Color.Transparent
        Me.verControlado.BackColorInternal = System.Drawing.Color.Transparent
        Me.verControlado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verControlado.ForeColor = System.Drawing.Color.Black
        Me.verControlado.Location = New System.Drawing.Point(114, 84)
        Me.verControlado.Name = "verControlado"
        Me.verControlado.Size = New System.Drawing.Size(77, 17)
        Me.verControlado.TabIndex = 17
        Me.verControlado.Text = "Controlado"
        '
        'txtCodigo
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Appearance = Appearance9
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(6, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 12
        '
        'txtLogin
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.txtLogin.Appearance = Appearance10
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.Black
        Me.txtLogin.Location = New System.Drawing.Point(112, 39)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.ReadOnly = True
        Me.txtLogin.Size = New System.Drawing.Size(245, 21)
        Me.txtLogin.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtLogin, "Digite el nombre asignado al usuario")
        '
        'txtClave
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.txtClave.Appearance = Appearance11
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClave.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Black
        Me.txtClave.Location = New System.Drawing.Point(363, 39)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(204, 21)
        Me.txtClave.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtClave, "Digite la clave de acceso del usuario")
        '
        'agrDatosPersonales
        '
        Me.agrDatosPersonales.Controls.Add(Me.etiDni)
        Me.agrDatosPersonales.Controls.Add(Me.etiApellidoPaterno)
        Me.agrDatosPersonales.Controls.Add(Me.etiApellidoMaterno)
        Me.agrDatosPersonales.Controls.Add(Me.fecNacimiento)
        Me.agrDatosPersonales.Controls.Add(Me.etiNombre)
        Me.agrDatosPersonales.Controls.Add(Me.txtApellidoPaterno)
        Me.agrDatosPersonales.Controls.Add(Me.txtApellidoMaterno)
        Me.agrDatosPersonales.Controls.Add(Me.Sexo1)
        Me.agrDatosPersonales.Controls.Add(Me.txtNombre)
        Me.agrDatosPersonales.Controls.Add(Me.etiFechaNacimiento)
        Me.agrDatosPersonales.Controls.Add(Me.txtDni)
        Me.agrDatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosPersonales.ForeColor = System.Drawing.Color.Black
        Me.agrDatosPersonales.Location = New System.Drawing.Point(11, 30)
        Me.agrDatosPersonales.Name = "agrDatosPersonales"
        Me.agrDatosPersonales.Size = New System.Drawing.Size(596, 113)
        Me.agrDatosPersonales.TabIndex = 44
        Me.agrDatosPersonales.Text = "Datos Personales"
        Me.agrDatosPersonales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiDni
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.etiDni.Appearance = Appearance12
        Me.etiDni.AutoSize = True
        Me.etiDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDni.ForeColor = System.Drawing.Color.Black
        Me.etiDni.Location = New System.Drawing.Point(8, 25)
        Me.etiDni.Name = "etiDni"
        Me.etiDni.Size = New System.Drawing.Size(27, 14)
        Me.etiDni.TabIndex = 0
        Me.etiDni.Text = "DNI:"
        '
        'etiApellidoPaterno
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.etiApellidoPaterno.Appearance = Appearance13
        Me.etiApellidoPaterno.AutoSize = True
        Me.etiApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiApellidoPaterno.ForeColor = System.Drawing.Color.Black
        Me.etiApellidoPaterno.Location = New System.Drawing.Point(114, 25)
        Me.etiApellidoPaterno.Name = "etiApellidoPaterno"
        Me.etiApellidoPaterno.Size = New System.Drawing.Size(91, 14)
        Me.etiApellidoPaterno.TabIndex = 2
        Me.etiApellidoPaterno.Text = "Apellido Paterno:"
        '
        'etiApellidoMaterno
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.etiApellidoMaterno.Appearance = Appearance14
        Me.etiApellidoMaterno.AutoSize = True
        Me.etiApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiApellidoMaterno.ForeColor = System.Drawing.Color.Black
        Me.etiApellidoMaterno.Location = New System.Drawing.Point(340, 25)
        Me.etiApellidoMaterno.Name = "etiApellidoMaterno"
        Me.etiApellidoMaterno.Size = New System.Drawing.Size(93, 14)
        Me.etiApellidoMaterno.TabIndex = 4
        Me.etiApellidoMaterno.Text = "Apellido Materno:"
        '
        'fecNacimiento
        '
        Me.fecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecNacimiento.Location = New System.Drawing.Point(277, 82)
        Me.fecNacimiento.Name = "fecNacimiento"
        Me.fecNacimiento.Size = New System.Drawing.Size(92, 20)
        Me.fecNacimiento.TabIndex = 41
        '
        'etiNombre
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.etiNombre.Appearance = Appearance15
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.Black
        Me.etiNombre.Location = New System.Drawing.Point(8, 67)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(48, 14)
        Me.etiNombre.TabIndex = 6
        Me.etiNombre.Text = "Nombre:"
        '
        'txtApellidoPaterno
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.txtApellidoPaterno.Appearance = Appearance16
        Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.ForeColor = System.Drawing.Color.Black
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(114, 40)
        Me.txtApellidoPaterno.MaxLength = 50
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(220, 21)
        Me.txtApellidoPaterno.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtApellidoPaterno, "Digite el apellido paterno del usuario")
        '
        'txtApellidoMaterno
        '
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.txtApellidoMaterno.Appearance = Appearance17
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.ForeColor = System.Drawing.Color.Black
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(340, 40)
        Me.txtApellidoMaterno.MaxLength = 50
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(234, 21)
        Me.txtApellidoMaterno.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtApellidoMaterno, "Digite el apellido materno del usuario")
        '
        'Sexo1
        '
        Me.Sexo1.BackColor = System.Drawing.Color.Transparent
        Me.Sexo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sexo1.Location = New System.Drawing.Point(375, 78)
        Me.Sexo1.Name = "Sexo1"
        E_Sexo1.Abreviatura = "M"
        E_Sexo1.Id = "1"
        E_Sexo1.Nombre = "Masculino"
        Me.Sexo1.Sexo = E_Sexo1
        Me.Sexo1.Size = New System.Drawing.Size(206, 24)
        Me.Sexo1.TabIndex = 8
        '
        'txtNombre
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Appearance = Appearance18
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(8, 82)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(263, 21)
        Me.txtNombre.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtNombre, "Digite los nombres del usuario")
        '
        'etiFechaNacimiento
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.etiFechaNacimiento.Appearance = Appearance19
        Me.etiFechaNacimiento.AutoSize = True
        Me.etiFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.etiFechaNacimiento.Location = New System.Drawing.Point(277, 67)
        Me.etiFechaNacimiento.Name = "etiFechaNacimiento"
        Me.etiFechaNacimiento.Size = New System.Drawing.Size(59, 14)
        Me.etiFechaNacimiento.TabIndex = 9
        Me.etiFechaNacimiento.Text = "Fec. Nac. :"
        '
        'txtDni
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.txtDni.Appearance = Appearance20
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.ForeColor = System.Drawing.Color.Black
        Me.txtDni.Location = New System.Drawing.Point(8, 40)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 21)
        Me.txtDni.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtDni, "Digite el número de DNI del usuario")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(613, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'ordUsuario
        '
        UltraDataColumn33.DataType = GetType(Boolean)
        Me.ordUsuario.Band.Columns.AddRange(New Object() {UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'ficUsuario
        '
        Me.ficUsuario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficUsuario.Controls.Add(Me.UltraTabPageControl1)
        Me.ficUsuario.Controls.Add(Me.UltraTabPageControl2)
        Me.ficUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficUsuario.Location = New System.Drawing.Point(0, 0)
        Me.ficUsuario.Name = "ficUsuario"
        Me.ficUsuario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficUsuario.Size = New System.Drawing.Size(1125, 534)
        Me.ficUsuario.TabIndex = 0
        UltraTab1.Key = "ficLista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "ficMantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficUsuario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficUsuario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1123, 511)
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 534)
        Me.Controls.Add(Me.ficUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Usuario"
        Me.Text = "Usuarios"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.agrPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrPerfil.ResumeLayout(False)
        CType(Me.griPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrListaPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaPerfil.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griPerfilder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordPerfilDer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.agrTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTurno.ResumeLayout(False)
        CType(Me.griTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrListaTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaTurno.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griListaTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl5.PerformLayout()
        CType(Me.numIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTiempoAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLanzaAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCierreAutomatico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrListaCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaCentro.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.griCentroder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordCentroDer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrTotalUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalUsuarios.ResumeLayout(False)
        CType(Me.griUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.agrUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrUsuario.ResumeLayout(False)
        CType(Me.agrDatoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoUsuario.ResumeLayout(False)
        Me.agrDatoUsuario.PerformLayout()
        CType(Me.txtAutorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verControlado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosPersonales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosPersonales.ResumeLayout(False)
        Me.agrDatosPersonales.PerformLayout()
        CType(Me.txtApellidoPaterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficUsuario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficUsuario As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ordUsuario As ISL.Controles.OrigenDatos
    Friend WithEvents agrUsuario As ISL.Controles.Agrupacion
    Friend WithEvents etiLogin As ISL.Controles.Etiqueta
    Friend WithEvents etiDni As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiApellidoPaterno As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents txtClave As ISL.Controles.Texto
    Friend WithEvents txtLogin As ISL.Controles.Texto
    Friend WithEvents txtDni As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtApellidoPaterno As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents etiClave As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaNacimiento As ISL.Controles.Etiqueta
    Friend WithEvents txtApellidoMaterno As ISL.Controles.Texto
    Friend WithEvents etiApellidoMaterno As ISL.Controles.Etiqueta
    Friend WithEvents agrTotalUsuarios As ISL.Controles.Agrupacion
    Friend WithEvents griUsuario As ISL.Controles.Grilla
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Sexo1 As ISL.Win.Sexo
    Friend WithEvents ordPerfil As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents griPerfilder As ISL.Controles.Grilla
    Friend WithEvents ordPerfilDer As ISL.Controles.OrigenDatos
    Friend WithEvents agrListaPerfil As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ficDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrPerfil As ISL.Controles.Agrupacion
    Friend WithEvents griPerfil As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTurno As ISL.Controles.Agrupacion
    Friend WithEvents agrListaTurno As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griTurno As ISL.Controles.Grilla
    Friend WithEvents griListaTurno As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents numIntervalo As ISL.Controles.Numero
    Friend WithEvents numTiempoAlerta As ISL.Controles.Numero
    Friend WithEvents verLanzaAlerta As ISL.Controles.Chequear
    Friend WithEvents verCierreAutomatico As ISL.Controles.Chequear
    Friend WithEvents etiTiempoAlerta As ISL.Controles.Etiqueta
    Friend WithEvents etiIntervalo As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents verControlado As ISL.Controles.Chequear
    Friend WithEvents fecNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAutorizacion As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents agrDatosPersonales As ISL.Controles.Agrupacion
    Friend WithEvents agrDatoUsuario As ISL.Controles.Agrupacion
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As Controles.Agrupacion
    Friend WithEvents griCentro As Controles.Grilla
    Friend WithEvents agrListaCentro As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griCentroder As Controles.Grilla
    Friend WithEvents ordCentro As Controles.OrigenDatos
    Friend WithEvents ordCentroDer As Controles.OrigenDatos
End Class
