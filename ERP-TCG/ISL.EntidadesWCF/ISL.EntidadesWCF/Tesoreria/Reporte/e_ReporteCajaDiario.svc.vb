<DataContract()> _
Public Class e_ReporteCajaDiario
    Implements Ie_ReporteCajaDiario

#Region "Declaracion de Variables"

    Private _codigo As String
    Private _trabajador As String
    Private _fechamov As Date
    Private _voucher As String
    Private _fecha As String
    Private _glosa As String
    Private _ingresos As Double
    Private _egresos As Double

    Private _usuario As String

    Public FechaInicio As Date
    Public FechaFin As Date
    Public IdCaja As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaMov() As Date
        Get
            Return _fechamov
        End Get
        Set(ByVal value As Date)
            _fechamov = value
        End Set
    End Property

    <DataMember()> _
    Public Property Voucher() As String
        Get
            Return _voucher
        End Get
        Set(ByVal value As String)
            _voucher = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ingresos() As Double
        Get
            Return _ingresos
        End Get
        Set(ByVal value As Double)
            _ingresos = value
        End Set
    End Property

    <DataMember()>
    Public Property Egresos() As Double
        Get
            Return _egresos
        End Get
        Set(ByVal value As Double)
            _egresos = value
        End Set
    End Property

    <DataMember()>
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()

        _codigo = ""
        _trabajador = ""
        _fechamov = #1/1/1901#
        _voucher = ""
        _fecha = #1/1/1901#
        _glosa = ""
        _ingresos = 0
        _egresos = 0
        _usuario = ""
    End Sub

    Public Sub New(ByVal ls_Codigo As String,
                   ByVal ls_Trabajador As String,
                   ByVal ld_FechaMov As Date,
                   ByVal ls_Voucher As String,
                   ByVal ld_Fecha As Date,
                   ByVal ls_Glosa As String,
                   ByVal ln_Ingresos As Double,
                   ByVal ln_Egresos As Double,
                   ByVal ls_Usuario As String)

        _codigo = ls_Codigo
        _trabajador = ls_Trabajador
        _fechamov = ld_FechaMov
        _voucher = ls_Voucher
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _ingresos = ln_Ingresos
        _egresos = ln_Egresos
        _usuario = ls_Usuario
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal reporteCajaDiario As e_ReporteCajaDiario) As e_ReporteCajaDiario Implements Ie_ReporteCajaDiario.Obtener
        Return reporteCajaDiario
    End Function

#End Region

End Class
