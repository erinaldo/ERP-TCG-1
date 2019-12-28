Imports ERP.EntidadesWCF

Public Class e_Lado


    Implements Ie_CierreTurno
    Implements IEquatable(Of e_Lado)

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


    Private _Id As Integer
    Private _IdEmpresaSis As String
    Private _IdSucursal As String
    Private _IdIsla As Integer
    Private _Nombre As String
    Private _Diesel As Boolean
    Private _G84 As Boolean
    Private _G90 As Boolean
    Private _G95 As Boolean
    Private _Estado As Integer
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _Activo As Boolean

#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = 0
        _IdEmpresaSis = ""
        _IdSucursal = ""
        _IdIsla = 0
        _Nombre = ""
        _Diesel = True
        _G84 = True
        _G90 = True
        _G95 = True
        _Estado = 0
        _UsuarioCreacion = ""
        _FechaCreacion = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModifica = #01/01/1901#
        _Activo = True
    End Sub

    Public Sub New(
              ByVal ln_Id As Integer _
              , ByVal ls_IdEmpresaSis As String _
              , ByVal ls_IdSucursal As String _
              , ByVal ln_IdIsla As Integer _
              , ByVal ls_Nombre As String _
              , ByVal lb_Diesel As Boolean _
              , ByVal lb_G84 As Boolean _
              , ByVal lb_G90 As Boolean _
              , ByVal lb_G95 As Boolean _
              , ByVal ln_Estado As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean
           )
        _Id = ln_Id
        _IdEmpresaSis = ls_IdEmpresaSis
        _IdSucursal = ls_IdSucursal
        _IdIsla = ln_IdIsla
        _Nombre = ls_Nombre
        _Diesel = lb_Diesel
        _G84 = lb_G84
        _G90 = lb_G90
        _G95 = lb_G95
        _Estado = ln_Estado
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
    End Sub

    Public Function Obtener(Item As e_CierreTurno) As e_CierreTurno Implements Ie_CierreTurno.Obtener
        Throw New NotImplementedException()
    End Function

    Public Function Equals(other As e_Lado) As Boolean Implements IEquatable(Of e_Lado).Equals
        Throw New NotImplementedException()
    End Function

#End Region
#Region "Propiedades"


    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
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
    Public Property IdSucursal() As String
        Get
            Return _IdSucursal
        End Get
        Set(ByVal value As String)
            _IdSucursal = value
        End Set
    End Property
    Public Property IdIsla() As Integer
        Get
            Return _IdIsla
        End Get
        Set(ByVal value As Integer)
            _IdIsla = value
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
    Public Property Diesel() As Boolean
        Get
            Return _Diesel
        End Get
        Set(ByVal value As Boolean)
            _Diesel = value
        End Set
    End Property
    Public Property G84() As Boolean
        Get
            Return _G84
        End Get
        Set(ByVal value As Boolean)
            _G84 = value
        End Set
    End Property
    Public Property G90() As Boolean
        Get
            Return _G90
        End Get
        Set(ByVal value As Boolean)
            _G90 = value
        End Set
    End Property
    Public Property G95() As Boolean
        Get
            Return _G95
        End Get
        Set(ByVal value As Boolean)
            _G95 = value
        End Set
    End Property
    Public Property Estado() As Integer
        Get
            Return _Estado
        End Get
        Set(ByVal value As Integer)
            _Estado = value
        End Set
    End Property
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
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
