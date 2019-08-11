

<DataContract()> _
Public Class e_ConfiguracionMTC
    Implements Ie_ConfiguracionMTC

#Region "Propiedad"

    Private _id As String
    Private _Codigo As String
    Private _nombre As String
    Private _capacidad As Double
    Private _longitudmax As Double
    Private _numeroejes As Integer
    Private _cantpesomaxeje1 As Double
    Private _cantpesomaxeje2 As Double
    Private _cantpesomaxeje3 As Double
    Private _cantpesomaxeje4 As Double
    Private _cantpesomaxeje5 As Double
    Private _cantpesomaxeje6 As Double
    Private _cantpesomaxeje7 As Double
    Private _cantpesomaxeje8 As Double
    Private _cantpesomaxeje9 As Double
    Private _cantpesomaxbruto As Double
    Private _Activo As Boolean
    <DataMember()> _
    Public UsuarioCreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

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
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Capacidad() As Double
        Get
            Return _capacidad
        End Get
        Set(ByVal value As Double)
            _capacidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property LongitudMax() As Double
        Get
            Return _longitudmax
        End Get
        Set(ByVal value As Double)
            _longitudmax = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroEjes() As Integer
        Get
            Return _numeroejes
        End Get
        Set(ByVal value As Integer)
            _numeroejes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje1() As Double
        Get
            Return _cantpesomaxeje1
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje2() As Double
        Get
            Return _cantpesomaxeje2
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje3() As Double
        Get
            Return _cantpesomaxeje3
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje4() As Double
        Get
            Return _cantpesomaxeje4
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje4 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje5() As Double
        Get
            Return _cantpesomaxeje5
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje5 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje6() As Double
        Get
            Return _cantpesomaxeje6
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje6 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje7() As Double
        Get
            Return _cantpesomaxeje7
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje7 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje8() As Double
        Get
            Return _cantpesomaxeje8
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje8 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxEje9() As Double
        Get
            Return _cantpesomaxeje9
        End Get
        Set(ByVal value As Double)
            _cantpesomaxeje9 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantPesoMaxBruto() As Double
        Get
            Return _cantpesomaxbruto
        End Get
        Set(ByVal value As Double)
            _cantpesomaxbruto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Double
        Get
            Return _Activo
        End Get
        Set(ByVal value As Double)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
               , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_Capacidad As Double _
              , ByVal ln_LongitudMax As Double _
              , ByVal ln_NumeroEjes As Integer _
              , ByVal ln_CantPesoMaxEje1 As Double _
              , ByVal ln_CantPesoMaxEje2 As Double _
              , ByVal ln_CantPesoMaxEje3 As Double _
              , ByVal ln_CantPesoMaxEje4 As Double _
              , ByVal ln_CantPesoMaxEje5 As Double _
              , ByVal ln_CantPesoMaxEje6 As Double _
              , ByVal ln_CantPesoMaxEje7 As Double _
              , ByVal ln_CantPesoMaxEje8 As Double _
              , ByVal ln_CantPesoMaxEje9 As Double _
              , ByVal ln_CantPesoMaxBruto As Double _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _Codigo = ls_Codigo
        _nombre = ls_Nombre
        _capacidad = ln_Capacidad
        _longitudmax = ln_LongitudMax
        _numeroejes = ln_NumeroEjes
        _cantpesomaxeje1 = ln_CantPesoMaxEje1
        _cantpesomaxeje2 = ln_CantPesoMaxEje2
        _cantpesomaxeje3 = ln_CantPesoMaxEje3
        _cantpesomaxeje4 = ln_CantPesoMaxEje4
        _cantpesomaxeje5 = ln_CantPesoMaxEje5
        _cantpesomaxeje6 = ln_CantPesoMaxEje6
        _cantpesomaxeje7 = ln_CantPesoMaxEje7
        _cantpesomaxeje8 = ln_CantPesoMaxEje8
        _cantpesomaxeje9 = ln_CantPesoMaxEje9
        _cantpesomaxbruto = ln_CantPesoMaxBruto
        _Activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ConfiguracionMTC
    ''' </summary>
    ''' <param name="configuracionMTC"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal configuracionMTC As e_ConfiguracionMTC) As e_ConfiguracionMTC Implements Ie_ConfiguracionMTC.Obtener
        Return configuracionMTC
    End Function

#End Region

End Class


