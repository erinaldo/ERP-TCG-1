' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Peaje" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Peaje.svc o e_Peaje.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Peaje
    Implements Ie_Peaje

#Region "Propiedades"
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property Codigo() As String
    <DataMember()>
    Public Property Nombre() As String
    <DataMember()>
    Public Property Ubicacion() As String
    <DataMember()>
    Public Property IdEmpresa() As String
    <DataMember()>
    Public Property Empresa() As String
    <DataMember()>
    Public Property IdLugar() As String
    <DataMember()>
    Public Property Lugar() As String
    <DataMember()>
    Public Property IndPagoIda() As Boolean
    <DataMember()>
    Public Property IndPagoRetorno() As Boolean
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
    <DataMember()>
    Public ListaTarifa As List(Of e_PeajeTarifa)
     
#End Region

#Region "Constructor"

    Sub New()
        TipoOperacion = ""
        Id = ""
        Codigo = ""
        Nombre = ""
        Ubicacion = ""
        IdEmpresa = ""
        Empresa = ""
        IdLugar = ""
        Lugar = ""
        IndPagoIda = False
        IndPagoRetorno = False
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
        ListaTarifa = New List(Of e_PeajeTarifa)
    End Sub

#End Region

#Region "Destructor"

    Public Sub Dispose()
        TipoOperacion = ""
        Id = ""
        Codigo = ""
        Nombre = ""
        Ubicacion = ""
        IdEmpresa = ""
        Empresa = ""
        IdLugar = ""
        Lugar = ""
        IndPagoIda = False
        IndPagoRetorno = False
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
        ListaTarifa = New List(Of e_PeajeTarifa)
    End Sub

#End Region

End Class
