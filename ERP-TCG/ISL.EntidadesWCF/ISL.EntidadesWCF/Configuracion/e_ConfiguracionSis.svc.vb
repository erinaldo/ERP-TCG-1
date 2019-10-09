

<DataContract()> _
Public Class e_ConfiguracionSis
    Implements Ie_ConfiguracionSis

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _nombretabla As String
    Private _activo As Boolean

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
    <DataMember()> _
    Public ListaConfiguracionSisDet As New List(Of e_ConfiguracionSisDet)

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
    Public Property NombreTabla() As String
        Get
            Return _nombretabla
        End Get
        Set(ByVal value As String)
            _nombretabla = value
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
              , ByVal ls_Nombre As String _
              , ByVal ls_NombreTabla As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _nombretabla = ls_NombreTabla
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ConfiguracionSis
    ''' </summary>
    ''' <param name="configuracionSis"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal configuracionSis As e_ConfiguracionSis) As e_ConfiguracionSis Implements Ie_ConfiguracionSis.Obtener
        Return configuracionSis
    End Function

#End Region

End Class


