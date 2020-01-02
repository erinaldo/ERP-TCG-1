<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Inventario
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
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadInicial")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadIngreso")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadSalida")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadFinal")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorTotal")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMayor")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMin")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMax")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAdm")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Editar", 0)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Inventario))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "ValorTotal", 12, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "ValorTotal", 12, True)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "PrecioTotal", 14, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "PrecioTotal", 14, True)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadInicial")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadIngreso")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadSalida")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadFinal")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorUnitario")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorTotal")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMayor")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMin")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMax")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorAdm")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdInventario")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdInventario")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorUnitario")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPrincipal")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrifo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccion")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPrincipal")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMovimiento")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Salida")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotal")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMarca")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreModelo")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Especificaciones")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRegistroInventario")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMarca")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreModelo")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Especificaciones")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantIngreso")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoIngreso")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorIngreso")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantSalida")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoSalida")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorSalida")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantSaldo")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoSaldo")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorSaldo")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Ingresos", 568317407)
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Salidas", 568317408)
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Existencias", 568317409)
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMovimiento")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantIngreso")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoIngreso")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorIngreso")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantSalida")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoSalida")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorSalida")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantSaldo")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoSaldo")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorSaldo")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabSharedControlsPage1_Fill_Panel = New System.Windows.Forms.Panel()
        Me.agrInventario = New ISL.Controles.Agrupacion(Me.components)
        Me.gridInventario = New ISL.Controles.Grilla(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.PEPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventariarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odInventario = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UE_DetInventario = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grDet_Inv = New ISL.Controles.Grilla(Me.components)
        Me.odDetInv = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnInventariar = New Infragistics.Win.Misc.UltraButton()
        Me.gridSubAlmacenes = New ISL.Controles.Grilla(Me.components)
        Me.odSubAlmacen = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gbDatosAdicionales = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.etiStock = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresMinimo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.etifechaAl = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.UE_RegistroInv = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grReg_Inv = New ISL.Controles.Grilla(Me.components)
        Me.mnuRegInv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExtornoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odRegistroInventario = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gb_DetalleAsignacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.gridDetalleAsignacion = New ISL.Controles.Grilla(Me.components)
        Me.odDetalleAsignacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.agrupacionRI = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agr_Valorizado_Det = New ISL.Controles.Agrupacion(Me.components)
        Me.grilla_Valorizado = New ISL.Controles.Grilla(Me.components)
        Me.odValorizado = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.decActual = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.FechaValorizado = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtUniMed = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.decMin = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMax = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiMin = New ISL.Controles.Etiqueta(Me.components)
        Me.etiMax = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMaterial = New ISL.Controles.Texto(Me.components)
        Me.eti_Material = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCentro = New ISL.Controles.Texto(Me.components)
        Me.txtAlmacen = New ISL.Controles.Texto(Me.components)
        Me.eti_TituloValorizado = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraToolbarsDockArea24 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea23 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea22 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea21 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ficInventario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1_Fill_Panel.SuspendLayout()
        CType(Me.agrInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrInventario.SuspendLayout()
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.odInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UE_DetInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UE_DetInventario.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.grDet_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.gridSubAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odSubAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.ColoresMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UE_RegistroInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UE_RegistroInv.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuRegInv.SuspendLayout()
        CType(Me.odRegistroInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_DetalleAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_DetalleAsignacion.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.gridDetalleAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrupacionRI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrupacionRI.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agr_Valorizado_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agr_Valorizado_Det.SuspendLayout()
        CType(Me.grilla_Valorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odValorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.decActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaValorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUniMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabSharedControlsPage1_Fill_Panel)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1272, 636)
        '
        'UltraTabSharedControlsPage1_Fill_Panel
        '
        Me.UltraTabSharedControlsPage1_Fill_Panel.Controls.Add(Me.agrInventario)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Controls.Add(Me.UE_RegistroInv)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraTabSharedControlsPage1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabSharedControlsPage1_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Name = "UltraTabSharedControlsPage1_Fill_Panel"
        Me.UltraTabSharedControlsPage1_Fill_Panel.Size = New System.Drawing.Size(1272, 636)
        Me.UltraTabSharedControlsPage1_Fill_Panel.TabIndex = 0
        '
        'agrInventario
        '
        Me.agrInventario.Controls.Add(Me.gridInventario)
        Me.agrInventario.Controls.Add(Me.UE_DetInventario)
        Me.agrInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrInventario.ForeColor = System.Drawing.Color.Black
        Me.agrInventario.Location = New System.Drawing.Point(0, 162)
        Me.agrInventario.Name = "agrInventario"
        Me.agrInventario.Size = New System.Drawing.Size(1272, 192)
        Me.agrInventario.TabIndex = 1
        Me.agrInventario.Text = "Existencias:"
        Me.agrInventario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridInventario
        '
        Me.gridInventario.ContextMenuStrip = Me.mcDetalle
        Me.gridInventario.DataSource = Me.odInventario
        UltraGridColumn182.Header.VisiblePosition = 5
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 6
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.Fixed = True
        UltraGridColumn184.Header.VisiblePosition = 1
        UltraGridColumn184.Width = 86
        UltraGridColumn185.Header.Fixed = True
        UltraGridColumn185.Header.VisiblePosition = 2
        UltraGridColumn185.Width = 304
        UltraGridColumn186.Header.VisiblePosition = 7
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.Caption = "Unid. Medida"
        UltraGridColumn187.Header.Fixed = True
        UltraGridColumn187.Header.VisiblePosition = 4
        UltraGridColumn187.Width = 85
        UltraGridColumn188.Header.VisiblePosition = 8
        UltraGridColumn188.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn189.CellAppearance = Appearance1
        UltraGridColumn189.Format = "#,##0.0000"
        UltraGridColumn189.Header.Caption = "Cant. Inicial"
        UltraGridColumn189.Header.VisiblePosition = 9
        UltraGridColumn189.MaskInput = "{double:-9.3:c}"
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn190.CellAppearance = Appearance2
        UltraGridColumn190.Format = "#,##0.0000"
        UltraGridColumn190.Header.Caption = "Cant. Ingreso"
        UltraGridColumn190.Header.VisiblePosition = 10
        UltraGridColumn190.MaskInput = "{double:-9.3:c}"
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn191.CellAppearance = Appearance3
        UltraGridColumn191.Format = "#,##0.0000"
        UltraGridColumn191.Header.Caption = "Cant. Salida"
        UltraGridColumn191.Header.VisiblePosition = 11
        UltraGridColumn191.MaskInput = "{double:-9.3:c}"
        Appearance4.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn192.CellAppearance = Appearance4
        UltraGridColumn192.Format = "#,##0.0000"
        UltraGridColumn192.Header.Caption = "Stock"
        UltraGridColumn192.Header.VisiblePosition = 12
        UltraGridColumn192.MaskInput = "{double:-9.3:c}"
        UltraGridColumn192.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn193.CellAppearance = Appearance5
        UltraGridColumn193.Format = "#,##0.0000"
        UltraGridColumn193.Header.Caption = "Costo Unit."
        UltraGridColumn193.Header.VisiblePosition = 13
        UltraGridColumn193.MaskInput = "{double:-9.3:c}"
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn194.CellAppearance = Appearance6
        UltraGridColumn194.Format = "#,##0.0000"
        UltraGridColumn194.Header.Caption = "Costo Total."
        UltraGridColumn194.Header.VisiblePosition = 14
        UltraGridColumn194.MaskInput = "{double:-9.3:c}"
        UltraGridColumn194.Width = 101
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn195.CellAppearance = Appearance7
        UltraGridColumn195.Format = "#,##0.0000"
        UltraGridColumn195.Header.Caption = "Precio Unit."
        UltraGridColumn195.Header.VisiblePosition = 15
        UltraGridColumn195.MaskInput = "{double:-9.3:c}"
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn196.CellAppearance = Appearance8
        UltraGridColumn196.Format = "#,##0.0000"
        UltraGridColumn196.Header.Caption = "Precio Total"
        UltraGridColumn196.Header.VisiblePosition = 16
        UltraGridColumn196.MaskInput = "{double:-9.3:c}"
        UltraGridColumn197.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn197.CellAppearance = Appearance9
        UltraGridColumn197.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn197.Header.Caption = "Actualizado Al"
        UltraGridColumn197.Header.VisiblePosition = 18
        UltraGridColumn198.Header.VisiblePosition = 19
        UltraGridColumn198.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn199.CellAppearance = Appearance10
        UltraGridColumn199.Header.Caption = "Stock Min."
        UltraGridColumn199.Header.VisiblePosition = 20
        UltraGridColumn199.Hidden = True
        UltraGridColumn199.MaskInput = "{double:-9.3:c}"
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn200.CellAppearance = Appearance11
        UltraGridColumn200.Header.Caption = "Stock Max."
        UltraGridColumn200.Header.VisiblePosition = 21
        UltraGridColumn200.Hidden = True
        UltraGridColumn200.MaskInput = "{double:-9.3:c}"
        UltraGridColumn201.Header.VisiblePosition = 22
        UltraGridColumn201.Width = 75
        UltraGridColumn202.Header.Fixed = True
        UltraGridColumn202.Header.VisiblePosition = 3
        UltraGridColumn202.Width = 68
        UltraGridColumn203.Header.VisiblePosition = 25
        UltraGridColumn203.Width = 159
        UltraGridColumn204.Header.VisiblePosition = 23
        UltraGridColumn204.Width = 293
        UltraGridColumn205.Header.VisiblePosition = 24
        UltraGridColumn205.Width = 265
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn1.CellAppearance = Appearance12
        UltraGridColumn1.Format = "#,##0.0000"
        UltraGridColumn1.Header.VisiblePosition = 17
        UltraGridColumn1.MaskInput = "{double:-9.3:c}"
        UltraGridColumn1.Width = 90
        UltraGridColumn2.Header.VisiblePosition = 26
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 27
        UltraGridColumn3.Hidden = True
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        Appearance13.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn206.CellAppearance = Appearance13
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn206.CellButtonAppearance = Appearance14
        UltraGridColumn206.Header.Caption = "Rect."
        UltraGridColumn206.Header.Fixed = True
        UltraGridColumn206.Header.VisiblePosition = 0
        UltraGridColumn206.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn206.Width = 33
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn206})
        Appearance15.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance15
        SummarySettings1.DisplayFormat = "{0:#,##0.00}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance16
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top
        Appearance17.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance17
        SummarySettings2.DisplayFormat = "{0:#,##0.00}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance18
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.gridInventario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridInventario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridInventario.DisplayLayout.MaxColScrollRegions = 1
        Me.gridInventario.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridInventario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridInventario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridInventario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridInventario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridInventario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridInventario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridInventario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridInventario.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.gridInventario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridInventario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridInventario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridInventario.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridInventario.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridInventario.DisplayLayout.UseFixedHeaders = True
        Me.gridInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridInventario.Location = New System.Drawing.Point(3, 17)
        Me.gridInventario.Name = "gridInventario"
        Me.gridInventario.Size = New System.Drawing.Size(1244, 172)
        Me.gridInventario.TabIndex = 0
        Me.gridInventario.TabStop = False
        Me.gridInventario.Text = "Stock de Materiales"
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEPSToolStripMenuItem, Me.PPToolStripMenuItem, Me.InventariarToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(141, 70)
        '
        'PEPSToolStripMenuItem
        '
        Me.PEPSToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.lupa
        Me.PEPSToolStripMenuItem.Name = "PEPSToolStripMenuItem"
        Me.PEPSToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PEPSToolStripMenuItem.Text = "Mostrar PEPS"
        Me.PEPSToolStripMenuItem.ToolTipText = "Valorizado PEPS"
        Me.PEPSToolStripMenuItem.Visible = False
        '
        'PPToolStripMenuItem
        '
        Me.PPToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.lupa
        Me.PPToolStripMenuItem.Name = "PPToolStripMenuItem"
        Me.PPToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PPToolStripMenuItem.Text = "Mostrar PP"
        Me.PPToolStripMenuItem.ToolTipText = "Valorizado Promedio Ponderado"
        '
        'InventariarToolStripMenuItem
        '
        Me.InventariarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.InventariarToolStripMenuItem.Name = "InventariarToolStripMenuItem"
        Me.InventariarToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.InventariarToolStripMenuItem.Text = "Inventariar"
        '
        'odInventario
        '
        Me.odInventario.AllowAdd = False
        Me.odInventario.AllowDelete = False
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        Me.odInventario.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UE_DetInventario
        '
        Me.UE_DetInventario.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UE_DetInventario.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UE_DetInventario.Dock = System.Windows.Forms.DockStyle.Right
        Me.UE_DetInventario.Expanded = False
        Me.UE_DetInventario.ExpandedSize = New System.Drawing.Size(327, 172)
        Me.UE_DetInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UE_DetInventario.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UE_DetInventario.Location = New System.Drawing.Point(1247, 17)
        Me.UE_DetInventario.Name = "UE_DetInventario"
        Me.UE_DetInventario.Size = New System.Drawing.Size(22, 172)
        Me.UE_DetInventario.TabIndex = 1
        Me.UE_DetInventario.TabStop = False
        Me.UE_DetInventario.Text = "Detalle de Inventario"
        Me.UE_DetInventario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grDet_Inv)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(645, 410)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'grDet_Inv
        '
        Me.grDet_Inv.DataSource = Me.odDetInv
        UltraGridColumn207.Header.VisiblePosition = 0
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 1
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 2
        UltraGridColumn209.Hidden = True
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn210.CellAppearance = Appearance19
        UltraGridColumn210.Header.VisiblePosition = 4
        UltraGridColumn210.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn210.Width = 92
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn211.CellAppearance = Appearance20
        UltraGridColumn211.Header.VisiblePosition = 5
        UltraGridColumn211.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn211.Width = 90
        UltraGridColumn212.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn212.CellAppearance = Appearance21
        UltraGridColumn212.Header.VisiblePosition = 3
        UltraGridColumn212.Width = 73
        UltraGridColumn213.Header.VisiblePosition = 6
        UltraGridColumn213.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213})
        Me.grDet_Inv.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grDet_Inv.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grDet_Inv.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grDet_Inv.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grDet_Inv.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grDet_Inv.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grDet_Inv.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grDet_Inv.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grDet_Inv.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grDet_Inv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grDet_Inv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grDet_Inv.Location = New System.Drawing.Point(0, 0)
        Me.grDet_Inv.Name = "grDet_Inv"
        Me.grDet_Inv.Size = New System.Drawing.Size(645, 410)
        Me.grDet_Inv.TabIndex = 7
        Me.grDet_Inv.TabStop = False
        '
        'odDetInv
        '
        Me.odDetInv.AllowAdd = False
        Me.odDetInv.AllowDelete = False
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn31.DefaultValue = 0R
        UltraDataColumn32.DataType = GetType(Double)
        UltraDataColumn32.DefaultValue = 0R
        UltraDataColumn33.DataType = GetType(Date)
        Me.odDetInv.Band.Columns.AddRange(New Object() {UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34})
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1272, 162)
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1272, 162)
        Me.UltraExpandableGroupBox1.TabIndex = 0
        Me.UltraExpandableGroupBox1.TabStop = False
        Me.UltraExpandableGroupBox1.Text = "Busquedad:"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.btnInventariar)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.gridSubAlmacenes)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.gbDatosAdicionales)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(1266, 139)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'Etiqueta8
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance22
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(385, -1)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta8.TabIndex = 1
        Me.Etiqueta8.Text = "SubAlmacen:"
        '
        'btnInventariar
        '
        Appearance23.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.btnInventariar.Appearance = Appearance23
        Me.btnInventariar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventariar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnInventariar.Location = New System.Drawing.Point(1199, 13)
        Me.btnInventariar.Name = "btnInventariar"
        Me.btnInventariar.Size = New System.Drawing.Size(93, 26)
        Me.btnInventariar.TabIndex = 3
        Me.btnInventariar.Text = "Inventariar"
        Me.btnInventariar.Visible = False
        '
        'gridSubAlmacenes
        '
        Me.gridSubAlmacenes.DataSource = Me.odSubAlmacen
        UltraGridColumn214.Header.VisiblePosition = 0
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 1
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 2
        UltraGridColumn216.Width = 76
        UltraGridColumn217.Header.VisiblePosition = 3
        UltraGridColumn217.Width = 372
        UltraGridColumn218.Header.VisiblePosition = 4
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 11
        UltraGridColumn219.Hidden = True
        UltraGridColumn220.Header.VisiblePosition = 5
        UltraGridColumn220.Width = 299
        UltraGridColumn221.Header.VisiblePosition = 6
        UltraGridColumn221.Hidden = True
        UltraGridColumn222.Header.VisiblePosition = 7
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 8
        UltraGridColumn223.Hidden = True
        UltraGridColumn224.Header.VisiblePosition = 9
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 10
        UltraGridColumn225.Hidden = True
        UltraGridColumn226.Header.VisiblePosition = 12
        UltraGridColumn226.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226})
        Me.gridSubAlmacenes.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridSubAlmacenes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridSubAlmacenes.DisplayLayout.MaxColScrollRegions = 1
        Me.gridSubAlmacenes.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridSubAlmacenes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridSubAlmacenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridSubAlmacenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridSubAlmacenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridSubAlmacenes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridSubAlmacenes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridSubAlmacenes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridSubAlmacenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridSubAlmacenes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridSubAlmacenes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridSubAlmacenes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridSubAlmacenes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSubAlmacenes.Location = New System.Drawing.Point(385, 14)
        Me.gridSubAlmacenes.Name = "gridSubAlmacenes"
        Me.gridSubAlmacenes.Size = New System.Drawing.Size(808, 121)
        Me.gridSubAlmacenes.TabIndex = 2
        Me.gridSubAlmacenes.TabStop = False
        Me.gridSubAlmacenes.Text = "Listado de Sub Almacenes"
        '
        'odSubAlmacen
        '
        Me.odSubAlmacen.AllowAdd = False
        Me.odSubAlmacen.AllowDelete = False
        UltraDataColumn36.DataType = GetType(Boolean)
        UltraDataColumn44.DataType = GetType(Boolean)
        Me.odSubAlmacen.Band.Columns.AddRange(New Object() {UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47})
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbDatosAdicionales.Controls.Add(Me.CheckBox2)
        Me.gbDatosAdicionales.Controls.Add(Me.CheckBox1)
        Me.gbDatosAdicionales.Controls.Add(Me.Fecha)
        Me.gbDatosAdicionales.Controls.Add(Me.etiStock)
        Me.gbDatosAdicionales.Controls.Add(Me.ColoresMinimo)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta13)
        Me.gbDatosAdicionales.Controls.Add(Me.etifechaAl)
        Me.gbDatosAdicionales.Controls.Add(Me.cboAlmacen)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.gbDatosAdicionales.Controls.Add(Me.cboCentro)
        Me.gbDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(379, 139)
        Me.gbDatosAdicionales.TabIndex = 0
        Me.gbDatosAdicionales.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox2.Location = New System.Drawing.Point(200, 106)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Stock Mayor a 0"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.Navy
        Me.CheckBox1.Location = New System.Drawing.Point(200, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Solo Activos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha.Location = New System.Drawing.Point(68, 69)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(94, 21)
        Me.Fecha.TabIndex = 5
        '
        'etiStock
        '
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.etiStock.Appearance = Appearance24
        Me.etiStock.AutoSize = True
        Me.etiStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiStock.ForeColor = System.Drawing.Color.Black
        Me.etiStock.Location = New System.Drawing.Point(15, 107)
        Me.etiStock.Name = "etiStock"
        Me.etiStock.Size = New System.Drawing.Size(128, 15)
        Me.etiStock.TabIndex = 7
        Me.etiStock.Text = "Debajo del Stock Mínimo"
        '
        'ColoresMinimo
        '
        Me.ColoresMinimo.Location = New System.Drawing.Point(146, 103)
        Me.ColoresMinimo.Name = "ColoresMinimo"
        Me.ColoresMinimo.Size = New System.Drawing.Size(46, 22)
        Me.ColoresMinimo.TabIndex = 8
        Me.ColoresMinimo.Text = "Control"
        '
        'Etiqueta13
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance25
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(15, 46)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta13.TabIndex = 2
        Me.Etiqueta13.Text = "Almacen"
        '
        'etifechaAl
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.etifechaAl.Appearance = Appearance26
        Me.etifechaAl.AutoSize = True
        Me.etifechaAl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etifechaAl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etifechaAl.Location = New System.Drawing.Point(48, 73)
        Me.etifechaAl.Name = "etifechaAl"
        Me.etifechaAl.Size = New System.Drawing.Size(14, 15)
        Me.etifechaAl.TabIndex = 4
        Me.etifechaAl.Text = "Al"
        '
        'cboAlmacen
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Appearance = Appearance27
        Me.cboAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacen.DropDownListWidth = 280
        Me.cboAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Location = New System.Drawing.Point(68, 42)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(300, 22)
        Me.cboAlmacen.TabIndex = 3
        Me.cboAlmacen.ValueMember = "Id"
        '
        'Etiqueta5
        '
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance28
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(25, 19)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Centro"
        '
        'cboCentro
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance29
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownListWidth = 180
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(68, 15)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(300, 22)
        Me.cboCentro.TabIndex = 1
        Me.cboCentro.ValueMember = "Id"
        '
        'UE_RegistroInv
        '
        Me.UE_RegistroInv.AllowDrop = True
        Me.UE_RegistroInv.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UE_RegistroInv.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UE_RegistroInv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UE_RegistroInv.ExpandedSize = New System.Drawing.Size(1272, 282)
        Me.UE_RegistroInv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UE_RegistroInv.Location = New System.Drawing.Point(0, 354)
        Me.UE_RegistroInv.Name = "UE_RegistroInv"
        Me.UE_RegistroInv.Size = New System.Drawing.Size(1272, 282)
        Me.UE_RegistroInv.TabIndex = 2
        Me.UE_RegistroInv.TabStop = False
        Me.UE_RegistroInv.Text = "Kardex"
        Me.UE_RegistroInv.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.grReg_Inv)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.gb_DetalleAsignacion)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.agrupacionRI)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1266, 259)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'grReg_Inv
        '
        Me.grReg_Inv.ContextMenuStrip = Me.mnuRegInv
        Me.grReg_Inv.DataSource = Me.odRegistroInventario
        UltraGridColumn227.Header.VisiblePosition = 0
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.Caption = "N° Movimiento"
        UltraGridColumn228.Header.VisiblePosition = 2
        UltraGridColumn229.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn229.Header.VisiblePosition = 1
        UltraGridColumn229.Width = 120
        UltraGridColumn230.Header.Caption = "Tipo Mov."
        UltraGridColumn230.Header.VisiblePosition = 3
        UltraGridColumn230.Width = 85
        UltraGridColumn231.Header.VisiblePosition = 4
        UltraGridColumn231.Width = 306
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn232.CellAppearance = Appearance30
        UltraGridColumn232.Format = "#,##0.0000"
        UltraGridColumn232.Header.VisiblePosition = 5
        UltraGridColumn232.Width = 88
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn233.CellAppearance = Appearance31
        UltraGridColumn233.Format = "#,##0.0000"
        UltraGridColumn233.Header.VisiblePosition = 6
        UltraGridColumn233.Width = 87
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn234.CellAppearance = Appearance32
        UltraGridColumn234.Format = "#,##0.0000"
        UltraGridColumn234.Header.Caption = "Costo Unit."
        UltraGridColumn234.Header.VisiblePosition = 7
        UltraGridColumn234.Width = 82
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn235.CellAppearance = Appearance33
        UltraGridColumn235.Format = "#,##0.0000"
        UltraGridColumn235.Header.Caption = "Costo Total"
        UltraGridColumn235.Header.VisiblePosition = 8
        UltraGridColumn235.Width = 83
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn236.CellAppearance = Appearance34
        UltraGridColumn236.Format = "#,##0.0000"
        UltraGridColumn236.Header.Caption = "Precio Unit."
        UltraGridColumn236.Header.VisiblePosition = 9
        UltraGridColumn236.Width = 90
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn237.CellAppearance = Appearance35
        UltraGridColumn237.Format = "#,##0.0000"
        UltraGridColumn237.Header.Caption = "Precio Total"
        UltraGridColumn237.Header.VisiblePosition = 10
        Appearance36.BackColor = System.Drawing.Color.Khaki
        Appearance36.Image = CType(resources.GetObject("Appearance36.Image"), Object)
        UltraGridColumn238.CellAppearance = Appearance36
        UltraGridColumn238.Header.Caption = "N° Orden"
        UltraGridColumn238.Header.VisiblePosition = 13
        UltraGridColumn238.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn238.Width = 145
        UltraGridColumn239.Header.VisiblePosition = 14
        UltraGridColumn240.Header.VisiblePosition = 15
        UltraGridColumn240.Width = 214
        UltraGridColumn241.Header.VisiblePosition = 16
        UltraGridColumn242.Header.VisiblePosition = 17
        UltraGridColumn242.Hidden = True
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn243.CellAppearance = Appearance37
        UltraGridColumn243.Header.VisiblePosition = 12
        UltraGridColumn243.Hidden = True
        UltraGridColumn244.Header.Caption = "Tipo Documento"
        UltraGridColumn244.Header.VisiblePosition = 18
        UltraGridColumn245.Header.Caption = "N° Documento"
        UltraGridColumn245.Header.VisiblePosition = 19
        UltraGridColumn245.Width = 113
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn246.CellAppearance = Appearance38
        UltraGridColumn246.Format = "#,##0.0000"
        UltraGridColumn246.Header.VisiblePosition = 11
        UltraGridColumn246.MaskInput = ""
        UltraGridColumn246.Width = 89
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246})
        Me.grReg_Inv.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grReg_Inv.DisplayLayout.MaxColScrollRegions = 1
        Me.grReg_Inv.DisplayLayout.MaxRowScrollRegions = 1
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
        Me.grReg_Inv.Location = New System.Drawing.Point(0, 30)
        Me.grReg_Inv.Name = "grReg_Inv"
        Me.grReg_Inv.Size = New System.Drawing.Size(1244, 229)
        Me.grReg_Inv.TabIndex = 1
        '
        'mnuRegInv
        '
        Me.mnuRegInv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtornoToolStripMenuItem, Me.AsientoToolStripMenuItem})
        Me.mnuRegInv.Name = "menuExtorno"
        Me.mnuRegInv.Size = New System.Drawing.Size(116, 48)
        '
        'ExtornoToolStripMenuItem
        '
        Me.ExtornoToolStripMenuItem.Enabled = False
        Me.ExtornoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.ExtornoToolStripMenuItem.Name = "ExtornoToolStripMenuItem"
        Me.ExtornoToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExtornoToolStripMenuItem.Text = "Extorno"
        '
        'AsientoToolStripMenuItem
        '
        Me.AsientoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.AsientoToolStripMenuItem.Name = "AsientoToolStripMenuItem"
        Me.AsientoToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AsientoToolStripMenuItem.Text = "Asiento"
        '
        'odRegistroInventario
        '
        Me.odRegistroInventario.AllowAdd = False
        Me.odRegistroInventario.AllowDelete = False
        UltraDataColumn53.DataType = GetType(Double)
        UltraDataColumn54.DataType = GetType(Double)
        UltraDataColumn55.DataType = GetType(Double)
        UltraDataColumn56.DataType = GetType(Double)
        UltraDataColumn57.DataType = GetType(Double)
        UltraDataColumn58.DataType = GetType(Double)
        UltraDataColumn67.DataType = GetType(Double)
        Me.odRegistroInventario.Band.Columns.AddRange(New Object() {UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67})
        '
        'gb_DetalleAsignacion
        '
        Me.gb_DetalleAsignacion.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gb_DetalleAsignacion.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.gb_DetalleAsignacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.gb_DetalleAsignacion.Expanded = False
        Me.gb_DetalleAsignacion.ExpandedSize = New System.Drawing.Size(632, 229)
        Me.gb_DetalleAsignacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_DetalleAsignacion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gb_DetalleAsignacion.Location = New System.Drawing.Point(1244, 30)
        Me.gb_DetalleAsignacion.Name = "gb_DetalleAsignacion"
        Me.gb_DetalleAsignacion.Size = New System.Drawing.Size(22, 229)
        Me.gb_DetalleAsignacion.TabIndex = 2
        Me.gb_DetalleAsignacion.TabStop = False
        Me.gb_DetalleAsignacion.Text = "Detalle de Asignacion"
        Me.gb_DetalleAsignacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.gb_DetalleAsignacion.Visible = False
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.gridDetalleAsignacion)
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(591, 209)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel3.Visible = False
        '
        'gridDetalleAsignacion
        '
        Me.gridDetalleAsignacion.DataSource = Me.odDetalleAsignacion
        UltraGridColumn247.Header.VisiblePosition = 0
        UltraGridColumn247.Hidden = True
        UltraGridColumn248.Header.VisiblePosition = 1
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 2
        UltraGridColumn249.Hidden = True
        UltraGridColumn250.Header.VisiblePosition = 3
        UltraGridColumn250.Width = 128
        UltraGridColumn251.Header.VisiblePosition = 4
        UltraGridColumn251.Hidden = True
        UltraGridColumn252.Header.VisiblePosition = 5
        UltraGridColumn252.Width = 120
        UltraGridColumn253.Header.VisiblePosition = 6
        UltraGridColumn253.Hidden = True
        UltraGridColumn254.Header.VisiblePosition = 7
        UltraGridColumn254.Width = 109
        UltraGridColumn255.Header.VisiblePosition = 8
        UltraGridColumn255.Width = 102
        UltraGridColumn256.Header.VisiblePosition = 9
        UltraGridColumn256.Width = 112
        UltraGridColumn257.Header.VisiblePosition = 10
        UltraGridColumn257.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257})
        Me.gridDetalleAsignacion.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.gridDetalleAsignacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDetalleAsignacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDetalleAsignacion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDetalleAsignacion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDetalleAsignacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDetalleAsignacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDetalleAsignacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDetalleAsignacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDetalleAsignacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDetalleAsignacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridDetalleAsignacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleAsignacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetalleAsignacion.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetalleAsignacion.Location = New System.Drawing.Point(0, 0)
        Me.gridDetalleAsignacion.Name = "gridDetalleAsignacion"
        Me.gridDetalleAsignacion.Size = New System.Drawing.Size(591, 209)
        Me.gridDetalleAsignacion.TabIndex = 7
        Me.gridDetalleAsignacion.TabStop = False
        '
        'odDetalleAsignacion
        '
        Me.odDetalleAsignacion.AllowAdd = False
        Me.odDetalleAsignacion.AllowDelete = False
        Me.odDetalleAsignacion.Band.Columns.AddRange(New Object() {UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78})
        '
        'agrupacionRI
        '
        Me.agrupacionRI.Controls.Add(Me.UltraButton1)
        Me.agrupacionRI.Controls.Add(Me.fecha_desde)
        Me.agrupacionRI.Controls.Add(Me.btnConsultar)
        Me.agrupacionRI.Controls.Add(Me.Etiqueta7)
        Me.agrupacionRI.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrupacionRI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrupacionRI.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrupacionRI.Location = New System.Drawing.Point(0, 0)
        Me.agrupacionRI.Name = "agrupacionRI"
        Me.agrupacionRI.Size = New System.Drawing.Size(1266, 30)
        Me.agrupacionRI.TabIndex = 0
        Me.agrupacionRI.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButton1
        '
        Appearance39.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.UltraButton1.Appearance = Appearance39
        Me.UltraButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.UltraButton1.Location = New System.Drawing.Point(263, 4)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(113, 23)
        Me.UltraButton1.TabIndex = 3
        Me.UltraButton1.Text = "Exportar"
        '
        'fecha_desde
        '
        Me.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_desde.Location = New System.Drawing.Point(49, 5)
        Me.fecha_desde.Name = "fecha_desde"
        Me.fecha_desde.Size = New System.Drawing.Size(80, 21)
        Me.fecha_desde.TabIndex = 1
        '
        'btnConsultar
        '
        Appearance40.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultar.Appearance = Appearance40
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultar.Location = New System.Drawing.Point(144, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(113, 23)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        '
        'Etiqueta7
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance41
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(7, 8)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta7.TabIndex = 0
        Me.Etiqueta7.Text = "Desde"
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 636)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1272, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 636)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1272, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 636)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1272, 0)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agr_Valorizado_Det)
        Me.UltraTabPageControl2.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1272, 636)
        '
        'Agr_Valorizado_Det
        '
        Me.Agr_Valorizado_Det.Controls.Add(Me.grilla_Valorizado)
        Me.Agr_Valorizado_Det.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agr_Valorizado_Det.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agr_Valorizado_Det.ForeColor = System.Drawing.Color.Black
        Me.Agr_Valorizado_Det.Location = New System.Drawing.Point(0, 102)
        Me.Agr_Valorizado_Det.Name = "Agr_Valorizado_Det"
        Me.Agr_Valorizado_Det.Size = New System.Drawing.Size(1272, 534)
        Me.Agr_Valorizado_Det.TabIndex = 1
        Me.Agr_Valorizado_Det.Text = "Tabla "
        Me.Agr_Valorizado_Det.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grilla_Valorizado
        '
        Me.grilla_Valorizado.DataSource = Me.odValorizado
        UltraGridColumn258.Header.VisiblePosition = 0
        UltraGridColumn258.Hidden = True
        Appearance42.TextHAlignAsString = "Center"
        Appearance42.TextVAlignAsString = "Middle"
        UltraGridColumn259.CellAppearance = Appearance42
        UltraGridColumn259.Header.Caption = "N° Movimiento"
        UltraGridColumn259.Header.VisiblePosition = 1
        UltraGridColumn259.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn259.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn259.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn259.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn259.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn259.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn259.RowLayoutColumnInfo.SpanY = 6
        UltraGridColumn260.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance43.TextHAlignAsString = "Left"
        Appearance43.TextVAlignAsString = "Middle"
        UltraGridColumn260.CellAppearance = Appearance43
        UltraGridColumn260.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn260.Header.VisiblePosition = 2
        UltraGridColumn260.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        UltraGridColumn260.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn260.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn260.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 20)
        UltraGridColumn260.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn260.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn260.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn260.Width = 91
        Appearance44.TextVAlignAsString = "Middle"
        UltraGridColumn261.CellAppearance = Appearance44
        UltraGridColumn261.Header.Caption = "Tipo Movimiento"
        UltraGridColumn261.Header.VisiblePosition = 3
        UltraGridColumn261.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn261.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn261.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(129, 20)
        UltraGridColumn261.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn261.RowLayoutColumnInfo.SpanX = 1
        UltraGridColumn261.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn261.Width = 116
        UltraGridColumn262.Header.VisiblePosition = 4
        UltraGridColumn262.RowLayoutColumnInfo.OriginX = 5
        UltraGridColumn262.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn262.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(296, 20)
        UltraGridColumn262.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn262.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn262.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn262.Width = 210
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn263.CellAppearance = Appearance45
        UltraGridColumn263.Header.Caption = "Cantidad"
        UltraGridColumn263.Header.VisiblePosition = 5
        UltraGridColumn263.MaskInput = "{double:-9.2:c}"
        UltraGridColumn263.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn263.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn263.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn263.RowLayoutColumnInfo.ParentGroupKey = "Ingresos"
        UltraGridColumn263.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 20)
        UltraGridColumn263.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn263.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn263.Width = 88
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn264.CellAppearance = Appearance46
        UltraGridColumn264.Header.Caption = "Costo"
        UltraGridColumn264.Header.VisiblePosition = 6
        UltraGridColumn264.MaskInput = "{double:-9.2:c}"
        UltraGridColumn264.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn264.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn264.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn264.RowLayoutColumnInfo.ParentGroupKey = "Ingresos"
        UltraGridColumn264.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 20)
        UltraGridColumn264.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn264.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn264.Width = 85
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn265.CellAppearance = Appearance47
        UltraGridColumn265.Header.Caption = "Valor"
        UltraGridColumn265.Header.VisiblePosition = 7
        UltraGridColumn265.MaskInput = "{double:-9.2:c}"
        UltraGridColumn265.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn265.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn265.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn265.RowLayoutColumnInfo.ParentGroupKey = "Ingresos"
        UltraGridColumn265.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 20)
        UltraGridColumn265.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn265.RowLayoutColumnInfo.SpanY = 4
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn266.CellAppearance = Appearance48
        UltraGridColumn266.Header.Caption = "Cantidad"
        UltraGridColumn266.Header.VisiblePosition = 8
        UltraGridColumn266.MaskInput = "{double:-9.2:c}"
        UltraGridColumn266.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn266.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn266.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn266.RowLayoutColumnInfo.ParentGroupKey = "Salidas"
        UltraGridColumn266.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 20)
        UltraGridColumn266.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn266.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn266.Width = 69
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn267.CellAppearance = Appearance49
        UltraGridColumn267.Header.Caption = "Costo"
        UltraGridColumn267.Header.VisiblePosition = 9
        UltraGridColumn267.MaskInput = "{double:-9.2:c}"
        UltraGridColumn267.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn267.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn267.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn267.RowLayoutColumnInfo.ParentGroupKey = "Salidas"
        UltraGridColumn267.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 20)
        UltraGridColumn267.RowLayoutColumnInfo.SpanX = 1
        UltraGridColumn267.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn267.Width = 85
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn268.CellAppearance = Appearance50
        UltraGridColumn268.Header.Caption = "Valor"
        UltraGridColumn268.Header.VisiblePosition = 10
        UltraGridColumn268.MaskInput = "{double:-9.2:c}"
        UltraGridColumn268.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn268.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn268.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn268.RowLayoutColumnInfo.ParentGroupKey = "Salidas"
        UltraGridColumn268.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 20)
        UltraGridColumn268.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn268.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn268.Width = 72
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn269.CellAppearance = Appearance51
        UltraGridColumn269.Header.Caption = "Cantidad"
        UltraGridColumn269.Header.VisiblePosition = 11
        UltraGridColumn269.MaskInput = "{double:-9.2:c}"
        UltraGridColumn269.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn269.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn269.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn269.RowLayoutColumnInfo.ParentGroupKey = "Existencias"
        UltraGridColumn269.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 20)
        UltraGridColumn269.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn269.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn269.Width = 70
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn270.CellAppearance = Appearance52
        UltraGridColumn270.Header.Caption = "Costo"
        UltraGridColumn270.Header.VisiblePosition = 12
        UltraGridColumn270.MaskInput = "{double:-9.2:c}"
        UltraGridColumn270.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn270.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn270.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn270.RowLayoutColumnInfo.ParentGroupKey = "Existencias"
        UltraGridColumn270.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn270.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn270.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn270.Width = 80
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn271.CellAppearance = Appearance53
        UltraGridColumn271.Header.Caption = "Valor"
        UltraGridColumn271.Header.VisiblePosition = 13
        UltraGridColumn271.MaskInput = "{double:-9.2:c}"
        UltraGridColumn271.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn271.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn271.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn271.RowLayoutColumnInfo.ParentGroupKey = "Existencias"
        UltraGridColumn271.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 20)
        UltraGridColumn271.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn271.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn271.Width = 86
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271})
        Appearance54.BackColor = System.Drawing.Color.PowderBlue
        UltraGridGroup1.CellAppearance = Appearance54
        Appearance55.BackColor = System.Drawing.Color.PowderBlue
        Appearance55.ForeColor = System.Drawing.Color.Blue
        UltraGridGroup1.Header.Appearance = Appearance55
        UltraGridGroup1.Key = "Ingresos"
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 7
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 6
        Appearance56.BackColor = System.Drawing.Color.PaleGreen
        UltraGridGroup2.CellAppearance = Appearance56
        Appearance57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        UltraGridGroup2.Header.Appearance = Appearance57
        UltraGridGroup2.Key = "Salidas"
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 13
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 5
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 6
        Appearance58.BackColor = System.Drawing.Color.SandyBrown
        UltraGridGroup3.CellAppearance = Appearance58
        Appearance59.ForeColor = System.Drawing.Color.Maroon
        UltraGridGroup3.Header.Appearance = Appearance59
        UltraGridGroup3.Key = "Existencias"
        UltraGridGroup3.RowLayoutGroupInfo.OriginX = 18
        UltraGridGroup3.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup3.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup3.RowLayoutGroupInfo.SpanY = 6
        UltraGridBand6.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3})
        UltraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.grilla_Valorizado.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grilla_Valorizado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_Valorizado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grilla_Valorizado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grilla_Valorizado.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grilla_Valorizado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grilla_Valorizado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilla_Valorizado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grilla_Valorizado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grilla_Valorizado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_Valorizado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilla_Valorizado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla_Valorizado.Location = New System.Drawing.Point(3, 17)
        Me.grilla_Valorizado.Name = "grilla_Valorizado"
        Me.grilla_Valorizado.Size = New System.Drawing.Size(1266, 514)
        Me.grilla_Valorizado.TabIndex = 0
        '
        'odValorizado
        '
        Me.odValorizado.AllowAdd = False
        Me.odValorizado.AllowDelete = False
        UltraDataColumn81.DataType = GetType(Date)
        Me.odValorizado.Band.Columns.AddRange(New Object() {UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92})
        Me.odValorizado.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object(-1) {})})
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.decActual)
        Me.GroupBox1.Controls.Add(Me.Etiqueta6)
        Me.GroupBox1.Controls.Add(Me.FechaValorizado)
        Me.GroupBox1.Controls.Add(Me.Etiqueta4)
        Me.GroupBox1.Controls.Add(Me.txtUniMed)
        Me.GroupBox1.Controls.Add(Me.Etiqueta3)
        Me.GroupBox1.Controls.Add(Me.decMin)
        Me.GroupBox1.Controls.Add(Me.decMax)
        Me.GroupBox1.Controls.Add(Me.etiMin)
        Me.GroupBox1.Controls.Add(Me.etiMax)
        Me.GroupBox1.Controls.Add(Me.txtMaterial)
        Me.GroupBox1.Controls.Add(Me.eti_Material)
        Me.GroupBox1.Controls.Add(Me.txtCentro)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen)
        Me.GroupBox1.Controls.Add(Me.eti_TituloValorizado)
        Me.GroupBox1.Controls.Add(Me.Etiqueta1)
        Me.GroupBox1.Controls.Add(Me.Etiqueta2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1272, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'decActual
        '
        Appearance60.BackColor = System.Drawing.Color.Khaki
        Appearance60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decActual.Appearance = Appearance60
        Me.decActual.BackColor = System.Drawing.Color.Khaki
        Me.decActual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decActual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decActual.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decActual.Location = New System.Drawing.Point(546, 39)
        Me.decActual.Name = "decActual"
        Me.decActual.NullText = "0.00"
        Me.decActual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decActual.ReadOnly = True
        Me.decActual.Size = New System.Drawing.Size(86, 22)
        Me.decActual.TabIndex = 10
        '
        'Etiqueta6
        '
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance61
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(475, 44)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(65, 15)
        Me.Etiqueta6.TabIndex = 9
        Me.Etiqueta6.Text = "Stock Actual"
        '
        'FechaValorizado
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.FechaValorizado.Appearance = Appearance62
        Me.FechaValorizado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FechaValorizado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaValorizado.ForeColor = System.Drawing.Color.Black
        Me.FechaValorizado.Location = New System.Drawing.Point(55, 19)
        Me.FechaValorizado.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.FechaValorizado.Name = "FechaValorizado"
        Me.FechaValorizado.ReadOnly = True
        Me.FechaValorizado.Size = New System.Drawing.Size(112, 22)
        Me.FechaValorizado.TabIndex = 1
        '
        'Etiqueta4
        '
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance63
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(35, 23)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Al"
        '
        'txtUniMed
        '
        Appearance64.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUniMed.Appearance = Appearance64
        Me.txtUniMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUniMed.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtUniMed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUniMed.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUniMed.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtUniMed.Location = New System.Drawing.Point(546, 67)
        Me.txtUniMed.Name = "txtUniMed"
        Me.txtUniMed.ReadOnly = True
        Me.txtUniMed.Size = New System.Drawing.Size(86, 22)
        Me.txtUniMed.TabIndex = 12
        Me.txtUniMed.Tag = "0"
        '
        'Etiqueta3
        '
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance65
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(474, 71)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta3.TabIndex = 11
        Me.Etiqueta3.Text = "Unidad Med."
        '
        'decMin
        '
        Appearance66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMin.Appearance = Appearance66
        Me.decMin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMin.Location = New System.Drawing.Point(751, 37)
        Me.decMin.Name = "decMin"
        Me.decMin.NullText = "0.00"
        Me.decMin.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMin.ReadOnly = True
        Me.decMin.Size = New System.Drawing.Size(86, 22)
        Me.decMin.TabIndex = 14
        '
        'decMax
        '
        Appearance67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMax.Appearance = Appearance67
        Me.decMax.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMax.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMax.Location = New System.Drawing.Point(751, 64)
        Me.decMax.Name = "decMax"
        Me.decMax.NullText = "0.00"
        Me.decMax.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMax.ReadOnly = True
        Me.decMax.Size = New System.Drawing.Size(86, 22)
        Me.decMax.TabIndex = 16
        '
        'etiMin
        '
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.etiMin.Appearance = Appearance68
        Me.etiMin.AutoSize = True
        Me.etiMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiMin.ForeColor = System.Drawing.Color.Black
        Me.etiMin.Location = New System.Drawing.Point(693, 43)
        Me.etiMin.Name = "etiMin"
        Me.etiMin.Size = New System.Drawing.Size(56, 15)
        Me.etiMin.TabIndex = 13
        Me.etiMin.Text = "Stock Min."
        '
        'etiMax
        '
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.etiMax.Appearance = Appearance69
        Me.etiMax.AutoSize = True
        Me.etiMax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiMax.ForeColor = System.Drawing.Color.Black
        Me.etiMax.Location = New System.Drawing.Point(690, 71)
        Me.etiMax.Name = "etiMax"
        Me.etiMax.Size = New System.Drawing.Size(59, 15)
        Me.etiMax.TabIndex = 15
        Me.etiMax.Text = "Stock Max."
        '
        'txtMaterial
        '
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaterial.Appearance = Appearance70
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaterial.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtMaterial.Location = New System.Drawing.Point(55, 67)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(340, 22)
        Me.txtMaterial.TabIndex = 7
        Me.txtMaterial.Tag = "0"
        '
        'eti_Material
        '
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.eti_Material.Appearance = Appearance71
        Me.eti_Material.AutoSize = True
        Me.eti_Material.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eti_Material.ForeColor = System.Drawing.Color.Black
        Me.eti_Material.Location = New System.Drawing.Point(9, 71)
        Me.eti_Material.Name = "eti_Material"
        Me.eti_Material.Size = New System.Drawing.Size(44, 15)
        Me.eti_Material.TabIndex = 6
        Me.eti_Material.Text = "Material"
        '
        'txtCentro
        '
        Appearance72.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCentro.Appearance = Appearance72
        Me.txtCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCentro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCentro.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCentro.Location = New System.Drawing.Point(227, 19)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.ReadOnly = True
        Me.txtCentro.Size = New System.Drawing.Size(168, 22)
        Me.txtCentro.TabIndex = 3
        Me.txtCentro.Tag = "0"
        '
        'txtAlmacen
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAlmacen.Appearance = Appearance73
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmacen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAlmacen.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtAlmacen.Location = New System.Drawing.Point(55, 43)
        Me.txtAlmacen.MaxLength = 100
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(340, 22)
        Me.txtAlmacen.TabIndex = 5
        Me.txtAlmacen.Tag = "0"
        '
        'eti_TituloValorizado
        '
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.eti_TituloValorizado.Appearance = Appearance74
        Me.eti_TituloValorizado.AutoSize = True
        Me.eti_TituloValorizado.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eti_TituloValorizado.ForeColor = System.Drawing.Color.Black
        Me.eti_TituloValorizado.Location = New System.Drawing.Point(406, 7)
        Me.eti_TituloValorizado.Name = "eti_TituloValorizado"
        Me.eti_TituloValorizado.Size = New System.Drawing.Size(275, 28)
        Me.eti_TituloValorizado.TabIndex = 8
        Me.eti_TituloValorizado.Text = "Método de Valorización : "
        '
        'Etiqueta1
        '
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance75
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(5, 47)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Almacen"
        '
        'Etiqueta2
        '
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance76
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(184, 23)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Centro"
        '
        'UltraToolbarsDockArea24
        '
        Me.UltraToolbarsDockArea24.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea24.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea24.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea24.Location = New System.Drawing.Point(916, 0)
        Me.UltraToolbarsDockArea24.Name = "UltraToolbarsDockArea24"
        Me.UltraToolbarsDockArea24.Size = New System.Drawing.Size(0, 452)
        '
        'UltraToolbarsDockArea23
        '
        Me.UltraToolbarsDockArea23.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea23.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea23.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea23.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea23.Name = "UltraToolbarsDockArea23"
        Me.UltraToolbarsDockArea23.Size = New System.Drawing.Size(0, 452)
        '
        'UltraToolbarsDockArea22
        '
        Me.UltraToolbarsDockArea22.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea22.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea22.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea22.Location = New System.Drawing.Point(0, 452)
        Me.UltraToolbarsDockArea22.Name = "UltraToolbarsDockArea22"
        Me.UltraToolbarsDockArea22.Size = New System.Drawing.Size(916, 0)
        '
        'UltraToolbarsDockArea21
        '
        Me.UltraToolbarsDockArea21.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea21.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea21.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea21.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea21.Name = "UltraToolbarsDockArea21"
        Me.UltraToolbarsDockArea21.Size = New System.Drawing.Size(916, 0)
        '
        'ficInventario
        '
        Me.ficInventario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficInventario.Controls.Add(Me.UltraTabPageControl1)
        Me.ficInventario.Controls.Add(Me.UltraTabPageControl2)
        Me.ficInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficInventario.Location = New System.Drawing.Point(0, 0)
        Me.ficInventario.Name = "ficInventario"
        Me.ficInventario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficInventario.Size = New System.Drawing.Size(1274, 659)
        Me.ficInventario.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Inventario"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Valorización"
        Me.ficInventario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficInventario.TabStop = False
        Me.ficInventario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1272, 636)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(480, 295)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 1
        Me.ugb_Espera.Visible = False
        '
        'frm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 659)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficInventario)
        Me.Name = "frm_Inventario"
        Me.Text = "Inventario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1_Fill_Panel.ResumeLayout(False)
        CType(Me.agrInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrInventario.ResumeLayout(False)
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.odInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UE_DetInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UE_DetInventario.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.grDet_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.gridSubAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odSubAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.ColoresMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UE_RegistroInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UE_RegistroInv.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuRegInv.ResumeLayout(False)
        CType(Me.odRegistroInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_DetalleAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_DetalleAsignacion.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.gridDetalleAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrupacionRI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrupacionRI.ResumeLayout(False)
        Me.agrupacionRI.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agr_Valorizado_Det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agr_Valorizado_Det.ResumeLayout(False)
        CType(Me.grilla_Valorizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odValorizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.decActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaValorizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUniMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficInventario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage1_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ficInventario As ISL.Controles.Ficha
    Friend WithEvents UltraToolbarsDockArea24 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea23 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea22 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea21 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents odInventario As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odSubAlmacen As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odDetInv As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odRegistroInventario As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents gbDatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents etiStock As ISL.Controles.Etiqueta
    Friend WithEvents ColoresMinimo As ISL.Controles.Colores
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents etifechaAl As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents agrInventario As ISL.Controles.Agrupacion
    Friend WithEvents gridInventario As ISL.Controles.Grilla
    Friend WithEvents UE_DetInventario As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grDet_Inv As ISL.Controles.Grilla
    Friend WithEvents UE_RegistroInv As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grReg_Inv As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agr_Valorizado_Det As ISL.Controles.Agrupacion
    Friend WithEvents grilla_Valorizado As ISL.Controles.Grilla
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents odValorizado As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents eti_TituloValorizado As ISL.Controles.Etiqueta
    Friend WithEvents eti_Material As ISL.Controles.Etiqueta
    Friend WithEvents txtCentro As ISL.Controles.Texto
    Friend WithEvents txtAlmacen As ISL.Controles.Texto
    Friend WithEvents txtMaterial As ISL.Controles.Texto
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents PEPSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents etiMin As ISL.Controles.Etiqueta
    Friend WithEvents etiMax As ISL.Controles.Etiqueta
    Friend WithEvents decMin As ISL.Controles.NumeroDecimal
    Friend WithEvents decMax As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents txtUniMed As ISL.Controles.Texto
    Friend WithEvents FechaValorizado As ISL.Controles.Fecha
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decActual As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents btnInventariar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents agrupacionRI As ISL.Controles.Agrupacion
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents InventariarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gb_DetalleAsignacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents gridDetalleAsignacion As ISL.Controles.Grilla
    Friend WithEvents odDetalleAsignacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents gridSubAlmacenes As ISL.Controles.Grilla
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents mnuRegInv As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExtornoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
