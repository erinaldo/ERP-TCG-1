' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TipoActivoFijo_CtaCtble" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TipoActivoFijo_CtaCtble.svc o e_TipoActivoFijo_CtaCtble.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_TipoActivoFijo_CtaCtble
    Implements Ie_TipoActivoFijo_CtaCtble

#Region "Variables"

    Public TipoOperacion As String = String.Empty
    Public IndTipoVehiculo As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedades"

    Public Property Id() As String
    Public Property IdTipoActivoFijo() As String
    Public Property TipoActivoFijo() As String
    Public Property IdCtaCtbleCompraD() As String
    Public Property CtaCtbleCompraD() As String
    Public Property IdCtaCtbleCompraH() As String
    Public Property CtaCtbleCompraH() As String
    Public Property IdCtaCtbleDeprecD() As String
    Public Property CtaCtbleDeprecD() As String
    Public Property IdCtaCtbleDeprecH() As String
    Public Property CtaCtbleDeprecH() As String
    Public Property IdCtaCtbleRevalorizacionD() As String
    Public Property CtaCtbleRevalorizacionD() As String
    Public Property IdCtaCtbleRevalorizacionH() As String
    Public Property CtaCtbleRevalorizacionH() As String
    Public Property IdCtaCtbleReadecuacionD() As String
    Public Property CtaCtbleReadecuacionD() As String
    Public Property IdCtaCtbleReadecuacionH() As String
    Public Property CtaCtbleReadecuacionH() As String
    Public Property Ejercicio() As Integer
    Public Property UsuarioCreacion() As String
    Public Property FechaCreacion() As Date
    Public Property UsuarioModificacion() As String
    Public Property FechaModificacion() As Date
    Public Property Activo() As Boolean
    Public Property IdCtaCtbleBajaD() As String
    Public Property CtaCtbleBajaD() As String
    Public Property IdGastoFuncion() As String
    Public Property IdDetConPond() As String
    Public Property Porcentaje() As Double

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        IndTipoVehiculo = False
        'Propiedades
        Id = String.Empty
        IdTipoActivoFijo = String.Empty
        IdCtaCtbleCompraD = String.Empty
        IdCtaCtbleCompraH = String.Empty
        IdCtaCtbleDeprecD = String.Empty
        IdCtaCtbleDeprecH = String.Empty
        IdCtaCtbleRevalorizacionD = String.Empty
        IdCtaCtbleRevalorizacionH = String.Empty
        IdCtaCtbleReadecuacionD = String.Empty
        IdCtaCtbleReadecuacionH = String.Empty
        Ejercicio = 0
        UsuarioCreacion = String.Empty
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        FechaModificacion = #1/1/1901#
        Activo = True
        TipoActivoFijo = String.Empty
        CtaCtbleCompraD = String.Empty
        CtaCtbleCompraH = String.Empty
        CtaCtbleDeprecD = String.Empty
        CtaCtbleDeprecH = String.Empty
        CtaCtbleRevalorizacionD = String.Empty
        CtaCtbleRevalorizacionH = String.Empty
        CtaCtbleReadecuacionD = String.Empty
        CtaCtbleReadecuacionH = String.Empty
        IdCtaCtbleBajaD = String.Empty
        CtaCtbleBajaD = String.Empty
        IdGastoFuncion = String.Empty
        IdDetConPond = String.Empty
        Porcentaje = 0
    End Sub

#End Region

End Class
