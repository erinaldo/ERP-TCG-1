<DataContract()> _
Public Class e_TipoMantenimiento
    Implements Ie_TipoMantenimiento

#Region "Declaración de variables"
    Private _Id As String
    Private _Descripcion As String = String.Empty
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    Private _Codigo As String
    Private _Modificado As Boolean = False
    Public Event DatoCambiado()

#End Region

#Region "Constructor y Propiedad"

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String _
                    , ByVal Descripcion As String, ByVal Activo As Boolean)
        _Id = Id
        _Descripcion = Descripcion
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _Codigo = Codigo
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
    Public Property Id() As String
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
    ''' Nombre de Tipo Mantenimiento
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Descripcion de Tipo Mantenimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
            RaiseEvent DatoCambiado()
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal tipoMantenimiento As e_TipoMantenimiento) As e_TipoMantenimiento Implements Ie_TipoMantenimiento.Obtener
        Return tipoMantenimiento
    End Function

End Class
