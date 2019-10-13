

<DataContract()> _
Public Class e_CuentaFlujoCaja
    Implements Ie_CuentaFlujoCaja

#Region "Propiedades"

    Private _id As String
    Private _idcuentacontable As String
    Private _idflujocaja As String
    Private _ejercicio As Integer
    Private _activo As Boolean
    Private _cuenta As String

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
    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

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
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentacontable
        End Get
        Set(ByVal value As String)
            _idcuentacontable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _idflujocaja
        End Get
        Set(ByVal value As String)
            _idflujocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Integer
        Get
            Return _ejercicio
        End Get
        Set(ByVal value As Integer)
            _ejercicio = value
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

#Region "Constructores"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal ln_Ejercicio As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Cuenta As String _
           )
        _id = ls_Id
        _idcuentacontable = ls_IdCuentaContable
        _idflujocaja = ls_IdFlujoCaja
        _ejercicio = ln_Ejercicio
        _activo = lb_Activo
        _cuenta = ls_Cuenta
    End Sub

#End Region

    Public Function Obtener(ByVal cuentaFlujoCaja As e_CuentaFlujoCaja) As e_CuentaFlujoCaja Implements Ie_CuentaFlujoCaja.Obtener
        Return cuentaFlujoCaja
    End Function

End Class
