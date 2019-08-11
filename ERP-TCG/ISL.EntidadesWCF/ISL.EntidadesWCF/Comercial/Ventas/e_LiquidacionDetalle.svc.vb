

' NOTA: si cambia aquí el nombre de clase "e_LiquidacionDetalle", también debe actualizar la referencia a "e_LiquidacionDetalle" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_LiquidacionDetalle
    Implements IEquatable(Of e_LiquidacionDetalle)

    Implements Ie_LiquidacionDetalle

    'Public Sub DoWork() Implements Ie_LiquidacionDetalle.DoWork
    'End Sub
#Region "Propiedad"

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public IndFormato As Integer
    <DataMember()> _
    Public IdCliente As String

    Private _Seleccion As Boolean
    Private _Id As String
    Private _IdLiquidacion As String
    Private _Operacion As String
    Private _IdOperacion As String
    Private _Viaje As String
    Private _IdViaje As String
    Private _Fecha As Date
    Private _CodigoOrigen As String
    Private _Origen As String
    Private _CodigoDestino As String
    Private _Destino As String
    Private _Tracto As String
    Private _Carreta As String
    Private _Capacidad As Decimal
    Private _Volumen As Decimal
    Private _FleteUnitario As Decimal
    Private _TotalFlete As Decimal
    Private _Ruta As String
    Private _NroCarga As String
    Private _GuiaRemitente As String
    Private _GuiaTransportista As String
    Private _IndFacturado As Integer
    Private _IndGrtConfirmada As Integer
    Private _IndDocumentos As Integer
    Private _IndGrtPerdido As Integer
    Private _Observacion As String
    Private _activo As Boolean
    Private _TipoVehiculo As String
    Private _Consolidado1 As String
    Private _Consolidado2 As String
    Private _Consolidado3 As String
    Private _Consolidado As Decimal
    Private _IdVehiculo As String
    Private _FechaLLegada As Date
    Private _FechaSalida As Date
    Private _CentroCosto1 As String
    Private _CentroCosto2 As String
    Private _CentroCosto3 As String

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property
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
    Public Property IdLiquidacion() As String
        Get
            Return _IdLiquidacion
        End Get
        Set(ByVal value As String)
            _IdLiquidacion = value
        End Set
    End Property
    <DataMember()> _
   Public Property Operacion() As String
        Get
            Return _Operacion
        End Get
        Set(ByVal value As String)
            _Operacion = value
        End Set
    End Property
    <DataMember()> _
   Public Property IdOperacion() As String
        Get
            Return _IdOperacion
        End Get
        Set(ByVal value As String)
            _IdOperacion = value
        End Set
    End Property
    <DataMember()> _
   Public Property Viaje() As String
        Get
            Return _Viaje
        End Get
        Set(ByVal value As String)
            _Viaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _IdViaje
        End Get
        Set(ByVal value As String)
            _IdViaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property
    <DataMember()> _
    Public Property CodigoOrigen() As String
        Get
            Return _CodigoOrigen
        End Get
        Set(ByVal value As String)
            _CodigoOrigen = value
        End Set
    End Property
    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property
    <DataMember()> _
    Public Property CodigoDestino() As String
        Get
            Return _CodigoDestino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property
    <DataMember()> _
   Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property
    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _Tracto
        End Get
        Set(ByVal value As String)
            _Tracto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Carreta() As String
        Get
            Return _Carreta
        End Get
        Set(ByVal value As String)
            _Carreta = value
        End Set
    End Property
    <DataMember()> _
   Public Property Capacidad() As Decimal
        Get
            Return _Capacidad
        End Get
        Set(ByVal value As Decimal)
            _Capacidad = value
        End Set
    End Property

    <DataMember()> _
   Public Property Volumen() As Decimal
        Get
            Return _Volumen
        End Get
        Set(ByVal value As Decimal)
            _Volumen = value
        End Set
    End Property
    <DataMember()> _
    Public Property FleteUnitario() As Decimal
        Get
            Return _FleteUnitario
        End Get
        Set(ByVal value As Decimal)
            _FleteUnitario = value
        End Set
    End Property
    <DataMember()> _
    Public Property TotalFlete() As Decimal
        Get
            Return _TotalFlete
        End Get
        Set(ByVal value As Decimal)
            _TotalFlete = value
        End Set
    End Property
    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property
    <DataMember()> _
    Public Property NroCarga() As String
        Get
            Return _NroCarga
        End Get
        Set(ByVal value As String)
            _NroCarga = value
        End Set
    End Property
    <DataMember()> _
   Public Property GuiaRemitente() As String
        Get
            Return _GuiaRemitente
        End Get
        Set(ByVal value As String)
            _GuiaRemitente = value
        End Set
    End Property
    <DataMember()> _
   Public Property GuiaTransportista() As String
        Get
            Return _GuiaTransportista
        End Get
        Set(ByVal value As String)
            _GuiaTransportista = value
        End Set
    End Property
    <DataMember()> _
   Public Property IndFacturado() As Integer
        Get
            Return _IndFacturado
        End Get
        Set(ByVal value As Integer)
            _IndFacturado = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndGrtConfirmada() As Integer
        Get
            Return _IndGrtConfirmada
        End Get
        Set(ByVal value As Integer)
            _IndGrtConfirmada = value
        End Set
    End Property
    <DataMember()> _
  Public Property IndDocumentos() As Integer
        Get
            Return _IndDocumentos
        End Get
        Set(ByVal value As Integer)
            _IndDocumentos = value
        End Set
    End Property
    <DataMember()> _
 Public Property IndGrtPerdido() As Integer
        Get
            Return _IndGrtPerdido
        End Get
        Set(ByVal value As Integer)
            _IndGrtPerdido = value
        End Set
    End Property
    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _TipoVehiculo
        End Get
        Set(ByVal value As String)
            _TipoVehiculo = value
        End Set
    End Property
    <DataMember()> _
   Public Property Consolidado1() As String
        Get
            Return _Consolidado1
        End Get
        Set(ByVal value As String)
            _Consolidado1 = value
        End Set
    End Property
    <DataMember()> _
   Public Property Consolidado2() As String
        Get
            Return _Consolidado2
        End Get
        Set(ByVal value As String)
            _Consolidado2 = value
        End Set
    End Property
    <DataMember()> _
   Public Property Consolidado3() As String
        Get
            Return _Consolidado3
        End Get
        Set(ByVal value As String)
            _Consolidado3 = value
        End Set
    End Property
    <DataMember()> _
   Public Property Consolidado() As Decimal
        Get
            Return _Consolidado
        End Get
        Set(ByVal value As Decimal)
            _Consolidado = value
        End Set
    End Property
    <DataMember()> _
   Public Property IdVehiculo() As String
        Get
            Return _IdVehiculo
        End Get
        Set(ByVal value As String)
            _IdVehiculo = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaLlegada() As Date
        Get
            Return _FechaLLegada
        End Get
        Set(ByVal value As Date)
            _FechaLLegada = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaSalida() As Date
        Get
            Return _FechaSalida
        End Get
        Set(ByVal value As Date)
            _FechaSalida = value
        End Set
    End Property
    <DataMember()> _
   Public Property CentroCosto1() As String
        Get
            Return _CentroCosto1
        End Get
        Set(ByVal value As String)
            _CentroCosto1 = value
        End Set
    End Property
    <DataMember()> _
    Public Property CentroCosto2() As String
        Get
            Return _CentroCosto2
        End Get
        Set(ByVal value As String)
            _CentroCosto2 = value
        End Set
    End Property
    <DataMember()> _
    Public Property CentroCosto3() As String
        Get
            Return _CentroCosto3
        End Get
        Set(ByVal value As String)
            _CentroCosto3 = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Id = ""
        FechaDesde = ""
        FechaHasta = ""
        Consolidado = 0
        FleteUnitario = 0
        TotalFlete = 0
        Consolidado1 = ""
        CentroCosto1 = ""
        CentroCosto2 = ""
        CentroCosto3 = ""
        FechaLlegada = Date.Today
        FechaSalida = Date.Today
        IdCliente = ""
    End Sub
    Public Sub New(ByVal lb_Seleccion As Boolean, _
              ByVal ls_Id As String _
              , ByVal ls_IdLiquidacion As String _
              , ByVal ls_Operacion As String _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_IdViaje As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_CodigoOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_CodigoDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ls_Tracto As String _
              , ByVal ls_Carreta As String _
              , ByVal ld_Capacidad As Decimal _
              , ByVal ld_Volumen As Decimal _
              , ByVal ld_FleteUnitario As Decimal _
              , ByVal ld_TotalFlete As Decimal _
              , ByVal ls_Ruta As String _
              , ByVal ls_NroCarga As String _
              , ByVal ls_GuiaRemitente As String _
              , ByVal ls_GuiaTransportista As String _
              , ByVal li_IndFacturado As Integer _
              , ByVal li_IndGrtConfirmada As Integer _
              , ByVal li_IndDocumentos As Integer _
              , ByVal li_IndGrtPerdido As Integer _
              , ByVal ls_Observacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_TipoVehiculo As String _
              , ByVal ls_Consolidado1 As String _
              , ByVal ls_Consolidado2 As String _
              , ByVal ls_Consolidado3 As String _
              , ByVal ls_Consolidado As Decimal _
              , ByVal ls_IdVehiculo As String _
              , ByVal ld_FechaLlegada As Date _
              , ByVal ld_FechaSalida As Date _
              , ByVal ls_CentroCosto1 As String _
              , ByVal ls_CentroCosto2 As String _
              , ByVal ls_CentroCosto3 As String)
        _Seleccion = lb_Seleccion
        _Id = ls_Id
        _IdLiquidacion = ls_IdLiquidacion
        _Operacion = ls_Operacion
        _IdOperacion = ls_IdOperacion
        _Viaje = ls_Viaje
        _IdViaje = ls_IdViaje
        _Fecha = ld_Fecha
        _CodigoOrigen = ls_CodigoOrigen
        _Origen = ls_Origen
        _CodigoDestino = ls_CodigoDestino
        _Destino = ls_Destino
        _Tracto = ls_Tracto
        _Carreta = ls_Carreta
        _Capacidad = ld_Capacidad
        _Volumen = ld_Volumen
        _FleteUnitario = ld_FleteUnitario
        _TotalFlete = ld_TotalFlete
        _Ruta = ls_Ruta
        _NroCarga = ls_NroCarga
        _GuiaRemitente = ls_GuiaRemitente
        _GuiaTransportista = ls_GuiaTransportista
        _IndFacturado = li_IndFacturado
        _IndGrtConfirmada = li_IndGrtConfirmada
        _IndDocumentos = li_IndDocumentos
        _IndGrtPerdido = li_IndGrtPerdido
        _Observacion = ls_Observacion
        _activo = lb_Activo
        _TipoVehiculo = ls_TipoVehiculo
        _Consolidado1 = ls_Consolidado1
        _Consolidado2 = ls_Consolidado2
        _Consolidado3 = ls_Consolidado3
        _Consolidado = ls_Consolidado
        _IdVehiculo = ls_IdVehiculo
        _FechaLLegada = ld_FechaLlegada
        _FechaSalida = ld_FechaSalida
        _CentroCosto1 = ls_CentroCosto1
        _CentroCosto2 = ls_CentroCosto2
        _CentroCosto3 = ls_CentroCosto3
    End Sub
#End Region

    Public Function Equals1(ByVal other As e_LiquidacionDetalle) As Boolean Implements System.IEquatable(Of e_LiquidacionDetalle).Equals
        If other.Seleccion = True Then Return True
    End Function
End Class

