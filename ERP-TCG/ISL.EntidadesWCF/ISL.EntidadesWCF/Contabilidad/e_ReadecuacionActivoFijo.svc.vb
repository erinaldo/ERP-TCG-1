<DataContract()> _
Public Class e_ReadecuacionActivoFijo
    Implements Ie_ReadecuacionActivoFijo

#Region "Variables"

    Public TipoOperacion As String = String.Empty
    Public ListReadecuacionAFDoc As List(Of e_ReadecuacionAF_Documento)
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
    Public Property FechaReadecuacion() As Date
    Public Property MontoInvertido() As Double
    Public Property MontoAgregar() As Double
    Public Property VidaUtilAgregar() As Double
    Public Property Observacion() As String
    Public Property Actual() As Integer
    Public Property Activo() As Boolean
    Public Property FechaCreacion() As Date
    Public Property UsuarioCreacion() As String
    Public Property FechaModificacion() As Date
    Public Property UsuarioModificacion() As String

    Public Property Periodo() As String
    Public Property ValorResidualAgregar() As Double
#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        ListReadecuacionAFDoc = New List(Of e_ReadecuacionAF_Documento)
        'Propiedades
        Id = String.Empty
        IdActivoFijo = String.Empty
        IdPeriodo = String.Empty
        FechaReadecuacion = #1/1/1901#
        MontoInvertido = 0
        MontoAgregar = 0
        VidaUtilAgregar = 0
        Observacion = String.Empty
        Actual = 0
        Activo = True
        FechaCreacion = #1/1/1901#
        UsuarioCreacion = String.Empty
        FechaModificacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        Periodo = String.Empty
        ValorResidualAgregar = 0
    End Sub

#End Region

End Class
