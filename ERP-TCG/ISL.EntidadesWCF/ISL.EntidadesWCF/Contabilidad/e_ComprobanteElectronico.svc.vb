<DataContract()> _
Public Class e_ComprobanteElectronico
    Implements Ie_ComprobanteElectronico

#Region "Declaracion de Variables"

    Private _id As String
    Private _tiporeferencia As Integer
    Private _idreferencia As String
    Private _xmlbase64 As String
    Private _nombrexml As String
    Private _valorcodbarras As String
    Private _valorcodqr As String
    Private _cdrxml As String
    Private _usuariocrea As String
    Private _fechacrea As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date
    Private _ValorResumen As String
    Private _estadoelectronico As String
    <DataMember()> _
    Public TipoOperacion As String
    Private _firma As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property TipoReferencia() As Integer
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As Integer)
            _tiporeferencia = value
        End Set
    End Property

    '<DataMember()> _
    Public Property EstadoElectronico() As String
        Get
            Return _estadoelectronico
        End Get
        Set(ByVal value As String)
            _estadoelectronico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property xmlbase64() As String
        Get
            Return _xmlbase64
        End Get
        Set(ByVal value As String)
            _xmlbase64 = value
        End Set
    End Property

    <DataMember()> _
    Public Property nombrexml() As String
        Get
            Return _nombrexml
        End Get
        Set(ByVal value As String)
            _nombrexml = value
        End Set
    End Property

    <DataMember()> _
    Public Property valorcodbarras() As String
        Get
            Return _valorcodbarras
        End Get
        Set(ByVal value As String)
            _valorcodbarras = value
        End Set
    End Property

    '<DataMember()> _
    Public Property valorcodqr() As String
        Get
            Return _valorcodqr
        End Get
        Set(ByVal value As String)
            _valorcodqr = value
        End Set
    End Property

    <DataMember()> _
    Public Property cdrxml() As String
        Get
            Return _cdrxml
        End Get
        Set(ByVal value As String)
            _cdrxml = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCrea() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorResumen() As String
        Get
            Return _ValorResumen
        End Get
        Set(ByVal value As String)
            _ValorResumen = value
        End Set
    End Property

    '<DataMember()> _
    Public Property Firma() As String
        Get
            Return _firma
        End Get
        Set(ByVal value As String)
            _firma = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = ""
        _tiporeferencia = 0
        _idreferencia = ""
        _xmlbase64 = ""
        _nombrexml = ""
        _valorcodbarras = ""
        _ValorResumen = ""
        _cdrxml = ""
        _usuariocrea = ""
        _fechacrea = #1/1/1901#
        _usuariomodifica = ""
        _fechamodifica = #1/1/1901#
        _firma = ""
        _valorcodqr = ""
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ln_TipoReferencia As Integer _
          , ByVal ls_IdReferencia As String _
          , ByVal ls_xmlbase64 As String _
          , ByVal ls_nombrexml As String _
          , ByVal ls_firma As String _
          , ByVal ls_valorcodbarras As String _
          , ByVal ls_valorcodqr As String _
          , ByVal ls_cdrxml As String _
           , ByVal ls_valorresumen As String _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_EstadoElectronico As String _
       )
        _id = ls_Id
        _tiporeferencia = ln_TipoReferencia
        _idreferencia = ls_IdReferencia
        _xmlbase64 = ls_xmlbase64
        _nombrexml = ls_nombrexml
        _valorcodbarras = ls_valorcodbarras
        _valorcodqr = ls_valorcodqr
        _ValorResumen = ls_valorresumen
        _cdrxml = ls_cdrxml
        _usuariocrea = ls_UsuarioCrea
        _fechacrea = ld_FechaCrea
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _firma = ls_firma
        _estadoelectronico = ls_EstadoElectronico
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(comprobanteelectronico As e_ComprobanteElectronico) As e_ComprobanteElectronico Implements Ie_ComprobanteElectronico.Obtener
        Return comprobanteelectronico
    End Function

#End Region

End Class
