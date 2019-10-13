<DataContract()> _
Public Class e_ClienteProveedor
    Implements Ie_ClienteProveedor
    Implements IPropiedadesBasicas

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _cliente As Integer
    Private _proveedor As Integer
    Private _comisionista As Integer
    Private _tipopersonaempresa As Integer
    Private _idpersonaempresa As String
    Private _fechaactividad As Date
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _nombre As String
    Private _indCategoriaSGI As Integer

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
    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As Integer
        Get
            Return _cliente
        End Get
        Set(ByVal value As Integer)
            _cliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As Integer
        Get
            Return _proveedor
        End Get
        Set(ByVal value As Integer)
            _proveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As Integer
        Get
            Return _comisionista
        End Get
        Set(ByVal value As Integer)
            _comisionista = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPersonaEmpresa() As Integer
        Get
            Return _tipopersonaempresa
        End Get
        Set(ByVal value As Integer)
            _tipopersonaempresa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersonaEmpresa() As String
        Get
            Return _idpersonaempresa
        End Get
        Set(ByVal value As String)
            _idpersonaempresa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaActividad() As Date
        Get
            Return _fechaactividad
        End Get
        Set(ByVal value As Date)
            _fechaactividad = value
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
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCategoriaSGI() As Integer
        Get
            Return _IndCategoriaSGI
        End Get
        Set(ByVal value As Integer)
            _IndCategoriaSGI = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idpersonaempresa = String.Empty
        _codigo = String.Empty
        _tipopersonaempresa = 0
        _cliente = 0
        _proveedor = 0
        _comisionista = 0
        _fechaactividad = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        TipoOperacion = String.Empty
        _nombre = String.Empty
        _indCategoriaSGI = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ln_Cliente As Integer _
              , ByVal ln_Proveedor As Integer _
              , ByVal ln_Comisionista As Integer _
              , ByVal ln_TipoPersonaEmpresa As Integer _
              , ByVal ls_IdPersonaEmpresa As String _
              , ByVal ld_FechaActividad As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Nombre As String _
              , ByVal li_indCategoriaSGI As Integer)
        _id = ls_Id
        _codigo = ls_Codigo
        _cliente = ln_Cliente
        _proveedor = ln_Proveedor
        _comisionista = ln_Comisionista
        _tipopersonaempresa = ln_TipoPersonaEmpresa
        _idpersonaempresa = ls_IdPersonaEmpresa
        _fechaactividad = ld_FechaActividad
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _nombre = ls_Nombre
        _indCategoriaSGI = li_indCategoriaSGI
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ClienteProveedor
    ''' </summary>
    ''' <param name="clienteProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal clienteProveedor As e_ClienteProveedor) As e_ClienteProveedor Implements Ie_ClienteProveedor.Obtener
        Return clienteProveedor
    End Function

#End Region

End Class


