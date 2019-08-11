
<DataContract()> _
Public Class e_TrabajoSQL
    Implements Ie_TrabajoSQL

#Region "Declaracion de Variables"

    Private _id As String
    Private _nombre As String
    Private _descripcion As String
    Private _paso As String
    Private _comando As String
    Private _habilitado As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As String

#End Region

#Region "Propiedas"

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
    Public Property Paso() As String
        Get
            Return _paso
        End Get
        Set(ByVal value As String)
            _paso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
        End Set
    End Property

    <DataMember()> _
    Public Property Habilitado() As Boolean
        Get
            Return _habilitado
        End Get
        Set(ByVal value As Boolean)
            _habilitado = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = ""
        _nombre = ""
        _descripcion = ""
        _paso = ""
        _comando = ""
        _habilitado = True
    End Sub

    Public Sub New(ByVal id As String, _
                   ByVal nombre As String, _
                   ByVal descripcion As String, _
                   ByVal paso As String, _
                   ByVal comando As String, _
                   ByVal habilitado As Boolean)
        _id = id
        _nombre = nombre
        _descripcion = descripcion
        _paso = paso
        _comando = comando
        _habilitado = habilitado
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_TrabajoSQL
    ''' </summary>
    ''' <param name="trabajoSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal trabajoSQL As e_TrabajoSQL) As e_TrabajoSQL Implements Ie_TrabajoSQL.Obtener
        Return trabajoSQL
    End Function

#End Region

End Class
