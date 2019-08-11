
<DataContract()> _
Public Class e_RequerimientoServicio
    Implements Ie_RequerimientoServicio

#Region "Propiedad"

    Private _id As String
    Private _seleccion As Boolean
    Private _idservicio As String
    Private _servicio As String
    Private _codservicio As String
    Private _idrequerimiento As String
    Private _requerimiento As String
    Private _idcentrocosto As String
    Private _centrocosto As String
    Private _mantenimiento As String
    Private _idmantenimiento As String
    Private _area As New e_Area 'id de otra tabla

    Private _asignado As Integer
    Private _cantidad As Double
    Private _precio As Double
    Private _glosa As String

    'Private _idempresaservicio As e_EmpresaServicio
    Private _idempresaservicio As String
    Private _estadorequerimientoservicio As String
    Private _idestadorequerimientoservicio As String
    Private _idequipo As String
    Private _equipo As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date

    Private _indicadorAprobacion As Boolean = False
    Private _aprobacion As Integer
    Private _NroOT As String = ""

    <DataMember()> _
    Public Tipooperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimiento() As String
        Get
            Return _idmantenimiento
        End Get
        Set(ByVal value As String)
            _idmantenimiento = value
        End Set
    End Property


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
    Public Property IdServicio() As String
        Get
            Return _idservicio
        End Get
        Set(ByVal value As String)
            _idservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorAprobacion() As Boolean
        Get
            Return _indicadorAprobacion
        End Get
        Set(ByVal value As Boolean)
            _indicadorAprobacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Servicio() As String
        Get
            Return _servicio
        End Get
        Set(ByVal value As String)
            _servicio = value
        End Set
    End Property
    <DataMember()> _
    Public Property CodigoServicio() As String
        Get
            Return _codservicio
        End Get
        Set(ByVal value As String)
            _codservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRequerimiento() As String
        Get
            Return _idrequerimiento
        End Get
        Set(ByVal value As String)
            _idrequerimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Asignado() As Integer
        Get
            Return _asignado
        End Get
        Set(ByVal value As Integer)
            _asignado = value
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
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
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
    Public Property IdCentroCosto() As String
        Get
            Return _idcentrocosto
        End Get
        Set(ByVal value As String)
            _idcentrocosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property CentroCosto() As String
        Get
            Return _centrocosto
        End Get
        Set(ByVal value As String)
            _centrocosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaServicio() As String
        Get
            Return _idempresaservicio
        End Get
        Set(ByVal value As String)
            _idempresaservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _idequipo
        End Get
        Set(ByVal value As String)
            _idequipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreEquipo() As String
        Get
            Return _equipo
        End Get
        Set(ByVal value As String)
            _equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOT() As String
        Get
            Return _NroOT
        End Get
        Set(ByVal value As String)
            _NroOT = value
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
    Public Property CodigoRequerimiento() As String
        Get
            Return _requerimiento
        End Get
        Set(ByVal value As String)
            _requerimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _area.Id
        End Get
        Set(ByVal value As String)
            _area.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area.Nombre
        End Get
        Set(ByVal value As String)
            _area.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoRequerimientoServicio() As String
        Get
            Return _idestadorequerimientoservicio
        End Get
        Set(ByVal value As String)
            _idestadorequerimientoservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoRequerimientoServicio() As String
        Get
            Return _estadorequerimientoservicio
        End Get
        Set(ByVal value As String)
            _estadorequerimientoservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Aprobacion() As Integer
        Get
            Return _aprobacion
        End Get
        Set(ByVal value As Integer)
            _aprobacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        FechaDesde = Date.Parse("01/01/1901")
        FechaHasta = Date.Parse("01/01/1901")
    End Sub

    Public Sub New( ByVal ls_Seleccion As String _
              , ByVal ls_Id As String _
              , ByVal ls_IdServicio As String _
              , ByVal ln_Asignado As Integer _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Precio As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdCentroCosto As String _
              , ByVal ls_CentroCosto As String _
              , ByVal ls_IdEmpresaServicio As String _
              , ByVal ls_IdRequerimiento As String _
              , ByVal ls_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ld_Servicio As String _
              , ByVal ld_CodigoServicio As String _
              , ByVal ld_CodigoRequerimiento As String _
              , ByVal ld_IdArea As String _
              , ByVal ld_Area As String _
              , ByVal ls_IdEstadoRequerimientoServicio As String _
              , ByVal ls_EstadoRequerimientoServicio As String _
              , ByVal ls_NroOT As String _
              , ByVal ls_Equipo As String _
              , ByVal ls_IdMantenimiento As String _
              , ByVal ls_Mantenimiento As String _
              , ByVal ls_IdEquipo As String)
        _seleccion = ls_Seleccion
        _id = ls_Id
        _idservicio = ls_IdServicio
        _asignado = ln_Asignado
        _cantidad = ln_Cantidad
        _precio = ln_Precio
        _glosa = ls_Glosa
        _idcentrocosto = ls_IdCentroCosto
        _centrocosto = ls_CentroCosto
        _idempresaservicio = ls_IdEmpresaServicio
        _idrequerimiento = ls_IdRequerimiento
        _activo = ls_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _servicio = ld_Servicio
        _codservicio = ld_CodigoServicio
        _requerimiento = ld_CodigoRequerimiento
        _area.Id = ld_IdArea
        _area.Nombre = ld_Area
        _NroOT = ls_NroOT
        _equipo = ls_Equipo
        _idequipo = ls_IdEquipo
        'If ls_indicadorAprobacion = -1 Then 'si es -1 indica que nunca se ha evaluado el requerimiento de material
        '    _indicadorAprobacion = 1
        'Else
        '    _indicadorAprobacion = ls_indicadorAprobacion 'si es 0:Rechazado , si es  1: Aprobado
        'End If
        _indicadorAprobacion = 1
        '_aprobacion = ls_indicadorAprobacion
        _estadorequerimientoservicio = ls_EstadoRequerimientoServicio
        _idestadorequerimientoservicio = ls_IdEstadoRequerimientoServicio
        _idmantenimiento = ls_IdMantenimiento
        _mantenimiento = ls_Mantenimiento
    End Sub

#End Region

    Public Function Obtener(ByVal requerimientoServicio As e_RequerimientoServicio) As e_RequerimientoServicio Implements Ie_RequerimientoServicio.Obtener
        Return requerimientoServicio
    End Function

End Class


