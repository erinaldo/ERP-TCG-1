

<DataContract()> _
Public Class e_Operacion
    Implements Ie_Operacion

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idruta As String
    Private _idestado As String
    Private _totalflete As Double
    Private _observacion As String
    Private _fecha As Date
    Private _usuariocreacion As String
    Private _IndFormato As Integer
    Private _fleteunitario As Double
    Private _cantidad As Double
    Private _idactividadnegocio As String
    Private _idTipoVehiculo As String
    Private _indGuiaTercero As Boolean

    <DataMember()>
    Public Tipooperacion As String
    <DataMember()>
    Public ActidadNegocio As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public oeListaBitacora As New List(Of e_Bitacora)
    <DataMember()> _
    Public oeViaje As New List(Of e_Viaje)

    <DataMember()> _
    Public oeOperacionDetalle As New List(Of e_OperacionDetalle)

    <DataMember()> _
    Public oeContratoTercero As New List(Of e_ViajesTerceros)

    <DataMember()> _
    Public oeIncidenciaAutentificadas As New e_IncidenciasAutentificadas

    <DataMember()> _
    Public NroOperacionVueltas As Integer
    <DataMember()> _
    Public ProgramarBloque As Boolean

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
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
    Public Property TotalFlete() As Double
        Get
            Return _totalflete
        End Get
        Set(ByVal value As Double)
            _totalflete = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property IndFormato() As Integer
        Get
            Return _IndFormato
        End Get
        Set(ByVal value As Integer)
            _IndFormato = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property FleteUnitario() As Double
        Get
            Return _fleteunitario
        End Get
        Set(ByVal value As Double)
            _fleteunitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _idTipoVehiculo
        End Get
        Set(ByVal value As String)
            _idTipoVehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndGuiaTercero() As Boolean
        Get
            Return _indGuiaTercero
        End Get
        Set(ByVal value As Boolean)
            _indGuiaTercero = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Tipooperacion = ""
        Id = ""
        IndFormato = 6

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdEstado As String _
              , ByVal ln_TotalFlete As Double _
              , ByVal ls_Observacion As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_IndFormato As Integer _
              , ByVal ln_cantidad As Double _
              , ByVal ln_fleteunitario As Double _
              , ByVal ls_idactividadnegocio As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _idruta = ls_IdRuta
        _idestado = ls_IdEstado
        _totalflete = ln_TotalFlete
        _observacion = ls_Observacion
        _fecha = ld_Fecha
        _usuariocreacion = ls_UsuarioCreacion
        _IndFormato = lb_IndFormato
        _cantidad = ln_cantidad
        _fleteunitario = ln_fleteunitario
        _idactividadnegocio = ls_idactividadnegocio
    End Sub

#End Region

    Public Function Obtener(ByVal operacion As e_Operacion) As e_Operacion Implements Ie_Operacion.Obtener
        Return operacion
    End Function

End Class


