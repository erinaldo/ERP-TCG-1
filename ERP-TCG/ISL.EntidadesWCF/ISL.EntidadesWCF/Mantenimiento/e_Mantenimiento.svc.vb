<DataContract()> _
Public Class e_Mantenimiento
    Implements Ie_Mantenimiento

#Region "Propiedad"

    Private _id As String
    Private _idtipomantenimiento As String
    Private _tipomantenimiento As String
    Private _nombre As String
    Private _codigo As String
    Private _descripcion As String
    Private _cantidad As Double
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _ordensecuencia As Integer
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _externa As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public lstDetalleEquipo As List(Of e_MantenimientoEquipo)
    <DataMember()> _
    Public lstDetalleMaterial As List(Of e_MantenimientoMaterial)
    <DataMember()> _
    Public lstDetalleServicio As List(Of e_MantenimientoServicio)
    <DataMember()> _
    Public lstDetalleActividad As List(Of e_MantenimientoActividad)
    <DataMember()> _
    Public lstDetalleOcupacion As List(Of e_MantenimientoOcupacion)

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
    Public Property IdTipoMantenimiento() As String
        Get
            Return _idtipomantenimiento
        End Get
        Set(ByVal value As String)
            _idtipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMantenimiento() As String
        Get
            Return _tipomantenimiento
        End Get
        Set(ByVal value As String)
            _tipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property OrdenSecuencia() As Integer
        Get
            Return _ordensecuencia
        End Get
        Set(ByVal value As Integer)
            _ordensecuencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
Public Property Externa() As Integer
        Get
            Return _externa
        End Get
        Set(ByVal value As Integer)
            _externa = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _idtipomantenimiento = ""
        _tipomantenimiento = ""
        _nombre = ""
        _codigo = ""
        _descripcion = ""
        _ordensecuencia = 0
        _cantidad = 0
        _idunidadmedida = ""
        _unidadmedida = ""
        _activo = True
        _usuariocreacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoMantenimiento As String _
              , ByVal ls_TipoMantenimiento As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_Codigo As String _
              , ByVal ls_Descripcion As String _
              , ByVal ln_OrdenSecuencia As Integer _
              , ByVal ln_Cantidad As Double _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_UnidadMedida As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_Externa As Integer _
                       )
        _id = ls_Id
        _idtipomantenimiento = ls_IdTipoMantenimiento
        _tipomantenimiento = ls_TipoMantenimiento
        _nombre = ls_Nombre
        _codigo = ln_Codigo
        _descripcion = ls_Descripcion
        _ordensecuencia = ln_OrdenSecuencia
        _cantidad = ln_Cantidad
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _externa = ln_Externa
    End Sub

#End Region

    Public Function Obtener(ByVal mantenimiento As e_Mantenimiento) As e_Mantenimiento Implements Ie_Mantenimiento.Obtener
        Return mantenimiento
    End Function

End Class
