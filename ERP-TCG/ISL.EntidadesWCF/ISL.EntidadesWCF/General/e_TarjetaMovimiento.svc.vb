' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TarjetaMovimiento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TarjetaMovimiento.svc o e_TarjetaMovimiento.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_TarjetaMovimiento
    Implements Ie_TarjetaMovimiento

#Region "Propiedades"

    Public Property Seleccion() As Boolean
    Public TipoOperacion As String
    Public Property Id() As String
    Public Property NroTarjeta() As String
    Public Property Ticket() As String
    Public Property Fecha() As Date
    Public Property FechaHasta() As Date
    Public Property Monto() As Decimal
    Public Property Valor() As Decimal
    Public Property Tipo() As String
    Public Property Lugar() As String
    Public Property Placa() As String
    Public Property IndGuardado() As Boolean
    Public Property IdGastoOperacion() As String
    Public Property UsuarioCreacion() As String
    Public Property FechaCreacion() As Date
    Public Property UsuarioModificacion() As String
    Public Property FechaModificacion() As Date
    Public Property Activo() As Boolean

    Public Property IndIngresado() As Boolean
    Public Property IdLugar() As String
    Public Property NombreLugar() As String

    Public Property PlacaISL As String

#End Region

#Region "Constructor"

    Sub New()
        Seleccion = False
        TipoOperacion = ""
        Id = ""
        NroTarjeta = ""
        Ticket = ""
        Fecha = #1/1/1901#
        FechaHasta = #1/1/1901#
        Monto = 0D
        Tipo = ""
        Lugar = ""
        Placa = ""
        IndIngresado = False
        IdGastoOperacion = ""
        IndGuardado = False
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
        IdLugar = ""
        NombreLugar = ""

        PlacaISL = ""
    End Sub

#End Region

#Region "Destructor"

    Public Sub Dispose()
        Seleccion = False
        TipoOperacion = ""
        Id = ""
        NroTarjeta = ""
        Ticket = ""
        Fecha = #1/1/1901#
        FechaHasta = #1/1/1901#
        Monto = 0D
        Tipo = ""
        Lugar = ""
        Placa = ""
        IndIngresado = False
        IdGastoOperacion = ""
        IndGuardado = False
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = ""
        FechaModificacion = #1/1/1901#
        Activo = True
        IdLugar = ""
        NombreLugar = ""

        PlacaISL = ""
    End Sub

#End Region

End Class
