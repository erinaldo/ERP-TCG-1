<DataContract()> _
Public Class e_SeguroComplementario
    Implements Ie_SeguroComplementario
    Implements IEquatable(Of e_SeguroComplementario)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtrabajador As String
    Private _aportasctr As Boolean
    Private _coberturapension As Integer
    Private _coberturasalud As Integer
    Private _idempresaeps As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _vigencia As Integer
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
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property AportaSCTR() As Boolean
        Get
            Return _aportasctr
        End Get
        Set(ByVal value As Boolean)
            _aportasctr = value
        End Set
    End Property

    <DataMember()> _
    Public Property CoberturaPension() As Integer
        Get
            Return _coberturapension
        End Get
        Set(ByVal value As Integer)
            _coberturapension = value
        End Set
    End Property

    <DataMember()> _
    Public Property CoberturaSalud() As Integer
        Get
            Return _coberturasalud
        End Get
        Set(ByVal value As Integer)
            _coberturasalud = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaEPS() As String
        Get
            Return _idempresaeps
        End Get
        Set(ByVal value As String)
            _idempresaeps = value
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
    Public Property Vigencia() As Integer
        Get
            Return _vigencia
        End Get
        Set(ByVal value As Integer)
            _vigencia = value
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
        _aportasctr = False
        _coberturapension = 0
        _coberturasalud = 0
        _idempresaeps = String.Empty
        _fechainicio = #1/1/1901#
        _fechafin = #1/1/1901#
        _vigencia = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal lb_AportaSCTR As Boolean _
              , ByVal ln_CoberturaPension As Integer _
              , ByVal ln_CoberturaSalud As Integer _
              , ByVal ls_IdEmpresaEPS As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ln_Vigencia As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _aportasctr = lb_AportaSCTR
        _coberturapension = ln_CoberturaPension
        _coberturasalud = ln_CoberturaSalud
        _idempresaeps = ls_IdEmpresaEPS
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _vigencia = ln_Vigencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeSeguroComplementario As e_SeguroComplementario) As e_SeguroComplementario Implements Ie_SeguroComplementario.obtener
        Return oeSeguroComplementario
    End Function

    Public Overloads Function Equals(ByVal oeSegComp As e_SeguroComplementario) As Boolean Implements System.IEquatable(Of e_SeguroComplementario).Equals
        Select Case oeSegComp.Equivale
            Case 1 : If Me.Id = oeSegComp.Id Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
