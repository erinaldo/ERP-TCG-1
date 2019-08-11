' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_RecargaPeajeDetalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_RecargaPeajeDetalle.svc o e_RecargaPeajeDetalle.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_RecargaPeajeDetalle
    Implements Ie_RecargaPeajeDetalle

#Region "Propiedades"

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdMoneda() As String
    <DataMember()>
    Public Property Moneda() As String
    <DataMember()>
    Public Property IdTipoDocumento() As String
    <DataMember()>
    Public Property TipoDocumento() As String
    <DataMember()>
    Public Property Serie() As String
    <DataMember()>
    Public Property Numero() As String
    <DataMember()>
    Public Property Fecha() As Date
    <DataMember()>
    Public Property FechaHasta() As Date
    <DataMember()>
    Public Property IdEstado() As String
    <DataMember()>
    Public Property Estado() As String
    <DataMember()>
    Public Property IdVehiculoTarjeta() As String
    <DataMember()>
    Public Property Placa() As String
    <DataMember()>
    Public Property NroTarjeta() As String
    <DataMember()>
    Public Property MontoTotal() As Decimal
    <DataMember()>
    Public Property MontoTarjeta() As Decimal
    <DataMember()>
    Public Property Glosa() As String
    <DataMember()>
    Public Property UsuarioCreacion() As String
    <DataMember()>
    Public Property FechaCreacion() As Date
    <DataMember()>
    Public Property UsuarioModificacion() As String
    <DataMember()>
    Public Property FechaModificacion() As Date
    <DataMember()>
    Public Property Activo() As Boolean

#End Region

#Region "Constructor"
    Sub New()
        TipoOperacion = "GEN"
        Id = ""
        IdTipoDocumento = ""
        TipoDocumento = ""
        IdMoneda = ""
        Moneda = ""
        Fecha = #1/1/1901#
        FechaHasta = #1/1/1901#
        Serie = ""
        Numero = ""
        IdEstado = ""
        Estado = ""
        IdVehiculoTarjeta = ""
        Placa = ""
        NroTarjeta = ""
        MontoTotal = 0D
        MontoTarjeta = 0D
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

#Region "Destructor"
    Public Sub Dispose()
        TipoOperacion = "GEN"
        Id = ""
        IdTipoDocumento = ""
        TipoDocumento = ""
        IdMoneda = ""
        Moneda = ""
        Fecha = #1/1/1901#
        FechaHasta = #1/1/1901#
        Serie = ""
        Numero = ""
        IdEstado = ""
        Estado = ""
        IdVehiculoTarjeta = ""
        Placa = ""
        NroTarjeta = ""
        MontoTotal = 0D
        MontoTarjeta = 0D
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

End Class
