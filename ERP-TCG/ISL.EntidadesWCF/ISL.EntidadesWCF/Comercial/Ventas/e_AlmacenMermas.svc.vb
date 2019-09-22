' NOTA: si cambia aquí el nombre de clase "e_AlmacenMermas", también debe actualizar la referencia a "e_AlmacenMermas" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_AlmacenMermas
    Implements Ie_AlmacenMermas

#Region "Propiedad"

    Private _id As String
    Private _idingresosalidamermas As String
    Private _material As New e_Material
    Private _idunidadmedida As String
    Private _factorconversion As Double
    Private _usuariocreacion As String
    Private _fechamodificacion As Date
    Private _precioventa As Double
    Private _stock As Double
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdCentro As String
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdIngresoSalidaMermas() As String
        Get
            Return _idingresosalidamermas
        End Get
        Set(ByVal value As String)
            _idingresosalidamermas = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _material.Id
        End Get
        Set(ByVal value As String)
            _material.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material.Nombre
        End Get
        Set(ByVal value As String)
            _material.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property FactorConversion() As Double
        Get
            Return _factorconversion
        End Get
        Set(ByVal value As Double)
            _factorconversion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioVenta() As Double
        Get
            Return _precioventa
        End Get
        Set(ByVal value As Double)
            _precioventa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Stock() As Double
        Get
            Return _stock
        End Get
        Set(ByVal value As Double)
            _stock = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        Id = ""
        IdIngresoSalidaMermas = ""
        TipoOperacion = ""
        IdMaterial = ""
        PrecioVenta = 0
        Stock = 0
        FactorConversion = 0
        IdUnidadMedida = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdIngresoSalidaMermas As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ln_FactorConversion As Double _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_PrecioVenta As Double _
              , ByVal ln_Stock As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Material As String)
        _id = ls_Id
        _idingresosalidamermas = ls_IdIngresoSalidaMermas
        _material.Id = ls_IdMaterial
        _material.Nombre = ls_Material
        _idunidadmedida = ls_IdUnidadMedida
        _factorconversion = ln_FactorConversion
        _usuariocreacion = ls_UsuarioCreacion
        _precioventa = ln_PrecioVenta
        _stock = ln_Stock
        _activo = lb_Activo
    End Sub

#End Region

End Class
