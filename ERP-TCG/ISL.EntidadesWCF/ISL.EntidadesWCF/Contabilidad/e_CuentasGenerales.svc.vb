<DataContract()> _
Public Class e_CuentasGenerales
    Implements Ie_CuentasGenerales

#Region "Propiedad"

    Private _id As String
    Private _idtablacontabledet As String
    Private _idcuentacontable As String
    Private _ejercicio As Integer
    Private _activo As Boolean
    Private _cuenta As String
    Private _nomcuenta As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdTablaContableDet() As String
        Get
            Return _idtablacontabledet
        End Get
        Set(ByVal value As String)
            _idtablacontabledet = value
            RaiseEvent DatoCambiado()
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
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCuenta() As String
        Get
            Return _nomcuenta
        End Get
        Set(ByVal value As String)
            _nomcuenta = value
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

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTablaContableDet As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ln_Ejercicio As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Cuenta As String _
              , ByVal ls_NomCuenta As String _
           )
        _id = ls_Id
        _idtablacontabledet = ls_IdTablaContableDet
        _idcuentacontable = ls_IdCuentaContable
        _ejercicio = ln_Ejercicio
        _activo = lb_Activo
        _cuenta = ls_Cuenta
        _nomcuenta = ls_NomCuenta
    End Sub

#End Region

    Public Function Obtener(ByVal cuentasGenerales As e_CuentasGenerales) As e_CuentasGenerales Implements Ie_CuentasGenerales.Obtener
        Return cuentasGenerales
    End Function

End Class
