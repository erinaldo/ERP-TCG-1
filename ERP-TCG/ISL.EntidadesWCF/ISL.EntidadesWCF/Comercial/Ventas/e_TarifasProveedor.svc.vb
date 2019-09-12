' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TarifasProveedor" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TarifasProveedor.svc o e_TarifasProveedor.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_TarifasProveedor
    Implements Ie_TarifasProveedor

#Region "Propiedad"

    Private _id As String
    Private _proveedor As New e_Proveedor
    Private _flujocaja As New e_FlujoCaja
    Private _material As New e_Material
    Private _idcliente As String
    Private _cliente As String
    Private _lugar As New e_Lugar
    Private _importe As Double
    Private _tipo As Integer
    Private _activo As Boolean
    Private _vigencia As Boolean
    Private _fechacreacion As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdProveedor() As String
        Get
            Return _proveedor.Id
        End Get
        Set(ByVal value As String)
            _proveedor.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As String
        Get
            Return _proveedor.Nombre
        End Get
        Set(ByVal value As String)
            _proveedor.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _material.Id
        End Get
        Set(ByVal value As String)
            _material.Id = value
        End Set
    End Property

    <DataMember()> _
     Public Property Material() As String
        Get
            Return _material.Nombre
        End Get
        Set(ByVal value As String)
            _material.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja As String
        Get
            Return _flujocaja.Id
        End Get
        Set(ByVal value As String)
            _flujocaja.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja As String
        Get
            Return _flujocaja.Nombre
        End Get
        Set(ByVal value As String)
            _flujocaja.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdLugar() As String
        Get
            Return _lugar.Id
        End Get
        Set(ByVal value As String)
            _lugar.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Lugar() As String
        Get
            Return _lugar.Nombre
        End Get
        Set(ByVal value As String)
            _lugar.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
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
    Public Property Vigencia() As Boolean
        Get
            Return _vigencia
        End Get
        Set(ByVal value As Boolean)
            _vigencia = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        Importe = 0
        Tipo = 0
        Vigencia = True
        IdLugar = String.Empty
        FechaCreacion = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdProveedor As String _
              , ByVal ls_Proveedor As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal ls_FlujoCaja As String _
              , ByVal ls_IdLugar As String _
              , ByVal ls_Lugar As String _
              , ByVal ln_Importe As Double _
              , ByVal ln_Tipo As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal lb_Vigencia As Boolean _
              , ByVal ld_FechaCreacion As Date _
                            , ByVal ls_IdMaterial As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String)
        _id = ls_Id
        _proveedor.Id = ls_IdProveedor
        _proveedor.Nombre = ls_Proveedor
        _flujocaja.Id = ls_IdFlujoCaja
        _flujocaja.Nombre = ls_FlujoCaja
        _lugar.Id = ls_IdLugar
        _lugar.Nombre = ls_Lugar
        _importe = ln_Importe
        _tipo = ln_Tipo
        _activo = lb_Activo
        _vigencia = lb_Vigencia
        _fechacreacion = ld_FechaCreacion
        _material.Id = ls_IdMaterial
        _material.Nombre = ls_Material
        _idcliente = ls_IdCliente
        _cliente = ls_Cliente
    End Sub

#End Region

    Public Function Obtener(ByVal TarifasProveedor As e_TarifasProveedor) As e_TarifasProveedor Implements Ie_TarifasProveedor.Obtener
        Return TarifasProveedor
    End Function

End Class
