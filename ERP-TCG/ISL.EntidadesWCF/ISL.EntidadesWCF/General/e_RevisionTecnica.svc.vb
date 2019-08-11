

<DataContract()> _
Public Class e_RevisionTecnica
    Implements Ie_RevisionTecnica
    Implements IEquatable(Of e_RevisionTecnica)

#Region "Propiedad"

    Private _id As String
    Private _iddocumentovehicular As String
    Private _codigo As String
    Private _descripcion As String
    Private _calificacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public FechaCreacion As DateTime
    <DataMember()> _
    Public UsuarioCreacion As String

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
    Public Property IdDocumentoVehicular() As String
        Get
            Return _iddocumentovehicular
        End Get
        Set(ByVal value As String)
            _iddocumentovehicular = value
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
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Calificacion() As String
        Get
            Return _calificacion
        End Get
        Set(ByVal value As String)
            _calificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDocumentoVehicular As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_Calificacion As String _
              , ByVal lb_Activo As Boolean _
               )

        _id = ls_Id
        _iddocumentovehicular = ls_IdDocumentoVehicular
        _codigo = ls_Codigo
        _descripcion = ls_Descripcion
        _calificacion = ls_Calificacion
        _activo = lb_Activo


    End Sub

#End Region

    Public Overloads Function Equals(ByVal oeRevTec As e_RevisionTecnica) As Boolean Implements IEquatable(Of e_RevisionTecnica).Equals
        If Me.Codigo = oeRevTec.Codigo Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal revisiontecnica As e_RevisionTecnica) As e_RevisionTecnica Implements Ie_RevisionTecnica.Obtener
        Return revisiontecnica
    End Function

End Class

