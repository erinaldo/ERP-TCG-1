' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CuadreCaja" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CuadreCaja.svc o e_CuadreCaja.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CuadreCaja
    Implements Ie_CuadreCaja

#Region "Propiedad"

    Private _id As String
    Private _caja As New e_Caja
    Private _fecha As Date
    Private _saldosistema As Double
    Private _efectivo As Double
    Private _otros As Double
    Private _diferencia As Double
    Private _totalbolsas As Double
    Private _totalgastos As Double
    Private _200 As Integer
    Private _100 As Integer
    Private _50 As Integer
    Private _20 As Integer
    Private _10 As Integer
    Private _5 As Integer
    Private _2 As Integer
    Private _1 As Integer
    Private _05 As Integer
    Private _02 As Integer
    Private _01 As Integer
    Private _005 As Integer
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _codigo As String
    Private _observacion As String
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public loCajaBolsa As New List(Of e_CuadreCajaBolsa)
    <DataMember()> _
    Public loCajaGasto As New List(Of e_CuadreCajaGasto)

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
    Public Property IdCaja() As String
        Get
            Return _caja.Id
        End Get
        Set(ByVal value As String)
            _caja.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Caja() As String
        Get
            Return _caja.Nombre
        End Get
        Set(ByVal value As String)
            _caja.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalBolsas() As Double
        Get
            Return _totalbolsas
        End Get
        Set(ByVal value As Double)
            _totalbolsas = value
        End Set
    End Property

    <DataMember()>
    Public Property TotalGastos() As Double
        Get
            Return _totalgastos
        End Get
        Set(ByVal value As Double)
            _totalgastos = value
        End Set
    End Property

    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoSistema() As Double
        Get
            Return _saldosistema
        End Get
        Set(ByVal value As Double)
            _saldosistema = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Efectivo() As Double
        Get
            Return _efectivo
        End Get
        Set(ByVal value As Double)
            _efectivo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Otros() As Double
        Get
            Return _otros
        End Get
        Set(ByVal value As Double)
            _otros = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Diferencia() As Double
        Get
            Return _diferencia
        End Get
        Set(ByVal value As Double)
            _diferencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num200() As Integer
        Get
            Return _200
        End Get
        Set(ByVal value As Integer)
            _200 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num100() As Integer
        Get
            Return _100
        End Get
        Set(ByVal value As Integer)
            _100 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num50() As Integer
        Get
            Return _50
        End Get
        Set(ByVal value As Integer)
            _50 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num20() As Integer
        Get
            Return _20
        End Get
        Set(ByVal value As Integer)
            _20 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num10() As Integer
        Get
            Return _10
        End Get
        Set(ByVal value As Integer)
            _10 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num5() As Integer
        Get
            Return _5
        End Get
        Set(ByVal value As Integer)
            _5 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num2() As Integer
        Get
            Return _2
        End Get
        Set(ByVal value As Integer)
            _2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num1() As Integer
        Get
            Return _1
        End Get
        Set(ByVal value As Integer)
            _1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num05() As Integer
        Get
            Return _05
        End Get
        Set(ByVal value As Integer)
            _05 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num02() As Integer
        Get
            Return _02
        End Get
        Set(ByVal value As Integer)
            _02 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num01() As Integer
        Get
            Return _01
        End Get
        Set(ByVal value As Integer)
            _01 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property num005() As Integer
        Get
            Return _005
        End Get
        Set(ByVal value As Integer)
            _005 = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Activo = True
        Fecha = Date.Parse("01/01/1901")
        FechaCreacion = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
                   , ByVal ls_Codigo As String _
              , ByVal ls_IdCaja As String _
              , ByVal ls_Caja As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_SaldoSistema As Double _
              , ByVal ln_Efectivo As Double _
              , ByVal ln_TotalGastos As Double _
              , ByVal ln_TotalBolsas As Double _
              , ByVal ln_Otros As Double _
              , ByVal ln_Diferencia As Double _
              , ByVal ls_Observacion As String _
              , ByVal ln_200 As Integer _
              , ByVal ln_100 As Integer _
              , ByVal ln_50 As Integer _
              , ByVal ln_20 As Integer _
              , ByVal ln_10 As Integer _
              , ByVal ln_5 As Integer _
              , ByVal ln_2 As Integer _
              , ByVal ln_1 As Integer _
              , ByVal ln_05 As Integer _
              , ByVal ln_02 As Integer _
              , ByVal ln_01 As Integer _
              , ByVal ln_005 As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date)
        _id = ls_Id
        _caja.Id = ls_IdCaja
        _caja.Nombre = ls_Caja
        _fecha = ld_Fecha
        _saldosistema = ln_SaldoSistema
        _codigo = ls_Codigo
        _efectivo = ln_Efectivo
        _otros = ln_Otros
        _diferencia = ln_Diferencia
        _observacion = ls_Observacion
        _totalbolsas = ln_TotalBolsas
        _totalgastos = ln_TotalGastos
        _200 = ln_200
        _100 = ln_100
        _50 = ln_50
        _20 = ln_20
        _10 = ln_10
        _5 = ln_5
        _2 = ln_2
        _1 = ln_1
        _05 = ln_05
        _02 = ln_02
        _01 = ln_01
        _005 = ln_005
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

#Region "Metodos"


#End Region

    Public Function Obtener(cuadrecaja As e_CuadreCaja) As e_CuadreCaja Implements Ie_CuadreCaja.Obtener
        Return cuadrecaja
    End Function

End Class
