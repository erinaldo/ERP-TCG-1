<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenCompra
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
        Dim UltraGridColumn648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimiento")
        Dim UltraGridColumn668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPorAtender")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimientoMaterial")
        Dim UltraGridColumn673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn674 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Aprobacion")
        Dim UltraGridColumn675 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimientoMaterial")
        Dim UltraGridColumn676 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAAtender")
        Dim UltraGridColumn677 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn678 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn679 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn680 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadARegularizar")
        Dim UltraGridColumn681 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPorRegularizar")
        Dim UltraGridColumn682 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRegularizado")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(581)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-7)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimiento")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPorAtender")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimientoMaterial")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Aprobacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimientoMaterial")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAAtender")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadARegularizar")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPorRegularizar")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndRegularizado")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn704 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn705 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn706 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn707 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn708 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn709 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn710 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn711 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn712 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn713 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn714 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn715 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn716 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn717 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn718 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn719 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn720 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn721 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn722 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn723 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn724 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn725 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn726 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn727 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn728 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn729 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn730 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn731 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn732 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn733 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenCompra))
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn683 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn684 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCotizacion")
        Dim UltraGridColumn685 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn686 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn687 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn688 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn689 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn690 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn691 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn692 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn693 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn694 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn695 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn696 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCotizacion")
        Dim UltraGridColumn697 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn698 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMat")
        Dim UltraGridColumn699 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn700 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn701 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoCotizacion")
        Dim UltraGridColumn702 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn703 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCotizacion")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCotizacion")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PosMat")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoCotizacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn564 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn565 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn566 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn567 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn568 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn569 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn570 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn571 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn572 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn573 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn574 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimientoSer")
        Dim UltraGridColumn575 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn576 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn577 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn578 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn579 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn580 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim UltraGridColumn581 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialPendiente")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn582 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialAAtender")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn583 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn584 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn585 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn586 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn587 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn588 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn589 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn590 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn591 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn592 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSolesSinImp")
        Dim UltraGridColumn593 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraGridColumn594 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn595 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn596 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenSalidaMaterial")
        Dim UltraGridColumn597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoAdm")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Notas")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimientoSer")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialPendiente")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialAAtender")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSolesSinImp")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pos")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenSalidaMaterial")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoAdm")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Notas")
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn734 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn735 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn736 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn737 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn738 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn739 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn740 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn741 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn742 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn743 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn744 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn745 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn746 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialPendiente")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn747 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn748 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn749 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn750 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn751 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn752 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn753 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn754 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn755 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn756 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn757 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn758 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn759 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn760 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn761 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioConImp")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn762 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn763 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialAAtender")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn764 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimientoSer")
        Dim UltraGridColumn765 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn766 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDetalleMaterial")
        Dim UltraGridColumn767 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn768 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajoMaterial")
        Dim UltraGridColumn769 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn770 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn771 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn772 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn773 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoAdm")
        Dim UltraGridColumn774 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn775 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn776 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn777 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn778 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn779 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn780 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialPendiente")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSinImp")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioConImp")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialAAtender")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimientoSer")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDetalleMaterial")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenTrabajoMaterial")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoAdm")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn781 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn782 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn783 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn784 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn785 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn786 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn787 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGuia")
        Dim UltraGridColumn788 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn789 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn790 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn791 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn792 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim UltraGridColumn793 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn794 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorMaterial")
        Dim UltraGridColumn795 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorServicio")
        Dim UltraGridColumn796 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn797 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacionEmergencia")
        Dim UltraGridColumn798 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorRechazo")
        Dim UltraGridColumn799 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn800 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn801 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn802 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn803 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn804 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorDocumentoAsociado")
        Dim UltraGridColumn805 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn806 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorVariasEntregas")
        Dim UltraGridColumn807 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn808 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrdenCompra")
        Dim UltraGridColumn809 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn810 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn811 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn812 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn813 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn814 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn815 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn816 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn817 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn818 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn819 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn820 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn821 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn822 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn823 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim UltraGridColumn824 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn825 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn826 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn827 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn828 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn829 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn830 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn831 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn832 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenOrigen")
        Dim UltraGridColumn833 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenDestino")
        Dim UltraGridColumn834 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperDocAsoc")
        Dim UltraGridColumn835 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn836 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraGridColumn837 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn838 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn839 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim UltraGridColumn840 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGuia")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorMaterial")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorServicio")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacionEmergencia")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorRechazo")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorDocumentoAsociado")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorVariasEntregas")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrdenCompra")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenOrigen")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenDestino")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperDocAsoc")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenCompra")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
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
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGuia")
        Dim UltraGridColumn609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorMaterial")
        Dim UltraGridColumn614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorServicio")
        Dim UltraGridColumn615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacionEmergencia")
        Dim UltraGridColumn617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorRechazo")
        Dim UltraGridColumn618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorDocumentoAsociado")
        Dim UltraGridColumn619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorVariasEntregas")
        Dim UltraGridColumn620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrdenCompra")
        Dim UltraGridColumn623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim UltraGridColumn637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorConsignacion")
        Dim UltraGridColumn643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consignacion")
        Dim UltraGridColumn644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTipoCompra")
        Dim UltraGridColumn647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCotizacion")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Notas", 0)
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn243 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn244 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn245 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGuia")
        Dim UltraDataColumn246 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn247 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn248 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn249 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraDataColumn250 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorMaterial")
        Dim UltraDataColumn251 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorServicio")
        Dim UltraDataColumn252 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn253 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacionEmergencia")
        Dim UltraDataColumn254 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorRechazo")
        Dim UltraDataColumn255 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorDocumentoAsociado")
        Dim UltraDataColumn256 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorVariasEntregas")
        Dim UltraDataColumn257 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn258 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn259 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrdenCompra")
        Dim UltraDataColumn260 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn261 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn262 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn263 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn264 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn265 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn266 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn267 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn268 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn269 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn270 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn271 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn272 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn273 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn274 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn275 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn276 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn277 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn278 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn279 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorConsignacion")
        Dim UltraDataColumn280 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consignacion")
        Dim UltraDataColumn281 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn282 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorAprobacion")
        Dim UltraDataColumn283 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTipoCompra")
        Dim UltraDataColumn284 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCotizacion")
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
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("GenerarD")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("GenerarD")
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Factura")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Boleta")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Guía")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Factura")
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Boleta")
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Guía")
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn285 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn286 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn287 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn288 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CategoriaServicio")
        Dim UltraDataColumn289 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn290 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn291 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn292 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn293 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn294 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn295 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn296 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaRequerimientos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odRequerimientos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion14 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaMateriales = New ISL.Controles.Grilla(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion13 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkBuscaCodigo = New ISL.Controles.Chequear(Me.components)
        Me.btnListarMateriales = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtBuscarMateriales = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListadoCotizacionDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odCotizacionDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.rfFechaCotHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.rfFechaCotDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarCot = New ISL.Controles.Boton(Me.components)
        Me.cboProveedorCot = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridDetalleOCMaterial = New ISL.Controles.Grilla(Me.components)
        Me.odOCMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeListadoMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.utcListadosMateriales = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleOrdenIngreso = New ISL.Controles.Grilla(Me.components)
        Me.odDetalleOrdenIngreso = New ISL.Controles.OrigenDatos(Me.components)
        Me.griListaOrdenIngreso = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextualOI = New ISL.Controles.MenuContextual(Me.components)
        Me.TSM_Factura = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Boleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Guia = New System.Windows.Forms.ToolStripMenuItem()
        Me.odOrdenIngreso = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnModificarPrecios = New ISL.Controles.Boton(Me.components)
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodBarras = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.rdbUrgente = New System.Windows.Forms.RadioButton()
        Me.rdbNormal = New System.Windows.Forms.RadioButton()
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion16 = New ISL.Controles.Agrupacion(Me.components)
        Me.griHistorialRechazo = New ISL.Controles.Grilla(Me.components)
        Me.btnTerminarOC = New ISL.Controles.Boton(Me.components)
        Me.fecFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.fecFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.fecFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.cmdSolesDolares = New ISL.Controles.Boton(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIGV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkRuc = New ISL.Controles.Chequear(Me.components)
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPorcenIGV = New ISL.Controles.Texto(Me.components)
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.cheReqAsoc = New ISL.Controles.Chequear(Me.components)
        Me.cheEntregasParciales = New ISL.Controles.Chequear(Me.components)
        Me.cheAutoAprobar = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNotas = New ISL.Controles.Texto(Me.components)
        Me.txtObservaciones = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbNumeroOrden = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumeroOrden = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnEnviarCorreo = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion17 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipoOrdenCompra = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.cbCentro = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion18 = New ISL.Controles.Agrupacion(Me.components)
        Me.decTotalIGVNCD = New ISL.Controles.NumeroDecimal(Me.components)
        Me.fecNotaCD = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.decIGVNCD = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.decSubTotalNCD = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroNotaCD = New ISL.Controles.Texto(Me.components)
        Me.txtSreNotaCD = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.agrPercepcion = New ISL.Controles.Agrupacion(Me.components)
        Me.DecPorcentajePercepcion = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cheActivoPercepcion = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecPercepcion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecTPagar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.agrDetraccion = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecDetraer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecMontoDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNetoPagar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenCompra = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaOrdenCompra = New ISL.Controles.Grilla(Me.components)
        Me.odListaOrdenCompra = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEliminarOrden = New ISL.Controles.Boton(Me.components)
        Me.btnCambiarEstado = New ISL.Controles.Boton(Me.components)
        Me.btnRechazar = New ISL.Controles.Boton(Me.components)
        Me.btnBloquear = New ISL.Controles.Boton(Me.components)
        Me.btnHistorial = New ISL.Controles.Boton(Me.components)
        Me.btnAtenderOC = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion20 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkRuc2 = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedorL = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboEstadoOrden = New ISL.Controles.ComboMaestros(Me.components)
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboMonedaL = New ISL.Controles.ComboMaestros(Me.components)
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.rdbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.Agrupacion19 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroOrdenCompra = New ISL.Controles.Texto(Me.components)
        Me.rdbNroOrden = New System.Windows.Forms.RadioButton()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresAtendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresPreEvaluada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresRechazada = New ISL.Controles.Colores(Me.components)
        Me.ColoresTerminada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAtendidoParcialmente = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEvaluado = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficDetalleOCMateriales = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuDetalle = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea6 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea7 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea8 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.FichaTop = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage6 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.odServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprobarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuContextualReq = New ISL.Controles.MenuContextual(Me.components)
        Me.RechazarStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NumeroDecimal1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage7 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ficOrdenCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.btn_GenerarVenta = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griListaRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Agrupacion14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion14.SuspendLayout()
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion13.SuspendLayout()
        CType(Me.chkBuscaCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griListadoCotizacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCotizacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.cboProveedorCot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.gridDetalleOCMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOCMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeListadoMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeListadoMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.utcListadosMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcListadosMateriales.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.griDetalleOrdenIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleOrdenIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griListaOrdenIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextualOI.SuspendLayout()
        CType(Me.odOrdenIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion16.SuspendLayout()
        CType(Me.griHistorialRechazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcenIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheReqAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheEntregasParciales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheAutoAprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.Agrupacion17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion17.SuspendLayout()
        CType(Me.cboTipoOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion18.SuspendLayout()
        CType(Me.decTotalIGVNCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecNotaCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decIGVNCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotalNCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroNotaCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSreNotaCD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.agrPercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrPercepcion.SuspendLayout()
        CType(Me.DecPorcentajePercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheActivoPercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecPercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetraccion.SuspendLayout()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecMontoDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetoPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenCompra.SuspendLayout()
        CType(Me.griListaOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListaOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion20.SuspendLayout()
        CType(Me.chkRuc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedorL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonedaL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion19.SuspendLayout()
        CType(Me.txtNroOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresPreEvaluada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresRechazada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficDetalleOCMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalleOCMateriales.SuspendLayout()
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.FichaTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FichaTop.SuspendLayout()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.MenuContextualReq.SuspendLayout()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrdenCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griListaRequerimientos)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(583, 251)
        '
        'griListaRequerimientos
        '
        Me.griListaRequerimientos.DataSource = Me.odRequerimientos
        UltraGridColumn648.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn648.Header.Caption = "Select"
        UltraGridColumn648.Header.VisiblePosition = 1
        UltraGridColumn648.Width = 37
        UltraGridColumn649.Header.VisiblePosition = 0
        UltraGridColumn649.Hidden = True
        UltraGridColumn649.Width = 85
        UltraGridColumn650.Header.Caption = "Requerimiento"
        UltraGridColumn650.Header.VisiblePosition = 3
        UltraGridColumn650.Width = 87
        UltraGridColumn651.Header.Caption = "Codigo"
        UltraGridColumn651.Header.VisiblePosition = 4
        UltraGridColumn651.Width = 69
        UltraGridColumn652.Header.VisiblePosition = 2
        UltraGridColumn652.Hidden = True
        UltraGridColumn653.Header.VisiblePosition = 5
        UltraGridColumn653.Width = 197
        UltraGridColumn654.Header.Caption = "Unidad de medida"
        UltraGridColumn654.Header.VisiblePosition = 8
        UltraGridColumn655.Header.VisiblePosition = 9
        UltraGridColumn655.Hidden = True
        UltraGridColumn656.Header.VisiblePosition = 10
        UltraGridColumn656.Hidden = True
        UltraGridColumn657.Header.VisiblePosition = 6
        UltraGridColumn657.Width = 176
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn658.CellAppearance = Appearance1
        UltraGridColumn658.Header.VisiblePosition = 7
        UltraGridColumn658.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn659.Header.VisiblePosition = 14
        UltraGridColumn659.Hidden = True
        UltraGridColumn660.Header.VisiblePosition = 15
        UltraGridColumn660.Hidden = True
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn661.CellAppearance = Appearance2
        UltraGridColumn661.Header.VisiblePosition = 12
        UltraGridColumn661.Hidden = True
        UltraGridColumn661.Width = 61
        UltraGridColumn662.Header.VisiblePosition = 13
        UltraGridColumn662.Width = 61
        UltraGridColumn663.Header.VisiblePosition = 16
        UltraGridColumn663.Hidden = True
        UltraGridColumn664.Header.VisiblePosition = 18
        UltraGridColumn664.Hidden = True
        UltraGridColumn665.Header.VisiblePosition = 17
        UltraGridColumn665.Hidden = True
        UltraGridColumn666.Header.VisiblePosition = 19
        UltraGridColumn666.Hidden = True
        UltraGridColumn667.Header.VisiblePosition = 20
        UltraGridColumn667.Hidden = True
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn668.CellAppearance = Appearance3
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn668.Header.Appearance = Appearance4
        UltraGridColumn668.Header.Caption = "Cantidad"
        UltraGridColumn668.Header.VisiblePosition = 11
        UltraGridColumn668.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn669.Header.VisiblePosition = 21
        UltraGridColumn669.Hidden = True
        UltraGridColumn670.Header.VisiblePosition = 22
        UltraGridColumn670.Hidden = True
        UltraGridColumn671.Header.VisiblePosition = 23
        UltraGridColumn671.Hidden = True
        UltraGridColumn672.Header.Caption = "Estado"
        UltraGridColumn672.Header.VisiblePosition = 24
        UltraGridColumn672.Hidden = True
        UltraGridColumn673.Header.VisiblePosition = 25
        UltraGridColumn673.Hidden = True
        UltraGridColumn674.Header.VisiblePosition = 26
        UltraGridColumn674.Hidden = True
        UltraGridColumn675.Header.VisiblePosition = 27
        UltraGridColumn675.Hidden = True
        UltraGridColumn676.Header.VisiblePosition = 28
        UltraGridColumn676.Hidden = True
        UltraGridColumn677.Header.VisiblePosition = 29
        UltraGridColumn677.Hidden = True
        UltraGridColumn678.Header.VisiblePosition = 30
        UltraGridColumn679.Header.VisiblePosition = 31
        UltraGridColumn679.Hidden = True
        UltraGridColumn680.Header.VisiblePosition = 32
        UltraGridColumn680.Hidden = True
        UltraGridColumn681.Header.VisiblePosition = 33
        UltraGridColumn681.Hidden = True
        UltraGridColumn682.Header.VisiblePosition = 34
        UltraGridColumn682.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn648, UltraGridColumn649, UltraGridColumn650, UltraGridColumn651, UltraGridColumn652, UltraGridColumn653, UltraGridColumn654, UltraGridColumn655, UltraGridColumn656, UltraGridColumn657, UltraGridColumn658, UltraGridColumn659, UltraGridColumn660, UltraGridColumn661, UltraGridColumn662, UltraGridColumn663, UltraGridColumn664, UltraGridColumn665, UltraGridColumn666, UltraGridColumn667, UltraGridColumn668, UltraGridColumn669, UltraGridColumn670, UltraGridColumn671, UltraGridColumn672, UltraGridColumn673, UltraGridColumn674, UltraGridColumn675, UltraGridColumn676, UltraGridColumn677, UltraGridColumn678, UltraGridColumn679, UltraGridColumn680, UltraGridColumn681, UltraGridColumn682})
        Me.griListaRequerimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaRequerimientos.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.griListaRequerimientos.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.griListaRequerimientos.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListaRequerimientos.DisplayLayout.GroupByBox.Hidden = True
        Me.griListaRequerimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaRequerimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRequerimientos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRequerimientos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaRequerimientos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Me.griListaRequerimientos.DisplayLayout.Override.CellAppearance = Appearance5
        Me.griListaRequerimientos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaRequerimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaRequerimientos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaRequerimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaRequerimientos.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.Button
        Me.griListaRequerimientos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaRequerimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Me.griListaRequerimientos.DisplayLayout.Override.RowAppearance = Appearance6
        Me.griListaRequerimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaRequerimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaRequerimientos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaRequerimientos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaRequerimientos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaRequerimientos.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaRequerimientos.Location = New System.Drawing.Point(0, 0)
        Me.griListaRequerimientos.Name = "griListaRequerimientos"
        Me.griListaRequerimientos.Size = New System.Drawing.Size(583, 251)
        Me.griListaRequerimientos.TabIndex = 0
        Me.griListaRequerimientos.TabStop = False
        Me.griListaRequerimientos.Tag = ""
        '
        'odRequerimientos
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn33.DataType = GetType(Double)
        UltraDataColumn34.DataType = GetType(Double)
        UltraDataColumn35.DataType = GetType(Boolean)
        Me.odRequerimientos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion14)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion13)
        Me.UltraTabPageControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(583, 251)
        '
        'Agrupacion14
        '
        Me.Agrupacion14.Controls.Add(Me.griListaMateriales)
        Me.Agrupacion14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion14.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion14.Location = New System.Drawing.Point(0, 48)
        Me.Agrupacion14.Name = "Agrupacion14"
        Me.Agrupacion14.Size = New System.Drawing.Size(583, 203)
        Me.Agrupacion14.TabIndex = 249
        Me.Agrupacion14.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaMateriales
        '
        Me.griListaMateriales.DataSource = Me.odMaterial
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaMateriales.DisplayLayout.Appearance = Appearance7
        UltraGridColumn704.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn704.Header.Appearance = Appearance8
        UltraGridColumn704.Header.VisiblePosition = 0
        UltraGridColumn704.Width = 27
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn705.Header.Appearance = Appearance9
        UltraGridColumn705.Header.VisiblePosition = 1
        UltraGridColumn705.Hidden = True
        UltraGridColumn706.Header.VisiblePosition = 9
        UltraGridColumn706.Hidden = True
        UltraGridColumn707.Header.VisiblePosition = 3
        UltraGridColumn707.Hidden = True
        UltraGridColumn707.Width = 320
        UltraGridColumn708.Header.Caption = "Unidad de medida"
        UltraGridColumn708.Header.VisiblePosition = 19
        UltraGridColumn708.Width = 114
        UltraGridColumn709.Header.VisiblePosition = 26
        UltraGridColumn709.Hidden = True
        UltraGridColumn710.Header.VisiblePosition = 4
        UltraGridColumn710.Width = 254
        UltraGridColumn711.Header.VisiblePosition = 6
        UltraGridColumn711.Hidden = True
        UltraGridColumn712.Header.VisiblePosition = 7
        UltraGridColumn712.Hidden = True
        UltraGridColumn713.Header.VisiblePosition = 8
        UltraGridColumn713.Hidden = True
        UltraGridColumn714.Header.VisiblePosition = 10
        UltraGridColumn714.Hidden = True
        UltraGridColumn715.Header.VisiblePosition = 11
        UltraGridColumn715.Hidden = True
        UltraGridColumn716.Header.VisiblePosition = 12
        UltraGridColumn716.Hidden = True
        UltraGridColumn717.Header.VisiblePosition = 13
        UltraGridColumn717.Hidden = True
        UltraGridColumn718.Header.VisiblePosition = 14
        UltraGridColumn718.Hidden = True
        UltraGridColumn719.Header.VisiblePosition = 15
        UltraGridColumn719.Hidden = True
        UltraGridColumn720.Header.VisiblePosition = 20
        UltraGridColumn720.Hidden = True
        UltraGridColumn721.Header.VisiblePosition = 22
        UltraGridColumn721.Hidden = True
        UltraGridColumn722.Header.VisiblePosition = 23
        UltraGridColumn722.Hidden = True
        UltraGridColumn723.Header.VisiblePosition = 24
        UltraGridColumn723.Hidden = True
        UltraGridColumn724.Header.VisiblePosition = 25
        UltraGridColumn724.Hidden = True
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn725.Header.Appearance = Appearance10
        UltraGridColumn725.Header.VisiblePosition = 5
        UltraGridColumn725.Hidden = True
        UltraGridColumn726.Header.VisiblePosition = 21
        UltraGridColumn726.Hidden = True
        UltraGridColumn727.Header.VisiblePosition = 18
        UltraGridColumn728.Header.Caption = "Costo"
        UltraGridColumn728.Header.VisiblePosition = 27
        UltraGridColumn729.Header.Caption = ":"
        UltraGridColumn729.Header.VisiblePosition = 2
        UltraGridColumn730.Header.VisiblePosition = 16
        UltraGridColumn730.Hidden = True
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn731.Header.Appearance = Appearance11
        UltraGridColumn731.Header.VisiblePosition = 17
        UltraGridColumn732.Header.VisiblePosition = 28
        UltraGridColumn732.Hidden = True
        UltraGridColumn733.Header.VisiblePosition = 29
        UltraGridColumn733.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn704, UltraGridColumn705, UltraGridColumn706, UltraGridColumn707, UltraGridColumn708, UltraGridColumn709, UltraGridColumn710, UltraGridColumn711, UltraGridColumn712, UltraGridColumn713, UltraGridColumn714, UltraGridColumn715, UltraGridColumn716, UltraGridColumn717, UltraGridColumn718, UltraGridColumn719, UltraGridColumn720, UltraGridColumn721, UltraGridColumn722, UltraGridColumn723, UltraGridColumn724, UltraGridColumn725, UltraGridColumn726, UltraGridColumn727, UltraGridColumn728, UltraGridColumn729, UltraGridColumn730, UltraGridColumn731, UltraGridColumn732, UltraGridColumn733})
        Me.griListaMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaMateriales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.GroupByBox.Appearance = Appearance12
        Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance13
        Me.griListaMateriales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.GroupByBox.Hidden = True
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance14.BackColor2 = System.Drawing.SystemColors.Control
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.PromptAppearance = Appearance14
        Me.griListaMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaMateriales.DisplayLayout.MaxRowScrollRegions = 1
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaMateriales.DisplayLayout.Override.ActiveCellAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.SystemColors.Highlight
        Appearance16.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaMateriales.DisplayLayout.Override.ActiveRowAppearance = Appearance16
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Appearance18.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaMateriales.DisplayLayout.Override.CellAppearance = Appearance18
        Me.griListaMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griListaMateriales.DisplayLayout.Override.CellPadding = 0
        Appearance19.BackColor = System.Drawing.SystemColors.Control
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.GroupByRowAppearance = Appearance19
        Appearance20.TextHAlignAsString = "Left"
        Me.griListaMateriales.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.griListaMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaMateriales.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Me.griListaMateriales.DisplayLayout.Override.RowAppearance = Appearance21
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaMateriales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaMateriales.DisplayLayout.Override.TemplateAddRowAppearance = Appearance22
        Me.griListaMateriales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaMateriales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaMateriales.Location = New System.Drawing.Point(2, 2)
        Me.griListaMateriales.Name = "griListaMateriales"
        Me.griListaMateriales.Size = New System.Drawing.Size(579, 199)
        Me.griListaMateriales.TabIndex = 10
        Me.griListaMateriales.Text = "Grilla2"
        '
        'odMaterial
        '
        UltraDataColumn36.DataType = GetType(Boolean)
        UltraDataColumn55.DefaultValue = "False"
        UltraDataColumn57.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65})
        '
        'Agrupacion13
        '
        Me.Agrupacion13.Controls.Add(Me.chkBuscaCodigo)
        Me.Agrupacion13.Controls.Add(Me.btnListarMateriales)
        Me.Agrupacion13.Controls.Add(Me.txtBuscarMateriales)
        Me.Agrupacion13.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion13.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion13.Name = "Agrupacion13"
        Me.Agrupacion13.Size = New System.Drawing.Size(583, 48)
        Me.Agrupacion13.TabIndex = 248
        Me.Agrupacion13.Text = "Agregar materiales:"
        Me.Agrupacion13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkBuscaCodigo
        '
        Me.chkBuscaCodigo.BackColor = System.Drawing.Color.Transparent
        Me.chkBuscaCodigo.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkBuscaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuscaCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkBuscaCodigo.Location = New System.Drawing.Point(436, 22)
        Me.chkBuscaCodigo.Name = "chkBuscaCodigo"
        Me.chkBuscaCodigo.Size = New System.Drawing.Size(116, 20)
        Me.chkBuscaCodigo.TabIndex = 236
        Me.chkBuscaCodigo.Text = "Codigo Material"
        '
        'btnListarMateriales
        '
        Appearance23.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnListarMateriales.Appearance = Appearance23
        Me.btnListarMateriales.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMateriales.ImageList = Me.imagenes
        Me.btnListarMateriales.Location = New System.Drawing.Point(400, 19)
        Me.btnListarMateriales.Name = "btnListarMateriales"
        Me.btnListarMateriales.Size = New System.Drawing.Size(30, 25)
        Me.btnListarMateriales.TabIndex = 235
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
        'txtBuscarMateriales
        '
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Appearance = Appearance24
        Me.txtBuscarMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBuscarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Location = New System.Drawing.Point(66, 22)
        Me.txtBuscarMateriales.MaxLength = 200
        Me.txtBuscarMateriales.Name = "txtBuscarMateriales"
        Me.txtBuscarMateriales.Size = New System.Drawing.Size(323, 21)
        Me.txtBuscarMateriales.TabIndex = 232
        '
        'Etiqueta6
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance25
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(20, 24)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta6.TabIndex = 228
        Me.Etiqueta6.Text = "Buscar:"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griListadoCotizacionDetalle)
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(583, 251)
        '
        'griListadoCotizacionDetalle
        '
        Me.griListadoCotizacionDetalle.DataSource = Me.odCotizacionDetalle
        UltraGridColumn683.Header.VisiblePosition = 0
        UltraGridColumn683.Hidden = True
        UltraGridColumn683.Width = 85
        UltraGridColumn684.Header.VisiblePosition = 1
        UltraGridColumn684.Hidden = True
        UltraGridColumn685.Header.VisiblePosition = 2
        UltraGridColumn685.Hidden = True
        UltraGridColumn686.Header.VisiblePosition = 6
        UltraGridColumn686.Width = 253
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn687.CellAppearance = Appearance26
        UltraGridColumn687.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn687.Header.VisiblePosition = 7
        UltraGridColumn687.MaskInput = "{double:9.4}"
        UltraGridColumn688.Header.VisiblePosition = 14
        UltraGridColumn688.Hidden = True
        UltraGridColumn689.Header.VisiblePosition = 13
        UltraGridColumn689.Hidden = True
        UltraGridColumn690.Header.VisiblePosition = 15
        UltraGridColumn690.Hidden = True
        UltraGridColumn691.Header.VisiblePosition = 12
        UltraGridColumn691.Hidden = True
        UltraGridColumn691.Width = 180
        UltraGridColumn692.Header.Caption = "Unidad de medida"
        UltraGridColumn692.Header.VisiblePosition = 11
        UltraGridColumn693.Header.VisiblePosition = 9
        UltraGridColumn693.Hidden = True
        UltraGridColumn693.Width = 305
        UltraGridColumn694.Header.VisiblePosition = 10
        UltraGridColumn694.Width = 257
        UltraGridColumn695.Header.Caption = "Codigo"
        UltraGridColumn695.Header.VisiblePosition = 5
        UltraGridColumn696.Header.VisiblePosition = 16
        UltraGridColumn696.Hidden = True
        UltraGridColumn697.Header.VisiblePosition = 17
        UltraGridColumn697.Hidden = True
        UltraGridColumn698.Header.VisiblePosition = 18
        UltraGridColumn698.Hidden = True
        UltraGridColumn699.Header.VisiblePosition = 19
        UltraGridColumn699.Hidden = True
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn700.CellAppearance = Appearance27
        UltraGridColumn700.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn700.Header.VisiblePosition = 8
        UltraGridColumn700.Hidden = True
        UltraGridColumn700.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn701.Header.Caption = "Cotización"
        UltraGridColumn701.Header.VisiblePosition = 4
        UltraGridColumn702.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn702.Header.VisiblePosition = 3
        UltraGridColumn702.Width = 37
        UltraGridColumn703.Header.VisiblePosition = 20
        UltraGridColumn703.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn683, UltraGridColumn684, UltraGridColumn685, UltraGridColumn686, UltraGridColumn687, UltraGridColumn688, UltraGridColumn689, UltraGridColumn690, UltraGridColumn691, UltraGridColumn692, UltraGridColumn693, UltraGridColumn694, UltraGridColumn695, UltraGridColumn696, UltraGridColumn697, UltraGridColumn698, UltraGridColumn699, UltraGridColumn700, UltraGridColumn701, UltraGridColumn702, UltraGridColumn703})
        Me.griListadoCotizacionDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListadoCotizacionDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griListadoCotizacionDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellAppearance = Appearance28
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.Button
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowAppearance = Appearance29
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListadoCotizacionDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListadoCotizacionDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListadoCotizacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListadoCotizacionDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListadoCotizacionDetalle.Location = New System.Drawing.Point(0, 33)
        Me.griListadoCotizacionDetalle.Name = "griListadoCotizacionDetalle"
        Me.griListadoCotizacionDetalle.Size = New System.Drawing.Size(583, 218)
        Me.griListadoCotizacionDetalle.TabIndex = 5
        Me.griListadoCotizacionDetalle.Tag = ""
        '
        'odCotizacionDetalle
        '
        UltraDataColumn68.DataType = GetType(Date)
        UltraDataColumn85.DataType = GetType(Boolean)
        UltraDataColumn85.DefaultValue = False
        Me.odCotizacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86})
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.rfFechaCotHasta)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion9.Controls.Add(Me.rfFechaCotDesde)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion9.Controls.Add(Me.btnBuscarCot)
        Me.Agrupacion9.Controls.Add(Me.cboProveedorCot)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(583, 33)
        Me.Agrupacion9.TabIndex = 4
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rfFechaCotHasta
        '
        Me.rfFechaCotHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaCotHasta.Location = New System.Drawing.Point(155, 6)
        Me.rfFechaCotHasta.Name = "rfFechaCotHasta"
        Me.rfFechaCotHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaCotHasta.TabIndex = 285
        '
        'Etiqueta3
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance30
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(136, 9)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(17, 15)
        Me.Etiqueta3.TabIndex = 284
        Me.Etiqueta3.Text = "Al:"
        '
        'rfFechaCotDesde
        '
        Me.rfFechaCotDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaCotDesde.Location = New System.Drawing.Point(33, 6)
        Me.rfFechaCotDesde.Name = "rfFechaCotDesde"
        Me.rfFechaCotDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaCotDesde.TabIndex = 283
        '
        'Etiqueta2
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance31
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 10)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(24, 15)
        Me.Etiqueta2.TabIndex = 282
        Me.Etiqueta2.Text = "Del:"
        '
        'btnBuscarCot
        '
        Appearance32.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnBuscarCot.Appearance = Appearance32
        Me.btnBuscarCot.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCot.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarCot.Location = New System.Drawing.Point(544, 3)
        Me.btnBuscarCot.Name = "btnBuscarCot"
        Me.btnBuscarCot.Size = New System.Drawing.Size(30, 27)
        Me.btnBuscarCot.TabIndex = 236
        '
        'cboProveedorCot
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cboProveedorCot.Appearance = Appearance33
        Me.cboProveedorCot.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance34.Image = 7
        EditorButton1.Appearance = Appearance34
        Me.cboProveedorCot.ButtonsRight.Add(EditorButton1)
        Me.cboProveedorCot.DisplayMember = "Nombre"
        Me.cboProveedorCot.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedorCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorCot.ForeColor = System.Drawing.Color.Black
        Me.cboProveedorCot.ImageList = Me.imagenes
        Me.cboProveedorCot.Location = New System.Drawing.Point(341, 6)
        Me.cboProveedorCot.Name = "cboProveedorCot"
        Me.cboProveedorCot.Size = New System.Drawing.Size(191, 21)
        Me.cboProveedorCot.TabIndex = 281
        Me.cboProveedorCot.ValueMember = "Id"
        '
        'UltraLabel2
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance35
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(280, 10)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel2.TabIndex = 280
        Me.UltraLabel2.Text = "Proveedor:"
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.gridDetalleOCMaterial)
        Me.UltraTabPageControl12.Controls.Add(Me.gbeListadoMateriales)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(1347, 280)
        '
        'gridDetalleOCMaterial
        '
        Me.gridDetalleOCMaterial.DataSource = Me.odOCMaterial
        UltraGridColumn563.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn563.Header.Caption = ""
        UltraGridColumn563.Header.VisiblePosition = 0
        UltraGridColumn563.Width = 27
        UltraGridColumn564.Header.VisiblePosition = 1
        UltraGridColumn564.Hidden = True
        UltraGridColumn565.Header.VisiblePosition = 2
        UltraGridColumn565.Hidden = True
        UltraGridColumn566.Header.VisiblePosition = 3
        UltraGridColumn566.Hidden = True
        UltraGridColumn567.Header.Caption = "Codigo"
        UltraGridColumn567.Header.VisiblePosition = 4
        UltraGridColumn567.Width = 79
        UltraGridColumn568.Header.VisiblePosition = 5
        UltraGridColumn568.Width = 307
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn569.CellAppearance = Appearance36
        UltraGridColumn569.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn569.Format = "#,###,###,##0.0000"
        UltraGridColumn569.Header.Caption = "Cantidad"
        UltraGridColumn569.Header.VisiblePosition = 7
        UltraGridColumn569.MaskInput = "{LOC}nnnnn.nnnn"
        UltraGridColumn569.Width = 73
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn570.CellAppearance = Appearance37
        UltraGridColumn570.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn570.Format = "#,###,###,##0.0000"
        UltraGridColumn570.Header.Caption = "PU S/Imp"
        UltraGridColumn570.Header.VisiblePosition = 11
        UltraGridColumn570.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn570.Width = 84
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn571.CellAppearance = Appearance38
        UltraGridColumn571.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn571.Format = "#,###,###,##0.0000"
        UltraGridColumn571.Header.Caption = "PU C/Imp"
        UltraGridColumn571.Header.VisiblePosition = 12
        UltraGridColumn571.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn571.Width = 86
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance39.FontData.BoldAsString = "True"
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn572.CellAppearance = Appearance39
        UltraGridColumn572.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn572.Format = "#,###,###,##0.0000"
        UltraGridColumn572.Header.VisiblePosition = 13
        UltraGridColumn572.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn572.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn572.Width = 99
        UltraGridColumn573.Header.Caption = "N° Req."
        UltraGridColumn573.Header.VisiblePosition = 20
        UltraGridColumn573.Hidden = True
        UltraGridColumn574.Header.Caption = "Nº ReqSer."
        UltraGridColumn574.Header.VisiblePosition = 19
        UltraGridColumn574.Hidden = True
        UltraGridColumn575.Header.VisiblePosition = 16
        UltraGridColumn575.Hidden = True
        UltraGridColumn576.Header.VisiblePosition = 21
        UltraGridColumn576.Hidden = True
        UltraGridColumn577.Header.Caption = "Almacen"
        UltraGridColumn577.Header.VisiblePosition = 17
        UltraGridColumn577.Width = 182
        UltraGridColumn578.Header.VisiblePosition = 18
        UltraGridColumn578.Hidden = True
        UltraGridColumn578.Width = 217
        Appearance40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn579.CellAppearance = Appearance40
        UltraGridColumn579.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn579.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn579.Header.VisiblePosition = 23
        UltraGridColumn579.Width = 173
        UltraGridColumn580.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn580.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn580.Header.Caption = "Igv"
        UltraGridColumn580.Header.VisiblePosition = 9
        UltraGridColumn580.Width = 48
        UltraGridColumn581.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn581.CellAppearance = Appearance41
        Appearance42.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        UltraGridColumn581.CellButtonAppearance = Appearance42
        UltraGridColumn581.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn581.Header.Caption = "Pendiente"
        UltraGridColumn581.Header.VisiblePosition = 14
        UltraGridColumn581.MaskInput = "{LOC}nnnnn.nnnn"
        UltraGridColumn581.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn581.Width = 85
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn582.CellAppearance = Appearance43
        UltraGridColumn582.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn582.Header.Caption = "Atender"
        UltraGridColumn582.Header.VisiblePosition = 15
        UltraGridColumn582.MaskInput = "{LOC}nnnnn.nnnn"
        UltraGridColumn582.Width = 76
        UltraGridColumn583.Header.VisiblePosition = 24
        UltraGridColumn583.Hidden = True
        UltraGridColumn584.Header.VisiblePosition = 25
        UltraGridColumn584.Hidden = True
        UltraGridColumn585.Header.Caption = "Unid. Med."
        UltraGridColumn585.Header.VisiblePosition = 6
        UltraGridColumn585.Width = 91
        UltraGridColumn586.Header.Caption = "Unid. Medida"
        UltraGridColumn586.Header.VisiblePosition = 8
        UltraGridColumn586.Hidden = True
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn587.CellAppearance = Appearance44
        UltraGridColumn587.Header.VisiblePosition = 26
        UltraGridColumn587.Hidden = True
        UltraGridColumn588.Header.VisiblePosition = 27
        UltraGridColumn588.Hidden = True
        UltraGridColumn589.Header.VisiblePosition = 28
        UltraGridColumn589.Hidden = True
        UltraGridColumn590.Header.VisiblePosition = 29
        UltraGridColumn590.Hidden = True
        UltraGridColumn591.Header.VisiblePosition = 30
        UltraGridColumn591.Hidden = True
        UltraGridColumn592.Header.VisiblePosition = 31
        UltraGridColumn592.Hidden = True
        UltraGridColumn592.MaskInput = "{LOC}nnnnnnnnnn.nnnn"
        UltraGridColumn593.Header.VisiblePosition = 32
        UltraGridColumn593.Hidden = True
        UltraGridColumn593.MaskInput = "{LOC}nnnnnnnnnn.nnnn"
        UltraGridColumn594.Header.VisiblePosition = 33
        UltraGridColumn594.Hidden = True
        UltraGridColumn595.Header.VisiblePosition = 34
        UltraGridColumn595.Hidden = True
        UltraGridColumn596.Header.VisiblePosition = 35
        UltraGridColumn596.Hidden = True
        UltraGridColumn597.Header.Caption = "Sub-Almacén"
        UltraGridColumn597.Header.VisiblePosition = 22
        UltraGridColumn597.Width = 223
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance45
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2.Format = "#,###,###,##0.0000"
        UltraGridColumn2.Header.VisiblePosition = 10
        UltraGridColumn2.MaskInput = "{double:9.4}"
        UltraGridColumn2.Width = 82
        UltraGridColumn5.Header.VisiblePosition = 36
        UltraGridColumn5.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn563, UltraGridColumn564, UltraGridColumn565, UltraGridColumn566, UltraGridColumn567, UltraGridColumn568, UltraGridColumn569, UltraGridColumn570, UltraGridColumn571, UltraGridColumn572, UltraGridColumn573, UltraGridColumn574, UltraGridColumn575, UltraGridColumn576, UltraGridColumn577, UltraGridColumn578, UltraGridColumn579, UltraGridColumn580, UltraGridColumn581, UltraGridColumn582, UltraGridColumn583, UltraGridColumn584, UltraGridColumn585, UltraGridColumn586, UltraGridColumn587, UltraGridColumn588, UltraGridColumn589, UltraGridColumn590, UltraGridColumn591, UltraGridColumn592, UltraGridColumn593, UltraGridColumn594, UltraGridColumn595, UltraGridColumn596, UltraGridColumn597, UltraGridColumn2, UltraGridColumn5})
        Me.gridDetalleOCMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.gridDetalleOCMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDetalleOCMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance46.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance46.BorderColor = System.Drawing.SystemColors.Window
        Me.gridDetalleOCMaterial.DisplayLayout.GroupByBox.Appearance = Appearance46
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDetalleOCMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance47
        Me.gridDetalleOCMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDetalleOCMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance48.BackColor2 = System.Drawing.SystemColors.Control
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance48.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDetalleOCMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance48
        Me.gridDetalleOCMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDetalleOCMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gridDetalleOCMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance49
        Appearance50.BackColor = System.Drawing.SystemColors.Highlight
        Appearance50.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.gridDetalleOCMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance50
        Me.gridDetalleOCMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleOCMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleOCMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDetalleOCMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance51.BackColor = System.Drawing.SystemColors.Window
        Me.gridDetalleOCMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance51
        Appearance52.BorderColor = System.Drawing.Color.Silver
        Appearance52.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridDetalleOCMaterial.DisplayLayout.Override.CellAppearance = Appearance52
        Me.gridDetalleOCMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDetalleOCMaterial.DisplayLayout.Override.CellPadding = 0
        Me.gridDetalleOCMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDetalleOCMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDetalleOCMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance53.BackColor = System.Drawing.SystemColors.Control
        Appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance53.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance53.BorderColor = System.Drawing.SystemColors.Window
        Me.gridDetalleOCMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance53
        Appearance54.TextHAlignAsString = "Center"
        Me.gridDetalleOCMaterial.DisplayLayout.Override.HeaderAppearance = Appearance54
        Me.gridDetalleOCMaterial.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.gridDetalleOCMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Appearance55.BorderColor = System.Drawing.Color.Silver
        Me.gridDetalleOCMaterial.DisplayLayout.Override.RowAppearance = Appearance55
        Me.gridDetalleOCMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDetalleOCMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDetalleOCMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleOCMaterial.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance56.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridDetalleOCMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance56
        Me.gridDetalleOCMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridDetalleOCMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridDetalleOCMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridDetalleOCMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetalleOCMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetalleOCMaterial.Location = New System.Drawing.Point(0, 0)
        Me.gridDetalleOCMaterial.Name = "gridDetalleOCMaterial"
        Me.gridDetalleOCMaterial.Size = New System.Drawing.Size(739, 280)
        Me.gridDetalleOCMaterial.TabIndex = 0
        Me.gridDetalleOCMaterial.TabStop = False
        Me.gridDetalleOCMaterial.Text = "Grilla2"
        '
        'odOCMaterial
        '
        UltraDataColumn87.DataType = GetType(Boolean)
        UltraDataColumn87.DefaultValue = False
        UltraDataColumn93.DataType = GetType(Double)
        UltraDataColumn96.DataType = GetType(Double)
        UltraDataColumn104.DataType = GetType(Boolean)
        UltraDataColumn104.DefaultValue = False
        UltraDataColumn105.DataType = GetType(Decimal)
        UltraDataColumn122.DataType = GetType(Double)
        Me.odOCMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123})
        '
        'gbeListadoMateriales
        '
        Me.gbeListadoMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeListadoMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeListadoMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeListadoMateriales.ExpandedSize = New System.Drawing.Size(608, 280)
        Me.gbeListadoMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeListadoMateriales.Location = New System.Drawing.Point(739, 0)
        Me.gbeListadoMateriales.Name = "gbeListadoMateriales"
        Me.gbeListadoMateriales.Size = New System.Drawing.Size(608, 280)
        Me.gbeListadoMateriales.TabIndex = 1
        Me.gbeListadoMateriales.TabStop = False
        Me.gbeListadoMateriales.Text = " Materiales"
        Me.gbeListadoMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.utcListadosMateriales)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(585, 274)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'utcListadosMateriales
        '
        Me.utcListadosMateriales.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.utcListadosMateriales.Controls.Add(Me.UltraTabPageControl5)
        Me.utcListadosMateriales.Controls.Add(Me.UltraTabPageControl6)
        Me.utcListadosMateriales.Controls.Add(Me.UltraTabPageControl3)
        Me.utcListadosMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcListadosMateriales.Location = New System.Drawing.Point(0, 0)
        Me.utcListadosMateriales.Name = "utcListadosMateriales"
        Me.utcListadosMateriales.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.utcListadosMateriales.Size = New System.Drawing.Size(585, 274)
        Me.utcListadosMateriales.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.utcListadosMateriales.TabIndex = 244
        UltraTab6.Key = "0"
        UltraTab6.TabPage = Me.UltraTabPageControl5
        UltraTab6.Text = "Requerimientos"
        UltraTab7.Key = "1"
        UltraTab7.TabPage = Me.UltraTabPageControl3
        UltraTab7.Text = "Materiales"
        UltraTab11.Key = "2"
        UltraTab11.TabPage = Me.UltraTabPageControl6
        UltraTab11.Text = "Cotizaciones"
        Me.utcListadosMateriales.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7, UltraTab11})
        Me.utcListadosMateriales.TabStop = False
        Me.utcListadosMateriales.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(583, 251)
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.griDetalleOrdenIngreso)
        Me.UltraTabPageControl13.Controls.Add(Me.griListaOrdenIngreso)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(1347, 280)
        '
        'griDetalleOrdenIngreso
        '
        Me.griDetalleOrdenIngreso.DataSource = Me.odDetalleOrdenIngreso
        Appearance57.BackColor = System.Drawing.SystemColors.Window
        Appearance57.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalleOrdenIngreso.DisplayLayout.Appearance = Appearance57
        UltraGridColumn734.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance58.TextHAlignAsString = "Center"
        UltraGridColumn734.Header.Appearance = Appearance58
        UltraGridColumn734.Header.VisiblePosition = 0
        UltraGridColumn734.Hidden = True
        UltraGridColumn734.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn734.Width = 65
        Appearance59.TextHAlignAsString = "Center"
        UltraGridColumn735.Header.Appearance = Appearance59
        UltraGridColumn735.Header.VisiblePosition = 1
        UltraGridColumn735.Hidden = True
        Appearance60.TextHAlignAsString = "Center"
        UltraGridColumn736.Header.Appearance = Appearance60
        UltraGridColumn736.Header.VisiblePosition = 2
        UltraGridColumn736.Hidden = True
        Appearance61.TextHAlignAsString = "Center"
        UltraGridColumn737.Header.Appearance = Appearance61
        UltraGridColumn737.Header.VisiblePosition = 3
        UltraGridColumn737.Hidden = True
        Appearance62.TextHAlignAsString = "Left"
        UltraGridColumn738.CellAppearance = Appearance62
        Appearance63.TextHAlignAsString = "Center"
        UltraGridColumn738.Header.Appearance = Appearance63
        UltraGridColumn738.Header.Caption = "Codigo"
        UltraGridColumn738.Header.VisiblePosition = 4
        UltraGridColumn738.Width = 116
        Appearance64.TextHAlignAsString = "Left"
        UltraGridColumn739.CellAppearance = Appearance64
        Appearance65.TextHAlignAsString = "Center"
        UltraGridColumn739.Header.Appearance = Appearance65
        UltraGridColumn739.Header.VisiblePosition = 5
        UltraGridColumn739.Width = 270
        Appearance66.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn740.CellAppearance = Appearance66
        UltraGridColumn740.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance67.TextHAlignAsString = "Center"
        UltraGridColumn740.Header.Appearance = Appearance67
        UltraGridColumn740.Header.Caption = "Cantidad"
        UltraGridColumn740.Header.VisiblePosition = 7
        UltraGridColumn740.MaskInput = "{double:9.4}"
        Appearance68.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn741.CellAppearance = Appearance68
        UltraGridColumn741.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance69.TextHAlignAsString = "Center"
        UltraGridColumn741.Header.Appearance = Appearance69
        UltraGridColumn741.Header.Caption = "Precio Unitario"
        UltraGridColumn741.Header.VisiblePosition = 9
        UltraGridColumn741.MaskInput = "{double:9.4}"
        Appearance70.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance70.TextHAlignAsString = "Right"
        UltraGridColumn742.CellAppearance = Appearance70
        Appearance71.TextHAlignAsString = "Center"
        UltraGridColumn742.Header.Appearance = Appearance71
        UltraGridColumn742.Header.Caption = "Valor Venta"
        UltraGridColumn742.Header.VisiblePosition = 10
        UltraGridColumn742.MaskInput = "{double:9.4}"
        UltraGridColumn742.Width = 97
        Appearance72.TextHAlignAsString = "Center"
        UltraGridColumn743.Header.Appearance = Appearance72
        UltraGridColumn743.Header.Caption = "Almacen"
        UltraGridColumn743.Header.VisiblePosition = 12
        UltraGridColumn743.Hidden = True
        UltraGridColumn743.Width = 225
        Appearance73.TextHAlignAsString = "Center"
        UltraGridColumn744.Header.Appearance = Appearance73
        UltraGridColumn744.Header.VisiblePosition = 11
        UltraGridColumn744.Width = 179
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn745.Header.Appearance = Appearance74
        UltraGridColumn745.Header.VisiblePosition = 13
        UltraGridColumn745.Hidden = True
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn746.Header.Appearance = Appearance75
        UltraGridColumn746.Header.VisiblePosition = 14
        UltraGridColumn746.Hidden = True
        Appearance76.TextHAlignAsString = "Center"
        UltraGridColumn747.Header.Appearance = Appearance76
        UltraGridColumn747.Header.VisiblePosition = 15
        UltraGridColumn747.Hidden = True
        Appearance77.TextHAlignAsString = "Center"
        UltraGridColumn748.Header.Appearance = Appearance77
        UltraGridColumn748.Header.VisiblePosition = 16
        UltraGridColumn748.Hidden = True
        Appearance78.TextHAlignAsString = "Center"
        UltraGridColumn749.Header.Appearance = Appearance78
        UltraGridColumn749.Header.VisiblePosition = 17
        UltraGridColumn749.Hidden = True
        Appearance79.TextHAlignAsString = "Center"
        UltraGridColumn750.Header.Appearance = Appearance79
        UltraGridColumn750.Header.VisiblePosition = 18
        UltraGridColumn750.Hidden = True
        Appearance80.TextHAlignAsString = "Center"
        UltraGridColumn751.Header.Appearance = Appearance80
        UltraGridColumn751.Header.Caption = "Unid. Med."
        UltraGridColumn751.Header.VisiblePosition = 6
        UltraGridColumn751.Width = 106
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn752.Header.Appearance = Appearance81
        UltraGridColumn752.Header.VisiblePosition = 19
        UltraGridColumn752.Hidden = True
        Appearance82.TextHAlignAsString = "Center"
        UltraGridColumn753.Header.Appearance = Appearance82
        UltraGridColumn753.Header.Caption = "Unidad Medida"
        UltraGridColumn753.Header.VisiblePosition = 8
        UltraGridColumn753.Hidden = True
        Appearance83.TextHAlignAsString = "Center"
        UltraGridColumn754.Header.Appearance = Appearance83
        UltraGridColumn754.Header.VisiblePosition = 20
        UltraGridColumn754.Hidden = True
        Appearance84.TextHAlignAsString = "Center"
        UltraGridColumn755.Header.Appearance = Appearance84
        UltraGridColumn755.Header.VisiblePosition = 21
        UltraGridColumn755.Hidden = True
        Appearance85.TextHAlignAsString = "Center"
        UltraGridColumn756.Header.Appearance = Appearance85
        UltraGridColumn756.Header.VisiblePosition = 22
        UltraGridColumn756.Hidden = True
        Appearance86.TextHAlignAsString = "Center"
        UltraGridColumn757.Header.Appearance = Appearance86
        UltraGridColumn757.Header.VisiblePosition = 23
        UltraGridColumn757.Hidden = True
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn758.Header.Appearance = Appearance87
        UltraGridColumn758.Header.VisiblePosition = 24
        UltraGridColumn758.Hidden = True
        Appearance88.TextHAlignAsString = "Center"
        UltraGridColumn759.Header.Appearance = Appearance88
        UltraGridColumn759.Header.VisiblePosition = 25
        UltraGridColumn759.Hidden = True
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn760.Header.Appearance = Appearance89
        UltraGridColumn760.Header.VisiblePosition = 26
        UltraGridColumn760.Hidden = True
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn761.Header.Appearance = Appearance90
        UltraGridColumn761.Header.VisiblePosition = 27
        UltraGridColumn761.Hidden = True
        Appearance91.TextHAlignAsString = "Center"
        UltraGridColumn762.Header.Appearance = Appearance91
        UltraGridColumn762.Header.VisiblePosition = 28
        UltraGridColumn762.Hidden = True
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn763.Header.Appearance = Appearance92
        UltraGridColumn763.Header.VisiblePosition = 29
        UltraGridColumn763.Hidden = True
        UltraGridColumn764.Header.VisiblePosition = 30
        UltraGridColumn764.Hidden = True
        UltraGridColumn765.Header.VisiblePosition = 31
        UltraGridColumn765.Hidden = True
        UltraGridColumn766.Header.VisiblePosition = 32
        UltraGridColumn766.Hidden = True
        UltraGridColumn767.Header.VisiblePosition = 33
        UltraGridColumn767.Hidden = True
        UltraGridColumn768.Header.VisiblePosition = 34
        UltraGridColumn768.Hidden = True
        UltraGridColumn769.Header.VisiblePosition = 35
        UltraGridColumn769.Hidden = True
        Appearance93.TextHAlignAsString = "Center"
        UltraGridColumn770.Header.Appearance = Appearance93
        UltraGridColumn770.Header.Caption = "SubAlmacen"
        UltraGridColumn770.Header.VisiblePosition = 36
        UltraGridColumn770.Width = 292
        UltraGridColumn771.Header.VisiblePosition = 38
        UltraGridColumn771.Hidden = True
        UltraGridColumn772.Header.VisiblePosition = 39
        UltraGridColumn772.Hidden = True
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn773.Header.Appearance = Appearance94
        UltraGridColumn773.Header.VisiblePosition = 37
        UltraGridColumn6.Header.VisiblePosition = 40
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 41
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 42
        UltraGridColumn8.Hidden = True
        UltraGridColumn774.Header.VisiblePosition = 43
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn734, UltraGridColumn735, UltraGridColumn736, UltraGridColumn737, UltraGridColumn738, UltraGridColumn739, UltraGridColumn740, UltraGridColumn741, UltraGridColumn742, UltraGridColumn743, UltraGridColumn744, UltraGridColumn745, UltraGridColumn746, UltraGridColumn747, UltraGridColumn748, UltraGridColumn749, UltraGridColumn750, UltraGridColumn751, UltraGridColumn752, UltraGridColumn753, UltraGridColumn754, UltraGridColumn755, UltraGridColumn756, UltraGridColumn757, UltraGridColumn758, UltraGridColumn759, UltraGridColumn760, UltraGridColumn761, UltraGridColumn762, UltraGridColumn763, UltraGridColumn764, UltraGridColumn765, UltraGridColumn766, UltraGridColumn767, UltraGridColumn768, UltraGridColumn769, UltraGridColumn770, UltraGridColumn771, UltraGridColumn772, UltraGridColumn773, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn774})
        UltraGridColumn775.Header.VisiblePosition = 0
        UltraGridColumn776.Header.VisiblePosition = 1
        UltraGridColumn777.Header.VisiblePosition = 3
        UltraGridColumn778.Header.VisiblePosition = 5
        UltraGridColumn779.Header.VisiblePosition = 4
        UltraGridColumn780.Header.VisiblePosition = 2
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn775, UltraGridColumn776, UltraGridColumn777, UltraGridColumn778, UltraGridColumn779, UltraGridColumn780})
        Me.griDetalleOrdenIngreso.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griDetalleOrdenIngreso.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griDetalleOrdenIngreso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance95.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance95.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance95.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrdenIngreso.DisplayLayout.GroupByBox.Appearance = Appearance95
        Appearance96.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrdenIngreso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance96
        Me.griDetalleOrdenIngreso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrdenIngreso.DisplayLayout.GroupByBox.Hidden = True
        Appearance97.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance97.BackColor2 = System.Drawing.SystemColors.Control
        Appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance97.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrdenIngreso.DisplayLayout.GroupByBox.PromptAppearance = Appearance97
        Me.griDetalleOrdenIngreso.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleOrdenIngreso.DisplayLayout.MaxRowScrollRegions = 1
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Appearance98.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.ActiveCellAppearance = Appearance98
        Appearance99.BackColor = System.Drawing.SystemColors.Highlight
        Appearance99.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.ActiveRowAppearance = Appearance99
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance100.BackColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.CardAreaAppearance = Appearance100
        Appearance101.BorderColor = System.Drawing.Color.Silver
        Appearance101.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.CellAppearance = Appearance101
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.CellPadding = 0
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance102.BackColor = System.Drawing.SystemColors.Control
        Appearance102.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance102.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance102.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.GroupByRowAppearance = Appearance102
        Appearance103.TextHAlignAsString = "Left"
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.HeaderAppearance = Appearance103
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance104.BackColor = System.Drawing.SystemColors.Window
        Appearance104.BorderColor = System.Drawing.Color.Silver
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.RowAppearance = Appearance104
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance105.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griDetalleOrdenIngreso.DisplayLayout.Override.TemplateAddRowAppearance = Appearance105
        Me.griDetalleOrdenIngreso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleOrdenIngreso.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleOrdenIngreso.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalleOrdenIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleOrdenIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleOrdenIngreso.Location = New System.Drawing.Point(0, 131)
        Me.griDetalleOrdenIngreso.Name = "griDetalleOrdenIngreso"
        Me.griDetalleOrdenIngreso.Size = New System.Drawing.Size(1347, 149)
        Me.griDetalleOrdenIngreso.TabIndex = 12
        '
        'odDetalleOrdenIngreso
        '
        UltraDataColumn125.DataType = GetType(Boolean)
        UltraDataColumn125.DefaultValue = False
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129})
        Me.odDetalleOrdenIngreso.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn130.DataType = GetType(Boolean)
        UltraDataColumn130.DefaultValue = False
        UltraDataColumn172.DataType = GetType(Double)
        Me.odDetalleOrdenIngreso.Band.Columns.AddRange(New Object() {UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172})
        '
        'griListaOrdenIngreso
        '
        Me.griListaOrdenIngreso.ContextMenuStrip = Me.MenuContextualOI
        Me.griListaOrdenIngreso.DataSource = Me.odOrdenIngreso
        UltraGridColumn781.Header.VisiblePosition = 0
        UltraGridColumn781.Hidden = True
        UltraGridColumn782.Header.VisiblePosition = 1
        UltraGridColumn782.Hidden = True
        UltraGridColumn783.Header.Caption = "Nro Orden"
        UltraGridColumn783.Header.VisiblePosition = 2
        UltraGridColumn783.Width = 103
        UltraGridColumn784.Header.VisiblePosition = 5
        UltraGridColumn784.Hidden = True
        UltraGridColumn785.Header.VisiblePosition = 6
        UltraGridColumn785.Hidden = True
        UltraGridColumn786.Header.VisiblePosition = 7
        UltraGridColumn786.Hidden = True
        UltraGridColumn787.Header.VisiblePosition = 10
        UltraGridColumn787.Hidden = True
        UltraGridColumn787.Width = 95
        UltraGridColumn788.Header.Caption = "Fecha"
        UltraGridColumn788.Header.VisiblePosition = 3
        UltraGridColumn788.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn788.Width = 140
        UltraGridColumn789.Header.VisiblePosition = 13
        UltraGridColumn789.Hidden = True
        UltraGridColumn790.Header.VisiblePosition = 14
        UltraGridColumn790.Hidden = True
        UltraGridColumn791.Header.VisiblePosition = 15
        UltraGridColumn791.Hidden = True
        UltraGridColumn792.Header.VisiblePosition = 16
        UltraGridColumn792.Hidden = True
        UltraGridColumn793.Header.VisiblePosition = 17
        UltraGridColumn793.Hidden = True
        UltraGridColumn794.Header.VisiblePosition = 18
        UltraGridColumn794.Hidden = True
        UltraGridColumn795.Header.VisiblePosition = 19
        UltraGridColumn795.Hidden = True
        UltraGridColumn796.Header.VisiblePosition = 20
        UltraGridColumn796.Hidden = True
        UltraGridColumn797.Header.VisiblePosition = 21
        UltraGridColumn797.Hidden = True
        UltraGridColumn798.Header.VisiblePosition = 22
        UltraGridColumn798.Hidden = True
        UltraGridColumn799.Header.VisiblePosition = 23
        UltraGridColumn799.Hidden = True
        UltraGridColumn800.Header.VisiblePosition = 24
        UltraGridColumn800.Hidden = True
        UltraGridColumn801.Header.VisiblePosition = 25
        UltraGridColumn801.Hidden = True
        UltraGridColumn802.Header.Caption = "Movimiento Inventario"
        UltraGridColumn802.Header.VisiblePosition = 4
        UltraGridColumn802.Width = 177
        UltraGridColumn803.Header.VisiblePosition = 26
        UltraGridColumn803.Hidden = True
        UltraGridColumn804.Header.VisiblePosition = 27
        UltraGridColumn804.Hidden = True
        UltraGridColumn805.Header.Caption = "Referencia"
        UltraGridColumn805.Header.VisiblePosition = 11
        UltraGridColumn805.Hidden = True
        UltraGridColumn805.Width = 141
        UltraGridColumn806.Header.VisiblePosition = 28
        UltraGridColumn806.Hidden = True
        UltraGridColumn807.Header.VisiblePosition = 29
        UltraGridColumn807.Hidden = True
        UltraGridColumn808.Header.VisiblePosition = 30
        UltraGridColumn808.Hidden = True
        UltraGridColumn809.Header.VisiblePosition = 31
        UltraGridColumn809.Hidden = True
        UltraGridColumn810.Header.Caption = "IdUsuario"
        UltraGridColumn810.Header.VisiblePosition = 32
        UltraGridColumn810.Hidden = True
        UltraGridColumn811.Header.VisiblePosition = 33
        UltraGridColumn811.Hidden = True
        UltraGridColumn812.Header.VisiblePosition = 34
        UltraGridColumn812.Hidden = True
        UltraGridColumn813.Header.VisiblePosition = 35
        UltraGridColumn813.Hidden = True
        UltraGridColumn814.Header.VisiblePosition = 36
        UltraGridColumn814.Hidden = True
        UltraGridColumn815.Header.VisiblePosition = 37
        UltraGridColumn815.Hidden = True
        UltraGridColumn816.Header.VisiblePosition = 38
        UltraGridColumn816.Hidden = True
        UltraGridColumn817.Header.Caption = "Tipo Orden"
        UltraGridColumn817.Header.VisiblePosition = 9
        UltraGridColumn817.Hidden = True
        UltraGridColumn817.Width = 231
        UltraGridColumn818.Header.VisiblePosition = 8
        UltraGridColumn818.Width = 78
        UltraGridColumn819.Header.Caption = "Estado"
        UltraGridColumn819.Header.VisiblePosition = 12
        UltraGridColumn819.Width = 120
        UltraGridColumn820.Header.VisiblePosition = 39
        UltraGridColumn820.Hidden = True
        UltraGridColumn821.Header.VisiblePosition = 40
        UltraGridColumn821.Hidden = True
        UltraGridColumn822.Header.VisiblePosition = 41
        UltraGridColumn822.Hidden = True
        UltraGridColumn823.Header.VisiblePosition = 42
        UltraGridColumn823.Hidden = True
        UltraGridColumn824.Header.VisiblePosition = 43
        UltraGridColumn824.Hidden = True
        UltraGridColumn825.Header.VisiblePosition = 44
        UltraGridColumn825.Hidden = True
        UltraGridColumn826.Header.Caption = "Usuario"
        UltraGridColumn826.Header.VisiblePosition = 50
        UltraGridColumn826.Width = 122
        UltraGridColumn827.Header.VisiblePosition = 45
        UltraGridColumn827.Hidden = True
        UltraGridColumn828.Header.VisiblePosition = 46
        UltraGridColumn828.Hidden = True
        UltraGridColumn829.Header.VisiblePosition = 47
        UltraGridColumn829.Hidden = True
        UltraGridColumn830.Header.Caption = "Documento Asoc."
        UltraGridColumn830.Header.VisiblePosition = 48
        UltraGridColumn830.Width = 189
        UltraGridColumn831.Header.Caption = "N° Documento"
        UltraGridColumn831.Header.VisiblePosition = 49
        UltraGridColumn831.Width = 128
        UltraGridColumn832.Header.VisiblePosition = 52
        UltraGridColumn832.Hidden = True
        UltraGridColumn833.Header.VisiblePosition = 53
        UltraGridColumn833.Hidden = True
        UltraGridColumn834.Header.VisiblePosition = 54
        UltraGridColumn834.Hidden = True
        UltraGridColumn835.Header.VisiblePosition = 55
        UltraGridColumn835.Hidden = True
        UltraGridColumn836.Header.VisiblePosition = 51
        UltraGridColumn836.Width = 107
        UltraGridColumn837.Header.VisiblePosition = 56
        UltraGridColumn837.Hidden = True
        UltraGridColumn838.Header.VisiblePosition = 57
        UltraGridColumn838.Hidden = True
        UltraGridColumn839.Header.VisiblePosition = 58
        UltraGridColumn839.Hidden = True
        UltraGridColumn840.Header.VisiblePosition = 59
        UltraGridColumn840.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 60
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 61
        UltraGridColumn4.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn781, UltraGridColumn782, UltraGridColumn783, UltraGridColumn784, UltraGridColumn785, UltraGridColumn786, UltraGridColumn787, UltraGridColumn788, UltraGridColumn789, UltraGridColumn790, UltraGridColumn791, UltraGridColumn792, UltraGridColumn793, UltraGridColumn794, UltraGridColumn795, UltraGridColumn796, UltraGridColumn797, UltraGridColumn798, UltraGridColumn799, UltraGridColumn800, UltraGridColumn801, UltraGridColumn802, UltraGridColumn803, UltraGridColumn804, UltraGridColumn805, UltraGridColumn806, UltraGridColumn807, UltraGridColumn808, UltraGridColumn809, UltraGridColumn810, UltraGridColumn811, UltraGridColumn812, UltraGridColumn813, UltraGridColumn814, UltraGridColumn815, UltraGridColumn816, UltraGridColumn817, UltraGridColumn818, UltraGridColumn819, UltraGridColumn820, UltraGridColumn821, UltraGridColumn822, UltraGridColumn823, UltraGridColumn824, UltraGridColumn825, UltraGridColumn826, UltraGridColumn827, UltraGridColumn828, UltraGridColumn829, UltraGridColumn830, UltraGridColumn831, UltraGridColumn832, UltraGridColumn833, UltraGridColumn834, UltraGridColumn835, UltraGridColumn836, UltraGridColumn837, UltraGridColumn838, UltraGridColumn839, UltraGridColumn840, UltraGridColumn3, UltraGridColumn4})
        Me.griListaOrdenIngreso.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griListaOrdenIngreso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.griListaOrdenIngreso.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenIngreso.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenIngreso.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance106.BorderColor = System.Drawing.Color.Silver
        Me.griListaOrdenIngreso.DisplayLayout.Override.CellAppearance = Appearance106
        Me.griListaOrdenIngreso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaOrdenIngreso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaOrdenIngreso.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaOrdenIngreso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaOrdenIngreso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance107.BorderColor = System.Drawing.Color.Silver
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowAppearance = Appearance107
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaOrdenIngreso.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.griListaOrdenIngreso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaOrdenIngreso.Dock = System.Windows.Forms.DockStyle.Top
        Me.griListaOrdenIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaOrdenIngreso.Location = New System.Drawing.Point(0, 0)
        Me.griListaOrdenIngreso.Name = "griListaOrdenIngreso"
        Me.griListaOrdenIngreso.Size = New System.Drawing.Size(1347, 131)
        Me.griListaOrdenIngreso.TabIndex = 3
        '
        'MenuContextualOI
        '
        Me.MenuContextualOI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextualOI.ForeColor = System.Drawing.Color.Black
        Me.MenuContextualOI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_Factura, Me.TSM_Boleta, Me.TSM_Guia})
        Me.MenuContextualOI.Name = "MenuContextual1"
        Me.MenuContextualOI.Size = New System.Drawing.Size(154, 70)
        '
        'TSM_Factura
        '
        Me.TSM_Factura.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.TSM_Factura.Name = "TSM_Factura"
        Me.TSM_Factura.Size = New System.Drawing.Size(153, 22)
        Me.TSM_Factura.Text = "Generar Factura"
        Me.TSM_Factura.ToolTipText = "Generar Factura de Compras"
        '
        'TSM_Boleta
        '
        Me.TSM_Boleta.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.TSM_Boleta.Name = "TSM_Boleta"
        Me.TSM_Boleta.Size = New System.Drawing.Size(153, 22)
        Me.TSM_Boleta.Text = "Generar Boleta"
        Me.TSM_Boleta.ToolTipText = "Generar Boleta"
        '
        'TSM_Guia
        '
        Me.TSM_Guia.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.TSM_Guia.Name = "TSM_Guia"
        Me.TSM_Guia.Size = New System.Drawing.Size(153, 22)
        Me.TSM_Guia.Text = "Generar Guia"
        Me.TSM_Guia.ToolTipText = "Generar Guia de Remision"
        '
        'odOrdenIngreso
        '
        UltraDataColumn180.DataType = GetType(Date)
        UltraDataColumn181.DataType = GetType(Date)
        UltraDataColumn182.DataType = GetType(Date)
        UltraDataColumn183.DataType = GetType(Date)
        UltraDataColumn184.DataType = GetType(Double)
        UltraDataColumn185.DataType = GetType(Double)
        UltraDataColumn186.DataType = GetType(Boolean)
        UltraDataColumn187.DataType = GetType(Boolean)
        UltraDataColumn188.DataType = GetType(Boolean)
        UltraDataColumn189.DataType = GetType(Boolean)
        UltraDataColumn190.DataType = GetType(Boolean)
        UltraDataColumn196.DataType = GetType(Boolean)
        UltraDataColumn198.DataType = GetType(Boolean)
        UltraDataColumn201.DataType = GetType(Boolean)
        Me.odOrdenIngreso.Band.Columns.AddRange(New Object() {UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207, UltraDataColumn208, UltraDataColumn209, UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231, UltraDataColumn232, UltraDataColumn233, UltraDataColumn234})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1343, 184)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnModificarPrecios)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel31)
        Me.Agrupacion3.Controls.Add(Me.txtCodBarras)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel9)
        Me.Agrupacion3.Controls.Add(Me.rdbUrgente)
        Me.Agrupacion3.Controls.Add(Me.rdbNormal)
        Me.Agrupacion3.Controls.Add(Me.lbl_etiqueta)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion16)
        Me.Agrupacion3.Controls.Add(Me.btnTerminarOC)
        Me.Agrupacion3.Controls.Add(Me.fecFechaPago)
        Me.Agrupacion3.Controls.Add(Me.fecFechaEntrega)
        Me.Agrupacion3.Controls.Add(Me.fecFechaActual)
        Me.Agrupacion3.Controls.Add(Me.cmdSolesDolares)
        Me.Agrupacion3.Controls.Add(Me.cboMoneda)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion11)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel18)
        Me.Agrupacion3.Controls.Add(Me.txtTC)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel8)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel17)
        Me.Agrupacion3.Controls.Add(Me.chkRuc)
        Me.Agrupacion3.Controls.Add(Me.cboProveedor)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel11)
        Me.Agrupacion3.Controls.Add(Me.txtPorcenIGV)
        Me.Agrupacion3.Controls.Add(Me.cboTipoPago)
        Me.Agrupacion3.Controls.Add(Me.txtEstado)
        Me.Agrupacion3.Controls.Add(Me.cheReqAsoc)
        Me.Agrupacion3.Controls.Add(Me.cheEntregasParciales)
        Me.Agrupacion3.Controls.Add(Me.cheAutoAprobar)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel32)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel12)
        Me.Agrupacion3.Controls.Add(Me.txtNotas)
        Me.Agrupacion3.Controls.Add(Me.txtObservaciones)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel7)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion3.Controls.Add(Me.lbNumeroOrden)
        Me.Agrupacion3.Controls.Add(Me.txtNumeroOrden)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion3.Controls.Add(Me.btnEnviarCorreo)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1343, 186)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnModificarPrecios
        '
        Appearance108.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance108.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnModificarPrecios.Appearance = Appearance108
        Me.btnModificarPrecios.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnModificarPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarPrecios.Enabled = False
        Me.btnModificarPrecios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPrecios.ForeColor = System.Drawing.Color.Black
        Me.btnModificarPrecios.Location = New System.Drawing.Point(428, 117)
        Me.btnModificarPrecios.Name = "btnModificarPrecios"
        Me.btnModificarPrecios.Size = New System.Drawing.Size(129, 25)
        Me.btnModificarPrecios.TabIndex = 24
        Me.btnModificarPrecios.Text = "ModificarPrecios"
        '
        'UltraLabel31
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.UltraLabel31.Appearance = Appearance109
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(354, 91)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(66, 15)
        Me.UltraLabel31.TabIndex = 30
        Me.UltraLabel31.Text = "Cod. Barras:"
        '
        'txtCodBarras
        '
        Appearance110.TextHAlignAsString = "Left"
        Appearance110.TextVAlignAsString = "Middle"
        Me.txtCodBarras.Appearance = Appearance110
        Me.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBarras.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(428, 90)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(262, 21)
        Me.txtCodBarras.TabIndex = 31
        '
        'UltraLabel9
        '
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance111
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(131, 131)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(88, 15)
        Me.UltraLabel9.TabIndex = 10
        Me.UltraLabel9.Text = "Tipo de Compra:"
        '
        'rdbUrgente
        '
        Me.rdbUrgente.AutoSize = True
        Me.rdbUrgente.BackColor = System.Drawing.Color.Transparent
        Me.rdbUrgente.ForeColor = System.Drawing.Color.Navy
        Me.rdbUrgente.Location = New System.Drawing.Point(289, 129)
        Me.rdbUrgente.Name = "rdbUrgente"
        Me.rdbUrgente.Size = New System.Drawing.Size(63, 17)
        Me.rdbUrgente.TabIndex = 12
        Me.rdbUrgente.TabStop = True
        Me.rdbUrgente.Text = "Urgente"
        Me.rdbUrgente.UseVisualStyleBackColor = False
        '
        'rdbNormal
        '
        Me.rdbNormal.AutoSize = True
        Me.rdbNormal.BackColor = System.Drawing.Color.Transparent
        Me.rdbNormal.ForeColor = System.Drawing.Color.Navy
        Me.rdbNormal.Location = New System.Drawing.Point(225, 129)
        Me.rdbNormal.Name = "rdbNormal"
        Me.rdbNormal.Size = New System.Drawing.Size(58, 17)
        Me.rdbNormal.TabIndex = 11
        Me.rdbNormal.TabStop = True
        Me.rdbNormal.Text = "Normal"
        Me.rdbNormal.UseVisualStyleBackColor = False
        '
        'lbl_etiqueta
        '
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance112
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(243, 32)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(57, 16)
        Me.lbl_etiqueta.TabIndex = 9
        Me.lbl_etiqueta.Text = "Etiqueta"
        Me.lbl_etiqueta.Visible = False
        '
        'Agrupacion16
        '
        Me.Agrupacion16.Controls.Add(Me.griHistorialRechazo)
        Me.Agrupacion16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion16.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion16.Location = New System.Drawing.Point(1000, 5)
        Me.Agrupacion16.Name = "Agrupacion16"
        Me.Agrupacion16.Size = New System.Drawing.Size(337, 175)
        Me.Agrupacion16.TabIndex = 38
        Me.Agrupacion16.Text = "Historial Rechazo"
        Me.Agrupacion16.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griHistorialRechazo
        '
        Appearance113.BackColor = System.Drawing.SystemColors.Window
        Appearance113.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griHistorialRechazo.DisplayLayout.Appearance = Appearance113
        UltraGridColumn280.Header.VisiblePosition = 0
        UltraGridColumn280.Hidden = True
        UltraGridColumn281.Header.VisiblePosition = 1
        UltraGridColumn281.Hidden = True
        UltraGridColumn282.Header.VisiblePosition = 2
        UltraGridColumn282.Hidden = True
        UltraGridColumn282.Width = 118
        UltraGridColumn283.Header.VisiblePosition = 3
        UltraGridColumn283.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn283.Width = 60
        UltraGridColumn284.Header.VisiblePosition = 4
        UltraGridColumn284.Width = 263
        UltraGridColumn285.Header.VisiblePosition = 5
        UltraGridColumn285.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285})
        Me.griHistorialRechazo.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griHistorialRechazo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorialRechazo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance114.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance114.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance114.BorderColor = System.Drawing.SystemColors.Window
        Me.griHistorialRechazo.DisplayLayout.GroupByBox.Appearance = Appearance114
        Appearance115.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorialRechazo.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance115
        Me.griHistorialRechazo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorialRechazo.DisplayLayout.GroupByBox.Hidden = True
        Appearance116.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance116.BackColor2 = System.Drawing.SystemColors.Control
        Appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance116.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorialRechazo.DisplayLayout.GroupByBox.PromptAppearance = Appearance116
        Me.griHistorialRechazo.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorialRechazo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance117.BackColor = System.Drawing.SystemColors.Window
        Appearance117.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griHistorialRechazo.DisplayLayout.Override.ActiveCellAppearance = Appearance117
        Appearance118.BackColor = System.Drawing.SystemColors.Highlight
        Appearance118.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griHistorialRechazo.DisplayLayout.Override.ActiveRowAppearance = Appearance118
        Me.griHistorialRechazo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griHistorialRechazo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance119.BackColor = System.Drawing.SystemColors.Window
        Me.griHistorialRechazo.DisplayLayout.Override.CardAreaAppearance = Appearance119
        Appearance120.BorderColor = System.Drawing.Color.Silver
        Appearance120.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griHistorialRechazo.DisplayLayout.Override.CellAppearance = Appearance120
        Me.griHistorialRechazo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHistorialRechazo.DisplayLayout.Override.CellPadding = 0
        Appearance121.BackColor = System.Drawing.SystemColors.Control
        Appearance121.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance121.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance121.BorderColor = System.Drawing.SystemColors.Window
        Me.griHistorialRechazo.DisplayLayout.Override.GroupByRowAppearance = Appearance121
        Appearance122.TextHAlignAsString = "Left"
        Me.griHistorialRechazo.DisplayLayout.Override.HeaderAppearance = Appearance122
        Me.griHistorialRechazo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHistorialRechazo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance123.BackColor = System.Drawing.SystemColors.Window
        Appearance123.BorderColor = System.Drawing.Color.Silver
        Me.griHistorialRechazo.DisplayLayout.Override.RowAppearance = Appearance123
        Me.griHistorialRechazo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance124.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griHistorialRechazo.DisplayLayout.Override.TemplateAddRowAppearance = Appearance124
        Me.griHistorialRechazo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griHistorialRechazo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griHistorialRechazo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griHistorialRechazo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorialRechazo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorialRechazo.Location = New System.Drawing.Point(3, 16)
        Me.griHistorialRechazo.Name = "griHistorialRechazo"
        Me.griHistorialRechazo.Size = New System.Drawing.Size(331, 156)
        Me.griHistorialRechazo.TabIndex = 0
        Me.griHistorialRechazo.TabStop = False
        Me.griHistorialRechazo.Text = "Grilla1"
        '
        'btnTerminarOC
        '
        Appearance125.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnTerminarOC.Appearance = Appearance125
        Me.btnTerminarOC.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnTerminarOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTerminarOC.Enabled = False
        Me.btnTerminarOC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminarOC.ForeColor = System.Drawing.Color.Black
        Me.btnTerminarOC.Location = New System.Drawing.Point(901, 121)
        Me.btnTerminarOC.Name = "btnTerminarOC"
        Me.btnTerminarOC.Size = New System.Drawing.Size(93, 25)
        Me.btnTerminarOC.TabIndex = 37
        Me.btnTerminarOC.Text = "Terminar OC"
        '
        'fecFechaPago
        '
        Me.fecFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaPago.Location = New System.Drawing.Point(247, 102)
        Me.fecFechaPago.Name = "fecFechaPago"
        Me.fecFechaPago.Size = New System.Drawing.Size(97, 20)
        Me.fecFechaPago.TabIndex = 16
        Me.fecFechaPago.TabStop = False
        '
        'fecFechaEntrega
        '
        Me.fecFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaEntrega.Location = New System.Drawing.Point(73, 102)
        Me.fecFechaEntrega.Name = "fecFechaEntrega"
        Me.fecFechaEntrega.Size = New System.Drawing.Size(103, 20)
        Me.fecFechaEntrega.TabIndex = 14
        Me.fecFechaEntrega.TabStop = False
        '
        'fecFechaActual
        '
        Me.fecFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaActual.Location = New System.Drawing.Point(247, 5)
        Me.fecFechaActual.Name = "fecFechaActual"
        Me.fecFechaActual.Size = New System.Drawing.Size(96, 20)
        Me.fecFechaActual.TabIndex = 8
        '
        'cmdSolesDolares
        '
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Me.cmdSolesDolares.Appearance = Appearance126
        Me.cmdSolesDolares.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmdSolesDolares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSolesDolares.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSolesDolares.ForeColor = System.Drawing.Color.Black
        Me.cmdSolesDolares.Location = New System.Drawing.Point(178, 78)
        Me.cmdSolesDolares.Name = "cmdSolesDolares"
        Me.cmdSolesDolares.Size = New System.Drawing.Size(46, 22)
        Me.cmdSolesDolares.TabIndex = 21
        Me.cmdSolesDolares.Text = "s/. a $"
        '
        'cboMoneda
        '
        Appearance127.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance127
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownListWidth = 180
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(73, 78)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(103, 21)
        Me.cboMoneda.TabIndex = 20
        Me.cboMoneda.ValueMember = "Id"
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.txtTotal)
        Me.Agrupacion11.Controls.Add(Me.UltraLabel13)
        Me.Agrupacion11.Controls.Add(Me.txtSubTotal)
        Me.Agrupacion11.Controls.Add(Me.UltraLabel14)
        Me.Agrupacion11.Controls.Add(Me.txtIGV)
        Me.Agrupacion11.Controls.Add(Me.UltraLabel15)
        Me.Agrupacion11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(134, 148)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(510, 32)
        Me.Agrupacion11.TabIndex = 35
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTotal
        '
        Appearance128.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Appearance = Appearance128
        Me.txtTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(377, 6)
        Me.txtTotal.MaskInput = "{LOC}nn,nnn,nnn,nnn.nnnn"
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NullText = "0.00"
        Me.txtTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(123, 22)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TabStop = False
        '
        'UltraLabel13
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance129
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(6, 11)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel13.TabIndex = 0
        Me.UltraLabel13.Text = "Subtotal:"
        '
        'txtSubTotal
        '
        Appearance130.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Appearance = Appearance130
        Me.txtSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Location = New System.Drawing.Point(55, 7)
        Me.txtSubTotal.MaskInput = "{LOC}nn,nnn,nnn,nnn.nnnn"
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.NullText = "0.00"
        Me.txtSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(126, 22)
        Me.txtSubTotal.TabIndex = 1
        Me.txtSubTotal.TabStop = False
        '
        'UltraLabel14
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Appearance131.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance131
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(187, 10)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel14.TabIndex = 2
        Me.UltraLabel14.Text = "IGV:"
        '
        'txtIGV
        '
        Appearance132.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Appearance = Appearance132
        Me.txtIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIGV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Location = New System.Drawing.Point(216, 6)
        Me.txtIGV.MaskInput = "{LOC}nn,nnn,nnn,nnn.nnnn"
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.NullText = "0.00"
        Me.txtIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(123, 22)
        Me.txtIGV.TabIndex = 3
        Me.txtIGV.TabStop = False
        '
        'UltraLabel15
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Appearance133.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance133
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(340, 10)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Total:"
        '
        'UltraLabel18
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Appearance134.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance134
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(354, 57)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel18.TabIndex = 28
        Me.UltraLabel18.Text = "Observacion"
        '
        'txtTC
        '
        Appearance135.ForeColor = System.Drawing.Color.Black
        Me.txtTC.Appearance = Appearance135
        Me.txtTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.Black
        Me.txtTC.Location = New System.Drawing.Point(279, 78)
        Me.txtTC.MaskInput = "{double:3.4}"
        Me.txtTC.Name = "txtTC"
        Me.txtTC.NullText = "0.00"
        Me.txtTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTC.ReadOnly = True
        Me.txtTC.Size = New System.Drawing.Size(65, 21)
        Me.txtTC.TabIndex = 22
        '
        'UltraLabel8
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance136
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(8, 57)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel8.TabIndex = 4
        Me.UltraLabel8.Text = "Proveedor:"
        '
        'UltraLabel17
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Appearance137.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance137
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(9, 33)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 2
        Me.UltraLabel17.Text = "Estado:"
        '
        'chkRuc
        '
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc.Appearance = Appearance138
        Me.chkRuc.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc.ForeColor = System.Drawing.Color.Black
        Me.chkRuc.Location = New System.Drawing.Point(301, 53)
        Me.chkRuc.Name = "chkRuc"
        Me.chkRuc.Size = New System.Drawing.Size(51, 20)
        Me.chkRuc.TabIndex = 6
        Me.chkRuc.Text = "RUC"
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownWidth = 400
        Me.cboProveedor.Location = New System.Drawing.Point(73, 53)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(221, 22)
        Me.cboProveedor.TabIndex = 5
        '
        'UltraLabel11
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.ForeColor = System.Drawing.Color.Navy
        Appearance139.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance139
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(565, 122)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel11.TabIndex = 25
        Me.UltraLabel11.Text = "IGV:"
        '
        'txtPorcenIGV
        '
        Me.txtPorcenIGV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcenIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPorcenIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenIGV.Location = New System.Drawing.Point(593, 118)
        Me.txtPorcenIGV.Name = "txtPorcenIGV"
        Me.txtPorcenIGV.ReadOnly = True
        Me.txtPorcenIGV.Size = New System.Drawing.Size(65, 21)
        Me.txtPorcenIGV.TabIndex = 26
        '
        'cboTipoPago
        '
        Appearance140.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance140
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance141.Image = 7
        EditorButton2.Appearance = Appearance141
        Me.cboTipoPago.ButtonsRight.Add(EditorButton2)
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.ImageList = Me.imagenes
        Me.cboTipoPago.Location = New System.Drawing.Point(428, 9)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(230, 21)
        Me.cboTipoPago.TabIndex = 18
        Me.cboTipoPago.ValueMember = "Id"
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(73, 29)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(157, 21)
        Me.txtEstado.TabIndex = 3
        '
        'cheReqAsoc
        '
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Me.cheReqAsoc.Appearance = Appearance142
        Me.cheReqAsoc.BackColor = System.Drawing.Color.Transparent
        Me.cheReqAsoc.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheReqAsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheReqAsoc.ForeColor = System.Drawing.Color.Black
        Me.cheReqAsoc.Location = New System.Drawing.Point(8, 162)
        Me.cheReqAsoc.Name = "cheReqAsoc"
        Me.cheReqAsoc.Size = New System.Drawing.Size(120, 20)
        Me.cheReqAsoc.TabIndex = 34
        Me.cheReqAsoc.TabStop = False
        Me.cheReqAsoc.Text = "Req. Asoc."
        Me.cheReqAsoc.Visible = False
        '
        'cheEntregasParciales
        '
        Appearance143.ForeColor = System.Drawing.Color.Navy
        Me.cheEntregasParciales.Appearance = Appearance143
        Me.cheEntregasParciales.BackColor = System.Drawing.Color.Transparent
        Me.cheEntregasParciales.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheEntregasParciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheEntregasParciales.ForeColor = System.Drawing.Color.Black
        Me.cheEntregasParciales.Location = New System.Drawing.Point(8, 145)
        Me.cheEntregasParciales.Name = "cheEntregasParciales"
        Me.cheEntregasParciales.Size = New System.Drawing.Size(120, 20)
        Me.cheEntregasParciales.TabIndex = 33
        Me.cheEntregasParciales.TabStop = False
        Me.cheEntregasParciales.Text = "Entregas parciales"
        Me.cheEntregasParciales.Visible = False
        '
        'cheAutoAprobar
        '
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Me.cheAutoAprobar.Appearance = Appearance144
        Me.cheAutoAprobar.BackColor = System.Drawing.Color.Transparent
        Me.cheAutoAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheAutoAprobar.Checked = True
        Me.cheAutoAprobar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cheAutoAprobar.Enabled = False
        Me.cheAutoAprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheAutoAprobar.ForeColor = System.Drawing.Color.Black
        Me.cheAutoAprobar.Location = New System.Drawing.Point(8, 128)
        Me.cheAutoAprobar.Name = "cheAutoAprobar"
        Me.cheAutoAprobar.Size = New System.Drawing.Size(120, 20)
        Me.cheAutoAprobar.TabIndex = 32
        Me.cheAutoAprobar.TabStop = False
        Me.cheAutoAprobar.Text = "Autoaprobar"
        '
        'UltraLabel32
        '
        Appearance145.BackColor = System.Drawing.Color.Transparent
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Appearance145.TextVAlignAsString = "Middle"
        Me.UltraLabel32.Appearance = Appearance145
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(713, 15)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel32.TabIndex = 27
        Me.UltraLabel32.Text = "Notas:"
        '
        'UltraLabel12
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Appearance146.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance146
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(353, 40)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel12.TabIndex = 27
        Me.UltraLabel12.Text = "Glosa /"
        '
        'txtNotas
        '
        Appearance147.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNotas.Appearance = Appearance147
        Me.txtNotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNotas.Location = New System.Drawing.Point(758, 9)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas.Size = New System.Drawing.Size(236, 103)
        Me.txtNotas.TabIndex = 29
        '
        'txtObservaciones
        '
        Appearance148.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Appearance = Appearance148
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Location = New System.Drawing.Point(428, 33)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(262, 54)
        Me.txtObservaciones.TabIndex = 29
        '
        'UltraLabel7
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Appearance149.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance149
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(243, 82)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(25, 15)
        Me.UltraLabel7.TabIndex = 23
        Me.UltraLabel7.Text = "T.C:"
        '
        'UltraLabel6
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance150
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(8, 82)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 19
        Me.UltraLabel6.Text = "Moneda:"
        '
        'UltraLabel5
        '
        Appearance151.BackColor = System.Drawing.Color.Transparent
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Appearance151.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance151
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(9, 106)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Entrega:"
        '
        'UltraLabel4
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Appearance152.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance152
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(206, 104)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel4.TabIndex = 15
        Me.UltraLabel4.Text = "Pago:"
        '
        'UltraLabel3
        '
        Appearance153.BackColor = System.Drawing.Color.Transparent
        Appearance153.ForeColor = System.Drawing.Color.Navy
        Appearance153.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance153
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(353, 11)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel3.TabIndex = 17
        Me.UltraLabel3.Text = "Tipo Pago:"
        '
        'lbNumeroOrden
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Appearance154.TextVAlignAsString = "Middle"
        Me.lbNumeroOrden.Appearance = Appearance154
        Me.lbNumeroOrden.AutoSize = True
        Me.lbNumeroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroOrden.Location = New System.Drawing.Point(9, 8)
        Me.lbNumeroOrden.Name = "lbNumeroOrden"
        Me.lbNumeroOrden.Size = New System.Drawing.Size(51, 15)
        Me.lbNumeroOrden.TabIndex = 0
        Me.lbNumeroOrden.Text = "Nro O.C.:"
        '
        'txtNumeroOrden
        '
        Me.txtNumeroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroOrden.Location = New System.Drawing.Point(73, 5)
        Me.txtNumeroOrden.Name = "txtNumeroOrden"
        Me.txtNumeroOrden.ReadOnly = True
        Me.txtNumeroOrden.Size = New System.Drawing.Size(117, 21)
        Me.txtNumeroOrden.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance155.BackColor = System.Drawing.Color.Transparent
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Appearance155.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance155
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(201, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Fecha:"
        '
        'btnEnviarCorreo
        '
        Appearance156.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnEnviarCorreo.Appearance = Appearance156
        Me.btnEnviarCorreo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(758, 121)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(93, 25)
        Me.btnEnviarCorreo.TabIndex = 36
        Me.btnEnviarCorreo.Text = "Enviar Correo"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion17)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1343, 184)
        '
        'Agrupacion17
        '
        Me.Agrupacion17.Controls.Add(Me.cboTipoOrdenCompra)
        Me.Agrupacion17.Controls.Add(Me.cboCentro)
        Me.Agrupacion17.Controls.Add(Me.cbCentro)
        Me.Agrupacion17.Controls.Add(Me.UltraLabel10)
        Me.Agrupacion17.Controls.Add(Me.Agrupacion18)
        Me.Agrupacion17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion17.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion17.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion17.Name = "Agrupacion17"
        Me.Agrupacion17.Size = New System.Drawing.Size(1343, 184)
        Me.Agrupacion17.TabIndex = 0
        Me.Agrupacion17.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipoOrdenCompra
        '
        Appearance157.ForeColor = System.Drawing.Color.Black
        Me.cboTipoOrdenCompra.Appearance = Appearance157
        Me.cboTipoOrdenCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance158.Image = 7
        EditorButton3.Appearance = Appearance158
        Me.cboTipoOrdenCompra.ButtonsRight.Add(EditorButton3)
        Me.cboTipoOrdenCompra.DisplayMember = "Nombre"
        Me.cboTipoOrdenCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoOrdenCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoOrdenCompra.ForeColor = System.Drawing.Color.Black
        Me.cboTipoOrdenCompra.ImageList = Me.imagenes
        Me.cboTipoOrdenCompra.Location = New System.Drawing.Point(494, 12)
        Me.cboTipoOrdenCompra.Name = "cboTipoOrdenCompra"
        Me.cboTipoOrdenCompra.Size = New System.Drawing.Size(173, 21)
        Me.cboTipoOrdenCompra.TabIndex = 325
        Me.cboTipoOrdenCompra.ValueMember = "Id"
        Me.cboTipoOrdenCompra.Visible = False
        '
        'cboCentro
        '
        Appearance159.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance159
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance160.Image = 7
        EditorButton4.Appearance = Appearance160
        Me.cboCentro.ButtonsRight.Add(EditorButton4)
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.ImageList = Me.imagenes
        ValueListItem3.DataValue = "M"
        ValueListItem3.DisplayText = "Materiales"
        ValueListItem4.DataValue = "S"
        ValueListItem4.DisplayText = "Servicios"
        Me.cboCentro.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.cboCentro.Location = New System.Drawing.Point(494, 36)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(173, 21)
        Me.cboCentro.TabIndex = 327
        Me.cboCentro.ValueMember = "Id"
        Me.cboCentro.Visible = False
        '
        'cbCentro
        '
        Me.cbCentro.BackColor = System.Drawing.Color.Transparent
        Me.cbCentro.BackColorInternal = System.Drawing.Color.Transparent
        Me.cbCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCentro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbCentro.Location = New System.Drawing.Point(432, 36)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Size = New System.Drawing.Size(58, 20)
        Me.cbCentro.TabIndex = 326
        Me.cbCentro.Text = "Centro:"
        Me.cbCentro.Visible = False
        '
        'UltraLabel10
        '
        Appearance161.BackColor = System.Drawing.Color.Transparent
        Appearance161.ForeColor = System.Drawing.Color.Navy
        Appearance161.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance161
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(430, 16)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel10.TabIndex = 328
        Me.UltraLabel10.Text = "Tipo Orden:"
        Me.UltraLabel10.Visible = False
        '
        'Agrupacion18
        '
        Me.Agrupacion18.Controls.Add(Me.decTotalIGVNCD)
        Me.Agrupacion18.Controls.Add(Me.fecNotaCD)
        Me.Agrupacion18.Controls.Add(Me.UltraLabel30)
        Me.Agrupacion18.Controls.Add(Me.decIGVNCD)
        Me.Agrupacion18.Controls.Add(Me.UltraLabel29)
        Me.Agrupacion18.Controls.Add(Me.decSubTotalNCD)
        Me.Agrupacion18.Controls.Add(Me.UltraLabel28)
        Me.Agrupacion18.Controls.Add(Me.txtNroNotaCD)
        Me.Agrupacion18.Controls.Add(Me.txtSreNotaCD)
        Me.Agrupacion18.Controls.Add(Me.UltraLabel26)
        Me.Agrupacion18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion18.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion18.Location = New System.Drawing.Point(8, 12)
        Me.Agrupacion18.Name = "Agrupacion18"
        Me.Agrupacion18.Size = New System.Drawing.Size(414, 68)
        Me.Agrupacion18.TabIndex = 324
        Me.Agrupacion18.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTotalIGVNCD
        '
        Appearance162.ForeColor = System.Drawing.Color.Black
        Me.decTotalIGVNCD.Appearance = Appearance162
        Me.decTotalIGVNCD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalIGVNCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalIGVNCD.ForeColor = System.Drawing.Color.Black
        Me.decTotalIGVNCD.Location = New System.Drawing.Point(317, 37)
        Me.decTotalIGVNCD.MaskInput = "{LOC}nnnnnn.nnnn"
        Me.decTotalIGVNCD.Name = "decTotalIGVNCD"
        Me.decTotalIGVNCD.NullText = "0.00"
        Me.decTotalIGVNCD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalIGVNCD.ReadOnly = True
        Me.decTotalIGVNCD.Size = New System.Drawing.Size(81, 21)
        Me.decTotalIGVNCD.TabIndex = 288
        '
        'fecNotaCD
        '
        Me.fecNotaCD.DateTime = New Date(2015, 5, 21, 0, 0, 0, 0)
        Me.fecNotaCD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecNotaCD.Location = New System.Drawing.Point(72, 7)
        Me.fecNotaCD.MaskInput = ""
        Me.fecNotaCD.Name = "fecNotaCD"
        Me.fecNotaCD.ReadOnly = True
        Me.fecNotaCD.Size = New System.Drawing.Size(100, 21)
        Me.fecNotaCD.TabIndex = 3
        Me.fecNotaCD.Value = New Date(2015, 5, 21, 0, 0, 0, 0)
        '
        'UltraLabel30
        '
        Appearance163.BackColor = System.Drawing.Color.Transparent
        Appearance163.ForeColor = System.Drawing.Color.Navy
        Appearance163.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance163
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(278, 41)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel30.TabIndex = 272
        Me.UltraLabel30.Text = "Total:"
        '
        'decIGVNCD
        '
        Appearance164.ForeColor = System.Drawing.Color.Black
        Me.decIGVNCD.Appearance = Appearance164
        Me.decIGVNCD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decIGVNCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decIGVNCD.ForeColor = System.Drawing.Color.Black
        Me.decIGVNCD.Location = New System.Drawing.Point(198, 37)
        Me.decIGVNCD.MaskInput = "{LOC}nnnnn.nnnn"
        Me.decIGVNCD.Name = "decIGVNCD"
        Me.decIGVNCD.NullText = "0.00"
        Me.decIGVNCD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decIGVNCD.ReadOnly = True
        Me.decIGVNCD.Size = New System.Drawing.Size(62, 21)
        Me.decIGVNCD.TabIndex = 287
        '
        'UltraLabel29
        '
        Appearance165.BackColor = System.Drawing.Color.Transparent
        Appearance165.ForeColor = System.Drawing.Color.Navy
        Appearance165.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance165
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(165, 41)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel29.TabIndex = 270
        Me.UltraLabel29.Text = "IGV:"
        '
        'decSubTotalNCD
        '
        Appearance166.ForeColor = System.Drawing.Color.Black
        Me.decSubTotalNCD.Appearance = Appearance166
        Me.decSubTotalNCD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotalNCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSubTotalNCD.ForeColor = System.Drawing.Color.Black
        Me.decSubTotalNCD.Location = New System.Drawing.Point(72, 37)
        Me.decSubTotalNCD.MaskInput = "{LOC}nnnnnn.nnnn"
        Me.decSubTotalNCD.Name = "decSubTotalNCD"
        Me.decSubTotalNCD.NullText = "0.00"
        Me.decSubTotalNCD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotalNCD.ReadOnly = True
        Me.decSubTotalNCD.Size = New System.Drawing.Size(76, 21)
        Me.decSubTotalNCD.TabIndex = 289
        '
        'UltraLabel28
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Appearance167.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance167
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(18, 41)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel28.TabIndex = 268
        Me.UltraLabel28.Text = "Subtotal:"
        '
        'txtNroNotaCD
        '
        Me.txtNroNotaCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroNotaCD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroNotaCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNotaCD.Location = New System.Drawing.Point(230, 7)
        Me.txtNroNotaCD.Name = "txtNroNotaCD"
        Me.txtNroNotaCD.ReadOnly = True
        Me.txtNroNotaCD.Size = New System.Drawing.Size(120, 21)
        Me.txtNroNotaCD.TabIndex = 2
        '
        'txtSreNotaCD
        '
        Me.txtSreNotaCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSreNotaCD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSreNotaCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSreNotaCD.Location = New System.Drawing.Point(178, 7)
        Me.txtSreNotaCD.Name = "txtSreNotaCD"
        Me.txtSreNotaCD.ReadOnly = True
        Me.txtSreNotaCD.Size = New System.Drawing.Size(48, 21)
        Me.txtSreNotaCD.TabIndex = 1
        '
        'UltraLabel26
        '
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Appearance168.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance168
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(6, 12)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel26.TabIndex = 325
        Me.UltraLabel26.Text = "F. Emision:"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1343, 184)
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.agrPercepcion)
        Me.Agrupacion12.Controls.Add(Me.agrDetraccion)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1343, 184)
        Me.Agrupacion12.TabIndex = 356
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrPercepcion
        '
        Appearance169.BackColor = System.Drawing.Color.Transparent
        Me.agrPercepcion.Appearance = Appearance169
        Me.agrPercepcion.Controls.Add(Me.DecPorcentajePercepcion)
        Me.agrPercepcion.Controls.Add(Me.cheActivoPercepcion)
        Me.agrPercepcion.Controls.Add(Me.UltraLabel19)
        Me.agrPercepcion.Controls.Add(Me.DecPercepcion)
        Me.agrPercepcion.Controls.Add(Me.UltraLabel20)
        Me.agrPercepcion.Controls.Add(Me.DecTPagar)
        Me.agrPercepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPercepcion.ForeColor = System.Drawing.Color.Black
        Me.agrPercepcion.Location = New System.Drawing.Point(6, 12)
        Me.agrPercepcion.Name = "agrPercepcion"
        Me.agrPercepcion.Size = New System.Drawing.Size(446, 48)
        Me.agrPercepcion.TabIndex = 354
        Me.agrPercepcion.Text = "Percepción"
        Me.agrPercepcion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'DecPorcentajePercepcion
        '
        Me.DecPorcentajePercepcion.Location = New System.Drawing.Point(48, 17)
        Me.DecPorcentajePercepcion.MaskInput = "nnn.nnn"
        Me.DecPorcentajePercepcion.Name = "DecPorcentajePercepcion"
        Me.DecPorcentajePercepcion.NullText = "0.00"
        Me.DecPorcentajePercepcion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.DecPorcentajePercepcion.Size = New System.Drawing.Size(74, 21)
        Me.DecPorcentajePercepcion.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.DecPorcentajePercepcion.TabIndex = 1
        '
        'cheActivoPercepcion
        '
        Me.cheActivoPercepcion.BackColor = System.Drawing.Color.Transparent
        Me.cheActivoPercepcion.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheActivoPercepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheActivoPercepcion.ForeColor = System.Drawing.Color.Black
        Me.cheActivoPercepcion.Location = New System.Drawing.Point(15, 18)
        Me.cheActivoPercepcion.Name = "cheActivoPercepcion"
        Me.cheActivoPercepcion.Size = New System.Drawing.Size(35, 20)
        Me.cheActivoPercepcion.TabIndex = 0
        Me.cheActivoPercepcion.Text = "% "
        '
        'UltraLabel19
        '
        Appearance170.BackColor = System.Drawing.Color.Transparent
        Appearance170.ForeColor = System.Drawing.Color.Navy
        Appearance170.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance170
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(144, 18)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel19.TabIndex = 3
        Me.UltraLabel19.Text = "Monto"
        '
        'DecPercepcion
        '
        Appearance171.ForeColor = System.Drawing.Color.Black
        Me.DecPercepcion.Appearance = Appearance171
        Me.DecPercepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecPercepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecPercepcion.ForeColor = System.Drawing.Color.Black
        Me.DecPercepcion.Location = New System.Drawing.Point(181, 15)
        Me.DecPercepcion.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.DecPercepcion.Name = "DecPercepcion"
        Me.DecPercepcion.NullText = "0.00"
        Me.DecPercepcion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecPercepcion.ReadOnly = True
        Me.DecPercepcion.Size = New System.Drawing.Size(80, 21)
        Me.DecPercepcion.TabIndex = 2
        '
        'UltraLabel20
        '
        Appearance172.BackColor = System.Drawing.Color.Transparent
        Appearance172.ForeColor = System.Drawing.Color.Navy
        Appearance172.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance172
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(290, 21)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(46, 15)
        Me.UltraLabel20.TabIndex = 5
        Me.UltraLabel20.Text = "T. Pagar"
        '
        'DecTPagar
        '
        Appearance173.ForeColor = System.Drawing.Color.Black
        Me.DecTPagar.Appearance = Appearance173
        Me.DecTPagar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTPagar.ForeColor = System.Drawing.Color.Black
        Me.DecTPagar.Location = New System.Drawing.Point(342, 16)
        Me.DecTPagar.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.DecTPagar.Name = "DecTPagar"
        Me.DecTPagar.NullText = "0.00"
        Me.DecTPagar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTPagar.ReadOnly = True
        Me.DecTPagar.Size = New System.Drawing.Size(90, 21)
        Me.DecTPagar.TabIndex = 3
        '
        'agrDetraccion
        '
        Appearance174.BackColor = System.Drawing.Color.Transparent
        Me.agrDetraccion.Appearance = Appearance174
        Me.agrDetraccion.Controls.Add(Me.UltraLabel21)
        Me.agrDetraccion.Controls.Add(Me.DecDetraer)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel22)
        Me.agrDetraccion.Controls.Add(Me.DecMontoDetraccion)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel23)
        Me.agrDetraccion.Controls.Add(Me.txtNetoPagar)
        Me.agrDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetraccion.ForeColor = System.Drawing.Color.Black
        Me.agrDetraccion.Location = New System.Drawing.Point(6, 66)
        Me.agrDetraccion.Name = "agrDetraccion"
        Me.agrDetraccion.Size = New System.Drawing.Size(446, 48)
        Me.agrDetraccion.TabIndex = 355
        Me.agrDetraccion.Text = "Detracción"
        Me.agrDetraccion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel21
        '
        Appearance175.BackColor = System.Drawing.Color.Transparent
        Appearance175.ForeColor = System.Drawing.Color.Navy
        Appearance175.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance175
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(30, 20)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(15, 15)
        Me.UltraLabel21.TabIndex = 0
        Me.UltraLabel21.Text = "%"
        '
        'DecDetraer
        '
        Me.DecDetraer.Location = New System.Drawing.Point(48, 17)
        Me.DecDetraer.MaskInput = "nnn.nnn"
        Me.DecDetraer.Name = "DecDetraer"
        Me.DecDetraer.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.DecDetraer.Size = New System.Drawing.Size(74, 21)
        Me.DecDetraer.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.DecDetraer.TabIndex = 1
        '
        'UltraLabel22
        '
        Appearance176.BackColor = System.Drawing.Color.Transparent
        Appearance176.ForeColor = System.Drawing.Color.Navy
        Appearance176.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance176
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(146, 23)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel22.TabIndex = 2
        Me.UltraLabel22.Text = "Monto"
        '
        'DecMontoDetraccion
        '
        Appearance177.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Appearance = Appearance177
        Me.DecMontoDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoDetraccion.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Location = New System.Drawing.Point(184, 18)
        Me.DecMontoDetraccion.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.DecMontoDetraccion.Name = "DecMontoDetraccion"
        Me.DecMontoDetraccion.NullText = "0.00"
        Me.DecMontoDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoDetraccion.ReadOnly = True
        Me.DecMontoDetraccion.Size = New System.Drawing.Size(80, 21)
        Me.DecMontoDetraccion.TabIndex = 2
        '
        'UltraLabel23
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Appearance178.ForeColor = System.Drawing.Color.Navy
        Appearance178.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance178
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(270, 21)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel23.TabIndex = 4
        Me.UltraLabel23.Text = "Neto a Pagar"
        '
        'txtNetoPagar
        '
        Appearance179.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Appearance = Appearance179
        Me.txtNetoPagar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNetoPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoPagar.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Location = New System.Drawing.Point(342, 18)
        Me.txtNetoPagar.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.txtNetoPagar.Name = "txtNetoPagar"
        Me.txtNetoPagar.NullText = "0.00"
        Me.txtNetoPagar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtNetoPagar.ReadOnly = True
        Me.txtNetoPagar.Size = New System.Drawing.Size(90, 21)
        Me.txtNetoPagar.TabIndex = 3
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenCompra)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1349, 540)
        '
        'agrOrdenCompra
        '
        Me.agrOrdenCompra.Controls.Add(Me.griListaOrdenCompra)
        Me.agrOrdenCompra.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenCompra.Location = New System.Drawing.Point(0, 125)
        Me.agrOrdenCompra.Name = "agrOrdenCompra"
        Me.agrOrdenCompra.Size = New System.Drawing.Size(1349, 415)
        Me.agrOrdenCompra.TabIndex = 1
        Me.agrOrdenCompra.Text = "Ordenes de Compra : "
        Me.agrOrdenCompra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaOrdenCompra
        '
        Me.griListaOrdenCompra.DataSource = Me.odListaOrdenCompra
        Appearance180.BackColor = System.Drawing.SystemColors.Window
        Appearance180.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaOrdenCompra.DisplayLayout.Appearance = Appearance180
        UltraGridColumn598.Header.VisiblePosition = 0
        UltraGridColumn598.Hidden = True
        UltraGridColumn599.Header.VisiblePosition = 1
        UltraGridColumn599.Hidden = True
        UltraGridColumn600.Header.Caption = "N° Orden"
        UltraGridColumn600.Header.VisiblePosition = 2
        UltraGridColumn601.Header.VisiblePosition = 3
        UltraGridColumn601.Hidden = True
        UltraGridColumn602.Header.VisiblePosition = 4
        UltraGridColumn602.Hidden = True
        UltraGridColumn603.Header.VisiblePosition = 5
        UltraGridColumn603.Hidden = True
        UltraGridColumn604.Header.VisiblePosition = 6
        UltraGridColumn604.Hidden = True
        Appearance181.TextHAlignAsString = "Right"
        UltraGridColumn605.CellAppearance = Appearance181
        UltraGridColumn605.Format = "#,###,###,##0.0000"
        UltraGridColumn605.Header.VisiblePosition = 10
        UltraGridColumn605.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn605.Width = 99
        Appearance182.TextHAlignAsString = "Right"
        UltraGridColumn606.CellAppearance = Appearance182
        UltraGridColumn606.Format = "#,###,###,##0.0000"
        UltraGridColumn606.Header.VisiblePosition = 11
        UltraGridColumn606.MaskInput = "{LOC}nnnnnnnn.nnnn"
        Appearance183.TextHAlignAsString = "Right"
        UltraGridColumn607.CellAppearance = Appearance183
        UltraGridColumn607.Format = "#,###,###,##0.0000"
        UltraGridColumn607.Header.VisiblePosition = 12
        UltraGridColumn607.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn608.Header.VisiblePosition = 14
        UltraGridColumn608.Hidden = True
        UltraGridColumn609.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn609.Header.Caption = "Fecha"
        UltraGridColumn609.Header.VisiblePosition = 7
        UltraGridColumn609.Width = 83
        UltraGridColumn610.Header.VisiblePosition = 15
        UltraGridColumn610.Hidden = True
        UltraGridColumn611.Header.VisiblePosition = 16
        UltraGridColumn611.Hidden = True
        UltraGridColumn612.Header.VisiblePosition = 17
        UltraGridColumn612.Hidden = True
        UltraGridColumn613.Header.VisiblePosition = 18
        UltraGridColumn613.Hidden = True
        UltraGridColumn614.Header.VisiblePosition = 19
        UltraGridColumn614.Hidden = True
        UltraGridColumn615.Header.VisiblePosition = 20
        UltraGridColumn615.Hidden = True
        UltraGridColumn616.Header.VisiblePosition = 21
        UltraGridColumn616.Hidden = True
        UltraGridColumn617.Header.VisiblePosition = 22
        UltraGridColumn617.Hidden = True
        UltraGridColumn618.Header.VisiblePosition = 23
        UltraGridColumn618.Hidden = True
        UltraGridColumn619.Header.VisiblePosition = 24
        UltraGridColumn619.Hidden = True
        UltraGridColumn620.Header.VisiblePosition = 25
        UltraGridColumn620.Hidden = True
        UltraGridColumn621.Header.VisiblePosition = 26
        UltraGridColumn621.Hidden = True
        UltraGridColumn622.Header.VisiblePosition = 27
        UltraGridColumn622.Hidden = True
        UltraGridColumn623.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn623.Header.VisiblePosition = 46
        UltraGridColumn623.Width = 158
        UltraGridColumn624.Header.VisiblePosition = 30
        UltraGridColumn624.Hidden = True
        UltraGridColumn625.Header.VisiblePosition = 31
        UltraGridColumn625.Hidden = True
        UltraGridColumn626.Header.VisiblePosition = 32
        UltraGridColumn626.Hidden = True
        UltraGridColumn627.Header.VisiblePosition = 9
        UltraGridColumn628.Header.VisiblePosition = 33
        UltraGridColumn628.Hidden = True
        UltraGridColumn629.Header.VisiblePosition = 34
        UltraGridColumn629.Hidden = True
        UltraGridColumn630.Header.VisiblePosition = 35
        UltraGridColumn630.Hidden = True
        UltraGridColumn631.Header.VisiblePosition = 36
        UltraGridColumn631.Hidden = True
        UltraGridColumn632.Header.VisiblePosition = 37
        UltraGridColumn632.Hidden = True
        UltraGridColumn633.Header.VisiblePosition = 38
        UltraGridColumn633.Hidden = True
        UltraGridColumn634.Header.VisiblePosition = 39
        UltraGridColumn634.Hidden = True
        UltraGridColumn635.Header.VisiblePosition = 40
        UltraGridColumn635.Hidden = True
        UltraGridColumn636.Header.VisiblePosition = 41
        UltraGridColumn636.Hidden = True
        UltraGridColumn637.Header.VisiblePosition = 13
        UltraGridColumn638.Header.Caption = "Estado"
        UltraGridColumn638.Header.VisiblePosition = 28
        UltraGridColumn638.Width = 128
        UltraGridColumn639.Header.VisiblePosition = 42
        UltraGridColumn639.Hidden = True
        UltraGridColumn640.Header.Caption = "Proveedor"
        UltraGridColumn640.Header.VisiblePosition = 8
        UltraGridColumn640.Width = 226
        UltraGridColumn641.Header.Caption = "Evaluación"
        UltraGridColumn641.Header.VisiblePosition = 43
        UltraGridColumn642.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn642.Header.VisiblePosition = 44
        UltraGridColumn642.Hidden = True
        UltraGridColumn643.Header.Caption = "Consignación"
        UltraGridColumn643.Header.VisiblePosition = 45
        UltraGridColumn643.Width = 81
        UltraGridColumn644.Header.Caption = "Ref. Documento"
        UltraGridColumn644.Header.VisiblePosition = 29
        UltraGridColumn644.Width = 165
        UltraGridColumn645.Header.VisiblePosition = 47
        UltraGridColumn645.Width = 180
        UltraGridColumn646.Header.VisiblePosition = 48
        UltraGridColumn646.Hidden = True
        UltraGridColumn647.Header.VisiblePosition = 49
        UltraGridColumn647.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 50
        UltraGridColumn1.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn598, UltraGridColumn599, UltraGridColumn600, UltraGridColumn601, UltraGridColumn602, UltraGridColumn603, UltraGridColumn604, UltraGridColumn605, UltraGridColumn606, UltraGridColumn607, UltraGridColumn608, UltraGridColumn609, UltraGridColumn610, UltraGridColumn611, UltraGridColumn612, UltraGridColumn613, UltraGridColumn614, UltraGridColumn615, UltraGridColumn616, UltraGridColumn617, UltraGridColumn618, UltraGridColumn619, UltraGridColumn620, UltraGridColumn621, UltraGridColumn622, UltraGridColumn623, UltraGridColumn624, UltraGridColumn625, UltraGridColumn626, UltraGridColumn627, UltraGridColumn628, UltraGridColumn629, UltraGridColumn630, UltraGridColumn631, UltraGridColumn632, UltraGridColumn633, UltraGridColumn634, UltraGridColumn635, UltraGridColumn636, UltraGridColumn637, UltraGridColumn638, UltraGridColumn639, UltraGridColumn640, UltraGridColumn641, UltraGridColumn642, UltraGridColumn643, UltraGridColumn644, UltraGridColumn645, UltraGridColumn646, UltraGridColumn647, UltraGridColumn1})
        Me.griListaOrdenCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griListaOrdenCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaOrdenCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance184.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance184.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance184.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.Appearance = Appearance184
        Appearance185.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance185
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.Hidden = True
        Appearance186.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance186.BackColor2 = System.Drawing.SystemColors.Control
        Appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance186.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.PromptAppearance = Appearance186
        Me.griListaOrdenCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaOrdenCompra.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaOrdenCompra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaOrdenCompra.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenCompra.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaOrdenCompra.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaOrdenCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaOrdenCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance187.BorderColor = System.Drawing.Color.Silver
        Me.griListaOrdenCompra.DisplayLayout.Override.RowAppearance = Appearance187
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaOrdenCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaOrdenCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaOrdenCompra.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaOrdenCompra.Location = New System.Drawing.Point(3, 46)
        Me.griListaOrdenCompra.Name = "griListaOrdenCompra"
        Me.griListaOrdenCompra.Size = New System.Drawing.Size(1343, 366)
        Me.griListaOrdenCompra.TabIndex = 0
        Me.griListaOrdenCompra.TabStop = False
        Me.griListaOrdenCompra.Text = "Grilla2"
        '
        'odListaOrdenCompra
        '
        UltraDataColumn284.DataType = GetType(Boolean)
        Me.odListaOrdenCompra.Band.Columns.AddRange(New Object() {UltraDataColumn235, UltraDataColumn236, UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242, UltraDataColumn243, UltraDataColumn244, UltraDataColumn245, UltraDataColumn246, UltraDataColumn247, UltraDataColumn248, UltraDataColumn249, UltraDataColumn250, UltraDataColumn251, UltraDataColumn252, UltraDataColumn253, UltraDataColumn254, UltraDataColumn255, UltraDataColumn256, UltraDataColumn257, UltraDataColumn258, UltraDataColumn259, UltraDataColumn260, UltraDataColumn261, UltraDataColumn262, UltraDataColumn263, UltraDataColumn264, UltraDataColumn265, UltraDataColumn266, UltraDataColumn267, UltraDataColumn268, UltraDataColumn269, UltraDataColumn270, UltraDataColumn271, UltraDataColumn272, UltraDataColumn273, UltraDataColumn274, UltraDataColumn275, UltraDataColumn276, UltraDataColumn277, UltraDataColumn278, UltraDataColumn279, UltraDataColumn280, UltraDataColumn281, UltraDataColumn282, UltraDataColumn283, UltraDataColumn284})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btn_GenerarVenta)
        Me.agrMenuLista.Controls.Add(Me.btnEliminarOrden)
        Me.agrMenuLista.Controls.Add(Me.btnCambiarEstado)
        Me.agrMenuLista.Controls.Add(Me.btnRechazar)
        Me.agrMenuLista.Controls.Add(Me.btnBloquear)
        Me.agrMenuLista.Controls.Add(Me.btnHistorial)
        Me.agrMenuLista.Controls.Add(Me.btnAtenderOC)
        Me.agrMenuLista.Controls.Add(Me.btnAprobar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 16)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1343, 30)
        Me.agrMenuLista.TabIndex = 1
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminarOrden
        '
        Appearance189.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance189.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnEliminarOrden.Appearance = Appearance189
        Me.btnEliminarOrden.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminarOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarOrden.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminarOrden.Enabled = False
        Me.btnEliminarOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarOrden.ForeColor = System.Drawing.Color.Black
        Me.btnEliminarOrden.Location = New System.Drawing.Point(468, 3)
        Me.btnEliminarOrden.Name = "btnEliminarOrden"
        Me.btnEliminarOrden.Size = New System.Drawing.Size(80, 24)
        Me.btnEliminarOrden.TabIndex = 6
        Me.btnEliminarOrden.Text = "Eliminar"
        Me.btnEliminarOrden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCambiarEstado
        '
        Appearance190.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance190.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnCambiarEstado.Appearance = Appearance190
        Me.btnCambiarEstado.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCambiarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCambiarEstado.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCambiarEstado.Enabled = False
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.ForeColor = System.Drawing.Color.Black
        Me.btnCambiarEstado.Location = New System.Drawing.Point(388, 3)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(80, 24)
        Me.btnCambiarEstado.TabIndex = 5
        Me.btnCambiarEstado.Text = "Generar"
        Me.btnCambiarEstado.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnRechazar
        '
        Appearance191.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance191.Image = Global.ISL.Win.My.Resources.Resources.Desconectado
        Me.btnRechazar.Appearance = Appearance191
        Me.btnRechazar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRechazar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRechazar.Enabled = False
        Me.btnRechazar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazar.ForeColor = System.Drawing.Color.Black
        Me.btnRechazar.Location = New System.Drawing.Point(308, 3)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(80, 24)
        Me.btnRechazar.TabIndex = 4
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnBloquear
        '
        Appearance192.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance192.Image = CType(resources.GetObject("Appearance192.Image"), Object)
        Me.btnBloquear.Appearance = Appearance192
        Me.btnBloquear.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBloquear.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBloquear.Enabled = False
        Me.btnBloquear.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBloquear.ForeColor = System.Drawing.Color.Black
        Me.btnBloquear.Location = New System.Drawing.Point(228, 3)
        Me.btnBloquear.Name = "btnBloquear"
        Me.btnBloquear.Size = New System.Drawing.Size(80, 24)
        Me.btnBloquear.TabIndex = 3
        Me.btnBloquear.Text = "Bloquear"
        Me.btnBloquear.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnHistorial
        '
        Appearance193.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance193.Image = CType(resources.GetObject("Appearance193.Image"), Object)
        Me.btnHistorial.Appearance = Appearance193
        Me.btnHistorial.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHistorial.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHistorial.Enabled = False
        Me.btnHistorial.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.Black
        Me.btnHistorial.Location = New System.Drawing.Point(152, 3)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(76, 24)
        Me.btnHistorial.TabIndex = 2
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAtenderOC
        '
        Appearance194.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance194.Image = CType(resources.GetObject("Appearance194.Image"), Object)
        Me.btnAtenderOC.Appearance = Appearance194
        Me.btnAtenderOC.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAtenderOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtenderOC.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAtenderOC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtenderOC.ForeColor = System.Drawing.Color.Black
        Me.btnAtenderOC.Location = New System.Drawing.Point(81, 3)
        Me.btnAtenderOC.Name = "btnAtenderOC"
        Me.btnAtenderOC.Size = New System.Drawing.Size(71, 24)
        Me.btnAtenderOC.TabIndex = 1
        Me.btnAtenderOC.Text = "Atender"
        Me.btnAtenderOC.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAprobar
        '
        Appearance195.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance195.Image = CType(resources.GetObject("Appearance195.Image"), Object)
        Me.btnAprobar.Appearance = Appearance195
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.Location = New System.Drawing.Point(3, 3)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(78, 24)
        Me.btnAprobar.TabIndex = 0
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion1
        '
        Appearance196.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion1.Appearance = Appearance196
        Me.Agrupacion1.Controls.Add(Me.Agrupacion20)
        Me.Agrupacion1.Controls.Add(Me.rdbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion19)
        Me.Agrupacion1.Controls.Add(Me.rdbNroOrden)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1349, 125)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion20
        '
        Me.Agrupacion20.Controls.Add(Me.UltraLabel24)
        Me.Agrupacion20.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion20.Controls.Add(Me.chkRuc2)
        Me.Agrupacion20.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion20.Controls.Add(Me.cboProveedorL)
        Me.Agrupacion20.Controls.Add(Me.cboEstadoOrden)
        Me.Agrupacion20.Controls.Add(Me.FechaHasta)
        Me.Agrupacion20.Controls.Add(Me.cboMonedaL)
        Me.Agrupacion20.Controls.Add(Me.FechaDesde)
        Me.Agrupacion20.Controls.Add(Me.UltraLabel16)
        Me.Agrupacion20.Controls.Add(Me.UltraLabel25)
        Me.Agrupacion20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion20.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion20.Location = New System.Drawing.Point(11, 38)
        Me.Agrupacion20.Name = "Agrupacion20"
        Me.Agrupacion20.Size = New System.Drawing.Size(379, 80)
        Me.Agrupacion20.TabIndex = 1
        Me.Agrupacion20.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel24
        '
        Appearance197.BackColor = System.Drawing.Color.Transparent
        Appearance197.ForeColor = System.Drawing.Color.Navy
        Appearance197.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance197
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(10, 6)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel24.TabIndex = 0
        Me.UltraLabel24.Text = "Desde:"
        '
        'Etiqueta7
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance198
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(161, 6)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "Estado:"
        '
        'chkRuc2
        '
        Appearance199.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc2.Appearance = Appearance199
        Me.chkRuc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc2.ForeColor = System.Drawing.Color.Black
        Me.chkRuc2.Location = New System.Drawing.Point(318, 56)
        Me.chkRuc2.Name = "chkRuc2"
        Me.chkRuc2.Size = New System.Drawing.Size(44, 20)
        Me.chkRuc2.TabIndex = 10
        Me.chkRuc2.Text = "Ruc"
        '
        'Etiqueta13
        '
        Appearance200.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance200
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(155, 32)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta13.TabIndex = 6
        Me.Etiqueta13.Text = "Moneda:"
        '
        'cboProveedorL
        '
        Me.cboProveedorL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedorL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedorL.CheckedListSettings.ListSeparator = ","
        Me.cboProveedorL.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedorL.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedorL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedorL.DropDownWidth = 400
        Me.cboProveedorL.Location = New System.Drawing.Point(76, 52)
        Me.cboProveedorL.Name = "cboProveedorL"
        Me.cboProveedorL.Size = New System.Drawing.Size(233, 22)
        Me.cboProveedorL.TabIndex = 9
        '
        'cboEstadoOrden
        '
        Appearance201.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.Appearance = Appearance201
        Me.cboEstadoOrden.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoOrden.DisplayMember = "Nombre"
        Me.cboEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoOrden.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.ImageList = Me.imagenes
        Me.cboEstadoOrden.Location = New System.Drawing.Point(206, 5)
        Me.cboEstadoOrden.Name = "cboEstadoOrden"
        Me.cboEstadoOrden.Size = New System.Drawing.Size(156, 21)
        Me.cboEstadoOrden.TabIndex = 5
        Me.cboEstadoOrden.ValueMember = "Id"
        '
        'FechaHasta
        '
        Me.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaHasta.Location = New System.Drawing.Point(53, 28)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(95, 20)
        Me.FechaHasta.TabIndex = 3
        '
        'cboMonedaL
        '
        Appearance202.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaL.Appearance = Appearance202
        Me.cboMonedaL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMonedaL.DisplayMember = "Nombre"
        Me.cboMonedaL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMonedaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaL.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaL.ImageList = Me.imagenes
        Me.cboMonedaL.Location = New System.Drawing.Point(206, 28)
        Me.cboMonedaL.Name = "cboMonedaL"
        Me.cboMonedaL.Size = New System.Drawing.Size(156, 21)
        Me.cboMonedaL.TabIndex = 7
        Me.cboMonedaL.ValueMember = "Id"
        '
        'FechaDesde
        '
        Me.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDesde.Location = New System.Drawing.Point(53, 4)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(95, 20)
        Me.FechaDesde.TabIndex = 1
        '
        'UltraLabel16
        '
        Appearance203.BackColor = System.Drawing.Color.Transparent
        Appearance203.ForeColor = System.Drawing.Color.Navy
        Appearance203.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance203
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(10, 56)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(60, 15)
        Me.UltraLabel16.TabIndex = 8
        Me.UltraLabel16.Text = "Proveedor :"
        '
        'UltraLabel25
        '
        Appearance204.BackColor = System.Drawing.Color.Transparent
        Appearance204.ForeColor = System.Drawing.Color.Navy
        Appearance204.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance204
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(10, 32)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel25.TabIndex = 2
        Me.UltraLabel25.Text = "Hasta:"
        '
        'rdbDatosAdicionales
        '
        Me.rdbDatosAdicionales.AutoSize = True
        Me.rdbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosAdicionales.Checked = True
        Me.rdbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosAdicionales.Location = New System.Drawing.Point(12, 21)
        Me.rdbDatosAdicionales.Name = "rdbDatosAdicionales"
        Me.rdbDatosAdicionales.Size = New System.Drawing.Size(107, 17)
        Me.rdbDatosAdicionales.TabIndex = 0
        Me.rdbDatosAdicionales.TabStop = True
        Me.rdbDatosAdicionales.Text = "DatosAdicionales"
        Me.rdbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'Agrupacion19
        '
        Me.Agrupacion19.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion19.Controls.Add(Me.txtNroOrdenCompra)
        Me.Agrupacion19.Enabled = False
        Me.Agrupacion19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion19.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion19.Location = New System.Drawing.Point(396, 38)
        Me.Agrupacion19.Name = "Agrupacion19"
        Me.Agrupacion19.Size = New System.Drawing.Size(200, 35)
        Me.Agrupacion19.TabIndex = 3
        Me.Agrupacion19.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta11
        '
        Appearance205.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance205
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(6, 13)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta11.TabIndex = 0
        Me.Etiqueta11.Text = "NroOrd:"
        '
        'txtNroOrdenCompra
        '
        Appearance206.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrdenCompra.Appearance = Appearance206
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrdenCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(55, 9)
        Me.txtNroOrdenCompra.MaxLength = 13
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(139, 21)
        Me.txtNroOrdenCompra.TabIndex = 1
        '
        'rdbNroOrden
        '
        Me.rdbNroOrden.AutoSize = True
        Me.rdbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rdbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rdbNroOrden.Location = New System.Drawing.Point(397, 21)
        Me.rdbNroOrden.Name = "rdbNroOrden"
        Me.rdbNroOrden.Size = New System.Drawing.Size(71, 17)
        Me.rdbNroOrden.TabIndex = 2
        Me.rdbNroOrden.TabStop = True
        Me.rdbNroOrden.Text = "NroOrden"
        Me.rdbNroOrden.UseVisualStyleBackColor = False
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.ColoresAtendido)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion7.Controls.Add(Me.ColoresPreEvaluada)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion7.Controls.Add(Me.ColoresRechazada)
        Me.Agrupacion7.Controls.Add(Me.ColoresTerminada)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion7.Controls.Add(Me.ColoresAtendidoParcialmente)
        Me.Agrupacion7.Controls.Add(Me.etiTerminada)
        Me.Agrupacion7.Controls.Add(Me.ColoresEvaluado)
        Me.Agrupacion7.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion7.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion7.Controls.Add(Me.etiGenerada)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Navy
        Me.Agrupacion7.Location = New System.Drawing.Point(611, 24)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(568, 79)
        Me.Agrupacion7.TabIndex = 6
        Me.Agrupacion7.Text = "Estados"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresAtendido
        '
        Me.ColoresAtendido.Location = New System.Drawing.Point(343, 40)
        Me.ColoresAtendido.Name = "ColoresAtendido"
        Me.ColoresAtendido.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAtendido.TabIndex = 9
        Me.ColoresAtendido.TabStop = False
        Me.ColoresAtendido.Text = "Control"
        '
        'Etiqueta10
        '
        Appearance207.BackColor = System.Drawing.Color.Transparent
        Appearance207.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Appearance = Appearance207
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(342, 22)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta10.TabIndex = 8
        Me.Etiqueta10.Text = "Atendida"
        '
        'ColoresPreEvaluada
        '
        Me.ColoresPreEvaluada.Location = New System.Drawing.Point(84, 41)
        Me.ColoresPreEvaluada.Name = "ColoresPreEvaluada"
        Me.ColoresPreEvaluada.Size = New System.Drawing.Size(46, 21)
        Me.ColoresPreEvaluada.TabIndex = 3
        Me.ColoresPreEvaluada.TabStop = False
        Me.ColoresPreEvaluada.Text = "Control"
        '
        'Etiqueta5
        '
        Appearance208.BackColor = System.Drawing.Color.Transparent
        Appearance208.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Appearance = Appearance208
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(74, 24)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Pre-Evaluada"
        '
        'Etiqueta4
        '
        Appearance209.BackColor = System.Drawing.Color.Transparent
        Appearance209.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Appearance = Appearance209
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(495, 22)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta4.TabIndex = 12
        Me.Etiqueta4.Text = "Rechazada"
        '
        'ColoresRechazada
        '
        Me.ColoresRechazada.Location = New System.Drawing.Point(494, 40)
        Me.ColoresRechazada.Name = "ColoresRechazada"
        Me.ColoresRechazada.Size = New System.Drawing.Size(46, 21)
        Me.ColoresRechazada.TabIndex = 13
        Me.ColoresRechazada.TabStop = False
        Me.ColoresRechazada.Text = "Control"
        '
        'ColoresTerminada
        '
        Me.ColoresTerminada.Location = New System.Drawing.Point(416, 40)
        Me.ColoresTerminada.Name = "ColoresTerminada"
        Me.ColoresTerminada.Size = New System.Drawing.Size(46, 21)
        Me.ColoresTerminada.TabIndex = 11
        Me.ColoresTerminada.TabStop = False
        Me.ColoresTerminada.Text = "Control"
        '
        'Etiqueta1
        '
        Appearance210.BackColor = System.Drawing.Color.Transparent
        Appearance210.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Appearance = Appearance210
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(415, 22)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta1.TabIndex = 10
        Me.Etiqueta1.Text = "Terminada"
        '
        'ColoresAtendidoParcialmente
        '
        Me.ColoresAtendidoParcialmente.Location = New System.Drawing.Point(245, 40)
        Me.ColoresAtendidoParcialmente.Name = "ColoresAtendidoParcialmente"
        Me.ColoresAtendidoParcialmente.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAtendidoParcialmente.TabIndex = 7
        Me.ColoresAtendidoParcialmente.TabStop = False
        Me.ColoresAtendidoParcialmente.Text = "Control"
        '
        'etiTerminada
        '
        Appearance211.BackColor = System.Drawing.Color.Transparent
        Appearance211.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance211
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(213, 23)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(113, 15)
        Me.etiTerminada.TabIndex = 6
        Me.etiTerminada.Text = "Atendido Parcialmente"
        '
        'ColoresEvaluado
        '
        Me.ColoresEvaluado.Color = System.Drawing.Color.Empty
        Me.ColoresEvaluado.Location = New System.Drawing.Point(157, 40)
        Me.ColoresEvaluado.Name = "ColoresEvaluado"
        Me.ColoresEvaluado.Size = New System.Drawing.Size(43, 21)
        Me.ColoresEvaluado.TabIndex = 5
        Me.ColoresEvaluado.TabStop = False
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Color = System.Drawing.Color.Empty
        Me.ColoresGenerado.Location = New System.Drawing.Point(7, 40)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.TabStop = False
        '
        'etiEnProceso
        '
        Appearance212.BackColor = System.Drawing.Color.Transparent
        Appearance212.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance212
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(154, 23)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(48, 15)
        Me.etiEnProceso.TabIndex = 4
        Me.etiEnProceso.Text = "Evaluado"
        '
        'etiGenerada
        '
        Appearance213.BackColor = System.Drawing.Color.Transparent
        Appearance213.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance213
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 23)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generado"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficDetalleOCMateriales)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea6)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea7)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea8)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1349, 540)
        '
        'ficDetalleOCMateriales
        '
        Me.ficDetalleOCMateriales.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.ficDetalleOCMateriales.Controls.Add(Me.UltraTabPageControl12)
        Me.ficDetalleOCMateriales.Controls.Add(Me.UltraTabPageControl13)
        Me.ficDetalleOCMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalleOCMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalleOCMateriales.Location = New System.Drawing.Point(0, 237)
        Me.ficDetalleOCMateriales.Name = "ficDetalleOCMateriales"
        Me.ficDetalleOCMateriales.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.ficDetalleOCMateriales.Size = New System.Drawing.Size(1349, 303)
        Me.ficDetalleOCMateriales.TabIndex = 1
        UltraTab12.TabPage = Me.UltraTabPageControl12
        UltraTab12.Text = "Detalle - OC"
        UltraTab13.TabPage = Me.UltraTabPageControl13
        UltraTab13.Text = "Orden's de Ingreso"
        Me.ficDetalleOCMateriales.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab12, UltraTab13})
        Me.ficDetalleOCMateriales.TabStop = False
        Me.ficDetalleOCMateriales.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1347, 280)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(0, 211)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1349, 26)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.MenuDetalle
        '
        'MenuDetalle
        '
        Appearance214.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.Appearance = Appearance214
        Me.MenuDetalle.DesignerFlags = 1
        Me.MenuDetalle.DockWithinContainer = Me
        Me.MenuDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuDetalle.ImageListLarge = Me.imagenes
        Me.MenuDetalle.ImageListSmall = Me.imagenes
        Me.MenuDetalle.MdiMergeable = False
        Me.MenuDetalle.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        Me.MenuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(75, 428)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(139, 164)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool35, PopupMenuTool3, ButtonTool31, ButtonTool1})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.MenuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance215.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.ToolbarSettings.Appearance = Appearance215
        Appearance216.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.ToolbarSettings.ToolAppearance = Appearance216
        Appearance217.Image = 7
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance217
        ButtonTool9.SharedPropsInternal.Caption = "Importar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool10.SharedPropsInternal.Caption = "Editar"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance218.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        ButtonTool12.SharedPropsInternal.AppearancesSmall.Appearance = Appearance218
        ButtonTool12.SharedPropsInternal.Caption = "Quitar"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool13.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool13.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool14.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance219.Image = 6
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance219
        ButtonTool15.SharedPropsInternal.Caption = "Listar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance220.Image = 2
        ButtonTool16.SharedPropsInternal.AppearancesSmall.Appearance = Appearance220
        ButtonTool16.SharedPropsInternal.Caption = "Generar OI"
        ButtonTool16.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance221.Image = 3
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance221
        ButtonTool17.SharedPropsInternal.Caption = "Ejecutar OI"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool18.SharedPropsInternal.Caption = "Importar"
        ButtonTool18.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance222.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance222
        ButtonTool19.SharedPropsInternal.Caption = "Agregar"
        ButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance223.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool4.Settings.Appearance = Appearance223
        Appearance224.ForeColor = System.Drawing.Color.Navy
        Appearance224.Image = 4
        PopupMenuTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance224
        PopupMenuTool4.SharedPropsInternal.Caption = "Generar Documento"
        PopupMenuTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        PopupMenuTool4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool11, ButtonTool20, ButtonTool21})
        Appearance225.Image = 4
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance225
        ButtonTool22.SharedPropsInternal.Caption = "Generar Factura"
        ButtonTool22.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance226.Image = 4
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance226
        ButtonTool23.SharedPropsInternal.Caption = "Generar Boleta"
        ButtonTool23.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance227.Image = 4
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance227
        ButtonTool24.SharedPropsInternal.Caption = "Generar Guía"
        Me.MenuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool9, ButtonTool10, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18, ButtonTool19, PopupMenuTool4, ButtonTool22, ButtonTool23, ButtonTool24})
        '
        'UltraToolbarsDockArea6
        '
        Me.UltraToolbarsDockArea6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea6.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea6.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea6.Location = New System.Drawing.Point(0, 540)
        Me.UltraToolbarsDockArea6.Name = "UltraToolbarsDockArea6"
        Me.UltraToolbarsDockArea6.Size = New System.Drawing.Size(1349, 0)
        Me.UltraToolbarsDockArea6.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea7
        '
        Me.UltraToolbarsDockArea7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea7.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea7.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea7.Location = New System.Drawing.Point(0, 211)
        Me.UltraToolbarsDockArea7.Name = "UltraToolbarsDockArea7"
        Me.UltraToolbarsDockArea7.Size = New System.Drawing.Size(0, 329)
        Me.UltraToolbarsDockArea7.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea8
        '
        Me.UltraToolbarsDockArea8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea8.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea8.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea8.Location = New System.Drawing.Point(1349, 211)
        Me.UltraToolbarsDockArea8.Name = "UltraToolbarsDockArea8"
        Me.UltraToolbarsDockArea8.Size = New System.Drawing.Size(0, 329)
        Me.UltraToolbarsDockArea8.ToolbarsManager = Me.MenuDetalle
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.FichaTop)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Navy
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1349, 211)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'FichaTop
        '
        Me.FichaTop.Controls.Add(Me.UltraTabSharedControlsPage6)
        Me.FichaTop.Controls.Add(Me.UltraTabPageControl4)
        Me.FichaTop.Controls.Add(Me.UltraTabPageControl8)
        Me.FichaTop.Controls.Add(Me.UltraTabPageControl7)
        Me.FichaTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FichaTop.Location = New System.Drawing.Point(2, 2)
        Me.FichaTop.Name = "FichaTop"
        Me.FichaTop.SharedControlsPage = Me.UltraTabSharedControlsPage6
        Me.FichaTop.Size = New System.Drawing.Size(1345, 207)
        Me.FichaTop.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.FichaTop.TabIndex = 0
        UltraTab15.Key = "0"
        UltraTab15.TabPage = Me.UltraTabPageControl4
        UltraTab15.Text = "Datos Generales"
        UltraTab16.TabPage = Me.UltraTabPageControl7
        UltraTab16.Text = "Nota de Credito"
        UltraTab17.Key = "1"
        UltraTab17.TabPage = Me.UltraTabPageControl8
        UltraTab17.Text = "Percepción / Detracción"
        Me.FichaTop.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab15, UltraTab16, UltraTab17})
        Me.FichaTop.TabStop = False
        Me.FichaTop.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage6
        '
        Me.UltraTabSharedControlsPage6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage6.Name = "UltraTabSharedControlsPage6"
        Me.UltraTabSharedControlsPage6.Size = New System.Drawing.Size(1343, 184)
        '
        'odServicio
        '
        UltraDataColumn293.DataType = GetType(Boolean)
        UltraDataColumn294.DataType = GetType(Boolean)
        UltraDataColumn294.DefaultValue = False
        Me.odServicio.Band.Columns.AddRange(New Object() {UltraDataColumn285, UltraDataColumn286, UltraDataColumn287, UltraDataColumn288, UltraDataColumn289, UltraDataColumn290, UltraDataColumn291, UltraDataColumn292, UltraDataColumn293, UltraDataColumn294, UltraDataColumn295, UltraDataColumn296})
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.AprobarToolStripMenuItem, Me.AtenderToolStripMenuItem, Me.EnviarCorreoToolStripMenuItem, Me.RechazarToolStripMenuItem, Me.CambiarEstadoToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(136, 180)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Requerimiento"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EditarToolStripMenuItem.Text = "Actualizar"
        Me.EditarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Requerimiento seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'AprobarToolStripMenuItem
        '
        Me.AprobarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.AprobarToolStripMenuItem.Name = "AprobarToolStripMenuItem"
        Me.AprobarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AprobarToolStripMenuItem.Text = "Aprobar"
        '
        'AtenderToolStripMenuItem
        '
        Me.AtenderToolStripMenuItem.Image = CType(resources.GetObject("AtenderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AtenderToolStripMenuItem.Name = "AtenderToolStripMenuItem"
        Me.AtenderToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AtenderToolStripMenuItem.Text = "Atender"
        '
        'EnviarCorreoToolStripMenuItem
        '
        Me.EnviarCorreoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
        Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EnviarCorreoToolStripMenuItem.Text = "Enviar e-Mail"
        '
        'RechazarToolStripMenuItem
        '
        Me.RechazarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.RechazarToolStripMenuItem.Name = "RechazarToolStripMenuItem"
        Me.RechazarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RechazarToolStripMenuItem.Text = "Rechazar"
        '
        'CambiarEstadoToolStripMenuItem
        '
        Me.CambiarEstadoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.CambiarEstadoToolStripMenuItem.Name = "CambiarEstadoToolStripMenuItem"
        Me.CambiarEstadoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CambiarEstadoToolStripMenuItem.Text = "Generar"
        '
        'MenuContextualReq
        '
        Me.MenuContextualReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextualReq.ForeColor = System.Drawing.Color.Black
        Me.MenuContextualReq.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechazarStripMenuItem1})
        Me.MenuContextualReq.Name = "MenuContextual1"
        Me.MenuContextualReq.Size = New System.Drawing.Size(121, 26)
        '
        'RechazarStripMenuItem1
        '
        Me.RechazarStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.RechazarStripMenuItem1.Name = "RechazarStripMenuItem1"
        Me.RechazarStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.RechazarStripMenuItem1.Text = "Rechazar"
        Me.RechazarStripMenuItem1.ToolTipText = "Rechazar requerimiento"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NumeroDecimal1
        '
        Appearance228.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Appearance = Appearance228
        Me.NumeroDecimal1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal1.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Location = New System.Drawing.Point(377, 6)
        Me.NumeroDecimal1.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.NumeroDecimal1.Name = "NumeroDecimal1"
        Me.NumeroDecimal1.NullText = "0.00"
        Me.NumeroDecimal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal1.ReadOnly = True
        Me.NumeroDecimal1.Size = New System.Drawing.Size(123, 21)
        Me.NumeroDecimal1.TabIndex = 288
        '
        'UltraLabel27
        '
        Appearance229.BackColor = System.Drawing.Color.Transparent
        Appearance229.ForeColor = System.Drawing.Color.Navy
        Appearance229.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance229
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(6, 11)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel27.TabIndex = 268
        Me.UltraLabel27.Text = "Subtotal:"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage7
        Me.UltraTabControl1.Size = New System.Drawing.Size(200, 100)
        Me.UltraTabControl1.TabIndex = 0
        '
        'UltraTabSharedControlsPage7
        '
        Me.UltraTabSharedControlsPage7.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage7.Name = "UltraTabSharedControlsPage7"
        Me.UltraTabSharedControlsPage7.Size = New System.Drawing.Size(196, 77)
        '
        'ficOrdenCompra
        '
        Me.ficOrdenCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrdenCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrdenCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOrdenCompra.Location = New System.Drawing.Point(0, 0)
        Me.ficOrdenCompra.Name = "ficOrdenCompra"
        Me.ficOrdenCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrdenCompra.Size = New System.Drawing.Size(1351, 563)
        Me.ficOrdenCompra.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficOrdenCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficOrdenCompra.TabStop = False
        Me.ficOrdenCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1349, 540)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(478, 333)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(393, 67)
        Me.ugb_Espera.TabIndex = 3
        Me.ugb_Espera.Visible = False
        '
        'btn_GenerarVenta
        '
        Appearance188.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance188.Image = Global.ISL.Win.My.Resources.Resources.user_male_add
        Me.btn_GenerarVenta.Appearance = Appearance188
        Me.btn_GenerarVenta.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_GenerarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_GenerarVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_GenerarVenta.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GenerarVenta.ForeColor = System.Drawing.Color.Black
        Me.btn_GenerarVenta.Location = New System.Drawing.Point(548, 3)
        Me.btn_GenerarVenta.Name = "btn_GenerarVenta"
        Me.btn_GenerarVenta.Size = New System.Drawing.Size(78, 24)
        Me.btn_GenerarVenta.TabIndex = 7
        Me.btn_GenerarVenta.Text = "Venta"
        Me.btn_GenerarVenta.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frm_OrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1351, 563)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficOrdenCompra)
        Me.Name = "frm_OrdenCompra"
        Me.Text = "Orden de Compra"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griListaRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Agrupacion14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion14.ResumeLayout(False)
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion13.ResumeLayout(False)
        Me.Agrupacion13.PerformLayout()
        CType(Me.chkBuscaCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griListadoCotizacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCotizacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        CType(Me.cboProveedorCot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.gridDetalleOCMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOCMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeListadoMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeListadoMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.utcListadosMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcListadosMateriales.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.griDetalleOrdenIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleOrdenIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griListaOrdenIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextualOI.ResumeLayout(False)
        CType(Me.odOrdenIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion16.ResumeLayout(False)
        CType(Me.griHistorialRechazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        Me.Agrupacion11.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcenIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheReqAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheEntregasParciales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheAutoAprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.Agrupacion17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion17.ResumeLayout(False)
        Me.Agrupacion17.PerformLayout()
        CType(Me.cboTipoOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion18.ResumeLayout(False)
        Me.Agrupacion18.PerformLayout()
        CType(Me.decTotalIGVNCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecNotaCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decIGVNCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSubTotalNCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroNotaCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSreNotaCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        CType(Me.agrPercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrPercepcion.ResumeLayout(False)
        Me.agrPercepcion.PerformLayout()
        CType(Me.DecPorcentajePercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheActivoPercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecPercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetraccion.ResumeLayout(False)
        Me.agrDetraccion.PerformLayout()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecMontoDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetoPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenCompra.ResumeLayout(False)
        CType(Me.griListaOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListaOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.Agrupacion20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion20.ResumeLayout(False)
        Me.Agrupacion20.PerformLayout()
        CType(Me.chkRuc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedorL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonedaL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion19.ResumeLayout(False)
        Me.Agrupacion19.PerformLayout()
        CType(Me.txtNroOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresPreEvaluada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresRechazada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficDetalleOCMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalleOCMateriales.ResumeLayout(False)
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.FichaTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FichaTop.ResumeLayout(False)
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.MenuContextualReq.ResumeLayout(False)
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrdenCompra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odListaOrdenCompra As ISL.Controles.OrigenDatos
    Friend WithEvents odRequerimientos As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextualReq As ISL.Controles.MenuContextual
    Friend WithEvents RechazarStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odServicio As ISL.Controles.OrigenDatos
    Friend WithEvents AprobarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents ficOrdenCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOrdenCompra As ISL.Controles.Agrupacion
    Friend WithEvents griListaOrdenCompra As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnAprobar As ISL.Controles.Boton
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresTerminada As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresAtendidoParcialmente As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEvaluado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMonedaL As ISL.Controles.ComboMaestros
    Friend WithEvents cboEstadoOrden As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents btnAtenderOC As ISL.Controles.Boton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPorcenIGV As ISL.Controles.Texto
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents cheReqAsoc As ISL.Controles.Chequear
    Friend WithEvents cheEntregasParciales As ISL.Controles.Chequear
    Friend WithEvents cheAutoAprobar As ISL.Controles.Chequear
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservaciones As ISL.Controles.Texto
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbNumeroOrden As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumeroOrden As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odOCMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents odOrdenIngreso As ISL.Controles.OrigenDatos
    Friend WithEvents odDetalleOrdenIngreso As ISL.Controles.OrigenDatos
    Friend WithEvents btnEnviarCorreo As ISL.Controles.Boton
    Friend WithEvents odCotizacionDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EnviarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuContextualOI As ISL.Controles.MenuContextual
    Friend WithEvents TSM_Factura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Boleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Guia As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkRuc As ISL.Controles.Chequear
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents txtTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIGV As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrPercepcion As ISL.Controles.Agrupacion
    Friend WithEvents cheActivoPercepcion As ISL.Controles.Chequear
    Friend WithEvents DecPorcentajePercepcion As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecPercepcion As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecTPagar As ISL.Controles.NumeroDecimal
    Friend WithEvents agrDetraccion As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecDetraer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecMontoDetraccion As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNetoPagar As ISL.Controles.NumeroDecimal
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents FichaTop As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage6 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmdSolesDolares As ISL.Controles.Boton
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnHistorial As ISL.Controles.Boton
    Friend WithEvents btnBloquear As ISL.Controles.Boton
    Friend WithEvents FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecFechaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkRuc2 As ISL.Controles.Chequear
    Private WithEvents cboProveedorL As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents RechazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTerminarOC As ISL.Controles.Boton
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresRechazada As ISL.Controles.Colores
    Friend WithEvents btnRechazar As ISL.Controles.Boton
    Friend WithEvents Agrupacion16 As ISL.Controles.Agrupacion
    Friend WithEvents griHistorialRechazo As ISL.Controles.Grilla
    Friend WithEvents ColoresPreEvaluada As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion17 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion18 As ISL.Controles.Agrupacion
    Friend WithEvents fecNotaCD As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtNroNotaCD As ISL.Controles.Texto
    Friend WithEvents txtSreNotaCD As ISL.Controles.Texto
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage7 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents NumeroDecimal1 As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTotalIGVNCD As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decIGVNCD As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decSubTotalNCD As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ColoresAtendido As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroOrdenCompra As ISL.Controles.Texto
    Friend WithEvents Agrupacion20 As ISL.Controles.Agrupacion
    Friend WithEvents rdbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents Agrupacion19 As ISL.Controles.Agrupacion
    Friend WithEvents rdbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents ficDetalleOCMateriales As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridDetalleOCMaterial As ISL.Controles.Grilla
    Friend WithEvents gbeListadoMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents utcListadosMateriales As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaRequerimientos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListadoCotizacionDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents rfFechaCotHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents rfFechaCotDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents btnBuscarCot As ISL.Controles.Boton
    Friend WithEvents cboProveedorCot As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion14 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion13 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarMateriales As ISL.Controles.Boton
    Friend WithEvents txtBuscarMateriales As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDetalleOrdenIngreso As ISL.Controles.Grilla
    Friend WithEvents griListaOrdenIngreso As ISL.Controles.Grilla
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents MenuDetalle As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea6 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea7 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea8 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents rdbUrgente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNormal As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCambiarEstado As ISL.Controles.Boton
    Friend WithEvents CambiarEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodBarras As ISL.Controles.Texto
    Friend WithEvents chkBuscaCodigo As ISL.Controles.Chequear
    Friend WithEvents btnModificarPrecios As ISL.Controles.Boton
    Friend WithEvents cboTipoOrdenCompra As ISL.Controles.ComboMaestros
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents cbCentro As ISL.Controles.Chequear
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnEliminarOrden As ISL.Controles.Boton
    Friend WithEvents griListaMateriales As ISL.Controles.Grilla
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNotas As ISL.Controles.Texto
    Friend WithEvents btn_GenerarVenta As Controles.Boton
End Class
