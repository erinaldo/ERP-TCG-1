<DataContract()> _
Public Class e_OrdenTrabajo_Servicio
    Implements Ie_OrdenTrabajo_Servicio

#Region "Propiedad"

    Private _id As String
    Private _ordentrabajo As String
    Private _servicio As String
    Private _mantenimientoequipo As String
    Private _cantidad As Double
    Private _costo As Double
    Private _costodolares As Double
    Private _descripcion As String
    Private _empresa As String
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdOrdenTrabajo() As String
        Get
            Return _ordentrabajo
        End Get
        Set(ByVal value As String)
            _ordentrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdServicio() As String
        Get
            Return _servicio
        End Get
        Set(ByVal value As String)
            _servicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimientoEquipo() As String
        Get
            Return _mantenimientoequipo
        End Get
        Set(ByVal value As String)
            _mantenimientoequipo = value
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
    Public Property Costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoDolares() As Double
        Get
            Return _costodolares
        End Get
        Set(ByVal value As Double)
            _costodolares = value
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
    Public Property IdEmpresaServicio() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
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
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdOrdenTrabajo As String _
              , ByVal ls_IdServicio As String _
              , ByVal ls_IdMantenimientoEquipo As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Costo As Double _
              , ByVal ls_Descripcion As String _
              , ByVal ls_IdEmpresaServicio As String _
              , ByVal ls_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
                  )
        _id = ls_Id
        _ordentrabajo = ls_IdOrdenTrabajo
        _servicio = ls_IdServicio
        _mantenimientoequipo = ls_IdMantenimientoEquipo
        _cantidad = ln_Cantidad
        _costo = ln_Costo
        _descripcion = ls_Descripcion
        _empresa = ls_IdEmpresaServicio
        _activo = ls_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal ordenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As e_OrdenTrabajo_Servicio Implements Ie_OrdenTrabajo_Servicio.Obtener
        Return ordenTrabajo_Servicio
    End Function

End Class
