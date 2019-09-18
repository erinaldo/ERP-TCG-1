<DataContract()> _
Public Class e_FondoPensionTrabajador
    Implements Ie_FondoPensionTrabajador
    Implements IEquatable(Of e_FondoPensionTrabajador)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idempresa As String
    Private _empresa As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _dni As String
    Private _cuspp As String
    Private _mixta As Integer
    Private _fechaactividad As Date
    Private _fechainactividad As Date
    Private _vigente As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leHistorial As New List(Of e_FondoPensionTrabajador)
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
    Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
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
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property CUSPP() As String
        Get
            Return _cuspp
        End Get
        Set(ByVal value As String)
            _cuspp = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mixta() As Integer
        Get
            Return _mixta
        End Get
        Set(ByVal value As Integer)
            _mixta = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaActividad() As Date
        Get
            Return _fechaactividad
        End Get
        Set(ByVal value As Date)
            _fechaactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInactividad() As Date
        Get
            Return _fechainactividad
        End Get
        Set(ByVal value As Date)
            _fechainactividad = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idempresa = String.Empty
        _idtrabajador = String.Empty
        _cuspp = String.Empty
        _mixta = -1
        _fechaactividad = #1/1/1901#
        _fechainactividad = #1/1/1901#
        _vigente = -1
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_Empresa As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_dni As String _
              , ByVal ls_CUSPP As String _
              , ByVal ln_Mixta As Integer _
              , ByVal ld_FechaActividad As Date _
              , ByVal ld_FechaInactividad As Date _
              , ByVal ln_Vigente As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idempresa = ls_IdEmpresa
        _empresa = ls_Empresa
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _dni = ls_dni
        _cuspp = ls_CUSPP
        _mixta = ln_Mixta
        _fechaactividad = ld_FechaActividad
        _fechainactividad = ld_FechaInactividad
        _vigente = ln_Vigente
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As e_FondoPensionTrabajador Implements Ie_FondoPensionTrabajador.obtener
        Return oeFondoPensionTrabajador
    End Function

    Public Overloads Function Equals(ByVal oeFonPenTra As e_FondoPensionTrabajador) As Boolean Implements System.IEquatable(Of e_FondoPensionTrabajador).Equals
        Select Case oeFonPenTra.Equivale
            Case 1 : If Me.IdTrabajador = oeFonPenTra.IdTrabajador Then Return True
            Case 2 : If Me.Empresa = oeFonPenTra.Empresa Then Return True
            Case 3 : If Me.CUSPP.Trim = oeFonPenTra.CUSPP.Trim Then Return True
        End Select
        Return False
    End Function

#End Region


End Class
