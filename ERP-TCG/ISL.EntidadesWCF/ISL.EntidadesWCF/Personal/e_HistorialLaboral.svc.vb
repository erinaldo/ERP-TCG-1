

<DataContract()> _
Public Class e_HistorialLaboral
    Implements Ie_HistorialLaboral

#Region "Declaracion de Variables"

    Private _id As String
    Private _idTrabajador As String
    Private _fechaIngreso As Date
    Private _fechaCese As Date
    Private _idMotivoCese As String
    Private _observaciones As String
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _idTrabajador = ""
        _fechaIngreso = Date.Now
        _idMotivoCese = String.Empty
        _observaciones = String.Empty
        _activo = True
        _usuariocreacion = ""
    End Sub

    Public Sub New(ByVal id As String _
              , ByVal idTrabajador As String _
              , ByVal fechaIngreso As Date _
              , ByVal fechaCese As Date _
              , ByVal idMotivoCese As String _
              , ByVal observaciones As String _
              , ByVal activo As Boolean _
              , ByVal usuarioCreacion As String _
           )
        _id = id
        _idTrabajador = idTrabajador
        _fechaIngreso = fechaIngreso
        _fechaCese = fechaCese
        _idMotivoCese = idMotivoCese
        _observaciones = observaciones
        _activo = activo
        _usuariocreacion = usuarioCreacion
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
    Public Property IdTrabajador() As String
        Get
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idTrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaIngreso
        End Get
        Set(ByVal value As Date)
            _fechaIngreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCese() As Date
        Get
            Return _fechaCese
        End Get
        Set(ByVal value As Date)
            _fechaCese = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMotivoCese() As String
        Get
            Return _idMotivoCese
        End Get
        Set(ByVal value As String)
            _idMotivoCese = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
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
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_HistorialLaboral
    ''' </summary>
    ''' <param name="historialLaboral"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal historialLaboral As e_HistorialLaboral) As e_HistorialLaboral Implements Ie_HistorialLaboral.Obtener
        Return historialLaboral
    End Function

#End Region

End Class



