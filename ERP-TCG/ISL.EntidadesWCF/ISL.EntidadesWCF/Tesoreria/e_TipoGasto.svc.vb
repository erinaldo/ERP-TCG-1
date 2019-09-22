


<DataContract()> _
Public Class e_TipoGasto
    Implements Ie_TipoGasto

#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    Private _Modificado As Boolean = False
    Private _TipoOperacion As String
    Private _IdUsuario As String
    <DataMember()> _
    Public oeTipoGastoDetalle As New List(Of e_TipoGastoDetalle)
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Constructor"

    Sub New()
        _Id = String.Empty
        _Codigo = String.Empty
        _Nombre = String.Empty
        _Abreviatura = String.Empty
        _Activo = True
    End Sub

    Sub New(ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Integer, _
            ByVal Usuario As String)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _IdUsuario = Usuario
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

    <DataMember()> _
    Public Property TipoOperacion() As String
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal tipoGasto As e_TipoGasto) As e_TipoGasto Implements Ie_TipoGasto.Obtener
        Return tipoGasto
    End Function

End Class

