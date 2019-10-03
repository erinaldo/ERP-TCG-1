

<DataContract()> _
Public Class e_ProcesoNegocio
    Implements Ie_ProcesoNegocio

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _indicador As Integer
    Private _protegido As Integer
    Private _activo As Boolean
    Private _seguridad As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public leActividadNegocio As New List(Of e_ActividadNegocio)
    <DataMember()> _
    Public leFlujoCaja As New List(Of e_FlujoCaja)

    Public Event DatoCambiado()
    'Public Event DatoCambiado As System.EventHandler

#End Region

#Region "Constructores"

    Public Sub New()
        _id = ""
        _codigo = ""
        _nombre = ""
        _indicador = -1
        _protegido = 1
        _seguridad = True
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal Codigo As String _
              , ByVal Nombre As String _
              , ByVal Indicador As Boolean _
              , ByVal protegido As Integer _
              , ByVal lb_Seguridad As Boolean _
              , ByVal Activo As Boolean _
              , ByVal UsuarioCreacion As String _
           )
        _id = Id
        _codigo = Codigo
        _nombre = Nombre
        _indicador = IIf(Indicador, 1, 0)
        _protegido = protegido
        _seguridad = lb_Seguridad
        _activo = Activo
        _usuariocreacion = UsuarioCreacion
    End Sub

#End Region

#Region "Propiedad"

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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Indicador() As Integer
        Get
            Return _indicador
        End Get
        Set(ByVal value As Integer)
            _indicador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Seguridad() As Boolean
        Get
            Return _seguridad
        End Get
        Set(ByVal value As Boolean)
            _seguridad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Protegido() As Integer
        Get
            Return _protegido
        End Get
        Set(ByVal value As Integer)
            _protegido = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
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

#End Region

    Public Function Obtener(ByVal procesoNegocio As e_ProcesoNegocio) As e_ProcesoNegocio Implements Ie_ProcesoNegocio.Obtener
        Return procesoNegocio
    End Function

End Class


