<DataContract()> _
Public Class e_DetalleInventario
    Implements Ie_DetalleInventario

#Region "Propiedad"

    Private _id As String
    Private _idinventario As String
    Private _idsubalmacen As String
    Private _idmaterial As String
    Private _cantidad As Double
    Private _valorunitario As Double
    Private _fechacreacion As Date

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
    Public Property IdInventario() As String
        Get
            Return _idinventario
        End Get
        Set(ByVal value As String)
            _idinventario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value

        End Set
    End Property

    <DataMember()> _
    Public Property ValorUnitario() As Double
        Get
            Return _valorunitario
        End Get
        Set(ByVal value As Double)
            _valorunitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idsubalmacen
        End Get
        Set(ByVal value As String)
            _idsubalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdInventario As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_ValorUnitario As Double _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idinventario = ls_IdInventario
        _idmaterial = ls_IdMaterial
        _cantidad = ln_Cantidad
        _valorunitario = ln_ValorUnitario
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal detalleInventario As e_DetalleInventario) As e_DetalleInventario Implements Ie_DetalleInventario.Obtener
        Return detalleInventario
    End Function

End Class
