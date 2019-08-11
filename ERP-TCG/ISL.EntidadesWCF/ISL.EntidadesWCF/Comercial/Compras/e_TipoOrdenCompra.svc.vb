

<DataContract()> _
Public Class e_TipoOrdenCompra
    Implements Ie_TipoOrdenCompra

#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id de Tipo OrdenCompra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo de Tipo OrdenCompra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Nombre de Tipo OrdenCompra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Abreviatura de Tipo OrdenCompra
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Activo de Tipo OrdenCompra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
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

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, _
                     ByVal Abreviatura As String, ByVal Activo As Boolean)
        _Id = Id
        _Codigo = Codigo
        _Abreviatura = Abreviatura
        _Nombre = Nombre
        _Activo = Activo

    End Sub

#End Region

    Public Function Obtener(ByVal tipoOrdenCompra As e_TipoOrdenCompra) As e_TipoOrdenCompra Implements Ie_TipoOrdenCompra.Obtener
        Return tipoOrdenCompra
    End Function

End Class


