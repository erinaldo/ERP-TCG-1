

<DataContract()> _
Public Class e_ProcesoGlosa
    Implements Ie_ProcesoGlosa

#Region "Propiedad"

    Private _id As String
    Private _idprocesonegocio As String
    Private _procesonegocio As String
    Private _nombre As String
    Private _activo As Integer

    Private _fechacreacion As Date
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
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio
        End Get
        Set(ByVal value As String)
            _idprocesonegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ProcesoNegocio() As String
        Get
            Return _procesonegocio
        End Get
        Set(ByVal value As String)
            _procesonegocio = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Integer
        Get
            Return _activo
        End Get
        Set(ByVal value As Integer)
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
        _activo = 1
        _id = ""
        _usuariocreacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdProcesoNegocio As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_Activo As Integer _
              , ByVal ls_ProcesoNegocio As String _
              , ByVal ls_UsuarioCreacion As String _
           )

        _id = ls_Id
        _idprocesonegocio = ls_IdProcesoNegocio
        _nombre = ls_Nombre
        _activo = ln_Activo
        _procesonegocio = ls_ProcesoNegocio
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal procesoGlosa As e_ProcesoGlosa) As e_ProcesoGlosa Implements Ie_ProcesoGlosa.Obtener
        Return procesoGlosa
    End Function

End Class


