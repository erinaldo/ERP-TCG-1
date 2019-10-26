' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CotizacionDetalleMatSer" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CotizacionDetalleMatSer.svc o e_CotizacionDetalleMatSer.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CotizacionDetalleSer
    Implements Ie_CotizacionDetalleSer
    Implements IEquatable(Of e_CotizacionDetalleSer)

#Region "Propiedad"

    Private _id As String
    Private _requerimientoservicio As New e_RequerimientoServicio
    Private _servicio As New e_Servicio
    Private _cantidad As Double
    Private _precio As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As String
    Private _glosa As String
    Private _cotizacionproveedor As New e_Cotizacion_Proveedor

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Tipo As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    Event DatoCambiado()

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
    Public Property IdRequerimientoServicio() As String
        Get
            Return _requerimientoservicio.Id
        End Get
        Set(ByVal value As String)
            _requerimientoservicio.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdServicio() As String
        Get
            Return _servicio.Id
        End Get
        Set(ByVal value As String)
            _servicio.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Servicio() As String
        Get
            Return _servicio.Nombre
        End Get
        Set(ByVal value As String)
            _servicio.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoServicio() As String
        Get
            Return _servicio.Codigo
        End Get
        Set(ByVal value As String)
            _servicio.Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
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
    Public Property IdCotizacionProveedor() As String
        Get
            Return _cotizacionproveedor.Id
        End Get
        Set(ByVal value As String)
            _cotizacionproveedor.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As String
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As String)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Activo = True
        Tipo = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdRequerimientoServicio As String _
              , ByVal ls_IdServicio As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Precio As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_FechaCreacion As String _
              , ByVal ls_Servicio As String _
              , ByVal ls_CodigoServicio As String _
              , ByVal ls_IdProveedor As String _
              , ByVal ls_Glosa As String)
        _id = ls_Id
        _requerimientoservicio.Id = ls_IdRequerimientoServicio
        _servicio.Id = ls_IdServicio
        _cantidad = ln_Cantidad
        _precio = ln_Precio
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ls_FechaCreacion
        _servicio.Nombre = ls_Servicio
        _servicio.Codigo = ls_CodigoServicio
        _cotizacionproveedor.Id = ls_IdProveedor
        _glosa = ls_Glosa
    End Sub

#End Region

    Public Function Obtener(ByVal cotizacionDetalleSer As e_CotizacionDetalleSer) As e_CotizacionDetalleSer Implements Ie_CotizacionDetalleSer.Obtener
        Return cotizacionDetalleSer
    End Function

    Public Function Equals1(ByVal other As e_CotizacionDetalleSer) As Boolean Implements System.IEquatable(Of e_CotizacionDetalleSer).Equals
        Select Case other.Tipo
            Case 0
                If Me.IdServicio = other.IdServicio.Trim Then Return True
        End Select
        Return False
    End Function

End Class
