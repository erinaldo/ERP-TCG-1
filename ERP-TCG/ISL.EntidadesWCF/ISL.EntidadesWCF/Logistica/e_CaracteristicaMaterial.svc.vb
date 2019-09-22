' NOTA: si cambia aquí el nombre de clase "e_CaracteristicaMaterial", también debe actualizar la referencia a "e_CaracteristicaMaterial" tanto en Web.config como en el archivo .svc asociado.
Public Class e_CaracteristicaMaterial
    Implements Ie_CaracteristicaMaterial

#Region "Propiedad"

    Private _id As String
    Private _caracteristicaespecial As New e_CaracteristicaEspecial
    Private _idmaterial As New e_Material
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
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
    Public Property IdCaracteristicaEspecial() As String
        Get
            Return _caracteristicaespecial.Id
        End Get
        Set(ByVal value As String)
            _caracteristicaespecial.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CaracteristicaEspecial() As String
        Get
            Return _caracteristicaespecial.Nombre
        End Get
        Set(ByVal value As String)
            _caracteristicaespecial.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial.Id
        End Get
        Set(ByVal value As String)
            _idmaterial.Id = value
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
              , ByVal ls_IdCaracteristicaEspeciales As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_CaracteristicaEspecial As String)
        _id = ls_Id
        _caracteristicaespecial.Id = ls_IdCaracteristicaEspeciales
        _idmaterial.Id = ls_IdMaterial
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _caracteristicaespecial.Nombre = ls_CaracteristicaEspecial
    End Sub

#End Region

    Public Function Obtener(ByVal caracteristicamaterial As e_CaracteristicaMaterial) As e_CaracteristicaMaterial Implements Ie_CaracteristicaMaterial.Obtener
        Return caracteristicamaterial
    End Function

End Class
