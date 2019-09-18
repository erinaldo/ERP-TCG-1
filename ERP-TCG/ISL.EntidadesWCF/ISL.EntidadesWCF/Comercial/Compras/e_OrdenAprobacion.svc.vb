

<DataContract()> _
Public Class e_OrdenAprobacion
    Implements Ie_OrdenAprobacion

#Region "Propiedad"

    Private _id As String
    Private _idorden As String
    Private _idtrabajador As String
    Private _fechaaprobacion As Date
    Private _indaprobacion As Boolean
    Private _indbloqueo As Boolean
    Private _activo As Boolean
    Private _usuariocreacion As String

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
    Public Property IdOrden() As String
        Get
            Return _idorden
        End Get
        Set(ByVal value As String)
            _idorden = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAprobacion() As Date
        Get
            Return _fechaaprobacion
        End Get
        Set(ByVal value As Date)
            _fechaaprobacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndAprobacion() As Boolean
        Get
            Return _indaprobacion
        End Get
        Set(ByVal value As Boolean)
            _indaprobacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndBloqueo() As Boolean
        Get
            Return _indbloqueo
        End Get
        Set(ByVal value As Boolean)
            _indbloqueo = value
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
              , ByVal ls_IdOrden As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ld_FechaAprobacion As Date _
              , ByVal lb_IndAprobacion As Boolean _
              , ByVal lb_IndBloqueo As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _idorden = ls_IdOrden
        _idtrabajador = ls_IdTrabajador
        _fechaaprobacion = ld_FechaAprobacion
        _indaprobacion = lb_IndAprobacion
        _indbloqueo = lb_IndBloqueo
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal ordenAprobacion As e_OrdenAprobacion) As e_OrdenAprobacion Implements Ie_OrdenAprobacion.Obtener
        Return ordenAprobacion
    End Function

End Class


