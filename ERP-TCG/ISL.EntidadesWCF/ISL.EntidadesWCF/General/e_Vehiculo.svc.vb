''' <summary>
''' Clase para definir la entidad: Vehículo
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Vehiculo
    Implements Ie_Vehiculo
    Implements ICloneable

#Region "Variables"

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public TipoActualizacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public UsuarioCreacion As String
    ''' <summary>
    ''' Varibles de busqueda en la consulta del listar
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public _Periodo As String
    <DataMember()> _
    Public _IndCompraVenta As Integer
    'Listas
    <DataMember()> _
    Public ListDocumentoVehicular As New List(Of e_DocumentoVehicular)
    <DataMember()> _
    Public ListHistorialPlaca As New List(Of e_Placa)
    <DataMember()> _
    Public ListDispositivo As New List(Of e_Dispositivo)
    <DataMember()> _
    Public ListBonificacion As New List(Of e_Bonificacion)
    <DataMember()> _
    Public ListAsignacionFlota As New List(Of e_AsignacionFlota)
    <DataMember()> _
    Public ListVehiculoEstados As New List(Of e_VehiculoEstado)
    <DataMember()> _
    Public ListVehiculoTarjeta As New List(Of e_VehiculoTarjeta)

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
    <DataMember()> _
    Public Property Codigo() As String
    <DataMember()> _
    Public Property Placa() As String
    <DataMember()> _
    Public Property Motriz() As Integer
    <DataMember()> _
    Public Property IdTipoVehiculo() As String
    <DataMember()> _
    Public Property TipoVehiculo() As String
    <DataMember()> _
    Public Property IdModeloFuncional() As String
    <DataMember()> _
    Public Property ModeloFuncional() As String
    <DataMember()> _
    Public Property IdMarca() As String
    <DataMember()> _
    Public Property Marca() As String
    <DataMember()> _
    Public Property IdModelo() As String
    <DataMember()> _
    Public Property Modelo() As String
    <DataMember()> _
    Public Property IdEmpresaPropietaria() As String
    <DataMember()> _
    Public Property EmpresaPropietaria() As String
    <DataMember()> _
    Public Property IdFlota() As String
    <DataMember()> _
    Public Property Activo() As Boolean
    <DataMember()> _
    Public Property Observacion() As String
    <DataMember()> _
    Public Property Odometro() As Double
    <DataMember()> _
    Public Property Horometro() As Double
    <DataMember()> _
    Public Property IdConfiguracionVehicularMTC() As String
    <DataMember()> _
    Public Property IdConfiguracionNeumaticos() As String
    <DataMember()> _
    Public Property ConfiguracionNeumaticos() As String
    <DataMember()> _
    Public Property Capacidad() As Double
    <DataMember()> _
    Public Property AnioFabricacion() As Integer
    <DataMember()> _
    Public Property NroSerieChasis() As String
    <DataMember()> _
    Public Property NroSerieMotor() As String
    <DataMember()> _
    Public Property Tara() As Double
    <DataMember()> _
    Public Property Largo() As Double
    <DataMember()> _
    Public Property Ancho() As Double
    <DataMember()> _
    Public Property Alto() As Double
    <DataMember()> _
    Public Property Color() As String
    <DataMember()> _
    Public Property NroEjes() As Integer
    <DataMember()> _
    Public Property NroNeumaticos() As Integer
    <DataMember()> _
    Public Property Cubicaje() As Double
    <DataMember()> _
    Public Property NroNeumaticosRepuesto() As Integer
    <DataMember()> _
    Public Property NroMTC() As String
    <DataMember()> _
   Public Property IdMaterialCombustible() As String
    'Combustible
    <DataMember()> _
    Public Property Seleccion() As Boolean
    <DataMember()> _
    Public Property CapacidadTanque() As Double
    <DataMember()> _
    Public Property IndEstado() As Integer
    <DataMember()> _
    Public Property PlacaAntigua() As String
    <DataMember()> _
    Public Property Fecha() As Date
    <DataMember()> _
    Public Property IndProrrateo() As Boolean
    <DataMember()> _
    Public Property IndPropiedad() As Integer
    <DataMember()> _
    Public Property IndActivoFijo() As Integer
    <DataMember()> _
    Public Property PesoNeto() As Double
    <DataMember()> _
    Public Property NroAsientos() As Integer
    <DataMember()> _
    Public Property NroPasajeros() As Integer
    <DataMember()> _
    Public Property NroEquipoMovil() As String
    <DataMember()> _
    Public Property DescripcionDetalle() As String
    <DataMember()> _
    Public Property Foto() As Byte()
    <DataMember()> _
    Public Property AnioModelo() As Integer
    <DataMember()> _
    Public Property IdModeloSunarp() As String
    <DataMember()> _
    Public Property IdTipoCarroceriaSunarp() As String
    <DataMember()> _
    Public Property TipoNeumatico() As String
    <DataMember()> _
    Public Property SuspensionNeumatica() As String
    <DataMember()> _
    Public Property Bonificacion() As String
    <DataMember()> _
    Public Property TomaFuerza() As String
    <DataMember()> _
    Public Property Modalidad() As String
    <DataMember()> _
    Public Property TarjetaCombustible() As String
    <DataMember()> _
    Public Property IdEmpresaGPS() As String
    <DataMember()> _
    Public Property RutaAsignada() As String
    <DataMember()> _
    Public Property IdClasificacionISL() As String
    <DataMember()> _
    Public Property IdTipoCarroceria() As String
    <DataMember()> _
    Public Property ClasificacionISL() As String
    <DataMember()> _
    Public Property TipoCarroceria() As String
    ''' <summary>
    ''' Variable para almacenar la persona responsable del Vehículo
    ''' </summary>
    <DataMember()> _
    Public Property ConductorAsignada() As String
    <DataMember()> _
    Public Property Monto() As Double

#End Region

#Region "Constructor"

    Sub New()
        'Variables
        TipoOperacion = "A"
        TipoActualizacion = String.Empty
        Modificado = False
        UsuarioCreacion = String.Empty
        _IndCompraVenta = 0
        _Periodo = String.Empty
        'Propiedades
        Id = String.Empty
        Codigo = String.Empty
        Placa = String.Empty
        Motriz = -1
        IdTipoVehiculo = String.Empty
        TipoVehiculo = String.Empty
        IdModeloFuncional = String.Empty
        ModeloFuncional = String.Empty
        IdMarca = String.Empty
        Marca = String.Empty
        IdModelo = String.Empty
        Modelo = String.Empty
        IdEmpresaPropietaria = String.Empty
        EmpresaPropietaria = String.Empty
        IdFlota = String.Empty
        Activo = True
        Observacion = String.Empty
        Odometro = 0.0
        Horometro = 0.0
        IdConfiguracionVehicularMTC = String.Empty
        IdConfiguracionNeumaticos = String.Empty
        ConfiguracionNeumaticos = String.Empty
        Capacidad = 0.0
        AnioFabricacion = 0
        NroSerieChasis = String.Empty
        NroSerieMotor = String.Empty
        Tara = 0.0
        Largo = 0.0
        Ancho = 0.0
        Alto = 0.0
        Color = String.Empty
        NroEjes = 0
        NroNeumaticos = 0
        Cubicaje = 0.0
        NroNeumaticosRepuesto = 0
        NroMTC = String.Empty
        IdMaterialCombustible = String.Empty
        Seleccion = False
        CapacidadTanque = 0.0
        IndEstado = 0
        PlacaAntigua = String.Empty
        Fecha = #1/1/1901#
        IndProrrateo = False
        IndPropiedad = 0
        IndActivoFijo = 0
        PesoNeto = 0.0
        NroAsientos = 0
        NroPasajeros = 0
        NroEquipoMovil = String.Empty
        DescripcionDetalle = String.Empty
        Foto = Nothing
        AnioModelo = 0
        IdModeloSunarp = String.Empty
        IdTipoCarroceriaSunarp = String.Empty
        TipoNeumatico = String.Empty
        SuspensionNeumatica = String.Empty
        Bonificacion = String.Empty
        TomaFuerza = String.Empty
        Modalidad = String.Empty
        TarjetaCombustible = String.Empty
        IdEmpresaGPS = String.Empty
        RutaAsignada = String.Empty
        ConductorAsignada = String.Empty
        Monto = 0.0
        IdClasificacionISL = String.Empty
        IdTipoCarroceria = String.Empty
    End Sub

#End Region

#Region "Métodos"

    Public Sub Dispose()
        'Variables
        TipoOperacion = "A"
        TipoActualizacion = String.Empty
        Modificado = False
        UsuarioCreacion = String.Empty
        _IndCompraVenta = 0
        _Periodo = String.Empty
        'Propiedades
        Codigo = String.Empty
        Placa = String.Empty
        Motriz = 0
        IdTipoVehiculo = String.Empty
        TipoVehiculo = String.Empty
        IdModeloFuncional = String.Empty
        ModeloFuncional = String.Empty
        IdMarca = String.Empty
        Marca = String.Empty
        IdModelo = String.Empty
        Modelo = String.Empty
        IdEmpresaPropietaria = String.Empty
        EmpresaPropietaria = String.Empty
        IdFlota = String.Empty
        Activo = True
        Observacion = String.Empty
        Odometro = 0.0
        Horometro = 0.0
        IdConfiguracionVehicularMTC = String.Empty
        IdConfiguracionNeumaticos = String.Empty
        ConfiguracionNeumaticos = String.Empty
        Capacidad = 0.0
        AnioFabricacion = 0
        NroSerieChasis = String.Empty
        NroSerieMotor = String.Empty
        Tara = 0.0
        Largo = 0.0
        Ancho = 0.0
        Alto = 0.0
        Color = String.Empty
        NroEjes = 0
        NroNeumaticos = 0
        Cubicaje = 0.0
        NroNeumaticosRepuesto = 0
        NroMTC = String.Empty
        IdMaterialCombustible = String.Empty
        Seleccion = False
        CapacidadTanque = 0.0
        IndEstado = 0
        PlacaAntigua = String.Empty
        Fecha = #1/1/1901#
        IndProrrateo = False
        IndPropiedad = 0
        IndActivoFijo = 0
        PesoNeto = 0.0
        NroAsientos = 0
        NroPasajeros = 0
        NroEquipoMovil = String.Empty
        DescripcionDetalle = String.Empty
        Foto = Nothing
        AnioModelo = 0
        IdModeloSunarp = String.Empty
        IdTipoCarroceriaSunarp = String.Empty
        TipoNeumatico = String.Empty
        SuspensionNeumatica = String.Empty
        Bonificacion = String.Empty
        TomaFuerza = String.Empty
        Modalidad = String.Empty
        TarjetaCombustible = String.Empty
        IdEmpresaGPS = String.Empty
        RutaAsignada = String.Empty
        ConductorAsignada = String.Empty
        Monto = 0.0
    End Sub

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Function Obtener(vehiculo As e_Vehiculo) As e_Vehiculo Implements Ie_Vehiculo.Obtener
        Return vehiculo
    End Function

    Public Function CapacidadUtil(TaraTracto As Double, TaraCarrreta As Double, Bonificacion As Double) As Double Implements Ie_Vehiculo.CapacidadUtil
        Return Bonificacion - (TaraTracto + TaraCarrreta)
    End Function

#End Region

End Class


