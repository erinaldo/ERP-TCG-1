
<DataContract()> _
Public Class e_PagoDescuento
    Implements Ie_PagoDescuento
    Implements IEquatable(Of e_PagoDescuento)

#Region "Declaracion de Variables"

    Private _idTrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _ingresobruto As String
    Private _monto As Double
    Private _saldo As Double
    Private _cuota As Double
    Private _saldofinal As Double
    Private _cadidprestamo As String
    Private _montoprestamo As String
    Private _cadidprestamodet As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Anio As String
    <DataMember()> _
    Public Mes As String
    <DataMember()> _
    Public DobleMes As Integer
    <DataMember()> _
    Public Indicador As Integer
    <DataMember()> _
    Public Equivale As Integer

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoBruto() As Double
        Get
            Return _ingresobruto
        End Get
        Set(ByVal value As Double)
            _ingresobruto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuota() As Double
        Get
            Return _cuota
        End Get
        Set(ByVal value As Double)
            _cuota = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoFinal() As Double
        Get
            Return (_saldo - _cuota)
        End Get
        Set(ByVal value As Double)
            _saldofinal = value
        End Set
    End Property

    Public Property CadIdPrestamo() As String
        Get
            Return _cadidprestamo
        End Get
        Set(ByVal value As String)
            _cadidprestamo = value
        End Set
    End Property

    Public Property MontoPrestamo() As String
        Get
            Return _montoprestamo
        End Get
        Set(ByVal value As String)
            _montoprestamo = value
        End Set
    End Property

    Public Property CadIdPrestamoDet() As String
        Get
            Return _cadidprestamodet
        End Get
        Set(ByVal value As String)
            _cadidprestamodet = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        _idTrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _monto = 0
        _saldo = 0
        _cuota = 0
        _saldofinal = 0
        _cadidprestamo = String.Empty
        _montoprestamo = String.Empty
        TipoOperacion = String.Empty
        _cadidprestamodet = String.Empty
        Indicador = -1

    End Sub

    Public Sub New(ByVal ls_IdTrabajador As String, _
                   ByVal ls_Dni As String, _
                   ByVal ls_Trabajador As String, _
                   ByVal ln_Monto As Double, _
                   ByVal ln_Saldo As Double, _
                   ByVal ln_Cuota As Double, _
                   ByVal ls_CadIdPrestamo As String, _
                   ByVal ls_MontoPrestamo As String, _
                   ByVal ls_CadIdPrestamoDet As String)

        _idTrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _monto = ln_Monto
        _saldo = ln_Saldo
        _cuota = ln_Cuota
        _cadidprestamo = ls_CadIdPrestamo
        _montoprestamo = ls_MontoPrestamo
        _cadidprestamodet = ls_CadIdPrestamoDet
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal pagodescuento As e_PagoDescuento) As e_PagoDescuento Implements Ie_PagoDescuento.Obtener
        Return pagodescuento
    End Function

    Public Overloads Function Equals(ByVal oePagoDesc As e_PagoDescuento) As Boolean Implements System.IEquatable(Of e_PagoDescuento).Equals

        Select Case oePagoDesc.Equivale
            Case 1 : If Me.IdTrabajador = oePagoDesc.IdTrabajador Then Return True
        End Select

        Return False
    End Function

#End Region

End Class

