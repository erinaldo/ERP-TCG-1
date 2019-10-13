' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ActivoFijo_CuentaContable" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ActivoFijo_CuentaContable.svc o e_ActivoFijo_CuentaContable.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_ActivoFijo_CuentaContable
    Implements Ie_ActivoFijo_CuentaContable

#Region "Variables"

    Public TipoOperacion As String = String.Empty
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Propiedades"

    Public Property Id() As String
    Public Property IdActivoFijo() As String
    Public Property IdPeriodo() As String
    Public Property Descripcion() As String
    Public Property IndInformacionContable() As Integer
    Public Property FechaAdquiere() As Date
    Public Property IndFecActivacion() As Integer
    Public Property FechaActivacion() As Date
    Public Property IdCtaCtbleCompra() As String
    Public Property IdCtaCtbleRevalorizacion() As String
    Public Property IdCtaCtbeDepreciacion() As String
    Public Property IdCtaCtbleReadeacuacion() As String
    Public Property ValorResidual() As Double
    Public Property DepreciacionAcumulada() As Double
    Public Property TipoAdquisicion() As Integer
    Public Property Actual() As Integer
    Public Property IdEmpFinancia() As String
    Public Property Observacion() As String
    Public Property Activo() As Boolean
    Public Property UsuarioCreacion() As String
    Public Property FechaCreacion() As Date
    Public Property UsuarioModificacion() As String
    Public Property FechaModificacion() As Date
    Public Property NroLeasing() As String
    Public Property ValorCuota() As Double
    Public Property FechaVencimiento() As Date
    Public Property Ejercicio() As Integer
    Public Property IdTipoActivo() As String
    Public Property TipoActivo() As String
    Public Property IdMetodoDepreciacion() As String
    Public Property NroAutorizacion() As String
    Public Property IdReadecuacion() As String

    Public Property Periodo() As String
    Public Property CtaCtbleCompra() As String
    Public Property CtaCtbleRevalorizacion() As String
    Public Property CtaCtbeDepreciacion() As String
    Public Property CtaCtbleReadeacuacion() As String
    Public Property CtaCtbleCompraH() As String
    Public Property CtaCtbleRevalorizacionH() As String
    Public Property CtaCtbeDepreciacionH() As String
    Public Property CtaCtbleReadeacuacionH() As String
    Public Property CtaCtbleDesactivacionD() As String
    Public Property GastoFuncion() As String
    Public Property IndReadecuacion() As Boolean

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        'Propiedades
        Id = String.Empty
        IdActivoFijo = String.Empty
        IdPeriodo = String.Empty
        Descripcion = String.Empty
        IndInformacionContable = 0
        FechaAdquiere = #1/1/1901#
        IndFecActivacion = 0
        FechaActivacion = #1/1/1901#
        IdCtaCtbleCompra = String.Empty
        IdCtaCtbleRevalorizacion = String.Empty
        IdCtaCtbeDepreciacion = String.Empty
        IdCtaCtbleReadeacuacion = String.Empty
        ValorResidual = 0
        DepreciacionAcumulada = 0
        TipoAdquisicion = 0
        Actual = 0
        IdEmpFinancia = String.Empty
        Observacion = String.Empty
        Activo = True
        UsuarioCreacion = String.Empty
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        FechaModificacion = #1/1/1901#
        NroLeasing = String.Empty
        ValorCuota = 0
        FechaVencimiento = #1/1/1901#
        Periodo = String.Empty
        CtaCtbleCompra = String.Empty
        CtaCtbleRevalorizacion = String.Empty
        CtaCtbeDepreciacion = String.Empty
        CtaCtbleReadeacuacion = String.Empty
        Ejercicio = 0
        IdTipoActivo = String.Empty
        TipoActivo = String.Empty
        CtaCtbleCompraH = String.Empty
        CtaCtbleRevalorizacionH = String.Empty
        CtaCtbeDepreciacionH = String.Empty
        CtaCtbleReadeacuacionH = String.Empty
        CtaCtbleDesactivacionD = String.Empty
        GastoFuncion = String.Empty
    End Sub

#End Region

End Class
