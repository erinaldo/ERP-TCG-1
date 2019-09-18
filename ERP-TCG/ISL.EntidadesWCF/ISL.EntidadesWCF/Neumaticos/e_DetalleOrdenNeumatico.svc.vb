<DataContract()> _
Public Class e_DetalleOrdenNeumatico
    Implements Ie_DetalleOrdenNeumatico


#Region "Declaracion de Variables"

    Private _id As String
    Private _idordenmaterial As String
    Private _idneumatico As String
    Private _fechaorden As Date
    Private _nroorden As String
    Private _codneumatico As String
    Private _descripcion As String
    Private _confirmacion As Integer
    Private _fechaconfirmacion As Date
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public oeNeumatico As e_Neumatico
    <DataMember()> _
    Public CantMat As Double
    <DataMember()> _
   Public IdReqMat As String
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdOrdenMaterial() As String
        Get
            Return _idordenmaterial
        End Get
        Set(ByVal value As String)
            _idordenmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdNeumatico() As String
        Get
            Return _idneumatico
        End Get
        Set(ByVal value As String)
            _idneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOrden() As Date
        Get
            Return _fechaorden
        End Get
        Set(ByVal value As Date)
            _fechaorden = value
        End Set
    End Property

    <DataMember()> _
   Public Property NroOrden() As String
        Get
            Return _nroorden
        End Get
        Set(ByVal value As String)
            _nroorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodNeumatico() As String
        Get
            Return _codneumatico
        End Get
        Set(ByVal value As String)
            _codneumatico = value
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
    Public Property Confirmacion() As Integer
        Get
            Return _confirmacion
        End Get
        Set(ByVal value As Integer)
            _confirmacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaConfirmacion() As Date
        Get
            Return _fechaconfirmacion
        End Get
        Set(ByVal value As Date)
            _fechaconfirmacion = value
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
        _idordenmaterial = String.Empty
        _idneumatico = String.Empty
        _fechaorden = #1/1/1901#
        _nroorden = String.Empty
        _codneumatico = String.Empty
        _descripcion = String.Empty
        _confirmacion = 0
        _fechaconfirmacion = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdOrdenMaterial As String _
              , ByVal ls_IdNeumatico As String _
              , ByVal ld_FechaOrden As Date _
              , ByVal ls_NroOrden As String _
              , ByVal ls_CodNeumatico As String _
              , ByVal ls_Descripcion As String _
              , ByVal ln_Confirmacion As Integer _
              , ByVal ld_FechaConfirmacion As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idordenmaterial = ls_IdOrdenMaterial
        _idneumatico = ls_IdNeumatico
        _fechaorden = ld_FechaOrden
        _nroorden = ls_NroOrden
        _codneumatico = ls_CodNeumatico
        _descripcion = ls_Descripcion
        _confirmacion = ln_Confirmacion
        _fechaconfirmacion = ld_FechaConfirmacion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal detalleordenneumatico As e_DetalleOrdenNeumatico) As e_DetalleOrdenNeumatico Implements Ie_DetalleOrdenNeumatico.Obtener
        Return detalleordenneumatico
    End Function

End Class
