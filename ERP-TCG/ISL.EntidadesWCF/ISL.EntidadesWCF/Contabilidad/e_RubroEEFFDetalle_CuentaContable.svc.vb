<DataContract()> _
Public Class e_RubroEEFFDetalle_CuentaContable
    Implements Ie_RubroEEFFDetalle_CuentaContable
    Implements IEquatable(Of e_RubroEEFFDetalle_CuentaContable)

#Region "Declaracion de Vairables"

    Private _Id As String
    Private _IdRubroEEFFDetalle As String
    Private _NroCuenta As String
    Private _FechaCrea As Date
    Private _UsuarioCrea As String
    Private _FechaModifica As Date
    Private _UsuarioModifica As String
    Private _Activo As Boolean

    Public TipoOperacion As String = ""
    Public TipoBusca As Integer
    Public Identificador As String

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

    Public Property IdRubroEEFFDetalle() As String
        Get
            Return _IdRubroEEFFDetalle
        End Get
        Set(ByVal value As String)
            _IdRubroEEFFDetalle = value
        End Set
    End Property

    Public Property NroCuenta() As String
        Get
            Return _NroCuenta
        End Get
        Set(ByVal value As String)
            _NroCuenta = value
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

#Region "Contructores"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdRubroEEFFDetalle = ""
        _NroCuenta = ""
        _FechaCrea = #1/1/1901#
        _UsuarioCrea = ""
        _FechaModifica = #1/1/1901#
        _UsuarioModifica = ""
        _Activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdRubroEEFFDetalle As String _
          , ByVal ls_Identificador As String _
          , ByVal ls_NroCuenta As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _Id = ls_Id
        _IdRubroEEFFDetalle = ls_IdRubroEEFFDetalle
        Identificador = ls_Identificador
        _NroCuenta = ls_NroCuenta
        _FechaCrea = ld_FechaCrea
        _UsuarioCrea = ls_UsuarioCrea
        _FechaModifica = ld_FechaModifica
        _UsuarioModifica = ls_UsuarioModifica
        _Activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeCC As e_RubroEEFFDetalle_CuentaContable) As Boolean Implements System.IEquatable(Of e_RubroEEFFDetalle_CuentaContable).Equals
        Select Case oeCC.TipoBusca
            Case 1 : If Me.Id = oeCC.Id Then Return True
            Case 2 : If Me.Identificador = oeCC.Identificador And Me.NroCuenta = oeCC.NroCuenta Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(rubroeeffdetalle_cuentacontable As e_RubroEEFFDetalle_CuentaContable) As e_RubroEEFFDetalle_CuentaContable Implements Ie_RubroEEFFDetalle_CuentaContable.Obtener
        Return rubroeeffdetalle_cuentacontable
    End Function

#End Region

    
End Class
