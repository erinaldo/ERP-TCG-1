<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenCompraServicio
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
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimiento")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoServicio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Asignado")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaServicio")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimientoServicio")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimientoServicio")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Aprobacion")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOT")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEquipo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimiento")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoServicio")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Asignado")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaServicio")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimientoServicio")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimientoServicio")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Aprobacion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOT")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEquipo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CategoriaServicio")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CategoriaServicio")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenCompraServicio))
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMaterialServicio")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMaterialServicio")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoServicio")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioConImp")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoServicio")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSolesSinImp")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoServicio")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSinImp")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioConImp")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoServicio")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSolesSinImp")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioDolaresSinImp")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pos")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem25 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem26 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
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
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGuia")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorMaterial")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorServicio")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacionEmergencia")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorRechazo")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorDocumentoAsociado")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorVariasEntregas")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrdenCompra")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorConsignacion")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consignacion")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTipoCompra")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCotizacion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Notas", 0)
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGuia")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorMaterial")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorServicio")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacionEmergencia")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorRechazo")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorDocumentoAsociado")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorVariasEntregas")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrdenCompra")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorConsignacion")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consignacion")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorAprobacion")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTipoCompra")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCotizacion")
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
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("GenerarD")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool39 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool40 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("GenerarD")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool41 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Factura")
        Dim ButtonTool42 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Boleta")
        Dim ButtonTool43 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Guía")
        Dim ButtonTool44 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Factura")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool45 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Boleta")
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool46 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Guía")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool48 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool50 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool52 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimiento")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPorAtender")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimientoMaterial")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Aprobacion")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimientoMaterial")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAAtender")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("GenerarD")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("GenerarD")
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Factura")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Boleta")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Guía")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Factura")
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Boleta")
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar Guía")
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaServiciosRequeridos = New ISL.Controles.Grilla(Me.components)
        Me.odRequerimientoServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaServicios = New ISL.Controles.Grilla(Me.components)
        Me.odServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion15 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCategoria = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCategoriaServicios = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griCotizacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odCotizaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListaCoti = New ISL.Controles.Boton(Me.components)
        Me.rfFechaCotHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.rfFechaCotDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaDetalleOrdenCompraServicio = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenCompraServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeListadoServicios = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.utcListadosServicios = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEnviar = New ISL.Controles.Boton(Me.components)
        Me.fecFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.fecFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.fecFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.cmdSolesDolares = New ISL.Controles.Boton(Me.components)
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
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
        Me.chkGenComprobante = New ISL.Controles.Chequear(Me.components)
        Me.agrGenerarComprabante = New ISL.Controles.Agrupacion(Me.components)
        Me.chkCajaChica = New ISL.Controles.Chequear(Me.components)
        Me.udtFechaEmision = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtNroComprabante = New ISL.Controles.Texto(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.txtEstadoDoc = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbTipoDocumento = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkRuc = New ISL.Controles.Chequear(Me.components)
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPorcenIGV = New ISL.Controles.Texto(Me.components)
        Me.cboTipoOrdenCompra = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.cbCentro = New ISL.Controles.Chequear(Me.components)
        Me.chkBloquea = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNotas = New ISL.Controles.Texto(Me.components)
        Me.txtObservaciones = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbNumeroOrden = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumeroOrden = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnEnviarCorreo = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.cheReqAsoc = New ISL.Controles.Chequear(Me.components)
        Me.cheEntregasParciales = New ISL.Controles.Chequear(Me.components)
        Me.cheAutoAprobar = New ISL.Controles.Chequear(Me.components)
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
        Me.btnCambiarEstado = New ISL.Controles.Boton(Me.components)
        Me.btnBloquear = New ISL.Controles.Boton(Me.components)
        Me.btnHistorial = New ISL.Controles.Boton(Me.components)
        Me.btnAtenderOC = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion13 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroOrdenCompra = New ISL.Controles.Texto(Me.components)
        Me.rdbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.rdbNroOrden = New System.Windows.Forms.RadioButton()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkRuc2 = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboProveedorL = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboEstadoOrden = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMonedaL = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresAtendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresTerminado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAtendidoParcialmente = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEvaluado = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFormaBusqueda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuDetalle = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea6 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea7 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea8 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea15 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea16 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea20 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea21 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.FichaTop = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage6 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.odRequerimientos = New ISL.Controles.OrigenDatos(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprobarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuContextualReq = New ISL.Controles.MenuContextual(Me.components)
        Me.RechazarStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ficOrdenCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Menu1 = New ISL.Controles.Menu(Me.components)
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.griListaServiciosRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odRequerimientoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.griListaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion15.SuspendLayout()
        CType(Me.cboCategoriaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.griListaDetalleOrdenCompraServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenCompraServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeListadoServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeListadoServicios.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.utcListadosServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcListadosServicios.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGenComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrGenerarComprabante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGenerarComprabante.SuspendLayout()
        CType(Me.chkCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtFechaEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroComprabante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcenIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBloquea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.cheReqAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheEntregasParciales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheAutoAprobar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Agrupacion13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion13.SuspendLayout()
        CType(Me.txtNroOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.chkRuc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedorL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonedaL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion10.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.FichaTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FichaTop.SuspendLayout()
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.MenuContextualReq.SuspendLayout()
        CType(Me.ficOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrdenCompra.SuspendLayout()
        CType(Me.Menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.griListaServiciosRequeridos)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(689, 126)
        '
        'griListaServiciosRequeridos
        '
        Me.griListaServiciosRequeridos.DataSource = Me.odRequerimientoServicio
        UltraGridColumn214.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn214.Header.Appearance = Appearance1
        UltraGridColumn214.Header.Caption = "Seleccionar"
        UltraGridColumn214.Header.VisiblePosition = 0
        UltraGridColumn214.Width = 54
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn215.Header.Appearance = Appearance2
        UltraGridColumn215.Header.VisiblePosition = 4
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 5
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 7
        UltraGridColumn217.Width = 247
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn218.Header.Appearance = Appearance3
        UltraGridColumn218.Header.Caption = "Centro de costo"
        UltraGridColumn218.Header.VisiblePosition = 10
        UltraGridColumn218.Hidden = True
        UltraGridColumn218.Width = 251
        UltraGridColumn219.Header.Caption = "Centro de costo"
        UltraGridColumn219.Header.VisiblePosition = 16
        UltraGridColumn219.Hidden = True
        Appearance4.BackColor = System.Drawing.Color.White
        UltraGridColumn220.CellAppearance = Appearance4
        UltraGridColumn220.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn220.Header.Appearance = Appearance5
        UltraGridColumn220.Header.VisiblePosition = 8
        UltraGridColumn220.MaskInput = "{double:9.4}"
        UltraGridColumn220.Width = 59
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn221.CellAppearance = Appearance6
        UltraGridColumn221.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn221.Header.Appearance = Appearance7
        UltraGridColumn221.Header.VisiblePosition = 9
        UltraGridColumn221.MaskInput = "{double:9.4}"
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn222.CellAppearance = Appearance8
        UltraGridColumn222.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn222.Header.Appearance = Appearance9
        UltraGridColumn222.Header.VisiblePosition = 11
        UltraGridColumn222.Width = 224
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn223.Header.Appearance = Appearance10
        UltraGridColumn223.Header.VisiblePosition = 13
        UltraGridColumn223.Hidden = True
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn224.Header.Appearance = Appearance11
        UltraGridColumn224.Header.VisiblePosition = 15
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.Caption = "Requerimiento"
        UltraGridColumn225.Header.VisiblePosition = 3
        UltraGridColumn226.Header.Caption = "Codigo"
        UltraGridColumn226.Header.VisiblePosition = 6
        UltraGridColumn226.Hidden = True
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn227.Header.Appearance = Appearance12
        UltraGridColumn227.Header.VisiblePosition = 12
        UltraGridColumn227.Hidden = True
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn228.Header.Appearance = Appearance13
        UltraGridColumn228.Header.VisiblePosition = 14
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.VisiblePosition = 17
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 18
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 19
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 20
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 21
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 22
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.VisiblePosition = 23
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.Header.Caption = "Estado"
        UltraGridColumn236.Header.VisiblePosition = 24
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 25
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.Caption = "N° OT"
        UltraGridColumn238.Header.VisiblePosition = 1
        UltraGridColumn239.Header.Caption = "Equipo"
        UltraGridColumn239.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239})
        Me.griListaServiciosRequeridos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaServiciosRequeridos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.Hidden = True
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServiciosRequeridos.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.griListaServiciosRequeridos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaServiciosRequeridos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaServiciosRequeridos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServiciosRequeridos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServiciosRequeridos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaServiciosRequeridos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaServiciosRequeridos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaServiciosRequeridos.DisplayLayout.Override.CellPadding = 0
        Me.griListaServiciosRequeridos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaServiciosRequeridos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaServiciosRequeridos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaServiciosRequeridos.DisplayLayout.Override.GroupByRowAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Left"
        Me.griListaServiciosRequeridos.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.griListaServiciosRequeridos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaServiciosRequeridos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowAppearance = Appearance19
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaServiciosRequeridos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServiciosRequeridos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaServiciosRequeridos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaServiciosRequeridos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaServiciosRequeridos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaServiciosRequeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaServiciosRequeridos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaServiciosRequeridos.Location = New System.Drawing.Point(0, 0)
        Me.griListaServiciosRequeridos.Name = "griListaServiciosRequeridos"
        Me.griListaServiciosRequeridos.Size = New System.Drawing.Size(689, 126)
        Me.griListaServiciosRequeridos.TabIndex = 0
        Me.griListaServiciosRequeridos.Text = "Grilla2"
        '
        'odRequerimientoServicio
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn19.DataType = GetType(Boolean)
        UltraDataColumn19.DefaultValue = False
        Me.odRequerimientoServicio.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.griListaServicios)
        Me.UltraTabPageControl15.Controls.Add(Me.Agrupacion15)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(689, 126)
        '
        'griListaServicios
        '
        Me.griListaServicios.DataSource = Me.odServicio
        UltraGridColumn240.Header.VisiblePosition = 0
        UltraGridColumn240.Hidden = True
        UltraGridColumn241.Header.VisiblePosition = 2
        UltraGridColumn241.Width = 83
        UltraGridColumn242.Header.VisiblePosition = 4
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.Caption = "Categoría"
        UltraGridColumn243.Header.VisiblePosition = 5
        UltraGridColumn243.Width = 127
        UltraGridColumn244.Header.VisiblePosition = 3
        UltraGridColumn244.Width = 226
        UltraGridColumn245.Header.VisiblePosition = 6
        UltraGridColumn246.Header.VisiblePosition = 7
        UltraGridColumn246.Hidden = True
        UltraGridColumn246.Width = 213
        UltraGridColumn247.Header.VisiblePosition = 8
        UltraGridColumn247.Hidden = True
        UltraGridColumn248.Header.VisiblePosition = 9
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn249.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn249.Header.VisiblePosition = 1
        UltraGridColumn249.Width = 46
        UltraGridColumn250.Header.VisiblePosition = 10
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.VisiblePosition = 11
        UltraGridColumn251.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251})
        UltraGridBand2.GroupHeadersVisible = False
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaServicios.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaServicios.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaServicios.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaServicios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServicios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServicios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaServicios.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Me.griListaServicios.DisplayLayout.Override.CellAppearance = Appearance20
        Me.griListaServicios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaServicios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaServicios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaServicios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Me.griListaServicios.DisplayLayout.Override.RowAppearance = Appearance21
        Me.griListaServicios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaServicios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaServicios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaServicios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaServicios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaServicios.Location = New System.Drawing.Point(0, 62)
        Me.griListaServicios.Name = "griListaServicios"
        Me.griListaServicios.Size = New System.Drawing.Size(689, 64)
        Me.griListaServicios.TabIndex = 1
        Me.griListaServicios.Tag = ""
        '
        'odServicio
        '
        UltraDataColumn35.DataType = GetType(Boolean)
        UltraDataColumn36.DataType = GetType(Boolean)
        UltraDataColumn36.DefaultValue = False
        Me.odServicio.Band.Columns.AddRange(New Object() {UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38})
        '
        'Agrupacion15
        '
        Me.Agrupacion15.Controls.Add(Me.btnCategoria)
        Me.Agrupacion15.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion15.Controls.Add(Me.cboCategoriaServicios)
        Me.Agrupacion15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion15.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion15.Name = "Agrupacion15"
        Me.Agrupacion15.Size = New System.Drawing.Size(689, 62)
        Me.Agrupacion15.TabIndex = 0
        Me.Agrupacion15.Text = "Agregar servicios:"
        Me.Agrupacion15.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCategoria
        '
        Appearance22.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnCategoria.Appearance = Appearance22
        Me.btnCategoria.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCategoria.ImageList = Me.imagenes
        Me.btnCategoria.Location = New System.Drawing.Point(423, 25)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(30, 28)
        Me.btnCategoria.TabIndex = 2
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
        'Etiqueta8
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance23
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
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCategoriaServicios.Appearance = Appearance24
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
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griCotizacion)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(689, 126)
        '
        'griCotizacion
        '
        Me.griCotizacion.DataSource = Me.odCotizaciones
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 85
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 412
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn26.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 9
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 11
        UltraGridColumn3.Width = 252
        UltraGridColumn4.Header.VisiblePosition = 12
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 13
        UltraGridColumn9.Header.VisiblePosition = 14
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn12.Header.VisiblePosition = 15
        UltraGridColumn12.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn22, UltraGridColumn23, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn9, UltraGridColumn10, UltraGridColumn12})
        Me.griCotizacion.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griCotizacion.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griCotizacion.DisplayLayout.GroupByBox.Hidden = True
        Me.griCotizacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griCotizacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCotizacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCotizacion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCotizacion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.griCotizacion.DisplayLayout.Override.CellAppearance = Appearance25
        Me.griCotizacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCotizacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCotizacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griCotizacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCotizacion.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griCotizacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Me.griCotizacion.DisplayLayout.Override.RowAppearance = Appearance26
        Me.griCotizacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCotizacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCotizacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCotizacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCotizacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCotizacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCotizacion.Location = New System.Drawing.Point(0, 41)
        Me.griCotizacion.Name = "griCotizacion"
        Me.griCotizacion.Size = New System.Drawing.Size(689, 85)
        Me.griCotizacion.TabIndex = 1
        Me.griCotizacion.Tag = ""
        '
        'odCotizaciones
        '
        UltraDataColumn54.DataType = GetType(Double)
        Me.odCotizaciones.Band.Columns.AddRange(New Object() {UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54})
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.btnListaCoti)
        Me.Agrupacion9.Controls.Add(Me.rfFechaCotHasta)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion9.Controls.Add(Me.rfFechaCotDesde)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(689, 41)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListaCoti
        '
        Appearance27.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListaCoti.Appearance = Appearance27
        Me.btnListaCoti.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListaCoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListaCoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaCoti.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListaCoti.ImageList = Me.imagenes
        Me.btnListaCoti.Location = New System.Drawing.Point(268, 6)
        Me.btnListaCoti.Name = "btnListaCoti"
        Me.btnListaCoti.Size = New System.Drawing.Size(30, 28)
        Me.btnListaCoti.TabIndex = 4
        '
        'rfFechaCotHasta
        '
        Me.rfFechaCotHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaCotHasta.Location = New System.Drawing.Point(156, 10)
        Me.rfFechaCotHasta.Name = "rfFechaCotHasta"
        Me.rfFechaCotHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaCotHasta.TabIndex = 3
        '
        'Etiqueta3
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance28
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(137, 13)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(17, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Al:"
        '
        'rfFechaCotDesde
        '
        Me.rfFechaCotDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaCotDesde.Location = New System.Drawing.Point(34, 10)
        Me.rfFechaCotDesde.Name = "rfFechaCotDesde"
        Me.rfFechaCotDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaCotDesde.TabIndex = 1
        '
        'Etiqueta4
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance29
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(6, 13)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(24, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Del:"
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.Agrupacion8)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1214, 159)
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.griListaDetalleOrdenCompraServicio)
        Me.Agrupacion8.Controls.Add(Me.gbeListadoServicios)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(1214, 159)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaDetalleOrdenCompraServicio
        '
        Me.griListaDetalleOrdenCompraServicio.DataSource = Me.odOrdenCompraServicio
        UltraGridColumn252.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn252.Header.VisiblePosition = 0
        UltraGridColumn252.Width = 49
        UltraGridColumn253.Header.VisiblePosition = 1
        UltraGridColumn253.Hidden = True
        UltraGridColumn254.Header.VisiblePosition = 2
        UltraGridColumn254.Hidden = True
        UltraGridColumn255.Header.VisiblePosition = 3
        UltraGridColumn255.Hidden = True
        UltraGridColumn256.Header.Caption = "Codigo"
        UltraGridColumn256.Header.VisiblePosition = 4
        UltraGridColumn257.Header.VisiblePosition = 5
        UltraGridColumn257.Width = 311
        UltraGridColumn258.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn258.CellAppearance = Appearance30
        UltraGridColumn258.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn258.Header.VisiblePosition = 6
        UltraGridColumn258.MaskInput = "nnn"
        UltraGridColumn258.Width = 61
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn259.CellAppearance = Appearance31
        UltraGridColumn259.Format = "#,###,###,##0.0000"
        UltraGridColumn259.Header.Caption = "PU S/Imp"
        UltraGridColumn259.Header.VisiblePosition = 7
        UltraGridColumn259.MaskInput = "{double:9.4}"
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn260.CellAppearance = Appearance32
        UltraGridColumn260.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn260.Format = "#,###,###,##0.0000"
        UltraGridColumn260.Header.Caption = "PU C/Imp"
        UltraGridColumn260.Header.VisiblePosition = 9
        UltraGridColumn260.MaskInput = "{double:9.4}"
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn261.CellAppearance = Appearance33
        UltraGridColumn261.Format = "#,###,###,##0.0000"
        UltraGridColumn261.Header.VisiblePosition = 10
        UltraGridColumn261.MaskInput = "{double:9.4}"
        UltraGridColumn262.Header.Caption = "N° Req."
        UltraGridColumn262.Header.VisiblePosition = 11
        UltraGridColumn263.Header.VisiblePosition = 12
        UltraGridColumn263.Hidden = True
        UltraGridColumn264.Header.VisiblePosition = 13
        UltraGridColumn264.Hidden = True
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn265.CellAppearance = Appearance34
        UltraGridColumn265.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn265.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn265.Header.VisiblePosition = 14
        UltraGridColumn265.Width = 240
        UltraGridColumn266.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn266.Header.Caption = "Igv"
        UltraGridColumn266.Header.VisiblePosition = 8
        UltraGridColumn267.Header.VisiblePosition = 15
        UltraGridColumn267.Hidden = True
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn268.CellAppearance = Appearance35
        UltraGridColumn268.Format = "#,###,###,##0.000"
        UltraGridColumn268.Header.VisiblePosition = 18
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.Header.VisiblePosition = 16
        UltraGridColumn269.Hidden = True
        UltraGridColumn270.Header.VisiblePosition = 17
        UltraGridColumn270.Hidden = True
        UltraGridColumn271.Header.VisiblePosition = 19
        UltraGridColumn271.Hidden = True
        UltraGridColumn272.Header.VisiblePosition = 20
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.Header.VisiblePosition = 21
        UltraGridColumn273.Hidden = True
        UltraGridColumn274.Header.VisiblePosition = 22
        UltraGridColumn274.Hidden = True
        UltraGridColumn275.Header.VisiblePosition = 23
        UltraGridColumn275.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 24
        UltraGridColumn13.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn13})
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance36.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.Appearance = Appearance36
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance37
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.Hidden = True
        Appearance38.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance38.BackColor2 = System.Drawing.SystemColors.Control
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance38.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.GroupByBox.PromptAppearance = Appearance38
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.MaxRowScrollRegions = 1
        Appearance39.BackColor = System.Drawing.SystemColors.Window
        Appearance39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.ActiveCellAppearance = Appearance39
        Appearance40.BackColor = System.Drawing.SystemColors.Highlight
        Appearance40.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.ActiveRowAppearance = Appearance40
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Appearance42.BorderColor = System.Drawing.Color.Silver
        Appearance42.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CellAppearance = Appearance42
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.CellPadding = 0
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance43.BackColor = System.Drawing.SystemColors.Control
        Appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance43.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance43.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.GroupByRowAppearance = Appearance43
        Appearance44.TextHAlignAsString = "Center"
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.HeaderAppearance = Appearance44
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.BorderColor = System.Drawing.Color.Silver
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowAppearance = Appearance45
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance46.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.Override.TemplateAddRowAppearance = Appearance46
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDetalleOrdenCompraServicio.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaDetalleOrdenCompraServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDetalleOrdenCompraServicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDetalleOrdenCompraServicio.Location = New System.Drawing.Point(2, 2)
        Me.griListaDetalleOrdenCompraServicio.Name = "griListaDetalleOrdenCompraServicio"
        Me.griListaDetalleOrdenCompraServicio.Size = New System.Drawing.Size(496, 155)
        Me.griListaDetalleOrdenCompraServicio.TabIndex = 0
        Me.griListaDetalleOrdenCompraServicio.Text = "Grilla2"
        '
        'odOrdenCompraServicio
        '
        UltraDataColumn55.DataType = GetType(Boolean)
        UltraDataColumn55.DefaultValue = False
        UltraDataColumn61.DataType = GetType(Double)
        UltraDataColumn69.DataType = GetType(Boolean)
        UltraDataColumn69.DefaultValue = False
        UltraDataColumn79.DataType = GetType(Double)
        Me.odOrdenCompraServicio.Band.Columns.AddRange(New Object() {UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79})
        '
        'gbeListadoServicios
        '
        Me.gbeListadoServicios.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeListadoServicios.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.gbeListadoServicios.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeListadoServicios.ExpandedSize = New System.Drawing.Size(714, 155)
        Me.gbeListadoServicios.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeListadoServicios.Location = New System.Drawing.Point(498, 2)
        Me.gbeListadoServicios.Name = "gbeListadoServicios"
        Me.gbeListadoServicios.Size = New System.Drawing.Size(714, 155)
        Me.gbeListadoServicios.TabIndex = 1
        Me.gbeListadoServicios.Text = "Servicios"
        Me.gbeListadoServicios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.utcListadosServicios)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(691, 149)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'utcListadosServicios
        '
        Me.utcListadosServicios.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.utcListadosServicios.Controls.Add(Me.UltraTabPageControl15)
        Me.utcListadosServicios.Controls.Add(Me.UltraTabPageControl16)
        Me.utcListadosServicios.Controls.Add(Me.UltraTabPageControl3)
        Me.utcListadosServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcListadosServicios.Location = New System.Drawing.Point(0, 0)
        Me.utcListadosServicios.Name = "utcListadosServicios"
        Me.utcListadosServicios.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.utcListadosServicios.Size = New System.Drawing.Size(691, 149)
        Me.utcListadosServicios.TabIndex = 0
        UltraTab9.Key = "0"
        UltraTab9.TabPage = Me.UltraTabPageControl16
        UltraTab9.Text = "Requerimientos"
        UltraTab8.Key = "1"
        UltraTab8.TabPage = Me.UltraTabPageControl15
        UltraTab8.Text = "Servicios"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Cotizaciones"
        Me.utcListadosServicios.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab8, UltraTab3})
        Me.utcListadosServicios.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(689, 126)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1220, 178)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnEnviar)
        Me.Agrupacion3.Controls.Add(Me.fecFechaPago)
        Me.Agrupacion3.Controls.Add(Me.fecFechaEntrega)
        Me.Agrupacion3.Controls.Add(Me.fecFechaActual)
        Me.Agrupacion3.Controls.Add(Me.cmdSolesDolares)
        Me.Agrupacion3.Controls.Add(Me.lbl_etiqueta)
        Me.Agrupacion3.Controls.Add(Me.cboMoneda)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion11)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel18)
        Me.Agrupacion3.Controls.Add(Me.txtTC)
        Me.Agrupacion3.Controls.Add(Me.chkGenComprobante)
        Me.Agrupacion3.Controls.Add(Me.agrGenerarComprabante)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel8)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel17)
        Me.Agrupacion3.Controls.Add(Me.chkRuc)
        Me.Agrupacion3.Controls.Add(Me.cboProveedor)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel11)
        Me.Agrupacion3.Controls.Add(Me.txtPorcenIGV)
        Me.Agrupacion3.Controls.Add(Me.cboTipoOrdenCompra)
        Me.Agrupacion3.Controls.Add(Me.cboCentro)
        Me.Agrupacion3.Controls.Add(Me.cboTipoPago)
        Me.Agrupacion3.Controls.Add(Me.txtEstado)
        Me.Agrupacion3.Controls.Add(Me.cbCentro)
        Me.Agrupacion3.Controls.Add(Me.chkBloquea)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel12)
        Me.Agrupacion3.Controls.Add(Me.txtNotas)
        Me.Agrupacion3.Controls.Add(Me.txtObservaciones)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel10)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel7)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion3.Controls.Add(Me.lbNumeroOrden)
        Me.Agrupacion3.Controls.Add(Me.txtNumeroOrden)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion3.Controls.Add(Me.btnEnviarCorreo)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1220, 178)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEnviar
        '
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance47.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnEnviar.Appearance = Appearance47
        Me.btnEnviar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(478, 116)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(76, 24)
        Me.btnEnviar.TabIndex = 33
        Me.btnEnviar.Text = "Env. Cont."
        Me.btnEnviar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'fecFechaPago
        '
        Me.fecFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaPago.Location = New System.Drawing.Point(577, 4)
        Me.fecFechaPago.Name = "fecFechaPago"
        Me.fecFechaPago.Size = New System.Drawing.Size(91, 20)
        Me.fecFechaPago.TabIndex = 13
        '
        'fecFechaEntrega
        '
        Me.fecFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaEntrega.Location = New System.Drawing.Point(426, 5)
        Me.fecFechaEntrega.Name = "fecFechaEntrega"
        Me.fecFechaEntrega.Size = New System.Drawing.Size(80, 20)
        Me.fecFechaEntrega.TabIndex = 11
        '
        'fecFechaActual
        '
        Me.fecFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaActual.Location = New System.Drawing.Point(252, 5)
        Me.fecFechaActual.Name = "fecFechaActual"
        Me.fecFechaActual.Size = New System.Drawing.Size(96, 20)
        Me.fecFechaActual.TabIndex = 3
        '
        'cmdSolesDolares
        '
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.cmdSolesDolares.Appearance = Appearance48
        Me.cmdSolesDolares.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmdSolesDolares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSolesDolares.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSolesDolares.ForeColor = System.Drawing.Color.Black
        Me.cmdSolesDolares.Location = New System.Drawing.Point(178, 79)
        Me.cmdSolesDolares.Name = "cmdSolesDolares"
        Me.cmdSolesDolares.Size = New System.Drawing.Size(46, 22)
        Me.cmdSolesDolares.TabIndex = 19
        Me.cmdSolesDolares.Text = "s/. a $"
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance49
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1097, 17)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(57, 16)
        Me.lbl_etiqueta.TabIndex = 25
        Me.lbl_etiqueta.Text = "Etiqueta"
        Me.lbl_etiqueta.Visible = False
        '
        'cboMoneda
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance50
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownListWidth = 180
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(74, 79)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(98, 21)
        Me.cboMoneda.TabIndex = 18
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
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(476, 142)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(510, 32)
        Me.Agrupacion11.TabIndex = 35
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTotal
        '
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Appearance = Appearance51
        Me.txtTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(377, 6)
        Me.txtTotal.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NullText = "0.00"
        Me.txtTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(123, 21)
        Me.txtTotal.TabIndex = 5
        '
        'UltraLabel13
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Appearance52.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance52
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(6, 11)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel13.TabIndex = 0
        Me.UltraLabel13.Text = "Subtotal:"
        '
        'txtSubTotal
        '
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Appearance = Appearance53
        Me.txtSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Location = New System.Drawing.Point(55, 7)
        Me.txtSubTotal.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.NullText = "0.00"
        Me.txtSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(126, 21)
        Me.txtSubTotal.TabIndex = 1
        '
        'UltraLabel14
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Appearance54.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance54
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(187, 10)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel14.TabIndex = 2
        Me.UltraLabel14.Text = "IGV:"
        '
        'txtIGV
        '
        Appearance55.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Appearance = Appearance55
        Me.txtIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Location = New System.Drawing.Point(216, 6)
        Me.txtIGV.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.NullText = "0.00"
        Me.txtIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(123, 21)
        Me.txtIGV.TabIndex = 3
        '
        'UltraLabel15
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance56
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(340, 10)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Total:"
        '
        'UltraLabel18
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Appearance57.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance57
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(355, 70)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel18.TabIndex = 31
        Me.UltraLabel18.Text = "Observacion"
        '
        'txtTC
        '
        Appearance58.ForeColor = System.Drawing.Color.Black
        Me.txtTC.Appearance = Appearance58
        Me.txtTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.Black
        Me.txtTC.Location = New System.Drawing.Point(283, 79)
        Me.txtTC.MaskInput = "{double:3.4}"
        Me.txtTC.Name = "txtTC"
        Me.txtTC.NullText = "0.00"
        Me.txtTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTC.ReadOnly = True
        Me.txtTC.Size = New System.Drawing.Size(65, 21)
        Me.txtTC.TabIndex = 21
        '
        'chkGenComprobante
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.FontData.Name = "Tahoma"
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.chkGenComprobante.Appearance = Appearance59
        Me.chkGenComprobante.BackColor = System.Drawing.Color.Transparent
        Me.chkGenComprobante.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkGenComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGenComprobante.ForeColor = System.Drawing.Color.Black
        Me.chkGenComprobante.Location = New System.Drawing.Point(10, 102)
        Me.chkGenComprobante.Name = "chkGenComprobante"
        Me.chkGenComprobante.Size = New System.Drawing.Size(136, 20)
        Me.chkGenComprobante.TabIndex = 9
        Me.chkGenComprobante.Text = "Generar Comprobante"
        '
        'agrGenerarComprabante
        '
        Me.agrGenerarComprabante.Controls.Add(Me.chkCajaChica)
        Me.agrGenerarComprabante.Controls.Add(Me.udtFechaEmision)
        Me.agrGenerarComprabante.Controls.Add(Me.txtNroComprabante)
        Me.agrGenerarComprabante.Controls.Add(Me.txtSerie)
        Me.agrGenerarComprabante.Controls.Add(Me.txtEstadoDoc)
        Me.agrGenerarComprabante.Controls.Add(Me.UltraLabel9)
        Me.agrGenerarComprabante.Controls.Add(Me.cmbTipoDocumento)
        Me.agrGenerarComprabante.Enabled = False
        Me.agrGenerarComprabante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGenerarComprabante.ForeColor = System.Drawing.Color.Black
        Me.agrGenerarComprabante.Location = New System.Drawing.Point(9, 116)
        Me.agrGenerarComprabante.Name = "agrGenerarComprabante"
        Me.agrGenerarComprabante.Size = New System.Drawing.Size(467, 58)
        Me.agrGenerarComprabante.TabIndex = 8
        Me.agrGenerarComprabante.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkCajaChica
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.FontData.Name = "Tahoma"
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.chkCajaChica.Appearance = Appearance60
        Me.chkCajaChica.BackColor = System.Drawing.Color.Transparent
        Me.chkCajaChica.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkCajaChica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCajaChica.ForeColor = System.Drawing.Color.Black
        Me.chkCajaChica.Location = New System.Drawing.Point(329, 32)
        Me.chkCajaChica.Name = "chkCajaChica"
        Me.chkCajaChica.Size = New System.Drawing.Size(75, 21)
        Me.chkCajaChica.TabIndex = 6
        Me.chkCajaChica.Text = "Caja Chica"
        '
        'udtFechaEmision
        '
        Appearance61.FontData.Name = "Tahoma"
        Me.udtFechaEmision.Appearance = Appearance61
        Me.udtFechaEmision.DateTime = New Date(2015, 8, 5, 0, 0, 0, 0)
        Me.udtFechaEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtFechaEmision.Location = New System.Drawing.Point(81, 31)
        Me.udtFechaEmision.MaskInput = ""
        Me.udtFechaEmision.Name = "udtFechaEmision"
        Me.udtFechaEmision.Size = New System.Drawing.Size(100, 22)
        Me.udtFechaEmision.TabIndex = 4
        Me.udtFechaEmision.Value = New Date(2015, 8, 5, 0, 0, 0, 0)
        '
        'txtNroComprabante
        '
        Appearance62.FontData.Name = "Tahoma"
        Me.txtNroComprabante.Appearance = Appearance62
        Me.txtNroComprabante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroComprabante.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroComprabante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroComprabante.Location = New System.Drawing.Point(328, 8)
        Me.txtNroComprabante.Name = "txtNroComprabante"
        Me.txtNroComprabante.Size = New System.Drawing.Size(133, 22)
        Me.txtNroComprabante.TabIndex = 2
        '
        'txtSerie
        '
        Appearance63.FontData.Name = "Tahoma"
        Me.txtSerie.Appearance = Appearance63
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(187, 8)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(135, 22)
        Me.txtSerie.TabIndex = 1
        '
        'txtEstadoDoc
        '
        Appearance64.FontData.Name = "Tahoma"
        Me.txtEstadoDoc.Appearance = Appearance64
        Me.txtEstadoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstadoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstadoDoc.Enabled = False
        Me.txtEstadoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoDoc.Location = New System.Drawing.Point(187, 32)
        Me.txtEstadoDoc.Name = "txtEstadoDoc"
        Me.txtEstadoDoc.Size = New System.Drawing.Size(136, 22)
        Me.txtEstadoDoc.TabIndex = 5
        '
        'UltraLabel9
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.FontData.Name = "Tahoma"
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance65
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(14, 36)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(60, 15)
        Me.UltraLabel9.TabIndex = 3
        Me.UltraLabel9.Text = "F. Emision:"
        '
        'cmbTipoDocumento
        '
        Appearance66.FontData.Name = "Tahoma"
        Appearance66.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoDocumento.Appearance = Appearance66
        Me.cmbTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDocumento.DisplayMember = "Nombre"
        Me.cmbTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDocumento.DropDownListWidth = 340
        Me.cmbTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoDocumento.ImageList = Me.imagenes
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 8)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(175, 22)
        Me.cmbTipoDocumento.TabIndex = 0
        Me.cmbTipoDocumento.ValueMember = "Id"
        '
        'UltraLabel8
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance67
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(8, 57)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel8.TabIndex = 6
        Me.UltraLabel8.Text = "Proveedor:"
        '
        'UltraLabel17
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance68
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(9, 33)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 4
        Me.UltraLabel17.Text = "Estado:"
        '
        'chkRuc
        '
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc.Appearance = Appearance69
        Me.chkRuc.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc.ForeColor = System.Drawing.Color.Black
        Me.chkRuc.Location = New System.Drawing.Point(297, 52)
        Me.chkRuc.Name = "chkRuc"
        Me.chkRuc.Size = New System.Drawing.Size(45, 20)
        Me.chkRuc.TabIndex = 16
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
        Me.cboProveedor.Location = New System.Drawing.Point(74, 53)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(217, 23)
        Me.cboProveedor.TabIndex = 7
        '
        'UltraLabel11
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance70
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(640, 121)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel11.TabIndex = 32
        Me.UltraLabel11.Text = "IGV:"
        '
        'txtPorcenIGV
        '
        Me.txtPorcenIGV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcenIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPorcenIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenIGV.Location = New System.Drawing.Point(674, 117)
        Me.txtPorcenIGV.Name = "txtPorcenIGV"
        Me.txtPorcenIGV.ReadOnly = True
        Me.txtPorcenIGV.Size = New System.Drawing.Size(65, 21)
        Me.txtPorcenIGV.TabIndex = 30
        '
        'cboTipoOrdenCompra
        '
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.cboTipoOrdenCompra.Appearance = Appearance71
        Me.cboTipoOrdenCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance72.Image = 7
        EditorButton1.Appearance = Appearance72
        Me.cboTipoOrdenCompra.ButtonsRight.Add(EditorButton1)
        Me.cboTipoOrdenCompra.DisplayMember = "Nombre"
        Me.cboTipoOrdenCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoOrdenCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoOrdenCompra.ForeColor = System.Drawing.Color.Black
        Me.cboTipoOrdenCompra.ImageList = Me.imagenes
        Me.cboTipoOrdenCompra.Location = New System.Drawing.Point(750, 5)
        Me.cboTipoOrdenCompra.Name = "cboTipoOrdenCompra"
        Me.cboTipoOrdenCompra.Size = New System.Drawing.Size(173, 21)
        Me.cboTipoOrdenCompra.TabIndex = 23
        Me.cboTipoOrdenCompra.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance73.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance73
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance74.Image = 7
        EditorButton2.Appearance = Appearance74
        Me.cboCentro.ButtonsRight.Add(EditorButton2)
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.ImageList = Me.imagenes
        ValueListItem25.DataValue = "M"
        ValueListItem25.DisplayText = "Materiales"
        ValueListItem26.DataValue = "S"
        ValueListItem26.DisplayText = "Servicios"
        Me.cboCentro.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem25, ValueListItem26})
        Me.cboCentro.Location = New System.Drawing.Point(750, 29)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(173, 21)
        Me.cboCentro.TabIndex = 27
        Me.cboCentro.ValueMember = "Id"
        '
        'cboTipoPago
        '
        Appearance75.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance75
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance76.Image = 7
        EditorButton3.Appearance = Appearance76
        Me.cboTipoPago.ButtonsRight.Add(EditorButton3)
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.ImageList = Me.imagenes
        Me.cboTipoPago.Location = New System.Drawing.Point(426, 29)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(242, 21)
        Me.cboTipoPago.TabIndex = 15
        Me.cboTipoPago.ValueMember = "Id"
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(74, 29)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(168, 21)
        Me.txtEstado.TabIndex = 5
        '
        'cbCentro
        '
        Me.cbCentro.BackColor = System.Drawing.Color.Transparent
        Me.cbCentro.BackColorInternal = System.Drawing.Color.Transparent
        Me.cbCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCentro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbCentro.Location = New System.Drawing.Point(688, 29)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Size = New System.Drawing.Size(58, 20)
        Me.cbCentro.TabIndex = 26
        Me.cbCentro.Text = "Centro:"
        '
        'chkBloquea
        '
        Appearance77.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkBloquea.Appearance = Appearance77
        Me.chkBloquea.BackColor = System.Drawing.Color.Transparent
        Me.chkBloquea.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkBloquea.Checked = True
        Me.chkBloquea.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBloquea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBloquea.ForeColor = System.Drawing.Color.Black
        Me.chkBloquea.Location = New System.Drawing.Point(567, 119)
        Me.chkBloquea.Name = "chkBloquea"
        Me.chkBloquea.Size = New System.Drawing.Size(66, 20)
        Me.chkBloquea.TabIndex = 34
        Me.chkBloquea.Text = "Bloq Act."
        Me.chkBloquea.Visible = False
        '
        'UltraLabel2
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Appearance78.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance78
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(706, 55)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel2.TabIndex = 28
        Me.UltraLabel2.Text = "Notas:"
        '
        'UltraLabel12
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance79
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(354, 56)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel12.TabIndex = 28
        Me.UltraLabel12.Text = "Glosa /"
        '
        'txtNotas
        '
        Appearance80.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNotas.Appearance = Appearance80
        Me.txtNotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNotas.Location = New System.Drawing.Point(752, 53)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas.Size = New System.Drawing.Size(270, 83)
        Me.txtNotas.TabIndex = 29
        '
        'txtObservaciones
        '
        Appearance81.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Appearance = Appearance81
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Location = New System.Drawing.Point(426, 54)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(242, 54)
        Me.txtObservaciones.TabIndex = 29
        '
        'UltraLabel10
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Appearance82.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance82
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(680, 8)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel10.TabIndex = 22
        Me.UltraLabel10.Text = "Tipo Orden:"
        '
        'UltraLabel7
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Appearance83.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance83
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(249, 83)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(25, 15)
        Me.UltraLabel7.TabIndex = 20
        Me.UltraLabel7.Text = "T.C:"
        '
        'UltraLabel6
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Appearance84.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance84
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(9, 81)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 17
        Me.UltraLabel6.Text = "Moneda:"
        '
        'UltraLabel5
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Appearance85.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance85
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(354, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel5.TabIndex = 10
        Me.UltraLabel5.Text = "Entrega:"
        '
        'UltraLabel4
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance86
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(542, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Pago:"
        '
        'UltraLabel3
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance87
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(353, 31)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel3.TabIndex = 14
        Me.UltraLabel3.Text = "Tipo Pago:"
        '
        'lbNumeroOrden
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.lbNumeroOrden.Appearance = Appearance88
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
        Me.txtNumeroOrden.Location = New System.Drawing.Point(74, 5)
        Me.txtNumeroOrden.Name = "txtNumeroOrden"
        Me.txtNumeroOrden.ReadOnly = True
        Me.txtNumeroOrden.Size = New System.Drawing.Size(117, 21)
        Me.txtNumeroOrden.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Appearance89.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance89
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(212, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Fecha:"
        '
        'btnEnviarCorreo
        '
        Appearance90.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnEnviarCorreo.Appearance = Appearance90
        Me.btnEnviarCorreo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(929, 3)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(93, 25)
        Me.btnEnviarCorreo.TabIndex = 24
        Me.btnEnviarCorreo.Text = "Enviar Correo"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1220, 178)
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.cheReqAsoc)
        Me.Agrupacion12.Controls.Add(Me.cheEntregasParciales)
        Me.Agrupacion12.Controls.Add(Me.cheAutoAprobar)
        Me.Agrupacion12.Controls.Add(Me.agrPercepcion)
        Me.Agrupacion12.Controls.Add(Me.agrDetraccion)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1220, 178)
        Me.Agrupacion12.TabIndex = 356
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cheReqAsoc
        '
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Me.cheReqAsoc.Appearance = Appearance91
        Me.cheReqAsoc.BackColor = System.Drawing.Color.Transparent
        Me.cheReqAsoc.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheReqAsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheReqAsoc.ForeColor = System.Drawing.Color.Black
        Me.cheReqAsoc.Location = New System.Drawing.Point(537, 84)
        Me.cheReqAsoc.Name = "cheReqAsoc"
        Me.cheReqAsoc.Size = New System.Drawing.Size(120, 20)
        Me.cheReqAsoc.TabIndex = 358
        Me.cheReqAsoc.Text = "Req. Asoc."
        Me.cheReqAsoc.Visible = False
        '
        'cheEntregasParciales
        '
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Me.cheEntregasParciales.Appearance = Appearance92
        Me.cheEntregasParciales.BackColor = System.Drawing.Color.Transparent
        Me.cheEntregasParciales.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheEntregasParciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheEntregasParciales.ForeColor = System.Drawing.Color.Black
        Me.cheEntregasParciales.Location = New System.Drawing.Point(537, 67)
        Me.cheEntregasParciales.Name = "cheEntregasParciales"
        Me.cheEntregasParciales.Size = New System.Drawing.Size(120, 20)
        Me.cheEntregasParciales.TabIndex = 357
        Me.cheEntregasParciales.Text = "Entregas parciales"
        Me.cheEntregasParciales.Visible = False
        '
        'cheAutoAprobar
        '
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Me.cheAutoAprobar.Appearance = Appearance93
        Me.cheAutoAprobar.BackColor = System.Drawing.Color.Transparent
        Me.cheAutoAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.cheAutoAprobar.Checked = True
        Me.cheAutoAprobar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cheAutoAprobar.Enabled = False
        Me.cheAutoAprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheAutoAprobar.ForeColor = System.Drawing.Color.Black
        Me.cheAutoAprobar.Location = New System.Drawing.Point(537, 48)
        Me.cheAutoAprobar.Name = "cheAutoAprobar"
        Me.cheAutoAprobar.Size = New System.Drawing.Size(120, 20)
        Me.cheAutoAprobar.TabIndex = 356
        Me.cheAutoAprobar.Text = "Autoaprobar"
        Me.cheAutoAprobar.Visible = False
        '
        'agrPercepcion
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Me.agrPercepcion.Appearance = Appearance94
        Me.agrPercepcion.Controls.Add(Me.DecPorcentajePercepcion)
        Me.agrPercepcion.Controls.Add(Me.cheActivoPercepcion)
        Me.agrPercepcion.Controls.Add(Me.UltraLabel19)
        Me.agrPercepcion.Controls.Add(Me.DecPercepcion)
        Me.agrPercepcion.Controls.Add(Me.UltraLabel20)
        Me.agrPercepcion.Controls.Add(Me.DecTPagar)
        Me.agrPercepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPercepcion.ForeColor = System.Drawing.Color.Black
        Me.agrPercepcion.Location = New System.Drawing.Point(6, 17)
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
        Me.DecPorcentajePercepcion.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.DecPorcentajePercepcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
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
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Appearance95.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance95
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
        Appearance96.ForeColor = System.Drawing.Color.Black
        Me.DecPercepcion.Appearance = Appearance96
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
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Appearance97.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance97
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
        Appearance98.ForeColor = System.Drawing.Color.Black
        Me.DecTPagar.Appearance = Appearance98
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
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Me.agrDetraccion.Appearance = Appearance99
        Me.agrDetraccion.Controls.Add(Me.UltraLabel21)
        Me.agrDetraccion.Controls.Add(Me.DecDetraer)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel22)
        Me.agrDetraccion.Controls.Add(Me.DecMontoDetraccion)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel23)
        Me.agrDetraccion.Controls.Add(Me.txtNetoPagar)
        Me.agrDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetraccion.ForeColor = System.Drawing.Color.Black
        Me.agrDetraccion.Location = New System.Drawing.Point(6, 71)
        Me.agrDetraccion.Name = "agrDetraccion"
        Me.agrDetraccion.Size = New System.Drawing.Size(446, 48)
        Me.agrDetraccion.TabIndex = 355
        Me.agrDetraccion.Text = "Detracción"
        Me.agrDetraccion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel21
        '
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Appearance100.ForeColor = System.Drawing.Color.Navy
        Appearance100.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance100
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
        Me.DecDetraer.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DecDetraer.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DecDetraer.Name = "DecDetraer"
        Me.DecDetraer.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.DecDetraer.Size = New System.Drawing.Size(74, 21)
        Me.DecDetraer.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.DecDetraer.TabIndex = 1
        '
        'UltraLabel22
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Appearance101.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance101
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
        Appearance102.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Appearance = Appearance102
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
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Appearance103.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance103
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
        Appearance104.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Appearance = Appearance104
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
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1226, 437)
        '
        'agrOrdenCompra
        '
        Me.agrOrdenCompra.Controls.Add(Me.griListaOrdenCompra)
        Me.agrOrdenCompra.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenCompra.Location = New System.Drawing.Point(0, 134)
        Me.agrOrdenCompra.Name = "agrOrdenCompra"
        Me.agrOrdenCompra.Size = New System.Drawing.Size(1226, 303)
        Me.agrOrdenCompra.TabIndex = 1
        Me.agrOrdenCompra.Text = "Ordenes de Compra : "
        Me.agrOrdenCompra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaOrdenCompra
        '
        Me.griListaOrdenCompra.DataSource = Me.odListaOrdenCompra
        Appearance105.BackColor = System.Drawing.SystemColors.Window
        Appearance105.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaOrdenCompra.DisplayLayout.Appearance = Appearance105
        UltraGridColumn276.Header.VisiblePosition = 0
        UltraGridColumn276.Hidden = True
        UltraGridColumn277.Header.VisiblePosition = 1
        UltraGridColumn277.Hidden = True
        UltraGridColumn278.Header.Caption = "N° Orden"
        UltraGridColumn278.Header.VisiblePosition = 2
        UltraGridColumn279.Header.VisiblePosition = 3
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 4
        UltraGridColumn280.Hidden = True
        UltraGridColumn281.Header.VisiblePosition = 5
        UltraGridColumn281.Hidden = True
        UltraGridColumn282.Header.VisiblePosition = 6
        UltraGridColumn282.Hidden = True
        Appearance106.TextHAlignAsString = "Right"
        UltraGridColumn283.CellAppearance = Appearance106
        UltraGridColumn283.Format = "#,###,###,##0.0000"
        UltraGridColumn283.Header.VisiblePosition = 10
        UltraGridColumn283.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn283.Width = 98
        Appearance107.TextHAlignAsString = "Right"
        UltraGridColumn284.CellAppearance = Appearance107
        UltraGridColumn284.Format = "#,###,###,##0.0000"
        UltraGridColumn284.Header.VisiblePosition = 11
        UltraGridColumn284.MaskInput = "{LOC}nnnnnnnn.nnnn"
        Appearance108.TextHAlignAsString = "Right"
        UltraGridColumn285.CellAppearance = Appearance108
        UltraGridColumn285.Format = "#,###,###,##0.0000"
        UltraGridColumn285.Header.VisiblePosition = 12
        UltraGridColumn285.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn286.Header.VisiblePosition = 13
        UltraGridColumn286.Hidden = True
        UltraGridColumn287.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn287.Header.Caption = "Fecha"
        UltraGridColumn287.Header.VisiblePosition = 7
        UltraGridColumn287.Width = 83
        UltraGridColumn288.Header.VisiblePosition = 14
        UltraGridColumn288.Hidden = True
        UltraGridColumn289.Header.VisiblePosition = 15
        UltraGridColumn289.Hidden = True
        UltraGridColumn290.Header.VisiblePosition = 16
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 17
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 18
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.Header.VisiblePosition = 19
        UltraGridColumn293.Hidden = True
        UltraGridColumn294.Header.VisiblePosition = 20
        UltraGridColumn294.Hidden = True
        UltraGridColumn295.Header.VisiblePosition = 21
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.VisiblePosition = 22
        UltraGridColumn296.Hidden = True
        UltraGridColumn297.Header.VisiblePosition = 23
        UltraGridColumn297.Hidden = True
        UltraGridColumn298.Header.VisiblePosition = 24
        UltraGridColumn298.Hidden = True
        UltraGridColumn299.Header.VisiblePosition = 25
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.VisiblePosition = 26
        UltraGridColumn300.Hidden = True
        UltraGridColumn301.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn301.Header.VisiblePosition = 42
        UltraGridColumn301.Width = 104
        UltraGridColumn302.Header.VisiblePosition = 29
        UltraGridColumn302.Hidden = True
        UltraGridColumn303.Header.VisiblePosition = 30
        UltraGridColumn303.Hidden = True
        UltraGridColumn304.Header.VisiblePosition = 31
        UltraGridColumn304.Hidden = True
        UltraGridColumn305.Header.VisiblePosition = 9
        UltraGridColumn306.Header.VisiblePosition = 32
        UltraGridColumn306.Hidden = True
        UltraGridColumn307.Header.VisiblePosition = 33
        UltraGridColumn307.Hidden = True
        UltraGridColumn308.Header.VisiblePosition = 34
        UltraGridColumn308.Hidden = True
        UltraGridColumn309.Header.VisiblePosition = 35
        UltraGridColumn309.Hidden = True
        UltraGridColumn310.Header.VisiblePosition = 36
        UltraGridColumn310.Hidden = True
        UltraGridColumn311.Header.VisiblePosition = 37
        UltraGridColumn311.Hidden = True
        UltraGridColumn312.Header.VisiblePosition = 38
        UltraGridColumn312.Hidden = True
        UltraGridColumn313.Header.VisiblePosition = 47
        UltraGridColumn314.Header.VisiblePosition = 39
        UltraGridColumn314.Hidden = True
        UltraGridColumn315.Header.VisiblePosition = 40
        UltraGridColumn315.Hidden = True
        UltraGridColumn316.Header.Caption = "Estado"
        UltraGridColumn316.Header.VisiblePosition = 27
        UltraGridColumn316.Width = 179
        UltraGridColumn317.Header.VisiblePosition = 41
        UltraGridColumn317.Hidden = True
        UltraGridColumn318.Header.Caption = "Proveedor"
        UltraGridColumn318.Header.VisiblePosition = 8
        UltraGridColumn318.Width = 226
        UltraGridColumn319.Header.Caption = "Evaluación"
        UltraGridColumn319.Header.VisiblePosition = 43
        UltraGridColumn320.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn320.Header.VisiblePosition = 44
        UltraGridColumn320.Hidden = True
        UltraGridColumn321.Header.Caption = "Consignación"
        UltraGridColumn321.Header.VisiblePosition = 45
        UltraGridColumn321.Hidden = True
        UltraGridColumn321.Width = 81
        UltraGridColumn322.Header.Caption = "Ref. Documento"
        UltraGridColumn322.Header.VisiblePosition = 28
        UltraGridColumn322.Width = 165
        UltraGridColumn323.Header.VisiblePosition = 48
        UltraGridColumn323.Width = 180
        UltraGridColumn324.Header.VisiblePosition = 49
        UltraGridColumn324.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 46
        UltraGridColumn14.Header.VisiblePosition = 50
        UltraGridColumn14.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn11, UltraGridColumn14})
        Me.griListaOrdenCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griListaOrdenCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaOrdenCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance109.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance109.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance109.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.Appearance = Appearance109
        Appearance110.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance110
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.Hidden = True
        Appearance111.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance111.BackColor2 = System.Drawing.SystemColors.Control
        Appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance111.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaOrdenCompra.DisplayLayout.GroupByBox.PromptAppearance = Appearance111
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
        Appearance112.BorderColor = System.Drawing.Color.Silver
        Me.griListaOrdenCompra.DisplayLayout.Override.RowAppearance = Appearance112
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaOrdenCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaOrdenCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaOrdenCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaOrdenCompra.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaOrdenCompra.Location = New System.Drawing.Point(3, 46)
        Me.griListaOrdenCompra.Name = "griListaOrdenCompra"
        Me.griListaOrdenCompra.Size = New System.Drawing.Size(1220, 254)
        Me.griListaOrdenCompra.TabIndex = 1
        Me.griListaOrdenCompra.Text = "Grilla2"
        '
        'odListaOrdenCompra
        '
        UltraDataColumn129.DataType = GetType(Boolean)
        Me.odListaOrdenCompra.Band.Columns.AddRange(New Object() {UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnCambiarEstado)
        Me.agrMenuLista.Controls.Add(Me.btnBloquear)
        Me.agrMenuLista.Controls.Add(Me.btnHistorial)
        Me.agrMenuLista.Controls.Add(Me.btnAtenderOC)
        Me.agrMenuLista.Controls.Add(Me.btnAprobar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 16)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1220, 30)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCambiarEstado
        '
        Appearance113.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance113.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnCambiarEstado.Appearance = Appearance113
        Me.btnCambiarEstado.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCambiarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCambiarEstado.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCambiarEstado.Enabled = False
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.ForeColor = System.Drawing.Color.Black
        Me.btnCambiarEstado.Location = New System.Drawing.Point(308, 3)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(80, 24)
        Me.btnCambiarEstado.TabIndex = 4
        Me.btnCambiarEstado.Text = "Generar"
        Me.btnCambiarEstado.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnBloquear
        '
        Appearance114.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance114.Image = CType(resources.GetObject("Appearance114.Image"), Object)
        Me.btnBloquear.Appearance = Appearance114
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
        Appearance115.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance115.Image = CType(resources.GetObject("Appearance115.Image"), Object)
        Me.btnHistorial.Appearance = Appearance115
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
        Appearance116.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance116.Image = CType(resources.GetObject("Appearance116.Image"), Object)
        Me.btnAtenderOC.Appearance = Appearance116
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
        Appearance117.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance117.Image = CType(resources.GetObject("Appearance117.Image"), Object)
        Me.btnAprobar.Appearance = Appearance117
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
        Me.Agrupacion1.Controls.Add(Me.Agrupacion13)
        Me.Agrupacion1.Controls.Add(Me.rdbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.rdbNroOrden)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion6)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion1.Controls.Add(Me.cboFormaBusqueda)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1226, 134)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion13
        '
        Me.Agrupacion13.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion13.Controls.Add(Me.txtNroOrdenCompra)
        Me.Agrupacion13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion13.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion13.Location = New System.Drawing.Point(391, 39)
        Me.Agrupacion13.Name = "Agrupacion13"
        Me.Agrupacion13.Size = New System.Drawing.Size(203, 34)
        Me.Agrupacion13.TabIndex = 3
        Me.Agrupacion13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta2
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance118
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 12)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "NroOrd:"
        '
        'txtNroOrdenCompra
        '
        Appearance119.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrdenCompra.Appearance = Appearance119
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrdenCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(55, 8)
        Me.txtNroOrdenCompra.MaxLength = 13
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(139, 21)
        Me.txtNroOrdenCompra.TabIndex = 1
        '
        'rdbDatosAdicionales
        '
        Me.rdbDatosAdicionales.AutoSize = True
        Me.rdbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosAdicionales.Checked = True
        Me.rdbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosAdicionales.Location = New System.Drawing.Point(6, 22)
        Me.rdbDatosAdicionales.Name = "rdbDatosAdicionales"
        Me.rdbDatosAdicionales.Size = New System.Drawing.Size(107, 17)
        Me.rdbDatosAdicionales.TabIndex = 0
        Me.rdbDatosAdicionales.TabStop = True
        Me.rdbDatosAdicionales.Text = "DatosAdicionales"
        Me.rdbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'rdbNroOrden
        '
        Me.rdbNroOrden.AutoSize = True
        Me.rdbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rdbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rdbNroOrden.Location = New System.Drawing.Point(391, 22)
        Me.rdbNroOrden.Name = "rdbNroOrden"
        Me.rdbNroOrden.Size = New System.Drawing.Size(71, 17)
        Me.rdbNroOrden.TabIndex = 2
        Me.rdbNroOrden.TabStop = True
        Me.rdbNroOrden.Text = "NroOrden"
        Me.rdbNroOrden.UseVisualStyleBackColor = False
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.UltraLabel24)
        Me.Agrupacion6.Controls.Add(Me.chkRuc2)
        Me.Agrupacion6.Controls.Add(Me.UltraLabel25)
        Me.Agrupacion6.Controls.Add(Me.cboProveedorL)
        Me.Agrupacion6.Controls.Add(Me.FechaDesde)
        Me.Agrupacion6.Controls.Add(Me.FechaHasta)
        Me.Agrupacion6.Controls.Add(Me.cboEstadoOrden)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion6.Controls.Add(Me.UltraLabel16)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion6.Controls.Add(Me.cboMonedaL)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(6, 39)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(374, 90)
        Me.Agrupacion6.TabIndex = 1
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel24
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Appearance120.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance120
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(6, 9)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel24.TabIndex = 0
        Me.UltraLabel24.Text = "Desde:"
        '
        'chkRuc2
        '
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc2.Appearance = Appearance121
        Me.chkRuc2.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc2.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc2.ForeColor = System.Drawing.Color.Black
        Me.chkRuc2.Location = New System.Drawing.Point(323, 62)
        Me.chkRuc2.Name = "chkRuc2"
        Me.chkRuc2.Size = New System.Drawing.Size(44, 20)
        Me.chkRuc2.TabIndex = 10
        Me.chkRuc2.Text = "Ruc"
        '
        'UltraLabel25
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Appearance122.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance122
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(6, 35)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel25.TabIndex = 2
        Me.UltraLabel25.Text = "Hasta:"
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
        Me.cboProveedorL.Location = New System.Drawing.Point(73, 61)
        Me.cboProveedorL.Name = "cboProveedorL"
        Me.cboProveedorL.Size = New System.Drawing.Size(244, 22)
        Me.cboProveedorL.TabIndex = 9
        '
        'FechaDesde
        '
        Me.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDesde.Location = New System.Drawing.Point(49, 7)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(95, 20)
        Me.FechaDesde.TabIndex = 1
        '
        'FechaHasta
        '
        Me.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaHasta.Location = New System.Drawing.Point(49, 35)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(95, 20)
        Me.FechaHasta.TabIndex = 3
        '
        'cboEstadoOrden
        '
        Appearance123.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.Appearance = Appearance123
        Me.cboEstadoOrden.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoOrden.DisplayMember = "Nombre"
        Me.cboEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoOrden.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.ImageList = Me.imagenes
        Me.cboEstadoOrden.Location = New System.Drawing.Point(211, 6)
        Me.cboEstadoOrden.Name = "cboEstadoOrden"
        Me.cboEstadoOrden.Size = New System.Drawing.Size(156, 21)
        Me.cboEstadoOrden.TabIndex = 5
        Me.cboEstadoOrden.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance124
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(165, 9)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "Estado:"
        '
        'UltraLabel16
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Appearance125.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance125
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(6, 65)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(60, 15)
        Me.UltraLabel16.TabIndex = 8
        Me.UltraLabel16.Text = "Proveedor :"
        '
        'Etiqueta13
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance126
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(159, 35)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta13.TabIndex = 6
        Me.Etiqueta13.Text = "Moneda:"
        '
        'cboMonedaL
        '
        Appearance127.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaL.Appearance = Appearance127
        Me.cboMonedaL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMonedaL.DisplayMember = "Nombre"
        Me.cboMonedaL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMonedaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaL.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaL.ImageList = Me.imagenes
        Me.cboMonedaL.Location = New System.Drawing.Point(211, 33)
        Me.cboMonedaL.Name = "cboMonedaL"
        Me.cboMonedaL.Size = New System.Drawing.Size(156, 21)
        Me.cboMonedaL.TabIndex = 7
        Me.cboMonedaL.ValueMember = "Id"
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.ColoresAtendido)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion7.Controls.Add(Me.ColoresTerminado)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion7.Controls.Add(Me.ColoresAtendidoParcialmente)
        Me.Agrupacion7.Controls.Add(Me.etiTerminada)
        Me.Agrupacion7.Controls.Add(Me.ColoresEvaluado)
        Me.Agrupacion7.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion7.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion7.Controls.Add(Me.etiGenerada)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(618, 23)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(388, 66)
        Me.Agrupacion7.TabIndex = 4
        Me.Agrupacion7.Text = "Estados"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresAtendido
        '
        Me.ColoresAtendido.Location = New System.Drawing.Point(252, 40)
        Me.ColoresAtendido.Name = "ColoresAtendido"
        Me.ColoresAtendido.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAtendido.TabIndex = 7
        Me.ColoresAtendido.Text = "Control"
        '
        'Etiqueta10
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Appearance = Appearance128
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(251, 22)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta10.TabIndex = 6
        Me.Etiqueta10.Text = "Atendida"
        '
        'ColoresTerminado
        '
        Me.ColoresTerminado.Location = New System.Drawing.Point(327, 40)
        Me.ColoresTerminado.Name = "ColoresTerminado"
        Me.ColoresTerminado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresTerminado.TabIndex = 9
        Me.ColoresTerminado.Text = "Control"
        '
        'Etiqueta1
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Appearance = Appearance129
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(317, 22)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta1.TabIndex = 8
        Me.Etiqueta1.Text = "Terminada"
        '
        'ColoresAtendidoParcialmente
        '
        Me.ColoresAtendidoParcialmente.Location = New System.Drawing.Point(155, 40)
        Me.ColoresAtendidoParcialmente.Name = "ColoresAtendidoParcialmente"
        Me.ColoresAtendidoParcialmente.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAtendidoParcialmente.TabIndex = 5
        Me.ColoresAtendidoParcialmente.Text = "Control"
        '
        'etiTerminada
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance130
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(123, 22)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(113, 15)
        Me.etiTerminada.TabIndex = 4
        Me.etiTerminada.Text = "Atendido Parcialmente"
        '
        'ColoresEvaluado
        '
        Me.ColoresEvaluado.Color = System.Drawing.Color.Empty
        Me.ColoresEvaluado.Location = New System.Drawing.Point(70, 40)
        Me.ColoresEvaluado.Name = "ColoresEvaluado"
        Me.ColoresEvaluado.Size = New System.Drawing.Size(43, 21)
        Me.ColoresEvaluado.TabIndex = 3
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Color = System.Drawing.Color.Empty
        Me.ColoresGenerado.Location = New System.Drawing.Point(7, 40)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 1
        '
        'etiEnProceso
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance131
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(67, 23)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(48, 15)
        Me.etiEnProceso.TabIndex = 2
        Me.etiEnProceso.Text = "Evaluado"
        '
        'etiGenerada
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance132
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 23)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generado"
        '
        'cboFormaBusqueda
        '
        Appearance133.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFormaBusqueda.Appearance = Appearance133
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
        Me.cboFormaBusqueda.Location = New System.Drawing.Point(1006, 39)
        Me.cboFormaBusqueda.Name = "cboFormaBusqueda"
        Me.cboFormaBusqueda.Size = New System.Drawing.Size(144, 21)
        Me.cboFormaBusqueda.TabIndex = 5
        Me.cboFormaBusqueda.ValueMember = "Id"
        Me.cboFormaBusqueda.Visible = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1226, 437)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Agrupacion10)
        Me.Agrupacion4.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea15)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea16)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea20)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea21)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 205)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1226, 232)
        Me.Agrupacion4.TabIndex = 1
        Me.Agrupacion4.Tag = " "
        Me.Agrupacion4.Text = "Detalle"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.ficDetalle)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(3, 43)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(1220, 186)
        Me.Agrupacion10.TabIndex = 1
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl11)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalle.Location = New System.Drawing.Point(2, 2)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.ficDetalle.Size = New System.Drawing.Size(1216, 182)
        Me.ficDetalle.TabIndex = 0
        UltraTab4.Key = "Servicio"
        UltraTab4.TabPage = Me.UltraTabPageControl11
        UltraTab4.Text = "Servicio"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1214, 159)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea6)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea7)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea8)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(3, 16)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1220, 27)
        Me.Agrupacion5.TabIndex = 0
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1216, 26)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.MenuDetalle
        '
        'MenuDetalle
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.Appearance = Appearance134
        Me.MenuDetalle.DesignerFlags = 1
        Me.MenuDetalle.DockWithinContainer = Me
        Me.MenuDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuDetalle.ImageListLarge = Me.imagenes
        Me.MenuDetalle.ImageListSmall = Me.imagenes
        Me.MenuDetalle.MdiMergeable = False
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.MenuSettings.Appearance = Appearance135
        Me.MenuDetalle.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2, ButtonTool5})
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.Ribbon.TabAreaAppearance = Appearance136
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.Ribbon.TabSettings.Appearance = Appearance137
        Me.MenuDetalle.ShowFullMenusDelay = 500
        Me.MenuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(120, 464)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(222, 96)
        UltraToolbar1.IsMainMenuBar = True
        Appearance138.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool1.InstanceProps.AppearancesLarge.Appearance = Appearance138
        Appearance139.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool1.InstanceProps.AppearancesLarge.AppearanceOnMenu = Appearance139
        Appearance140.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool1.InstanceProps.AppearancesLarge.AppearanceOnRibbonGroup = Appearance140
        Appearance141.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool1.InstanceProps.AppearancesLarge.AppearanceOnToolbar = Appearance141
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool8, ButtonTool25, ButtonTool26, PopupMenuTool1, ButtonTool27, ButtonTool28})
        Appearance142.ForeColor = System.Drawing.Color.Navy
        UltraToolbar1.Settings.Appearance = Appearance142
        UltraToolbar1.Text = "utMenuDetalle"
        Me.MenuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance143.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.ToolbarSettings.Appearance = Appearance143
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Me.MenuDetalle.ToolbarSettings.EditAppearance = Appearance144
        Appearance145.Image = 7
        ButtonTool29.SharedPropsInternal.AppearancesSmall.Appearance = Appearance145
        ButtonTool29.SharedPropsInternal.Caption = "Importar"
        ButtonTool29.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance146.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool30.SharedPropsInternal.AppearancesSmall.Appearance = Appearance146
        ButtonTool30.SharedPropsInternal.Caption = "Editar"
        ButtonTool30.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance147.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool32.SharedPropsInternal.AppearancesSmall.Appearance = Appearance147
        ButtonTool32.SharedPropsInternal.Caption = "Quitar"
        ButtonTool32.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance148.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool33.SharedPropsInternal.AppearancesSmall.Appearance = Appearance148
        ButtonTool33.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool33.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance149.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool34.SharedPropsInternal.AppearancesSmall.Appearance = Appearance149
        ButtonTool34.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool34.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance150.Image = 6
        ButtonTool36.SharedPropsInternal.AppearancesSmall.Appearance = Appearance150
        ButtonTool36.SharedPropsInternal.Caption = "Listar"
        ButtonTool36.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance151.Image = 2
        ButtonTool37.SharedPropsInternal.AppearancesSmall.Appearance = Appearance151
        ButtonTool37.SharedPropsInternal.Caption = "Generar OI"
        ButtonTool37.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance152.Image = 3
        ButtonTool38.SharedPropsInternal.AppearancesSmall.Appearance = Appearance152
        ButtonTool38.SharedPropsInternal.Caption = "Ejecutar OI"
        ButtonTool38.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance153.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool39.SharedPropsInternal.AppearancesSmall.Appearance = Appearance153
        ButtonTool39.SharedPropsInternal.Caption = "Importar"
        ButtonTool39.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance154.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool40.SharedPropsInternal.AppearancesSmall.Appearance = Appearance154
        ButtonTool40.SharedPropsInternal.Caption = "Agregar"
        ButtonTool40.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance155.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool2.InstanceProps.AppearancesLarge.Appearance = Appearance155
        Appearance156.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool2.InstanceProps.AppearancesSmall.Appearance = Appearance156
        Appearance157.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool2.InstanceProps.AppearancesSmall.AppearanceOnToolbar = Appearance157
        Appearance158.ForeColor = System.Drawing.Color.Navy
        Appearance158.ForeColorDisabled = System.Drawing.Color.Navy
        PopupMenuTool2.Settings.Appearance = Appearance158
        Appearance159.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool2.Settings.EditAppearance = Appearance159
        Appearance160.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool2.Settings.ToolAppearance = Appearance160
        Appearance161.Image = 4
        PopupMenuTool2.SharedPropsInternal.AppearancesSmall.Appearance = Appearance161
        PopupMenuTool2.SharedPropsInternal.Caption = "Generar Documento"
        PopupMenuTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        PopupMenuTool2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool41, ButtonTool42, ButtonTool43})
        Appearance162.Image = 4
        ButtonTool44.SharedPropsInternal.AppearancesSmall.Appearance = Appearance162
        ButtonTool44.SharedPropsInternal.Caption = "Generar Factura"
        ButtonTool44.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance163.Image = 4
        ButtonTool45.SharedPropsInternal.AppearancesSmall.Appearance = Appearance163
        ButtonTool45.SharedPropsInternal.Caption = "Generar Boleta"
        ButtonTool45.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance164.Image = 4
        ButtonTool46.SharedPropsInternal.AppearancesSmall.Appearance = Appearance164
        ButtonTool46.SharedPropsInternal.Caption = "Generar Guía"
        ButtonTool48.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool50.SharedPropsInternal.Caption = "ButtonTool2"
        Appearance165.Image = 4
        ButtonTool52.SharedPropsInternal.AppearancesSmall.Appearance = Appearance165
        ButtonTool52.SharedPropsInternal.Caption = "GenDoc"
        ButtonTool52.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.MenuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool29, ButtonTool30, ButtonTool32, ButtonTool33, ButtonTool34, ButtonTool36, ButtonTool37, ButtonTool38, ButtonTool39, ButtonTool40, PopupMenuTool2, ButtonTool44, ButtonTool45, ButtonTool46, ButtonTool48, ButtonTool50, ButtonTool52})
        '
        'UltraToolbarsDockArea6
        '
        Me.UltraToolbarsDockArea6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea6.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea6.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea6.Location = New System.Drawing.Point(2, 25)
        Me.UltraToolbarsDockArea6.Name = "UltraToolbarsDockArea6"
        Me.UltraToolbarsDockArea6.Size = New System.Drawing.Size(1216, 0)
        Me.UltraToolbarsDockArea6.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea7
        '
        Me.UltraToolbarsDockArea7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea7.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea7.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea7.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea7.Name = "UltraToolbarsDockArea7"
        Me.UltraToolbarsDockArea7.Size = New System.Drawing.Size(0, 23)
        Me.UltraToolbarsDockArea7.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea8
        '
        Me.UltraToolbarsDockArea8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea8.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea8.ForeColor = System.Drawing.Color.Navy
        Me.UltraToolbarsDockArea8.Location = New System.Drawing.Point(1218, 2)
        Me.UltraToolbarsDockArea8.Name = "UltraToolbarsDockArea8"
        Me.UltraToolbarsDockArea8.Size = New System.Drawing.Size(0, 23)
        Me.UltraToolbarsDockArea8.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea15
        '
        Me.UltraToolbarsDockArea15.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea15.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea15.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea15.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea15.Name = "UltraToolbarsDockArea15"
        Me.UltraToolbarsDockArea15.Size = New System.Drawing.Size(1220, 0)
        '
        'UltraToolbarsDockArea16
        '
        Me.UltraToolbarsDockArea16.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea16.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea16.Location = New System.Drawing.Point(3, 229)
        Me.UltraToolbarsDockArea16.Name = "UltraToolbarsDockArea16"
        Me.UltraToolbarsDockArea16.Size = New System.Drawing.Size(1220, 0)
        '
        'UltraToolbarsDockArea20
        '
        Me.UltraToolbarsDockArea20.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea20.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea20.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea20.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea20.Name = "UltraToolbarsDockArea20"
        Me.UltraToolbarsDockArea20.Size = New System.Drawing.Size(0, 213)
        '
        'UltraToolbarsDockArea21
        '
        Me.UltraToolbarsDockArea21.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea21.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea21.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea21.Location = New System.Drawing.Point(1223, 16)
        Me.UltraToolbarsDockArea21.Name = "UltraToolbarsDockArea21"
        Me.UltraToolbarsDockArea21.Size = New System.Drawing.Size(0, 213)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1220, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(3, 229)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1220, 0)
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 213)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1223, 16)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 213)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.FichaTop)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1226, 205)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'FichaTop
        '
        Me.FichaTop.Controls.Add(Me.UltraTabSharedControlsPage6)
        Me.FichaTop.Controls.Add(Me.UltraTabPageControl4)
        Me.FichaTop.Controls.Add(Me.UltraTabPageControl8)
        Me.FichaTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FichaTop.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FichaTop.Location = New System.Drawing.Point(2, 2)
        Me.FichaTop.Name = "FichaTop"
        Me.FichaTop.SharedControlsPage = Me.UltraTabSharedControlsPage6
        Me.FichaTop.Size = New System.Drawing.Size(1222, 201)
        Me.FichaTop.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.FichaTop.TabIndex = 0
        UltraTab5.Key = "0"
        UltraTab5.TabPage = Me.UltraTabPageControl4
        UltraTab5.Text = "Datos Generales"
        UltraTab10.Key = "1"
        UltraTab10.TabPage = Me.UltraTabPageControl8
        UltraTab10.Text = "Percepción / Detracción"
        Me.FichaTop.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab10})
        Me.FichaTop.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage6
        '
        Me.UltraTabSharedControlsPage6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage6.Name = "UltraTabSharedControlsPage6"
        Me.UltraTabSharedControlsPage6.Size = New System.Drawing.Size(1220, 178)
        '
        'odRequerimientos
        '
        UltraDataColumn130.DataType = GetType(Boolean)
        UltraDataColumn130.DefaultValue = False
        Me.odRequerimientos.Band.Columns.AddRange(New Object() {UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163})
        '
        'odMaterial
        '
        UltraDataColumn164.DataType = GetType(Boolean)
        UltraDataColumn183.DefaultValue = "False"
        UltraDataColumn185.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192})
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.AprobarToolStripMenuItem, Me.AtenderToolStripMenuItem, Me.EnviarCorreoToolStripMenuItem, Me.RechazarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(136, 158)
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
        'ficOrdenCompra
        '
        Me.ficOrdenCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrdenCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrdenCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOrdenCompra.Location = New System.Drawing.Point(0, 0)
        Me.ficOrdenCompra.Name = "ficOrdenCompra"
        Me.ficOrdenCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrdenCompra.Size = New System.Drawing.Size(1228, 460)
        Me.ficOrdenCompra.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficOrdenCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficOrdenCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1226, 437)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Menu1
        '
        Appearance166.ForeColor = System.Drawing.Color.Navy
        Me.Menu1.Appearance = Appearance166
        Me.Menu1.DesignerFlags = 1
        Me.Menu1.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.Menu1.ImageListLarge = Me.imagenes
        Me.Menu1.ImageListSmall = Me.imagenes
        Me.Menu1.MdiMergeable = False
        Me.Menu1.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        Me.Menu1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.FloatingLocation = New System.Drawing.Point(120, 464)
        UltraToolbar2.FloatingSize = New System.Drawing.Size(222, 96)
        UltraToolbar2.IsMainMenuBar = True
        UltraToolbar2.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool35, PopupMenuTool3, ButtonTool31, ButtonTool1})
        UltraToolbar2.Text = "utMenuDetalle"
        Me.Menu1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Me.Menu1.ToolbarSettings.Appearance = Appearance167
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Me.Menu1.ToolbarSettings.ToolAppearance = Appearance168
        Appearance169.Image = 7
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance169
        ButtonTool9.SharedPropsInternal.Caption = "Importar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool10.SharedPropsInternal.Caption = "Editar"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance170.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        ButtonTool12.SharedPropsInternal.AppearancesSmall.Appearance = Appearance170
        ButtonTool12.SharedPropsInternal.Caption = "Quitar"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool13.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool13.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool14.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance171.Image = 6
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance171
        ButtonTool15.SharedPropsInternal.Caption = "Listar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance172.Image = 2
        ButtonTool16.SharedPropsInternal.AppearancesSmall.Appearance = Appearance172
        ButtonTool16.SharedPropsInternal.Caption = "Generar OI"
        ButtonTool16.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance173.Image = 3
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance173
        ButtonTool17.SharedPropsInternal.Caption = "Ejecutar OI"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool18.SharedPropsInternal.Caption = "Importar"
        ButtonTool18.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance174.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance174
        ButtonTool19.SharedPropsInternal.Caption = "Agregar"
        ButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance175.ForeColor = System.Drawing.Color.Navy
        PopupMenuTool4.Settings.Appearance = Appearance175
        Appearance176.Image = 4
        PopupMenuTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance176
        PopupMenuTool4.SharedPropsInternal.Caption = "Generar Documento"
        PopupMenuTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        PopupMenuTool4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool11, ButtonTool20, ButtonTool21})
        Appearance177.Image = 4
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance177
        ButtonTool22.SharedPropsInternal.Caption = "Generar Factura"
        ButtonTool22.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance178.Image = 4
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance178
        ButtonTool23.SharedPropsInternal.Caption = "Generar Boleta"
        ButtonTool23.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance179.Image = 4
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance179
        ButtonTool24.SharedPropsInternal.Caption = "Generar Guía"
        Me.Menu1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool9, ButtonTool10, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18, ButtonTool19, PopupMenuTool4, ButtonTool22, ButtonTool23, ButtonTool24})
        '
        'frm_OrdenCompraServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1228, 460)
        Me.Controls.Add(Me.ficOrdenCompra)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_OrdenCompraServicio"
        Me.Text = "Orden Compra Servicios"
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.griListaServiciosRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odRequerimientoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.griListaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion15.ResumeLayout(False)
        Me.Agrupacion15.PerformLayout()
        CType(Me.cboCategoriaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        CType(Me.griListaDetalleOrdenCompraServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenCompraServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeListadoServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeListadoServicios.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.utcListadosServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcListadosServicios.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        Me.Agrupacion11.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGenComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrGenerarComprabante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGenerarComprabante.ResumeLayout(False)
        Me.agrGenerarComprabante.PerformLayout()
        CType(Me.chkCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtFechaEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroComprabante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcenIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBloquea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        CType(Me.cheReqAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheEntregasParciales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheAutoAprobar, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Agrupacion13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion13.ResumeLayout(False)
        Me.Agrupacion13.PerformLayout()
        CType(Me.txtNroOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.chkRuc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedorL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonedaL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAtendidoParcialmente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion10.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.FichaTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FichaTop.ResumeLayout(False)
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.MenuContextualReq.ResumeLayout(False)
        CType(Me.ficOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrdenCompra.ResumeLayout(False)
        CType(Me.Menu1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MenuDetalle As ISL.Controles.Menu
    Friend WithEvents odServicio As ISL.Controles.OrigenDatos
    Friend WithEvents odRequerimientoServicio As ISL.Controles.OrigenDatos
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
    Friend WithEvents ColoresTerminado As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresAtendidoParcialmente As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEvaluado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents cboFormaBusqueda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMonedaL As ISL.Controles.ComboMaestros
    Friend WithEvents cboEstadoOrden As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents btnAtenderOC As ISL.Controles.Boton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents ficDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gbeListadoServicios As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents utcListadosServicios As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaServicios As ISL.Controles.Grilla
    Friend WithEvents Agrupacion15 As ISL.Controles.Agrupacion
    Friend WithEvents btnCategoria As ISL.Controles.Boton
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboCategoriaServicios As ISL.Controles.ComboMaestros
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaServiciosRequeridos As ISL.Controles.Grilla
    Friend WithEvents griListaDetalleOrdenCompraServicio As ISL.Controles.Grilla
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea6 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea7 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea8 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea15 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea16 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea20 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea21 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPorcenIGV As ISL.Controles.Texto
    Friend WithEvents cboTipoOrdenCompra As ISL.Controles.ComboMaestros
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents cbCentro As ISL.Controles.Chequear
    Friend WithEvents chkBloquea As ISL.Controles.Chequear
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservaciones As ISL.Controles.Texto
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbNumeroOrden As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumeroOrden As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents odOrdenCompraServicio As ISL.Controles.OrigenDatos
    Friend WithEvents btnEnviarCorreo As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EnviarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkRuc As ISL.Controles.Chequear
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrGenerarComprabante As ISL.Controles.Agrupacion
    Friend WithEvents txtEstadoDoc As ISL.Controles.Texto
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbTipoDocumento As ISL.Controles.ComboMaestros
    Friend WithEvents chkGenComprobante As ISL.Controles.Chequear
    Friend WithEvents txtTC As ISL.Controles.NumeroDecimal
    Friend WithEvents udtFechaEmision As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtNroComprabante As ISL.Controles.Texto
    Friend WithEvents txtSerie As ISL.Controles.Texto
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
    Friend WithEvents btnEnviar As ISL.Controles.Boton
    Friend WithEvents RechazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkCajaChica As ISL.Controles.Chequear
    Friend WithEvents Menu1 As ISL.Controles.Menu
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents rfFechaCotHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents rfFechaCotDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents griCotizacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents odCotizaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnListaCoti As ISL.Controles.Boton
    Friend WithEvents ColoresAtendido As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion13 As ISL.Controles.Agrupacion
    Friend WithEvents rdbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroOrdenCompra As ISL.Controles.Texto
    Friend WithEvents btnCambiarEstado As ISL.Controles.Boton
    Friend WithEvents cheReqAsoc As ISL.Controles.Chequear
    Friend WithEvents cheEntregasParciales As ISL.Controles.Chequear
    Friend WithEvents cheAutoAprobar As ISL.Controles.Chequear
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNotas As ISL.Controles.Texto

End Class
