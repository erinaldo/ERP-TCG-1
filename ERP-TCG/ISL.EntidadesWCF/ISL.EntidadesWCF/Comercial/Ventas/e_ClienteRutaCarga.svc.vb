' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ClienteRutaCarga" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ClienteRutaCarga.svc o e_ClienteRutaCarga.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ClienteRutaCarga
    Implements Ie_ClienteRutaCarga

#Region "Propiedad"

    Private _id As String
    Private _cliente As New e_Cliente
    Private _material As New e_Material
    Private _origen As New e_Lugar
    Private _destino As New e_Lugar
    Private _indcuenta As Integer
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean

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
    Public Property IdCliente() As String
        Get
            Return _cliente.Id
        End Get
        Set(ByVal value As String)
            _cliente.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _cliente.Nombre
        End Get
        Set(ByVal value As String)
            _cliente.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _material.Id
        End Get
        Set(ByVal value As String)
            _material.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material.Nombre
        End Get
        Set(ByVal value As String)
            _material.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _origen.Id
        End Get
        Set(ByVal value As String)
            _origen.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _origen.Nombre
        End Get
        Set(ByVal value As String)
            _origen.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _destino.Id
        End Get
        Set(ByVal value As String)
            _destino.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _destino.Nombre
        End Get
        Set(ByVal value As String)
            _destino.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCuenta() As Integer
        Get
            Return _indcuenta
        End Get
        Set(ByVal value As Integer)
            _indcuenta = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ln_IndCuenta As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _cliente.Id = ls_IdCliente
        _cliente.Nombre = ls_Cliente
        _material.Id = ls_IdMaterial
        _material.Nombre = ls_Material
        _origen.Id = ls_IdOrigen
        _origen.Nombre = ls_Origen
        _destino.Id = ls_IdDestino
        _destino.Nombre = ls_Destino
        _indcuenta = ln_IndCuenta
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal clienterutacarga As e_ClienteRutaCarga) As e_ClienteRutaCarga Implements Ie_ClienteRutaCarga.Obtener
        Return clienterutacarga
    End Function

#End Region

End Class
