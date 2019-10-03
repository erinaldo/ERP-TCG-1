' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CtaCtbleSubFamiliaMat" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CtaCtbleSubFamiliaMat.svc o e_CtaCtbleSubFamiliaMat.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CtaCtbleSubFamiliaMat
    Implements Ie_CtaCtbleSubFamiliaMat
    Implements IEquatable(Of e_CtaCtbleSubFamiliaMat)

#Region "Propiedad"

    Private _id As String
    Private _subfamilia As New e_SubFamiliaMaterial
    Private _cuentacontable As New e_CuentaContable
    Private _itemgasto As New e_ItemGasto
    Private _ctactblecompra As New e_CuentaContable
    Private _ctactbleconsumo As New e_CuentaContable
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TotalCuentas As Double
    <DataMember()> _
    Public Tipo As Integer = 0
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdSubFamilia() As String
        Get
            Return _subfamilia.Id
        End Get
        Set(ByVal value As String)
            _subfamilia.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SubFamilia() As String
        Get
            Return _subfamilia.Nombre
        End Get
        Set(ByVal value As String)
            _subfamilia.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCtaCtbleExistencias() As String
        Get
            Return _cuentacontable.Id
        End Get
        Set(ByVal value As String)
            _cuentacontable.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCtaCtbleCompras() As String
        Get
            Return _ctactblecompra.Id
        End Get
        Set(ByVal value As String)
            _ctactblecompra.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCtaCtbleConsumo() As String
        Get
            Return _ctactbleconsumo.Id
        End Get
        Set(ByVal value As String)
            _ctactbleconsumo.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CtaCtbleExistencias() As String
        Get
            Return _cuentacontable.Nombre
        End Get
        Set(ByVal value As String)
            _cuentacontable.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CtaCtbleCompra() As String
        Get
            Return _ctactblecompra.Nombre
        End Get
        Set(ByVal value As String)
            _ctactblecompra.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCtaCtbleCompra() As String
        Get
            Return _ctactblecompra.Cuenta
        End Get
        Set(ByVal value As String)
            _ctactblecompra.Cuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CtaCtbleConsumo() As String
        Get
            Return _ctactbleconsumo.Nombre
        End Get
        Set(ByVal value As String)
            _ctactbleconsumo.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCtaCtbleConsumo() As String
        Get
            Return _ctactbleconsumo.Cuenta
        End Get
        Set(ByVal value As String)
            _ctactbleconsumo.Cuenta = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property IdItemGasto() As String
        Get
            Return _itemgasto.Id
        End Get
        Set(ByVal value As String)
            _itemgasto.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCtaCtbleExistencias() As String
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
        TotalCuentas = 0
        Tipo = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdSubFamilia As String _
              , ByVal ls_SubFamilia As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_NroCuenta As String _
              , ByVal ls_Cuenta As String _
              , ByVal ls_Ejercicio As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCtaCtbleCompra As String _
              , ByVal ls_CtaCtbleCompra As String _
              , ByVal ls_NroCtaCtbleCompra As String _
              , ByVal ls_IdCtaCtbleConsumo As String _
              , ByVal ls_CtaCtbleConsumo As String _
              , ByVal ls_NroCtaCtbleConsumo As String _
              , ByVal ls_IdItemGasto As String _
              , ByVal ls_ItemGasto As String)
        _id = ls_Id
        _subfamilia.Id = ls_IdSubFamilia
        _subfamilia.Nombre = ls_SubFamilia
        _cuentacontable.Id = ls_IdCuentaContable
        _cuentacontable.Cuenta = ls_NroCuenta
        _cuentacontable.Nombre = ls_Cuenta
        _cuentacontable.Ejercicio = ls_Ejercicio
        _ctactblecompra.Id = ls_IdCtaCtbleCompra
        _ctactblecompra.Nombre = ls_CtaCtbleCompra
        _ctactblecompra.Cuenta = ls_NroCtaCtbleCompra
        _ctactbleconsumo.Id = ls_IdCtaCtbleConsumo
        _ctactbleconsumo.Nombre = ls_CtaCtbleConsumo
        _ctactbleconsumo.Cuenta = ls_NroCtaCtbleConsumo
        _itemgasto.Id = ls_IdItemGasto
        _itemgasto.Nombre = ls_ItemGasto
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal ctactblesubfamilia As e_CtaCtbleSubFamiliaMat) As e_CtaCtbleSubFamiliaMat Implements Ie_CtaCtbleSubFamiliaMat.Obtener
        Return ctactblesubfamilia
    End Function

    Public Function Equals1(ctactblesfm As e_CtaCtbleSubFamiliaMat) As Boolean Implements IEquatable(Of e_CtaCtbleSubFamiliaMat).Equals
        Select Case ctactblesfm.Tipo
            Case 1
                If Me.IdSubFamilia.Trim = ctactblesfm.IdSubFamilia.Trim Then Return True
        End Select

        Return False
    End Function

#End Region

End Class
