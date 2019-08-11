<DataContract()> _
Public Class e_RegistroInventarioDocumento
    Implements Ie_RegistroInventarioDocumento

#Region "Propiedad"

    Private _id As String
    Private _codigo As String

    'Private _IdMaterial As String
    'Private _IdUnidadMedida As String
    'Private _Precio As Double

    Private _oeMovimintoDoc As String
    'Private _oeOrden As New e_Orden
    Private _oeRegistroInventario As String

    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRegistroInventario() As String
        Get
            Return _oeRegistroInventario
        End Get
        Set(ByVal value As String)
            _oeRegistroInventario = value
        End Set
    End Property

    '--Material - Precio
    '<DataMember()> _
    'Public Property IdMaterial() As String
    '    Get
    '        Return _IdMaterial
    '    End Get
    '    Set(ByVal value As String)
    '        _IdMaterial = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property Precio() As Double
    '    Get
    '        Return _Precio
    '    End Get
    '    Set(ByVal value As Double)
    '        _Precio = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property IdUnidadMedida() As String
    '    Get
    '        Return _IdUnidadMedida
    '    End Get
    '    Set(ByVal value As String)
    '        _IdUnidadMedida = value
    '    End Set
    'End Property

    '-- Orden
    '<DataMember()> _
    'Public Property IdTipoOrden() As String
    '    Get
    '        Return _oeOrden.IdTipoOrden
    '    End Get
    '    Set(ByVal value As String)
    '        _oeOrden.IdTipoOrden = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property IdOrden() As String
    '    Get
    '        Return _oeOrden.Id
    '    End Get
    '    Set(ByVal value As String)
    '        _oeOrden.Id = value
    '    End Set
    'End Property
    '--Documento
    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _oeMovimintoDoc
        End Get
        Set(ByVal value As String)
            _oeMovimintoDoc = value
        End Set
    End Property
    '<DataMember()> _
    'Public Property IdTipoDocumento() As String
    '    Get
    '        Return _oeMovimintoDoc.IdTipoDocumento
    '    End Get
    '    Set(ByVal value As String)
    '        _oeMovimintoDoc.IdTipoDocumento = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property NumeroSerie() As String
    '    Get
    '        Return _oeMovimintoDoc.Serie
    '    End Get
    '    Set(ByVal value As String)
    '        _oeMovimintoDoc.Serie = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property NumeroDocumento() As String
    '    Get
    '        Return _oeMovimintoDoc.Numero
    '    End Get
    '    Set(ByVal value As String)
    '        _oeMovimintoDoc.Numero = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub
    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdRegistroInventario As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _codigo = ls_Codigo
        _oeRegistroInventario = ls_IdRegistroInventario
        _oeMovimintoDoc = ls_IdMovimientoDocumento
        _activo = lb_Activo
    End Sub
#End Region

    Public Function Obtener(ByVal registroInventarioDocumento As e_RegistroInventarioDocumento) As e_RegistroInventarioDocumento Implements Ie_RegistroInventarioDocumento.Obtener
        Return registroInventarioDocumento
    End Function

End Class
