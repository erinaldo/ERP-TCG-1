<DataContract()> _
Public Class e_ComprobanteElectronicoBath
    Implements Ie_ComprobanteElectronicoBath

#Region "Declaracion de Variables"

    Private _id As String
    Private _tiporeferencia As Integer
    Private _fechaenvio As Date
    Private _xmlbase64 As String
    Private _nombrexml As String
    Private _cdrxml As String
    Private _ticket As String
    Private _indbaja As Boolean
    Private _estado As String
    Private _usuariocrea As String
    Private _fechacrea As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date
    Private _ValorResumen As String
    Private _Firma As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public leDetalle As New List(Of e_ComprobanteElectronicoBath_Detalle)
    <DataMember()>
    Public PrefijoID As String = ""
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

    <DataMember()> _
    Public Property FechaEnvio() As Date
        Get
            Return _fechaenvio
        End Get
        Set(ByVal value As Date)
            _fechaenvio = value
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
    Public Property cdrxml() As String
        Get
            Return _cdrxml
        End Get
        Set(ByVal value As String)
            _cdrxml = value
        End Set
    End Property

    <DataMember()> _
    Public Property valorResumen() As String
        Get
            Return _ValorResumen
        End Get
        Set(ByVal value As String)
            _ValorResumen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Firma() As String
        Get
            Return _Firma
        End Get
        Set(ByVal value As String)
            _Firma = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ticket() As String
        Get
            Return _ticket
        End Get
        Set(ByVal value As String)
            _ticket = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndBaja() As Boolean
        Get
            Return _indbaja
        End Get
        Set(ByVal value As Boolean)
            _indbaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

#End Region

#Region "Contructor"

    Public Sub New()
        _id = ""
        _tiporeferencia = 0
        _fechaenvio = #1/1/1901#
        _xmlbase64 = ""
        _nombrexml = ""
        _cdrxml = ""
        _ticket = ""
        _indbaja = False
        _estado = ""
        _usuariocrea = ""
        _fechacrea = #1/1/1901#
        _usuariomodifica = ""
        _fechamodifica = #1/1/1901#
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ln_TipoReferencia As Integer _
          , ByVal ld_FechaEnvio As Date _
          , ByVal ls_xmlbase64 As String _
          , ByVal ls_nombrexml As String _
          , ByVal ls_cdrxml As String _
          , ByVal ls_Ticket As String _
          , ByVal lb_IndBaja As Boolean _
          , ByVal ls_Estado As String _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModifica As Date _
           , ByVal ls_valorResuemn As String _
            , ByVal ls_Firma As String _
       )
        _id = ls_Id
        _tiporeferencia = ln_TipoReferencia
        _fechaenvio = ld_FechaEnvio
        _xmlbase64 = ls_xmlbase64
        _nombrexml = ls_nombrexml
        _cdrxml = ls_cdrxml
        _ticket = ls_Ticket
        _indbaja = lb_IndBaja
        _estado = ls_Estado
        _usuariocrea = ls_UsuarioCrea
        _fechacrea = ld_FechaCrea
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _ValorResumen = ls_valorResuemn
        _Firma = ls_Firma
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(comprobanteelectronicobath As e_ComprobanteElectronicoBath) As e_ComprobanteElectronicoBath Implements Ie_ComprobanteElectronicoBath.Obtener
        Return comprobanteelectronicobath
    End Function

#End Region

End Class
