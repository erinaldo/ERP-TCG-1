<DataContract()> _
Public Class e_RubroEstadoFinanciero_Detalle
    Implements Ie_RubroEstadoFinanciero_Detalle
    Implements IEquatable(Of e_RubroEstadoFinanciero_Detalle)

#Region "Declaracion de Variables"

    Private _Id As String
    Private _IdRubroEstadoFinanciero As String
    Private _Codigo As String
    Private _Descripcion As String
    Private _Identificador As String
    Private _Nivel As Integer
    Private _Linea As Integer
    Private _Superior As Integer
    Private _IdDepende As String
    Private _Depende As String
    Private _IndTotal As Integer
    Private _FechaCrea As Date
    Private _UsuarioCrea As String
    Private _FechaModifica As Date
    Private _UsuarioModifica As String
    Private _Activo As Boolean

    Public TipoOperacion As String = ""
    Public TipoBusca As Integer
    Public IdentificaPadre As String = ""
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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

    Public Property IdRubroEstadoFinanciero() As String
        Get
            Return _IdRubroEstadoFinanciero
        End Get
        Set(ByVal value As String)
            _IdRubroEstadoFinanciero = value
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

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Identificador() As String
        Get
            Return _Identificador
        End Get
        Set(ByVal value As String)
            _Identificador = value
        End Set
    End Property

    Public Property Nivel() As Integer
        Get
            Return _Nivel
        End Get
        Set(ByVal value As Integer)
            _Nivel = value
        End Set
    End Property

    Public Property Linea() As Integer
        Get
            Return _Linea
        End Get
        Set(ByVal value As Integer)
            _Linea = value
        End Set
    End Property

    Public Property Superior() As Integer
        Get
            Return _Superior
        End Get
        Set(ByVal value As Integer)
            _Superior = value
        End Set
    End Property

    Public Property IdDepende() As String
        Get
            Return _IdDepende
        End Get
        Set(ByVal value As String)
            _IdDepende = value
        End Set
    End Property

    Public Property Depende() As String
        Get
            Return _Depende
        End Get
        Set(ByVal value As String)
            _Depende = value
        End Set
    End Property

    Public Property IndTotal() As Integer
        Get
            Return _IndTotal
        End Get
        Set(ByVal value As Integer)
            _IndTotal = value
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
        IdentificaPadre = ""
        _Id = ""
        _IdRubroEstadoFinanciero = ""
        _Codigo = ""
        _Descripcion = ""
        _Identificador = ""
        _Nivel = 0
        _Linea = 0
        _Superior = 0
        _IdDepende = ""
        _Depende = ""
        _IndTotal = 0
        _FechaCrea = #1/1/1901#
        _UsuarioCrea = ""
        _FechaModifica = #1/1/1901#
        _UsuarioModifica = ""
        _Activo = True

    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdRubroEstadoFinanciero As String _
          , ByVal ls_Codigo As String _
          , ByVal ls_Descripcion As String _
          , ByVal ls_Identificador As String _
          , ByVal ln_Nivel As Integer _
          , ByVal ln_Linea As Integer _
          , ByVal ln_Superior As Integer _
          , ByVal ls_IdDepende As String _
          , ByVal ls_Depende As String _
          , ByVal ln_IndTotal As Integer _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _Id = ls_Id
        _IdRubroEstadoFinanciero = ls_IdRubroEstadoFinanciero
        _Codigo = ls_Codigo
        _Descripcion = ls_Descripcion
        _Identificador = ls_Identificador
        _Nivel = ln_Nivel
        _Linea = ln_Linea
        _Superior = ln_Superior
        _IdDepende = ls_IdDepende
        _Depende = ls_Depende
        _IndTotal = ln_IndTotal
        _FechaCrea = ld_FechaCrea
        _UsuarioCrea = ls_UsuarioCrea
        _FechaModifica = ld_FechaModifica
        _UsuarioModifica = ls_UsuarioModifica
        _Activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeDet As e_RubroEstadoFinanciero_Detalle) As Boolean Implements System.IEquatable(Of e_RubroEstadoFinanciero_Detalle).Equals
        Select Case oeDet.TipoBusca
            Case 1 : If Me.Id = oeDet.Id Then Return True
            Case 2 : If Me.Id = oeDet.Id And Me.Nivel = oeDet.Nivel And Me.Linea = oeDet.Linea And Me.Codigo.Trim = oeDet.Codigo.Trim Then Return True
            Case 3 : If Me.Identificador = oeDet.Identificador Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(rubroestadofinanciero_detalle As e_RubroEstadoFinanciero_Detalle) As e_RubroEstadoFinanciero_Detalle Implements Ie_RubroEstadoFinanciero_Detalle.Obtener
        Return rubroestadofinanciero_detalle
    End Function

    Public Function GeneraIdenticador() As String
        Dim str01 As String = "", str02 As String = "", cad As String = ""
        str01 = StrDup(2 - Len(Nivel.ToString), "0") & Nivel.ToString
        str02 = StrDup(3 - Len(Linea.ToString), "0") & Linea.ToString
        cad = str01 & str02
        Return cad
    End Function

#End Region

End Class
