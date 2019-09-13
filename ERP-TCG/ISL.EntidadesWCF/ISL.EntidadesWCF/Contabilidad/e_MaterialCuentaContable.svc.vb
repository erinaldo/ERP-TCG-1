<DataContract()> _
Public Class e_MaterialCuentaContable
    Implements Ie_MaterialCuentaContable

#Region "Propiedad"

    Private _id As String
    Private _idmaterial As String
    Private _idcuentactble As String
    Private _cuenta As String
    Private _nrocuenta As String
    Private _idcuentactbleActivo As String
    Private _ejercicio As Integer
    Private _activo As Boolean


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
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuenta() As String
        Get
            Return _nrocuenta
        End Get
        Set(ByVal value As String)
            _nrocuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentactble
        End Get
        Set(ByVal value As String)
            _idcuentactble = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContableActivo() As String
        Get
            Return _idcuentactbleActivo
        End Get
        Set(ByVal value As String)
            _idcuentactbleActivo = value
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

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_Cuenta As String _
              , ByVal ls_NroCuenta As String _
              , ByVal ln_Ejercicio As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCuentaContableActivo As String _
           )

        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _idcuentactble = ls_IdCuentaContable
        _ejercicio = ln_Ejercicio
        _activo = lb_Activo
        _cuenta = ls_Cuenta
        _nrocuenta = ls_NroCuenta
        _idcuentactbleActivo = ls_IdCuentaContableActivo

    End Sub

#End Region

    Public Function Obtener(ByVal materialCuentaContable As e_MaterialCuentaContable) As e_MaterialCuentaContable Implements Ie_MaterialCuentaContable.Obtener
        Return materialCuentaContable
    End Function

End Class
