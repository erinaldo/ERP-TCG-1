<DataContract()> _
Public Class e_RegimenSalud
    Implements Ie_RegimenSalud
    Implements IEquatable(Of e_RegimenSalud)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtrabajador As String
    Private _regimen As String
    Private _idplaneps As String
    Private _adicional As Integer
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _vigente As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdEmpresaPS As String
    <DataMember()> _
    Public Equivale As Integer

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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Regimen() As String
        Get
            Return _regimen
        End Get
        Set(ByVal value As String)
            _regimen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPlanEPS() As String
        Get
            Return _idplaneps
        End Get
        Set(ByVal value As String)
            _idplaneps = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional() As Integer
        Get
            Return _adicional
        End Get
        Set(ByVal value As Integer)
            _adicional = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Integer
        Get
            Return _vigente
        End Get
        Set(ByVal value As Integer)
            _vigente = value
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

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idtrabajador = String.Empty
        _regimen = String.Empty
        _idplaneps = String.Empty
        _adicional = 0
        _fechainicio = #1/1/1901#
        _fechafin = #1/1/1901#
        _vigente = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Regimen As String _
              , ByVal ls_IdPlanEPS As String _
              , ByVal ln_Adicional As Integer _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ln_Vigente As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )

        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _regimen = ls_Regimen
        _idplaneps = ls_IdPlanEPS
        _adicional = ln_Adicional
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _vigente = ln_Vigente
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo

    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeRegimenSalud As e_RegimenSalud) As e_RegimenSalud Implements Ie_RegimenSalud.obtener
        Return oeRegimenSalud
    End Function

    Public Overloads Function Equals(ByVal oeRSalud As e_RegimenSalud) As Boolean Implements System.IEquatable(Of e_RegimenSalud).Equals
        Select Case oeRSalud.Equivale
            Case 1 : If Me.Id = oeRSalud.Id Then Return True
            Case 2 : If Me.IdTrabajador = oeRSalud.IdTrabajador Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
