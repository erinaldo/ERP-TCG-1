<DataContract()> _
Public Class e_MovimientoNeumatico
    Implements Ie_MovimientoNeumatico

#Region "Declaracion de Variables"

    Private _id As String
    Private _vidaneumatico As String
    Private _motivo As String
    Private _estadoinicial As String
    Private _estadofinal As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _indvigente As Integer
    Private _idoperacionneumatico As String
    Private _costosoles As Double
    Private _idvehiculo As String
    Private _idconductor As String
    Private _idtecniconeu As String
    Private _fechamov As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

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
    Public Property IdVidaNeumatico() As String
        Get
            Return _vidaneumatico
        End Get
        Set(ByVal value As String)
            _vidaneumatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMotivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoInicial() As String
        Get
            Return _estadoinicial
        End Get
        Set(ByVal value As String)
            _estadoinicial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoFinal() As String
        Get
            Return _estadofinal
        End Get
        Set(ByVal value As String)
            _estadofinal = value
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

    <DataMember()> _
    Public Property IndVigente() As Integer
        Get
            Return _indvigente
        End Get
        Set(ByVal value As Integer)
            _indvigente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacionNeumatico() As String
        Get
            Return _idoperacionneumatico
        End Get
        Set(ByVal value As String)
            _idoperacionneumatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoSoles() As Double
        Get
            Return _costosoles
        End Get
        Set(ByVal value As Double)
            _costosoles = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdConductor() As String
        Get
            Return _idconductor
        End Get
        Set(ByVal value As String)
            _idconductor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTecnicoNeu() As String
        Get
            Return _idtecniconeu
        End Get
        Set(ByVal value As String)
            _idtecniconeu = value
            RaiseEvent DatoCambiado()
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _vidaneumatico = String.Empty
        _motivo = String.Empty
        _estadoinicial = String.Empty
        _estadofinal = String.Empty
        _activo = True
        _usuariocreacion = String.Empty
        _indvigente = 0
        _idoperacionneumatico = String.Empty
        _costosoles = 0
        _idvehiculo = String.Empty
        _idconductor = String.Empty
        _idtecniconeu = String.Empty
        _fechamov = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdVidaNeumatico As String _
              , ByVal ls_IdMotivo As String _
              , ByVal ls_EstadoInicial As String _
              , ByVal ls_EstadoFinal As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_IndVigente As Integer _
              , ByVal ls_IdOperacionNeumatico As String _
              , ByVal ld_CostoSoles As Double _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_IdConductor As String _
              , ByVal ls_IdTecnicoNeu As String _
              , ByVal ld_FechaMov As Date _
                         )
        _id = ls_Id
        _vidaneumatico = ls_IdVidaNeumatico
        _motivo = ls_IdMotivo
        _estadoinicial = ls_EstadoInicial
        _estadofinal = ls_EstadoFinal
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _indvigente = ln_IndVigente
        _idoperacionneumatico = ls_IdOperacionNeumatico
        _costosoles = ld_CostoSoles
        _idvehiculo = ls_IdVehiculo
        _idconductor = ls_IdConductor
        _idtecniconeu = ls_IdTecnicoNeu
        _fechamov = ld_FechaMov
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MovimientoNeumatico
    ''' </summary>
    ''' <param name="movimientoNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal movimientoNeumatico As e_MovimientoNeumatico) As e_MovimientoNeumatico Implements Ie_MovimientoNeumatico.Obtener
        Return movimientoNeumatico
    End Function

#End Region

End Class
