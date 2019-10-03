<DataContract()> _
Public Class e_OrdenAsignacion_UnidadAsignacion
    Implements Ie_OrdenAsignacion_UnidadAsignacion

#Region "Propiedad"

    Private _id As String
    Private _idordenasignacion As String
    Private _indunidadasignacion As String 'V:Vehiculo // P:Persona // A:Area
    Private _idunidadasignacion As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _nombre As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdOrdenAsignacion() As String
        Get
            Return _idordenasignacion
        End Get
        Set(ByVal value As String)
            _idordenasignacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndUnidadAsignacion() As String
        Get
            Return _indunidadasignacion
        End Get
        Set(ByVal value As String)
            _indunidadasignacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadAsignacion() As String
        Get
            Return _idunidadasignacion
        End Get
        Set(ByVal value As String)
            _idunidadasignacion = value
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
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
                   , ByVal ls_IndUnidadAsignacion As String _
                   , ByVal ls_IdUnidadAsignacion As String _
                   , ByVal ls_NombreAsignacion As String)
        _id = ls_Id
        _indunidadasignacion = ls_IndUnidadAsignacion
        _idunidadasignacion = ls_IdUnidadAsignacion
        _nombre = ls_NombreAsignacion
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdOrdenAsignacion As String _
              , ByVal ls_IndUnidadAsignacion As String _
              , ByVal ls_IdUnidadAsignacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idordenasignacion = ls_IdOrdenAsignacion
        _indunidadasignacion = ls_IndUnidadAsignacion
        _idunidadasignacion = ls_IdUnidadAsignacion
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal ordenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As e_OrdenAsignacion_UnidadAsignacion Implements Ie_OrdenAsignacion_UnidadAsignacion.Obtener
        Return ordenAsignacion_UnidadAsignacion
    End Function

End Class
