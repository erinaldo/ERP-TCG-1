' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DespachoOperaciones" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DespachoOperaciones.svc o e_DespachoOperaciones.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_DespachoOperaciones
    Implements Ie_DespachoOperaciones

#Region "Variables"

    Public TipoOperacion As String = String.Empty
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedades"

    Public Property Seleccion() As Boolean

    Public Property Id() As String
    Public Property IdDespacho() As String
    Public Property IdViaje() As String
    Public Property Piloto() As String
    Public Property Copiloto() As String
    Public Property IdTracto() As String
    Public Property Tracto() As String
    Public Property GlosaN() As String
    Public Property Carreta() As String
    Public Property Zona() As String
    Public Property Origen() As String
    Public Property Destino() As String
    Public Property Estado() As String
    Public Property Cliente() As String
    Public Property MaterialCarga() As String
    Public Property Tonelada() As Double
    Public Property MNTO() As String
    Public Property Monto() As Double
    Public Property ClienteGlosa() As String
    Public Property Hora() As Date
    Public Property EstadoGlosa() As String
    Public Property Disponible() As String
    Public Property Ocurrencia() As String
    Public Property Observacion() As String
    Public Property Glosa() As String
    Public Property UsuarioCrea() As String
    Public Property FechaCrea() As Date
    Public Property UsuarioModifica() As String
    Public Property FechaModifica() As Date
    Public Property Activo() As Boolean
    Public Property NroCelular() As String
    Public Property IdMarcaVehiculo() As String
    Public Property TipoVehiculoCarreta() As String
    Public Property NroMTC() As String
    Public Property NroMTCCarreta() As String
    Public Property Brevete() As String
    Public Property IndMantenimiento() As Boolean
    Public Property IdEscala() As String

    'Propiedades del Viaje Programado en el SGI
    Public Property CodigoViajeProg As String
    Public Property IdTractoProg As String
    Public Property IdCarretaProg As String
    Public Property IdPilotoProg As String
    Public Property IdCopilotoProg As String
    Public Property IdOrigenProg As String
    Public Property IdDestinoProg As String
    Public Property ClienteProg As String
    Public Property TotalFleteProg As Double

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = String.Empty
        Seleccion = False
        Id = String.Empty
        IdDespacho = String.Empty
        IdViaje = String.Empty
        Piloto = String.Empty
        Copiloto = String.Empty
        IdTracto = String.Empty
        Tracto = String.Empty
        GlosaN = String.Empty
        Carreta = String.Empty
        Zona = String.Empty
        Origen = String.Empty
        Destino = String.Empty
        Estado = String.Empty
        Cliente = String.Empty
        MaterialCarga = String.Empty
        Tonelada = 0
        MNTO = String.Empty
        Monto = 0
        ClienteGlosa = String.Empty
        Hora = #1/1/1901#
        EstadoGlosa = String.Empty
        Disponible = String.Empty
        Ocurrencia = "0"
        Observacion = "0"
        Glosa = String.Empty
        UsuarioCrea = String.Empty
        FechaCrea = #1/1/1901#
        UsuarioModifica = String.Empty
        FechaModifica = #1/1/1901#
        Activo = True
        NroCelular = String.Empty
        IdMarcaVehiculo = String.Empty
        TipoVehiculoCarreta = String.Empty
        NroMTC = String.Empty
        Brevete = String.Empty
        IndMantenimiento = False
        IdEscala = String.Empty
        NroMTCCarreta = String.Empty
        CodigoViajeProg = String.Empty
        IdTractoProg = String.Empty
        IdCarretaProg = String.Empty
        IdPilotoProg = String.Empty
        IdCopilotoProg = String.Empty
        IdOrigenProg = String.Empty
        IdDestinoProg = String.Empty
        ClienteProg = String.Empty
        TotalFleteProg = 0.0
    End Sub

    Public Sub Dispose()
        TipoOperacion = String.Empty
        Seleccion = False
        Id = String.Empty
        IdDespacho = String.Empty
        IdViaje = String.Empty
        Piloto = String.Empty
        Copiloto = String.Empty
        IdTracto = String.Empty
        Tracto = String.Empty
        GlosaN = String.Empty
        Carreta = String.Empty
        Zona = String.Empty
        Origen = String.Empty
        Destino = String.Empty
        Estado = String.Empty
        Cliente = String.Empty
        MaterialCarga = String.Empty
        Tonelada = 0
        MNTO = String.Empty
        Monto = 0
        ClienteGlosa = String.Empty
        Hora = #1/1/1901#
        EstadoGlosa = String.Empty
        Disponible = String.Empty
        Ocurrencia = "0"
        Observacion = "0"
        Glosa = String.Empty
        UsuarioCrea = String.Empty
        FechaCrea = #1/1/1901#
        UsuarioModifica = String.Empty
        FechaModifica = #1/1/1901#
        Activo = True
        NroCelular = String.Empty
        IdMarcaVehiculo = String.Empty
        TipoVehiculoCarreta = String.Empty
        NroMTC = String.Empty
        Brevete = String.Empty
        IndMantenimiento = False
        IdEscala = String.Empty
        NroMTCCarreta = String.Empty
        CodigoViajeProg = String.Empty
        IdTractoProg = String.Empty
        IdCarretaProg = String.Empty
        IdPilotoProg = String.Empty
        IdCopilotoProg = String.Empty
        IdOrigenProg = String.Empty
        IdDestinoProg = String.Empty
        ClienteProg = String.Empty
        TotalFleteProg = 0.0
    End Sub

#End Region
   
End Class

