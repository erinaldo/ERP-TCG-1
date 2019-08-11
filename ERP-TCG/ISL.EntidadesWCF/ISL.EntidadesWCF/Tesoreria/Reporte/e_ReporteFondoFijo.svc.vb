<DataContract()> _
Public Class e_ReporteFondoFijo
    Implements Ie_ReporteFondoFijo

#Region "Declaración de variables"

    Private _N As String
    Private _Referencia As String
    Private _Ingresos As Decimal
    Private _Egresos As Decimal

    Public loFondoFijo As New List(Of e_ReporteFondoFijo)
    Public loFlete As New List(Of e_Movimiento_Flete)
    Public loHabilitacion, loDescuento As New List(Of e_Movimiento_Viaje)
    Public loLiquidacion As New List(Of e_GastoOperacion)
    Public loGrupoLiquidacion, loGrupoDescuento, loGrupoCajaChica, loGrupoFlete As New List(Of e_Grupo)
    Public loCajasExternas As New List(Of e_GastoOperacion)
    Public loGastoCajaChica As New List(Of e_Movimiento_Administrativo)
    Public loPrestamosCuenta As New List(Of e_PrestamosCuenta)
    Public loValesRendir As New List(Of e_ValesRendir)
    Public loOtrosIngresos As New List(Of e_OtrosIngresos)

    Public FechaDesde As String
    Public FechaHasta As String

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Egresos() As Decimal
        Get
            Return _Egresos
        End Get
        Set(ByVal value As Decimal)
            _Egresos = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ingresos() As Decimal
        Get
            Return _Ingresos
        End Get
        Set(ByVal value As Decimal)
            _Ingresos = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _Referencia
        End Get
        Set(ByVal value As String)
            _Referencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property N() As String
        Get
            Return _N
        End Get
        Set(ByVal value As String)
            _N = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal ls_N As String, ByVal ls_Referencia As String, ByVal ld_Ingresos As Double, ByVal ld_Egresos As Double)

        _N = ls_N
        _Referencia = ls_Referencia
        _Ingresos = ld_Ingresos
        _Egresos = ld_Egresos
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal reporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo Implements Ie_ReporteFondoFijo.Obtener
        Return reporteFondoFijo
    End Function

#End Region

End Class
