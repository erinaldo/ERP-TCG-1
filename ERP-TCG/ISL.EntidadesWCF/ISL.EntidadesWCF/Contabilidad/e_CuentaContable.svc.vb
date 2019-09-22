<DataContract()> _
Public Class e_CuentaContable
    Implements Ie_CuentaContable
    Implements ICloneable

    Implements IEquatable(Of e_CuentaContable)

#Region "Declaración de variables"

    Private _seleccion As Boolean
    Private _id As String
    Private _cuenta As String
    Private _nombre As String
    Private _Ejercicio As Integer
    Private _idNaturaleza As String
    Private _movimiento As Boolean
    Private _idtipocuentacorriente As String
    Private _tesoreria As Integer
    Private _idtipodocgeneral As String
    Private _trabajador As Integer
    Private _conciliacion As Integer
    Private _monedaextrangera As Integer
    Private _Serie As Integer
    Private _nrodocumento As Integer
    Private _fechaemision As Integer
    Private _fechavencimiento As Integer
    Private _centrocosto As Integer
    Private _flujocaja As Integer
    Private _tracto As Integer
    Private _ruta As Integer
    Private _banco As Integer
    Private _analisis01 As Integer
    Private _analisi02 As Integer
    Private _activo As Boolean
    Private _GastoFuncion As Integer
    Private _PartidaAnalisis As Integer
    Private _IdTablaContableDet As String

    <DataMember()> _
    Public CuentaAsociada As New List(Of e_CuentaAsociada)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public IdTipoCompra As String

    <DataMember()> _
    Public Equivale As Integer

    Public TipoBusca As Integer

    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
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
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Naturaleza() As String
        Get
            Return _idNaturaleza
        End Get
        Set(ByVal value As String)
            _idNaturaleza = value
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

    <DataMember()> _
    Public Property Movimiento() As Boolean
        Get
            Return _movimiento
        End Get
        Set(ByVal value As Boolean)
            _movimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCuentaCorriente() As String
        Get
            Return _idtipocuentacorriente
        End Get
        Set(ByVal value As String)
            _idtipocuentacorriente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tesoreria() As Integer
        Get
            Return _tesoreria
        End Get
        Set(ByVal value As Integer)
            _tesoreria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocGeneral() As String
        Get
            Return _idtipodocgeneral
        End Get
        Set(ByVal value As String)
            _idtipodocgeneral = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As Integer
        Get
            Return _trabajador
        End Get
        Set(ByVal value As Integer)
            _trabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Conciliacion() As Integer
        Get
            Return _conciliacion
        End Get
        Set(ByVal value As Integer)
            _conciliacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property MonedaExtranjera() As Integer
        Get
            Return _monedaextrangera
        End Get
        Set(ByVal value As Integer)
            _monedaextrangera = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As Integer
        Get
            Return _Serie
        End Get
        Set(ByVal value As Integer)
            _Serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroDocumento() As Integer
        Get
            Return _nrodocumento
        End Get
        Set(ByVal value As Integer)
            _nrodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Integer
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Integer)
            _fechaemision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Integer
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Integer)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CentroCosto() As Integer
        Get
            Return _centrocosto
        End Get
        Set(ByVal value As Integer)
            _centrocosto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja() As Integer
        Get
            Return _flujocaja
        End Get
        Set(ByVal value As Integer)
            _flujocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tracto() As Integer
        Get
            Return _tracto
        End Get
        Set(ByVal value As Integer)
            _tracto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As Integer
        Get
            Return _ruta
        End Get
        Set(ByVal value As Integer)
            _ruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Banco() As Integer
        Get
            Return _banco
        End Get
        Set(ByVal value As Integer)
            _banco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Analisis01() As Integer
        Get
            Return _analisis01
        End Get
        Set(ByVal value As Integer)
            _analisis01 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Analisis02() As Integer
        Get
            Return _analisi02
        End Get
        Set(ByVal value As Integer)
            _analisi02 = value
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
    Public Property GastoFuncion() As Integer
        Get
            Return _GastoFuncion
        End Get
        Set(ByVal value As Integer)
            _GastoFuncion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
    <DataMember()> _
    Public Property PartidaAnalisis() As Integer
        Get
            Return _PartidaAnalisis
        End Get
        Set(ByVal value As Integer)
            _PartidaAnalisis = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdTablaContableDet() As String
        Get
            Return _IdTablaContableDet
        End Get
        Set(ByVal value As String)
            _IdTablaContableDet = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        TipoOperacion = "N"
        TipoCuentaCorriente = ""
        TipoDocGeneral = ""
        Id = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Cuenta As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Ejercicio As Integer _
              , ByVal ls_IdNaturaleza As String _
              , ByVal lb_Movimiento As Boolean _
              , ByVal ls_IdTipoCuentaCorriente As String _
              , ByVal ln_Tesoreria As Integer _
              , ByVal ls_IdTipoDocGeneral As String _
              , ByVal ln_Trabajador As Integer _
              , ByVal ln_Conciliacion As Integer _
              , ByVal ln_MonedaExtrangera As Integer _
              , ByVal ln_Serie As Integer _
              , ByVal ln_NroDocumento As Integer _
              , ByVal ln_FechaEmision As Integer _
              , ByVal ln_FechaVencimiento As Integer _
              , ByVal ln_CentroCosto As Integer _
              , ByVal ln_FlujoCaja As Integer _
              , ByVal ln_Tracto As Integer _
              , ByVal ln_Ruta As Integer _
              , ByVal ln_Banco As Integer _
              , ByVal ln_Analisis01 As Integer _
              , ByVal ln_Analisi02 As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_GastoFuncion As Integer _
              , ByVal lsIdTipoCompra As String _
              , ByVal ln_PartidaAnalisis As Integer _
              , ByVal ls_IdTablaContableDet As String)
        IdTipoCompra = lsIdTipoCompra
        _id = ls_Id
        _cuenta = ls_Cuenta
        _nombre = ls_Nombre
        _Ejercicio = ls_Ejercicio
        _idNaturaleza = ls_IdNaturaleza
        _movimiento = lb_Movimiento
        _idtipocuentacorriente = ls_IdTipoCuentaCorriente
        _tesoreria = ln_Tesoreria
        _idtipodocgeneral = ls_IdTipoDocGeneral
        _trabajador = ln_Trabajador
        _conciliacion = ln_Conciliacion
        _monedaextrangera = ln_MonedaExtrangera
        _Serie = ln_Serie
        _nrodocumento = ln_NroDocumento
        _fechaemision = ln_FechaEmision
        _fechavencimiento = ln_FechaVencimiento
        _centrocosto = ln_CentroCosto
        _flujocaja = ln_FlujoCaja
        _tracto = ln_Tracto
        _ruta = ln_Ruta
        _banco = ln_Banco
        _analisis01 = ln_Analisis01
        _analisi02 = ln_Analisi02
        _activo = lb_Activo
        _GastoFuncion = ls_GastoFuncion
        _PartidaAnalisis = ln_PartidaAnalisis
        _IdTablaContableDet = ls_IdTablaContableDet
    End Sub

#End Region

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Function NivelCuenta() As Integer
        Dim _nc As Integer = 0
        _nc = Cuenta.Trim.Length - 1
        Return _nc
    End Function

    Public Function Obtener(ByVal cuentaContable As e_CuentaContable) As e_CuentaContable Implements Ie_CuentaContable.Obtener
        Return cuentaContable
    End Function

    Public Overloads Function Equals(ByVal oeCta As e_CuentaContable) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_CuentaContable).Equals
        Select Case oeCta.Equivale
            Case 0 : If Me.Cuenta.Trim = oeCta.Cuenta.Trim Then Return True
            Case 1 : If Me.Id.Trim = oeCta.Id.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
