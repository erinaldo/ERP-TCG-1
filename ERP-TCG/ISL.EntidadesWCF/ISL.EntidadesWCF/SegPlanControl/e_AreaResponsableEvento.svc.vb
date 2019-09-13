' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_AreaResponsableEvento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_AreaResponsableEvento.svc o e_AreaResponsableEvento.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_AreaResponsableEvento
    Implements Ie_AreaResponsableEvento
    Implements IEquatable(Of e_AreaResponsableEvento)

#Region "Propiedad"
    Private _id As String
    Private _codigo As String
    Private _idevento As String
    Private _codigoevento As String
    Private _idtipoevento As String
    Private _tipoevento As String
    Private _idtipo As String
    Private _tipo As String
    Private _idarea As String
    Private _area As String
    Private _glosa As String
    Private _idviaje As String
    Private _codigoviaje As String
    Private _tracto As String
    Private _fechaincidencia As Date
    Private _descripcion As String
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

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
    Public Property IdEvento() As String
        Get
            Return _idevento
        End Get
        Set(ByVal value As String)
            _idevento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoEvento() As String
        Get
            Return _codigoevento
        End Get
        Set(ByVal value As String)
            _codigoevento = value
            RaiseEvent DatoCambiado()
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
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
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
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoViaje() As String
        Get
            Return _codigoviaje
        End Get
        Set(ByVal value As String)
            _codigoviaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _tracto
        End Get
        Set(ByVal value As String)
            _tracto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIncidencia() As Date
        Get
            Return _fechaincidencia
        End Get
        Set(ByVal value As Date)
            _fechaincidencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdEvento As String _
              , ByVal ls_IdTipoEvento As String _
              , ByVal ls_IdArea As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idevento = ls_IdEvento
        _idtipoevento = ls_IdTipoEvento
        _idarea = ls_IdArea
        '_area = ls_Area
        '_tipoevento = ls_TipoEvento
        '_prefijo = ls_Prefijo
        '_correlativo = ls_Correlativo
        '_tipo = ls_Tipo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
    End Sub

#End Region

    Public Overloads Function Equals(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) _
    As Boolean Implements System.IEquatable(Of e_AreaResponsableEvento).Equals
        If Me.IdArea.Trim = oeAreaResponsableEvento.IdArea.Trim Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DoWork() Implements Ie_AreaResponsableEvento.DoWork
    End Sub

End Class
