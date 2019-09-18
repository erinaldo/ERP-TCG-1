' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Flota_Trabajador" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Flota_Trabajador.svc o e_Flota_Trabajador.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Flota_Trabajador
    Implements Ie_Flota_Trabajador

#Region "Variables"

    Public TipoOperacion As String = String.Empty
    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Propiedades"

    Public Property Id() As String
    Public Property IdTrabajador() As String
    Public Property IdFlota() As String
    Public Property Glosa() As String
    Public Property FechaInicio() As Date
    Public Property FechaFin() As Date
    Public Property Actual() As Boolean
    Public Property UsuarioCreacion() As String
    Public Property FechaCreacion() As Date
    Public Property UsuarioModificacion() As String
    Public Property FechaModificacion() As Date
    Public Property Activo() As Boolean

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        'Propiedades
        Id = String.Empty
        IdTrabajador = String.Empty
        IdFlota = String.Empty
        Glosa = String.Empty
        FechaInicio = #1/1/1901#
        FechaFin = #1/1/1901#
        Actual = False
        UsuarioCreacion = String.Empty
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

#Region "Metodos"

    Public Sub Dispose()
        'Variables
        TipoOperacion = String.Empty
        'Propiedades
        Id = String.Empty
        IdTrabajador = String.Empty
        IdFlota = String.Empty
        Glosa = String.Empty
        FechaInicio = #1/1/1901#
        FechaFin = #1/1/1901#
        Actual = False
        UsuarioCreacion = String.Empty
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        FechaModificacion = #1/1/1901#
        Activo = True
    End Sub

#End Region

End Class
