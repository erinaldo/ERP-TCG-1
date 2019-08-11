



<DataContract()> _
Public Class e_Saldo
    Implements Ie_Saldo

#Region "Declaracion de Variables"

    Private _id As String
    Private _tipo As Integer
    Private _idcuentacorriente As String
    Private _idcaja As String
    Private _fechahora As Date
    Private _saldo As Decimal
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
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorriente
        End Get
        Set(ByVal value As String)
            _idcuentacorriente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCaja() As String
        Get
            Return _idcaja
        End Get
        Set(ByVal value As String)
            _idcaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaHora() As Date
        Get
            Return _fechahora
        End Get
        Set(ByVal value As Date)
            _fechahora = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
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
        _fechahora = #1/1/1901#
        _saldo = 0
        _tipo = 0
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ln_Tipo As Integer _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_IdCaja As String _
              , ByVal ld_FechaHora As Date _
              , ByVal ln_Saldo As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _tipo = ln_Tipo
        _idcuentacorriente = ls_IdCuentaCorriente
        _idcaja = ls_IdCaja
        _fechahora = ld_FechaHora
        _saldo = ln_Saldo
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal saldo As e_Saldo) As e_Saldo Implements Ie_Saldo.Obtener
        Return saldo
    End Function

End Class

