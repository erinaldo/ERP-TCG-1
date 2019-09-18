<DataContract()> _
Public Class e_ConsolidadoUtilidad
    Implements Ie_ConsolidadoUtilidad
    Implements IEquatable(Of e_ConsolidadoUtilidad)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idutilidad As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _indsituacion As Integer
    Private _sueldoanual As Double
    Private _subsidios As Double
    Private _sueldonetoanual As Double
    Private _utilidadporsueldo As Double
    Private _diastrabajadosanual As Integer
    Private _utilidadpordiastrabajados As Double
    Private _utilidadtotal As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodfica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public IndAdministrativo As Integer
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
    Public Property IdUtilidad() As String
        Get
            Return _idutilidad
        End Get
        Set(ByVal value As String)
            _idutilidad = value
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
    Public Property IndSituacion() As Integer
        Get
            Return _indsituacion
        End Get
        Set(ByVal value As Integer)
            _indsituacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property SueldoAnual() As Double
        Get
            Return _sueldoanual
        End Get
        Set(ByVal value As Double)
            _sueldoanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Subsidios() As Double
        Get
            Return _subsidios
        End Get
        Set(ByVal value As Double)
            _subsidios = value
        End Set
    End Property

    <DataMember()> _
    Public Property SueldoNetoAnual() As Double
        Get
            Return _sueldonetoanual
        End Get
        Set(ByVal value As Double)
            _sueldonetoanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property UtilidadporSueldo() As Double
        Get
            Return _utilidadporsueldo
        End Get
        Set(ByVal value As Double)
            _utilidadporsueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasTrabajadosAnual() As Integer
        Get
            Return _diastrabajadosanual
        End Get
        Set(ByVal value As Integer)
            _diastrabajadosanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property UtilidadporDiasTrabajados() As Double
        Get
            Return _utilidadpordiastrabajados
        End Get
        Set(ByVal value As Double)
            _utilidadpordiastrabajados = value
        End Set
    End Property

    <DataMember()> _
    Public Property UtilidadTotal() As Double
        Get
            Return _utilidadtotal
        End Get
        Set(ByVal value As Double)
            _utilidadtotal = value
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
    Public Property UsuarioModfica() As String
        Get
            Return _usuariomodfica
        End Get
        Set(ByVal value As String)
            _usuariomodfica = value
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
        _idutilidad = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _indsituacion = 0
        _sueldoanual = 0
        _subsidios = 0
        _sueldonetoanual = 0
        _utilidadporsueldo = 0
        _diastrabajadosanual = 0
        _utilidadpordiastrabajados = 0
        _utilidadtotal = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodfica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdUtilidad As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_IndSituacion As Integer _
              , ByVal ln_SueldoAnual As Double _
              , ByVal ln_Subsidios As Double _
              , ByVal ln_SueldoNetoAnual As Double _
              , ByVal ln_UtilidadporSueldo As Double _
              , ByVal ln_DiasTrabajadosAnual As Integer _
              , ByVal ln_UtilidadporDiasTrabajados As Double _
              , ByVal ln_UtilidadTotal As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModfica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idutilidad = ls_IdUtilidad
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _indsituacion = ln_IndSituacion
        _sueldoanual = ln_SueldoAnual
        _subsidios = ln_Subsidios
        _sueldonetoanual = ln_SueldoNetoAnual
        _utilidadporsueldo = ln_UtilidadporSueldo
        _diastrabajadosanual = ln_DiasTrabajadosAnual
        _utilidadpordiastrabajados = ln_UtilidadporDiasTrabajados
        _utilidadtotal = ln_UtilidadTotal
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodfica = ls_UsuarioModfica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetalleUtilidad As e_ConsolidadoUtilidad) As e_ConsolidadoUtilidad Implements Ie_ConsolidadoUtilidad.obtener
        Return oeDetalleUtilidad
    End Function

    Public Overloads Function Equals(ByVal oeDetUti As e_ConsolidadoUtilidad) As Boolean Implements System.IEquatable(Of e_ConsolidadoUtilidad).Equals
        Select Case oeDetUti.Equivale
            Case 1 : If Me.Id = oeDetUti.Id Then Return True
            Case 2 : If Me.IdTrabajador = oeDetUti.IdTrabajador Then Return True
            Case 3 : If Me.Dni = oeDetUti.Dni Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
