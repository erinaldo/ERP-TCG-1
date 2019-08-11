

<DataContract()> _
Public Class e_Detraccion_Det
    Implements Ie_Detraccion_Det

#Region "Declaracion de Variables"

    Private _id As String
    Private _idventa As String
    Private _monto As Double
    Private _fechaaplicado As Date
    Private _indpendiente As Boolean
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property IdVenta() As String
        Get
            Return _idventa
        End Get
        Set(ByVal value As String)
            _idventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAplicado() As Date
        Get
            Return _fechaaplicado
        End Get
        Set(ByVal value As Date)
            _fechaaplicado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Pendiente() As Boolean
        Get
            Return _indpendiente
        End Get
        Set(ByVal value As Boolean)
            _indpendiente = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _activo = True
        _idventa = String.Empty
        _id = String.Empty
        _indpendiente = False
        _fechaaplicado = #1/1/1901#
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdVenta As String _
              , ByVal ln_Monto As Double _
              , ByVal ld_FechaAplicado As Date _
              , ByVal lb_IndPendiente As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _idventa = ls_IdVenta
        _monto = ln_Monto
        _fechaaplicado = ld_FechaAplicado
        _indpendiente = lb_IndPendiente
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal detraccion_Det As e_Detraccion_Det) As e_Detraccion_Det Implements Ie_Detraccion_Det.Obtener
        Return detraccion_Det
    End Function

End Class

