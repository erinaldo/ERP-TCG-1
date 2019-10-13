

<DataContract()> _
Public Class e_DocumentoSinAsociacion
    Implements Ie_DocumentoSinAsociacion

#Region "Propiedad"

    Private _id As String
    Private _glosa As String
    Private _fecha As Date
    Private _evaluado As Integer
    Private _idusuariosolicito As String
    Private _idusuarioevalua As String
    Private _idtipodocumento As String
    Private _iddocumento As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFin As Date
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Evaluado() As Integer
        Get
            Return _evaluado
        End Get
        Set(ByVal value As Integer)
            _evaluado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioSolicito() As String
        Get
            Return _idusuariosolicito
        End Get
        Set(ByVal value As String)
            _idusuariosolicito = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioEvalua() As String
        Get
            Return _idusuarioevalua
        End Get
        Set(ByVal value As String)
            _idusuarioevalua = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumento() As String
        Get
            Return _iddocumento
        End Get
        Set(ByVal value As String)
            _iddocumento = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
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
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Evaluado As Integer _
              , ByVal ls_IdUsuarioSolicito As String _
              , ByVal ls_IdUsuarioEvalua As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_IdDocumento As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _evaluado = ln_Evaluado
        _idusuariosolicito = ls_IdUsuarioSolicito
        _idusuarioevalua = ls_IdUsuarioEvalua
        _idtipodocumento = ls_IdTipoDocumento
        _iddocumento = ls_IdDocumento
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub
#End Region

    Public Function Obtener(ByVal documentoSinAsociacion As e_DocumentoSinAsociacion) As e_DocumentoSinAsociacion Implements Ie_DocumentoSinAsociacion.Obtener
        Return documentoSinAsociacion
    End Function

End Class


