' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CtaCtbleCatServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CtaCtbleCatServicio.svc o e_CtaCtbleCatServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CtaCtbleCatServicio
    Implements Ie_CtaCtbleCatServicio

#Region "Propiedad"

    Private _id As String
    Private _idcategoriaservicio As New e_CategoriaServicio
    Private _cuentacontable As New e_CuentaContable
    Private _itemgasto As New e_ItemGasto
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TotalCuenta As Double = 0
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

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
    Public Property IdCategoriaServicio() As String
        Get
            Return _idcategoriaservicio.Id
        End Get
        Set(ByVal value As String)
            _idcategoriaservicio.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _cuentacontable.Id
        End Get
        Set(ByVal value As String)
            _cuentacontable.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaContable() As String
        Get
            Return _cuentacontable.Nombre
        End Get
        Set(ByVal value As String)
            _cuentacontable.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuentaContable() As String
        Get
            Return _cuentacontable.Cuenta
        End Get
        Set(ByVal value As String)
            _cuentacontable.Cuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Integer
        Get
            Return _cuentacontable.Ejercicio
        End Get
        Set(ByVal value As Integer)
            _cuentacontable.Ejercicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdItemGasto() As String
        Get
            Return _itemgasto.Id
        End Get
        Set(ByVal value As String)
            _itemgasto.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ItemGasto() As String
        Get
            Return _itemgasto.Nombre
        End Get
        Set(ByVal value As String)
            _itemgasto.Nombre = value
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
        TipoOperacion = ""
        Activo = True
        TotalCuenta = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCategoriaServicio As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_CuentaContable As String _
              , ByVal ls_NroCuentaContable As String _
              , ByVal li_Ejercicio As Integer _
              , ByVal ls_IdItemGasto As String _
              , ByVal ls_ItemGasto As String)
        _id = ls_Id
        _idcategoriaservicio.Id = ls_IdCategoriaServicio
        _cuentacontable.Id = ls_IdCuentaContable
        _cuentacontable.Nombre = ls_CuentaContable
        _cuentacontable.Cuenta = ls_NroCuentaContable
        _cuentacontable.Ejercicio = li_Ejercicio
        _itemgasto.Id = ls_IdItemGasto
        _itemgasto.Nombre = ls_ItemGasto
    End Sub

#End Region

    Public Function Obtener(ctactblecatservicio As e_CtaCtbleCatServicio) As e_CtaCtbleCatServicio Implements Ie_CtaCtbleCatServicio.Obtener
        Return ctactblecatservicio
    End Function

End Class