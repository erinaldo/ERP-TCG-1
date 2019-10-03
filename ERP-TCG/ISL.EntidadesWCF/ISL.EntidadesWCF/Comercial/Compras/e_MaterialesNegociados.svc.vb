

<DataContract()> _
Public Class e_MaterialesNegociados
    Implements Ie_MaterialesNegociados

#Region "Propiedad"

    Private _id As String
    Private _proveedor As String
    Private _fecha As Date
    Private _vigente As Boolean
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _glosa As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public loMaterialesNegociadosDet As New List(Of e_MaterialesNegociadosDet)
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
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
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
    Public Property Vigente() As Boolean
        Get
            Return _vigente
        End Get
        Set(ByVal value As Boolean)
            _vigente = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdProveedor As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_Vigente As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String)
        _id = ls_Id
        _proveedor = ls_IdProveedor
        _fecha = ld_Fecha
        _vigente = lb_Vigente
        _fechacreacion = ld_FechaCreacion
        _glosa = ls_Glosa
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal materialesnegociados As e_MaterialesNegociados) As e_MaterialesNegociados Implements Ie_MaterialesNegociados.Obtener
        Return materialesnegociados
    End Function

End Class


