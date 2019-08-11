' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Despacho" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Despacho.svc o e_Despacho.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_Despacho
    Implements Ie_Despacho

#Region "Variables"

    Public TipoOperacion As String
    Public ListDespachoOperaciones As List(Of e_DespachoOperaciones)
    Public FechaHasta As Date
    Public FechaValida As Date
    Public IdZonaEditar As String
#End Region

#Region "Propiedades"

    Public Property Id() As String
    Public Property IdCentro() As String
    Public Property Codigo() As String
    Public Property Fecha() As Date
    Public Property ProdReal() As Double
    Public Property ProdProgramado() As Double
    Public Property ProdTotal() As Double
    Public Property IdEstado() As String
    Public Property Glosa() As String
    Public Property Observacion() As String
    Public Property UsuarioCrea() As String
    Public Property FechaCrea() As Date
    Public Property UsuarioModifica() As String
    Public Property FechaModifica() As Date
    Public Property Activo() As Boolean

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = String.Empty
        Id = String.Empty
        IdCentro = String.Empty
        Codigo = String.Empty
        Fecha = #1/1/1901#
        ProdReal = 0
        ProdProgramado = 0
        ProdTotal = 0
        IdEstado = String.Empty
        Glosa = String.Empty
        Observacion = String.Empty
        UsuarioCrea = String.Empty
        FechaCrea = #1/1/1901#
        UsuarioModifica = String.Empty
        FechaModifica = #1/1/1901#
        Activo = True
        ListDespachoOperaciones = New List(Of e_DespachoOperaciones)
        FechaHasta = #1/1/1901#
        FechaValida = #1/1/1901#
        IdZonaEditar = String.Empty
    End Sub

    Public Sub Dispose()
        TipoOperacion = String.Empty
        Id = String.Empty
        IdCentro = String.Empty
        Codigo = String.Empty
        Fecha = #1/1/1901#
        ProdReal = 0
        ProdProgramado = 0
        ProdTotal = 0
        IdEstado = String.Empty
        Glosa = String.Empty
        Observacion = String.Empty
        UsuarioCrea = String.Empty
        FechaCrea = #1/1/1901#
        UsuarioModifica = String.Empty
        FechaModifica = #1/1/1901#
        Activo = True
        ListDespachoOperaciones = New List(Of e_DespachoOperaciones)
        FechaHasta = #1/1/1901#
        FechaValida = #1/1/1901#
        IdZonaEditar = String.Empty
    End Sub

#End Region
   
End Class
