<DataContract()> _
Public Class e_MetasCombustible
    Implements Ie_MetasCombustible

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idmodelotracto As String
    Private _modelotracto As String
    Private _idmarcatracto As String
    Private _marcatracto As String
    Private _idmodelocarreta As String
    Private _modelocarreta As String
    Private _idmarcacarreta As String
    Private _marcacarreta As String
    Private _ruta As String
    Private _pesos As String
    Private _rendimiento As Double
    Private _distancia As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _Seleccion As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean



    Public Event DatoCambiado()

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
   Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdModeloTracto() As String
        Get
            Return _idmodelotracto
        End Get
        Set(ByVal value As String)
            _idmodelotracto = value
        End Set
    End Property

    <DataMember()> _
   Public Property ModeloTracto() As String
        Get
            Return _modelotracto
        End Get
        Set(ByVal value As String)
            _modelotracto = value
        End Set
    End Property

    <DataMember()> _
    Public Property MarcaTracto() As String
        Get
            Return _marcatracto
        End Get
        Set(ByVal value As String)
            _marcatracto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarcaTracto() As String
        Get
            Return _idmarcatracto
        End Get
        Set(ByVal value As String)
            _idmarcatracto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdModeloCarreta() As String
        Get
            Return _idmodelocarreta
        End Get
        Set(ByVal value As String)
            _idmodelocarreta = value
        End Set
    End Property

    <DataMember()> _
    Public Property ModeloCarreta() As String
        Get
            Return _modelocarreta
        End Get
        Set(ByVal value As String)
            _modelocarreta = value
        End Set
    End Property

    <DataMember()> _
    Public Property MarcaCarreta() As String
        Get
            Return _idmarcacarreta
        End Get
        Set(ByVal value As String)
            _idmarcacarreta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarcaCarreta() As String
        Get
            Return _idmarcacarreta
        End Get
        Set(ByVal value As String)
            _idmarcacarreta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Pesos() As String
        Get
            Return _pesos
        End Get
        Set(ByVal value As String)
            _pesos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Rendimiento() As Double
        Get
            Return _rendimiento
        End Get
        Set(ByVal value As Double)
            _rendimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Distancia() As Double
        Get
            Return _distancia
        End Get
        Set(ByVal value As Double)
            _distancia = value
            RaiseEvent DatoCambiado()
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
Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        Pesos = ""
        Ruta = ""
        Rendimiento = 0
        Distancia = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdModeloTracto As String _
              , ByVal ls_ModeloTracto As String _
              , ByVal ls_MarcaTracto As String _
              , ByVal ls_IdMarcaTracto As String _
              , ByVal ls_IdModeloCarreta As String _
              , ByVal ls_ModeloCarreta As String _
              , ByVal ls_MarcaCarreta As String _
              , ByVal ls_IdMarcaCarreta As String _
              , ByVal ls_Ruta As String _
              , ByVal ls_Pesos As String _
              , ByVal ln_Rendimiento As Double _
              , ByVal ln_Distancia As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
                     )
        _id = ls_Id
        _codigo = ls_Codigo

        _idmodelotracto = ls_IdModeloTracto
        _modelotracto = ls_ModeloTracto
        _marcatracto = ls_MarcaTracto
        _idmarcatracto = ls_IdMarcaTracto

        _idmodelocarreta = ls_IdModeloCarreta
        _modelocarreta = ls_ModeloCarreta
        _idmarcacarreta = ls_MarcaCarreta
        _idmarcacarreta = ls_IdMarcaCarreta

        _ruta = ls_Ruta
        _pesos = ls_Pesos
        _rendimiento = ln_Rendimiento
        _distancia = ln_Distancia
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _Seleccion = False
    End Sub

#End Region

    Public Function Obtener(ByVal metasCombustible As e_MetasCombustible) As e_MetasCombustible Implements Ie_MetasCombustible.Obtener
        Return metasCombustible
    End Function

End Class
