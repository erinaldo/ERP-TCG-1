<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenVenMaterial
    Inherits ISL.Win.frm_MenuPadre

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
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenComercial")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPendiente")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAtender")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoInventario")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndImpuesto")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PDscto")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dscto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadReal")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenComercial")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPendiente")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAtender")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoInventario")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndImpuesto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PDscto")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dscto")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadReal")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMinimo")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMaximo")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMinimo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMaximo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPlanTrabajoEquipo")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPlanTrabajoEquipo")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMovimientoInventario")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreReferencia")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMovimientoInventario")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Orden")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreReferencia")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorAprobacion")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorAprobacion")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenComercial")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoExistencia")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreTipoCompra")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DocAsoc")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFactSer")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCantidadVariable")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenReferencia")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturadoProducto")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVendedorTrabajador")
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
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarOS")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarGuia")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EjecutarOS")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarNotaSalida")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarOS")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarGuia")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EjecutarOS")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarNotaSalida")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenVenMaterial))
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercialMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrdenComMat = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griAlmacenMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odAlmacenMaterial = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkTipoMaterial = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDestinoViaje = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboOrigenViaje = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkTransporte = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chbBuscarCod = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnBuscarMat = New Infragistics.Win.Misc.UltraButton()
        Me.txtMaterial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btn_ActualizarDetOrden = New Infragistics.Win.Misc.UltraButton()
        Me.griDetalleOrden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odDetalleOrden = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenSalida = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odOrdIng = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrdenComercial = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAnular = New Infragistics.Win.Misc.UltraButton()
        Me.btnAtender = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.colorTerminado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorEvaluado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorParcial = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAtendido = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAnulado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.grbNroOrden = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.rdbNroOrden = New System.Windows.Forms.RadioButton()
        Me.rdbDatosBasicos = New System.Windows.Forms.RadioButton()
        Me.grbDatosBasicos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbMonedaB = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbgClienteB = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.odEmpresa = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDetalleOrdenComercial = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.upMenu = New Infragistics.Win.Misc.UltraPanel()
        Me.btnBoletearSer = New Infragistics.Win.Misc.UltraButton()
        Me.btnFacturarSer = New Infragistics.Win.Misc.UltraButton()
        Me.ClientArea_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me._ClientArea_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuDetalle = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._ClientArea_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._ClientArea_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._ClientArea_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbgClienteAlterno = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboVendedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkFacturado = New System.Windows.Forms.CheckBox()
        Me.chkFactSer = New System.Windows.Forms.CheckBox()
        Me.btnCrearCtaCte = New Infragistics.Win.Misc.UltraButton()
        Me.txtCodSaldoCtaCte = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbgCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblOperacion = New Infragistics.Win.Misc.UltraLabel()
        Me.cbDocumento = New System.Windows.Forms.CheckBox()
        Me.cbRuc = New System.Windows.Forms.CheckBox()
        Me.decTipoCambio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnEmitirDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decImpuesto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decSubTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbMoneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.grbDocAsoc = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtEstadoDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmbTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.txtEstado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbNumeroOrden = New Infragistics.Win.Misc.UltraLabel()
        Me.ficOrdenComercial = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.griOrdenComercialMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.griAlmacenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odAlmacenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.chkTipoMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestinoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigenViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chbBuscarCod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.griDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.griOrdenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.odOrdIng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNroOrden.SuspendLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosBasicos.SuspendLayout()
        CType(Me.cmbMonedaB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgClienteB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.ficDetalleOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalleOrdenComercial.SuspendLayout()
        Me.upMenu.ClientArea.SuspendLayout()
        Me.upMenu.SuspendLayout()
        Me.ClientArea_Fill_Panel.SuspendLayout()
        CType(Me.mnuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgClienteAlterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodSaldoCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDocAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDocAsoc.SuspendLayout()
        CType(Me.txtEstadoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrdenComercial.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox10)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1213, 277)
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.griOrdenComercialMaterial)
        Me.UltraGroupBox10.Controls.Add(Me.gbeMateriales)
        Me.UltraGroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(1213, 277)
        Me.UltraGroupBox10.TabIndex = 0
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercialMaterial
        '
        Me.griOrdenComercialMaterial.DataSource = Me.odOrdenComMat
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercialMaterial.DisplayLayout.Appearance = Appearance1
        UltraGridColumn76.Header.VisiblePosition = 0
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 1
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.Caption = "SubAlmacen"
        UltraGridColumn78.Header.VisiblePosition = 16
        UltraGridColumn78.Width = 161
        UltraGridColumn79.Header.VisiblePosition = 13
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Width = 311
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn81.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn81.Header.Caption = "UM"
        UltraGridColumn81.Header.VisiblePosition = 4
        UltraGridColumn81.Width = 42
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn82.CellAppearance = Appearance2
        UltraGridColumn82.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn82.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn82.Header.VisiblePosition = 17
        UltraGridColumn82.Width = 269
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance3
        UltraGridColumn83.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn83.Format = "#,###,###,##0.000"
        UltraGridColumn83.Header.VisiblePosition = 5
        UltraGridColumn83.MaskInput = "{double:9.3}"
        UltraGridColumn83.Width = 72
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn84.CellAppearance = Appearance4
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn84.CellButtonAppearance = Appearance5
        UltraGridColumn84.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn84.Format = "#,###,###,##0.000"
        UltraGridColumn84.Header.Caption = "Pendiente"
        UltraGridColumn84.Header.VisiblePosition = 12
        UltraGridColumn84.MaskInput = "{double:9.3}"
        UltraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn84.Width = 80
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn85.CellAppearance = Appearance6
        UltraGridColumn85.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn85.Format = "#,###,###,##0.000"
        UltraGridColumn85.Header.Caption = "Atender"
        UltraGridColumn85.Header.VisiblePosition = 14
        UltraGridColumn85.MaskInput = "{double:9.3}"
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn85.Width = 80
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn86.CellAppearance = Appearance7
        UltraGridColumn86.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn86.Format = "#,###,###,##0.000"
        UltraGridColumn86.Header.Caption = "CostoU."
        UltraGridColumn86.Header.VisiblePosition = 7
        UltraGridColumn86.MaskInput = "{double:9.3}"
        UltraGridColumn86.Width = 80
        UltraGridColumn87.Header.VisiblePosition = 27
        UltraGridColumn87.Hidden = True
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn88.CellAppearance = Appearance8
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn88.Format = "#,###,###,##0.000"
        UltraGridColumn88.Header.Caption = "PrecioU."
        UltraGridColumn88.Header.VisiblePosition = 8
        UltraGridColumn88.MaskInput = "{double:9.3}"
        UltraGridColumn88.Width = 80
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance9
        UltraGridColumn89.Format = "#,###,###,##0.000"
        UltraGridColumn89.Header.VisiblePosition = 9
        UltraGridColumn89.MaskInput = "{double:9.3}"
        UltraGridColumn89.Width = 80
        UltraGridColumn90.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn90.Header.Caption = "IGV"
        UltraGridColumn90.Header.VisiblePosition = 6
        UltraGridColumn90.Width = 47
        UltraGridColumn91.Header.VisiblePosition = 18
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 19
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 20
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 21
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 22
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 23
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 24
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 2
        UltraGridColumn98.Width = 76
        UltraGridColumn99.Header.Caption = "Almacen"
        UltraGridColumn99.Header.VisiblePosition = 15
        UltraGridColumn99.Width = 195
        UltraGridColumn100.Header.VisiblePosition = 25
        UltraGridColumn100.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn101.CellAppearance = Appearance10
        UltraGridColumn101.Header.Caption = "%Dscto"
        UltraGridColumn101.Header.VisiblePosition = 10
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn102.CellAppearance = Appearance11
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn102.Header.VisiblePosition = 11
        UltraGridColumn102.MaskInput = "{double:4.2}"
        UltraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn102.Width = 59
        UltraGridColumn103.Header.VisiblePosition = 26
        UltraGridColumn103.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103})
        Me.griOrdenComercialMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griOrdenComercialMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercialMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.Appearance = Appearance12
        Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance13
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance14.BackColor2 = System.Drawing.SystemColors.Control
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance14
        Me.griOrdenComercialMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercialMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercialMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercialMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercialMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercialMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercialMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercialMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercialMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.griOrdenComercialMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercialMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercialMaterial.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griOrdenComercialMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercialMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercialMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercialMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercialMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercialMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercialMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercialMaterial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercialMaterial.Name = "griOrdenComercialMaterial"
        Me.griOrdenComercialMaterial.Size = New System.Drawing.Size(484, 271)
        Me.griOrdenComercialMaterial.TabIndex = 0
        Me.griOrdenComercialMaterial.Text = "Grilla2"
        '
        'odOrdenComMat
        '
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn28.DataType = GetType(Double)
        Me.odOrdenComMat.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28})
        '
        'Filtro
        '
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2007
        '
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(723, 271)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(487, 3)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(723, 271)
        Me.gbeMateriales.TabIndex = 1
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox12)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(700, 265)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.griAlmacenMaterial)
        Me.UltraGroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox13.Location = New System.Drawing.Point(0, 40)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(700, 225)
        Me.UltraGroupBox13.TabIndex = 3
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griAlmacenMaterial
        '
        Me.griAlmacenMaterial.DataSource = Me.odAlmacenMaterial
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAlmacenMaterial.DisplayLayout.Appearance = Appearance16
        UltraGridColumn104.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn104.Header.Caption = ""
        UltraGridColumn104.Header.VisiblePosition = 5
        UltraGridColumn104.Width = 29
        UltraGridColumn105.Header.VisiblePosition = 0
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 1
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 2
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.Caption = ""
        UltraGridColumn108.Header.VisiblePosition = 3
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 4
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 6
        UltraGridColumn110.Width = 233
        UltraGridColumn111.Header.VisiblePosition = 7
        UltraGridColumn111.Width = 213
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn112.CellAppearance = Appearance17
        UltraGridColumn112.Header.VisiblePosition = 9
        UltraGridColumn112.MaskInput = "{double:9.4}"
        UltraGridColumn112.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn113.Header.VisiblePosition = 10
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 11
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 12
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 13
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 14
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 15
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 16
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 17
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 18
        UltraGridColumn121.Hidden = True
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn122.CellAppearance = Appearance18
        UltraGridColumn122.Header.Caption = "Stock"
        UltraGridColumn122.Header.VisiblePosition = 8
        UltraGridColumn122.MaskInput = "{double:9.4}"
        UltraGridColumn122.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn124.Header.VisiblePosition = 19
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 20
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 21
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 22
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 23
        UltraGridColumn128.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128})
        Me.griAlmacenMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griAlmacenMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmacenMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.Appearance = Appearance19
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance20
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.griAlmacenMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmacenMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAlmacenMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmacenMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmacenMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmacenMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmacenMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Me.griAlmacenMaterial.DisplayLayout.Override.RowAppearance = Appearance22
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmacenMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAlmacenMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmacenMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAlmacenMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlmacenMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenMaterial.Location = New System.Drawing.Point(3, 3)
        Me.griAlmacenMaterial.Name = "griAlmacenMaterial"
        Me.griAlmacenMaterial.Size = New System.Drawing.Size(694, 219)
        Me.griAlmacenMaterial.TabIndex = 0
        Me.griAlmacenMaterial.Text = "Grilla2"
        '
        'odAlmacenMaterial
        '
        UltraDataColumn29.DataType = GetType(Boolean)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn45.DataType = GetType(Double)
        UltraDataColumn46.DataType = GetType(Double)
        UltraDataColumn47.DataType = GetType(Double)
        Me.odAlmacenMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52})
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.chkTipoMaterial)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox12.Controls.Add(Me.cboDestinoViaje)
        Me.UltraGroupBox12.Controls.Add(Me.cboOrigenViaje)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox12.Controls.Add(Me.chkTransporte)
        Me.UltraGroupBox12.Controls.Add(Me.chbBuscarCod)
        Me.UltraGroupBox12.Controls.Add(Me.btnBuscarMat)
        Me.UltraGroupBox12.Controls.Add(Me.txtMaterial)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(700, 40)
        Me.UltraGroupBox12.TabIndex = 0
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkTipoMaterial
        '
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.chkTipoMaterial.Appearance = Appearance23
        Me.chkTipoMaterial.BackColor = System.Drawing.Color.Transparent
        Me.chkTipoMaterial.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkTipoMaterial.Location = New System.Drawing.Point(403, 13)
        Me.chkTipoMaterial.Name = "chkTipoMaterial"
        Me.chkTipoMaterial.Size = New System.Drawing.Size(109, 22)
        Me.chkTipoMaterial.TabIndex = 3
        Me.chkTipoMaterial.Text = "Compra Venta"
        '
        'UltraLabel27
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UltraLabel27.Appearance = Appearance24
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Location = New System.Drawing.Point(24, 48)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel27.TabIndex = 353
        Me.UltraLabel27.Text = "Origen :"
        '
        'cboDestinoViaje
        '
        Me.cboDestinoViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDestinoViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDestinoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestinoViaje.Location = New System.Drawing.Point(366, 41)
        Me.cboDestinoViaje.Name = "cboDestinoViaje"
        Me.cboDestinoViaje.Size = New System.Drawing.Size(225, 22)
        Me.cboDestinoViaje.TabIndex = 356
        '
        'cboOrigenViaje
        '
        Me.cboOrigenViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboOrigenViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrigenViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigenViaje.Location = New System.Drawing.Point(75, 40)
        Me.cboOrigenViaje.Name = "cboOrigenViaje"
        Me.cboOrigenViaje.Size = New System.Drawing.Size(225, 22)
        Me.cboOrigenViaje.TabIndex = 355
        '
        'UltraLabel28
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UltraLabel28.Appearance = Appearance25
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(318, 48)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(46, 15)
        Me.UltraLabel28.TabIndex = 354
        Me.UltraLabel28.Text = "Destino:"
        '
        'chkTransporte
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.chkTransporte.Appearance = Appearance26
        Me.chkTransporte.AutoSize = True
        Me.chkTransporte.BackColor = System.Drawing.Color.Transparent
        Me.chkTransporte.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkTransporte.Location = New System.Drawing.Point(618, 13)
        Me.chkTransporte.Name = "chkTransporte"
        Me.chkTransporte.Size = New System.Drawing.Size(76, 18)
        Me.chkTransporte.TabIndex = 5
        Me.chkTransporte.Text = "Transporte"
        Me.chkTransporte.Visible = False
        '
        'chbBuscarCod
        '
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.chbBuscarCod.Appearance = Appearance27
        Me.chbBuscarCod.BackColor = System.Drawing.Color.Transparent
        Me.chbBuscarCod.BackColorInternal = System.Drawing.Color.Transparent
        Me.chbBuscarCod.Location = New System.Drawing.Point(552, 11)
        Me.chbBuscarCod.Name = "chbBuscarCod"
        Me.chbBuscarCod.Size = New System.Drawing.Size(60, 22)
        Me.chbBuscarCod.TabIndex = 4
        Me.chbBuscarCod.Text = "Codigo"
        Me.chbBuscarCod.Visible = False
        '
        'btnBuscarMat
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBuscarMat.Appearance = Appearance28
        Me.btnBuscarMat.Location = New System.Drawing.Point(367, 8)
        Me.btnBuscarMat.Name = "btnBuscarMat"
        Me.btnBuscarMat.Size = New System.Drawing.Size(30, 28)
        Me.btnBuscarMat.TabIndex = 2
        '
        'txtMaterial
        '
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Location = New System.Drawing.Point(76, 12)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(288, 22)
        Me.txtMaterial.TabIndex = 1
        '
        'UltraLabel20
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Appearance29.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance29
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(11, 16)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel20.TabIndex = 0
        Me.UltraLabel20.Text = "Materiales:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1213, 277)
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.btn_ActualizarDetOrden)
        Me.UltraGroupBox7.Controls.Add(Me.griDetalleOrden)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 147)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1213, 130)
        Me.UltraGroupBox7.TabIndex = 1
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btn_ActualizarDetOrden
        '
        Appearance30.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance30.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_ActualizarDetOrden.Appearance = Appearance30
        Me.btn_ActualizarDetOrden.Enabled = False
        Me.btn_ActualizarDetOrden.Location = New System.Drawing.Point(2, 3)
        Me.btn_ActualizarDetOrden.Name = "btn_ActualizarDetOrden"
        Me.btn_ActualizarDetOrden.Size = New System.Drawing.Size(41, 23)
        Me.btn_ActualizarDetOrden.TabIndex = 366
        '
        'griDetalleOrden
        '
        Me.griDetalleOrden.DataSource = Me.odDetalleOrden
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalleOrden.DisplayLayout.Appearance = Appearance31
        UltraGridColumn129.Header.VisiblePosition = 0
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 1
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.Header.VisiblePosition = 2
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 3
        UltraGridColumn132.Hidden = True
        UltraGridColumn255.Header.Caption = "Almacen"
        UltraGridColumn255.Header.VisiblePosition = 10
        UltraGridColumn255.Width = 221
        UltraGridColumn256.Header.Caption = "SubAlmacen"
        UltraGridColumn256.Header.VisiblePosition = 11
        UltraGridColumn256.Width = 203
        UltraGridColumn257.Header.VisiblePosition = 12
        UltraGridColumn257.Hidden = True
        UltraGridColumn258.Header.VisiblePosition = 13
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.VisiblePosition = 4
        UltraGridColumn260.Header.VisiblePosition = 5
        UltraGridColumn260.Width = 298
        UltraGridColumn261.Header.Caption = "UM"
        UltraGridColumn261.Header.VisiblePosition = 6
        UltraGridColumn261.Width = 48
        UltraGridColumn262.Header.VisiblePosition = 14
        UltraGridColumn262.Hidden = True
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn263.CellAppearance = Appearance32
        UltraGridColumn263.Header.VisiblePosition = 7
        UltraGridColumn263.MaskInput = "{double:9.3}"
        UltraGridColumn263.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn263.Width = 90
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn264.CellAppearance = Appearance33
        UltraGridColumn264.Header.VisiblePosition = 15
        UltraGridColumn264.Hidden = True
        UltraGridColumn264.MaskInput = "{double:9.4}"
        UltraGridColumn264.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn264.Width = 90
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn265.CellAppearance = Appearance34
        UltraGridColumn265.Header.VisiblePosition = 8
        UltraGridColumn265.MaskInput = "{double:9.3}"
        UltraGridColumn265.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn265.Width = 90
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn266.CellAppearance = Appearance35
        UltraGridColumn266.Header.VisiblePosition = 9
        UltraGridColumn266.MaskInput = "{double:9.3}"
        UltraGridColumn266.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn266.Width = 90
        UltraGridColumn267.Header.VisiblePosition = 16
        UltraGridColumn267.Hidden = True
        UltraGridColumn268.Header.VisiblePosition = 17
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.Header.VisiblePosition = 18
        UltraGridColumn269.Hidden = True
        UltraGridColumn270.Header.VisiblePosition = 19
        UltraGridColumn270.Hidden = True
        UltraGridColumn271.Header.VisiblePosition = 20
        UltraGridColumn271.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271})
        Me.griDetalleOrden.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griDetalleOrden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance36.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrden.DisplayLayout.GroupByBox.Appearance = Appearance36
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance37
        Me.griDetalleOrden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrden.DisplayLayout.GroupByBox.Hidden = True
        Appearance38.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance38.BackColor2 = System.Drawing.SystemColors.Control
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance38.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrden.DisplayLayout.GroupByBox.PromptAppearance = Appearance38
        Me.griDetalleOrden.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleOrden.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetalleOrden.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleOrden.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleOrden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleOrden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleOrden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleOrden.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleOrden.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleOrden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Me.griDetalleOrden.DisplayLayout.Override.RowAppearance = Appearance39
        Me.griDetalleOrden.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleOrden.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleOrden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleOrden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleOrden.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalleOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleOrden.Location = New System.Drawing.Point(3, 3)
        Me.griDetalleOrden.Name = "griDetalleOrden"
        Me.griDetalleOrden.Size = New System.Drawing.Size(1207, 124)
        Me.griDetalleOrden.TabIndex = 2
        Me.griDetalleOrden.Text = "Grilla2"
        '
        'odDetalleOrden
        '
        UltraDataColumn65.DataType = GetType(Double)
        UltraDataColumn66.DataType = GetType(Double)
        UltraDataColumn67.DataType = GetType(Double)
        UltraDataColumn68.DataType = GetType(Double)
        UltraDataColumn70.DataType = GetType(Date)
        UltraDataColumn72.DataType = GetType(Date)
        UltraDataColumn73.DataType = GetType(Boolean)
        Me.odDetalleOrden.Band.Columns.AddRange(New Object() {UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73})
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.griOrdenSalida)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1213, 147)
        Me.UltraGroupBox6.TabIndex = 0
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenSalida
        '
        Me.griOrdenSalida.ContextMenuStrip = Me.ContextMenuStrip1
        Me.griOrdenSalida.DataSource = Me.odOrdIng
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenSalida.DisplayLayout.Appearance = Appearance40
        UltraGridColumn272.Header.VisiblePosition = 0
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.Header.VisiblePosition = 1
        UltraGridColumn273.Hidden = True
        UltraGridColumn274.Header.VisiblePosition = 2
        UltraGridColumn274.Hidden = True
        UltraGridColumn275.Header.VisiblePosition = 3
        UltraGridColumn275.Hidden = True
        UltraGridColumn276.Header.VisiblePosition = 4
        UltraGridColumn276.Hidden = True
        UltraGridColumn277.Header.VisiblePosition = 5
        UltraGridColumn277.Hidden = True
        UltraGridColumn278.Header.VisiblePosition = 11
        UltraGridColumn278.Width = 99
        UltraGridColumn279.Header.VisiblePosition = 6
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 9
        UltraGridColumn280.Width = 115
        UltraGridColumn281.Header.VisiblePosition = 10
        UltraGridColumn281.Hidden = True
        UltraGridColumn282.Header.Caption = "TipoDocumento"
        UltraGridColumn282.Header.VisiblePosition = 12
        UltraGridColumn282.Width = 205
        UltraGridColumn283.Header.VisiblePosition = 7
        UltraGridColumn283.Width = 118
        UltraGridColumn284.Header.VisiblePosition = 13
        UltraGridColumn284.Hidden = True
        UltraGridColumn285.Header.Caption = "Documento"
        UltraGridColumn285.Header.VisiblePosition = 14
        UltraGridColumn285.Width = 112
        UltraGridColumn286.Header.VisiblePosition = 15
        UltraGridColumn286.Hidden = True
        UltraGridColumn287.Header.VisiblePosition = 16
        UltraGridColumn287.Hidden = True
        UltraGridColumn288.Header.VisiblePosition = 17
        UltraGridColumn288.Hidden = True
        UltraGridColumn289.Header.VisiblePosition = 18
        UltraGridColumn289.Hidden = True
        UltraGridColumn290.Header.VisiblePosition = 19
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 20
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 21
        UltraGridColumn292.Width = 108
        UltraGridColumn293.Header.Caption = "Fecha"
        UltraGridColumn293.Header.VisiblePosition = 8
        UltraGridColumn293.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn293.Width = 129
        UltraGridColumn294.Header.VisiblePosition = 22
        UltraGridColumn294.Hidden = True
        UltraGridColumn295.Header.VisiblePosition = 23
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.VisiblePosition = 24
        UltraGridColumn296.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296})
        Me.griOrdenSalida.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griOrdenSalida.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenSalida.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance41.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance41.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenSalida.DisplayLayout.GroupByBox.Appearance = Appearance41
        Appearance42.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenSalida.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance42
        Me.griOrdenSalida.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenSalida.DisplayLayout.GroupByBox.Hidden = True
        Appearance43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance43.BackColor2 = System.Drawing.SystemColors.Control
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenSalida.DisplayLayout.GroupByBox.PromptAppearance = Appearance43
        Me.griOrdenSalida.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenSalida.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenSalida.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenSalida.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenSalida.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenSalida.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenSalida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenSalida.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenSalida.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenSalida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance44.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenSalida.DisplayLayout.Override.RowAppearance = Appearance44
        Me.griOrdenSalida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenSalida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenSalida.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenSalida.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenSalida.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenSalida.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenSalida.Name = "griOrdenSalida"
        Me.griOrdenSalida.Size = New System.Drawing.Size(1207, 141)
        Me.griOrdenSalida.TabIndex = 3
        Me.griOrdenSalida.Text = "Grilla2"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'odOrdIng
        '
        UltraDataColumn91.DataType = GetType(Double)
        UltraDataColumn95.DataType = GetType(Date)
        UltraDataColumn97.DataType = GetType(Date)
        UltraDataColumn98.DataType = GetType(Boolean)
        Me.odOrdIng.Band.Columns.AddRange(New Object() {UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1221, 495)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griOrdenComercial)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 159)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1221, 336)
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercial
        '
        Me.griOrdenComercial.DataSource = Me.odOrdenComercial
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance45
        UltraGridColumn297.Header.VisiblePosition = 0
        UltraGridColumn297.Hidden = True
        UltraGridColumn298.Header.VisiblePosition = 1
        UltraGridColumn298.Hidden = True
        UltraGridColumn299.Header.VisiblePosition = 2
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.VisiblePosition = 3
        UltraGridColumn300.Hidden = True
        UltraGridColumn301.Header.VisiblePosition = 6
        UltraGridColumn301.Width = 211
        UltraGridColumn302.Header.VisiblePosition = 7
        UltraGridColumn302.Hidden = True
        UltraGridColumn303.Header.VisiblePosition = 8
        UltraGridColumn303.Hidden = True
        UltraGridColumn304.Header.VisiblePosition = 15
        UltraGridColumn304.Width = 149
        UltraGridColumn305.Header.VisiblePosition = 10
        UltraGridColumn305.Hidden = True
        UltraGridColumn306.Header.VisiblePosition = 9
        UltraGridColumn306.Width = 65
        UltraGridColumn307.Header.VisiblePosition = 11
        UltraGridColumn307.Hidden = True
        UltraGridColumn308.Header.VisiblePosition = 18
        UltraGridColumn308.Hidden = True
        UltraGridColumn308.Width = 231
        UltraGridColumn309.Header.VisiblePosition = 5
        UltraGridColumn310.Header.VisiblePosition = 4
        UltraGridColumn310.Width = 109
        UltraGridColumn311.Header.VisiblePosition = 17
        UltraGridColumn311.Width = 75
        UltraGridColumn312.Header.VisiblePosition = 19
        UltraGridColumn312.Hidden = True
        UltraGridColumn313.Header.VisiblePosition = 27
        UltraGridColumn313.Hidden = True
        UltraGridColumn314.Header.VisiblePosition = 20
        UltraGridColumn314.Hidden = True
        UltraGridColumn314.MaskInput = "{double:9.3}"
        UltraGridColumn315.Header.VisiblePosition = 28
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.MaskInput = "{double:9.3}"
        UltraGridColumn316.Header.Caption = "TipoCompra"
        UltraGridColumn316.Header.VisiblePosition = 21
        UltraGridColumn316.Hidden = True
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn317.CellAppearance = Appearance46
        UltraGridColumn317.Format = "#,###,###,##0.00"
        UltraGridColumn317.Header.VisiblePosition = 12
        UltraGridColumn317.MaskInput = "{double:9.2}"
        UltraGridColumn317.Width = 73
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn318.CellAppearance = Appearance47
        UltraGridColumn318.Format = "#,###,###,##0.00"
        UltraGridColumn318.Header.VisiblePosition = 13
        UltraGridColumn318.MaskInput = "{double:9.2}"
        UltraGridColumn318.Width = 73
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn319.CellAppearance = Appearance48
        UltraGridColumn319.Format = "#,###,###,##0.00"
        UltraGridColumn319.Header.VisiblePosition = 14
        UltraGridColumn319.MaskInput = "{double:9.2}"
        UltraGridColumn319.Width = 74
        UltraGridColumn320.Header.VisiblePosition = 22
        UltraGridColumn320.Hidden = True
        UltraGridColumn321.Header.VisiblePosition = 23
        UltraGridColumn321.Hidden = True
        UltraGridColumn322.Header.VisiblePosition = 24
        UltraGridColumn322.Hidden = True
        UltraGridColumn323.Header.VisiblePosition = 25
        UltraGridColumn323.Hidden = True
        UltraGridColumn324.Header.VisiblePosition = 26
        UltraGridColumn324.Hidden = True
        UltraGridColumn325.Header.VisiblePosition = 16
        UltraGridColumn325.Width = 89
        UltraGridColumn326.Header.VisiblePosition = 29
        UltraGridColumn326.Hidden = True
        UltraGridColumn327.Header.VisiblePosition = 30
        UltraGridColumn327.Hidden = True
        UltraGridColumn328.Header.VisiblePosition = 31
        UltraGridColumn328.Hidden = True
        UltraGridColumn329.Header.VisiblePosition = 32
        UltraGridColumn329.Hidden = True
        UltraGridColumn330.Header.VisiblePosition = 33
        UltraGridColumn330.Hidden = True
        UltraGridColumn331.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn331.Header.Caption = "Vendedor"
        UltraGridColumn331.Header.VisiblePosition = 34
        UltraGridColumn331.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn331.Width = 258
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance49.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance49
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance50
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance51.BackColor2 = System.Drawing.SystemColors.Control
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance51
        Me.griOrdenComercial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance52.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance52
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercial.Name = "griOrdenComercial"
        Me.griOrdenComercial.Size = New System.Drawing.Size(1215, 330)
        Me.griOrdenComercial.TabIndex = 1
        Me.griOrdenComercial.Text = "Grilla2"
        '
        'odOrdenComercial
        '
        UltraDataColumn111.DataType = GetType(Date)
        UltraDataColumn114.DataType = GetType(Short)
        UltraDataColumn116.DataType = GetType(Short)
        UltraDataColumn117.DataType = GetType(Double)
        UltraDataColumn119.DataType = GetType(Double)
        UltraDataColumn120.DataType = GetType(Double)
        UltraDataColumn121.DataType = GetType(Double)
        UltraDataColumn123.DataType = GetType(Date)
        UltraDataColumn125.DataType = GetType(Date)
        UltraDataColumn126.DataType = GetType(Boolean)
        UltraDataColumn128.DataType = GetType(Boolean)
        UltraDataColumn129.DataType = GetType(Boolean)
        UltraDataColumn130.DataType = GetType(Boolean)
        UltraDataColumn132.DataType = GetType(Boolean)
        Me.odOrdenComercial.Band.Columns.AddRange(New Object() {UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133})
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnEliminar)
        Me.UltraGroupBox2.Controls.Add(Me.btnAnular)
        Me.UltraGroupBox2.Controls.Add(Me.btnAtender)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 127)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1221, 32)
        Me.UltraGroupBox2.TabIndex = 4
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Appearance = Appearance53
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(177, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 26)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAnular
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.btnAnular.Appearance = Appearance54
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Enabled = False
        Me.btnAnular.Location = New System.Drawing.Point(90, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(87, 26)
        Me.btnAnular.TabIndex = 4
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAtender
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.btnAtender.Appearance = Appearance55
        Me.btnAtender.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAtender.Enabled = False
        Me.btnAtender.Location = New System.Drawing.Point(3, 3)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(87, 26)
        Me.btnAtender.TabIndex = 1
        Me.btnAtender.Text = "Atender"
        Me.btnAtender.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox11)
        Me.UltraGroupBox1.Controls.Add(Me.grbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbDatosBasicos)
        Me.UltraGroupBox1.Controls.Add(Me.grbDatosBasicos)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1221, 127)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Buscar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.colorTerminado)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox11.Controls.Add(Me.colorEvaluado)
        Me.UltraGroupBox11.Controls.Add(Me.colorParcial)
        Me.UltraGroupBox11.Controls.Add(Me.colorAtendido)
        Me.UltraGroupBox11.Controls.Add(Me.colorAnulado)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(413, 77)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(661, 42)
        Me.UltraGroupBox11.TabIndex = 344
        Me.UltraGroupBox11.Text = "Estados"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorTerminado
        '
        Me.colorTerminado.Color = System.Drawing.Color.LightGreen
        Me.colorTerminado.Location = New System.Drawing.Point(602, 16)
        Me.colorTerminado.Name = "colorTerminado"
        Me.colorTerminado.Size = New System.Drawing.Size(46, 22)
        Me.colorTerminado.TabIndex = 356
        Me.colorTerminado.Text = "LightGreen"
        '
        'UltraLabel26
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance56
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(535, 20)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel26.TabIndex = 355
        Me.UltraLabel26.Text = "Terminada:"
        '
        'UltraLabel25
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Appearance57.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance57
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(429, 20)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel25.TabIndex = 354
        Me.UltraLabel25.Text = "Anulada:"
        '
        'UltraLabel24
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Appearance58.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance58
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(319, 20)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel24.TabIndex = 353
        Me.UltraLabel24.Text = "Atendido:"
        '
        'UltraLabel23
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Appearance59.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance59
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(141, 20)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(120, 15)
        Me.UltraLabel23.TabIndex = 352
        Me.UltraLabel23.Text = "Atendido Parcialmente:"
        '
        'UltraLabel22
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Appearance60.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance60
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(27, 20)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel22.TabIndex = 351
        Me.UltraLabel22.Text = "Evaluado:"
        '
        'colorEvaluado
        '
        Me.colorEvaluado.Color = System.Drawing.Color.PaleGoldenrod
        Me.colorEvaluado.Location = New System.Drawing.Point(89, 16)
        Me.colorEvaluado.Name = "colorEvaluado"
        Me.colorEvaluado.Size = New System.Drawing.Size(46, 22)
        Me.colorEvaluado.TabIndex = 349
        Me.colorEvaluado.Text = "PaleGoldenrod"
        '
        'colorParcial
        '
        Me.colorParcial.Color = System.Drawing.Color.PaleTurquoise
        Me.colorParcial.Location = New System.Drawing.Point(267, 16)
        Me.colorParcial.Name = "colorParcial"
        Me.colorParcial.Size = New System.Drawing.Size(46, 22)
        Me.colorParcial.TabIndex = 348
        Me.colorParcial.Text = "PaleTurquoise"
        '
        'colorAtendido
        '
        Me.colorAtendido.Color = System.Drawing.Color.SandyBrown
        Me.colorAtendido.Location = New System.Drawing.Point(377, 16)
        Me.colorAtendido.Name = "colorAtendido"
        Me.colorAtendido.Size = New System.Drawing.Size(46, 22)
        Me.colorAtendido.TabIndex = 347
        Me.colorAtendido.Text = "SandyBrown"
        '
        'colorAnulado
        '
        Me.colorAnulado.Color = System.Drawing.Color.LightCoral
        Me.colorAnulado.Location = New System.Drawing.Point(483, 16)
        Me.colorAnulado.Name = "colorAnulado"
        Me.colorAnulado.Size = New System.Drawing.Size(46, 22)
        Me.colorAnulado.TabIndex = 346
        Me.colorAnulado.Text = "LightCoral"
        '
        'grbNroOrden
        '
        Me.grbNroOrden.Controls.Add(Me.UltraLabel19)
        Me.grbNroOrden.Controls.Add(Me.txtNroOrden)
        Me.grbNroOrden.Location = New System.Drawing.Point(413, 35)
        Me.grbNroOrden.Name = "grbNroOrden"
        Me.grbNroOrden.Size = New System.Drawing.Size(220, 39)
        Me.grbNroOrden.TabIndex = 343
        Me.grbNroOrden.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel19
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Appearance61.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance61
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel19.TabIndex = 344
        Me.UltraLabel19.Text = "Orden:"
        '
        'txtNroOrden
        '
        Me.txtNroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrden.Location = New System.Drawing.Point(51, 9)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(155, 22)
        Me.txtNroOrden.TabIndex = 0
        '
        'rdbNroOrden
        '
        Me.rdbNroOrden.AutoSize = True
        Me.rdbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rdbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rdbNroOrden.Location = New System.Drawing.Point(413, 18)
        Me.rdbNroOrden.Name = "rdbNroOrden"
        Me.rdbNroOrden.Size = New System.Drawing.Size(72, 17)
        Me.rdbNroOrden.TabIndex = 342
        Me.rdbNroOrden.Text = "NroOrden"
        Me.rdbNroOrden.UseVisualStyleBackColor = False
        '
        'rdbDatosBasicos
        '
        Me.rdbDatosBasicos.AutoSize = True
        Me.rdbDatosBasicos.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosBasicos.Checked = True
        Me.rdbDatosBasicos.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosBasicos.Location = New System.Drawing.Point(11, 18)
        Me.rdbDatosBasicos.Name = "rdbDatosBasicos"
        Me.rdbDatosBasicos.Size = New System.Drawing.Size(88, 17)
        Me.rdbDatosBasicos.TabIndex = 341
        Me.rdbDatosBasicos.TabStop = True
        Me.rdbDatosBasicos.Text = "DatosBasicos"
        Me.rdbDatosBasicos.UseVisualStyleBackColor = False
        '
        'grbDatosBasicos
        '
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel15)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel18)
        Me.grbDatosBasicos.Controls.Add(Me.cmbMonedaB)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel16)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaInicio)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaFin)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel14)
        Me.grbDatosBasicos.Controls.Add(Me.cboEstado)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel13)
        Me.grbDatosBasicos.Controls.Add(Me.cbgClienteB)
        Me.grbDatosBasicos.Location = New System.Drawing.Point(11, 35)
        Me.grbDatosBasicos.Name = "grbDatosBasicos"
        Me.grbDatosBasicos.Size = New System.Drawing.Size(392, 84)
        Me.grbDatosBasicos.TabIndex = 340
        Me.grbDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel15
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Appearance62.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance62
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(6, 9)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel15.TabIndex = 337
        Me.UltraLabel15.Text = "Desde:"
        '
        'UltraLabel18
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance63
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(7, 62)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel18.TabIndex = 339
        Me.UltraLabel18.Text = "Cliente:"
        '
        'cmbMonedaB
        '
        Me.cmbMonedaB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMonedaB.Location = New System.Drawing.Point(210, 5)
        Me.cmbMonedaB.Name = "cmbMonedaB"
        Me.cmbMonedaB.Size = New System.Drawing.Size(173, 22)
        Me.cmbMonedaB.TabIndex = 0
        '
        'UltraLabel16
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance64
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 35)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel16.TabIndex = 338
        Me.UltraLabel16.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(51, 6)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(99, 21)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(51, 32)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(99, 21)
        Me.dtpFechaFin.TabIndex = 2
        '
        'UltraLabel14
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance65
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(162, 35)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel14.TabIndex = 336
        Me.UltraLabel14.Text = "Estado:"
        '
        'cboEstado
        '
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.Location = New System.Drawing.Point(210, 31)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(173, 22)
        Me.cboEstado.TabIndex = 3
        Me.cboEstado.ValueMember = "Id"
        '
        'UltraLabel13
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Appearance66.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance66
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(156, 9)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel13.TabIndex = 335
        Me.UltraLabel13.Text = "Moneda:"
        '
        'cbgClienteB
        '
        Me.cbgClienteB.DataSource = Me.odEmpresa
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Appearance67.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgClienteB.DisplayLayout.Appearance = Appearance67
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 5
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Width = 250
        UltraGridColumn7.Header.VisiblePosition = 9
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn9.Header.VisiblePosition = 24
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 22
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 19
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 20
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 12
        UltraGridColumn18.Header.VisiblePosition = 14
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn24.Header.VisiblePosition = 18
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.cbgClienteB.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.cbgClienteB.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgClienteB.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance68.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance68.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteB.DisplayLayout.GroupByBox.Appearance = Appearance68
        Appearance69.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteB.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance69
        Me.cbgClienteB.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance70.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance70.BackColor2 = System.Drawing.SystemColors.Control
        Appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance70.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteB.DisplayLayout.GroupByBox.PromptAppearance = Appearance70
        Me.cbgClienteB.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgClienteB.DisplayLayout.MaxRowScrollRegions = 1
        Appearance71.BackColor = System.Drawing.SystemColors.Window
        Appearance71.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgClienteB.DisplayLayout.Override.ActiveCellAppearance = Appearance71
        Appearance72.BackColor = System.Drawing.SystemColors.Highlight
        Appearance72.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgClienteB.DisplayLayout.Override.ActiveRowAppearance = Appearance72
        Me.cbgClienteB.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cbgClienteB.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance73.BackColor = System.Drawing.SystemColors.Window
        Me.cbgClienteB.DisplayLayout.Override.CardAreaAppearance = Appearance73
        Appearance74.BorderColor = System.Drawing.Color.Silver
        Appearance74.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgClienteB.DisplayLayout.Override.CellAppearance = Appearance74
        Me.cbgClienteB.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgClienteB.DisplayLayout.Override.CellPadding = 0
        Appearance75.BackColor = System.Drawing.SystemColors.Control
        Appearance75.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance75.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance75.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteB.DisplayLayout.Override.GroupByRowAppearance = Appearance75
        Appearance76.TextHAlignAsString = "Left"
        Me.cbgClienteB.DisplayLayout.Override.HeaderAppearance = Appearance76
        Me.cbgClienteB.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cbgClienteB.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance77.BackColor = System.Drawing.SystemColors.Window
        Appearance77.BorderColor = System.Drawing.Color.Silver
        Me.cbgClienteB.DisplayLayout.Override.RowAppearance = Appearance77
        Me.cbgClienteB.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance78.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgClienteB.DisplayLayout.Override.TemplateAddRowAppearance = Appearance78
        Me.cbgClienteB.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgClienteB.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgClienteB.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgClienteB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgClienteB.Location = New System.Drawing.Point(55, 58)
        Me.cbgClienteB.Name = "cbgClienteB"
        Me.cbgClienteB.Size = New System.Drawing.Size(328, 23)
        Me.cbgClienteB.TabIndex = 333
        '
        'odEmpresa
        '
        Me.odEmpresa.DataSource = GetType(ISL.EntidadesWCF.e_Empresa)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1221, 495)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.ficDetalleOrdenComercial)
        Me.UltraGroupBox5.Controls.Add(Me.upMenu)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 163)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1221, 332)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalleOrdenComercial
        '
        Me.ficDetalleOrdenComercial.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalleOrdenComercial.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalleOrdenComercial.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalleOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalleOrdenComercial.Location = New System.Drawing.Point(3, 29)
        Me.ficDetalleOrdenComercial.Name = "ficDetalleOrdenComercial"
        Me.ficDetalleOrdenComercial.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalleOrdenComercial.Size = New System.Drawing.Size(1215, 300)
        Me.ficDetalleOrdenComercial.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Detalle"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "OrdenSalida"
        Me.ficDetalleOrdenComercial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDetalleOrdenComercial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1213, 277)
        '
        'upMenu
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Me.upMenu.Appearance = Appearance79
        '
        'upMenu.ClientArea
        '
        Me.upMenu.ClientArea.Controls.Add(Me.btnBoletearSer)
        Me.upMenu.ClientArea.Controls.Add(Me.btnFacturarSer)
        Me.upMenu.ClientArea.Controls.Add(Me.ClientArea_Fill_Panel)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Left)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Right)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Bottom)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Top)
        Me.upMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.upMenu.Location = New System.Drawing.Point(3, 3)
        Me.upMenu.Name = "upMenu"
        Me.upMenu.Size = New System.Drawing.Size(1215, 26)
        Me.upMenu.TabIndex = 0
        '
        'btnBoletearSer
        '
        Appearance80.BackColor = System.Drawing.Color.Gainsboro
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.btnBoletearSer.Appearance = Appearance80
        Me.btnBoletearSer.Location = New System.Drawing.Point(711, 0)
        Me.btnBoletearSer.Name = "btnBoletearSer"
        Me.btnBoletearSer.Size = New System.Drawing.Size(87, 23)
        Me.btnBoletearSer.TabIndex = 365
        Me.btnBoletearSer.Text = "Bolet. Serv."
        Me.btnBoletearSer.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnFacturarSer
        '
        Appearance81.BackColor = System.Drawing.Color.Gainsboro
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.btnFacturarSer.Appearance = Appearance81
        Me.btnFacturarSer.Location = New System.Drawing.Point(621, 0)
        Me.btnFacturarSer.Name = "btnFacturarSer"
        Me.btnFacturarSer.Size = New System.Drawing.Size(87, 23)
        Me.btnFacturarSer.TabIndex = 364
        Me.btnFacturarSer.Text = "Fact. Serv."
        Me.btnFacturarSer.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ClientArea_Fill_Panel
        '
        Me.ClientArea_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClientArea_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientArea_Fill_Panel.Location = New System.Drawing.Point(0, 28)
        Me.ClientArea_Fill_Panel.Name = "ClientArea_Fill_Panel"
        Me.ClientArea_Fill_Panel.Size = New System.Drawing.Size(1215, 0)
        Me.ClientArea_Fill_Panel.TabIndex = 0
        '
        '_ClientArea_Toolbars_Dock_Area_Left
        '
        Me._ClientArea_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._ClientArea_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 28)
        Me._ClientArea_Toolbars_Dock_Area_Left.Name = "_ClientArea_Toolbars_Dock_Area_Left"
        Me._ClientArea_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 0)
        Me._ClientArea_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnuDetalle
        '
        'mnuDetalle
        '
        Me.mnuDetalle.DesignerFlags = 1
        Me.mnuDetalle.DockWithinContainer = Me.upMenu.ClientArea
        Me.mnuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool11})
        UltraToolbar1.Text = "UltraToolbar1"
        Me.mnuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance82.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance82
        ButtonTool6.SharedPropsInternal.Caption = "Agregar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance83.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance83
        ButtonTool7.SharedPropsInternal.Caption = "Quitar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool8.SharedPropsInternal.Caption = "GenerarOS"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool9.SharedPropsInternal.Caption = "GenerarGuia"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool10.SharedPropsInternal.Caption = "EjecutarOS"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool12.SharedPropsInternal.Caption = "GenerarNotaSalida"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool12})
        '
        '_ClientArea_Toolbars_Dock_Area_Right
        '
        Me._ClientArea_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._ClientArea_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1215, 28)
        Me._ClientArea_Toolbars_Dock_Area_Right.Name = "_ClientArea_Toolbars_Dock_Area_Right"
        Me._ClientArea_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 0)
        Me._ClientArea_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnuDetalle
        '
        '_ClientArea_Toolbars_Dock_Area_Bottom
        '
        Me._ClientArea_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._ClientArea_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 26)
        Me._ClientArea_Toolbars_Dock_Area_Bottom.Name = "_ClientArea_Toolbars_Dock_Area_Bottom"
        Me._ClientArea_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1215, 0)
        Me._ClientArea_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnuDetalle
        '
        '_ClientArea_Toolbars_Dock_Area_Top
        '
        Me._ClientArea_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._ClientArea_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._ClientArea_Toolbars_Dock_Area_Top.Name = "_ClientArea_Toolbars_Dock_Area_Top"
        Me._ClientArea_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1215, 28)
        Me._ClientArea_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnuDetalle
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cboTipoPago)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox4.Controls.Add(Me.cbgClienteAlterno)
        Me.UltraGroupBox4.Controls.Add(Me.cboVendedor)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.chkFacturado)
        Me.UltraGroupBox4.Controls.Add(Me.chkFactSer)
        Me.UltraGroupBox4.Controls.Add(Me.btnCrearCtaCte)
        Me.UltraGroupBox4.Controls.Add(Me.txtCodSaldoCtaCte)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox4.Controls.Add(Me.cbgCliente)
        Me.UltraGroupBox4.Controls.Add(Me.lblOperacion)
        Me.UltraGroupBox4.Controls.Add(Me.cbDocumento)
        Me.UltraGroupBox4.Controls.Add(Me.cbRuc)
        Me.UltraGroupBox4.Controls.Add(Me.decTipoCambio)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox4.Controls.Add(Me.btnEmitirDoc)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox9)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFechaPago)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox4.Controls.Add(Me.cmbMoneda)
        Me.UltraGroupBox4.Controls.Add(Me.grbDocAsoc)
        Me.UltraGroupBox4.Controls.Add(Me.txtEstado)
        Me.UltraGroupBox4.Controls.Add(Me.txtOrden)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox4.Controls.Add(Me.lbNumeroOrden)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1221, 163)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipoPago
        '
        Appearance84.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance84
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance85.Image = 7
        EditorButton1.Appearance = Appearance85
        Me.cboTipoPago.ButtonsRight.Add(EditorButton1)
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(551, 5)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(230, 22)
        Me.cboTipoPago.TabIndex = 370
        Me.cboTipoPago.ValueMember = "Id"
        '
        'UltraLabel21
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance86
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(492, 60)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel21.TabIndex = 369
        Me.UltraLabel21.Text = "C. Alterno:"
        '
        'cbgClienteAlterno
        '
        EditorButton2.Key = "Left"
        Me.cbgClienteAlterno.ButtonsLeft.Add(EditorButton2)
        EditorButton3.Key = "Right"
        Me.cbgClienteAlterno.ButtonsRight.Add(EditorButton3)
        Me.cbgClienteAlterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbgClienteAlterno.DataSource = Me.odEmpresa
        Appearance87.BackColor = System.Drawing.SystemColors.Window
        Appearance87.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgClienteAlterno.DisplayLayout.Appearance = Appearance87
        UltraGridColumn357.Header.VisiblePosition = 0
        UltraGridColumn357.Hidden = True
        UltraGridColumn358.Header.VisiblePosition = 5
        UltraGridColumn358.Hidden = True
        UltraGridColumn359.Header.VisiblePosition = 1
        UltraGridColumn360.Header.VisiblePosition = 2
        UltraGridColumn361.Header.VisiblePosition = 3
        UltraGridColumn362.Header.VisiblePosition = 7
        UltraGridColumn362.Width = 300
        UltraGridColumn363.Header.VisiblePosition = 9
        UltraGridColumn363.Hidden = True
        UltraGridColumn364.Header.VisiblePosition = 6
        UltraGridColumn365.Header.VisiblePosition = 24
        UltraGridColumn365.Hidden = True
        UltraGridColumn366.Header.VisiblePosition = 8
        UltraGridColumn367.Header.VisiblePosition = 11
        UltraGridColumn367.Hidden = True
        UltraGridColumn368.Header.VisiblePosition = 13
        UltraGridColumn368.Hidden = True
        UltraGridColumn369.Header.VisiblePosition = 15
        UltraGridColumn369.Hidden = True
        UltraGridColumn370.Header.VisiblePosition = 22
        UltraGridColumn370.Hidden = True
        UltraGridColumn371.Header.VisiblePosition = 19
        UltraGridColumn371.Hidden = True
        UltraGridColumn372.Header.VisiblePosition = 20
        UltraGridColumn372.Hidden = True
        UltraGridColumn373.Header.VisiblePosition = 12
        UltraGridColumn374.Header.VisiblePosition = 14
        UltraGridColumn375.Header.VisiblePosition = 16
        UltraGridColumn376.Header.VisiblePosition = 17
        UltraGridColumn377.Header.VisiblePosition = 4
        UltraGridColumn377.Hidden = True
        UltraGridColumn378.Header.VisiblePosition = 21
        UltraGridColumn379.Header.VisiblePosition = 23
        UltraGridColumn380.Header.VisiblePosition = 18
        UltraGridColumn380.Hidden = True
        UltraGridColumn381.Header.VisiblePosition = 10
        UltraGridColumn381.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376, UltraGridColumn377, UltraGridColumn378, UltraGridColumn379, UltraGridColumn380, UltraGridColumn381})
        Me.cbgClienteAlterno.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.cbgClienteAlterno.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgClienteAlterno.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance88.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance88.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance88.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.Appearance = Appearance88
        Appearance89.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance89
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance90.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance90.BackColor2 = System.Drawing.SystemColors.Control
        Appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance90.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.PromptAppearance = Appearance90
        Me.cbgClienteAlterno.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgClienteAlterno.DisplayLayout.MaxRowScrollRegions = 1
        Appearance91.BackColor = System.Drawing.SystemColors.Window
        Appearance91.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgClienteAlterno.DisplayLayout.Override.ActiveCellAppearance = Appearance91
        Appearance92.BackColor = System.Drawing.SystemColors.Highlight
        Appearance92.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgClienteAlterno.DisplayLayout.Override.ActiveRowAppearance = Appearance92
        Me.cbgClienteAlterno.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgClienteAlterno.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance93.BackColor = System.Drawing.SystemColors.Window
        Me.cbgClienteAlterno.DisplayLayout.Override.CardAreaAppearance = Appearance93
        Appearance94.BorderColor = System.Drawing.Color.Silver
        Appearance94.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgClienteAlterno.DisplayLayout.Override.CellAppearance = Appearance94
        Me.cbgClienteAlterno.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgClienteAlterno.DisplayLayout.Override.CellPadding = 0
        Appearance95.BackColor = System.Drawing.SystemColors.Control
        Appearance95.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance95.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance95.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteAlterno.DisplayLayout.Override.GroupByRowAppearance = Appearance95
        Appearance96.TextHAlignAsString = "Left"
        Me.cbgClienteAlterno.DisplayLayout.Override.HeaderAppearance = Appearance96
        Me.cbgClienteAlterno.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance97.BackColor = System.Drawing.SystemColors.Window
        Appearance97.BorderColor = System.Drawing.Color.Silver
        Me.cbgClienteAlterno.DisplayLayout.Override.RowAppearance = Appearance97
        Me.cbgClienteAlterno.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance98.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgClienteAlterno.DisplayLayout.Override.TemplateAddRowAppearance = Appearance98
        Me.cbgClienteAlterno.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgClienteAlterno.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgClienteAlterno.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgClienteAlterno.DisplayMember = "Nombre"
        Me.cbgClienteAlterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgClienteAlterno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgClienteAlterno.Location = New System.Drawing.Point(551, 56)
        Me.cbgClienteAlterno.Name = "cbgClienteAlterno"
        Me.cbgClienteAlterno.Size = New System.Drawing.Size(303, 23)
        Me.cbgClienteAlterno.TabIndex = 368
        Me.cbgClienteAlterno.ValueMember = "Id"
        '
        'cboVendedor
        '
        Me.cboVendedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance99.Image = CType(resources.GetObject("Appearance99.Image"), Object)
        EditorButton4.Appearance = Appearance99
        Me.cboVendedor.ButtonsRight.Add(EditorButton4)
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVendedor.Location = New System.Drawing.Point(1063, 27)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(215, 22)
        Me.cboVendedor.TabIndex = 367
        Me.cboVendedor.Visible = False
        '
        'UltraLabel11
        '
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Appearance100.ForeColor = System.Drawing.Color.Navy
        Appearance100.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance100
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(1063, 10)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel11.TabIndex = 366
        Me.UltraLabel11.Text = "Vendedor:"
        Me.UltraLabel11.Visible = False
        '
        'chkFacturado
        '
        Me.chkFacturado.AutoSize = True
        Me.chkFacturado.BackColor = System.Drawing.Color.Transparent
        Me.chkFacturado.ForeColor = System.Drawing.Color.Navy
        Me.chkFacturado.Location = New System.Drawing.Point(1179, 60)
        Me.chkFacturado.Name = "chkFacturado"
        Me.chkFacturado.Size = New System.Drawing.Size(120, 17)
        Me.chkFacturado.TabIndex = 22
        Me.chkFacturado.Text = "Servicio Facturado?"
        Me.chkFacturado.UseVisualStyleBackColor = False
        Me.chkFacturado.Visible = False
        '
        'chkFactSer
        '
        Me.chkFactSer.AutoSize = True
        Me.chkFactSer.BackColor = System.Drawing.Color.Transparent
        Me.chkFactSer.ForeColor = System.Drawing.Color.Navy
        Me.chkFactSer.Location = New System.Drawing.Point(1063, 61)
        Me.chkFactSer.Name = "chkFactSer"
        Me.chkFactSer.Size = New System.Drawing.Size(100, 17)
        Me.chkFactSer.TabIndex = 21
        Me.chkFactSer.Text = "Servicio Carga?"
        Me.chkFactSer.UseVisualStyleBackColor = False
        Me.chkFactSer.Visible = False
        '
        'btnCrearCtaCte
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCtaCte.Appearance = Appearance101
        Me.btnCrearCtaCte.AutoSize = True
        Me.btnCrearCtaCte.Enabled = False
        Me.btnCrearCtaCte.Location = New System.Drawing.Point(933, 123)
        Me.btnCrearCtaCte.Name = "btnCrearCtaCte"
        Me.btnCrearCtaCte.Size = New System.Drawing.Size(10, 10)
        Me.btnCrearCtaCte.TabIndex = 28
        '
        'txtCodSaldoCtaCte
        '
        Me.txtCodSaldoCtaCte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodSaldoCtaCte.Enabled = False
        Me.txtCodSaldoCtaCte.Location = New System.Drawing.Point(794, 125)
        Me.txtCodSaldoCtaCte.MaxLength = 20
        Me.txtCodSaldoCtaCte.Name = "txtCodSaldoCtaCte"
        Me.txtCodSaldoCtaCte.ReadOnly = True
        Me.txtCodSaldoCtaCte.Size = New System.Drawing.Size(133, 22)
        Me.txtCodSaldoCtaCte.TabIndex = 27
        Me.txtCodSaldoCtaCte.Tag = "Numero Documento"
        '
        'UltraLabel29
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel29.Appearance = Appearance102
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Enabled = False
        Me.UltraLabel29.Location = New System.Drawing.Point(743, 129)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel29.TabIndex = 26
        Me.UltraLabel29.Text = "Cta Cte:"
        '
        'cbgCliente
        '
        EditorButton5.Key = "Left"
        Me.cbgCliente.ButtonsLeft.Add(EditorButton5)
        EditorButton6.Key = "Right"
        Me.cbgCliente.ButtonsRight.Add(EditorButton6)
        Me.cbgCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbgCliente.DataSource = Me.odEmpresa
        Appearance103.BackColor = System.Drawing.SystemColors.Window
        Appearance103.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgCliente.DisplayLayout.Appearance = Appearance103
        UltraGridColumn382.Header.VisiblePosition = 0
        UltraGridColumn382.Hidden = True
        UltraGridColumn383.Header.VisiblePosition = 5
        UltraGridColumn383.Hidden = True
        UltraGridColumn384.Header.VisiblePosition = 1
        UltraGridColumn385.Header.VisiblePosition = 2
        UltraGridColumn386.Header.VisiblePosition = 3
        UltraGridColumn387.Header.VisiblePosition = 7
        UltraGridColumn387.Width = 300
        UltraGridColumn388.Header.VisiblePosition = 9
        UltraGridColumn388.Hidden = True
        UltraGridColumn389.Header.VisiblePosition = 6
        UltraGridColumn390.Header.VisiblePosition = 24
        UltraGridColumn390.Hidden = True
        UltraGridColumn391.Header.VisiblePosition = 8
        UltraGridColumn392.Header.VisiblePosition = 11
        UltraGridColumn392.Hidden = True
        UltraGridColumn393.Header.VisiblePosition = 13
        UltraGridColumn393.Hidden = True
        UltraGridColumn394.Header.VisiblePosition = 15
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.VisiblePosition = 22
        UltraGridColumn395.Hidden = True
        UltraGridColumn396.Header.VisiblePosition = 19
        UltraGridColumn396.Hidden = True
        UltraGridColumn397.Header.VisiblePosition = 20
        UltraGridColumn397.Hidden = True
        UltraGridColumn398.Header.VisiblePosition = 12
        UltraGridColumn399.Header.VisiblePosition = 14
        UltraGridColumn400.Header.VisiblePosition = 16
        UltraGridColumn401.Header.VisiblePosition = 17
        UltraGridColumn402.Header.VisiblePosition = 4
        UltraGridColumn402.Hidden = True
        UltraGridColumn403.Header.VisiblePosition = 21
        UltraGridColumn404.Header.VisiblePosition = 23
        UltraGridColumn405.Header.VisiblePosition = 18
        UltraGridColumn405.Hidden = True
        UltraGridColumn406.Header.VisiblePosition = 10
        UltraGridColumn406.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn382, UltraGridColumn383, UltraGridColumn384, UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406})
        Me.cbgCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.cbgCliente.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance104.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance104.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance104.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.GroupByBox.Appearance = Appearance104
        Appearance105.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance105
        Me.cbgCliente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance106.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance106.BackColor2 = System.Drawing.SystemColors.Control
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance106.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.PromptAppearance = Appearance106
        Me.cbgCliente.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgCliente.DisplayLayout.MaxRowScrollRegions = 1
        Appearance107.BackColor = System.Drawing.SystemColors.Window
        Appearance107.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgCliente.DisplayLayout.Override.ActiveCellAppearance = Appearance107
        Appearance108.BackColor = System.Drawing.SystemColors.Highlight
        Appearance108.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgCliente.DisplayLayout.Override.ActiveRowAppearance = Appearance108
        Me.cbgCliente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance109.BackColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.CardAreaAppearance = Appearance109
        Appearance110.BorderColor = System.Drawing.Color.Silver
        Appearance110.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgCliente.DisplayLayout.Override.CellAppearance = Appearance110
        Me.cbgCliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgCliente.DisplayLayout.Override.CellPadding = 0
        Appearance111.BackColor = System.Drawing.SystemColors.Control
        Appearance111.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance111.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance111.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.GroupByRowAppearance = Appearance111
        Appearance112.TextHAlignAsString = "Left"
        Me.cbgCliente.DisplayLayout.Override.HeaderAppearance = Appearance112
        Me.cbgCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance113.BackColor = System.Drawing.SystemColors.Window
        Appearance113.BorderColor = System.Drawing.Color.Silver
        Me.cbgCliente.DisplayLayout.Override.RowAppearance = Appearance113
        Me.cbgCliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance114.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgCliente.DisplayLayout.Override.TemplateAddRowAppearance = Appearance114
        Me.cbgCliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgCliente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgCliente.DisplayMember = "Nombre"
        Me.cbgCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgCliente.Location = New System.Drawing.Point(72, 57)
        Me.cbgCliente.Name = "cbgCliente"
        Me.cbgCliente.Size = New System.Drawing.Size(338, 23)
        Me.cbgCliente.TabIndex = 9
        Me.cbgCliente.ValueMember = "Id"
        '
        'lblOperacion
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Red
        Appearance115.TextVAlignAsString = "Middle"
        Me.lblOperacion.Appearance = Appearance115
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.Location = New System.Drawing.Point(586, 126)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 0)
        Me.lblOperacion.TabIndex = 25
        '
        'cbDocumento
        '
        Me.cbDocumento.AutoSize = True
        Me.cbDocumento.BackColor = System.Drawing.Color.Transparent
        Me.cbDocumento.ForeColor = System.Drawing.Color.Navy
        Me.cbDocumento.Location = New System.Drawing.Point(10, 84)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(15, 14)
        Me.cbDocumento.TabIndex = 11
        Me.cbDocumento.UseVisualStyleBackColor = False
        '
        'cbRuc
        '
        Me.cbRuc.AutoSize = True
        Me.cbRuc.BackColor = System.Drawing.Color.Transparent
        Me.cbRuc.ForeColor = System.Drawing.Color.Navy
        Me.cbRuc.Location = New System.Drawing.Point(416, 58)
        Me.cbRuc.Name = "cbRuc"
        Me.cbRuc.Size = New System.Drawing.Size(47, 17)
        Me.cbRuc.TabIndex = 10
        Me.cbRuc.Text = "RUC"
        Me.cbRuc.UseVisualStyleBackColor = False
        '
        'decTipoCambio
        '
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Location = New System.Drawing.Point(694, 31)
        Me.decTipoCambio.MaskInput = "{double:2.3}"
        Me.decTipoCambio.MaxValue = 5.0R
        Me.decTipoCambio.MinValue = 0R
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.Size = New System.Drawing.Size(44, 22)
        Me.decTipoCambio.TabIndex = 18
        Me.decTipoCambio.TabStop = False
        '
        'UltraLabel12
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Appearance116.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance116
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(660, 35)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(28, 15)
        Me.UltraLabel12.TabIndex = 17
        Me.UltraLabel12.Text = "T.C.:"
        '
        'btnEmitirDoc
        '
        Appearance117.BackColor = System.Drawing.Color.Gainsboro
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Me.btnEmitirDoc.Appearance = Appearance117
        Me.btnEmitirDoc.Enabled = False
        Me.btnEmitirDoc.Location = New System.Drawing.Point(477, 119)
        Me.btnEmitirDoc.Name = "btnEmitirDoc"
        Me.btnEmitirDoc.Size = New System.Drawing.Size(87, 28)
        Me.btnEmitirDoc.TabIndex = 24
        Me.btnEmitirDoc.Text = "Emi. Doc."
        Me.btnEmitirDoc.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.decTotal)
        Me.UltraGroupBox9.Controls.Add(Me.decImpuesto)
        Me.UltraGroupBox9.Controls.Add(Me.decSubTotal)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox9.Location = New System.Drawing.Point(477, 84)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(494, 34)
        Me.UltraGroupBox9.TabIndex = 23
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTotal
        '
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Location = New System.Drawing.Point(383, 6)
        Me.decTotal.MaskInput = "{double:9.2}"
        Me.decTotal.Name = "decTotal"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.ReadOnly = True
        Me.decTotal.Size = New System.Drawing.Size(100, 22)
        Me.decTotal.TabIndex = 5
        '
        'decImpuesto
        '
        Me.decImpuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImpuesto.Location = New System.Drawing.Point(238, 6)
        Me.decImpuesto.MaskInput = "{double:9.2}"
        Me.decImpuesto.Name = "decImpuesto"
        Me.decImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImpuesto.ReadOnly = True
        Me.decImpuesto.Size = New System.Drawing.Size(100, 22)
        Me.decImpuesto.TabIndex = 3
        '
        'decSubTotal
        '
        Me.decSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal.Location = New System.Drawing.Point(65, 6)
        Me.decSubTotal.MaskInput = "{double:9.2}"
        Me.decSubTotal.Name = "decSubTotal"
        Me.decSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal.ReadOnly = True
        Me.decSubTotal.Size = New System.Drawing.Size(100, 22)
        Me.decSubTotal.TabIndex = 1
        '
        'UltraLabel10
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Appearance118.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance118
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(344, 10)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Total:"
        '
        'UltraLabel7
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Appearance119.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance119
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(7, 10)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "SubTotal:"
        '
        'UltraLabel9
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Appearance120.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance120
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(173, 10)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(55, 15)
        Me.UltraLabel9.TabIndex = 2
        Me.UltraLabel9.Text = "Impuesto:"
        '
        'UltraLabel6
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Appearance121.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance121
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(819, 10)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel6.TabIndex = 19
        Me.UltraLabel6.Text = "Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(860, 6)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(186, 69)
        Me.txtGlosa.TabIndex = 20
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Enabled = False
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(551, 32)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(103, 21)
        Me.dtpFechaPago.TabIndex = 16
        '
        'UltraLabel5
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Appearance122.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance122
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(483, 35)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(67, 15)
        Me.UltraLabel5.TabIndex = 15
        Me.UltraLabel5.Text = "FechaCobro:"
        '
        'UltraLabel4
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Appearance123.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance123
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(491, 10)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel4.TabIndex = 13
        Me.UltraLabel4.Text = "TipoCobro:"
        '
        'UltraLabel3
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance124
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(277, 35)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Moneda:"
        '
        'UltraLabel2
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Appearance125.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance125
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(257, 10)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "FechaOrden:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(331, 6)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(134, 21)
        Me.dtpFecha.TabIndex = 3
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMoneda.Location = New System.Drawing.Point(331, 31)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(134, 22)
        Me.cmbMoneda.TabIndex = 7
        Me.cmbMoneda.ValueMember = "Id"
        '
        'grbDocAsoc
        '
        Me.grbDocAsoc.Controls.Add(Me.txtEstadoDoc)
        Me.grbDocAsoc.Controls.Add(Me.txtNumero)
        Me.grbDocAsoc.Controls.Add(Me.UltraLabel1)
        Me.grbDocAsoc.Controls.Add(Me.txtSerie)
        Me.grbDocAsoc.Controls.Add(Me.cmbTipoDocumento)
        Me.grbDocAsoc.Controls.Add(Me.dtpFechaDoc)
        Me.grbDocAsoc.Enabled = False
        Me.grbDocAsoc.Location = New System.Drawing.Point(25, 84)
        Me.grbDocAsoc.Name = "grbDocAsoc"
        Me.grbDocAsoc.Size = New System.Drawing.Size(446, 63)
        Me.grbDocAsoc.TabIndex = 12
        Me.grbDocAsoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtEstadoDoc
        '
        Me.txtEstadoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstadoDoc.Location = New System.Drawing.Point(241, 33)
        Me.txtEstadoDoc.Name = "txtEstadoDoc"
        Me.txtEstadoDoc.ReadOnly = True
        Me.txtEstadoDoc.Size = New System.Drawing.Size(199, 22)
        Me.txtEstadoDoc.TabIndex = 5
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Location = New System.Drawing.Point(320, 6)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(120, 22)
        Me.txtNumero.TabIndex = 4
        '
        'UltraLabel1
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Appearance126.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance126
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 35)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(57, 15)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "FechaDoc:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Location = New System.Drawing.Point(241, 6)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(73, 22)
        Me.txtSerie.TabIndex = 3
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 6)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(229, 22)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'dtpFechaDoc
        '
        Me.dtpFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDoc.Location = New System.Drawing.Point(69, 33)
        Me.dtpFechaDoc.Name = "dtpFechaDoc"
        Me.dtpFechaDoc.Size = New System.Drawing.Size(166, 21)
        Me.dtpFechaDoc.TabIndex = 2
        '
        'txtEstado
        '
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Location = New System.Drawing.Point(72, 31)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(159, 22)
        Me.txtEstado.TabIndex = 5
        '
        'txtOrden
        '
        Me.txtOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOrden.Location = New System.Drawing.Point(72, 6)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(159, 22)
        Me.txtOrden.TabIndex = 1
        '
        'UltraLabel8
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Appearance127.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance127
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(24, 60)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel8.TabIndex = 8
        Me.UltraLabel8.Text = "Cliente:"
        '
        'UltraLabel17
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Appearance128.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance128
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(24, 35)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 4
        Me.UltraLabel17.Text = "Estado:"
        '
        'lbNumeroOrden
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.lbNumeroOrden.Appearance = Appearance129
        Me.lbNumeroOrden.AutoSize = True
        Me.lbNumeroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroOrden.Location = New System.Drawing.Point(27, 10)
        Me.lbNumeroOrden.Name = "lbNumeroOrden"
        Me.lbNumeroOrden.Size = New System.Drawing.Size(39, 15)
        Me.lbNumeroOrden.TabIndex = 0
        Me.lbNumeroOrden.Text = "Orden:"
        '
        'ficOrdenComercial
        '
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrdenComercial.Location = New System.Drawing.Point(0, 0)
        Me.ficOrdenComercial.Name = "ficOrdenComercial"
        Me.ficOrdenComercial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrdenComercial.Size = New System.Drawing.Size(1223, 518)
        Me.ficOrdenComercial.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.ficOrdenComercial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficOrdenComercial.TabStop = False
        Me.ficOrdenComercial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1221, 495)
        '
        'frm_OrdenVenMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 518)
        Me.Controls.Add(Me.ficOrdenComercial)
        Me.Name = "frm_OrdenVenMaterial"
        Me.Text = "OrdenVentaMaterial"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        CType(Me.griOrdenComercialMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.griAlmacenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odAlmacenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        Me.UltraGroupBox12.PerformLayout()
        CType(Me.chkTipoMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestinoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigenViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chbBuscarCod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.griDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.griOrdenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.odOrdIng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNroOrden.ResumeLayout(False)
        Me.grbNroOrden.PerformLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosBasicos.ResumeLayout(False)
        Me.grbDatosBasicos.PerformLayout()
        CType(Me.cmbMonedaB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgClienteB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.ficDetalleOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalleOrdenComercial.ResumeLayout(False)
        Me.upMenu.ClientArea.ResumeLayout(False)
        Me.upMenu.ResumeLayout(False)
        Me.ClientArea_Fill_Panel.ResumeLayout(False)
        CType(Me.mnuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgClienteAlterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodSaldoCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        Me.UltraGroupBox9.PerformLayout()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDocAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDocAsoc.ResumeLayout(False)
        Me.grbDocAsoc.PerformLayout()
        CType(Me.txtEstadoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrdenComercial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficOrdenComercial As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Filtro As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents odOrdenComercial As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odOrdenComMat As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odOrdIng As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odDetalleOrden As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cmbMonedaB As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMoneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents grbDocAsoc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtEstadoDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmbTipoDocumento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dtpFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEstado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbNumeroOrden As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTipoCambio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnEmitirDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents decTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decImpuesto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decSubTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAtender As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbgClienteB As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents rdbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDatosBasicos As System.Windows.Forms.RadioButton
    Friend WithEvents grbDatosBasicos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents colorEvaluado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorParcial As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAtendido As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAnulado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents grbNroOrden As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents odAlmacenMaterial As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ficDetalleOrdenComercial As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercialMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDetalleOrden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents odEmpresa As System.Windows.Forms.BindingSource
    Friend WithEvents cbRuc As System.Windows.Forms.CheckBox
    Friend WithEvents cbDocumento As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblOperacion As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAnular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents colorTerminado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griOrdenSalida As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cbgCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griAlmacenMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chbBuscarCod As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnBuscarMat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMaterial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    ' Friend WithEvents _ClientArea_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuDetalle As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    'Friend WithEvents _ClientArea_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    'Friend WithEvents _ClientArea_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    'Friend WithEvents _ClientArea_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents chkTransporte As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboDestinoViaje As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboOrigenViaje As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCrearCtaCte As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtCodSaldoCtaCte As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upMenu As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ClientArea_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents btnFacturarSer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkFactSer As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacturado As System.Windows.Forms.CheckBox
    Friend WithEvents btnBoletearSer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_ActualizarDetOrden As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboVendedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkTipoMaterial As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbgClienteAlterno As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboTipoPago As Controles.ComboMaestros
End Class
