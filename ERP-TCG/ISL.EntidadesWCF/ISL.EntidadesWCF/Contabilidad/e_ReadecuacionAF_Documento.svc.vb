' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ReadecuacionAF_Documento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ReadecuacionAF_Documento.svc o e_ReadecuacionAF_Documento.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ReadecuacionAF_Documento
    Implements Ie_ReadecuacionAF_Documento

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
    Public Property IdReadecuacionActivoFijo() As String
    Public Property IdDocumento() As String
    Public Property IdTipoDocumento() As String
    Public Property TipoDocumento() As String
    Public Property Serie() As String
    Public Property Numero() As String
    Public Property Valor() As Double
    Public Property Glosa() As String
    Public Property UsuarioCreacion() As String
    Public Property FechaCreacion() As Date
    Public Property UsuarioModificacion() As String
    Public Property FechaModificacion() As Date
    Public Property Activo() As Boolean
    Public Property IndTipoDoc() As Integer

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        'Propiedades
        Id = String.Empty
        IdReadecuacionActivoFijo = String.Empty
        IdDocumento = String.Empty
        Glosa = String.Empty
        UsuarioCreacion = String.Empty
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        FechaModificacion = #1/1/1901#
        Activo = True
        IdTipoDocumento = String.Empty
        TipoDocumento = String.Empty
        Serie = String.Empty
        Numero = String.Empty
        Valor = 0.0
        IndTipoDoc = 0
    End Sub

#End Region

End Class

