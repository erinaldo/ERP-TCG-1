


<DataContract()> _
Public Class e_DepositoDetalle
    Implements Ie_DepositoDetalle
    Implements IEquatable(Of e_DepositoDetalle)

#Region "Propiedad"

    Private _id As String
    Private _iddeposito As String
    Private _idmovimientoflete As String
    Private _importe As Double
    Private _glosa As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    'datos flete
    Private _idViaje As String
    Private _viaje As String
    Private _trabajador As String
    Private _fecha As Date
    Private _flete As Decimal
    Private _carga As String
    Private _idcliente As String
    Private _cliente As String
    Private _SaldoPorDepositar As String
    Private _IdMovimiento As String
    Private _IdOperacionDetalle As String

    Private _IdGrupo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public IndFleOpe As Integer

    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDeposito() As String
        Get
            Return _iddeposito
        End Get
        Set(ByVal value As String)
            _iddeposito = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacionDetalle() As String
        Get
            Return _IdOperacionDetalle
        End Get
        Set(ByVal value As String)
            _IdOperacionDetalle = value
        End Set
    End Property


    <DataMember()> _
    Public Property IdMovimientoFlete() As String
        Get
            Return _idmovimientoflete
        End Get
        Set(ByVal value As String)
            _idmovimientoflete = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
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
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
        End Set
    End Property


    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idViaje
        End Get
        Set(ByVal value As String)
            _idViaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoPorDepositar() As String
        Get
            Return _SaldoPorDepositar
        End Get
        Set(ByVal value As String)
            _SaldoPorDepositar = value
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
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carga() As String
        Get
            Return _carga
        End Get
        Set(ByVal value As String)
            _carga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As Decimal
        Get
            Return _flete
        End Get
        Set(ByVal value As Decimal)
            _flete = value
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
    Public Property IdMovimiento() As String
        Get
            Return _IdMovimiento
        End Get
        Set(ByVal value As String)
            _IdMovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGrupo() As String
        Get
            Return _IdGrupo
        End Get
        Set(ByVal value As String)
            _IdGrupo = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDeposito As String _
              , ByVal ls_IdMovimientoFlete As String _
              , ByVal ln_Importe As Double _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Fecha As String _
              , ByVal ls_Flete As Decimal _
              , ByVal ls_Carga As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ls_SaldoPorDepositar As Decimal _
              , ByVal ls_IdMovimiento As String _
              , ByVal ls_IdGrupo As String _
           )
        _id = ls_Id
        _iddeposito = ls_IdDeposito
        _idmovimientoflete = ls_IdMovimientoFlete
        _importe = ln_Importe
        _glosa = ls_Glosa
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _viaje = ls_Viaje
        _trabajador = ls_Trabajador
        _fecha = ls_Fecha
        _flete = ls_Flete
        _carga = ls_Carga
        _idcliente = ls_IdCliente
        _cliente = ls_Cliente
        _SaldoPorDepositar = ls_SaldoPorDepositar
        _IdMovimiento = ls_IdMovimiento
        _IdGrupo = ls_IdGrupo

    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oeDepositoDetalle As e_DepositoDetalle) _
    As Boolean Implements System.IEquatable(Of e_DepositoDetalle).Equals
        If oeDepositoDetalle.IndFleOpe = 1 Then
            If Me.IdMovimientoFlete = oeDepositoDetalle.IdMovimientoFlete Then
                Return True
            Else
                Return False
            End If
        Else
            If Me.IdOperacionDetalle = oeDepositoDetalle.IdOperacionDetalle Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Public Function Obtener(ByVal depositoDetalle As e_DepositoDetalle) As e_DepositoDetalle Implements Ie_DepositoDetalle.Obtener
        Return depositoDetalle
    End Function

#End Region

End Class

