

<DataContract()> _
Public Class e_Archivo
    Implements Ie_Archivo

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _rutadocumento As String
    Private _seleccion As Integer

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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
    Public Property RutaDocumento() As String
        Get
            Return _rutadocumento
        End Get
        Set(ByVal value As String)
            _rutadocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property


#End Region

#Region "Constructor"

    Public Sub New()


    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal Codigo As String _
              , ByVal TipoPersonaEmpresa As Integer _
              , ByVal IdPersonaEmpresa As String _
              , ByVal Nombre As String _
              , ByVal FechaActividad As Date _
              , ByVal Comisionista As Integer _
              , ByVal UsuarioCreacion As String _
              , ByVal Activo As Boolean _
              , ByVal Dni As String _
            )

    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Archivo
    ''' </summary>
    ''' <param name="archivo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal archivo As e_Archivo) As e_Archivo Implements Ie_Archivo.Obtener
        Return archivo
    End Function

#End Region

End Class


