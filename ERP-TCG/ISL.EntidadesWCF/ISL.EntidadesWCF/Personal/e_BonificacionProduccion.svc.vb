<DataContract()> _
Public Class e_BonificacionProduccion
    Implements Ie_BonificacionProduccion

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _montoplanilla As Double
    Private _montocaja As Double
    Private _indruta As Integer
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
    Public NroMes As Integer
    <DataMember()> _
    Public Ejercicio As Integer
    <DataMember()> _
    Public Mes As Integer

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
    Public Property IdPlanilla() As String
        Get
            Return _idplanilla
        End Get
        Set(ByVal value As String)
            _idplanilla = value
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
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
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
    Public Property MontoPlanilla() As Double
        Get
            Return _montoplanilla
        End Get
        Set(ByVal value As Double)
            _montoplanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCaja() As Double
        Get
            Return _montocaja
        End Get
        Set(ByVal value As Double)
            _montocaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndRuta() As Integer
        Get
            Return _indruta
        End Get
        Set(ByVal value As Integer)
            _indruta = value
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
        _idplanilla = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _montoplanilla = 0
        _montocaja = 0
        _indruta = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdPlanilla As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Dni As String _
          , ByVal ls_Trabajador As String _
          , ByVal ln_MontoPlanilla As Double _
          , ByVal ln_MontoCaja As Double _
          , ByVal ln_IndRuta As Integer _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
          , ByVal ln_Ejercicio As Integer _
          , ByVal ln_Mes As Integer _
       )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _montoplanilla = ln_MontoPlanilla
        _montocaja = ln_MontoCaja
        _indruta = ln_IndRuta
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
        Ejercicio = ln_Ejercicio
        Mes = ln_Mes
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeBonificacionProduccion As e_BonificacionProduccion) As e_BonificacionProduccion Implements Ie_BonificacionProduccion.obtener
        Return oeBonificacionProduccion
    End Function

#End Region


End Class
