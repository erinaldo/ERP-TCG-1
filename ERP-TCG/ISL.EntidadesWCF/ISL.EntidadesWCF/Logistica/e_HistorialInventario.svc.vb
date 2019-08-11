<DataContract(), KnownType(GetType(e_Historial))> _
Public Class e_HistorialInventario
    Implements Ie_HistorialInventario

#Region "Propiedad"

    Private _id As String
    Private _idhistorial As String
    Private _idmaterial As String
    Private _material As String
    Private _codmaterial As String
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _cantidadfinal As Double
    Private _valorunitario As Double
    Private _valortotal As Double
    Private _fecha As Date
    <DataMember()> _
    Public Activo As Boolean
    <DataMember()> _
    Public TipoOperacion As String

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
    Public Property IdHistorial() As String
        Get
            Return _idhistorial
        End Get
        Set(ByVal value As String)
            _idhistorial = value
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
    Public Property Codigo() As String
        Get
            Return _codmaterial
        End Get
        Set(ByVal value As String)
            _codmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadFinal() As Double
        Get
            Return _cantidadfinal
        End Get
        Set(ByVal value As Double)
            _cantidadfinal = value
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
    Public Property ValorTotal() As Double
        Get
            Return _valortotal
        End Get
        Set(ByVal value As Double)
            _valortotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdHistorial As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_UnidadMedida As String _
              , ByVal ln_CantidadFinal As Double _
              , ByVal ln_ValorUnitario As Double _
              , ByVal ln_ValorTotal As Double _
              , ByVal ld_Fecha As Date _
           )
        _id = ls_Id
        _idhistorial = ls_IdHistorial
        _idmaterial = ls_IdMaterial
        _codmaterial = ls_Codigo
        _material = ls_Material
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _cantidadfinal = ln_CantidadFinal
        _valorunitario = ln_ValorUnitario
        _valortotal = ln_ValorTotal
        _fecha = ld_Fecha
    End Sub

#End Region

    Public Function Obtener(ByVal historialInventario As e_HistorialInventario) As e_HistorialInventario Implements Ie_HistorialInventario.Obtener
        Return historialInventario
    End Function

End Class
