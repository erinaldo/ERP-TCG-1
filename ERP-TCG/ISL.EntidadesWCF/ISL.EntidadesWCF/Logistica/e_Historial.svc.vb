<DataContract()> _
Public Class e_Historial
    Implements Ie_Historial

#Region "Propiedad"

    Private _id As String
    Private _idsubalmacen As String
    Private _codsubalmacen As String
    Private _idalmacen As String
    Private _almacen As String
    Private _idcentro As String
    Private _centro As String
    Private _fecha As Date
    Private _glosa As String
    Private _activo As Boolean

    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public FechaCreacion As Date

    <DataMember()> _
    Public _fechaInicio As Date
    <DataMember()> _
    Public _fechaFin As Date

    <DataMember()> _
    Public lstHistorialInventario As New List(Of e_HistorialInventario)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdSubAlmacen() As String
        Get
            Return _idsubalmacen
        End Get
        Set(ByVal value As String)
            _idsubalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubAlmacen() As String
        Get
            Return _codsubalmacen
        End Get
        Set(ByVal value As String)
            _codsubalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idalmacen
        End Get
        Set(ByVal value As String)
            _idalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _almacen
        End Get
        Set(ByVal value As String)
            _almacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
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
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Glosa As String _
           )
        _id = ls_Id
        _idsubalmacen = ls_IdSubAlmacen
        _fecha = ld_Fecha
        _activo = lb_Activo
        usuariocreacion = ls_UsuarioCreacion
        fechacreacion = ld_FechaCreacion
        _glosa = ls_Glosa
    End Sub
    Public Sub New( _
                ByVal ls_Id As String _
                , ByVal ld_Fecha As Date _
                , ByVal ls_Glosa As String _
                , ByVal ls_IdSubAlmacen As String _
                , ByVal ls_SubAlmacen As String _
                , ByVal ls_IdAlmacen As String _
                , ByVal ls_Almacen As String _
                , ByVal ls_IdCentro As String _
                , ByVal ls_Centro As String _
                , ByVal ls_Activo As String _
              )
        _id = ls_Id
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _idsubalmacen = ls_IdSubAlmacen
        _codsubalmacen = ls_SubAlmacen
        _idalmacen = ls_IdAlmacen
        _almacen = ls_Almacen
        _idcentro = ls_IdCentro
        _centro = ls_Centro
        _activo = ls_Activo
    End Sub
#End Region

    Public Function Obtener(ByVal historial As e_Historial) As e_Historial Implements Ie_Historial.Obtener
        Return historial
    End Function

End Class
