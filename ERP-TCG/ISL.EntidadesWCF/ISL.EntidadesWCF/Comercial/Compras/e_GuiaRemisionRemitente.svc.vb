

<DataContract()> _
Public Class e_GuiaRemisionRemitente
    Implements Ie_GuiaRemisionRemitente

#Region "Propiedad"

    Private _id As String
    Private _idempresaproveedor As String
    Private _empresaproveedor As String
    Private _idtipoguia As String
    Private _serie As String
    Private _numero As String
    Private _idmotivotraslado As String
    Private _motivotraslado As String
    Private _idempresaorigen As String
    Private _idempresadestino As String
    Private _iddireccionorigen As String
    Private _iddirecciondestino As String
    Private _fecha As Date = #1/1/1901#
    Private _glosa As String
    Private _piloto As String
    Private _placavehiculo As String
    Private _placacarreta As String
    Private _idestado As String
    Private _estado As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date = #1/1/1901#
    <DataMember()> _
    Public fechaFin As Date
    <DataMember()> _
    Public fechaInicio As Date
    <DataMember()> _
    Public lstGRRMaterial As New List(Of e_GuiaRRemitenteMaterial)
    <DataMember()> _
    Public lstOrden As New List(Of e_Orden)
    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

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
    Public Property IdEmpresaProveedor() As String
        Get
            Return _idempresaproveedor
        End Get
        Set(ByVal value As String)
            _idempresaproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Private _Nombre As String
    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _empresaproveedor
        End Get
        Set(ByVal value As String)
            _empresaproveedor = value
        End Set
    End Property

    Private _nroGuia As String
    <DataMember()> _
    Public Property NroGuia() As String
        Get
            Return _nroGuia
        End Get
        Set(ByVal value As String)
            _nroGuia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoGuia() As String
        Get
            Return _idtipoguia
        End Get
        Set(ByVal value As String)
            _idtipoguia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MotivoTraslado() As String
        Get
            Return _motivotraslado
        End Get
        Set(ByVal value As String)
            _motivotraslado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMotivoTraslado() As String
        Get
            Return _idmotivotraslado
        End Get
        Set(ByVal value As String)
            _idmotivotraslado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaOrigen() As String
        Get
            Return _idempresaorigen
        End Get
        Set(ByVal value As String)
            _idempresaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaDestino() As String
        Get
            Return _idempresadestino
        End Get
        Set(ByVal value As String)
            _idempresadestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionOrigen() As String
        Get
            Return _iddireccionorigen
        End Get
        Set(ByVal value As String)
            _iddireccionorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionDestino() As String
        Get
            Return _iddirecciondestino
        End Get
        Set(ByVal value As String)
            _iddirecciondestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _piloto
        End Get
        Set(ByVal value As String)
            _piloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PlacaVehiculo() As String
        Get
            Return _placavehiculo
        End Get
        Set(ByVal value As String)
            _placavehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PlacaCarreta() As String
        Get
            Return _placacarreta
        End Get
        Set(ByVal value As String)
            _placacarreta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Private _nombreUsuario As String

    <DataMember()> _
    Public Property NombreUsuario() As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value As String)
            _nombreUsuario = value
        End Set
    End Property


    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresaProveedor As String _
              , ByVal ls_NombreProveedor As String _
              , ByVal ls_IdTipoGuia As String _
              , ByVal ls_NroGuia As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_MotTraslado As String _
              , ByVal ls_IdMotivoTraslado As String _
              , ByVal ls_IdEmpresaOrigen As String _
              , ByVal ls_IdEmpresaDestino As String _
              , ByVal ls_IdDireccionOrigen As String _
              , ByVal ls_IdDireccionDestino As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Glosa As String _
              , ByVal ls_Piloto As String _
              , ByVal ls_PlacaVehiculo As String _
              , ByVal ls_PlacaCarreta As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_NombreUsuario As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idempresaproveedor = ls_IdEmpresaProveedor
        _empresaproveedor = ls_NombreProveedor
        _idtipoguia = ls_IdTipoGuia
        _nroGuia = ls_NroGuia
        _serie = ls_Serie
        _numero = ls_Numero
        _idmotivotraslado = ls_IdMotivoTraslado
        _motivotraslado = ls_MotTraslado
        _idempresaorigen = ls_IdEmpresaOrigen
        _idempresadestino = ls_IdEmpresaDestino
        _iddireccionorigen = ls_IdDireccionOrigen
        _iddirecciondestino = ls_IdDireccionDestino
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _piloto = ls_Piloto
        _placavehiculo = ls_PlacaVehiculo
        _placacarreta = ls_PlacaCarreta
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _activo = lb_Activo
        _nombreUsuario = ls_NombreUsuario
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal guiaRemisionRemitente As e_GuiaRemisionRemitente) As e_GuiaRemisionRemitente Implements Ie_GuiaRemisionRemitente.Obtener
        Return guiaRemisionRemitente
    End Function

End Class


