<DataContract()> _
Public Class e_Flota_Cuota
    Implements Ie_Flota_Cuota

#Region "Variables"


    Private _Id As String
    Private _IdFlota As String
    Private _Importe As Double
    Private _FechaInicio As Date
    Private _FechaFin As Date
    Private _Vigente As Integer
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
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
    Public Property IdFlota() As String
        Get
            Return _IdFlota
        End Get
        Set(ByVal value As String)
            _IdFlota = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Integer
        Get
            Return _Vigente
        End Get
        Set(ByVal value As Integer)
            _Vigente = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
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

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdFlota = ""
        _Importe = 0
        _FechaInicio = #1/1/1901#
        _FechaFin = #1/1/1901#
        _Vigente = 0
        _UsuarioCreacion = ""
        _FechaCreacion = #1/1/1901#
        _UsuarioModifica = ""
        _FechaModifica = #1/1/1901#
        _Activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdFlota As String _
          , ByVal ln_Importe As Double _
          , ByVal ld_FechaInicio As Date _
          , ByVal ld_FechaFin As Date _
          , ByVal ln_Vigente As Integer _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal lb_Activo As Boolean _
       )
        _Id = ls_Id
        _IdFlota = ls_IdFlota
        _Importe = ln_Importe
        _FechaInicio = ld_FechaInicio
        _FechaFin = ld_FechaFin
        _Vigente = ln_Vigente
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(flota_cuota As e_Flota_Cuota) As e_Flota_Cuota Implements Ie_Flota_Cuota.Obtener
        Return flota_cuota
    End Function

#End Region



End Class
