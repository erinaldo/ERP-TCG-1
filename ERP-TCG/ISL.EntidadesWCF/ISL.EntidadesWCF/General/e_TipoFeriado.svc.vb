''' <summary>
''' Clase para definir la entidad: TipoFeriado
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_TipoFeriado
    Implements Ie_TipoFeriado
    Implements IPropiedadesBasicas

#Region "Propiedades"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _activo As Boolean

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
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
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal tipoferiado As e_TipoFeriado) As e_TipoFeriado Implements Ie_TipoFeriado.Obtener
        Return tipoferiado
    End Function

#End Region

End Class
