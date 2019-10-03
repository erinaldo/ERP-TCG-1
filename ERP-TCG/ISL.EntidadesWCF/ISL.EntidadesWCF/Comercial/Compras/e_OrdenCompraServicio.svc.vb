

<DataContract()> _
Public Class e_OrdenCompraServicio
    Implements Ie_OrdenCompraServicio

#Region "Declaración de variables"

    Private _Id As String
    Private _idOrden As String
    Private _idServicio As String
    Private _Servicio As String
    Private _codServicio As String
    Private _Cantidad As Double
    Private _ValorVenta As Double  'Es el subtotal sin incluir IGV, este se guardará en la BD para cuando es una orden de compra
    Private _Importe As Double 'Es el subtotal con IGV, solo servirá para que el usuario lo visualize.
    Private _PrecioUnitarioSinImp As Double
    Private _PrecioUnitarioConImp As Double
    'Private _PrecioUnitarioDolaresSinImp As Double
    Private _costounitario As Double
    Private _IndicadorIgv As Boolean
    Private _Activo As Boolean
    Private _Seleccion As Boolean
    Private _idArea As String
    Private _Area As String
    Private _Glosa As String
    Private _Notas As String
    Private _idCentroCosto As String
    Private _CentroCosto As String
    Private _idReqServicio As String
    Private _CodReqServicio As String

    <DataMember()> _
    Public IdEquipo As String

    <DataMember()> _
    Public TipoOrdenCompra As String ' Si es RM:Requerimiento de materiales,  M:Materiales , RS:Requerimientos de servicios , S: Servicios , C:Cotizaciones  ---Este campo me permite identificar que registro pertenece a que listado segun tipo.

    <DataMember()> _
    Public TipoOperacion As String
    Private _Pos As Integer 'Para saber la posicion de cada registro y controlar si va o no va incluido el IGV segun la posicion.
    <DataMember()>
    Public PrefijoID As String = ""


#End Region

#Region "Propiedades"

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
    Public Property PrecioUnitarioSinImp() As Double
        Get
            Return _PrecioUnitarioSinImp
        End Get
        Set(ByVal value As Double)
            _PrecioUnitarioSinImp = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitarioConImp() As Double
        Get
            Return _PrecioUnitarioConImp
        End Get
        Set(ByVal value As Double)
            _PrecioUnitarioConImp = value
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

    '<DataMember()> _
    'Public Property PrecioUnitarioDolaresSinImp() As Double
    '    Get
    '        Return _PrecioUnitarioDolaresSinImp
    '    End Get
    '    Set(ByVal value As Double)
    '        _PrecioUnitarioDolaresSinImp = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
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
    Public Property IdServicio() As String
        Get
            Return _idServicio
        End Get
        Set(ByVal value As String)
            _idServicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Servicio() As String
        Get
            Return _Servicio
        End Get
        Set(ByVal value As String)
            _Servicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoServicio() As String
        Get
            Return _codServicio
        End Get
        Set(ByVal value As String)
            _codServicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Double)
            _Cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorVenta() As Double
        Get
            Return _ValorVenta
        End Get
        Set(ByVal value As Double)
            _ValorVenta = value
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
    Public Property IdRequerimientoServicio() As String
        Get
            Return _idReqServicio
        End Get
        Set(ByVal value As String)
            _idReqServicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoRequerimiento() As String
        Get
            Return _CodReqServicio
        End Get
        Set(ByVal value As String)
            _CodReqServicio = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    '-------------------------------PARA LOS DETALLE DE ORDEN DE COMPRA -------------------------------------
    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal IdOrden As String, _
            ByVal IdServicio As String, _
            ByVal Servicio As String, _
            ByVal Cantidad As Double, _
            ByVal PrecioUnitarioConImp As Double, _
            ByVal CambioMoneda As Double, _
            ByVal ValorVenta As Double, _
            ByVal IndicadorIgv As Boolean, _
            ByVal Activo As Boolean, _
            ByVal Porcentaje As Double, _
            ByVal Glosa As String, _
            ByVal Notas As String, _
            ByVal CodigoRequerimiento As String, _
            ByVal IdArea As String, _
            ByVal Area As String, _
            ByVal CodigoServicio As String, _
            ByVal IdRequerimientoServicio As String, _
            ByVal TipoMoneda As String, _
            ByVal ls_IdEquipo As String _
            ) '23 paranetros

        _Seleccion = Seleccion
        _Id = Id
        _idOrden = IdOrden
        _idServicio = IdServicio
        _Servicio = Servicio
        _Cantidad = Cantidad
        _PrecioUnitarioSinImp = IIf(IndicadorIgv, Math.Round(PrecioUnitarioConImp / (Porcentaje + 1), 4), Math.Round(PrecioUnitarioConImp, 4)) 'PrecioUnitarioSinImp
        '_PrecioUnitarioConImp = _PrecioUnitarioSinImp * (Porcentaje + 1)
        _PrecioUnitarioConImp = PrecioUnitarioConImp
        _Importe = Cantidad * _PrecioUnitarioConImp
        _ValorVenta = ValorVenta 'Es el subtotal sin incluir IGV        


        'If TipoMoneda = "SOLES" Then
        '    _PrecioUnitarioSolesSinImp = PrecioUnitarioSinImp
        '    _PrecioUnitarioDolaresSinImp = Math.Round(PrecioUnitarioSinImp / CambioMoneda, 4)
        'Else
        '    _PrecioUnitarioSolesSinImp = Math.Round(PrecioUnitarioSinImp * CambioMoneda, 4)
        '    _PrecioUnitarioDolaresSinImp = PrecioUnitarioSinImp
        'End If

        _IndicadorIgv = IndicadorIgv
        _Activo = Activo
        _Glosa = Glosa
        _Notas = Notas
        _CodReqServicio = CodigoRequerimiento
        _idReqServicio = IdRequerimientoServicio
        _idArea = IdArea
        _Area = Area
        _codServicio = CodigoServicio

        IdEquipo = ls_IdEquipo

    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ordenCompraServicio As e_OrdenCompraServicio) As e_OrdenCompraServicio Implements Ie_OrdenCompraServicio.Obtener
        Return ordenCompraServicio
    End Function

#End Region

End Class


