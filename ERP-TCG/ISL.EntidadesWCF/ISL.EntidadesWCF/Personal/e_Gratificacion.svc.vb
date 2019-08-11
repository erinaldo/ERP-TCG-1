<DataContract()> _
Public Class e_Gratificacion
    Implements Ie_Gratificacion

#Region "Declaracion de Variables"

    Private _id As String
    Private _idperiodo As String
    Private _periodo As String
    Private _indtipo As Integer
    Private _tipo As String
    Private _codigo As String
    Private _monto As Double
    Private _pendiente As Double
    Private _glosa As String
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    Private _fechapago As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public PromBono As Integer
    <DataMember()> _
    Public leDetalle As List(Of e_DetalleGratificacion)
    <DataMember()> _
    Public dtDetalle As DataTable

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
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Select Case _indtipo
                Case 1 : _tipo = "GRATIFICACION"
                Case 2 : _tipo = "CTS"
            End Select
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

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
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Pendiente() As Double
        Get
            Return _pendiente
        End Get
        Set(ByVal value As Double)
            _pendiente = value
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
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaPago() As Date
        Get
            Return _fechapago
        End Get
        Set(ByVal value As Date)
            _fechapago = value
        End Set
    End Property

#End Region

#Region "Constrcutor"

    Public Sub New()
        _id = String.Empty
        _idperiodo = String.Empty
        _periodo = String.Empty
        _indtipo = 0
        _tipo = String.Empty
        _codigo = String.Empty
        _monto = 0
        _pendiente = 0
        _glosa = String.Empty
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_Periodo As String _
              , ByVal ln_IndTipo As Integer _
              , ByVal ls_Codigo As String _
              , ByVal ln_Monto As Double _
              , ByVal ln_Pendiente As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ln_PromBono As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idperiodo = ls_IdPeriodo
        _periodo = ls_Periodo
        _indtipo = ln_IndTipo
        _codigo = ls_Codigo
        _monto = ln_Monto
        _pendiente = ln_Pendiente
        _glosa = ls_Glosa
        _idestado = ls_IdEstado
        _estado = ls_Estado
        PromBono = ln_PromBono
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeGratificacion As e_Gratificacion) As e_Gratificacion Implements Ie_Gratificacion.obtener
        Return oeGratificacion
    End Function

#End Region

End Class
