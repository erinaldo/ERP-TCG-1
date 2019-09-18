

<DataContract()> _
Public Class e_ProcesoServicio
    Implements Ie_ProcesoServicio

#Region "Propiedad"

    Private _id As String
    Private _idservicio As New e_Servicio
    Private _idprocesonegocio As New e_ProcesoNegocio
    Private _activo As Boolean
    Private _servicio As String
    Private _proceso As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Proceso() As String
        Get
            Return _proceso
        End Get
        Set(ByVal value As String)
            _proceso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Servicio() As String
        Get
            Return _servicio
        End Get
        Set(ByVal value As String)
            _servicio = value
        End Set
    End Property

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
    Public Property IdServicio() As String
        Get
            Return _idservicio.Id
        End Get
        Set(ByVal value As String)
            _idservicio.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio.Id
        End Get
        Set(ByVal value As String)
            _idprocesonegocio.Id = value
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
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdServicio As String _
              , ByVal ls_IdProcesoNegocio As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Proceso As String _
              , ByVal ls_Servicio As String _
           )
        _id = ls_Id
        _idservicio.Id = ls_IdServicio
        _idprocesonegocio.Id = ls_IdProcesoNegocio
        _activo = lb_Activo
        _proceso = ls_Proceso
        _servicio = ls_Servicio
    End Sub

#End Region

    Public Function Obtener(ByVal procesoServicio As e_ProcesoServicio) As e_ProcesoServicio Implements Ie_ProcesoServicio.Obtener
        Return procesoServicio
    End Function

End Class


