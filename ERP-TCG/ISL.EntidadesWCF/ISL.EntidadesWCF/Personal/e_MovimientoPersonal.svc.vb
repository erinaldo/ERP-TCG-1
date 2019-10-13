

<DataContract()> _
Public Class e_MovimientoPersonal
    Implements Ie_MovimientoPersonal

#Region "Declaración de variables"

    Private _id As String
    Private _idTrabajador As String

    Private _idSituacionAdministrativa As String
    Private _fechaInicio As Date
    Private _fechaFin As Date
    Private _retorno As Boolean
    Private _fechaRetorno As Date

    Private _observacion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    Private _situacion As String

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
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String _
              , ByVal idTrabajador As String _
              , ByVal idSituacionAdministrativa As String _
              , ByVal fechaInicio As Date _
              , ByVal nroDias As Integer _
              , ByVal fechaFin As Date _
              , ByVal retorno As Boolean _
              , ByVal fechaRetorno As Date _
              , ByVal observacion As String _
              , ByVal fechaCreacion As Date _
              , ByVal usuarioCreacion As String _
              , ByVal activo As Boolean _
           )
        _id = id
        _idTrabajador = idTrabajador
        _idSituacionAdministrativa = idSituacionAdministrativa
        _fechaInicio = fechaInicio
        _nroDias = nroDias
        _fechaFin = fechaFin
        _retorno = retorno
        _fechaRetorno = fechaRetorno
        _observacion = observacion
        _fechacreacion = fechaCreacion
        _usuariocreacion = usuarioCreacion
        _activo = activo
    End Sub

    Public Sub New(ByVal id As String _
          , ByVal idTrabajador As String _
          , ByVal apepat As String _
          , ByVal apemat As String _
          , ByVal nombres As String _
          , ByVal fechaInicio As Date _
          , ByVal nroDias As Integer _
          , ByVal fechaFin As Date _
                        , ByVal retorno As Boolean _
              , ByVal fechaRetorno As Date _
          , ByVal idSituacionAdministrativa As String _
          , ByVal situacion As String _
          , ByVal observacion As String _
          , ByVal activo As Boolean _
          , ByVal fechaCreacion As Date _
          , ByVal usuarioCreacion As String _
       )
        _id = id
        _idTrabajador = idTrabajador
        _apepat = apepat
        _apemat = apemat
        _nombres = nombres
        _idSituacionAdministrativa = idSituacionAdministrativa
        _situacion = situacion
        _fechaInicio = fechaInicio
        _nroDias = nroDias
        _fechaFin = fechaFin
        _retorno = retorno
        _fechaRetorno = fechaRetorno
        _observacion = observacion
        _fechacreacion = fechaCreacion
        _usuariocreacion = usuarioCreacion
        _activo = activo
    End Sub

#End Region

#Region "Propiedades"

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
        End Set
    End Property

    Private _apepat As String
    <DataMember()> _
    Public Property ApellidoPaterno() As String
        Get
            Return _apepat
        End Get
        Set(ByVal value As String)
            _apepat = value
        End Set
    End Property

    Private _apemat As String
    <DataMember()> _
    Public Property ApellidoMaterno() As String
        Get
            Return _apemat
        End Get
        Set(ByVal value As String)
            _apemat = value
        End Set
    End Property

    Private _nombres As String
    <DataMember()> _
    Public Property Nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad extra utilizada para almacenar el texto completo de la situación del trabajador
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Situacion() As String
        Get
            Return _situacion
        End Get
        Set(ByVal value As String)
            _situacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSituacionAdministrativa() As String
        Get
            Return _idSituacionAdministrativa
        End Get
        Set(ByVal value As String)
            _idSituacionAdministrativa = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechaFin
        End Get
        Set(ByVal value As Date)
            _fechaFin = value
        End Set
    End Property

    Private _nroDias As Integer
    <DataMember()> _
    Public Property NroDias() As Integer
        Get
            Return _nroDias
        End Get
        Set(ByVal value As Integer)
            _nroDias = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para almacenar la confirmación de retorno del trabajador a la empresa
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Retorno() As Boolean
        Get
            Return _retorno
        End Get
        Set(ByVal value As Boolean)
            _retorno = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para almacenar la información de la fecha de retorno del trabajador a la empresa
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property FechaRetorno() As Date
        Get
            Return _fechaRetorno
        End Get
        Set(ByVal value As Date)
            _fechaRetorno = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MovimientoPersonal
    ''' </summary>
    ''' <param name="movimientoPersonal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal movimientoPersonal As e_MovimientoPersonal) As e_MovimientoPersonal Implements Ie_MovimientoPersonal.Obtener
        Return movimientoPersonal
    End Function

#End Region

End Class


