

<DataContract()> _
Public Class e_AplicaDetraccion
    Implements Ie_AplicaDetraccion

#Region "Declaracion de varaibles"

    Private _IdMovimientoDocumento As String
    Private _Serie As String
    Private _Numero As String
    Private _FechaEmision As Date
    Private _IdCliente As String
    Private _Cliente As String
    Private _IdTipoMoneda As String
    Private _TipoMoneda As String
    Private _Total As Double
    Private _Saldo As Double
    Private _Detraccion As Double
    Private _SaldoDetraccion As Double
    Private _FechaCobro As String
    Private _CuentaBancaria As String
    Private _MontoCobro As String
    Private _SumaCobro As Double
    Private _Aplicado As Boolean
    Private _Informe As Boolean
    Private _IdVenta As String
    Private _NroInforme As String
    Private _FechaUltimo As Date
    Private _diasven As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public _FechaInicio As Date
    <DataMember()> _
    Public _FechaFin As Date
    <DataMember()> _
    Public _IndAplicado As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _IdMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _IdMovimientoDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _Serie
        End Get
        Set(ByVal value As String)
            _Serie = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _FechaEmision
        End Get
        Set(ByVal value As Date)
            _FechaEmision = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoMoneda() As String
        Get
            Return _IdTipoMoneda
        End Get
        Set(ByVal value As String)
            _IdTipoMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMoneda() As String
        Get
            Return _TipoMoneda
        End Get
        Set(ByVal value As String)
            _TipoMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Detraccion() As Double
        Get
            Return _Detraccion
        End Get
        Set(ByVal value As Double)
            _Detraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoDetraccion() As Double
        Get
            Return _SaldoDetraccion
        End Get
        Set(ByVal value As Double)
            _SaldoDetraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCobro() As String
        Get
            Return _FechaCobro
        End Get
        Set(ByVal value As String)
            _FechaCobro = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaBancaria() As String
        Get
            Return _CuentaBancaria
        End Get
        Set(ByVal value As String)
            _CuentaBancaria = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCobro() As String
        Get
            Return _MontoCobro
        End Get
        Set(ByVal value As String)
            _MontoCobro = value
        End Set
    End Property

    <DataMember()> _
    Public Property SumaCobro() As Double
        Get
            Return _SumaCobro
        End Get
        Set(ByVal value As Double)
            _SumaCobro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Aplicado() As Boolean
        Get
            Return _Aplicado
        End Get
        Set(ByVal value As Boolean)
            _Aplicado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Informe() As Boolean
        Get
            Return _Informe
        End Get
        Set(ByVal value As Boolean)
            _Informe = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVenta() As String
        Get
            Return _IdVenta
        End Get
        Set(ByVal value As String)
            _IdVenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroInforme() As String
        Get
            Return _NroInforme
        End Get
        Set(ByVal value As String)
            _NroInforme = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaUltimo() As Date
        Get
            Return _FechaUltimo
        End Get
        Set(ByVal value As Date)
            _FechaUltimo = value
        End Set
    End Property

    <DataMember()> _
   Public Property DiasVen() As Integer
        Get
            If _Saldo > 0 Then
                DiasVen = 0
            Else
                Dim fec As Date = #1/1/1901#
                Dim fechaxx As Date = _FechaUltimo
                Dim dia As String = _FechaUltimo.DayOfWeek.ToString
                If dia = "Monday" Then
                    fec = _FechaUltimo.AddDays(7)
                Else
                    fec = _FechaUltimo.AddDays(6)
                End If

                DiasVen = DateDiff(DateInterval.Day, fec, Date.Now)
            End If
            Return DiasVen
        End Get
        Set(ByVal value As Integer)
            _diasven = value
            'RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _IdMovimientoDocumento = String.Empty
        _Serie = String.Empty
        _Numero = String.Empty
        _FechaEmision = #1/1/1901#
        _IdCliente = String.Empty
        _Cliente = String.Empty
        _IdTipoMoneda = String.Empty
        _TipoMoneda = String.Empty
        _Total = 0
        _Saldo = 0
        _Detraccion = 0
        _SaldoDetraccion = 0
        _FechaCobro = String.Empty
        _CuentaBancaria = String.Empty
        _MontoCobro = String.Empty
        _Aplicado = False
        _Informe = False
        _FechaUltimo = #1/1/1901#
        _diasven = 0
        TipoOperacion = String.Empty
    End Sub

    Public Sub New(ByVal ls_IdMovimientoDocumento As String _
                   , ByVal ls_Serie As String _
                   , ByVal ls_Numero As String _
                   , ByVal ld_FechaEmision As Date _
                   , ByVal ls_IdCliente As String _
                   , ByVal ls_Cliente As String _
                   , ByVal ls_IdTipoMoneda As String _
                   , ByVal ls_TipoMoneda As String _
                   , ByVal ln_Total As Double _
                   , ByVal ln_Saldo As Double _
                   , ByVal ln_Detraccion As Double _
                   , ByVal ln_SaldoDetraccion As Double _
                   , ByVal ls_FechaCobro As String _
                   , ByVal ls_CuentaBancaria As String _
                   , ByVal ls_MontoCobro As String _
                   , ByVal ln_SumaCobro As Double _
                   , ByVal lb_Aplicado As Boolean _
                   , ByVal lb_Informe As Boolean _
                   , ByVal ls_IdVenta As String _
                   , ByVal ls_NroInforme As String _
                   , ByVal ld_FechaUltimo As Date)

        _IdMovimientoDocumento = ls_IdMovimientoDocumento
        _Serie = ls_Serie
        _Numero = ls_Numero
        _FechaEmision = ld_FechaEmision
        _IdCliente = ls_IdCliente
        _Cliente = ls_Cliente
        _IdTipoMoneda = ls_IdTipoMoneda
        _TipoMoneda = ls_TipoMoneda
        _Total = ln_Total
        _Saldo = ln_Saldo
        _Detraccion = ln_Detraccion
        _SaldoDetraccion = ln_SaldoDetraccion
        _FechaCobro = ls_FechaCobro
        _CuentaBancaria = ls_CuentaBancaria
        _MontoCobro = ls_MontoCobro
        _SumaCobro = ln_SumaCobro
        _Aplicado = lb_Aplicado
        _Informe = lb_Informe
        _IdVenta = ls_IdVenta
        _NroInforme = ls_NroInforme
        _FechaUltimo = ld_FechaUltimo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal aplicaDetraccion As e_AplicaDetraccion) As e_AplicaDetraccion Implements Ie_AplicaDetraccion.Obtener
        Return aplicaDetraccion
    End Function

#End Region

End Class


