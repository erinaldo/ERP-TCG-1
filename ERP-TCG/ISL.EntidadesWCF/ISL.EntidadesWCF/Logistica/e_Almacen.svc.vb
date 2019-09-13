<DataContract()> _
Public Class e_Almacen
    Implements Ie_Almacen
    Implements IEquatable(Of e_Almacen)

#Region "Declaración de variables"

    Private _Seleccion As Boolean
    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    Private _Capacidad As Double
    Private _Tipo As Integer
    Private _Direccion As String
    Private _Propio As Boolean
    Private _Lotizable As Boolean
    Private _idCentro As String
    Private _Centro As String
    Private _ubigeo As String
    Private _IdProveedor As String

    <DataMember()> _
    Public lstZona As List(Of e_Zona)
    <DataMember()> _
    Public leSubAlmacen As List(Of e_SubAlmacen)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public IndPrincipal As Integer
    <DataMember()> _
    Public CargaCompleta As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Constructor"

    Sub New()
        TipoOperacion = ""
        _IdProveedor = ""
        _Tipo = 0
    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Boolean, _
            ByVal Capacidad As Double, _
            ByVal Direccion As String, _
            ByVal Propio As Boolean, _
            ByVal Lotizable As Boolean, _
            ByVal Tipo As Integer, _
            ByVal IdCentro As String, _
            ByVal NombreCentro As String, _
            ByVal Ubigeo As String, _
            ByVal IdProveedor As String _
            )
        _Seleccion = Seleccion
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _Capacidad = Capacidad
        _Direccion = Direccion
        _Propio = Propio
        _Lotizable = Lotizable
        _Tipo = Tipo
        _Centro = NombreCentro
        _idCentro = IdCentro
        _ubigeo = Ubigeo
        _IdProveedor = IdProveedor
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
            RaiseEvent DatoCambiado()
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
    Public Property IdProveedor() As String
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As String)
            _IdProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Capacidad() As Double
        Get
            Return _Capacidad
        End Get
        Set(ByVal value As Double)
            _Capacidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Propio() As Boolean
        Get
            Return _Propio
        End Get
        Set(ByVal value As Boolean)
            _Propio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Lotizable() As Boolean
        Get
            Return _Lotizable
        End Get
        Set(ByVal value As Boolean)
            _Lotizable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idCentro
        End Get
        Set(ByVal value As String)
            _idCentro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ubigeo() As String
        Get
            Return _ubigeo
        End Get
        Set(ByVal value As String)
            _ubigeo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal almacen As e_Almacen) As e_Almacen Implements Ie_Almacen.Obtener
        Return almacen
    End Function

    Public Overloads Function Equals(ByVal oeAlm As e_Almacen) As Boolean Implements System.IEquatable(Of e_Almacen).Equals
        Select Case oeAlm.Equivale
            Case 1 : If Me.Id = oeAlm.Id Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
