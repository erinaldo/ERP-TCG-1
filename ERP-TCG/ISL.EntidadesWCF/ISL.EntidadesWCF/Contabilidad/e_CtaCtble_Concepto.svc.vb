' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CtaCtble_Concepto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CtaCtble_Concepto.svc o e_CtaCtble_Concepto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CtaCtble_Concepto
    Implements Ie_CtaCtble_Concepto
    Implements IEquatable(Of e_CtaCtble_Concepto)

#Region "Propiedad"

    Private _id As String
    Private _cuentacontable As New e_CuentaContable
    Private _conceptoingresos As New e_ConceptoIngresos
    Private _flujocaja As New e_FlujoCaja
    Private _moneda As New e_Moneda
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Tipo As Integer
    <DataMember()> _
    Public Ejercicio As Integer
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
    Public Property IdMoneda() As String
        Get
            Return _moneda.Id
        End Get
        Set(ByVal value As String)
            _moneda.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaContable() As String
        Get
            Return _cuentacontable.Cuenta
        End Get
        Set(ByVal value As String)
            _cuentacontable.Cuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdConceptoIngresos() As String
        Get
            Return _conceptoingresos.Id
        End Get
        Set(ByVal value As String)
            _conceptoingresos.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _flujocaja.Id
        End Get
        Set(ByVal value As String)
            _flujocaja.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
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
        Tipo = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_CuentaContable As String _
              , ByVal ls_IdConceptoIngresos As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal ls_IdMoneda As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _cuentacontable.Id = ls_IdCuentaContable
        _cuentacontable.Cuenta = ls_CuentaContable
        _conceptoingresos.Id = ls_IdConceptoIngresos
        _flujocaja.Id = ls_IdFlujoCaja
        _moneda.Id = ls_IdMoneda
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ctactble_concepto As e_CtaCtble_Concepto) As e_CtaCtble_Concepto Implements Ie_CtaCtble_Concepto.Obtener
        Return ctactble_concepto
    End Function

    Public Function Equals1(other As e_CtaCtble_Concepto) As Boolean Implements IEquatable(Of e_CtaCtble_Concepto).Equals
        Select Case other.Tipo
            Case 0
                If Me.IdCuentaContable.Trim = other.IdCuentaContable.Trim And Me.IdConceptoIngresos = other.IdConceptoIngresos Then Return True
            Case 1
                If Me.IdConceptoIngresos.Trim = other.IdConceptoIngresos.Trim Then Return True
        End Select
    End Function

End Class
