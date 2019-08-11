

<DataContract()> _
Public Class e_Cotizacion
    Implements Ie_Cotizacion

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _glosa As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _estado As New e_Estado
    Private _moneda As New e_Moneda
    Private _proveedor As New e_Proveedor
    Private _equipo As New e_Equipo
    Private _importe As Double
    Private _indmaterialservicio As String
    
    <DataMember()> _
    Public lstCotizacionProveedor As New List(Of e_Cotizacion_Proveedor)

    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFinal As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdEstado() As String
        Get
            Return _estado.Id
        End Get
        Set(ByVal value As String)
            _estado.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado.Nombre
        End Get
        Set(ByVal value As String)
            _estado.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Equipo() As String
        Get
            Return _equipo.Nombre
        End Get
        Set(ByVal value As String)
            _equipo.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _equipo.Id
        End Get
        Set(ByVal value As String)
            _equipo.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As String
        Get
            Return _proveedor.Nombre
        End Get
        Set(ByVal value As String)
            _proveedor.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _proveedor.Id
        End Get
        Set(ByVal value As String)
            _proveedor.Id = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndMaterialServicio() As String
        Get
            Return _indmaterialservicio
        End Get
        Set(ByVal value As String)
            _indmaterialservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _moneda.Nombre
        End Get
        Set(ByVal value As String)
            _moneda.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _moneda.Id
        End Get
        Set(ByVal value As String)
            _moneda.Id = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Activo = True
        Importe = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Moneda As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_IndMaterialServicio As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_IdProveedor As String _
              , ByVal ls_Proveedor As String _
              , ByVal ls_IdEquipo As String _
              , ByVal ls_Equipo As String _
              , ByVal ld_Importe As Double)
        _id = ls_Id
        _codigo = ls_Codigo
        _glosa = ls_Glosa
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _moneda.Nombre = ls_Moneda
        _moneda.Id = ls_IdMoneda
        _indmaterialservicio = ls_IndMaterialServicio
        _estado.Id = ls_IdEstado
        _estado.Nombre = ls_Estado
        _proveedor.Id = ls_IdProveedor
        _proveedor.Nombre = ls_Proveedor
        _equipo.Id = ls_IdEquipo
        _equipo.Nombre = ls_Equipo
        _importe = ld_Importe
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal cotizacion As e_Cotizacion) As e_Cotizacion Implements Ie_Cotizacion.Obtener
        Return cotizacion
    End Function

#End Region

End Class


