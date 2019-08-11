''' <summary>
''' Clase para definir la entidad: Marca
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Marca
    Implements Ie_Marca
    Implements IPropiedadesBasicas

#Region "Constructor"

    Private _Id As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    Private _Codigo As String
    Private _tipomarca As Integer

    <DataMember()> _
    Public Modificado As Boolean = False
    Private _usuariocreacion As String
    <DataMember()> _
    Public TipoOperacion As String

    Public Sub New()
        Activo = True
        TipoMarca = 9
        TipoOperacion = ""
    End Sub

    Public Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String, ByVal Activo As Boolean, ByVal TipoMarca As Integer)
        _Id = Id
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _Codigo = Codigo
        _tipomarca = TipoMarca
    End Sub

    Public Sub New(ByVal Id As String)
        _Id = Id
        _Nombre = ""
        _Abreviatura = ""
        _Activo = Nothing
        _Codigo = ""
    End Sub
#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id de Tipo Mantenimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo de Tipo Vehiculo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre de Tipo Mantenimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    ''' <summary>
    ''' Abreviatura de Tipo Mantenimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

    ''' <summary>
    ''' Activo de Tipo Mantenimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property


    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMarca() As Integer
        Get
            Return _tipomarca
        End Get
        Set(ByVal value As Integer)
            _tipomarca = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal marca As e_Marca) As e_Marca Implements Ie_Marca.Obtener
        Return marca
    End Function

#End Region

End Class


