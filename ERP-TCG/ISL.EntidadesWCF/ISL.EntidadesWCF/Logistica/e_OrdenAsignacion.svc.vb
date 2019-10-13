<DataContract()> _
Public Class e_OrdenAsignacion
    Implements Ie_OrdenAsignacion

#Region "Propiedad"

    Private _id As String
    Private _fecha As Date
    Private _nrooa As String
    Private _glosa As String
    Private _indunidadasignacion As String
    Private _unidadasignada As String
    Private _idestado As String
    Private _estado As String
    Private _usuariocreacion As New e_Usuario

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
    <DataMember()>
    Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public Idunidadasignada As String
    <DataMember()> _
    Public IndUnidad As String

    <DataMember()> _
    Public FechaCreacion As Date
    <DataMember()> _
    Public Activo As Boolean

    <DataMember()> _
    Public lstUnidadAsignada As New List(Of e_OrdenAsignacion_UnidadAsignacion)
    <DataMember()> _
    Public lstUnidadAsignadaMat As New List(Of e_OrdenAsignacion_Material)
    <DataMember()> _
    Public lstRequerimiento As New List(Of e_Requerimiento)

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
    Public Property NroOA() As String
        Get
            Return _nrooa
        End Get
        Set(ByVal value As String)
            _nrooa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndUnidadAsignada() As String
        Get
            Return _indunidadasignacion
        End Get
        Set(ByVal value As String)
            _indunidadasignacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoOA() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoOA() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadAsignada() As String
        Get
            Return _unidadasignada
        End Get
        Set(ByVal value As String)
            _unidadasignada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuario() As String
        Get
            Return _usuariocreacion.Id
        End Get
        Set(ByVal value As String)
            _usuariocreacion.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _usuariocreacion.Login
        End Get
        Set(ByVal value As String)
            _usuariocreacion.Login = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_NroOA As String _
              , ByVal ls_IdEstadoOA As String _
              , ByVal ls_EstadoOA As String _
              , ByVal ls_IndUnidadAsignada As String _
              , ByVal ls_UnidadAsignada As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_Usuario As String _
              , ByVal ls_IdUsuario As String)
        _id = ls_Id
        _fecha = ld_Fecha
        _nrooa = ls_NroOA
        _idestado = ls_IdEstadoOA
        _estado = ls_EstadoOA
        _indunidadasignacion = ls_IndUnidadAsignada
        _glosa = ls_Glosa
        _unidadasignada = ls_UnidadAsignada
        _usuariocreacion.Login = ls_Usuario
        _usuariocreacion.Id = ls_IdUsuario
    End Sub

#End Region

    Public Function Obtener(ByVal ordenAsignacion As e_OrdenAsignacion) As e_OrdenAsignacion Implements Ie_OrdenAsignacion.Obtener
        Return ordenAsignacion
    End Function

End Class
