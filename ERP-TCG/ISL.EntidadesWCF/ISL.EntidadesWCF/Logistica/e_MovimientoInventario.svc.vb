<DataContract()> _
Public Class e_MovimientoInventario
    Implements Ie_MovimientoInventario

#Region "Declaración de variables"

    Private _Seleccion As Boolean
    Private _Id As String
    Private _Codigo As String = String.Empty
    Private _Nombre As String
    Private _Abreviatura As String = String.Empty
    Private _Activo As Boolean
    Private _idTipoMovimientoInventario As String
    Private _TipoMovimientoInventario As String
    Private _IndDevolucion As Boolean
    Private _Modificado As Boolean = False
    Private _TipoOperacion As String

    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String

#End Region

#Region "Constructor"

    Sub New()
        _IndDevolucion = False
    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Boolean, _
            ByVal NombreTipoMovimientoInventario As String, _
            ByVal IdTipoMovimientoInventario As String, _
            ByVal IndDevolucion As Boolean)
        _Seleccion = Seleccion
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _TipoMovimientoInventario = NombreTipoMovimientoInventario
        _idTipoMovimientoInventario = IdTipoMovimientoInventario
        _IndDevolucion = IndDevolucion
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
    Public Property IndDevolucion() As Boolean
        Get
            Return _IndDevolucion
        End Get
        Set(ByVal value As Boolean)
            _IndDevolucion = value
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
    Public Property NombreTipoMovimientoInventario() As String
        Get
            Return _TipoMovimientoInventario
        End Get
        Set(ByVal value As String)
            _TipoMovimientoInventario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoMovimientoInventario() As String
        Get
            Return _idTipoMovimientoInventario
        End Get
        Set(ByVal value As String)
            _idTipoMovimientoInventario = value
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

#Region "Metodos"

    Public Function Obtener(ByVal movimientoInventario As e_MovimientoInventario) As e_MovimientoInventario Implements Ie_MovimientoInventario.Obtener
        Return movimientoInventario
    End Function

#End Region

End Class
