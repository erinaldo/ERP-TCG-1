<DataContract()> _
Public Class e_ProgramacionPago
    Implements Ie_ProgramacionPago

#Region "Declaración de variables"

    Private _Id As String
    Private _Observaciones As String
    Private _IdEstado As String
    Private _NroLote As String
    Private _IdUsuario As String
    Private _MontoOriginal As Decimal
    Private _Retencion As Decimal
    Private _Detraccion As Decimal
    Private _MontoPago As Decimal
    Private _Moneda As String
    Private _FechaCrea As Date = #1/1/1901#
    Private _FechaModifica As Date = #1/1/1901#
    '-------------- LINEAS AGREGADAS PARA LA PROGRAMACIÓN DE PAGOS POR MOVIMIENTO DE DOC-------------------
    Public lst_MovimientoDocumento As List(Of e_MovimientoDocumento)
    Public lst_DetalleProgPago As List(Of e_DetalleProgramacionPago)
    '-----------------------------------------------------------------------------------------------------
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Sub New(ByVal Id As String, ByVal IdEstado As String, ByVal NroLote As String, ByVal IdUsuario As String, ByVal MontoOriginal As Decimal, _
            ByVal Retencion As Decimal, ByVal Detraccion As Decimal, ByVal MontoPago As Decimal, Observaciones As String, FechaCrea As Date, FechaModifica As Date, _
             Moneda As String)
        _Id = Id
        _IdEstado = IdEstado
        _NroLote = NroLote
        _IdUsuario = IdUsuario
        _MontoOriginal = MontoOriginal
        _Retencion = Retencion
        _Detraccion = Detraccion
        _MontoPago = MontoPago
        _Observaciones = Observaciones
        _FechaCrea = FechaCrea
        _FechaModifica = FechaModifica
        _Moneda = Moneda
    End Sub

    Sub New()
        _Id = Id
        _IdEstado = IdEstado
        _NroLote = NroLote
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
    Public Property Observaciones() As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
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
    Public Property NroLote() As String
        Get
            Return _NroLote
        End Get
        Set(ByVal value As String)
            _NroLote = value
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
    Public Property Retencion() As Decimal
        Get
            Return _Retencion
        End Get
        Set(ByVal value As Decimal)
            _Retencion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Detraccion() As Decimal
        Get
            Return _Detraccion
        End Get
        Set(ByVal value As Decimal)
            _Detraccion = value
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
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    

    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    

    Public Function Obtener(ByVal programacionpago As e_ProgramacionPago) As e_ProgramacionPago Implements Ie_ProgramacionPago.Obtener
        Return programacionpago
    End Function
#End Region

End Class

