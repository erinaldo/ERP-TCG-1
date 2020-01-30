' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_GuiaRRVenta_Print" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_GuiaRRVenta_Print.svc o e_GuiaRRVenta_Print.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_GuiaRRVenta_Print
    Implements Ie_GuiaRRVenta_Print

    Public Property Partida() As String
    Public Property LocPartida() As String
    Public Property Destinatario() As String
    Public Property Ruc() As String
    Public Property Dni() As String
    Public Property Lledada() As String
    Public Property LocLlegada() As String
    Public Property Transportista() As String
    Public Property RucTrans() As String
    Public Property Marca() As String
    Public Property Placas() As String
    Public Property FecEmision() As Date
    Public Property FecTraslado() As Date
    Public Property Chofer() As String
    Public Property Brevete() As String
    Public Property MTC() As String
    Public Property DocAsoc() As String
    Public Property Motivo() As String
    Public Property Peso() As Double

    Sub New()
        Partida = String.Empty
        LocPartida = String.Empty
        Destinatario = String.Empty
        Ruc = String.Empty
        Dni = String.Empty
        Lledada = String.Empty
        LocLlegada = String.Empty
        Transportista = String.Empty
        RucTrans = String.Empty
        Marca = String.Empty
        Placas = String.Empty
        FecEmision = Date.Parse("01/01/1901")
        FecTraslado = Date.Parse("01/01/1901")
        Chofer = String.Empty
        Brevete = String.Empty
        MTC = String.Empty
        DocAsoc = String.Empty
        Motivo = String.Empty
        Peso = 0.0
    End Sub


    Public Function obtener(oeDetalleGratificacion As e_GuiaRRVenta_Print) As e_GuiaRRVenta_Print Implements Ie_GuiaRRVenta_Print.obtener
        Return oeDetalleGratificacion
    End Function

End Class
