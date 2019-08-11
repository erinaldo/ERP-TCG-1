<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Material
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdZona")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMinimo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMaximo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdZona")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMinimo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMaximo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Material))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPrincipal")
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPrincipal")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CaracteristicaEspecial")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCaracteristicaEspecial")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CaracteristicaEspecial")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCaracteristicaEspecial")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1223)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(906)
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton7 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton8 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton9 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton10 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton11 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContableActivo")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCuenta")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataBand3 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand4 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_Almacenes = New ISL.Controles.Grilla(Me.components)
        Me.odAlmacenes = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtZona = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndStockMaximo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndStockMinimo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAgregarAlmacen = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cbAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaCodBarras = New ISL.Controles.Grilla(Me.components)
        Me.odCodigoBarras = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnQuitarCodigo = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigoBarra = New ISL.Controles.Texto(Me.components)
        Me.btnAgregarCodigo = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griCaracteristicaMaterial = New ISL.Controles.Grilla(Me.components)
        Me.odCarMat = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnQuitCarac = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAgrCar = New Infragistics.Win.Misc.UltraButton()
        Me.cboCaracteristicaEspecial = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrLista = New ISL.Controles.Agrupacion(Me.components)
        Me.griMaterial = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cbTipoMaterial = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cbSubFamilia = New ISL.Controles.ComboMaestros(Me.components)
        Me.cbFamilia = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tcDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrMantenimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.verActivoFijo = New ISL.Controles.Chequear(Me.components)
        Me.chkContabilizable = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmbModelo = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbMarca = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnGuardarProveedor = New ISL.Controles.Boton(Me.components)
        Me.txtId = New ISL.Controles.Texto(Me.components)
        Me.cboTipoMaterial = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.decPeso = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtMedida = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.txtSerial = New ISL.Controles.Texto(Me.components)
        Me.cboUnidadMedida = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboTipoUnidadMedida = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboSubFamilia = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboFamilia = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.verIgv = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.odMaterialCtaCtble = New ISL.Controles.OrigenDatos(Me.components)
        Me.odMarca = New ISL.Controles.OrigenDatos(Me.components)
        Me.ficMaterial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.odMaterialFamilia = New ISL.Controles.OrigenDatos(Me.components)
        Me.odMaterialMedida = New ISL.Controles.OrigenDatos(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.grid_Almacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.txtZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndStockMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.griListaCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtCodigoBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.griCaracteristicaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCarMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cboCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLista.SuspendLayout()
        CType(Me.griMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cbTipoMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSubFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDetalle.SuspendLayout()
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMantenimiento.SuspendLayout()
        CType(Me.verActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkContabilizable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterialCtaCtble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMaterial.SuspendLayout()
        CType(Me.odMaterialFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterialMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.grid_Almacenes)
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1229, 255)
        '
        'grid_Almacenes
        '
        Me.grid_Almacenes.DataSource = Me.odAlmacenes
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 34
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 7
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Width = 383
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.VisiblePosition = 11
        UltraGridColumn20.Header.VisiblePosition = 12
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance1
        UltraGridColumn21.Header.VisiblePosition = 14
        UltraGridColumn21.MaskInput = "nnnnn"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn21.Width = 80
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance2
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn22.Header.VisiblePosition = 15
        UltraGridColumn22.MaskInput = "nnnnn"
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn22.Width = 85
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance3
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn23.Header.VisiblePosition = 16
        UltraGridColumn23.MaskInput = "nnnnn"
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn24.Header.VisiblePosition = 17
        UltraGridColumn24.Hidden = True
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance4
        UltraGridColumn28.Header.VisiblePosition = 13
        UltraGridColumn28.MaskInput = "{double:8.4}"
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn28.Width = 95
        UltraGridColumn29.Header.VisiblePosition = 18
        UltraGridColumn29.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn28, UltraGridColumn29})
        Me.grid_Almacenes.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_Almacenes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Almacenes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Almacenes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Almacenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_Almacenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Me.grid_Almacenes.DisplayLayout.Override.CellAppearance = Appearance5
        Me.grid_Almacenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Almacenes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Almacenes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Almacenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Me.grid_Almacenes.DisplayLayout.Override.RowAppearance = Appearance6
        Me.grid_Almacenes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Almacenes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_Almacenes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Almacenes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grid_Almacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Almacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Almacenes.Location = New System.Drawing.Point(0, 58)
        Me.grid_Almacenes.Name = "grid_Almacenes"
        Me.grid_Almacenes.Size = New System.Drawing.Size(1229, 197)
        Me.grid_Almacenes.TabIndex = 1
        '
        'odAlmacenes
        '
        UltraDataColumn14.DataType = GetType(Short)
        UltraDataColumn15.DataType = GetType(Short)
        UltraDataColumn16.DataType = GetType(Short)
        UltraDataColumn18.DataType = GetType(Double)
        Me.odAlmacenes.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.txtZona)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion2.Controls.Add(Me.ndStockMaximo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion2.Controls.Add(Me.ndStockMinimo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.btnAgregarAlmacen)
        Me.Agrupacion2.Controls.Add(Me.cbAlmacen)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1229, 58)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Agregar:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtZona
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtZona.Appearance = Appearance7
        Me.txtZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtZona.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtZona.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtZona.Location = New System.Drawing.Point(897, 27)
        Me.txtZona.MaxLength = 20
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(113, 21)
        Me.txtZona.TabIndex = 7
        Me.txtZona.Tag = "0"
        '
        'Etiqueta25
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta25.Appearance = Appearance8
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta25.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta25.Location = New System.Drawing.Point(860, 29)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta25.TabIndex = 6
        Me.Etiqueta25.Text = "Zona:"
        '
        'ndStockMaximo
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.ndStockMaximo.Appearance = Appearance9
        Me.ndStockMaximo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndStockMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndStockMaximo.ForeColor = System.Drawing.Color.Black
        Me.ndStockMaximo.Location = New System.Drawing.Point(747, 26)
        Me.ndStockMaximo.Name = "ndStockMaximo"
        Me.ndStockMaximo.NullText = "0.00"
        Me.ndStockMaximo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndStockMaximo.Size = New System.Drawing.Size(90, 21)
        Me.ndStockMaximo.TabIndex = 5
        '
        'Etiqueta24
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta24.Appearance = Appearance10
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta24.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta24.Location = New System.Drawing.Point(669, 28)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(76, 14)
        Me.Etiqueta24.TabIndex = 4
        Me.Etiqueta24.Text = "Stock Maximo:"
        '
        'ndStockMinimo
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.ndStockMinimo.Appearance = Appearance11
        Me.ndStockMinimo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndStockMinimo.ForeColor = System.Drawing.Color.Black
        Me.ndStockMinimo.Location = New System.Drawing.Point(561, 26)
        Me.ndStockMinimo.Name = "ndStockMinimo"
        Me.ndStockMinimo.NullText = "0.00"
        Me.ndStockMinimo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndStockMinimo.Size = New System.Drawing.Size(90, 21)
        Me.ndStockMinimo.TabIndex = 3
        '
        'Etiqueta23
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta23.Appearance = Appearance12
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta23.Location = New System.Drawing.Point(483, 28)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(73, 14)
        Me.Etiqueta23.TabIndex = 2
        Me.Etiqueta23.Text = "Stock Minimo:"
        '
        'Etiqueta2
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance13
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta2.Location = New System.Drawing.Point(17, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Almacen:"
        '
        'btnAgregarAlmacen
        '
        Appearance14.Image = "add.ico"
        Me.btnAgregarAlmacen.Appearance = Appearance14
        Me.btnAgregarAlmacen.ImageList = Me.imagenes
        Me.btnAgregarAlmacen.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarAlmacen.Location = New System.Drawing.Point(1016, 23)
        Me.btnAgregarAlmacen.Name = "btnAgregarAlmacen"
        Me.btnAgregarAlmacen.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarAlmacen.TabIndex = 8
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
        'cbAlmacen
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.cbAlmacen.Appearance = Appearance15
        Me.cbAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbAlmacen.DisplayMember = "Nombre"
        Me.cbAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cbAlmacen.Location = New System.Drawing.Point(72, 26)
        Me.cbAlmacen.Name = "cbAlmacen"
        Me.cbAlmacen.Size = New System.Drawing.Size(377, 21)
        Me.cbAlmacen.TabIndex = 1
        Me.cbAlmacen.ValueMember = "Id"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griListaCodBarras)
        Me.UltraTabPageControl9.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1229, 255)
        '
        'griListaCodBarras
        '
        Me.griListaCodBarras.DataSource = Me.odCodigoBarras
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaCodBarras.DisplayLayout.Appearance = Appearance16
        UltraGridColumn335.Header.VisiblePosition = 0
        UltraGridColumn335.Hidden = True
        UltraGridColumn336.Header.VisiblePosition = 1
        UltraGridColumn336.Width = 203
        UltraGridColumn337.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn337.Header.VisiblePosition = 2
        UltraGridColumn338.Header.VisiblePosition = 3
        UltraGridColumn338.Hidden = True
        UltraGridColumn339.Header.VisiblePosition = 4
        UltraGridColumn339.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn338, UltraGridColumn339})
        Me.griListaCodBarras.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaCodBarras.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaCodBarras.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaCodBarras.DisplayLayout.GroupByBox.Appearance = Appearance17
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaCodBarras.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance18
        Me.griListaCodBarras.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance19.BackColor2 = System.Drawing.SystemColors.Control
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaCodBarras.DisplayLayout.GroupByBox.PromptAppearance = Appearance19
        Me.griListaCodBarras.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaCodBarras.DisplayLayout.MaxRowScrollRegions = 1
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaCodBarras.DisplayLayout.Override.ActiveCellAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.SystemColors.Highlight
        Appearance21.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaCodBarras.DisplayLayout.Override.ActiveRowAppearance = Appearance21
        Me.griListaCodBarras.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaCodBarras.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Me.griListaCodBarras.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Appearance23.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaCodBarras.DisplayLayout.Override.CellAppearance = Appearance23
        Me.griListaCodBarras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaCodBarras.DisplayLayout.Override.CellPadding = 0
        Appearance24.BackColor = System.Drawing.SystemColors.Control
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaCodBarras.DisplayLayout.Override.GroupByRowAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Left"
        Me.griListaCodBarras.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.griListaCodBarras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaCodBarras.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Me.griListaCodBarras.DisplayLayout.Override.RowAppearance = Appearance26
        Me.griListaCodBarras.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaCodBarras.DisplayLayout.Override.TemplateAddRowAppearance = Appearance27
        Me.griListaCodBarras.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaCodBarras.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaCodBarras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaCodBarras.Location = New System.Drawing.Point(0, 52)
        Me.griListaCodBarras.Name = "griListaCodBarras"
        Me.griListaCodBarras.Size = New System.Drawing.Size(1229, 203)
        Me.griListaCodBarras.TabIndex = 1
        Me.griListaCodBarras.Text = "Grilla1"
        '
        'odCodigoBarras
        '
        UltraDataColumn22.DataType = GetType(Boolean)
        Me.odCodigoBarras.Band.Columns.AddRange(New Object() {UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnQuitarCodigo)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion3.Controls.Add(Me.txtCodigoBarra)
        Me.Agrupacion3.Controls.Add(Me.btnAgregarCodigo)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1229, 52)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Agregar:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnQuitarCodigo
        '
        Appearance28.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Appearance28.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance28.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnQuitarCodigo.Appearance = Appearance28
        Me.btnQuitarCodigo.ImageList = Me.imagenes
        Me.btnQuitarCodigo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitarCodigo.Location = New System.Drawing.Point(294, 21)
        Me.btnQuitarCodigo.Name = "btnQuitarCodigo"
        Me.btnQuitarCodigo.Size = New System.Drawing.Size(26, 26)
        Me.btnQuitarCodigo.TabIndex = 3
        '
        'Etiqueta10
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance29
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta10.Location = New System.Drawing.Point(20, 25)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(77, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Código Barras:"
        '
        'txtCodigoBarra
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoBarra.Appearance = Appearance30
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoBarra.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCodigoBarra.Location = New System.Drawing.Point(105, 24)
        Me.txtCodigoBarra.MaxLength = 300
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(151, 21)
        Me.txtCodigoBarra.TabIndex = 1
        Me.txtCodigoBarra.TabStop = False
        Me.txtCodigoBarra.Tag = "0"
        '
        'btnAgregarCodigo
        '
        Appearance31.Image = "add.ico"
        Appearance31.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance31.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAgregarCodigo.Appearance = Appearance31
        Me.btnAgregarCodigo.ImageList = Me.imagenes
        Me.btnAgregarCodigo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarCodigo.Location = New System.Drawing.Point(262, 21)
        Me.btnAgregarCodigo.Name = "btnAgregarCodigo"
        Me.btnAgregarCodigo.Size = New System.Drawing.Size(26, 26)
        Me.btnAgregarCodigo.TabIndex = 2
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.griCaracteristicaMaterial)
        Me.UltraTabPageControl10.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1229, 255)
        '
        'griCaracteristicaMaterial
        '
        Me.griCaracteristicaMaterial.DataSource = Me.odCarMat
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griCaracteristicaMaterial.DisplayLayout.Appearance = Appearance32
        UltraGridColumn328.Header.VisiblePosition = 0
        UltraGridColumn328.Hidden = True
        UltraGridColumn329.Header.VisiblePosition = 1
        UltraGridColumn329.Hidden = True
        UltraGridColumn330.Header.VisiblePosition = 3
        UltraGridColumn330.Hidden = True
        UltraGridColumn331.Header.VisiblePosition = 2
        UltraGridColumn331.Hidden = True
        UltraGridColumn332.Header.VisiblePosition = 4
        UltraGridColumn332.Width = 349
        UltraGridColumn333.Header.VisiblePosition = 5
        UltraGridColumn333.Hidden = True
        UltraGridColumn334.Header.VisiblePosition = 6
        UltraGridColumn334.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334})
        Me.griCaracteristicaMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griCaracteristicaMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCaracteristicaMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.griCaracteristicaMaterial.DisplayLayout.GroupByBox.Appearance = Appearance33
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCaracteristicaMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance34
        Me.griCaracteristicaMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance35.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance35.BackColor2 = System.Drawing.SystemColors.Control
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCaracteristicaMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance35
        Me.griCaracteristicaMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griCaracteristicaMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griCaracteristicaMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance36
        Appearance37.BackColor = System.Drawing.SystemColors.Highlight
        Appearance37.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griCaracteristicaMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance37
        Me.griCaracteristicaMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCaracteristicaMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Me.griCaracteristicaMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance38
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Appearance39.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griCaracteristicaMaterial.DisplayLayout.Override.CellAppearance = Appearance39
        Me.griCaracteristicaMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCaracteristicaMaterial.DisplayLayout.Override.CellPadding = 0
        Appearance40.BackColor = System.Drawing.SystemColors.Control
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.griCaracteristicaMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance40
        Appearance41.TextHAlignAsString = "Left"
        Me.griCaracteristicaMaterial.DisplayLayout.Override.HeaderAppearance = Appearance41
        Me.griCaracteristicaMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCaracteristicaMaterial.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance42.BackColor = System.Drawing.SystemColors.Window
        Appearance42.BorderColor = System.Drawing.Color.Silver
        Me.griCaracteristicaMaterial.DisplayLayout.Override.RowAppearance = Appearance42
        Me.griCaracteristicaMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance43.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griCaracteristicaMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance43
        Me.griCaracteristicaMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCaracteristicaMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCaracteristicaMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCaracteristicaMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCaracteristicaMaterial.Location = New System.Drawing.Point(0, 52)
        Me.griCaracteristicaMaterial.Name = "griCaracteristicaMaterial"
        Me.griCaracteristicaMaterial.Size = New System.Drawing.Size(1229, 203)
        Me.griCaracteristicaMaterial.TabIndex = 1
        Me.griCaracteristicaMaterial.Text = "Grilla1"
        '
        'odCarMat
        '
        UltraDataColumn26.DataType = GetType(Date)
        Me.odCarMat.Band.Columns.AddRange(New Object() {UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31})
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.btnQuitCarac)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion4.Controls.Add(Me.btnAgrCar)
        Me.Agrupacion4.Controls.Add(Me.cboCaracteristicaEspecial)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1229, 52)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Agregar:"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnQuitCarac
        '
        Appearance44.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Appearance44.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance44.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnQuitCarac.Appearance = Appearance44
        Me.btnQuitCarac.ImageList = Me.imagenes
        Me.btnQuitCarac.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitCarac.Location = New System.Drawing.Point(400, 21)
        Me.btnQuitCarac.Name = "btnQuitCarac"
        Me.btnQuitCarac.Size = New System.Drawing.Size(26, 26)
        Me.btnQuitCarac.TabIndex = 3
        '
        'Etiqueta22
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta22.Appearance = Appearance45
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta22.Location = New System.Drawing.Point(11, 27)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta22.TabIndex = 0
        Me.Etiqueta22.Text = "Caracteristica:"
        '
        'btnAgrCar
        '
        Appearance46.Image = "add.ico"
        Appearance46.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance46.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAgrCar.Appearance = Appearance46
        Me.btnAgrCar.ImageList = Me.imagenes
        Me.btnAgrCar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgrCar.Location = New System.Drawing.Point(368, 21)
        Me.btnAgrCar.Name = "btnAgrCar"
        Me.btnAgrCar.Size = New System.Drawing.Size(26, 26)
        Me.btnAgrCar.TabIndex = 2
        '
        'cboCaracteristicaEspecial
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCaracteristicaEspecial.Appearance = Appearance47
        Appearance48.Image = 7
        EditorButton1.Appearance = Appearance48
        Me.cboCaracteristicaEspecial.ButtonsRight.Add(EditorButton1)
        Me.cboCaracteristicaEspecial.DisplayMember = "Nombre"
        Me.cboCaracteristicaEspecial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCaracteristicaEspecial.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCaracteristicaEspecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaracteristicaEspecial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCaracteristicaEspecial.ImageList = Me.imagenes
        Me.cboCaracteristicaEspecial.Location = New System.Drawing.Point(90, 25)
        Me.cboCaracteristicaEspecial.Name = "cboCaracteristicaEspecial"
        Me.cboCaracteristicaEspecial.Size = New System.Drawing.Size(272, 21)
        Me.cboCaracteristicaEspecial.TabIndex = 1
        Me.cboCaracteristicaEspecial.ValueMember = "Id"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrLista)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1231, 546)
        '
        'agrLista
        '
        Me.agrLista.Controls.Add(Me.griMaterial)
        Me.agrLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrLista.Location = New System.Drawing.Point(0, 55)
        Me.agrLista.Name = "agrLista"
        Me.agrLista.Size = New System.Drawing.Size(1231, 491)
        Me.agrLista.TabIndex = 1
        Me.agrLista.Text = "Total de Materiales:"
        Me.agrLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griMaterial
        '
        Me.griMaterial.ContextMenuStrip = Me.MenuContextual1
        Me.griMaterial.DataSource = Me.odMaterial
        Me.griMaterial.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn295.Header.VisiblePosition = 0
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn296.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn296.Header.VisiblePosition = 1
        UltraGridColumn296.Hidden = True
        UltraGridColumn297.Header.VisiblePosition = 2
        UltraGridColumn297.Width = 119
        UltraGridColumn298.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn298.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn298.Header.VisiblePosition = 3
        UltraGridColumn298.Width = 483
        UltraGridColumn299.Header.VisiblePosition = 4
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.Caption = "Tipo Material"
        UltraGridColumn300.Header.VisiblePosition = 5
        UltraGridColumn300.Width = 151
        UltraGridColumn301.Header.VisiblePosition = 10
        UltraGridColumn301.Hidden = True
        UltraGridColumn302.Header.VisiblePosition = 8
        UltraGridColumn302.Width = 199
        UltraGridColumn303.Header.VisiblePosition = 7
        UltraGridColumn303.Hidden = True
        UltraGridColumn304.Header.Caption = "Sub Familia"
        UltraGridColumn304.Header.VisiblePosition = 9
        UltraGridColumn304.Width = 154
        UltraGridColumn305.Header.VisiblePosition = 11
        UltraGridColumn305.Hidden = True
        UltraGridColumn306.Header.Caption = "Tipo U. Medida"
        UltraGridColumn306.Header.VisiblePosition = 12
        UltraGridColumn306.Hidden = True
        UltraGridColumn306.Width = 91
        UltraGridColumn307.Header.VisiblePosition = 14
        UltraGridColumn307.Hidden = True
        UltraGridColumn308.Header.Caption = "U. Medida"
        UltraGridColumn308.Header.VisiblePosition = 13
        UltraGridColumn308.Hidden = True
        UltraGridColumn308.Width = 98
        UltraGridColumn309.Header.VisiblePosition = 16
        UltraGridColumn309.Hidden = True
        UltraGridColumn309.Width = 53
        UltraGridColumn310.Header.VisiblePosition = 15
        UltraGridColumn310.Hidden = True
        UltraGridColumn310.Width = 53
        UltraGridColumn311.Header.VisiblePosition = 17
        UltraGridColumn311.Width = 79
        UltraGridColumn312.Header.VisiblePosition = 18
        UltraGridColumn312.Hidden = True
        UltraGridColumn313.Header.VisiblePosition = 19
        UltraGridColumn313.Hidden = True
        UltraGridColumn314.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn314.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn314.Header.VisiblePosition = 6
        UltraGridColumn314.Hidden = True
        UltraGridColumn315.Header.VisiblePosition = 20
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.Width = 99
        UltraGridColumn316.Header.VisiblePosition = 21
        UltraGridColumn316.Hidden = True
        UltraGridColumn316.Width = 99
        UltraGridColumn317.Header.VisiblePosition = 22
        UltraGridColumn317.Hidden = True
        UltraGridColumn317.Width = 101
        UltraGridColumn318.Header.VisiblePosition = 23
        UltraGridColumn318.Hidden = True
        UltraGridColumn318.Width = 94
        UltraGridColumn319.Header.VisiblePosition = 24
        UltraGridColumn319.Hidden = True
        UltraGridColumn319.Width = 108
        UltraGridColumn320.Header.VisiblePosition = 25
        UltraGridColumn320.Hidden = True
        UltraGridColumn320.Width = 92
        UltraGridColumn26.Header.VisiblePosition = 26
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.Width = 92
        UltraGridColumn27.Header.VisiblePosition = 27
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 77
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn26, UltraGridColumn27})
        Me.griMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griMaterial.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.griMaterial.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.griMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance49.BorderColor = System.Drawing.Color.Silver
        Me.griMaterial.DisplayLayout.Override.CellAppearance = Appearance49
        Me.griMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance50.BorderColor = System.Drawing.Color.Silver
        Me.griMaterial.DisplayLayout.Override.RowAppearance = Appearance50
        Me.griMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMaterial.Location = New System.Drawing.Point(3, 16)
        Me.griMaterial.Name = "griMaterial"
        Me.griMaterial.Size = New System.Drawing.Size(1225, 472)
        Me.griMaterial.TabIndex = 0
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Material o artículo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Material seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Material seleccionado"
        '
        'odMaterial
        '
        UltraDataColumn32.DataType = GetType(Boolean)
        UltraDataColumn49.DataType = GetType(Boolean)
        UltraDataColumn49.DefaultValue = False
        UltraDataColumn51.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cbTipoMaterial)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.cbSubFamilia)
        Me.Agrupacion1.Controls.Add(Me.cbFamilia)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1231, 55)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Filtros"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cbTipoMaterial
        '
        Appearance51.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbTipoMaterial.Appearance = Appearance51
        Me.cbTipoMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance52.Image = 7
        EditorButton2.Appearance = Appearance52
        Me.cbTipoMaterial.ButtonsRight.Add(EditorButton2)
        Me.cbTipoMaterial.DisplayMember = "Nombre"
        Me.cbTipoMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbTipoMaterial.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbTipoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoMaterial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbTipoMaterial.ImageList = Me.imagenes
        Me.cbTipoMaterial.Location = New System.Drawing.Point(41, 25)
        Me.cbTipoMaterial.Name = "cbTipoMaterial"
        Me.cbTipoMaterial.Size = New System.Drawing.Size(318, 21)
        Me.cbTipoMaterial.TabIndex = 1
        Me.cbTipoMaterial.ValueMember = "Id"
        '
        'Etiqueta5
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance53
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta5.Location = New System.Drawing.Point(6, 29)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Tipo:"
        '
        'cbSubFamilia
        '
        Appearance54.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbSubFamilia.Appearance = Appearance54
        Appearance55.Image = 7
        EditorButton3.Appearance = Appearance55
        Me.cbSubFamilia.ButtonsRight.Add(EditorButton3)
        Me.cbSubFamilia.DisplayMember = "Nombre"
        Me.cbSubFamilia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbSubFamilia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbSubFamilia.ImageList = Me.imagenes
        Me.cbSubFamilia.Location = New System.Drawing.Point(791, 25)
        Me.cbSubFamilia.Name = "cbSubFamilia"
        Me.cbSubFamilia.Size = New System.Drawing.Size(336, 21)
        Me.cbSubFamilia.TabIndex = 5
        Me.cbSubFamilia.ValueMember = "Id"
        '
        'cbFamilia
        '
        Appearance56.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbFamilia.Appearance = Appearance56
        Appearance57.Image = 7
        EditorButton4.Appearance = Appearance57
        Me.cbFamilia.ButtonsRight.Add(EditorButton4)
        Me.cbFamilia.DisplayMember = "Nombre"
        Me.cbFamilia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbFamilia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbFamilia.ImageList = Me.imagenes
        Me.cbFamilia.Location = New System.Drawing.Point(414, 25)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(303, 21)
        Me.cbFamilia.TabIndex = 3
        Me.cbFamilia.ValueMember = "Id"
        '
        'Etiqueta13
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance58
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta13.Location = New System.Drawing.Point(723, 29)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta13.TabIndex = 4
        Me.Etiqueta13.Text = "SubFamilia:"
        '
        'Etiqueta16
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance59
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta16.Location = New System.Drawing.Point(365, 29)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta16.TabIndex = 2
        Me.Etiqueta16.Text = "Familia:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.tcDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrMantenimiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1231, 546)
        '
        'tcDetalle
        '
        Me.tcDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl6)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl9)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl10)
        Me.tcDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetalle.Location = New System.Drawing.Point(0, 268)
        Me.tcDetalle.Name = "tcDetalle"
        Me.tcDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcDetalle.Size = New System.Drawing.Size(1231, 278)
        Me.tcDetalle.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl6
        UltraTab1.Text = "Almacenes"
        UltraTab2.TabPage = Me.UltraTabPageControl9
        UltraTab2.Text = "Codigos Barra"
        UltraTab3.TabPage = Me.UltraTabPageControl10
        UltraTab3.Text = "Caracteristicas"
        Me.tcDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.tcDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1229, 255)
        '
        'agrMantenimiento
        '
        Appearance60.BackColor = System.Drawing.Color.White
        Appearance60.BackColor2 = System.Drawing.Color.White
        Me.agrMantenimiento.ContentAreaAppearance = Appearance60
        Me.agrMantenimiento.Controls.Add(Me.verActivoFijo)
        Me.agrMantenimiento.Controls.Add(Me.chkContabilizable)
        Me.agrMantenimiento.Controls.Add(Me.cmbModelo)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta27)
        Me.agrMantenimiento.Controls.Add(Me.cmbMarca)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta26)
        Me.agrMantenimiento.Controls.Add(Me.btnGuardarProveedor)
        Me.agrMantenimiento.Controls.Add(Me.txtId)
        Me.agrMantenimiento.Controls.Add(Me.cboTipoMaterial)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta4)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta3)
        Me.agrMantenimiento.Controls.Add(Me.decPeso)
        Me.agrMantenimiento.Controls.Add(Me.txtMedida)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta15)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta14)
        Me.agrMantenimiento.Controls.Add(Me.txtGlosa)
        Me.agrMantenimiento.Controls.Add(Me.txtSerial)
        Me.agrMantenimiento.Controls.Add(Me.cboUnidadMedida)
        Me.agrMantenimiento.Controls.Add(Me.cboTipoUnidadMedida)
        Me.agrMantenimiento.Controls.Add(Me.cboSubFamilia)
        Me.agrMantenimiento.Controls.Add(Me.cboFamilia)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta12)
        Me.agrMantenimiento.Controls.Add(Me.verIgv)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta11)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta9)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta8)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta7)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta6)
        Me.agrMantenimiento.Controls.Add(Me.txtCodigo)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta1)
        Me.agrMantenimiento.Controls.Add(Me.verActivo)
        Me.agrMantenimiento.Controls.Add(Me.txtNombre)
        Me.agrMantenimiento.Controls.Add(Me.etiNombre)
        Me.agrMantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMantenimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.agrMantenimiento.Name = "agrMantenimiento"
        Me.agrMantenimiento.Size = New System.Drawing.Size(1231, 268)
        Me.agrMantenimiento.TabIndex = 0
        Me.agrMantenimiento.Text = "Dato"
        Me.agrMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verActivoFijo
        '
        Appearance61.FontData.BoldAsString = "True"
        Me.verActivoFijo.Appearance = Appearance61
        Me.verActivoFijo.AutoSize = True
        Me.verActivoFijo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.verActivoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivoFijo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivoFijo.Location = New System.Drawing.Point(422, 240)
        Me.verActivoFijo.Name = "verActivoFijo"
        Me.verActivoFijo.Size = New System.Drawing.Size(77, 17)
        Me.verActivoFijo.TabIndex = 23
        Me.verActivoFijo.Text = "Activo Fijo:"
        '
        'chkContabilizable
        '
        Me.chkContabilizable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkContabilizable.Location = New System.Drawing.Point(298, 241)
        Me.chkContabilizable.Name = "chkContabilizable"
        Me.chkContabilizable.Size = New System.Drawing.Size(80, 20)
        Me.chkContabilizable.TabIndex = 22
        Me.chkContabilizable.Text = "Divisible:"
        '
        'cmbModelo
        '
        Appearance62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbModelo.Appearance = Appearance62
        Me.cmbModelo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance63.Image = 7
        EditorButton5.Appearance = Appearance63
        Me.cmbModelo.ButtonsRight.Add(EditorButton5)
        Me.cmbModelo.DisplayMember = "Nombre"
        Me.cmbModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbModelo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbModelo.ImageList = Me.imagenes
        Me.cmbModelo.Location = New System.Drawing.Point(593, 76)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(272, 21)
        Me.cmbModelo.TabIndex = 27
        Me.cmbModelo.ValueMember = "Id"
        '
        'Etiqueta27
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta27.Appearance = Appearance64
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta27.Location = New System.Drawing.Point(542, 76)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta27.TabIndex = 26
        Me.Etiqueta27.Text = "Modelo:"
        '
        'cmbMarca
        '
        Appearance65.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMarca.Appearance = Appearance65
        Me.cmbMarca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance66.Image = 7
        EditorButton6.Appearance = Appearance66
        Me.cmbMarca.ButtonsRight.Add(EditorButton6)
        Me.cmbMarca.DisplayMember = "Nombre"
        Me.cmbMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMarca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMarca.ImageList = Me.imagenes
        Me.cmbMarca.Location = New System.Drawing.Point(593, 48)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(272, 21)
        Me.cmbMarca.TabIndex = 25
        Me.cmbMarca.ValueMember = "Id"
        '
        'Etiqueta26
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta26.Appearance = Appearance67
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta26.Location = New System.Drawing.Point(542, 49)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta26.TabIndex = 24
        Me.Etiqueta26.Text = "Marca:"
        '
        'btnGuardarProveedor
        '
        Appearance68.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardarProveedor.Appearance = Appearance68
        Me.btnGuardarProveedor.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarProveedor.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarProveedor.Location = New System.Drawing.Point(273, 210)
        Me.btnGuardarProveedor.Name = "btnGuardarProveedor"
        Me.btnGuardarProveedor.Size = New System.Drawing.Size(77, 25)
        Me.btnGuardarProveedor.TabIndex = 18
        Me.btnGuardarProveedor.Text = "Guardar"
        Me.btnGuardarProveedor.Visible = False
        '
        'txtId
        '
        Appearance69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Appearance = Appearance69
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtId.Location = New System.Drawing.Point(22, 31)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(28, 21)
        Me.txtId.TabIndex = 0
        Me.txtId.Tag = "0"
        Me.txtId.Visible = False
        '
        'cboTipoMaterial
        '
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoMaterial.Appearance = Appearance70
        Me.cboTipoMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance71.Image = 7
        EditorButton7.Appearance = Appearance71
        Me.cboTipoMaterial.ButtonsRight.Add(EditorButton7)
        Me.cboTipoMaterial.DisplayMember = "Nombre"
        Me.cboTipoMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoMaterial.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMaterial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoMaterial.ImageList = Me.imagenes
        Me.cboTipoMaterial.Location = New System.Drawing.Point(173, 78)
        Me.cboTipoMaterial.Name = "cboTipoMaterial"
        Me.cboTipoMaterial.Size = New System.Drawing.Size(326, 21)
        Me.cboTipoMaterial.TabIndex = 7
        Me.cboTipoMaterial.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance72
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta4.Location = New System.Drawing.Point(74, 83)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(86, 14)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Tipo de Material:"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta3.Location = New System.Drawing.Point(271, 241)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(21, 14)
        Me.Etiqueta3.TabIndex = 21
        Me.Etiqueta3.Text = "Kg."
        '
        'decPeso
        '
        Appearance73.ForeColor = System.Drawing.Color.Black
        Me.decPeso.Appearance = Appearance73
        Me.decPeso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPeso.ForeColor = System.Drawing.Color.Black
        Me.decPeso.Location = New System.Drawing.Point(174, 239)
        Me.decPeso.Name = "decPeso"
        Me.decPeso.NullText = "0.00"
        Me.decPeso.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPeso.Size = New System.Drawing.Size(90, 21)
        Me.decPeso.TabIndex = 20
        '
        'txtMedida
        '
        Appearance74.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMedida.Appearance = Appearance74
        Me.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMedida.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtMedida.Location = New System.Drawing.Point(174, 212)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(90, 21)
        Me.txtMedida.TabIndex = 17
        Me.txtMedida.Tag = "0"
        '
        'Etiqueta15
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance75
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta15.Location = New System.Drawing.Point(126, 241)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta15.TabIndex = 19
        Me.Etiqueta15.Text = "Peso:"
        '
        'Etiqueta14
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta14.Appearance = Appearance76
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta14.Location = New System.Drawing.Point(115, 214)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta14.TabIndex = 16
        Me.Etiqueta14.Text = "Medida:"
        '
        'txtGlosa
        '
        Appearance77.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance77
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(593, 132)
        Me.txtGlosa.MaxLength = 500
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(272, 103)
        Me.txtGlosa.TabIndex = 31
        Me.txtGlosa.Tag = "0"
        '
        'txtSerial
        '
        Appearance78.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerial.Appearance = Appearance78
        Me.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerial.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtSerial.Location = New System.Drawing.Point(593, 103)
        Me.txtSerial.MaxLength = 20
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(272, 21)
        Me.txtSerial.TabIndex = 29
        Me.txtSerial.Tag = "0"
        '
        'cboUnidadMedida
        '
        Appearance79.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboUnidadMedida.Appearance = Appearance79
        Me.cboUnidadMedida.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance80.Image = 7
        EditorButton8.Appearance = Appearance80
        Me.cboUnidadMedida.ButtonsRight.Add(EditorButton8)
        Me.cboUnidadMedida.DisplayMember = "Nombre"
        Me.cboUnidadMedida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUnidadMedida.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadMedida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboUnidadMedida.ImageList = Me.imagenes
        Me.cboUnidadMedida.Location = New System.Drawing.Point(175, 185)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(272, 21)
        Me.cboUnidadMedida.TabIndex = 15
        Me.cboUnidadMedida.ValueMember = "Id"
        '
        'cboTipoUnidadMedida
        '
        Appearance81.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoUnidadMedida.Appearance = Appearance81
        Me.cboTipoUnidadMedida.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance82.Image = 7
        EditorButton9.Appearance = Appearance82
        Me.cboTipoUnidadMedida.ButtonsRight.Add(EditorButton9)
        Me.cboTipoUnidadMedida.DisplayMember = "Nombre"
        Me.cboTipoUnidadMedida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoUnidadMedida.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUnidadMedida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoUnidadMedida.ImageList = Me.imagenes
        Me.cboTipoUnidadMedida.Location = New System.Drawing.Point(175, 159)
        Me.cboTipoUnidadMedida.Name = "cboTipoUnidadMedida"
        Me.cboTipoUnidadMedida.Size = New System.Drawing.Size(272, 21)
        Me.cboTipoUnidadMedida.TabIndex = 13
        Me.cboTipoUnidadMedida.ValueMember = "Id"
        '
        'cboSubFamilia
        '
        Appearance83.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboSubFamilia.Appearance = Appearance83
        Me.cboSubFamilia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance84.Image = 7
        EditorButton10.Appearance = Appearance84
        Me.cboSubFamilia.ButtonsRight.Add(EditorButton10)
        Me.cboSubFamilia.DisplayMember = "Nombre"
        Me.cboSubFamilia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboSubFamilia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboSubFamilia.ImageList = Me.imagenes
        Me.cboSubFamilia.Location = New System.Drawing.Point(174, 132)
        Me.cboSubFamilia.Name = "cboSubFamilia"
        Me.cboSubFamilia.Size = New System.Drawing.Size(325, 21)
        Me.cboSubFamilia.TabIndex = 11
        Me.cboSubFamilia.ValueMember = "Id"
        '
        'cboFamilia
        '
        Appearance85.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFamilia.Appearance = Appearance85
        Me.cboFamilia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance86.Image = 7
        EditorButton11.Appearance = Appearance86
        Me.cboFamilia.ButtonsRight.Add(EditorButton11)
        Me.cboFamilia.DisplayMember = "Nombre"
        Me.cboFamilia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFamilia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFamilia.ImageList = Me.imagenes
        Me.cboFamilia.Location = New System.Drawing.Point(174, 105)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Size = New System.Drawing.Size(325, 21)
        Me.cboFamilia.TabIndex = 9
        Me.cboFamilia.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance87
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(542, 133)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta12.TabIndex = 30
        Me.Etiqueta12.Text = "Glosa:"
        '
        'verIgv
        '
        Me.verIgv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.verIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIgv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIgv.Location = New System.Drawing.Point(947, 127)
        Me.verIgv.Name = "verIgv"
        Me.verIgv.Size = New System.Drawing.Size(100, 20)
        Me.verIgv.TabIndex = 32
        Me.verIgv.Text = "Afecto a IGV:"
        Me.verIgv.Visible = False
        '
        'Etiqueta11
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance88
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta11.Location = New System.Drawing.Point(542, 104)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta11.TabIndex = 28
        Me.Etiqueta11.Text = "Serial:"
        '
        'Etiqueta9
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance89
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta9.Location = New System.Drawing.Point(63, 187)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(96, 14)
        Me.Etiqueta9.TabIndex = 14
        Me.Etiqueta9.Text = "Unidad de Medida:"
        '
        'Etiqueta8
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance90
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta8.Location = New System.Drawing.Point(39, 161)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(120, 14)
        Me.Etiqueta8.TabIndex = 12
        Me.Etiqueta8.Text = "Tipo Unidad de Medida:"
        '
        'Etiqueta7
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance91
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta7.Location = New System.Drawing.Point(98, 133)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta7.TabIndex = 10
        Me.Etiqueta7.Text = "SubFamilia:"
        '
        'Etiqueta6
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance92
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta6.Location = New System.Drawing.Point(117, 108)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta6.TabIndex = 8
        Me.Etiqueta6.Text = "Familia:"
        '
        'txtCodigo
        '
        Appearance93.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance93
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCodigo.Location = New System.Drawing.Point(174, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Tag = "0"
        '
        'Etiqueta1
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance94
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(115, 26)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Código:"
        '
        'verActivo
        '
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(270, 25)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(120, 20)
        Me.verActivo.TabIndex = 3
        Me.verActivo.TabStop = False
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance95.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance95
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtNombre.Location = New System.Drawing.Point(173, 51)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(325, 21)
        Me.txtNombre.TabIndex = 5
        Me.txtNombre.Tag = "0"
        '
        'etiNombre
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Me.etiNombre.Appearance = Appearance96
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(115, 53)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 4
        Me.etiNombre.Text = "Nombre:"
        '
        'odMaterialCtaCtble
        '
        Me.odMaterialCtaCtble.Band.Columns.AddRange(New Object() {UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67})
        '
        'odMarca
        '
        Me.odMarca.Band.Columns.AddRange(New Object() {UltraDataColumn68, UltraDataColumn69})
        '
        'ficMaterial
        '
        Me.ficMaterial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficMaterial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMaterial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMaterial.Location = New System.Drawing.Point(0, 0)
        Me.ficMaterial.Name = "ficMaterial"
        Me.ficMaterial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficMaterial.Size = New System.Drawing.Size(1233, 569)
        Me.ficMaterial.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Mantenimiento"
        Me.ficMaterial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.ficMaterial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1231, 546)
        '
        'odMaterialFamilia
        '
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn70, UltraDataColumn71, UltraDataColumn72})
        UltraDataBand1.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn73, UltraDataColumn74, UltraDataColumn75})
        Me.odMaterialFamilia.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.odMaterialFamilia.Band.Columns.AddRange(New Object() {UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79})
        '
        'odMaterialMedida
        '
        UltraDataBand4.Columns.AddRange(New Object() {UltraDataColumn80, UltraDataColumn81, UltraDataColumn82})
        UltraDataBand3.ChildBands.AddRange(New Object() {UltraDataBand4})
        UltraDataBand3.Columns.AddRange(New Object() {UltraDataColumn83, UltraDataColumn84, UltraDataColumn85})
        Me.odMaterialMedida.Band.ChildBands.AddRange(New Object() {UltraDataBand3})
        Me.odMaterialMedida.Band.Columns.AddRange(New Object() {UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89})
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(418, 250)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 23
        Me.ugb_Espera.Visible = False
        '
        'frm_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1233, 569)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficMaterial)
        Me.Name = "frm_Material"
        Me.Text = "Material"
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.grid_Almacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.txtZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndStockMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.griListaCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtCodigoBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.griCaracteristicaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCarMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cboCaracteristicaEspecial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLista.ResumeLayout(False)
        CType(Me.griMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cbTipoMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSubFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.tcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDetalle.ResumeLayout(False)
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMantenimiento.ResumeLayout(False)
        Me.agrMantenimiento.PerformLayout()
        CType(Me.verActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkContabilizable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterialCtaCtble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMaterial.ResumeLayout(False)
        CType(Me.odMaterialFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterialMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficMaterial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMantenimiento As ISL.Controles.Agrupacion
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents txtSerial As ISL.Controles.Texto
    Friend WithEvents cboUnidadMedida As ISL.Controles.ComboMaestros
    Friend WithEvents cboTipoUnidadMedida As ISL.Controles.ComboMaestros
    Friend WithEvents cboSubFamilia As ISL.Controles.ComboMaestros
    Friend WithEvents cboFamilia As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents verIgv As ISL.Controles.Chequear

    Friend WithEvents agrLista As ISL.Controles.Agrupacion
    Friend WithEvents griMaterial As ISL.Controles.Grilla
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents odMaterialFamilia As ISL.Controles.OrigenDatos
    Friend WithEvents odMaterialMedida As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odMarca As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents txtMedida As ISL.Controles.Texto
    Friend WithEvents decPeso As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoMaterial As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cbAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents cbTipoMaterial As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cbSubFamilia As ISL.Controles.ComboMaestros
    Friend WithEvents cbFamilia As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents odMaterialCtaCtble As ISL.Controles.OrigenDatos
    Friend WithEvents txtId As ISL.Controles.Texto
    Friend WithEvents btnGuardarProveedor As ISL.Controles.Boton
    Friend WithEvents odCodigoBarras As ISL.Controles.OrigenDatos
    Friend WithEvents btnAgregarCodigo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtCodigoBarra As ISL.Controles.Texto
    Friend WithEvents btnQuitarCodigo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griListaCodBarras As ISL.Controles.Grilla
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents btnQuitCarac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgrCar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboCaracteristicaEspecial As ISL.Controles.ComboMaestros
    Friend WithEvents griCaracteristicaMaterial As ISL.Controles.Grilla
    Friend WithEvents odCarMat As ISL.Controles.OrigenDatos
    Friend WithEvents tcDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents btnAgregarAlmacen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents grid_Almacenes As ISL.Controles.Grilla
    Friend WithEvents odAlmacenes As ISL.Controles.OrigenDatos
    Friend WithEvents ndStockMinimo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents ndStockMaximo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents txtZona As ISL.Controles.Texto
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents cmbModelo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents cmbMarca As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents chkContabilizable As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents verActivoFijo As ISL.Controles.Chequear
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
