'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

<DataContract()>
Public Class e_SueldoTrabajador
    Implements Ie_SueldoTrabajador
    Implements IEquatable(Of e_SueldoTrabajador)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _dni As String
    Private _sueldo As Double
    Private _tipopago As Integer
    Private _periocidad As Integer
    Private _fechaactividad As Date
    Private _fechainactividad As Date
    Private _vigente As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _sueldocaja As Double '@0001
    Private _produccion As Integer '@0001
    Private _idCentroCosto As String '@0001
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leHistorial As New List(Of e_SueldoTrabajador)
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property Sueldo() As Double
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Double)
            _sueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As Integer
        Get
            Return _tipopago
        End Get
        Set(ByVal value As Integer)
            _tipopago = value
        End Set
    End Property

    <DataMember()> _
    Public Property Periocidad() As Integer
        Get
            Return _periocidad
        End Get
        Set(ByVal value As Integer)
            _periocidad = value
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

    <DataMember()>
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    '@0001 Ini
    <DataMember()>
    Public Property SueldoCaja() As Double
        Get
            Return _sueldocaja
        End Get
        Set(ByVal value As Double)
            _sueldocaja = value
        End Set
    End Property
    <DataMember()>
    Public Property Produccion() As Integer
        Get
            Return _produccion
        End Get
        Set(ByVal value As Integer)
            _produccion = value
        End Set
    End Property
    <DataMember()>
    Public Property IdCentroCosto() As String
        Get
            Return _idCentroCosto
        End Get
        Set(ByVal value As String)
            _idCentroCosto = value
        End Set
    End Property
    '@0001 Fin
#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idtrabajador = String.Empty
        _trabajador = String.Empty
        _dni = String.Empty
        _sueldo = 0
        _tipopago = -1
        _periocidad = -1
        _fechaactividad = #1/1/1901#
        _fechainactividad = #1/1/1901#
        _vigente = -1
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        _sueldocaja = 0
        _produccion = -1
        _idCentroCosto = String.Empty
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ln_Sueldo As Double _
              , ByVal ln_TipoPago As Integer _
              , ByVal ln_Periocidad As Integer _
              , ByVal ld_FechaActividad As Date _
              , ByVal ld_FechaInactividad As Date _
              , ByVal ln_Vigente As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_SueldoCaja As Double _
              , ByVal ln_Produccion As Integer _
              , ByVal ls_IdCentroCosto As String
           )
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _dni = ls_Dni
        _sueldo = ln_Sueldo
        _tipopago = ln_TipoPago
        _periocidad = ln_Periocidad
        _fechaactividad = ld_FechaActividad
        _fechainactividad = ld_FechaInactividad
        _vigente = ln_Vigente
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _sueldocaja = ln_SueldoCaja
        _produccion = ln_Produccion
        _idCentroCosto = ls_IdCentroCosto
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As e_SueldoTrabajador Implements Ie_SueldoTrabajador.obtener
        Return oeSueldoTrabajador
    End Function

    Public Overloads Function Equals(ByVal oeSueTra As e_SueldoTrabajador) As Boolean Implements System.IEquatable(Of e_SueldoTrabajador).Equals
        Select Case oeSueTra.Equivale
            Case 1 : If Me.IdTrabajador = oeSueTra.IdTrabajador Then Return True
            Case 2 : If Me.Sueldo = oeSueTra.Sueldo Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
