


<DataContract()> _
Public Class e_BolsaViaje
    Implements Ie_BolsaViaje

#Region "Propiedad"

    Private _id As String
    Private _idruta As String
    Private _idtipovehiculo As String
    Private _idconceptogasto As String
    Private _minimo As Double
    Private _descripcionminimo As String
    Private _normal As Double
    Private _descripcionnormal As String
    Private _maximo As Double
    Private _descripcionmaximo As String
    Private _activo As Boolean

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
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _idtipovehiculo
        End Get
        Set(ByVal value As String)
            _idtipovehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ConceptoGasto() As String
        Get
            Return _idconceptogasto
        End Get
        Set(ByVal value As String)
            _idconceptogasto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Minimo() As Double
        Get
            Return _minimo
        End Get
        Set(ByVal value As Double)
            _minimo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescripcionMinimo() As String
        Get
            Return _descripcionminimo
        End Get
        Set(ByVal value As String)
            _descripcionminimo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Normal() As Double
        Get
            Return _normal
        End Get
        Set(ByVal value As Double)
            _normal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescripcionNormal() As String
        Get
            Return _descripcionnormal
        End Get
        Set(ByVal value As String)
            _descripcionnormal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Maximo() As Double
        Get
            Return _maximo
        End Get
        Set(ByVal value As Double)
            _maximo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescripcionMaximo() As String
        Get
            Return _descripcionmaximo
        End Get
        Set(ByVal value As String)
            _descripcionmaximo = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        Id = ""
        IdRuta = ""
        Activo = True
        TipoOperacion = ""
        Minimo = 0
        Normal = 0
        Maximo = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_IdConceptoGasto As String _
              , ByVal ln_Minimo As Double _
              , ByVal ls_DescripcionMinimo As String _
              , ByVal ln_Normal As Double _
              , ByVal ls_DescripcionNormal As String _
              , ByVal ln_Maximo As Double _
              , ByVal ls_DescripcionMaximo As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idruta = ls_IdRuta
        _idtipovehiculo = ls_IdTipoVehiculo
        _idconceptogasto = ls_IdConceptoGasto
        _minimo = ln_Minimo
        _descripcionminimo = ls_DescripcionMinimo
        _normal = ln_Normal
        _descripcionnormal = ls_DescripcionNormal
        _maximo = ln_Maximo
        _descripcionmaximo = ls_DescripcionMaximo
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal bolsaViaje As e_BolsaViaje) As e_BolsaViaje Implements Ie_BolsaViaje.Obtener
        Return bolsaViaje
    End Function

End Class


