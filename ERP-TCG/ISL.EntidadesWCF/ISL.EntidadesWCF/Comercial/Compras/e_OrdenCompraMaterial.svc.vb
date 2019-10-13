

<DataContract()> _
Public Class e_OrdenCompraMaterial
    Implements Ie_OrdenCompraMaterial

#Region "Declaración de variables"

    Private _Id As String
    Private _idOrden As String
    Private _idOSMaterial As String

    Private _CantidadMaterial As Double
    Private _preciototal As Double
    Private _costounitario As Double
    Private _PrecioUnitario As Double
    Private _PrecioUnitarioDolaresSinImp As Double
    Private _PrecioUnitarioSolesSinImp As Double
    Private _idAlmacen As String
    Private _Almacen As String
    Private _idSubAlmacen As String

    Private _CantidadMaterialAAtender As Double 'Se utilizará cuando se atienda una orden de compra generandoce una orden de ingreso. Se manipulara cuando se modifique el detalle de la orden de compra
    Private _CantidadMaterialPendiente As Decimal   'Son los que todavia no son atendidos(Por atender).Se utilizará cuando se atienda una orden de compra generandoce una orden de ingreso. Se manipulara cuando se modifique el detalle de la orden de compra
    Private _IndicadorIgv As Boolean
    Private _PrecioOriginal As Double
    Private _Activo As Boolean
    Private _Seleccion As Boolean
    Private _IdMaterial As String
    Private _Material As String
    Private _codMaterial As String
    Private _codnombre As String
    Private _Servicio As String
    Private _idArea As String
    Private _Area As String
    Private _Glosa As String
    Private _Notas As String
    Private _idCentroCosto As String
    Private _CentroCosto As String
    Private _idUnidadMedida As String
    Private _UnidadMedida As String
    Private _tipoUnidadMedida As String

    Private _RequerimientoMaterial As New e_RequerimientoMaterial
    <DataMember()> _
    Public TipoOrdenCompra As String ' Si es RM:Requerimiento de materiales,  M:Materiales , RS:Requerimientos de servicios , S: Servicios , C:Cotizaciones  ---Este campo me permite identificar que registro pertenece a que listado segun tipo.
    Private _Pos As Integer 'Para saber la posicion de cada registro y controlar si va o no va incluido el IGV segun la posicion.
    <DataMember()> _
    Public IdCotizacionDetalle As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public ListaOCMaterial_OSMaterial As New List(Of e_OCMaterial_OSMaterial)

    <DataMember()>
    Public TipoOperacion As String

    <DataMember()>
    Public Property CostoAdm() As Double

#End Region

