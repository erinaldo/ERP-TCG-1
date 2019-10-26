<DataContract()> _
Public Class e_MovimientoInventarioAlmacen
    Implements Ie_MovimientoInventarioAlmacen
    Implements IEquatable(Of e_MovimientoInventarioAlmacen)

#Region "Declaración de variables"

    Private _Seleccion As Boolean
    Private _Id As String
    Private _idAlmacen As String
    Private _Almacen As String
    Private _idcentro As String
    Private _centro As String
    Private _idMovimientoInventario As String
    Private _MovimientoInventario As String
    Private _Activo As Boolean
    Private _Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal IdCentro As String, _
            ByVal Centro As String, _
            ByVal IdAlmacen As String, _
            ByVal Almacen As String, _
            ByVal IdMovimientoInventario As String, _
            ByVal MovimientoInventario As String, _
            ByVal Activo As Boolean)
        _Seleccion = Seleccion
        _Id = Id
        _idcentro = IdCentro
        _centro = Centro
        _idAlmacen = IdAlmacen
        _Almacen = Almacen
        _idMovimientoInventario = IdMovimientoInventario
        _MovimientoInventario = MovimientoInventario
        _Activo = Activo
    End Sub


    Sub New(ByVal Id As String, _
            ByVal IdAlmacen As String, _
            ByVal IdMovimientoInventario As String, _
            ByVal Activo As Boolean)
        _Id = Id
        _idAlmacen = IdAlmacen
        _idMovimientoInventario = IdMovimientoInventario
        _Activo = Activo
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
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(ByVal value As String)
            _idAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _Almacen
        End Get
        Set(ByVal value As String)
            _Almacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoInventario() As String
        Get
            Return _idMovimientoInventario
        End Get
        Set(ByVal value As String)
            _idMovimientoInventario = value
        End Set
    End Property

    <DataMember()> _
    Public Property MovimientoInventario() As String
        Get
            Return _MovimientoInventario
        End Get
        Set(ByVal value As String)
            _MovimientoInventario = value
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

#Region "Metodos"

    Public Function Obtener(ByVal movimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As e_MovimientoInventarioAlmacen Implements Ie_MovimientoInventarioAlmacen.Obtener
        Return movimientoInventarioAlmacen
    End Function

    Public Overloads Function Equals(ByVal oeMovInvAlmacen As e_MovimientoInventarioAlmacen) As Boolean Implements IEquatable(Of e_MovimientoInventarioAlmacen).Equals
        If Me.IdAlmacen.Trim = oeMovInvAlmacen.IdAlmacen.Trim Then Return True
        Return False
    End Function

#End Region

End Class
