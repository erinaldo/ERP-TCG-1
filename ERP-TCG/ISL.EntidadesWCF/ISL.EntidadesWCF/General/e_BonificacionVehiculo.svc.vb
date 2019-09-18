

<DataContract()> _
Public Class e_BonificacionVehiculo
    Implements Ie_BonificacionVehiculo
    Implements IEquatable(Of e_BonificacionVehiculo)

#Region "Propiedad"

    Private _id As String
    Private _iddocumentovehicular As String
    Private _eje As String
    Private _tiposuspension As String
    Private _kgeje As Double
    Private _kgsuspension As Double
    Private _kgneumatico As Double
    Private _claseneumatico As String
    Private _bonificacioneje As Double
    Private _pesoeje As Double
    Private _fechacreacion As DateTime
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdDocumentoVehicular() As String
        Get
            Return _iddocumentovehicular
        End Get
        Set(ByVal value As String)
            _iddocumentovehicular = value
        End Set
    End Property

    <DataMember()> _
    Public Property Eje() As String
        Get
            Return _eje
        End Get
        Set(ByVal value As String)
            _eje = value
        End Set
    End Property

    <DataMember()> _
  Public Property TipoSuspension() As String
        Get
            Return _tiposuspension
        End Get
        Set(ByVal value As String)
            _tiposuspension = value
        End Set
    End Property

    <DataMember()> _
    Public Property KgEje() As Double
        Get
            Return _kgeje
        End Get
        Set(ByVal value As Double)
            _kgeje = value
        End Set
    End Property

    <DataMember()> _
    Public Property KgSuspension() As Double
        Get
            Return _kgsuspension
        End Get
        Set(ByVal value As Double)
            _kgsuspension = value
        End Set
    End Property

    <DataMember()> _
    Public Property KgNeumatico() As Double
        Get
            Return _kgneumatico
        End Get
        Set(ByVal value As Double)
            _kgneumatico = value
        End Set
    End Property

    <DataMember()> _
Public Property ClaseNeumatico() As String
        Get
            Return _claseneumatico
        End Get
        Set(ByVal value As String)
            _claseneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonificacionEje() As Double
        Get
            Return _bonificacioneje
        End Get
        Set(ByVal value As Double)
            _bonificacioneje = value
        End Set
    End Property

    <DataMember()> _
    Public Property PesoEje() As Double
        Get
            Return _pesoeje
        End Get
        Set(ByVal value As Double)
            _pesoeje = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As DateTime
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As DateTime)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

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
        'Id = ""
        'IdEmpresaEmisora = ""
        'IdEmpresaPropietaria = ""
        'IdTipoDocumento = ""
        'IdMoneda = ""
        'IdVehiculo = ""
        'Activo = True
        'TipoOperacion = ""
        'Descripcion = ""
        'IndVigencia = False
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDocumentoVehicular As String _
              , ByVal ls_Eje As String _
              , ByVal ls_TipoSuspension As String _
              , ByVal ld_KgEje As Double _
              , ByVal ld_KgSuspension As Double _
              , ByVal ld_KgNeumatico As Double _
              , ByVal ls_ClaseNeumatico As String _
              , ByVal ld_BonificacionEje As Double _
              , ByVal ld_PesoEje As Double _
              , ByVal lf_FechaCreacion As DateTime _
              , ByVal ls_usuariocreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _iddocumentovehicular = ls_IdDocumentoVehicular
        _eje = ls_Eje
        _tiposuspension = ls_TipoSuspension
        _kgeje = ld_KgEje
        _kgsuspension = ld_KgSuspension
        _kgneumatico = ld_KgNeumatico
        _claseneumatico = ls_ClaseNeumatico
        _bonificacioneje = ld_BonificacionEje
        _pesoeje = ld_PesoEje
        _fechacreacion = lf_FechaCreacion
        _usuariocreacion = ls_usuariocreacion
        _activo = lb_Activo

    End Sub

#End Region

    Public Overloads Function Equals(ByVal oeBonVeh As e_BonificacionVehiculo) As Boolean Implements IEquatable(Of e_BonificacionVehiculo).Equals
        If Me.Eje = oeBonVeh.Eje Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal bonificacionvehiculo As e_BonificacionVehiculo) As e_BonificacionVehiculo Implements Ie_BonificacionVehiculo.Obtener
        Return bonificacionvehiculo
    End Function

End Class

