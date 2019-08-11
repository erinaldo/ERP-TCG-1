<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenAsignacion
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadInicial")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadIngreso")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadSalida")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadFinal")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorTotal")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMayor")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMin")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMax")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Editar", 0)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "ValorTotal", 12, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "ValorTotal", 12, True)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "PrecioTotal", 14, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "PrecioTotal", 14, True)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim UltraGridColumn526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEquipo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEquipo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEquipo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEquipo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenAsignacion")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndUnidadAsignacion")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidad")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadAsignada")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialEntregada")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialDevuelto")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDescuento")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDescuento")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenAsignacion")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndUnidadAsignacion")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidad")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialEntregada")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialDevuelto")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOA_Material")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantAux")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDescuento")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDescuento")
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
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenAsignacion")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndUnidadAsignacion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidad")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialEntregada")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialDevuelto")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOA_Material")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantAux")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDescuento")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoDescuento")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenAsignacion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndUnidadAsignacion")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidad")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadAsignada")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialEntregada")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialDevuelto")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDescuento")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoDescuento")
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOA")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadAsignada")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOA")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOA")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndUnidadAsignada")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOA")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadAsignada")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOA")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOA")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndUnidadAsignada")
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utDetalle")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Devolucion")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Actualizar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Devolucion")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenAsignacion))
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Actualizar")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand3 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOA_Material")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Especificaciones")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenAsignacion")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndUnidadAsignacion")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidad")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialEntregada")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialDevuelto")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOA_Material")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenAsignacion")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndUnidadAsignacion")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidad")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadAsignada")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialEntregada")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialDevuelto")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridInventario = New ISL.Controles.Grilla(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarRequerimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularOAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grReg_Inv = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griEquipos = New ISL.Controles.Grilla(Me.components)
        Me.odEquipos = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griArea = New ISL.Controles.Grilla(Me.components)
        Me.odArea = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTrabajadores = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_Materiales = New ISL.Controles.Grilla(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.optBusqueda = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.btnListarMateriales = New ISL.Controles.Boton(Me.components)
        Me.txtBuscarMateriales = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_UA_Material = New ISL.Controles.Grilla(Me.components)
        Me.odEAT = New ISL.Controles.OrigenDatos(Me.components)
        Me.uebHistorialMaterial = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ficHistorialMaterial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.gbEAT = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.fcEAT = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_OA = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenAsociacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnAnular = New ISL.Controles.Boton(Me.components)
        Me.btnCerrar = New ISL.Controles.Boton(Me.components)
        Me.btnEjecutar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.gbDatosAdicionales = New ISL.Controles.Agrupacion(Me.components)
        Me.rfFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.rfFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.cmdTipoUnidadAsignada = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiEPA = New ISL.Controles.Etiqueta(Me.components)
        Me.cmEstadoOA = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmEAT = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.gbNroOA = New ISL.Controles.Agrupacion(Me.components)
        Me.txtOA = New ISL.Controles.Texto(Me.components)
        Me.rbNroOA = New System.Windows.Forms.RadioButton()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresAnulado = New ISL.Controles.Colores(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.ColoresTerminada = New ISL.Controles.Colores(Me.components)
        Me.ColoresEnProceso = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalle = New ISL.Controles.Agrupacion(Me.components)
        Me.fcMaterial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnDetalle = New ISL.Controles.Menu(Me.components)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.etiGenerando = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroOA = New ISL.Controles.Texto(Me.components)
        Me.odDetalleAsignacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.tcOA = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.grid_Materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.optBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.grid_UA_Material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uebHistorialMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uebHistorialMaterial.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.ficHistorialMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficHistorialMaterial.SuspendLayout()
        CType(Me.gbEAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEAT.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.fcEAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fcEAT.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.grid_OA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenAsociacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cmdTipoUnidadAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmEstadoOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmEAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbNroOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNroOA.SuspendLayout()
        CType(Me.txtOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.ColoresAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEnProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalle.SuspendLayout()
        CType(Me.fcMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fcMaterial.SuspendLayout()
        CType(Me.mnDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcOA.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.gridInventario)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(587, 183)
        '
        'gridInventario
        '
        Me.gridInventario.ContextMenuStrip = Me.mcDetalle
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 86
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Width = 304
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Unid. Medida"
        UltraGridColumn15.Header.VisiblePosition = 7
        UltraGridColumn15.Width = 85
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance1
        UltraGridColumn17.Format = "#,##0.0000"
        UltraGridColumn17.Header.Caption = "Cant. Inicial"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.MaskInput = "{double:-9.3:c}"
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance2
        UltraGridColumn18.Format = "#,##0.0000"
        UltraGridColumn18.Header.Caption = "Cant. Ingreso"
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.MaskInput = "{double:-9.3:c}"
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance3
        UltraGridColumn30.Format = "#,##0.0000"
        UltraGridColumn30.Header.Caption = "Cant. Salida"
        UltraGridColumn30.Header.VisiblePosition = 11
        UltraGridColumn30.MaskInput = "{double:-9.3:c}"
        Appearance4.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance4
        UltraGridColumn31.Format = "#,##0.0000"
        UltraGridColumn31.Header.Caption = "Stock"
        UltraGridColumn31.Header.VisiblePosition = 12
        UltraGridColumn31.MaskInput = "{double:-9.3:c}"
        UltraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance5
        UltraGridColumn32.Format = "#,##0.0000"
        UltraGridColumn32.Header.Caption = "Costo Unit."
        UltraGridColumn32.Header.VisiblePosition = 13
        UltraGridColumn32.MaskInput = "{double:-9.3:c}"
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance6
        UltraGridColumn33.Format = "#,##0.0000"
        UltraGridColumn33.Header.Caption = "Costo Total."
        UltraGridColumn33.Header.VisiblePosition = 14
        UltraGridColumn33.MaskInput = "{double:-9.3:c}"
        UltraGridColumn33.Width = 101
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance7
        UltraGridColumn34.Format = "#,##0.0000"
        UltraGridColumn34.Header.Caption = "Precio Unit."
        UltraGridColumn34.Header.VisiblePosition = 15
        UltraGridColumn34.MaskInput = "{double:-9.3:c}"
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance8
        UltraGridColumn35.Format = "#,##0.0000"
        UltraGridColumn35.Header.Caption = "Precio Total"
        UltraGridColumn35.Header.VisiblePosition = 16
        UltraGridColumn35.MaskInput = "{double:-9.3:c}"
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn36.CellAppearance = Appearance9
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Header.Caption = "Actualizado Al"
        UltraGridColumn36.Header.VisiblePosition = 17
        UltraGridColumn37.Header.VisiblePosition = 18
        UltraGridColumn37.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance10
        UltraGridColumn38.Header.Caption = "Stock Min."
        UltraGridColumn38.Header.VisiblePosition = 19
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.MaskInput = "{double:-9.3:c}"
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance11
        UltraGridColumn39.Header.Caption = "Stock Max."
        UltraGridColumn39.Header.VisiblePosition = 20
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.MaskInput = "{double:-9.3:c}"
        UltraGridColumn40.Header.VisiblePosition = 21
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.Width = 75
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Width = 68
        UltraGridColumn42.Header.VisiblePosition = 22
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Width = 159
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn2.CellAppearance = Appearance12
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance13.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.CellButtonAppearance = Appearance13
        UltraGridColumn2.Header.Caption = "Rect."
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn2.Width = 33
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn2})
        Appearance14.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance14
        SummarySettings1.DisplayFormat = "{0:#,##0.00}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance15
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top
        Appearance16.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance16
        SummarySettings2.DisplayFormat = "{0:#,##0.00}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance17
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.gridInventario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridInventario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridInventario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridInventario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridInventario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridInventario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridInventario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridInventario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridInventario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridInventario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridInventario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridInventario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridInventario.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridInventario.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridInventario.Location = New System.Drawing.Point(0, 0)
        Me.gridInventario.Name = "gridInventario"
        Me.gridInventario.Size = New System.Drawing.Size(587, 183)
        Me.gridInventario.TabIndex = 9
        Me.gridInventario.Text = "Stock de Materiales"
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.GenerarRequerimientoToolStripMenuItem, Me.AnularOAToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(132, 114)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Proveedor"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Proveedor seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Proveedor seleccionado"
        '
        'GenerarRequerimientoToolStripMenuItem
        '
        Me.GenerarRequerimientoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.GenerarRequerimientoToolStripMenuItem.Name = "GenerarRequerimientoToolStripMenuItem"
        Me.GenerarRequerimientoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.GenerarRequerimientoToolStripMenuItem.Text = "Generar RQ"
        '
        'AnularOAToolStripMenuItem
        '
        Me.AnularOAToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.AnularOAToolStripMenuItem.Name = "AnularOAToolStripMenuItem"
        Me.AnularOAToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AnularOAToolStripMenuItem.Text = "Anular OA"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.grReg_Inv)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(587, 183)
        '
        'grReg_Inv
        '
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
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn529.CellAppearance = Appearance18
        UltraGridColumn529.Format = "#,##0.000"
        UltraGridColumn529.Header.VisiblePosition = 5
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn530.CellAppearance = Appearance19
        UltraGridColumn530.Format = "#,##0.000"
        UltraGridColumn530.Header.VisiblePosition = 6
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn531.CellAppearance = Appearance20
        UltraGridColumn531.Format = "#,##0.000"
        UltraGridColumn531.Header.Caption = "Costo Unit."
        UltraGridColumn531.Header.VisiblePosition = 7
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn532.CellAppearance = Appearance21
        UltraGridColumn532.Format = "#,##0.000"
        UltraGridColumn532.Header.Caption = "Costo Total"
        UltraGridColumn532.Header.VisiblePosition = 8
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn533.CellAppearance = Appearance22
        UltraGridColumn533.Format = "#,##0.000"
        UltraGridColumn533.Header.Caption = "Precio Unit."
        UltraGridColumn533.Header.VisiblePosition = 9
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn534.CellAppearance = Appearance23
        UltraGridColumn534.Format = "#,##0.000"
        UltraGridColumn534.Header.Caption = "Precio Total"
        UltraGridColumn534.Header.VisiblePosition = 10
        Appearance24.BackColor = System.Drawing.Color.Khaki
        Appearance24.Image = Global.ISL.Win.My.Resources.Resources.lupa
        UltraGridColumn535.CellAppearance = Appearance24
        UltraGridColumn535.Header.Caption = "N° Orden"
        UltraGridColumn535.Header.VisiblePosition = 13
        UltraGridColumn535.Hidden = True
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
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn540.CellAppearance = Appearance25
        UltraGridColumn540.Header.VisiblePosition = 12
        UltraGridColumn540.Hidden = True
        UltraGridColumn541.Header.Caption = "Tipo Documento"
        UltraGridColumn541.Header.VisiblePosition = 18
        UltraGridColumn541.Hidden = True
        UltraGridColumn542.Header.Caption = "N° Documento"
        UltraGridColumn542.Header.VisiblePosition = 19
        UltraGridColumn542.Hidden = True
        UltraGridColumn542.Width = 113
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn543.CellAppearance = Appearance26
        UltraGridColumn543.Format = ""
        UltraGridColumn543.Header.VisiblePosition = 11
        UltraGridColumn543.Hidden = True
        UltraGridColumn543.MaskInput = "{double:-9.3}"
        UltraGridColumn543.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn543.Width = 81
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn524, UltraGridColumn525, UltraGridColumn526, UltraGridColumn527, UltraGridColumn528, UltraGridColumn529, UltraGridColumn530, UltraGridColumn531, UltraGridColumn532, UltraGridColumn533, UltraGridColumn534, UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn538, UltraGridColumn539, UltraGridColumn540, UltraGridColumn541, UltraGridColumn542, UltraGridColumn543})
        Me.grReg_Inv.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
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
        Me.grReg_Inv.Size = New System.Drawing.Size(587, 183)
        Me.grReg_Inv.TabIndex = 7
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griEquipos)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(570, 409)
        '
        'griEquipos
        '
        Me.griEquipos.DataSource = Me.odEquipos
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 1
        UltraGridColumn72.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 221
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 162
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 9
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 10
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 11
        UltraGridColumn75.Width = 145
        UltraGridColumn76.Header.VisiblePosition = 12
        UltraGridColumn76.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn72, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76})
        UltraGridBand3.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griEquipos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griEquipos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griEquipos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance27.BorderColor = System.Drawing.Color.Silver
        Me.griEquipos.DisplayLayout.Override.CellAppearance = Appearance27
        Me.griEquipos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griEquipos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griEquipos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griEquipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Me.griEquipos.DisplayLayout.Override.RowAppearance = Appearance28
        Me.griEquipos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griEquipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griEquipos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEquipos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEquipos.Location = New System.Drawing.Point(0, 0)
        Me.griEquipos.Name = "griEquipos"
        Me.griEquipos.Size = New System.Drawing.Size(570, 409)
        Me.griEquipos.TabIndex = 4
        '
        'odEquipos
        '
        Me.odEquipos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griArea)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(570, 409)
        '
        'griArea
        '
        Me.griArea.DataSource = Me.odArea
        UltraGridColumn77.Header.Caption = "Select"
        UltraGridColumn77.Header.VisiblePosition = 0
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.Width = 39
        UltraGridColumn78.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn78.Header.VisiblePosition = 1
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn79.Header.VisiblePosition = 2
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.Width = 66
        UltraGridColumn80.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Width = 361
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn81.Header.VisiblePosition = 4
        UltraGridColumn81.Width = 128
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        UltraGridBand4.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griArea.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griArea.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griArea.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.griArea.DisplayLayout.Override.CellAppearance = Appearance29
        Me.griArea.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griArea.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griArea.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griArea.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance30.BorderColor = System.Drawing.Color.Silver
        Me.griArea.DisplayLayout.Override.RowAppearance = Appearance30
        Me.griArea.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griArea.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griArea.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griArea.Location = New System.Drawing.Point(0, 0)
        Me.griArea.Name = "griArea"
        Me.griArea.Size = New System.Drawing.Size(570, 409)
        Me.griArea.TabIndex = 2
        '
        'odArea
        '
        UltraDataColumn14.DataType = GetType(Boolean)
        UltraDataColumn19.DataType = GetType(Boolean)
        Me.odArea.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21})
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griTrabajadores)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(570, 409)
        '
        'griTrabajadores
        '
        Me.griTrabajadores.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griTrabajadores.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BorderColor = System.Drawing.Color.Silver
        Me.griTrabajadores.DisplayLayout.Override.CellAppearance = Appearance31
        Me.griTrabajadores.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTrabajadores.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTrabajadores.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTrabajadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Me.griTrabajadores.DisplayLayout.Override.RowAppearance = Appearance32
        Me.griTrabajadores.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTrabajadores.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTrabajadores.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTrabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTrabajadores.Location = New System.Drawing.Point(0, 0)
        Me.griTrabajadores.Name = "griTrabajadores"
        Me.griTrabajadores.Size = New System.Drawing.Size(570, 409)
        Me.griTrabajadores.TabIndex = 3
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.grid_Materiales)
        Me.UltraTabPageControl8.Controls.Add(Me.Agrupacion8)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(570, 409)
        '
        'grid_Materiales
        '
        Me.grid_Materiales.DataSource = Me.odMaterial
        Appearance33.BackColor = System.Drawing.SystemColors.Window
        Appearance33.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_Materiales.DisplayLayout.Appearance = Appearance33
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance34.TextHAlignAsString = "Center"
        UltraGridColumn22.Header.Appearance = Appearance34
        UltraGridColumn22.Header.Caption = "Select"
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn22.Width = 43
        Appearance35.TextHAlignAsString = "Center"
        UltraGridColumn23.Header.Appearance = Appearance35
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        Appearance36.TextHAlignAsString = "Center"
        UltraGridColumn24.Header.Appearance = Appearance36
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Width = 76
        Appearance37.TextHAlignAsString = "Center"
        UltraGridColumn25.Header.Appearance = Appearance37
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.Width = 282
        Appearance38.TextHAlignAsString = "Center"
        UltraGridColumn26.Header.Appearance = Appearance38
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.Width = 62
        Appearance39.TextHAlignAsString = "Center"
        UltraGridColumn27.Header.Appearance = Appearance39
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Hidden = True
        Appearance40.TextHAlignAsString = "Center"
        UltraGridColumn28.Header.Appearance = Appearance40
        UltraGridColumn28.Header.VisiblePosition = 11
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 155
        Appearance41.TextHAlignAsString = "Center"
        UltraGridColumn29.Header.Appearance = Appearance41
        UltraGridColumn29.Header.VisiblePosition = 10
        UltraGridColumn29.Hidden = True
        Appearance42.TextHAlignAsString = "Center"
        UltraGridColumn82.Header.Appearance = Appearance42
        UltraGridColumn82.Header.VisiblePosition = 12
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.Width = 178
        Appearance43.TextHAlignAsString = "Center"
        UltraGridColumn94.Header.Appearance = Appearance43
        UltraGridColumn94.Header.VisiblePosition = 13
        UltraGridColumn94.Hidden = True
        Appearance44.TextHAlignAsString = "Center"
        UltraGridColumn95.Header.Appearance = Appearance44
        UltraGridColumn95.Header.VisiblePosition = 17
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.Width = 211
        Appearance45.TextHAlignAsString = "Center"
        UltraGridColumn96.Header.Appearance = Appearance45
        UltraGridColumn96.Header.VisiblePosition = 14
        UltraGridColumn96.Hidden = True
        Appearance46.TextHAlignAsString = "Center"
        UltraGridColumn97.Header.Appearance = Appearance46
        UltraGridColumn97.Header.VisiblePosition = 15
        UltraGridColumn97.Hidden = True
        Appearance47.TextHAlignAsString = "Center"
        UltraGridColumn134.Header.Appearance = Appearance47
        UltraGridColumn134.Header.VisiblePosition = 16
        UltraGridColumn134.Hidden = True
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn135.Header.Appearance = Appearance48
        UltraGridColumn135.Header.Caption = "Unidad Medida"
        UltraGridColumn135.Header.VisiblePosition = 18
        UltraGridColumn135.Width = 96
        Appearance49.TextHAlignAsString = "Center"
        UltraGridColumn136.Header.Appearance = Appearance49
        UltraGridColumn136.Header.VisiblePosition = 19
        UltraGridColumn136.Hidden = True
        UltraGridColumn136.Width = 66
        Appearance50.TextHAlignAsString = "Center"
        UltraGridColumn137.Header.Appearance = Appearance50
        UltraGridColumn137.Header.VisiblePosition = 20
        UltraGridColumn137.Hidden = True
        Appearance51.TextHAlignAsString = "Center"
        UltraGridColumn138.Header.Appearance = Appearance51
        UltraGridColumn138.Header.VisiblePosition = 21
        UltraGridColumn138.Hidden = True
        Appearance52.TextHAlignAsString = "Center"
        UltraGridColumn139.Header.Appearance = Appearance52
        UltraGridColumn139.Header.VisiblePosition = 22
        UltraGridColumn139.Hidden = True
        Appearance53.TextHAlignAsString = "Center"
        UltraGridColumn140.Header.Appearance = Appearance53
        UltraGridColumn140.Header.VisiblePosition = 23
        UltraGridColumn140.Hidden = True
        Appearance54.TextHAlignAsString = "Center"
        UltraGridColumn141.Header.Appearance = Appearance54
        UltraGridColumn141.Header.VisiblePosition = 9
        UltraGridColumn141.Hidden = True
        Appearance55.TextHAlignAsString = "Center"
        UltraGridColumn43.Header.Appearance = Appearance55
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.Width = 206
        Appearance56.TextHAlignAsString = "Center"
        UltraGridColumn44.Header.Appearance = Appearance56
        UltraGridColumn44.Header.VisiblePosition = 24
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 25
        UltraGridColumn45.Hidden = True
        Appearance57.TextHAlignAsString = "Center"
        UltraGridColumn46.Header.Appearance = Appearance57
        UltraGridColumn46.Header.Caption = "Costo"
        UltraGridColumn46.Header.VisiblePosition = 26
        UltraGridColumn47.Header.Caption = ":"
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Width = 152
        UltraGridColumn48.Header.VisiblePosition = 27
        UltraGridColumn48.Hidden = True
        Appearance58.TextHAlignAsString = "Center"
        UltraGridColumn49.Header.Appearance = Appearance58
        UltraGridColumn49.Header.VisiblePosition = 6
        UltraGridColumn49.Width = 211
        UltraGridColumn50.Header.VisiblePosition = 28
        UltraGridColumn50.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 29
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 30
        UltraGridColumn93.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn82, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn92, UltraGridColumn93})
        UltraGridBand5.GroupHeadersVisible = False
        Me.grid_Materiales.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grid_Materiales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Materiales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance59.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance59.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_Materiales.DisplayLayout.GroupByBox.Appearance = Appearance59
        Appearance60.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_Materiales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance60
        Me.grid_Materiales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Materiales.DisplayLayout.GroupByBox.Hidden = True
        Appearance61.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance61.BackColor2 = System.Drawing.SystemColors.Control
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance61.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_Materiales.DisplayLayout.GroupByBox.PromptAppearance = Appearance61
        Me.grid_Materiales.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Materiales.DisplayLayout.MaxRowScrollRegions = 1
        Appearance62.BackColor = System.Drawing.SystemColors.Window
        Appearance62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grid_Materiales.DisplayLayout.Override.ActiveCellAppearance = Appearance62
        Appearance63.BackColor = System.Drawing.SystemColors.Highlight
        Appearance63.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grid_Materiales.DisplayLayout.Override.ActiveRowAppearance = Appearance63
        Me.grid_Materiales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_Materiales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance64.BackColor = System.Drawing.SystemColors.Window
        Me.grid_Materiales.DisplayLayout.Override.CardAreaAppearance = Appearance64
        Appearance65.BorderColor = System.Drawing.Color.Silver
        Appearance65.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid_Materiales.DisplayLayout.Override.CellAppearance = Appearance65
        Me.grid_Materiales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_Materiales.DisplayLayout.Override.CellPadding = 0
        Appearance66.BackColor = System.Drawing.SystemColors.Control
        Appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance66.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance66.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_Materiales.DisplayLayout.Override.GroupByRowAppearance = Appearance66
        Appearance67.TextHAlignAsString = "Left"
        Me.grid_Materiales.DisplayLayout.Override.HeaderAppearance = Appearance67
        Me.grid_Materiales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance68.BackColor = System.Drawing.SystemColors.Window
        Appearance68.BorderColor = System.Drawing.Color.Silver
        Me.grid_Materiales.DisplayLayout.Override.RowAppearance = Appearance68
        Me.grid_Materiales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Materiales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Materiales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance69.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid_Materiales.DisplayLayout.Override.TemplateAddRowAppearance = Appearance69
        Me.grid_Materiales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Materiales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Materiales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Materiales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Materiales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Materiales.Location = New System.Drawing.Point(0, 56)
        Me.grid_Materiales.Name = "grid_Materiales"
        Me.grid_Materiales.Size = New System.Drawing.Size(570, 353)
        Me.grid_Materiales.TabIndex = 10
        Me.grid_Materiales.Text = "Grilla2"
        '
        'odMaterial
        '
        UltraDataColumn22.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Decimal)
        UltraDataColumn40.DataType = GetType(Boolean)
        UltraDataColumn40.DefaultValue = False
        UltraDataColumn42.DataType = GetType(Boolean)
        UltraDataColumn45.DataType = GetType(Decimal)
        UltraDataColumn45.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn46.DataType = GetType(Decimal)
        UltraDataColumn46.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52})
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.optBusqueda)
        Me.Agrupacion8.Controls.Add(Me.btnListarMateriales)
        Me.Agrupacion8.Controls.Add(Me.txtBuscarMateriales)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(570, 56)
        Me.Agrupacion8.TabIndex = 9
        Me.Agrupacion8.Text = "Agregar Materiales:"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'optBusqueda
        '
        Me.optBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.optBusqueda.BackColorInternal = System.Drawing.Color.Transparent
        Me.optBusqueda.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optBusqueda.CheckedIndex = 0
        ValueListItem1.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Codigo"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Nombre"
        Me.optBusqueda.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optBusqueda.ItemSpacingHorizontal = 10
        Me.optBusqueda.ItemSpacingVertical = 5
        Me.optBusqueda.Location = New System.Drawing.Point(16, 24)
        Me.optBusqueda.Name = "optBusqueda"
        Me.optBusqueda.Size = New System.Drawing.Size(132, 21)
        Me.optBusqueda.TabIndex = 235
        Me.optBusqueda.Text = "Codigo"
        '
        'btnListarMateriales
        '
        Appearance70.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMateriales.Appearance = Appearance70
        Me.btnListarMateriales.AutoSize = True
        Me.btnListarMateriales.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMateriales.Location = New System.Drawing.Point(535, 21)
        Me.btnListarMateriales.Name = "btnListarMateriales"
        Me.btnListarMateriales.Size = New System.Drawing.Size(26, 26)
        Me.btnListarMateriales.TabIndex = 234
        '
        'txtBuscarMateriales
        '
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Appearance = Appearance71
        Me.txtBuscarMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBuscarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Location = New System.Drawing.Point(157, 24)
        Me.txtBuscarMateriales.MaxLength = 200
        Me.txtBuscarMateriales.Name = "txtBuscarMateriales"
        Me.txtBuscarMateriales.Size = New System.Drawing.Size(372, 21)
        Me.txtBuscarMateriales.TabIndex = 232
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl3.Controls.Add(Me.gbEAT)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1196, 438)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.grid_UA_Material)
        Me.Agrupacion1.Controls.Add(Me.uebHistorialMaterial)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(601, 438)
        Me.Agrupacion1.TabIndex = 10
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_UA_Material
        '
        Me.grid_UA_Material.DataSource = Me.odEAT
        Appearance72.BackColor = System.Drawing.SystemColors.Window
        Appearance72.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_UA_Material.DisplayLayout.Appearance = Appearance72
        Appearance73.TextHAlignAsString = "Center"
        UltraGridColumn98.Header.Appearance = Appearance73
        UltraGridColumn98.Header.Caption = "Select"
        UltraGridColumn98.Header.VisiblePosition = 0
        UltraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn98.Width = 42
        UltraGridColumn99.Header.VisiblePosition = 1
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 2
        UltraGridColumn100.Hidden = True
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn101.Header.Appearance = Appearance74
        UltraGridColumn101.Header.Caption = "Tipo"
        UltraGridColumn101.Header.VisiblePosition = 4
        UltraGridColumn101.Width = 91
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn102.Header.Appearance = Appearance75
        UltraGridColumn102.Header.Caption = "Asignado a // Material"
        UltraGridColumn102.Header.VisiblePosition = 3
        UltraGridColumn102.Width = 274
        Appearance76.TextHAlignAsString = "Center"
        UltraGridColumn103.Header.Appearance = Appearance76
        UltraGridColumn103.Header.Caption = "Unid. Med."
        UltraGridColumn103.Header.VisiblePosition = 5
        UltraGridColumn103.Width = 101
        Appearance77.TextHAlignAsString = "Center"
        UltraGridColumn104.Header.Appearance = Appearance77
        UltraGridColumn104.Header.Caption = "Cant."
        UltraGridColumn104.Header.VisiblePosition = 6
        UltraGridColumn104.Width = 74
        Appearance78.TextHAlignAsString = "Center"
        UltraGridColumn105.Header.Appearance = Appearance78
        UltraGridColumn105.Header.Caption = "Cant. Entr."
        UltraGridColumn105.Header.VisiblePosition = 7
        UltraGridColumn105.Width = 75
        Appearance79.TextHAlignAsString = "Center"
        UltraGridColumn106.Header.Appearance = Appearance79
        UltraGridColumn106.Header.Caption = "Cant. Dev."
        UltraGridColumn106.Header.VisiblePosition = 8
        UltraGridColumn106.Width = 64
        UltraGridColumn107.Header.Caption = "SubAlmacen"
        UltraGridColumn107.Header.VisiblePosition = 12
        Appearance80.TextHAlignAsString = "Center"
        UltraGridColumn108.Header.Appearance = Appearance80
        UltraGridColumn108.Header.VisiblePosition = 9
        UltraGridColumn108.Hidden = True
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn109.Header.Appearance = Appearance81
        UltraGridColumn109.Header.VisiblePosition = 11
        UltraGridColumn110.Header.VisiblePosition = 13
        UltraGridColumn110.Hidden = True
        Appearance82.TextHAlignAsString = "Center"
        UltraGridColumn111.Header.Appearance = Appearance82
        UltraGridColumn111.Header.VisiblePosition = 10
        UltraGridColumn111.Width = 60
        UltraGridColumn112.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn112.Header.Caption = "Desc."
        UltraGridColumn112.Header.VisiblePosition = 14
        UltraGridColumn112.Width = 43
        Appearance83.TextHAlignAsString = "Right"
        UltraGridColumn113.CellAppearance = Appearance83
        UltraGridColumn113.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn113.Header.Caption = "MontoDesc."
        UltraGridColumn113.Header.VisiblePosition = 15
        UltraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn114.Header.VisiblePosition = 16
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114})
        UltraGridColumn115.Header.Caption = "Select"
        UltraGridColumn115.Header.VisiblePosition = 0
        UltraGridColumn115.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn115.Width = 23
        UltraGridColumn116.Header.VisiblePosition = 1
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 2
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 4
        UltraGridColumn118.Width = 91
        UltraGridColumn119.Header.VisiblePosition = 3
        UltraGridColumn119.Width = 274
        UltraGridColumn120.Header.VisiblePosition = 5
        UltraGridColumn120.Width = 101
        UltraGridColumn121.Header.Caption = "Cant."
        UltraGridColumn121.Header.VisiblePosition = 6
        UltraGridColumn121.Width = 74
        UltraGridColumn122.Header.Caption = "Cant. Ent."
        UltraGridColumn122.Header.VisiblePosition = 7
        UltraGridColumn122.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn122.Width = 75
        UltraGridColumn123.Header.Caption = "Cant. Dev."
        UltraGridColumn123.Header.VisiblePosition = 8
        UltraGridColumn123.Width = 64
        UltraGridColumn124.Header.VisiblePosition = 9
        UltraGridColumn124.Width = 60
        UltraGridColumn125.Header.VisiblePosition = 10
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 11
        UltraGridColumn127.Header.VisiblePosition = 12
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 13
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 14
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 15
        UltraGridColumn130.Width = 159
        UltraGridColumn131.Header.VisiblePosition = 16
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 17
        UltraGridColumn132.Width = 43
        UltraGridColumn133.Header.VisiblePosition = 18
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133})
        Me.grid_UA_Material.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grid_UA_Material.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.grid_UA_Material.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_UA_Material.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance84.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance84.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_UA_Material.DisplayLayout.GroupByBox.Appearance = Appearance84
        Appearance85.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_UA_Material.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance85
        Me.grid_UA_Material.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_UA_Material.DisplayLayout.GroupByBox.Hidden = True
        Appearance86.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance86.BackColor2 = System.Drawing.SystemColors.Control
        Appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance86.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_UA_Material.DisplayLayout.GroupByBox.PromptAppearance = Appearance86
        Me.grid_UA_Material.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_UA_Material.DisplayLayout.MaxRowScrollRegions = 1
        Appearance87.BackColor = System.Drawing.SystemColors.Window
        Appearance87.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grid_UA_Material.DisplayLayout.Override.ActiveCellAppearance = Appearance87
        Appearance88.BackColor = System.Drawing.SystemColors.Highlight
        Appearance88.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grid_UA_Material.DisplayLayout.Override.ActiveRowAppearance = Appearance88
        Me.grid_UA_Material.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_UA_Material.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_UA_Material.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance89.BackColor = System.Drawing.SystemColors.Window
        Me.grid_UA_Material.DisplayLayout.Override.CardAreaAppearance = Appearance89
        Appearance90.BorderColor = System.Drawing.Color.Silver
        Appearance90.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid_UA_Material.DisplayLayout.Override.CellAppearance = Appearance90
        Me.grid_UA_Material.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_UA_Material.DisplayLayout.Override.CellPadding = 0
        Appearance91.BackColor = System.Drawing.SystemColors.Control
        Appearance91.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance91.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance91.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_UA_Material.DisplayLayout.Override.GroupByRowAppearance = Appearance91
        Appearance92.TextHAlignAsString = "Left"
        Me.grid_UA_Material.DisplayLayout.Override.HeaderAppearance = Appearance92
        Me.grid_UA_Material.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance93.BackColor = System.Drawing.SystemColors.Window
        Appearance93.BorderColor = System.Drawing.Color.Silver
        Me.grid_UA_Material.DisplayLayout.Override.RowAppearance = Appearance93
        Me.grid_UA_Material.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid_UA_Material.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance94.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid_UA_Material.DisplayLayout.Override.TemplateAddRowAppearance = Appearance94
        Me.grid_UA_Material.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_UA_Material.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_UA_Material.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_UA_Material.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_UA_Material.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_UA_Material.Location = New System.Drawing.Point(3, 3)
        Me.grid_UA_Material.Name = "grid_UA_Material"
        Me.grid_UA_Material.Size = New System.Drawing.Size(595, 203)
        Me.grid_UA_Material.TabIndex = 9
        Me.grid_UA_Material.Text = "Grilla1"
        '
        'odEAT
        '
        UltraDataColumn53.DataType = GetType(Boolean)
        UltraDataColumn59.DataType = GetType(Decimal)
        UltraDataColumn60.DataType = GetType(Decimal)
        UltraDataColumn61.DataType = GetType(Decimal)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71})
        Me.odEAT.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn72.DataType = GetType(Boolean)
        Me.odEAT.Band.Columns.AddRange(New Object() {UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87})
        '
        'uebHistorialMaterial
        '
        Me.uebHistorialMaterial.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.uebHistorialMaterial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uebHistorialMaterial.ExpandedSize = New System.Drawing.Size(595, 229)
        Me.uebHistorialMaterial.Location = New System.Drawing.Point(3, 206)
        Me.uebHistorialMaterial.Name = "uebHistorialMaterial"
        Me.uebHistorialMaterial.Size = New System.Drawing.Size(595, 229)
        Me.uebHistorialMaterial.TabIndex = 1
        Me.uebHistorialMaterial.TabStop = False
        Me.uebHistorialMaterial.Text = "Historial Material Trabajador"
        Me.uebHistorialMaterial.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ficHistorialMaterial)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(589, 206)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'ficHistorialMaterial
        '
        Me.ficHistorialMaterial.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.ficHistorialMaterial.Controls.Add(Me.UltraTabPageControl4)
        Me.ficHistorialMaterial.Controls.Add(Me.UltraTabPageControl9)
        Me.ficHistorialMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficHistorialMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficHistorialMaterial.Location = New System.Drawing.Point(0, 0)
        Me.ficHistorialMaterial.Name = "ficHistorialMaterial"
        Me.ficHistorialMaterial.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.ficHistorialMaterial.Size = New System.Drawing.Size(589, 206)
        Me.ficHistorialMaterial.TabIndex = 0
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "UnidadAsignacion"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Material"
        Me.ficHistorialMaterial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab9})
        Me.ficHistorialMaterial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(587, 183)
        '
        'gbEAT
        '
        Me.gbEAT.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbEAT.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbEAT.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbEAT.ExpandedSize = New System.Drawing.Size(595, 438)
        Me.gbEAT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEAT.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbEAT.Location = New System.Drawing.Point(601, 0)
        Me.gbEAT.Name = "gbEAT"
        Me.gbEAT.Size = New System.Drawing.Size(595, 438)
        Me.gbEAT.TabIndex = 9
        Me.gbEAT.Text = "Asignar Unidad // Material"
        Me.gbEAT.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fcEAT)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(572, 432)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'fcEAT
        '
        Me.fcEAT.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.fcEAT.Controls.Add(Me.UltraTabPageControl5)
        Me.fcEAT.Controls.Add(Me.UltraTabPageControl6)
        Me.fcEAT.Controls.Add(Me.UltraTabPageControl7)
        Me.fcEAT.Controls.Add(Me.UltraTabPageControl8)
        Me.fcEAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fcEAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fcEAT.Location = New System.Drawing.Point(0, 0)
        Me.fcEAT.Name = "fcEAT"
        Me.fcEAT.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.fcEAT.Size = New System.Drawing.Size(572, 432)
        Me.fcEAT.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Equipos"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Areas"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Trabajadores"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Materiales"
        Me.fcEAT.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab7, UltraTab8})
        Me.fcEAT.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(570, 409)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1204, 579)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.grid_OA)
        Me.Agrupacion4.Controls.Add(Me.agrMenuLista)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 129)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1204, 450)
        Me.Agrupacion4.TabIndex = 3
        Me.Agrupacion4.Text = "Ordenes de Asignación"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_OA
        '
        Me.grid_OA.ContextMenuStrip = Me.mcDetalle
        Me.grid_OA.DataSource = Me.odOrdenAsociacion
        Appearance95.BackColor = System.Drawing.SystemColors.Window
        Appearance95.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_OA.DisplayLayout.Appearance = Appearance95
        Appearance96.TextHAlignAsString = "Center"
        UltraGridColumn83.Header.Appearance = Appearance96
        UltraGridColumn83.Header.VisiblePosition = 0
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance97.TextHAlignAsString = "Center"
        UltraGridColumn84.Header.Appearance = Appearance97
        UltraGridColumn84.Header.VisiblePosition = 1
        UltraGridColumn84.MaskInput = "{LOC}dd/mm/yyyy "
        UltraGridColumn84.Width = 94
        Appearance98.TextHAlignAsString = "Center"
        UltraGridColumn85.Header.Appearance = Appearance98
        UltraGridColumn85.Header.Caption = "N° O. Asignacion"
        UltraGridColumn85.Header.VisiblePosition = 2
        UltraGridColumn85.Width = 122
        Appearance99.TextHAlignAsString = "Center"
        UltraGridColumn86.Header.Appearance = Appearance99
        UltraGridColumn86.Header.Caption = "Asignado a"
        UltraGridColumn86.Header.VisiblePosition = 4
        UltraGridColumn86.Width = 287
        Appearance100.TextHAlignAsString = "Center"
        UltraGridColumn87.Header.Appearance = Appearance100
        UltraGridColumn87.Header.VisiblePosition = 5
        UltraGridColumn87.Hidden = True
        Appearance101.TextHAlignAsString = "Center"
        UltraGridColumn88.Header.Appearance = Appearance101
        UltraGridColumn88.Header.Caption = "Estado"
        UltraGridColumn88.Header.VisiblePosition = 6
        UltraGridColumn88.Width = 105
        Appearance102.TextHAlignAsString = "Center"
        UltraGridColumn89.Header.Appearance = Appearance102
        UltraGridColumn89.Header.VisiblePosition = 7
        UltraGridColumn89.Width = 229
        UltraGridColumn90.Header.VisiblePosition = 8
        UltraGridColumn91.Header.VisiblePosition = 9
        UltraGridColumn91.Hidden = True
        Appearance103.TextHAlignAsString = "Center"
        UltraGridColumn51.CellAppearance = Appearance103
        UltraGridColumn51.Header.Caption = "Unidad"
        UltraGridColumn51.Header.VisiblePosition = 3
        UltraGridColumn51.Width = 47
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn51})
        Me.grid_OA.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.grid_OA.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_OA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance104.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance104.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance104.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_OA.DisplayLayout.GroupByBox.Appearance = Appearance104
        Appearance105.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_OA.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance105
        Me.grid_OA.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_OA.DisplayLayout.GroupByBox.Hidden = True
        Appearance106.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance106.BackColor2 = System.Drawing.SystemColors.Control
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance106.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_OA.DisplayLayout.GroupByBox.PromptAppearance = Appearance106
        Me.grid_OA.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_OA.DisplayLayout.MaxRowScrollRegions = 1
        Appearance107.BackColor = System.Drawing.SystemColors.Window
        Appearance107.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grid_OA.DisplayLayout.Override.ActiveCellAppearance = Appearance107
        Appearance108.BackColor = System.Drawing.SystemColors.Highlight
        Appearance108.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grid_OA.DisplayLayout.Override.ActiveRowAppearance = Appearance108
        Me.grid_OA.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_OA.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance109.BackColor = System.Drawing.SystemColors.Window
        Me.grid_OA.DisplayLayout.Override.CardAreaAppearance = Appearance109
        Appearance110.BorderColor = System.Drawing.Color.Silver
        Appearance110.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid_OA.DisplayLayout.Override.CellAppearance = Appearance110
        Me.grid_OA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_OA.DisplayLayout.Override.CellPadding = 0
        Me.grid_OA.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_OA.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_OA.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance111.BackColor = System.Drawing.SystemColors.Control
        Appearance111.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance111.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance111.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_OA.DisplayLayout.Override.GroupByRowAppearance = Appearance111
        Appearance112.TextHAlignAsString = "Left"
        Me.grid_OA.DisplayLayout.Override.HeaderAppearance = Appearance112
        Me.grid_OA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance113.BackColor = System.Drawing.SystemColors.Window
        Appearance113.BorderColor = System.Drawing.Color.Silver
        Me.grid_OA.DisplayLayout.Override.RowAppearance = Appearance113
        Me.grid_OA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_OA.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_OA.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance114.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid_OA.DisplayLayout.Override.TemplateAddRowAppearance = Appearance114
        Me.grid_OA.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_OA.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_OA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_OA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_OA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_OA.Location = New System.Drawing.Point(3, 47)
        Me.grid_OA.Name = "grid_OA"
        Me.grid_OA.Size = New System.Drawing.Size(1198, 400)
        Me.grid_OA.TabIndex = 3
        '
        'odOrdenAsociacion
        '
        Me.odOrdenAsociacion.Band.Columns.AddRange(New Object() {UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnAnular)
        Me.agrMenuLista.Controls.Add(Me.btnCerrar)
        Me.agrMenuLista.Controls.Add(Me.btnEjecutar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1198, 30)
        Me.agrMenuLista.TabIndex = 10
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAnular
        '
        Appearance115.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance115.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnAnular.Appearance = Appearance115
        Me.btnAnular.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Enabled = False
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Location = New System.Drawing.Point(193, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(95, 24)
        Me.btnAnular.TabIndex = 8
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCerrar
        '
        Appearance116.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance116.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnCerrar.Appearance = Appearance116
        Me.btnCerrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCerrar.Enabled = False
        Me.btnCerrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(98, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(95, 24)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Terminar "
        Me.btnCerrar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEjecutar
        '
        Appearance117.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance117.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnEjecutar.Appearance = Appearance117
        Me.btnEjecutar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEjecutar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEjecutar.Enabled = False
        Me.btnEjecutar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.ForeColor = System.Drawing.Color.Black
        Me.btnEjecutar.Location = New System.Drawing.Point(3, 3)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(95, 24)
        Me.btnEjecutar.TabIndex = 6
        Me.btnEjecutar.Text = "Generar RQ"
        Me.btnEjecutar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.gbDatosAdicionales)
        Me.Agrupacion3.Controls.Add(Me.rbDatosAdicionales)
        Me.Agrupacion3.Controls.Add(Me.gbNroOA)
        Me.Agrupacion3.Controls.Add(Me.rbNroOA)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1204, 129)
        Me.Agrupacion3.TabIndex = 2
        Me.Agrupacion3.Text = "Filtros:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.rfFechaDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.gbDatosAdicionales.Controls.Add(Me.rfFechaHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.cmdTipoUnidadAsignada)
        Me.gbDatosAdicionales.Controls.Add(Me.etiEPA)
        Me.gbDatosAdicionales.Controls.Add(Me.cmEstadoOA)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta13)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta21)
        Me.gbDatosAdicionales.Controls.Add(Me.cmEAT)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta8)
        Me.gbDatosAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosAdicionales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(12, 46)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(485, 77)
        Me.gbDatosAdicionales.TabIndex = 340
        Me.gbDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rfFechaDesde
        '
        Me.rfFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaDesde.Location = New System.Drawing.Point(55, 8)
        Me.rfFechaDesde.Name = "rfFechaDesde"
        Me.rfFechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaDesde.TabIndex = 337
        '
        'Etiqueta5
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance118
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(13, 33)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta5.TabIndex = 9
        Me.Etiqueta5.Text = "Asinado a:"
        '
        'rfFechaHasta
        '
        Me.rfFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaHasta.Location = New System.Drawing.Point(198, 8)
        Me.rfFechaHasta.Name = "rfFechaHasta"
        Me.rfFechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaHasta.TabIndex = 338
        '
        'cmdTipoUnidadAsignada
        '
        Appearance119.ForeColor = System.Drawing.Color.Black
        Me.cmdTipoUnidadAsignada.Appearance = Appearance119
        Me.cmdTipoUnidadAsignada.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmdTipoUnidadAsignada.DisplayMember = "Nombre"
        Me.cmdTipoUnidadAsignada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmdTipoUnidadAsignada.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmdTipoUnidadAsignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTipoUnidadAsignada.ForeColor = System.Drawing.Color.Black
        Me.cmdTipoUnidadAsignada.Location = New System.Drawing.Point(13, 49)
        Me.cmdTipoUnidadAsignada.Name = "cmdTipoUnidadAsignada"
        Me.cmdTipoUnidadAsignada.Size = New System.Drawing.Size(163, 21)
        Me.cmdTipoUnidadAsignada.TabIndex = 3
        Me.cmdTipoUnidadAsignada.ValueMember = "Id"
        '
        'etiEPA
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Me.etiEPA.Appearance = Appearance120
        Me.etiEPA.AutoSize = True
        Me.etiEPA.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEPA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEPA.Location = New System.Drawing.Point(198, 34)
        Me.etiEPA.Name = "etiEPA"
        Me.etiEPA.Size = New System.Drawing.Size(138, 15)
        Me.etiEPA.TabIndex = 11
        Me.etiEPA.Text = "Equipo / Area / Trabajador:"
        '
        'cmEstadoOA
        '
        Appearance121.ForeColor = System.Drawing.Color.Black
        Me.cmEstadoOA.Appearance = Appearance121
        Me.cmEstadoOA.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmEstadoOA.DisplayMember = "Nombre"
        Me.cmEstadoOA.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmEstadoOA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmEstadoOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmEstadoOA.ForeColor = System.Drawing.Color.Black
        Me.cmEstadoOA.Location = New System.Drawing.Point(345, 7)
        Me.cmEstadoOA.Name = "cmEstadoOA"
        Me.cmEstadoOA.Size = New System.Drawing.Size(124, 21)
        Me.cmEstadoOA.TabIndex = 5
        Me.cmEstadoOA.ValueMember = "Id"
        '
        'Etiqueta13
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance122
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(302, 10)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta13.TabIndex = 12
        Me.Etiqueta13.Text = "Estado:"
        '
        'Etiqueta21
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance123
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(161, 10)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 336
        Me.Etiqueta21.Text = "Hasta:"
        '
        'cmEAT
        '
        Appearance124.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmEAT.Appearance = Appearance124
        Me.cmEAT.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmEAT.DisplayMember = "Nombre"
        Me.cmEAT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmEAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmEAT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmEAT.Location = New System.Drawing.Point(198, 49)
        Me.cmEAT.Name = "cmEAT"
        Me.cmEAT.Size = New System.Drawing.Size(271, 21)
        Me.cmEAT.TabIndex = 252
        Me.cmEAT.ValueMember = "Id"
        '
        'Etiqueta8
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance125
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(13, 10)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta8.TabIndex = 335
        Me.Etiqueta8.Text = "Desde:"
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(12, 26)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(109, 17)
        Me.rbDatosAdicionales.TabIndex = 339
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'gbNroOA
        '
        Me.gbNroOA.Controls.Add(Me.txtOA)
        Me.gbNroOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNroOA.ForeColor = System.Drawing.Color.Black
        Me.gbNroOA.Location = New System.Drawing.Point(509, 47)
        Me.gbNroOA.Name = "gbNroOA"
        Me.gbNroOA.Size = New System.Drawing.Size(148, 34)
        Me.gbNroOA.TabIndex = 332
        Me.gbNroOA.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtOA
        '
        Appearance126.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOA.Appearance = Appearance126
        Me.txtOA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOA.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOA.Location = New System.Drawing.Point(6, 7)
        Me.txtOA.MaxLength = 13
        Me.txtOA.Name = "txtOA"
        Me.txtOA.Size = New System.Drawing.Size(132, 21)
        Me.txtOA.TabIndex = 3
        '
        'rbNroOA
        '
        Me.rbNroOA.AutoSize = True
        Me.rbNroOA.BackColor = System.Drawing.Color.Transparent
        Me.rbNroOA.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroOA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbNroOA.Location = New System.Drawing.Point(509, 26)
        Me.rbNroOA.Name = "rbNroOA"
        Me.rbNroOA.Size = New System.Drawing.Size(139, 17)
        Me.rbNroOA.TabIndex = 331
        Me.rbNroOA.Text = "N° Orden de Asignacion"
        Me.rbNroOA.UseVisualStyleBackColor = False
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.ColoresAnulado)
        Me.Agrupacion5.Controls.Add(Me.etiGenerada)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion5.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion5.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion5.Controls.Add(Me.ColoresTerminada)
        Me.Agrupacion5.Controls.Add(Me.ColoresEnProceso)
        Me.Agrupacion5.Controls.Add(Me.etiTerminada)
        Me.Agrupacion5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(679, 28)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(266, 67)
        Me.Agrupacion5.TabIndex = 330
        Me.Agrupacion5.Text = "Estados"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresAnulado
        '
        Me.ColoresAnulado.Location = New System.Drawing.Point(207, 33)
        Me.ColoresAnulado.Name = "ColoresAnulado"
        Me.ColoresAnulado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresAnulado.TabIndex = 14
        Me.ColoresAnulado.Text = "Control"
        '
        'etiGenerada
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance127
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(8, 18)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 9
        Me.etiGenerada.Text = "Generada"
        '
        'Etiqueta7
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Appearance = Appearance128
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(209, 17)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta7.TabIndex = 13
        Me.Etiqueta7.Text = "Anulado"
        '
        'etiEnProceso
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance129
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(69, 17)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(57, 15)
        Me.etiEnProceso.TabIndex = 10
        Me.etiEnProceso.Text = "En proceso"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(12, 34)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 7
        Me.ColoresGenerado.Text = "Control"
        '
        'ColoresTerminada
        '
        Me.ColoresTerminada.Location = New System.Drawing.Point(145, 33)
        Me.ColoresTerminada.Name = "ColoresTerminada"
        Me.ColoresTerminada.Size = New System.Drawing.Size(46, 22)
        Me.ColoresTerminada.TabIndex = 12
        Me.ColoresTerminada.Text = "Control"
        '
        'ColoresEnProceso
        '
        Me.ColoresEnProceso.Location = New System.Drawing.Point(75, 33)
        Me.ColoresEnProceso.Name = "ColoresEnProceso"
        Me.ColoresEnProceso.Size = New System.Drawing.Size(43, 22)
        Me.ColoresEnProceso.TabIndex = 8
        Me.ColoresEnProceso.Text = "Control"
        '
        'etiTerminada
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance130
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(139, 17)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(56, 15)
        Me.etiTerminada.TabIndex = 11
        Me.etiTerminada.Text = "Terminada"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1204, 579)
        '
        'agrDetalle
        '
        Me.agrDetalle.Controls.Add(Me.fcMaterial)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.agrDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalle.ForeColor = System.Drawing.Color.Black
        Me.agrDetalle.Location = New System.Drawing.Point(0, 73)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(1204, 506)
        Me.agrDetalle.TabIndex = 204
        Me.agrDetalle.Text = "Detalle"
        Me.agrDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fcMaterial
        '
        Me.fcMaterial.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.fcMaterial.Controls.Add(Me.UltraTabPageControl3)
        Me.fcMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fcMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fcMaterial.Location = New System.Drawing.Point(3, 42)
        Me.fcMaterial.Name = "fcMaterial"
        Me.fcMaterial.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.fcMaterial.Size = New System.Drawing.Size(1198, 461)
        Me.fcMaterial.TabIndex = 8
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Unidad Asignada - Material"
        Me.fcMaterial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        Me.fcMaterial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1196, 438)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(3, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1198, 26)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnDetalle
        '
        'mnDetalle
        '
        Appearance131.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnDetalle.Appearance = Appearance131
        Me.mnDetalle.DesignerFlags = 1
        Me.mnDetalle.DockWithinContainer = Me
        Me.mnDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.mnDetalle.MdiMergeable = False
        Me.mnDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2, ButtonTool5, ButtonTool3, ButtonTool1})
        UltraToolbar1.Text = "utDetalle"
        Me.mnDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance132.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance132
        ButtonTool6.SharedPropsInternal.Caption = "Consultar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance133.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance133
        ButtonTool7.SharedPropsInternal.Caption = "Agregar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance134.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool8.SharedPropsInternal.AppearancesSmall.Appearance = Appearance134
        ButtonTool8.SharedPropsInternal.Caption = "Guardar"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance135.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool14.SharedPropsInternal.AppearancesSmall.Appearance = Appearance135
        ButtonTool14.SharedPropsInternal.Caption = "Quitar"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance136.Image = CType(resources.GetObject("Appearance136.Image"), Object)
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance136
        ButtonTool9.SharedPropsInternal.Caption = "Devolución"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance137.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance137
        ButtonTool4.SharedPropsInternal.Caption = "Actualizar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool14, ButtonTool9, ButtonTool4})
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(3, 503)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1198, 0)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(3, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 487)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1201, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 487)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnDetalle
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.dtpFecha)
        Me.agrDatoGeneral.Controls.Add(Me.etiGenerando)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta3)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta6)
        Me.agrDatoGeneral.Controls.Add(Me.txtEstado)
        Me.agrDatoGeneral.Controls.Add(Me.txtGlosa)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta2)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta4)
        Me.agrDatoGeneral.Controls.Add(Me.txtNroOA)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.ForeColor = System.Drawing.Color.Transparent
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1204, 73)
        Me.agrDatoGeneral.TabIndex = 202
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(259, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecha.TabIndex = 323
        '
        'etiGenerando
        '
        Me.etiGenerando.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Appearance138.ForeColor = System.Drawing.Color.Red
        Me.etiGenerando.Appearance = Appearance138
        Me.etiGenerando.AutoSize = True
        Me.etiGenerando.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerando.ForeColor = System.Drawing.Color.Black
        Me.etiGenerando.Location = New System.Drawing.Point(849, 20)
        Me.etiGenerando.Name = "etiGenerando"
        Me.etiGenerando.Size = New System.Drawing.Size(182, 18)
        Me.etiGenerando.TabIndex = 232
        Me.etiGenerando.Text = "Generando Requerimiento"
        Me.etiGenerando.Visible = False
        '
        'Etiqueta3
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance139
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(217, 22)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta3.TabIndex = 231
        Me.Etiqueta3.Text = "Fecha:"
        '
        'Etiqueta6
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance140
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(370, 22)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta6.TabIndex = 229
        Me.Etiqueta6.Text = "Estado:"
        '
        'txtEstado
        '
        Appearance141.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Appearance = Appearance141
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Location = New System.Drawing.Point(416, 18)
        Me.txtEstado.MaxLength = 200
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(108, 21)
        Me.txtEstado.TabIndex = 228
        '
        'txtGlosa
        '
        Appearance142.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance142
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(106, 43)
        Me.txtGlosa.MaxLength = 200
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(925, 25)
        Me.txtGlosa.TabIndex = 1
        '
        'Etiqueta2
        '
        Appearance143.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance143
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(66, 47)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Etiqueta4
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance144
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(10, 22)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(90, 15)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "N° O. Asignación:"
        '
        'txtNroOA
        '
        Appearance145.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOA.Appearance = Appearance145
        Me.txtNroOA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOA.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOA.Location = New System.Drawing.Point(106, 18)
        Me.txtNroOA.MaxLength = 10
        Me.txtNroOA.Name = "txtNroOA"
        Me.txtNroOA.ReadOnly = True
        Me.txtNroOA.Size = New System.Drawing.Size(105, 21)
        Me.txtNroOA.TabIndex = 0
        '
        'odDetalleAsignacion
        '
        UltraDataColumn98.DataType = GetType(Boolean)
        UltraDataBand3.Columns.AddRange(New Object() {UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105})
        UltraDataBand2.ChildBands.AddRange(New Object() {UltraDataBand3})
        UltraDataColumn106.DataType = GetType(Boolean)
        UltraDataColumn111.DataType = GetType(Decimal)
        UltraDataColumn112.DataType = GetType(Decimal)
        UltraDataColumn113.DataType = GetType(Decimal)
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118})
        Me.odDetalleAsignacion.Band.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataColumn119.DataType = GetType(Boolean)
        Me.odDetalleAsignacion.Band.Columns.AddRange(New Object() {UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129})
        '
        'tcOA
        '
        Me.tcOA.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcOA.Controls.Add(Me.UltraTabPageControl1)
        Me.tcOA.Controls.Add(Me.UltraTabPageControl2)
        Me.tcOA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcOA.Location = New System.Drawing.Point(0, 0)
        Me.tcOA.Name = "tcOA"
        Me.tcOA.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcOA.Size = New System.Drawing.Size(1206, 602)
        Me.tcOA.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcOA.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcOA.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1204, 579)
        '
        'frm_OrdenAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 602)
        Me.Controls.Add(Me.tcOA)
        Me.Name = "frm_OrdenAsignacion"
        Me.Text = "Solicitud de Materiales"
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.grid_Materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.optBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.grid_UA_Material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uebHistorialMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uebHistorialMaterial.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.ficHistorialMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficHistorialMaterial.ResumeLayout(False)
        CType(Me.gbEAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEAT.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.fcEAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fcEAT.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.grid_OA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenAsociacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cmdTipoUnidadAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmEstadoOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmEAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbNroOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNroOA.ResumeLayout(False)
        Me.gbNroOA.PerformLayout()
        CType(Me.txtOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.ColoresAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEnProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalle.ResumeLayout(False)
        CType(Me.fcMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fcMaterial.ResumeLayout(False)
        CType(Me.mnDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcOA.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcOA As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents etiEPA As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cmEstadoOA As ISL.Controles.ComboMaestros
    Friend WithEvents cmdTipoUnidadAsignada As ISL.Controles.ComboMaestros
    Friend WithEvents ColoresTerminada As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEnProceso As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents odOrdenAsociacion As ISL.Controles.OrigenDatos
    Friend WithEvents grid_OA As ISL.Controles.Grilla
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmEAT As ISL.Controles.ComboMaestros
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroOA As ISL.Controles.Texto
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents agrDetalle As ISL.Controles.Agrupacion
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnDetalle As ISL.Controles.Menu
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents fcMaterial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gbEAT As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents fcEAT As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents odEquipos As ISL.Controles.OrigenDatos
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griArea As ISL.Controles.Grilla
    Friend WithEvents odArea As ISL.Controles.OrigenDatos
    Friend WithEvents griTrabajadores As ISL.Controles.Grilla
    Friend WithEvents griEquipos As ISL.Controles.Grilla
    Friend WithEvents odEAT As ISL.Controles.OrigenDatos
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarMateriales As ISL.Controles.Boton
    Friend WithEvents txtBuscarMateriales As ISL.Controles.Texto
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents grid_Materiales As ISL.Controles.Grilla
    Friend WithEvents odDetalleAsignacion As ISL.Controles.OrigenDatos
    Friend WithEvents btnEjecutar As ISL.Controles.Boton
    Friend WithEvents etiGenerando As ISL.Controles.Etiqueta
    Friend WithEvents GenerarRequerimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCerrar As ISL.Controles.Boton
    Friend WithEvents btnAnular As ISL.Controles.Boton
    Friend WithEvents ColoresAnulado As ISL.Controles.Colores
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents rfFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents AnularOAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents gbNroOA As ISL.Controles.Agrupacion
    Friend WithEvents txtOA As ISL.Controles.Texto
    Friend WithEvents rbNroOA As System.Windows.Forms.RadioButton
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents gbDatosAdicionales As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents grid_UA_Material As ISL.Controles.Grilla
    Friend WithEvents uebHistorialMaterial As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ficHistorialMaterial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grReg_Inv As ISL.Controles.Grilla
    Friend WithEvents gridInventario As ISL.Controles.Grilla
    Friend WithEvents optBusqueda As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
