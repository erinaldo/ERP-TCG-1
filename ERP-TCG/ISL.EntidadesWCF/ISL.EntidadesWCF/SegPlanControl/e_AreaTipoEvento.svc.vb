' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_AreaTipoEvento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_AreaTipoEvento.svc o e_AreaTipoEvento.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_AreaTipoEvento
    Implements Ie_AreaTipoEvento
    Implements IEquatable(Of e_AreaTipoEvento)

#Region "Propiedad"
    Private _id As String
    Private _codigo As String
    Private _idtipoevento As String
    Private _tipoevento As String
    Private _idtipo As String
    Private _tipo As String
    Private _idarea As String
    Private _area As String
    Private _glosa As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    Public TipoOperacion As String
    Public Modificado As Boolean

    Event DatoCambiado()

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
    Public Property IdTipoEvento() As String
        Get
            Return _idtipoevento
        End Get
        Set(ByVal value As String)
            _idtipoevento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoEvento() As String
        Get
            Return _tipoevento
        End Get
        Set(ByVal value As String)
            _tipoevento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipo() As String
        Get
            Return _idtipo
        End Get
        Set(ByVal value As String)
            _idtipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idArea
        End Get
        Set(ByVal value As String)
            _idArea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub
#End Region

    Public Sub DoWork() Implements Ie_AreaTipoEvento.DoWork
    End Sub

    Public Overloads Function Equals(ByVal oeAreaTipoEvento As e_AreaTipoEvento) _
    As Boolean Implements System.IEquatable(Of e_AreaTipoEvento).Equals
        If Me.IdArea.Trim = oeAreaTipoEvento.IdArea.Trim Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
