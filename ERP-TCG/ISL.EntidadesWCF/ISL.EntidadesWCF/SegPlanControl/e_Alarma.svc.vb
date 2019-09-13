' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Alarma" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Alarma.svc o e_Alarma.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Alarma
    Implements Ie_Alarma
    Implements IEquatable(Of e_Alarma)

#Region "Propiedad"
    Private _id As String
    Private _codigo As String
    Private _idviaje As String
    Private _idtipoevento As String
    Private _tipoevento As String
    Private _idtipo As String
    Private _tipo As String
    Private _idoperador As String
    Private _operador As String
    Private _fechahora As Date
    Private _descripcion As String
    Private _idubicacion As String
    Private _ubicacion As String
    Private _referencialugar As String
    Private _observacion As String
    Private _estado As String
    Private _nombreestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    <DataMember()> _
    Public Identificador As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public CodigoViaje As String
    <DataMember()> _
    Public Origen As String
    <DataMember()> _
    Public Destino As String
    <DataMember()> _
    Public Escala As String
    <DataMember()> _
    Public Piloto As String
    <DataMember()> _
    Public Copiloto As String
    <DataMember()> _
    Public Tracto As String
    <DataMember()> _
    Public TipoVehiculo As String
    <DataMember()> _
    Public Carreta As String
    <DataMember()> _
    Public Fecha As DateTime
    <DataMember()> _
    Public Cliente As String
    <DataMember()> _
    Public PesoToneladas As Decimal
    <DataMember()> _
    Public CargaMaterial As String

    <DataMember()> _
    Public leAreaAlarma As New List(Of e_AreaResponsableEvento)

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdOperador() As String
        Get
            Return _idoperador
        End Get
        Set(ByVal value As String)
            _idoperador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Operador() As String
        Get
            Return _operador
        End Get
        Set(ByVal value As String)
            _operador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaHora() As Date
        Get
            Return _fechahora
        End Get
        Set(ByVal value As Date)
            _fechahora = value
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

    <DataMember()> _
    Public Property IdUbicacion() As String
        Get
            Return _idubicacion
        End Get
        Set(ByVal value As String)
            _idubicacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ReferenciaLugar() As String
        Get
            Return _referencialugar
        End Get
        Set(ByVal value As String)
            _referencialugar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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
    Public Property NombreEstado() As String
        Get
            Return _nombreestado
        End Get
        Set(ByVal value As String)
            _nombreestado = value
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

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdTipoEvento As String _
              , ByVal ls_TipoEvento As String _
              , ByVal ls_IdTipo As String _
              , ByVal ls_Tipo As String _
              , ByVal ls_IdOperador As String _
              , ByVal ld_FechaHora As Date _
              , ByVal ls_Descripcion As String _
              , ByVal ls_IdUbicacion As String _
              , ByVal ls_ReferenciaLugar As String _
              , ByVal ls_Estado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idviaje = ls_IdViaje
        _idtipoevento = ls_IdTipoEvento
        _tipoevento = ls_TipoEvento
        _idtipo = ls_IdTipo
        _tipo = ls_Tipo
        _idoperador = ls_IdOperador
        _fechahora = ld_FechaHora
        _descripcion = ls_Descripcion
        _idubicacion = ls_IdUbicacion
        _referencialugar = ls_ReferenciaLugar
        _estado = ls_Estado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
    End Sub

#End Region

    Public Overloads Function Equals(ByVal oeAlarma As e_Alarma) _
    As Boolean Implements System.IEquatable(Of e_Alarma).Equals
        If Me.Identificador = oeAlarma.Identificador Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DoWork() Implements Ie_Alarma.DoWork
    End Sub

End Class
