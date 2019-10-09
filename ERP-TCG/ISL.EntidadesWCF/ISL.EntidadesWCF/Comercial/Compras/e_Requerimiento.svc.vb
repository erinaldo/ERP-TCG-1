

<DataContract()> _
Public Class e_Requerimiento
    Implements Ie_Requerimiento

#Region "Propiedad"

    Private _id As String
    Private _codigo As String 'Generado por un procedimiento almacenado.
    Private _fechaatencion As Date 'Fecha en la que se atenderá el requerimiento
    Private _materialservicio As String 'Indica si el requerimiento es un servicio(S) o material(M)
    Private _idestadorequerimiento As String
    Private _estadorequerimiento As String
    Private _idtrabajador As String
    Private _trabajador As String
    'Private _idtrabajadoraprobacion As String
    Private _descripcion As String 'Glosa 
    Private _idarea As String
    Private _area As String 'id de otra tabla
    Private _tiporeferencia As String
    Private _referencia As String
    Private _idreferencia As String

    'Private _OrdenTrabajo As New e_OrdenTrabajo  'Este campo no se manipulara en el requerimiento.
    Private _idEquipo As String

    Private _glosaatencion As String 'Glosa a utilizar cuando se atienda un pedido

    'Private _idusuarioatendio As New e_UsuarioAtendio
    Private _idusuarioatencion As String 'Usuario que atiende el pedido

    <DataMember()> _
    Public lstRequerimientoMaterial As New List(Of e_RequerimientoMaterial)
    <DataMember()> _
    Public lstRequerimientoServicio As New List(Of e_RequerimientoServicio)
    <DataMember()> _
    Public IdTrabajadorAprobacion As String

    Private _activo As Boolean
    Private _usuariocreacion As String 'Usuario que genera el pedido
    Private _fechacreacion As Date 'Fecha en la que se registra el requerimiento, fecha en la que se solicita el requerimiento.

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public PrefijoCentro As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Private _fechainicio As Date
    Private _fechaFinal As Date
    Private _opcionFecha As String

    <DataMember()> _
    Public oeOrdenSalida As New e_Orden

    <DataMember()> _
    Public oeOrdenIngreso As New e_Orden

    ''' <summary>
    ''' 'variables para la creacion de asientos por ingreso y salida con documento no emitido
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    <DataMember()> _
    Public IdPeriodo As String = ""
    <DataMember()> _
    Public TipoCambio As Double = 0
    <DataMember()> _
    Public IdVehiculo As String = ""
    <DataMember()> _
    Public oeOrdenIngresoAlmPrincipal As New e_Orden
    <DataMember()> _
    Public oeOrdenSalidaAlmPrincipal As New e_Orden

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
    Public Property FechaAtencion() As Date
        Get
            Return _fechaatencion
        End Get
        Set(ByVal value As Date)
            _fechaatencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property MaterialServicio() As String
        Get
            Return _materialservicio
        End Get
        Set(ByVal value As String)
            _materialservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoRequerimiento() As String
        Get
            Return _idestadorequerimiento
        End Get
        Set(ByVal value As String)
            _idestadorequerimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoRequerimiento() As String
        Get
            Return _estadorequerimiento
        End Get
        Set(ByVal value As String)
            _estadorequerimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As String
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As String)
            _tiporeferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _idEquipo
        End Get
        Set(ByVal value As String)
            _idEquipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaAtencion() As String
        Get
            Return _glosaatencion
        End Get
        Set(ByVal value As String)
            _glosaatencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioAtencion() As String
        Get
            Return _idusuarioatencion
        End Get
        Set(ByVal value As String)
            _idusuarioatencion = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFinal() As Date
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As Date)
            _fechaFinal = value
        End Set
    End Property

    <DataMember()> _
    Public Property OpcionFecha() As String
        Get
            Return _opcionFecha
        End Get
        Set(ByVal value As String)
            _opcionFecha = value
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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        EstadoRequerimiento = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ld_FechaAtencion As String _
              , ByVal lb_MaterialServicio As String _
              , ByVal ls_IdEstadoRequerimiento As String _
              , ByVal ls_EstadoRequerimiento As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ls_TipoReferencia As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_Referencia As String _
              , ByVal ls_GlosaAtencion As String _
              , ByVal ls_IdUsuarioAtendio As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ld_Trabajador As String _
              , ByVal ls_IdEquipo As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _materialservicio = lb_MaterialServicio
        _idestadorequerimiento = ls_IdEstadoRequerimiento
        _estadorequerimiento = ls_EstadoRequerimiento
        _descripcion = ls_Descripcion
        _idarea = ls_IdArea
        _area = ls_Area
        _tiporeferencia = ls_TipoReferencia
        _idreferencia = ls_IdReferencia
        _referencia = ls_Referencia
        _glosaatencion = ls_GlosaAtencion
        _idusuarioatencion = ls_IdUsuarioAtendio
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _idEquipo = ls_IdEquipo
        If Not ld_FechaAtencion Is Nothing And Not ld_FechaAtencion.Equals("") And Not ld_FechaAtencion.Equals("01/01/1901 12:00:00 a.m.") Then
            _fechaatencion = Date.Parse(ld_FechaAtencion)
        Else
            _fechaatencion = Date.Parse(ld_FechaCreacion)
        End If
        _trabajador = ld_Trabajador

    End Sub

#End Region

    Public Function Obtener(ByVal requerimiento As e_Requerimiento) As e_Requerimiento Implements Ie_Requerimiento.Obtener
        Return requerimiento
    End Function

End Class


