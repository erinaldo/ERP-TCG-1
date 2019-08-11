' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_VehiculoTarjeta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_VehiculoTarjeta.svc o e_VehiculoTarjeta.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_VehiculoTarjeta
    Implements Ie_VehiculoTarjeta

#Region "Propiedades"

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdVehiculo() As String
    <DataMember()>
    Public Property Placa() As String
    <DataMember()>
    Public Property IdEmpresaPropietaria() As String
    <DataMember()>
    Public Property EmpresaPropietaria() As String
    <DataMember()>
    Public Property NroTarjeta() As String
    <DataMember()>
    Public Property FechaInicial() As Date
    <DataMember()>
    Public Property FechaFinal() As Date
    <DataMember()>
    Public Property Glosa() As String
    <DataMember()>
    Public Property Actual() As Boolean
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
        IdVehiculo = ""
        Placa = ""
        IdEmpresaPropietaria = ""
        EmpresaPropietaria = ""
        NroTarjeta = ""
        FechaInicial = #1/1/1901#
        FechaFinal = #1/1/1901#
        Glosa = ""
        Actual = False
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
        IdVehiculo = ""
        Placa = ""
        IdEmpresaPropietaria = ""
        EmpresaPropietaria = ""
        NroTarjeta = ""
        FechaInicial = #1/1/1901#
        FechaFinal = #1/1/1901#
        Glosa = ""
        Actual = False
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

End Class
