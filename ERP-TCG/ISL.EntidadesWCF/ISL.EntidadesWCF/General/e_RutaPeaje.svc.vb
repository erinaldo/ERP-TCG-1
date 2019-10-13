' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_RutaPeaje" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_RutaPeaje.svc o e_RutaPeaje.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_RutaPeaje
    Implements Ie_RutaPeaje

#Region "Propiedades"
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdRuta() As String
    <DataMember()>
    Public Property IdPeaje() As String
    <DataMember()>
    Public Property Peaje() As String
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
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Constructor"
    Sub New()
        TipoOperacion = ""
        Id = ""
        IdRuta = ""
        IdPeaje = ""
        Peaje = ""
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
        TipoOperacion = ""
        Id = ""
        IdRuta = ""
        IdPeaje = ""
        Peaje = ""
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

End Class
