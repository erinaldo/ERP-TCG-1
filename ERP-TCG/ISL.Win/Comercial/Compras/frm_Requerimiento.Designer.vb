<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Requerimiento
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
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimiento")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPorAtender")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Requerimiento))
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Aprobacion")
        Dim UltraGridColumn445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimientoMaterial")
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAAtender")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimientoMaterial")
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim UltraGridColumn452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRegularizado")
        Dim UltraGridColumn453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPorRegularizar")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadARegularizar")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtencion")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimiento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPorAtender")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Aprobacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimientoMaterial")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAAtender")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimientoMaterial")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndRegularizado")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPorRegularizar")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadARegularizar")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtencion")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
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
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CategoriaServicio")
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CategoriaServicio")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimiento")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoServicio")
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Asignado")
        Dim UltraGridColumn512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaServicio")
        Dim UltraGridColumn513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimientoServicio")
        Dim UltraGridColumn515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimientoServicio")
        Dim UltraGridColumn516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Aprobacion")
        Dim UltraGridColumn518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOT")
        Dim UltraGridColumn521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEquipo")
        Dim UltraGridColumn522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimiento")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoServicio")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Asignado")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaServicio")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimientoServicio")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimientoServicio")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Aprobacion")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOT")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEquipo")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimiento")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetalleRequerimiento")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPorAtender")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAAtender")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimientoMaterial")
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimientoMaterial")
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSancion")
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Especificaciones")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Especificaciones")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimiento")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDetalleRequerimiento")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPorAtender")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAAtender")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimientoMaterial")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimientoMaterial")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSancion")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim UltraGridColumn526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMovimiento")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Salida")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotal")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("id")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtencion")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimiento")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimiento")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaAtencion")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioAtencion")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OpcionFecha")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinal")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("id")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtencion")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimiento")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimiento")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaAtencion")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioAtencion")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OpcionFecha")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinal")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool4")
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrMaterialesRequeridos = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaMaterialRequeridos = New ISL.Controles.Grilla(Me.components)
        Me.odRequerimientoMateriales = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agrMateriales = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaMateriales = New ISL.Controles.Grilla(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListarMateriales = New ISL.Controles.Boton(Me.components)
        Me.txtBuscarMateriales = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrServiciosRequeridos = New ISL.Controles.Agrupacion(Me.components)
        Me.gbeServicios = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agrServicio = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaServicio = New ISL.Controles.Grilla(Me.components)
        Me.odServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCategoria = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCategoriaServicios = New ISL.Controles.ComboMaestros(Me.components)
        Me.griListaServiciosRequeridos = New ISL.Controles.Grilla(Me.components)
        Me.odRequerimientoServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.grilla_OA_Material = New ISL.Controles.Grilla(Me.components)
        Me.odOAReqMat = New ISL.Controles.OrigenDatos(Me.components)
        Me.uebHistorialMaterial = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grReg_Inv = New ISL.Controles.Grilla(Me.components)
        Me.odRegistroInventario = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrRequerimientos = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaRequerimientos = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odRequerimientos = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.btnTerminarRQ = New ISL.Controles.Boton(Me.components)
        Me.btnActualizaOT = New ISL.Controles.Boton(Me.components)
        Me.btnRegReq = New ISL.Controles.Boton(Me.components)
        Me.btnAtenderReq = New ISL.Controles.Boton(Me.components)
        Me.btnEvaluarReq = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboCentro = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.rangoFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.rangoFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresAtendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAtendidoParcialmente = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEvaluado = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFormaBusqueda = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboAreaL = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboRequerimiento = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbArea = New ISL.Controles.Chequear(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.cmEquipo = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnActualizarDetalle = New ISL.Controles.Boton(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtMaterial = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoBarras = New ISL.Controles.Texto(Me.components)
        Me.fecAtencion = New System.Windows.Forms.DateTimePicker()
        Me.fecFecha = New System.Windows.Forms.DateTimePicker()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorAtendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorPendiente = New ISL.Controles.Colores(Me.components)
        Me.colorAtendidoParcial = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresPorRegularizar = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresGeneradaDetalle = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresRechazado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAprobado = New ISL.Controles.Colores(Me.components)
        Me.ColoresPreaprobado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtArea = New ISL.Controles.Texto(Me.components)
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.agrDetalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.tcDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuCotizacionProveedor = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ficRequerimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.agrMaterialesRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMaterialesRequeridos.SuspendLayout()
        CType(Me.griListaMaterialRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odRequerimientoMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.agrMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMateriales.SuspendLayout()
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.agrServiciosRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrServiciosRequeridos.SuspendLayout()
        CType(Me.gbeServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeServicios.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.agrServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrServicio.SuspendLayout()
        CType(Me.griListaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.cboCategoriaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griListaServiciosRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odRequerimientoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion10.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.grilla_OA_Material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOAReqMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uebHistorialMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uebHistorialMaterial.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odRegistroInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrRequerimientos.SuspendLayout()
        CType(Me.griListaRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cmEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAtendidoParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.ColoresPorRegularizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGeneradaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresRechazado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAprobado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresPreaprobado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuCotizacionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficRequerimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.agrMaterialesRequeridos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1237, 307)
        '
        'agrMaterialesRequeridos
        '
        Me.agrMaterialesRequeridos.Controls.Add(Me.griListaMaterialRequeridos)
        Me.agrMaterialesRequeridos.Controls.Add(Me.gbeMateriales)
        Me.agrMaterialesRequeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMaterialesRequeridos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMaterialesRequeridos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMaterialesRequeridos.Location = New System.Drawing.Point(0, 0)
        Me.agrMaterialesRequeridos.Name = "agrMaterialesRequeridos"
        Me.agrMaterialesRequeridos.Size = New System.Drawing.Size(1237, 307)
        Me.agrMaterialesRequeridos.TabIndex = 0
        Me.agrMaterialesRequeridos.Text = "Materiales requeridos : 0"
        Me.agrMaterialesRequeridos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaMaterialRequeridos
        '
        Me.griListaMaterialRequeridos.DataSource = Me.odRequerimientoMateriales
        UltraGridColumn419.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn419.Header.Appearance = Appearance1
        UltraGridColumn419.Header.Caption = "Seleccionar"
        UltraGridColumn419.Header.VisiblePosition = 0
        UltraGridColumn419.Hidden = True
        UltraGridColumn419.Width = 36
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn420.Header.Appearance = Appearance2
        UltraGridColumn420.Header.VisiblePosition = 1
        UltraGridColumn420.Hidden = True
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn421.Header.Appearance = Appearance3
        UltraGridColumn421.Header.VisiblePosition = 2
        UltraGridColumn421.Hidden = True
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn422.Header.Appearance = Appearance4
        UltraGridColumn422.Header.VisiblePosition = 5
        UltraGridColumn422.Width = 249
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn423.Header.Appearance = Appearance5
        UltraGridColumn423.Header.VisiblePosition = 6
        UltraGridColumn423.Hidden = True
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn424.Header.Appearance = Appearance6
        UltraGridColumn424.Header.VisiblePosition = 8
        UltraGridColumn424.Width = 66
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn425.Header.Appearance = Appearance7
        UltraGridColumn425.Header.VisiblePosition = 13
        UltraGridColumn425.Width = 135
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn426.Header.Appearance = Appearance8
        UltraGridColumn426.Header.VisiblePosition = 21
        UltraGridColumn426.Hidden = True
        UltraGridColumn426.Width = 174
        UltraGridColumn427.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn427.CellAppearance = Appearance9
        UltraGridColumn427.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn427.Format = "#,##0.0000"
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn427.Header.Appearance = Appearance10
        UltraGridColumn427.Header.Caption = "Stock"
        UltraGridColumn427.Header.VisiblePosition = 15
        UltraGridColumn427.Width = 58
        UltraGridColumn428.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn428.Header.Appearance = Appearance11
        UltraGridColumn428.Header.VisiblePosition = 19
        UltraGridColumn428.Hidden = True
        UltraGridColumn428.Width = 58
        UltraGridColumn429.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn429.CellAppearance = Appearance12
        UltraGridColumn429.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn429.Format = "#,##0.0000"
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn429.Header.Appearance = Appearance13
        UltraGridColumn429.Header.VisiblePosition = 7
        UltraGridColumn429.MaskInput = "{double:9.4}"
        UltraGridColumn429.Width = 71
        UltraGridColumn430.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn430.CellAppearance = Appearance14
        UltraGridColumn430.Format = "#,##0.0000"
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn430.Header.Appearance = Appearance15
        UltraGridColumn430.Header.VisiblePosition = 22
        UltraGridColumn430.Hidden = True
        UltraGridColumn430.MaskInput = "{double:9.4}"
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance16.Image = Global.ISL.Win.My.Resources.Resources.Editar
        UltraGridColumn431.CellAppearance = Appearance16
        Appearance17.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        UltraGridColumn431.CellButtonAppearance = Appearance17
        UltraGridColumn431.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn431.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn431.Header.Appearance = Appearance18
        UltraGridColumn431.Header.VisiblePosition = 23
        UltraGridColumn431.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn431.Width = 152
        Appearance19.TextHAlignAsString = "Center"
        UltraGridColumn432.Header.Appearance = Appearance19
        UltraGridColumn432.Header.VisiblePosition = 25
        UltraGridColumn432.Hidden = True
        Appearance20.TextHAlignAsString = "Center"
        UltraGridColumn433.Header.Appearance = Appearance20
        UltraGridColumn433.Header.VisiblePosition = 24
        UltraGridColumn433.Hidden = True
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn434.Header.Appearance = Appearance21
        UltraGridColumn434.Header.VisiblePosition = 26
        UltraGridColumn434.Hidden = True
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn435.Header.Appearance = Appearance22
        UltraGridColumn435.Header.VisiblePosition = 27
        UltraGridColumn435.Hidden = True
        UltraGridColumn436.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn436.CellAppearance = Appearance23
        Appearance24.Image = CType(resources.GetObject("Appearance24.Image"), Object)
        UltraGridColumn436.CellButtonAppearance = Appearance24
        UltraGridColumn436.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn436.Format = "#,##0.0000"
        Appearance25.TextHAlignAsString = "Center"
        UltraGridColumn436.Header.Appearance = Appearance25
        UltraGridColumn436.Header.Caption = "Por atender"
        UltraGridColumn436.Header.VisiblePosition = 9
        UltraGridColumn436.MaskInput = ""
        UltraGridColumn436.ShowInkButton = Infragistics.Win.ShowInkButton.Always
        UltraGridColumn436.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn436.Width = 65
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn437.Header.Appearance = Appearance26
        UltraGridColumn437.Header.VisiblePosition = 28
        UltraGridColumn437.Hidden = True
        UltraGridColumn437.Width = 104
        UltraGridColumn438.Header.VisiblePosition = 29
        UltraGridColumn438.Hidden = True
        UltraGridColumn439.Header.VisiblePosition = 30
        UltraGridColumn439.Hidden = True
        Appearance27.TextHAlignAsString = "Center"
        UltraGridColumn440.Header.Appearance = Appearance27
        UltraGridColumn440.Header.Caption = "Codigo"
        UltraGridColumn440.Header.VisiblePosition = 4
        UltraGridColumn440.Width = 59
        UltraGridColumn441.Header.VisiblePosition = 31
        UltraGridColumn441.Hidden = True
        UltraGridColumn442.Header.VisiblePosition = 32
        UltraGridColumn442.Hidden = True
        UltraGridColumn443.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn443.Header.Caption = "Aprobar"
        UltraGridColumn443.Header.VisiblePosition = 17
        UltraGridColumn443.Hidden = True
        UltraGridColumn444.Header.VisiblePosition = 33
        UltraGridColumn444.Hidden = True
        UltraGridColumn445.Header.Caption = "Estado"
        UltraGridColumn445.Header.VisiblePosition = 20
        UltraGridColumn445.Width = 73
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn446.CellAppearance = Appearance28
        UltraGridColumn446.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn446.Format = "#,##0.0000"
        UltraGridColumn446.Header.Caption = "Atender"
        UltraGridColumn446.Header.VisiblePosition = 12
        UltraGridColumn446.MaskInput = ""
        UltraGridColumn446.Width = 59
        UltraGridColumn447.Header.VisiblePosition = 34
        UltraGridColumn447.Hidden = True
        UltraGridColumn448.Header.VisiblePosition = 35
        UltraGridColumn448.Hidden = True
        UltraGridColumn449.Header.Caption = "Sub Almacén"
        UltraGridColumn449.Header.VisiblePosition = 14
        UltraGridColumn449.Width = 125
        UltraGridColumn450.Header.VisiblePosition = 36
        UltraGridColumn450.Hidden = True
        UltraGridColumn451.Header.VisiblePosition = 3
        UltraGridColumn451.Width = 118
        UltraGridColumn452.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn452.Header.Caption = "Regularizado"
        UltraGridColumn452.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn452.Header.VisiblePosition = 16
        UltraGridColumn452.Width = 65
        UltraGridColumn453.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn453.CellAppearance = Appearance29
        Appearance30.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        UltraGridColumn453.CellButtonAppearance = Appearance30
        UltraGridColumn453.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn453.Format = "#,##0.0000"
        UltraGridColumn453.Header.Caption = "Por Regularizar"
        UltraGridColumn453.Header.VisiblePosition = 10
        UltraGridColumn453.MaskInput = "{double:9.4}"
        UltraGridColumn453.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn453.Width = 78
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn454.CellAppearance = Appearance31
        UltraGridColumn454.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn454.Format = "#,##0.0000"
        UltraGridColumn454.Header.Caption = "Regularizar"
        UltraGridColumn454.Header.VisiblePosition = 11
        UltraGridColumn454.Width = 60
        UltraGridColumn455.Header.VisiblePosition = 37
        UltraGridColumn455.Hidden = True
        UltraGridColumn456.Header.VisiblePosition = 18
        UltraGridColumn457.Header.VisiblePosition = 38
        UltraGridColumn457.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn419, UltraGridColumn420, UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427, UltraGridColumn428, UltraGridColumn429, UltraGridColumn430, UltraGridColumn431, UltraGridColumn432, UltraGridColumn433, UltraGridColumn434, UltraGridColumn435, UltraGridColumn436, UltraGridColumn437, UltraGridColumn438, UltraGridColumn439, UltraGridColumn440, UltraGridColumn441, UltraGridColumn442, UltraGridColumn443, UltraGridColumn444, UltraGridColumn445, UltraGridColumn446, UltraGridColumn447, UltraGridColumn448, UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn452, UltraGridColumn453, UltraGridColumn454, UltraGridColumn455, UltraGridColumn456, UltraGridColumn457})
        Me.griListaMaterialRequeridos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaMaterialRequeridos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMaterialRequeridos.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMaterialRequeridos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.griListaMaterialRequeridos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMaterialRequeridos.DisplayLayout.GroupByBox.Hidden = True
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMaterialRequeridos.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.griListaMaterialRequeridos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaMaterialRequeridos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaMaterialRequeridos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaMaterialRequeridos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaMaterialRequeridos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaMaterialRequeridos.DisplayLayout.Override.CellPadding = 0
        Me.griListaMaterialRequeridos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaMaterialRequeridos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaMaterialRequeridos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaMaterialRequeridos.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.griListaMaterialRequeridos.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.griListaMaterialRequeridos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaMaterialRequeridos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Me.griListaMaterialRequeridos.DisplayLayout.Override.RowAppearance = Appearance37
        Me.griListaMaterialRequeridos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaMaterialRequeridos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaMaterialRequeridos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaMaterialRequeridos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaMaterialRequeridos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaMaterialRequeridos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaMaterialRequeridos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaMaterialRequeridos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaMaterialRequeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaMaterialRequeridos.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaMaterialRequeridos.ImageList = Me.imagenes
        Me.griListaMaterialRequeridos.Location = New System.Drawing.Point(3, 17)
        Me.griListaMaterialRequeridos.Name = "griListaMaterialRequeridos"
        Me.griListaMaterialRequeridos.Size = New System.Drawing.Size(1209, 287)
        Me.griListaMaterialRequeridos.TabIndex = 0
        Me.griListaMaterialRequeridos.Text = "Grilla2"
        '
        'odRequerimientoMateriales
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn25.DataType = GetType(Boolean)
        UltraDataColumn25.DefaultValue = True
        UltraDataColumn34.DataType = GetType(Boolean)
        UltraDataColumn35.DataType = GetType(Double)
        UltraDataColumn36.DataType = GetType(Double)
        Me.odRequerimientoMateriales.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
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
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.Expanded = False
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(658, 287)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(1212, 17)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(22, 287)
        Me.gbeMateriales.TabIndex = 1
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.gbeMateriales.Visible = False
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.agrMateriales)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion6)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(638, 197)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'agrMateriales
        '
        Me.agrMateriales.Controls.Add(Me.griListaMateriales)
        Me.agrMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMateriales.ForeColor = System.Drawing.Color.Black
        Me.agrMateriales.Location = New System.Drawing.Point(0, 62)
        Me.agrMateriales.Name = "agrMateriales"
        Me.agrMateriales.Size = New System.Drawing.Size(638, 135)
        Me.agrMateriales.TabIndex = 247
        Me.agrMateriales.Text = "Materiales:"
        Me.agrMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaMateriales
        '
        Me.griListaMateriales.DataSource = Me.odMaterial
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Appearance38.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaMateriales.DisplayLayout.Appearance = Appearance38
        UltraGridColumn458.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance39.TextHAlignAsString = "Center"
        UltraGridColumn458.Header.Appearance = Appearance39
        UltraGridColumn458.Header.VisiblePosition = 0
        UltraGridColumn458.Width = 27
        Appearance40.TextHAlignAsString = "Center"
        UltraGridColumn459.Header.Appearance = Appearance40
        UltraGridColumn459.Header.VisiblePosition = 1
        UltraGridColumn459.Hidden = True
        UltraGridColumn460.Header.VisiblePosition = 9
        UltraGridColumn460.Hidden = True
        UltraGridColumn461.Header.Caption = ":"
        UltraGridColumn461.Header.VisiblePosition = 3
        UltraGridColumn461.Width = 316
        UltraGridColumn462.Header.Caption = "Unid. Med."
        UltraGridColumn462.Header.VisiblePosition = 17
        UltraGridColumn462.Width = 114
        UltraGridColumn463.Header.VisiblePosition = 25
        UltraGridColumn463.Hidden = True
        UltraGridColumn464.Header.VisiblePosition = 4
        UltraGridColumn464.Width = 254
        UltraGridColumn465.Header.VisiblePosition = 6
        UltraGridColumn465.Hidden = True
        UltraGridColumn466.Header.VisiblePosition = 7
        UltraGridColumn466.Hidden = True
        UltraGridColumn467.Header.VisiblePosition = 8
        UltraGridColumn467.Hidden = True
        UltraGridColumn468.Header.VisiblePosition = 10
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.Header.VisiblePosition = 11
        UltraGridColumn469.Hidden = True
        UltraGridColumn470.Header.VisiblePosition = 12
        UltraGridColumn470.Hidden = True
        UltraGridColumn471.Header.VisiblePosition = 13
        UltraGridColumn471.Hidden = True
        UltraGridColumn472.Header.VisiblePosition = 14
        UltraGridColumn472.Hidden = True
        UltraGridColumn473.Header.VisiblePosition = 15
        UltraGridColumn473.Hidden = True
        UltraGridColumn474.Header.VisiblePosition = 18
        UltraGridColumn474.Hidden = True
        UltraGridColumn475.Header.VisiblePosition = 21
        UltraGridColumn475.Hidden = True
        UltraGridColumn476.Header.VisiblePosition = 22
        UltraGridColumn476.Hidden = True
        UltraGridColumn477.Header.VisiblePosition = 23
        UltraGridColumn477.Hidden = True
        UltraGridColumn478.Header.VisiblePosition = 24
        UltraGridColumn478.Hidden = True
        Appearance41.TextHAlignAsString = "Center"
        UltraGridColumn479.Header.Appearance = Appearance41
        UltraGridColumn479.Header.VisiblePosition = 5
        UltraGridColumn479.Hidden = True
        UltraGridColumn480.Header.VisiblePosition = 19
        UltraGridColumn480.Hidden = True
        UltraGridColumn481.Header.VisiblePosition = 16
        UltraGridColumn482.Header.Caption = "Costo"
        UltraGridColumn482.Header.VisiblePosition = 20
        UltraGridColumn483.Header.VisiblePosition = 2
        UltraGridColumn483.Hidden = True
        UltraGridColumn484.Header.VisiblePosition = 26
        UltraGridColumn484.Hidden = True
        UltraGridColumn485.Header.VisiblePosition = 27
        UltraGridColumn485.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485})
        Me.griListaMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaMateriales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance42.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance42.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance42.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.GroupByBox.Appearance = Appearance42
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance43
        Me.griListaMateriales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.GroupByBox.Hidden = True
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance44.BackColor2 = System.Drawing.SystemColors.Control
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.PromptAppearance = Appearance44
        Me.griListaMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaMateriales.DisplayLayout.MaxRowScrollRegions = 1
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaMateriales.DisplayLayout.Override.ActiveCellAppearance = Appearance45
        Appearance46.BackColor = System.Drawing.SystemColors.Highlight
        Appearance46.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaMateriales.DisplayLayout.Override.ActiveRowAppearance = Appearance46
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.CardAreaAppearance = Appearance47
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Appearance48.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaMateriales.DisplayLayout.Override.CellAppearance = Appearance48
        Me.griListaMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griListaMateriales.DisplayLayout.Override.CellPadding = 0
        Appearance49.BackColor = System.Drawing.SystemColors.Control
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.GroupByRowAppearance = Appearance49
        Appearance50.TextHAlignAsString = "Center"
        Me.griListaMateriales.DisplayLayout.Override.HeaderAppearance = Appearance50
        Me.griListaMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaMateriales.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance51.BackColor = System.Drawing.SystemColors.Window
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Me.griListaMateriales.DisplayLayout.Override.RowAppearance = Appearance51
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaMateriales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaMateriales.DisplayLayout.Override.TemplateAddRowAppearance = Appearance52
        Me.griListaMateriales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaMateriales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaMateriales.Location = New System.Drawing.Point(2, 18)
        Me.griListaMateriales.Name = "griListaMateriales"
        Me.griListaMateriales.Size = New System.Drawing.Size(634, 115)
        Me.griListaMateriales.TabIndex = 9
        Me.griListaMateriales.Text = "Grilla2"
        '
        'odMaterial
        '
        UltraDataColumn40.DataType = GetType(Boolean)
        UltraDataColumn59.DefaultValue = "False"
        UltraDataColumn61.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67})
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.btnListarMateriales)
        Me.Agrupacion6.Controls.Add(Me.txtBuscarMateriales)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(638, 62)
        Me.Agrupacion6.TabIndex = 4
        Me.Agrupacion6.Text = "Agregar materiales:"
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnListarMateriales
        '
        Appearance53.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMateriales.Appearance = Appearance53
        Me.btnListarMateriales.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMateriales.ImageList = Me.imagenes
        Me.btnListarMateriales.Location = New System.Drawing.Point(396, 25)
        Me.btnListarMateriales.Name = "btnListarMateriales"
        Me.btnListarMateriales.Size = New System.Drawing.Size(30, 28)
        Me.btnListarMateriales.TabIndex = 235
        '
        'txtBuscarMateriales
        '
        Appearance54.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Appearance = Appearance54
        Me.txtBuscarMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBuscarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Location = New System.Drawing.Point(66, 29)
        Me.txtBuscarMateriales.MaxLength = 200
        Me.txtBuscarMateriales.Name = "txtBuscarMateriales"
        Me.txtBuscarMateriales.Size = New System.Drawing.Size(323, 21)
        Me.txtBuscarMateriales.TabIndex = 232
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(19, 33)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta6.TabIndex = 228
        Me.Etiqueta6.Text = "Buscar:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.agrServiciosRequeridos)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1237, 307)
        '
        'agrServiciosRequeridos
        '
        Me.agrServiciosRequeridos.Controls.Add(Me.gbeServicios)
        Me.agrServiciosRequeridos.Controls.Add(Me.griListaServiciosRequeridos)
        Me.agrServiciosRequeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrServiciosRequeridos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrServiciosRequeridos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrServiciosRequeridos.Location = New System.Drawing.Point(0, 0)
        Me.agrServiciosRequeridos.Name = "agrServiciosRequeridos"
        Me.agrServiciosRequeridos.Size = New System.Drawing.Size(1237, 307)
        Me.agrServiciosRequeridos.TabIndex = 0
        Me.agrServiciosRequeridos.Text = "Servicios requeridos : 0"
        Me.agrServiciosRequeridos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbeServicios
        '
        Me.gbeServicios.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeServicios.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.gbeServicios.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeServicios.Expanded = False
        Me.gbeServicios.ExpandedSize = New System.Drawing.Size(666, 287)
        Me.gbeServicios.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeServicios.Location = New System.Drawing.Point(1212, 17)
        Me.gbeServicios.Name = "gbeServicios"
        Me.gbeServicios.Size = New System.Drawing.Size(22, 287)
        Me.gbeServicios.TabIndex = 1
        Me.gbeServicios.Text = "Servicios"
        Me.gbeServicios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.agrServicio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion7)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(643, 263)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'agrServicio
        '
        Me.agrServicio.Controls.Add(Me.griListaServicio)
        Me.agrServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrServicio.ForeColor = System.Drawing.Color.Black
        Me.agrServicio.Location = New System.Drawing.Point(0, 62)
        Me.agrServicio.Name = "agrServicio"
        Me.agrServicio.Size = New System.Drawing.Size(643, 201)
        Me.agrServicio.TabIndex = 1
        Me.agrServicio.Text = "Servicios:"
        Me.agrServicio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaServicio
        '
        Me.griListaServicio.DataSource = Me.odServicio
        UltraGridColumn486.Header.VisiblePosition = 0
        UltraGridColumn486.Hidden = True
        Appearance55.TextHAlignAsString = "Center"
        UltraGridColumn487.Header.Appearance = Appearance55
        UltraGridColumn487.Header.VisiblePosition = 2
        UltraGridColumn487.Width = 83
        UltraGridColumn488.Header.VisiblePosition = 3
        UltraGridColumn488.Hidden = True
        UltraGridColumn489.Header.Caption = "Categoria"
        UltraGridColumn489.Header.VisiblePosition = 5
        UltraGridColumn489.Width = 136
        UltraGridColumn490.Header.VisiblePosition = 4
        UltraGridColumn490.Width = 471
        UltraGridColumn491.Header.VisiblePosition = 6
        UltraGridColumn491.Width = 71
        UltraGridColumn492.Header.VisiblePosition = 7
        UltraGridColumn492.Width = 117
        UltraGridColumn493.Header.VisiblePosition = 9
        UltraGridColumn493.Hidden = True
        Appearance56.TextHAlignAsString = "Center"
        UltraGridColumn494.Header.Appearance = Appearance56
        UltraGridColumn494.Header.VisiblePosition = 8
        UltraGridColumn495.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn495.Header.Caption = "Seleccionar"
        UltraGridColumn495.Header.VisiblePosition = 1
        UltraGridColumn495.Hidden = True
        UltraGridColumn495.Width = 38
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495})
        Me.griListaServicio.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaServicio.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServicio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance57.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaServicio.DisplayLayout.GroupByBox.Appearance = Appearance57
        Appearance58.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServicio.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance58
        Me.griListaServicio.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServicio.DisplayLayout.GroupByBox.Hidden = True
        Appearance59.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance59.BackColor2 = System.Drawing.SystemColors.Control
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance59.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServicio.DisplayLayout.GroupByBox.PromptAppearance = Appearance59
        Me.griListaServicio.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaServicio.DisplayLayout.MaxRowScrollRegions = 1
        Appearance60.BackColor = System.Drawing.SystemColors.Window
        Appearance60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaServicio.DisplayLayout.Override.ActiveCellAppearance = Appearance60
        Appearance61.BackColor = System.Drawing.SystemColors.Highlight
        Appearance61.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaServicio.DisplayLayout.Override.ActiveRowAppearance = Appearance61
        Me.griListaServicio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServicio.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServicio.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance62.BackColor = System.Drawing.SystemColors.Window
        Me.griListaServicio.DisplayLayout.Override.CardAreaAppearance = Appearance62
        Appearance63.BorderColor = System.Drawing.Color.Silver
        Appearance63.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaServicio.DisplayLayout.Override.CellAppearance = Appearance63
        Me.griListaServicio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaServicio.DisplayLayout.Override.CellPadding = 0
        Me.griListaServicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaServicio.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaServicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance64.BackColor = System.Drawing.SystemColors.Control
        Appearance64.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance64.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance64.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaServicio.DisplayLayout.Override.GroupByRowAppearance = Appearance64
        Appearance65.TextHAlignAsString = "Left"
        Me.griListaServicio.DisplayLayout.Override.HeaderAppearance = Appearance65
        Me.griListaServicio.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaServicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance66.BackColor = System.Drawing.SystemColors.Window
        Appearance66.BorderColor = System.Drawing.Color.Silver
        Me.griListaServicio.DisplayLayout.Override.RowAppearance = Appearance66
        Me.griListaServicio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaServicio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaServicio.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance67.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaServicio.DisplayLayout.Override.TemplateAddRowAppearance = Appearance67
        Me.griListaServicio.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaServicio.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaServicio.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaServicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaServicio.Location = New System.Drawing.Point(3, 16)
        Me.griListaServicio.Name = "griListaServicio"
        Me.griListaServicio.Size = New System.Drawing.Size(637, 182)
        Me.griListaServicio.TabIndex = 0
        Me.griListaServicio.Text = "Grilla1"
        '
        'odServicio
        '
        UltraDataColumn76.DataType = GetType(Boolean)
        UltraDataColumn77.DataType = GetType(Boolean)
        UltraDataColumn77.DefaultValue = False
        Me.odServicio.Band.Columns.AddRange(New Object() {UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77})
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.btnCategoria)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion7.Controls.Add(Me.cboCategoriaServicios)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(643, 62)
        Me.Agrupacion7.TabIndex = 0
        Me.Agrupacion7.Text = "Agregar servicios:"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCategoria
        '
        Appearance68.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnCategoria.Appearance = Appearance68
        Me.btnCategoria.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCategoria.ImageList = Me.imagenes
        Me.btnCategoria.Location = New System.Drawing.Point(423, 21)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(30, 32)
        Me.btnCategoria.TabIndex = 2
        '
        'Etiqueta8
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance69
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(25, 31)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta8.TabIndex = 0
        Me.Etiqueta8.Text = "Categoria:"
        '
        'cboCategoriaServicios
        '
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCategoriaServicios.Appearance = Appearance70
        Me.cboCategoriaServicios.DisplayMember = "Nombre"
        Me.cboCategoriaServicios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCategoriaServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoriaServicios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCategoriaServicios.Location = New System.Drawing.Point(85, 29)
        Me.cboCategoriaServicios.Name = "cboCategoriaServicios"
        Me.cboCategoriaServicios.Size = New System.Drawing.Size(332, 21)
        Me.cboCategoriaServicios.TabIndex = 1
        Me.cboCategoriaServicios.ValueMember = "Id"
        '
        'griListaServiciosRequeridos
        '
        Me.griListaServiciosRequeridos.DataSource = Me.odRequerimientoServicio
        UltraGridColumn496.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance71.TextHAlignAsString = "Center"
        UltraGridColumn496.Header.Appearance = Appearance71
        UltraGridColumn496.Header.Caption = "Seleccionar"
        UltraGridColumn496.Header.VisiblePosition = 0
        UltraGridColumn496.Width = 40
        Appearance72.TextHAlignAsString = "Center"
        UltraGridColumn497.Header.Appearance = Appearance72
        UltraGridColumn497.Header.VisiblePosition = 1
        UltraGridColumn497.Hidden = True
        UltraGridColumn498.Header.VisiblePosition = 2
        UltraGridColumn498.Hidden = True
        UltraGridColumn499.Header.VisiblePosition = 4
        UltraGridColumn499.Width = 341
        Appearance73.TextHAlignAsString = "Center"
        UltraGridColumn500.Header.Appearance = Appearance73
        UltraGridColumn500.Header.Caption = "Centro de costo"
        UltraGridColumn500.Header.VisiblePosition = 7
        UltraGridColumn500.Hidden = True
        UltraGridColumn500.Width = 251
        UltraGridColumn501.Header.VisiblePosition = 13
        UltraGridColumn501.Hidden = True
        Appearance74.BackColor = System.Drawing.Color.White
        Appearance74.TextHAlignAsString = "Right"
        UltraGridColumn502.CellAppearance = Appearance74
        UltraGridColumn502.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn502.Header.Appearance = Appearance75
        UltraGridColumn502.Header.VisiblePosition = 5
        UltraGridColumn502.MaskInput = "{double:9.4}"
        UltraGridColumn502.Width = 59
        Appearance76.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance76.TextHAlignAsString = "Right"
        UltraGridColumn503.CellAppearance = Appearance76
        UltraGridColumn503.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance77.TextHAlignAsString = "Center"
        UltraGridColumn503.Header.Appearance = Appearance77
        UltraGridColumn503.Header.VisiblePosition = 6
        UltraGridColumn503.Hidden = True
        UltraGridColumn503.MaskInput = "{double:9.4}"
        Appearance78.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn504.CellAppearance = Appearance78
        UltraGridColumn504.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn504.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance79.TextHAlignAsString = "Center"
        UltraGridColumn504.Header.Appearance = Appearance79
        UltraGridColumn504.Header.VisiblePosition = 8
        UltraGridColumn504.Width = 224
        Appearance80.TextHAlignAsString = "Center"
        UltraGridColumn505.Header.Appearance = Appearance80
        UltraGridColumn505.Header.VisiblePosition = 10
        UltraGridColumn505.Hidden = True
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn506.Header.Appearance = Appearance81
        UltraGridColumn506.Header.VisiblePosition = 12
        UltraGridColumn506.Hidden = True
        UltraGridColumn507.Header.VisiblePosition = 14
        UltraGridColumn507.Hidden = True
        UltraGridColumn508.Header.Caption = "Codigo"
        UltraGridColumn508.Header.VisiblePosition = 3
        Appearance82.TextHAlignAsString = "Center"
        UltraGridColumn509.Header.Appearance = Appearance82
        UltraGridColumn509.Header.VisiblePosition = 9
        UltraGridColumn509.Hidden = True
        Appearance83.TextHAlignAsString = "Center"
        UltraGridColumn510.Header.Appearance = Appearance83
        UltraGridColumn510.Header.VisiblePosition = 11
        UltraGridColumn510.Hidden = True
        UltraGridColumn511.Header.VisiblePosition = 15
        UltraGridColumn511.Hidden = True
        UltraGridColumn512.Header.VisiblePosition = 16
        UltraGridColumn512.Hidden = True
        UltraGridColumn513.Header.VisiblePosition = 17
        UltraGridColumn513.Hidden = True
        UltraGridColumn514.Header.VisiblePosition = 19
        UltraGridColumn514.Hidden = True
        UltraGridColumn515.Header.Caption = "Estado"
        UltraGridColumn515.Header.VisiblePosition = 18
        UltraGridColumn516.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn516.Header.Caption = "Aprobar"
        UltraGridColumn516.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn516.Header.VisiblePosition = 20
        UltraGridColumn517.Header.VisiblePosition = 21
        UltraGridColumn517.Hidden = True
        UltraGridColumn518.Header.VisiblePosition = 22
        UltraGridColumn518.Hidden = True
        UltraGridColumn519.Header.VisiblePosition = 23
        UltraGridColumn519.Hidden = True
        UltraGridColumn520.Header.VisiblePosition = 24
        UltraGridColumn520.Hidden = True
        UltraGridColumn521.Header.VisiblePosition = 25
        UltraGridColumn521.Hidden = True
        UltraGridColumn522.Header.VisiblePosition = 26
        UltraGridColumn522.Hidden = True
        UltraGridColumn523.Header.VisiblePosition = 27
        UltraGridColumn523.Width = 180
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504, UltraGridColumn505, UltraGridColumn506, UltraGridColumn507, UltraGridColumn508, UltraGridColumn509, UltraGridColumn510, UltraGridColumn511, UltraGridColumn512, UltraGridColumn513, UltraGridColumn514, UltraGridColumn515, UltraGridColumn516, UltraGridColumn517, UltraGridColumn518, UltraGridColumn519, UltraGridColumn520, UltraGridColumn521, UltraGridColumn522, UltraGridColumn523})
        Me.griListaServiciosRequeridos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaServiciosRequeridos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance84.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance84.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.Appearance = Appearance84
        Appearance85.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance85
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.Hidden = True
        Appearance86.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance86.BackColor2 = System.Drawing.SystemColors.Control
        Appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance86.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.PromptAppearance = Appearance86
        Me.griListaServiciosRequeridos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaServiciosRequeridos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaServiciosRequeridos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServiciosRequeridos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServiciosRequeridos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaServiciosRequeridos.DisplayLayout.Override.CellPadding = 0
        Me.griListaServiciosRequeridos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaServiciosRequeridos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaServiciosRequeridos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaServiciosRequeridos.DisplayLayout.Override.GroupByRowAppearance = Appearance87
        Appearance88.TextHAlignAsString = "Left"
        Me.griListaServiciosRequeridos.DisplayLayout.Override.HeaderAppearance = Appearance88
        Me.griListaServiciosRequeridos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaServiciosRequeridos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance89.BackColor = System.Drawing.SystemColors.Window
        Appearance89.BorderColor = System.Drawing.Color.Silver
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowAppearance = Appearance89
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServiciosRequeridos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaServiciosRequeridos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaServiciosRequeridos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaServiciosRequeridos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaServiciosRequeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaServiciosRequeridos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaServiciosRequeridos.Location = New System.Drawing.Point(3, 17)
        Me.griListaServiciosRequeridos.Name = "griListaServiciosRequeridos"
        Me.griListaServiciosRequeridos.Size = New System.Drawing.Size(1231, 287)
        Me.griListaServiciosRequeridos.TabIndex = 0
        Me.griListaServiciosRequeridos.Text = "Grilla2"
        '
        'odRequerimientoServicio
        '
        UltraDataColumn78.DataType = GetType(Boolean)
        UltraDataColumn78.DefaultValue = False
        UltraDataColumn98.DataType = GetType(Boolean)
        UltraDataColumn98.DefaultValue = False
        Me.odRequerimientoServicio.Band.Columns.AddRange(New Object() {UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion10)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1237, 307)
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.Agrupacion8)
        Me.Agrupacion10.Controls.Add(Me.uebHistorialMaterial)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(1237, 307)
        Me.Agrupacion10.TabIndex = 0
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.grilla_OA_Material)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion8.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(1231, 275)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.Text = "Materiales requeridos : 0"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grilla_OA_Material
        '
        Me.grilla_OA_Material.DataSource = Me.odOAReqMat
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn363.Header.Appearance = Appearance90
        UltraGridColumn363.Header.VisiblePosition = 17
        UltraGridColumn363.Hidden = True
        Appearance91.TextHAlignAsString = "Center"
        UltraGridColumn364.Header.Appearance = Appearance91
        UltraGridColumn364.Header.VisiblePosition = 0
        UltraGridColumn364.Hidden = True
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn365.Header.Appearance = Appearance92
        UltraGridColumn365.Header.VisiblePosition = 1
        UltraGridColumn365.Hidden = True
        Appearance93.TextHAlignAsString = "Center"
        UltraGridColumn366.Header.Appearance = Appearance93
        UltraGridColumn366.Header.Caption = "Codigo"
        UltraGridColumn366.Header.VisiblePosition = 2
        UltraGridColumn366.Width = 83
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn367.Header.Appearance = Appearance94
        UltraGridColumn367.Header.VisiblePosition = 3
        UltraGridColumn367.Width = 315
        Appearance95.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance95.TextHAlignAsString = "Right"
        UltraGridColumn368.CellAppearance = Appearance95
        UltraGridColumn368.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance96.TextHAlignAsString = "Center"
        UltraGridColumn368.Header.Appearance = Appearance96
        UltraGridColumn368.Header.VisiblePosition = 5
        UltraGridColumn368.MaskInput = "{double:9.4}"
        UltraGridColumn368.Width = 70
        Appearance97.TextHAlignAsString = "Center"
        UltraGridColumn369.Header.Appearance = Appearance97
        UltraGridColumn369.Header.VisiblePosition = 18
        UltraGridColumn369.Hidden = True
        UltraGridColumn369.Width = 104
        Appearance98.TextHAlignAsString = "Center"
        UltraGridColumn370.Header.Appearance = Appearance98
        UltraGridColumn370.Header.Caption = "Unid. Med."
        UltraGridColumn370.Header.VisiblePosition = 6
        UltraGridColumn370.Width = 78
        Appearance99.TextHAlignAsString = "Center"
        UltraGridColumn371.Header.Appearance = Appearance99
        UltraGridColumn371.Header.VisiblePosition = 4
        UltraGridColumn371.Hidden = True
        UltraGridColumn372.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Appearance100.TextHAlignAsString = "Right"
        UltraGridColumn372.CellAppearance = Appearance100
        Appearance101.Image = CType(resources.GetObject("Appearance101.Image"), Object)
        UltraGridColumn372.CellButtonAppearance = Appearance101
        UltraGridColumn372.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance102.TextHAlignAsString = "Center"
        UltraGridColumn372.Header.Appearance = Appearance102
        UltraGridColumn372.Header.Caption = "Por atender"
        UltraGridColumn372.Header.VisiblePosition = 9
        UltraGridColumn372.MaskInput = "{double:9.4}"
        UltraGridColumn372.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn372.Width = 83
        Appearance103.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance103.TextHAlignAsString = "Right"
        UltraGridColumn373.CellAppearance = Appearance103
        UltraGridColumn373.Header.Caption = "Atender"
        UltraGridColumn373.Header.VisiblePosition = 10
        UltraGridColumn373.MaskInput = "{double:9.4}"
        UltraGridColumn373.Width = 69
        Appearance104.TextHAlignAsString = "Center"
        UltraGridColumn374.Header.Appearance = Appearance104
        UltraGridColumn374.Header.Caption = "Almacen"
        UltraGridColumn374.Header.VisiblePosition = 7
        UltraGridColumn374.Width = 165
        Appearance105.TextHAlignAsString = "Center"
        UltraGridColumn375.Header.Appearance = Appearance105
        UltraGridColumn375.Header.VisiblePosition = 12
        UltraGridColumn375.Hidden = True
        UltraGridColumn375.Width = 174
        UltraGridColumn376.Header.Caption = "Sub Almacén"
        UltraGridColumn376.Header.VisiblePosition = 8
        UltraGridColumn376.Width = 127
        Appearance106.TextHAlignAsString = "Center"
        UltraGridColumn377.Header.Appearance = Appearance106
        UltraGridColumn377.Header.Caption = "CentroCosto"
        UltraGridColumn377.Header.VisiblePosition = 11
        UltraGridColumn377.Hidden = True
        UltraGridColumn377.Width = 87
        UltraGridColumn378.Header.VisiblePosition = 19
        UltraGridColumn378.Hidden = True
        Appearance107.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance107.Image = CType(resources.GetObject("Appearance107.Image"), Object)
        UltraGridColumn379.CellAppearance = Appearance107
        Appearance108.Image = CType(resources.GetObject("Appearance108.Image"), Object)
        UltraGridColumn379.CellButtonAppearance = Appearance108
        UltraGridColumn379.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn379.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance109.TextHAlignAsString = "Center"
        UltraGridColumn379.Header.Appearance = Appearance109
        UltraGridColumn379.Header.VisiblePosition = 16
        UltraGridColumn379.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn379.Width = 260
        UltraGridColumn380.Header.VisiblePosition = 20
        UltraGridColumn380.Hidden = True
        UltraGridColumn381.Header.VisiblePosition = 22
        UltraGridColumn381.Hidden = True
        UltraGridColumn382.Header.Caption = "Estado"
        UltraGridColumn382.Header.VisiblePosition = 21
        UltraGridColumn382.Hidden = True
        Appearance110.TextHAlignAsString = "Right"
        UltraGridColumn383.CellAppearance = Appearance110
        Appearance111.TextHAlignAsString = "Center"
        UltraGridColumn383.Header.Appearance = Appearance111
        UltraGridColumn383.Header.VisiblePosition = 13
        UltraGridColumn383.Hidden = True
        UltraGridColumn383.MaskInput = "{double:9.4}"
        UltraGridColumn384.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.TextHAlignAsString = "Right"
        UltraGridColumn384.CellAppearance = Appearance112
        Appearance113.TextHAlignAsString = "Center"
        UltraGridColumn384.Header.Appearance = Appearance113
        UltraGridColumn384.Header.Caption = "Stock"
        UltraGridColumn384.Header.VisiblePosition = 14
        UltraGridColumn384.MaskInput = "{double:9.4}"
        UltraGridColumn384.Width = 69
        UltraGridColumn385.Header.VisiblePosition = 15
        UltraGridColumn386.Header.VisiblePosition = 23
        UltraGridColumn386.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 24
        UltraGridColumn2.Hidden = True
        UltraGridColumn387.Header.VisiblePosition = 25
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376, UltraGridColumn377, UltraGridColumn378, UltraGridColumn379, UltraGridColumn380, UltraGridColumn381, UltraGridColumn382, UltraGridColumn383, UltraGridColumn384, UltraGridColumn385, UltraGridColumn386, UltraGridColumn2, UltraGridColumn387})
        UltraGridColumn388.Header.VisiblePosition = 0
        UltraGridColumn388.Hidden = True
        UltraGridColumn388.Width = 59
        UltraGridColumn389.Header.VisiblePosition = 1
        UltraGridColumn389.Hidden = True
        UltraGridColumn389.Width = 221
        UltraGridColumn390.Header.VisiblePosition = 2
        UltraGridColumn390.Hidden = True
        UltraGridColumn390.Width = 84
        UltraGridColumn391.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn391.Header.Caption = "Marca"
        UltraGridColumn391.Header.VisiblePosition = 3
        UltraGridColumn391.Width = 171
        UltraGridColumn392.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance114.TextHAlignAsString = "Center"
        UltraGridColumn392.Header.Appearance = Appearance114
        UltraGridColumn392.Header.Caption = "Modelo"
        UltraGridColumn392.Header.VisiblePosition = 4
        UltraGridColumn392.Width = 221
        UltraGridColumn393.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance115.TextHAlignAsString = "Center"
        UltraGridColumn393.Header.Appearance = Appearance115
        UltraGridColumn393.Header.Caption = "Estado"
        UltraGridColumn393.Header.VisiblePosition = 5
        UltraGridColumn393.Width = 122
        UltraGridColumn394.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn394.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn394.Header.VisiblePosition = 6
        UltraGridColumn394.Width = 109
        UltraGridColumn395.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn395.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn395.Header.VisiblePosition = 7
        UltraGridColumn395.Width = 200
        UltraGridColumn1.Header.VisiblePosition = 8
        UltraGridColumn1.Width = 111
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn1})
        UltraGridBand6.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.HeaderIcons
        UltraGridBand6.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.grilla_OA_Material.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grilla_OA_Material.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grilla_OA_Material.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance116.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance116.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance116.BorderColor = System.Drawing.SystemColors.Window
        Me.grilla_OA_Material.DisplayLayout.GroupByBox.Appearance = Appearance116
        Appearance117.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grilla_OA_Material.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance117
        Me.grilla_OA_Material.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grilla_OA_Material.DisplayLayout.GroupByBox.Hidden = True
        Appearance118.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance118.BackColor2 = System.Drawing.SystemColors.Control
        Appearance118.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance118.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grilla_OA_Material.DisplayLayout.GroupByBox.PromptAppearance = Appearance118
        Me.grilla_OA_Material.DisplayLayout.MaxColScrollRegions = 1
        Me.grilla_OA_Material.DisplayLayout.MaxRowScrollRegions = 1
        Me.grilla_OA_Material.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grilla_OA_Material.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_OA_Material.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_OA_Material.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grilla_OA_Material.DisplayLayout.Override.CellPadding = 0
        Me.grilla_OA_Material.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grilla_OA_Material.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grilla_OA_Material.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.grilla_OA_Material.DisplayLayout.Override.GroupByRowAppearance = Appearance119
        Appearance120.TextHAlignAsString = "Left"
        Me.grilla_OA_Material.DisplayLayout.Override.HeaderAppearance = Appearance120
        Me.grilla_OA_Material.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.grilla_OA_Material.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance121.BackColor = System.Drawing.SystemColors.Window
        Appearance121.BorderColor = System.Drawing.Color.Silver
        Me.grilla_OA_Material.DisplayLayout.Override.RowAppearance = Appearance121
        Me.grilla_OA_Material.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grilla_OA_Material.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grilla_OA_Material.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_OA_Material.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Free
        Me.grilla_OA_Material.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.grilla_OA_Material.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grilla_OA_Material.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grilla_OA_Material.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grilla_OA_Material.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilla_OA_Material.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla_OA_Material.Location = New System.Drawing.Point(3, 17)
        Me.grilla_OA_Material.Name = "grilla_OA_Material"
        Me.grilla_OA_Material.Size = New System.Drawing.Size(1225, 255)
        Me.grilla_OA_Material.TabIndex = 0
        Me.grilla_OA_Material.Text = "Grilla2"
        '
        'odOAReqMat
        '
        UltraDataColumn114.DataType = GetType(Date)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114})
        Me.odOAReqMat.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.odOAReqMat.Band.Columns.AddRange(New Object() {UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139})
        '
        'uebHistorialMaterial
        '
        Me.uebHistorialMaterial.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.uebHistorialMaterial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uebHistorialMaterial.Expanded = False
        Me.uebHistorialMaterial.ExpandedSize = New System.Drawing.Size(1231, 192)
        Me.uebHistorialMaterial.Location = New System.Drawing.Point(3, 278)
        Me.uebHistorialMaterial.Name = "uebHistorialMaterial"
        Me.uebHistorialMaterial.Size = New System.Drawing.Size(1231, 26)
        Me.uebHistorialMaterial.TabIndex = 0
        Me.uebHistorialMaterial.TabStop = False
        Me.uebHistorialMaterial.Text = "Historial Material Trabajador"
        Me.uebHistorialMaterial.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.grReg_Inv)
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1219, 169)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel3.Visible = False
        '
        'grReg_Inv
        '
        Me.grReg_Inv.DataSource = Me.odRegistroInventario
        UltraGridColumn524.Header.VisiblePosition = 0
        UltraGridColumn524.Hidden = True
        UltraGridColumn525.Header.Caption = "N° Movimiento"
        UltraGridColumn525.Header.VisiblePosition = 2
        UltraGridColumn525.Hidden = True
        UltraGridColumn526.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn526.Header.VisiblePosition = 1
        UltraGridColumn526.Width = 120
        UltraGridColumn527.Header.Caption = "Tipo Mov."
        UltraGridColumn527.Header.VisiblePosition = 3
        UltraGridColumn527.Width = 85
        UltraGridColumn528.Header.VisiblePosition = 4
        UltraGridColumn528.Width = 306
        Appearance122.TextHAlignAsString = "Right"
        UltraGridColumn529.CellAppearance = Appearance122
        UltraGridColumn529.Format = "#,##0.000"
        UltraGridColumn529.Header.VisiblePosition = 5
        Appearance123.TextHAlignAsString = "Right"
        UltraGridColumn530.CellAppearance = Appearance123
        UltraGridColumn530.Format = "#,##0.000"
        UltraGridColumn530.Header.VisiblePosition = 6
        Appearance124.TextHAlignAsString = "Right"
        UltraGridColumn531.CellAppearance = Appearance124
        UltraGridColumn531.Format = "#,##0.000"
        UltraGridColumn531.Header.Caption = "Costo Unit."
        UltraGridColumn531.Header.VisiblePosition = 7
        Appearance125.TextHAlignAsString = "Right"
        UltraGridColumn532.CellAppearance = Appearance125
        UltraGridColumn532.Format = "#,##0.000"
        UltraGridColumn532.Header.Caption = "Costo Total"
        UltraGridColumn532.Header.VisiblePosition = 8
        Appearance126.TextHAlignAsString = "Right"
        UltraGridColumn533.CellAppearance = Appearance126
        UltraGridColumn533.Format = "#,##0.000"
        UltraGridColumn533.Header.Caption = "Precio Unit."
        UltraGridColumn533.Header.VisiblePosition = 9
        Appearance127.TextHAlignAsString = "Right"
        UltraGridColumn534.CellAppearance = Appearance127
        UltraGridColumn534.Format = "#,##0.000"
        UltraGridColumn534.Header.Caption = "Precio Total"
        UltraGridColumn534.Header.VisiblePosition = 10
        Appearance128.BackColor = System.Drawing.Color.Khaki
        Appearance128.Image = Global.ISL.Win.My.Resources.Resources.lupa
        UltraGridColumn535.CellAppearance = Appearance128
        UltraGridColumn535.Header.Caption = "N° Orden"
        UltraGridColumn535.Header.VisiblePosition = 13
        UltraGridColumn535.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn535.Width = 145
        UltraGridColumn536.Header.VisiblePosition = 14
        UltraGridColumn536.Hidden = True
        UltraGridColumn537.Header.VisiblePosition = 15
        UltraGridColumn537.Hidden = True
        UltraGridColumn537.Width = 214
        UltraGridColumn538.Header.VisiblePosition = 16
        UltraGridColumn539.Header.VisiblePosition = 17
        UltraGridColumn539.Hidden = True
        Appearance129.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn540.CellAppearance = Appearance129
        UltraGridColumn540.Header.VisiblePosition = 12
        UltraGridColumn540.Hidden = True
        UltraGridColumn541.Header.Caption = "Tipo Documento"
        UltraGridColumn541.Header.VisiblePosition = 18
        UltraGridColumn541.Hidden = True
        UltraGridColumn542.Header.Caption = "N° Documento"
        UltraGridColumn542.Header.VisiblePosition = 19
        UltraGridColumn542.Hidden = True
        UltraGridColumn542.Width = 113
        Appearance130.TextHAlignAsString = "Right"
        UltraGridColumn543.CellAppearance = Appearance130
        UltraGridColumn543.Format = ""
        UltraGridColumn543.Header.VisiblePosition = 11
        UltraGridColumn543.MaskInput = "{double:-9.3}"
        UltraGridColumn543.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn543.Width = 81
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn524, UltraGridColumn525, UltraGridColumn526, UltraGridColumn527, UltraGridColumn528, UltraGridColumn529, UltraGridColumn530, UltraGridColumn531, UltraGridColumn532, UltraGridColumn533, UltraGridColumn534, UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn538, UltraGridColumn539, UltraGridColumn540, UltraGridColumn541, UltraGridColumn542, UltraGridColumn543})
        Me.grReg_Inv.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.grReg_Inv.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grReg_Inv.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grReg_Inv.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grReg_Inv.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grReg_Inv.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grReg_Inv.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grReg_Inv.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grReg_Inv.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grReg_Inv.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grReg_Inv.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grReg_Inv.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grReg_Inv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grReg_Inv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grReg_Inv.Location = New System.Drawing.Point(0, 0)
        Me.grReg_Inv.Name = "grReg_Inv"
        Me.grReg_Inv.Size = New System.Drawing.Size(1219, 169)
        Me.grReg_Inv.TabIndex = 6
        '
        'odRegistroInventario
        '
        Me.odRegistroInventario.AllowAdd = False
        Me.odRegistroInventario.AllowDelete = False
        UltraDataColumn145.DataType = GetType(Double)
        UltraDataColumn146.DataType = GetType(Double)
        UltraDataColumn147.DataType = GetType(Double)
        UltraDataColumn148.DataType = GetType(Double)
        UltraDataColumn149.DataType = GetType(Double)
        UltraDataColumn150.DataType = GetType(Double)
        UltraDataColumn159.DataType = GetType(Double)
        Me.odRegistroInventario.Band.Columns.AddRange(New Object() {UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrRequerimientos)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1239, 449)
        '
        'agrRequerimientos
        '
        Me.agrRequerimientos.Controls.Add(Me.griListaRequerimientos)
        Me.agrRequerimientos.Controls.Add(Me.agrMenuLista)
        Me.agrRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrRequerimientos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrRequerimientos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrRequerimientos.Location = New System.Drawing.Point(0, 92)
        Me.agrRequerimientos.Name = "agrRequerimientos"
        Me.agrRequerimientos.Size = New System.Drawing.Size(1239, 357)
        Me.agrRequerimientos.TabIndex = 1
        Me.agrRequerimientos.Text = "Requerimientos : "
        Me.agrRequerimientos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaRequerimientos
        '
        Me.griListaRequerimientos.ContextMenuStrip = Me.MenuContextual1
        Me.griListaRequerimientos.DataSource = Me.odRequerimientos
        Appearance131.TextHAlignAsString = "Center"
        UltraGridColumn396.Header.Appearance = Appearance131
        UltraGridColumn396.Header.VisiblePosition = 0
        UltraGridColumn396.Hidden = True
        Appearance132.TextHAlignAsString = "Center"
        UltraGridColumn397.Header.Appearance = Appearance132
        UltraGridColumn397.Header.VisiblePosition = 1
        UltraGridColumn397.Width = 97
        UltraGridColumn398.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance133.TextHAlignAsString = "Center"
        UltraGridColumn398.Header.Appearance = Appearance133
        UltraGridColumn398.Header.Caption = "Fecha de atención"
        UltraGridColumn398.Header.VisiblePosition = 20
        Appearance134.TextHAlignAsString = "Center"
        UltraGridColumn399.Header.Appearance = Appearance134
        UltraGridColumn399.Header.Caption = "Tipo requerimiento"
        UltraGridColumn399.Header.VisiblePosition = 2
        UltraGridColumn399.Hidden = True
        UltraGridColumn399.Width = 312
        Appearance135.TextHAlignAsString = "Center"
        UltraGridColumn400.Header.Appearance = Appearance135
        UltraGridColumn400.Header.VisiblePosition = 3
        UltraGridColumn400.Hidden = True
        Appearance136.TextHAlignAsString = "Center"
        UltraGridColumn401.Header.Appearance = Appearance136
        UltraGridColumn401.Header.Caption = "Estado"
        UltraGridColumn401.Header.VisiblePosition = 5
        UltraGridColumn401.Width = 124
        Appearance137.TextHAlignAsString = "Center"
        UltraGridColumn402.Header.Appearance = Appearance137
        UltraGridColumn402.Header.Caption = "Descripción"
        UltraGridColumn402.Header.VisiblePosition = 6
        UltraGridColumn402.Width = 227
        Appearance138.TextHAlignAsString = "Center"
        UltraGridColumn403.Header.Appearance = Appearance138
        UltraGridColumn403.Header.VisiblePosition = 7
        UltraGridColumn403.Hidden = True
        Appearance139.TextHAlignAsString = "Center"
        UltraGridColumn404.Header.Appearance = Appearance139
        UltraGridColumn404.Header.VisiblePosition = 12
        UltraGridColumn404.Width = 108
        Appearance140.TextHAlignAsString = "Center"
        UltraGridColumn405.Header.Appearance = Appearance140
        UltraGridColumn405.Header.VisiblePosition = 10
        UltraGridColumn405.Hidden = True
        UltraGridColumn405.Width = 123
        Appearance141.TextHAlignAsString = "Center"
        UltraGridColumn406.Header.Appearance = Appearance141
        UltraGridColumn406.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        UltraGridColumn406.Header.VisiblePosition = 9
        UltraGridColumn406.Width = 102
        Appearance142.TextHAlignAsString = "Center"
        UltraGridColumn407.Header.Appearance = Appearance142
        UltraGridColumn407.Header.Caption = "Glosa atención"
        UltraGridColumn407.Header.VisiblePosition = 13
        UltraGridColumn407.Hidden = True
        UltraGridColumn407.Width = 156
        Appearance143.TextHAlignAsString = "Center"
        UltraGridColumn408.Header.Appearance = Appearance143
        UltraGridColumn408.Header.Caption = "Atendido Por"
        UltraGridColumn408.Header.VisiblePosition = 14
        UltraGridColumn408.Width = 161
        Appearance144.TextHAlignAsString = "Center"
        UltraGridColumn409.Header.Appearance = Appearance144
        UltraGridColumn409.Header.VisiblePosition = 15
        UltraGridColumn409.Hidden = True
        UltraGridColumn410.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance145.TextHAlignAsString = "Center"
        UltraGridColumn410.Header.Appearance = Appearance145
        UltraGridColumn410.Header.Caption = "Fecha"
        UltraGridColumn410.Header.VisiblePosition = 4
        UltraGridColumn410.MaskInput = "{LOC}dd/mm/yyyy hh:mm:ss tt"
        UltraGridColumn410.Width = 168
        Appearance146.TextHAlignAsString = "Center"
        UltraGridColumn411.Header.Appearance = Appearance146
        UltraGridColumn411.Header.VisiblePosition = 16
        UltraGridColumn411.Hidden = True
        Appearance147.TextHAlignAsString = "Center"
        UltraGridColumn412.Header.Appearance = Appearance147
        UltraGridColumn412.Header.VisiblePosition = 17
        UltraGridColumn412.Hidden = True
        Appearance148.TextHAlignAsString = "Center"
        UltraGridColumn413.Header.Appearance = Appearance148
        UltraGridColumn413.Header.VisiblePosition = 18
        UltraGridColumn413.Hidden = True
        Appearance149.TextHAlignAsString = "Center"
        UltraGridColumn414.Header.Appearance = Appearance149
        UltraGridColumn414.Header.VisiblePosition = 19
        UltraGridColumn414.Hidden = True
        Appearance150.TextHAlignAsString = "Center"
        UltraGridColumn415.Header.Appearance = Appearance150
        UltraGridColumn415.Header.VisiblePosition = 11
        UltraGridColumn415.Width = 201
        UltraGridColumn416.Header.VisiblePosition = 21
        UltraGridColumn416.Hidden = True
        UltraGridColumn417.Header.VisiblePosition = 22
        UltraGridColumn417.Hidden = True
        Appearance151.TextHAlignAsString = "Center"
        UltraGridColumn418.Header.Appearance = Appearance151
        UltraGridColumn418.Header.Caption = "Tipo Referencia"
        UltraGridColumn418.Header.VisiblePosition = 8
        UltraGridColumn418.Width = 128
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408, UltraGridColumn409, UltraGridColumn410, UltraGridColumn411, UltraGridColumn412, UltraGridColumn413, UltraGridColumn414, UltraGridColumn415, UltraGridColumn416, UltraGridColumn417, UltraGridColumn418})
        Me.griListaRequerimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griListaRequerimientos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance152.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance152.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance152.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance152.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaRequerimientos.DisplayLayout.GroupByBox.Appearance = Appearance152
        Appearance153.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaRequerimientos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance153
        Me.griListaRequerimientos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaRequerimientos.DisplayLayout.GroupByBox.Hidden = True
        Appearance154.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance154.BackColor2 = System.Drawing.SystemColors.Control
        Appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance154.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaRequerimientos.DisplayLayout.GroupByBox.PromptAppearance = Appearance154
        Me.griListaRequerimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaRequerimientos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaRequerimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRequerimientos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRequerimientos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaRequerimientos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance155.BorderColor = System.Drawing.Color.Silver
        Me.griListaRequerimientos.DisplayLayout.Override.CellAppearance = Appearance155
        Me.griListaRequerimientos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaRequerimientos.DisplayLayout.Override.CellPadding = 0
        Me.griListaRequerimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaRequerimientos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaRequerimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaRequerimientos.DisplayLayout.Override.GroupByRowAppearance = Appearance156
        Appearance157.TextHAlignAsString = "Left"
        Me.griListaRequerimientos.DisplayLayout.Override.HeaderAppearance = Appearance157
        Me.griListaRequerimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance158.BorderColor = System.Drawing.Color.Silver
        Me.griListaRequerimientos.DisplayLayout.Override.RowAppearance = Appearance158
        Me.griListaRequerimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaRequerimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaRequerimientos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaRequerimientos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaRequerimientos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaRequerimientos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaRequerimientos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaRequerimientos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaRequerimientos.Location = New System.Drawing.Point(3, 47)
        Me.griListaRequerimientos.Name = "griListaRequerimientos"
        Me.griListaRequerimientos.Size = New System.Drawing.Size(1233, 307)
        Me.griListaRequerimientos.TabIndex = 1
        Me.griListaRequerimientos.Text = "Grilla1"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.EvaluarToolStripMenuItem, Me.AtenderToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 114)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Requerimiento"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EditarToolStripMenuItem.Text = "Actualizar"
        Me.EditarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Requerimiento seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'EvaluarToolStripMenuItem
        '
        Me.EvaluarToolStripMenuItem.Image = CType(resources.GetObject("EvaluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EvaluarToolStripMenuItem.Name = "EvaluarToolStripMenuItem"
        Me.EvaluarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EvaluarToolStripMenuItem.Text = "Evaluar"
        '
        'AtenderToolStripMenuItem
        '
        Me.AtenderToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.AtenderToolStripMenuItem.Name = "AtenderToolStripMenuItem"
        Me.AtenderToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AtenderToolStripMenuItem.Text = "Atender"
        '
        'odRequerimientos
        '
        UltraDataColumn162.DataType = GetType(Date)
        UltraDataColumn162.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn174.DataType = GetType(Date)
        UltraDataColumn175.DataType = GetType(Boolean)
        UltraDataColumn175.DefaultValue = False
        Me.odRequerimientos.Band.Columns.AddRange(New Object() {UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnEliminar)
        Me.agrMenuLista.Controls.Add(Me.btnTerminarRQ)
        Me.agrMenuLista.Controls.Add(Me.btnActualizaOT)
        Me.agrMenuLista.Controls.Add(Me.btnRegReq)
        Me.agrMenuLista.Controls.Add(Me.btnAtenderReq)
        Me.agrMenuLista.Controls.Add(Me.btnEvaluarReq)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1233, 30)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance159.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance159.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnEliminar.Appearance = Appearance159
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(400, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 24)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnTerminarRQ
        '
        Appearance160.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance160.Image = Global.ISL.Win.My.Resources.Resources.hire_me
        Me.btnTerminarRQ.Appearance = Appearance160
        Me.btnTerminarRQ.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnTerminarRQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTerminarRQ.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTerminarRQ.Enabled = False
        Me.btnTerminarRQ.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminarRQ.ForeColor = System.Drawing.Color.Black
        Me.btnTerminarRQ.Location = New System.Drawing.Point(325, 3)
        Me.btnTerminarRQ.Name = "btnTerminarRQ"
        Me.btnTerminarRQ.Size = New System.Drawing.Size(75, 24)
        Me.btnTerminarRQ.TabIndex = 4
        Me.btnTerminarRQ.Text = "Terminar"
        Me.btnTerminarRQ.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnActualizaOT
        '
        Appearance161.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance161.Image = Global.ISL.Win.My.Resources.Resources.clipboard
        Me.btnActualizaOT.Appearance = Appearance161
        Me.btnActualizaOT.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnActualizaOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizaOT.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnActualizaOT.Enabled = False
        Me.btnActualizaOT.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizaOT.ForeColor = System.Drawing.Color.Black
        Me.btnActualizaOT.Location = New System.Drawing.Point(232, 3)
        Me.btnActualizaOT.Name = "btnActualizaOT"
        Me.btnActualizaOT.Size = New System.Drawing.Size(93, 24)
        Me.btnActualizaOT.TabIndex = 3
        Me.btnActualizaOT.Text = "Actualiza OT"
        Me.btnActualizaOT.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnRegReq
        '
        Appearance162.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance162.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.btnRegReq.Appearance = Appearance162
        Me.btnRegReq.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnRegReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegReq.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRegReq.Enabled = False
        Me.btnRegReq.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegReq.ForeColor = System.Drawing.Color.Black
        Me.btnRegReq.Location = New System.Drawing.Point(147, 3)
        Me.btnRegReq.Name = "btnRegReq"
        Me.btnRegReq.Size = New System.Drawing.Size(85, 24)
        Me.btnRegReq.TabIndex = 2
        Me.btnRegReq.Text = "Regularizar"
        Me.btnRegReq.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAtenderReq
        '
        Appearance163.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance163.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAtenderReq.Appearance = Appearance163
        Me.btnAtenderReq.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAtenderReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtenderReq.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAtenderReq.Enabled = False
        Me.btnAtenderReq.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtenderReq.ForeColor = System.Drawing.Color.Black
        Me.btnAtenderReq.Location = New System.Drawing.Point(75, 3)
        Me.btnAtenderReq.Name = "btnAtenderReq"
        Me.btnAtenderReq.Size = New System.Drawing.Size(72, 24)
        Me.btnAtenderReq.TabIndex = 1
        Me.btnAtenderReq.Text = "Atender"
        Me.btnAtenderReq.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEvaluarReq
        '
        Appearance164.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance164.Image = CType(resources.GetObject("Appearance164.Image"), Object)
        Me.btnEvaluarReq.Appearance = Appearance164
        Me.btnEvaluarReq.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEvaluarReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEvaluarReq.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEvaluarReq.Enabled = False
        Me.btnEvaluarReq.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluarReq.ForeColor = System.Drawing.Color.Black
        Me.btnEvaluarReq.Location = New System.Drawing.Point(3, 3)
        Me.btnEvaluarReq.Name = "btnEvaluarReq"
        Me.btnEvaluarReq.Size = New System.Drawing.Size(72, 24)
        Me.btnEvaluarReq.TabIndex = 0
        Me.btnEvaluarReq.Text = "Evaluar"
        Me.btnEvaluarReq.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboCentro)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion1.Controls.Add(Me.rangoFechaHasta)
        Me.Agrupacion1.Controls.Add(Me.rangoFechaDesde)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.cboFormaBusqueda)
        Me.Agrupacion1.Controls.Add(Me.cboAreaL)
        Me.Agrupacion1.Controls.Add(Me.cboRequerimiento)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion1.Controls.Add(Me.cbArea)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1239, 92)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCentro
        '
        Appearance165.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance165
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(481, 30)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(106, 21)
        Me.cboCentro.TabIndex = 6
        Me.cboCentro.ValueMember = "Id"
        '
        'Etiqueta23
        '
        Appearance166.BackColor = System.Drawing.Color.Transparent
        Appearance166.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance166
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(435, 34)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta23.TabIndex = 5
        Me.Etiqueta23.Text = "Centro:"
        '
        'rangoFechaHasta
        '
        Me.rangoFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rangoFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rangoFechaHasta.Location = New System.Drawing.Point(332, 29)
        Me.rangoFechaHasta.Name = "rangoFechaHasta"
        Me.rangoFechaHasta.Size = New System.Drawing.Size(84, 20)
        Me.rangoFechaHasta.TabIndex = 4
        '
        'rangoFechaDesde
        '
        Me.rangoFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rangoFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rangoFechaDesde.Location = New System.Drawing.Point(202, 29)
        Me.rangoFechaDesde.Name = "rangoFechaDesde"
        Me.rangoFechaDesde.Size = New System.Drawing.Size(83, 20)
        Me.rangoFechaDesde.TabIndex = 2
        '
        'Etiqueta21
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance167
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(291, 32)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 3
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta2
        '
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance168
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(162, 32)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Desde:"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.ColoresAtendido)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion3.Controls.Add(Me.ColoresAtendidoParcialmente)
        Me.Agrupacion3.Controls.Add(Me.etiTerminada)
        Me.Agrupacion3.Controls.Add(Me.ColoresEvaluado)
        Me.Agrupacion3.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion3.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion3.Controls.Add(Me.etiGenerada)
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(630, 23)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(307, 62)
        Me.Agrupacion3.TabIndex = 11
        Me.Agrupacion3.Text = "Estados"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresAtendido
        '
        Me.ColoresAtendido.Location = New System.Drawing.Point(248, 33)
        Me.ColoresAtendido.Name = "ColoresAtendido"
        Me.ColoresAtendido.Size = New System.Drawing.Size(46, 22)
        Me.ColoresAtendido.TabIndex = 7
        Me.ColoresAtendido.Text = "Control"
        '
        'Etiqueta3
        '
        Appearance169.BackColor = System.Drawing.Color.Transparent
        Appearance169.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Appearance = Appearance169
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(247, 18)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Atendido"
        '
        'ColoresAtendidoParcialmente
        '
        Me.ColoresAtendidoParcialmente.Location = New System.Drawing.Point(164, 33)
        Me.ColoresAtendidoParcialmente.Name = "ColoresAtendidoParcialmente"
        Me.ColoresAtendidoParcialmente.Size = New System.Drawing.Size(46, 22)
        Me.ColoresAtendidoParcialmente.TabIndex = 5
        Me.ColoresAtendidoParcialmente.Text = "Control"
        '
        'etiTerminada
        '
        Appearance170.BackColor = System.Drawing.Color.Transparent
        Appearance170.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance170
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(145, 18)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(81, 15)
        Me.etiTerminada.TabIndex = 4
        Me.etiTerminada.Text = "Atención Parcial"
        '
        'ColoresEvaluado
        '
        Me.ColoresEvaluado.Location = New System.Drawing.Point(95, 33)
        Me.ColoresEvaluado.Name = "ColoresEvaluado"
        Me.ColoresEvaluado.Size = New System.Drawing.Size(43, 22)
        Me.ColoresEvaluado.TabIndex = 3
        Me.ColoresEvaluado.Text = "Control"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(13, 33)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "Control"
        '
        'etiEnProceso
        '
        Appearance171.BackColor = System.Drawing.Color.Transparent
        Appearance171.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance171
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(88, 18)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(48, 15)
        Me.etiEnProceso.TabIndex = 2
        Me.etiEnProceso.Text = "Evaluado"
        '
        'etiGenerada
        '
        Appearance172.BackColor = System.Drawing.Color.Transparent
        Appearance172.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance172
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(9, 18)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generado"
        '
        'cboFormaBusqueda
        '
        Appearance173.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFormaBusqueda.Appearance = Appearance173
        Me.cboFormaBusqueda.DisplayMember = "Nombre"
        Me.cboFormaBusqueda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFormaBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFormaBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaBusqueda.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "FS"
        ValueListItem1.DisplayText = "Fecha de solicitud :"
        ValueListItem2.DataValue = "FA"
        ValueListItem2.DisplayText = "Fecha de Atención :"
        Me.cboFormaBusqueda.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cboFormaBusqueda.Location = New System.Drawing.Point(11, 30)
        Me.cboFormaBusqueda.Name = "cboFormaBusqueda"
        Me.cboFormaBusqueda.Size = New System.Drawing.Size(144, 21)
        Me.cboFormaBusqueda.TabIndex = 0
        Me.cboFormaBusqueda.ValueMember = "Id"
        '
        'cboAreaL
        '
        Appearance174.ForeColor = System.Drawing.Color.Black
        Me.cboAreaL.Appearance = Appearance174
        Me.cboAreaL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance175.Image = 7
        EditorButton1.Appearance = Appearance175
        Me.cboAreaL.ButtonsRight.Add(EditorButton1)
        Me.cboAreaL.DisplayMember = "Nombre"
        Me.cboAreaL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAreaL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAreaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaL.ForeColor = System.Drawing.Color.Black
        Me.cboAreaL.ImageList = Me.imagenes
        Me.cboAreaL.Location = New System.Drawing.Point(330, 62)
        Me.cboAreaL.Name = "cboAreaL"
        Me.cboAreaL.Size = New System.Drawing.Size(257, 21)
        Me.cboAreaL.TabIndex = 10
        Me.cboAreaL.ValueMember = "Id"
        '
        'cboRequerimiento
        '
        Appearance176.ForeColor = System.Drawing.Color.Black
        Me.cboRequerimiento.Appearance = Appearance176
        Me.cboRequerimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance177.Image = 7
        EditorButton2.Appearance = Appearance177
        Me.cboRequerimiento.ButtonsRight.Add(EditorButton2)
        Me.cboRequerimiento.DisplayMember = "Nombre"
        Me.cboRequerimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRequerimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRequerimiento.ForeColor = System.Drawing.Color.Black
        Me.cboRequerimiento.ImageList = Me.imagenes
        ValueListItem3.DataValue = "M"
        ValueListItem3.DisplayText = "MATERIALES"
        ValueListItem4.DataValue = "S"
        ValueListItem4.DisplayText = "SERVICIOS"
        Me.cboRequerimiento.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.cboRequerimiento.Location = New System.Drawing.Point(48, 60)
        Me.cboRequerimiento.Name = "cboRequerimiento"
        Me.cboRequerimiento.Size = New System.Drawing.Size(217, 21)
        Me.cboRequerimiento.TabIndex = 8
        Me.cboRequerimiento.ValueMember = "Id"
        '
        'UltraLabel5
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Appearance178.ForeColor = System.Drawing.Color.Navy
        Appearance178.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance178
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(12, 66)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(30, 15)
        Me.UltraLabel5.TabIndex = 7
        Me.UltraLabel5.Text = "Tipo:"
        '
        'cbArea
        '
        Me.cbArea.BackColor = System.Drawing.Color.Transparent
        Me.cbArea.BackColorInternal = System.Drawing.Color.Transparent
        Me.cbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbArea.Location = New System.Drawing.Point(275, 63)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(53, 20)
        Me.cbArea.TabIndex = 9
        Me.cbArea.Text = "Area:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1239, 449)
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalle.Location = New System.Drawing.Point(0, 119)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficDetalle.Size = New System.Drawing.Size(1239, 330)
        Me.ficDetalle.TabIndex = 0
        UltraTab3.Key = "Material"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Material"
        UltraTab4.Key = "Servicio"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Servicio"
        UltraTab5.Key = "OA_Material"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Material Orden Asignación"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1237, 307)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.cmEquipo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion2.Controls.Add(Me.btnActualizarDetalle)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel7)
        Me.Agrupacion2.Controls.Add(Me.txtMaterial)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion2.Controls.Add(Me.txtCodigoBarras)
        Me.Agrupacion2.Controls.Add(Me.fecAtencion)
        Me.Agrupacion2.Controls.Add(Me.fecFecha)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion9)
        Me.Agrupacion2.Controls.Add(Me.txtCodigo)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion2.Controls.Add(Me.lbl_etiqueta)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.txtArea)
        Me.Agrupacion2.Controls.Add(Me.txtDescripcion)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel22)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1239, 119)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmEquipo
        '
        Appearance179.ForeColor = System.Drawing.Color.Black
        Me.cmEquipo.Appearance = Appearance179
        Me.cmEquipo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmEquipo.DisplayMember = "Nombre"
        Me.cmEquipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmEquipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmEquipo.ForeColor = System.Drawing.Color.Black
        Me.cmEquipo.Location = New System.Drawing.Point(633, 22)
        Me.cmEquipo.Name = "cmEquipo"
        Me.cmEquipo.Size = New System.Drawing.Size(104, 21)
        Me.cmEquipo.TabIndex = 12
        Me.cmEquipo.ValueMember = "Id"
        Me.cmEquipo.Visible = False
        '
        'Etiqueta11
        '
        Appearance180.BackColor = System.Drawing.Color.Transparent
        Appearance180.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance180
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(636, 6)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta11.TabIndex = 11
        Me.Etiqueta11.Text = "Equipo:"
        Me.Etiqueta11.Visible = False
        '
        'btnActualizarDetalle
        '
        Appearance181.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance181.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnActualizarDetalle.Appearance = Appearance181
        Me.btnActualizarDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnActualizarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarDetalle.Enabled = False
        Me.btnActualizarDetalle.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnActualizarDetalle.Location = New System.Drawing.Point(256, 45)
        Me.btnActualizarDetalle.Name = "btnActualizarDetalle"
        Me.btnActualizarDetalle.Size = New System.Drawing.Size(82, 24)
        Me.btnActualizarDetalle.TabIndex = 6
        Me.btnActualizarDetalle.Text = "Actualizar"
        Me.btnActualizarDetalle.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel7
        '
        Appearance182.BackColor = System.Drawing.Color.Transparent
        Appearance182.ForeColor = System.Drawing.Color.Navy
        Appearance182.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance182
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(1020, 69)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel7.TabIndex = 17
        Me.UltraLabel7.Text = "Material:"
        Me.UltraLabel7.Visible = False
        '
        'txtMaterial
        '
        Appearance183.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaterial.Appearance = Appearance183
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaterial.Location = New System.Drawing.Point(1019, 85)
        Me.txtMaterial.MaxLength = 200
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(232, 22)
        Me.txtMaterial.TabIndex = 18
        Me.txtMaterial.Visible = False
        '
        'UltraLabel6
        '
        Appearance184.BackColor = System.Drawing.Color.Transparent
        Appearance184.ForeColor = System.Drawing.Color.Navy
        Appearance184.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance184
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(1020, 27)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(93, 15)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "Codigo de Barras:"
        Me.UltraLabel6.Visible = False
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarras.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(1019, 42)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(232, 22)
        Me.txtCodigoBarras.TabIndex = 16
        Me.txtCodigoBarras.Visible = False
        '
        'fecAtencion
        '
        Me.fecAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecAtencion.Location = New System.Drawing.Point(106, 61)
        Me.fecAtencion.Name = "fecAtencion"
        Me.fecAtencion.Size = New System.Drawing.Size(121, 20)
        Me.fecAtencion.TabIndex = 5
        '
        'fecFecha
        '
        Me.fecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFecha.Location = New System.Drawing.Point(106, 36)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(121, 20)
        Me.fecFecha.TabIndex = 3
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.colorAtendido)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion9.Controls.Add(Me.colorPendiente)
        Me.Agrupacion9.Controls.Add(Me.colorAtendidoParcial)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(351, 79)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(389, 32)
        Me.Agrupacion9.TabIndex = 19
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorAtendido
        '
        Me.colorAtendido.Location = New System.Drawing.Point(58, 5)
        Me.colorAtendido.Name = "colorAtendido"
        Me.colorAtendido.Size = New System.Drawing.Size(46, 21)
        Me.colorAtendido.TabIndex = 1
        Me.colorAtendido.Text = "Control"
        '
        'Etiqueta10
        '
        Appearance185.BackColor = System.Drawing.Color.Transparent
        Appearance185.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance185
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(9, 8)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Atendido"
        '
        'colorPendiente
        '
        Me.colorPendiente.Location = New System.Drawing.Point(340, 5)
        Me.colorPendiente.Name = "colorPendiente"
        Me.colorPendiente.Size = New System.Drawing.Size(43, 21)
        Me.colorPendiente.TabIndex = 5
        Me.colorPendiente.Text = "Control"
        '
        'colorAtendidoParcial
        '
        Me.colorAtendidoParcial.Location = New System.Drawing.Point(230, 5)
        Me.colorAtendidoParcial.Name = "colorAtendidoParcial"
        Me.colorAtendidoParcial.Size = New System.Drawing.Size(46, 21)
        Me.colorAtendidoParcial.TabIndex = 3
        Me.colorAtendidoParcial.Text = "Control"
        '
        'Etiqueta12
        '
        Appearance186.BackColor = System.Drawing.Color.Transparent
        Appearance186.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance186
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(285, 8)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta12.TabIndex = 4
        Me.Etiqueta12.Text = "Pendiente"
        '
        'Etiqueta13
        '
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Appearance187.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance187
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(114, 8)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(113, 15)
        Me.Etiqueta13.TabIndex = 2
        Me.Etiqueta13.Text = "Atendido Parcialmente"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(106, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(121, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'UltraLabel4
        '
        Appearance188.BackColor = System.Drawing.Color.Transparent
        Appearance188.ForeColor = System.Drawing.Color.Navy
        Appearance188.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance188
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(58, 14)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Codigo:"
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance189.BackColor = System.Drawing.Color.Transparent
        Appearance189.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance189
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1100, 13)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(57, 16)
        Me.lbl_etiqueta.TabIndex = 14
        Me.lbl_etiqueta.Text = "Etiqueta"
        Me.lbl_etiqueta.Visible = False
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.ColoresPorRegularizar)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion4.Controls.Add(Me.ColoresGeneradaDetalle)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion4.Controls.Add(Me.ColoresRechazado)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion4.Controls.Add(Me.ColoresAprobado)
        Me.Agrupacion4.Controls.Add(Me.ColoresPreaprobado)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion4.Location = New System.Drawing.Point(743, 5)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(254, 106)
        Me.Agrupacion4.TabIndex = 13
        Me.Agrupacion4.Text = "Estados"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresPorRegularizar
        '
        Me.ColoresPorRegularizar.Location = New System.Drawing.Point(180, 38)
        Me.ColoresPorRegularizar.Name = "ColoresPorRegularizar"
        Me.ColoresPorRegularizar.Size = New System.Drawing.Size(46, 21)
        Me.ColoresPorRegularizar.TabIndex = 5
        Me.ColoresPorRegularizar.Text = "Control"
        '
        'Etiqueta1
        '
        Appearance190.BackColor = System.Drawing.Color.Transparent
        Appearance190.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance190
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(170, 21)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(76, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "PorRegularizar"
        '
        'ColoresGeneradaDetalle
        '
        Me.ColoresGeneradaDetalle.Location = New System.Drawing.Point(14, 38)
        Me.ColoresGeneradaDetalle.Name = "ColoresGeneradaDetalle"
        Me.ColoresGeneradaDetalle.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGeneradaDetalle.TabIndex = 1
        Me.ColoresGeneradaDetalle.Text = "Control"
        '
        'Etiqueta4
        '
        Appearance191.BackColor = System.Drawing.Color.Transparent
        Appearance191.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance191
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(11, 21)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Generado"
        '
        'ColoresRechazado
        '
        Me.ColoresRechazado.Location = New System.Drawing.Point(92, 79)
        Me.ColoresRechazado.Name = "ColoresRechazado"
        Me.ColoresRechazado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresRechazado.TabIndex = 9
        Me.ColoresRechazado.Text = "Control"
        '
        'Etiqueta5
        '
        Appearance192.BackColor = System.Drawing.Color.Transparent
        Appearance192.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance192
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(86, 63)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta5.TabIndex = 8
        Me.Etiqueta5.Text = "Rechazado"
        '
        'ColoresAprobado
        '
        Me.ColoresAprobado.Location = New System.Drawing.Point(14, 79)
        Me.ColoresAprobado.Name = "ColoresAprobado"
        Me.ColoresAprobado.Size = New System.Drawing.Size(43, 21)
        Me.ColoresAprobado.TabIndex = 7
        Me.ColoresAprobado.Text = "Control"
        '
        'ColoresPreaprobado
        '
        Me.ColoresPreaprobado.Location = New System.Drawing.Point(92, 38)
        Me.ColoresPreaprobado.Name = "ColoresPreaprobado"
        Me.ColoresPreaprobado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresPreaprobado.TabIndex = 3
        Me.ColoresPreaprobado.Text = "Control"
        '
        'Etiqueta7
        '
        Appearance193.BackColor = System.Drawing.Color.Transparent
        Appearance193.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance193
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(9, 63)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta7.TabIndex = 6
        Me.Etiqueta7.Text = "Aprobado"
        '
        'Etiqueta9
        '
        Appearance194.BackColor = System.Drawing.Color.Transparent
        Appearance194.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance194
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(86, 21)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta9.TabIndex = 2
        Me.Etiqueta9.Text = "Preaprobado"
        '
        'UltraLabel2
        '
        Appearance195.BackColor = System.Drawing.Color.Transparent
        Appearance195.ForeColor = System.Drawing.Color.Navy
        Appearance195.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance195
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 61)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(84, 15)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Fecha Atención:"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Enabled = False
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(106, 85)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(232, 21)
        Me.txtArea.TabIndex = 8
        '
        'txtDescripcion
        '
        Appearance196.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Appearance = Appearance196
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(348, 22)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(276, 54)
        Me.txtDescripcion.TabIndex = 10
        '
        'UltraLabel3
        '
        Appearance197.BackColor = System.Drawing.Color.Transparent
        Appearance197.ForeColor = System.Drawing.Color.Navy
        Appearance197.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance197
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(348, 6)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Descripción:"
        '
        'UltraLabel1
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Appearance198.ForeColor = System.Drawing.Color.Navy
        Appearance198.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance198
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(62, 38)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Fecha:"
        '
        'UltraLabel22
        '
        Appearance199.BackColor = System.Drawing.Color.Transparent
        Appearance199.ForeColor = System.Drawing.Color.Navy
        Appearance199.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance199
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(69, 87)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(31, 15)
        Me.UltraLabel22.TabIndex = 7
        Me.UltraLabel22.Text = "Área:"
        '
        'agrDetalle
        '
        Me.agrDetalle.Location = New System.Drawing.Point(0, 0)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(200, 110)
        Me.agrDetalle.TabIndex = 0
        '
        'tcDetalle
        '
        Me.tcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tcDetalle.Name = "tcDetalle"
        Me.tcDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcDetalle.Size = New System.Drawing.Size(200, 100)
        Me.tcDetalle.TabIndex = 0
        Me.tcDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(198, 79)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1189, 26)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'mnuCotizacionProveedor
        '
        Appearance200.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnuCotizacionProveedor.Appearance = Appearance200
        Me.mnuCotizacionProveedor.DesignerFlags = 1
        Me.mnuCotizacionProveedor.DockWithinContainer = Me
        Me.mnuCotizacionProveedor.DockWithinContainerBaseType = GetType(frm_MenuPadre)
        Me.mnuCotizacionProveedor.MdiMergeable = False
        Me.mnuCotizacionProveedor.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.mnuCotizacionProveedor.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(252, 298)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(447, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool19})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.mnuCotizacionProveedor.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance201.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance201
        ButtonTool6.SharedPropsInternal.Caption = "Agregar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance202.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance202
        ButtonTool7.SharedPropsInternal.Caption = "Editar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance203.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool8.SharedPropsInternal.AppearancesSmall.Appearance = Appearance203
        ButtonTool8.SharedPropsInternal.Caption = "Eliminar"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance204.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance204
        ButtonTool9.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance205.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance205
        ButtonTool10.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool11.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool12.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool13.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance206.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool14.SharedPropsInternal.AppearancesSmall.Appearance = Appearance206
        ButtonTool14.SharedPropsInternal.Caption = "Consultar"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance207.Image = CType(resources.GetObject("Appearance207.Image"), Object)
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance207
        ButtonTool15.SharedPropsInternal.Caption = "Exportar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance208.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance208
        ButtonTool17.SharedPropsInternal.Caption = "Modificar"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance209.Image = Global.ISL.Win.My.Resources.Resources.Excel
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance209
        ButtonTool5.SharedPropsInternal.Caption = "Importar"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuCotizacionProveedor.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool17, ButtonTool5})
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(3, 207)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1189, 0)
        Me.UltraToolbarsDockArea2.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 191)
        Me.UltraToolbarsDockArea3.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1192, 16)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 191)
        Me.UltraToolbarsDockArea4.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'ficRequerimiento
        '
        Me.ficRequerimiento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficRequerimiento.Controls.Add(Me.UltraTabPageControl1)
        Me.ficRequerimiento.Controls.Add(Me.UltraTabPageControl2)
        Me.ficRequerimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficRequerimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficRequerimiento.Location = New System.Drawing.Point(0, 0)
        Me.ficRequerimiento.Name = "ficRequerimiento"
        Me.ficRequerimiento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficRequerimiento.Size = New System.Drawing.Size(1241, 472)
        Me.ficRequerimiento.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficRequerimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficRequerimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1239, 449)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(422, 202)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 23
        Me.ugb_Espera.Visible = False
        '
        'frm_Requerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 472)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficRequerimiento)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Requerimiento"
        Me.Text = "Requerimiento"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.agrMaterialesRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMaterialesRequeridos.ResumeLayout(False)
        CType(Me.griListaMaterialRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odRequerimientoMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.agrMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMateriales.ResumeLayout(False)
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.agrServiciosRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrServiciosRequeridos.ResumeLayout(False)
        CType(Me.gbeServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeServicios.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.agrServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrServicio.ResumeLayout(False)
        CType(Me.griListaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.cboCategoriaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griListaServiciosRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odRequerimientoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion10.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        CType(Me.grilla_OA_Material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOAReqMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uebHistorialMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uebHistorialMaterial.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odRegistroInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrRequerimientos.ResumeLayout(False)
        CType(Me.griListaRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cmEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAtendidoParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.ColoresPorRegularizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGeneradaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresRechazado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAprobado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresPreaprobado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuCotizacionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficRequerimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents odRequerimientos As ISL.Controles.OrigenDatos
    Friend WithEvents odRequerimientoMateriales As ISL.Controles.OrigenDatos
    Friend WithEvents agrDetalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tcDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents odServicio As ISL.Controles.OrigenDatos
    Friend WithEvents odRequerimientoServicio As ISL.Controles.OrigenDatos
    Friend WithEvents EvaluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ficRequerimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrRequerimientos As ISL.Controles.Agrupacion
    Friend WithEvents griListaRequerimientos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnAtenderReq As ISL.Controles.Boton
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresAtendido As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresAtendidoParcialmente As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEvaluado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents btnEvaluarReq As ISL.Controles.Boton
    Friend WithEvents cboFormaBusqueda As ISL.Controles.ComboMaestros
    Friend WithEvents cboAreaL As ISL.Controles.ComboMaestros
    Friend WithEvents cboRequerimiento As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbArea As ISL.Controles.Chequear
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresGeneradaDetalle As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresRechazado As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresAprobado As ISL.Controles.Colores
    Friend WithEvents ColoresPreaprobado As ISL.Controles.Colores
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtArea As ISL.Controles.Texto
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odOAReqMat As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents colorAtendido As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents colorPendiente As ISL.Controles.Colores
    Friend WithEvents colorAtendidoParcial As ISL.Controles.Colores
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents rangoFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rangoFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents fecFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecAtencion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRegReq As ISL.Controles.Boton
    Friend WithEvents ColoresPorRegularizar As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.Combo
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigoBarras As ISL.Controles.Texto
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMaterial As ISL.Controles.Texto
    Friend WithEvents btnActualizarDetalle As ISL.Controles.Boton
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cmEquipo As ISL.Controles.ComboMaestros
    Friend WithEvents mnuCotizacionProveedor As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents odRegistroInventario As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnActualizaOT As ISL.Controles.Boton
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents btnTerminarRQ As ISL.Controles.Boton
    Friend WithEvents ficDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMaterialesRequeridos As ISL.Controles.Agrupacion
    Friend WithEvents griListaMaterialRequeridos As ISL.Controles.Grilla
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agrMateriales As ISL.Controles.Agrupacion
    Friend WithEvents griListaMateriales As ISL.Controles.Grilla
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarMateriales As ISL.Controles.Boton
    Friend WithEvents txtBuscarMateriales As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrServiciosRequeridos As ISL.Controles.Agrupacion
    Friend WithEvents gbeServicios As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agrServicio As ISL.Controles.Agrupacion
    Friend WithEvents griListaServicio As ISL.Controles.Grilla
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents btnCategoria As ISL.Controles.Boton
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboCategoriaServicios As ISL.Controles.ComboMaestros
    Friend WithEvents griListaServiciosRequeridos As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents grilla_OA_Material As ISL.Controles.Grilla
    Friend WithEvents uebHistorialMaterial As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grReg_Inv As ISL.Controles.Grilla
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
