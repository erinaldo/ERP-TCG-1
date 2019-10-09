''' <summary>
''' Entidad que contiene los detalles de la facturación de combustible
''' </summary>
''' <remarks></remarks>
<DataContract(), KnownType(GetType(e_DetalleDocumento)), KnownType(GetType(e_MovimientoDocumento))> _
Public Class e_DetalleDocumentoCombustible
    Implements Ie_DetalleDocumentoCombustible

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ld_FechaTanqueo As Date _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdEmpresaGrifo As String _
              , ByVal ln_NroLinea As Integer _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_PrecioUnit As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_SerieComprobante As String _
              , ByVal ls_NumeroComprobante As String _
              , ByVal ln_Igv As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal lb_IndGravado As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_CodigoMaterial As String _
              , ByVal ls_PrecioIgv As Double _
              , ByVal ls_NombreMaterial As String _
              , ByVal ln_Valor As Double _
              , ByVal ls_NroVale As String _
              , ByVal ls_PlacaVeh As String _
           )
        _id = ls_Id
        _IdViaje = ls_IdViaje
        _IdVehiculo = ls_IdVehiculo
        _IdMaterial = ls_IdMaterial
        _IdGrifo = ls_IdEmpresaGrifo
        _nroLinea = ln_NroLinea
        _cantidad = ln_Cantidad
        _preciounit = ln_PrecioUnit
        _igv = ln_Igv
        _activo = lb_Activo
        _indGravado = lb_IndGravado
        _usuariocreacion = ls_UsuarioCreacion
        _CodMaterial = ls_CodigoMaterial
        _PrecioIgv = ls_PrecioIgv
        _Material = ls_NombreMaterial
        _valor = ln_Valor
    End Sub

#End Region

#Region "Declaración de variables"

    Private _id As String
    Private _nroLinea As Integer
    Private _cantidad As Double
    Private _preciounit As Double
    Private _igv As Double
    Private _activo As Boolean
    Private _indGravado As Boolean
    Private _PrecioIgv As Double
    Private _usuariocreacion As String
    Private _Seleccion As Boolean
    Private _IdRegConsumoCombustible As String
    Private _PlacaVeh As String
    Private _NroVale As String
    Private _Material As String
    Private _IdViaje As String
    Private _IdVehiculo As String
    Private _IdMaterial As String
    Private _IdGrifo As String
    Private _CodMaterial As String
    Private _FechaTanqueo As Date
    Private _CodViaje As String
    Private _idDetalleDocumento As String
    Private _SaldoReferencia As Double
    Private _unidadmedida As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property SaldoReferencia() As String
        Get
            Return _SaldoReferencia
        End Get
        Set(ByVal value As String)
            _SaldoReferencia = value
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
    Public Property IdRegConsumoCombustible() As String
        Get
            Return _IdRegConsumoCombustible
        End Get
        Set(ByVal value As String)
            _IdRegConsumoCombustible = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaTanqueo() As Date
        Get
            Return _FechaTanqueo
        End Get
        Set(ByVal value As Date)
            _FechaTanqueo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _IdViaje
        End Get
        Set(ByVal value As String)
            _IdViaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodViaje() As String
        Get
            Return _CodViaje
        End Get
        Set(ByVal value As String)
            _CodViaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _IdVehiculo
        End Get
        Set(ByVal value As String)
            _IdVehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _IdMaterial
        End Get
        Set(ByVal value As String)
            _IdMaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaGrifo() As String
        Get
            Return _IdGrifo
        End Get
        Set(ByVal value As String)
            _IdGrifo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroLinea() As Integer
        Get
            Return _nroLinea
        End Get
        Set(ByVal value As Integer)
            _nroLinea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnit() As Double
        Get
            Return _preciounit
        End Get
        Set(ByVal value As Double)
            _preciounit = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDetalleDocumento() As String
        Get
            Return _idDetalleDocumento
        End Get
        Set(ByVal value As String)
            _idDetalleDocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Igv() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndGravado() As Boolean
        Get
            Return _indGravado
        End Get
        Set(ByVal value As Boolean)
            _indGravado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodMaterial() As String
        Get
            Return _CodMaterial
        End Get
        Set(ByVal value As String)
            _CodMaterial = value
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
    Public Property PrecioIGV() As Double
        Get
            Return _PrecioIgv
        End Get
        Set(ByVal value As Double)
            _PrecioIgv = value
        End Set
    End Property

    Private _valor As Double
    <DataMember()> _
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroVale() As String
        Get
            Return _NroVale
        End Get
        Set(ByVal value As String)
            _NroVale = value
        End Set
    End Property

    <DataMember()> _
    Public Property PlacaVeh() As String
        Get
            Return _PlacaVeh
        End Get
        Set(ByVal value As String)
            _PlacaVeh = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Public Function Obtener(ByVal detalleDocumentoCombustible As e_DetalleDocumentoCombustible) As e_DetalleDocumentoCombustible Implements Ie_DetalleDocumentoCombustible.Obtener
        Return detalleDocumentoCombustible
    End Function

#End Region

End Class
