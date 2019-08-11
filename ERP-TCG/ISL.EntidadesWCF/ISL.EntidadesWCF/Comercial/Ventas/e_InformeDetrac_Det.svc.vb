

<DataContract()> _
Public Class e_InformeDetrac_Det
    Implements Ie_InformeDetrac_Det

#Region "Declaracion de Variables"

    Private _id As String
    Private _idinformedetrac As String
    Private _idventa As String
    Private _monto As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _RazonSocial As String
    Private _Ruc As String
    Private _FechaDoc As Date
    Private _TotalDoc As Double
    Private _SerieDoc As String
    Private _NumeroDoc As String
    Private _NroInforme As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property IdInformeDetrac() As String
        Get
            Return _idinformedetrac
        End Get
        Set(ByVal value As String)
            _idinformedetrac = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVenta() As String
        Get
            Return _idventa
        End Get
        Set(ByVal value As String)
            _idventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SerieDoc() As String
        Get
            Return _SerieDoc
        End Get
        Set(ByVal value As String)
            _SerieDoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDoc() As String
        Get
            Return _NumeroDoc
        End Get
        Set(ByVal value As String)
            _NumeroDoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property RazonSocial() As String
        Get
            Return _RazonSocial
        End Get
        Set(ByVal value As String)
            _RazonSocial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ruc() As String
        Get
            Return _Ruc
        End Get
        Set(ByVal value As String)
            _Ruc = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaDoc() As Date
        Get
            Return _FechaDoc
        End Get
        Set(ByVal value As Date)
            _FechaDoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalDoc() As Double
        Get
            Return _TotalDoc
        End Get
        Set(ByVal value As Double)
            _TotalDoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroFactura() As String
        Get
            Return Right(_SerieDoc, 3) & "/" & Right(_NumeroDoc, 7)
        End Get
        Set(ByVal value As String)
            'NroFactura = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroInforme() As String
        Get
            Return _NroInforme
        End Get
        Set(ByVal value As String)
            _NroInforme = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _activo = True
        _id = String.Empty
        _idinformedetrac = String.Empty
        _idventa = String.Empty
        _monto = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _SerieDoc = String.Empty
        _NumeroDoc = String.Empty
        _TotalDoc = 0
        _FechaDoc = #1/1/1901#
        _Ruc = String.Empty
        _RazonSocial = String.Empty
        _NroInforme = String.Empty
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdInformeDetrac As String _
              , ByVal ls_IdVenta As String _
              , ByVal ln_Monto As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_SerieDoc As String _
              , ByVal ls_NumeroDoc As String _
              , ByVal ls_RazonSocial As String _
              , ByVal ld_FechaDoc As Date _
              , ByVal ln_TotalDoc As Double _
              , ByVal ls_Ruc As String _
              , ByVal ls_NroInforme As String _
           )
        _id = ls_Id
        _idinformedetrac = ls_IdInformeDetrac
        _idventa = ls_IdVenta
        _monto = ln_Monto
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _SerieDoc = ls_SerieDoc
        _NumeroDoc = ls_NumeroDoc
        _RazonSocial = ls_RazonSocial
        _FechaDoc = ld_FechaDoc
        _TotalDoc = ln_TotalDoc
        _Ruc = ls_Ruc
        _NroInforme = ls_NroInforme
    End Sub

#End Region

    Public Function Obtener(ByVal informeDetrac_Det As e_InformeDetrac_Det) As e_InformeDetrac_Det Implements Ie_InformeDetrac_Det.Obtener
        Return informeDetrac_Det
    End Function

End Class


