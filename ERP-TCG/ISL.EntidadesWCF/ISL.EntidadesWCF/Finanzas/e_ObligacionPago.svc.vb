<DataContract()> _
Public Class e_ObligacionPago
    Implements Ie_ObligacionPago

#Region "Declaracion de Variables"

    Private _id As String
    Private _idmovimientocajabanco As String
    Private _idobligacionfinanciera As String
    Private _nrocuota As Integer
    Private _fechainicial As Date
    Private _montoinicialmn As Double
    Private _montoinicialme As Double
    Private _indcancelado As Boolean
    Private _fechafinal As Date
    Private _montofinalmn As Double
    Private _montofinalme As Double
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public MacPCLocalCreacion As String
    <DataMember()> _
    Public OeAsientoMov_ObligFin As New e_AsientoMov_ObligacionFin
    <DataMember()> _
    Public _IdAsientoMovimiento As String

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
    Public Property IdMovimientoCajaBanco() As String
        Get
            Return _idmovimientocajabanco
        End Get
        Set(ByVal value As String)
            _idmovimientocajabanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdObligacionFinanciera() As String
        Get
            Return _idobligacionfinanciera
        End Get
        Set(ByVal value As String)
            _idobligacionfinanciera = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuota() As Integer
        Get
            Return _nrocuota
        End Get
        Set(ByVal value As Integer)
            _nrocuota = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicial() As Date
        Get
            Return _fechainicial
        End Get
        Set(ByVal value As Date)
            _fechainicial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInicialMN() As Double
        Get
            Return _montoinicialmn
        End Get
        Set(ByVal value As Double)
            _montoinicialmn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInicialME() As Double
        Get
            Return _montoinicialme
        End Get
        Set(ByVal value As Double)
            _montoinicialme = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCancelado() As Boolean
        Get
            Return _indcancelado
        End Get
        Set(ByVal value As Boolean)
            _indcancelado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFinal() As Date
        Get
            Return _fechafinal
        End Get
        Set(ByVal value As Date)
            _fechafinal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoFinalMN() As Double
        Get
            Return _montofinalmn
        End Get
        Set(ByVal value As Double)
            _montofinalmn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoFinalME() As Double
        Get
            Return _montofinalme
        End Get
        Set(ByVal value As Double)
            _montofinalme = value
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
        Activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoCajaBanco As String _
              , ByVal ls_IdObligacionFinanciera As String _
              , ByVal ln_NroCuota As Integer _
              , ByVal ld_FechaInicial As Date _
              , ByVal ln_MontoInicialMN As Double _
              , ByVal ln_MontoInicialME As Double _
              , ByVal lb_IndCancelado As Boolean _
              , ByVal ld_FechaFinal As Date _
              , ByVal ln_MontoFinalMN As Double _
              , ByVal ln_MontoFinalME As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _idmovimientocajabanco = ls_IdMovimientoCajaBanco
        _idobligacionfinanciera = ls_IdObligacionFinanciera
        _nrocuota = ln_NroCuota
        _fechainicial = ld_FechaInicial
        _montoinicialmn = ln_MontoInicialMN
        _montoinicialme = ln_MontoInicialME
        _indcancelado = lb_IndCancelado
        _fechafinal = ld_FechaFinal
        _montofinalmn = ln_MontoFinalMN
        _montofinalme = ln_MontoFinalME
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ObligacionPago
    ''' </summary>
    ''' <param name="obligacionPago"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal obligacionPago As e_ObligacionPago) As e_ObligacionPago Implements Ie_ObligacionPago.Obtener
        Return obligacionPago
    End Function

#End Region

End Class


