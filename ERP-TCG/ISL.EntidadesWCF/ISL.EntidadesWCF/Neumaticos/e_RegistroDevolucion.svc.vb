<DataContract()> _
Public Class e_RegistroDevolucion
    Implements Ie_RegistroDevolucion

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _fecha As Date
    Private _tipo As Integer
    Private _idestado As String
    Private _estado As String
    Private _idclienteproveedor As String
    Private _clienteproveedor As String
    Private _idresponsable As String
    Private _responsable As String
    Private _descripcion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leDetalleRD As New List(Of e_DetalleRegistroDevolucion)

#End Region

#Region "Propiedades"

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
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
    Public Property IdClienteProveedor() As String
        Get
            Return _idclienteproveedor
        End Get
        Set(ByVal value As String)
            _idclienteproveedor = value
        End Set
    End Property

    <DataMember()> _
Public Property ClienteProveedor() As String
        Get
            Return _clienteproveedor
        End Get
        Set(ByVal value As String)
            _clienteproveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdResponsable() As String
        Get
            Return _idresponsable
        End Get
        Set(ByVal value As String)
            _idresponsable = value
        End Set
    End Property

    <DataMember()> _
Public Property Responsable() As String
        Get
            Return _responsable
        End Get
        Set(ByVal value As String)
            _responsable = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _fecha = #1/1/1901#
        _tipo = 0
        _idestado = String.Empty
        _estado = String.Empty
        _idclienteproveedor = String.Empty
        _clienteproveedor = String.Empty
        _idresponsable = String.Empty
        _responsable = String.Empty
        _descripcion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Tipo As Integer _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_IdClienteProveedor As String _
              , ByVal ls_ClienteProveedor As String _
              , ByVal ls_IdResponsable As String _
              , ByVal ls_Responsable As String _
              , ByVal ls_Descripcion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _fecha = ld_Fecha
        _tipo = ln_Tipo
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _idclienteproveedor = ls_IdClienteProveedor
        _clienteproveedor = ls_ClienteProveedor
        _idresponsable = ls_IdResponsable
        _responsable = ls_Responsable
        _descripcion = ls_Descripcion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal registrodevolucion As e_RegistroDevolucion) As e_RegistroDevolucion Implements Ie_RegistroDevolucion.Obtener
        Return registrodevolucion
    End Function

#End Region

End Class
