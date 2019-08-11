


<DataContract()> _
Public Class e_MovimientoCaja
    Implements Ie_MovimientoCaja

#Region "Declaración de Variables"

    Private _empresa As String
    Private _fechacompleta As String
    Private _viaje As String
    Private _usuario As String
    Private _voucher As String
    Private _egreso As Double
    Private _egresotexto As String
    Private _glosa As String
    Private _idTrabajadorRecepciona As String
    Private _trabajador As String
    Private _dni As String
    Private _cargo As String
    Private _piloto As String
    Private _mov As String
    <DataMember()> _
    Public IdMovimiento As String
    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
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
    Public Property IdTrabajadorRecepciona() As String
        Get
            Return _idTrabajadorRecepciona
        End Get
        Set(ByVal value As String)
            _idTrabajadorRecepciona = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCompleto() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Egreso() As Double
        Get
            Return _egreso
        End Get
        Set(ByVal value As Double)
            _egreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property EgresoTexto() As String
        Get
            Return _egresotexto
        End Get
        Set(ByVal value As String)
            _egresotexto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Voucher() As String
        Get
            Return _voucher
        End Get
        Set(ByVal value As String)
            _voucher = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _piloto
        End Get
        Set(ByVal value As String)
            _piloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCompleta() As String
        Get
            Return _fechacompleta
        End Get
        Set(ByVal value As String)
            _fechacompleta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mov() As String
        Get
            Return _mov
        End Get
        Set(ByVal value As String)
            _mov = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()
        _fechacompleta = Date.Now
        _viaje = ""
        _usuario = ""
        _voucher = ""
        _egreso = 0
        _glosa = ""
        _idTrabajadorRecepciona = ""
        _trabajador = ""
        _dni = ""
        _cargo = ""
        _egresotexto = ""
        _mov = ""
    End Sub

    Sub New(ByVal Empresa As String, _
            ByVal Fecha As String, _
            ByVal Viaje As String, _
            ByVal Usuario As String, _
            ByVal Voucher As String, _
            ByVal Egreso As Double, _
            ByVal Glosa As String, _
            ByVal IdTrabajadorRecepciona As String, _
            ByVal Trabajador As String, _
            ByVal Dni As String, _
            ByVal Cargo As String, _
            ByVal Piloto As String, _
            ByVal egresoTexto As String, _
            ByVal Movimiento As String)

        _empresa = Empresa
        _fechacompleta = Fecha
        _viaje = Viaje
        _usuario = Usuario
        _voucher = Voucher
        _egreso = Egreso
        _glosa = Glosa
        _idTrabajadorRecepciona = IdTrabajadorRecepciona
        _trabajador = Trabajador
        _dni = Dni
        _cargo = Cargo
        _piloto = Piloto
        _egresotexto = egresoTexto
        _mov = Movimiento
    End Sub

#End Region

    Public Function Obtener(ByVal movimientoCaja As e_MovimientoCaja) As e_MovimientoCaja Implements Ie_MovimientoCaja.Obtener
        Return movimientoCaja
    End Function

End Class

