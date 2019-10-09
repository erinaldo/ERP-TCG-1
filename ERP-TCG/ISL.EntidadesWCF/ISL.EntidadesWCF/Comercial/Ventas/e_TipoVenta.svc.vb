

<DataContract()> _
Public Class e_TipoVenta
    Implements Ie_TipoVenta

#Region "Propiedad"

    Private _id As String
    Private _idtablacontabledet As String
    Private _idcuentacontable As String
    Private _cuenta As String

    Private _ejercicio As Integer
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
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
        TipoOperacion = ""
    End Sub

    Public Sub New(ls_Id As String _
              , ls_IdTablaContableDet As String _
              , ls_IdCuentaContable As String _
              , ln_Ejercicio As Integer _
              , lb_Activo As Boolean _
              , ls_Cuenta As String)
        _id = ls_Id
        _idtablacontabledet = ls_IdTablaContableDet
        _idcuentacontable = ls_IdCuentaContable
        _cuenta = ls_Cuenta
        _ejercicio = ln_Ejercicio
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal tipoVenta As e_TipoVenta) As e_TipoVenta Implements Ie_TipoVenta.Obtener
        Return tipoVenta
    End Function

End Class


