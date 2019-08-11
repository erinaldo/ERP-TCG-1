' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DepreciacionActivoFijo" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DepreciacionActivoFijo.svc o e_DepreciacionActivoFijo.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_DepreciacionActivoFijo
    Implements Ie_DepreciacionActivoFijo

#Region "Variables"

    Public TipoOperacion As String = String.Empty
    Public TipoCambio As Double = 0.0
    Public IdTipoActivoFijo As String = String.Empty
    Public TipoActivoFijo As String = String.Empty

    Public IndTipoVehiculo As Boolean = False
    Public IdCentroCosto As String = String.Empty
    Public IdGastoFuncion As String = String.Empty
#End Region

#Region "Propiedades"

    Public Property Id() As String
    Public Property IdActivoFijo() As String
    Public Property IdPeriodo() As String
    Public Property IdAFCuentaContable() As String
    Public Property IdCuentaOrigen() As String
    Public Property IdCuentaDestino() As String
    Public Property Valor() As Double
    Public Property Importe() As Double
    Public Property Observacion() As String
    Public Property Actual() As Integer
    Public Property FechaCreacion() As Date
    Public Property UsuarioCreacion() As String
    Public Property Activo() As Boolean
    Public Property IdAsiento() As String
    Public Property Periodo() As String

    


#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        TipoCambio = 0.0
        IdTipoActivoFijo = String.Empty
        TipoActivoFijo = String.Empty
        IndTipoVehiculo = False
        IdCentroCosto = String.Empty
        'Propiedades
        Id = String.Empty
        IdActivoFijo = String.Empty
        IdPeriodo = String.Empty
        IdAFCuentaContable = String.Empty
        IdCuentaOrigen = String.Empty
        IdCuentaDestino = String.Empty
        Valor = 0.0
        Importe = 0.0
        Observacion = String.Empty
        Actual = 0
        FechaCreacion = #1/1/1901#
        UsuarioCreacion = String.Empty
        Activo = True
        IdAsiento = String.Empty
        Periodo = String.Empty
    End Sub

#End Region


End Class
