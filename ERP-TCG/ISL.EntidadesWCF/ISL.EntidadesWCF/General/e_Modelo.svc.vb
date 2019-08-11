''' <summary>
''' Clase para definir la entidad: Modelo
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Modelo
    Implements Ie_Modelo
    Implements IPropiedadesBasicas

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _idmarca As String
    Private _marca As String
    Private _indempresa As Integer
    Private _indsunarp As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False

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
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    Private _MarcaModelo As String
    <DataMember()> _
    Public Property MarcaModelo() As String
        Get
            Return _MarcaModelo
        End Get
        Set(ByVal value As String)
            _MarcaModelo = value
        End Set
    End Property


    Private _Seleccion As Boolean
    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEmpresa() As Integer
        Get
            Return _indempresa
        End Get
        Set(ByVal value As Integer)
            _indempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndSunarp() As Integer
        Get
            Return _indsunarp
        End Get
        Set(ByVal value As Integer)
            _indsunarp = value
        End Set
    End Property
    
#End Region

#Region "Constructor"

    Sub New()
        TipoOperacion = ""
        _id = ""
        _codigo = ""
        _nombre = ""
        _abreviatura = ""
        _activo = True
        _idmarca = ""
        _marca = ""
    End Sub

    Public Sub New( _
              ByVal Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal lb_Activo As Boolean _
              , ByVal IdMarca As String _
              , ByVal Marca As String _
              , ByVal MarcaModelo As String _
              , ByVal li_IndEmpresa As Integer _
              , ByVal li_IndSunarp As Integer)
        _Seleccion = Seleccion
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _activo = lb_Activo
        _idmarca = IdMarca
        _marca = Marca
        _MarcaModelo = MarcaModelo
        _indempresa = li_IndEmpresa
        _indsunarp = li_IndSunarp
    End Sub
#End Region

#Region "Métodos"

    Public Function Obtener(ByVal modelo As e_Modelo) As e_Modelo Implements Ie_Modelo.Obtener
        Return modelo
    End Function

#End Region

End Class


