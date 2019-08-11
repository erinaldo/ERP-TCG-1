<DataContract()> _
Public Class e_ReporteOA
    Implements Ie_ReporteOA

#Region "Declaracion de Variables"

    Private _idoa As String
    Private _nrooa As String
    Private _fecha As Date
    Private _glosa As String
    Private _estado As String
    Private _unidadasignada As String
    Private _area As String
    Private _idmaterial As String
    Private _codigomaterial As String
    Private _material As String
    Private _unidadmedida As String
    Private _cantidadped As Double
    Private _cantidadent As Double
    Private _preciounitario As Double
    Private _importe As Double

    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public IdUnidad As String
    <DataMember()> _
    Public IdMaterial As String
    <DataMember()> _
    Public IdAlmacen As String

#End Region

#Region "Popiedades"

    <DataMember()> _
    Public Property IdOA() As String
        Get
            Return _idoa
        End Get
        Set(ByVal value As String)
            _idoa = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOA() As String
        Get
            Return _nrooa
        End Get
        Set(ByVal value As String)
            _nrooa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadAsignada() As String
        Get
            Return _unidadasignada
        End Get
        Set(ByVal value As String)
            _unidadasignada = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    <DataMember()> _
     Public Property IdMat() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
        End Set
    End Property

    <DataMember()> _
     Public Property CodMat() As String
        Get
            Return _codigomaterial
        End Get
        Set(ByVal value As String)
            _codigomaterial = value
        End Set
    End Property

    <DataMember()> _
   Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantPedida() As Double
        Get
            Return _cantidadped
        End Get
        Set(ByVal value As Double)
            _cantidadped = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantEntregada() As Double
        Get
            Return _cantidadent
        End Get
        Set(ByVal value As Double)
            _cantidadent = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        FechaDesde = #1/1/1901#
        FechaHasta = #1/1/1901#
        TipoOperacion = String.Empty
        IdMaterial = String.Empty
        IdUnidad = String.Empty
    End Sub

    Public Sub New(ByVal ls_IdOA As String _
                   , ByVal ls_NroOA As String _
                   , ByVal ld_Fecha As Date _
                   , ByVal ls_Glosa As String _
                   , ByVal ls_Estado As String _
                   , ByVal ls_UnidadAsignada As String _
                   , ByVal ls_Area As String _
                   , ByVal ls_IdMaterial As String _
                   , ByVal ls_CodigoMaterial As String _
                   , ByVal ls_Material As String _
                   , ByVal ls_UnidadMedida As String _
                   , ByVal ln_CantPedida As Double _
                   , ByVal ln_CantEntregada As Double _
                   , ByVal ln_PrecioUnitario As Double _
                   , ByVal ln_Importe As Double _
                   )
        _idoa = ls_IdOA
        _nrooa = ls_NroOA
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _estado = ls_Estado
        _unidadasignada = ls_UnidadAsignada
        _area = ls_Area
        _idmaterial = ls_IdMaterial
        _codigomaterial = ls_CodigoMaterial
        _material = ls_Material
        _unidadmedida = ls_UnidadMedida
        _cantidadped = ln_CantPedida
        _cantidadent = ln_CantEntregada
        _preciounitario = ln_PrecioUnitario
        _importe = ln_Importe
    End Sub



#End Region

    Public Function Obtener(ByVal reporteoa As e_ReporteOA) As e_ReporteOA Implements Ie_ReporteOA.Obtener
        Return reporteoa
    End Function

End Class
