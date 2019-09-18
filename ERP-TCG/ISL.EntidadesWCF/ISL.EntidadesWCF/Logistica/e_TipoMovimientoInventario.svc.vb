<DataContract()> _
Public Class e_TipoMovimientoInventario
    Implements Ie_TipoMovimientoInventario

#Region "Declaración de variables"
    Private _Id As String
    Private _Codigo As String = String.Empty
    Private _Nombre As String
    Private _Abreviatura As String = String.Empty
    Private _Activo As Boolean
    Private _Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Boolean)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
    End Sub
#End Region

#Region "Propiedades"
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
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
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
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
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

    Private _TipoOperacion As String

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

    Public Function Obtener(ByVal tipoMovimientoInventario As e_TipoMovimientoInventario) As e_TipoMovimientoInventario Implements Ie_TipoMovimientoInventario.Obtener
        Return tipoMovimientoInventario
    End Function

End Class
