''' <summary>
''' Entidad para el almacenar información del objeto para el Registro de Consumo de combustibles
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_ReporteTanqueoCombustible
    Implements Ie_ReporteTanqueoCombustible

#Region "Declaración de variables"

    Private _año As Integer
    Private _mes As Integer
    Private _semana As New Integer
    Private _dia As New Integer
    Private _placa As String
    Private _marca As String
    Private _modelo As String
    Private _carreta As String
    Private _fechaviaje As Date
    Private _piloto As String
    Private _copiloto As String
    Private _fechatanqueo As Date
    Private _dist As Double
    Private _cons As Double
    Private _metas As String
    Private _pesos As String
    Private _rend As Double
    Private _rendesperado As Double
    Private _glsesperado As Double
    Private _desviacion As Double

    Public Event DatoCambiado()

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New( _
              ByVal ln_Año As Integer _
              , ByVal ln_Mes As Integer _
              , ByVal ln_Semana As Integer _
              , ByVal ln_Dia As Integer _
              , ByVal ls_Placa As String _
              , ByVal ls_Marca As String _
              , ByVal ls_Modelo As String _
              , ByVal ls_Carreta As String _
              , ByVal ld_FechaViaje As Date _
              , ByVal ls_Piloto As String _
              , ByVal ls_Copiloto As String _
              , ByVal ld_FechaTanqueo As Date _
              , ByVal ln_Dist As Double _
              , ByVal ln_Cons As Double _
              , ByVal ls_Metas As String _
              , ByVal ls_Pesos As String _
              , ByVal ln_Rend As Double _
              , ByVal ln_RendEsperado As Double _
              , ByVal ln_GlsEsperado As Double _
              , ByVal ln_Desviacion As Double _
                     )
        _año = ln_Año
        _mes = ln_Mes
        _semana = ln_Semana
        _dia = ln_Dia
        _placa = ls_Placa
        _marca = ls_Marca
        _modelo = ls_Modelo
        _carreta = ls_Carreta
        _fechaviaje = ld_FechaViaje
        _piloto = ls_Piloto
        _copiloto = ls_Copiloto
        _fechatanqueo = ld_FechaTanqueo
        _dist = ln_Dist
        _cons = ln_Cons
        _metas = ls_Metas
        _pesos = ls_Pesos
        _rend = ln_Rend
        _rendesperado = ln_RendEsperado
        _glsesperado = ln_GlsEsperado
        _desviacion = ln_Desviacion

    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Año() As Integer
        Get
            Return _año
        End Get
        Set(ByVal value As Integer)
            _año = value
        End Set
    End Property

    <DataMember()> _
   Public Property Mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property

    <DataMember()> _
Public Property Semana() As Integer
        Get
            Return _semana
        End Get
        Set(ByVal value As Integer)
            _semana = value
        End Set
    End Property

    <DataMember()> _
Public Property Dia() As Integer
        Get
            Return _dia
        End Get
        Set(ByVal value As Integer)
            _dia = value
        End Set
    End Property

    <DataMember()> _
Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    <DataMember()> _
Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
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
Public Property FechaViaje() As Date
        Get
            Return _fechaviaje
        End Get
        Set(ByVal value As Date)
            _fechaviaje = value
        End Set
    End Property

    <DataMember()> _
Public Property Piloto() As String
        Get
            Return _piloto
        End Get
        Set(ByVal value As String)
            _piloto = value
        End Set
    End Property

    <DataMember()> _
Public Property Copiloto() As String
        Get
            Return _copiloto
        End Get
        Set(ByVal value As String)
            _copiloto = value
        End Set
    End Property

    <DataMember()> _
Public Property FechaTanqueo() As Date
        Get
            Return _fechatanqueo
        End Get
        Set(ByVal value As Date)
            _fechatanqueo = value
        End Set
    End Property

    <DataMember()> _
Public Property Dist() As Double
        Get
            Return _dist
        End Get
        Set(ByVal value As Double)
            _dist = value
        End Set
    End Property

    <DataMember()> _
Public Property Cons() As Double
        Get
            Return _cons
        End Get
        Set(ByVal value As Double)
            _cons = value
        End Set
    End Property

    <DataMember()> _
Public Property Metas() As String
        Get
            Return _metas
        End Get
        Set(ByVal value As String)
            _metas = value
        End Set
    End Property

    <DataMember()> _
Public Property Pesos() As String
        Get
            Return _pesos
        End Get
        Set(ByVal value As String)
            _pesos = value
        End Set
    End Property

    <DataMember()> _
Public Property Rend() As Double
        Get
            Return _rend
        End Get
        Set(ByVal value As Double)
            _rend = value
        End Set
    End Property

    <DataMember()> _
Public Property RendEsperado() As Double
        Get
            Return _rendesperado
        End Get
        Set(ByVal value As Double)
            _rendesperado = value
        End Set
    End Property

    <DataMember()> _
Public Property GlsEsperado() As Double
        Get
            Return _glsesperado
        End Get
        Set(ByVal value As Double)
            _glsesperado = value
        End Set
    End Property

    <DataMember()> _
Public Property Desviacion() As Double
        Get
            Return _desviacion
        End Get
        Set(ByVal value As Double)
            _desviacion = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal ReporteTanqueoCombustible As e_ReporteTanqueoCombustible) As e_ReporteTanqueoCombustible Implements Ie_ReporteTanqueoCombustible.Obtener
        Return ReporteTanqueoCombustible
    End Function

End Class
