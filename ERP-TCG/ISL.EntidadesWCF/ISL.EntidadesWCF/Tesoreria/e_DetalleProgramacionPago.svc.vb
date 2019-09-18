<DataContract()> _
Public Class e_DetalleProgramacionPago
    Implements Ie_DetalleProgramacionPago

#Region "Declaración de variables"

    Private _Id As String = ""
    Private _IdMovimientoDocumento As String = ""
    Private _IdProgramacionPago As String = ""
    Private _IdEstado As String = ""
    Private _IdUsuario As String = ""
    Private _MontoOriginal As Decimal = 0.0
    Private _Afectacion As Decimal = 0.0
    Private _MontoPago As Decimal = 0.0
    Private _PorcAfect As Decimal = 0.0
    Private _TipoAfect As String = ""
    Private _TipoOrden As String = ""
    Private _IdTipoGasto As String = ""
    Private _CtaBancaria As String = ""
    Private _NroOperacion As String = ""
    Private _FlujoGasto As String = ""
    Private _CtaContable As String = ""
    Private _MedioPago As String = ""
    Private _FechaPago As Date = #1/1/1901#
    <DataMember()> _
    Public TipoOperacion As String = ""
    <DataMember()> _
    Public Modificado As Boolean = False
    Public Event DatoCambiado()
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Constructores"

    Sub New(ByVal Id As String, ByVal IdEstado As String, IdProgramacionPago As String, ByVal IdUsuario As String, ByVal MontoOriginal As Decimal, _
            ByVal Afectacion As Decimal, PorcAfect As Decimal, TipoOrden As String, TipoAfect As String,
            ByVal MontoPago As Decimal, IdMovimientoDocumento As String, IdTipoGasto As String, CtaBancaria As String, _
             NroOperacion As String, FlujoGasto As String, CtaContable As String, MedioPago As String, FechaPago As Date)
        _Id = Id
        _IdEstado = IdEstado
        _IdProgramacionPago = IdProgramacionPago
        _IdUsuario = IdUsuario
        _MontoOriginal = MontoOriginal
        _Afectacion = Afectacion
        _PorcAfect = PorcAfect
        _MontoPago = MontoPago
        _TipoOrden = TipoOrden
        _TipoAfect = TipoAfect
        _IdMovimientoDocumento = IdMovimientoDocumento
        _IdTipoGasto = IdTipoGasto
        _MedioPago = MedioPago
        _FlujoGasto = FlujoGasto
        _CtaBancaria = CtaBancaria
        _NroOperacion = NroOperacion
        _CtaContable = CtaContable
        _FechaPago = FechaPago
    End Sub

    Sub New()
        _Id = Id
        _IdEstado = IdEstado
        _IdMovimientoDocumento = IdMovimientoDocumento
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _IdMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _IdMovimientoDocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoGasto() As String
        Get
            Return _IdTipoGasto
        End Get
        Set(ByVal value As String)
            _IdTipoGasto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdProgramacionPago() As String
        Get
            Return _IdProgramacionPago
        End Get
        Set(ByVal value As String)
            _IdProgramacionPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuario() As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoOriginal() As Decimal
        Get
            Return _MontoOriginal
        End Get
        Set(ByVal value As Decimal)
            _MontoOriginal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Afectacion() As Decimal
        Get
            Return _Afectacion
        End Get
        Set(ByVal value As Decimal)
            _Afectacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PorcAfect() As Decimal
        Get
            Return _PorcAfect
        End Get
        Set(ByVal value As Decimal)
            _PorcAfect = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property TipoAfect() As String
        Get
            Return _TipoAfect
        End Get
        Set(ByVal value As String)
            _TipoAfect = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property TipoOrden() As String
        Get
            Return _TipoOrden
        End Get
        Set(ByVal value As String)
            _TipoOrden = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property CtaBancaria() As String
        Get
            Return _CtaBancaria
        End Get
        Set(ByVal value As String)
            _CtaBancaria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property NroOperacion() As String
        Get
            Return _NroOperacion
        End Get
        Set(ByVal value As String)
            _NroOperacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FlujoGasto() As String
        Get
            Return _FlujoGasto
        End Get
        Set(ByVal value As String)
            _FlujoGasto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property CtaContable() As String
        Get
            Return _CtaContable
        End Get
        Set(ByVal value As String)
            _CtaContable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MedioPago() As String
        Get
            Return _MedioPago
        End Get
        Set(ByVal value As String)
            _MedioPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoPago() As Decimal
        Get
            Return _MontoPago
        End Get
        Set(ByVal value As Decimal)
            _MontoPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaPago() As Date
        Get
            Return _FechaPago
        End Get
        Set(ByVal value As Date)
            _FechaPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Function Obtener(ByVal detalleprogramacionpago As e_DetalleProgramacionPago) As e_DetalleProgramacionPago Implements Ie_DetalleProgramacionPago.Obtener
        Return detalleprogramacionpago
    End Function
#End Region

End Class

