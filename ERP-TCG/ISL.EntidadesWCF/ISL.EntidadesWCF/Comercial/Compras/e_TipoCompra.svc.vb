

<DataContract()> _
Public Class e_TipoCompra
    Implements Ie_TipoCompra

#Region "Propiedad"

    Private _id As String
    Private _idtablacontabledet As String
    Private _cuenta As String
    Private _idcuentacontable60 As String
    Private _idcuentacontable61 As String
    Private _ejercicio As Integer
    Private _activo As Boolean

    Private _nomcta60 As String
    Private _nomcta61 As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable60() As String
        Get
            Return _idcuentacontable60
        End Get
        Set(ByVal value As String)
            _idcuentacontable60 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable61() As String
        Get
            Return _idcuentacontable61
        End Get
        Set(ByVal value As String)
            _idcuentacontable61 = value
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

    <DataMember()> _
    Public Property NombreCuenta60() As String
        Get
            Return _nomcta60
        End Get
        Set(ByVal value As String)
            _nomcta60 = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCuenta61() As String
        Get
            Return _nomcta61
        End Get
        Set(ByVal value As String)
            _nomcta61 = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTablaContableDet As String _
              , ByVal ls_Cuenta As String _
              , ByVal ls_IdCuentaContable60 As String _
              , ByVal ls_Nombre60 As String _
              , ByVal ls_IdCuentaContable61 As String _
              , ByVal ls_Nombre61 As String _
              , ByVal ln_Ejercicio As Integer _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idtablacontabledet = ls_IdTablaContableDet
        _cuenta = ls_Cuenta
        _idcuentacontable60 = ls_IdCuentaContable60
        _nomcta60 = ls_Nombre60
        _idcuentacontable61 = ls_IdCuentaContable61
        _nomcta61 = ls_Nombre61
        _ejercicio = ln_Ejercicio
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal tipoCompra As e_TipoCompra) As e_TipoCompra Implements Ie_TipoCompra.Obtener
        Return tipoCompra
    End Function

End Class


