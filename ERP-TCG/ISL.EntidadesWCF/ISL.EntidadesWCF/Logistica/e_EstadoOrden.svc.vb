<DataContract()> _
Public Class e_EstadoOrden
    Implements Ie_EstadoOrden

#Region "Declaración de variables"
    Private _Id As String
    Private _Nombre As String
    Private _Activo As Boolean
    Private _Modificado As Boolean = False
    Private _NombreSubEstado As String
    Private _TipoOperacion As String

    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Constructor"
    Sub New()
        Activo = True
    End Sub

    Sub New(ByVal Id As String, _
            ByVal Nombre As String, _
            ByVal Activo As Boolean)
        _Id = Id
        _Nombre = Nombre
        _Activo = Activo
    End Sub
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property NombreSubEstado() As String
        Get
            Return _NombreSubEstado
        End Get
        Set(ByVal value As String)
            _NombreSubEstado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modificado() As Boolean
        Get
            Return _Modificado
        End Get
        Set(ByVal value As Boolean)
            _Modificado = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOperacion() As String
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal estadoOrden As e_EstadoOrden) As e_EstadoOrden Implements Ie_EstadoOrden.Obtener
        Return estadoOrden
    End Function

End Class
