<DataContract()> _
Public Class e_ReporteDescTrabajador
    Implements Ie_ReporteDescTrabajador

#Region "Declaracion de Variables"

    Private _adelanto As Double
    Private _sancion As Double
    Private _total As Double
    Private _estado As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Anio As String
    <DataMember()> _
    Public Mes As String
    <DataMember()> _
    Public Indicador As String
    <DataMember()> _
    Public oeTrabajador As New e_Trabajador

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Adelanto() As Double
        Get
            Return _adelanto
        End Get
        Set(ByVal value As Double)
            _adelanto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Sancion() As Double
        Get
            Return _sancion
        End Get
        Set(ByVal value As Double)
            _sancion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal ls_IdTrabajador As String, _
                   ByVal ls_Dni As String, _
                   ByVal ls_NombreCompleto As String, _
                   ByVal lb_Activo As Boolean, _
                   ByVal ld_Adelanto As Double, _
                   ByVal ld_Sancion As Double)

        oeTrabajador.Id = ls_IdTrabajador
        oeTrabajador.oePersona.Dni = ls_Dni
        oeTrabajador.oePersona.Nombre = ls_NombreCompleto
        oeTrabajador.Activo = lb_Activo

        _adelanto = ld_Adelanto
        _sancion = ld_Sancion
        _total = ld_Adelanto + ld_Sancion

    End Sub

#End Region

    Public Function Obtener(ByVal reportedectrabajador As e_ReporteDescTrabajador) As e_ReporteDescTrabajador Implements Ie_ReporteDescTrabajador.Obtener
        Return reportedectrabajador
    End Function

End Class
