<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AprobarOrdenesCompra
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
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioConImp")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialPendiente")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialAAtender")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSolesSinImp")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenSalidaMaterial")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
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
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSinImp")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioConImp")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialPendiente")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialAAtender")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSolesSinImp")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenSalidaMaterial")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pos")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoServicio")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioConImp")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoServicio")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSolesSinImp")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoServicio")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSinImp")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioConImp")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoServicio")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSolesSinImp")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pos")
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim GradientEffect1 As Infragistics.UltraChart.Resources.Appearance.GradientEffect = New Infragistics.UltraChart.Resources.Appearance.GradientEffect()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGuia")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorMaterial")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorServicio")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacionEmergencia")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorRechazo")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorDocumentoAsociado")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorVariasEntregas")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrdenCompra")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorConsignacion")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consignacion")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGuia")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorMaterial")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorServicio")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacionEmergencia")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorRechazo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorDocumentoAsociado")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorVariasEntregas")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrdenCompra")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorConsignacion")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consignacion")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorAprobacion")
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AprobarOrdenesCompra))
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaDetalleOrdenCompraMaterial = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenCompraMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaDetalleOrdenCompraServicio = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenCompraServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtNumeroOrden = New ISL.Controles.Texto(Me.components)
        Me.txtFechaOrden = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.gbeListadoHistorial = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.panelOcultarGrafico = New Infragistics.Win.Misc.UltraPanel()
        Me.chaHistorialCompras = New Infragistics.Win.UltraWinChart.UltraChart()
        Me.gbeListadoMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griHistorialCompras = New ISL.Controles.Grilla(Me.components)
        Me.odHistorialCompras = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrOrdenCompra = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaOrdenCompra = New ISL.Controles.Grilla(Me.components)
        Me.odListaOrdenCompra = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.verLimites = New ISL.Controles.Chequear(Me.components)
        Me.rfOrdenHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfOrdenDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnRechazar = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresRechazado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAtendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAtendidoParcialmente = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEvaluado = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFormaBusqueda = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboMaterialServicio = New ISL.Controles.ComboMaestros(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstadoOrden = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.AprobarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ficRequerimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTip = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griListaDetalleOrdenCompraMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenCompraMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListaDetalleOrdenCompraServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenCompraServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.txtNumeroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeListadoHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeListadoHistorial.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        Me.panelOcultarGrafico.SuspendLayout()
        CType(Me.chaHistorialCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeListadoMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeListadoMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griHistorialCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odHistorialCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenCompra.SuspendLayout()
        CType(Me.griListaOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListaOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.verLimites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.ColoresRechazado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterialServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ficRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficRequerimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griListaDetalleOrdenCompraMaterial)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1258, 414)
        '
        'griListaDetalleOrdenCompraMaterial
        '
        Me.griListaDetalleOrdenCompraMaterial.DataSource = Me.odOrdenCompraMaterial
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 61
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Codigo"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 193
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance1
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn7.Header.Caption = "Cantidad"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance2
        UltraGridColumn8.Header.Caption = "PU S/Imp"
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn8.Width = 81
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance3
        UltraGridColumn9.Header.Caption = "PU C/Imp"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn9.Width = 87
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance4
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn10.Width = 84
        UltraGridColumn11.Header.Caption = "N° Req."
        UltraGridColumn11.Header.VisiblePosition = 17
        UltraGridColumn12.Header.VisiblePosition = 14
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 18
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 16
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn16.CellAppearance = Appearance5
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn16.Header.VisiblePosition = 19
        UltraGridColumn16.Width = 138
        UltraGridColumn17.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn17.Header.Caption = "Igv"
        UltraGridColumn17.Header.VisiblePosition = 8
        UltraGridColumn17.Width = 54
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance6
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn18.Header.Caption = "Pediente"
        UltraGridColumn18.Header.VisiblePosition = 12
        UltraGridColumn18.MaskInput = "{double:9.4}"
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.Width = 85
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance7
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn19.Header.Caption = "Atender"
        UltraGridColumn19.Header.VisiblePosition = 13
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.MaskInput = "{double:9.4}"
        UltraGridColumn19.Width = 62
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.Caption = "Unid. Med."
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 28
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 27
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn35.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35})
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.GroupByBox.Appearance = Appearance8
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance9
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance10.BackColor2 = System.Drawing.SystemColors.Control
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance10
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Highlight
        Appearance12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance12
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance13
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Appearance14.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.CellAppearance = Appearance14
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.CellPadding = 0
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance15.BackColor = System.Drawing.SystemColors.Control
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance15
        Appearance16.TextHAlignAsString = "Center"
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.RowAppearance = Appearance17
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDetalleOrdenCompraMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaDetalleOrdenCompraMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDetalleOrdenCompraMaterial.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDetalleOrdenCompraMaterial.Location = New System.Drawing.Point(0, 0)
        Me.griListaDetalleOrdenCompraMaterial.Name = "griListaDetalleOrdenCompraMaterial"
        Me.griListaDetalleOrdenCompraMaterial.Size = New System.Drawing.Size(1258, 414)
        Me.griListaDetalleOrdenCompraMaterial.TabIndex = 8
        Me.griListaDetalleOrdenCompraMaterial.Text = "Grilla2"
        '
        'odOrdenCompraMaterial
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataColumn17.DefaultValue = False
        UltraDataColumn18.DataType = GetType(Decimal)
        Me.odOrdenCompraMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListaDetalleOrdenCompraServicio)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1260, 413)
        '
        'griListaDetalleOrdenCompraServicio
        '
        Me.griListaDetalleOrdenCompraServicio.DataSource = Me.odOrdenCompraServicio
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.Width = 61
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.Caption = "Codigo"
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn41.Width = 334
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridColumn43.Header.Caption = "PU S/Imp"
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn44.Header.Caption = "PU C/Imp"
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn46.Header.Caption = "N° Req."
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn47.Header.VisiblePosition = 11
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 12
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn49.CellAppearance = Appearance19
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn49.Header.VisiblePosition = 13
        UltraGridColumn49.Width = 138
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn50.Header.Caption = "Igv"
        UltraGridColumn50.Header.VisiblePosition = 14
        UltraGridColumn51.Header.VisiblePosition = 15
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 18
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 16
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 17
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 19
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 20
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 21
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 22
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 23
        UltraGridColumn59.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.Hidden = True
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.SystemColors.Highlight
        Appearance24.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.ActiveRowAppearance = Appearance24
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Appearance26.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CellAppearance = Appearance26
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CellPadding = 0
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance27.BackColor = System.Drawing.SystemColors.Control
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.GroupByRowAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Center"
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowAppearance = Appearance29
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.TemplateAddRowAppearance = Appearance30
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaDetalleOrdenCompraServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDetalleOrdenCompraServicio.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.griListaDetalleOrdenCompraServicio.Location = New System.Drawing.Point(0, 0)
        Me.griListaDetalleOrdenCompraServicio.Name = "griListaDetalleOrdenCompraServicio"
        Me.griListaDetalleOrdenCompraServicio.Size = New System.Drawing.Size(1260, 413)
        Me.griListaDetalleOrdenCompraServicio.TabIndex = 246
        Me.griListaDetalleOrdenCompraServicio.Text = "Grilla2"
        '
        'odOrdenCompraServicio
        '
        UltraDataColumn36.DataType = GetType(Boolean)
        UltraDataColumn36.DefaultValue = False
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn50.DataType = GetType(Boolean)
        UltraDataColumn50.DefaultValue = False
        Me.odOrdenCompraServicio.Band.Columns.AddRange(New Object() {UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenCompra)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1270, 723)
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion6.Controls.Add(Me.gbeListadoHistorial)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 208)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1270, 515)
        Me.Agrupacion6.TabIndex = 250
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ficDetalle)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1266, 487)
        Me.Agrupacion2.TabIndex = 9
        Me.Agrupacion2.Text = "Detalle de OC"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalle.Location = New System.Drawing.Point(3, 47)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalle.Size = New System.Drawing.Size(1260, 437)
        Me.ficDetalle.TabIndex = 290
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Materiales"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Servicios"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1258, 414)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.txtNumeroOrden)
        Me.Agrupacion5.Controls.Add(Me.txtFechaOrden)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel22)
        Me.Agrupacion5.Controls.Add(Me.txtProveedor)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(3, 17)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1260, 30)
        Me.Agrupacion5.TabIndex = 289
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtNumeroOrden
        '
        Me.txtNumeroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroOrden.Location = New System.Drawing.Point(41, 4)
        Me.txtNumeroOrden.Name = "txtNumeroOrden"
        Me.txtNumeroOrden.Size = New System.Drawing.Size(170, 22)
        Me.txtNumeroOrden.TabIndex = 283
        '
        'txtFechaOrden
        '
        Me.txtFechaOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFechaOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaOrden.Location = New System.Drawing.Point(656, 4)
        Me.txtFechaOrden.Name = "txtFechaOrden"
        Me.txtFechaOrden.ReadOnly = True
        Me.txtFechaOrden.Size = New System.Drawing.Size(201, 22)
        Me.txtFechaOrden.TabIndex = 288
        '
        'UltraLabel2
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance31
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 7)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(21, 15)
        Me.UltraLabel2.TabIndex = 284
        Me.UltraLabel2.Text = "N°:"
        '
        'UltraLabel1
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance32
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(615, 7)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 287
        Me.UltraLabel1.Text = "Fecha:"
        '
        'UltraLabel22
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance33
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(228, 7)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel22.TabIndex = 285
        Me.UltraLabel22.Text = "Proveedor:"
        '
        'txtProveedor
        '
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(289, 4)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(313, 22)
        Me.txtProveedor.TabIndex = 286
        '
        'gbeListadoHistorial
        '
        Me.gbeListadoHistorial.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeListadoHistorial.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.gbeListadoHistorial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbeListadoHistorial.Expanded = False
        Me.gbeListadoHistorial.ExpandedSize = New System.Drawing.Size(1266, 227)
        Me.gbeListadoHistorial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbeListadoHistorial.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.gbeListadoHistorial.Location = New System.Drawing.Point(2, 489)
        Me.gbeListadoHistorial.Name = "gbeListadoHistorial"
        Me.gbeListadoHistorial.Size = New System.Drawing.Size(1266, 24)
        Me.gbeListadoHistorial.TabIndex = 249
        Me.gbeListadoHistorial.Text = "Historial de Compras"
        Me.gbeListadoHistorial.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.panelOcultarGrafico)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.chaHistorialCompras)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.gbeListadoMateriales)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1262, 203)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'panelOcultarGrafico
        '
        Me.panelOcultarGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOcultarGrafico.Location = New System.Drawing.Point(611, 0)
        Me.panelOcultarGrafico.Name = "panelOcultarGrafico"
        Me.panelOcultarGrafico.Size = New System.Drawing.Size(651, 203)
        Me.panelOcultarGrafico.TabIndex = 248
        Me.panelOcultarGrafico.Visible = False
        '
        '			'UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
        '			'ChartType' must be persisted ahead of any Axes change made in design time.
        '		
        Me.chaHistorialCompras.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.LineChart
        '
        'chaHistorialCompras
        '
        Me.chaHistorialCompras.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.chaHistorialCompras.Axis.PE = PaintElement1
        Me.chaHistorialCompras.Axis.X.Extent = 48
        Me.chaHistorialCompras.Axis.X.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.chaHistorialCompras.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.FormatString = ""
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.chaHistorialCompras.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.X.LineThickness = 1
        Me.chaHistorialCompras.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.chaHistorialCompras.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.X.MajorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.chaHistorialCompras.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.X.MinorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.X.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.chaHistorialCompras.Axis.X.Visible = True
        Me.chaHistorialCompras.Axis.X2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray
        Me.chaHistorialCompras.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.chaHistorialCompras.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.chaHistorialCompras.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.FormatString = ""
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.chaHistorialCompras.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.X2.Labels.Visible = False
        Me.chaHistorialCompras.Axis.X2.LineThickness = 1
        Me.chaHistorialCompras.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.chaHistorialCompras.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.X2.MajorGridLines.Visible = True
        Me.chaHistorialCompras.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.chaHistorialCompras.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.X2.MinorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.X2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.chaHistorialCompras.Axis.X2.Visible = False
        Me.chaHistorialCompras.Axis.Y.Extent = 64
        Me.chaHistorialCompras.Axis.Y.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.chaHistorialCompras.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.chaHistorialCompras.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Y.LineThickness = 1
        Me.chaHistorialCompras.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.chaHistorialCompras.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Y.MajorGridLines.Visible = True
        Me.chaHistorialCompras.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.chaHistorialCompras.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Y.MinorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.Y.TickmarkInterval = 100.0R
        Me.chaHistorialCompras.Axis.Y.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.chaHistorialCompras.Axis.Y.Visible = True
        Me.chaHistorialCompras.Axis.Y2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray
        Me.chaHistorialCompras.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.chaHistorialCompras.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Y2.Labels.Visible = False
        Me.chaHistorialCompras.Axis.Y2.LineThickness = 1
        Me.chaHistorialCompras.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.chaHistorialCompras.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Y2.MajorGridLines.Visible = True
        Me.chaHistorialCompras.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.chaHistorialCompras.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Y2.MinorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.Y2.TickmarkInterval = 100.0R
        Me.chaHistorialCompras.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.chaHistorialCompras.Axis.Y2.Visible = False
        Me.chaHistorialCompras.Axis.Z.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.Z.Labels.ItemFormatString = ""
        Me.chaHistorialCompras.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Z.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Z.LineThickness = 1
        Me.chaHistorialCompras.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.chaHistorialCompras.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Z.MajorGridLines.Visible = True
        Me.chaHistorialCompras.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.chaHistorialCompras.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Z.MinorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.Z.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.chaHistorialCompras.Axis.Z.Visible = False
        Me.chaHistorialCompras.Axis.Z2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray
        Me.chaHistorialCompras.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.Z2.Labels.ItemFormatString = ""
        Me.chaHistorialCompras.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Z2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.chaHistorialCompras.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.chaHistorialCompras.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chaHistorialCompras.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.chaHistorialCompras.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chaHistorialCompras.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.Axis.Z2.Labels.Visible = False
        Me.chaHistorialCompras.Axis.Z2.LineThickness = 1
        Me.chaHistorialCompras.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.chaHistorialCompras.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Z2.MajorGridLines.Visible = True
        Me.chaHistorialCompras.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.chaHistorialCompras.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.chaHistorialCompras.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.chaHistorialCompras.Axis.Z2.MinorGridLines.Visible = False
        Me.chaHistorialCompras.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.chaHistorialCompras.Axis.Z2.Visible = False
        Me.chaHistorialCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.chaHistorialCompras.ColorModel.AlphaLevel = CType(150, Byte)
        Me.chaHistorialCompras.ColorModel.ColorBegin = System.Drawing.Color.Pink
        Me.chaHistorialCompras.ColorModel.ColorEnd = System.Drawing.Color.DarkRed
        Me.chaHistorialCompras.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.CustomLinear
        Me.chaHistorialCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chaHistorialCompras.Effects.Effects.Add(GradientEffect1)
        Me.chaHistorialCompras.Location = New System.Drawing.Point(611, 0)
        Me.chaHistorialCompras.Name = "chaHistorialCompras"
        Me.chaHistorialCompras.Size = New System.Drawing.Size(651, 203)
        Me.chaHistorialCompras.TabIndex = 247
        Me.chaHistorialCompras.TitleBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.chaHistorialCompras.TitleBottom.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.TitleBottom.Text = "Fecha Compra"
        Me.chaHistorialCompras.TitleLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.chaHistorialCompras.TitleLeft.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.TitleLeft.Text = "Precio"
        Me.chaHistorialCompras.TitleLeft.Visible = True
        Me.chaHistorialCompras.TitleTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.chaHistorialCompras.TitleTop.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.chaHistorialCompras.TitleTop.Text = "HISTORIAL DE COMPRAS"
        Me.chaHistorialCompras.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray
        Me.chaHistorialCompras.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray
        '
        'gbeListadoMateriales
        '
        Me.gbeListadoMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeListadoMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeListadoMateriales.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbeListadoMateriales.ExpandedSize = New System.Drawing.Size(611, 203)
        Me.gbeListadoMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOnBorder
        Me.gbeListadoMateriales.Location = New System.Drawing.Point(0, 0)
        Me.gbeListadoMateriales.Name = "gbeListadoMateriales"
        Me.gbeListadoMateriales.Size = New System.Drawing.Size(611, 203)
        Me.gbeListadoMateriales.TabIndex = 246
        Me.gbeListadoMateriales.Text = " "
        Me.gbeListadoMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griHistorialCompras)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 2)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(591, 199)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griHistorialCompras
        '
        Me.griHistorialCompras.DataSource = Me.odHistorialCompras
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.Caption = "N° Orden"
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridColumn62.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance34.TextHAlignAsString = "Center"
        UltraGridColumn62.CellAppearance = Appearance34
        UltraGridColumn62.Header.Caption = "Fecha"
        UltraGridColumn62.Header.VisiblePosition = 2
        UltraGridColumn62.Width = 65
        UltraGridColumn63.Header.VisiblePosition = 3
        UltraGridColumn63.Width = 220
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn64.CellAppearance = Appearance35
        UltraGridColumn64.Header.Caption = "Cant."
        UltraGridColumn64.Header.VisiblePosition = 4
        UltraGridColumn64.MaskInput = "{double:-9.2:c}"
        UltraGridColumn64.Width = 73
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn65.CellAppearance = Appearance36
        UltraGridColumn65.Header.VisiblePosition = 5
        UltraGridColumn65.MaskInput = "{double:-9.2:c}"
        UltraGridColumn65.Width = 71
        UltraGridColumn66.Header.VisiblePosition = 6
        UltraGridColumn66.Width = 125
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        Me.griHistorialCompras.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griHistorialCompras.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorialCompras.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance37.BorderColor = System.Drawing.SystemColors.Window
        Me.griHistorialCompras.DisplayLayout.GroupByBox.Appearance = Appearance37
        Appearance38.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorialCompras.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance38
        Me.griHistorialCompras.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorialCompras.DisplayLayout.GroupByBox.Hidden = True
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance39.BackColor2 = System.Drawing.SystemColors.Control
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorialCompras.DisplayLayout.GroupByBox.PromptAppearance = Appearance39
        Me.griHistorialCompras.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorialCompras.DisplayLayout.MaxRowScrollRegions = 1
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griHistorialCompras.DisplayLayout.Override.ActiveCellAppearance = Appearance40
        Appearance41.BackColor = System.Drawing.SystemColors.Highlight
        Appearance41.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griHistorialCompras.DisplayLayout.Override.ActiveRowAppearance = Appearance41
        Me.griHistorialCompras.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorialCompras.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorialCompras.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griHistorialCompras.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance42.BackColor = System.Drawing.SystemColors.Window
        Me.griHistorialCompras.DisplayLayout.Override.CardAreaAppearance = Appearance42
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Appearance43.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griHistorialCompras.DisplayLayout.Override.CellAppearance = Appearance43
        Me.griHistorialCompras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHistorialCompras.DisplayLayout.Override.CellPadding = 0
        Me.griHistorialCompras.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHistorialCompras.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance44.BackColor = System.Drawing.SystemColors.Control
        Appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance44.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance44.BorderColor = System.Drawing.SystemColors.Window
        Me.griHistorialCompras.DisplayLayout.Override.GroupByRowAppearance = Appearance44
        Appearance45.TextHAlignAsString = "Center"
        Me.griHistorialCompras.DisplayLayout.Override.HeaderAppearance = Appearance45
        Me.griHistorialCompras.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griHistorialCompras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance46.BackColor = System.Drawing.SystemColors.Window
        Appearance46.BorderColor = System.Drawing.Color.Silver
        Me.griHistorialCompras.DisplayLayout.Override.RowAppearance = Appearance46
        Me.griHistorialCompras.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHistorialCompras.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHistorialCompras.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorialCompras.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griHistorialCompras.DisplayLayout.Override.TemplateAddRowAppearance = Appearance47
        Me.griHistorialCompras.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griHistorialCompras.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griHistorialCompras.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griHistorialCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorialCompras.Font = New System.Drawing.Font("Arial", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorialCompras.Location = New System.Drawing.Point(0, 0)
        Me.griHistorialCompras.Name = "griHistorialCompras"
        Me.griHistorialCompras.Size = New System.Drawing.Size(591, 199)
        Me.griHistorialCompras.TabIndex = 9
        Me.griHistorialCompras.Text = "Grilla2"
        '
        'odHistorialCompras
        '
        UltraDataColumn62.DataType = GetType(Date)
        UltraDataColumn64.DataType = GetType(Double)
        UltraDataColumn65.DataType = GetType(Double)
        Me.odHistorialCompras.Band.Columns.AddRange(New Object() {UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66})
        '
        'agrOrdenCompra
        '
        Me.agrOrdenCompra.Controls.Add(Me.griListaOrdenCompra)
        Me.agrOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenCompra.Location = New System.Drawing.Point(0, 70)
        Me.agrOrdenCompra.Name = "agrOrdenCompra"
        Me.agrOrdenCompra.Size = New System.Drawing.Size(1270, 138)
        Me.agrOrdenCompra.TabIndex = 2
        Me.agrOrdenCompra.Text = "Orden's Compra : "
        Me.agrOrdenCompra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaOrdenCompra
        '
        Me.griListaOrdenCompra.DataSource = Me.odListaOrdenCompra
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaOrdenCompra.DisplayLayout.Appearance = Appearance48
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 2
        UltraGridColumn70.Header.VisiblePosition = 3
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 4
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 5
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 6
        UltraGridColumn73.Hidden = True
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn74.CellAppearance = Appearance49
        UltraGridColumn74.Header.VisiblePosition = 10
        UltraGridColumn74.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn75.CellAppearance = Appearance50
        UltraGridColumn75.Header.VisiblePosition = 11
        UltraGridColumn75.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn76.CellAppearance = Appearance51
        UltraGridColumn76.Header.VisiblePosition = 12
        UltraGridColumn76.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn77.Header.VisiblePosition = 13
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn78.Header.Caption = "Fecha de orden"
        UltraGridColumn78.Header.VisiblePosition = 7
        UltraGridColumn79.Header.VisiblePosition = 14
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 15
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 16
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 17
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 18
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn84.Header.Caption = "Evaluar"
        UltraGridColumn84.Header.VisiblePosition = 30
        UltraGridColumn85.Header.VisiblePosition = 19
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 20
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 21
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 22
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 23
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 24
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 25
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 28
        UltraGridColumn93.Header.VisiblePosition = 31
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 32
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 33
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 9
        UltraGridColumn97.Header.VisiblePosition = 34
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 35
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 36
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 37
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 38
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 39
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 40
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 41
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 42
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 43
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.Caption = "Estado"
        UltraGridColumn107.Header.VisiblePosition = 26
        UltraGridColumn107.Width = 150
        UltraGridColumn108.Header.VisiblePosition = 44
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.Caption = "Proveedor"
        UltraGridColumn109.Header.VisiblePosition = 8
        UltraGridColumn109.Width = 220
        UltraGridColumn110.Header.Caption = "Evaluación"
        UltraGridColumn110.Header.VisiblePosition = 29
        UltraGridColumn110.Width = 85
        UltraGridColumn111.Header.VisiblePosition = 45
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.Caption = "Consignación"
        UltraGridColumn112.Header.VisiblePosition = 27
        UltraGridColumn113.Header.VisiblePosition = 46
        UltraGridColumn114.Header.VisiblePosition = 47
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114})
        Me.griListaOrdenCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaOrdenCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaOrdenCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance52.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance52.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.Appearance = Appearance52
        Appearance53.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance53
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.Hidden = True
        Appearance54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance54.BackColor2 = System.Drawing.SystemColors.Control
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance54.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.PromptAppearance = Appearance54
        Me.griListaOrdenCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaOrdenCompra.DisplayLayout.MaxRowScrollRegions = 1
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Appearance55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaOrdenCompra.DisplayLayout.Override.ActiveCellAppearance = Appearance55
        Appearance56.BackColor = System.Drawing.SystemColors.Highlight
        Appearance56.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaOrdenCompra.DisplayLayout.Override.ActiveRowAppearance = Appearance56
        Me.griListaOrdenCompra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenCompra.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenCompra.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance57.BackColor = System.Drawing.SystemColors.Window
        Me.griListaOrdenCompra.DisplayLayout.Override.CardAreaAppearance = Appearance57
        Appearance58.BorderColor = System.Drawing.Color.Silver
        Appearance58.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaOrdenCompra.DisplayLayout.Override.CellAppearance = Appearance58
        Me.griListaOrdenCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaOrdenCompra.DisplayLayout.Override.CellPadding = 0
        Me.griListaOrdenCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaOrdenCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance59.BackColor = System.Drawing.SystemColors.Control
        Appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance59.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance59.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaOrdenCompra.DisplayLayout.Override.GroupByRowAppearance = Appearance59
        Appearance60.TextHAlignAsString = "Left"
        Me.griListaOrdenCompra.DisplayLayout.Override.HeaderAppearance = Appearance60
        Me.griListaOrdenCompra.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaOrdenCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaOrdenCompra.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance61.BackColor = System.Drawing.SystemColors.Window
        Appearance61.BorderColor = System.Drawing.Color.Silver
        Me.griListaOrdenCompra.DisplayLayout.Override.RowAppearance = Appearance61
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenCompra.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance62.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaOrdenCompra.DisplayLayout.Override.TemplateAddRowAppearance = Appearance62
        Me.griListaOrdenCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaOrdenCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaOrdenCompra.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaOrdenCompra.Location = New System.Drawing.Point(3, 17)
        Me.griListaOrdenCompra.Name = "griListaOrdenCompra"
        Me.griListaOrdenCompra.Size = New System.Drawing.Size(1264, 118)
        Me.griListaOrdenCompra.TabIndex = 9
        Me.griListaOrdenCompra.Text = "Grilla2"
        '
        'odListaOrdenCompra
        '
        UltraDataColumn111.DataType = GetType(Boolean)
        UltraDataColumn111.DefaultValue = False
        Me.odListaOrdenCompra.Band.Columns.AddRange(New Object() {UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.verLimites)
        Me.Agrupacion1.Controls.Add(Me.rfOrdenHasta)
        Me.Agrupacion1.Controls.Add(Me.rfOrdenDesde)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.btnRechazar)
        Me.Agrupacion1.Controls.Add(Me.btnAprobar)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.cboFormaBusqueda)
        Me.Agrupacion1.Controls.Add(Me.cboMaterialServicio)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion1.Controls.Add(Me.cboEstadoOrden)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1270, 70)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verLimites
        '
        Me.verLimites.BackColor = System.Drawing.Color.Transparent
        Me.verLimites.BackColorInternal = System.Drawing.Color.Transparent
        Me.verLimites.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verLimites.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verLimites.Location = New System.Drawing.Point(920, 6)
        Me.verLimites.Name = "verLimites"
        Me.verLimites.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verLimites.Size = New System.Drawing.Size(83, 30)
        Me.verLimites.TabIndex = 335
        Me.verLimites.Text = "Restringir por Limite"
        '
        'rfOrdenHasta
        '
        Me.rfOrdenHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenHasta.Location = New System.Drawing.Point(306, 9)
        Me.rfOrdenHasta.Name = "rfOrdenHasta"
        Me.rfOrdenHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfOrdenHasta.TabIndex = 334
        '
        'rfOrdenDesde
        '
        Me.rfOrdenDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenDesde.Location = New System.Drawing.Point(165, 9)
        Me.rfOrdenDesde.Name = "rfOrdenDesde"
        Me.rfOrdenDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfOrdenDesde.TabIndex = 333
        '
        'Etiqueta21
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance63
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(267, 13)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 332
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta3
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance64
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(125, 13)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta3.TabIndex = 331
        Me.Etiqueta3.Text = "Desde:"
        '
        'btnRechazar
        '
        Appearance65.BackColor = System.Drawing.Color.LightGray
        Appearance65.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRechazar.Appearance = Appearance65
        Me.btnRechazar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRechazar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazar.ForeColor = System.Drawing.Color.Black
        Me.btnRechazar.Location = New System.Drawing.Point(847, 35)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(67, 25)
        Me.btnRechazar.TabIndex = 315
        Me.btnRechazar.Text = "Rechazar"
        '
        'btnAprobar
        '
        Appearance66.BackColor = System.Drawing.Color.LightGray
        Appearance66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAprobar.Appearance = Appearance66
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.Location = New System.Drawing.Point(847, 9)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(67, 25)
        Me.btnAprobar.TabIndex = 314
        Me.btnAprobar.Text = "Aprobar"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.ColoresRechazado)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion3.Controls.Add(Me.ColoresAtendido)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion3.Controls.Add(Me.ColoresAtendidoParcialmente)
        Me.Agrupacion3.Controls.Add(Me.etiTerminada)
        Me.Agrupacion3.Controls.Add(Me.ColoresEvaluado)
        Me.Agrupacion3.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion3.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion3.Controls.Add(Me.etiGenerada)
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(408, 5)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(433, 59)
        Me.Agrupacion3.TabIndex = 313
        Me.Agrupacion3.Text = "Estados"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresRechazado
        '
        Me.ColoresRechazado.Location = New System.Drawing.Point(337, 31)
        Me.ColoresRechazado.Name = "ColoresRechazado"
        Me.ColoresRechazado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresRechazado.TabIndex = 10
        Me.ColoresRechazado.Text = "Control"
        '
        'Etiqueta1
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Appearance = Appearance67
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(336, 17)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta1.TabIndex = 9
        Me.Etiqueta1.Text = "Rechazada"
        '
        'ColoresAtendido
        '
        Me.ColoresAtendido.Location = New System.Drawing.Point(266, 31)
        Me.ColoresAtendido.Name = "ColoresAtendido"
        Me.ColoresAtendido.Size = New System.Drawing.Size(46, 22)
        Me.ColoresAtendido.TabIndex = 8
        Me.ColoresAtendido.Text = "Control"
        '
        'Etiqueta5
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Appearance = Appearance68
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(265, 17)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta5.TabIndex = 7
        Me.Etiqueta5.Text = "Terminada"
        '
        'ColoresAtendidoParcialmente
        '
        Me.ColoresAtendidoParcialmente.Location = New System.Drawing.Point(167, 31)
        Me.ColoresAtendidoParcialmente.Name = "ColoresAtendidoParcialmente"
        Me.ColoresAtendidoParcialmente.Size = New System.Drawing.Size(46, 22)
        Me.ColoresAtendidoParcialmente.TabIndex = 6
        Me.ColoresAtendidoParcialmente.Text = "Control"
        '
        'etiTerminada
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance69
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(133, 17)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(113, 15)
        Me.etiTerminada.TabIndex = 5
        Me.etiTerminada.Text = "Atendido Parcialmente"
        '
        'ColoresEvaluado
        '
        Me.ColoresEvaluado.Location = New System.Drawing.Point(74, 31)
        Me.ColoresEvaluado.Name = "ColoresEvaluado"
        Me.ColoresEvaluado.Size = New System.Drawing.Size(43, 22)
        Me.ColoresEvaluado.TabIndex = 2
        Me.ColoresEvaluado.Text = "Control"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(11, 31)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "Control"
        '
        'etiEnProceso
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance70
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(69, 17)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(48, 15)
        Me.etiEnProceso.TabIndex = 4
        Me.etiEnProceso.Text = "Evaluado"
        '
        'etiGenerada
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance71
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 17)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 3
        Me.etiGenerada.Text = "Generado"
        '
        'cboFormaBusqueda
        '
        Appearance72.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFormaBusqueda.Appearance = Appearance72
        Me.cboFormaBusqueda.DisplayMember = "Nombre"
        Me.cboFormaBusqueda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFormaBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFormaBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaBusqueda.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "FO"
        ValueListItem1.DisplayText = "Fecha de orden :"
        ValueListItem2.DataValue = "FE"
        ValueListItem2.DisplayText = "Fecha de entrega :"
        ValueListItem15.DataValue = "FP"
        ValueListItem15.DisplayText = "Fecha de pago :"
        Me.cboFormaBusqueda.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem15})
        Me.cboFormaBusqueda.Location = New System.Drawing.Point(11, 8)
        Me.cboFormaBusqueda.Name = "cboFormaBusqueda"
        Me.cboFormaBusqueda.Size = New System.Drawing.Size(112, 21)
        Me.cboFormaBusqueda.TabIndex = 312
        Me.cboFormaBusqueda.ValueMember = "Id"
        '
        'cboMaterialServicio
        '
        Appearance73.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialServicio.Appearance = Appearance73
        Me.cboMaterialServicio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance74.Image = 7
        EditorButton1.Appearance = Appearance74
        Me.cboMaterialServicio.ButtonsRight.Add(EditorButton1)
        Me.cboMaterialServicio.DisplayMember = "Nombre"
        Me.cboMaterialServicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterialServicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMaterialServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterialServicio.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialServicio.ImageList = Me.imagenes
        Me.cboMaterialServicio.Location = New System.Drawing.Point(285, 36)
        Me.cboMaterialServicio.Name = "cboMaterialServicio"
        Me.cboMaterialServicio.Size = New System.Drawing.Size(119, 21)
        Me.cboMaterialServicio.TabIndex = 311
        Me.cboMaterialServicio.ValueMember = "Id"
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
        'Etiqueta11
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance75
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(233, 41)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta11.TabIndex = 307
        Me.Etiqueta11.Text = "Mat./Ser:"
        '
        'cboEstadoOrden
        '
        Appearance76.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.Appearance = Appearance76
        Me.cboEstadoOrden.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance77.Image = 7
        EditorButton2.Appearance = Appearance77
        Me.cboEstadoOrden.ButtonsRight.Add(EditorButton2)
        Me.cboEstadoOrden.DisplayMember = "Nombre"
        Me.cboEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoOrden.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.ImageList = Me.imagenes
        Me.cboEstadoOrden.Location = New System.Drawing.Point(56, 36)
        Me.cboEstadoOrden.Name = "cboEstadoOrden"
        Me.cboEstadoOrden.Size = New System.Drawing.Size(143, 21)
        Me.cboEstadoOrden.TabIndex = 305
        Me.cboEstadoOrden.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance78
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(12, 41)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta7.TabIndex = 302
        Me.Etiqueta7.Text = "Estado:"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AprobarToolStripMenuItem, Me.RechazarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 48)
        '
        'AprobarToolStripMenuItem
        '
        Me.AprobarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Logo_Induamerica_pequeño
        Me.AprobarToolStripMenuItem.Name = "AprobarToolStripMenuItem"
        Me.AprobarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AprobarToolStripMenuItem.Text = "Aprobar"
        '
        'RechazarToolStripMenuItem
        '
        Me.RechazarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Logo_Induamerica_pequeño
        Me.RechazarToolStripMenuItem.Name = "RechazarToolStripMenuItem"
        Me.RechazarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.RechazarToolStripMenuItem.Text = "Rechazar"
        '
        'ficRequerimiento
        '
        Me.ficRequerimiento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficRequerimiento.Controls.Add(Me.UltraTabPageControl1)
        Me.ficRequerimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficRequerimiento.Location = New System.Drawing.Point(0, 0)
        Me.ficRequerimiento.Name = "ficRequerimiento"
        Me.ficRequerimiento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficRequerimiento.Size = New System.Drawing.Size(1272, 746)
        Me.ficRequerimiento.TabIndex = 3
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        Me.ficRequerimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.ficRequerimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1270, 723)
        '
        'ToolTip
        '
        Me.ToolTip.ContainingControl = Me
        '
        'frm_AprobarOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 746)
        Me.Controls.Add(Me.ficRequerimiento)
        Me.Name = "frm_AprobarOrdenesCompra"
        Me.Text = "Aprobar Ordenes de Compra"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griListaDetalleOrdenCompraMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenCompraMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListaDetalleOrdenCompraServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenCompraServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.txtNumeroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeListadoHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeListadoHistorial.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.panelOcultarGrafico.ResumeLayout(False)
        CType(Me.chaHistorialCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeListadoMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeListadoMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griHistorialCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odHistorialCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenCompra.ResumeLayout(False)
        CType(Me.griListaOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListaOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.verLimites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.ColoresRechazado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterialServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ficRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficRequerimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents ficRequerimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents ficDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaDetalleOrdenCompraMaterial As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaDetalleOrdenCompraServicio As ISL.Controles.Grilla
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents txtNumeroOrden As ISL.Controles.Texto
    Friend WithEvents txtFechaOrden As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents agrOrdenCompra As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnRechazar As ISL.Controles.Boton
    Friend WithEvents btnAprobar As ISL.Controles.Boton
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresAtendido As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresAtendidoParcialmente As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEvaluado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents cboFormaBusqueda As ISL.Controles.ComboMaestros
    Friend WithEvents cboMaterialServicio As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoOrden As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents odOrdenCompraMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents odOrdenCompraServicio As ISL.Controles.OrigenDatos
    Friend WithEvents odListaOrdenCompra As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents gbeListadoHistorial As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griHistorialCompras As ISL.Controles.Grilla
    Friend WithEvents odHistorialCompras As ISL.Controles.OrigenDatos
    Friend WithEvents gbeListadoMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Private WithEvents chaHistorialCompras As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents AprobarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rfOrdenHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfOrdenDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents panelOcultarGrafico As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents verLimites As ISL.Controles.Chequear
    Friend WithEvents ToolTip As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ColoresRechazado As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents griListaOrdenCompra As ISL.Controles.Grilla

End Class
