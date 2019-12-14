<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenSalida
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialAAtender")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimientoSer")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajoMaterial")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
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
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
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
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenSalida))
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMaterial")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadReal")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUnidad")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoSubAlmacen")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreAlmacen")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitarioReal")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorTotal")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
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
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMovimiento")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMaterial")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadReal")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUnidad")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoSubAlmacen")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreAlmacen")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorUnitario")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorUnitarioReal")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorTotal")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
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
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridOrdenMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOMat = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaMateriales = New ISL.Controles.Grilla(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListarMateriales = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtBuscarMateriales = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gbDocAsociar = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaDoc = New ISL.Controles.Grilla(Me.components)
        Me.odDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoDoc = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarOrdenes = New ISL.Controles.Boton(Me.components)
        Me.GriAsocDoc = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridOrdenMovimientos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odMov = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenesdeIngreso = New ISL.Controles.Agrupacion(Me.components)
        Me.gridListaOrden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjecutarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odOrden = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnRectificar = New ISL.Controles.Boton(Me.components)
        Me.btnEjecutar = New ISL.Controles.Boton(Me.components)
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.gbOI = New ISL.Controles.Agrupacion(Me.components)
        Me.txtNSalida = New ISL.Controles.Texto(Me.components)
        Me.rbNroOrden = New System.Windows.Forms.RadioButton()
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.gbDatosAdicionales = New ISL.Controles.Agrupacion(Me.components)
        Me.rfOrdenSalidaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.rfOrdenSalidaDesde = New System.Windows.Forms.DateTimePicker()
        Me.cboEstadoOrden = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFiltroMovimiento = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresTerminada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuDet = New ISL.Controles.Menu(Me.components)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea17 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea18 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea19 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea20 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea13 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea14 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea15 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea16 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea5 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea6 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea7 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea8 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecFechaOrden = New System.Windows.Forms.DateTimePicker()
        Me.cboMovimientoInventario = New ISL.Controles.ComboMaestros(Me.components)
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.etiEstado = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtNroOrden = New ISL.Controles.Texto(Me.components)
        Me.etiNroOrden = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tEjecutar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ficOrden = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage1_Fill_Panel = New System.Windows.Forms.Panel()
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.gridOrdenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.gbDocAsociar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDocAsociar.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griListaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GriAsocDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.gridOrdenMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrOrdenesdeIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenesdeIngreso.SuspendLayout()
        CType(Me.gridListaOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        CType(Me.gbOI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOI.SuspendLayout()
        CType(Me.txtNSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFiltroMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalle.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.MenuDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.cboMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.ficOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrden.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.gridOrdenMaterial)
        Me.UltraTabPageControl3.Controls.Add(Me.gbeMateriales)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1169, 223)
        '
        'gridOrdenMaterial
        '
        Me.gridOrdenMaterial.DataSource = Me.odOMat
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridOrdenMaterial.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn1.Header.Appearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 64
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance3
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn3.Header.Appearance = Appearance4
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn4.Header.Appearance = Appearance5
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        Appearance6.TextHAlignAsString = "Left"
        UltraGridColumn5.CellAppearance = Appearance6
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn5.Header.Appearance = Appearance7
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 303
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance8
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn6.Header.Appearance = Appearance9
        UltraGridColumn6.Header.Caption = "Cantidad"
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn6.MaskInput = "{double:9.4}"
        UltraGridColumn6.Width = 91
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance10
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn7.Header.Appearance = Appearance11
        UltraGridColumn7.Header.Caption = "Precio"
        UltraGridColumn7.Header.VisiblePosition = 9
        UltraGridColumn7.MaskInput = "{double:9.4}"
        UltraGridColumn7.Width = 101
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn8.Header.Appearance = Appearance13
        UltraGridColumn8.Header.Caption = "Valor Venta"
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn8.MaskInput = "{double:9.4}"
        UltraGridColumn8.Width = 95
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn9.Header.Appearance = Appearance14
        UltraGridColumn9.Header.Caption = "Almacen"
        UltraGridColumn9.Header.VisiblePosition = 12
        UltraGridColumn9.Width = 295
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn10.Header.Appearance = Appearance15
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 262
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn11.Header.Appearance = Appearance16
        UltraGridColumn11.Header.VisiblePosition = 13
        UltraGridColumn11.Hidden = True
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn12.Header.Appearance = Appearance17
        UltraGridColumn12.Header.VisiblePosition = 14
        UltraGridColumn12.Hidden = True
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn13.Header.Appearance = Appearance18
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        Appearance19.TextHAlignAsString = "Center"
        UltraGridColumn14.Header.Appearance = Appearance19
        UltraGridColumn14.Header.VisiblePosition = 16
        UltraGridColumn14.Hidden = True
        Appearance20.TextHAlignAsString = "Center"
        UltraGridColumn15.Header.Appearance = Appearance20
        UltraGridColumn15.Header.VisiblePosition = 17
        UltraGridColumn15.Hidden = True
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn16.Header.Appearance = Appearance21
        UltraGridColumn16.Header.VisiblePosition = 18
        UltraGridColumn16.Hidden = True
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn17.Header.Appearance = Appearance22
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.Hidden = True
        Appearance23.TextHAlignAsString = "Center"
        UltraGridColumn18.Header.Appearance = Appearance23
        UltraGridColumn18.Header.Caption = "Unid. Med."
        UltraGridColumn18.Header.VisiblePosition = 6
        UltraGridColumn18.Width = 79
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn19.Header.Appearance = Appearance24
        UltraGridColumn19.Header.VisiblePosition = 20
        UltraGridColumn19.Hidden = True
        Appearance25.TextHAlignAsString = "Center"
        UltraGridColumn20.Header.Appearance = Appearance25
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn21.Header.Appearance = Appearance26
        UltraGridColumn21.Header.VisiblePosition = 22
        UltraGridColumn21.Hidden = True
        Appearance27.TextHAlignAsString = "Center"
        UltraGridColumn22.Header.Appearance = Appearance27
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        Appearance28.TextHAlignAsString = "Center"
        UltraGridColumn23.Header.Appearance = Appearance28
        UltraGridColumn23.Header.Caption = "Codigo"
        UltraGridColumn23.Header.VisiblePosition = 4
        Appearance29.TextHAlignAsString = "Center"
        UltraGridColumn24.Header.Appearance = Appearance29
        UltraGridColumn24.Header.VisiblePosition = 24
        UltraGridColumn24.Hidden = True
        Appearance30.TextHAlignAsString = "Center"
        UltraGridColumn25.Header.Appearance = Appearance30
        UltraGridColumn25.Header.VisiblePosition = 25
        UltraGridColumn25.Hidden = True
        Appearance31.TextHAlignAsString = "Center"
        UltraGridColumn26.Header.Appearance = Appearance31
        UltraGridColumn26.Header.VisiblePosition = 26
        UltraGridColumn26.Hidden = True
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn27.Header.Appearance = Appearance32
        UltraGridColumn27.Header.VisiblePosition = 27
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 28
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 29
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 30
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 31
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 7
        UltraGridColumn32.Width = 76
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance33.TextHAlignAsString = "Center"
        UltraGridColumn33.Header.Appearance = Appearance33
        UltraGridColumn33.Header.Caption = "SubAlmacen"
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Width = 248
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn35.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 35
        UltraGridColumn160.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn160})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        Me.gridOrdenMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridOrdenMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridOrdenMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance34.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance34.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance34.BorderColor = System.Drawing.SystemColors.Window
        Me.gridOrdenMaterial.DisplayLayout.GroupByBox.Appearance = Appearance34
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridOrdenMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance35
        Me.gridOrdenMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridOrdenMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance36.BackColor2 = System.Drawing.SystemColors.Control
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridOrdenMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance36
        Me.gridOrdenMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.gridOrdenMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gridOrdenMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance37
        Appearance38.BackColor = System.Drawing.SystemColors.Highlight
        Appearance38.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.gridOrdenMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance38
        Me.gridOrdenMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridOrdenMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridOrdenMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance39.BackColor = System.Drawing.SystemColors.Window
        Me.gridOrdenMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance39
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Appearance40.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridOrdenMaterial.DisplayLayout.Override.CellAppearance = Appearance40
        Me.gridOrdenMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridOrdenMaterial.DisplayLayout.Override.CellPadding = 0
        Me.gridOrdenMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridOrdenMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance41.BackColor = System.Drawing.SystemColors.Control
        Appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance41.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance41.BorderColor = System.Drawing.SystemColors.Window
        Me.gridOrdenMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance41
        Appearance42.TextHAlignAsString = "Left"
        Me.gridOrdenMaterial.DisplayLayout.Override.HeaderAppearance = Appearance42
        Me.gridOrdenMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Me.gridOrdenMaterial.DisplayLayout.Override.RowAppearance = Appearance43
        Me.gridOrdenMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridOrdenMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridOrdenMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridOrdenMaterial.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridOrdenMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance44
        Me.gridOrdenMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridOrdenMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridOrdenMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridOrdenMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOrdenMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridOrdenMaterial.Location = New System.Drawing.Point(0, 0)
        Me.gridOrdenMaterial.Name = "gridOrdenMaterial"
        Me.gridOrdenMaterial.Size = New System.Drawing.Size(1147, 223)
        Me.gridOrdenMaterial.TabIndex = 0
        Me.gridOrdenMaterial.Text = "Grilla1"
        '
        'odOMat
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn27.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.odOMat.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        '
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.Expanded = False
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(756, 223)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(1147, 0)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(22, 223)
        Me.gbeMateriales.TabIndex = 1
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griListaMateriales)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion8)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(733, 216)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'griListaMateriales
        '
        Me.griListaMateriales.DataSource = Me.odMaterial
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaMateriales.DisplayLayout.Appearance = Appearance45
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance46.TextHAlignAsString = "Center"
        UltraGridColumn161.Header.Appearance = Appearance46
        UltraGridColumn161.Header.VisiblePosition = 0
        UltraGridColumn161.Width = 27
        Appearance47.TextHAlignAsString = "Center"
        UltraGridColumn162.Header.Appearance = Appearance47
        UltraGridColumn162.Header.VisiblePosition = 1
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 9
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 3
        UltraGridColumn164.Hidden = True
        UltraGridColumn164.Width = 320
        UltraGridColumn165.Header.VisiblePosition = 6
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 7
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 8
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 10
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 11
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 12
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 13
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 14
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 15
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.Caption = "Unidad de medida"
        UltraGridColumn174.Header.VisiblePosition = 19
        UltraGridColumn174.Width = 114
        UltraGridColumn175.Header.VisiblePosition = 20
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 21
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 22
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.Header.VisiblePosition = 23
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 24
        UltraGridColumn179.Hidden = True
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn180.Header.Appearance = Appearance48
        UltraGridColumn180.Header.VisiblePosition = 5
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 4
        UltraGridColumn181.Width = 254
        UltraGridColumn182.Header.VisiblePosition = 25
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.Caption = "Costo"
        UltraGridColumn183.Header.VisiblePosition = 26
        UltraGridColumn184.Header.VisiblePosition = 18
        UltraGridColumn185.Header.Caption = ":"
        UltraGridColumn185.Header.VisiblePosition = 2
        UltraGridColumn186.Header.VisiblePosition = 27
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 16
        UltraGridColumn187.Hidden = True
        Appearance49.TextHAlignAsString = "Center"
        UltraGridColumn188.Header.Appearance = Appearance49
        UltraGridColumn188.Header.VisiblePosition = 17
        UltraGridColumn218.Header.VisiblePosition = 28
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 29
        UltraGridColumn219.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn218, UltraGridColumn219})
        Me.griListaMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaMateriales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.griListaMateriales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.GroupByBox.Hidden = True
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.griListaMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaMateriales.DisplayLayout.MaxRowScrollRegions = 1
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaMateriales.DisplayLayout.Override.ActiveCellAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.SystemColors.Highlight
        Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaMateriales.DisplayLayout.Override.ActiveRowAppearance = Appearance54
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Appearance56.BorderColor = System.Drawing.Color.Silver
        Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaMateriales.DisplayLayout.Override.CellAppearance = Appearance56
        Me.griListaMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griListaMateriales.DisplayLayout.Override.CellPadding = 0
        Appearance57.BackColor = System.Drawing.SystemColors.Control
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.Override.GroupByRowAppearance = Appearance57
        Appearance58.TextHAlignAsString = "Left"
        Me.griListaMateriales.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.griListaMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaMateriales.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.griListaMateriales.DisplayLayout.Override.RowAppearance = Appearance59
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaMateriales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaMateriales.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        Me.griListaMateriales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaMateriales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaMateriales.Location = New System.Drawing.Point(0, 56)
        Me.griListaMateriales.Name = "griListaMateriales"
        Me.griListaMateriales.Size = New System.Drawing.Size(733, 160)
        Me.griListaMateriales.TabIndex = 1
        Me.griListaMateriales.Text = "Grilla2"
        '
        'odMaterial
        '
        UltraDataColumn37.DataType = GetType(Boolean)
        UltraDataColumn37.DefaultValue = False
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66})
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.btnListarMateriales)
        Me.Agrupacion8.Controls.Add(Me.txtBuscarMateriales)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(733, 56)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.Text = "Agregar Materiales:"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListarMateriales
        '
        Appearance61.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMateriales.Appearance = Appearance61
        Me.btnListarMateriales.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMateriales.ImageList = Me.imagenes
        Me.btnListarMateriales.Location = New System.Drawing.Point(423, 19)
        Me.btnListarMateriales.Name = "btnListarMateriales"
        Me.btnListarMateriales.Size = New System.Drawing.Size(30, 32)
        Me.btnListarMateriales.TabIndex = 2
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
        Appearance62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Appearance = Appearance62
        Me.txtBuscarMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBuscarMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBuscarMateriales.Location = New System.Drawing.Point(66, 24)
        Me.txtBuscarMateriales.MaxLength = 200
        Me.txtBuscarMateriales.Name = "txtBuscarMateriales"
        Me.txtBuscarMateriales.Size = New System.Drawing.Size(351, 22)
        Me.txtBuscarMateriales.TabIndex = 1
        '
        'Etiqueta19
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta19.Appearance = Appearance63
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(20, 26)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta19.TabIndex = 0
        Me.Etiqueta19.Text = "Buscar:"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.gbDocAsociar)
        Me.UltraTabPageControl9.Controls.Add(Me.GriAsocDoc)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1169, 223)
        '
        'gbDocAsociar
        '
        Me.gbDocAsociar.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbDocAsociar.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.gbDocAsociar.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbDocAsociar.ExpandedSize = New System.Drawing.Size(636, 223)
        Me.gbDocAsociar.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbDocAsociar.Location = New System.Drawing.Point(533, 0)
        Me.gbDocAsociar.Name = "gbDocAsociar"
        Me.gbDocAsociar.Size = New System.Drawing.Size(636, 223)
        Me.gbDocAsociar.TabIndex = 1
        Me.gbDocAsociar.Text = "Listado de Documentos"
        Me.gbDocAsociar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griListaDoc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(613, 217)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griListaDoc
        '
        Me.griListaDoc.DataSource = Me.odDocumentos
        Appearance64.BackColor = System.Drawing.SystemColors.Window
        Appearance64.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaDoc.DisplayLayout.Appearance = Appearance64
        UltraGridColumn69.Header.VisiblePosition = 0
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 1
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 7
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 8
        UltraGridColumn72.Hidden = True
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn73.CellAppearance = Appearance65
        UltraGridColumn73.Header.VisiblePosition = 10
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn73.Width = 123
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn74.CellAppearance = Appearance66
        UltraGridColumn74.Header.Caption = "Imp. Venta"
        UltraGridColumn74.Header.VisiblePosition = 11
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance67.TextHAlignAsString = "Right"
        UltraGridColumn75.CellAppearance = Appearance67
        UltraGridColumn75.Header.VisiblePosition = 12
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn76.Header.VisiblePosition = 13
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 14
        UltraGridColumn77.Hidden = True
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn78.CellAppearance = Appearance68
        UltraGridColumn78.Header.VisiblePosition = 15
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.MaskInput = ""
        UltraGridColumn79.Header.VisiblePosition = 16
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 5
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 6
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.Width = 132
        UltraGridColumn82.Header.VisiblePosition = 17
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 18
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn84.Header.Caption = "Fecha"
        UltraGridColumn84.Header.VisiblePosition = 4
        UltraGridColumn84.Width = 107
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
        UltraGridColumn92.Header.VisiblePosition = 26
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 27
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 28
        UltraGridColumn94.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 29
        UltraGridColumn189.Hidden = True
        UltraGridColumn96.Header.Caption = "Estado"
        UltraGridColumn96.Header.VisiblePosition = 9
        UltraGridColumn97.Header.Caption = "Empresa"
        UltraGridColumn97.Header.VisiblePosition = 2
        UltraGridColumn97.Width = 291
        UltraGridColumn98.Header.Caption = "Nº Documento"
        UltraGridColumn98.Header.VisiblePosition = 3
        UltraGridColumn98.Width = 143
        UltraGridColumn99.Header.VisiblePosition = 30
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 31
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 32
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 33
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 34
        UltraGridColumn103.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn36.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn189, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn36})
        Me.griListaDoc.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaDoc.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDoc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance69.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance69.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDoc.DisplayLayout.GroupByBox.Appearance = Appearance69
        Appearance70.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDoc.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance70
        Me.griListaDoc.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDoc.DisplayLayout.GroupByBox.Hidden = True
        Appearance71.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance71.BackColor2 = System.Drawing.SystemColors.Control
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance71.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDoc.DisplayLayout.GroupByBox.PromptAppearance = Appearance71
        Me.griListaDoc.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaDoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDoc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDoc.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaDoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDoc.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDoc.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDoc.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaDoc.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDoc.Location = New System.Drawing.Point(0, 62)
        Me.griListaDoc.Name = "griListaDoc"
        Me.griListaDoc.Size = New System.Drawing.Size(613, 155)
        Me.griListaDoc.TabIndex = 1
        Me.griListaDoc.Text = "Grilla2"
        '
        'odDocumentos
        '
        Me.odDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta51)
        Me.Agrupacion2.Controls.Add(Me.fecHasta)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta50)
        Me.Agrupacion2.Controls.Add(Me.fecDesde)
        Me.Agrupacion2.Controls.Add(Me.cboTipoDoc)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion2.Controls.Add(Me.btnBuscarOrdenes)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(613, 62)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Documento a Asociar:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta51
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance72
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(144, 33)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta51.TabIndex = 2
        Me.Etiqueta51.Text = "Hasta:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(186, 29)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(85, 21)
        Me.fecHasta.TabIndex = 3
        '
        'Etiqueta50
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance73
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(6, 33)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta50.TabIndex = 0
        Me.Etiqueta50.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(53, 30)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(85, 21)
        Me.fecDesde.TabIndex = 1
        '
        'cboTipoDoc
        '
        Appearance74.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDoc.Appearance = Appearance74
        Me.cboTipoDoc.DisplayMember = "Nombre"
        Me.cboTipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDoc.Location = New System.Drawing.Point(371, 29)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(165, 22)
        Me.cboTipoDoc.TabIndex = 5
        Me.cboTipoDoc.ValueMember = "Id"
        '
        'Etiqueta17
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance75
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(280, 33)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta17.TabIndex = 4
        Me.Etiqueta17.Text = "Tipo Documento"
        '
        'btnBuscarOrdenes
        '
        Appearance76.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance76.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance76.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnBuscarOrdenes.Appearance = Appearance76
        Me.btnBuscarOrdenes.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarOrdenes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarOrdenes.ImageList = Me.imagenes
        Me.btnBuscarOrdenes.Location = New System.Drawing.Point(542, 25)
        Me.btnBuscarOrdenes.Name = "btnBuscarOrdenes"
        Me.btnBuscarOrdenes.Size = New System.Drawing.Size(30, 31)
        Me.btnBuscarOrdenes.TabIndex = 6
        '
        'GriAsocDoc
        '
        Me.GriAsocDoc.DataSource = Me.odDocumentos
        Appearance77.BackColor = System.Drawing.SystemColors.Window
        Appearance77.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.GriAsocDoc.DisplayLayout.Appearance = Appearance77
        UltraGridColumn104.Header.VisiblePosition = 0
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 3
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.Width = 169
        UltraGridColumn106.Header.VisiblePosition = 7
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 8
        UltraGridColumn107.Hidden = True
        Appearance78.TextHAlignAsString = "Right"
        UltraGridColumn108.CellAppearance = Appearance78
        UltraGridColumn108.Header.VisiblePosition = 9
        UltraGridColumn108.Hidden = True
        UltraGridColumn108.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn108.Width = 123
        Appearance79.TextHAlignAsString = "Right"
        UltraGridColumn109.CellAppearance = Appearance79
        UltraGridColumn109.Header.Caption = "Imp. Venta"
        UltraGridColumn109.Header.VisiblePosition = 10
        UltraGridColumn109.Hidden = True
        UltraGridColumn109.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance80.TextHAlignAsString = "Right"
        UltraGridColumn110.CellAppearance = Appearance80
        UltraGridColumn110.Header.VisiblePosition = 11
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn110.Width = 143
        UltraGridColumn111.Header.VisiblePosition = 13
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 14
        UltraGridColumn112.Hidden = True
        Appearance81.TextHAlignAsString = "Right"
        UltraGridColumn113.CellAppearance = Appearance81
        UltraGridColumn113.Header.VisiblePosition = 15
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.MaskInput = ""
        UltraGridColumn114.Header.VisiblePosition = 16
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 5
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 6
        UltraGridColumn116.Hidden = True
        UltraGridColumn116.Width = 132
        UltraGridColumn117.Header.VisiblePosition = 17
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 18
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn119.Header.Caption = "Fecha"
        UltraGridColumn119.Header.VisiblePosition = 1
        UltraGridColumn119.Width = 107
        UltraGridColumn120.Header.VisiblePosition = 19
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 20
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 21
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 22
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 23
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 24
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 25
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 26
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 27
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 28
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 29
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.Header.Caption = "Estado"
        UltraGridColumn131.Header.VisiblePosition = 12
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.Caption = "Empresa"
        UltraGridColumn132.Header.VisiblePosition = 2
        UltraGridColumn132.Width = 291
        UltraGridColumn133.Header.Caption = "Nº Documento"
        UltraGridColumn133.Header.VisiblePosition = 4
        UltraGridColumn133.Width = 143
        UltraGridColumn134.Header.VisiblePosition = 30
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 31
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 32
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.VisiblePosition = 33
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 34
        UltraGridColumn138.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 35
        UltraGridColumn37.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn37})
        Me.GriAsocDoc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.GriAsocDoc.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GriAsocDoc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance82.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance82.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance82.BorderColor = System.Drawing.SystemColors.Window
        Me.GriAsocDoc.DisplayLayout.GroupByBox.Appearance = Appearance82
        Appearance83.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GriAsocDoc.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance83
        Me.GriAsocDoc.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GriAsocDoc.DisplayLayout.GroupByBox.Hidden = True
        Appearance84.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance84.BackColor2 = System.Drawing.SystemColors.Control
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance84.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GriAsocDoc.DisplayLayout.GroupByBox.PromptAppearance = Appearance84
        Me.GriAsocDoc.DisplayLayout.MaxColScrollRegions = 1
        Me.GriAsocDoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.GriAsocDoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriAsocDoc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriAsocDoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GriAsocDoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GriAsocDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GriAsocDoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriAsocDoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriAsocDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriAsocDoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GriAsocDoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriAsocDoc.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.GriAsocDoc.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GriAsocDoc.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GriAsocDoc.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.GriAsocDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriAsocDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriAsocDoc.Location = New System.Drawing.Point(0, 0)
        Me.GriAsocDoc.Name = "GriAsocDoc"
        Me.GriAsocDoc.Size = New System.Drawing.Size(1169, 223)
        Me.GriAsocDoc.TabIndex = 0
        Me.GriAsocDoc.Text = "Grilla2"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.gridOrdenMovimientos)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1169, 223)
        '
        'gridOrdenMovimientos
        '
        Me.gridOrdenMovimientos.DataSource = Me.odMov
        Appearance85.BackColor = System.Drawing.SystemColors.Window
        Appearance85.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridOrdenMovimientos.DisplayLayout.Appearance = Appearance85
        Appearance86.TextHAlignAsString = "Center"
        UltraGridColumn139.Header.Appearance = Appearance86
        UltraGridColumn139.Header.VisiblePosition = 0
        UltraGridColumn139.Hidden = True
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn140.Header.Appearance = Appearance87
        UltraGridColumn140.Header.Caption = "Nro Movimiento"
        UltraGridColumn140.Header.VisiblePosition = 1
        UltraGridColumn140.Width = 102
        Appearance88.TextHAlignAsString = "Center"
        UltraGridColumn141.Header.Appearance = Appearance88
        UltraGridColumn141.Header.VisiblePosition = 2
        UltraGridColumn141.Hidden = True
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn142.Header.Appearance = Appearance89
        UltraGridColumn142.Header.VisiblePosition = 3
        UltraGridColumn142.Hidden = True
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn143.Header.Appearance = Appearance90
        UltraGridColumn143.Header.Caption = "Material"
        UltraGridColumn143.Header.VisiblePosition = 4
        UltraGridColumn143.Width = 291
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn144.CellAppearance = Appearance91
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn144.Header.Appearance = Appearance92
        UltraGridColumn144.Header.VisiblePosition = 5
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn145.CellAppearance = Appearance93
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn145.Header.Appearance = Appearance94
        UltraGridColumn145.Header.Caption = "Cantidad Real"
        UltraGridColumn145.Header.VisiblePosition = 7
        Appearance95.TextHAlignAsString = "Center"
        UltraGridColumn146.Header.Appearance = Appearance95
        UltraGridColumn146.Header.VisiblePosition = 8
        UltraGridColumn146.Hidden = True
        Appearance96.TextHAlignAsString = "Center"
        UltraGridColumn147.Header.Appearance = Appearance96
        UltraGridColumn147.Header.Caption = "Unidad"
        UltraGridColumn147.Header.VisiblePosition = 6
        UltraGridColumn147.Width = 87
        UltraGridColumn148.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance97.TextHAlignAsString = "Center"
        UltraGridColumn148.Header.Appearance = Appearance97
        UltraGridColumn148.Header.VisiblePosition = 9
        UltraGridColumn148.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn148.Width = 124
        Appearance98.TextHAlignAsString = "Center"
        UltraGridColumn149.Header.Appearance = Appearance98
        UltraGridColumn149.Header.VisiblePosition = 11
        UltraGridColumn149.Hidden = True
        Appearance99.TextHAlignAsString = "Center"
        UltraGridColumn150.Header.Appearance = Appearance99
        UltraGridColumn150.Header.Caption = "SubAlmacen"
        UltraGridColumn150.Header.VisiblePosition = 10
        UltraGridColumn150.Width = 102
        Appearance100.TextHAlignAsString = "Center"
        UltraGridColumn151.Header.Appearance = Appearance100
        UltraGridColumn151.Header.VisiblePosition = 12
        UltraGridColumn151.Hidden = True
        Appearance101.TextHAlignAsString = "Center"
        UltraGridColumn152.Header.Appearance = Appearance101
        UltraGridColumn152.Header.Caption = "Almacen"
        UltraGridColumn152.Header.VisiblePosition = 13
        UltraGridColumn152.Width = 166
        Appearance102.TextHAlignAsString = "Center"
        UltraGridColumn153.Header.Appearance = Appearance102
        UltraGridColumn153.Header.Caption = "Usuario"
        UltraGridColumn153.Header.VisiblePosition = 14
        UltraGridColumn153.Hidden = True
        UltraGridColumn153.Width = 167
        Appearance103.TextHAlignAsString = "Center"
        UltraGridColumn154.Header.Appearance = Appearance103
        UltraGridColumn154.Header.VisiblePosition = 15
        UltraGridColumn154.Hidden = True
        Appearance104.TextHAlignAsString = "Center"
        UltraGridColumn155.Header.Appearance = Appearance104
        UltraGridColumn155.Header.VisiblePosition = 16
        UltraGridColumn155.Hidden = True
        Appearance105.TextHAlignAsString = "Center"
        UltraGridColumn156.Header.Appearance = Appearance105
        UltraGridColumn156.Header.VisiblePosition = 17
        UltraGridColumn156.Hidden = True
        Appearance106.TextHAlignAsString = "Center"
        UltraGridColumn157.Header.Appearance = Appearance106
        UltraGridColumn157.Header.VisiblePosition = 18
        UltraGridColumn157.Hidden = True
        Appearance107.TextHAlignAsString = "Center"
        UltraGridColumn158.Header.Appearance = Appearance107
        UltraGridColumn158.Header.VisiblePosition = 19
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.Caption = "Usuario"
        UltraGridColumn159.Header.VisiblePosition = 20
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159})
        UltraGridBand5.SummaryFooterCaption = "Totales:"
        Me.gridOrdenMovimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.gridOrdenMovimientos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridOrdenMovimientos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance108.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance108.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance108.BorderColor = System.Drawing.SystemColors.Window
        Me.gridOrdenMovimientos.DisplayLayout.GroupByBox.Appearance = Appearance108
        Appearance109.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridOrdenMovimientos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance109
        Me.gridOrdenMovimientos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridOrdenMovimientos.DisplayLayout.GroupByBox.Hidden = True
        Appearance110.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance110.BackColor2 = System.Drawing.SystemColors.Control
        Appearance110.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance110.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridOrdenMovimientos.DisplayLayout.GroupByBox.PromptAppearance = Appearance110
        Me.gridOrdenMovimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.gridOrdenMovimientos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance111.BackColor = System.Drawing.SystemColors.Window
        Appearance111.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gridOrdenMovimientos.DisplayLayout.Override.ActiveCellAppearance = Appearance111
        Appearance112.BackColor = System.Drawing.SystemColors.Highlight
        Appearance112.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.gridOrdenMovimientos.DisplayLayout.Override.ActiveRowAppearance = Appearance112
        Me.gridOrdenMovimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridOrdenMovimientos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridOrdenMovimientos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance113.BackColor = System.Drawing.SystemColors.Window
        Me.gridOrdenMovimientos.DisplayLayout.Override.CardAreaAppearance = Appearance113
        Appearance114.BorderColor = System.Drawing.Color.Silver
        Appearance114.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridOrdenMovimientos.DisplayLayout.Override.CellAppearance = Appearance114
        Me.gridOrdenMovimientos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridOrdenMovimientos.DisplayLayout.Override.CellPadding = 0
        Me.gridOrdenMovimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridOrdenMovimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance115.BackColor = System.Drawing.SystemColors.Control
        Appearance115.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance115.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance115.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance115.BorderColor = System.Drawing.SystemColors.Window
        Me.gridOrdenMovimientos.DisplayLayout.Override.GroupByRowAppearance = Appearance115
        Appearance116.TextHAlignAsString = "Left"
        Me.gridOrdenMovimientos.DisplayLayout.Override.HeaderAppearance = Appearance116
        Me.gridOrdenMovimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance117.BackColor = System.Drawing.SystemColors.Window
        Appearance117.BorderColor = System.Drawing.Color.Silver
        Me.gridOrdenMovimientos.DisplayLayout.Override.RowAppearance = Appearance117
        Me.gridOrdenMovimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridOrdenMovimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridOrdenMovimientos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridOrdenMovimientos.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance118.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridOrdenMovimientos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance118
        Me.gridOrdenMovimientos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridOrdenMovimientos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridOrdenMovimientos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridOrdenMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOrdenMovimientos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridOrdenMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.gridOrdenMovimientos.Name = "gridOrdenMovimientos"
        Me.gridOrdenMovimientos.Size = New System.Drawing.Size(1169, 223)
        Me.gridOrdenMovimientos.TabIndex = 0
        Me.gridOrdenMovimientos.Text = "Grilla1"
        '
        'odMov
        '
        Me.odMov.Band.Columns.AddRange(New Object() {UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenesdeIngreso)
        Me.UltraTabPageControl1.Controls.Add(Me.agrFiltro)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1177, 472)
        '
        'agrOrdenesdeIngreso
        '
        Me.agrOrdenesdeIngreso.Controls.Add(Me.gridListaOrden)
        Me.agrOrdenesdeIngreso.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenesdeIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenesdeIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenesdeIngreso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenesdeIngreso.Location = New System.Drawing.Point(0, 101)
        Me.agrOrdenesdeIngreso.Name = "agrOrdenesdeIngreso"
        Me.agrOrdenesdeIngreso.Size = New System.Drawing.Size(1177, 371)
        Me.agrOrdenesdeIngreso.TabIndex = 1
        Me.agrOrdenesdeIngreso.Text = "Listado de Ordenes de Salida"
        Me.agrOrdenesdeIngreso.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridListaOrden
        '
        Me.gridListaOrden.ContextMenuStrip = Me.MenuContextual1
        Me.gridListaOrden.DataSource = Me.odOrden
        UltraGridColumn190.Header.VisiblePosition = 0
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.Caption = "N° Orden"
        UltraGridColumn191.Header.VisiblePosition = 1
        UltraGridColumn191.Width = 96
        UltraGridColumn192.Header.VisiblePosition = 4
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 5
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn194.Header.Caption = "Fecha"
        UltraGridColumn194.Header.VisiblePosition = 2
        UltraGridColumn194.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn194.Width = 129
        UltraGridColumn195.Header.VisiblePosition = 8
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 9
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 10
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 11
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.Caption = "Movimiento Inventario"
        UltraGridColumn199.Header.VisiblePosition = 3
        UltraGridColumn199.Width = 234
        UltraGridColumn200.Header.Caption = "Tipo Referencia"
        UltraGridColumn200.Header.VisiblePosition = 12
        UltraGridColumn200.Width = 188
        UltraGridColumn201.Header.VisiblePosition = 13
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.Caption = "IdUsuario"
        UltraGridColumn202.Header.VisiblePosition = 16
        UltraGridColumn202.Hidden = True
        UltraGridColumn202.Width = 247
        UltraGridColumn203.Header.VisiblePosition = 20
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 17
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 18
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 19
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.Caption = "Tipo Orden"
        UltraGridColumn207.Header.VisiblePosition = 7
        UltraGridColumn207.Hidden = True
        UltraGridColumn207.Width = 212
        UltraGridColumn208.Header.VisiblePosition = 6
        UltraGridColumn208.Width = 73
        UltraGridColumn209.Header.Caption = "Estado"
        UltraGridColumn209.Header.VisiblePosition = 15
        UltraGridColumn209.Width = 87
        UltraGridColumn210.Header.VisiblePosition = 21
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 22
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.Caption = "Usuario"
        UltraGridColumn212.Header.VisiblePosition = 23
        UltraGridColumn212.Width = 87
        UltraGridColumn213.Header.VisiblePosition = 14
        UltraGridColumn213.Width = 114
        UltraGridColumn214.Header.VisiblePosition = 24
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 25
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 26
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 27
        UltraGridColumn217.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 28
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 29
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 30
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 31
        UltraGridColumn68.Width = 106
        UltraGridColumn38.Header.VisiblePosition = 32
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 33
        UltraGridColumn39.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn38, UltraGridColumn39})
        Me.gridListaOrden.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.gridListaOrden.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridListaOrden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridListaOrden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridListaOrden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridListaOrden.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridListaOrden.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridListaOrden.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridListaOrden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridListaOrden.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridListaOrden.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridListaOrden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridListaOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridListaOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridListaOrden.Location = New System.Drawing.Point(3, 47)
        Me.gridListaOrden.Name = "gridListaOrden"
        Me.gridListaOrden.Size = New System.Drawing.Size(1171, 321)
        Me.gridListaOrden.TabIndex = 1
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.EjecutarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(122, 92)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Orden de Ingreso"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Orden de Ingreso seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Orden de Ingreso seleccionada"
        '
        'EjecutarToolStripMenuItem
        '
        Me.EjecutarToolStripMenuItem.Image = CType(resources.GetObject("EjecutarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EjecutarToolStripMenuItem.Name = "EjecutarToolStripMenuItem"
        Me.EjecutarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EjecutarToolStripMenuItem.Text = "Ejecutar"
        '
        'odOrden
        '
        UltraDataColumn128.DataType = GetType(Date)
        UltraDataColumn129.DataType = GetType(Double)
        UltraDataColumn135.DataType = GetType(Boolean)
        Me.odOrden.Band.Columns.AddRange(New Object() {UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnRectificar)
        Me.agrMenuLista.Controls.Add(Me.btnEjecutar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1171, 30)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnRectificar
        '
        Appearance119.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance119.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnRectificar.Appearance = Appearance119
        Me.btnRectificar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnRectificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRectificar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRectificar.Enabled = False
        Me.btnRectificar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRectificar.ForeColor = System.Drawing.Color.Black
        Me.btnRectificar.Location = New System.Drawing.Point(80, 3)
        Me.btnRectificar.Name = "btnRectificar"
        Me.btnRectificar.Size = New System.Drawing.Size(89, 24)
        Me.btnRectificar.TabIndex = 1
        Me.btnRectificar.Text = "Rectificar"
        Me.tEjecutar.SetToolTip(Me.btnRectificar, "Rectificar Orden")
        Me.btnRectificar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.btnRectificar.Visible = False
        '
        'btnEjecutar
        '
        Appearance120.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance120.Image = CType(resources.GetObject("Appearance120.Image"), Object)
        Me.btnEjecutar.Appearance = Appearance120
        Me.btnEjecutar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEjecutar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEjecutar.Enabled = False
        Me.btnEjecutar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.ForeColor = System.Drawing.Color.Black
        Me.btnEjecutar.Location = New System.Drawing.Point(3, 3)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(77, 24)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        Me.tEjecutar.SetToolTip(Me.btnEjecutar, "Ejecuta Orden")
        Me.btnEjecutar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.gbOI)
        Me.agrFiltro.Controls.Add(Me.rbNroOrden)
        Me.agrFiltro.Controls.Add(Me.rbDatosAdicionales)
        Me.agrFiltro.Controls.Add(Me.gbDatosAdicionales)
        Me.agrFiltro.Controls.Add(Me.Agrupacion1)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1177, 101)
        Me.agrFiltro.TabIndex = 0
        Me.agrFiltro.Text = "Filtros:"
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbOI
        '
        Me.gbOI.Controls.Add(Me.txtNSalida)
        Me.gbOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOI.ForeColor = System.Drawing.Color.Black
        Me.gbOI.Location = New System.Drawing.Point(538, 40)
        Me.gbOI.Name = "gbOI"
        Me.gbOI.Size = New System.Drawing.Size(146, 36)
        Me.gbOI.TabIndex = 3
        Me.gbOI.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNSalida
        '
        Me.txtNSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNSalida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNSalida.Enabled = False
        Me.txtNSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNSalida.Location = New System.Drawing.Point(6, 6)
        Me.txtNSalida.MaxLength = 13
        Me.txtNSalida.Name = "txtNSalida"
        Me.txtNSalida.Size = New System.Drawing.Size(132, 21)
        Me.txtNSalida.TabIndex = 0
        '
        'rbNroOrden
        '
        Me.rbNroOrden.AutoSize = True
        Me.rbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rbNroOrden.Location = New System.Drawing.Point(538, 20)
        Me.rbNroOrden.Name = "rbNroOrden"
        Me.rbNroOrden.Size = New System.Drawing.Size(120, 17)
        Me.rbNroOrden.TabIndex = 2
        Me.rbNroOrden.Text = "N° Orden de Salida:"
        Me.rbNroOrden.UseVisualStyleBackColor = False
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(6, 20)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(113, 17)
        Me.rbDatosAdicionales.TabIndex = 0
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales:"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.rfOrdenSalidaHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta15)
        Me.gbDatosAdicionales.Controls.Add(Me.rfOrdenSalidaDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.cboEstadoOrden)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta21)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta9)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta8)
        Me.gbDatosAdicionales.Controls.Add(Me.cboFiltroMovimiento)
        Me.gbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosAdicionales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(5, 40)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(518, 58)
        Me.gbDatosAdicionales.TabIndex = 1
        Me.gbDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rfOrdenSalidaHasta
        '
        Me.rfOrdenSalidaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenSalidaHasta.Location = New System.Drawing.Point(51, 35)
        Me.rfOrdenSalidaHasta.Name = "rfOrdenSalidaHasta"
        Me.rfOrdenSalidaHasta.Size = New System.Drawing.Size(98, 21)
        Me.rfOrdenSalidaHasta.TabIndex = 3
        '
        'Etiqueta15
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance121
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(10, 10)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta15.TabIndex = 0
        Me.Etiqueta15.Text = "Desde:"
        '
        'rfOrdenSalidaDesde
        '
        Me.rfOrdenSalidaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenSalidaDesde.Location = New System.Drawing.Point(51, 7)
        Me.rfOrdenSalidaDesde.Name = "rfOrdenSalidaDesde"
        Me.rfOrdenSalidaDesde.Size = New System.Drawing.Size(98, 21)
        Me.rfOrdenSalidaDesde.TabIndex = 1
        '
        'cboEstadoOrden
        '
        Appearance122.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.Appearance = Appearance122
        Me.cboEstadoOrden.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoOrden.DisplayMember = "Nombre"
        Me.cboEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoOrden.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.ImageList = Me.imagenes
        Me.cboEstadoOrden.Location = New System.Drawing.Point(312, 33)
        Me.cboEstadoOrden.Name = "cboEstadoOrden"
        Me.cboEstadoOrden.Size = New System.Drawing.Size(200, 22)
        Me.cboEstadoOrden.TabIndex = 7
        Me.cboEstadoOrden.ValueMember = "Id"
        '
        'Etiqueta21
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance123
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(13, 37)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 2
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta9
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance124
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(266, 37)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta9.TabIndex = 6
        Me.Etiqueta9.Text = "Estado:"
        '
        'Etiqueta8
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance125
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(174, 10)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(132, 15)
        Me.Etiqueta8.TabIndex = 4
        Me.Etiqueta8.Text = "Movimiento de Inventario:"
        '
        'cboFiltroMovimiento
        '
        Appearance126.ForeColor = System.Drawing.Color.Black
        Me.cboFiltroMovimiento.Appearance = Appearance126
        Me.cboFiltroMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboFiltroMovimiento.DisplayMember = "Nombre"
        Me.cboFiltroMovimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFiltroMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFiltroMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFiltroMovimiento.ForeColor = System.Drawing.Color.Black
        Me.cboFiltroMovimiento.ImageList = Me.imagenes
        Me.cboFiltroMovimiento.Location = New System.Drawing.Point(312, 6)
        Me.cboFiltroMovimiento.Name = "cboFiltroMovimiento"
        Me.cboFiltroMovimiento.Size = New System.Drawing.Size(200, 22)
        Me.cboFiltroMovimiento.TabIndex = 5
        Me.cboFiltroMovimiento.ValueMember = "Id"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.ColoresTerminada)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion1.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion1.Controls.Add(Me.etiGenerada)
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(701, 20)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(132, 67)
        Me.Agrupacion1.TabIndex = 4
        Me.Agrupacion1.Text = "Estados"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresTerminada
        '
        Me.ColoresTerminada.Location = New System.Drawing.Point(70, 40)
        Me.ColoresTerminada.Name = "ColoresTerminada"
        Me.ColoresTerminada.Size = New System.Drawing.Size(46, 22)
        Me.ColoresTerminada.TabIndex = 3
        Me.ColoresTerminada.Text = "Control"
        '
        'Etiqueta16
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Appearance = Appearance127
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(70, 22)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta16.TabIndex = 2
        Me.Etiqueta16.Text = "Terminada"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(6, 40)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "Control"
        '
        'etiGenerada
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance128
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 22)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generada"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1177, 472)
        '
        'agrDetalle
        '
        Me.agrDetalle.Controls.Add(Me.ficDetalle)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea17)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea18)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea19)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea20)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea13)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea14)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea15)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea16)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea5)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea6)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea7)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea8)
        Me.agrDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalle.Location = New System.Drawing.Point(0, 180)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(1177, 292)
        Me.agrDetalle.TabIndex = 1
        Me.agrDetalle.Text = "Detalles"
        Me.agrDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl9)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalle.Location = New System.Drawing.Point(3, 43)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalle.Size = New System.Drawing.Size(1171, 246)
        Me.ficDetalle.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Material"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Asociar Orden"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Movimientos"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab9, UltraTab2})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1169, 223)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(3, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1171, 26)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ToolbarsManager = Me.MenuDet
        '
        'MenuDet
        '
        Appearance129.ForeColor = System.Drawing.Color.Black
        Me.MenuDet.Appearance = Appearance129
        Me.MenuDet.DesignerFlags = 1
        Me.MenuDet.DockWithinContainer = Me
        Me.MenuDet.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuDet.MdiMergeable = False
        Me.MenuDet.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool13, ButtonTool14})
        Me.MenuDet.MiniToolbar.ToolRowCount = 1
        Me.MenuDet.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool17, ButtonTool3, ButtonTool1})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.MenuDet.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance130.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance130
        ButtonTool4.SharedPropsInternal.Caption = "Guardar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance131.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance131
        ButtonTool5.SharedPropsInternal.Caption = "Editar"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance132.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance132
        ButtonTool6.SharedPropsInternal.Caption = "Quitar [-]"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance133.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance133
        ButtonTool10.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance134.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool12.SharedPropsInternal.AppearancesSmall.Appearance = Appearance134
        ButtonTool12.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool15.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool16.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool18.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance135.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance135
        ButtonTool9.SharedPropsInternal.Caption = "Consultar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance136.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance136
        ButtonTool19.SharedPropsInternal.Caption = "Agregar [+]"
        ButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance137.Image = Global.ISL.Win.My.Resources.Resources.Excel
        ButtonTool2.SharedPropsInternal.AppearancesSmall.Appearance = Appearance137
        ButtonTool2.SharedPropsInternal.Caption = "Importar [*]"
        ButtonTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.MenuDet.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool10, ButtonTool12, ButtonTool15, ButtonTool16, ButtonTool18, ButtonTool9, ButtonTool19, ButtonTool2})
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(3, 289)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1171, 0)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.MenuDet
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(3, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 272)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ToolbarsManager = Me.MenuDet
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1174, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 272)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ToolbarsManager = Me.MenuDet
        '
        'UltraToolbarsDockArea17
        '
        Me.UltraToolbarsDockArea17.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea17.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea17.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea17.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea17.Name = "UltraToolbarsDockArea17"
        Me.UltraToolbarsDockArea17.Size = New System.Drawing.Size(1171, 0)
        '
        'UltraToolbarsDockArea18
        '
        Me.UltraToolbarsDockArea18.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea18.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea18.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea18.Location = New System.Drawing.Point(3, 289)
        Me.UltraToolbarsDockArea18.Name = "UltraToolbarsDockArea18"
        Me.UltraToolbarsDockArea18.Size = New System.Drawing.Size(1171, 0)
        '
        'UltraToolbarsDockArea19
        '
        Me.UltraToolbarsDockArea19.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea19.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea19.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea19.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea19.Name = "UltraToolbarsDockArea19"
        Me.UltraToolbarsDockArea19.Size = New System.Drawing.Size(0, 272)
        '
        'UltraToolbarsDockArea20
        '
        Me.UltraToolbarsDockArea20.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea20.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea20.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea20.Location = New System.Drawing.Point(1174, 17)
        Me.UltraToolbarsDockArea20.Name = "UltraToolbarsDockArea20"
        Me.UltraToolbarsDockArea20.Size = New System.Drawing.Size(0, 272)
        '
        'UltraToolbarsDockArea13
        '
        Me.UltraToolbarsDockArea13.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea13.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea13.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea13.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea13.Name = "UltraToolbarsDockArea13"
        Me.UltraToolbarsDockArea13.Size = New System.Drawing.Size(1171, 0)
        '
        'UltraToolbarsDockArea14
        '
        Me.UltraToolbarsDockArea14.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea14.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea14.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea14.Location = New System.Drawing.Point(3, 289)
        Me.UltraToolbarsDockArea14.Name = "UltraToolbarsDockArea14"
        Me.UltraToolbarsDockArea14.Size = New System.Drawing.Size(1171, 0)
        '
        'UltraToolbarsDockArea15
        '
        Me.UltraToolbarsDockArea15.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea15.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea15.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea15.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea15.Name = "UltraToolbarsDockArea15"
        Me.UltraToolbarsDockArea15.Size = New System.Drawing.Size(0, 272)
        '
        'UltraToolbarsDockArea16
        '
        Me.UltraToolbarsDockArea16.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea16.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea16.Location = New System.Drawing.Point(1174, 17)
        Me.UltraToolbarsDockArea16.Name = "UltraToolbarsDockArea16"
        Me.UltraToolbarsDockArea16.Size = New System.Drawing.Size(0, 272)
        '
        'UltraToolbarsDockArea5
        '
        Me.UltraToolbarsDockArea5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea5.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea5.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea5.Name = "UltraToolbarsDockArea5"
        Me.UltraToolbarsDockArea5.Size = New System.Drawing.Size(1171, 0)
        '
        'UltraToolbarsDockArea6
        '
        Me.UltraToolbarsDockArea6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea6.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea6.Location = New System.Drawing.Point(3, 289)
        Me.UltraToolbarsDockArea6.Name = "UltraToolbarsDockArea6"
        Me.UltraToolbarsDockArea6.Size = New System.Drawing.Size(1171, 0)
        '
        'UltraToolbarsDockArea7
        '
        Me.UltraToolbarsDockArea7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea7.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea7.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea7.Name = "UltraToolbarsDockArea7"
        Me.UltraToolbarsDockArea7.Size = New System.Drawing.Size(0, 272)
        '
        'UltraToolbarsDockArea8
        '
        Me.UltraToolbarsDockArea8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea8.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea8.Location = New System.Drawing.Point(1174, 17)
        Me.UltraToolbarsDockArea8.Name = "UltraToolbarsDockArea8"
        Me.UltraToolbarsDockArea8.Size = New System.Drawing.Size(0, 272)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(0, 180)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1177, 0)
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(0, 472)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1177, 0)
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(0, 180)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 292)
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1177, 180)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 292)
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.fecFechaOrden)
        Me.agrDatoGeneral.Controls.Add(Me.cboMovimientoInventario)
        Me.agrDatoGeneral.Controls.Add(Me.lbl_etiqueta)
        Me.agrDatoGeneral.Controls.Add(Me.txtProveedor)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta4)
        Me.agrDatoGeneral.Controls.Add(Me.txtEstado)
        Me.agrDatoGeneral.Controls.Add(Me.etiEstado)
        Me.agrDatoGeneral.Controls.Add(Me.cboMoneda)
        Me.agrDatoGeneral.Controls.Add(Me.txtNroOrden)
        Me.agrDatoGeneral.Controls.Add(Me.etiNroOrden)
        Me.agrDatoGeneral.Controls.Add(Me.txtGlosa)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta13)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta12)
        Me.agrDatoGeneral.Controls.Add(Me.decTotal)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta11)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta10)
        Me.agrDatoGeneral.Controls.Add(Me.verActivo)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta1)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1177, 180)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecFechaOrden
        '
        Me.fecFechaOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaOrden.Location = New System.Drawing.Point(332, 78)
        Me.fecFechaOrden.Name = "fecFechaOrden"
        Me.fecFechaOrden.Size = New System.Drawing.Size(98, 20)
        Me.fecFechaOrden.TabIndex = 7
        '
        'cboMovimientoInventario
        '
        Appearance138.ForeColor = System.Drawing.Color.Black
        Me.cboMovimientoInventario.Appearance = Appearance138
        Me.cboMovimientoInventario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMovimientoInventario.DisplayMember = "Nombre"
        Me.cboMovimientoInventario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMovimientoInventario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMovimientoInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMovimientoInventario.ForeColor = System.Drawing.Color.Black
        Me.cboMovimientoInventario.ImageList = Me.imagenes
        Me.cboMovimientoInventario.Location = New System.Drawing.Point(94, 20)
        Me.cboMovimientoInventario.Name = "cboMovimientoInventario"
        Me.cboMovimientoInventario.Size = New System.Drawing.Size(351, 22)
        Me.cboMovimientoInventario.TabIndex = 1
        Me.cboMovimientoInventario.ValueMember = "Id"
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance139
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1085, 18)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(84, 18)
        Me.lbl_etiqueta.TabIndex = 17
        Me.lbl_etiqueta.Text = "Ejecutar OS"
        Me.lbl_etiqueta.Visible = False
        '
        'txtProveedor
        '
        Appearance140.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Appearance = Appearance140
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Location = New System.Drawing.Point(94, 48)
        Me.txtProveedor.MaxLength = 200
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(351, 22)
        Me.txtProveedor.TabIndex = 3
        Me.txtProveedor.TabStop = False
        Me.txtProveedor.Tag = ""
        Me.txtProveedor.Text = "INDUAMERICA SERVICIOS LOGISTICOS S.A.C."
        '
        'Etiqueta4
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance141
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(38, 52)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Empresa:"
        '
        'txtEstado
        '
        Appearance142.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Appearance = Appearance142
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Location = New System.Drawing.Point(534, 48)
        Me.txtEstado.MaxLength = 200
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(102, 22)
        Me.txtEstado.TabIndex = 15
        '
        'etiEstado
        '
        Appearance143.BackColor = System.Drawing.Color.Transparent
        Me.etiEstado.Appearance = Appearance143
        Me.etiEstado.AutoSize = True
        Me.etiEstado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEstado.Location = New System.Drawing.Point(488, 52)
        Me.etiEstado.Name = "etiEstado"
        Me.etiEstado.Size = New System.Drawing.Size(40, 15)
        Me.etiEstado.TabIndex = 14
        Me.etiEstado.Text = "Estado:"
        Me.etiEstado.Visible = False
        '
        'cboMoneda
        '
        Appearance144.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance144
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.ImageList = Me.imagenes
        Me.cboMoneda.Location = New System.Drawing.Point(94, 76)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 22)
        Me.cboMoneda.TabIndex = 5
        Me.cboMoneda.ValueMember = "Id"
        '
        'txtNroOrden
        '
        Appearance145.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrden.Appearance = Appearance145
        Me.txtNroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrden.Location = New System.Drawing.Point(534, 20)
        Me.txtNroOrden.MaxLength = 200
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.ReadOnly = True
        Me.txtNroOrden.Size = New System.Drawing.Size(102, 22)
        Me.txtNroOrden.TabIndex = 13
        '
        'etiNroOrden
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Me.etiNroOrden.Appearance = Appearance146
        Me.etiNroOrden.AutoSize = True
        Me.etiNroOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNroOrden.Location = New System.Drawing.Point(474, 24)
        Me.etiNroOrden.Name = "etiNroOrden"
        Me.etiNroOrden.Size = New System.Drawing.Size(54, 15)
        Me.etiNroOrden.TabIndex = 12
        Me.etiNroOrden.Text = "N° Orden:"
        Me.etiNroOrden.Visible = False
        '
        'txtGlosa
        '
        Appearance147.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance147
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(94, 104)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(351, 42)
        Me.txtGlosa.TabIndex = 9
        Me.txtGlosa.Tag = "0"
        '
        'Etiqueta13
        '
        Appearance148.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance148
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(54, 106)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta13.TabIndex = 8
        Me.Etiqueta13.Text = "Glosa:"
        '
        'Etiqueta12
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance149
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(42, 80)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta12.TabIndex = 4
        Me.Etiqueta12.Text = "Moneda:"
        '
        'decTotal
        '
        Appearance150.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotal.Appearance = Appearance150
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotal.Location = New System.Drawing.Point(94, 152)
        Me.decTotal.Name = "decTotal"
        Me.decTotal.NullText = "0.00"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.ReadOnly = True
        Me.decTotal.Size = New System.Drawing.Size(100, 22)
        Me.decTotal.TabIndex = 11
        '
        'Etiqueta11
        '
        Appearance151.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance151
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(22, 156)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta11.TabIndex = 10
        Me.Etiqueta11.Text = "Total Monto:"
        '
        'Etiqueta10
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance152
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(285, 80)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta10.TabIndex = 6
        Me.Etiqueta10.Text = "Fecha:"
        '
        'verActivo
        '
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(534, 76)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(55, 24)
        Me.verActivo.TabIndex = 16
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'Etiqueta1
        '
        Appearance153.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance153
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(24, 24)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Movimiento:"
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.QuitarToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(112, 48)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        Me.AgregarToolStripMenuItem.ToolTipText = "Insertar un nuevo Detalle"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        Me.QuitarToolStripMenuItem.ToolTipText = "Quitar detalle seleccionado"
        '
        'ficOrden
        '
        Me.ficOrden.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrden.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrden.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOrden.Location = New System.Drawing.Point(0, 0)
        Me.ficOrden.Name = "ficOrden"
        Me.ficOrden.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrden.Size = New System.Drawing.Size(1179, 495)
        Me.ficOrden.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.ficOrden.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab4})
        Me.ficOrden.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraTabSharedControlsPage1_Fill_Panel)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1177, 472)
        '
        'UltraTabSharedControlsPage1_Fill_Panel
        '
        Me.UltraTabSharedControlsPage1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraTabSharedControlsPage1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabSharedControlsPage1_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Name = "UltraTabSharedControlsPage1_Fill_Panel"
        Me.UltraTabSharedControlsPage1_Fill_Panel.Size = New System.Drawing.Size(1177, 472)
        Me.UltraTabSharedControlsPage1_Fill_Panel.TabIndex = 0
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 472)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1177, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 472)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1177, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 472)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1177, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_OrdenSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1179, 495)
        Me.Controls.Add(Me.ficOrden)
        Me.Name = "frm_OrdenSalida"
        Me.Tag = "1CH000000002"
        Me.Text = "Orden de Salida"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.gridOrdenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.gbDocAsociar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDocAsociar.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griListaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GriAsocDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.gridOrdenMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrOrdenesdeIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenesdeIngreso.ResumeLayout(False)
        CType(Me.gridListaOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.agrFiltro.PerformLayout()
        CType(Me.gbOI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOI.ResumeLayout(False)
        Me.gbOI.PerformLayout()
        CType(Me.txtNSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFiltroMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalle.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.MenuDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.cboMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.ficOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrden.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDet As ISL.Controles.Menu
    Friend WithEvents ficOrden As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabSharedControlsPage1_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDetalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ficDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea17 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea18 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea19 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea20 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea13 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea14 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea15 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea16 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea5 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea6 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea7 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea8 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents txtNroOrden As ISL.Controles.Texto
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents odOrden As ISL.Controles.OrigenDatos
    Friend WithEvents odOMat As ISL.Controles.OrigenDatos
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents etiEstado As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents etiNroOrden As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents agrOrdenesdeIngreso As ISL.Controles.Agrupacion
    Friend WithEvents gridListaOrden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents rbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents btnEjecutar As ISL.Controles.Boton
    Friend WithEvents cboFiltroMovimiento As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoOrden As ISL.Controles.ComboMaestros
    Friend WithEvents txtNSalida As ISL.Controles.Texto
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents cboMovimientoInventario As ISL.Controles.ComboMaestros
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridOrdenMovimientos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents odMov As ISL.Controles.OrigenDatos
    Friend WithEvents tEjecutar As System.Windows.Forms.ToolTip
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridOrdenMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarMateriales As ISL.Controles.Boton
    Friend WithEvents txtBuscarMateriales As ISL.Controles.Texto
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents decTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresTerminada As ISL.Controles.Colores
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents EjecutarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents gbDocAsociar As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents cboTipoDoc As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents btnBuscarOrdenes As ISL.Controles.Boton
    Friend WithEvents GriAsocDoc As ISL.Controles.Grilla
    Friend WithEvents griListaDoc As ISL.Controles.Grilla
    Friend WithEvents rfOrdenSalidaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfOrdenSalidaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaOrden As System.Windows.Forms.DateTimePicker
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnRectificar As ISL.Controles.Boton
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbOI As ISL.Controles.Agrupacion
    Friend WithEvents gbDatosAdicionales As ISL.Controles.Agrupacion
    Friend WithEvents griListaMateriales As ISL.Controles.Grilla
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class