#Region "Propiedades"

    Friend PrecioUnitarioConImp As Double

    <DataMember()> _
    Public Property Pos() As Integer
        Get
            Return _Pos
        End Get
        Set(ByVal value As Integer)
            _Pos = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterialPendiente() As Decimal
        Get
            Return _CantidadMaterialPendiente
        End Get
        Set(ByVal value As Decimal)
            _CantidadMaterialPendiente = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioTotal() As Double
        Get
            Return _preciototal
        End Get
        Set(ByVal value As Double)
            _preciototal = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoUnitario() As Double
        Get
            Return _costounitario
        End Get
        Set(ByVal value As Double)
            _costounitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitarioSolesSinImp() As Double
        Get
            Return _PrecioUnitarioSolesSinImp
        End Get
        Set(ByVal value As Double)
            _PrecioUnitarioSolesSinImp = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitarioDolaresSinImp() As Double
        Get
            Return _PrecioUnitarioDolaresSinImp
        End Get
        Set(ByVal value As Double)
            _PrecioUnitarioDolaresSinImp = value
        End Set
    End Property

    <DataMember()> _
    Public Property CentroCosto() As String
        Get
            Return _CentroCosto
        End Get
        Set(ByVal value As String)
            _CentroCosto = value
        End Set
    End Property


    <DataMember()> _
    Public Property IdCentroCosto() As String
        Get
            Return _idCentroCosto
        End Get
        Set(ByVal value As String)
            _idCentroCosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenSalidaMaterial() As String
        Get
            Return _idOSMaterial
        End Get
        Set(ByVal value As String)
            _idOSMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Notas() As String
        Get
            Return _Notas
        End Get
        Set(ByVal value As String)
            _Notas = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idArea
        End Get
        Set(ByVal value As String)
            _idArea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrden() As String
        Get
            Return _idOrden
        End Get
        Set(ByVal value As String)
            _idOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _IdMaterial
        End Get
        Set(ByVal value As String)
            _IdMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _Material
        End Get
        Set(ByVal value As String)
            _Material = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMaterial() As String
        Get
            Return _codMaterial
        End Get
        Set(ByVal value As String)
            _codMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoNombre() As String
        Get
            Return _codMaterial
        End Get
        Set(ByVal value As String)
            _codMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterial() As Double
        Get
            Return _CantidadMaterial
        End Get
        Set(ByVal value As Double)
            _CantidadMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Double)
            _PrecioUnitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idSubAlmacen
        End Get
        Set(ByVal value As String)
            _idSubAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(ByVal value As String)
            _idAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _Almacen
        End Get
        Set(ByVal value As String)
            _Almacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterialAAtender() As Double
        Get
            Return _CantidadMaterialAAtender
        End Get
        Set(ByVal value As Double)
            _CantidadMaterialAAtender = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorIgv() As Boolean
        Get
            Return _IndicadorIgv
        End Get
        Set(ByVal value As Boolean)
            _IndicadorIgv = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idUnidadMedida
        End Get
        Set(ByVal value As String)
            _idUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _UnidadMedida
        End Get
        Set(ByVal value As String)
            _UnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _tipoUnidadMedida
        End Get
        Set(ByVal value As String)
            _tipoUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRequerimientoMaterial() As String
        Get
            Return _RequerimientoMaterial.Id
        End Get
        Set(ByVal value As String)
            _RequerimientoMaterial.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoRequerimiento() As String
        Get
            Return _RequerimientoMaterial.CodigoRequerimiento
        End Get
        Set(ByVal value As String)
            _RequerimientoMaterial.CodigoRequerimiento = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()
        _Activo = True
    End Sub

    '-------------------------------PARA LOS DETALLE DE ORDEN DE COMPRA -------------------------------------
    Sub New(ByVal lb_Seleccion As Boolean,
            ByVal ls_Id As String,
            ByVal ls_IdOrden As String,
            ByVal ls_IdMaterial As String,
            ByVal ls_Material As String,
            ByVal ld_CantidadMaterial As Double,
            ByVal ld_CostoAdm As Double,
            ByVal ld_CostoUnitario As Double,
            ByVal ld_CambioMoneda As Double,
            ByVal ld_PrecioTotal As Double,
            ByVal ls_IdAlmacen As String,
            ByVal ls_Almacen As String,
            ByVal ld_CantidadMaterialPendiente As Decimal,
            ByVal lb_IndicadorIgv As Boolean,
            ByVal lb_Activo As Boolean,
            ByVal ls_IdUnidadMedida As String,
            ByVal ls_UnidadMedida As String,
            ByVal ls_IdTipoUnidadMedida As String,
            ByVal ld_Porcentaje As Double,
            ByVal ls_Glosa As String,
             ByVal ls_Notas As String,
            ByVal ls_CodigoRequerimiento As String,
            ByVal ls_IdArea As String,
            ByVal ls_Area As String,
            ByVal ls_CodigoMaterial As String,
            ByVal ls_IdRequerimientoMaterial As String,
            ByVal ls_TipoMoneda As String,
            ByVal ls_IdSubAlmacen As String) '23 paranetros

        _Seleccion = lb_Seleccion
        _Id = ls_Id
        _idOrden = ls_IdOrden
        _IdMaterial = ls_IdMaterial
        _Material = ls_Material
        _CantidadMaterial = ld_CantidadMaterial
        _costounitario = ld_CostoUnitario
        'If lb_IndicadorIgv Then
        _PrecioUnitario = ld_PrecioTotal / CantidadMaterial
        'End If
        CostoAdm = ld_CostoAdm
        '_ValorVenta = ValorVenta 'Es el subtotal sin incluir IGV        
        '_Importe = Math.Round(_PrecioUnitarioConImp * CantidadMaterial, 4)
        _preciototal = ld_PrecioTotal
        If ls_TipoMoneda = "SOLES" Then
            _PrecioUnitarioSolesSinImp = _costounitario
            _PrecioUnitarioDolaresSinImp = Math.Round(_costounitario / ld_CambioMoneda, 4)
        Else
            _PrecioUnitarioSolesSinImp = Math.Round(_costounitario * ld_CambioMoneda, 4)
            _PrecioUnitarioDolaresSinImp = _costounitario
        End If

        _idAlmacen = ls_IdAlmacen
        _Almacen = ls_Almacen
        _CantidadMaterialPendiente = ld_CantidadMaterialPendiente
        _IndicadorIgv = lb_IndicadorIgv
        _Activo = lb_Activo
        _idUnidadMedida = ls_IdUnidadMedida
        _UnidadMedida = ls_UnidadMedida
        _tipoUnidadMedida = ls_IdTipoUnidadMedida
        _Glosa = ls_Glosa
        _Notas = ls_Notas
        _RequerimientoMaterial.CodigoRequerimiento = ls_CodigoRequerimiento
        _RequerimientoMaterial.Id = ls_IdRequerimientoMaterial
        _idArea = ls_IdArea
        _Area = ls_Area
        _codMaterial = ls_CodigoMaterial
        _idSubAlmacen = ls_IdSubAlmacen

    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ordenCompraMaterial As e_OrdenCompraMaterial) As e_OrdenCompraMaterial Implements Ie_OrdenCompraMaterial.Obtener
        Return ordenCompraMaterial
    End Function

#End Region

End Class


