' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ImagenesDocumentos" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ImagenesDocumentos.svc o e_ImagenesDocumentos.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_ImagenesDocumentos
    Implements Ie_ImagenesDocumentos
    Implements IEquatable(Of e_ImagenesDocumentos)

#Region "Propiedad"

    Private _id As String
    Private _idvehiculo As String
    Private _idtrabajador As String
    Private _rutaimagen As String
    Private _tipodocumento As New e_TipoDocumento
    Private _nrodocumento As String
    Private _descripcion As String
    Private _fechavencimiento As Date
    Private _indvigente As Boolean
    Private _fechavigencia As Date
    Private _placa As String
    Private _modelofuncional As String
    Private _vencimiento As Integer
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _fechamodificacion As Date
    Private _usuariocreacion As String
    Private _usuariomodificacion As String
    Private _imagen As New List(Of Drawing.Image)
    <DataMember()> _
    Public Indicador As String
    <DataMember()>
    Public Identificador As String
    <DataMember()>
    Public PrefijoID As String = ""
    '<DataMember()> _
    'Public ListaDetalle As New List(Of e_DocumentoVehiculoDetalle)
    <DataMember()> _
    Public Property Imagen() As List(Of Drawing.Image)
        Get
            Return _imagen
        End Get
        Set(ByVal value As List(Of Drawing.Image))
            _imagen = value
        End Set
    End Property

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public FechaFin As Date

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
    Public Property RutaImagen() As String
        Get
            Return _rutaimagen
        End Get
        Set(ByVal value As String)
            _rutaimagen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVigencia() As Date
        Get
            Return _fechavigencia
        End Get
        Set(ByVal value As Date)
            _fechavigencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDocumento() As String
        Get
            Return _nrodocumento
        End Get
        Set(ByVal value As String)
            _nrodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vencimiento() As Integer
        Get
            Return _vencimiento
        End Get
        Set(ByVal value As Integer)
            _vencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _tipodocumento.Id
        End Get
        Set(ByVal value As String)
            _tipodocumento.Id = value
            RaiseEvent DatoCambiado()
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
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento.Nombre
        End Get
        Set(ByVal value As String)
            _tipodocumento.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    <DataMember()> _
    Public Property ModeloFuncional() As String
        Get
            Return _modelofuncional
        End Get
        Set(ByVal value As String)
            _modelofuncional = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndVigente() As Boolean
        Get
            Return _indvigente
        End Get
        Set(ByVal value As Boolean)
            _indvigente = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModificacion() As Date
        Get
            Return _fechamodificacion
        End Get
        Set(ByVal value As Date)
            _fechamodificacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property UsuarioModificacion() As String
        Get
            Return _usuariomodificacion
        End Get
        Set(ByVal value As String)
            _usuariomodificacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    

#End Region

#Region "Constructor"

    Public Sub New()
        Id = ""
        TipoOperacion = ""
        Activo = True
        IdVehiculo = ""
        ModeloFuncional = ""
        IdTrabajador = ""
        NroDocumento = ""
        IndVigente = True
        FechaCreacion = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_RutaImagen As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_NroDocumento As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Placa As String _
              , ByVal ls_TipoDocumento As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ld_FechaModificacion As Date _
              , ByVal ln_Vencimiento As Integer _
              , ByVal lb_IndVigente As Boolean)
        _id = ls_Id
        _rutaimagen = ls_RutaImagen
        _descripcion = ls_Descripcion
        _idvehiculo = ls_IdVehiculo
        _tipodocumento.Id = ls_IdTipoDocumento
        _tipodocumento.Nombre = ls_TipoDocumento
        _placa = ls_Placa
        _idtrabajador = ls_IdTrabajador
        _nrodocumento = ls_NroDocumento
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechavencimiento = ld_FechaVencimiento
        _fechamodificacion = ld_FechaModificacion
        _vencimiento = ln_Vencimiento
        _indvigente = lb_IndVigente
    End Sub

#End Region

    Public Function Obtener(ByVal ImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos Implements Ie_ImagenesDocumentos.Obtener
        Return ImagenesDocumentosVehiculos
    End Function

    Public Overloads Function Equals(ByVal oeImagenesDocumentos As e_ImagenesDocumentos) _
    As Boolean Implements System.IEquatable(Of e_ImagenesDocumentos).Equals
        If Me.Identificador = oeImagenesDocumentos.Identificador Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
