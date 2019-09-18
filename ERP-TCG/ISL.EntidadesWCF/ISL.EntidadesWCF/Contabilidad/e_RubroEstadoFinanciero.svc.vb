<DataContract()> _
Public Class e_RubroEstadoFinanciero
    Implements Ie_RubroEstadoFinanciero

#Region "Declaracion de Variables"

    Private _Id As String
    Private _Codigo As String
    Private _NroRegistro As String
    Private _Nombre As String
    Private _EstructuraArchivo As String
    Private _FechaCrea As Date
    Private _UsuarioCrea As String
    Private _FechaModifica As Date
    Private _UsuarioModifica As String
    Private _Activo As Boolean

    Public TipoOperacion As String
    Public CargaCompleta As Boolean = False
    Public leDetalle As List(Of e_RubroEstadoFinanciero_Detalle)
    Public leCuenta As List(Of e_RubroEEFFDetalle_CuentaContable)
    <DataMember()>
    Public PrefijoID As String = ""
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

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property NroRegistro() As String
        Get
            Return _NroRegistro
        End Get
        Set(ByVal value As String)
            _NroRegistro = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property EstructuraArchivo() As String
        Get
            Return _EstructuraArchivo
        End Get
        Set(ByVal value As String)
            _EstructuraArchivo = value
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

    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
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

    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
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

#Region "Contructor"

    Public Sub New()

        TipoOperacion = ""
        _Id = ""
        _Codigo = ""
        _NroRegistro = ""
        _Nombre = ""
        _EstructuraArchivo = ""
        _FechaCrea = #1/1/1901#
        _UsuarioCrea = ""
        _FechaModifica = #1/1/1901#
        _UsuarioModifica = ""
        _Activo = True

    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_Codigo As String _
          , ByVal ls_NroRegistro As String _
          , ByVal ls_Nombre As String _
          , ByVal ls_EstructuraArchivo As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _Id = ls_Id
        _Codigo = ls_Codigo
        _NroRegistro = ls_NroRegistro
        _Nombre = ls_Nombre
        _EstructuraArchivo = ls_EstructuraArchivo
        _FechaCrea = ld_FechaCrea
        _UsuarioCrea = ls_UsuarioCrea
        _FechaModifica = ld_FechaModifica
        _UsuarioModifica = ls_UsuarioModifica
        _Activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(rubroestadofinanciero As e_RubroEstadoFinanciero) As e_RubroEstadoFinanciero Implements Ie_RubroEstadoFinanciero.Obtener
        Return rubroestadofinanciero
    End Function

#End Region

End Class
