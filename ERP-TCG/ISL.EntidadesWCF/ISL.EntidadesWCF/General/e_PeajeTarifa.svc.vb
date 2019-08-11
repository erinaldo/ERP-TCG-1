' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_PeajeTarifa" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_PeajeTarifa.svc o e_PeajeTarifa.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_PeajeTarifa
    Implements Ie_PeajeTarifa

#Region "Propiedades"

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Property Id() As String
    <DataMember()>
    Public Property IdPeaje() As String
    <DataMember()>
    Public Property CantidadEjes() As Integer
    <DataMember()>
    Public Property IdTipoVehiculoTarifa() As String
    <DataMember()>
    Public Property Monto() As Decimal
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
        TipoOperacion = ""
        Id = ""
        IdPeaje = ""
        CantidadEjes = 0
        IdTipoVehiculoTarifa = ""
        Monto = 0D
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub
#End Region

#Region "Destructror"

    Public Sub Dispose()
        TipoOperacion = ""
        Id = ""
        IdPeaje = ""
        CantidadEjes = 0
        IdTipoVehiculoTarifa = ""
        Monto = 0D
        Glosa = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

End Class
