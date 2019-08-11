

<DataContract()> _
Public Class e_ObligacionAyudaDetalle
    Implements Ie_ObligacionAyudaDetalle
    Implements IEquatable(Of e_ObligacionAyudaDetalle)

#Region "Declaración de variables"

    Private ls_NroContrato As String ' Nro de contrato bancario
    Private ln_MontoCapital As Double ' Amortizacion de capital
    Private ls_NroVencimiento As String ' Nro Cuota
    Private ld_FechaVencimiento As Date
    Private ln_TasaInteres As Double ' % de interes anual
    Private ln_MontoInteres As Double
    Private ln_Comision As Double
    Private ln_Gastos As Double
    Private ln_Portes As Double
    Private ln_MontoCuota As Double
    Private ln_IGV As Double
    Private ln_Total As Double

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property NroContrato() As String
        Get
            Return ls_NroContrato
        End Get
        Set(ByVal value As String)
            ls_NroContrato = value
        End Set
    End Property

    <DataMember()> _
    Public Property TasaInteres() As Double
        Get
            Return ln_TasaInteres
        End Get
        Set(ByVal value As Double)
            ln_TasaInteres = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroVencimiento() As String
        Get
            Return ls_NroVencimiento
        End Get
        Set(ByVal value As String)
            ls_NroVencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return ld_FechaVencimiento
        End Get
        Set(ByVal value As Date)
            ld_FechaVencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCapital() As Double
        Get
            Return ln_MontoCapital
        End Get
        Set(ByVal value As Double)
            ln_MontoCapital = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteres() As Double
        Get
            Return ln_MontoInteres
        End Get
        Set(ByVal value As Double)
            ln_MontoInteres = value
        End Set
    End Property

    <DataMember()> _
        Public Property MontoCuota() As Double
        Get
            Return ln_MontoCapital + ln_MontoInteres + ln_Portes
        End Get
        Set(ByVal value As Double)
            ln_MontoCuota = value
        End Set
    End Property


    <DataMember()> _
    Public Property Comision() As Double
        Get
            Return ln_Comision
        End Get
        Set(ByVal value As Double)
            ln_Comision = value
        End Set
    End Property

    <DataMember()> _
    Public Property Portes() As Double
        Get
            Return ln_Portes
        End Get
        Set(ByVal value As Double)
            ln_Portes = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gastos() As Double
        Get
            Return ln_Gastos
        End Get
        Set(ByVal value As Double)
            ln_Gastos = value
        End Set
    End Property

    <DataMember()> _
    Public Property IGV() As Double
        Get
            Return ln_IGV
        End Get
        Set(ByVal value As Double)
            ln_IGV = value
        End Set
    End Property


    <DataMember()> _
    Public Property Total() As Double
        Get
            Return ln_Total
        End Get
        Set(ByVal value As Double)
            ln_Total = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal lsCodBanco As String, ByVal ln_Mon As Double, ByVal ld_FecVenc As Date)
        ls_NroContrato = lsCodBanco
        ln_MontoCapital = ln_Mon
        ld_FechaVencimiento = ld_FecVenc
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals2(ByVal other As e_ObligacionAyudaDetalle) As Boolean Implements System.IEquatable(Of e_ObligacionAyudaDetalle).Equals
        If Me.NroContrato = other.NroContrato And Me.MontoCapital = other.MontoCapital And Me.FechaVencimiento = other.FechaVencimiento Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal factoryFEED As e_ObligacionAyudaDetalle) As e_ObligacionAyudaDetalle Implements Ie_ObligacionAyudaDetalle.Obtener
        Return factoryFEED
    End Function

#End Region

End Class



