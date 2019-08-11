


<DataContract()> _
Public Class e_TipoGastoDetalle
    Implements Ie_TipoGastoDetalle

#Region "Declaración de variables"

    Private _Id As String
    Private _IdTipoGasto As String
    Private _IdFlujoCaja As String
    Private _FlujoCaja As String
    Private _Activo As Boolean
    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoGasto() As String
        Get
            Return _IdTipoGasto
        End Get
        Set(ByVal value As String)
            _IdTipoGasto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _IdFlujoCaja
        End Get
        Set(ByVal value As String)
            _IdFlujoCaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja() As String
        Get
            Return _FlujoCaja
        End Get
        Set(ByVal value As String)
            _FlujoCaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Public Sub New()
        _Activo = True
        _Id = String.Empty
        _FlujoCaja = String.Empty
        TipoOperacion = "N"
    End Sub

    Public Sub New(ByVal Id As String, ByVal IdTipoGasto As String, ByVal IdFlujoCaja As String, _
            ByVal FlujoCaja As String, ByVal Activo As Boolean)
        _Id = Id
        _IdTipoGasto = IdTipoGasto
        _IdFlujoCaja = IdFlujoCaja
        _FlujoCaja = FlujoCaja
        _Activo = Activo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal tipoGastoDetalle As e_TipoGastoDetalle) As e_TipoGastoDetalle Implements Ie_TipoGastoDetalle.Obtener
        Return tipoGastoDetalle
    End Function

#End Region

End Class

