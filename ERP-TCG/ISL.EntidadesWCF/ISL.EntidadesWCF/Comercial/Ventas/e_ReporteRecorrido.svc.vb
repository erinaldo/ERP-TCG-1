

<DataContract()> _
Public Class e_ReporteRecorrido
    Implements Ie_ReporteRecorrido

#Region "Propiedad"

    Private _codigooperacion As String
    Private _estadooperacion As String
    Private _fechaoperacion As DateTime
    Private _codigoviaje As String
    Private _estadoviaje As String
    Private _fechaviaje As DateTime
    Private _tracto As String
    Private _carreta As String
    Private _origen As String
    Private _destino As String
    Private _kmtractoorigen As Double
    Private _kmtractodestino As Double
    Private _kmcarretaorigen As Double
    Private _kmcarretadestino As Double
    Private _kmideal As Double
    Private _kmdiferencia As Double
    Private _kmmuerto As Double
    Private _kmreal As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
     Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public Motriz As Integer
    <DataMember()> _
    Public IdCarretas As String
    <DataMember()> _
    Public IdTractos As String


    <DataMember()> _
    Public Property CodigoOperacion() As String
        Get
            Return _codigooperacion
        End Get
        Set(ByVal value As String)
            _codigooperacion = value
        End Set
    End Property

    <DataMember()> _
  Public Property EstadoOperacion() As String
        Get
            Return _estadooperacion
        End Get
        Set(ByVal value As String)
            _estadooperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOperacion() As DateTime
        Get
            Return _fechaoperacion
        End Get
        Set(ByVal value As DateTime)
            _fechaoperacion = value
        End Set
    End Property

    <DataMember()> _
   Public Property CodigoViaje() As String
        Get
            Return _codigoviaje
        End Get
        Set(ByVal value As String)
            _codigoviaje = value
        End Set
    End Property

    <DataMember()> _
  Public Property EstadoViaje() As String
        Get
            Return _estadoviaje
        End Get
        Set(ByVal value As String)
            _estadoviaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaViaje() As DateTime
        Get
            Return _fechaviaje
        End Get
        Set(ByVal value As DateTime)
            _fechaviaje = value
        End Set
    End Property

    <DataMember()> _
  Public Property Tracto() As String
        Get
            Return _tracto
        End Get
        Set(ByVal value As String)
            _tracto = value
        End Set
    End Property

    <DataMember()> _
  Public Property Carreta() As String
        Get
            Return _carreta
        End Get
        Set(ByVal value As String)
            _carreta = value
        End Set
    End Property

    <DataMember()> _
  Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    <DataMember()> _
  Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    <DataMember()> _
  Public Property KmTractoOrigen() As Double
        Get
            Return _kmtractoorigen
        End Get
        Set(ByVal value As Double)
            _kmtractoorigen = value
        End Set
    End Property

    <DataMember()> _
  Public Property KmTractoDestino() As Double
        Get
            Return _kmtractodestino
        End Get
        Set(ByVal value As Double)
            _kmtractodestino = value
        End Set
    End Property

    <DataMember()> _
Public Property KmCarretaOrigen() As Double
        Get
            Return _kmcarretaorigen
        End Get
        Set(ByVal value As Double)
            _kmcarretaorigen = value
        End Set
    End Property

    <DataMember()> _
  Public Property KmCarretaDestino() As Double
        Get
            Return _kmcarretadestino
        End Get
        Set(ByVal value As Double)
            _kmcarretadestino = value
        End Set
    End Property

    <DataMember()> _
Public Property KmIdeal() As Double
        Get
            Return _kmideal
        End Get
        Set(ByVal value As Double)
            _kmideal = value
        End Set
    End Property

    <DataMember()> _
  Public Property KmDiferencia() As Double
        Get
            Return _kmdiferencia
        End Get
        Set(ByVal value As Double)
            _kmdiferencia = value
        End Set
    End Property

    <DataMember()> _
Public Property KmMuerto() As Double
        Get
            Return _kmmuerto
        End Get
        Set(ByVal value As Double)
            _kmmuerto = value
        End Set
    End Property

    <DataMember()> _
  Public Property KmReal() As Double
        Get
            Return _kmreal
        End Get
        Set(ByVal value As Double)
            _kmreal = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_codigooperacion As String _
              , ByVal ls_estadooperacion As String _
              , ByVal ld_fechaoperacion As DateTime _
              , ByVal ls_codigoviaje As String _
              , ByVal ls_estadoviaje As String _
              , ByVal ld_fechaviaje As DateTime _
              , ByVal ls_tracto As String _
              , ByVal ls_carreta As String _
              , ByVal ls_origen As String _
              , ByVal ls_destino As String _
              , ByVal ld_kmtractoorigen As Double _
              , ByVal ld_kmtractodestino As Double _
              , ByVal ld_kmcarretaorigen As Double _
              , ByVal ld_kmcarretadestino As Double _
              , ByVal ld_kmideal As Double _
              , ByVal ld_kmdiferencia As Double _
              , ByVal ld_kmmuerto As Double _
              , ByVal ld_kmreal As Double _
                    )

        _codigooperacion = ls_codigooperacion
        _estadooperacion = ls_estadooperacion
        _fechaoperacion = ld_fechaoperacion
        _codigoviaje = ls_codigoviaje
        _estadoviaje = ls_estadoviaje
        _fechaviaje = ld_fechaviaje
        _tracto = ls_tracto
        _carreta = ls_carreta
        _origen = ls_origen
        _destino = ls_destino
        _kmtractoorigen = ld_kmtractoorigen
        _kmtractodestino = ld_kmtractodestino
        _kmcarretaorigen = ld_kmcarretaorigen
        _kmcarretadestino = ld_kmcarretadestino
        _kmideal = ld_kmideal
        _kmdiferencia = ld_kmdiferencia
        _kmmuerto = ld_kmmuerto
        _kmreal = ld_kmreal

    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal reporterecorrido As e_ReporteRecorrido) As e_ReporteRecorrido Implements Ie_ReporteRecorrido.Obtener
        Return reporterecorrido
    End Function

#End Region

End Class


