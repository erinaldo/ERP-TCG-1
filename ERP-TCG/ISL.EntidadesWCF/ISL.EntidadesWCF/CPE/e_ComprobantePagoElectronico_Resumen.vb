Public Class e_ComprobantePagoElectronico_Resumen

    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public IndPrincipal As Integer
    <DataMember()>
    Public CargaCompleta As Boolean

    Public Event DatoCambiado()

#Region "Declaración de variables"


    Private _Id As String
    Private _IdEmpresaSis As String
    Private _TipoResumen As Integer
    Private _FechaResumen As String
    Private _FechaDocumentos As String
    Private _Correlativo As String
    Private _Ticket As String
    Private _Hash_RSA As String
    Private _Rpta_Sunat As String
    Private _Ruta_XML As String
    Private _IdEstado As String
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _Activo As Boolean
#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdEmpresaSis = ""
        _TipoResumen = 0
        _FechaResumen = ""
        _FechaDocumentos = ""
        _Correlativo = ""
        _Ticket = ""
        _Hash_RSA = ""
        _Rpta_Sunat = ""
        _Ruta_XML = ""
        _IdEstado = ""
        _UsuarioCrea = ""
        _FechaCrea = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModifica = #01/01/1901#
        _Activo = True
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresaSis As String _
              , ByVal ln_TipoResumen As Integer _
              , ByVal ls_FechaResumen As String _
              , ByVal ls_FechaDocumentos As String _
              , ByVal ls_Correlativo As String _
              , ByVal ls_Ticket As String _
              , ByVal ls_Hash_RSA As String _
              , ByVal ls_Rpta_Sunat As String _
              , ByVal ls_Ruta_XML As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean
           )
        _Id = ls_Id
        _IdEmpresaSis = ls_IdEmpresaSis
        _TipoResumen = ln_TipoResumen
        _FechaResumen = ls_FechaResumen
        _FechaDocumentos = ls_FechaDocumentos
        _Correlativo = ls_Correlativo
        _Ticket = ls_Ticket
        _Hash_RSA = ls_Hash_RSA
        _Rpta_Sunat = ls_Rpta_Sunat
        _Ruta_XML = ls_Ruta_XML
        _IdEstado = ls_IdEstado
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
    End Sub

#End Region
#Region "Propiedades"


    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Public Property IdEmpresaSis() As String
        Get
            Return _IdEmpresaSis
        End Get
        Set(ByVal value As String)
            _IdEmpresaSis = value
        End Set
    End Property
    Public Property TipoResumen() As Integer
        Get
            Return _TipoResumen
        End Get
        Set(ByVal value As Integer)
            _TipoResumen = value
        End Set
    End Property
    Public Property FechaResumen() As String
        Get
            Return _FechaResumen
        End Get
        Set(ByVal value As String)
            _FechaResumen = value
        End Set
    End Property
    Public Property FechaDocumentos() As String
        Get
            Return _FechaDocumentos
        End Get
        Set(ByVal value As String)
            _FechaDocumentos = value
        End Set
    End Property
    Public Property Correlativo() As String
        Get
            Return _Correlativo
        End Get
        Set(ByVal value As String)
            _Correlativo = value
        End Set
    End Property
    Public Property Ticket() As String
        Get
            Return _Ticket
        End Get
        Set(ByVal value As String)
            _Ticket = value
        End Set
    End Property
    Public Property Hash_RSA() As String
        Get
            Return _Hash_RSA
        End Get
        Set(ByVal value As String)
            _Hash_RSA = value
        End Set
    End Property
    Public Property Rpta_Sunat() As String
        Get
            Return _Rpta_Sunat
        End Get
        Set(ByVal value As String)
            _Rpta_Sunat = value
        End Set
    End Property
    Public Property Ruta_XML() As String
        Get
            Return _Ruta_XML
        End Get
        Set(ByVal value As String)
            _Ruta_XML = value
        End Set
    End Property
    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
        End Set
    End Property
    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property
    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
        End Set
    End Property
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property
#End Region
End Class
