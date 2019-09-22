<DataContract()> _
Public Class e_EmpresaCuenta
    Implements Ie_EmpresaCuenta

#Region "Propiedad"

    Private _id As String
    Private _idcuentacontable As String
    Private _idproveedorcliente As String
    Private _idmoneda As String
    Private _activo As Boolean
    Private _indcompraventa As Integer
    Private _Ejercicio As Integer
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
    Public Property IdProveedorCliente() As String
        Get
            Return _idproveedorcliente
        End Get
        Set(ByVal value As String)
            _idproveedorcliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
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

    <DataMember()> _
    Public Property IndCompraVenta() As Integer
        Get
            Return _indcompraventa
        End Get
        Set(ByVal value As Integer)
            _indcompraventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Integer
        Get
            Return _Ejercicio
        End Get
        Set(ByVal value As Integer)
            _Ejercicio = value
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
              , ByVal ls_IdCuentacontable As String _
              , ByVal ls_IdProveedorCliente As String _
              , ByVal ls_IdMoneda As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_IndCompraVenta As Integer _
              , ByVal ln_Ejercicio As Integer _
           )
        _id = ls_Id
        _idcuentacontable = ls_IdCuentacontable
        _idproveedorcliente = ls_IdProveedorCliente
        _idmoneda = ls_IdMoneda
        _activo = lb_Activo
        _indcompraventa = ln_IndCompraVenta
        _Ejercicio = ln_Ejercicio
    End Sub

#End Region

    Public Function Obtener(ByVal empresaCuenta As e_EmpresaCuenta) As e_EmpresaCuenta Implements Ie_EmpresaCuenta.Obtener
        Return empresaCuenta
    End Function

End Class
