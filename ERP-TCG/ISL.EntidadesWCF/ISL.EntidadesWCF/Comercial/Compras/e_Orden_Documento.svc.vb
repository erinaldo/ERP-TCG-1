

<DataContract()> _
Public Class e_Orden_Documento
    Implements Ie_Orden_Documento

#Region "Propiedad"

    Private _id As String
    'Private _idtipodocumento As New e_TipoDocumento
    'Private _idorden As New e_Orden
    Private _idmovDoc As String
    Private _idtipodoc As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _idTipoOrden As String
    Private _idOrden As String
    Private _indconsignacion As String

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public TipoOrden As Integer
    <DataMember()>
    Public TipoExistencia As Integer
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
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodoc
        End Get
        Set(ByVal value As String)
            _idtipodoc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumento() As String
        Get
            Return _idmovDoc
        End Get
        Set(ByVal value As String)
            _idmovDoc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoOrden() As String
        Get
            Return _idTipoOrden
        End Get
        Set(ByVal value As String)
            _idTipoOrden = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrden() As String
        Get
            Return _idOrden
        End Get
        Set(ByVal value As String)
            _idOrden = value
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

    <DataMember()> _
    Public Property IndConsignacion() As String
        Get
            Return _indconsignacion
        End Get
        Set(ByVal value As String)
            _indconsignacion = value
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
        Id = ""
        Activo = True
        IndConsignacion = ""
        IdOrden = ""
        IdDocumento = ""
        FechaCreacion = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_IdDocumento As String _
              , ByVal ls_IdTipoOrden As String _
              , ByVal ls_IdOrden As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_IndConsignacion As String)
        _id = ls_Id
        _idtipodoc = ls_IdTipoDocumento
        _idmovDoc = ls_IdDocumento
        _idTipoOrden = ls_IdTipoOrden
        _idOrden = ls_IdOrden
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _indconsignacion = lb_IndConsignacion
    End Sub

#End Region

    Public Function Obtener(ByVal orden_Documento As e_Orden_Documento) As e_Orden_Documento Implements Ie_Orden_Documento.Obtener
        Return orden_Documento
    End Function

End Class


