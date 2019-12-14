' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ReferenciaAsociada" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ReferenciaAsociada.svc o e_ReferenciaAsociada.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ReferenciaAsociada
    Implements Ie_ReferenciaAsociada

    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdEmpresaSis() As String
    <DataMember()>
    Public Property IdSucursal() As String
    <DataMember()>
    Public Property IdTablaPrincipal() As String
    <DataMember()>
    Public Property IdTablaAsociada() As String
    <DataMember()>
    Public Property TipoRelacion() As Integer
    <DataMember()>
    Public Property Glosa() As String


    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public TipoOperacion As String = ""
    <DataMember()>
    Public UsuarioCreacion As String = ""

    Sub New()
        Id = String.Empty
        IdEmpresaSis = String.Empty
        IdSucursal = String.Empty
        IdTablaPrincipal = String.Empty
        IdTablaAsociada = String.Empty
        TipoRelacion = 0
        Glosa = ""
        UsuarioCreacion = String.Empty
    End Sub

    Public Function Obtener(ByVal referencia As e_ReferenciaAsociada) As e_ReferenciaAsociada Implements Ie_ReferenciaAsociada.Obtener
        Return referencia
    End Function

End Class
