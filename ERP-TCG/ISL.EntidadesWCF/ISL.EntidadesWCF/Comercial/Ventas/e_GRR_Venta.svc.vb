' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_GRR_Venta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_GRR_Venta.svc o e_GRR_Venta.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF

Public Class e_GRR_Venta
    Implements Ie_GRR_Venta

    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdEmpresaSis() As String
    <DataMember()>
    Public Property IdSucursal() As String
    <DataMember()>
    Public Property IdTransportista() As String
    <DataMember()>
    Public Property Transportista() As String
    <DataMember()>
    Public Property IdCliente() As String
    <DataMember()>
    Public Property Cliente() As String
    <DataMember()>
    Public Property Fecha() As Date
    <DataMember()>
    Public Property FechaTraslado() As Date
    <DataMember()>
    Public Property IdEstado() As String
    <DataMember()>
    Public Property Estado() As String
    <DataMember()>
    Public Property Serie() As String
    <DataMember()>
    Public Property Numero() As String
    <DataMember()>
    Public Property TotalPeso() As Double
    <DataMember()>
    Public Property IdVehiculo() As String
    <DataMember()>
    Public Property Vehiculo() As String
    <DataMember()>
    Public Property Marca() As String
    <DataMember()>
    Public Property MTCVehiculo() As String
    <DataMember()>
    Public Property IdCarreta() As String
    <DataMember()>
    Public Property Carreta() As String
    '<DataMember()>
    'Public Property MTCCarreta() As String
    <DataMember()>
    Public Property IdChofer() As String
    <DataMember()>
    Public Property Chofer() As String
    <DataMember()>
    Public Property Brevete() As String
    <DataMember()>
    Public Property IdMotivoTraslado() As String
    <DataMember()>
    Public Property MotivoTraslado() As String
    <DataMember()>
    Public Property IdPartida() As String
    <DataMember()>
    Public Property Partida() As String
    <DataMember()>
    Public Property IdDestino() As String
    <DataMember()>
    Public Property Destino() As String
    <DataMember()>
    Public Property UsuarioCrea() As String

    <DataMember()>
    Public lo_GRRVenta_Detalle As List(Of e_GuiaRemisionRemitente_Detalle)
    <DataMember()>
    Public oeReferenciaAsoc As New e_ReferenciaAsociada
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public TipoOperacion As String = ""
    <DataMember()>
    Public IdViaje As String = ""

    Public Sub New()
        Id = String.Empty
        IdEmpresaSis = String.Empty
        IdSucursal = String.Empty
        IdTransportista = String.Empty
        Transportista = String.Empty
        IdCliente = String.Empty
        Cliente = String.Empty
        Fecha = Date.Parse("01/01/1901")
        FechaTraslado = Date.Parse("01/01/1901")
        IdEstado = String.Empty
        Estado = String.Empty
        Serie = String.Empty
        Numero = String.Empty
        TotalPeso = 0
        IdVehiculo = String.Empty
        Vehiculo = String.Empty
        Marca = String.Empty
        MTCVehiculo = String.Empty
        IdCarreta = String.Empty
        Carreta = String.Empty
        IdChofer = String.Empty
        Chofer = String.Empty
        Brevete = String.Empty
        IdMotivoTraslado = String.Empty
        MotivoTraslado = String.Empty
        IdPartida = String.Empty
        Partida = String.Empty
        IdDestino = String.Empty
        Destino = String.Empty
        UsuarioCrea = String.Empty
    End Sub

    Public Function Obtener(ByVal guiaRemitente As e_GRR_Venta) As e_GRR_Venta Implements Ie_GRR_Venta.Obtener
        Return guiaRemitente
    End Function

    Public Sub DoWork() Implements Ie_GRR_Venta.DoWork
        Throw New NotImplementedException()
    End Sub
End Class
