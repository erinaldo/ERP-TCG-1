' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_GuiaRemisionRemitente_Detalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_GuiaRemisionRemitente_Detalle.svc o e_GuiaRemisionRemitente_Detalle.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_GuiaRemisionRemitente_Detalle
    Implements Ie_GuiaRemisionRemitente_Detalle

    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdEmpresaSis() As String
    <DataMember()>
    Public Property IdSucursal() As String
    <DataMember()>
    Public Property IdGRR_Venta() As String
    <DataMember()>
    Public Property IdUnidadMedida() As String
    <DataMember()>
    Public Property IdMaterial() As String
    <DataMember()>
    Public Property CodigoMaterial() As String
    <DataMember()>
    Public Property Material() As String
    <DataMember()>
    Public Property Cantidad() As Decimal
    <DataMember()>
    Public Property Peso() As Decimal
    <DataMember()>
    Public Property PesoTotal() As Decimal
    <DataMember()>
    Public Property UsuarioCrea() As String

    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public TipoOperacion As String = ""

    Sub New()
        Id = String.Empty
        IdEmpresaSis = String.Empty
        IdSucursal = String.Empty
        IdGRR_Venta = String.Empty
        IdUnidadMedida = String.Empty
        IdMaterial = String.Empty
        CodigoMaterial = String.Empty
        Material = String.Empty
        Cantidad = 0
        Peso = 0
        PesoTotal = 0
        UsuarioCrea = String.Empty
    End Sub


    Public Function Obtener(ByVal guiaRemitente As Ie_GuiaRemisionRemitente_Detalle) As Ie_GuiaRemisionRemitente_Detalle Implements Ie_GuiaRemisionRemitente_Detalle.Obtener
        Return guiaRemitente
    End Function

End Class
