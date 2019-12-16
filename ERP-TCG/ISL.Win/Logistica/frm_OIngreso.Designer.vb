<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OIngreso
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
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
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialAAtender")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimientoSer")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajoMaterial")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialAAtender")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimientoSer")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenTrabajoMaterial")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_RegistroInventario", -1)
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAdm")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMaterial")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadReal")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitarioReal")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorTotal")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUnidad")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoSubAlmacen")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreAlmacen")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.uegMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaMateriales = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.txtBuscaMateriales = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.griOrdenMaterial = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.uebDocumento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaDoc = New ISL.Controles.Grilla(Me.components)
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.uceTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.fecFinDoc = New System.Windows.Forms.DateTimePicker()
        Me.fecInicioDoc = New System.Windows.Forms.DateTimePicker()
        Me.griOrdAsoc = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMovimientos = New ISL.Controles.Grilla(Me.components)
        Me.ERegistroInventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrden = New ISL.Controles.Grilla(Me.components)
        Me.odOrden = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnGenerarAsiento = New Infragistics.Win.Misc.UltraButton()
        Me.btnRectificar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEjecutar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraColorPicker3 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraColorPicker2 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraColorPicker1 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.gbOI = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtNroOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.gbDatosAdicionales = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uceEstadoOrden = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uceMovFiltro = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.rbNroOrden = New System.Windows.Forms.RadioButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnImportar = New Infragistics.Win.Misc.UltraButton()
        Me.btnQuitar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.numTotalOrden = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtEstadoOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkRuc = New System.Windows.Forms.CheckBox()
        Me.dtpFechaOrden = New System.Windows.Forms.DateTimePicker()
        Me.uceMoneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.uceMovInventario = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficOIngreso = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.uegMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uegMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txtBuscaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griOrdenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.uebDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uebDocumento.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griListaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.uceTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griOrdAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERegistroInventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.griOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.UltraColorPicker3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbOI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOI.SuspendLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.uceEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uceMovFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb1.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.numTotalOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uceMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uceMovInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOIngreso.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.uegMateriales)
        Me.UltraTabPageControl3.Controls.Add(Me.griOrdenMaterial)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1126, 284)
        '
        'uegMateriales
        '
        Me.uegMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.uegMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.uegMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.uegMateriales.ExpandedSize = New System.Drawing.Size(582, 284)
        Me.uegMateriales.ForeColor = System.Drawing.Color.Navy
        Me.uegMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.uegMateriales.Location = New System.Drawing.Point(544, 0)
        Me.uegMateriales.Name = "uegMateriales"
        Me.uegMateriales.Size = New System.Drawing.Size(582, 284)
        Me.uegMateriales.TabIndex = 1
        Me.uegMateriales.Text = "Materiales"
        Me.uegMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griListaMateriales)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox6)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(559, 278)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griListaMateriales
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaMateriales.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn1.Header.Appearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 27
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance3
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 9
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 320
        UltraGridColumn5.Header.Caption = "Unidad de medida"
        UltraGridColumn5.Header.VisiblePosition = 19
        UltraGridColumn5.Width = 114
        UltraGridColumn6.Header.VisiblePosition = 26
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 254
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 20
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 22
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 23
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 24
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 25
        UltraGridColumn21.Hidden = True
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn22.Header.Appearance = Appearance4
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 21
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 18
        UltraGridColumn25.Header.Caption = "Costo"
        UltraGridColumn25.Header.VisiblePosition = 27
        UltraGridColumn26.Header.Caption = ":"
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridColumn27.Header.VisiblePosition = 16
        UltraGridColumn27.Hidden = True
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn28.Header.Appearance = Appearance5
        UltraGridColumn28.Header.VisiblePosition = 17
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        Me.griListaMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaMateriales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.griListaMateriales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.GroupByBox.Hidden = True
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Me.griListaMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaMateriales.DisplayLayout.MaxRowScrollRegions = 1
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaMateriales.DisplayLayout.Override.ActiveCellAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.SystemColors.Highlight
        Appearance10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaMateriales.DisplayLayout.Override.ActiveRowAppearance = Appearance10
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaMateriales.DisplayLayout.Override.CellAppearance = Appearance12
        Me.griListaMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griListaMateriales.DisplayLayout.Override.CellPadding = 0
        Appearance13.BackColor = System.Drawing.SystemColors.Control
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.GroupByRowAppearance = Appearance13
        Appearance14.TextHAlignAsString = "Left"
        Me.griListaMateriales.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.griListaMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaMateriales.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griListaMateriales.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaMateriales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaMateriales.DisplayLayout.Override.TemplateAddRowAppearance = Appearance16
        Me.griListaMateriales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaMateriales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaMateriales.Location = New System.Drawing.Point(0, 56)
        Me.griListaMateriales.Name = "griListaMateriales"
        Me.griListaMateriales.Size = New System.Drawing.Size(559, 222)
        Me.griListaMateriales.TabIndex = 1
        Me.griListaMateriales.Text = "Grilla2"
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox6.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox6.Controls.Add(Me.txtBuscaMateriales)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(559, 56)
        Me.UltraGroupBox6.TabIndex = 0
        Me.UltraGroupBox6.Text = "Materiales"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel7
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance17
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(14, 32)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "Material:"
        '
        'UltraButton1
        '
        Appearance18.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance18.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance18.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraButton1.Appearance = Appearance18
        Me.UltraButton1.Location = New System.Drawing.Point(380, 27)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(51, 23)
        Me.UltraButton1.TabIndex = 2
        '
        'txtBuscaMateriales
        '
        Me.txtBuscaMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscaMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBuscaMateriales.Location = New System.Drawing.Point(68, 28)
        Me.txtBuscaMateriales.Name = "txtBuscaMateriales"
        Me.txtBuscaMateriales.Size = New System.Drawing.Size(306, 22)
        Me.txtBuscaMateriales.TabIndex = 1
        '
        'griOrdenMaterial
        '
        Me.griOrdenMaterial.DataSource = Me.odOrdenMaterial
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 1
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.Caption = "Codigo"
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn35.Width = 82
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridColumn36.Width = 390
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance19
        UltraGridColumn37.Format = "#,##0.0000"
        UltraGridColumn37.Header.Caption = "Cantidad"
        UltraGridColumn37.Header.VisiblePosition = 6
        UltraGridColumn37.MaskInput = "{double:9.4}"
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn37.Width = 90
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance20
        UltraGridColumn38.Format = "#,##0.0000"
        UltraGridColumn38.Header.Caption = "Precio Unit."
        UltraGridColumn38.Header.VisiblePosition = 7
        UltraGridColumn38.MaskInput = "{double:9.4}"
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn38.Width = 90
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance21
        UltraGridColumn39.Format = "#,##0.0000"
        UltraGridColumn39.Header.Caption = "Total"
        UltraGridColumn39.Header.VisiblePosition = 8
        UltraGridColumn39.MaskInput = "{double:9.4}"
        UltraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn39.Width = 90
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.Header.VisiblePosition = 9
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 20
        UltraGridColumn41.Width = 192
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 11
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 13
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 15
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 16
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.Caption = "U. Medida"
        UltraGridColumn47.Header.VisiblePosition = 17
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 19
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn49.Header.Caption = "U. Medida"
        UltraGridColumn49.Header.VisiblePosition = 5
        UltraGridColumn49.Width = 70
        UltraGridColumn50.Header.VisiblePosition = 22
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 23
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 24
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 25
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 26
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 27
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 28
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 29
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 30
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 31
        UltraGridColumn59.Hidden = True
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn60.CellAppearance = Appearance22
        UltraGridColumn60.Header.Caption = "Orden"
        UltraGridColumn60.Header.VisiblePosition = 14
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Width = 94
        UltraGridColumn61.Header.VisiblePosition = 32
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 33
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn63.Header.Caption = "SubAlmacen"
        UltraGridColumn63.Header.VisiblePosition = 21
        UltraGridColumn63.Width = 160
        UltraGridColumn64.Header.VisiblePosition = 34
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 35
        UltraGridColumn65.Hidden = True
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn66.CellAppearance = Appearance23
        UltraGridColumn66.Header.VisiblePosition = 12
        UltraGridColumn66.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        Me.griOrdenMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griOrdenMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenMaterial.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griOrdenMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOrdenMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griOrdenMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenMaterial.Location = New System.Drawing.Point(0, 0)
        Me.griOrdenMaterial.Name = "griOrdenMaterial"
        Me.griOrdenMaterial.Size = New System.Drawing.Size(1126, 284)
        Me.griOrdenMaterial.TabIndex = 0
        '
        'odOrdenMaterial
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        Me.odOrdenMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.uebDocumento)
        Me.UltraTabPageControl4.Controls.Add(Me.griOrdAsoc)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1126, 284)
        '
        'uebDocumento
        '
        Me.uebDocumento.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.uebDocumento.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.uebDocumento.Dock = System.Windows.Forms.DockStyle.Right
        Me.uebDocumento.ExpandedSize = New System.Drawing.Size(573, 284)
        Me.uebDocumento.ForeColor = System.Drawing.Color.Navy
        Me.uebDocumento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.uebDocumento.Location = New System.Drawing.Point(553, 0)
        Me.uebDocumento.Name = "uebDocumento"
        Me.uebDocumento.Size = New System.Drawing.Size(573, 284)
        Me.uebDocumento.TabIndex = 1
        Me.uebDocumento.Text = "Documentos"
        Me.uebDocumento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griListaDoc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraGroupBox7)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(550, 278)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griListaDoc
        '
        Me.griListaDoc.DataSource = Me.odListadoDocumentos
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 5
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 6
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 7
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 8
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 9
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 10
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 11
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.Width = 117
        UltraGridColumn76.Header.VisiblePosition = 12
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 13
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 14
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 16
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 17
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 18
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 2
        UltraGridColumn83.Header.VisiblePosition = 19
        UltraGridColumn83.Hidden = True
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn84.CellAppearance = Appearance24
        UltraGridColumn84.Format = "#,##0.0000"
        UltraGridColumn84.Header.VisiblePosition = 15
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.MaskInput = ""
        UltraGridColumn84.Width = 89
        UltraGridColumn85.Header.VisiblePosition = 20
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 21
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 22
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 23
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 24
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 25
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 26
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 27
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 28
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 29
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.Caption = "Proveedor"
        UltraGridColumn95.Header.VisiblePosition = 4
        UltraGridColumn95.Width = 297
        UltraGridColumn96.Header.Caption = "Documento"
        UltraGridColumn96.Header.VisiblePosition = 3
        UltraGridColumn96.Width = 116
        UltraGridColumn97.Header.VisiblePosition = 30
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 31
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 32
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 33
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 34
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 35
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 36
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 37
        UltraGridColumn104.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104})
        Me.griListaDoc.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaDoc.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaDoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDoc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaDoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDoc.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griListaDoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griListaDoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDoc.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDoc.Location = New System.Drawing.Point(0, 35)
        Me.griListaDoc.Name = "griListaDoc"
        Me.griListaDoc.Size = New System.Drawing.Size(550, 243)
        Me.griListaDoc.TabIndex = 1
        '
        'odListadoDocumentos
        '
        UltraDataColumn52.DataType = GetType(Date)
        UltraDataColumn74.DataType = GetType(Boolean)
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74})
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox7.Controls.Add(Me.uceTipoDocumento)
        Me.UltraGroupBox7.Controls.Add(Me.fecFinDoc)
        Me.UltraGroupBox7.Controls.Add(Me.fecInicioDoc)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(550, 35)
        Me.UltraGroupBox7.TabIndex = 0
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButton2
        '
        Appearance25.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance25.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance25.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraButton2.Appearance = Appearance25
        Me.UltraButton2.Location = New System.Drawing.Point(463, 4)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(51, 23)
        Me.UltraButton2.TabIndex = 3
        '
        'uceTipoDocumento
        '
        Me.uceTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uceTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uceTipoDocumento.Location = New System.Drawing.Point(218, 5)
        Me.uceTipoDocumento.Name = "uceTipoDocumento"
        Me.uceTipoDocumento.Size = New System.Drawing.Size(239, 22)
        Me.uceTipoDocumento.TabIndex = 2
        Me.uceTipoDocumento.ValueMember = "Id"
        '
        'fecFinDoc
        '
        Me.fecFinDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFinDoc.Location = New System.Drawing.Point(112, 6)
        Me.fecFinDoc.Name = "fecFinDoc"
        Me.fecFinDoc.Size = New System.Drawing.Size(100, 21)
        Me.fecFinDoc.TabIndex = 1
        '
        'fecInicioDoc
        '
        Me.fecInicioDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicioDoc.Location = New System.Drawing.Point(6, 6)
        Me.fecInicioDoc.Name = "fecInicioDoc"
        Me.fecInicioDoc.Size = New System.Drawing.Size(100, 21)
        Me.fecInicioDoc.TabIndex = 0
        '
        'griOrdAsoc
        '
        Me.griOrdAsoc.DataSource = Me.odListadoDocumentos
        UltraGridColumn105.Header.VisiblePosition = 0
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 1
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 2
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 3
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 4
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 5
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 6
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 7
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 8
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 9
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 10
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 14
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 16
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 17
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 18
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 11
        UltraGridColumn120.Width = 99
        UltraGridColumn121.Header.VisiblePosition = 19
        UltraGridColumn121.Hidden = True
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn122.CellAppearance = Appearance26
        UltraGridColumn122.Format = "#,##0.0000"
        UltraGridColumn122.Header.VisiblePosition = 15
        UltraGridColumn122.Hidden = True
        UltraGridColumn122.MaskInput = ""
        UltraGridColumn122.Width = 89
        UltraGridColumn123.Header.VisiblePosition = 20
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 21
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 22
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 23
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 24
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 25
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 26
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 27
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.Header.VisiblePosition = 28
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 29
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 13
        UltraGridColumn133.Width = 418
        UltraGridColumn134.Header.VisiblePosition = 12
        UltraGridColumn134.Width = 141
        UltraGridColumn135.Header.VisiblePosition = 30
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 31
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.VisiblePosition = 32
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 33
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 34
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 35
        UltraGridColumn140.Hidden = True
        UltraGridColumn141.Header.VisiblePosition = 36
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 37
        UltraGridColumn142.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142})
        Me.griOrdAsoc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griOrdAsoc.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdAsoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdAsoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdAsoc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdAsoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdAsoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdAsoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdAsoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdAsoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdAsoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOrdAsoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdAsoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griOrdAsoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdAsoc.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griOrdAsoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdAsoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdAsoc.Location = New System.Drawing.Point(0, 0)
        Me.griOrdAsoc.Name = "griOrdAsoc"
        Me.griOrdAsoc.Size = New System.Drawing.Size(1126, 284)
        Me.griOrdAsoc.TabIndex = 0
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griMovimientos)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1126, 284)
        '
        'griMovimientos
        '
        Me.griMovimientos.DataSource = Me.ERegistroInventarioBindingSource
        UltraGridColumn198.Header.VisiblePosition = 0
        UltraGridColumn199.Header.VisiblePosition = 2
        UltraGridColumn200.Header.VisiblePosition = 4
        UltraGridColumn143.Header.VisiblePosition = 1
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.Caption = "N° Movimiento"
        UltraGridColumn144.Header.VisiblePosition = 5
        UltraGridColumn144.Width = 119
        UltraGridColumn145.Header.VisiblePosition = 6
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn146.Header.VisiblePosition = 3
        UltraGridColumn146.Width = 89
        UltraGridColumn147.Header.VisiblePosition = 13
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 15
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 7
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.Header.VisiblePosition = 8
        UltraGridColumn150.Width = 266
        UltraGridColumn151.Header.VisiblePosition = 11
        UltraGridColumn151.Hidden = True
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn152.CellAppearance = Appearance27
        UltraGridColumn152.Format = "#,##0.0000"
        UltraGridColumn152.Header.VisiblePosition = 9
        UltraGridColumn152.MaskInput = "{double:9.4}"
        UltraGridColumn152.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn152.Width = 95
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn153.CellAppearance = Appearance28
        UltraGridColumn153.Format = "#,##0.0000"
        UltraGridColumn153.Header.VisiblePosition = 10
        UltraGridColumn153.MaskInput = "{double:9.4}"
        UltraGridColumn153.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn153.Width = 107
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn154.CellAppearance = Appearance29
        UltraGridColumn154.Format = "#,##0.0000"
        UltraGridColumn154.Header.VisiblePosition = 17
        UltraGridColumn154.MaskInput = "{double:9.4}"
        UltraGridColumn154.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn155.CellAppearance = Appearance30
        UltraGridColumn155.Format = "#,##0.0000"
        UltraGridColumn155.Header.VisiblePosition = 18
        UltraGridColumn155.Hidden = True
        UltraGridColumn155.MaskInput = "{double:9.4}"
        UltraGridColumn155.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn156.CellAppearance = Appearance31
        UltraGridColumn156.Format = "#,##0.0000"
        UltraGridColumn156.Header.VisiblePosition = 19
        UltraGridColumn156.MaskInput = "{double:9.4}"
        UltraGridColumn156.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn157.Header.VisiblePosition = 22
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 16
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 12
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 21
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 14
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 20
        UltraGridColumn162.Width = 185
        UltraGridColumn163.Header.VisiblePosition = 23
        UltraGridColumn163.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163})
        Me.griMovimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griMovimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimientos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griMovimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovimientos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovimientos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovimientos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griMovimientos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimientos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.griMovimientos.Name = "griMovimientos"
        Me.griMovimientos.Size = New System.Drawing.Size(1126, 284)
        Me.griMovimientos.TabIndex = 0
        '
        'ERegistroInventarioBindingSource
        '
        Me.ERegistroInventarioBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_RegistroInventario)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox8)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1134, 473)
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.griOrden)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 144)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1134, 329)
        Me.UltraGroupBox8.TabIndex = 2
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrden
        '
        Me.griOrden.DataSource = Me.odOrden
        UltraGridColumn164.Header.VisiblePosition = 0
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 2
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.Caption = "Orden"
        UltraGridColumn166.Header.VisiblePosition = 1
        UltraGridColumn166.Width = 89
        UltraGridColumn167.Header.VisiblePosition = 3
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 4
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 5
        UltraGridColumn169.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn169.Width = 141
        UltraGridColumn170.Header.VisiblePosition = 6
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 7
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 8
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 9
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 10
        UltraGridColumn174.Width = 240
        UltraGridColumn175.Header.VisiblePosition = 12
        UltraGridColumn175.Width = 203
        UltraGridColumn176.Header.VisiblePosition = 13
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 31
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.Header.VisiblePosition = 14
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 15
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 16
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 17
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 18
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 11
        UltraGridColumn184.Header.VisiblePosition = 24
        UltraGridColumn184.Width = 156
        UltraGridColumn185.Header.VisiblePosition = 20
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.Header.VisiblePosition = 21
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 22
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.Caption = "Usuario"
        UltraGridColumn188.Header.VisiblePosition = 32
        UltraGridColumn188.Width = 119
        UltraGridColumn189.Header.VisiblePosition = 23
        UltraGridColumn189.Width = 113
        UltraGridColumn190.Header.VisiblePosition = 25
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 26
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.Caption = "Tipo Documento"
        UltraGridColumn192.Header.VisiblePosition = 19
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 27
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 28
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 29
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 30
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 33
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197})
        Me.griOrden.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griOrden.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrden.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrden.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrden.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrden.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrden.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griOrden.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOrden.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrden.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griOrden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrden.Location = New System.Drawing.Point(3, 3)
        Me.griOrden.Name = "griOrden"
        Me.griOrden.Size = New System.Drawing.Size(1128, 323)
        Me.griOrden.TabIndex = 0
        '
        'odOrden
        '
        UltraDataColumn80.DataType = GetType(Date)
        UltraDataColumn81.DataType = GetType(Double)
        UltraDataColumn87.DataType = GetType(Boolean)
        Me.odOrden.Band.Columns.AddRange(New Object() {UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108})
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnGenerarAsiento)
        Me.UltraGroupBox2.Controls.Add(Me.btnRectificar)
        Me.UltraGroupBox2.Controls.Add(Me.btnEjecutar)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 110)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1134, 34)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnGenerarAsiento
        '
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnGenerarAsiento.Appearance = Appearance32
        Me.btnGenerarAsiento.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGenerarAsiento.Location = New System.Drawing.Point(172, 3)
        Me.btnGenerarAsiento.Name = "btnGenerarAsiento"
        Me.btnGenerarAsiento.Size = New System.Drawing.Size(91, 28)
        Me.btnGenerarAsiento.TabIndex = 3
        Me.btnGenerarAsiento.Text = "Asiento"
        '
        'btnRectificar
        '
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.btnRectificar.Appearance = Appearance33
        Me.btnRectificar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRectificar.Enabled = False
        Me.btnRectificar.Location = New System.Drawing.Point(81, 3)
        Me.btnRectificar.Name = "btnRectificar"
        Me.btnRectificar.Size = New System.Drawing.Size(91, 28)
        Me.btnRectificar.TabIndex = 1
        Me.btnRectificar.Text = "Rectificar"
        '
        'btnEjecutar
        '
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.Image = Global.ISL.Win.My.Resources.Resources.situacionadm
        Me.btnEjecutar.Appearance = Appearance34
        Me.btnEjecutar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEjecutar.Enabled = False
        Me.btnEjecutar.Location = New System.Drawing.Point(3, 3)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(78, 28)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox11)
        Me.UltraGroupBox1.Controls.Add(Me.gbOI)
        Me.UltraGroupBox1.Controls.Add(Me.gbDatosAdicionales)
        Me.UltraGroupBox1.Controls.Add(Me.rbDatosAdicionales)
        Me.UltraGroupBox1.Controls.Add(Me.rbNroOrden)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1134, 110)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Filtros"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox11.Controls.Add(Me.UltraColorPicker3)
        Me.UltraGroupBox11.Controls.Add(Me.UltraColorPicker2)
        Me.UltraGroupBox11.Controls.Add(Me.UltraColorPicker1)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(615, 40)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(387, 54)
        Me.UltraGroupBox11.TabIndex = 4
        Me.UltraGroupBox11.Text = "Estados"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel12
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance35
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(256, 27)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel12.TabIndex = 4
        Me.UltraLabel12.Text = "Terminada:"
        '
        'UltraLabel11
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance36
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(120, 27)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(77, 15)
        Me.UltraLabel11.TabIndex = 2
        Me.UltraLabel11.Text = "Recepcionada:"
        '
        'UltraLabel10
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance37
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(5, 27)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel10.TabIndex = 0
        Me.UltraLabel10.Text = "Generada:"
        '
        'UltraColorPicker3
        '
        Me.UltraColorPicker3.Color = System.Drawing.Color.LightGreen
        Me.UltraColorPicker3.Location = New System.Drawing.Point(323, 23)
        Me.UltraColorPicker3.Name = "UltraColorPicker3"
        Me.UltraColorPicker3.Size = New System.Drawing.Size(47, 22)
        Me.UltraColorPicker3.TabIndex = 5
        Me.UltraColorPicker3.Text = "LightGreen"
        '
        'UltraColorPicker2
        '
        Me.UltraColorPicker2.Color = System.Drawing.Color.Khaki
        Me.UltraColorPicker2.Location = New System.Drawing.Point(203, 23)
        Me.UltraColorPicker2.Name = "UltraColorPicker2"
        Me.UltraColorPicker2.Size = New System.Drawing.Size(47, 22)
        Me.UltraColorPicker2.TabIndex = 3
        Me.UltraColorPicker2.Text = "Khaki"
        '
        'UltraColorPicker1
        '
        Me.UltraColorPicker1.Color = System.Drawing.Color.White
        Me.UltraColorPicker1.Location = New System.Drawing.Point(67, 23)
        Me.UltraColorPicker1.Name = "UltraColorPicker1"
        Me.UltraColorPicker1.Size = New System.Drawing.Size(47, 22)
        Me.UltraColorPicker1.TabIndex = 1
        Me.UltraColorPicker1.Text = "White"
        '
        'gbOI
        '
        Me.gbOI.Controls.Add(Me.txtNroOrden)
        Me.gbOI.Location = New System.Drawing.Point(447, 40)
        Me.gbOI.Name = "gbOI"
        Me.gbOI.Size = New System.Drawing.Size(162, 42)
        Me.gbOI.TabIndex = 3
        Me.gbOI.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNroOrden
        '
        Me.txtNroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrden.Location = New System.Drawing.Point(6, 8)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(150, 22)
        Me.txtNroOrden.TabIndex = 0
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.uceEstadoOrden)
        Me.gbDatosAdicionales.Controls.Add(Me.uceMovFiltro)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel16)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel15)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel14)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel13)
        Me.gbDatosAdicionales.Controls.Add(Me.fecHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.fecDesde)
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(11, 40)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(430, 63)
        Me.gbDatosAdicionales.TabIndex = 1
        Me.gbDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'uceEstadoOrden
        '
        Me.uceEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uceEstadoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uceEstadoOrden.Location = New System.Drawing.Point(239, 35)
        Me.uceEstadoOrden.Name = "uceEstadoOrden"
        Me.uceEstadoOrden.Size = New System.Drawing.Size(185, 22)
        Me.uceEstadoOrden.TabIndex = 7
        Me.uceEstadoOrden.ValueMember = "Id"
        '
        'uceMovFiltro
        '
        Me.uceMovFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uceMovFiltro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uceMovFiltro.Location = New System.Drawing.Point(239, 8)
        Me.uceMovFiltro.Name = "uceMovFiltro"
        Me.uceMovFiltro.Size = New System.Drawing.Size(185, 22)
        Me.uceMovFiltro.TabIndex = 5
        Me.uceMovFiltro.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance38
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(191, 39)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel16.TabIndex = 6
        Me.UltraLabel16.Text = "Estado:"
        '
        'UltraLabel15
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance39
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(167, 12)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(66, 15)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Movimiento:"
        '
        'UltraLabel14
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance40
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(21, 39)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel14.TabIndex = 2
        Me.UltraLabel14.Text = "Hasta:"
        '
        'UltraLabel13
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance41
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(19, 12)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel13.TabIndex = 0
        Me.UltraLabel13.Text = "Desde:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(64, 36)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(97, 21)
        Me.fecHasta.TabIndex = 3
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(64, 9)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(97, 21)
        Me.fecDesde.TabIndex = 1
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(11, 20)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(109, 17)
        Me.rbDatosAdicionales.TabIndex = 0
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'rbNroOrden
        '
        Me.rbNroOrden.AutoSize = True
        Me.rbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rbNroOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbNroOrden.Location = New System.Drawing.Point(447, 20)
        Me.rbNroOrden.Name = "rbNroOrden"
        Me.rbNroOrden.Size = New System.Drawing.Size(125, 17)
        Me.rbNroOrden.TabIndex = 2
        Me.rbNroOrden.Text = "N° Orden de Ingreso"
        Me.rbNroOrden.UseVisualStyleBackColor = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1134, 473)
        '
        'ugb1
        '
        Me.ugb1.Controls.Add(Me.ficDetalle)
        Me.ugb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb1.Location = New System.Drawing.Point(0, 160)
        Me.ugb1.Name = "ugb1"
        Me.ugb1.Size = New System.Drawing.Size(1134, 313)
        Me.ugb1.TabIndex = 2
        Me.ugb1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Location = New System.Drawing.Point(3, 3)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalle.Size = New System.Drawing.Size(1128, 307)
        Me.ficDetalle.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficDetalle.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Materiales"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Orden"
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Movimientos"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1126, 284)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.btnImportar)
        Me.UltraGroupBox4.Controls.Add(Me.btnQuitar)
        Me.UltraGroupBox4.Controls.Add(Me.btnAgregar)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 112)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1134, 48)
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.Text = "Detalles"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnImportar
        '
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.btnImportar.Appearance = Appearance42
        Me.btnImportar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImportar.Enabled = False
        Me.btnImportar.Location = New System.Drawing.Point(153, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 28)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        '
        'btnQuitar
        '
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Appearance43.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.btnQuitar.Appearance = Appearance43
        Me.btnQuitar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnQuitar.Location = New System.Drawing.Point(78, 17)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 28)
        Me.btnQuitar.TabIndex = 1
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Appearance44.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAgregar.Appearance = Appearance44
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregar.Location = New System.Drawing.Point(3, 17)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.lbl_etiqueta)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox3.Controls.Add(Me.numTotalOrden)
        Me.UltraGroupBox3.Controls.Add(Me.txtEstadoOrden)
        Me.UltraGroupBox3.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox3.Controls.Add(Me.txtOrden)
        Me.UltraGroupBox3.Controls.Add(Me.chkRuc)
        Me.UltraGroupBox3.Controls.Add(Me.dtpFechaOrden)
        Me.UltraGroupBox3.Controls.Add(Me.uceMoneda)
        Me.UltraGroupBox3.Controls.Add(Me.cboProveedor)
        Me.UltraGroupBox3.Controls.Add(Me.uceMovInventario)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1134, 112)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.Text = "Datos Generales"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance45
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1041, 20)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(82, 18)
        Me.lbl_etiqueta.TabIndex = 17
        Me.lbl_etiqueta.Text = "Ejecutar OI"
        Me.lbl_etiqueta.Visible = False
        '
        'UltraLabel9
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance46
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(429, 82)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel9.TabIndex = 13
        Me.UltraLabel9.Text = "Total:"
        '
        'numTotalOrden
        '
        Me.numTotalOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalOrden.Location = New System.Drawing.Point(468, 77)
        Me.numTotalOrden.MaskInput = "{double:-9.4}"
        Me.numTotalOrden.Name = "numTotalOrden"
        Me.numTotalOrden.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalOrden.Size = New System.Drawing.Size(123, 22)
        Me.numTotalOrden.TabIndex = 14
        '
        'txtEstadoOrden
        '
        Me.txtEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstadoOrden.Location = New System.Drawing.Point(468, 48)
        Me.txtEstadoOrden.Name = "txtEstadoOrden"
        Me.txtEstadoOrden.ReadOnly = True
        Me.txtEstadoOrden.Size = New System.Drawing.Size(123, 22)
        Me.txtEstadoOrden.TabIndex = 12
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(651, 22)
        Me.txtGlosa.MaxLength = 200
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(250, 77)
        Me.txtGlosa.TabIndex = 16
        '
        'txtOrden
        '
        Me.txtOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOrden.Location = New System.Drawing.Point(468, 20)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(123, 22)
        Me.txtOrden.TabIndex = 10
        '
        'chkRuc
        '
        Me.chkRuc.AutoSize = True
        Me.chkRuc.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc.Location = New System.Drawing.Point(334, 50)
        Me.chkRuc.Name = "chkRuc"
        Me.chkRuc.Size = New System.Drawing.Size(47, 17)
        Me.chkRuc.TabIndex = 4
        Me.chkRuc.Text = "RUC"
        Me.chkRuc.UseVisualStyleBackColor = False
        '
        'dtpFechaOrden
        '
        Me.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOrden.Location = New System.Drawing.Point(278, 78)
        Me.dtpFechaOrden.Name = "dtpFechaOrden"
        Me.dtpFechaOrden.Size = New System.Drawing.Size(103, 21)
        Me.dtpFechaOrden.TabIndex = 8
        '
        'uceMoneda
        '
        Me.uceMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uceMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uceMoneda.Location = New System.Drawing.Point(84, 77)
        Me.uceMoneda.Name = "uceMoneda"
        Me.uceMoneda.Size = New System.Drawing.Size(144, 22)
        Me.uceMoneda.TabIndex = 6
        Me.uceMoneda.ValueMember = "Id"
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
        Me.cboProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(84, 48)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(244, 23)
        Me.cboProveedor.TabIndex = 3
        '
        'uceMovInventario
        '
        Me.uceMovInventario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uceMovInventario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uceMovInventario.Location = New System.Drawing.Point(84, 20)
        Me.uceMovInventario.Name = "uceMovInventario"
        Me.uceMovInventario.Size = New System.Drawing.Size(297, 22)
        Me.uceMovInventario.TabIndex = 1
        Me.uceMovInventario.ValueMember = "Id"
        '
        'UltraLabel8
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance47
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(234, 82)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel8.TabIndex = 7
        Me.UltraLabel8.Text = "Fecha:"
        '
        'UltraLabel6
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance48
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(423, 24)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel6.TabIndex = 9
        Me.UltraLabel6.Text = "Orden:"
        '
        'UltraLabel5
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance49
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(420, 52)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel5.TabIndex = 11
        Me.UltraLabel5.Text = "Estado:"
        '
        'UltraLabel4
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance50
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(610, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel4.TabIndex = 15
        Me.UltraLabel4.Text = "Glosa:"
        '
        'UltraLabel3
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance51
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(19, 51)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Proveedor:"
        '
        'UltraLabel2
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance52
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(30, 82)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Moneda:"
        '
        'UltraLabel1
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance53
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 24)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(66, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Movimiento:"
        '
        'ficOIngreso
        '
        Me.ficOIngreso.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOIngreso.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOIngreso.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOIngreso.Location = New System.Drawing.Point(0, 0)
        Me.ficOIngreso.Name = "ficOIngreso"
        Me.ficOIngreso.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOIngreso.Size = New System.Drawing.Size(1136, 496)
        Me.ficOIngreso.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficOIngreso.TabIndex = 0
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Mantenimiento"
        Me.ficOIngreso.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5})
        Me.ficOIngreso.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1134, 473)
        '
        'frm_OIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 496)
        Me.Controls.Add(Me.ficOIngreso)
        Me.Name = "frm_OIngreso"
        Me.Tag = "1CH000000001"
        Me.Text = "Orden Ingreso"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.uegMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uegMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.txtBuscaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griOrdenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.uebDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uebDocumento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griListaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        Me.UltraGroupBox7.PerformLayout()
        CType(Me.uceTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griOrdAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERegistroInventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.griOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.UltraColorPicker3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbOI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOI.ResumeLayout(False)
        Me.gbOI.PerformLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.uceEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uceMovFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb1.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.numTotalOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uceMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uceMovInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOIngreso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficOIngreso As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ficDetalle As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnImportar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnQuitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griOrdenMaterial As ISL.Controles.Grilla
    Friend WithEvents griOrdAsoc As ISL.Controles.Grilla
    Friend WithEvents griMovimientos As ISL.Controles.Grilla
    Friend WithEvents uegMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griListaMateriales As ISL.Controles.Grilla
    Friend WithEvents uebDocumento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griListaDoc As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uceMovInventario As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dtpFechaOrden As System.Windows.Forms.DateTimePicker
    Friend WithEvents uceMoneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkRuc As System.Windows.Forms.CheckBox
    Friend WithEvents txtOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtEstadoOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numTotalOrden As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtBuscaMateriales As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents rbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents gbDatosAdicionales As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraColorPicker1 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents gbOI As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraColorPicker3 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraColorPicker2 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents uceEstadoOrden As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uceMovFiltro As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griOrden As ISL.Controles.Grilla
    Friend WithEvents btnRectificar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEjecutar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtNroOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents odOrden As ISL.Controles.OrigenDatos
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents odOrdenMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents fecFinDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicioDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uceTipoDocumento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ERegistroInventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnGenerarAsiento As Infragistics.Win.Misc.UltraButton
End Class
