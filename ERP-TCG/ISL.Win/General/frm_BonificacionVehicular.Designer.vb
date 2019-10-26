<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BonificacionVehicular
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroResolucion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bonificacion")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroResolucion")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Bonificacion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Porcentaje")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumentoVehicular")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Eje")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoSuspension")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KgEje")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KgSuspension")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KgNeumatico")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClaseNeumatico")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonificacionEje")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoEje")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Capacidades", 81373954)
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("GrupoLinea", 81373955)
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumentoVehicular")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Eje")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoSuspension")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KgEje")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KgSuspension")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KgNeumatico")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClaseNeumatico")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonificacionEje")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoEje")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GroupListado = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grid_Bonos = New ISL.Controles.Grilla(Me.components)
        Me.MenuBonificaciones = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odDocumentoBonificacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.GridBonificaciones = New Infragistics.Win.Misc.UltraGroupBox()
        Me.expVencer = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chk_Vigentes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPinta = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDias = New ISL.Controles.Numero(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel4 = New Infragistics.Win.Misc.UltraPanel()
        Me.Grid_BonosDetalles = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odBonificaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.CmbSuspension = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndKgSuspension = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndKgNeumatico = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndKgEje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.CmbNeumatico = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndBonificacionEje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndPesoEje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.CmbEje = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.OptRemolcadorPosterior = New System.Windows.Forms.RadioButton()
        Me.CmbFilTracto = New ISL.Controles.ComboMaestros(Me.components)
        Me.OptRemolcadorDelantero = New System.Windows.Forms.RadioButton()
        Me.OptMotorizado = New System.Windows.Forms.RadioButton()
        Me.TxtNroRuedas = New ISL.Controles.Texto(Me.components)
        Me.TxtNroEjes = New ISL.Controles.Texto(Me.components)
        Me.TxtMotor = New ISL.Controles.Texto(Me.components)
        Me.TxtSerie = New ISL.Controles.Texto(Me.components)
        Me.TxtAñoFabri = New ISL.Controles.Texto(Me.components)
        Me.TxtModelo = New ISL.Controles.Texto(Me.components)
        Me.TxtMarca = New ISL.Controles.Texto(Me.components)
        Me.TxtCategoria = New ISL.Controles.Texto(Me.components)
        Me.TxtPlaca = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.Texto1 = New ISL.Controles.Texto(Me.components)
        Me.TxtNumero = New ISL.Controles.Texto(Me.components)
        Me.dtp_FTermino = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FEmision = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaInicio = New Infragistics.Win.Misc.UltraLabel()
        Me.txtResolucion = New ISL.Controles.Texto(Me.components)
        Me.LblNumero = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ndPorcentajeFinal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ndPesoFinal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndBonificacionFinal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.tcBonificacion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.numDias = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorVencimiento = New ISL.Controles.Colores(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.GroupListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupListado.SuspendLayout()
        CType(Me.grid_Bonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBonificaciones.SuspendLayout()
        CType(Me.odDocumentoBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBonificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridBonificaciones.SuspendLayout()
        CType(Me.expVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expVencer.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.chk_Vigentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.ColorPinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        Me.UltraPanel4.ClientArea.SuspendLayout()
        Me.UltraPanel4.SuspendLayout()
        CType(Me.Grid_BonosDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odBonificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.CmbSuspension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndKgSuspension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndKgNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndKgEje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndBonificacionEje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndPesoEje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.CmbFilTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroRuedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroEjes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAñoFabri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        CType(Me.ndPorcentajeFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndPesoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndBonificacionFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcBonificacion.SuspendLayout()
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GroupListado)
        Me.UltraTabPageControl1.Controls.Add(Me.GridBonificaciones)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1147, 583)
        '
        'GroupListado
        '
        Me.GroupListado.Controls.Add(Me.grid_Bonos)
        Me.GroupListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupListado.Location = New System.Drawing.Point(0, 85)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(1147, 498)
        Me.GroupListado.TabIndex = 1
        Me.GroupListado.Text = "Relación de Bonificaciones vehiculares"
        Me.GroupListado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grid_Bonos
        '
        Me.grid_Bonos.ContextMenuStrip = Me.MenuBonificaciones
        Me.grid_Bonos.DataSource = Me.odDocumentoBonificacion
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        Appearance1.TextHAlignAsString = "Left"
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.Caption = "Número de Resolucion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 186
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance2
        UltraGridColumn3.Header.Caption = "Número de P. de Bon."
        UltraGridColumn3.Header.VisiblePosition = 2
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance3
        UltraGridColumn4.Header.VisiblePosition = 3
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance4
        UltraGridColumn5.Header.VisiblePosition = 4
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance5
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.Caption = "Fecha de Emision"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 103
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.Caption = "Fecha de Vencimiento"
        UltraGridColumn8.Header.VisiblePosition = 7
        Appearance6.TextHAlignAsString = "Left"
        UltraGridColumn9.CellAppearance = Appearance6
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 203
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn10.CellAppearance = Appearance7
        UltraGridColumn10.Header.VisiblePosition = 9
        Appearance8.TextHAlignAsString = "Left"
        UltraGridColumn11.CellAppearance = Appearance8
        UltraGridColumn11.Header.Caption = "Tipo de Vehiculo"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 233
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Appearance9.TextHAlignAsString = "Center"
        UltraGridBand1.Override.ActiveCellAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Center"
        UltraGridBand1.Override.CellAppearance = Appearance10
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Bonos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_Bonos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Bonos.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Bonos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Appearance11.TextVAlignAsString = "Middle"
        Me.grid_Bonos.DisplayLayout.Override.CellAppearance = Appearance11
        Me.grid_Bonos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Bonos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Bonos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Bonos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Bonos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grid_Bonos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Bonos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_Bonos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Bonos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Bonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Bonos.Location = New System.Drawing.Point(2, 19)
        Me.grid_Bonos.Name = "grid_Bonos"
        Me.grid_Bonos.Size = New System.Drawing.Size(1143, 477)
        Me.grid_Bonos.TabIndex = 15
        '
        'MenuBonificaciones
        '
        Me.MenuBonificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBonificaciones.ForeColor = System.Drawing.Color.Black
        Me.MenuBonificaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuBonificaciones.Name = "MenuContextual1"
        Me.MenuBonificaciones.Size = New System.Drawing.Size(111, 70)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'odDocumentoBonificacion
        '
        Me.odDocumentoBonificacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'GridBonificaciones
        '
        Me.GridBonificaciones.Controls.Add(Me.expVencer)
        Me.GridBonificaciones.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.GridBonificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridBonificaciones.Location = New System.Drawing.Point(0, 0)
        Me.GridBonificaciones.Name = "GridBonificaciones"
        Me.GridBonificaciones.Size = New System.Drawing.Size(1147, 85)
        Me.GridBonificaciones.TabIndex = 0
        Me.GridBonificaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'expVencer
        '
        Me.expVencer.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.expVencer.ContentAreaAppearance = Appearance12
        Me.expVencer.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.expVencer.Dock = System.Windows.Forms.DockStyle.Left
        Me.expVencer.ExpandedSize = New System.Drawing.Size(176, 81)
        Me.expVencer.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.expVencer.Location = New System.Drawing.Point(244, 2)
        Me.expVencer.Name = "expVencer"
        Me.expVencer.Size = New System.Drawing.Size(176, 81)
        Me.expVencer.TabIndex = 32
        Me.expVencer.Text = "Vigencia"
        Me.expVencer.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.chk_Vigentes)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(25, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(148, 75)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'chk_Vigentes
        '
        Me.chk_Vigentes.BackColor = System.Drawing.Color.White
        Me.chk_Vigentes.BackColorInternal = System.Drawing.Color.White
        Me.chk_Vigentes.Checked = True
        Me.chk_Vigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Vigentes.Location = New System.Drawing.Point(3, 32)
        Me.chk_Vigentes.Name = "chk_Vigentes"
        Me.chk_Vigentes.Size = New System.Drawing.Size(141, 20)
        Me.chk_Vigentes.TabIndex = 0
        Me.chk_Vigentes.Text = "Mostrar solo vigentes."
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance13
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(242, 81)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(242, 81)
        Me.UltraExpandableGroupBox2.TabIndex = 31
        Me.UltraExpandableGroupBox2.Text = "Venc."
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorPinta)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.NumeroDias)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(25, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(214, 75)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'Etiqueta3
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance14
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(0, 35)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "Por vencer en"
        '
        'ColorPinta
        '
        Me.ColorPinta.Color = System.Drawing.Color.LightCoral
        Me.ColorPinta.Location = New System.Drawing.Point(167, 31)
        Me.ColorPinta.Name = "ColorPinta"
        Me.ColorPinta.Size = New System.Drawing.Size(44, 22)
        Me.ColorPinta.TabIndex = 7
        Me.ColorPinta.Text = "LightCoral"
        '
        'Etiqueta2
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance15
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(137, 35)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(24, 14)
        Me.Etiqueta2.TabIndex = 9
        Me.Etiqueta2.Text = "días"
        '
        'NumeroDias
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.NumeroDias.Appearance = Appearance16
        Me.NumeroDias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDias.ForeColor = System.Drawing.Color.MidnightBlue
        Me.NumeroDias.Location = New System.Drawing.Point(81, 31)
        Me.NumeroDias.MaskInput = "nnn"
        Me.NumeroDias.Name = "NumeroDias"
        Me.NumeroDias.NullText = "0"
        Me.NumeroDias.Size = New System.Drawing.Size(52, 21)
        Me.NumeroDias.TabIndex = 38
        Me.NumeroDias.Value = 45
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1147, 583)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.UltraPanel1)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 301)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1147, 282)
        Me.UltraGroupBox4.TabIndex = 2
        Me.UltraGroupBox4.Text = "Detalle de Bonificación Vehicular"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPanel2)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(2, 19)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1143, 261)
        Me.UltraPanel1.TabIndex = 2
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraPanel4)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(1143, 261)
        Me.UltraPanel2.TabIndex = 14
        '
        'UltraPanel4
        '
        Appearance17.BackColor = System.Drawing.Color.AliceBlue
        Me.UltraPanel4.Appearance = Appearance17
        '
        'UltraPanel4.ClientArea
        '
        Me.UltraPanel4.ClientArea.Controls.Add(Me.Grid_BonosDetalles)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel4.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel4.Name = "UltraPanel4"
        Me.UltraPanel4.Size = New System.Drawing.Size(1143, 261)
        Me.UltraPanel4.TabIndex = 343
        '
        'Grid_BonosDetalles
        '
        Me.Grid_BonosDetalles.DataSource = Me.odBonificaciones
        Appearance18.BackColor = System.Drawing.Color.AliceBlue
        Appearance18.BorderAlpha = Infragistics.Win.Alpha.Opaque
        Appearance18.BorderColor = System.Drawing.Color.AliceBlue
        Appearance18.TextVAlignAsString = "Middle"
        Me.Grid_BonosDetalles.DisplayLayout.Appearance = Appearance18
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn12.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 77)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn13.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance19.TextHAlignAsString = "Center"
        Appearance19.TextVAlignAsString = "Middle"
        UltraGridColumn14.Header.Appearance = Appearance19
        UltraGridColumn14.Header.Caption = "Eje o Conjunto de ejes"
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn14.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(100, 0)
        UltraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn15.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance20.TextHAlignAsString = "Center"
        Appearance20.TextVAlignAsString = "Middle"
        UltraGridColumn15.Header.Appearance = Appearance20
        UltraGridColumn15.Header.Caption = "Tipo de Suspension (1)"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn15.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(107, 0)
        UltraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 5
        Appearance21.TextHAlignAsString = "Right"
        Appearance21.TextVAlignAsString = "Middle"
        UltraGridColumn16.CellAppearance = Appearance21
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance22.TextHAlignAsString = "Center"
        Appearance22.TextVAlignAsString = "Middle"
        UltraGridColumn16.Header.Appearance = Appearance22
        UltraGridColumn16.Header.Caption = "Eje o Conjunto de ejes (Kg.)"
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupKey = "Capacidades"
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn16.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 37)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 4
        Appearance23.TextHAlignAsString = "Right"
        Appearance23.TextVAlignAsString = "Middle"
        UltraGridColumn17.CellAppearance = Appearance23
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance24.TextHAlignAsString = "Center"
        Appearance24.TextVAlignAsString = "Middle"
        UltraGridColumn17.Header.Appearance = Appearance24
        UltraGridColumn17.Header.Caption = "Conjunto de Suspensión (Kg.)"
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridColumn17.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupKey = "Capacidades"
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn17.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 37)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 4
        Appearance25.TextHAlignAsString = "Right"
        Appearance25.TextVAlignAsString = "Middle"
        UltraGridColumn18.CellAppearance = Appearance25
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance26.TextHAlignAsString = "Center"
        Appearance26.TextVAlignAsString = "Middle"
        UltraGridColumn18.Header.Appearance = Appearance26
        UltraGridColumn18.Header.Caption = "Neumático (Kg.) (2)"
        UltraGridColumn18.Header.VisiblePosition = 6
        UltraGridColumn18.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupKey = "Capacidades"
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn18.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 37)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance27.TextHAlignAsString = "Center"
        Appearance27.TextVAlignAsString = "Middle"
        UltraGridColumn19.Header.Appearance = Appearance27
        UltraGridColumn19.Header.Caption = "Clase de Neumatico (3)"
        UltraGridColumn19.Header.VisiblePosition = 7
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(124, 0)
        UltraGridColumn19.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 5
        Appearance28.TextHAlignAsString = "Right"
        Appearance28.TextVAlignAsString = "Middle"
        UltraGridColumn20.CellAppearance = Appearance28
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance29.TextHAlignAsString = "Center"
        Appearance29.TextVAlignAsString = "Middle"
        UltraGridColumn20.Header.Appearance = Appearance29
        UltraGridColumn20.Header.Caption = "Bonificación otorgada para el eje o conjunto de ejes"
        UltraGridColumn20.Header.VisiblePosition = 8
        UltraGridColumn20.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn20.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(122, 0)
        UltraGridColumn20.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 5
        Appearance30.TextHAlignAsString = "Right"
        Appearance30.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance30
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance31.TextHAlignAsString = "Center"
        Appearance31.TextVAlignAsString = "Middle"
        UltraGridColumn21.Header.Appearance = Appearance31
        UltraGridColumn21.Header.Caption = "Peso máximo por eje o conjunto de ejes con bonificación (Kg.)"
        UltraGridColumn21.Header.VisiblePosition = 9
        UltraGridColumn21.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(115, 0)
        UltraGridColumn21.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn22.Header.VisiblePosition = 10
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn22.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Header.VisiblePosition = 11
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn23.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Header.VisiblePosition = 12
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupKey = "GrupoLinea"
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(170, 0)
        UltraGridColumn24.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 65)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 5
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        Appearance32.TextHAlignAsString = "Center"
        Appearance32.TextVAlignAsString = "Middle"
        UltraGridGroup1.Header.Appearance = Appearance32
        UltraGridGroup1.Header.Caption = "Capacidades especificadas por el fabricante"
        UltraGridGroup1.Key = "Capacidades"
        UltraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 8
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.ParentGroupIndex = 1
        UltraGridGroup1.RowLayoutGroupInfo.ParentGroupKey = "GrupoLinea"
        UltraGridGroup1.RowLayoutGroupInfo.PreferredLabelSize = New System.Drawing.Size(0, 34)
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 5
        UltraGridGroup2.Header.Caption = ""
        UltraGridGroup2.Key = "GrupoLinea"
        UltraGridGroup2.RowLayoutGroupInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.Bottom
        UltraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 0
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 26
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 6
        UltraGridBand2.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2})
        Appearance33.TextHAlignAsString = "Center"
        Appearance33.TextVAlignAsString = "Middle"
        UltraGridBand2.Header.Appearance = Appearance33
        UltraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.Grid_BonosDetalles.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid_BonosDetalles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.Grid_BonosDetalles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance34.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance34.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance34.BorderColor = System.Drawing.SystemColors.Window
        Me.Grid_BonosDetalles.DisplayLayout.GroupByBox.Appearance = Appearance34
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grid_BonosDetalles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance35
        Me.Grid_BonosDetalles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance36.BackColor2 = System.Drawing.SystemColors.Control
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grid_BonosDetalles.DisplayLayout.GroupByBox.PromptAppearance = Appearance36
        Me.Grid_BonosDetalles.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_BonosDetalles.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_BonosDetalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grid_BonosDetalles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grid_BonosDetalles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grid_BonosDetalles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.Grid_BonosDetalles.DisplayLayout.Override.CellPadding = 0
        Me.Grid_BonosDetalles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_BonosDetalles.DisplayLayout.Override.FilterOperatorDropDownItems = Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.None
        Me.Grid_BonosDetalles.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance37.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.BorderColor = System.Drawing.SystemColors.Window
        Me.Grid_BonosDetalles.DisplayLayout.Override.GroupByRowAppearance = Appearance37
        Appearance38.TextHAlignAsString = "Left"
        Me.Grid_BonosDetalles.DisplayLayout.Override.HeaderAppearance = Appearance38
        Me.Grid_BonosDetalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance39.BackColor = System.Drawing.SystemColors.Window
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Me.Grid_BonosDetalles.DisplayLayout.Override.RowAppearance = Appearance39
        Me.Grid_BonosDetalles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_BonosDetalles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_BonosDetalles.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid_BonosDetalles.DisplayLayout.Override.TemplateAddRowAppearance = Appearance40
        Me.Grid_BonosDetalles.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_BonosDetalles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid_BonosDetalles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid_BonosDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_BonosDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_BonosDetalles.Location = New System.Drawing.Point(0, 0)
        Me.Grid_BonosDetalles.Name = "Grid_BonosDetalles"
        Me.Grid_BonosDetalles.Size = New System.Drawing.Size(876, 261)
        Me.Grid_BonosDetalles.TabIndex = 22
        Me.Grid_BonosDetalles.Text = "UltraGrid1"
        '
        'odBonificaciones
        '
        Me.odBonificaciones.Band.Columns.AddRange(New Object() {UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance41.BackColor = System.Drawing.Color.White
        Appearance41.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance41
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(267, 261)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(876, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(267, 261)
        Me.UltraExpandableGroupBox1.TabIndex = 342
        Me.UltraExpandableGroupBox1.Text = "Detalle de bonificación vehicular:"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraButton1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel18)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel23)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.CmbSuspension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel21)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndKgSuspension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndKgNeumatico)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel19)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndKgEje)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.CmbNeumatico)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel16)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndBonificacionEje)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndPesoEje)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.CmbEje)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(25, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(239, 255)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraButton1
        '
        Appearance42.Image = "add.ico"
        Me.UltraButton1.Appearance = Appearance42
        Me.UltraButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.UltraButton1.Location = New System.Drawing.Point(143, 223)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(69, 30)
        Me.UltraButton1.TabIndex = 362
        Me.UltraButton1.Text = "Eliminar"
        '
        'btnAgregar
        '
        Appearance43.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance43
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(42, 223)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(70, 30)
        Me.btnAgregar.TabIndex = 341
        Me.btnAgregar.Text = "Agregar"
        '
        'UltraLabel18
        '
        Appearance44.BackColor = System.Drawing.Color.White
        Me.UltraLabel18.Appearance = Appearance44
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(3, 7)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(91, 15)
        Me.UltraLabel18.TabIndex = 354
        Me.UltraLabel18.Text = "Seleccione un eje"
        '
        'UltraLabel23
        '
        Appearance45.BackColor = System.Drawing.Color.White
        Me.UltraLabel23.Appearance = Appearance45
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(3, 196)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(102, 15)
        Me.UltraLabel23.TabIndex = 361
        Me.UltraLabel23.Text = "Peso máx. por eje :"
        '
        'CmbSuspension
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.CmbSuspension.Appearance = Appearance46
        Me.CmbSuspension.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbSuspension.DisplayMember = "Nombre"
        Me.CmbSuspension.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbSuspension.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbSuspension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSuspension.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "MECANICA"
        ValueListItem1.DisplayText = "MECANICA"
        ValueListItem2.DataValue = "NEUMATICA"
        ValueListItem2.DisplayText = "NEUMATICA"
        Me.CmbSuspension.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.CmbSuspension.Location = New System.Drawing.Point(123, 30)
        Me.CmbSuspension.Name = "CmbSuspension"
        Me.CmbSuspension.Size = New System.Drawing.Size(108, 21)
        Me.CmbSuspension.TabIndex = 7
        Me.CmbSuspension.ValueMember = "Id"
        '
        'UltraLabel21
        '
        Appearance47.BackColor = System.Drawing.Color.White
        Me.UltraLabel21.Appearance = Appearance47
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(3, 169)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(110, 15)
        Me.UltraLabel21.TabIndex = 360
        Me.UltraLabel21.Text = "Bonificación por eje :"
        '
        'ndKgSuspension
        '
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.ndKgSuspension.Appearance = Appearance48
        Me.ndKgSuspension.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndKgSuspension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKgSuspension.ForeColor = System.Drawing.Color.Black
        Me.ndKgSuspension.Location = New System.Drawing.Point(123, 84)
        Me.ndKgSuspension.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndKgSuspension.Name = "ndKgSuspension"
        Me.ndKgSuspension.NullText = "0.00"
        Me.ndKgSuspension.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKgSuspension.Size = New System.Drawing.Size(108, 21)
        Me.ndKgSuspension.TabIndex = 338
        '
        'UltraLabel20
        '
        Appearance49.BackColor = System.Drawing.Color.White
        Me.UltraLabel20.Appearance = Appearance49
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(3, 142)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(107, 15)
        Me.UltraLabel20.TabIndex = 359
        Me.UltraLabel20.Text = "Clase de Neumático:"
        '
        'ndKgNeumatico
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.ndKgNeumatico.Appearance = Appearance50
        Me.ndKgNeumatico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndKgNeumatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKgNeumatico.ForeColor = System.Drawing.Color.Black
        Me.ndKgNeumatico.Location = New System.Drawing.Point(123, 111)
        Me.ndKgNeumatico.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndKgNeumatico.Name = "ndKgNeumatico"
        Me.ndKgNeumatico.NullText = "0.00"
        Me.ndKgNeumatico.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKgNeumatico.Size = New System.Drawing.Size(108, 21)
        Me.ndKgNeumatico.TabIndex = 342
        '
        'UltraLabel19
        '
        Appearance51.BackColor = System.Drawing.Color.White
        Me.UltraLabel19.Appearance = Appearance51
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(3, 115)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(86, 15)
        Me.UltraLabel19.TabIndex = 358
        Me.UltraLabel19.Text = "Neumático (Kg.)"
        '
        'ndKgEje
        '
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.ndKgEje.Appearance = Appearance52
        Me.ndKgEje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndKgEje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKgEje.ForeColor = System.Drawing.Color.Black
        Me.ndKgEje.Location = New System.Drawing.Point(123, 57)
        Me.ndKgEje.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndKgEje.Name = "ndKgEje"
        Me.ndKgEje.NullText = "0.00"
        Me.ndKgEje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKgEje.Size = New System.Drawing.Size(108, 21)
        Me.ndKgEje.TabIndex = 333
        '
        'UltraLabel17
        '
        Appearance53.BackColor = System.Drawing.Color.White
        Me.UltraLabel17.Appearance = Appearance53
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(3, 88)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(118, 15)
        Me.UltraLabel17.TabIndex = 357
        Me.UltraLabel17.Text = "Conj suspensión (Kg.):"
        '
        'CmbNeumatico
        '
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.CmbNeumatico.Appearance = Appearance54
        Me.CmbNeumatico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbNeumatico.DisplayMember = "Nombre"
        Me.CmbNeumatico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbNeumatico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbNeumatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbNeumatico.ForeColor = System.Drawing.Color.Black
        ValueListItem7.DataValue = "CONVENCIONAL"
        ValueListItem7.DisplayText = "CONVENCIONAL"
        ValueListItem8.DataValue = "EXTRA ANCHO"
        ValueListItem8.DisplayText = "EXTRA ANCHO"
        Me.CmbNeumatico.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8})
        Me.CmbNeumatico.Location = New System.Drawing.Point(123, 138)
        Me.CmbNeumatico.Name = "CmbNeumatico"
        Me.CmbNeumatico.Size = New System.Drawing.Size(108, 21)
        Me.CmbNeumatico.TabIndex = 8
        Me.CmbNeumatico.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance55.BackColor = System.Drawing.Color.White
        Me.UltraLabel16.Appearance = Appearance55
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(3, 61)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(115, 15)
        Me.UltraLabel16.TabIndex = 356
        Me.UltraLabel16.Text = "Eje o Conj. ejes (Kg.):"
        '
        'ndBonificacionEje
        '
        Appearance56.ForeColor = System.Drawing.Color.Black
        Me.ndBonificacionEje.Appearance = Appearance56
        Me.ndBonificacionEje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndBonificacionEje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndBonificacionEje.ForeColor = System.Drawing.Color.Black
        Me.ndBonificacionEje.Location = New System.Drawing.Point(123, 165)
        Me.ndBonificacionEje.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndBonificacionEje.Name = "ndBonificacionEje"
        Me.ndBonificacionEje.NullText = "0.00"
        Me.ndBonificacionEje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndBonificacionEje.Size = New System.Drawing.Size(108, 21)
        Me.ndBonificacionEje.TabIndex = 339
        '
        'UltraLabel15
        '
        Appearance57.BackColor = System.Drawing.Color.White
        Me.UltraLabel15.Appearance = Appearance57
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(3, 34)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(104, 15)
        Me.UltraLabel15.TabIndex = 355
        Me.UltraLabel15.Text = "Tipo de suspensión:"
        '
        'ndPesoEje
        '
        Appearance58.ForeColor = System.Drawing.Color.Black
        Me.ndPesoEje.Appearance = Appearance58
        Me.ndPesoEje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndPesoEje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndPesoEje.ForeColor = System.Drawing.Color.Black
        Me.ndPesoEje.Location = New System.Drawing.Point(123, 192)
        Me.ndPesoEje.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndPesoEje.Name = "ndPesoEje"
        Me.ndPesoEje.NullText = "0.00"
        Me.ndPesoEje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndPesoEje.Size = New System.Drawing.Size(108, 21)
        Me.ndPesoEje.TabIndex = 352
        '
        'CmbEje
        '
        Appearance59.ForeColor = System.Drawing.Color.Black
        Me.CmbEje.Appearance = Appearance59
        Me.CmbEje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbEje.DisplayMember = "Nombre"
        Me.CmbEje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbEje.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbEje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEje.ForeColor = System.Drawing.Color.Black
        ValueListItem5.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem5.DataValue = "DELANTERO"
        ValueListItem5.DisplayText = "DELANTERO"
        ValueListItem6.DataValue = "POSTERIOR 1"
        ValueListItem6.DisplayText = "POSTERIOR 1"
        ValueListItem9.DataValue = "POSTERIOR 2"
        ValueListItem9.DisplayText = "POSTERIOR 2"
        ValueListItem11.DataValue = "POSTERIOR 3"
        ValueListItem11.DisplayText = "POSTERIOR 3"
        ValueListItem10.DataValue = "POSTERIOR 4"
        ValueListItem10.DisplayText = "POSTERIOR 4"
        Me.CmbEje.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6, ValueListItem9, ValueListItem11, ValueListItem10})
        Me.CmbEje.Location = New System.Drawing.Point(123, 3)
        Me.CmbEje.Name = "CmbEje"
        Me.CmbEje.Size = New System.Drawing.Size(108, 21)
        Me.CmbEje.TabIndex = 353
        Me.CmbEje.ValueMember = ""
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox2.Controls.Add(Me.Texto1)
        Me.UltraGroupBox2.Controls.Add(Me.TxtNumero)
        Me.UltraGroupBox2.Controls.Add(Me.dtp_FTermino)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.dtp_FEmision)
        Me.UltraGroupBox2.Controls.Add(Me.LblFechaInicio)
        Me.UltraGroupBox2.Controls.Add(Me.txtResolucion)
        Me.UltraGroupBox2.Controls.Add(Me.LblNumero)
        Me.UltraGroupBox2.Controls.Add(Me.Panel)
        Me.UltraGroupBox2.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1147, 301)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraLabel24
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel24.Appearance = Appearance60
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(11, 27)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(87, 15)
        Me.UltraLabel24.TabIndex = 343
        Me.UltraLabel24.Text = "Resolución MTC:"
        '
        'UltraLabel22
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel22.Appearance = Appearance61
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(11, 55)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(77, 15)
        Me.UltraLabel22.TabIndex = 342
        Me.UltraLabel22.Text = "Emp. emisora:"
        '
        'UltraLabel14
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel14.Appearance = Appearance62
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(53, 162)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel14.TabIndex = 341
        Me.UltraLabel14.Text = "Glosa:"
        '
        'UltraGroupBox3
        '
        Appearance63.BackColor = System.Drawing.Color.White
        Me.UltraGroupBox3.Appearance = Appearance63
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox1)
        Me.UltraGroupBox3.Controls.Add(Me.TxtNroRuedas)
        Me.UltraGroupBox3.Controls.Add(Me.TxtNroEjes)
        Me.UltraGroupBox3.Controls.Add(Me.TxtMotor)
        Me.UltraGroupBox3.Controls.Add(Me.TxtSerie)
        Me.UltraGroupBox3.Controls.Add(Me.TxtAñoFabri)
        Me.UltraGroupBox3.Controls.Add(Me.TxtModelo)
        Me.UltraGroupBox3.Controls.Add(Me.TxtMarca)
        Me.UltraGroupBox3.Controls.Add(Me.TxtCategoria)
        Me.UltraGroupBox3.Controls.Add(Me.TxtPlaca)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(443, 23)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(375, 222)
        Me.UltraGroupBox3.TabIndex = 14
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.OptRemolcadorPosterior)
        Me.UltraGroupBox1.Controls.Add(Me.CmbFilTracto)
        Me.UltraGroupBox1.Controls.Add(Me.OptRemolcadorDelantero)
        Me.UltraGroupBox1.Controls.Add(Me.OptMotorizado)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(359, 75)
        Me.UltraGroupBox1.TabIndex = 344
        '
        'OptRemolcadorPosterior
        '
        Me.OptRemolcadorPosterior.AutoSize = True
        Me.OptRemolcadorPosterior.Location = New System.Drawing.Point(22, 52)
        Me.OptRemolcadorPosterior.Name = "OptRemolcadorPosterior"
        Me.OptRemolcadorPosterior.Size = New System.Drawing.Size(168, 17)
        Me.OptRemolcadorPosterior.TabIndex = 12
        Me.OptRemolcadorPosterior.Text = "Vehículo Remolcado Posterior "
        Me.OptRemolcadorPosterior.UseVisualStyleBackColor = True
        '
        'CmbFilTracto
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.CmbFilTracto.Appearance = Appearance64
        Me.CmbFilTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbFilTracto.DisplayMember = "Placa"
        Me.CmbFilTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbFilTracto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbFilTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFilTracto.ForeColor = System.Drawing.Color.Black
        Me.CmbFilTracto.Location = New System.Drawing.Point(240, 26)
        Me.CmbFilTracto.Name = "CmbFilTracto"
        Me.CmbFilTracto.Size = New System.Drawing.Size(105, 21)
        Me.CmbFilTracto.TabIndex = 11
        Me.CmbFilTracto.ValueMember = "Id"
        '
        'OptRemolcadorDelantero
        '
        Me.OptRemolcadorDelantero.AutoSize = True
        Me.OptRemolcadorDelantero.Location = New System.Drawing.Point(22, 28)
        Me.OptRemolcadorDelantero.Name = "OptRemolcadorDelantero"
        Me.OptRemolcadorDelantero.Size = New System.Drawing.Size(168, 17)
        Me.OptRemolcadorDelantero.TabIndex = 6
        Me.OptRemolcadorDelantero.Text = "Vehículo Remolcado delantero"
        Me.OptRemolcadorDelantero.UseVisualStyleBackColor = True
        '
        'OptMotorizado
        '
        Me.OptMotorizado.AutoSize = True
        Me.OptMotorizado.Checked = True
        Me.OptMotorizado.Location = New System.Drawing.Point(22, 7)
        Me.OptMotorizado.Name = "OptMotorizado"
        Me.OptMotorizado.Size = New System.Drawing.Size(120, 17)
        Me.OptMotorizado.TabIndex = 5
        Me.OptMotorizado.TabStop = True
        Me.OptMotorizado.Text = "Vehículo Motorizado"
        Me.OptMotorizado.UseVisualStyleBackColor = True
        '
        'TxtNroRuedas
        '
        Appearance65.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroRuedas.Appearance = Appearance65
        Me.TxtNroRuedas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroRuedas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNroRuedas.Enabled = False
        Me.TxtNroRuedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroRuedas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroRuedas.Location = New System.Drawing.Point(264, 167)
        Me.TxtNroRuedas.MaxLength = 100
        Me.TxtNroRuedas.Name = "TxtNroRuedas"
        Me.TxtNroRuedas.Size = New System.Drawing.Size(91, 21)
        Me.TxtNroRuedas.TabIndex = 297
        '
        'TxtNroEjes
        '
        Appearance66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroEjes.Appearance = Appearance66
        Me.TxtNroEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroEjes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNroEjes.Enabled = False
        Me.TxtNroEjes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroEjes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroEjes.Location = New System.Drawing.Point(264, 140)
        Me.TxtNroEjes.MaxLength = 100
        Me.TxtNroEjes.Name = "TxtNroEjes"
        Me.TxtNroEjes.Size = New System.Drawing.Size(91, 21)
        Me.TxtNroEjes.TabIndex = 296
        '
        'TxtMotor
        '
        Appearance67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMotor.Appearance = Appearance67
        Me.TxtMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtMotor.Enabled = False
        Me.TxtMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMotor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMotor.Location = New System.Drawing.Point(264, 115)
        Me.TxtMotor.MaxLength = 100
        Me.TxtMotor.Name = "TxtMotor"
        Me.TxtMotor.Size = New System.Drawing.Size(91, 21)
        Me.TxtMotor.TabIndex = 295
        '
        'TxtSerie
        '
        Appearance68.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtSerie.Appearance = Appearance68
        Me.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtSerie.Enabled = False
        Me.TxtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtSerie.Location = New System.Drawing.Point(264, 88)
        Me.TxtSerie.MaxLength = 100
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(91, 21)
        Me.TxtSerie.TabIndex = 294
        '
        'TxtAñoFabri
        '
        Appearance69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoFabri.Appearance = Appearance69
        Me.TxtAñoFabri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAñoFabri.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtAñoFabri.Enabled = False
        Me.TxtAñoFabri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAñoFabri.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoFabri.Location = New System.Drawing.Point(85, 193)
        Me.TxtAñoFabri.MaxLength = 100
        Me.TxtAñoFabri.Name = "TxtAñoFabri"
        Me.TxtAñoFabri.Size = New System.Drawing.Size(86, 21)
        Me.TxtAñoFabri.TabIndex = 293
        '
        'TxtModelo
        '
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtModelo.Appearance = Appearance70
        Me.TxtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtModelo.Enabled = False
        Me.TxtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtModelo.Location = New System.Drawing.Point(85, 167)
        Me.TxtModelo.MaxLength = 100
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(86, 21)
        Me.TxtModelo.TabIndex = 292
        '
        'TxtMarca
        '
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMarca.Appearance = Appearance71
        Me.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMarca.Location = New System.Drawing.Point(85, 140)
        Me.TxtMarca.MaxLength = 100
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(86, 21)
        Me.TxtMarca.TabIndex = 291
        '
        'TxtCategoria
        '
        Appearance72.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCategoria.Appearance = Appearance72
        Me.TxtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCategoria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCategoria.Enabled = False
        Me.TxtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategoria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCategoria.Location = New System.Drawing.Point(85, 115)
        Me.TxtCategoria.MaxLength = 100
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(86, 21)
        Me.TxtCategoria.TabIndex = 290
        '
        'TxtPlaca
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPlaca.Appearance = Appearance73
        Me.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPlaca.Enabled = False
        Me.TxtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlaca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPlaca.Location = New System.Drawing.Point(85, 88)
        Me.TxtPlaca.MaxLength = 100
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(86, 21)
        Me.TxtPlaca.TabIndex = 289
        '
        'UltraLabel13
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel13.Appearance = Appearance74
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(189, 171)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(74, 15)
        Me.UltraLabel13.TabIndex = 21
        Me.UltraLabel13.Text = "9. N° Ruedas:"
        '
        'UltraLabel12
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel12.Appearance = Appearance75
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(189, 144)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(55, 15)
        Me.UltraLabel12.TabIndex = 20
        Me.UltraLabel12.Text = "8. N°Ejes:"
        '
        'UltraLabel11
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel11.Appearance = Appearance76
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(189, 119)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(67, 15)
        Me.UltraLabel11.TabIndex = 19
        Me.UltraLabel11.Text = "7. N° Motor:"
        '
        'UltraLabel10
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel10.Appearance = Appearance77
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(189, 92)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(63, 15)
        Me.UltraLabel10.TabIndex = 18
        Me.UltraLabel10.Text = "6. N° Serie:"
        '
        'UltraLabel9
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel9.Appearance = Appearance78
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(13, 197)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(67, 15)
        Me.UltraLabel9.TabIndex = 17
        Me.UltraLabel9.Text = "5. Año fabr.:"
        '
        'UltraLabel8
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel8.Appearance = Appearance79
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(13, 170)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(57, 15)
        Me.UltraLabel8.TabIndex = 16
        Me.UltraLabel8.Text = "4. Modelo:"
        '
        'UltraLabel7
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel7.Appearance = Appearance80
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(13, 143)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(51, 15)
        Me.UltraLabel7.TabIndex = 15
        Me.UltraLabel7.Text = "3. Marca:"
        '
        'UltraLabel6
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel6.Appearance = Appearance81
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(13, 119)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel6.TabIndex = 14
        Me.UltraLabel6.Text = "2. Categoria:"
        '
        'UltraLabel5
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel5.Appearance = Appearance82
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 92)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "1. Placa:"
        '
        'Texto1
        '
        Appearance83.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Texto1.Appearance = Appearance83
        Me.Texto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto1.Enabled = False
        Me.Texto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Texto1.Location = New System.Drawing.Point(108, 51)
        Me.Texto1.MaxLength = 100
        Me.Texto1.Name = "Texto1"
        Me.Texto1.Size = New System.Drawing.Size(170, 21)
        Me.Texto1.TabIndex = 340
        Me.Texto1.Text = "MTC"
        '
        'TxtNumero
        '
        Appearance84.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNumero.Appearance = Appearance84
        Me.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNumero.Location = New System.Drawing.Point(108, 78)
        Me.TxtNumero.MaxLength = 100
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(170, 21)
        Me.TxtNumero.TabIndex = 288
        '
        'dtp_FTermino
        '
        Me.dtp_FTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FTermino.Location = New System.Drawing.Point(108, 132)
        Me.dtp_FTermino.Name = "dtp_FTermino"
        Me.dtp_FTermino.Size = New System.Drawing.Size(170, 21)
        Me.dtp_FTermino.TabIndex = 328
        '
        'UltraLabel1
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance85
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(11, 135)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(82, 15)
        Me.UltraLabel1.TabIndex = 327
        Me.UltraLabel1.Text = "Fecha Termino:"
        '
        'dtp_FEmision
        '
        Me.dtp_FEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FEmision.Location = New System.Drawing.Point(108, 106)
        Me.dtp_FEmision.Name = "dtp_FEmision"
        Me.dtp_FEmision.Size = New System.Drawing.Size(170, 21)
        Me.dtp_FEmision.TabIndex = 326
        '
        'LblFechaInicio
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaInicio.Appearance = Appearance86
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Location = New System.Drawing.Point(10, 108)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(80, 15)
        Me.LblFechaInicio.TabIndex = 289
        Me.LblFechaInicio.Text = "Fecha Emisión:"
        '
        'txtResolucion
        '
        Appearance87.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Appearance87.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtResolucion.Appearance = Appearance87
        Me.txtResolucion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtResolucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResolucion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResolucion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtResolucion.Location = New System.Drawing.Point(108, 23)
        Me.txtResolucion.MaxLength = 100
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(170, 21)
        Me.txtResolucion.TabIndex = 287
        '
        'LblNumero
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Me.LblNumero.Appearance = Appearance88
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(10, 81)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(79, 15)
        Me.LblNumero.TabIndex = 13
        Me.LblNumero.Text = "Bonificación N:"
        '
        'Panel
        '
        Appearance89.BackColor = System.Drawing.Color.White
        Me.Panel.Appearance = Appearance89
        Me.Panel.Controls.Add(Me.ndPorcentajeFinal)
        Me.Panel.Controls.Add(Me.ndPesoFinal)
        Me.Panel.Controls.Add(Me.UltraLabel4)
        Me.Panel.Controls.Add(Me.UltraLabel3)
        Me.Panel.Controls.Add(Me.ndBonificacionFinal)
        Me.Panel.Controls.Add(Me.UltraLabel2)
        Me.Panel.Location = New System.Drawing.Point(11, 251)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(807, 44)
        Me.Panel.TabIndex = 329
        '
        'ndPorcentajeFinal
        '
        Appearance90.ForeColor = System.Drawing.Color.Black
        Me.ndPorcentajeFinal.Appearance = Appearance90
        Me.ndPorcentajeFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndPorcentajeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndPorcentajeFinal.ForeColor = System.Drawing.Color.Black
        Me.ndPorcentajeFinal.Location = New System.Drawing.Point(721, 12)
        Me.ndPorcentajeFinal.MaskInput = "nnn.nn"
        Me.ndPorcentajeFinal.Name = "ndPorcentajeFinal"
        Me.ndPorcentajeFinal.NullText = "0.00"
        Me.ndPorcentajeFinal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndPorcentajeFinal.Size = New System.Drawing.Size(75, 21)
        Me.ndPorcentajeFinal.TabIndex = 333
        '
        'ndPesoFinal
        '
        Appearance91.ForeColor = System.Drawing.Color.Black
        Me.ndPesoFinal.Appearance = Appearance91
        Me.ndPesoFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndPesoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndPesoFinal.ForeColor = System.Drawing.Color.Black
        Me.ndPesoFinal.Location = New System.Drawing.Point(511, 13)
        Me.ndPesoFinal.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndPesoFinal.Name = "ndPesoFinal"
        Me.ndPesoFinal.NullText = "0.00"
        Me.ndPesoFinal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndPesoFinal.Size = New System.Drawing.Size(75, 21)
        Me.ndPesoFinal.TabIndex = 332
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(653, 17)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel4.TabIndex = 334
        Me.UltraLabel4.Text = "Porcentaje:"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(337, 17)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(170, 15)
        Me.UltraLabel3.TabIndex = 331
        Me.UltraLabel3.Text = "Peso bruto veh. con bonificación:"
        '
        'ndBonificacionFinal
        '
        Appearance92.ForeColor = System.Drawing.Color.Black
        Me.ndBonificacionFinal.Appearance = Appearance92
        Me.ndBonificacionFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndBonificacionFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndBonificacionFinal.ForeColor = System.Drawing.Color.Black
        Me.ndBonificacionFinal.Location = New System.Drawing.Point(225, 12)
        Me.ndBonificacionFinal.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndBonificacionFinal.Name = "ndBonificacionFinal"
        Me.ndBonificacionFinal.NullText = "0.00"
        Me.ndBonificacionFinal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndBonificacionFinal.Size = New System.Drawing.Size(73, 21)
        Me.ndBonificacionFinal.TabIndex = 330
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(6, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(223, 15)
        Me.UltraLabel2.TabIndex = 290
        Me.UltraLabel2.Text = "Bonificación otorgada Peso bruto veh. (Kg):"
        '
        'txtGlosa
        '
        Appearance93.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance93
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(108, 160)
        Me.txtGlosa.MaxLength = 100
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(170, 85)
        Me.txtGlosa.TabIndex = 335
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1147, 583)
        '
        'tcBonificacion
        '
        Me.tcBonificacion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcBonificacion.Controls.Add(Me.UltraTabPageControl1)
        Me.tcBonificacion.Controls.Add(Me.UltraTabPageControl2)
        Me.tcBonificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcBonificacion.Location = New System.Drawing.Point(0, 0)
        Me.tcBonificacion.Name = "tcBonificacion"
        Me.tcBonificacion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcBonificacion.Size = New System.Drawing.Size(1149, 606)
        Me.tcBonificacion.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tcBonificacion.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcBonificacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcBonificacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'numDias
        '
        Appearance94.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numDias.Appearance = Appearance94
        Me.numDias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDias.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numDias.Location = New System.Drawing.Point(81, 17)
        Me.numDias.MaskInput = "nnn"
        Me.numDias.Name = "numDias"
        Me.numDias.NullText = "0"
        Me.numDias.Size = New System.Drawing.Size(52, 21)
        Me.numDias.TabIndex = 38
        Me.numDias.Value = 45
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(139, 24)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(24, 14)
        Me.Etiqueta1.TabIndex = 9
        Me.Etiqueta1.Text = "días"
        '
        'Etiqueta51
        '
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(3, 24)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta51.TabIndex = 8
        Me.Etiqueta51.Text = "Por vencer en"
        '
        'ColorVencimiento
        '
        Me.ColorVencimiento.Color = System.Drawing.Color.LightCoral
        Me.ColorVencimiento.Location = New System.Drawing.Point(169, 17)
        Me.ColorVencimiento.Name = "ColorVencimiento"
        Me.ColorVencimiento.Size = New System.Drawing.Size(44, 21)
        Me.ColorVencimiento.TabIndex = 7
        Me.ColorVencimiento.Text = "LightCoral"
        '
        'frm_BonificacionVehicular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 606)
        Me.Controls.Add(Me.tcBonificacion)
        Me.Name = "frm_BonificacionVehicular"
        Me.Text = "Bonificaciones vehiculares"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.GroupListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupListado.ResumeLayout(False)
        CType(Me.grid_Bonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBonificaciones.ResumeLayout(False)
        CType(Me.odDocumentoBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBonificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridBonificaciones.ResumeLayout(False)
        CType(Me.expVencer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expVencer.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.chk_Vigentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.ColorPinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        Me.UltraPanel4.ClientArea.ResumeLayout(False)
        Me.UltraPanel4.ResumeLayout(False)
        CType(Me.Grid_BonosDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odBonificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.CmbSuspension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndKgSuspension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndKgNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndKgEje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndBonificacionEje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndPesoEje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.CmbFilTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroRuedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroEjes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMotor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAñoFabri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.ndPorcentajeFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndPesoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndBonificacionFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcBonificacion.ResumeLayout(False)
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents odDocumentoBonificacion As ISL.Controles.OrigenDatos
    Friend WithEvents odBonificaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents TxtNroRuedas As ISL.Controles.Texto
    Friend WithEvents TxtNroEjes As ISL.Controles.Texto
    Friend WithEvents CmbFilTracto As ISL.Controles.ComboMaestros
    Friend WithEvents TxtMotor As ISL.Controles.Texto
    Friend WithEvents TxtSerie As ISL.Controles.Texto
    Friend WithEvents TxtAñoFabri As ISL.Controles.Texto
    Friend WithEvents TxtModelo As ISL.Controles.Texto
    Friend WithEvents TxtMarca As ISL.Controles.Texto
    Friend WithEvents TxtCategoria As ISL.Controles.Texto
    Friend WithEvents TxtPlaca As ISL.Controles.Texto
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Texto1 As ISL.Controles.Texto
    Friend WithEvents TxtNumero As ISL.Controles.Texto
    Friend WithEvents dtp_FTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaInicio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtResolucion As ISL.Controles.Texto
    Friend WithEvents LblNumero As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ndPorcentajeFinal As ISL.Controles.NumeroDecimal
    Friend WithEvents ndPesoFinal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndBonificacionFinal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GroupListado As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GridBonificaciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tcBonificacion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CmbSuspension As ISL.Controles.ComboMaestros
    Friend WithEvents ndKgSuspension As ISL.Controles.NumeroDecimal
    Friend WithEvents ndKgNeumatico As ISL.Controles.NumeroDecimal
    Friend WithEvents ndKgEje As ISL.Controles.NumeroDecimal
    Friend WithEvents CmbNeumatico As ISL.Controles.ComboMaestros
    Friend WithEvents ndBonificacionEje As ISL.Controles.NumeroDecimal
    Friend WithEvents ndPesoEje As ISL.Controles.NumeroDecimal
    Friend WithEvents CmbEje As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraPanel4 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents OptRemolcadorDelantero As System.Windows.Forms.RadioButton
    Friend WithEvents OptMotorizado As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents OptRemolcadorPosterior As System.Windows.Forms.RadioButton
    Friend WithEvents grid_Bonos As ISL.Controles.Grilla
    Friend WithEvents numDias As ISL.Controles.Numero
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents ColorVencimiento As ISL.Controles.Colores
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPinta As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDias As ISL.Controles.Numero
    Friend WithEvents expVencer As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents chk_Vigentes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents MenuBonificaciones As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Grid_BonosDetalles As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
