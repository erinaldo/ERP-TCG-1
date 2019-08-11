

<DataContract()> _
Public Class e_ReporteClienteMensual
    Implements Ie_ReporteClienteMensual

#Region "Declaracion de Variables"

    Private _idtipodoc As String
    Private _tipodoc As String
    Private _idcliente As String
    Private _nrodoc As String
    Private _cliente As String
    Private _mes As String
    Private _total As Double
    Private _porctotal As Double
    Private _acumulado As Double
    Private _porcacumulado As Double
    Private _indpareto As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Anio As String


#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdTipoDoc() As String
        Get
            Return _idtipodoc
        End Get
        Set(ByVal value As String)
            _idtipodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDoc() As String
        Get
            Return _tipodoc
        End Get
        Set(ByVal value As String)
            _tipodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDoc() As String
        Get
            Return _nrodoc
        End Get
        Set(ByVal value As String)
            _nrodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
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

    <DataMember()> _
    Public Property PorcTotal() As Double
        Get
            Return _porctotal
        End Get
        Set(ByVal value As Double)
            _porctotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property Acumulado() As Double
        Get
            Return _acumulado
        End Get
        Set(ByVal value As Double)
            _acumulado = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcAcumulado() As Double
        Get
            Return _porcacumulado
        End Get
        Set(ByVal value As Double)
            _porcacumulado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPareto() As Integer
        Get
            Return _indpareto
        End Get
        Set(ByVal value As Integer)
            _indpareto = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        TipoOperacion = String.Empty
        Anio = String.Empty
        _mes = String.Empty
        _indpareto = 0
    End Sub

    Public Sub New(ByVal ls_IdTipoDoc As String _
                    , ByVal ls_TipoDoc As String _
                    , ByVal ls_IdCliente As String _
                    , ByVal ls_NroDoc As String _
                    , ByVal ls_Cliente As String _
                    , ByVal ls_Mes As String _
                    , ByVal ln_Total As Double)

        _idtipodoc = ls_IdTipoDoc
        _tipodoc = ls_TipoDoc
        _idcliente = ls_IdCliente
        _nrodoc = ls_NroDoc
        _cliente = ls_Cliente
        _mes = ls_Mes
        _total = ln_Total
        _porctotal = 0
        _acumulado = 0
        _porcacumulado = 0
        _indpareto = 0
    End Sub

#End Region

    Public Function Obtener(ByVal reporteclientemensual As e_ReporteClienteMensual) As e_ReporteClienteMensual Implements Ie_ReporteClienteMensual.Obtener
        Return reporteclientemensual
    End Function

End Class


