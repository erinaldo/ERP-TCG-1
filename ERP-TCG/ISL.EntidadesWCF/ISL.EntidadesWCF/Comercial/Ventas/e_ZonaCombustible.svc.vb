
Public Class e_ZonaCombustible
    Implements Ie_ZonaCombustible

#Region "Declaración de variables"

    Private _Id As String
    Private _IdRuta As String
    Private _IdOrigenRuta As String
    Private _IdDestinoRuta As String
    Private _OrigenRuta As String
    Private _DestinoRuta As String
    Private _KilometrosRuta As Double
    Private _IdFlota As String
    Private _Orden As Integer
    Private _IdOrigen As String
    Private _IdDestino As String
    Private _Origen As String
    Private _Destino As String
    Private _Kilometros As Double
    Private _Activo As Boolean
    Private _UsuarioCreacion As String
    Private _UsuarioModifica As String
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Propiedades"

    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property IdRuta() As String
        Get
            Return _IdRuta
        End Get
        Set(ByVal value As String)
            _IdRuta = value
        End Set
    End Property

    Public Property IdOrigenRuta() As String
        Get
            Return _IdOrigenRuta
        End Get
        Set(ByVal value As String)
            _IdOrigenRuta = value
        End Set
    End Property

    Public Property IdDestinoRuta() As String
        Get
            Return _IdDestinoRuta
        End Get
        Set(ByVal value As String)
            _IdDestinoRuta = value
        End Set
    End Property

    Public Property OrigenRuta() As String
        Get
            Return _OrigenRuta
        End Get
        Set(ByVal value As String)
            _OrigenRuta = value
        End Set
    End Property

    Public Property DestinoRuta() As String
        Get
            Return _DestinoRuta
        End Get
        Set(ByVal value As String)
            _DestinoRuta = value
        End Set
    End Property

    Public Property KilometrosRuta() As Double
        Get
            Return _KilometrosRuta
        End Get
        Set(ByVal value As Double)
            _KilometrosRuta = value
        End Set
    End Property

    Public Property IdFlota() As String
        Get
            Return _IdFlota
        End Get
        Set(ByVal value As String)
            _IdFlota = value
        End Set
    End Property

    Public Property Orden() As Integer
        Get
            Return _Orden
        End Get
        Set(ByVal value As Integer)
            _Orden = value
        End Set
    End Property

    Public Property IdOrigen() As String
        Get
            Return _IdOrigen
        End Get
        Set(ByVal value As String)
            _IdOrigen = value
        End Set
    End Property

    Public Property IdDestino() As String
        Get
            Return _IdDestino
        End Get
        Set(ByVal value As String)
            _IdDestino = value
        End Set
    End Property

    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property

    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property


    Public Property Kilometros() As Double
        Get
            Return _Kilometros
        End Get
        Set(ByVal value As Double)
            _Kilometros = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()

        TipoOperacion = ""
        _Id = ""
        _IdRuta = ""
        _IdFlota = ""
        _Orden = 0
        _IdOrigen = ""
        _IdDestino = ""
        _Activo = True
        _UsuarioCreacion = ""
        _UsuarioModifica = ""
        _Kilometros = 0.0
        _KilometrosRuta = 0
        _IdOrigenRuta = ""
        _IdDestinoRuta = ""
        _Origen = ""
        _Destino = ""
        _OrigenRuta = ""
        _DestinoRuta = ""
    End Sub

#End Region

#Region "Constructor"

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdRuta As String _
          , ByVal ls_IdOrigenRuta As String _
          , ByVal ls_IdDestinoRuta As String _
          , ByVal ls_OrigenRuta As String _
          , ByVal ls_DestinoRuta As String _
          , ByVal ld_KilometrosRuta As Double _
          , ByVal ls_IdFlota As String _
          , ByVal li_Orden As Integer _
          , ByVal ls_IdOrigen As String _
          , ByVal ls_IdDestino As String _
          , ByVal ls_Origen As String _
          , ByVal ls_Destino As String _
          , ByVal ld_Kilometros As Double _
          , ByVal lb_Activo As Boolean _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ls_UsuarioModifica As String _
       )
        _Id = ls_Id
        _IdRuta = ls_IdRuta
        _IdOrigenRuta = ls_IdOrigenRuta
        _IdDestinoRuta = ls_IdDestinoRuta
        _OrigenRuta = ls_OrigenRuta
        _DestinoRuta = ls_DestinoRuta
        _KilometrosRuta = ld_KilometrosRuta
        _IdFlota = ls_IdFlota
        _Orden = li_Orden
        _IdOrigen = ls_IdOrigen
        _IdDestino = ls_IdDestino
        _Origen = ls_Origen
        _Destino = ls_Destino
        _Kilometros = ld_Kilometros
        _Activo = lb_Activo
        _UsuarioCreacion = ls_UsuarioCreacion
        _UsuarioModifica = ls_UsuarioModifica
    End Sub

#End Region

    Public Function Obtener(ByVal zonacombustible As e_ZonaCombustible) As e_ZonaCombustible Implements Ie_ZonaCombustible.Obtener
        Return zonacombustible
    End Function

End Class
